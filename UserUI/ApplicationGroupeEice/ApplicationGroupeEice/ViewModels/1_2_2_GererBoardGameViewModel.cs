﻿using Caliburn.Micro;
using MCG_Library;
using MCG_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class GererBoardGameViewModel : Screen
    {
        #region Private Fields
        private int _userId;
        private string _warningMessage;

        public string WarningMessage
        {
            get { return _warningMessage; }
            set
            {
                _warningMessage = value;
                NotifyOfPropertyChange(() => WarningMessage);
            }
        }

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                NotifyOfPropertyChange(() => UserId);
            }
        }

        private GameModel _selectedUGame;
        private GameModel _selectedCGame;
        private BindableCollection<GameModel> _userGames = new BindableCollection<GameModel>();
        private BindableCollection<GameModel> _communityGames = new BindableCollection<GameModel>();
        #endregion

        #region Public Properties
        public GameModel SelectedUGame
        {
            get { return _selectedUGame; }
            set
            {
                _selectedUGame = value;
                NotifyOfPropertyChange(() => SelectedUGame);
            }
        }

        public GameModel SelectedCGame
        {
            get { return _selectedCGame; }
            set
            {
                _selectedCGame = value;
                NotifyOfPropertyChange(() => SelectedCGame);
            }
        }

        public BindableCollection<GameModel> UserGames
        {
            get { return _userGames; }
            set { _userGames = value; NotifyOfPropertyChange(() => UserGames); }
        }

        public BindableCollection<GameModel> CommunityGames
        {
            get { return _communityGames; }
            set { _communityGames = value; NotifyOfPropertyChange(() => CommunityGames); }
        }
        #endregion

        #region Constructor
        public GererBoardGameViewModel(int userId)
        {
            List<GameModel> userGames = GlobalConfig.Connection.GetUserBoardGames(userId);
            List<GameModel> communityGames = GlobalConfig.Connection.GetBoardGame_UserNotPossessed(userId);
            UserId = userId;

            foreach (var game in userGames)
            {
                communityGames.RemoveAll(communityGame => communityGame.GameId.Equals(game.GameId));
            }

            foreach (var uGame in userGames)
            {
                UserGames.Add(uGame);
            }

            foreach (var CGame in communityGames)
            {
                CommunityGames.Add(CGame);
            }
        }
        #endregion
    }
}