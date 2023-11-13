using BCMP.DAO;
using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.Service
{
    public class DepartmentService
    {
        private static DepartmentService instance;

        public static List<Department> departments;

        public static DepartmentService Instance
        {
            get { if (instance == null) instance = new DepartmentService(); return instance; }
            private set => instance = value;
        }

        private DepartmentService() { }

        public List<Department> GetAllListDepartment()
        {
            return departments = DepartmentDAO.Instance.GetAllDepartment();
        }

        public bool InsertDepartmentByManger(string name)
        {
            if (DepartmentDAO.Instance.InsertDepartment(name))
            {
                return true;
            }
            return false;
        }
        public bool UpdateDepartmentByManager(string name, int departmentId)
        {
            if (DepartmentDAO.Instance.UpdateDepartment(name, departmentId))
            {
                return true;
            }
            return false;
        }

        public bool DeleteDepartemntByManager(int departmentId)
        {
            if (DepartmentDAO.Instance.DeleteDepartment(departmentId))
            {
                return true;
            }
            return false;
        }



    }
}
