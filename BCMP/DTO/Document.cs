using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BCMP.DTO
{
    public class Document
    {
        private string name;
        private string path;
        private DateTime? releaseDate;
        private string typeFile;
        private string serialNumber;
        private string status;
        private int missionId;
        private string userId;
        private string projectId;

        public Document(
            string name, string path,
            DateTime? releaseDate,
            string typeFile, string serialNumber,
            string status, int missionId,
            string userId, string projectId)
        {
            this.Name = name;
            this.Path = path;
            this.ReleaseDate = releaseDate;
            this.TypeFile = typeFile;
            this.SerialNumber = serialNumber;
            this.MissionId = missionId;
            this.Status = status;
            this.ProjectId = projectId;
            this.UserId = userId;
        }

        public Document(DataRow row)
        {

            this.MissionId = (int)row["MissionId"];
            this.Status = row["Status"].ToString();
            this.ProjectId = row["ProjectId"].ToString();
            this.UserId = row["UserId"].ToString();
        }

        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }
        public DateTime? ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string TypeFile { get => typeFile; set => typeFile = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Status { get => status; set => status = value; }
        public int MissionId { get => missionId; set => missionId = value; }
        public string ProjectId { get => projectId; set => projectId = value; }
        public string UserId { get => userId; set => userId = value; }
    }
}
