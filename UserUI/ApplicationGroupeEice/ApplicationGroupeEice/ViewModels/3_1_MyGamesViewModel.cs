using Caliburn.Micro;
using MCG_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ApplicationGroupeEice.ViewModels
{
    public class MyGamesViewModel : Screen
    {
        #region Private Fields
        private GameModel _selectedGame;
        private List<DeveloperModel> _selectedDeveloper;
        private List<AchievementModel> _selectedAchievement;
        private List<GenreModel> _selectedGenre;
        private BindableCollection<GameModel> _userGames = new BindableCollection<GameModel>();
        private BindableCollection<GenreModel> _gameGenre;
        private string _errorMessage;
        #endregion

        #region Public Properties
        public GameModel SelectedGame
        {
            get { return _selectedGame; }
            set
            {
                _selectedGame = value;
                SelectedGenre = value.GameGenres;
                SelectedDeveloper = value.GameDevelopers;
                SelectedAchievement = value.GameAchievements;
                WarningMessage = "";
                NotifyOfPropertyChange(() => SelectedGame);
            }
        }

        public List<DeveloperModel> SelectedDeveloper
        {
            get { return _selectedDeveloper; }
            set
            {
                _selectedDeveloper = value;
                SelectedGame.GameDevelopers = value;
                NotifyOfPropertyChange(() => SelectedDeveloper);
            }
        }

        public List<AchievementModel> SelectedAchievement
        {
            get { return _selectedAchievement; }
            set
            {
                _selectedAchievement = value;
                SelectedGame.GameAchievements = value;
                NotifyOfPropertyChange(() => SelectedAchievement);
            }
        }

        public List<GenreModel> SelectedGenre
        {
            get { return _selectedGenre; }
            set
            {
                _selectedGenre = value;
                SelectedGame.GameGenres = value;
                NotifyOfPropertyChange(() => SelectedGenre);
            }
        }

        public BindableCollection<GameModel> UserGames
        {
            get { return _userGames; }
            set { _userGames = value; }
        }

        public BindableCollection<GenreModel> GameGenre
        {
            get { return _gameGenre; }
            set { _gameGenre = value; }
        }

        public string WarningMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => WarningMessage);
            }
        }
        #endregion

        /// <summary>
        /// Constructeur pour le controle d'utilisateur "MyGamesViewModel"
        /// </summary>
        /// <param name="modele"></param>
        public MyGamesViewModel(List<GameModel> modele)
        {
            List<GameModel> userGames = new List<GameModel>();
            userGames = modele;

            foreach (var game in userGames)
            {
                UserGames.Add(game);
            }
        }

        public void LinkButton()
        {
            try
            {
                Process.Start(SelectedGame.GameNews);
            }
            catch (Exception)
            {
                WarningMessage = "Veuillez selectionner un jeu";
            }
        }
    }
}
