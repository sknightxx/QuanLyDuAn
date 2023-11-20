using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BCMP.DAO
{
    public class MissionDAO
    {
        private static MissionDAO instance;

        public static MissionDAO Instance
        {
            get { if (instance == null) instance = new MissionDAO(); return instance; }
            private set => instance = value;
        }

        private MissionDAO() { }

        public bool InsertMissions(string title, string description, DateTime plannedStartDate, DateTime plannedEndDate, int isPublic, string projectId, string userId)
        {
            string query = "USP_InsertMission @title , @description , @progress , @plannedStartDate , @plannedEndDate , @isPublic , @status , @projectId , @userId";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { title, description, 0.0, plannedStartDate, plannedEndDate, isPublic, "TO DO", projectId, userId });
            return result > 0;
        }

        public List<Mission> GetAllMissionsByProjectId(string projectId)
        {
            List<Mission> list = new List<Mission>();
            string query = "USP_GetMissionByProjectId @projectId";
            DataTable result = DataProvider.Instance.ExcuteQuery(query,new object[] {projectId});
            foreach (DataRow row in result.Rows)
            {
                list.Add(new Mission(row));
            }
            return list;
        }

        public bool DeletMissionByMissionId(string missionId)
        {
            string query = "USP_DeletMission @missionId";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { missionId });
            return result > 0;
        }

        public bool UpdateMissionByMissionId(int missionId,string title, string description, DateTime plannedStartDate, DateTime plannedEndDate, int isPublic,string status, string projectId, string userId)
        {
            string query = "USP_UpdateMission @missionId ,  @title = , @description = ,@progress = , @plannedStartDate = , @plannedEndDate , @isPublic , @status , @projectId , @userId";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {missionId, title, description, 0.0, plannedStartDate, plannedEndDate, isPublic, status, projectId, userId });
            return result > 0;
        }

        public bool UpdateActualStartMission(int missionId, DateTime actualStartDate)
        {
            string query = "USP_UpdateActualStartMission @missionId , @actualStartDate";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { missionId, actualStartDate });
            return result > 0;
        }

        public bool UpdateActualEndMission(int missionId, DateTime actualEndDate)
        {
            string query = "USP_UpdateActualEndMission @missionId , @actualStartDate";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { missionId, actualEndDate });
            return result > 0;
        }

        public bool UpdateStatusMissionByMissionId(int missionId, string status)
        {
            string query = "USP_UpdateStatusMissionByMissionId @missionId , @status";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { missionId, status });
            return result > 0;
        }

        public bool UpdateDescriptionMissionByMissionId(int missionId, string description)
        {
            string query = "USP_UpdateStatusMissionByMissionId @missionId , @description";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { missionId, description });
            return result > 0;
        }
    }
}
