using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.DAO
{
    public class RoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance
        {
            get { if (instance == null) instance = new RoleDAO(); return instance; }
            private set => instance = value;
        }

        private RoleDAO() { }

        public Role GetById(int roleId)
        {
            Role emp = null;
            string query = "USP_GetRoleById @userId";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { roleId });
            foreach (DataRow row in result.Rows)
            {
                emp = new Role(row);
            }
            return emp;
        }
    }
}
