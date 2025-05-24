using stigzler.Winforms.Base.Forms.BaseForm;

namespace C64DreamsTool.Data.Entities
{
    internal class Game
    {
        public bool AlsoUpdateLaunchbox { get; set; } = false;

        public string CustomCmdText { get; set; } = string.Empty;

        public bool DarkMode { get; set; } = false;

        public string Developer { get; set; } = string.Empty;

        public string GameFile { get; set; } = string.Empty;

        public Dictionary<GameImageType, string> GameImages { get; set; } = new Dictionary<GameImageType, string>();

        public int MagazinePageNumber { get; set; } = 0;

        public string MagazinePath { get; set; } = string.Empty;

        // totes cheating, but not enough life left, fucker.
        public BaseForm MainForm { get; set; } = null!;

        public string ManualPath { get; set; } = string.Empty;

        public string Name { get; set; } = "{To be set}";

        public string Notes { get; set; } = string.Empty;

        public string Publisher { get; set; } = string.Empty;

        public string SidPath { get; set; } = string.Empty;

        public bool WarnOnOverwrite { get; set; } = true;
    }
}