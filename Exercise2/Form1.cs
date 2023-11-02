using System;
using System.Collections.Concurrent;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        // ==============
        // INITIALIZATION 
        // ==============
        
        int SingleStepCommand = 0;          // 4/3/0 for +Single Step/-Single Step/NOP,
        
        Byte dequeueItem;
        ConcurrentQueue<Byte> dataQueue = new ConcurrentQueue<Byte>();

        Packet incomingPacket = new Packet();

        int encoderDifference = 0;
        const int transmissionBaudRate = 9600;
        const int beltPitch = 2; // mm
        const int pulleyTeethPerRevolution = 20;
        const double encoderCountsPerRevolution = 979.62 / 4; // 979.62 is Polulu website, /4 b/c we/re only using one out of 4 quadrature signals
        const int DCMotorPWM = 1000;
        double relativePosition = 0;
        double deltaPosition = 0;
        const double incomingPacketDeltaT = 0.033; // data being sent at 10Hz
        bool startStepRun = false;

        StreamWriter outputFile;

        bool moveFlag = false;

        double currentPlotTime = 0;

        public Form1()
        {
            InitializeComponent();
            trackBarEx2DCPWM.Value = 0;
            textBoxEx2DCPWM.Text = Convert.ToString(trackBarEx2DCPWM.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // timer enable
            timerSerialPort.Enabled = true;

            // COM port select ComboBox enable
            comboBoxCOMPorts.Items.Clear();
            comboBoxCOMPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (comboBoxCOMPorts.Items.Count == 0)
            {
                comboBoxCOMPorts.Text = "No COM ports!";
            }
            else
            {
                comboBoxCOMPorts.SelectedIndex = 0;
            }
        }
         
        // =====================
        // Serial Communications 
        // =====================
        private void comboBoxCOMPorts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            serialPort.PortName = comboBoxCOMPorts.SelectedItem.ToString();
        }

        private void buttonConnectSerial_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Close();
                serialPort.Dispose();
                serialPort.Open();
                buttonSerial.Text = "Disconnect Serial!";
            }
            else
            {
                serialPort.Close();
                serialPort.Dispose();
                buttonSerial.Text = "Connect Serial!";
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Byte newByte = 0;
            int bytesToRead;

            bytesToRead = serialPort.BytesToRead;
            while (bytesToRead != 0)
            {
                newByte = (byte) serialPort.ReadByte();
                dataQueue.Enqueue(newByte);
                bytesToRead = serialPort.BytesToRead;
            }
        }
        // =====================
        // Exercise 2
        // =====================
        private void trackBarVelocityControl_Scroll(object sender, EventArgs e)
        {
            textBoxEx2DCPWM.Text = Convert.ToString(trackBarEx2DCPWM.Value);
        }
        private void buttonDCEmergencyStop_Click(object sender, EventArgs e)
        {
            textBoxEx2DCPWM.Text = Convert.ToString(0);
        }

        private void textBoxPWMPercentage_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStepperStepsPerSecond.Text == "-")
            {
                return;
            }
            if (textBoxEx2DCPWM.Text == "")
            {
                trackBarEx2DCPWM.Value = 0;
            }
            else
            {
                trackBarEx2DCPWM.Value = Convert.ToInt32(textBoxEx2DCPWM.Text);
            }
        }
        // ==========================
        // Exercise 3
        // ==========================

        private void trackBarStepperVelocityControl_Scroll(object sender, EventArgs e)
        {
            textBoxStepperStepsPerSecond.Text = Convert.ToString(trackBarStepperVelocityControl.Value);
        }
        private void textBoxStepperStepsPerSecond_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStepperStepsPerSecond.Text == "-")
            {
                return;
            }
            if (textBoxStepperStepsPerSecond.Text == "")
            {
                trackBarStepperVelocityControl.Value = 0;
            }
            else
            {
                trackBarStepperVelocityControl.Value = Convert.ToInt32(textBoxStepperStepsPerSecond.Text);
            }
        }
        private void buttonStepperLeft_Click(object sender, EventArgs e)
        {
            textBoxStepperStepsPerSecond.Text = Convert.ToString(0);
            SingleStepCommand = 6;
        }
        private void buttonStepperRightStep_Click(object sender, EventArgs e)
        {
            textBoxStepperStepsPerSecond.Text = Convert.ToString(0);
            SingleStepCommand = 5;
        }
        private void buttonStepperStop_Click(object sender, EventArgs e)
        {
            textBoxStepperStepsPerSecond.Text = Convert.ToString(0);
        }

        // ==========================
        // Exercise 4
        // ==========================

        private void trackBarEx4DCPWM_Scroll(object sender, EventArgs e)
        {
            textBoxEx4DCPWM.Text = Convert.ToString(trackBarEx4DCPWM.Value);
        }
        private void buttonEx4DCEStop_Click(object sender, EventArgs e)
        {
            textBoxEx4DCPWM.Text = Convert.ToString(0);
        }
        private void textBoxEx4DCPWM_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEx4DCPWM.Text == "-")
            {
                return;
            }
            if (textBoxEx4DCPWM.Text == "")
            {
                trackBarEx4DCPWM.Value = 0;
            }
            else
            {
                trackBarEx4DCPWM.Value = Convert.ToInt32(textBoxEx4DCPWM.Text);
            }
        }
        private void buttonEx4ResetPosition_Click(object sender, EventArgs e)
        {
            relativePosition = 0;
            currentPlotTime = 0;
            chartEx4.Series["Position vs Time"].Points.Clear();
            chartEx4.Series["Velocity vs Time"].Points.Clear();
        }

        // ==========================
        // Exercise 5 
        // ==========================
        private void checkBoxEx5SaveToFile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEx5SaveToFile.Checked)
            {
                if (string.IsNullOrEmpty(textBoxEx5FileName.Text))
                {
                    checkBoxEx5SaveToFile.Checked = false;
                }
                else
                {
                    outputFile = new StreamWriter(textBoxEx5FileName.Text);
                }
            } else
            {
                if (outputFile != null)
                {
                    outputFile.Flush();
                    outputFile.Close();
                }
            }
        }

        private void buttonEx5StartStepRun_Click(object sender, EventArgs e)
        {
            relativePosition = 0;
            startStepRun = true;
        }
        private void buttonEx5EStop_Click(object sender, EventArgs e)
        {
            textBoxEx5DCPWM.Text = Convert.ToString(0);
            startStepRun = false;
        }
        private void buttonEx5Move_Click(object sender, EventArgs e)
        {
            if (textBoxEx5XPosition.Text != "")
            {
                moveFlag = true;
            }
            
        }

        // ==========================
        // In use in all tabs
        // ==========================

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxEx2DCPWM.Text = Convert.ToString(0);
            textBoxStepperStepsPerSecond.Text = Convert.ToString(0);
            textBoxEx4DCPWM.Text = Convert.ToString(0);
            relativePosition = 0;
        }

        private void timerSerialPort_Tick(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                return;
            }
            
            // RECEIVE BYTE SCHEME
            // BYTE 0 - cmd | BYTE 1 - dat0      | BYTE 2 - dat1
            // 255          | 0 / 1 -> neg / pos | EncoderByte

            // READ
            while (dataQueue.TryDequeue(out dequeueItem))
            {
                // In all cases, we want to append to the receieved bytes
                textBoxSerialDataStream.AppendText($"{Convert.ToString(dequeueItem)},");
                // Use this in case we want to use the received bytes elsewhere...
                switch (tabControl.SelectedTab.Text)
                {
                    case "Ex. 4: Encoder Reader":
                        if (incomingPacket.parseNext(dequeueItem)) // Only do anything if we have a full packet
                        {
                            encoderDifference = incomingPacket.dat1;
                            if (incomingPacket.dat0 == 0)
                            {
                                encoderDifference *= -1; // if dat0 == 0 it's a negative number else do nothing
                            }
                            // [mm] = encoderDifference [counts] / encoderCountsPerRevolution [counts/360] * pulleyTeethPerRevolution [teeth/360] * beltPitch [mm/teeth];
                            deltaPosition = encoderDifference / encoderCountsPerRevolution * pulleyTeethPerRevolution * beltPitch;
                            relativePosition += deltaPosition;

                            textBoxEncoderHz.Text = Convert.ToString((double) encoderDifference / encoderCountsPerRevolution / incomingPacketDeltaT);
                            textBoxEncoderRPM.Text = Convert.ToString(60* encoderDifference / encoderCountsPerRevolution / incomingPacketDeltaT);
                            textBoxLinearPosition.Text = Convert.ToString(relativePosition); // Change in the position
                            textBoxLinearVelocity.Text = Convert.ToString(deltaPosition / incomingPacketDeltaT);

                            chartEx4.Series["Position vs Time"].Points.AddXY(currentPlotTime, relativePosition);
                            chartEx4.Series["Velocity vs Time"].Points.AddXY(currentPlotTime, 60 * encoderDifference / encoderCountsPerRevolution / incomingPacketDeltaT);
                            currentPlotTime += incomingPacketDeltaT;
                        }
                        break;
                    case "Ex. 5: Close Loop":
                        if (!incomingPacket.parseNext(dequeueItem)) // Only do anything if we have a full packet
                        {
                            break;
                       }

                        encoderDifference = incomingPacket.dat1;
                        if (incomingPacket.dat0 == 0)
                        {
                            encoderDifference *= -1; // if dat0 == 0 it's a negative number else do nothing
                        }
                        deltaPosition = encoderDifference / encoderCountsPerRevolution * pulleyTeethPerRevolution * beltPitch;
                        relativePosition += deltaPosition;
                        txtDebugOutput1.Text = Convert.ToString(deltaPosition);
                        txtDebugOutput2.Text = Convert.ToString(relativePosition);
                                
                        if (checkBoxEx5SaveToFile.Checked)
                        {
                            outputFile.Write(currentPlotTime + "," + deltaPosition + "\n");
                            outputFile.Flush();
                        }
                        currentPlotTime += incomingPacketDeltaT;

                        break;
                    default:
                        break;
                }
            }
            // CONTROL BYTE SCHEME
            // BYTE 0 | BYTE 1 - dat0   | BYTE 2 - dat1                                          | BYTE 3 - dat2                                          | BYTE 4 - dat3 | BYTE 5 - dat4
            // 255    | 0 STOP          | /                                                      | /                                                      | /             | /
            // 255    | 1 DC STOP       | /                                                      | /                                                      | /             | / 
            // 255    | 2 DC +Velocity  | 0-100 PWM%                                             | /                                                      | /             | / 
            // 255    | 3 DC -Velocity  | 0-100 PWM%                                             | /                                                      | /             | /
            // 255    | 4 STEPPER STOP  | /                                                      | /                                                      | /             | /
            // 255    | 5 STEPPER +STEP | if 0, single step, if > 0 the MSB of the counter value | if 0, single step, if > 0 the LSB of the counter value | /             | 0b100 means BYTE 2 is 255
            // 255    | 6 STEPPER -STEP | if 0, single step, if > 0 the MSB of the counter value | if 0, single step, if > 0 the LSB of the counter value | /             | 0b010 means BYTE 3 is 255
            // 255    | 7 2-axis CTRL   | X position (relative to current)                       | Y position (relative to current)                       | Velocity      | 0b001 means BYTE 4 is 255

            byte[] command = new byte[6];
            // WRITE
            switch (tabControl.SelectedTab.Text)
            {
                case "Ex. 2: DC Motor Control":
                    // Set the bytes that don't change
                    command[0] = 255;
                    serialPort.Write(command, 0, 1);
                    command[2] = 0; // default data high byte
                    command[3] = 0; // default data low byte
                    command[4] = 0;
                    command[5] = 0;
                    if (textBoxEx2DCPWM.Text == "") // if blank, assume stop
                    {
                        command[1] = 1;
                        command[2] = 0;
                    }
                    else // DC motor velocity command
                    {
                        if (textBoxEx2DCPWM.Text == "-")
                        {
                            break;
                        }
                        if (Convert.ToInt32(textBoxEx2DCPWM.Text) == 0)
                        {
                            command[1] = 1; // DC STOP
                        }
                        else if (Convert.ToInt32(textBoxEx2DCPWM.Text) > 0)
                        {
                            command[1] = 2; // CW
                        }
                        else
                        {
                            command[1] = 3; // CCW
                        }
                        serialPort.Write(command, 1, 1);
                        //int velocity = Math.Abs(Convert.ToInt32(textBoxEx2DCPWM.Text)) / 100 * 0xFFFF;
                        int velocity = (int)(Math.Abs(Convert.ToInt32(textBoxEx2DCPWM.Text)) /100.0 * 254);
                        command[2] = (byte)(velocity);
                        serialPort.Write(command, 2, 1);
                        //command[2] = (byte)((velocity >> 8) & 0xFF);
                        command[3] = 0; // hack, because command[2] == 0 -> ~0%
                        serialPort.Write(command, 3, 1);
                        //command[3] = (byte)((velocity & 0xFF));
                        //textBoxDebug.Text = command[2].ToString(); // does not display byte
                        textBoxDebug.Text = velocity.ToString();
                        //Console.WriteLine(System.Text.Encoding.UTF8.GetString(command, 0, 5));
                    }
                    command[4] = 0;
                    serialPort.Write(command, 4, 1);
                    //serialPort.Write(command, 0, 5);
                    //serialPort.Write(command, 0, 6);

                    break;
/*                case "Ex. 3: Stepper Motor Control":
                    // Set the bytes that don't change
                    command[0] = 255;
                    command[4] = 0; // reset escape byte
                    command[5] = 0;
                    if (textBoxStepperStepsPerSecond.Text == "") // if the field is blank, set to zero
                    {
                        command[1] = 4;
                        command[2] = 0;
                        command[3] = 0;
                    }
                    else  // if the field is non blank
                    {
                        if (SingleStepCommand != 0) // if there's a single step command
                        {
                            command[1] = (byte)SingleStepCommand;
                            command[2] = 0;
                            command[3] = 0;
                            command[4] = 0;
                            SingleStepCommand = 0;
                        }
                        else // if there's a velocity command
                        {
                            // direction of velocity:
                            if (textBoxStepperStepsPerSecond.Text == "-")
                            {
                                break;
                            }
                            if (Convert.ToInt32(textBoxStepperStepsPerSecond.Text) == 0)
                            {
                                command[1] = 4; // STEPPER  STOP
                                // all other bytes are ignored...
                            }
                            else
                            {
                                // direction
                                if (Convert.ToInt32(textBoxStepperStepsPerSecond.Text) > 0)
                                {
                                    command[1] = 5;
                                }
                                else
                                {
                                    command[1] = 6;
                                }
                                // magnitude of velocity
                                int counterValue = DCMotorPWM / Math.Abs(Convert.ToInt16(textBoxStepperStepsPerSecond.Text));
                                if ((Byte)(counterValue >> 8) == 0xFF) // if it's 255, change to 0 and update escape byte
                                {
                                    command[2] = 0x00;
                                    command[4] |= 0b10;
                                }
                                else
                                {
                                    command[2] = (Byte)(counterValue >> 8);  // shift right to get the 8 MSB 
                                }
                                if ((Byte)(counterValue) == 0xFF) // if it's 255, change to 0 and update escape byte
                                {
                                    command[2] = 0x00;
                                    command[4] |= 0b01;
                                }
                                else
                                {
                                    command[3] = (Byte)counterValue;         // truncate counterValue to get the 8 LSB
                                }
                            }
                        }
                    }
                    serialPort.Write(command, 0, 6);
                    break;
                case "Ex. 4: Encoder Reader":
                    // Set the bytes that don't change
                    command[0] = 255;
                    command[3] = 0;
                    command[4] = 0;
                    command[5] = 0;
                    if (textBoxEx4DCPWM.Text == "") // if blank, assume stop
                    {
                        command[1] = 1;
                        command[2] = 0;
                    }
                    else // DC motor velocity command
                    {
                        if (textBoxEx4DCPWM.Text == "-")
                        {
                            break;
                        }
                        if (Convert.ToInt32(textBoxEx4DCPWM.Text) == 0)
                        {
                            command[1] = 1; // DC STOP
                        }
                        else if (Convert.ToInt32(textBoxEx4DCPWM.Text) > 0)
                        {
                            command[1] = 2;
                        }
                        else
                        {
                            command[1] = 3;
                        }
                        command[2] = (byte)Math.Abs(Convert.ToInt32(textBoxEx4DCPWM.Text));
                    }
                    serialPort.Write(command, 0, 6);
                    break;
                case "Ex. 5: Close Loop":
                    // A flag will be set when we click the 'run' button. We run for a specified number of seconds.
                    if (startStepRun)
                    {
                        // tell the motor to run at the specified percentage
                        command[0] = 255;
                        command[1] = 2;
                        command[2] = (byte)Math.Abs(Convert.ToInt32(textBoxEx5DCPWM.Text));
                        command[3] = 0;
                        command[4] = 0;
                        command[5] = 0;
                        serialPort.Write(command, 0, 6);
                            
                        if (relativePosition > Convert.ToInt32(textBoxEx5RunLength.Text))
                        {
                            // command motor stop
                            command[0] = 255;
                            command[1] = 1;
                            command[2] = 0;
                            command[3] = 0;
                            command[4] = 0;
                            command[5] = 0;
                            serialPort.Write(command, 0, 6);
                            startStepRun = false;
                        }
                    }

                    if (moveFlag)
                    {
                        // command the MSP430 to a specified position
                        command[0] = 255;
                        command[1] = 7;
                        command[2] = (byte)(Convert.ToInt16(textBoxEx5XPosition.Text));// / beltPitch / pulleyTeethPerRevolution * encoderCountsPerRevolution)
                        command[3] = 0;
                        command[4] = 0;
                        command[5] = 0;
                        serialPort.Write(command, 0, 6);
                        moveFlag = false;
                    }


                    break;
*/
                default:
                    throw new DirectoryNotFoundException("GOOF - wrong tab");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Packet
    {
        const Byte PACKET_START_BYTE = 0xFF;

        // raw packet bytes
        public Byte cmd;
        public Byte dat0;
        public Byte dat1;

        enum Packet_ParseState
        {
            Packet_ParseState_err, // error state. For convenience, this is also the initial state.

            // Remainder of states indicate which byte is about to be read
            Packet_ParseState_dat0,
            Packet_ParseState_dat1,
            Packet_ParseState_done,
        };

        // state
        Packet_ParseState state;

        // implement Constructor

        public bool parseNext(Byte next_val)
        {
            if (next_val == PACKET_START_BYTE)
            {
                // Throw everything out and start from the top.
                state = Packet_ParseState.Packet_ParseState_dat0;
                return false;
            }

            // Otherwise, we have normal data
            switch (state)
            {
                case Packet_ParseState.Packet_ParseState_dat0:
                    dat0 = next_val;
                    state = Packet_ParseState.Packet_ParseState_dat1;
                    return false;
                case Packet_ParseState.Packet_ParseState_dat1:
                    dat1 = next_val;
                    return true;

                case Packet_ParseState.Packet_ParseState_err:
                // error state - we have no idea where we are, so all we can do is wait for the next start byte
                case Packet_ParseState.Packet_ParseState_done:
                // If we're done, then next byte should've been START_BYTE, and the if statement at the start of this function should've triggered. Sincre we're here, evidently it didn't, so there's been a problem
                default:
                    state = Packet_ParseState.Packet_ParseState_err;
                    return false;
            }
        }





    }
}



