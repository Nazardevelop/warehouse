namespace lab2_warehouse
{
    partial class FormPartners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartners));
            this.lblAddpartner = new System.Windows.Forms.Label();
            this.tBaddpartner = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lBpartners = new System.Windows.Forms.ListBox();
            this.lblpartners = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddpartner
            // 
            this.lblAddpartner.AutoSize = true;
            this.lblAddpartner.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddpartner.Location = new System.Drawing.Point(3, 9);
            this.lblAddpartner.Name = "lblAddpartner";
            this.lblAddpartner.Size = new System.Drawing.Size(236, 24);
            this.lblAddpartner.TabIndex = 0;
            this.lblAddpartner.Text = "Name of organization";
            // 
            // tBaddpartner
            // 
            this.tBaddpartner.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBaddpartner.Location = new System.Drawing.Point(7, 36);
            this.tBaddpartner.Name = "tBaddpartner";
            this.tBaddpartner.Size = new System.Drawing.Size(100, 27);
            this.tBaddpartner.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(7, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.Location = new System.Drawing.Point(236, 208);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(138, 42);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lBpartners
            // 
            this.lBpartners.FormattingEnabled = true;
            this.lBpartners.Location = new System.Drawing.Point(208, 36);
            this.lBpartners.Name = "lBpartners";
            this.lBpartners.Size = new System.Drawing.Size(174, 147);
            this.lBpartners.TabIndex = 4;
            this.lBpartners.SelectedIndexChanged += new System.EventHandler(this.lBpartners_SelectedIndexChanged);
            // 
            // lblpartners
            // 
            this.lblpartners.AutoSize = true;
            this.lblpartners.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblpartners.Location = new System.Drawing.Point(255, 9);
            this.lblpartners.Name = "lblpartners";
            this.lblpartners.Size = new System.Drawing.Size(96, 24);
            this.lblpartners.TabIndex = 5;
            this.lblpartners.Text = "Partners";
            // 
            // FormPartners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab2_warehouse.Properties.Resources.galery_warehouse_op_20110331_6_400x300;
            this.ClientSize = new System.Drawing.Size(386, 262);
            this.Controls.Add(this.lblpartners);
            this.Controls.Add(this.lBpartners);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tBaddpartner);
            this.Controls.Add(this.lblAddpartner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPartners";
            this.Text = "Partners";
            this.Load += new System.EventHandler(this.FormPartners_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddpartner;
        private System.Windows.Forms.TextBox tBaddpartner;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListBox lBpartners;
        private System.Windows.Forms.Label lblpartners;
    }
}