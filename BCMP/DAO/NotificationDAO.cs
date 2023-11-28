using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace BCMP.DAO
{
    public class NotificationDAO
    {
        private static NotificationDAO instance;

        public static NotificationDAO Instance
        {
            get { if (instance == null) instance = new NotificationDAO(); return instance; }
            private set => instance = value;
        }


        private NotificationDAO() { }

        public List<Notification> GetNotificationByUserId(string userid)
        {
            List<Notification> list = new List<Notification>();
            string query = "USP_GetNotificationByUserId @userId";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userid });
            foreach (DataRow row in result.Rows)
            {
                list.Add(new Notification(row));
            }
            return list;
        }

        public bool InsertNotification(string description, string title, DateTime createdate, int missionId, int userId)
        {
            String query = "USP_InsertNotification @description , @title , @createDate , @isRead , @missionId , userId";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { description, title, createdate, 0, missionId, userId });
            return result > 0;
        }
    }
}
