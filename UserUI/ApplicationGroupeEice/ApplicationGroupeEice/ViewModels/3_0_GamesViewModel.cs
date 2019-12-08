using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using MCG_Library.Models;

namespace ApplicationGroupeEice.ViewModels
{
    public class GamesViewModel : Conductor<object>
    {
        UserModel userData;
        List<GameModel> userGames;

        public GamesViewModel(UserModel modele)
        {
            userData = modele;
            userGames = userData.UserGames;
            ActivateItem(new MyGamesViewModel(userData.UserGames));
        }

        public void MI_MesJeux()
        {
            ActivateItem(new MyGamesViewModel(userGames));
        }

        public void MI_GererJeux()
        {
            ActivateItem(new GererJeuxViewModel(userData.UserId));
        }

        public void MI_GererAchievement()
        {
            ActivateItem(new GererAchievementViewModel(userData.UserId));
        }

        public void MI_GererDefis()
        {
            ActivateItem(new GererDefisViewModel(userData.UserId));
        }
    }
}
