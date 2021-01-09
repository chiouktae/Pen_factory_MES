using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Factory
{
    public partial class Form1 : MetroForm
    {
        // 네트워크 연결 정보 직접 대입
        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=scott;Password=tiger;";

        // 오라클 연결
        OracleConnection conn;
        // 명령 객체 생성
        OracleCommand cmd;

        //상태
        int state = 1;
        bool flag = false;

        //이미지박스용
        int X, Y;


        Form3 form3;
        public Form1()
        {
            InitializeComponent();
            conn = new OracleConnection(strConn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            oraclesearch();
        }


        void Step1_Active()
        {
            string[] arr1 = selectitem.Text.Split('_');
            string pen = arr1[0];
            string type = arr1[1];
            if (type.Equals("1"))
            {
                if (pen.Equals("Black"))
                {
                    K_Gp.Value = K_Gp.Value - 1;
                }
                else if (pen.Equals("Red"))
                {
                    R_Gp.Value = R_Gp.Value - 1;
                }
                else if (pen.Equals("Blue"))
                {
                    B_Gp.Value = B_Gp.Value - 1;
                }
            }
            else if(type.Equals("2"))
            {
                K_Gp.Value = K_Gp.Value - 1;
                R_Gp.Value = R_Gp.Value - 1;
            }
            else if (type.Equals("3"))
            {
                K_Gp.Value = K_Gp.Value - 1;
                R_Gp.Value = R_Gp.Value - 1;
                B_Gp.Value = B_Gp.Value - 1;
            }
            SaveOracle();
            oraclesearch();
            Movebal();
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            state++;
        }
        void Step2_Active()
        {
            string[] arr1 = selectitem.Text.Split('_');
            string type = arr1[1];
            if (type.Equals("1"))
            {
                S_Gp.Value = S_Gp.Value - 1;
            }
            else if (type.Equals("2"))
            {
                S_Gp.Value = S_Gp.Value - 2;
            }
            else if (type.Equals("3"))
            {
                S_Gp.Value = S_Gp.Value - 3;
            }
            SaveOracle();
            oraclesearch();
            Movebal2();
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            state++;
        }
        void Step3_Active()
        {
            string[] arr1 = selectitem.Text.Split('_');
            string type = arr1[1];
            if (type.Equals("1"))
            {
                C1_Gp.Value = C1_Gp.Value - 1;
            }
            else if (type.Equals("2"))
            {
                C2_Gp.Value = C2_Gp.Value - 1;
            }
            else if (type.Equals("3"))
            {
                C3_Gp.Value = (C3_Gp.Value - 1);
            }
            SaveOracle();
            oraclesearch();
            Movebal3();
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            state++;

        }
        void Step4_Active()
        {
            string[] arr1 = selectitem.Text.Split('_');
            string type = arr1[1];
            if (type.Equals("1"))
            {
                B1_Gp.Value = B1_Gp.Value - 1;
            }
            else if (type.Equals("2"))
            {
                B2_Gp.Value = B2_Gp.Value - 1;
            }
            else if (type.Equals("3"))
            {
                B3_Gp.Value = B3_Gp.Value - 1;
            }
            SaveOracle();
            oraclesearch();
            Movebal4();
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            state++;

        }
        void Step5_Active()
        {
            string[] arr1 = selectitem.Text.Split('_');
            string pen = arr1[0];
            string type = arr1[1];
            if (type.Equals("1"))
            {
                if (pen.Equals("Black"))
                {
                    SK_Gp.Value = SK_Gp.Value - 1;
                }
                else if (pen.Equals("Red"))
                {
                    SR_Gp.Value = SR_Gp.Value - 1;
                }
                else if (pen.Equals("Blue"))
                {
                    SB_Gp.Value = SB_Gp.Value - 1;
                }
            }
            else if (type.Equals("2"))
            {
                SK_Gp.Value = SK_Gp.Value - 1;
                SR_Gp.Value = SR_Gp.Value - 1;
            }
            else if (type.Equals("3"))
            {
                SK_Gp.Value = SK_Gp.Value - 1;
                SR_Gp.Value = SR_Gp.Value - 1;
                SB_Gp.Value = SB_Gp.Value - 1;
            }
            SaveOracle();
            oraclesearch();
            Movebal5();
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            if (type.Equals("1"))
            {
                if (pen.Equals("Black"))
                {
                    FK1_Gp.Value = FK1_Gp.Value + 1;
                }
                else if (pen.Equals("Red"))
                {
                    FR1_Gp.Value = FR1_Gp.Value + 1;
                }
                else if (pen.Equals("Blue"))
                {
                    FB1_Gp.Value = FB1_Gp.Value + 1;
                }
            }
            else if (type.Equals("2"))
            {
                FC2_Gp.Value = FC2_Gp.Value + 1;
            }
            else if (type.Equals("3"))
            {
                FC3_Gp.Value = FC3_Gp.Value + 1;
            }

            state = 1;
            SaveOracle();
        }
        private void Step1_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                if (!selectitem.Text.Equals("미지정"))
                {
                    Step1_Active();
                }
            }
        }

        private void Step2_Click(object sender, EventArgs e)
        {
            if (state == 2)
            {
                if (!selectitem.Text.Equals("미지정"))
                {
                    Step2_Active();
                }
            }
        }

        private void Step3_Click(object sender, EventArgs e)
        {
            if (state == 3)
            {
                if (!selectitem.Text.Equals("미지정"))
                {
                    Step3_Active();
                }
            }
        }

        private void Step4_Click(object sender, EventArgs e)
        {
            if (state == 4)
            {
                if (!selectitem.Text.Equals("미지정"))
                {
                    Step4_Active();
                }
            }
                
        }

        private void Step5_Click(object sender, EventArgs e)
        {
            if (state == 5)
            {
                if (!selectitem.Text.Equals("미지정"))
                {
                    Step5_Active();
                }
            }
                
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(cmd);
            form2.ShowDialog();
            oraclesearch();
        }

        private void Made_Click_1(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.FormSendEvent += new Form3.FormSendDataHandler(DieaseUpdateEventMethod);
            form3.Show();
        }
        private void DieaseUpdateEventMethod(object sender)
        {
            string[] arr = ((string)sender).Split('/');
            selectitem.Text = arr[0];
            maketime.Text = arr[1];
            form3.Close();
            flag = false;
            Run();
        }
        private void Wait()
        {
            Application.DoEvents();
            Thread.Sleep(100);
        }
        private void Run()
        {
            for (; Convert.ToInt32(maketime.Text) > 0; maketime.Text = (Convert.ToInt32(maketime.Text) - 1).ToString())
            {
                string[] arr1 = selectitem.Text.Split('_');
                string pen = arr1[0];
                string type = arr1[1];
                if (type.Equals("1"))
                {
                    if (S_Gp.Value < 1)
                    {
                        flag = true;
                        MessageBox.Show("스프링이 부족합니다.");
                        break;
                    }
                    if (C1_Gp.Value < 1)
                    {
                        flag = true;
                        MessageBox.Show("뚜껑이 부족합니다.");
                        break;
                    }
                    if (B1_Gp.Value < 1)
                    {
                        flag = true;
                        MessageBox.Show("몸체가 부족합니다.");
                        break;
                    }
                    if (pen.Equals("Black"))
                    {
                        if (K_Gp.Value < 1)
                        {
                            flag = true;
                            MessageBox.Show("심이 부족합니다.");
                            break;
                        }
                        if (Convert.ToInt32(SK_Gp.Value) < 1)
                        {
                            flag = true;
                            MessageBox.Show("버튼이 부족합니다.");
                            break;
                        }
                    }
                    else if (pen.Equals("Blue"))
                    {
                        if (B_Gp.Value < 1)
                        {
                            flag = true;
                            MessageBox.Show("심이 부족합니다.");
                            break;
                        }
                        if (SB_Gp.Value < 1)
                        {
                            flag = true;
                            MessageBox.Show("버튼이 부족합니다.");
                            break;
                        }
                    }
                    else if (pen.Equals("Red"))
                    {
                        if (R_Gp.Value < 1)
                        {
                            flag = true;
                            MessageBox.Show("심이 부족합니다.");
                            break;
                        }
                        if (SR_Gp.Value < 1)
                        {
                            flag = true;
                            MessageBox.Show("버튼이 부족합니다.");
                            break;
                        }
                    }
                }
                else if (type.Equals("2"))
                {
                    if (S_Gp.Value < 2)
                    {
                        flag = true;
                        MessageBox.Show("스프링이 부족합니다.");
                        break;
                    }
                    if (C2_Gp.Value < 1)
                    {
                        flag = true;
                        MessageBox.Show("뚜껑이 부족합니다.");
                        break;
                    }
                    if (B2_Gp.Value < 1)
                    {
                        flag = true;
                        MessageBox.Show("몸체가 부족합니다.");
                        break;
                    }
                    if ((R_Gp.Value < 1) || (K_Gp.Value < 1))
                    {
                        flag = true;
                        MessageBox.Show("심이 부족합니다.");
                        break;
                    }
                    if ((SR_Gp.Value < 1) || (SK_Gp.Value < 1))
                    {
                        flag = true;
                        MessageBox.Show("버튼이 부족합니다.");
                        break;
                    }
                }
                else if (type.Equals("3"))
                {
                    if (S_Gp.Value < 3)
                    {
                        flag = true;
                        MessageBox.Show("스프링이 부족합니다.");
                        break;
                    }
                    if (C2_Gp.Value < 1)
                    {
                        flag = true;
                        MessageBox.Show("뚜껑이 부족합니다.");
                        break;
                    }
                    if (B2_Gp.Value < 1)
                    {
                        flag = true;
                        MessageBox.Show("몸체가 부족합니다.");
                        break;
                    }
                    if ((R_Gp.Value < 1) || (K_Gp.Value < 1) || (B_Gp.Value < 1))
                    {
                        flag = true;
                        MessageBox.Show("심이 부족합니다.");
                        break;
                    }
                    if ((SR_Gp.Value < 1) || (SK_Gp.Value < 1) || (SB_Gp.Value < 1))
                    {
                        flag = true;
                        MessageBox.Show("버튼이 부족합니다.");
                        break;
                    }
                }
                while (flag)
                    Wait();
                if (state == 1)
                {
                    Step1_Active();
                    
                    while(flag)
                        Wait();
                }
                if (state == 2)
                {
                    Step2_Active();
                    
                    while (flag)
                        Wait();
                }
                if (state == 3)
                {
                    Step3_Active();
                    
                    while (flag)
                        Wait();
                }
                if (state == 4)
                {
                    Step4_Active();
                    
                    while (flag)
                        Wait();
                }
                if (state == 5)
                {
                    Step5_Active();
                    
                    while (flag)
                        Wait();
                }
            }
        }
        void oraclesearch()
        {
            //검은 볼펜 심 
            cmd.CommandText = "select VOL from p_factory where ID = 101";
            OracleDataReader rdr1 = cmd.ExecuteReader();
            while (rdr1.Read())
            {
                int VOL = rdr1.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(K_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(K_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(K_Gp, 1);
                }
                K_Gp.Value = VOL;
            }

            //빨간 볼펜 심
            cmd.CommandText = "select VOL from p_factory where ID = 102";
            OracleDataReader rdr2 = cmd.ExecuteReader();
            while (rdr2.Read())
            {
                int VOL = rdr2.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(R_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(R_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(R_Gp, 1);
                }
                R_Gp.Value = VOL;
            }

            //파란 볼펜 심
            cmd.CommandText = "select VOL from p_factory where ID = 103";
            OracleDataReader rdr3 = cmd.ExecuteReader();
            while (rdr3.Read())
            {
                int VOL = rdr3.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(B_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(B_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(B_Gp, 1);
                }
                B_Gp.Value = VOL;
            }

            //  스프링
            cmd.CommandText = "select VOL from p_factory where ID = 201";
            OracleDataReader rdr4 = cmd.ExecuteReader();
            while (rdr4.Read())
            {
                int VOL = rdr4.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(S_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(S_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(S_Gp, 1);
                }
                S_Gp.Value =VOL;
            }

            // 단색 뚜껑
            cmd.CommandText = "select VOL from p_factory where ID = 301";
            OracleDataReader rdr5 = cmd.ExecuteReader();
            while (rdr5.Read())
            {
                int VOL = rdr5.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(C1_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(C1_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(C1_Gp, 1);
                }
                C1_Gp.Value = VOL;
            }
            // 2색 뚜껑
            cmd.CommandText = "select VOL from p_factory where ID = 302";
            OracleDataReader rdr6 = cmd.ExecuteReader();
            while (rdr6.Read())
            {
                int VOL = rdr6.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(C2_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(C2_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(C2_Gp, 1);
                }
                C2_Gp.Value = VOL;
            }
            // 3색 뚜껑
            cmd.CommandText = "select VOL from p_factory where ID = 303";
            OracleDataReader rdr7 = cmd.ExecuteReader();
            while (rdr7.Read())
            {
                int VOL = rdr7.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(C3_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(C3_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(C3_Gp, 1);
                }
                C3_Gp.Value = VOL;
            }
            // 단색 몸통
            cmd.CommandText = "select VOL from p_factory where ID = 401";
            OracleDataReader rdr8 = cmd.ExecuteReader();
            while (rdr8.Read())
            {
                int VOL = rdr8.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(B1_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(B1_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(B1_Gp, 1);
                }
                B1_Gp.Value = VOL;
            }
            // 2색 몸통
            cmd.CommandText = "select VOL from p_factory where ID = 402";
            OracleDataReader rdr9 = cmd.ExecuteReader();
            while (rdr9.Read())
            {
                int VOL = rdr9.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(B2_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(B2_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(B2_Gp, 1);
                }
                B2_Gp.Value = VOL;
            }
            // 3색 몸통
            cmd.CommandText = "select VOL from p_factory where ID = 403";
            OracleDataReader rdr10 = cmd.ExecuteReader();
            while (rdr10.Read())
            {
                int VOL = rdr10.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(B3_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(B3_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(B3_Gp, 1);
                }
                B3_Gp.Value = VOL;
            }
            // 블랙버튼
            cmd.CommandText = "select VOL from p_factory where ID = 501";
            OracleDataReader rdr11 = cmd.ExecuteReader();
            while (rdr11.Read())
            {
                int VOL = rdr11.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(SK_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(SK_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(SK_Gp, 1);
                }
                SK_Gp.Value = VOL;
            }
            // 레드버튼
            cmd.CommandText = "select VOL from p_factory where ID = 502";
            OracleDataReader rdr12 = cmd.ExecuteReader();
            while (rdr12.Read())
            {
                int VOL = rdr12.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(SR_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(SR_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(SR_Gp, 1);
                }
                SR_Gp.Value = VOL;
            }
            // 블루 버튼
            cmd.CommandText = "select VOL from p_factory where ID = 503";
            OracleDataReader rdr13 = cmd.ExecuteReader();
            while (rdr13.Read())
            {
                int VOL = rdr13.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(SB_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(SB_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(SB_Gp, 1);
                }
                SB_Gp.Value = VOL;
            }
            // 블랙 제품
            cmd.CommandText = "select VOL from p_factory where ID = 901";
            OracleDataReader rdr14 = cmd.ExecuteReader();
            while (rdr14.Read())
            {
                int VOL = rdr14.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(FK1_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(FK1_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(FK1_Gp, 1);
                }
                FK1_Gp.Value = VOL;
            }
            // 레드 제품
            cmd.CommandText = "select VOL from p_factory where ID = 902";
            OracleDataReader rdr15 = cmd.ExecuteReader();
            while (rdr15.Read())
            {
                int VOL = rdr15.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(FR1_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(FR1_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(FR1_Gp, 1);
                }
                FR1_Gp.Value = VOL;
            }
            // 블루 제품
            cmd.CommandText = "select VOL from p_factory where ID = 903";
            OracleDataReader rdr16 = cmd.ExecuteReader();
            while (rdr16.Read())
            {
                int VOL = rdr16.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(FB1_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(FB1_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(FB1_Gp, 1);
                }
                FB1_Gp.Value = VOL;
            }
            // 2색 제품
            cmd.CommandText = "select VOL from p_factory where ID = 904";
            OracleDataReader rdr17 = cmd.ExecuteReader();
            while (rdr17.Read())
            {
                int VOL = rdr17.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(FC2_Gp ,2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(FC2_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(FC2_Gp, 1);
                }
                FC2_Gp.Value = VOL;
            }
            // 3색 제품
            cmd.CommandText = "select VOL from p_factory where ID = 905";
            OracleDataReader rdr18 = cmd.ExecuteReader();
            while (rdr18.Read())
            {
                int VOL = rdr18.GetInt32(0);
                if (VOL < 20)
                {
                    ModifyProgressBarColor.SetState(FC3_Gp, 2);
                }
                else if (VOL < 40)
                {
                    ModifyProgressBarColor.SetState(FC3_Gp, 3);
                }
                else
                {
                    ModifyProgressBarColor.SetState(FC3_Gp, 1);
                }
                FC3_Gp.Value = VOL;
            }
        }

        private void SaveOracle()
        {
            // SQL문 지정 및 INSERT 실행
            // 검은펜 심
            cmd.CommandText = $"update p_factory set vol = {K_Gp.Value} where ID = 101";
            cmd.ExecuteNonQuery();
            // 파란펜 심
            cmd.CommandText = $"update p_factory set vol = {B_Gp.Value} where ID = 103";
            cmd.ExecuteNonQuery();
            // 빨간펜 심
            cmd.CommandText = $"update p_factory set vol = {R_Gp.Value} where ID = 102";
            cmd.ExecuteNonQuery();
            // 스프링
            cmd.CommandText = $"update p_factory set vol = {S_Gp.Value} where ID = 201";
            cmd.ExecuteNonQuery();
            // 1구 캡
            cmd.CommandText = $"update p_factory set vol = {C1_Gp.Value} where ID = 301";
            cmd.ExecuteNonQuery();
            // 2구 캡
            cmd.CommandText = $"update p_factory set vol = {C2_Gp.Value} where ID = 302";
            cmd.ExecuteNonQuery();
            // 3구 캡
            cmd.CommandText = $"update p_factory set vol = {C3_Gp.Value} where ID = 303";
            cmd.ExecuteNonQuery();
            // 1구 바디
            cmd.CommandText = $"update p_factory set vol = {B1_Gp.Value} where ID = 401";
            cmd.ExecuteNonQuery();
            // 2구 바디
            cmd.CommandText = $"update p_factory set vol = {B2_Gp.Value} where ID = 402";
            cmd.ExecuteNonQuery();
            // 3구 바디
            cmd.CommandText = $"update p_factory set vol = {B3_Gp.Value} where ID = 403";
            cmd.ExecuteNonQuery();
            // 1구 버튼
            cmd.CommandText = $"update p_factory set vol = {SK_Gp.Value} where ID = 501";
            cmd.ExecuteNonQuery();
            // 2구 버튼
            cmd.CommandText = $"update p_factory set vol = {SB_Gp.Value} where ID = 503";
            cmd.ExecuteNonQuery();
            // 3구 버튼
            cmd.CommandText = $"update p_factory set vol = {SR_Gp.Value} where ID = 502";
            cmd.ExecuteNonQuery();
            // 검은펜 제품
            cmd.CommandText = $"update p_factory set vol = {FK1_Gp.Value} where ID = 901";
            cmd.ExecuteNonQuery();
            // 빨간펜 제품
            cmd.CommandText = $"update p_factory set vol = {FR1_Gp.Value} where ID = 902";
            cmd.ExecuteNonQuery();
            // 파란펜 제품
            cmd.CommandText = $"update p_factory set vol = {FB1_Gp.Value} where ID = 903";
            cmd.ExecuteNonQuery();
            // 2구 제품
            cmd.CommandText = $"update p_factory set vol = {FC2_Gp.Value} where ID = 904";
            cmd.ExecuteNonQuery();
            // 3구 제품
            cmd.CommandText = $"update p_factory set vol = {FC3_Gp.Value} where ID = 905";
            cmd.ExecuteNonQuery();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void Movebal()          //사진1 움직임
        {


            X = pictureBox1.Location.X.GetHashCode();
            Y = pictureBox1.Location.Y.GetHashCode();

            int i, j;

            i = 0;
            j = 51;
            pictureBox1.Visible = true;
            pictureBox5.Visible = false;
            pictureBox1.Location = new Point(i, j);
            /*while(j < 148)
            {
                j += 10;
                Thread.Sleep(10);           //y축
                pictureBox1.Location = new Point(i, j);
            }*/
            while (i < 50)
            {
                i += 10;
                Thread.Sleep(10);                    //x축
                pictureBox1.Location = new Point(i, j);
            }


        }

        private void Movebal2() //사진2 움직임
        {
            X = pictureBox2.Location.X.GetHashCode();
            Y = pictureBox2.Location.Y.GetHashCode();

            int i, j;

            i = 50;
            j = 51;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Location = new Point(i, j);
            /*while(j < 148)
            {
                j += 10;
                Thread.Sleep(10);           //y축
                pictureBox1.Location = new Point(i, j);
            }*/
            while (i < 280)
            {
                i += 10;
                Thread.Sleep(10);                    //x축
                pictureBox2.Location = new Point(i, j);
            }


        }


        private void Movebal3()  //사진 3 움직임
        {
            X = pictureBox3.Location.X.GetHashCode();
            Y = pictureBox3.Location.Y.GetHashCode();

            int i, j;

            i = 280;
            j = 51;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Location = new Point(i, j);
            /*while(j < 148)
            {
                j += 10;
                Thread.Sleep(10);           //y축
                pictureBox1.Location = new Point(i, j);
            }*/
            while (i < 510)
            {
                i += 10;
                Thread.Sleep(10);                    //x축
                pictureBox3.Location = new Point(i, j);
            }


        }

        private void Movebal4()  //사진4 움직임
        {
            X = pictureBox4.Location.X.GetHashCode();
            Y = pictureBox4.Location.Y.GetHashCode();

            int i, j;

            i = 510;
            j = 51;
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Location = new Point(i, j);
            /*while(j < 148)
            {
                j += 10;
                Thread.Sleep(10);           //y축
                pictureBox1.Location = new Point(i, j);
            }*/
            while (i < 740)
            {
                i += 10;
                Thread.Sleep(10);                    //x축
                pictureBox4.Location = new Point(i, j);
            }



        }

        private void Movebal5()  //사진5 움직임 후 Restart
        {
            X = pictureBox5.Location.X.GetHashCode();
            Y = pictureBox5.Location.Y.GetHashCode();

            int i, j;

            i = 740;
            j = 51;
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Location = new Point(i, j);
            /*while(j < 148)
            {
                j += 10;
                Thread.Sleep(10);           //y축
                pictureBox1.Location = new Point(i, j);
            }*/
            while (i < 970)
            {
                i += 10;
                Thread.Sleep(10);                    //x축
                pictureBox5.Location = new Point(i, j);
            }

        }
        public void Error_Blink(PictureBox pic)
        {
            int i = 0;

            for (i = 0; i < 5; i++)
            {
                pic.Visible = false;
                Application.DoEvents();
                Thread.Sleep(100);
                pic.Visible = true;
                Application.DoEvents();
                Thread.Sleep(100);
            }
        }
        public void Picture_Off(PictureBox pic)
        {
            pic.Visible = false;
        }

        public void Picture_Location(PictureBox pic, int x, int y, bool visible, PictureBoxSizeMode sizemode)
        {
            X = pic.Location.X.GetHashCode();
            Y = pic.Location.Y.GetHashCode();
            int i, j;
            i = x;                 //X
            j = y;                 //Y
            pic.Location = new Point(i, j);

            pic.Visible = visible;
            //pic.Load(Properties.Resources.error);//이미지박스 이미지 변경
            pic.SizeMode = sizemode;
        }
        private void Error_Click(object sender, EventArgs e)
        {
            flag = true;
            label19.BackColor = Color.Red;
            if (state == 1)
            {
                Picture_Location(pictureBox6, 275, 400, true, PictureBoxSizeMode.StretchImage);
                Error_Blink(pictureBox6);
            }
            if (state == 2)
            {
                Picture_Location(pictureBox6, 504, 400, true, PictureBoxSizeMode.StretchImage);
                Error_Blink(pictureBox6);
            }
            if (state == 3)
            {
                Picture_Location(pictureBox6, 733, 400, true, PictureBoxSizeMode.StretchImage);
                Error_Blink(pictureBox6);
            }
            if (state == 4)
            {
                Picture_Location(pictureBox6, 970, 400, true, PictureBoxSizeMode.StretchImage);
                Error_Blink(pictureBox6);
            }
            if (state == 5)
            {
                Picture_Location(pictureBox6, 1200, 400, true, PictureBoxSizeMode.StretchImage);
                Error_Blink(pictureBox6);
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            flag = true;
            label19.BackColor = Color.Orange;
            Picture_Off(pictureBox6);
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            flag = false;
            label19.BackColor = Color.YellowGreen;
            Run();
            Picture_Off(pictureBox6);
        }
        private void K_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(K_Gp, $"{Convert.ToInt32(K_Gp.Value)}/100");
        }
        private void B_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(B_Gp, $"{Convert.ToInt32(B_Gp.Value)}/100");
        }
        private void R_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(R_Gp, $"{Convert.ToInt32(R_Gp.Value)}/100");
        }
        private void S_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip4.SetToolTip(S_Gp, $"{Convert.ToInt32(S_Gp.Value)}/100");
        }

        private void C1_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip5.SetToolTip(C1_Gp, $"{Convert.ToInt32(C1_Gp.Value)}/100");
        }

        private void C2_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip6.SetToolTip(C2_Gp, $"{Convert.ToInt32(C2_Gp.Value)}/100");
        }

        private void C3_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip7.SetToolTip(C3_Gp, $"{Convert.ToInt32(C3_Gp.Value)}/100");
        }

        private void B1_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip8.SetToolTip(B1_Gp, $"{Convert.ToInt32(B1_Gp.Value)}/100");
        }

        private void B2_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip9.SetToolTip(B2_Gp, $"{Convert.ToInt32(B2_Gp.Value)}/100");
        }

        private void B3_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip10.SetToolTip(B3_Gp, $"{Convert.ToInt32(B3_Gp.Value)}/100");
        }

        private void SK_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip11.SetToolTip(SK_Gp, $"{Convert.ToInt32(SK_Gp.Value)}/100");
        }

        private void SB_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip12.SetToolTip(SB_Gp, $"{Convert.ToInt32(SB_Gp.Value)}/100");
        }

        private void SR_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip13.SetToolTip(SR_Gp, $"{Convert.ToInt32(SR_Gp.Value)}/100");
        }

        private void FK1_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip14.SetToolTip(FK1_Gp, $"{Convert.ToInt32(FK1_Gp.Value)}/100");
        }

        private void FR1_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip15.SetToolTip(FR1_Gp, $"{Convert.ToInt32(FR1_Gp.Value)}/100");
        }

        private void FB1_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip16.SetToolTip(FB1_Gp, $"{Convert.ToInt32(FB1_Gp.Value)}/100");
        }

        private void FC2_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip17.SetToolTip(FC2_Gp, $"{Convert.ToInt32(FC2_Gp.Value)}/100");
        }


        private void FC3_Gp_MouseHover(object sender, EventArgs e)
        {
            toolTip18.SetToolTip(FC3_Gp, $"{Convert.ToInt32(FC3_Gp.Value)}/100");
        }

    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}