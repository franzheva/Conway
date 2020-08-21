namespace Conway
{
    partial class AddNewFunction
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
            this.FunctionNameTB = new System.Windows.Forms.TextBox();
            this.FunctionTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NameLabelWarning = new System.Windows.Forms.Label();
            this.FunctionLabelWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FunctionNameTB
            // 
            this.FunctionNameTB.Location = new System.Drawing.Point(84, 26);
            this.FunctionNameTB.Name = "FunctionNameTB";
            this.FunctionNameTB.Size = new System.Drawing.Size(173, 20);
            this.FunctionNameTB.TabIndex = 0;
            // 
            // FunctionTB
            // 
            this.FunctionTB.Location = new System.Drawing.Point(84, 68);
            this.FunctionTB.Multiline = true;
            this.FunctionTB.Name = "FunctionTB";
            this.FunctionTB.Size = new System.Drawing.Size(173, 139);
            this.FunctionTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Function:";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(94, 234);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 23);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add Function";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NameLabelWarning
            // 
            this.NameLabelWarning.AutoSize = true;
            this.NameLabelWarning.ForeColor = System.Drawing.Color.Red;
            this.NameLabelWarning.Location = new System.Drawing.Point(91, 49);
            this.NameLabelWarning.Name = "NameLabelWarning";
            this.NameLabelWarning.Size = new System.Drawing.Size(0, 13);
            this.NameLabelWarning.TabIndex = 5;
            // 
            // FunctionLabelWarning
            // 
            this.FunctionLabelWarning.AutoSize = true;
            this.FunctionLabelWarning.ForeColor = System.Drawing.Color.Red;
            this.FunctionLabelWarning.Location = new System.Drawing.Point(91, 210);
            this.FunctionLabelWarning.Name = "FunctionLabelWarning";
            this.FunctionLabelWarning.Size = new System.Drawing.Size(0, 13);
            this.FunctionLabelWarning.TabIndex = 6;
            // 
            // AddNewFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 269);
            this.Controls.Add(this.FunctionLabelWarning);
            this.Controls.Add(this.NameLabelWarning);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FunctionTB);
            this.Controls.Add(this.FunctionNameTB);
            this.MaximizeBox = false;
            this.Name = "AddNewFunction";
            this.Text = "AddNewFunction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FunctionNameTB;
        private System.Windows.Forms.TextBox FunctionTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label NameLabelWarning;
        private System.Windows.Forms.Label FunctionLabelWarning;
    }
}