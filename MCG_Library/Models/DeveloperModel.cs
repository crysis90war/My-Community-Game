using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class DeveloperModel
    {
        private int _developerId;
        private string _developerName;

        public int DeveloperId
        {
            get { return _developerId; }
            set { _developerId = value; }
        }

        public string DeveloperName
        {
            get { return _developerName; }
            set { _developerName = value; }
        }

        public DeveloperModel()
        {

        }

        public DeveloperModel(string developerName)
        {
            this.DeveloperName = developerName;
        }

        public DeveloperModel(int developerId, string developerName)
        {
            this.DeveloperId = developerId;
            this.DeveloperName = developerName;
        }
    }
}
