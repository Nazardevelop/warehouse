namespace lab2_warehouse
{
    partial class FormStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaff));
            this.lblsex = new System.Windows.Forms.Label();
            this.cmBsex = new System.Windows.Forms.ComboBox();
            this.lblname = new System.Windows.Forms.Label();
            this.tBname = new System.Windows.Forms.TextBox();
            this.lblsurname = new System.Windows.Forms.Label();
            this.tBsurname = new System.Windows.Forms.TextBox();
            this.dTPbirth = new System.Windows.Forms.DateTimePicker();
            this.lblbirth = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lBstaff = new System.Windows.Forms.ListBox();
            this.btnFire = new System.Windows.Forms.Button();
            this.lblPost = new System.Windows.Forms.Label();
            this.tBpost = new System.Windows.Forms.TextBox();
            this.lblOrg = new System.Windows.Forms.Label();
            this.cBorg = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblsex.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblsex.Location = new System.Drawing.Point(-3, 9);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(72, 34);
            this.lblsex.TabIndex = 0;
            this.lblsex.Text = "SEX";
            // 
            // cmBsex
            // 
            this.cmBsex.BackColor = System.Drawing.Color.Aqua;
            this.cmBsex.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBsex.FormattingEnabled = true;
            this.cmBsex.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cmBsex.Location = new System.Drawing.Point(3, 46);
            this.cmBsex.Name = "cmBsex";
            this.cmBsex.Size = new System.Drawing.Size(81, 32);
            this.cmBsex.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblname.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblname.Location = new System.Drawing.Point(-3, 97);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(97, 34);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // tBname
            // 
            this.tBname.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBname.Location = new System.Drawing.Point(3, 134);
            this.tBname.Name = "tBname";
            this.tBname.Size = new System.Drawing.Size(91, 31);
            this.tBname.TabIndex = 3;
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblsurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblsurname.Location = new System.Drawing.Point(-3, 177);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(144, 34);
            this.lblsurname.TabIndex = 4;
            this.lblsurname.Text = "Surname";
            // 
            // tBsurname
            // 
            this.tBsurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBsurname.Location = new System.Drawing.Point(3, 214);
            this.tBsurname.Name = "tBsurname";
            this.tBsurname.Size = new System.Drawing.Size(91, 31);
            this.tBsurname.TabIndex = 5;
            // 
            // dTPbirth
            // 
            this.dTPbirth.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dTPbirth.Location = new System.Drawing.Point(-6, 302);
            this.dTPbirth.Name = "dTPbirth";
            this.dTPbirth.Size = new System.Drawing.Size(251, 31);
            this.dTPbirth.TabIndex = 6;
            // 
            // lblbirth
            // 
            this.lblbirth.AutoSize = true;
            this.lblbirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblbirth.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblbirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblbirth.Location = new System.Drawing.Point(-3, 265);
            this.lblbirth.Name = "lblbirth";
            this.lblbirth.Size = new System.Drawing.Size(86, 34);
            this.lblbirth.TabIndex = 7;
            this.lblbirth.Text = "Birth";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblStaff.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblStaff.Location = new System.Drawing.Point(375, 12);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(85, 34);
            this.lblStaff.TabIndex = 9;
            this.lblStaff.Text = "Staff";
            // 
            // lBstaff
            // 
            this.lBstaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lBstaff.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBstaff.FormattingEnabled = true;
            this.lBstaff.ItemHeight = 24;
            this.lBstaff.Location = new System.Drawing.Point(293, 46);
            this.lBstaff.Name = "lBstaff";
            this.lBstaff.Size = new System.Drawing.Size(265, 220);
            this.lBstaff.TabIndex = 10;
            this.lBstaff.SelectedIndexChanged += new System.EventHandler(this.lBstaff_SelectedIndexChanged);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFire.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFire.ForeColor = System.Drawing.Color.Blue;
            this.btnFire.Location = new System.Drawing.Point(433, 272);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(94, 46);
            this.btnFire.TabIndex = 11;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPost.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPost.Location = new System.Drawing.Point(140, 0);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(91, 34);
            this.lblPost.TabIndex = 12;
            this.lblPost.Text = "POST";
            // 
            // tBpost
            // 
            this.tBpost.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBpost.Location = new System.Drawing.Point(140, 37);
            this.tBpost.Name = "tBpost";
            this.tBpost.Size = new System.Drawing.Size(91, 31);
            this.tBpost.TabIndex = 13;
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblOrg.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblOrg.Location = new System.Drawing.Point(140, 97);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(122, 34);
            this.lblOrg.TabIndex = 14;
            this.lblOrg.Text = "Partner";
            // 
            // cBorg
            // 
            this.cBorg.BackColor = System.Drawing.Color.Aqua;
            this.cBorg.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBorg.FormattingEnabled = true;
            this.cBorg.Location = new System.Drawing.Point(164, 145);
            this.cBorg.Name = "cBorg";
            this.cBorg.Size = new System.Drawing.Size(81, 32);
            this.cBorg.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(307, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 46);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab2_warehouse.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(570, 352);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cBorg);
            this.Controls.Add(this.lblOrg);
            this.Controls.Add(this.tBpost);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.lBstaff);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.lblbirth);
            this.Controls.Add(this.dTPbirth);
            this.Controls.Add(this.tBsurname);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.tBname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.cmBsex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStaff";
            this.Text = "Employ/Fire";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.ComboBox cmBsex;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox tBname;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.TextBox tBsurname;
        private System.Windows.Forms.DateTimePicker dTPbirth;
        private System.Windows.Forms.Label lblbirth;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.ListBox lBstaff;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.TextBox tBpost;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.ComboBox cBorg;
        private System.Windows.Forms.Button btnAdd;
    }
}