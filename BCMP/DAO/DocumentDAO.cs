using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.DAO
{
    public class DocumentDAO
    {
        private static DocumentDAO instance;

        public static DocumentDAO Instance
        {
            get { if (instance == null) instance = new DocumentDAO(); return instance; }
            private set => instance = value;
        }

        private DocumentDAO() { }

        public bool InsertDocument(string name, string path, DateTime releaseDatem, string typeFile, string serialNumber, string status, string projectId,int missionId, string userId, string partnerCodeId, string type, int departmentId)
        {
            if(missionId == -1)
            {
                string query = "USP_InsertDocumentInProject @name , @path , @releaseDate , @typeFile , @serialNumber , @status , @projectId , @userId , @partnerCodeId , @type , @departmentId";
                int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { name, path, releaseDatem, typeFile, serialNumber, status, projectId, userId, partnerCodeId, type, departmentId });
                return result > 0;
            } else
            {
                string query = "USP_InsertDocument @name , @path , @releaseDate , @typeFile , @serialNumber , @status , @projectId , @missionId , @userId , @partnerCodeId , @type , @departmentId";
                int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { name, path, releaseDatem, typeFile, serialNumber, status, projectId, missionId, userId, partnerCodeId, type, departmentId });
                return result > 0;
            }
        }

        public List<Document> GetAllDocumentInPublic()
        {
            List<Document> list = new List<Document>();
            string query = "USP_GetAllDocumentInPublic";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            int a = result.Rows.Count;
            foreach(DataRow row in result.Rows)
            {
                Document item = new Document(row);
                string b = item.Name;
                list.Add(item);
            }
            return list;
        }

        public List<Document> GetAllDocumentInProject(string projectId)
        {
            List<Document> list = new List<Document>();
            string query = "USP_GetAllDocumentInProject @projectId";
            DataTable result = DataProvider.Instance.ExcuteQuery(query,new object[] {projectId});
            int a = result.Rows.Count;
            foreach (DataRow row in result.Rows)
            {
                Document item = new Document(row);
                string b = item.Name;
                list.Add(item);
            }
            return list;
        }

        public List<Document> GetAllDocumentInMission(int missionId)
        {
            List<Document> list = new List<Document>();
            string query = "USP_GetAllDocumentInMission @missionId";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { missionId });
            int a = result.Rows.Count;
            foreach (DataRow row in result.Rows)
            {
                Document item = new Document(row);
                string b = item.Name;
                list.Add(item);
            }
            return list;
        }

        public List<Document> GetAllDocumentInDepartment(int departmentId)
        {
            List<Document> list = new List<Document>();
            string query = "USP_GetAllDocumentInDepartment @departmentId";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { departmentId });
            int a = result.Rows.Count;
            foreach (DataRow row in result.Rows)
            {
                Document item = new Document(row);
                string b = item.Name;
                list.Add(item);
            }
            return list;
        }

        public List<Document> GetAllDocumentInPublicUser(string userId)
        {
            List<Document> list = new List<Document>();
            string query = "USP_GetAllDocumentInPublicUser @userId";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userId });
            int a = result.Rows.Count;
            foreach (DataRow row in result.Rows)
            {
                Document item = new Document(row);
                string b = item.Name;
                list.Add(item);
            }
            return list;
        }

        public bool DeletDocumentByCEO(string serial)
        {
            string query = "USP_DeleteDocumentBySerial @serialNumber";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { serial });
            return result > 0;
        }






    }
}
