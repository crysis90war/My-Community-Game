using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class RoleModel
    {
		private int _roleId;

		public int RoleId
		{
			get { return _roleId; }
			set { _roleId = value; }
		}

		private string _roleName;

		public string RoleName
		{
			get { return _roleName; }
			set { _roleName = value; }
		}

		public RoleModel()
		{

		}
	}
}
