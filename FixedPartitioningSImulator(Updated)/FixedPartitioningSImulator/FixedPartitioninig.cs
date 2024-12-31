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
            int memorySizeValue;
            int processCountValue;

            if (String.IsNullOrEmpty(MemorySizeBox.Text) || !int.TryParse(MemorySizeBox.Text, out memorySizeValue) || memorySizeValue < 1000 || memorySizeValue > 5000)
            {
                MemorySizeBox.Text = "";
                MessageBox.Show("Minimum Memory: 1000kb \n Maximum Memory: 5000kb.");
            }
            else if (String.IsNullOrEmpty(ProcessCountBox.Text) || !int.TryParse(ProcessCountBox.Text, out processCountValue) || processCountValue < 5 || processCountValue > 10)
            {
                ProcessCountBox.Text = "";
                MessageBox.Show("Minimum Processes: 5 \n Maximum Processes: 10.");
            }
            else
            {
                memorySize = memorySizeValue;
                processNum = processCountValue;
                processArray = new int[processNum][];
                InitializeArrays();
                CreateProcessInputFields();
                GeneratePartitions();
                CreateMemoryPanels();
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (InsertInputsIntoProcessArray())
            {
                SortProcessArrayByArrivalTime();
                InitializeSimulationArrays();
                AllocateInitialProcesses();
                InitializeTimer();
            }
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
            int value;

            if (textBox.Name.StartsWith("MemSizeTextBox", StringComparison.OrdinalIgnoreCase))
            {
                if (int.TryParse(textBox.Text, out value) && !textBox.Text.EndsWith("kb", StringComparison.OrdinalIgnoreCase))
                {
                    textBox.Text += "kb";
                }
            }
            else
            {
                if (int.TryParse(textBox.Text, out value) && !textBox.Text.EndsWith("msec", StringComparison.OrdinalIgnoreCase))
                {
                    textBox.Text += "msec";
                }
            }
        }

        private void CreateMemoryPanels()
        {
            MemoryPanel.Controls.Clear();
            int panelHeight = MemoryPanel.Height / processNum;
            Color panelColor = Color.FromArgb(119, 141, 169);
            for (int i = 0; i < processNum; i++)
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
                    MessageBox.Show("Please enter non-negative values for all fields.");
                    return false;
                }

                processArray[i][0] = i + 1;
                processArray[i][1] = memSize;
                processArray[i][2] = arrivalTime;
                processArray[i][3] = runTime;
            }
            return true;
        }

        private void SortProcessArrayByArrivalTime()
        {
            Array.Sort(processArray, (x, y) => x[2].CompareTo(y[2]));
        }

        private void AllocateInitialProcesses()
        {
            for (int i = 0; i < processNum; i++)
            {
                if (processArray[i][2] == 0)
                {
                    AllocateProcess(i);
                }
            }
        }

        private void RunSimulationStep()
        {
            for (int i = 0; i < processNum; i++)
            {
                if (counter == processArray[i][2])
                {
                    if (!AllocateProcess(i))
                    {
                        waitingArray[currentWaitingIndex] = i;
                        currentWaitingIndex++;
                    }
                }
                if (counter == simulationArray[i])
                {
                    DeallocateProcess(i);
                }
            }
            for (int j = 0; j < currentWaitingIndex; j++)
            {
                if (waitingArray[j] != -1 && AllocateProcess(waitingArray[j]))
                {
                    waitingArray[j] = -1;
                }
            }
        }

        private void GeneratePartitions()
        {
            int availableMemory = memorySize - OSMemory;
            partitionSize = availableMemory / processNum;
            partitions = new int[processNum];
            for (int i = 0; i < processNum; i++)
            {
                partitions[i] = partitionSize;
            }
        }

        private bool AllocateProcess(int index)
        {
            for (int j = 0; j < processNum; j++)
            {
                if (partitions[j] >= processArray[index][1] && !IsPartitionAllocated(j))
                {
                    partitions[j] -= processArray[index][1];
                    Panel partitionPanel = (Panel)MemoryPanel.Controls["PartitionPanel" + j];
                    partitionPanel.Controls.Clear();
                    Label processLabel = new Label
                    {
                        Text = "P" + processArray[index][0],
                        BackColor = Color.Transparent,
                        ForeColor = Color.White,
                        AutoSize = true,
                        Location = new Point(partitionPanel.Width / 2 - 20, partitionPanel.Height / 2 - 10)
                    };
                    partitionPanel.Controls.Add(processLabel);
                    simulationArray[index] = counter + processArray[index][3];
                    return true;
                }
            }
            return false;
        }

        private void DeallocateProcess(int index)
        {
            for (int j = 0; j < processNum; j++)
            {
                if (MemoryPanel.Controls["PartitionPanel" + j].Controls.OfType<Label>().Any(l => l.Text == "P" + processArray[index][0]))
                {
                    partitions[j] += processArray[index][1];
                    Panel partitionPanel = (Panel)MemoryPanel.Controls["PartitionPanel" + j];
                    partitionPanel.Controls.Clear();
                    Label freeLabel = new Label
                    {
                        Text = "Free",
                        BackColor = Color.Transparent,
                        ForeColor = Color.White,
                        AutoSize = true,
                        Location = new Point(partitionPanel.Width / 2 - 20, partitionPanel.Height / 2 - 10)
                    };
                    partitionPanel.Controls.Add(freeLabel);
                    simulationArray[index] = -1;
                    break;
                }
            }
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

            overlayPanels.Clear();
        }

        private bool IsPartitionAllocated(int partitionIndex)
        {
            return MemoryPanel.Controls["PartitionPanel" + partitionIndex].Controls.OfType<Label>().Any(l => l.Text.StartsWith("P"));
        }
    }
}
