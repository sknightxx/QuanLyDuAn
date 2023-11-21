using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMP.EventsHandler
{
    public class UpdateProjectEventArgs : EventArgs
    {
        public Project UpdatedProject { get; }

        public UpdateProjectEventArgs(Project updatedProject)
        {
            UpdatedProject = updatedProject;
        }
    }
}
