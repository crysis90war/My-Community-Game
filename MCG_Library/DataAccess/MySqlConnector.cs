using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCG_Library.Models;
using MySql.Data.MySqlClient;
using Dapper;
using System.Data;

namespace MCG_Library.DataAccess
{
    public class MySqlConnector : IDataConnection
    {
        public void CreerDefi(DefiModel modele, int userId, int gameId)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_user", userId);
                p.Add("@in_ref_game", gameId);
                p.Add("@in_defi_name", modele.DefiName.ToUpper());
                p.Add("@in_defi_displayName", modele.DefiDisplayName);
                p.Add("@in_defi_description", modele.DefiDescription);
                p.Add("@in_defi_score", modele.DefiScore);

                connection.Execute("spDefi_insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreerAchievement(AchievementModel modele, int gameId)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_game", gameId);
                p.Add("@in_achievement_name", modele.AchievementName);
                p.Add("@in_achievement_displayName", modele.AchievementDisplayName);
                p.Add("@in_achievement_description", modele.AchievementDescription);
                p.Add("@in_achievement_icon_url", modele.AchievementIconUrl);
                p.Add("@in_achievement_iconGray_url", modele.AchievementIconGrayUrl);
                p.Add("@in_achievement_percent", modele.AchievementPercent);

                connection.Execute("spAchievement_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreerGameDeveloper(int gameId, int developerId)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_game", gameId);
                p.Add("@in_ref_developer", developerId);

                connection.Execute("spGameDevelopers_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreerGameGenre(int gameId, int genreId)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_game", gameId);
                p.Add("@in_ref_genre", genreId);

                connection.Execute("spGameGenres_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreerGenre(GenreModel modele)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_genre_name", modele.GenreName);
                connection.Execute("spGenre_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreerDeveloper(DeveloperModel modele)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_developer_name", modele.DeveloperName);
                connection.Execute("spDeveloper_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreerJeu(GameModel modele)
        {
            List<GenreModel> genres = new List<GenreModel>();
            List<string> genresString = new List<string>();
            List<DeveloperModel> developers = new List<DeveloperModel>();
            List<string> developersString = new List<string>();
            int gameId;
            int genreId;
            int developerId;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_game_appid", modele.GameAppId);
                p.Add("@in_game_name", modele.GameName);
                p.Add("@in_game_image_url", modele.GameImageUrl);
                p.Add("@in_game_description", modele.GameDescription);
                p.Add("@in_game_release_date", modele.GameReleaseDate);

                connection.Execute("spGame_Insert", p, commandType: CommandType.StoredProcedure);

                genres = connection.Query<GenreModel>("spGetGenre_All").ToList();
                developers = connection.Query<DeveloperModel>("spGetDeveloper_all").ToList();

                gameId = GetGameId_ByGameAppId(modele);

                // ----------------------------------------------------------------------------------------------------------

                List<string> listtest = new List<string>();

                foreach (var genreInGame in modele.GameGenres)
                {
                    string nom = genreInGame.GenreName;
                    bool contient = false;
                    foreach (var genreInList in genres)
                    {
                        if (genreInList.GenreName.Contains(nom))
                        {
                            genreId = GetGenreId_ByName(genreInGame);
                            CreerGameGenre(gameId, genreInList.GenreId);
                            contient = true;
                        }
                    }
                    if (contient == false)
                    {
                        CreerGenre(genreInGame);
                        genreId = GetGenreId_ByName(genreInGame);
                        CreerGameGenre(gameId, genreId);
                    }
                }

                foreach (var developerInGame in modele.GameDevelopers)
                {
                    string nom = developerInGame.DeveloperName;
                    bool contient = false;

                    foreach (var developerInList in developers)
                    {
                        if (developerInList.DeveloperName.Contains(nom))
                        {
                            developerId = GetDeveloperId_ByName(developerInList);
                            CreerGameDeveloper(gameId, developerId);
                            contient = true;
                        }
                    }
                    if (contient == false)
                    {
                        CreerDeveloper(developerInGame);
                        developerId = GetDeveloperId_ByName(developerInGame);
                        CreerGameDeveloper(gameId, developerId);
                    }
                }

                // ----------------------------------------------------------------------------------------------------------

                foreach (var gameAchievement in modele.GameAchievements)
                {
                    CreerAchievement(gameAchievement, gameId);
                }
            }
        }

        public int GetGameId_ByGameAppId(GameModel modele)
        {
            int output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_game_appid", modele.GameAppId);

                output = connection.Query<int>("spGetGameId_ByGameAppId", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return output;
        }

        public int GetGenreId_ByName(GenreModel modele)
        {
            int output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_genre_name", modele.GenreName);

                output = connection.Query<int>("spGetGenreId_ByName", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            return output;
        }

        public int GetDeveloperId_ByName(DeveloperModel modele)
        {
            int output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_developer_name", modele.DeveloperName);

                output = connection.Query<int>("spGetDeveloperId_ByName", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return output;
        }

        public void CreerUtilisateur(UserModel modele)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_user_login", modele.UserLogin.ToLower());
                p.Add("@in_user_public_name", modele.UserPublicName);
                p.Add("@in_user_email", modele.UserEmail.ToLower());
                p.Add("@in_user_password", modele.UserPassword);

                connection.Execute("spUser_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateConnexionUtilisateur(UserModel modele)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_user_id", modele.UserId);

                connection.Execute("spUpdateUser_Connection", p, commandType: CommandType.StoredProcedure);

                p = new DynamicParameters();
                p.Add("@in_ref_user", modele.UserId);

                connection.Execute("spUpdateUser_StatusOnline", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateDeconnexionUtilisateur(UserModel modele)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_user", modele.UserId);

                connection.Execute("spUpdateUser_StatusOffline", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateUserAchievement(int userId, int userAchievementId)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_user", userId);
                p.Add("@in_ref_achievement", userAchievementId);
                connection.Execute("spUserAchievement_Update", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateUser_Score(int userId, int newScore)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@IN_user_id", userId);
                p.Add("@IN_user_score", newScore);

                connection.Execute("spUpdateUser_Score", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateUser_Rank(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@IN_user_id", userId);

                connection.Execute("spUpdateUser_Rank", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreerJeuUtilisateur(UserModel modele, int gameId)
        {
            List<AchievementModel> achievements = new List<AchievementModel>();

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_user_game_ref_user", modele.UserId);
                p.Add("@in_user_game_ref_game", gameId);

                connection.Execute("spUserGame_Insert", p, commandType: CommandType.StoredProcedure);

                p = new DynamicParameters();
                p.Add("IN_achievement_ref_game", gameId);
                achievements = connection.Query<AchievementModel>("spGetAchievement_ByGame", p, commandType: CommandType.StoredProcedure).ToList();

                foreach (var achievement in achievements)
                {
                    p = new DynamicParameters();
                    p.Add("@in_ref_user", modele.UserId);
                    p.Add("@in_ref_achievement", achievement.AchievementId);

                    connection.Execute("spAchievement_InsertByUserGame", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public List<AchievementModel> GetAchievements_All()
        {
            List<AchievementModel> output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                output = connection.Query<AchievementModel>("spGetAchievements_All").ToList();
            }

            return output;
        }

        public List<DeveloperModel> GetDeveloper_All()
        {
            List<DeveloperModel> output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                output = connection.Query<DeveloperModel>("spGetDeveloper_All").ToList();
            }

            return output;
        }

        public List<GameModel> GetGame_All()
        {
            List<GameModel> output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                output = connection.Query<GameModel>("spGetGame_All").ToList();
                var p = new DynamicParameters();

                foreach (var game in output)
                {
                    p = new DynamicParameters();
                    p.Add("@IN_achievement_ref_game", game.GameId);
                    game.GameAchievements = connection.Query<AchievementModel>("spGetAchievement_ByGame", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (var achievement in game.GameAchievements)
                    {
                        achievement.AchievementScore = achievement.AchievementScoreCalcule();
                    }
                }

                foreach (var game in output)
                {
                    p = new DynamicParameters();
                    p.Add("@in_ref_game", game.GameId);
                    game.GameGenres = connection.Query<GenreModel>("spGetGenre_ByGame", p, commandType: CommandType.StoredProcedure).ToList();
                }

                foreach (var game in output)
                {
                    p = new DynamicParameters();
                    p.Add("@in_ref_game", game.GameId);
                    game.GameDevelopers = connection.Query<DeveloperModel>("spGetDeveloper_ByGame", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }

        public List<GameModel> GetGame_UserNotPossessed(int userId)
        {
            List<GameModel> output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_user", userId);

                output = connection.Query<GameModel>("spGetGame_UserNotPossessed", p, commandType: CommandType.StoredProcedure).ToList();

                foreach (var game in output)
                {
                    p = new DynamicParameters();
                    p.Add("@IN_achievement_ref_game", game.GameId);
                    game.GameAchievements = connection.Query<AchievementModel>("spGetAchievement_ByGame", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (var achievement in game.GameAchievements)
                    {
                        achievement.AchievementScore = achievement.AchievementScoreCalcule();
                    }
                }

                foreach (var game in output)
                {
                    p = new DynamicParameters();
                    p.Add("@in_ref_game", game.GameId);
                    game.GameGenres = connection.Query<GenreModel>("spGetGenre_ByGame", p, commandType: CommandType.StoredProcedure).ToList();
                }

                foreach (var game in output)
                {
                    p = new DynamicParameters();
                    p.Add("@in_ref_game", game.GameId);
                    game.GameDevelopers = connection.Query<DeveloperModel>("spGetDeveloper_ByGame", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }

        public GameModel GetGame_ByGameId(int gameId)
        {
            GameModel output;
            var p = new DynamicParameters();

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                p = new DynamicParameters();
                p.Add("in_game_id", gameId);

                output = connection.Query<GameModel>("spGetGame_ByGameId", p, commandType: CommandType.StoredProcedure).First();

                p = new DynamicParameters();
                p.Add("@IN_achievement_ref_game", output.GameId);
                output.GameAchievements = connection.Query<AchievementModel>("spGetAchievement_ByGame", p, commandType: CommandType.StoredProcedure).ToList();

                p = new DynamicParameters();
                p.Add("@in_ref_game", gameId);
                output.GameDefis = connection.Query<DefiModel>("spGetDefi_AllApproved", p, commandType: CommandType.StoredProcedure).ToList();

                p = new DynamicParameters();
                p.Add("@in_ref_game", output.GameId);
                output.GameGenres = connection.Query<GenreModel>("spGetGenre_ByGame", p, commandType: CommandType.StoredProcedure).ToList();

                p = new DynamicParameters();
                p.Add("@in_ref_game", output.GameId);
                output.GameDevelopers = connection.Query<DeveloperModel>("spGetDeveloper_ByGame", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<GameModel> GetUserGames(int userId)
        {
            List<GameModel> output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_user", userId);
                output = connection.Query<GameModel>("spUserGame_GetAll", p, commandType: CommandType.StoredProcedure).ToList();

                foreach (var game in output)
                {
                    p = new DynamicParameters();
                    p.Add("@IN_ref_user", userId);
                    p.Add("@IN_ref_game", game.GameId);
                    game.GameAchievements = connection.Query<AchievementModel>("spGetUserAchievement_ByUserNGame", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (var achievement in game.GameAchievements)
                    {
                        achievement.AchievementScore = achievement.AchievementScoreCalcule();
                    }
                }

                foreach (var game in output)
                {
                    p = new DynamicParameters();
                    p.Add("@IN_ref_user", userId);
                    p.Add("@IN_ref_game", game.GameId);
                    game.GameDefis = connection.Query<DefiModel>("spGetUserDefi_ByUserNGame", p, commandType: CommandType.StoredProcedure).ToList();
                }

                foreach (var game in output)
                {
                    p = new DynamicParameters();
                    p.Add("@in_ref_game", game.GameId);
                    game.GameGenres = connection.Query<GenreModel>("spGetGenre_ByGame", p, commandType: CommandType.StoredProcedure).ToList();
                }

                foreach (var game in output)
                {
                    p = new DynamicParameters();
                    p.Add("@in_ref_game", game.GameId);
                    game.GameDevelopers = connection.Query<DeveloperModel>("spGetDeveloper_ByGame", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }

        public List<GenreModel> GetGenre_All()
        {
            List<GenreModel> output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                output = connection.Query<GenreModel>("spGetGenre_All").ToList();
            }

            return output;
        }

        public UserModel GetUser_Info(int userId)
        {
            UserModel output;
            List<GameModel> userGameIds = new List<GameModel>();
            List<GameModel> userGames = new List<GameModel>();

            List<AchievementModel> gameAchievement = new List<AchievementModel>();
            List<List<AchievementModel>> userGameAchievement = new List<List<AchievementModel>>();

            var p = new DynamicParameters();

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                // Récupère info utilisateur
                p = new DynamicParameters();
                p.Add("@in_user_id", userId);
                output = connection.Query<UserModel>("spGetUser_Info", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                output.UserStatus = connection.Query<StatusModel>("spGetUser_Status", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                output.UserRank = connection.Query<RankModel>("spGetUser_Rank", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                output.UserRole = connection.Query<RoleModel>("spGetUser_Role", p, commandType: CommandType.StoredProcedure).FirstOrDefault();


                // Récupère gameIds
                p = new DynamicParameters();
                p.Add("in_ref_user", output.UserId);

                output.NumberOfTrophies = connection.Query<int>(" spGetNumberAccomplishedAchievement", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                //userGameIds = connection.Query<GameModel>("spUserGame_GetAll", p, commandType: CommandType.StoredProcedure).ToList();

                //foreach (var gameId in userGameIds)
                //{
                //    GameModel gameModel = new GameModel();
                //    gameModel = GetGame_ByGameId(gameId.GameId);

                //    userGames.Add(gameModel);
                //}

                userGames = GetUserGames(userId);
                output.UserFriends = GetUserFriendship_Confirmed(userId);
                output.UserFriendRequest = GetUserFriendship_Sent(userId);
                output.UserFriendReceived = GetUserFriendship_Received(userId);

                output.UserGames = userGames;

                //foreach (var game in userGameIds)
                //{
                //    p = new DynamicParameters();
                //    p.Add("in_ref_user", output.UserId);
                //    p.Add("in_achievement_ref_game", game.GameId);

                //    gameAchievement = connection.Query<AchievementModel>("spUserAchievement_GetAll", p, commandType: CommandType.StoredProcedure).ToList();
                //    userGameAchievement.Add(gameAchievement);
                //}

                //output.UserGameAchievements = userGameAchievement;
            }

            return output;
        }

        public UserModel GetUser_One(string userName, string userPassword)
        {
            UserModel output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_user_login", userName);
                p.Add("@in_user_password", userPassword);

                output = connection.Query<UserModel>("spGetUser_UserId ", p, commandType: CommandType.StoredProcedure).FirstOrDefault();

                p = new DynamicParameters();
                p.Add("@in_user_id", output.UserId);
                output.UserRole = connection.Query<RoleModel>("spGetUser_Role", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return output;
        }

        public List<UserModel> GetUser_Classement()
        {
            List<UserModel> output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                output = connection.Query<UserModel>("AfficherClassement").ToList();
                var p = new DynamicParameters();

                foreach (var user in output)
                {
                    p = new DynamicParameters();
                    p.Add("@in_user_id", user.UserId);
                    user.UserStatus = connection.Query<StatusModel>("spGetUser_Status", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    user.UserRank = connection.Query<RankModel>("spGetUser_Rank", p, commandType: CommandType.StoredProcedure).FirstOrDefault();

                    p = new DynamicParameters();
                    p.Add("in_ref_user", user.UserId);

                    user.NumberOfTrophies = connection.Query<int>(" spGetNumberAccomplishedAchievement", p, commandType: CommandType.StoredProcedure).FirstOrDefault();

                    List<GameModel> userGames = new List<GameModel>();

                    userGames = GetUserGames(user.UserId);

                    user.UserGames = userGames;
                }
            }

            return output;
        }

        public List<AchievementModel> GetUserAchievement_Achieved(int userId)
        {
            List<AchievementModel> output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@IN_user_id", userId);

                output = connection.Query<AchievementModel>("spGetUserAchievement_Achieved", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<UserModel> GetUserFriendship_Confirmed(int userId)
        {
            List<UserModel> output = new List<UserModel>();

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                List<int> friendIds;
                var p = new DynamicParameters();
                p.Add("@in_ref_user", userId);
                friendIds = connection.Query<int>("spGetUserFriendship_Confirmed", p, commandType: CommandType.StoredProcedure).ToList();


                foreach (var friendid in friendIds)
                {
                    UserModel tempuser = new UserModel();
                    p = new DynamicParameters();
                    p.Add("@in_user_id", friendid);
                    tempuser = connection.Query<UserModel>("spGetUser_Info", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    tempuser.UserStatus = connection.Query<StatusModel>("spGetUser_Status", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    tempuser.UserRank = connection.Query<RankModel>("spGetUser_Rank", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    output.Add(tempuser);
                }
            }

            return output;
        }

        public List<UserModel> GetUserFriendship_Sent(int userId)
        {
            List<UserModel> output = new List<UserModel>();

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                List<int> friendIds;
                var p = new DynamicParameters();
                p.Add("@in_ref_source", userId);
                friendIds = connection.Query<int>("spGetUserFriendship_Source", p, commandType: CommandType.StoredProcedure).ToList();


                foreach (var friendid in friendIds)
                {
                    UserModel tempuser = new UserModel();
                    p = new DynamicParameters();
                    p.Add("@in_user_id", friendid);
                    tempuser = connection.Query<UserModel>("spGetUser_Info", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    tempuser.UserStatus = connection.Query<StatusModel>("spGetUser_Status", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    tempuser.UserRank = connection.Query<RankModel>("spGetUser_Rank", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    output.Add(tempuser);
                }
            }

            return output;
        }

        public List<UserModel> GetUserFriendship_Received(int userId)
        {
            List<UserModel> output = new List<UserModel>();

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                List<int> friendIds;
                var p = new DynamicParameters();
                p.Add("@in_ref_target", userId);
                friendIds = connection.Query<int>("spGetUserFriendship_Target", p, commandType: CommandType.StoredProcedure).ToList();


                foreach (var friendid in friendIds)
                {
                    UserModel tempuser = new UserModel();
                    p = new DynamicParameters();
                    p.Add("@in_user_id", friendid);
                    tempuser = connection.Query<UserModel>("spGetUser_Info", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    tempuser.UserStatus = connection.Query<StatusModel>("spGetUser_Status", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    tempuser.UserRank = connection.Query<RankModel>("spGetUser_Rank", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    output.Add(tempuser);
                }
            }

            return output;
        }

        public void CreerInvitationAmi(int sourceUserId, int targetUserId)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_source", sourceUserId);
                p.Add("@in_ref_target", targetUserId);

                connection.Execute("spFriendship_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateFriendship_State(int sourceUserId, int targetUserId)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_source", sourceUserId);
                p.Add("@in_ref_target", targetUserId);
                connection.Execute("spUpdateFriendship_State", p, commandType: CommandType.StoredProcedure);
            }
        }

        public int GetUser_Count()
        {
            int output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                output = connection.Query<int>("spGetUser_Count").FirstOrDefault();
            }

            return output;
        }

        public int GetUser_OnlineCount()
        {
            int output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                output = connection.Query<int>("spGetUser_OnlineCount").FirstOrDefault();
            }

            return output;
        }

        public int GetGame_Count()
        {
            int output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                output = connection.Query<int>("spGetGame_Count").FirstOrDefault();
            }

            return output;
        }

        public void CreerPrivate_Msg(Private_MsgModel model)
        {
            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();

                p.Add("@in_is_seen", model.Is_seen);
                p.Add("@in_content", model.Content);

                p.Add("@in_ref_sender", model.Ref_sender);
                p.Add("@in_ref_receiver", model.Ref_receiver);
                p.Add("@in_sent_at", model.Sent_at);

                connection.Execute("spPrivate_msg_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Private_MsgModel> GetPrivate_msg_refSender_refReceiver(int userId, int ref_receiver)
        {
            List<Private_MsgModel> output;
            var p = new DynamicParameters();
            p.Add("@in_ref_sender", userId);
            p.Add("@in_ref_receiver", ref_receiver);

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                output = connection.Query<Private_MsgModel>("spGetPrivate_msg_refSender_refReceiver", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<DefiModel> GetDefi_MesDefisApprouves(int userId)
        {
            List<DefiModel> output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_user", userId);
                output = connection.Query<DefiModel>("spGetDefi_MesDefisApprouves", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<DefiModel> GetDefi_AllApproved(int gameId)
        {
            List<DefiModel> output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_game", gameId);
                output = connection.Query<DefiModel>("spGetDefi_AllApproved", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<UserModel> GetUser_All()
        {
            List<UserModel> output;

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                output = connection.Query<UserModel>("spGetUser_All").ToList();
                foreach (var user in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@in_user_id", user.UserId);
                    user.UserStatus = connection.Query<StatusModel>("spGetUser_Status", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    user.UserRank = connection.Query<RankModel>("spGetUser_Rank", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    user.UserRole = connection.Query<RoleModel>("spGetUser_Role", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }

            return output;
        }

        public void UpdateUser_Ban(int userId)
        {

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_user", userId);

                connection.Execute("spUpdateUserBan_ById", p, commandType: CommandType.StoredProcedure);

                
            }


        }
        public void UpdateUser_Unban(int userId)
        {

            using (MySqlConnection connection = new MySqlConnection(GlobalConfig.CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@in_ref_user", userId);

                connection.Execute("spUpdateUserUnban_ById", p, commandType: CommandType.StoredProcedure);


            }


        }

    }
}