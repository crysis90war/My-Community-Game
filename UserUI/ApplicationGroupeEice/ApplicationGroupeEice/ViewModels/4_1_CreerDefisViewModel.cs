using Caliburn.Micro;
using MCG_Library;
using MCG_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class CreerDefisViewModel : Screen
    {
        #region Private Fields
        private int _userId;
        private string _challengeName;
        private string _challengeDisplayName;
        private string _challengeDescription;
        private string _warningMessage = "";
        private UserModel _userData = new UserModel();
        private BindableCollection<GameModel> _userGames = new BindableCollection<GameModel>();
        private GameModel _selectedGame;
        private BindableCollection<ScoreModel> _challengeScore = new BindableCollection<ScoreModel>();
        private ScoreModel _selectedChallengeScore;

        #endregion

        #region Public Properties
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }

        public BindableCollection<GameModel> UserGames
        {
            get { return _userGames; }
            set { _userGames = value; NotifyOfPropertyChange(() => UserGames); }
        }
        public GameModel SelectedGame
        {
            get { return _selectedGame; }
            set { _selectedGame = value; NotifyOfPropertyChange(() => SelectedGame); }
        }
        public BindableCollection<ScoreModel> ChallengeScore
        {
            get { return _challengeScore; }
            set { _challengeScore = value; NotifyOfPropertyChange(() => ChallengeScore); }
        }

        public ScoreModel SelectedChallengeScore
        {
            get { return _selectedChallengeScore; }
            set { _selectedChallengeScore = value; NotifyOfPropertyChange(() => SelectedChallengeScore); }
        }

        public UserModel UserData
        {
            get { return _userData; }
            set { _userData = value; NotifyOfPropertyChange(() => UserData); }
        }

        public string ChallengeDisplayName
        {
            get { return _challengeDisplayName; }
            set { _challengeDisplayName = value; NotifyOfPropertyChange(() => ChallengeDisplayName); }
        }

        public string ChallengeName
        {
            get { return _challengeName; }
            set { _challengeName = value; NotifyOfPropertyChange(() => ChallengeName); }
        }

        public string ChallengeDescription
        {
            get { return _challengeDescription; }
            set { _challengeDescription = value; NotifyOfPropertyChange(() => ChallengeDescription); }
        }

        public string WarningMessage
        {
            get { return _warningMessage; }
            set { _warningMessage = value; NotifyOfPropertyChange(() => WarningMessage); }
        }
        #endregion

        #region Constructor
        public CreerDefisViewModel(int userId)
        {
            InitializeScore();
            UserId = userId;
            // UserModel userData = new UserModel();
            List<GameModel> userGames = new List<GameModel>();
            UserData = GlobalConfig.Connection.GetUser_Info(userId);
            userGames = UserData.UserGames;

            foreach (var game in userGames)
            {
                UserGames.Add(game);
            }
        }
        #endregion

        #region Others
        public void boutonCreerDefi()
        {
            try
            {
                if (ChallengeName.Length != 0 && ChallengeDisplayName.Length != 0 && SelectedChallengeScore != null && SelectedGame != null)
                {
                    DefiModel modele = new DefiModel();
                    modele.DefiName = ChallengeName;
                    modele.DefiDisplayName = ChallengeDisplayName;
                    if (ChallengeDescription.Length == 0)
                    {
                        ChallengeDescription = "";
                        modele.DefiDescription = ChallengeDescription;
                    }
                    else
                    {
                        modele.DefiDescription = ChallengeDescription;
                    }
                    modele.DefiScore = SelectedChallengeScore.Score;


                    GlobalConfig.Connection.CreerDefi(modele, UserData.UserId, SelectedGame.GameId);
                    ReinitialisationChamps();
                    WarningMessage = "Défi crée avec succès.";
                }
                else
                {
                    WarningMessage = "Tous les champs sauf description sont obligatoire.";
                }
            }
            catch (Exception error)
            {
                System.Diagnostics.Debug.WriteLine(error.Message);
                WarningMessage = error.Message;
            }
        }

        public void InitializeScore()
        {
            List<ScoreModel> listScore = new List<ScoreModel>();

            int scoreDepart = 1;
            for (int i = 0; i < 10; i++)
            {
                listScore.Add(new ScoreModel(scoreDepart));
                scoreDepart++;
            }

            foreach (var score in listScore)
            {
                ChallengeScore.Add(score);
            }
        }

        public void ReinitialisationChamps()
        {
            ChallengeName = "";
            ChallengeDisplayName = "";
            ChallengeDescription = "";
            SelectedChallengeScore = null;
            SelectedGame = null;
        }
        #endregion
    }
}
