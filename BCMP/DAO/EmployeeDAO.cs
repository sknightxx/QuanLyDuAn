using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using BCMP.DTO;
using Firebase.Auth;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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

        public List<Employee> GetAllEmployee()
        {
            string query = "USP_GetEmployee";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            List<Employee> list = new List<Employee>();
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Employee(row));
            }
            return list;
        }

        public List<Employee> GetAllEmployeeBySearch(string fullname)
        {
            string query = "USP_SearchEmployee @fullname";
            DataTable data = DataProvider.Instance.ExcuteQuery(query,new object[] {fullname});
            List<Employee> list = new List<Employee>();
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Employee(row));
            }
            return list;
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

        public bool InsertEmployee(string email, string password,string phonenumber, string userid, int departmentid, int roleid, string fullname , bool typeEmployee)
        {
            int type = 0;
            if (typeEmployee)
            {
                type = 1;
            }
            String query = "USP_InsertEmployee @email , @password , @isDeactivated , @phoneNumber , @userId , @departmentId , @roleId , @fullname , @typeEmployee ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { email, password, 0, phonenumber, userid, departmentid, roleid , fullname , type });
            bool res = result > 0;
            return result > 0;
        }

        public bool DeleteEmployeeByUserId(string userId)
        {
            String query = "USP_DeleteEmployee @userId";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { userId });
            return result > 0;
        }

        public bool UpdateEmployeeByUserId(string email, string password, string phonenumber, string userid, int departmentid, int roleid, bool isDeativated, string fullname , bool typeEmployee)
        {
            int deactivated = 0;
            if (isDeativated == false)
            {
                deactivated = 0;
            }
            else
            {
                deactivated = 1;
            }
            int type = 0;
            if (typeEmployee)
            {
                type = 1;
            }
            String query = "USP_UpdateEmployee @email , @password , @isDeactivated , @phoneNumber , @userId , @departmentId , @roleId , @fullname , @typeEmployee";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { email, password, deactivated, phonenumber, userid, departmentid, roleid , fullname , type });
            return result > 0;
        }
        
        public bool UpdateIsDeactivatedEmployee(string userId, bool isDeactivated)
        {
            int deactivated = 0;
            if (isDeactivated == false)
            {
                deactivated = 1;
            }
            else
            {
                deactivated = 0;
            }
            String query = "USP_UpdateIsDeactivatedEmployee @userId , @isDeactivated ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { userId,deactivated});
            return result > 0;
        }

        public bool UpdatePasswordEmployee(string userId, string newpassword)
        {
            String query = "USP_UpdatePasswordEmployee @userId , @newpassword ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { userId, newpassword });
            return result > 0;
        }
    }
}
