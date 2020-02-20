namespace Logbook.Model
{
    partial class InfoPanel
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
            this.date = new System.Windows.Forms.Label();
            this.studentfullname = new System.Windows.Forms.Label();
            this.allstudentscame = new System.Windows.Forms.Label();
            this.homeworks = new System.Windows.Forms.Label();
            this.classworks = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.Label();
            this.crystalcount = new System.Windows.Forms.Label();
            this.crystalimg = new System.Windows.Forms.PictureBox();
            this.allstudentscamerdtn = new MaterialSkin.Controls.MaterialCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.crystalimg)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.date.ForeColor = System.Drawing.SystemColors.Highlight;
            this.date.Location = new System.Drawing.Point(318, 25);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(93, 13);
            this.date.TabIndex = 32;
            this.date.Text = "Mystat\'a daxil olub";
            // 
            // studentfullname
            // 
            this.studentfullname.AutoSize = true;
            this.studentfullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentfullname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.studentfullname.Location = new System.Drawing.Point(107, 25);
            this.studentfullname.Name = "studentfullname";
            this.studentfullname.Size = new System.Drawing.Size(109, 13);
            this.studentfullname.TabIndex = 21;
            this.studentfullname.Text = "Tələbənin adı, Soyadı";
            // 
            // allstudentscame
            // 
            this.allstudentscame.AutoSize = true;
            this.allstudentscame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allstudentscame.ForeColor = System.Drawing.SystemColors.Highlight;
            this.allstudentscame.Location = new System.Drawing.Point(448, 24);
            this.allstudentscame.Name = "allstudentscame";
            this.allstudentscame.Size = new System.Drawing.Size(104, 13);
            this.allstudentscame.TabIndex = 33;
            this.allstudentscame.Text = "Hər kəsi qeyd etmək";
            // 
            // homeworks
            // 
            this.homeworks.AutoSize = true;
            this.homeworks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeworks.ForeColor = System.Drawing.SystemColors.Highlight;
            this.homeworks.Location = new System.Drawing.Point(598, 25);
            this.homeworks.Name = "homeworks";
            this.homeworks.Size = new System.Drawing.Size(68, 13);
            this.homeworks.TabIndex = 34;
            this.homeworks.Text = "Yoxlama işlər";
            // 
            // classworks
            // 
            this.classworks.AutoSize = true;
            this.classworks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classworks.ForeColor = System.Drawing.SystemColors.Highlight;
            this.classworks.Location = new System.Drawing.Point(692, 25);
            this.classworks.Name = "classworks";
            this.classworks.Size = new System.Drawing.Size(49, 13);
            this.classworks.TabIndex = 35;
            this.classworks.Text = "Sinifdə iş";
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comment.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comment.Location = new System.Drawing.Point(980, 29);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(26, 13);
            this.comment.TabIndex = 36;
            this.comment.Text = "Rəy";
            // 
            // crystalcount
            // 
            this.crystalcount.AutoSize = true;
            this.crystalcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crystalcount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crystalcount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.crystalcount.Location = new System.Drawing.Point(859, 21);
            this.crystalcount.Name = "crystalcount";
            this.crystalcount.Size = new System.Drawing.Size(19, 21);
            this.crystalcount.TabIndex = 37;
            this.crystalcount.Text = "5";
            // 
            // crystalimg
            // 
            this.crystalimg.Image = global::Logbook.Properties.Resources.icons8_crystal_80__1_;
            this.crystalimg.Location = new System.Drawing.Point(884, 16);
            this.crystalimg.Name = "crystalimg";
            this.crystalimg.Size = new System.Drawing.Size(34, 26);
            this.crystalimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crystalimg.TabIndex = 31;
            this.crystalimg.TabStop = false;
            // 
            // allstudentscamerdtn
            // 
            this.allstudentscamerdtn.AutoSize = true;
            this.allstudentscamerdtn.Depth = 0;
            this.allstudentscamerdtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.allstudentscamerdtn.Location = new System.Drawing.Point(475, 40);
            this.allstudentscamerdtn.Margin = new System.Windows.Forms.Padding(0);
            this.allstudentscamerdtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.allstudentscamerdtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.allstudentscamerdtn.Name = "allstudentscamerdtn";
            this.allstudentscamerdtn.Ripple = true;
            this.allstudentscamerdtn.Size = new System.Drawing.Size(26, 30);
            this.allstudentscamerdtn.TabIndex = 39;
            this.allstudentscamerdtn.UseVisualStyleBackColor = true;
            this.allstudentscamerdtn.CheckedChanged += new System.EventHandler(this.allstudentscame_CheckedChanged);
            // 
            // InfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.allstudentscamerdtn);
            this.Controls.Add(this.crystalcount);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.classworks);
            this.Controls.Add(this.homeworks);
            this.Controls.Add(this.allstudentscame);
            this.Controls.Add(this.date);
            this.Controls.Add(this.crystalimg);
            this.Controls.Add(this.studentfullname);
            this.Name = "InfoPanel";
            this.Size = new System.Drawing.Size(1037, 66);
            this.Load += new System.EventHandler(this.InfoPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crystalimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.PictureBox crystalimg;
        private System.Windows.Forms.Label studentfullname;
        private System.Windows.Forms.Label allstudentscame;
        private System.Windows.Forms.Label homeworks;
        private System.Windows.Forms.Label classworks;
        private System.Windows.Forms.Label comment;
        private System.Windows.Forms.Label crystalcount;
        private MaterialSkin.Controls.MaterialCheckBox allstudentscamerdtn;
    }
}
