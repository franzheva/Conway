namespace Conway
{
    partial class ControlSettings
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.controlDepth_tb = new System.Windows.Forms.TextBox();
            this.cycleLength_tb = new System.Windows.Forms.TextBox();
            this.sigma1_tb = new System.Windows.Forms.TextBox();
            this.sigma2_tb = new System.Windows.Forms.TextBox();
            this.gamma_tb = new System.Windows.Forms.TextBox();
            this.SetControl_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control Depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cycle Lepth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sigma 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sigma 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gamma";
            // 
            // controlDepth_tb
            // 
            this.controlDepth_tb.Location = new System.Drawing.Point(105, 31);
            this.controlDepth_tb.Name = "controlDepth_tb";
            this.controlDepth_tb.Size = new System.Drawing.Size(100, 20);
            this.controlDepth_tb.TabIndex = 5;
            // 
            // cycleLength_tb
            // 
            this.cycleLength_tb.Location = new System.Drawing.Point(105, 56);
            this.cycleLength_tb.Name = "cycleLength_tb";
            this.cycleLength_tb.Size = new System.Drawing.Size(100, 20);
            this.cycleLength_tb.TabIndex = 6;
            // 
            // sigma1_tb
            // 
            this.sigma1_tb.Location = new System.Drawing.Point(105, 82);
            this.sigma1_tb.Name = "sigma1_tb";
            this.sigma1_tb.Size = new System.Drawing.Size(100, 20);
            this.sigma1_tb.TabIndex = 7;
            // 
            // sigma2_tb
            // 
            this.sigma2_tb.Location = new System.Drawing.Point(105, 108);
            this.sigma2_tb.Name = "sigma2_tb";
            this.sigma2_tb.Size = new System.Drawing.Size(100, 20);
            this.sigma2_tb.TabIndex = 8;
            // 
            // gamma_tb
            // 
            this.gamma_tb.Location = new System.Drawing.Point(105, 134);
            this.gamma_tb.Name = "gamma_tb";
            this.gamma_tb.Size = new System.Drawing.Size(100, 20);
            this.gamma_tb.TabIndex = 9;
            // 
            // SetControl_btn
            // 
            this.SetControl_btn.Location = new System.Drawing.Point(77, 178);
            this.SetControl_btn.Name = "SetControl_btn";
            this.SetControl_btn.Size = new System.Drawing.Size(75, 23);
            this.SetControl_btn.TabIndex = 10;
            this.SetControl_btn.Text = "Set Control";
            this.SetControl_btn.UseVisualStyleBackColor = true;
            this.SetControl_btn.Click += new System.EventHandler(this.SetControl_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 318);
            this.textBox1.TabIndex = 11;
            // 
            // ControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 353);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SetControl_btn);
            this.Controls.Add(this.gamma_tb);
            this.Controls.Add(this.sigma2_tb);
            this.Controls.Add(this.sigma1_tb);
            this.Controls.Add(this.cycleLength_tb);
            this.Controls.Add(this.controlDepth_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ControlSettings";
            this.Text = "ControlSettings";
            this.Load += new System.EventHandler(this.ControlSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox controlDepth_tb;
        private System.Windows.Forms.TextBox cycleLength_tb;
        private System.Windows.Forms.TextBox sigma1_tb;
        private System.Windows.Forms.TextBox sigma2_tb;
        private System.Windows.Forms.TextBox gamma_tb;
        private System.Windows.Forms.Button SetControl_btn;
        private System.Windows.Forms.TextBox textBox1;
    }
}