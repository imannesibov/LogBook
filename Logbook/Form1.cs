using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logbook.Model;


namespace Logbook
{
    public partial class logbook : Form
    {
        Auditory auditory = new Auditory();
        public logbook()
        {
            InitializeComponent();
            foreach (var item in this.Controls)
            {
                var con = item as StudentPanel;
                if (con != null)
                {
                    ınfoPanel.AllRadioSelected += con.AttendLesson;
                }
            }
        } 
    
        private void logbook_Load(object sender, EventArgs e)
        { 
                Mahammad.SetFullname(auditory.students[0].Fullname);
                Alasgar.SetFullname(auditory.students[1].Fullname);
                Zabil.SetFullname(auditory.students[2].Fullname);
                Arif.SetFullname(auditory.students[3].Fullname);

            Mahammad.SetRowNumber(auditory.students[0].RowNumber);
            Alasgar.SetRowNumber(auditory.students[1].RowNumber);
            Zabil.SetRowNumber(auditory.students[2].RowNumber);
            Arif.SetRowNumber(auditory.students[3].RowNumber);


            Mahammad.SetImage(auditory.students[0].imageURL);
            Mahammad.SetImage(auditory.students[1].imageURL);
            Mahammad.SetImage(auditory.students[2].imageURL);
            Mahammad.SetImage(auditory.students[3].imageURL);


        }

        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void studentPanel1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void topicnametextbox_Click(object sender, EventArgs e)
        {
            topicnametextbox.Text = "";
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (mainteacher.Checked)
            {
                teachername.Text = auditory.teacher.Fullname;
            }
            if (otherteacher.Checked)
            {
                teachername.Text = "Müəllim əvəz olunur";
            }
        }
    }
}
