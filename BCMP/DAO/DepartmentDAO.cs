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
    }
}
