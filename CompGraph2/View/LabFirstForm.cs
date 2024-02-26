using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompGraph.View;



namespace CompGraph
{
    public partial class LabFirstForm : Form
    {

        private void LabFirstForm_Load(object sender, EventArgs e)
        {
            MatrixOperations tab1 = new MatrixOperations();            
            tab1.Dock = DockStyle.Fill;            
            TabControl.TabPages[0].Controls.Add(tab1);
            VectorModule tab2 = new VectorModule();
            tab2.Dock = DockStyle.Fill;
            TabControl.TabPages[1].Controls.Add(tab2);
        }

        public LabFirstForm()
        {
            InitializeComponent();
        }


    }

}
