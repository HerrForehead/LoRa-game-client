﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_voor_challenge
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!gameDestroyer.Checked)
            {
                Application.Exit();
            }
        }
    }
}
