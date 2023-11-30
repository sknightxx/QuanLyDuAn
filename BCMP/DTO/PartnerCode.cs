using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.DTO
{
    public class PartnerCode
    {
        private string partnerCodeId;
        private string functionalPartner;
        public PartnerCode(string partnerCodeId, string functionalPartner)
        {
            PartnerCodeId = partnerCodeId;
            FunctionalPartner = functionalPartner;

        }

        public PartnerCode(DataRow row)
        {
            PartnerCodeId = row["PartnerCodeId"].ToString();
            FunctionalPartner = row["FunctionalPartner"].ToString();
        }

        public string PartnerCodeId { get => partnerCodeId; set => partnerCodeId = value; }
        public string FunctionalPartner { get => functionalPartner; set => functionalPartner = value; }
    }
}
