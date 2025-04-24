using Iced.Intel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace VibrateGames
{
    public static class MemoryHelper
    {
        [DllImport("kernel32.dll")]
        [SuppressMessage("Interoperability", "SYSLIB1054:Use 'LibraryImportAttribute' instead of 'DllImportAttribute' to generate P/Invoke marshalling code at compile time", Justification = "<Pending>")]
        internal static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        [SuppressMessage("Interoperability", "SYSLIB1054:Use 'LibraryImportAttribute' instead of 'DllImportAttribute' to generate P/Invoke marshalling code at compile time", Justification = "<Pending>")]
        internal static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        public class ProcessInfo(IntPtr processHandle, ProcessModule module)
        {
            public IntPtr Handle { get; set; } = processHandle;
            public ProcessModule Module { get; set; } = module;
        }

        public static ProcessInfo? FindProcess(string name, string moduleName)
        {
            Process[] processes = Process.GetProcessesByName(name);
            foreach (Process process in processes)
            {
                if (process.MainModule?.ModuleName == moduleName)
                {
                    int PROCESS_VM_READ = 0x0010;
                    var handle = OpenProcess(PROCESS_VM_READ, false, process.Id);
                    return new ProcessInfo(handle, process.MainModule);
                }
            }
            return null;
        }

        /// <summary>
        /// Finds an array of bytes within a processes memory.
        /// </summary>
        /// <param name="aobPattern">A string representing the bytes you want to find in hex split by ' '. ?? means any data</param>
        /// <param name="process">The process to search through</param>
        /// <returns>Pointer to the location of the AOB in memory</returns>
        public static IntPtr FindAOB(string aobPattern, ProcessInfo process)
        {
            if (process.Module == null)
            {
                return 0;
            }

            byte[] processMemory = new byte[process.Module.ModuleMemorySize];
            byte?[] aob = ConvertAOB(aobPattern);
            ReadProcessMemory(process.Handle, process.Module.BaseAddress, processMemory, process.Module.ModuleMemorySize, out _);

            return ScanLogic(process.Module, processMemory, aob);
        }

        /// <summary>
        /// Finds the address in memory after indirecting with an array of pointer offsets.
        /// </summary>
        /// <param name="proccessHandle"></param>
        /// <param name="baseAddress"></param>
        /// <param name="offsets"></param>
        /// <returns></returns>
        public static IntPtr RunPointerOffsets(IntPtr proccessHandle, IntPtr baseAddress, int[] offsets)
        {
            byte[] buffer = new byte[8];

            // Initial Pointer
            ReadProcessMemory(proccessHandle, baseAddress, buffer, 8, out _);
            IntPtr pointer = (nint)BitConverter.ToInt64(buffer, 0);

            // Run through offsets
            foreach (int offset in offsets)
            {
                ReadProcessMemory(proccessHandle, pointer + offset, buffer, 8, out _);
                pointer = (nint)BitConverter.ToInt64(buffer, 0);
            }
            return pointer;
        }

        /// <summary>
        /// Disassembles machine code into a human readable instruction.
        /// </summary>
        /// <param name="byteCode"></param>
        /// <returns></returns>
        public static Instruction Disassemble(byte[] byteCode)
        {
            ByteArrayCodeReader codeReader = new(byteCode);
            Decoder decoder = Decoder.Create(64, codeReader);
            return decoder.Decode();
        }

        private static byte?[] ConvertAOB(string aob)
        {
            List<byte?> convertertedAOB = [];
            foreach (string token in aob.Split(' '))
            {
                if (token == "??") 
                { 
                    convertertedAOB.Add(null); 
                }
                else 
                { 
                    convertertedAOB.Add(Convert.ToByte(token, 16)); 
                }
            }
            return [.. convertertedAOB];
        }

        /// <summary>
        /// Scans for a set of bytes within a process
        /// </summary>
        /// <param name="processModule"></param>
        /// <param name="processMemory"></param>
        /// <param name="aob"></param>
        /// <returns></returns>
        private static IntPtr ScanLogic(ProcessModule processModule, byte[] processMemory, byte?[] aob)
        {
            for (int index = 0; index < processMemory.Length; index++)
            {
                if (AreBytesEqual(processMemory, index, aob))
                {
                    return processModule.BaseAddress + index;
                }
            }
            return IntPtr.Zero;
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
    }
}
