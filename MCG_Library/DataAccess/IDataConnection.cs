using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCG_Library.Models;

namespace MCG_Library.DataAccess
{
    public interface IDataConnection
    {
        void CreerJeu(GameModel modele);

        void CreerDefi(DefiModel modele, int userId, int gameId);

        void CreerInvitationAmi(int sourceUserId, int targetUserId);

        void CreerAchievement(AchievementModel modele, int gameId);

        void CreerGenre(GenreModel modele);

        void CreerDeveloper(DeveloperModel modele);

        void CreerGameGenre(int gameId, int genreId);

        void CreerGameDeveloper(int gameId, int developerId);
        List<UserModel> GetUser_All();
        void CreerUtilisateur(UserModel modele);

        List<DefiModel> GetDefi_MesDefisApprouves(int userId);

        void UpdateConnexionUtilisateur(UserModel modele);

        void UpdateDeconnexionUtilisateur(UserModel modele);

        void UpdateUserAchievement(int userId, int userAchievementId);

        void UpdateUser_Score(int userId, int newScore);

        void UpdateUser_Rank(int userId);

        void UpdateFriendship_State(int sourceUserId, int targetUserId);

        void UpdateUser_Ban(int userId);

        void UpdateUser_Unban(int userId);

        void CreerJeuUtilisateur(UserModel modele, int gameId);

        UserModel GetUser_One(string userName, string userPassword);

        UserModel GetUser_Info(int userId);

        int GetUser_Count();

        int GetGame_Count();

        int GetUser_OnlineCount();

        List<DefiModel> GetDefi_AllApproved(int gameId);

        int GetGameId_ByGameAppId(GameModel modele);

        int GetGenreId_ByName(GenreModel modele);

        int GetDeveloperId_ByName(DeveloperModel modele);

        List<GameModel> GetUserGames(int userId);

        GameModel GetGame_ByGameId(int gameId);

        List<AchievementModel> GetUserAchievement_Achieved(int userId);

        List<GameModel> GetGame_All();

        List<UserModel> GetUser_Classement();

        List<GameModel> GetGame_UserNotPossessed(int userId);

        List<UserModel> GetUserFriendship_Confirmed(int userId);

        List<UserModel> GetUserFriendship_Sent(int userId);

        List<UserModel> GetUserFriendship_Received(int userId);

        List<AchievementModel> GetAchievements_All();

        List<GenreModel> GetGenre_All();

        List<DeveloperModel> GetDeveloper_All();

        void CreerPrivate_Msg(Private_MsgModel model);

        List<Private_MsgModel> GetPrivate_msg_refSender_refReceiver(int userId, int ref_receiver);

        List<GameModel> GetUserBoardGames(int userId);

        List<GameModel> GetBoardGame_UserNotPossessed(int userId);
    }
}
