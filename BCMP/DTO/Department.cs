using System;
using System.Collections.Generic;
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

        public string Name { get => name; set => name = value; }
        public int DepartmentId { get => departmentId; set => departmentId = value; }
    }
}
