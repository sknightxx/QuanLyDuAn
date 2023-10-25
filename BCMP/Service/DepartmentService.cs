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

        


    }
}
