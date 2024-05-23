using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompGraph.View
{
    public partial class LabFourthForm : Form
    {
        public LabFourthForm()
        {
            InitializeComponent();
        }

        private void LabFourthForm_Load(object sender, EventArgs e)
        {
            Lab4_Vova lab4 = new Lab4_Vova();
            lab4.Dock = DockStyle.Fill;
            tabControl_LabFourth.TabPages[2].Controls.Add(lab4);
        }
    }
}
