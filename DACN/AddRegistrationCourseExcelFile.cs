﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using Z.Dapper.Plus;

namespace DACN
{
    public partial class AddRegistrationCourseExcelFile : Form
    {
        DataTableCollection tableCollection;
        Connection connection = new Connection();
        public AddRegistrationCourseExcelFile()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
           
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
