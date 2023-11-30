using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.DAO
{
    public class PartnerCodeDAO
    {
        private static PartnerCodeDAO instance;

        public static PartnerCodeDAO Instance
        {
            get { if (instance == null) instance = new PartnerCodeDAO(); return instance; }
            private set => instance = value;
        }

        public List<PartnerCode> GetAllPartnerCode()
        {
            List<PartnerCode> partners = new List<PartnerCode>();
            string query = "USP_GetPartnercode";
            DataTable resuslt = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow row in resuslt.Rows)
            {
                PartnerCode item = new PartnerCode(row);
                partners.Add(item);
            }
            return partners;
        }
    }
}
