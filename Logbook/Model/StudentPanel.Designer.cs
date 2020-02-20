namespace Logbook.Model
{
    partial class StudentPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentfullname = new System.Windows.Forms.Label();
            this.rownumber = new System.Windows.Forms.Label();
            this.homework = new System.Windows.Forms.ComboBox();
            this.classwork = new System.Windows.Forms.ComboBox();
            this.crysthree = new System.Windows.Forms.PictureBox();
            this.crystwo = new System.Windows.Forms.PictureBox();
            this.crysone = new System.Windows.Forms.PictureBox();
            this.studenticon = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.Label();
            this.inclass = new MaterialSkin.Controls.MaterialRadioButton();
            this.delayed = new MaterialSkin.Controls.MaterialRadioButton();
            this.notinclass = new MaterialSkin.Controls.MaterialRadioButton();
            this.cancelcrys = new MaterialSkin.Controls.MaterialFlatButton();
            this.commentbtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.commenttextbox = new System.Windows.Forms.TextBox();
            this.studentimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crysthree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crysone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentimg)).BeginInit();
            this.SuspendLayout();
            // 
            // studentfullname
            // 
            this.studentfullname.AutoSize = true;
            this.studentfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentfullname.Location = new System.Drawing.Point(103, 26);
            this.studentfullname.Name = "studentfullname";
            this.studentfullname.Size = new System.Drawing.Size(147, 20);
            this.studentfullname.TabIndex = 5;
            this.studentfullname.Text = "Stuent Name name";
            // 
            // rownumber
            // 
            this.rownumber.AutoSize = true;
            this.rownumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rownumber.Location = new System.Drawing.Point(3, 26);
            this.rownumber.Name = "rownumber";
            this.rownumber.Size = new System.Drawing.Size(18, 20);
            this.rownumber.TabIndex = 3;
            this.rownumber.Text = "1";
            // 
            // homework
            // 
            this.homework.Enabled = false;
            this.homework.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homework.FormattingEnabled = true;
            this.homework.ItemHeight = 13;
            this.homework.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.homework.Location = new System.Drawing.Point(609, 20);
            this.homework.MaxDropDownItems = 12;
            this.homework.Name = "homework";
            this.homework.Size = new System.Drawing.Size(58, 21);
            this.homework.TabIndex = 9;
            this.homework.SelectedIndexChanged += new System.EventHandler(this.homework_SelectedIndexChanged);
            // 
            // classwork
            // 
            this.classwork.Enabled = false;
            this.classwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classwork.FormattingEnabled = true;
            this.classwork.ItemHeight = 13;
            this.classwork.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.classwork.Location = new System.Drawing.Point(688, 20);
            this.classwork.MaxDropDownItems = 12;
            this.classwork.Name = "classwork";
            this.classwork.Size = new System.Drawing.Size(58, 21);
            this.classwork.TabIndex = 10;
            this.classwork.SelectedIndexChanged += new System.EventHandler(this.classwork_SelectedIndexChanged);
            // 
            // crysthree
            // 
            this.crysthree.Image = global::Logbook.Properties.Resources.icons8_crystal_80;
            this.crysthree.Location = new System.Drawing.Point(858, 20);
            this.crysthree.Name = "crysthree";
            this.crysthree.Size = new System.Drawing.Size(22, 21);
            this.crysthree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crysthree.TabIndex = 17;
            this.crysthree.TabStop = false;
            this.crysthree.Tag = "0";
            this.crysthree.Click += new System.EventHandler(this.crys_Click);
            // 
            // crystwo
            // 
            this.crystwo.Image = global::Logbook.Properties.Resources.icons8_crystal_80;
            this.crystwo.Location = new System.Drawing.Point(828, 20);
            this.crystwo.Name = "crystwo";
            this.crystwo.Size = new System.Drawing.Size(22, 21);
            this.crystwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crystwo.TabIndex = 16;
            this.crystwo.TabStop = false;
            this.crystwo.Tag = "0";
            this.crystwo.Click += new System.EventHandler(this.crys_Click);
            // 
            // crysone
            // 
            this.crysone.Image = global::Logbook.Properties.Resources.icons8_crystal_80;
            this.crysone.Location = new System.Drawing.Point(796, 20);
            this.crysone.Name = "crysone";
            this.crysone.Size = new System.Drawing.Size(22, 21);
            this.crysone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crysone.TabIndex = 11;
            this.crysone.TabStop = false;
            this.crysone.Tag = "0";
            this.crysone.Click += new System.EventHandler(this.crys_Click);
            // 
            // studenticon
            // 
            this.studenticon.Image = global::Logbook.Properties.Resources.icons8_student_male_100__1_;
            this.studenticon.Location = new System.Drawing.Point(32, 12);
            this.studenticon.Name = "studenticon";
            this.studenticon.Size = new System.Drawing.Size(55, 42);
            this.studenticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studenticon.TabIndex = 4;
            this.studenticon.TabStop = false;
            this.studenticon.MouseEnter += new System.EventHandler(this.studenticon_MouseEnter);
            this.studenticon.MouseLeave += new System.EventHandler(this.studenticon_MouseLeave);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(303, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(89, 20);
            this.date.TabIndex = 18;
            this.date.Text = "19.02.2020";
            // 
            // inclass
            // 
            this.inclass.AutoSize = true;
            this.inclass.Depth = 0;
            this.inclass.Font = new System.Drawing.Font("Roboto", 10F);
            this.inclass.Location = new System.Drawing.Point(441, 19);
            this.inclass.Margin = new System.Windows.Forms.Padding(0);
            this.inclass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.inclass.MouseState = MaterialSkin.MouseState.HOVER;
            this.inclass.Name = "inclass";
            this.inclass.Ripple = true;
            this.inclass.Size = new System.Drawing.Size(25, 30);
            this.inclass.TabIndex = 19;
            this.inclass.TabStop = true;
            this.inclass.UseVisualStyleBackColor = true;
            this.inclass.CheckedChanged += new System.EventHandler(this.inclass_CheckedChanged);
            // 
            // delayed
            // 
            this.delayed.AutoSize = true;
            this.delayed.Depth = 0;
            this.delayed.Font = new System.Drawing.Font("Roboto", 10F);
            this.delayed.Location = new System.Drawing.Point(475, 19);
            this.delayed.Margin = new System.Windows.Forms.Padding(0);
            this.delayed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.delayed.MouseState = MaterialSkin.MouseState.HOVER;
            this.delayed.Name = "delayed";
            this.delayed.Ripple = true;
            this.delayed.Size = new System.Drawing.Size(25, 30);
            this.delayed.TabIndex = 20;
            this.delayed.TabStop = true;
            this.delayed.UseVisualStyleBackColor = true;
            this.delayed.CheckedChanged += new System.EventHandler(this.delayed_CheckedChanged);
            this.delayed.Click += new System.EventHandler(this.inclass_CheckedChanged);
            // 
            // notinclass
            // 
            this.notinclass.AutoSize = true;
            this.notinclass.Depth = 0;
            this.notinclass.Font = new System.Drawing.Font("Roboto", 10F);
            this.notinclass.Location = new System.Drawing.Point(510, 19);
            this.notinclass.Margin = new System.Windows.Forms.Padding(0);
            this.notinclass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.notinclass.MouseState = MaterialSkin.MouseState.HOVER;
            this.notinclass.Name = "notinclass";
            this.notinclass.Ripple = true;
            this.notinclass.Size = new System.Drawing.Size(25, 30);
            this.notinclass.TabIndex = 21;
            this.notinclass.TabStop = true;
            this.notinclass.UseVisualStyleBackColor = true;
            this.notinclass.Click += new System.EventHandler(this.inclass_CheckedChanged);
            // 
            // cancelcrys
            // 
            this.cancelcrys.AutoSize = true;
            this.cancelcrys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelcrys.BackColor = System.Drawing.Color.Transparent;
            this.cancelcrys.Depth = 0;
            this.cancelcrys.ForeColor = System.Drawing.Color.Transparent;
            this.cancelcrys.Icon = global::Logbook.Properties.Resources.icons8_x_coordinate_80;
            this.cancelcrys.Location = new System.Drawing.Point(885, 11);
            this.cancelcrys.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelcrys.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelcrys.Name = "cancelcrys";
            this.cancelcrys.Primary = false;
            this.cancelcrys.Size = new System.Drawing.Size(44, 36);
            this.cancelcrys.TabIndex = 22;
            this.cancelcrys.UseVisualStyleBackColor = false;
            this.cancelcrys.Click += new System.EventHandler(this.cancelcrys_Click);
            // 
            // commentbtn
            // 
            this.commentbtn.AutoSize = true;
            this.commentbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.commentbtn.BackColor = System.Drawing.Color.Transparent;
            this.commentbtn.Depth = 0;
            this.commentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentbtn.ForeColor = System.Drawing.Color.Transparent;
            this.commentbtn.Icon = global::Logbook.Properties.Resources.icons8_chat_bubble_100;
            this.commentbtn.Location = new System.Drawing.Point(979, 11);
            this.commentbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.commentbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.commentbtn.Name = "commentbtn";
            this.commentbtn.Primary = false;
            this.commentbtn.Size = new System.Drawing.Size(44, 36);
            this.commentbtn.TabIndex = 23;
            this.commentbtn.UseVisualStyleBackColor = false;
            this.commentbtn.Click += new System.EventHandler(this.commentbtn_Click);
            // 
            // commenttextbox
            // 
            this.commenttextbox.Location = new System.Drawing.Point(796, 47);
            this.commenttextbox.Multiline = true;
            this.commenttextbox.Name = "commenttextbox";
            this.commenttextbox.Size = new System.Drawing.Size(227, 45);
            this.commenttextbox.TabIndex = 24;
            this.commenttextbox.Visible = false;
            // 
            // studentimg
            // 
            this.studentimg.Image = global::Logbook.Properties.Resources.icons8_student_male_100__1_;
            this.studentimg.Location = new System.Drawing.Point(7, -1);
            this.studentimg.Name = "studentimg";
            this.studentimg.Size = new System.Drawing.Size(55, 42);
            this.studentimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentimg.TabIndex = 25;
            this.studentimg.TabStop = false;
            this.studentimg.Visible = false;
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.studentimg);
            this.Controls.Add(this.commenttextbox);
            this.Controls.Add(this.commentbtn);
            this.Controls.Add(this.cancelcrys);
            this.Controls.Add(this.notinclass);
            this.Controls.Add(this.delayed);
            this.Controls.Add(this.inclass);
            this.Controls.Add(this.date);
            this.Controls.Add(this.crysthree);
            this.Controls.Add(this.crystwo);
            this.Controls.Add(this.crysone);
            this.Controls.Add(this.classwork);
            this.Controls.Add(this.homework);
            this.Controls.Add(this.studentfullname);
            this.Controls.Add(this.studenticon);
            this.Controls.Add(this.rownumber);
            this.Name = "StudentPanel";
            this.Size = new System.Drawing.Size(1052, 96);
            this.Load += new System.EventHandler(this.StudentPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crysthree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crysone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenticon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentfullname;
        private System.Windows.Forms.PictureBox studenticon;
        private System.Windows.Forms.Label rownumber;
        private System.Windows.Forms.ComboBox homework;
        private System.Windows.Forms.ComboBox classwork;
        private System.Windows.Forms.PictureBox crysone;
        private System.Windows.Forms.PictureBox crystwo;
        private System.Windows.Forms.PictureBox crysthree;
        private System.Windows.Forms.Label date;
        private MaterialSkin.Controls.MaterialRadioButton inclass;
        private MaterialSkin.Controls.MaterialRadioButton delayed;
        private MaterialSkin.Controls.MaterialRadioButton notinclass;
        private MaterialSkin.Controls.MaterialFlatButton cancelcrys;
        private MaterialSkin.Controls.MaterialFlatButton commentbtn;
        private System.Windows.Forms.TextBox commenttextbox;
        private System.Windows.Forms.PictureBox studentimg;
    }
}
