using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class GenreModel
    {
        private int _genreId;
        private string _genreName;

        public int GenreId
        {
            get { return _genreId; }
            set { _genreId = value; }
        }

        public string GenreName
        {
            get { return _genreName; }
            set { _genreName = value; }
        }

        public GenreModel()
        {

        }

        public GenreModel(string genreName)
        {
            this.GenreName = genreName;
        }

        public GenreModel(int genreId, string genreName)
        {
            this.GenreId = genreId;
            this.GenreName = genreName;
        }
    }
}
