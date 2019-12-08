using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class StatusModel
    {
        private int _statusId;
        private string _statusName;
        private string _statusIconUrl;

        public int StatusId
        {
            get { return _statusId; }
            set { _statusId = value; }
        }

        public string StatusName
        {
            get { return _statusName; }
            set { _statusName = value; }
        }

        public string StatusIconUrl
        {
            get { return _statusIconUrl; }
            set { _statusIconUrl = value; }
        }
    }
}
