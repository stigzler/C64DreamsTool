using stigzler.Winforms.Base.Forms.BaseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace C64DreamsTool.Data.Entities
{
    internal class Game
    {
        [Description(@"How you wish the game to be named in the C64Dreams ecosystem. Some conventions include: 'The' is at the end (e.g. 'Last Ninja, The'). Same game, different developer have the dev in parentheses (e.g. 'Donkey Kong (Atari)'). You cannot use characters that are illegal in filenames (\/:*?<>|"").")]
        public string Name { get; set; } = "{To be set}";

       // public GameFiles GameFiles { get; set; } = new GameFiles();

        public string GameFile { get; set; } = string.Empty;

        public string SidPath { get; set; } = string.Empty;

        public string ManualPath { get; set; } = string.Empty;

        public string MagazinePath { get; set; } = string.Empty;
        public int MagazinePageNumber { get; set; } = 0;
        public string CustomCmdText { get; set; } = string.Empty; 
        


        public Dictionary<GameImageType,string> GameImages { get; set; } = new Dictionary<GameImageType, string>();
        public string Developer { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public bool AlsoUpdateLaunchbox { get; set; } = false;
        public bool WarnOnOverwrite { get; set; } = true;

       

        public bool DarkMode { get; set; } = false; // totes cheating, but not enough life left, fucker.
        public BaseForm MainForm { get; set; } = null!; // see DarkMode
    }
}
