using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCMP.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BCMP.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance 
        { 
            get { if (instance == null) instance = new EmployeeDAO();return instance; } 
            private set => instance = value; 
        }

        private EmployeeDAO() { }

        public Employee Login(string userid, string password)
        {
            string query = "USP_Login @userid , @password";

            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userid, password });
            Employee emp = null;
            foreach (DataRow row in result.Rows)
            {
                emp = new Employee(row);
            }
            return emp;
        }

        public Employee GetById(string userid)
        {
            Employee emp = null;
            string query = "USP_GetEmployeeById @userId";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userid });
            foreach(DataRow row in result.Rows)
            {
                emp = new Employee(row);
            }
            return emp;
        }

        public bool InsertEmployee(string email, string password,string phonenumber, string userid, int departmentid, int roleid)
        {
            String query = "USP_InsertEmployee @email , @password , @isDeactivated , @phoneNumber , @userId , @departmentId , @roleId ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { email, password, 0, phonenumber, userid, departmentid, roleid });
            bool res = result > 0;
            return result > 0;
        }
    }
}
