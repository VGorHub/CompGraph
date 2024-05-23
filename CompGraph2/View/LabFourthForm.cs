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
        //grisha41 grisha41;
        public LabFourthForm()
        {
            InitializeComponent();
            //grisha41 = new grisha41();
            //tabPage2.Controls.Add(grisha41);

            Lab4_Vova Lab4 = new Lab4_Vova();
            Lab4.Dock = DockStyle.Fill;
            tabControl_LabFourth.TabPages[2].Controls.Add(Lab4);

        }
    }
}
