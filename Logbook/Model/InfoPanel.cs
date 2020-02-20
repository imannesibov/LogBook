using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Logbook.Model
{
    public partial class InfoPanel : UserControl
    {
        public event EventHandler AllRadioSelected;
        public InfoPanel()
        {
            InitializeComponent();

          
        }

        public void SetCrystalCount(string count)
        {
            crystalcount.Text = count;
        }
        private void InfoPanel_Load(object sender, EventArgs e)
        {

        }

        private void allstudentscame_CheckedChanged(object sender, EventArgs e)
        {
            AllRadioSelected(sender, e);
        }
    }
}
