﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class DefiModel
    {
        #region Private Fields
        private int _defiId;
		private int _defiCreatorId;

		public int DefiCreatorId
		{
			get { return _defiCreatorId; }
			set { _defiCreatorId = value; }
		}

		private string _defiName;
		private string _defiDisplayName;
		private string _defiDescription;
		private string _defiCreatedDate;
		private int _defiIsApproved;
		private int _defiScore;

		#endregion

		#region Public Properties
		public int DefiId
		{
			get { return _defiId; }
			set { _defiId = value; }
		}

		public string DefiName
		{
			get { return _defiName; }
			set { _defiName = value; }
		}

		public string DefiDisplayName
		{
			get { return _defiDisplayName; }
			set { _defiDisplayName = value; }
		}

		public string DefiDescription
		{
			get { return _defiDescription; }
			set { _defiDescription = value; }
		}

		public string DefiCreatedDate
		{
			get { return _defiCreatedDate; }
			set { _defiCreatedDate = value; }
		}

		public int DefiIsApproved
		{
			get { return _defiIsApproved; }
			set { _defiIsApproved = value; }
		}

		public int DefiScore
		{
			get { return _defiScore; }
			set { _defiScore = value; }
		}
		#endregion

		public DefiModel()
		{

		}

		public DefiModel(string defiName, string defiDisplayName, string defiDescription, int defiCreatorId, int defiScore)
		{
			this.DefiName = defiName;
			this.DefiDisplayName = defiDisplayName;
			this.DefiDescription = defiDescription;
			this.DefiCreatorId = defiCreatorId;
			this.DefiScore = defiScore;
		}

		public string ScoreToString
		{
			get
			{
				return $"Score : { DefiScore }";
			}
		}
	}
}
