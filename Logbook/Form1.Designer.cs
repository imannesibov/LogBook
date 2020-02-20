namespace Logbook
{
    partial class logbook
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainteacher = new MaterialSkin.Controls.MaterialRadioButton();
            this.otherteacher = new MaterialSkin.Controls.MaterialRadioButton();
            this.topicnametextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.teachername = new MaterialSkin.Controls.MaterialLabel();
            this.Arif = new Logbook.Model.StudentPanel();
            this.Zabil = new Logbook.Model.StudentPanel();
            this.Alasgar = new Logbook.Model.StudentPanel();
            this.Mahammad = new Logbook.Model.StudentPanel();
            this.ınfoPanel = new Logbook.Model.InfoPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "FSDA_1813";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(171, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Winform Forms)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mainteacher
            // 
            this.mainteacher.AutoSize = true;
            this.mainteacher.Depth = 0;
            this.mainteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mainteacher.Location = new System.Drawing.Point(33, 78);
            this.mainteacher.Margin = new System.Windows.Forms.Padding(0);
            this.mainteacher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mainteacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainteacher.Name = "mainteacher";
            this.mainteacher.Ripple = true;
            this.mainteacher.Size = new System.Drawing.Size(115, 30);
            this.mainteacher.TabIndex = 9;
            this.mainteacher.TabStop = true;
            this.mainteacher.Text = "Əsas müəllim";
            this.mainteacher.UseVisualStyleBackColor = true;
            this.mainteacher.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // otherteacher
            // 
            this.otherteacher.AutoSize = true;
            this.otherteacher.Depth = 0;
            this.otherteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.otherteacher.Location = new System.Drawing.Point(174, 78);
            this.otherteacher.Margin = new System.Windows.Forms.Padding(0);
            this.otherteacher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.otherteacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.otherteacher.Name = "otherteacher";
            this.otherteacher.Ripple = true;
            this.otherteacher.Size = new System.Drawing.Size(152, 30);
            this.otherteacher.TabIndex = 10;
            this.otherteacher.TabStop = true;
            this.otherteacher.Text = "Müəllim əvəz olunur";
            this.otherteacher.UseVisualStyleBackColor = true;
            // 
            // topicnametextbox
            // 
            this.topicnametextbox.Depth = 0;
            this.topicnametextbox.Hint = "";
            this.topicnametextbox.Location = new System.Drawing.Point(738, 78);
            this.topicnametextbox.MaxLength = 32767;
            this.topicnametextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.topicnametextbox.Name = "topicnametextbox";
            this.topicnametextbox.PasswordChar = '\0';
            this.topicnametextbox.SelectedText = "";
            this.topicnametextbox.SelectionLength = 0;
            this.topicnametextbox.SelectionStart = 0;
            this.topicnametextbox.Size = new System.Drawing.Size(189, 23);
            this.topicnametextbox.TabIndex = 16;
            this.topicnametextbox.TabStop = false;
            this.topicnametextbox.Text = "Mövzunu daxil edin";
            this.topicnametextbox.UseSystemPasswordChar = false;
            this.topicnametextbox.Click += new System.EventHandler(this.topicnametextbox_Click);
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Enabled = false;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(614, 78);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(189, 23);
            this.materialSingleLineTextField2.TabIndex = 17;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.Text = "Dərsin mövzusu :";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(376, 27);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 18);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Müəllim : ";
            // 
            // teachername
            // 
            this.teachername.AutoSize = true;
            this.teachername.Depth = 0;
            this.teachername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.teachername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.teachername.Location = new System.Drawing.Point(445, 28);
            this.teachername.MouseState = MaterialSkin.MouseState.HOVER;
            this.teachername.Name = "teachername";
            this.teachername.Size = new System.Drawing.Size(77, 18);
            this.teachername.TabIndex = 19;
            this.teachername.Text = "seçilməyib";
            // 
            // Arif
            // 
            this.Arif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Arif.Location = new System.Drawing.Point(-3, 483);
            this.Arif.Name = "Arif";
            this.Arif.Size = new System.Drawing.Size(1037, 96);
            this.Arif.TabIndex = 15;
            // 
            // Zabil
            // 
            this.Zabil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Zabil.Location = new System.Drawing.Point(-3, 383);
            this.Zabil.Name = "Zabil";
            this.Zabil.Size = new System.Drawing.Size(1037, 96);
            this.Zabil.TabIndex = 14;
            // 
            // Alasgar
            // 
            this.Alasgar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Alasgar.Location = new System.Drawing.Point(-3, 283);
            this.Alasgar.Name = "Alasgar";
            this.Alasgar.Size = new System.Drawing.Size(1037, 96);
            this.Alasgar.TabIndex = 13;
            // 
            // Mahammad
            // 
            this.Mahammad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Mahammad.Location = new System.Drawing.Point(-3, 182);
            this.Mahammad.Name = "Mahammad";
            this.Mahammad.Size = new System.Drawing.Size(1037, 96);
            this.Mahammad.TabIndex = 12;
            this.Mahammad.Load += new System.EventHandler(this.studentPanel1_Load);
            // 
            // ınfoPanel
            // 
            this.ınfoPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ınfoPanel.Location = new System.Drawing.Point(-3, 112);
            this.ınfoPanel.Name = "ınfoPanel";
            this.ınfoPanel.Size = new System.Drawing.Size(1037, 66);
            this.ınfoPanel.TabIndex = 11;
            // 
            // logbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1028, 584);
            this.Controls.Add(this.teachername);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.topicnametextbox);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.Arif);
            this.Controls.Add(this.Zabil);
            this.Controls.Add(this.Alasgar);
            this.Controls.Add(this.Mahammad);
            this.Controls.Add(this.ınfoPanel);
            this.Controls.Add(this.otherteacher);
            this.Controls.Add(this.mainteacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1044, 623);
            this.MinimumSize = new System.Drawing.Size(1044, 623);
            this.Name = "logbook";
            this.ShowIcon = false;
            this.Text = "Logbook";
            this.Load += new System.EventHandler(this.logbook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRadioButton mainteacher;
        private MaterialSkin.Controls.MaterialRadioButton otherteacher;
        private Model.InfoPanel ınfoPanel;
        private Model.StudentPanel Mahammad;
        private Model.StudentPanel Alasgar;
        private Model.StudentPanel Zabil;
        private Model.StudentPanel Arif;
        private MaterialSkin.Controls.MaterialSingleLineTextField topicnametextbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel teachername;
    }
}

