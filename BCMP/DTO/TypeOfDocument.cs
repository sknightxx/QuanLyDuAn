using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.DTO
{
    public class TypeOfDocument
    {
        private string type;
        private string description;

        public TypeOfDocument(string type, string description)
        {
            Type = type;
            Description = description;
        }

        public TypeOfDocument(DataRow row)
        {
            Type = row["Type"].ToString();
            Description = row["Description"].ToString();
        }

        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
    }
}
