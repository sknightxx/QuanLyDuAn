using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace BCMP.DTO
{
    public class Notification
    {
        private int notificationId;
        private string description;
        private string title;
        private DateTime? createDate;
        private bool isRead;
        private int missionId;
        private string userId;

        public Notification(int notificationId, string description, string title, DateTime? createDate, bool isRead, int missionId, string userId)
        {
            this.NotificationId = notificationId;
            this.Description = description;
            this.Title = title;
            this.CreateDate = createDate;
            this.IsRead = isRead;
            this.MissionId = missionId;
            this.UserId = userId;
        }

        public Notification(DataRow row)
        {
            this.NotificationId = (int)row["NotificationId"];
            this.Description = row["Description"].ToString();
            this.Title = row["Title"].ToString();
            this.CreateDate = (DateTime?)row["CreatedDate"];
            if ((int)row["IsRead"] == 0)
            {
                this.IsRead = false;
            } else
            {
                this.IsRead = true;
            }
        
            this.MissionId = (int)row["MissionId"];
            this.UserId = row["UserId"].ToString();
        }

        public int NotificationId { get => notificationId; set => notificationId = value; }
        public string Description { get => description; set => description = value; }
        public string Title { get => title; set => title = value; }
        public DateTime? CreateDate { get => createDate; set => createDate = value; }
        public bool IsRead { get => isRead; set => isRead = value; }
        public int MissionId { get => missionId; set => missionId = value; }
        public string UserId { get => userId; set => userId = value; }
    }
}
