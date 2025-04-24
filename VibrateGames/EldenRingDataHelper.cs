using Iced.Intel;
using System.Diagnostics;

namespace VibrateGames
{
    internal class EldenRingDataHelper
    {
        private IntPtr EldenRingProcessHandle;
        private ProcessModule? MainModule;
        private IntPtr playerParamAddress;

        private readonly PlayerParams? playerParams;

        public EldenRingDataHelper()
        {
            if (FindEldenRingProcess())
            {
                SetPlayerParamAddress();
                playerParams = new PlayerParams(EldenRingProcessHandle, playerParamAddress);
            }
        }

        public bool FindEldenRingProcess()
        {
            Process[] processes = Process.GetProcessesByName("eldenring");
            foreach (Process process in processes)
            {
                if (process.MainModule?.ModuleName == "eldenring.exe")
                {
                    int PROCESS_VM_READ = 0x0010;
                    EldenRingProcessHandle = MemoryHelper.OpenProcess(PROCESS_VM_READ, false, process.Id);
                    MainModule = process.MainModule;
                    return true;
                }
            }
            return false;
        }

        private void SetPlayerParamAddress()
        {
            if (MainModule == null) { return; }
            string GameDataManAOB = "48 8B 05 ?? ?? ?? ?? 48 85 C0 74 05 48 8B 40 58 C3 C3";

            // Find the address instruction to disassemble
            IntPtr addressOfInstruction = MemoryHelper.FindAOB(GameDataManAOB, EldenRingProcessHandle, MainModule);

            // Get the machine code to disassemble to find address of GameDataMan
            byte[] buffer = new byte[8];
            MemoryHelper.ReadProcessMemory(EldenRingProcessHandle, addressOfInstruction, buffer, 7, out _);
            Instruction instruction = MemoryHelper.Disassemble(buffer);

            IntPtr gameDataMan = addressOfInstruction + (nint)instruction.MemoryDisplacement64;

            playerParamAddress = MemoryHelper.RunPointerOffsets(EldenRingProcessHandle, gameDataMan, [0x08]);
        }

        public int GetHP()
        {
            playerParams?.UpdateStats();

            return playerParams?.Hp ?? 0;
        }
    }

    public class PlayerParams(IntPtr EldenRingProcessHandle, IntPtr PlayerParamAddress)
    {
        public void UpdateStats()
        {
            int size = 0xFD + 0x01;
            byte[] buffer = new byte[size];

            MemoryHelper.ReadProcessMemory(EldenRingProcessHandle, PlayerParamAddress, buffer, size + 0x04, out _);
            Hp = BitConverter.ToInt32(buffer, 0x10);
            MaxHp = BitConverter.ToInt32(buffer, 0x14);
            BaseMaxHp = BitConverter.ToInt32(buffer, 0x18);

            Mp = BitConverter.ToInt32(buffer, 0x1c);
            MaxMp = BitConverter.ToInt32(buffer, 0x20);

            Sp = BitConverter.ToInt32(buffer, 0x2c);
            MaxSp = BitConverter.ToInt32(buffer, 0x30);
            BaseMaxSp = BitConverter.ToInt32(buffer, 0x34);

            Vigor = BitConverter.ToInt32(buffer, 0x3c);
            Mind = BitConverter.ToInt32(buffer, 0x40);
            Endurance = BitConverter.ToInt32(buffer, 0x44);
            Strength = BitConverter.ToInt32(buffer, 0x48);
            Dexterity = BitConverter.ToInt32(buffer, 0x4c);
            Inteligence = BitConverter.ToInt32(buffer, 0x50);
            Faith = BitConverter.ToInt32(buffer, 0x54);
            Arcane = BitConverter.ToInt32(buffer, 0x58);

            SoulLv = BitConverter.ToInt32(buffer, 0x68);
            Soul = BitConverter.ToInt32(buffer, 0x6c);
            TotalGetSoul = BitConverter.ToInt32(buffer, 0x70);
            ImmunityPoison = BitConverter.ToInt32(buffer, 0x78);
            ImmunityRot = BitConverter.ToInt32(buffer, 0x7c);
            RobustnessBleed = BitConverter.ToInt32(buffer, 0x80);
            Vitality = BitConverter.ToInt32(buffer, 0x84);
            RobustnessFrostbite = BitConverter.ToInt32(buffer, 0x88);
            FocusSleep = BitConverter.ToInt32(buffer, 0x8c);
            FocusMadness = BitConverter.ToInt32(buffer, 0x90);

            ScadutreeBlessing = buffer[0xFC];
            ReveredSpiritAshBlessing = buffer[0xFD];
        }

        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public int BaseMaxHp { get; set; }
        public int Mp { get; set; }
        public int MaxMp { get; set; }
        public int Sp { get; set; }
        public int MaxSp { get; set; }
        public int BaseMaxSp { get; set; }
        public int Vigor { get; set; }
        public int Mind { get; set; }
        public int Endurance { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Inteligence { get; set; }
        public int Faith { get; set; }
        public int Arcane { get; set; }
        public int SoulLv { get; set; }
        public int Soul { get; set; }
        public int TotalGetSoul { get; set; }
        public int ImmunityPoison { get; set; }
        public int ImmunityRot { get; set; }
        public int RobustnessBleed { get; set; }
        public int Vitality { get; set; }
        public int RobustnessFrostbite { get; set; }
        public int FocusSleep { get; set; }
        public int FocusMadness { get; set; }

        public int ScadutreeBlessing { get; set; }
        public int ReveredSpiritAshBlessing { get; set; }
    }
}
