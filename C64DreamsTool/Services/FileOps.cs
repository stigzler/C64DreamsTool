using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C64DreamsTool.Services
{
    internal static class FileOps
    {
        internal static bool FileExists(string rootpath, string filename)
        {
            if (File.Exists(Path.Combine(rootpath, filename)))
                return true;

            foreach (string subDir in Directory.GetDirectories(rootpath, "*", SearchOption.AllDirectories))
            {
                if (File.Exists(Path.Combine(subDir, filename)))
                    return true;
            }

            return false;
        }

        internal static bool FileExistsRecursive(string rootPath, string filename)
        {
            if (File.Exists(Path.Combine(rootPath, filename)))
                return true;

            foreach (string subDir in Directory.GetDirectories(rootPath))
            {
                if (FileExistsRecursive(subDir, filename))
                    return true;
            }

            return false;
        }

    }
}
