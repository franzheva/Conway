namespace Conway
{
    partial class Function
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tentCB = new System.Windows.Forms.CheckBox();
            this.logisticCB = new System.Windows.Forms.CheckBox();
            this.fieldsizetb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scaletb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Function";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 73);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 129);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 60);
            this.textBox1.TabIndex = 2;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(383, 42);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(383, 71);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 100);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inner function";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Outer function";
            // 
            // tentCB
            // 
            this.tentCB.AutoSize = true;
            this.tentCB.Location = new System.Drawing.Point(232, 196);
            this.tentCB.Name = "tentCB";
            this.tentCB.Size = new System.Drawing.Size(48, 17);
            this.tentCB.TabIndex = 7;
            this.tentCB.Text = "Tent";
            this.tentCB.UseVisualStyleBackColor = true;
            this.tentCB.CheckedChanged += new System.EventHandler(this.tentCB_CheckedChanged);
            // 
            // logisticCB
            // 
            this.logisticCB.AutoSize = true;
            this.logisticCB.Location = new System.Drawing.Point(232, 219);
            this.logisticCB.Name = "logisticCB";
            this.logisticCB.Size = new System.Drawing.Size(62, 17);
            this.logisticCB.TabIndex = 8;
            this.logisticCB.Text = "Logistic";
            this.logisticCB.UseVisualStyleBackColor = true;
            this.logisticCB.CheckedChanged += new System.EventHandler(this.logisticCB_CheckedChanged);
            // 
            // fieldsizetb
            // 
            this.fieldsizetb.Location = new System.Drawing.Point(387, 196);
            this.fieldsizetb.Name = "fieldsizetb";
            this.fieldsizetb.Size = new System.Drawing.Size(42, 20);
            this.fieldsizetb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Set field size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Set scale:";
            // 
            // scaletb
            // 
            this.scaletb.Location = new System.Drawing.Point(387, 218);
            this.scaletb.Name = "scaletb";
            this.scaletb.Size = new System.Drawing.Size(42, 20);
            this.scaletb.TabIndex = 11;
            // 
            // Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 282);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scaletb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fieldsizetb);
            this.Controls.Add(this.logisticCB);
            this.Controls.Add(this.tentCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Function";
            this.Text = "Function";
            this.Load += new System.EventHandler(this.Function_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox tentCB;
        private System.Windows.Forms.CheckBox logisticCB;
        private System.Windows.Forms.TextBox fieldsizetb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scaletb;
    }
}