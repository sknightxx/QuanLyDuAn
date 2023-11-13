using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.DAO
{
    public class DepartmentDAO
    {
        private static DepartmentDAO instance;

        public static DepartmentDAO Instance
        {
            get { if (instance == null) instance = new DepartmentDAO(); return instance; }
            private set => instance = value;
        }

        private DepartmentDAO() { }

        public List<Department> GetAllDepartment()
        {
            String query = "USP_GetDepartment";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            List<Department> list = new List<Department>();
            foreach(DataRow row in result.Rows)
            {
                Department item = new Department(row);
                list.Add(item);
            }
            return list;
        }

        public bool InsertDepartment(string name)
        {
            string query = "USP_InsertDepartment @name";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { name });
            return result > 0;
        }

        public bool UpdateDepartment(string name, int departmentId)
        {
            string query = "USP_UpdateDepartment @name , @departmentId";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { name, departmentId });
            return result > 0;
        }

        public bool DeleteDepartment(int departmentId)
        {
            string query = "USP_DeleteDepartment @departmentId";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { departmentId });
            return result > 0;
        }
    }
}
