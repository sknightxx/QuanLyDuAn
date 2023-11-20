using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCMP.DAO;
using BCMP.DTO;

namespace BCMP.Service
{
    public class MissionService
    {
        private static MissionService instance;
        public static List<Mission> missList;

        public static MissionService Instance
        {
            get { if (instance == null) instance = new MissionService(); return instance; }
            private set => instance = value;
        }

        private MissionService() { }

        public bool InsertValidateMission(string title, string description, DateTime plannedStartDate, DateTime plannedEndDate, int isPublic, string projectId, string userId)
        {
            if (MissionDAO.Instance.InsertMissions(title, description, plannedStartDate, plannedEndDate, isPublic, projectId, userId))
            {
                return true;
            }
            return false;
        }

        public bool UpdateMissionByManager(int missionId , string title, string description, DateTime plannedStartDate, DateTime plannedEndDate, int isPublic,string status, string projectId, string userId)
        {
            if (MissionDAO.Instance.UpdateMissionByMissionId(missionId, title, description, plannedStartDate, plannedEndDate, isPublic, status, projectId, userId))
            {
                return true;
            }
            return false;
        }

        public bool UpdateActualStartMissionBySystem(int missionId, DateTime actualStartDate)
        {
            if (MissionDAO.Instance.UpdateActualStartMission(missionId, actualStartDate))
            {
                return true;
            }
            return false;
        }

        public bool UpdateActualEndMissionBySystem(int missionId, DateTime actualEndDate)
        {
            if (MissionDAO.Instance.UpdateActualEndMission(missionId, actualEndDate))
            {
                return true;
            }
            return false;
        }

        public bool UpdateStatusMissionByUser(int missionId , string status)
        {
            if (MissionDAO.Instance.UpdateStatusMissionByMissionId(missionId,status)){
                return true;
            }
            return false;
        }

        public bool UpdateDescriptionMissionByUser(int missionId, string description)
        {
            if (MissionDAO.Instance.UpdateDescriptionMissionByMissionId(missionId, description))
            {
                return true;
            }
            return false;
        }

    }
}
