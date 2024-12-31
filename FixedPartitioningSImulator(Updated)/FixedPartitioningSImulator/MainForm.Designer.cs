using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FixedPartitioningSimulator
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            memorySizeLabel = new Label();
            memorySizeTextBox = new TextBox();
            processesCountLabel = new Label();
            processesCountTextBox = new TextBox();
            generateProcessesButton = new Button();
            dynamicPanel = new FlowLayoutPanel();
            startButton = new Button();
            memoryPanel = new Panel();
            timerLabel = new Label();
            simulationTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // memorySizeLabel
            // 
            memorySizeLabel.AutoSize = true;
            memorySizeLabel.Location = new Point(12, 15);
            memorySizeLabel.Name = "memorySizeLabel";
            memorySizeLabel.Size = new Size(78, 15);
            memorySizeLabel.TabIndex = 0;
            memorySizeLabel.Text = "Memory Size:";
            // 
            // memorySizeTextBox
            // 
            memorySizeTextBox.Location = new Point(120, 12);
            memorySizeTextBox.Name = "memorySizeTextBox";
            memorySizeTextBox.Size = new Size(100, 23);
            memorySizeTextBox.TabIndex = 1;
            // 
            // processesCountLabel
            // 
            processesCountLabel.AutoSize = true;
            processesCountLabel.Location = new Point(12, 45);
            processesCountLabel.Name = "processesCountLabel";
            processesCountLabel.Size = new Size(100, 15);
            processesCountLabel.TabIndex = 2;
            processesCountLabel.Text = "Number of Procs:";
            // 
            // processesCountTextBox
            // 
            processesCountTextBox.Location = new Point(120, 42);
            processesCountTextBox.Name = "processesCountTextBox";
            processesCountTextBox.Size = new Size(100, 23);
            processesCountTextBox.TabIndex = 3;
            // 
            // generateProcessesButton
            // 
            generateProcessesButton.Location = new Point(240, 40);
            generateProcessesButton.Name = "generateProcessesButton";
            generateProcessesButton.Size = new Size(100, 23);
            generateProcessesButton.TabIndex = 10;
            generateProcessesButton.Text = "Generate Inputs";
            generateProcessesButton.UseVisualStyleBackColor = true;
            generateProcessesButton.Click += generateProcessesButton_Click;
            // 
            // dynamicPanel
            // 
            dynamicPanel.Location = new Point(15, 75);
            dynamicPanel.Name = "dynamicPanel";
            dynamicPanel.Size = new Size(380, 398);
            dynamicPanel.TabIndex = 11;
            // 
            // startButton
            // 
            startButton.Location = new Point(561, 40);
            startButton.Name = "startButton";
            startButton.Size = new Size(100, 23);
            startButton.TabIndex = 12;
            startButton.Text = "Start Simulation";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // memoryPanel
            // 
            memoryPanel.BorderStyle = BorderStyle.FixedSingle;
            memoryPanel.Location = new Point(410, 75);
            memoryPanel.Name = "memoryPanel";
            memoryPanel.Size = new Size(580, 398);
            memoryPanel.TabIndex = 13;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Location = new Point(410, 48);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(50, 15);
            timerLabel.TabIndex = 14;
            timerLabel.Text = "Time: 0s";
            // 
            // simulationTimer
            // 
            simulationTimer.Interval = 1000;
            simulationTimer.Tick += simulationTimer_Tick;
            // 
            // MainForm
            // 
            ClientSize = new Size(1000, 500);
            Controls.Add(timerLabel);
            Controls.Add(memoryPanel);
            Controls.Add(startButton);
            Controls.Add(dynamicPanel);
            Controls.Add(generateProcessesButton);
            Controls.Add(processesCountTextBox);
            Controls.Add(processesCountLabel);
            Controls.Add(memorySizeTextBox);
            Controls.Add(memorySizeLabel);
            Name = "MainForm";
            Text = "Fixed Partitioning Simulator";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label memorySizeLabel;
        private System.Windows.Forms.TextBox memorySizeTextBox;
        private System.Windows.Forms.Label processesCountLabel;
        private System.Windows.Forms.TextBox processesCountTextBox;
        private System.Windows.Forms.Button generateProcessesButton;
        private System.Windows.Forms.FlowLayoutPanel dynamicPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel memoryPanel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer simulationTimer;
    }
}
