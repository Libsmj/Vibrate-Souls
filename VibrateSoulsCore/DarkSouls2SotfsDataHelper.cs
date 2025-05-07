using Iced.Intel;
using System.Text;
using static VibrateSoulsCore.MemoryHelper;

namespace VibrateSoulsCore
{
    public class DarkSouls2DataHelper
    {
        public readonly PlayerParams PlayerParams;

        private readonly VsProcess DarkSouls2Process;
        private nint GameDataMan;

        public DarkSouls2DataHelper(VsProcess darkSouls2Process)
        {
            DarkSouls2Process = darkSouls2Process;
            SetGameDataManAddress();

            PlayerParams = new PlayerParams(DarkSouls2Process.OpenHandle, GameDataMan);
        }

        private void SetGameDataManAddress()
        {
            AOBParam gameDataManAOB = new("48 8B 05 ?? ?? ?? ?? 48 8B 58 38 48 85 DB 74 ?? F6");
            List<AOBParam> aobs = [gameDataManAOB];

            // Find the address instruction to disassemble
            FindAOBs(DarkSouls2Process, aobs);

            // Get the machine code to disassemble to find address of GameDataMan
            byte[] buffer = new byte[7];
            ReadProcessMemory(DarkSouls2Process.OpenHandle, gameDataManAOB.Address, buffer, 7, out _);
            Instruction instruction = Disassemble(buffer);

            GameDataMan = gameDataManAOB.Address + (nint)instruction.MemoryDisplacement64;
        }
    }

    public class DS2PlayerParams
    {
        private readonly nint processHandle;
        private readonly nint playerParamAddress; 

        public DS2PlayerParams(nint darkSouls2ProcessHandle, nint gameDataMan)
        {
            processHandle = darkSouls2ProcessHandle;
            playerParamAddress = RunPointerOffsets(processHandle, gameDataMan, [0x08]);
        }

        public void UpdateStats()
        {
            int size = 0xFD + 0x01;
            byte[] buffer = new byte[size];

            ReadProcessMemory(processHandle, playerParamAddress, buffer, size + 0x04, out _);
            Hp = BitConverter.ToInt32(buffer, 0x10);

            PlayerName = Encoding.Unicode.GetString(buffer, 0x9c, 32).Trim((char)0x0);
        }

        public int Hp { get; set; }

        public string PlayerName { get; set; } = "";
    }
}
