﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerGridEditor.Forms
{
    public partial class EditAllLocksForm : Form
    {
        MainForm mainForm;
        public EditAllLocksForm(MainForm mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();
        }

        private void lockIslndsBtn_Click(object sender, EventArgs e)
        {
            foreach (Server server in mainForm.currentProject.servers)
                server.islandLocked = true;

            mainForm.InvalidateMapPanel();
        }

        private void unlockIslndsBtn_Click(object sender, EventArgs e)
        {
            foreach (Server server in mainForm.currentProject.servers)
                server.islandLocked = false;

            mainForm.InvalidateMapPanel();
        }

        private void lockDiscoBtn_Click(object sender, EventArgs e)
        {
            foreach (Server server in mainForm.currentProject.servers)
                server.discoLocked = true;

            mainForm.InvalidateMapPanel();
        }

        private void unlockDiscoBtn_Click(object sender, EventArgs e)
        {
            foreach (Server server in mainForm.currentProject.servers)
                server.discoLocked = false;

            mainForm.InvalidateMapPanel();
        }

        private void lockPaths_Click(object sender, EventArgs e)
        {
            foreach (Server server in mainForm.currentProject.servers)
                server.pathsLocked = true;

            mainForm.InvalidateMapPanel();
        }

        private void unlockPaths_Click(object sender, EventArgs e)
        {
            foreach (Server server in mainForm.currentProject.servers)
                server.pathsLocked = false;

            mainForm.InvalidateMapPanel();
        }

        private void lockWinds_Click(object sender, EventArgs e)
        {
            foreach (Server server in mainForm.currentProject.servers)
                server.windsLocked = true;

            mainForm.InvalidateMapPanel();
        }

        private void unlockWinds_Click(object sender, EventArgs e)
        {
            foreach (Server server in mainForm.currentProject.servers)
                server.windsLocked = false;

            mainForm.InvalidateMapPanel();
        }
    }
}
