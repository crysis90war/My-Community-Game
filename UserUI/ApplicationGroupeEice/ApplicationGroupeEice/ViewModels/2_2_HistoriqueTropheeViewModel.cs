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
    public class HistoriqueTropheeViewModel : Screen
    {
        private BindableCollection<AchievementModel> _userAchievements = new BindableCollection<AchievementModel>();

        public BindableCollection<AchievementModel> UserAchievements
        {
            get { return _userAchievements; }
            set { _userAchievements = value; }
        }

        public HistoriqueTropheeViewModel(int userId)
        {
            List<AchievementModel> userAchievements = GlobalConfig.Connection.GetUserAchievement_Achieved(userId);

            foreach (var achievement in userAchievements)
            {
                UserAchievements.Add(achievement);
            }
        }
    }
}
