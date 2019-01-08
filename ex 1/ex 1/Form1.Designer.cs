namespace ex_1
{
    partial class Form1
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdateDb = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpDate = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbFamily = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(62, 90);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(89, 37);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "SelectByDs";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(62, 176);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 17);
            this.lbl1.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(187, 90);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 36);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdateDb
            // 
            this.btnUpdateDb.Location = new System.Drawing.Point(312, 90);
            this.btnUpdateDb.Name = "btnUpdateDb";
            this.btnUpdateDb.Size = new System.Drawing.Size(89, 37);
            this.btnUpdateDb.TabIndex = 3;
            this.btnUpdateDb.Text = "UpdateDs 2 DB";
            this.btnUpdateDb.UseVisualStyleBackColor = true;
            this.btnUpdateDb.Click += new System.EventHandler(this.btnUpdateDb_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(684, 362);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 37);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "RefreshDB";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpDate
            // 
            this.btnUpDate.Location = new System.Drawing.Point(529, 90);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(89, 37);
            this.btnUpDate.TabIndex = 6;
            this.btnUpDate.Text = "UpDate";
            this.btnUpDate.UseVisualStyleBackColor = true;
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(267, 171);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(197, 22);
            this.txbId.TabIndex = 7;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(267, 227);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(197, 22);
            this.txbName.TabIndex = 8;
            // 
            // txbFamily
            // 
            this.txbFamily.Location = new System.Drawing.Point(267, 280);
            this.txbFamily.Name = "txbFamily";
            this.txbFamily.Size = new System.Drawing.Size(197, 22);
            this.txbFamily.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Family :";
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.ForeColor = System.Drawing.Color.Maroon;
            this.lblErr.Location = new System.Drawing.Point(284, 339);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 17);
            this.lblErr.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbFamily);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.btnUpDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdateDb);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdateDb;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpDate;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErr;
    }
}

