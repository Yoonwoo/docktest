using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WeifenLuo.WinFormsUI.ThemeVS2015;

namespace docktest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            var theme = new VS2015BlueTheme();
            dockPanel1.Theme = theme;
            this.TopLevel = true;
            //Form2 f2 = new Form2();
            //f2.Show(dockPanel1, DockState.DockLeft);
            //Form3 f3 = new Form3();
            //f3.Show(dockPanel1, DockState.DockRight);
            Form4 f4 = new Form4();
            f4.Show(dockPanel1, DockState.Document);
          //  this.Show(dockPanel1, DockState.Document);
        }
    }
}
