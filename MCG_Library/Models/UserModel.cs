using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class UserModel
    {
        #region Private Fields
        private int _userExists;
        private int _userId;
        private string _userLogin;
        private string _userPublicName;
        private string _userEmail;
        private string _userPassword;
        private string _userSteamId;
        private int _userScore;
        private int _userIsBanned;
        private string _userCreatedDate;
        private string _userUpdatedDate;
        private string _userConnectedDate;
        private int _numberOfTrophies;
        private int _userClassement;
        private StatusModel _userStatus;
        private RankModel _userRank;
        private RoleModel _userRole;
        private List<UserModel> _userFriends = new List<UserModel>();
        private List<UserModel> _userFriendRequest = new List<UserModel>();
        private List<UserModel> _userFriendReceived = new List<UserModel>();
        private List<GameModel> _userGames = new List<GameModel>();

        private UserModel _selectedUser;

        public UserModel SelectedUser
        {
            get { return _selectedUser; }
            set { _selectedUser = value; }
        }

        #endregion

        #region Public Properties
        public int UserExists
        {
            get { return _userExists; }
            private set { _userExists = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string UserLogin
        {
            get { return _userLogin; }
            set { _userLogin = value; }
        }

        public string UserPublicName
        {
            get { return _userPublicName; }
            set { _userPublicName = value; }
        }

        public string UserEmail
        {
            get { return _userEmail; }
            set { _userEmail = value; }
        }

        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

        public string UserSteamId
        {
            get { return _userSteamId; }
            set { _userSteamId = value; }
        }

        public int UserScore
        {
            get { return _userScore; }
            set { _userScore = value; }
        }

        public int UserIsBanned
        {
            get { return _userIsBanned; }
            set { _userIsBanned = value; }
        }

        public string UserCreatedDate
        {
            get { return _userCreatedDate; }
            set { _userCreatedDate = value; }
        }

        public string UserUpdateDate
        {
            get { return _userUpdatedDate; }
            set { _userUpdatedDate = value; }
        }

        public string UserConnectedDate
        {
            get { return _userConnectedDate; }
            set { _userConnectedDate = value; }
        }

        public int NumberOfTrophies
        {
            get { return _numberOfTrophies; }
            set { _numberOfTrophies = value; }
        }

        public int UserClassement
        {
            get { return _userClassement; }
            set { _userClassement = value; }
        }

        public StatusModel UserStatus
        {
            get { return _userStatus; }
            set { _userStatus = value; }
        }

        public RankModel UserRank
        {
            get { return _userRank; }
            set { _userRank = value; }
        }

        public RoleModel UserRole
        {
            get { return _userRole; }
            set { _userRole = value; }
        }

        public List<UserModel> UserFriends
        {
            get { return _userFriends; }
            set { _userFriends = value; }
        }

        public List<UserModel> UserFriendRequest
        {
            get { return _userFriendRequest; }
            set { _userFriendRequest = value; }
        }

        public List<UserModel> UserFriendReceived
        {
            get { return _userFriendReceived; }
            set { _userFriendReceived = value; }
        }

        public List<GameModel> UserGames
        {
            get { return _userGames; }
            set { _userGames = value; }
        }
        #endregion

        #region Constructors
        public UserModel()
        {

        }

        public UserModel(int userId, string userPrivateName, string userPublicName, string userEmail, string userPassword, int userSteamId)
        {

        }

        /// <summary>
        /// Constructeur pour la gestion d'administraeur
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userPrivateName"></param>
        /// <param name="userPublicName"></param>
        /// <param name="userEmail"></param>
        /// <param name="userSteamId"></param>
        /// <param name="userScore"></param>
        /// <param name="userCreatedDate"></param>
        /// <param name="userConnectedDate"></param>
        public UserModel(int userId, string userPrivateName, string userPublicName, string userEmail, string userSteamId, int userScore, string userCreatedDate, string userConnectedDate)
        {
            this.UserId = userId;
            this.UserLogin = userPrivateName;
            this.UserPublicName = userPublicName;
            this.UserEmail = userEmail;
            this.UserSteamId = userSteamId;
            this.UserScore = userScore;
            this.UserCreatedDate = userCreatedDate;
            this.UserConnectedDate = userConnectedDate;
        }
        #endregion

        #region Others
        public string IsBannedState
        {
            get
            {
                if (UserIsBanned == 1)
                {
                    return $"Banni";
                }
                else
                {
                    return $"Active";
                }
            }
        }
        #endregion
    }
}
