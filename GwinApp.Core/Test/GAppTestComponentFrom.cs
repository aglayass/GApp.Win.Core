﻿#define TEST1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;

namespace GApp.Win.Test
{



    public partial class GAppTestComponentForm : Form
    {


        public bool TestMode = false;


        public GAppTestComponentForm()
        {
            InitializeComponent();
        }

        public void StopToViewDemo(string TestName)
        {
            if (!TestMode)
                MessageBox.Show(TestName, "StopToViewDemo");

        }
    }
}
