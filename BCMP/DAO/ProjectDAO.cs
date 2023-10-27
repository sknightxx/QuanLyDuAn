using System;
using System.Collections.Generic;
using System.Linq;
using BCMP.DTO;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BCMP.DAO
{
    public class ProjectDAO
    {
        private static ProjectDAO instance;

        public static ProjectDAO Instance
        {
            get { if (instance == null) instance = new ProjectDAO(); return instance; }
            private set => instance = value;
        }

        private ProjectDAO() { }

        public bool InsertProject(string projectId, string name, string description, DateTime plannedStartDate, DateTime plannedEndDate, int departmentId)
        {
            string query = "USP_InsertProject @projectid , @name , @description , @plannedStartDate , @plannedEndDate , @departmentId";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {projectId,name,description,plannedStartDate,plannedEndDate,departmentId});
            return result > 0;
        }

        public List<Project> GetAllProject()
        {
            string query = "USP_GetProject";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            List<Project> list = new List<Project>();
            foreach(DataRow row in data.Rows)
            {
                list.Add(new Project(row));
            }
            return list;
        }

        public Project GetProjectById(string projectId)
        {
            string query = "USP_GetProjectById @projectId";
            Project pro = null;
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { projectId });
            foreach(DataRow row in data.Rows)
            {
                pro = new Project(row);
            }
            return pro;
        }

        public bool DeleteProjectByProjectId(string projectId)
        {
            string query = "USP_DeleteProject @projectId";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { projectId });
            return result > 0;
        }

        public bool UpdateProjectByProjectId(string projectId, string name, string description, DateTime plannedStartDate, DateTime plannedEndDate, int departmentId)
        {
            string query = "USP_UpdateProject @projectId , @name , @description , @plannedStartDate , @plannedEndDate";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { projectId, name, description, plannedStartDate, plannedEndDate, departmentId });
            return result > 0;
        }

        public bool UpdateActualStartProject(string projectId , DateTime actualStartDate)
        {
            String query = "USP_UpdateActualStartProject @projectId , @actualStartDate";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { projectId, actualStartDate });
            return result > 0;
        }

        public bool UpdateActualEndProject(string projectId, DateTime actualEndDate)
        {
            String query = "USP_UpdateActualEndProject @projectId , @actualEndDate";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { projectId, actualEndDate });
            return result > 0;
        }
    }
}
