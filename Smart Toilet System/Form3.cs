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
    public partial class Form3 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "bbXOzidDfJbztjsXfcTJFrgm6x2L2rthCsvzr01y",
            BasePath = "https://iot-toliet-default-rtdb.firebaseio.com"
        };

        IFirebaseClient client;

        public Form3()
        {
            InitializeComponent();
        }

        private async void btnNewAccount_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetAsync("user/" + txtNewId.Text);

            FirebaseResponse res = await client.GetAsync("ogn/");

            Data id = resp.ResultAs<Data>();

            originalnum original = res.ResultAs<originalnum>();

            if (id == null)
            {
                if (txtNewPassword.Text == "" || txtNewPassword2.Text == "")
                    MessageBox.Show("패스워드를 입력하세요", "Warning!");
                else if (txtNewPassword.Text != txtNewPassword2.Text)
                {
                    MessageBox.Show("패스워드가 같지 않습니다.", "Warning!");
                }
                else
                {
                    if (txtogn.Text == original.num)// 고유번호 추가
                    {
                        var data = new Data
                        {
                            ID = txtNewId.Text,
                            PW = txtNewPassword.Text
                        };
                        SetResponse response = await client.SetAsync("user/" + data.ID, data);

                        MessageBox.Show("회원 가입 성공!", "알림");
                        this.Close();
                    }
                    else
                        MessageBox.Show("고유번호가 다릅니다.", "Warning!");
                }
            }
            else
            {
                if (txtNewId.Text == "")
                    MessageBox.Show("아이디를 입력해주세요.", "Warning!");
                else
                    MessageBox.Show("중복된 아이디가 있습니다.", "Warning");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
                MessageBox.Show("연결 성공");
        }
    }
}
