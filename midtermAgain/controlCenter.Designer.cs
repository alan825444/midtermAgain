namespace midtermAgain
{
    partial class controlCenter
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
            this.btn_accountMng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_accountMng
            // 
            this.btn_accountMng.Font = new System.Drawing.Font("華康粗黑體(P)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_accountMng.Location = new System.Drawing.Point(39, 36);
            this.btn_accountMng.Name = "btn_accountMng";
            this.btn_accountMng.Size = new System.Drawing.Size(136, 61);
            this.btn_accountMng.TabIndex = 0;
            this.btn_accountMng.Text = "帳號管理";
            this.btn_accountMng.UseVisualStyleBackColor = true;
            this.btn_accountMng.Click += new System.EventHandler(this.btn_accountMng_Click);
            // 
            // controlCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.btn_accountMng);
            this.Name = "controlCenter";
            this.Text = "controlCenter";
            this.Load += new System.EventHandler(this.controlCenter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_accountMng;
    }
}