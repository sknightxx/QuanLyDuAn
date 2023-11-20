using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.DTO
{
    public class Mission
    {
        private int missionId;
        private string title;
        private string description;
        private float progress;
        private DateTime? plannedStartDate;
        private DateTime? plannedEndDate;
        private DateTime? actualStartDate;
        private DateTime? actualEndDate;
        private bool isPulic;
        private string status;
        private string projectId;
        private string userId;

        public Mission(int missionId, string title, string description, float progress, DateTime? plannedStartDate, DateTime? plannedEndDate, DateTime? actualStartDate, DateTime? actualEndDate, bool isPulic, string status, string projectId, string userId)
        {
            this.MissionId = missionId;
            this.Title = title;
            this.Description = description;
            this.Progress = progress;
            this.PlannedStartDate = plannedStartDate;
            this.PlannedEndDate = plannedEndDate;
            this.ActualStartDate = actualStartDate;
            this.ActualEndDate = actualEndDate;
            this.IsPulic = isPulic;
            this.Status = status;
            this.ProjectId = projectId;
            this.UserId = userId;
        }

        public Mission(DataRow row)
        {
            this.MissionId = (int)row["MissionId"];
            this.Title = row["Title"].ToString();
            this.Description = row["Description"].ToString();
            this.Progress = (float)row["Progress"];
            this.PlannedStartDate = (DateTime?)row["PlannedStartDate"];
            this.PlannedEndDate = (DateTime?)row["PlannedEndDate"];
            var actualStartDateTemp = row["ActualStartDate"];
            if (actualStartDateTemp.ToString() != "")
            {
                this.ActualStartDate = (DateTime?)row["ActualStartDate"];
            }
            else
            {
                this.ActualStartDate = null;
            }
            var actualEndDateTemp = row["ActualStartDate"];
            if (actualEndDateTemp.ToString() != "")
            {
                this.ActualEndDate = (DateTime?)row["ActualEndDate"];
            }
            else
            {
                this.ActualEndDate = null;
            }
            this.ProjectId = row["ProjectId"].ToString();
            this.UserId = row["UserId"].ToString();
        }

        public int MissionId { get => missionId; set => missionId = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public float Progress { get => progress; set => progress = value; }
        public DateTime? PlannedStartDate { get => plannedStartDate; set => plannedStartDate = value; }
        public DateTime? PlannedEndDate { get => plannedEndDate; set => plannedEndDate = value; }
        public DateTime? ActualStartDate { get => actualStartDate; set => actualStartDate = value; }
        public DateTime? ActualEndDate { get => actualEndDate; set => actualEndDate = value; }
        public bool IsPulic { get => isPulic; set => isPulic = value; }
        public string Status { get => status; set => status = value; }
        public string ProjectId { get => projectId; set => projectId = value; }
        public string UserId { get => userId; set => userId = value; }
    }
}
