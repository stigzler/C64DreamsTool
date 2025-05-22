using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C64DreamsTool.Data.Entities
{
    internal class GameFile
    {
        public string Filepath { get; set; } = "{To be set}";
        public string RenameTo { get; set; } = string.Empty;
        public bool Primary { get; set; } = false;
    }
}
