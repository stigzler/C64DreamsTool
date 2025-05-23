using C64DreamsTool.Data.Entities;
using C64DreamsTool.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace C64DreamsTool.Services
{
    internal class LaunchboxOps
    {
        internal static bool LaunchboxExecutablesRunning()
        {
            string[] launchboxProcesses = { "BigBox", "LaunchBox" };
            foreach (string process in launchboxProcesses)
            {
                Process[] processes = Process.GetProcessesByName(process);
                if (processes.Length > 0)
                {
                    return true;
                }
            }
            return false;
        }


        internal static XDocument ReadLaunchboxGamesXml()
        {
            string gamesXml = Path.Combine(Settings.Default.LaunchboxRootPath, $"Data\\Platforms\\{Settings.Default.GameslistName}.xml");
            //string gamesXml = "C:\\temp\\project tests\\C64DreamsImporter\\testGameUpdate.xml";
            return XDocument.Load(gamesXml);
        }

        internal static string AddNewGame(Game game)
        {
            string gamesXml = Path.Combine(Settings.Default.LaunchboxRootPath, $"Data\\Platforms\\{Settings.Default.GameslistName}.xml");
            XDocument xDocument = ReadLaunchboxGamesXml();

            var gameElement = xDocument.Descendants("Game").FirstOrDefault(x => x.Element("Title")?.Value == game.Name);

            if (gameElement != null)
            {
                if (game.WarnOnOverwrite)
                {
                    stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                        "A game of this name is already in the Launchbox database for the C64 Dreams Install. Do you want to delete this entry and use the new values to update the database? Choosing no will mean the database is not updated.",
                        "Game already in database",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, "Update database error", game.DarkMode,
                        stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                    DialogResult result = messageBox.ShowDialog(game.MainForm);

                    if (result == DialogResult.No)
                    {
                        return null;
                    }

                }
                gameElement.Remove();
            }

            gameElement = new XElement("Game");
            gameElement.Add(new XElement("ApplicationPath", Path.Combine($"C64 Dreams\\Games\\{game.Name}\\{game.Name}.vbs")));
            gameElement.Add(new XElement("Title", game.Name));
            gameElement.Add(new XElement("Developer", game.Developer));
            gameElement.Add(new XElement("Publisher", game.Publisher));
            gameElement.Add(new XElement("Platform", Settings.Default.GameslistName));
            gameElement.Add(new XElement("DateAdded", DateTime.Now.ToString("o")));
            gameElement.Add(new XElement("Notes", game.Notes));
            gameElement.Add(new XElement("GameID", Guid.NewGuid().ToString()));

            xDocument.Element("LaunchBox").Add(gameElement);
            xDocument.Save(gamesXml);

            return null;

        }




    }



}

