namespace C.net_Test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(368, 153);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 51);
            this.btn.TabIndex = 0;
            this.btn.Text = "点击";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab
            // 
            this.lab.Location = new System.Drawing.Point(233, 73);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(55, 38);
            this.lab.TabIndex = 1;
            this.lab.Text = "0";
            this.lab.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab1
            // 
            this.lab1.AllowDrop = true;
            this.lab1.Location = new System.Drawing.Point(233, 153);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(55, 51);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "0";
            // 
            // lab2
            // 
            this.lab2.Location = new System.Drawing.Point(233, 256);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(55, 44);
            this.lab2.TabIndex = 3;
            this.lab2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
    }
}

