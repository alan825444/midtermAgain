namespace midtermAgain
{
    partial class accountMng
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
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.cb_Permision = new System.Windows.Forms.ComboBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.cb_verification = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dataEdit = new System.Windows.Forms.Button();
            this.btn_verify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_info
            // 
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(29, 49);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RowTemplate.Height = 24;
            this.dgv_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_info.Size = new System.Drawing.Size(736, 277);
            this.dgv_info.TabIndex = 0;
            // 
            // cb_Permision
            // 
            this.cb_Permision.FormattingEnabled = true;
            this.cb_Permision.Location = new System.Drawing.Point(70, 23);
            this.cb_Permision.Name = "cb_Permision";
            this.cb_Permision.Size = new System.Drawing.Size(65, 20);
            this.cb_Permision.TabIndex = 1;
            this.cb_Permision.Text = "全部";
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(186, 23);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(52, 20);
            this.cb_gender.TabIndex = 2;
            this.cb_gender.Text = "全部";
            // 
            // cb_verification
            // 
            this.cb_verification.FormattingEnabled = true;
            this.cb_verification.Location = new System.Drawing.Point(318, 23);
            this.cb_verification.Name = "cb_verification";
            this.cb_verification.Size = new System.Drawing.Size(71, 20);
            this.cb_verification.TabIndex = 3;
            this.cb_verification.Text = "全部";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "權限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "性別";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "認證狀態";
            // 
            // btn_dataEdit
            // 
            this.btn_dataEdit.Location = new System.Drawing.Point(29, 332);
            this.btn_dataEdit.Name = "btn_dataEdit";
            this.btn_dataEdit.Size = new System.Drawing.Size(106, 39);
            this.btn_dataEdit.TabIndex = 7;
            this.btn_dataEdit.Text = "修改資料";
            this.btn_dataEdit.UseVisualStyleBackColor = true;
            // 
            // btn_verify
            // 
            this.btn_verify.Location = new System.Drawing.Point(153, 332);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(106, 39);
            this.btn_verify.TabIndex = 8;
            this.btn_verify.Text = "驗證帳號";
            this.btn_verify.UseVisualStyleBackColor = true;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // accountMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.btn_dataEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_verification);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.cb_Permision);
            this.Controls.Add(this.dgv_info);
            this.Name = "accountMng";
            this.Text = "accountMng";
            this.Load += new System.EventHandler(this.accountMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.ComboBox cb_Permision;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.ComboBox cb_verification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dataEdit;
        private System.Windows.Forms.Button btn_verify;
    }
}