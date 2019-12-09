using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class ScoreModel
    {
		private int _score;

		public int Score
		{
			get { return _score; }
			set { _score = value; }
		}

		public ScoreModel()
		{

		}

		public ScoreModel(int score)
		{
			this.Score = score;
		}

		public string ScoreToString
		{
			get
			{
				return $"{ Score }";
			}
		}
	}
}
