﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompGraph.View;
using static System.Net.Mime.MediaTypeNames;

namespace CompGraph.View
{
    public partial class ChooseLaboratory : Form
    {
        LabFirstForm workWithMatrix = null;
        LabSecondForm grafics = null;
        LabThirdForm pictures = null;
        LabFourthForm labfourth = null;
        public ChooseLaboratory()
        {
            InitializeComponent();
        }
        

        private void LabFirstButton_Click(object sender, EventArgs e)
        {
            workWithMatrix = new LabFirstForm();
            if (workWithMatrix.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void LabSeconfButton_Click(object sender, EventArgs e)
        {
            grafics = new LabSecondForm();
            if (grafics.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void LabThirdButton_Click(object sender, EventArgs e)
        {
            pictures = new LabThirdForm();
            if (pictures.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void LabQuarterButton_Click(object sender, EventArgs e)
        {
            labfourth = new LabFourthForm();
            if (labfourth.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
