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
            this.PanelForSettings = new System.Windows.Forms.Panel();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.AveragePopulationLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TcycleCoincidenceLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExportPopDataBtn = new System.Windows.Forms.Button();
            this.Control_Label = new System.Windows.Forms.Label();
            this.PanelForSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcSet
            // 
            this.funcSet.Location = new System.Drawing.Point(3, 3);
            this.funcSet.Name = "funcSet";
            this.funcSet.Size = new System.Drawing.Size(79, 23);
            this.funcSet.TabIndex = 3;
            this.funcSet.Text = "Set Function";
            this.funcSet.UseVisualStyleBackColor = true;
            this.funcSet.Click += new System.EventHandler(this.funcSet_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startTimerButton
            // 
            this.startTimerButton.Location = new System.Drawing.Point(203, 3);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(79, 23);
            this.startTimerButton.TabIndex = 6;
            this.startTimerButton.Text = "Start timer";
            this.startTimerButton.UseVisualStyleBackColor = true;
            this.startTimerButton.Click += new System.EventHandler(this.startTimerButton_Click);
            // 
            // stopTimer
            // 
            this.stopTimer.Location = new System.Drawing.Point(288, 3);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(79, 23);
            this.stopTimer.TabIndex = 7;
            this.stopTimer.Text = "Pause timer";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // Control_btn
            // 
            this.Control_btn.Location = new System.Drawing.Point(88, 3);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Population:";
            // 
            // PopulationLabel
            // 
            this.PopulationLabel.AutoSize = true;
            this.PopulationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopulationLabel.Location = new System.Drawing.Point(448, 7);
            this.PopulationLabel.Name = "PopulationLabel";
            this.PopulationLabel.Size = new System.Drawing.Size(15, 16);
            this.PopulationLabel.TabIndex = 10;
            this.PopulationLabel.Text = "0";
            // 
            // IterationLabel
            // 
            this.IterationLabel.AutoSize = true;
            this.IterationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IterationLabel.Location = new System.Drawing.Point(87, 43);
            this.IterationLabel.Name = "IterationLabel";
            this.IterationLabel.Size = new System.Drawing.Size(15, 16);
            this.IterationLabel.TabIndex = 12;
            this.IterationLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Iteration:";
            // 
            // PanelForSettings
            // 
            this.PanelForSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelForSettings.Controls.Add(this.ExportPopDataBtn);
            this.PanelForSettings.Controls.Add(this.TcycleCoincidenceLbl);
            this.PanelForSettings.Controls.Add(this.label6);
            this.PanelForSettings.Controls.Add(this.AveragePopulationLbl);
            this.PanelForSettings.Controls.Add(this.label4);
            this.PanelForSettings.Controls.Add(this.Control_Label);
            this.PanelForSettings.Controls.Add(this.Control_btn);
            this.PanelForSettings.Controls.Add(this.IterationLabel);
            this.PanelForSettings.Controls.Add(this.funcSet);
            this.PanelForSettings.Controls.Add(this.label3);
            this.PanelForSettings.Controls.Add(this.startTimerButton);
            this.PanelForSettings.Controls.Add(this.PopulationLabel);
            this.PanelForSettings.Controls.Add(this.stopTimer);
            this.PanelForSettings.Controls.Add(this.label1);
            this.PanelForSettings.Location = new System.Drawing.Point(0, 0);
            this.PanelForSettings.Name = "PanelForSettings";
            this.PanelForSettings.Size = new System.Drawing.Size(740, 75);
            this.PanelForSettings.TabIndex = 13;
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Location = new System.Drawing.Point(3, 81);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(740, 381);
            this.DrawingPanel.TabIndex = 14;
            // 
            // AveragePopulationLbl
            // 
            this.AveragePopulationLbl.AutoSize = true;
            this.AveragePopulationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AveragePopulationLbl.Location = new System.Drawing.Point(500, 27);
            this.AveragePopulationLbl.Name = "AveragePopulationLbl";
            this.AveragePopulationLbl.Size = new System.Drawing.Size(15, 16);
            this.AveragePopulationLbl.TabIndex = 14;
            this.AveragePopulationLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Average  population:";
            // 
            // TcycleCoincidenceLbl
            // 
            this.TcycleCoincidenceLbl.AutoSize = true;
            this.TcycleCoincidenceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcycleCoincidenceLbl.Location = new System.Drawing.Point(500, 47);
            this.TcycleCoincidenceLbl.Name = "TcycleCoincidenceLbl";
            this.TcycleCoincidenceLbl.Size = new System.Drawing.Size(15, 16);
            this.TcycleCoincidenceLbl.TabIndex = 16;
            this.TcycleCoincidenceLbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "T-cycle coincidence:";
            // 
            // ExportPopDataBtn
            // 
            this.ExportPopDataBtn.Location = new System.Drawing.Point(203, 36);
            this.ExportPopDataBtn.Name = "ExportPopDataBtn";
            this.ExportPopDataBtn.Size = new System.Drawing.Size(164, 23);
            this.ExportPopDataBtn.TabIndex = 17;
            this.ExportPopDataBtn.Text = "Export Population Data";
            this.ExportPopDataBtn.UseVisualStyleBackColor = true;
            this.ExportPopDataBtn.Click += new System.EventHandler(this.ExportPopDataBtn_Click);
            // Control_Label
            // 
            this.Control_Label.AutoSize = true;
            this.Control_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control_Label.ForeColor = System.Drawing.Color.Red;
            this.Control_Label.Location = new System.Drawing.Point(85, 27);
            this.Control_Label.Name = "Control_Label";
            this.Control_Label.Size = new System.Drawing.Size(94, 16);
            this.Control_Label.TabIndex = 13;
            this.Control_Label.Text = "Control is off";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 474);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.PanelForSettings);
            this.Name = "Form1";
            this.Text = "Conway";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.PanelForSettings.ResumeLayout(false);
            this.PanelForSettings.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel PanelForSettings;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Label TcycleCoincidenceLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AveragePopulationLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExportPopDataBtn;
        private System.Windows.Forms.Label Control_Label;
    }
}

