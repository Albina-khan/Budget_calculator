﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void showAllMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            members members = new members();
            members.MdiParent = this;
            members.Show();
        }


        private void history_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.MdiParent = this;
            history.Show();
        }
    }
}
