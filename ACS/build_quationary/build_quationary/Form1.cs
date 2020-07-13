using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace build_quationary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public  DataTable CsvToDataTable(string filename, string seperator)
        {
            int t = 0;
            DataTable dt = new DataTable();
            bool isFirst = true;
            using (System.IO.FileStream fs = new System.IO.FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (System.IO.StreamReader sr = new StreamReader(fs, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        var eachLineStr = sr.ReadLine();

                        string[] rows = eachLineStr.Split(new string[] { seperator }, StringSplitOptions.None);

                        //exclude first line
                        if (isFirst)
                        {
                            for (int i = 0; i < rows.Length; i++)
                            {
                                dt.Columns.Add();
                            }
                            isFirst = false;
                            continue;
                        }
                        //split string to array of string use seperator
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < int.Parse(collength.Text); i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                        t++;
                    }
                }
            }
            return dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //< form class="radio_btn">
            //1.在每一天或每一週的練習，我都會設立一個特別的目標來引導自己練習。
            //<br>
            //<input type = "radio" name="question1" value="Taipei"> 男<br>
            //<input type = "radio" name="question1" value="Taoyuan"> 女<br>
            //<input type = "radio" name="question1" value="Taipei"> 男<br>
            //<input type = "radio" name="question1" value="Taoyuan"> 女<br>
            //</form>
            //<br>
            int t = 0;
            DataTable dt = CsvToDataTable("qn1.csv", ",");
            string str = "";
            for (int i = 0; i < int.Parse(rowcount.Text); i++)
            {
                str +="<form class=\"radio_btn\">" + "\r\n";
                str += dt.Rows[i][0].ToString() + "\r\n";
                str += "<br>" + "\r\n";
                str += "<input type = \"radio\" name = \"question" + (i + 1) +"\" value = \"1\"  id=\"tem"+t+ "\"> <label for=\"tem" + t + "\">1 幾乎沒有</label> <br>" + "\r\n";t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"2\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 2 偶爾有 </label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"3\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\">3 常常 </label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"4\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\">4 幾乎都是 </label> <br>" + "\r\n"; t++;
                str += "<br>" + "</form>\r\n";
            }
            output.Text = str;
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            int t = 0;
            DataTable dt = CsvToDataTable("qn2.csv", ",");
            string str = "";
            for (int i = 0; i < int.Parse(rowcount.Text); i++)
            {
                str += "<form class=\"radio_btn\">" + "\r\n";
                str += dt.Rows[i][0].ToString() + "\r\n";
                str += "<br>" + "\r\n";
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"1\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 1 幾乎不會</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"2\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 2 很少</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"3\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 3 偶而</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"4\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 4 經常</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"5\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 5 幾乎都是</label> <br>" + "\r\n"; t++;
                str += "<br>" + "</form>\r\n";
            }
            output.Text = str;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int t = 0;
            DataTable dt = CsvToDataTable("qn3.csv", ",");
            string str = "";
            for (int i = 0; i < int.Parse(rowcount.Text); i++)
            {
                str += "<form class=\"radio_btn\">" + "\r\n";
                str += dt.Rows[i][0].ToString() + "\r\n";
                str += "<br>" + "\r\n";
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"1\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 1 幾乎沒有</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"2\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 2 偶爾有</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"3\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 3 常常</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"4\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 4 幾乎都是</label> <br>" + "\r\n"; t++;
                str += "<br>" + "</form>\r\n";
            }
            output.Text = str;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int t = 0;
            DataTable dt = CsvToDataTable("qn4.csv", ",");
            string str = "";
            for (int i = 0; i < int.Parse(rowcount.Text); i++)
            {
                switch (i+1)
                {
                    case 1:
                        str += "<h2>一、技巧意象</h2>" + "\r\n";
                    break;
                    case 4:
                        str += "<h2>二、策略意象</h2>" + "\r\n";
                    break;
                    case 8:
                        str += "<h2>三、目標意象</h2>" + "\r\n";
                    break;
                    case 12:
                        str += "<h2>四、情緒意象</h2>" + "\r\n";
                    break;
                    case 15:
                        str += "<h2>五、精熟意象</h2>" + "\r\n";
                    break;
                    default:
                        break;
                }
                str += "<form class=\"radio_btn\">" + "\r\n";
                str += dt.Rows[i][0].ToString() + "\r\n";
                str += "<br>" + "\r\n";
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"1\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 1 非常不同意</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"2\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 2 不同意</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"3\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 3 無意見</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"4\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 4 同意</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"5\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 5 非常同意</label> <br>" + "\r\n"; t++;
                str += "<br>" + "</form>\r\n";
            }
            output.Text = str;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DataTable dt = CsvToDataTable("qn5.csv", ",");
            string str = "";
            int t = 0;
            for (int i = 0; i < int.Parse(rowcount.Text); i++)
            {
                switch (i + 1)
                {
                    case 1:
                        str += "<h2>一、清楚回饋</h2>" + "\r\n";
                        break;
                    case 4:
                        str += "<h2>二、勝任感 </h2>" + "\r\n";
                        break;
                    case 15:
                        str += "<h2>三、掌控自如</h2>" + "\r\n";
                        break;
                    case 18:
                        str += "<h2>四、專注力</h2>" + "\r\n";
                        break;
                    case 22:
                        str += "<h2>五、自成性</h2>" + "\r\n";
                        break;
                    default:
                        break;
                }
                str += "<form class=\"radio_btn\">" + "\r\n";
                str += dt.Rows[i][0].ToString() + "\r\n";
                str += "<br>" + "\r\n";
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"1\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 1 非常不同意</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"2\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 2 不同意</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"3\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 3 無意見</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"4\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 4 同意</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"5\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 5 非常同意</label> <br>" + "\r\n"; t++;
                str += "<br>" + "</form>\r\n";
            }
            output.Text = str;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int t = 0;
            DataTable dt = CsvToDataTable("qn6.csv", ",");
            string str = "";
            for (int i = 0; i < int.Parse(rowcount.Text); i++)
            {
                str += "<form class=\"radio_btn\">" + "\r\n";
                str += dt.Rows[i][0].ToString() + "\r\n";
                str += "<br>" + "\r\n";
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"1\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 1 幾乎沒有</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"2\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 2 偶爾有</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"3\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 3 常常有</label> <br>" + "\r\n"; t++;
                str += "<br>" + "</form>\r\n";
            }
            output.Text = str;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int t = 0;
            DataTable dt = CsvToDataTable("qn7.csv", ",");
            string str = "";
            for (int i = 0; i < int.Parse(rowcount.Text); i++)
            {
                str += "<form class=\"radio_btn\">" + "\r\n";
                str += dt.Rows[i][0].ToString() + "\r\n";
                str += "<br>" + "\r\n";
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"1\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 1 非常不同意</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"2\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 2 不同意</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"3\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 3 有點不同意</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"4\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 4 不太確定</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"5\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 5 有點同意</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"6\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 6 同意</label> <br>" + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (i + 1) + "\" value = \"7\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> 7 非常同意</label> <br>" + "\r\n"; t++;
                str += "<br>" + "</form>\r\n";
            }
            output.Text = str;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            //             <h3> 第一題 </h3>
            //              <sapn > A 能和別人相處融洽
            //                              , B 對自己沒有信心
            //                              , C 能徹底執行任何一項工作
            //                              , D容易有點情緒化
            //              </sapn>
            //              < form class="radio_btn"> 
            //              <br><br>最像:
            //              <input type = "radio" name = "question1" value = "1" > A
            //              <input type = "radio" name = "question1" value = "2" > B
            //              <input type = "radio" name = "question1" value = "3" > C
            //              <input type = "radio" name = "question1" value = "4" > D
            //              <br> </ form>
            //              <form class="radio_btn"> 
            //              <br>最不像:
            //              <input type = "radio" name = "question2" value = "1" > A
            //              <input type = "radio" name = "question2" value = "2" > B
            //              <input type = "radio" name = "question2" value = "3" > C
            //              <input type = "radio" name = "question2" value = "4" > D<br>
            //              <br></ form >
            int t = 0;
            DataTable dt = CsvToDataTable("qn8.csv", ",");
            string str = "";
            int k = 1;
            for (int i = 0; i < int.Parse(rowcount.Text); i++)
            {
                str += "<h3> 第 "+ (i+1).ToString() +" 題 </h3>" + "\r\n";
                str += "<span>" + dt.Rows[i][0].ToString() + ", " + dt.Rows[i][1].ToString() + ", " + dt.Rows[i][2].ToString() + ", " + dt.Rows[i][3].ToString() + "</span>\r\n";
                str += "<form class=\"radio_btn\"><br><br>最像:" + "\r\n";
                str += "<input type = \"radio\" name = \"question" + (k) + "\" value = \"1\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> A " + "</label> " + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (k) + "\" value = \"2\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> B " + "</label> " + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (k) + "\" value = \"3\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> C " + "</label> " + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (k) + "\" value = \"4\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> D " + "</label> " + "\r\n"; t++;
                str += "<br>" + "</form>\r\n";
                k++;
                str += "<form class=\"radio_btn\"><br>最不像:" + "\r\n";
                str += "<form class=\"radio_btn\"><br>最不像:" + "\r\n";
                str += "<input type = \"radio\" name = \"question" + (k) + "\" value = \"1\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> A " + "</label> " + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (k) + "\" value = \"2\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> B " + "</label> " + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (k) + "\" value = \"3\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> C " + "</label> " + "\r\n"; t++;
                str += "<input type = \"radio\" name = \"question" + (k) + "\" value = \"4\" id=\"tem" + t + "\"> <label for=\"tem" + t + "\"> D " + "</label> " + "\r\n"; t++;
                str += "<br>" + "</form>\r\n";
                ++k;
            }
            output.Text = str;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            DataTable dt = CsvToDataTable("qn"+textBox1.Text+".csv", ",");
            string str = "編號,";
            for (int i = 0; i < int.Parse(rowcount.Text); i++)
            {
                str += dt.Rows[i][0].ToString() + ",";
            }
            output.Text = str + "紀錄日期,";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            DataTable dt = CsvToDataTable("qnt" + textBox1.Text + ".csv", ",");
            string str = "編號,";
            for (int i = 0; i < int.Parse(rowcount.Text); i++)
            {
                str += dt.Rows[i][0].ToString() + ","+dt.Rows[i][1]+",";
            }
            output.Text = str + "紀錄日期,";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            int[] q_count = new int[9] { 19, 28, 31, 21, 18, 25, 14, 16, 76 };
            string s = "abcdefghi";
            string str = "num : num, ";
            int k = 0;
            foreach(var i in q_count)
            {
                for(int j=1;j<= i; j++)
                {
                    str += s[k] + j.ToString() +" : NA, ";
                }
                k++;
            }
            output.Text = str;
        }
    }
}
