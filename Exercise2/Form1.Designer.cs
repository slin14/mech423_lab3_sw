
namespace Exercise2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.DCMotor = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonEx2DCEStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEx2DCPWM = new System.Windows.Forms.TextBox();
            this.trackBarEx2DCPWM = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonStepperRightStep = new System.Windows.Forms.Button();
            this.buttonStepperLeftStep = new System.Windows.Forms.Button();
            this.buttonStepperStop = new System.Windows.Forms.Button();
            this.textBoxStepperStepsPerSecond = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarStepperVelocityControl = new System.Windows.Forms.TrackBar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chartEx4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonEx4ResetPosition = new System.Windows.Forms.Button();
            this.buttonEx4DCEStop = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxEx4DCPWM = new System.Windows.Forms.TextBox();
            this.trackBarEx4DCPWM = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLinearVelocity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLinearPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEncoderRPM = new System.Windows.Forms.TextBox();
            this.textBoxEncoderHz = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonEx5Move = new System.Windows.Forms.Button();
            this.textBoxEx5XPosition = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.buttonEx5EStop = new System.Windows.Forms.Button();
            this.buttonEx5StartStepRun = new System.Windows.Forms.Button();
            this.textBoxEx5FileName = new System.Windows.Forms.TextBox();
            this.checkBoxEx5SaveToFile = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxEx5RunLength = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxEx5DCPWM = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonEx6Move = new System.Windows.Forms.Button();
            this.textBoxEx6Velocity = new System.Windows.Forms.TextBox();
            this.textBoxEx6YPosition = new System.Windows.Forms.TextBox();
            this.textBoxEx6XPosition = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonSerial = new System.Windows.Forms.Button();
            this.comboBoxCOMPorts = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timerSerialPort = new System.Windows.Forms.Timer(this.components);
            this.textBoxSerialDataStream = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDebugOutput1 = new System.Windows.Forms.TextBox();
            this.txtDebugOutput2 = new System.Windows.Forms.TextBox();
            this.txtDebugOutput3 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.DCMotor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEx2DCPWM)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStepperVelocityControl)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEx4DCPWM)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.DCMotor);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(244, 12);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(981, 524);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // DCMotor
            // 
            this.DCMotor.Controls.Add(this.label14);
            this.DCMotor.Controls.Add(this.label13);
            this.DCMotor.Controls.Add(this.buttonEx2DCEStop);
            this.DCMotor.Controls.Add(this.label2);
            this.DCMotor.Controls.Add(this.label1);
            this.DCMotor.Controls.Add(this.textBoxEx2DCPWM);
            this.DCMotor.Controls.Add(this.trackBarEx2DCPWM);
            this.DCMotor.Location = new System.Drawing.Point(4, 25);
            this.DCMotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DCMotor.Name = "DCMotor";
            this.DCMotor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DCMotor.Size = new System.Drawing.Size(973, 495);
            this.DCMotor.TabIndex = 0;
            this.DCMotor.Text = "Ex. 2: DC Motor Control";
            this.DCMotor.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 112);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Gantry to Idler";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(757, 132);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Gantry to Motor";
            // 
            // buttonEx2DCEStop
            // 
            this.buttonEx2DCEStop.BackColor = System.Drawing.Color.Red;
            this.buttonEx2DCEStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEx2DCEStop.Location = new System.Drawing.Point(341, 96);
            this.buttonEx2DCEStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEx2DCEStop.Name = "buttonEx2DCEStop";
            this.buttonEx2DCEStop.Size = new System.Drawing.Size(89, 59);
            this.buttonEx2DCEStop.TabIndex = 4;
            this.buttonEx2DCEStop.Text = "E-STOP";
            this.buttonEx2DCEStop.UseVisualStyleBackColor = false;
            this.buttonEx2DCEStop.Click += new System.EventHandler(this.buttonDCEmergencyStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "PWM Percentage";
            // 
            // textBoxEx2DCPWM
            // 
            this.textBoxEx2DCPWM.Location = new System.Drawing.Point(341, 70);
            this.textBoxEx2DCPWM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEx2DCPWM.Name = "textBoxEx2DCPWM";
            this.textBoxEx2DCPWM.Size = new System.Drawing.Size(89, 22);
            this.textBoxEx2DCPWM.TabIndex = 1;
            this.textBoxEx2DCPWM.TextChanged += new System.EventHandler(this.textBoxPWMPercentage_TextChanged);
            // 
            // trackBarEx2DCPWM
            // 
            this.trackBarEx2DCPWM.Location = new System.Drawing.Point(5, 6);
            this.trackBarEx2DCPWM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarEx2DCPWM.Maximum = 100;
            this.trackBarEx2DCPWM.Minimum = -100;
            this.trackBarEx2DCPWM.Name = "trackBarEx2DCPWM";
            this.trackBarEx2DCPWM.Size = new System.Drawing.Size(756, 56);
            this.trackBarEx2DCPWM.TabIndex = 0;
            this.trackBarEx2DCPWM.TabStop = false;
            this.trackBarEx2DCPWM.TickFrequency = 5;
            this.trackBarEx2DCPWM.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEx2DCPWM.Scroll += new System.EventHandler(this.trackBarVelocityControl_Scroll);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.buttonStepperRightStep);
            this.tabPage3.Controls.Add(this.buttonStepperLeftStep);
            this.tabPage3.Controls.Add(this.buttonStepperStop);
            this.tabPage3.Controls.Add(this.textBoxStepperStepsPerSecond);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.trackBarStepperVelocityControl);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(973, 495);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Ex. 3: Stepper Motor Control";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "Gantry to Idler";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(679, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Gantry to Motor";
            // 
            // buttonStepperRightStep
            // 
            this.buttonStepperRightStep.Location = new System.Drawing.Point(559, 70);
            this.buttonStepperRightStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStepperRightStep.Name = "buttonStepperRightStep";
            this.buttonStepperRightStep.Size = new System.Drawing.Size(100, 28);
            this.buttonStepperRightStep.TabIndex = 7;
            this.buttonStepperRightStep.Text = "> [ + ]";
            this.buttonStepperRightStep.UseVisualStyleBackColor = true;
            this.buttonStepperRightStep.Click += new System.EventHandler(this.buttonStepperRightStep_Click);
            // 
            // buttonStepperLeftStep
            // 
            this.buttonStepperLeftStep.Location = new System.Drawing.Point(360, 70);
            this.buttonStepperLeftStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStepperLeftStep.Name = "buttonStepperLeftStep";
            this.buttonStepperLeftStep.Size = new System.Drawing.Size(100, 28);
            this.buttonStepperLeftStep.TabIndex = 6;
            this.buttonStepperLeftStep.Text = "[ - ] <";
            this.buttonStepperLeftStep.UseVisualStyleBackColor = true;
            this.buttonStepperLeftStep.Click += new System.EventHandler(this.buttonStepperLeft_Click);
            // 
            // buttonStepperStop
            // 
            this.buttonStepperStop.BackColor = System.Drawing.Color.Red;
            this.buttonStepperStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStepperStop.Location = new System.Drawing.Point(468, 70);
            this.buttonStepperStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStepperStop.Name = "buttonStepperStop";
            this.buttonStepperStop.Size = new System.Drawing.Size(83, 28);
            this.buttonStepperStop.TabIndex = 5;
            this.buttonStepperStop.Text = "STOP";
            this.buttonStepperStop.UseVisualStyleBackColor = false;
            this.buttonStepperStop.Click += new System.EventHandler(this.buttonStepperStop_Click);
            // 
            // textBoxStepperStepsPerSecond
            // 
            this.textBoxStepperStepsPerSecond.Location = new System.Drawing.Point(453, 133);
            this.textBoxStepperStepsPerSecond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxStepperStepsPerSecond.Name = "textBoxStepperStepsPerSecond";
            this.textBoxStepperStepsPerSecond.Size = new System.Drawing.Size(117, 22);
            this.textBoxStepperStepsPerSecond.TabIndex = 4;
            this.textBoxStepperStepsPerSecond.TextChanged += new System.EventHandler(this.textBoxStepperStepsPerSecond_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Steps per Second";
            // 
            // trackBarStepperVelocityControl
            // 
            this.trackBarStepperVelocityControl.LargeChange = 100;
            this.trackBarStepperVelocityControl.Location = new System.Drawing.Point(4, 7);
            this.trackBarStepperVelocityControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarStepperVelocityControl.Maximum = 1000;
            this.trackBarStepperVelocityControl.Minimum = -1000;
            this.trackBarStepperVelocityControl.Name = "trackBarStepperVelocityControl";
            this.trackBarStepperVelocityControl.Size = new System.Drawing.Size(1008, 56);
            this.trackBarStepperVelocityControl.SmallChange = 10;
            this.trackBarStepperVelocityControl.TabIndex = 1;
            this.trackBarStepperVelocityControl.TabStop = false;
            this.trackBarStepperVelocityControl.TickFrequency = 100;
            this.trackBarStepperVelocityControl.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarStepperVelocityControl.Scroll += new System.EventHandler(this.trackBarStepperVelocityControl_Scroll);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chartEx4);
            this.tabPage4.Controls.Add(this.buttonEx4ResetPosition);
            this.tabPage4.Controls.Add(this.buttonEx4DCEStop);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.textBoxEx4DCPWM);
            this.tabPage4.Controls.Add(this.trackBarEx4DCPWM);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.textBoxLinearVelocity);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.textBoxLinearPosition);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBoxEncoderRPM);
            this.tabPage4.Controls.Add(this.textBoxEncoderHz);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(973, 495);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Ex. 4: Encoder Reader";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chartEx4
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEx4.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEx4.Legends.Add(legend1);
            this.chartEx4.Location = new System.Drawing.Point(12, 241);
            this.chartEx4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartEx4.Name = "chartEx4";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.Legend = "Legend1";
            series1.Name = "Position vs Time";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Velocity vs Time";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartEx4.Series.Add(series1);
            this.chartEx4.Series.Add(series2);
            this.chartEx4.Size = new System.Drawing.Size(756, 219);
            this.chartEx4.TabIndex = 16;
            this.chartEx4.Text = "chart1";
            // 
            // buttonEx4ResetPosition
            // 
            this.buttonEx4ResetPosition.Location = new System.Drawing.Point(527, 73);
            this.buttonEx4ResetPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEx4ResetPosition.Name = "buttonEx4ResetPosition";
            this.buttonEx4ResetPosition.Size = new System.Drawing.Size(151, 28);
            this.buttonEx4ResetPosition.TabIndex = 15;
            this.buttonEx4ResetPosition.Text = "Reset Position";
            this.buttonEx4ResetPosition.UseVisualStyleBackColor = true;
            this.buttonEx4ResetPosition.Click += new System.EventHandler(this.buttonEx4ResetPosition_Click);
            // 
            // buttonEx4DCEStop
            // 
            this.buttonEx4DCEStop.BackColor = System.Drawing.Color.Red;
            this.buttonEx4DCEStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEx4DCEStop.Location = new System.Drawing.Point(12, 212);
            this.buttonEx4DCEStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEx4DCEStop.Name = "buttonEx4DCEStop";
            this.buttonEx4DCEStop.Size = new System.Drawing.Size(75, 23);
            this.buttonEx4DCEStop.TabIndex = 14;
            this.buttonEx4DCEStop.Text = "E-STOP";
            this.buttonEx4DCEStop.UseVisualStyleBackColor = false;
            this.buttonEx4DCEStop.Click += new System.EventHandler(this.buttonEx4DCEStop_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "PWM Percentage";
            // 
            // textBoxEx4DCPWM
            // 
            this.textBoxEx4DCPWM.Location = new System.Drawing.Point(12, 182);
            this.textBoxEx4DCPWM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEx4DCPWM.Name = "textBoxEx4DCPWM";
            this.textBoxEx4DCPWM.Size = new System.Drawing.Size(89, 22);
            this.textBoxEx4DCPWM.TabIndex = 11;
            this.textBoxEx4DCPWM.TextChanged += new System.EventHandler(this.textBoxEx4DCPWM_TextChanged);
            // 
            // trackBarEx4DCPWM
            // 
            this.trackBarEx4DCPWM.Location = new System.Drawing.Point(12, 106);
            this.trackBarEx4DCPWM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarEx4DCPWM.Maximum = 100;
            this.trackBarEx4DCPWM.Minimum = -100;
            this.trackBarEx4DCPWM.Name = "trackBarEx4DCPWM";
            this.trackBarEx4DCPWM.Size = new System.Drawing.Size(756, 56);
            this.trackBarEx4DCPWM.TabIndex = 10;
            this.trackBarEx4DCPWM.TabStop = false;
            this.trackBarEx4DCPWM.TickFrequency = 5;
            this.trackBarEx4DCPWM.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEx4DCPWM.Scroll += new System.EventHandler(this.trackBarEx4DCPWM_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Relative Position (mm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Velocity (mm/s)";
            // 
            // textBoxLinearVelocity
            // 
            this.textBoxLinearVelocity.Location = new System.Drawing.Point(216, 43);
            this.textBoxLinearVelocity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLinearVelocity.Name = "textBoxLinearVelocity";
            this.textBoxLinearVelocity.ReadOnly = true;
            this.textBoxLinearVelocity.Size = new System.Drawing.Size(145, 22);
            this.textBoxLinearVelocity.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Linear Motion";
            // 
            // textBoxLinearPosition
            // 
            this.textBoxLinearPosition.Location = new System.Drawing.Point(216, 75);
            this.textBoxLinearPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLinearPosition.Name = "textBoxLinearPosition";
            this.textBoxLinearPosition.ReadOnly = true;
            this.textBoxLinearPosition.Size = new System.Drawing.Size(145, 22);
            this.textBoxLinearPosition.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "RPM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rotational Motion";
            // 
            // textBoxEncoderRPM
            // 
            this.textBoxEncoderRPM.Location = new System.Drawing.Point(12, 75);
            this.textBoxEncoderRPM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEncoderRPM.Name = "textBoxEncoderRPM";
            this.textBoxEncoderRPM.ReadOnly = true;
            this.textBoxEncoderRPM.Size = new System.Drawing.Size(145, 22);
            this.textBoxEncoderRPM.TabIndex = 1;
            // 
            // textBoxEncoderHz
            // 
            this.textBoxEncoderHz.Location = new System.Drawing.Point(12, 43);
            this.textBoxEncoderHz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEncoderHz.Name = "textBoxEncoderHz";
            this.textBoxEncoderHz.ReadOnly = true;
            this.textBoxEncoderHz.Size = new System.Drawing.Size(145, 22);
            this.textBoxEncoderHz.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDebugOutput3);
            this.tabPage1.Controls.Add(this.txtDebugOutput2);
            this.tabPage1.Controls.Add(this.txtDebugOutput1);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.buttonEx5Move);
            this.tabPage1.Controls.Add(this.textBoxEx5XPosition);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.buttonEx5EStop);
            this.tabPage1.Controls.Add(this.buttonEx5StartStepRun);
            this.tabPage1.Controls.Add(this.textBoxEx5FileName);
            this.tabPage1.Controls.Add(this.checkBoxEx5SaveToFile);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.textBoxEx5RunLength);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.textBoxEx5DCPWM);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(973, 495);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Ex. 5: Close Loop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(117, 266);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 17);
            this.label24.TabIndex = 27;
            this.label24.Text = "mm";
            // 
            // buttonEx5Move
            // 
            this.buttonEx5Move.Location = new System.Drawing.Point(171, 260);
            this.buttonEx5Move.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEx5Move.Name = "buttonEx5Move";
            this.buttonEx5Move.Size = new System.Drawing.Size(100, 28);
            this.buttonEx5Move.TabIndex = 26;
            this.buttonEx5Move.Text = "Go!";
            this.buttonEx5Move.UseVisualStyleBackColor = true;
            this.buttonEx5Move.Click += new System.EventHandler(this.buttonEx5Move_Click);
            // 
            // textBoxEx5XPosition
            // 
            this.textBoxEx5XPosition.Location = new System.Drawing.Point(11, 262);
            this.textBoxEx5XPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEx5XPosition.Name = "textBoxEx5XPosition";
            this.textBoxEx5XPosition.Size = new System.Drawing.Size(97, 22);
            this.textBoxEx5XPosition.TabIndex = 25;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 242);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(136, 17);
            this.label25.TabIndex = 23;
            this.label25.Text = "X Position (Relative)";
            // 
            // buttonEx5EStop
            // 
            this.buttonEx5EStop.BackColor = System.Drawing.Color.Red;
            this.buttonEx5EStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEx5EStop.Location = new System.Drawing.Point(11, 160);
            this.buttonEx5EStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEx5EStop.Name = "buttonEx5EStop";
            this.buttonEx5EStop.Size = new System.Drawing.Size(156, 28);
            this.buttonEx5EStop.TabIndex = 22;
            this.buttonEx5EStop.Text = "STOP";
            this.buttonEx5EStop.UseVisualStyleBackColor = false;
            this.buttonEx5EStop.Click += new System.EventHandler(this.buttonEx5EStop_Click);
            // 
            // buttonEx5StartStepRun
            // 
            this.buttonEx5StartStepRun.Location = new System.Drawing.Point(11, 124);
            this.buttonEx5StartStepRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEx5StartStepRun.Name = "buttonEx5StartStepRun";
            this.buttonEx5StartStepRun.Size = new System.Drawing.Size(156, 28);
            this.buttonEx5StartStepRun.TabIndex = 21;
            this.buttonEx5StartStepRun.Text = "Apply Step Input";
            this.buttonEx5StartStepRun.UseVisualStyleBackColor = true;
            this.buttonEx5StartStepRun.Click += new System.EventHandler(this.buttonEx5StartStepRun_Click);
            // 
            // textBoxEx5FileName
            // 
            this.textBoxEx5FileName.Location = new System.Drawing.Point(11, 92);
            this.textBoxEx5FileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEx5FileName.Name = "textBoxEx5FileName";
            this.textBoxEx5FileName.Size = new System.Drawing.Size(444, 22);
            this.textBoxEx5FileName.TabIndex = 20;
            // 
            // checkBoxEx5SaveToFile
            // 
            this.checkBoxEx5SaveToFile.AutoSize = true;
            this.checkBoxEx5SaveToFile.Location = new System.Drawing.Point(11, 66);
            this.checkBoxEx5SaveToFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEx5SaveToFile.Name = "checkBoxEx5SaveToFile";
            this.checkBoxEx5SaveToFile.Size = new System.Drawing.Size(109, 21);
            this.checkBoxEx5SaveToFile.TabIndex = 19;
            this.checkBoxEx5SaveToFile.Text = "Save To File";
            this.checkBoxEx5SaveToFile.UseVisualStyleBackColor = true;
            this.checkBoxEx5SaveToFile.CheckedChanged += new System.EventHandler(this.checkBoxEx5SaveToFile_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(275, 42);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 17);
            this.label20.TabIndex = 5;
            this.label20.Text = "mm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 42);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "Run Length (Relative) :";
            // 
            // textBoxEx5RunLength
            // 
            this.textBoxEx5RunLength.Location = new System.Drawing.Point(171, 38);
            this.textBoxEx5RunLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEx5RunLength.Name = "textBoxEx5RunLength";
            this.textBoxEx5RunLength.Size = new System.Drawing.Size(95, 22);
            this.textBoxEx5RunLength.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(275, 11);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(235, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "%, Positive (Gantry to Motor) ONLY!";
            // 
            // textBoxEx5DCPWM
            // 
            this.textBoxEx5DCPWM.Location = new System.Drawing.Point(171, 6);
            this.textBoxEx5DCPWM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEx5DCPWM.Name = "textBoxEx5DCPWM";
            this.textBoxEx5DCPWM.Size = new System.Drawing.Size(95, 22);
            this.textBoxEx5DCPWM.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 10);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Step Input PWM:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.buttonEx6Move);
            this.tabPage2.Controls.Add(this.textBoxEx6Velocity);
            this.tabPage2.Controls.Add(this.textBoxEx6YPosition);
            this.tabPage2.Controls.Add(this.textBoxEx6XPosition);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(973, 495);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Ex. 6: 2 Axis Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(123, 55);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(99, 28);
            this.progressBar2.TabIndex = 29;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 55);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(99, 28);
            this.progressBar1.TabIndex = 28;
            // 
            // buttonEx6Move
            // 
            this.buttonEx6Move.Location = new System.Drawing.Point(359, 21);
            this.buttonEx6Move.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEx6Move.Name = "buttonEx6Move";
            this.buttonEx6Move.Size = new System.Drawing.Size(100, 28);
            this.buttonEx6Move.TabIndex = 27;
            this.buttonEx6Move.Text = "Go!";
            this.buttonEx6Move.UseVisualStyleBackColor = true;
            // 
            // textBoxEx6Velocity
            // 
            this.textBoxEx6Velocity.Location = new System.Drawing.Point(233, 23);
            this.textBoxEx6Velocity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEx6Velocity.Name = "textBoxEx6Velocity";
            this.textBoxEx6Velocity.Size = new System.Drawing.Size(116, 22);
            this.textBoxEx6Velocity.TabIndex = 11;
            // 
            // textBoxEx6YPosition
            // 
            this.textBoxEx6YPosition.Location = new System.Drawing.Point(123, 23);
            this.textBoxEx6YPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEx6YPosition.Name = "textBoxEx6YPosition";
            this.textBoxEx6YPosition.Size = new System.Drawing.Size(97, 22);
            this.textBoxEx6YPosition.TabIndex = 10;
            // 
            // textBoxEx6XPosition
            // 
            this.textBoxEx6XPosition.Location = new System.Drawing.Point(12, 23);
            this.textBoxEx6XPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEx6XPosition.Name = "textBoxEx6XPosition";
            this.textBoxEx6XPosition.Size = new System.Drawing.Size(97, 22);
            this.textBoxEx6XPosition.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(229, 4);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 17);
            this.label23.TabIndex = 2;
            this.label23.Text = "Velocity (PWM %)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(119, 4);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "Y Position (cm)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 4);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "X Position (cm)";
            // 
            // buttonSerial
            // 
            this.buttonSerial.Location = new System.Drawing.Point(20, 15);
            this.buttonSerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSerial.Name = "buttonSerial";
            this.buttonSerial.Size = new System.Drawing.Size(217, 28);
            this.buttonSerial.TabIndex = 2;
            this.buttonSerial.Text = "Connect Serial!";
            this.buttonSerial.UseVisualStyleBackColor = true;
            this.buttonSerial.Click += new System.EventHandler(this.buttonConnectSerial_Click);
            // 
            // comboBoxCOMPorts
            // 
            this.comboBoxCOMPorts.FormattingEnabled = true;
            this.comboBoxCOMPorts.Location = new System.Drawing.Point(16, 50);
            this.comboBoxCOMPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCOMPorts.Name = "comboBoxCOMPorts";
            this.comboBoxCOMPorts.Size = new System.Drawing.Size(220, 24);
            this.comboBoxCOMPorts.TabIndex = 1;
            this.comboBoxCOMPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOMPorts_SelectedIndexChanged_1);
            // 
            // serialPort
            // 
            this.serialPort.WriteTimeout = 5000;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // timerSerialPort
            // 
            this.timerSerialPort.Enabled = true;
            this.timerSerialPort.Tick += new System.EventHandler(this.timerSerialPort_Tick);
            // 
            // textBoxSerialDataStream
            // 
            this.textBoxSerialDataStream.Location = new System.Drawing.Point(16, 174);
            this.textBoxSerialDataStream.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSerialDataStream.Multiline = true;
            this.textBoxSerialDataStream.Name = "textBoxSerialDataStream";
            this.textBoxSerialDataStream.ReadOnly = true;
            this.textBoxSerialDataStream.Size = new System.Drawing.Size(220, 360);
            this.textBoxSerialDataStream.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 154);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Return Bytes";
            // 
            // txtDebugOutput1
            // 
            this.txtDebugOutput1.Location = new System.Drawing.Point(709, 236);
            this.txtDebugOutput1.Name = "txtDebugOutput1";
            this.txtDebugOutput1.Size = new System.Drawing.Size(100, 22);
            this.txtDebugOutput1.TabIndex = 28;
            // 
            // txtDebugOutput2
            // 
            this.txtDebugOutput2.Location = new System.Drawing.Point(709, 265);
            this.txtDebugOutput2.Name = "txtDebugOutput2";
            this.txtDebugOutput2.Size = new System.Drawing.Size(100, 22);
            this.txtDebugOutput2.TabIndex = 29;
            // 
            // txtDebugOutput3
            // 
            this.txtDebugOutput3.Location = new System.Drawing.Point(709, 294);
            this.txtDebugOutput3.Name = "txtDebugOutput3";
            this.txtDebugOutput3.Size = new System.Drawing.Size(100, 22);
            this.txtDebugOutput3.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 554);
            this.Controls.Add(this.buttonSerial);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxCOMPorts);
            this.Controls.Add(this.textBoxSerialDataStream);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MECH423Lab3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.DCMotor.ResumeLayout(false);
            this.DCMotor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEx2DCPWM)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStepperVelocityControl)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEx4DCPWM)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage DCMotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEx2DCPWM;
        private System.Windows.Forms.TrackBar trackBarEx2DCPWM;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonSerial;
        private System.Windows.Forms.ComboBox comboBoxCOMPorts;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timerSerialPort;
        private System.Windows.Forms.TrackBar trackBarStepperVelocityControl;
        private System.Windows.Forms.TextBox textBoxStepperStepsPerSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStepperRightStep;
        private System.Windows.Forms.Button buttonStepperLeftStep;
        private System.Windows.Forms.Button buttonStepperStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEncoderRPM;
        private System.Windows.Forms.TextBox textBoxEncoderHz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLinearVelocity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLinearPosition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEx4DCPWM;
        private System.Windows.Forms.TrackBar trackBarEx4DCPWM;
        public System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TextBox textBoxSerialDataStream;
        private System.Windows.Forms.Button buttonEx2DCEStop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonEx4DCEStop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxEx5DCPWM;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonEx4ResetPosition;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxEx5RunLength;
        private System.Windows.Forms.TextBox textBoxEx5FileName;
        private System.Windows.Forms.CheckBox checkBoxEx5SaveToFile;
        private System.Windows.Forms.Button buttonEx5StartStepRun;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonEx5EStop;
        private System.Windows.Forms.TextBox textBoxEx6Velocity;
        private System.Windows.Forms.TextBox textBoxEx6YPosition;
        private System.Windows.Forms.TextBox textBoxEx6XPosition;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonEx5Move;
        private System.Windows.Forms.TextBox textBoxEx5XPosition;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button buttonEx6Move;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEx4;
        private System.Windows.Forms.TextBox txtDebugOutput3;
        private System.Windows.Forms.TextBox txtDebugOutput2;
        private System.Windows.Forms.TextBox txtDebugOutput1;
    }
}

