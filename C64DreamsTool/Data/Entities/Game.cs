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

        public GameFiles GameFiles { get; set; } = new GameFiles();

        public string SidPath { get; set; } = string.Empty;

        public string ManualPath { get; set; } = string.Empty;

        public string MagazinePath { get; set; } = string.Empty;

        public int MagazinePageNumber { get; set; } = 0;

        public string CustomCmdText { get; set; } = string.Empty;   



        //[Description("The path to the original file. This is used to create a copy of the original file in the C64Dreams ecosystem.")]
        //public string OriginalFilepath { get; set; } = "{To be set}";

        //[Description("The path to the finla game folder once processed.")]
        //public string ProcessedGameDirectory { get; set; } = "{To be set}";



    }
}
