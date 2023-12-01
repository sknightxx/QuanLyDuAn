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
        private string type;
        private int departmentId;
        private string partnerCode;

        public Document(
            string name, string path,
            DateTime? releaseDate,
            string typeFile, string serialNumber,
            string status, int missionId,
            string userId, string projectId, string type, int departmentId,string partnerCode)
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
            this.Type = type;
            this.PartnerCode = partnerCode;
            this.DepartmentId = departmentId;
        }

        public Document(DataRow row)
        {

            this.Name = row["Name"].ToString();
            this.Path = row["Path"].ToString();
            this.ReleaseDate = (DateTime?)row["ReleaseDate"];
            this.TypeFile = row["TypeFile"].ToString();
            this.SerialNumber = row["SerialNumber"].ToString();
            this.Status = row["Status"].ToString();
            this.ProjectId = row["ProjectId"].ToString();
            var missint = row["MissionId"];
            if (!DBNull.Value.Equals(missint))
            {
                this.MissionId = (int)row["MissionId"];
            }
            else
            {
                this.MissionId = -1;
            }
            this.UserId = row["UserId"].ToString();
            this.PartnerCode = row["PartnerCodeId"].ToString();
            this.Type = row["Type"].ToString();
            var depint = row["DepartmentId"];
            if(!DBNull.Value.Equals(depint))
            {
                this.DepartmentId = (int)row["DepartmentId"];
            } else
            {
                this.DepartmentId = 0;
            }

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
        public string Type { get => type; set => type = value; }
        public int DepartmentId { get => departmentId; set => departmentId = value; }
        public string PartnerCode { get => partnerCode; set => partnerCode = value; }
    }
}
