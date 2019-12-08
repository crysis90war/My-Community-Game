using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class RankModel
    {
        #region Private Fields
        private int _rankId;
        private string _rankName;
        private int _rankExp;
        private string _rankIconUrl;
        #endregion

        #region Public Properties
        public int RankId
        {
            get { return _rankId; }
            set { _rankId = value; }
        }

        public string RankName
        {
            get { return _rankName; }
            set { _rankName = value; }
        }

        public int RankExp
        {
            get { return _rankExp; }
            set { _rankExp = value; }
        }

        public string RankIconUrl
        {
            get { return _rankIconUrl; }
            set { _rankIconUrl = value; }
        }
        #endregion

        #region Constructors

        public RankModel()
        {

        }

        public RankModel(int rankId, string rankName, int rankExp, string rankIconUrl)
        {
            this.RankId = rankId;
            this.RankName = rankName;
            this.RankExp = rankExp;
            this.RankIconUrl = rankIconUrl;
        }
        #endregion

        #region Others
        // ...
        #endregion
    }
}
