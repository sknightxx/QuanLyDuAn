using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.DAO
{
    public class TypeOfDocumentDAO
    {
        private static TypeOfDocumentDAO instance;

        public static TypeOfDocumentDAO Instance
        {
            get { if (instance == null) instance = new TypeOfDocumentDAO(); return instance; }
            private set => instance = value;
        }

        public List<TypeOfDocument> GetAllTypeOfDocument()
        {
            List<TypeOfDocument> type = new List<TypeOfDocument>();
            string query = "USP_GetTypeOfDocument";
            DataTable resuslt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in resuslt.Rows)
            {
                TypeOfDocument item = new TypeOfDocument(row);
                type.Add(item);
            }
            return type;
        }
    }
}
