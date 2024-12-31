using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedPartitioningSImulator
{
    public partial class FixedPartitioninig : Form
    {
        int memorySize;
        int processNum;
        int partitionSize;
        int[][] processArray;
        int[] simulationArray;
        int[] waitingArray;
        int[] partitions;
        int partitionCount = new Random().Next(3,10);
        int OSMemory = 100;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int counter = 0;
        int currentWaitingIndex = 0;
        Dictionary<int, Panel> overlayPanels = new Dictionary<int, Panel>();

        public FixedPartitioninig()
        {
            InitializeComponent();
            this.Load += FixedPartitioninig_Load;
        }

        private void FixedPartitioninig_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.FromArgb(27, 38, 59), 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void InitializeTimer()
        {
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            UpdateTickTockLabel();
            RunSimulationStep();
        }

        private void UpdateTickTockLabel()
        {
            if (TickTockLabel.InvokeRequired)
            {
                TickTockLabel.Invoke(new Action(UpdateTickTockLabel));
            }
            else
            {
                TickTockLabel.Text = counter.ToString();
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(MemorySizeBox.Text, out int memoryInput) || memoryInput > 5000 || memoryInput < 1000)
            {
                MemorySizeBox.Text = "";
                MessageBox.Show("Minimum Memory: 1000kb \n Maximum Memory: 5000kb.");
                return;
            }

            if (!int.TryParse(ProcessCountBox.Text, out int processInput) || processInput > 10 || processInput < 3)
            {
                ProcessCountBox.Text = "";
                MessageBox.Show("Minimum Processes: 3 \n Maximum Processes: 10.");
                return;
            }

            memorySize = memoryInput;
            processNum = processInput;
            processArray = new int[processNum][];
            InitializeArrays();
            CreateProcessInputFields();
            GeneratePartitions();
            CreateMemoryPanels();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!InsertInputsIntoProcessArray())
            {
                return;
            }
            SortProcessArrayByArrivalTime();
            InitializeSimulationArrays();
            AllocateInitialProcesses();
            InitializeTimer();
        }

        private void InitializeArrays()
        {
            for (int i = 0; i < processNum; i++)
            {
                processArray[i] = new int[4];
            }
        }

        private void InitializeSimulationArrays()
        {
            simulationArray = new int[processNum];
            waitingArray = new int[processNum * 2];
            for (int i = 0; i < processNum; i++)
            {
                simulationArray[i] = -1;
            }
            for (int i = 0; i < waitingArray.Length; i++)
            {
                waitingArray[i] = -1;
            }
        }

        private void CreateProcessInputFields()
        {
            InputSectionBox.Controls.Clear();

            for (int i = 0; i < processNum; i++)
            {
                int verticalOffset = 30 * i;

                Label memSizeLabel = new Label
                {
                    Text = "Memory Size for P" + (i + 1) + ":",
                    Location = new Point(10, verticalOffset),
                    AutoSize = true
                };
                InputSectionBox.Controls.Add(memSizeLabel);

                TextBox memSizeTextBox = new TextBox
                {
                    Name = "MemSizeTextBox" + i,
                    Location = new Point(150, verticalOffset)
                };
                memSizeTextBox.Leave += AddKBToTextbox;
                InputSectionBox.Controls.Add(memSizeTextBox);

                Label arrivalTimeLabel = new Label
                {
                    Text = "Arrival Time for P" + (i + 1) + ":",
                    Location = new Point(300, verticalOffset),
                    AutoSize = true
                };
                InputSectionBox.Controls.Add(arrivalTimeLabel);

                TextBox arrivalTimeTextBox = new TextBox
                {
                    Name = "ArrivalTimeTextBox" + i,
                    Location = new Point(450, verticalOffset)
                };
                arrivalTimeTextBox.Leave += AddKBToTextbox;
                InputSectionBox.Controls.Add(arrivalTimeTextBox);

                Label runTimeLabel = new Label
                {
                    Text = "Run Time for P" + (i + 1) + ":",
                    Location = new Point(600, verticalOffset),
                    AutoSize = true
                };
                InputSectionBox.Controls.Add(runTimeLabel);

                TextBox runTimeTextBox = new TextBox
                {
                    Name = "RunTimeTextBox" + i,
                    Location = new Point(750, verticalOffset)
                };
                runTimeTextBox.Leave += AddKBToTextbox;
                InputSectionBox.Controls.Add(runTimeTextBox);
            }
        }

        private void AddKBToTextbox(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Name.StartsWith("MemSizeTextBox", StringComparison.OrdinalIgnoreCase))
            {
                if (!textBox.Text.EndsWith("kb", StringComparison.OrdinalIgnoreCase))
                {
                    textBox.Text += "kb";
                }
            }
            else
            {
                if (!textBox.Text.EndsWith("msec", StringComparison.OrdinalIgnoreCase))
                {
                    textBox.Text += "msec";
                }
            }
        }

        private void CreateMemoryPanels()
        {
            MemoryPanel.Controls.Clear();
            int panelHeight = MemoryPanel.Height / partitionCount;
            Color panelColor = Color.FromArgb(119, 141, 169);
            for (int i = 0; i < partitionCount; i++)
            {
                Panel partitionPanel = new Panel
                {
                    Name = "PartitionPanel" + i,
                    Size = new Size(MemoryPanel.Width, panelHeight),
                    Location = new Point(0, i * panelHeight),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = panelColor
                };
                Label freeLabel = new Label
                {
                    Text = "Free",
                    Name = "FreeLabel" + i,
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    AutoSize = true,
                    Location = new Point(partitionPanel.Width / 2 - 20, panelHeight / 2 - 10)
                };
                partitionPanel.Controls.Add(freeLabel);
                MemoryPanel.Controls.Add(partitionPanel);
                Label partitionSizeLabel = new Label
                {
                    Text = partitions[i] + "kb",
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    Location = new Point(MemoryPanel.Right + 10, MemoryPanel.Top + i * panelHeight + panelHeight / 2 - 10)
                };
                this.Controls.Add(partitionSizeLabel);
            }
        }

        private bool InsertInputsIntoProcessArray()
        {
            for (int i = 0; i < processNum; i++)
            {
                TextBox memSizeTextBox = (TextBox)InputSectionBox.Controls["MemSizeTextBox" + i];
                TextBox arrivalTimeTextBox = (TextBox)InputSectionBox.Controls["ArrivalTimeTextBox" + i];
                TextBox runTimeTextBox = (TextBox)InputSectionBox.Controls["RunTimeTextBox" + i];

                if (!int.TryParse(memSizeTextBox.Text.Replace("kb", ""), out int memSize) || memSize < 0 ||
                    !int.TryParse(arrivalTimeTextBox.Text.Replace("msec", ""), out int arrivalTime) || arrivalTime < 0 ||
                    !int.TryParse(runTimeTextBox.Text.Replace("msec", ""), out int runTime) || runTime < 0)
                {
                    MessageBox.Show("Invalid input detected. Please enter valid positive numbers.");
                    return false;
                }

                processArray[i][0] = i + 1;
                processArray[i][1] = memSize;
                processArray[i][2] = arrivalTime;
                processArray[i][3] = runTime;

                ProcessLabel.Text += $"P{processArray[i][0]} initialized\n";
            }
            return true;
        }

        private void SortProcessArrayByArrivalTime()
        {
            Array.Sort(processArray, (x, y) => x[2].CompareTo(y[2]));
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Process Array Order:");
            for (int i = 0; i < processNum; i++)
            {
                stringBuilder.AppendLine($"Process {processArray[i][0]}: Memory Size - {processArray[i][1]}kb, Arrival Time - {processArray[i][2]}, Run Time - {processArray[i][3]}");
            }
            ListLabel.Text = stringBuilder.ToString();
        }

        private void GeneratePartitions()
        {
            memorySize -= OSMemory;
            partitionSize = memorySize / partitionCount;
            partitions = new int[partitionCount];
            for (int i = 0; i < partitionCount; i++)
            {
                partitions[i] = partitionSize;
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Partitions:");
            for (int i = 0; i < partitions.Length; i++)
            {
                stringBuilder.AppendLine($"Partition {i + 1}: {partitions[i]}kb");
            }
            PartitionLabel.Text = stringBuilder.ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            counter = 0;
            UpdateTickTockLabel();

            MemorySizeBox.Text = "";
            ProcessCountBox.Text = "";
            ProcessLabel.Text = "";
            WaitingListLabel.Text = "";

            InputSectionBox.Controls.Clear();
            MemoryPanel.Controls.Clear();

            var labelsToRemove = new List<Control>();
            foreach (Control control in this.Controls)
            {
                if (control is Label && control != TickTockLabel && control != ListLabel && control != PartitionLabel && control != label6)
                {
                    labelsToRemove.Add(control);
                }
            }
            foreach (var label in labelsToRemove)
            {
                this.Controls.Remove(label);
            }

            ListLabel.Text = "";
            PartitionLabel.Text = "";
            partitionCount = new Random().Next(3, 10);
            overlayPanels.Clear();
        }

        private void RunSimulationStep()
        {
            bool anyProcessLeft = false;
            bool allTerminated = true;

            for (int i = 0; i < processNum; i++)
            {
                int processId = processArray[i][0];
                int memorySize = processArray[i][1];
                int arrivalTime = processArray[i][2];
                int runTime = processArray[i][3];

                if (counter == runTime)
                {
                    TerminateProcess(processId);
                }

                if (counter == arrivalTime)
                {
                    if (memorySize > partitionSize)
                    {
                        if (currentWaitingIndex < waitingArray.Length)
                        {
                            waitingArray[currentWaitingIndex++] = processId;
                            ProcessLabel.Text += $"P{processId} transferred to waiting list\n";
                        }
                        else
                        {
                            MessageBox.Show("Waiting array is full. Cannot add more processes to the waiting queue.");
                        }
                    }
                    else
                    {
                        AllocateProcess(processId, memorySize);
                    }
                }

                if (arrivalTime <= counter && counter < runTime)
                {
                    anyProcessLeft = true;
                }

                if (counter < runTime)
                {
                    allTerminated = false;
                }
            }

            for (int i = 0; i < currentWaitingIndex; i++)
            {
                int processId = waitingArray[i];

                if (processId != -1 && processArray.Any(p => p[0] == processId))
                {
                    var process = processArray.First(p => p[0] == processId);
                    int memorySize = process[1];

                    if (memorySize <= partitionSize)
                    {
                        for (int j = i; j < currentWaitingIndex - 1; j++)
                        {
                            waitingArray[j] = waitingArray[j + 1];
                        }
                        waitingArray[--currentWaitingIndex] = -1;

                        AllocateProcess(processId, memorySize);
                    }
                }
            }

            if (!anyProcessLeft)
            {
                if (allTerminated || currentWaitingIndex == 0)
                {
                    timer.Stop();
                    TickTockLabel.Text = "0";
                    MessageBox.Show("All processes have been successfully accommodated and completed.");
                }
            }
            UpdateWaitingListLabel();
        }


        private void AllocateProcess(int processId, int memorySize)
        {
            for (int i = 0; i < simulationArray.Length; i++)
            {
                if (simulationArray[i] == -1)
                {
                    simulationArray[i] = processId;
                    UpdatePartitionPanel(processId, memorySize, i);
                    ProcessLabel.Text += $"P{processId} allocated:{memorySize}kb\n";
                    break;
                }
            }
            UpdateWaitingListLabel();
        }

        private void UpdateWaitingListLabel()
        {
            StringBuilder waitingListText = new StringBuilder();
            waitingListText.AppendLine("Waiting List:");
            for (int i = 0; i < currentWaitingIndex; i++)
            {
                int processId = waitingArray[i];
                if (processId != -1)
                {
                    waitingListText.AppendLine($"Process {processId}");
                }
            }
            WaitingListLabel.Text = waitingListText.ToString();
        }

        private void TerminateProcess(int processId)
        {
            for (int i = 0; i < simulationArray.Length; i++)
            {
                if (simulationArray[i] == processId)
                {
                    simulationArray[i] = -1;
                    ResetPartitionPanel(i);
                    ProcessLabel.Text += $"P{processId} completed\n";
                    break;
                }
            }
        }

        private void UpdatePartitionPanel(int processId, int memorySize, int index)
        {
            double percentage = (double)memorySize / partitionSize * 100;
            int panelHeight = MemoryPanel.Height / partitionCount;

            Panel processPanel = new Panel
            {
                Size = new Size(MemoryPanel.Width, (int)(panelHeight * percentage / 100)),
                Location = new Point(0, index * panelHeight),
                BackColor = Color.LightGreen,
                Name = "OverlayPanel" + index
            };

            Label processLabel = new Label
            {
                Text = $"P{processId} ({memorySize}kb)",
                AutoSize = true,
                Location = new Point(processPanel.Width / 2 - 30, processPanel.Height / 2 - 10)
            };

            processPanel.Controls.Add(processLabel);
            MemoryPanel.Controls.Add(processPanel);
            MemoryPanel.Controls.SetChildIndex(processPanel, 0);
            overlayPanels[index] = processPanel;
        }

        private void ResetPartitionPanel(int index)
        {
            if (overlayPanels.TryGetValue(index, out Panel processPanel))
            {
                processPanel.Dispose();
                overlayPanels.Remove(index);
                Panel partitionPanel = (Panel)MemoryPanel.Controls["PartitionPanel" + index];
                partitionPanel.Controls.Clear();
                Label freeLabel = new Label
                {
                    Text = "Free",
                    Name = "FreeLabel" + index,
                    AutoSize = true,
                    Location = new Point(partitionPanel.Width / 2 - 20, partitionPanel.Height / 2 - 10)
                };
                partitionPanel.Controls.Add(freeLabel);
                partitionPanel.BackColor = Color.FromArgb(119, 141, 169);
                partitionPanel.ForeColor = Color.White;
            }
        }

        private void AllocateInitialProcesses()
        {
            for (int i = 0; i < processNum; i++)
            {
                int processId = processArray[i][0];
                int memorySize = processArray[i][1];
                int arrivalTime = processArray[i][2];

                if (arrivalTime == 0)
                {
                    if (memorySize <= partitionSize)
                    {
                        AllocateProcess(processId, memorySize);
                    }
                    else
                    {
                        waitingArray[currentWaitingIndex++] = processId;
                    }
                }
            }
        }

        private void InputSectionBox_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(panel.ClientRectangle, Color.White, panel.BackColor, 90F))
                {
                    e.Graphics.FillRectangle(brush, panel.ClientRectangle);
                }
            }
        }
    }
}
