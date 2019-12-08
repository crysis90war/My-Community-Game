using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCG_Library.Models;

namespace MCG_Library.DataAccess
{
    public class TextConnector
    {
        public void CreerAchievement(AchievementModel modele, int gameId)
        {
            throw new NotImplementedException();
        }

        public void CreerGameDeveloper(GameModel modele)
        {
            throw new NotImplementedException();
        }

        public void CreerGameGenre(GameModel gameModel)
        {
            throw new NotImplementedException();
        }

        public void CreerGenre(GenreModel modele)
        {
            throw new NotImplementedException();
        }

        public void CreerJeu(GameModel modele)
        {
            throw new NotImplementedException();
        }

        public void CreerUtilisateur(UserModel modele)
        {
            throw new NotImplementedException();
        }

        public List<AchievementModel> GetAchievements_All()
        {
            throw new NotImplementedException();
        }

        public List<DeveloperModel> GetDeveloper_All()
        {
            throw new NotImplementedException();
        }

        public List<GameModel> GetGame_All()
        {
            return GlobalConfig.GamesFiles.FullFilePath().ChargerFichier().ConvertirVersGameModel();
        }

        public List<GenreModel> GetGenre_All()
        {


            throw new NotImplementedException();
        }

        public UserModel GetUser_Info(int userId)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUser_One(string userName, string userPassword)
        {
            throw new NotImplementedException();
        }

        public void UpdateConnexionUtilisateur(UserModel modele)
        {
            throw new NotImplementedException();
        }

        public void CreerJeuUtilisateur(UserModel modele, int gameId)
        {
            throw new NotImplementedException();
        }

        public GameModel GetGame_ByGameId(int gameId)
        {
            throw new NotImplementedException();
        }

        public void UpdateDeconnexionUtilisateur(UserModel modele)
        {
            throw new NotImplementedException();
        }

        public List<GameModel> GetUserGames(int userId)
        {
            throw new NotImplementedException();
        }

        public List<GameModel> GetGame_UserNotPossessed(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
