using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.DTO
{
    public class Role
    {
        private int roleId;
        private string title;
        private string description;

        public Role(int roleid, string title, string description)
        {
            this.RoleId = roleid;
            this.Title = title;
            this.Description = description;
        }

        public Role(DataRow row)
        {
            this.RoleId = (int) row["RoleId"];
            this.Title = row["title"].ToString();
            this.Description = row["description"].ToString();
        }

        public int RoleId { get => roleId; set => roleId = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
    }
}
