using C64DreamsTool.Data;
using C64DreamsTool.Data.Entities;
using C64DreamsTool.Properties;
using stigzler.Utilities.Base.Extensions;
using stigzler.Winforms.Base.Forms.BaseForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Windows.Forms.LinkLabel;

namespace C64DreamsTool.Services
{
    internal static class GameOps
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameDetails"></param>
        /// <returns>If null - game dir made successfully. Errors fed back.</returns>
        internal static string AddGame(Game game, bool darkMode, BaseForm form)
        {
            string c64DGamesPath = Path.Combine(Settings.Default.LaunchboxRootPath, "C64 Dreams\\Games");
            string gameFileExt = Path.GetExtension(game.GameFile);
            string gameDir = Path.Combine(c64DGamesPath, game.Name);
            string candidateSidPath = Path.Combine(Settings.Default.LaunchboxRootPath,"C64 Dreams\\Music\\C64 Dreams",$"{game.Name}.sid");
            string candidateManualPath = Path.Combine(gameDir, $"{game.Name} Manual{Path.GetExtension(game.ManualPath)}");

            // DO CHECKS ==============================================================================================
            // Check Game Name and Game File are not empty
            if (game.Name == string.Empty || game.GameFile == string.Empty) return $"Add Game requires a Name and Game File as a minimum.";

            // Check for Invalid filename chars
            if (!IsValidFilename(game.Name)) return $"Game name contains invalid filepath characters. Please revise.";

            // Check for permissible extension
            if (!Settings.Default.PermissableGameExts.Contains(gameFileExt.ToLower()))
                return $"Game file is not a permissible extension. \n \n Permissible extensions are: {string.Join(",", Settings.Default.PermissableGameExts.Cast<string>().ToArray<string>())}.";

            // Check if Game Dir exists already
            if (Directory.Exists(Path.Combine(gameDir)))
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                        "A directory for this game already exists. Would you like to delete this and install the new game files?",
                        "Game directory already exists.",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, "Game directory already exists", darkMode,
                        stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                DialogResult result = messageBox.ShowDialog(form);
                if (result == DialogResult.Yes)
                {
                    Directory.Delete(gameDir, true);
                    if (game.SidPath != string.Empty && File.Exists(candidateSidPath)) File.Delete(candidateSidPath);
                }
                else
                {
                    return "Game folder already exists.";
                }
            }

            // Check Sid file
            if (game.SidPath != string.Empty && File.Exists(candidateSidPath)) return $"SID file already exists: \n \n {candidateSidPath}";
            if (game.SidPath != string.Empty && Path.GetExtension(game.SidPath) != ".sid") return $"The sid file chosen does not have a .sid extension.";

            // Manuals
            if (game.ManualPath != string.Empty && File.Exists(candidateManualPath)) return $"Manual file already exists: \n \n {candidateManualPath}";
            if (game.ManualPath != string.Empty && (Path.GetExtension(candidateManualPath) != ".pdf" && Path.GetExtension(candidateSidPath) != ".cbz"))
                return $"The manual file chosen does not have a .pdf or .cbz extension.";

            // Reviews
            if (game.MagazinePath != string.Empty && !FileOps.FileExistsRecursive(c64DGamesPath, game.MagazinePath))
                return $"The magazine file chosen does not exist in the Launchbox C64 Dreams folder. \n \n {game.MagazinePath}";

            // ADD GAME FILES ==============================================================================================    
            Directory.CreateDirectory(gameDir);

            // Game File:
            switch (gameFileExt)
            {
                case ".d64":
                case ".t64":
                    Debug.WriteLine(Path.Combine(gameDir, $"Disk1{gameFileExt}"));
                    File.Copy(game.GameFile, Path.Combine(gameDir, $"Disk1{gameFileExt}"), true);
                    break;
                case ".crt":
                case ".d81":
                    Debug.WriteLine(Path.Combine(gameDir, $"{game.Name}{gameFileExt}"));
                    File.Copy(game.GameFile, Path.Combine(gameDir, $"{game.Name}{gameFileExt}"), true);
                    break;
            }

            // Sid file:
            if (game.SidPath != string.Empty)
            {
                File.Copy(game.SidPath, candidateSidPath, true);
            }

            // Manual file:
            if (game.ManualPath != string.Empty)
            {
                File.Copy(game.ManualPath, candidateManualPath, true);
            }

            // Other files:
            // Cmd File:
            if (game.CustomCmdText != string.Empty)
            {
                string cmdFilePath = Path.Combine(gameDir, $"{game.Name}.cmd");
                File.WriteAllText(cmdFilePath, game.CustomCmdText);
            }
            else
            {
                // cmd file required for d64 + t64 files. NOT required for .crt and .d81 files.
                if (gameFileExt == ".d64" || gameFileExt == ".t64")
                {
                    string cmdFilePath = Path.Combine(gameDir, $"{game.Name}.cmd");
                    string cmdText = $"Disk1{gameFileExt}";
                    File.WriteAllText(cmdFilePath, cmdText);
                }
            }

            // Game.bat file:
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(gameDir, "Game.bat")))
                outputFile.Write(Resources.GameBat);

            // Game vbs file:
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(gameDir, $"{game.Name}.vbs")))
                outputFile.Write(Resources.GameVbs);


            // Magazine file:
            if (game.MagazinePath != string.Empty)
            {
                string gameReviewPath = Path.Combine(gameDir, "Zzap Review");
                Directory.CreateDirectory(gameReviewPath);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(gameReviewPath, $"{game.Name} (Local).vbs")))
                    outputFile.Write(Resources.ReviewVbs);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(gameReviewPath, $"Review.bat")))
                    outputFile.Write(Resources.ReviewBat);

                string ReviewAhkString = Resources.ReviewAhk;
                ReviewAhkString = ReviewAhkString.Replace("[MAGAZINEFILE]", game.MagazinePath);
                ReviewAhkString = ReviewAhkString.Replace("[PAGENUMBER]", game.MagazinePageNumber.ToString());

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(gameReviewPath, $"Review.ahk")))
                    outputFile.Write(ReviewAhkString);
            }

            // UPDATE LAUNCHBOX DB ==============================================================================================    
            if (game.AlsoUpdateLaunchbox)
            {
                LaunchboxOps.AddNewGame(game);
            }

            // PROCESS ANY IMAGES ==============================================================================================    
            foreach (var gameImage in game.GameImages)
            {
                if (gameImage.Value == string.Empty) continue;

                string description = ((GameImageType)gameImage.Key).Description();
                string imagePath = Path.Combine(Settings.Default.LaunchboxRootPath, $"Images\\C64 Dreams\\{description}",
                   $"{game.Name}-00{Path.GetExtension(   gameImage.Value)}");    

                File.Copy(gameImage.Value, imagePath, true);
            }
            return null;
        }

        private static bool IsValidFilename(string filename)
        {
            // Check for invalid characters in the filename
            char[] invalidChars = System.IO.Path.GetInvalidFileNameChars();
            return !filename.Any(c => invalidChars.Contains(c));
        }

    }
}
