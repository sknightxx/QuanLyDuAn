using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.DTO
{
    public class Department
    {
        private string name;
        private int departmentId;

        public Department(string name, int departmentId)
        {
            this.DepartmentId = departmentId;
            this.Name = name;
        }

        public Department(DataRow row)
        {
            this.DepartmentId = (int)row["DepartmentId"];
            this.Name = row["Name"].ToString();
        }

        public string Name { get => name; set => name = value; }
        public int DepartmentId { get => departmentId; set => departmentId = value; }
    }
}
