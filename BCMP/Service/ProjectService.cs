using BCMP.DAO;
using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.Service
{
    public class ProjectService
    {
        private static ProjectService instance;
        private static List<Project> proList = ProjectDAO.Instance.GetAllProject();

        public static ProjectService Instance
        {
            get { if (instance == null) instance = new ProjectService(); return instance; }
            private set => instance = value;
        }

        private ProjectService() { }

        public bool InsertValidateProject(string projectId, string name, string description, DateTime plannedStartDate, DateTime plannedEndDate, int departmentId)
        {
            if (ProjectDAO.Instance.InsertProject(projectId, name, description, plannedStartDate, plannedEndDate,departmentId))
            {
                return true;
            }
            return false;
        }
    }
}
