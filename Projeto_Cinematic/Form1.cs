﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cinematic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingressoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro_ingresso cIngresso = new cadastro_ingresso();
            cIngresso.MdiParent = this;
            cIngresso.Show();
        }
    }
}
