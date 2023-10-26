using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.DTO
{
    public class Project
    {
        private string projectId;
        private string name;
        private string description;
        private DateTime? plannedStartDate;
        private DateTime? plannedEndDate;
        private DateTime? actualStartDate;
        private DateTime? actualEndDate;
        private int departmentId;

        public Project(string projectId, string name, string description, DateTime? plannedStartDate, DateTime? plannedEndDate, DateTime? actualStartDate, DateTime? actualEndDate, int departmentId)
        {
            this.ProjectId = projectId;
            this.Name = name;
            this.Description = description;
            this.PlannedStartDate = plannedStartDate;
            this.PlannedEndDate = plannedEndDate;
            this.ActualStartDate = actualStartDate;
            this.ActualEndDate = actualEndDate;
            this.DepartmentId = departmentId;
        }

        public Project(DataRow row)
        {
            this.ProjectId = row["ProjectId"].ToString(); ;
            this.Name = row["Name"].ToString();
            this.Description = row["Desciption"].ToString();
            this.PlannedStartDate = (DateTime?)row["PlannedStartDate"];
            this.PlannedEndDate = (DateTime?)row["PlannedEndDate"];
            var actualStartDateTemp = row["ActualStartDate"];
            if(actualStartDateTemp.ToString() != "")
            {
                this.ActualStartDate = (DateTime?)row["ActualStartDate"];
            } else
            {
                this.ActualStartDate = null;
            }
            var actualEndDateTemp = row["ActualStartDate"];
            if (actualEndDateTemp.ToString() != "")
            {
                this.ActualEndDate = (DateTime?)row["ActualEndDate"];
            } else
            {
                this.ActualEndDate = null;
            }
            this.DepartmentId = (int)row["DepartmentId"];
        }

        public string ProjectId { get => projectId; set => projectId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public DateTime? PlannedStartDate { get => plannedStartDate; set => plannedStartDate = value; }
        public DateTime? PlannedEndDate { get => plannedEndDate; set => plannedEndDate = value; }
        public DateTime? ActualStartDate { get => actualStartDate; set => actualStartDate = value; }
        public DateTime? ActualEndDate { get => actualEndDate; set => actualEndDate = value; }
        public int DepartmentId { get => departmentId; set => departmentId = value; }
    }
}
