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
    public partial class Form2 : Form
    {
        int userinck = 0;
        int useroutck = 3;
        int userck1 = 0;
        int userck2 = 0;
        int userck3 = 0;
        int changeck1 = 0;
        int changeck2 = 0;
        int changeck3 = 0;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "bbXOzidDfJbztjsXfcTJFrgm6x2L2rthCsvzr01y",
            BasePath = "https://iot-toliet-default-rtdb.firebaseio.com"
        };

        IFirebaseClient client;

        public Form2()
        {
            InitializeComponent();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            lblused.Text = userinck.ToString();
            lblempty.Text = useroutck.ToString();

            client = new FireSharp.FirebaseClient(config);
            if (client != null)
                MessageBox.Show("연결 성공");

            while (true)
            {
                FirebaseResponse resp = await client.GetAsync("toilet/");

                toilet t = resp.ResultAs<toilet>();

                if (t != null)
                {
                    if (t.first == 1)
                    {
                        if(userck1 == 0)
                        {
                            userck1 += 1;
                            pbUserIn1.Visible = true;
                            pbUserOut1.Visible = false;
                            if (useroutck != 0)
                            {
                                userinck += 1;
                                useroutck -= 1;
                            }
                            lblused.Text = userinck.ToString();
                            lblempty.Text = useroutck.ToString();
                        }
                    }
                    else
                    {
                        if(userck1 == 1) 
                        {
                            userck1 -= 1;
                            pbUserIn1.Visible = false;
                            pbUserOut1.Visible = true;
                            if (userinck != 0)
                            {
                                userinck -= 1;
                                useroutck += 1;
                            }
                            lblused.Text = userinck.ToString();
                            lblempty.Text = useroutck.ToString();
                        }
                    }

                    if (t.second == 1)
                    {
                        if (userck2 == 0)
                        {
                            userck2 += 1;
                            pbUserIn2.Visible = true;
                            pbUserOut2.Visible = false;
                            if (useroutck != 0)
                            {
                                userinck += 1;
                                useroutck -= 1;
                            }
                            lblused.Text = userinck.ToString();
                            lblempty.Text = useroutck.ToString();
                        }
                    }
                    else
                    {
                        if (userck2 == 1)
                        {
                            userck2 -= 1;
                            pbUserIn2.Visible = false;
                            pbUserOut2.Visible = true;
                            if (userinck != 0)
                            {
                                userinck -= 1;
                                useroutck += 1;
                            }
                            lblused.Text = userinck.ToString();
                            lblempty.Text = useroutck.ToString();
                        }
                    }

                    if (t.third == 1)
                    {
                        if (userck3 == 0)
                        {
                            userck3 += 1;
                            pbUserIn3.Visible = true;
                            pbUserOut3.Visible = false;
                            if (useroutck != 0)
                            {
                                userinck += 1;
                                useroutck -= 1;
                            }
                            lblused.Text = userinck.ToString();
                            lblempty.Text = useroutck.ToString();
                        }
                    }
                    else
                    {
                        if (userck3 == 1)
                        {
                            userck3 -= 1;
                            pbUserIn3.Visible = false;
                            pbUserOut3.Visible = true;
                            if (userinck != 0)
                            {
                                userinck -= 1;
                                useroutck += 1;
                            }
                            lblused.Text = userinck.ToString();
                            lblempty.Text = useroutck.ToString();
                        }
                    }

                    if (t.danger1 == 1)
                    {
                        pbDanger1.Visible = true;
                        pbSafe1.Visible = false;
                        DialogResult result = MessageBox.Show("1번칸 위험신호", "Warning!", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            var data = new toilet
                            {
                                first = t.first,
                                second = t.second,
                                third = t.third,
                                danger1 = 0,
                                danger2 = t.danger2,
                                danger3 = t.danger3,
                                change1 = t.change1,
                                change2 = t.change2,
                                change3 = t.change3,
                            };

                            FirebaseResponse res = await client.UpdateAsync("toilet/", data);
                            pbDanger1.Visible = false;
                            pbSafe1.Visible = true;
                        }
                    }

                    if (t.danger2 == 1)
                    {
                        pbDanger2.Visible = true;
                        pbSafe2.Visible = false;
                        DialogResult result = MessageBox.Show("2번칸 위험신호", "Warning!", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            var data = new toilet
                            {
                                first = t.first,
                                second = t.second,
                                third = t.third,
                                danger1 = t.danger1,
                                danger2 = 0,
                                danger3 = t.danger3,
                                change1 = t.change1,
                                change2 = t.change2,
                                change3 = t.change3,
                            };

                            FirebaseResponse res = await client.UpdateAsync("toilet/", data);
                            pbDanger2.Visible = false;
                            pbSafe2.Visible = true;
                        }
                    }

                    if (t.danger3 == 1)
                    {
                        pbDanger3.Visible = true;
                        pbSafe3.Visible = false;
                        DialogResult result = MessageBox.Show("3번칸 위험신호", "Warning!", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            var data = new toilet
                            {
                                first = t.first,
                                second = t.second,
                                third = t.third,
                                danger1 = t.danger1,
                                danger2 = t.danger2,
                                danger3 = 0,
                                change1 = t.change1,
                                change2 = t.change2,
                                change3 = t.change3,
                            };

                            FirebaseResponse res = await client.UpdateAsync("toilet/", data);
                            pbDanger3.Visible = false;
                            pbSafe3.Visible = true;
                        }
                    }

                    if (t.change1 == 1)
                    {
                        if (changeck1 == 0)
                        {
                            pbtsChange1.Visible = true;
                            pbtsFull1.Visible = false;
                            changeck1 += 1;
                        }
                    }
                    else
                    {
                        if (changeck1 == 1)
                        {
                            pbtsChange1.Visible = false;
                            pbtsFull1.Visible = true;
                            changeck1 -= 1;
                        }
                    }

                    if (t.change2 == 1)
                    {
                        if (changeck2 == 0)
                        {
                            pbtsChange2.Visible = true;
                            pbtsFull2.Visible = false;
                            changeck2 += 1;
                        }
                    }
                    else
                    {
                        if (changeck2 == 1)
                        {
                            pbtsChange2.Visible = false;
                            pbtsFull2.Visible = true;
                            changeck2 -= 1;
                        }
                    }

                    if (t.change3 == 1)
                    {
                        if (changeck3 == 0)
                        {
                            pbtsChange3.Visible = true;
                            pbtsFull3.Visible = false;
                            changeck3 += 1;
                        }
                    }
                    else
                    {
                        if (changeck3 == 1)
                        {
                            pbtsChange1.Visible = false;
                            pbtsFull1.Visible = true;
                            changeck3 -= 1;
                        }
                    }
                }
            }
        }
    }
}

/*used=사용중
enpty=빈칸
pbtsFull, pbSafe, pbUserout 이 세가지가 디폴트값!
사진은 차후에 채울 예정입니다. 
*/