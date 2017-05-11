namespace Matching_MSEProcess
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFileModdle = new System.Windows.Forms.Button();
            this.btnFilePattern = new System.Windows.Forms.Button();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThz = new System.Windows.Forms.TextBox();
            this.btnGenRotatMSE = new System.Windows.Forms.Button();
            this.txtMse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFileModdle
            // 
            this.btnFileModdle.Location = new System.Drawing.Point(12, 12);
            this.btnFileModdle.Name = "btnFileModdle";
            this.btnFileModdle.Size = new System.Drawing.Size(114, 38);
            this.btnFileModdle.TabIndex = 0;
            this.btnFileModdle.Text = "FileModdle";
            this.btnFileModdle.UseVisualStyleBackColor = true;
            this.btnFileModdle.Click += new System.EventHandler(this.btnFileModdle_Click);
            // 
            // btnFilePattern
            // 
            this.btnFilePattern.Location = new System.Drawing.Point(158, 12);
            this.btnFilePattern.Name = "btnFilePattern";
            this.btnFilePattern.Size = new System.Drawing.Size(114, 38);
            this.btnFilePattern.TabIndex = 1;
            this.btnFilePattern.Text = "FilePattern";
            this.btnFilePattern.UseVisualStyleBackColor = true;
            this.btnFilePattern.Click += new System.EventHandler(this.btnFilePattern_Click);
            // 
            // txtDx
            // 
            this.txtDx.Location = new System.Drawing.Point(56, 71);
            this.txtDx.Name = "txtDx";
            this.txtDx.Size = new System.Drawing.Size(114, 25);
            this.txtDx.TabIndex = 2;
            this.txtDx.Text = "10.0780561323875";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dy";
            // 
            // txtDy
            // 
            this.txtDy.Location = new System.Drawing.Point(56, 113);
            this.txtDy.Name = "txtDy";
            this.txtDy.Size = new System.Drawing.Size(114, 25);
            this.txtDy.TabIndex = 4;
            this.txtDy.Text = "-22.9270766939679";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dz";
            // 
            // txtDz
            // 
            this.txtDz.Location = new System.Drawing.Point(56, 157);
            this.txtDz.Name = "txtDz";
            this.txtDz.Size = new System.Drawing.Size(114, 25);
            this.txtDz.TabIndex = 6;
            this.txtDz.Text = "1.70743330204912";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thx";
            // 
            // txtThx
            // 
            this.txtThx.Location = new System.Drawing.Point(56, 198);
            this.txtThx.Name = "txtThx";
            this.txtThx.Size = new System.Drawing.Size(114, 25);
            this.txtThx.TabIndex = 8;
            this.txtThx.Text = "359.90488177157";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thy";
            // 
            // txtThy
            // 
            this.txtThy.Location = new System.Drawing.Point(56, 239);
            this.txtThy.Name = "txtThy";
            this.txtThy.Size = new System.Drawing.Size(114, 25);
            this.txtThy.TabIndex = 10;
            this.txtThy.Text = "0.00909256633905833";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Thz";
            // 
            // txtThz
            // 
            this.txtThz.Location = new System.Drawing.Point(56, 281);
            this.txtThz.Name = "txtThz";
            this.txtThz.Size = new System.Drawing.Size(114, 25);
            this.txtThz.TabIndex = 12;
            this.txtThz.Text = "1.18965562854505";
            // 
            // btnGenRotatMSE
            // 
            this.btnGenRotatMSE.Location = new System.Drawing.Point(19, 331);
            this.btnGenRotatMSE.Name = "btnGenRotatMSE";
            this.btnGenRotatMSE.Size = new System.Drawing.Size(114, 38);
            this.btnGenRotatMSE.TabIndex = 14;
            this.btnGenRotatMSE.Text = "GenRotatMSE";
            this.btnGenRotatMSE.UseVisualStyleBackColor = true;
            this.btnGenRotatMSE.Click += new System.EventHandler(this.btnGenRotatMSE_Click);
            // 
            // txtMse
            // 
            this.txtMse.Location = new System.Drawing.Point(158, 331);
            this.txtMse.Multiline = true;
            this.txtMse.Name = "txtMse";
            this.txtMse.Size = new System.Drawing.Size(114, 38);
            this.txtMse.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 396);
            this.Controls.Add(this.txtMse);
            this.Controls.Add(this.btnGenRotatMSE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtThz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDx);
            this.Controls.Add(this.btnFilePattern);
            this.Controls.Add(this.btnFileModdle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileModdle;
        private System.Windows.Forms.Button btnFilePattern;
        private System.Windows.Forms.TextBox txtDx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThz;
        private System.Windows.Forms.Button btnGenRotatMSE;
        private System.Windows.Forms.TextBox txtMse;
    }
}

