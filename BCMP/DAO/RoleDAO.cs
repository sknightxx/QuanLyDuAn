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

        public List<Role> GetAllRole()
        {
            String query = "USP_GetRole";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            List<Role> list = new List<Role>();
            foreach (DataRow row in result.Rows)
            {
                Role item = new Role(row);
                list.Add(item);
            }
            return list;
        }

        public bool InsertRole(string title, string description)
        {
            string query = "USP_InsertRole @title , @description";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { title, description });
            return result > 0;
        }

        public bool UpdateRole(int roleId, string title, string description)
        {
            string query = "USP_UpdateRole @roleId , @title , @description";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { roleId, title, description });
            return result > 0;
        }

        public bool DeleteRole(int roleId)
        {
            string query = "USP_DeleteRole @roleId";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { roleId });
            return result > 0;
        }
    }
}
