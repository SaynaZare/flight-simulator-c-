using System;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Web.Script.Serialization;
using System.Drawing;
using System.Text;
using Guna.UI2.WinForms;
using Guna.UI2.Designer;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CourseWork2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm

    {
        

        TcpClient m_client;
        const int port = 9999;
        Thread listeningThread = null;

        //declare delegates 
        public delegate void TrackBarDelegate(ControlsUpdate ThrottleUpdates, ControlsUpdate ElevatorPitchUpdate);
        public delegate void transferTelemetryDelegate(string dataUpdate);

        public TrackBarDelegate TrackBarEvent;
        public transferTelemetryDelegate TelemetryUpdateEvent;
        TrackBarDelegate TD;
       ControlsUpdate T;
        TelemetryUpdate TUpdate;

        public Form1()
        {
       
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(IPText, "enter IP Address, ex: 000.00.00.000");

            TrackBarEvent += new TrackBarDelegate(UpdateControlVariable);
            TelemetryUpdateEvent += new transferTelemetryDelegate(AddTelemetryHistory);
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                m_client = new TcpClient();
                IPAddress ip = IPAddress.Parse(IPText.Text);

                // Attempt to connect to the server
                m_client.Connect(ip, port);

                MessageBox.Show("Connected to: " + IPText.Text);

                // Start listening for received messages on a new thread
                listeningThread = new Thread(new ThreadStart(Listen));
                listeningThread.Start();
            }
            //catches invalid ip address entered by user
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid IP address format. Please enter a valid IP address.\n\n" + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            //anything else that could go wrong, this will stop program from crashing
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while trying to connect.\n\n" + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listen()
        {
            
            try
            {
                //client is recieveiong a stream of data
                NetworkStream stream = m_client.GetStream();
                byte[] buffer = new byte[255];

                while (true)
                {
                    int numBytes = stream.Read(buffer, 0, buffer.Length);
                    if (numBytes > 0)
                    {
                        string data = Encoding.ASCII.GetString(buffer, 0, numBytes);

                        // Deserialize and invoke delegate safely
                        try
                        {
                            TelemetryUpdate telemetry = new JavaScriptSerializer().Deserialize<TelemetryUpdate>(data);
                            TelemetryUpdateEvent?.Invoke(data); // Keep the raw data as an argument
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Deserialization error: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Listening thread error: {ex.Message}");
            }

        }
        
        //declaring the controlers variables
    public struct ControlsUpdate
        {
            public double Throttle;
            public double ElevatorPitch; // pitch positive goes up and negative down
        }

        //declaring the telemertry variables to recieve from airplane
      public struct TelemetryUpdate
        {
            public double Altitude; //ft
            public double Speed; //knts
            public double pitch;//pitch relative to horizen indicating pointing up or down
            public double VerticalSpeed;
            public double Throttle;
            public double ElevatorPitch;
            public int WarningCode; 
            //0-> no warning, 1-> too low(less than 1000ft); 2->stall
        }

        public void UpdateControlVariable(ControlsUpdate ThrottleValue, ControlsUpdate EPitchValue)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new TrackBarDelegate(UpdateControlVariable),new object[] { ThrottleValue, EPitchValue });
            }

            else
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string ThrottleJsonText = serializer.Serialize(ThrottleValue);
                string EpitchJsonText = serializer.Serialize( EPitchValue);

                EPitchDegreeTxt.Text = EPitchValue.ElevatorPitch.ToString() + "°";
                ThrottlePercentageTxt.Text = ThrottleValue.Throttle.ToString() + "%";

                //TelemetryText.AppendText("update deligate, Throttle value : " + ThrottleJsonText + "Elevator Pitch Value: " + EPitchValue );
                //TelemetryText.AppendText(Environment.NewLine);
            }
        }


        private void genericTBar_Scroll(object sender, EventArgs e)
        {
            try
            {

                // Prepare control update values
                ControlsUpdate update = new ControlsUpdate
                {
                    Throttle = ThrottleTBar.Value,
                    ElevatorPitch = ElevatorPitchTBar.Value
                };

                // Invoke the trackbar event for UI updates
                TrackBarEvent?.Invoke(update, update);

                // Send data to the server
                if (m_client != null && m_client.Connected)
                {
                    // Serialize the control data
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    string jsonMessage = serializer.Serialize(update);

                    // Write to the network stream
                    NetworkStream stream = m_client.GetStream();
                    byte[] rawData = Encoding.ASCII.GetBytes(jsonMessage);
                    stream.Write(rawData, 0, rawData.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending data: {ex.Message}");
            }
        }

        private async void AddTelemetryHistory(string data)
        {

            if (this.InvokeRequired)
            {
                this.Invoke(new transferTelemetryDelegate(AddTelemetryHistory), new object[] { data });
                return;
            }

            try
            {
                TelemetryUpdate telemetry = new JavaScriptSerializer().Deserialize<TelemetryUpdate>(data);

                // Add data to grid safely
                DataGrid.Rows.Add(new object[]
                {
            DateTime.Now.ToString("hh:mm"),
            telemetry.Altitude.ToString(),
            telemetry.Speed.ToString(),
            telemetry.pitch.ToString(),
            telemetry.VerticalSpeed.ToString(),
            telemetry.Throttle.ToString(),
            telemetry.ElevatorPitch.ToString(),
                });

                AltitudeTxt.Text = telemetry.Altitude.ToString("F2");
                SpeedTxt.Text = telemetry.Speed.ToString("F2"); 
                PitchTxt.Text = telemetry.pitch.ToString("F2");
                VspeedTxt.Text = telemetry.VerticalSpeed.ToString("F2");
                EpitchTxt.Text = telemetry.ElevatorPitch.ToString("F2");
                ThrottleTxt.Text= telemetry.Throttle.ToString("F2");
                WarningTxt.Text = telemetry.WarningCode.ToString();

                //updating warningMSg incase there is a warning code
                if (telemetry.WarningCode == 1)
                {
                   
                    WarningMsgText.Text = "The airplane is too low, height is below 1000.\n increase the pitch immediately!!!\n plane crash danger💀";
                    WarningMsgText.ForeColor = Color.Orange;
                    ShakeForm();

                }

                else if (telemetry.WarningCode == 2)
                {

                    WarningMsgText.Text = "Stall";
                    WarningMsgText.ForeColor = Color.Red;
                    StallPlanePic.Visible = true;
                    StablePlanePic.Visible = false;
                    ShakeForm();
                }

                else
                {
                    WarningMsgText.Text = "✈️no warning detected✈️ keep the airplane stable ";
                    WarningMsgText.ForeColor = Color.Gray;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating telemetry history: {ex.Message}");
            }
        }

        private async void ShakeForm()
        {
            // Save the original location of the form
            Point originalLocation = this.Location;

            // Define the shake offset and the number of shakes
            int shakeAmplitude = 5; // How far the form moves
            int shakeTimes = 5; // Number of shakes

            // Perform the shaking effect
            for (int i = 0; i < shakeTimes; i++)
            {
                this.Location = new Point(originalLocation.X + shakeAmplitude, originalLocation.Y);
                await Task.Delay(100); // Small delay for smooth animation
                this.Location = new Point(originalLocation.X - shakeAmplitude, originalLocation.Y);
                await Task.Delay(100);
                this.Location = new Point(originalLocation.X, originalLocation.Y + shakeAmplitude);
                await Task.Delay(100);
                this.Location = new Point(originalLocation.X, originalLocation.Y - shakeAmplitude);
                await Task.Delay(50);
            }

            // Reset the form's location to the original position
            this.Location = originalLocation;
        }


    }
}

