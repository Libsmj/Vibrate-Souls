using static VibrateSoulsCore.MemoryHelper;

namespace VibrateSoulsCore
{
    public class GameDataHelper
    {
        internal VsProcess? ProcessInfo;
        public EventHandler<GameEventArgs>? GameDataChanged;

        public GameDataHelper() 
        { 
        }

        internal virtual void UpdateStats()
        {
            OnGameDataChanged(GameEventArgs.Empty);
        }

        protected virtual void OnGameDataChanged(GameEventArgs e) 
        {
            GameDataChanged?.Invoke(this, e);
        }
    }

    public class GameEventArgs : EventArgs
    {
        public int HpChange;
        public static new readonly GameEventArgs Empty = new GameEventArgs();

        public GameEventArgs() : base() { }

        public GameEventArgs(int hpChange) 
        {
            HpChange = hpChange;
        }
    }
}
