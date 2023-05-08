using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Smart_Toilet_System
{
    public partial class Form1 : Form
    {
        Form2 f2 = null;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "bbXOzidDfJbztjsXfcTJFrgm6x2L2rthCsvzr01y",
            BasePath = "https://iot-toliet-default-rtdb.firebaseio.com"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetAsync("user/" + txtId.Text);

            Data id = resp.ResultAs<Data>();

            if (id == null)
            {
                MessageBox.Show("아이디가 존재하지 않습니다.", "Warning!");
            }
            else
            {
                if (txtPassword.Text == "")
                    MessageBox.Show("패스워드를 입력하세요", "Warning!");

                if (txtId.Text == "")
                    MessageBox.Show("아이디를 입력하세요", "Warning!");

                if (id.PW == txtPassword.Text)
                {
                    MessageBox.Show("로그인 성공", "알림");
                    if (f2 == null)
                    {
                        f2 = new Form2();
                    }
                    f2.Show();
                }
                else
                    MessageBox.Show("패스워드가 일치하지 않습니다.", "Warning!");
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
                MessageBox.Show("연결 성공");
        }
    }
}
