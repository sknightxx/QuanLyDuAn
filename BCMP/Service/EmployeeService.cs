using BCMP.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BCMP.Service
{
    public class EmployeeService
    {
        private static EmployeeService instance;

        public static EmployeeService Instance
        {
            get { if (instance == null) instance = new EmployeeService(); return instance; }
            private set => instance = value;
        }

        private EmployeeService() { }

        public bool InsertEmployeeVaildate(string email, string password,string phonenumber, string userid, int departmentid, int roleid)
        {
            if(EmployeeDAO.Instance.InsertEmployee(email, password, phonenumber, userid, departmentid, roleid))
            {
                return true;
            }
            return false;
        }

        public bool EmailValidate(string email)
        {
           if(email == null) return false;
           if(new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            return false;
        }

        public bool UpdateEmployeeByManager(string email, string password, string phonenumber, string userid, int departmentid, int roleid, bool isDeativated)
        {
            if (EmployeeDAO.Instance.UpdateEmployeeByUserId(email, password, phonenumber, userid, departmentid, roleid, isDeativated))
            {
                return true;
            }
            return false;
        }

        public bool DeleteEmployeeByManager(string userId)
        {
            if (EmployeeDAO.Instance.DeleteEmployeeByUserId(userId))
            {
                return true;
            }
            return false;
        }

        public bool UpdateIsDeactivatedEmployeeByManager(string userid, bool isDeativated)
        {
            if (EmployeeDAO.Instance.UpdateIsDeactivatedEmployee(userid, isDeativated))
            {
                return true;
            }
            return false;
        }

        public bool UpdateChangePassword(string userid,string newpassword)
        {
            if (EmployeeDAO.Instance.UpdatePasswordEmployee(userid, newpassword))
            {
                return true;
            }
            return false;
        }
    }
}
