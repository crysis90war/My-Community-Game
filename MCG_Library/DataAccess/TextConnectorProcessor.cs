using MCG_Library.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string NomFichier)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ NomFichier}";
        }

        public static List<string> ChargerFichier(this string fichier)
        {
            if (!File.Exists(fichier))
            {
                return new List<string>();
            }

            return File.ReadAllLines(fichier).ToList();
        }

        public static List<GameModel> ConvertirVersGameModel(this List<string> lignes)
        {
            List<GameModel> output = new List<GameModel>();

            foreach (string ligne in lignes)
            {
                string[] cols = ligne.Split('\t');
                GameModel p = new GameModel();
                p.GameAppId = int.Parse(cols[0]);
                p.GameName = cols[1];
                p.GameDescription = cols[2];
                p.GameImageUrl = cols[3];
                p.GameReleaseDate = cols[4];

                p.GameDevelopers = new List<DeveloperModel>();
                DeveloperModel newDev = new DeveloperModel();
                string[] colsDev = cols[5].Split(',');
                for (int i = 0; i < colsDev.Length; i++)
                {
                    string devName = colsDev[i].Trim();
                    newDev = new DeveloperModel(devName);
                    p.GameDevelopers.Add(newDev);
                }

                p.GameGenres = new List<GenreModel>();
                GenreModel newGenre = new GenreModel();
                string[] colsGenre = cols[6].Split(',');
                for (int i = 0; i < colsGenre.Length; i++)
                {
                    string genreName = colsGenre[i].Trim();
                    newGenre = new GenreModel(genreName);
                    p.GameGenres.Add(newGenre);
                }

                output.Add(p);
            }

            return output;
        }
    }
}
