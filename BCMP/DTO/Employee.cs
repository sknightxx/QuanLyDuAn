using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace BCMP.DTO
{
    public class Employee
    {
        private string userId;
        private string password;
        private string email;
        private string phoneNumber;
        private int departmentId;
        private int roleId;
        private bool isDeactivated;
        private string fullName;
        private bool typeEmployee;
        public Employee(String userid, String password, string email, 
            string phonenumber, int departmentid, int roleid, bool isdeactivated, string fullname)
        {
            this.UserId = userid;
            this.Password = password;
            this.Email = email;
            this.PhoneNumber = phonenumber;
            this.DepartmentId = departmentid;
            this.RoleId = roleid;
            this.isDeactivated = isdeactivated;
            this.FullName = fullname;
            this.TypeEmployee = true;
        }

        public Employee(DataRow row)
        {
            this.UserId = row["UserId"].ToString();
            this.Password = row["Password"].ToString();
            this.Email = row["Email"].ToString();
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.DepartmentId = (int)row["DepartmentId"];
            this.RoleId = (int)row["RoleId"];
            if ((int)row["IsDeactivated"] == 0)
            {
                this.isDeactivated = false;
            } else
            {
                this.isDeactivated = true;
            }
           
            
            this.FullName = row["fullname"].ToString();
            
            if ((int)row["TypeEmployee"] == 1)
            {
                this.TypeEmployee = true;
            }
            else
            {
                this.TypeEmployee = false;
            }
        }

        public string UserId { get => userId; set => userId = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int DepartmentId { get => departmentId; set => departmentId = value; }
        public int RoleId { get => roleId; set => roleId = value; }
        public bool IsDeactivated { get => isDeactivated; set => isDeactivated = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public bool TypeEmployee { get => typeEmployee; set => typeEmployee = value; }
    }


}
