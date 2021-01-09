using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Factory
{
    public partial class Form2 : Form
    {
        OracleCommand cmd;

        List<product> list = new List<product>();
        List<TextBox> txt = new List<TextBox>();

        public Form2(OracleCommand cmd)
        {
            InitializeComponent();
            this.cmd = cmd;
        }


        private void Save01_Click_1(object sender, EventArgs e)
        {
            string[] text_names =
            {
                "Add_K", "Add_R" , "Add_B", "Add_Spring", "Add_C1", "Add_C2", "Add_C3", "Add_Body1", "Add_Body2", "Add_Body3",
                "Add_Sbt1", "Add_Sbt2", "Add_Sbt3"
            };

            foreach (var item in text_names)
            {
                Control[] ccc = this.Controls.Find(item, true);
                txt.Add((TextBox)ccc[0]);
            }

            cmd.CommandText = "select * from (select * from p_factory order by ID) where RowNum <14";

            // 결과 리더 객체를 리턴
            OracleDataReader rdr = cmd.ExecuteReader();
            // 레코드 계속 가져와서 루핑
            while (rdr.Read())
            {
                string ID = rdr["ID"].ToString();
                string NAME = rdr["NAME"].ToString();
                string VOL = rdr["VOL"].ToString();
                string PRICE = rdr["PRICE"].ToString();

                list.Add(new product(ID, NAME, VOL, PRICE));
            }

            for (int z = 0; z < list.Count; z++)
            {
                int total = Convert.ToInt32(list[z].VOL) + Convert.ToInt32(txt[z].Text);
                if (total > 100)
                {
                    MessageBox.Show($"{list[z].NAME}가 {total - 100}가 초과 되었습니다");
                    //MessageBox.Show($"재입력요청");
                    //return;
                }
            }

            for (int z = 0; z < list.Count; z++)
            {
                cmd.CommandText = $"update p_factory set VOL = (CASE WHEN VOL+{txt[z].Text} >= 100 THEN 100 ELSE VOL+{txt[z].Text} END) where ID = {list[z].ID}";
                cmd.ExecuteNonQuery();
            }


            //// 볼펜 심 재고 추가
            //string a = Add_K.Text;
            //string b = Add_R.Text;
            //string c = Add_B.Text;

            //cmd.CommandText = $"update p_factory set VOL = (CASE WHEN VOL+{a} >= 100 THEN 100 ELSE VOL+{a} END) where ID = 101";
            //cmd.ExecuteNonQuery();

            //cmd.CommandText = $"update p_factory set VOL = VOL + {b} where ID = 102";
            //cmd.ExecuteNonQuery();

            //cmd.CommandText = $"update p_factory set VOL = VOL + {c} where ID = 103";
            //cmd.ExecuteNonQuery();

            //// 스프링 재고 추가
            //string d = Add_Spring.Text;
            //cmd.CommandText = $"update p_factory set VOL = VOL + {d} where ID = 201";
            //cmd.ExecuteNonQuery();

            //// 뚜껑 재고 추가
            //string f = Add_C1.Text;
            //string g = Add_C2.Text;
            //string h = Add_C3.Text;

            //cmd.CommandText = $"update p_factory set VOL = VOL + {f} where ID = 301";  // 단색 캡
            //cmd.ExecuteNonQuery();

            //cmd.CommandText = $"update p_factory set VOL = VOL + {g} where ID = 302";  // 2색 캡
            //cmd.ExecuteNonQuery();

            //cmd.CommandText = $"update p_factory set VOL = VOL + {h} where ID = 303";  // 3색 캡
            //cmd.ExecuteNonQuery();

            //// 몸통 재고 추가

            //string i = Add_Body1.Text;
            //string j = Add_Body2.Text;
            //string k = Add_Body3.Text;

            //cmd.CommandText = $"update p_factory set VOL = VOL + {i} where ID = 401";  //  단색 바디
            //cmd.ExecuteNonQuery();

            //cmd.CommandText = $"update p_factory set VOL = VOL + {j} where ID = 402";  // 2색 바디
            //cmd.ExecuteNonQuery();

            //cmd.CommandText = $"update p_factory set VOL = VOL + {k} where ID = 403";  // 3색 바디 
            //cmd.ExecuteNonQuery();


            //// 버튼 재고 추가 
            //string o = Add_Sbt1.Text;
            //string p = Add_Sbt2.Text;
            //string q = Add_Sbt3.Text;

            //cmd.CommandText = $"update p_factory set VOL = VOL + {o} where ID = 501";  // black 버튼
            //cmd.ExecuteNonQuery();

            //cmd.CommandText = $"update p_factory set VOL = VOL + {p} where ID = 502";  // red 버튼
            //cmd.ExecuteNonQuery();

            //cmd.CommandText = $"update p_factory set VOL = VOL + {q} where ID = 503";  // blue 버튼 
            //cmd.ExecuteNonQuery();


            this.Close();
        }
    }
}