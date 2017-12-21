using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GPS_Mods
{
    public partial class Form1 : Form
    {
        bool timerFl; // Идетификатор работы таймера 
        int timerSch,     // Счётчик таймера
            timerInerv;       // Интервал таймера
        string numPort;       // Номер порта
        int speedPort;
        SerialPort port;
        TransformCoordinates tc;
        const int N = 50; //размер масива координат
        List<coordinates> coord = new List<coordinates>(); // Хранилище координат        
        

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();       
        private void TimerEventProcessor(Object myObject,
                                         EventArgs myEventArgs)
        {
            timerSch++;
            readComPort();
            
        }
        public Form1()
        {
            InitializeComponent();            
            this.Text += " " + Properties.Settings.Default.Version;            
            INIT_DEFAULT();            
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = timerInerv;
            port = new SerialPort();
            System.Threading.Thread.Sleep(timerInerv);
        }

        private void INIT_DEFAULT()
        {
            Properties.Settings.Default.open_sum++;
            cbNumPort.Items.Clear();
            cbNumPort.Items.AddRange(SerialPort.GetPortNames());
            timerFl = false;   
            timerSch = 0;    
            timerInerv = Properties.Settings.Default.time_interval;
            if (timerInerv >= 0)
                timerInerv = 1000;
            cbTimerInterv.SelectedIndex = cbTimerInterv.Items.IndexOf(timerInerv.ToString());           
            speedPort = Properties.Settings.Default.speed_port;
            cbSpeedPort.SelectedIndex = cbSpeedPort.Items.IndexOf(speedPort.ToString());    
            numPort = Properties.Settings.Default.num_port;
            cbNumPort.SelectedIndex = cbNumPort.Items.IndexOf(numPort);
            Properties.Settings.Default.Save();            
            tsslConnect.Text = "Disconnect";
            tsslPort.Text = "No port";
        }
        private void INIT()
        {
            try
            {
                numPort = cbNumPort.SelectedItem.ToString();
                speedPort = Convert.ToInt32(cbSpeedPort.SelectedItem.ToString());
                timerInerv = Convert.ToInt32(cbTimerInterv.SelectedItem.ToString());
                Properties.Settings.Default.num_port = numPort;
                Properties.Settings.Default.speed_port = speedPort;
                Properties.Settings.Default.time_interval = timerInerv;
                Properties.Settings.Default.Save();
                // настройки порта
                port.PortName = numPort;
                port.BaudRate = speedPort;
                port.DataBits = 8;
                port.Parity = System.IO.Ports.Parity.None;
                port.StopBits = System.IO.Ports.StopBits.One;
                port.ReadTimeout = timerInerv;
                port.WriteTimeout = timerInerv;
            }
            catch (Exception e)
            {
                MessageBox.Show("Вылет по исключению", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void openPort()
        {            
            port.Open();
            tsslConnect.Text = "Connect";
            tsslPort.Text = cbNumPort.SelectedItem.ToString();
           
        }

        private void closePort()
        {
            port.Close();
            tsslConnect.Text = "Disconnect";
        }

        public void readComPort()
        {
            if (port.BytesToRead > 0)
            {
                string indata = port.ReadExisting();

                string[] result;
                string resultGPRMC = "START";
                string[] stringSeparators = new string[] {"$"};
                string[] stringSeparatorsZPT = new string[] { "," };
                result = indata.Split(stringSeparators, StringSplitOptions.None);
                for (int i = 0; i < result.Length; i++)
                {
                    richTextBox1.Text += result[i];
                    richTextBox1.Text += "\n";
                }
                richTextBox1.Text += "\n--------------------------------------------------------------------------------------\n\n"; 
                
                resultGPRMC = getSearchString(result, "GPRMC");

                richTextBox1.Text += "\t\t";
                richTextBox1.Text += resultGPRMC;
                richTextBox1.Text += "\n";

                richTextBox1.Text += "\n-------------------------------------!!!-------------------------------------------------\n\n";
                if (!resultGPRMC.Contains("NOT_DATA"))
                {
                    result = resultGPRMC.Split(stringSeparatorsZPT, StringSplitOptions.None);
                    for (int i = 0; i < result.Length; i++)
                    {
                        richTextBox1.Text += result[i];
                        richTextBox1.Text += "\n";
                    }
                    lbDate.Text = getDate(result[9]);
                    lbTime.Text = getTime(result[1]);
                    lbLat.Text = getCoord(result[3], result[4]);
                    lbLon.Text = getCoord(result[5], result[6]);
                    if (!(result[3].Contains("")) && !(result[5].Contains("")))
                    {
                        tc.Transform(Convert.ToDouble(result[3]), Convert.ToDouble(result[5]));
                        lbXm.Text = tc.GetX().ToString();
                        lbYm.Text = tc.GetY().ToString();
                        richTextBox1.Text += "\nCOOORDINATE X = " + tc.GetX().ToString() + "\tY = " + tc.GetY().ToString();
                    }
                    else
                    {
                        lbXm.Text = " нет данных";
                        lbYm.Text = " нет данных";
                        richTextBox1.Text += "\nCOOORDINATE X = NULL\tY = NULL";
                    }
                }
                else
                {
                    richTextBox1.Text += "\nNEHER_BIT\n";
                }

                
                
                

                richTextBox1.Text += "\n=======================================================================================\n\n";

                /*label4.Text = indata;
                label7.Text = result[0];
                label9.Text = timerSch.ToString();*/
                lbDUMP.Items.Add(indata);
            }
        }

        private void storageСoord(string coord1, string coord2)
        {
            if (!(coord1.Contains("")) && !(coord2.Contains("")))
            {
                coordinates c;
                c.coord1 = Convert.ToDouble(coord1);
                c.coord2 = Convert.ToDouble(coord2);
                coord.Add(c);

                for (int i = 0; i < coord.Count; i++)
                {

                }
            }
        }

        private string getSearchString(string[] arr, string str)
        {
            string result = "NOT_DATA";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(str) && arr[i].Contains("*"))
                {
                    result = arr[i];
                }
                else
                {
                    result = "NOT_DATA";
                }
            }
            return result;
        }

        private string getDate(string str)
        {
            string result = "";
            char[] arr;            
            arr = str.ToCharArray(0, str.Length);
            for(int i = 0; i < arr.Length - 1; i+=2)
            {
                result += arr[i].ToString();
                result += arr[i + 1].ToString();
                if (i != 2)
                    result += ".";
                else
                    result += ".20";
            }
            return result;
        }

        private string getTime(string str)
        {            
            string result = "";
            char[] arr;                     
            arr = str.ToCharArray(0, 2);
            result = arr[0].ToString();
            result += arr[1].ToString();
            result = (Convert.ToInt32(result) + 3).ToString();
            result += ":";
            arr = str.ToCharArray(2, str.Length - 2);
            for (int i = 0; i < arr.Length - 1; i += 2)
            {
                if (arr[i] != '.')
                {
                    result += arr[i].ToString();
                    result += arr[i + 1].ToString();
                    if(i != 2)
                        result += ":";
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        private string getCoord(string str, string NSWE)
        {
            string result = "";
            result = str;
            if (NSWE.Contains("N"))
                result += " северная широта";
            else if(NSWE.Contains("S"))
                result += " южная широта";
            else if(NSWE.Contains("W"))
                result += " западная долгота";
            else if (NSWE.Contains("E"))
                result += " восточная долгота";  
            else
                result += " нет данных";
            return result;
        }

        private void btCleanList_Click(object sender, EventArgs e)
        {
            lbDUMP.Items.Clear();
            richTextBox1.Clear();
        }

        private void cbSpeedPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            INIT();
        }

        private void cbNumPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            INIT();
        }

        private void cbTimerInterv_SelectedIndexChanged(object sender, EventArgs e)
        {
            INIT();
        }

        private void btStartScan_Click(object sender, EventArgs e)
        {
            if (timerFl != true)
            {
                if (cbNumPort.SelectedIndex != -1 && cbSpeedPort.SelectedIndex != -1 && cbTimerInterv.SelectedIndex != -1)
                {
                    myTimer.Start();
                    timerFl = true;
                    btStartScan.Text = "СТОП";
                    openPort();
                }
                else
                {
                    MessageBox.Show("Не все поля настроек заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                myTimer.Stop();
                timerFl = false;
                btStartScan.Text = "СТАРТ";
                closePort();
            }
        }
    }
}
