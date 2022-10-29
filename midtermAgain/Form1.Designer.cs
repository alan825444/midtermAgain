namespace midtermAgain
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_regist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_regist
            // 
            this.btn_regist.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_regist.Location = new System.Drawing.Point(230, 325);
            this.btn_regist.Name = "btn_regist";
            this.btn_regist.Size = new System.Drawing.Size(105, 39);
            this.btn_regist.TabIndex = 0;
            this.btn_regist.Text = "註冊";
            this.btn_regist.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(77, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "登入";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_test
            // 
            this.btn_test.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_test.Location = new System.Drawing.Point(346, 369);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(62, 40);
            this.btn_test.TabIndex = 2;
            this.btn_test.Text = "測試用按鈕";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 409);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_regist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_regist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_test;
    }
}

