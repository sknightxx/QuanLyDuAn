﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCMP.Forms
{
    public partial class FormProject : Form
    {
        public FormProject()
        {
            InitializeComponent();
        }

        private void bt_CreateProject_Click(object sender, EventArgs e)
        {
            

            FormAddProject AddProjectForm = new FormAddProject();
            AddProjectForm.Show();
        }
    }
}
