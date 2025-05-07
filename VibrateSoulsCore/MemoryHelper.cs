using Iced.Intel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace VibrateSoulsCore
{
    public static partial class MemoryHelper
    {
        #region Process Info
        [LibraryImport("kernel32.dll")]
        internal static partial nint OpenProcess(int dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [LibraryImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static partial bool CloseHandle(nint hProcess);

        [LibraryImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static partial bool ReadProcessMemory(nint hProcess, nint lpBaseAddress, [Out]byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        public class VsProcess
        {
            public VsProcess(Process process, nint handle)
            {
                GameProcess = process;
                if (process.MainModule == null) 
                {
                    throw new Exception("Module was not found");
                }
                Module = process.MainModule;
                OpenHandle = handle;
            }

            public Process GameProcess;
            public ProcessModule Module;
            public nint OpenHandle;
        }

        public static VsProcess? FindProcess(string name, string moduleName)
        {
            Process[] processes = Process.GetProcessesByName(name);
            foreach (Process process in processes)
            {
                if (process.MainModule?.ModuleName == moduleName)
                {
                    int PROCESS_VM_READ = 0x0010;
                    nint handle = OpenProcess(PROCESS_VM_READ, false, process.Id);
                    VsProcess vsProcess = new VsProcess(process, handle);
                    
                    return vsProcess;
                }
            }
            return null;
        }
        #endregion

        #region AOB Scan
        public class AOBParam
        {
            public AOBParam(byte?[] aob)
            {
                AOB = aob;
            }

            public AOBParam(string aob) 
                : this(ConvertAOB(aob)) 
            { }

            public readonly byte?[] AOB;
            public readonly int[]? Offsets;

            public nint Address;

            /// <summary>
            /// Converts a string representation of bytes to search for into an array
            /// </summary>
            /// <param name="aob"></param>
            /// <returns></returns>
            private static byte?[] ConvertAOB(string aob)
            {
                return [.. aob.Split(' ').Select<string, byte?>(
                    token => token == "??" 
                    ? null 
                    : Convert.ToByte(token, 16)
                    )];
            }
        }

        /// <summary>
        /// Finds an array of bytes within a processes memory.
        /// </summary>
        /// <param name="process">The process to search through</param>
        /// <param name="aobParams"></param>
        /// <returns>Pointer to the location of the AOB in memory</returns>
        public static void FindAOBs(VsProcess process, List<AOBParam> aobParams)
        {
            int size = 0x10000; // Number of bytes to read at once
            int bytesToCopy = size + LongestAOB(aobParams);
            byte[] processMemory = new byte[bytesToCopy];


            for (int index = 0; index < process.Module.ModuleMemorySize; index++)
            {
                if (index % size == 0)
                {
                    // Get next chunk of memory
                    if (bytesToCopy + index > process.Module.ModuleMemorySize)
                    {
                        bytesToCopy = process.Module.ModuleMemorySize - index;
                    }
                    ReadProcessMemory(process.OpenHandle, process.Module.BaseAddress + index, processMemory, bytesToCopy, out _);
                }

                for (int aobIndex = 0; aobIndex < aobParams.Count; aobIndex++)
                {
                    AOBParam aobParam = aobParams[aobIndex];
                    if (AreBytesEqual(processMemory, index % size, aobParam.AOB))
                    {
                        aobParam.Address = process.Module.BaseAddress + index;
                        aobParams.RemoveAt(aobIndex--); // Remove AOB, we don't need to scan for it again
                        if (aobParams.Count == 0)
                        {
                            // All AOBs found
                            return;
                        }
                    }
                }
            }
        }

        private static bool AreBytesEqual(byte[] processMemory, int index, byte?[] aob)
        {
            for (int i = 0; i < aob.Length && i + index < processMemory.Length; i++)
            {
                if (aob[i] != null && aob[i] != processMemory[i + index])
                {
                    return false;
                }
            }
            return true;
        }

        private static int LongestAOB(List<AOBParam> aobParams)
        {
            int maxLength = 0;
            foreach (AOBParam aobParam in aobParams)
            {
                int length = aobParam.AOB.Length;
                if (length > maxLength)
                {
                    maxLength = length;
                }
            }
            return maxLength;
        }

        /// <summary>
        /// Disassembles machine code into a human readable instruction.
        /// </summary>
        /// <param name="byteCode"></param>
        /// <returns></returns>
        public static Instruction Disassemble(byte[] byteCode)
        {
            ByteArrayCodeReader codeReader = new(byteCode);
            var decoder = Decoder.Create(64, codeReader);
            return decoder.Decode();
        }

        /// <summary>
        /// Finds the address in memory after indirecting with an array of pointer offsets.
        /// </summary>
        /// <param name="proccessHandle"></param>
        /// <param name="baseAddress"></param>
        /// <param name="offsets"></param>
        /// <returns></returns>
        public static nint RunPointerOffsets(nint proccessHandle, nint baseAddress, int[] offsets)
        {
            byte[] buffer = new byte[8];

            // Initial Pointer
            ReadProcessMemory(proccessHandle, baseAddress, buffer, 8, out _);
            nint pointer = (nint)BitConverter.ToInt64(buffer, 0);

            // Run through offsets
            foreach (int offset in offsets)
            {
                ReadProcessMemory(proccessHandle, pointer + offset, buffer, 8, out _);
                pointer = (nint)BitConverter.ToInt64(buffer, 0);
            }
            return pointer;
        }
        #endregion
    }
}
