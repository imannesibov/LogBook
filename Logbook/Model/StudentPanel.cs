using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook.Model
{
    public partial class StudentPanel : UserControl
    {
        static class Rate
        {
            public const string crysone = "crysone";
            public const string crystwo = "crystwo";
            public const string crysthree = "crysthree";
        }
        public StudentPanel()
        {
            InitializeComponent();
        }

        public void AttendLesson(object sender, EventArgs e)
        {
            if (!inclass.Checked)
            {
                inclass.Checked = true;
            }
            else { inclass.Checked = false; }
        }

        public void SetFullname(string fullname)
        {
            studentfullname.Text = fullname;
        }

        public void SetRowNumber(string rowNumber)
        {
            rownumber.Text = rowNumber;
        }
        public void SetImage(Image ımage)
        {
            studentimg.Image = ımage;
        }

        //public void SetImage(Properties.Resources resource)
        //{
        //    studentimg.ImageLocation = DirectoryInfo(resource);
        //}
        private void StudentPanel_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString();
        }



        public event EventHandler<EventArgs> MarkAllAsCame;




        //public void MarkAllAsCame()
        //{
        //    if (!inclass.Enabled)
        //    {
        //        inclass.Enabled = true;
        //    }
        //    else
        //    {
        //        inclass.Enabled = false;

        //    }

        //}

        InfoPanel InfoPanel = new InfoPanel();

        private void crys_Click(object sender, EventArgs e)
        {
            var crystal = sender as PictureBox;

            switch (crystal.Name)
            {
                case Rate.crysone:
                    { 
                        crysone.Image = Properties.Resources.icons8_crystal_80__1_; 


                        break;
                    }
                case Rate.crystwo:
                    {
                        crysone.Image = Properties.Resources.icons8_crystal_80__1_;
                        crystal.Image = Properties.Resources.icons8_crystal_80__1_;
                        break;
                    }
                case Rate.crysthree:
                    {
                        crysone.Image = Properties.Resources.icons8_crystal_80__1_;
                        crystwo.Image = Properties.Resources.icons8_crystal_80__1_;
                        crystal.Image = Properties.Resources.icons8_crystal_80__1_;
                        break;
                    }

            }
        }

        private void classwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classwork.SelectedIndex > 0)
            {
                homework.Enabled = false;
            }
            else
            {
                homework.Enabled = true;

            }
        }
        private void homework_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (homework.SelectedIndex > 0)
            {
                classwork.Enabled = false;
            }
            else
            {
                classwork.Enabled = true;

            }
        }
        private void cancelcrys_Click(object sender, EventArgs e)
        {
            crysone.Image = Properties.Resources.icons8_crystal_80;
            crystwo.Image = Properties.Resources.icons8_crystal_80;
            crysthree.Image = Properties.Resources.icons8_crystal_80;
        }

        private void commentbtn_Click(object sender, EventArgs e)
        {
            if (commenttextbox.Visible != true)
            {
                commenttextbox.Visible = true;
            }
            else
            {
                commenttextbox.Visible = false;
            }

        }

        private void inclass_CheckedChanged(object sender, EventArgs e)
        {
            if (inclass.Checked || delayed.Checked)
            {
                homework.Enabled = true;
                classwork.Enabled = true;
            }

            if (notinclass.Checked)
            {
                homework.Enabled = false;
                classwork.Enabled = false;
            }
        }

        private void delayed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void studenticon_MouseLeave(object sender, EventArgs e)
        {
            studentimg.Visible = false;

        }

        private void studenticon_MouseEnter(object sender, EventArgs e)
        {
            studentimg.Visible = true;
        }


    }
}
