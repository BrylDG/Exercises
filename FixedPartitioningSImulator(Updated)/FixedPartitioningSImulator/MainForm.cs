using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FixedPartitioningSimulator
{
    public partial class MainForm : Form
    {
        private const int OS_MEMORY_SIZE = 1500;
        private int memorySize;
        private int processesCount;
        private int clock = 0;

        private List<Process> processes = new List<Process>();
        private List<Partition> partitions = new List<Partition>();

        private List<TextBox> memorySizeTextBoxes = new List<TextBox>();
        private List<TextBox> arrivalTimeTextBoxes = new List<TextBox>();
        private List<TextBox> runTimeTextBoxes = new List<TextBox>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void generateProcessesButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(processesCountTextBox.Text, out processesCount))
            {
                dynamicPanel.Controls.Clear();
                memorySizeTextBoxes.Clear();
                arrivalTimeTextBoxes.Clear();
                runTimeTextBoxes.Clear();

                for (int i = 0; i < processesCount; i++)
                {
                    var memoryLabel = new Label
                    {
                        Text = $"Memory Size (P{i + 1}):",
                        AutoSize = true
                    };
                    var memoryTextBox = new TextBox
                    {
                        Name = $"memorySizeTextBox{i}",
                        Width = 50
                    };
                    memorySizeTextBoxes.Add(memoryTextBox);

                    var arrivalLabel = new Label
                    {
                        Text = $"Arrival Time (P{i + 1}):",
                        AutoSize = true
                    };
                    var arrivalTextBox = new TextBox
                    {
                        Name = $"arrivalTimeTextBox{i}",
                        Width = 50
                    };
                    arrivalTimeTextBoxes.Add(arrivalTextBox);

                    var runLabel = new Label
                    {
                        Text = $"Run Time (P{i + 1}):",
                        AutoSize = true
                    };
                    var runTextBox = new TextBox
                    {
                        Name = $"runTimeTextBox{i}",
                        Width = 50
                    };
                    runTimeTextBoxes.Add(runTextBox);

                    dynamicPanel.Controls.Add(memoryLabel);
                    dynamicPanel.Controls.Add(memoryTextBox);
                    dynamicPanel.Controls.Add(arrivalLabel);
                    dynamicPanel.Controls.Add(arrivalTextBox);
                    dynamicPanel.Controls.Add(runLabel);
                    dynamicPanel.Controls.Add(runTextBox);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the number of processes.");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(memorySizeTextBox.Text, out memorySize) &&
                processesCount > 0 &&
                ValidateProcessInputs())
            {
                InitializeMemory();
                InitializeProcesses();
                simulationTimer.Start();
            }
            else
            {
                MessageBox.Show("Please ensure all inputs are valid.");
            }
        }

        private bool ValidateProcessInputs()
        {
            for (int i = 0; i < processesCount; i++)
            {
                if (!int.TryParse(memorySizeTextBoxes[i].Text, out _) ||
                    !int.TryParse(arrivalTimeTextBoxes[i].Text, out _) ||
                    !int.TryParse(runTimeTextBoxes[i].Text, out _))
                {
                    return false;
                }
            }
            return true;
        }

        private void InitializeMemory()
        {
            int availableMemory = memorySize - OS_MEMORY_SIZE;
            partitions.Clear();
            partitions.Add(new Partition { Size = OS_MEMORY_SIZE, Occupied = true, Process = Process.CreateOSProcess(OS_MEMORY_SIZE) });

            for (int i = 0; i < processesCount; i++)
            {
                partitions.Add(new Partition { Size = availableMemory / processesCount, Occupied = false });
            }
            DrawMemory();
        }

        private void InitializeProcesses()
        {
            processes.Clear();
            for (int i = 0; i < processesCount; i++)
            {
                processes.Add(new Process
                {
                    MemorySize = int.Parse(memorySizeTextBoxes[i].Text),
                    ArrivalTime = int.Parse(arrivalTimeTextBoxes[i].Text),
                    RunTime = int.Parse(runTimeTextBoxes[i].Text)
                });
            }
        }

        private void simulationTimer_Tick(object sender, EventArgs e)
        {
            clock++;
            timerLabel.Text = $"Time: {clock}s";

            foreach (var process in processes)
            {
                if (process.ArrivalTime == clock)
                {
                    AllocateMemory(process);
                }

                if (process.FinishTime == clock)
                {
                    ReleaseMemory(process);
                }
            }

            DrawMemory();

            if (AllProcessesCompleted())
            {
                simulationTimer.Stop();
                MessageBox.Show("All processes have completed.");
                ResetSimulation();
            }
        }

        private bool AllProcessesCompleted()
        {
            return processes.All(p => p.FinishTime <= clock);
        }

        private void AllocateMemory(Process process)
        {
            foreach (var partition in partitions)
            {
                if (!partition.Occupied && partition.Size >= process.MemorySize)
                {
                    partition.Occupied = true;
                    partition.Process = process;
                    process.StartTime = clock;
                    process.FinishTime = clock + process.RunTime;
                    break;
                }
            }
        }

        private void ReleaseMemory(Process process)
        {
            foreach (var partition in partitions)
            {
                if (partition.Process == process)
                {
                    partition.Occupied = false;
                    partition.Process = null;
                    break;
                }
            }
        }

        private void DrawMemory()
        {
            memoryPanel.Controls.Clear();
            int partitionHeight = memoryPanel.Height / partitions.Count;

            for (int i = 0; i < partitions.Count; i++)
            {
                var partition = partitions[i];
                var partitionLabel = new Label
                {
                    Text = partition.Occupied ? (partition.Process.Id == 0 ? "OS" : $"P{partition.Process.Id}") : "Free",
                    Size = new Size(memoryPanel.Width, partitionHeight),
                    Location = new Point(0, i * partitionHeight),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = partition.Occupied ? (partition.Process.Id == 0 ? Color.Blue : Color.Red) : Color.Green,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                memoryPanel.Controls.Add(partitionLabel);
            }
        }

        private void ResetSimulation()
        {
            clock = 0;
            memorySize = 0;
            processesCount = 0;
            processes.Clear();
            partitions.Clear();
            memorySizeTextBox.Clear();
            processesCountTextBox.Clear();
            dynamicPanel.Controls.Clear();
            memoryPanel.Controls.Clear();
            timerLabel.Text = "Time: 0s";
        }

        private class Process
        {
            private static int counter = 0;
            public int Id { get; private set; }
            public int MemorySize { get; set; }
            public int ArrivalTime { get; set; }
            public int RunTime { get; set; }
            public int StartTime { get; set; }
            public int FinishTime { get; set; }

            public Process()
            {
                Id = ++counter;
            }

            public static Process CreateOSProcess(int osMemorySize)
            {
                return new Process
                {
                    Id = 0,
                    MemorySize = osMemorySize,
                    ArrivalTime = 0,
                    RunTime = int.MaxValue // OS runs indefinitely
                };
            }
        }

        private class Partition
        {
            public int Size { get; set; }
            public bool Occupied { get; set; }
            public Process Process { get; set; }
        }
    }
}
