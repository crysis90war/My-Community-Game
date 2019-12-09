using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class DefiModel
    {
		private int _defiId;

		public int DefiId
		{
			get { return _defiId; }
			set { _defiId = value; }
		}

		private string _defiName;

		public string DefiName
		{
			get { return _defiName; }
			set { _defiName = value; }
		}

		private string _defiDisplayName;

		public string DefiDisplayName
		{
			get { return _defiDisplayName; }
			set { _defiDisplayName = value; }
		}

		private string _defiDescription;

		public string DefiDescription
		{
			get { return _defiDescription; }
			set { _defiDescription = value; }
		}

		private string _defiCreatedDate;

		public string DefiCreatedDate
		{
			get { return _defiCreatedDate; }
			set { _defiCreatedDate = value; }
		}

		private int _defiCreator;

		public int DefiCreator
		{
			get { return _defiCreator; }
			set { _defiCreator = value; }
		}

		private int _defiIsApproved;

		public int DefiIsApproved
		{
			get { return _defiIsApproved; }
			set { _defiIsApproved = value; }
		}

		private int _defiScore;

		public int DefiScore
		{
			get { return _defiScore; }
			set { _defiScore = value; }
		}


		public DefiModel()
		{

		}

		public DefiModel(string defiName, string defiDisplayName, string defiDescription, int defiCreator, int defiScore)
		{
			this.DefiName = defiName;
			this.DefiDisplayName = defiDisplayName;
			this.DefiDescription = defiDescription;
			this.DefiCreator = defiCreator;
			this.DefiScore = defiScore;
		}
	}
}
