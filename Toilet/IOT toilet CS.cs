using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort sPort;

        public Form1()
        {
            InitializeComponent();

            foreach (var ports in SerialPort.GetPortNames()) //컴퓨터의 시리얼 포트를 콤보박스에 입력
            {
                comboBox1.Items.Add(ports);
            }
            

            //sPort = new SerialPort("COM3", 9600);
            //sPort.Open();       //Serial Port= sPort
            //sPort.DataReceived += SPort_DataReceived;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource = SerialPort.GetPortNames();
        }

        private void SPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string s = sPort.ReadLine();
            Console.WriteLine(s);
            this.BeginInvoke((new Action(delegate {showValue(s); })));
        }

        private void showValue(string s) //아두이노에서 받아온 값의 판정 함수
        {
            if (s == "User In\r") //값을 받아올 때 /r를 같이 받아옴
            {
                label1.Text = "사용중";
                pninout1.BackColor = Color.Red;
            }
            else if (s == "User Out\r")
            {
                label1.Text = "사용가능";
                pninout1.BackColor = Color.Green;
            }
            else if (s == "Danger!\r")
            {
                label2.Text = "관리자 호출!";
                pncall1.BackColor = Color.Red;
            }
            else if (s == "Full\r")
            {
                label3.Text = "휴지가 충분합니다.";
                pnts.BackColor = Color.Green;
            }
            else if (s == "Change!\r")
            {
                label3.Text = "휴지를 교체해주세요.";
                pnts.BackColor = Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            ComboBox cb = sender as ComboBox;
            sPort = new SerialPort(cb.SelectedItem.ToString());
            sPort.Open();
            sPort.DataReceived += SPort_DataReceived;
        }

        private void pninout1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //reset 버튼 코딩
        {
            label2.Text = "";
            pncall1.BackColor = DefaultBackColor;

        }

        private void pbcall_Click(object sender, EventArgs e)
        {

        }

        private void pncall1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }


