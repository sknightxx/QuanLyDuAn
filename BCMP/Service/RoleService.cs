using BCMP.DAO;
using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.Service
{
    public class RoleService
    {
        private static RoleService instance;

        public static List<Role> roles;

        public static RoleService Instance
        {
            get { if (instance == null) instance = new RoleService(); return instance; }
            private set => instance = value;
        }

        private RoleService() { }

        public List<Role> GetAllListRole()
        {
            return roles = RoleDAO.Instance.GetAllRole();
        }
    }

}
