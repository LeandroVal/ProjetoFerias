﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeFerramentas
{
    public partial class ContainerP : Form
    {
        public ContainerP()
        {
            InitializeComponent();
        }

        private void ContainerP_Load(object sender, EventArgs e)
        {

             //////////////// Propriedades do MDIContainer
            /////////////////////////////////////////////////////////////////////////////
            MdiClient ctlMDI = (MdiClient)this.Controls[this.Controls.Count - 1];    ///
            ctlMDI.BackColor = Color.WhiteSmoke;                                    ///
            ctlMDI.BackgroundImage = Properties.Resources.fundo4;                  ///
            /////////////////////////////////////////////////////////////////////////
        }

        private void ms_princ_fer_emp_Click(object sender, EventArgs e)
        {

        }
    }
}
