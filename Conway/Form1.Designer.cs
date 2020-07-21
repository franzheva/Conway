namespace Conway
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
            this.components = new System.ComponentModel.Container();
            this.funcSet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startTimerButton = new System.Windows.Forms.Button();
            this.stopTimer = new System.Windows.Forms.Button();
            this.Control_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PopulationLabel = new System.Windows.Forms.Label();
            this.IterationLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // funcSet
            // 
            this.funcSet.Location = new System.Drawing.Point(631, 23);
            this.funcSet.Name = "funcSet";
            this.funcSet.Size = new System.Drawing.Size(79, 23);
            this.funcSet.TabIndex = 3;
            this.funcSet.Text = "Set Function";
            this.funcSet.UseVisualStyleBackColor = true;
            this.funcSet.Click += new System.EventHandler(this.funcSet_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startTimerButton
            // 
            this.startTimerButton.Location = new System.Drawing.Point(631, 86);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(79, 23);
            this.startTimerButton.TabIndex = 6;
            this.startTimerButton.Text = "Start timer";
            this.startTimerButton.UseVisualStyleBackColor = true;
            this.startTimerButton.Click += new System.EventHandler(this.startTimerButton_Click);
            // 
            // stopTimer
            // 
            this.stopTimer.Location = new System.Drawing.Point(631, 116);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(79, 23);
            this.stopTimer.TabIndex = 7;
            this.stopTimer.Text = "Pause timer";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // Control_btn
            // 
            this.Control_btn.Location = new System.Drawing.Point(631, 54);
            this.Control_btn.Name = "Control_btn";
            this.Control_btn.Size = new System.Drawing.Size(79, 23);
            this.Control_btn.TabIndex = 8;
            this.Control_btn.Text = "Control";
            this.Control_btn.UseVisualStyleBackColor = true;
            this.Control_btn.Click += new System.EventHandler(this.Control_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Population:";
            // 
            // PopulationLabel
            // 
            this.PopulationLabel.AutoSize = true;
            this.PopulationLabel.Location = new System.Drawing.Point(583, 423);
            this.PopulationLabel.Name = "PopulationLabel";
            this.PopulationLabel.Size = new System.Drawing.Size(13, 13);
            this.PopulationLabel.TabIndex = 10;
            this.PopulationLabel.Text = "0";
            // 
            // IterationLabel
            // 
            this.IterationLabel.AutoSize = true;
            this.IterationLabel.Location = new System.Drawing.Point(583, 452);
            this.IterationLabel.Name = "IterationLabel";
            this.IterationLabel.Size = new System.Drawing.Size(13, 13);
            this.IterationLabel.TabIndex = 12;
            this.IterationLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Iteration:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 474);
            this.Controls.Add(this.IterationLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PopulationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Control_btn);
            this.Controls.Add(this.stopTimer);
            this.Controls.Add(this.startTimerButton);
            this.Controls.Add(this.funcSet);
            this.Name = "Form1";
            this.Text = "Conway";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button funcSet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startTimerButton;
        private System.Windows.Forms.Button stopTimer;
        private System.Windows.Forms.Button Control_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PopulationLabel;
        private System.Windows.Forms.Label IterationLabel;
        private System.Windows.Forms.Label label3;
    }
}

