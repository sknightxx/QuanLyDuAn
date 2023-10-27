using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCMP.DAO;
using BCMP.DTO;

namespace BCMP.Service
{
    public class AuthService
    {
        private static AuthService instance;
        public static Employee empCur;
        public static Role roleCur;

        public static AuthService Instance { 
            get { if (instance == null) instance = new AuthService();return instance; } 
            private set => instance = value; 
        }

        private AuthService() { }

        public bool LoginValidateEmployee(string userid, string password)
        {
            empCur = EmployeeDAO.Instance.Login(userid,password);
            if(Equals(empCur, null))
            {
                return false;
            }
            roleCur = RoleDAO.Instance.GetById(empCur.RoleId);
            return true;
        }

        public bool ValidateIsDeactivated()
        {
            if(empCur == null)
            {
                return false;
            } else if(empCur.IsDeactivated == true)
            {
                return true;
            } else { return false; }
        }

        public bool EmployeeIsExist(string userid)
        {
            Employee emp = EmployeeDAO.Instance.GetById(userid);
            if(emp == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public bool ProjectIsExist(string projectId)
        {
            Project emp = ProjectDAO.Instance.GetProjectById(projectId);
            if (emp == null)
            {
                return false;
            }
            return true;
        }
    }
}
