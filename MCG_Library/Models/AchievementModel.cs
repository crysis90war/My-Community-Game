using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class AchievementModel
    {
        #region Private Fields
        private int _achievementId;
        private string _achievementName;
        private string _achievementDisplayName;
        private string _achievementDescription;
        private string _achievementIconUrl;
        private string _achievementIconGrayUrl;
        private double _achievementPercent;
        private int _achievementAchieved;
        private string _achievementAchievedDate;
        private int _achievementScore;

        public int AchievementScore
        {
            get { return _achievementScore; }
            set 
            {
                _achievementScore = value; 
            }
        }

        #endregion

        #region Public Properties
        public int AchievementId
        {
            get { return _achievementId; }
            set { _achievementId = value; }
        }

        public string AchievementName
        {
            get { return _achievementName; }
            set { _achievementName = value; }
        }

        public string AchievementDisplayName
        {
            get { return _achievementDisplayName; }
            set { _achievementDisplayName = value; }
        }

        public string AchievementDescription
        {
            get { return _achievementDescription; }
            set { _achievementDescription = value; }
        }

        public string AchievementIconUrl
        {
            get { return _achievementIconUrl; }
            set { _achievementIconUrl = value; }
        }

        public string AchievementIconGrayUrl
        {
            get { return _achievementIconGrayUrl; }
            set { _achievementIconGrayUrl = value; }
        }

        public double AchievementPercent
        {
            get { return Math.Truncate(_achievementPercent); }
            set { _achievementPercent = value; }
        }
        public int AchievementAchieved
        {
            get { return _achievementAchieved; }
            set { _achievementAchieved = value; }
        }

        public string AchievementAchievedDate
        {
            get { return _achievementAchievedDate; }
            set { _achievementAchievedDate = value; }
        }
        #endregion

        #region Constructors
        public AchievementModel()
        {

        }

        /// <summary>
        /// Constructeur permettant d'ajouter un achievement qui n'est pas encore obtenu
        /// </summary>
        /// <param name="achievementId"></param>
        /// <param name="achievementName"></param>
        /// <param name="achievementDisplayName"></param>
        /// <param name="achievementDescription"></param>
        /// <param name="achievementIconGrayUrl"></param>
        /// <param name="achievementPercent"></param>
        /// <param name="achievementAchieved"></param>
        public AchievementModel(int achievementId, string achievementName, string achievementDisplayName, string achievementDescription, string achievementIconGrayUrl, double achievementPercent, int achievementAchieved)
        {
            this.AchievementId = achievementId;
            this.AchievementName = achievementName;
            this.AchievementDisplayName = achievementDisplayName;
            this.AchievementDescription = achievementDescription;
            this.AchievementIconGrayUrl = achievementIconGrayUrl;
            this.AchievementPercent = achievementPercent;
            this.AchievementAchieved = achievementAchieved;
        }

        /// <summary>
        /// Constructeur permettant d'ajouter un achievement obtenu
        /// </summary>
        /// <param name="achievementId"></param>
        /// <param name="achievementName"></param>
        /// <param name="achievementDisplayName"></param>
        /// <param name="achievementDescription"></param>
        /// <param name="achievementIconUrl"></param>
        /// <param name="achievementPercent"></param>
        /// <param name="achievementAchieved"></param>
        /// <param name="achievementAchievedDate"></param>
        public AchievementModel(int achievementId, string achievementName, string achievementDisplayName, string achievementDescription, string achievementIconUrl, double achievementPercent, int achievementAchieved, string achievementAchievedDate)
        {
            this.AchievementId = achievementId;
            this.AchievementName = achievementName;
            this.AchievementDisplayName = achievementDisplayName;
            this.AchievementDescription = achievementDescription;
            this.AchievementIconUrl = achievementIconUrl;
            this.AchievementPercent = achievementPercent;
            this.AchievementAchieved = achievementAchieved;
            this.AchievementAchievedDate = achievementAchievedDate;
        }

        public AchievementModel(string achievementName, string achievementDisplayName, string achievementDescription, string achievementIconUrl, string achievementIconGrayUrl, double achievementPercent)
        {
            this.AchievementName = achievementName;
            this.AchievementDisplayName = achievementDisplayName;
            this.AchievementDescription = achievementDescription;
            this.AchievementIconUrl = achievementIconUrl;
            this.AchievementPercent = achievementPercent;
            this.AchievementIconGrayUrl = achievementIconGrayUrl;
        }
        #endregion

        #region Others
        public string AchievementAchiedorNot
        {
            get
            {
                if (AchievementAchieved == 1)
                {
                    return $"{ AchievementIconUrl }";
                }
                else
                {
                    return $"{ AchievementIconGrayUrl }";
                }
            }
        }

        public int AchievementScoreCalcule()
        {
            int score = 0;

            if (AchievementPercent >= 90 && AchievementPercent < 100)
            {
                score = 2;
            }
            if (AchievementPercent >= 80 && AchievementPercent < 90)
            {
                score = 4;
            }
            if (AchievementPercent >= 70 && AchievementPercent < 80)
            {
                score = 6;
            }
            if (AchievementPercent >= 60 && AchievementPercent < 70)
            {
                score = 8;
            }
            if (AchievementPercent >= 50 && AchievementPercent < 60)
            {
                score = 10;
            }
            if (AchievementPercent >= 40 && AchievementPercent < 50)
            {
                score = 12;
            }
            if (AchievementPercent >= 30 && AchievementPercent < 40)
            {
                score = 14;
            }
            if (AchievementPercent >= 20 && AchievementPercent < 30)
            {
                score = 16;
            }
            if (AchievementPercent >= 10 && AchievementPercent < 20)
            {
                score = 18;
            }
            if (AchievementPercent >= 0 && AchievementPercent < 10)
            {
                score = 20;
            }

            return score;
        }
        #endregion
    }
}
