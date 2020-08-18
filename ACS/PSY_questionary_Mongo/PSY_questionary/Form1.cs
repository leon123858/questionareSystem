using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Globalization;
using System.Data.Common;
using System.Diagnostics;

namespace PSY_questionary
{
    public partial class Form1 : Form
    {
        static int[] q_count = new int[9] { 19, 28, 31, 21, 18, 25, 14, 16, 76 };
        static string[] csv_title = new string[9];
        static string uri = "mongodb://127.0.0.1:27017";
        void read_txt_to_list()
        {
            StreamReader sr = new StreamReader("ListNumber.txt", System.Text.Encoding.UTF8);
            while(sr.Peek() > -1) { ListNumber.Items.Add(sr.ReadLine());}
            sr.Close();
        }
        public Form1()
        {
            InitializeComponent();
            csv_title[0] = "姓名,性別,年齡,生日,身份證字號,身高(cm),體重(kg),聯絡電話,聯絡地址?,常用Email,就讀學校,系級,接觸桌球之球齡,近兩年最佳成績表現,平時慣用手,打桌球時慣用手,教練,一對一練習時數,團練時數,";
            csv_title[1] = "1. 在每一天或每一週的練習，我都會設立一個特別的目標來引導自己練習。,2. 我會把自己最大的天份及技能表現出來。 ,3. 當教練告訴我如何改正錯誤時，我傾向於獨自承受並且 感到煩惱。,4. 當我在從事運動時，我能夠集中注意力而不會分心。,5. 在比賽時無論情況如何糟糕，我會保持積極及熱忱的態度。,6. 在有壓力下我傾向於會表現的更好，因為腦筋會更清楚。,7. 我相當擔心別人對於我的表現的看法。,8. 為了達到自己的目標，我會傾向於做一些計劃。,9. 我對於自己即將會表現的很好相當有信心。,10. 當教練批評我時，我會感到煩惱而不是得到幫助。,11. 當我聽到或看到什麼時，並不會產生分離思考而造成干擾，這對我來說是容易的。,12. 我會擔心自己的表現，因此給自己很多壓力。,13. 在每一次的練習中，我會設定自己的表現目標。,14. 我不必別人催我努力練習，也會 100%的付出。,15. 假如教練對我有所批評或大叫時，我會改正錯誤而不會覺得很難過。,16. 在我的運動領域中，對於一些突發的狀況我能夠處理的很好。,17. 當事情變糟時，我通常會告訴自己冷靜下來，而且非常有效。,18. 比赛中的壓力越大時，我越能夠享受它。,19. 在比赛時，我會害怕犯錯或無法成功。,20. 比賽開始之前，在我的腦海中已經蘊釀了一套自己的比賽計劃。,21. 當我覺得自己太緊張時，我能夠很快的放鬆身體並且鎮定下來。,22. 有壓力的情境對我而言是一種挑戰，我樂於接受。,23. 我會想像如果自己失敗或放棄了會發生什麼事。,24. 無論發生什麼事情，我都能控制自己的情緒。,25. 我能夠很容易的引導自己的注意力焦點在單一的人或物體上。,26. 當我沒有達到目標時，會激勵我更加的努力。 ,27. 我會仔細的聆聽教練的指示及建議，並以此來改善自己的技術。,28. 當壓來臨時我很少犯錯，因為我會更專注。,";
            csv_title[2] = "1. 每次一練習，我會設定自己想達成的目標。,2. 練習時，不用教練督促，我會自動自發的練習。,3. 我可以將注意力集中在比賽上而不分心。,4. 我會仔細聆聽教練的忠告和指示而獲得技巧的進步。,5. 當我設定的目標未達成時，我會更努力的練習。,6. 比賽或練習我總是全力以赴，不需要被別人強迫表現。,7. 比賽中我很容易受到一些因素的干擾而分心。,8. 對教練的指示我會虛心接受與遵照行事。,9. 對於平常的訓練，我會有很高的自我要求。,10. 當比賽氣氛越緊張時，我越能感受比賽的樂趣。,11. 比賽中遇到不滿意的情況時，我會激勵自己振作。,12. 比賽中我會一直想到剛才的失誤，而無法集中注意力在比賽上。,13. 我常懷疑自己的運動實力。,14. 我會做許多規劃以達到自己的目標。,15. 在比賽中，我會因為觀眾的干擾而分心。,16. 我覺得自己的各方面條件都比對手好。,17. 教練或別人對我的批評，我會參考反省改進。,18. 在平常的訓練外，我會再另外找時間練習。,19. 我喜歡把有壓力感覺的比賽視為一種挑戰。,20. 當感覺到自己太緊張時，我能夠很快的放鬆身體並且鎮定下來。,21. 我會虛心接受教練的指導與糾正。,22. 我對自己的運動技術很有信心。,23. 我會以每天或每週為單元，設定訓練的目標來引導自己練習。,24. 外界的壓力不會影響到我的表現。,25. 比賽中我可以運用放鬆技巧以紓解壓力。,26. 當比賽場上情況變糟時，我會告訴自己要保持冷靜。,27. 當教練告訴我要如何改正錯誤動作時，我會認為他是在找我麻煩。,28. 面對失誤與挫折時，我會運用正面思考的策略穩定自己情緒。,29. 失誤時我能冷靜思考、自我調整，避免再失誤。,30. 我會要求自己比別人多花一些時間練習。,31. 我有信心在比賽中會表現的很好。,";
            csv_title[3] = "1. 我感到輕鬆自在。,2. 我覺得神經過敏。,3. 我感到舒適。,4. 我擔心自己無法在比賽中發揮應有的實力。,5. 我覺得有自信。,6. 我擔心輸掉比賽。,7．我覺得胃部緊縮。,8．我感到安心。 ,9．我有信心克服挑戰。,10. 我擔心表現不佳。,11. 我心跳急速。,12. 我有信心表現良好。,13. 我擔心是否能達成自己的目標。,14. 我感到胃下垂。,15. 我心情覺得輕鬆。,16. 我擔心其他人對我的表現感到失望。,17．我的手心出汗。,18．我有自信，因為我預計能達到自己的目標。,19．我擔心自己無法專注比賽。,20. 我感到全身緊繃。,21．我有信心突破壓力。 ,";
            csv_title[4] = "1. 我想像自己能修正發球技術上的缺點。,2. 我想像自己修正發球動作的技巧。,3. 我想像成功地執行發球技巧。,4. 我在腦中想像發球的戰術。,5. 為了預防戰而失效，我可以想像替代的策略。,6. 我想像擬定未來的比賽計畫。, 7. 我想像比賽計畫的每個細節（例如進攻與守、快慢節奏等）。,8. 我想像自己赢得一面獎牌。, 9. 我想像自己上臺領獎。,10. 我想像在比賽中贏得勝利。,11. 我想像其他運動員因為我的好表現而鼓勵我。,12. 我想像從事自己擅長的運動時，會產生正面的情緒。,13. 我想像從事擅長的運動時，會感覺到期待與興奮。,14. 我想像在運動表現時感覺到興奮。,15. 我想像即使比賽進行得不順利，仍舊付出 100%的努力。,16. 我想像自己在遭遇挫折後，依然能保持正面態度。,17. 我想像在艱難的情境中保持自信。,18. 我想像自己是堅強的。,";
            csv_title[5] = "1. 我相信我的能力足以面對桌球訓練中的挑戰。,2. 我的能力與我所面對的桌球動作大致相符合。,3. 我認為我有足夠的能力勝任更高層次的挑戰。,4. 我不需太多思考就能做出正確的動作。,5. 從事桌球運動時，我感覺我動作、呼吸順暢。,6. 我總是知道接下來要做什麼動作。,7. 我總是能很快就進入狀況，沈浸在快樂之中。,8. 我總是能很快找到我想要的感覺。 ,9. 從事桌球運動時，我會將注意力集中正在進行的動作上。,10. 從事桌球運動時，我能夠完全專注。 ,11. 我對正在進行的動作能操控自如。,12. 從事桌球運動時，我能完全控制我的身體。,13. 我感覺我能控制正在做的動作。,14. 從事桌球運動時，我總是覺得時間過得特別快。,15. 以我的專項運動項目來看，我的身材勻稱合宜。,16. 從事桌球運動時，控制好自己的身體動作對我而言是簡單的。,17. 我覺得從事桌球運動是一件非常快樂的事情。,18. 我不會在意別人如何看待我。,19. 我不必擔心我的桌球表現。,20. 從事桌球運動時，若沒其他事物提醒，我不會注意時間。,21. 從事桌球運動時，時間似乎停止了。,22. 我會專注在動作上面忘了自我。,23. 我喜歡從事桌球運動的感覺，並且想要再次獲得此感覺。,24. 從事完桌球運動後，讓我感覺很好。,25．從事桌球運動時，我樂在其中。,";
            csv_title[6] = "1．和別人比賽是一件很愉快的事。,2．在比賽前，我會感到不安。 ,3．在比賽前，我會擔心表現欠佳。 ,4．在比賽時，我是一位好的運動員。 ,5．在比賽時，我擔心失誤。 ,6．在比賽前，我是冷静的。,7．在比賽時，設定一項目標是重要的。,8．在比賽前，我會覺得反胃。 ,9．比賽前一刻，我感覺我的心跳比平常快。,10．我喜歡在耗體力的競賽中比賽。,11．在比賽前，我覺得心情輕鬆。 ,12．在比賽前，我覺得神經緊張。 ,12．在比賽前，我覺得神經緊張。 ,14．在比賽前，我感覺神經緊張，肌肉僵硬。,";
            csv_title[7] = "1. 通常我能知道自己會有某些感受的原因。,2. 我很了解自己的情緒。,3. 我真的能明白自己的感受。,4. 我常常知道自己為什麼覺得開心或不高興。,5. 遇到困難時，我能控制自己的脾氣。 ,6. 我很能控制自己的情緒。,7. 當我憤怒時，我通常能在很短的時間內冷靜下來。,8. 我對自己的情緒有很強的控制能力。,9. 我通常能為自己制定目標並盡量完成這些目標。 ,10. 我經常告訴自己是一個有能力的人。 ,11. 我是一個能鼓勵自己的人。 ,12. 我經常鼓勵自己要做到最好。,13. 我通常能從朋友的行為中猜到他們的情緒。 ,14. 我觀察別人情緒的能力很強。,15. 我能很敏銳地洞悉別人的感受和情绪。 ,16. 我很了解身邊的人的情緒。 ,";
            csv_title[8] = "1.最符合,1.最不符合,2.最符合,2.最不符合,3.最符合,3.最不符合,4.最符合,4.最不符合,5.最符合,5.最不符合,6.最符合,6.最不符合,7.最符合,7.最不符合,8.最符合,8.最不符合,9.最符合,9.最不符合,10.最符合,10.最不符合,11.最符合,11.最不符合,12.最符合,12.最不符合,13.最符合,13.最不符合,14.最符合,14.最不符合,15.最符合,15.最不符合,16.最符合,16.最不符合,17.最符合,17.最不符合,18.最符合,18.最不符合,19.最符合,19.最不符合,20.最符合,20.最不符合,21.最符合,21.最不符合,22.最符合,22.最不符合,23.最符合,23.最不符合,24.最符合,24.最不符合,25.最符合,25.最不符合,26.最符合,26.最不符合,27.最符合,27.最不符合,28.最符合,28.最不符合,29.最符合,29.最不符合,30.最符合,30.最不符合,31.最符合,31.最不符合,32.最符合,32.最不符合,33.最符合,33.最不符合,34.最符合,34.最不符合,35.最符合,35.最不符合,36.最符合,36.最不符合,37.最符合,37.最不符合,38.最符合,38.最不符合,";
            show.Text = "程式開始\r\n請先複製再進行其他操作\r\n";
            read_txt_to_list();
            pictureBox1.Image = Image.FromFile(".\\icon.png");
        }
        void setShow(string message)
        {
            show.Text += string.Format("{0}\r\n", message);
            show.Select(show.Text.Length - 1, 0);
            show.ScrollToCaret();
        }
        //備分
        void backupOne(MongoClient mongoClient, MongoClient mongoClient_local, string db, string db_backup, string table_name)
        {
            var collection = mongoClient.GetDatabase(db).GetCollection<BsonDocument>(table_name);
            var documents = collection.Find(new BsonDocument()).ToList();
            //載入在地
            var table = mongoClient_local.GetDatabase(db_backup).GetCollection<BsonDocument>(table_name);
            if (documents.Count > 0)
                table.InsertManyAsync(documents);
        }
        private void backup_Click(object sender, EventArgs e)
        {
            try
            {
                progress_word.Text = "備份進度:";
                //progressBar.Value = 0;
                //獲取雲資料
                MongoClient dbClient_cloud = new MongoClient(uri);
                MongoClient dbClient_local = new MongoClient(uri);
                //progressBar.Value += progressBar.Step * 10;
                for (int i = 0; i < q_count.Length; i++)
                {
                    backupOne(dbClient_cloud, dbClient_local, "qn","qn_b", "qn" + i);
                    //progressBar.Value += progressBar.Step * 10;
                }
                backupOne(dbClient_cloud, dbClient_local, "personq","personq_b", "personall");
                //progressBar.Value = 100;
                setShow("完成資料備份");
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupbox3.Enabled = true;
            }
            catch (Exception et)
            {
                setShow(et.Message);
            }
        }
        string getOutPut(string str)
        {
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                {
                    if (!string.IsNullOrEmpty(dataGridView[j, i].Value.ToString()))
                    {
                        if (j > 0)
                            str = str + "," + dataGridView[j, i].Value.ToString();
                        else
                        {
                            if (string.IsNullOrEmpty(str))
                                str = dataGridView[j, i].Value.ToString();
                            else
                                str = str + Environment.NewLine + dataGridView[j, i].Value.ToString();
                        }
                    }
                }
            }
            return str;
        }

        private void outCSV_one_Click(object sender, EventArgs e)
        {
            string input_date2 = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                input_date2 = folderBrowserDialog1.SelectedPath;
            string strValue = string.Empty;
            //CSV 匯出的標題 要先塞一樣的格式字串 充當標題
            strValue = "編號," + csv_title[show_which_qn.Value] + "紀錄日期,";
            strValue = getOutPut(strValue);
            //存成檔案（注意！！當有中文字的時候 存檔案一定要用 UTF8）
            string strFile = input_date2 + "/page" + show_which_qn.Value.ToString() + ".csv";
            try
            {
                if (!string.IsNullOrEmpty(strValue))
                {
                    File.WriteAllText(strFile, HttpUtility.UrlDecode(strValue), Encoding.UTF8);
                    setShow("輸出第" + show_which_qn.Value.ToString() + "為CSV檔成功");
                }
            }
            catch (Exception et)
            {
                setShow(et.Message);
            }
        }
        //private void transformOne(MongoClient mongoClient, int q,string mode)
        //{
        //    var dbplace = "";
        //    if (mode == "delete")
        //        dbplace = "qn";
        //    else
        //        dbplace = "qn_b";
        //    var collection = mongoClient.GetDatabase(dbplace).GetCollection<BsonDocument>("qn" + q);
        //    var documents = collection.Find(new BsonDocument()).ToList();
        //    if (documents.Count > 0)
        //    {
        //        //寫下SQL指令
        //        String strSQL = "INSERT INTO page" + q + " VALUES ";
        //        foreach (var doc in documents)
        //        {
        //            string innerstr = "";
        //            for (int j = 1; j <= q_count[q]; j++)
        //            {
        //                innerstr += "', '" + doc[j.ToString()];
        //            }
        //            strSQL += " ('" + doc["num"] + innerstr + "', '" + doc["date"] + "'),";
        //        }
        //        //去尾逗號
        //        strSQL = strSQL.Substring(0, strSQL.Length - 1);
        //        //下命令
        //        SqlConnection sqlConn = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
        //        "AttachDbFilename=|DataDirectory|Database.mdf;" + "Initial Catalog = MyNotAutoNamedDb;" +
        //        "Integrated Security=True");
        //        sqlConn.Open();
        //        SqlCommand sqlcommand = new SqlCommand(strSQL, sqlConn);
        //        sqlcommand.ExecuteNonQuery();
        //        sqlConn.Close();
        //        //刪去雲端data
        //        if (mode == "delete")
        //        {
        //            foreach (var i in documents)
        //            {
        //                collection.DeleteManyAsync(i);
        //            }
        //        }
        //    }
        //}
        //private void dataTransform_Click(object sender, EventArgs e)
        //{
        //    progress_word.Text = "轉移進度:";
        //    progressBar.Value = 0;
        //    try
        //    {
        //        MongoClient dbClient_cloud = new MongoClient(uri);
        //        for (int q = 0; q < q_count.Length; q++)
        //        {
        //            transformOne(dbClient_cloud, q,"delete");
        //            progressBar.Value += progressBar.Step * 10;
        //        }
        //        // delete table_all 的 data
        //        var collection2 = dbClient_cloud.GetDatabase("personq").GetCollection<BsonDocument>("personall");
        //        var documents2 = collection2.Find(new BsonDocument()).ToList();
        //        progressBar.Value += progressBar.Step * 10;
        //        foreach (var i in documents2)
        //        {
        //            collection2.DeleteManyAsync(i);
        //        }
        //        progressBar.Value = 100;
        //        setShow("完成資料轉移");
        //    }
        //    catch (Exception et)
        //    {
        //        setShow(et.Message);
        //    }
        //}
        void show_one_on_datagrid(int num)
        {
            progress_word.Text = "顯示進度:";
            //progressBar.Value = 0;
            MongoClient dbClient_local = new MongoClient(uri);
            //progressBar.Value += progressBar.Step * 1;
            var table = dbClient_local.GetDatabase("qn").GetCollection<BsonDocument>("qn" + num);
            var document = table.Find(new BsonDocument()).ToList();
            //progressBar.Value += progressBar.Step * 1;
            if (document.Count > 0)
            {
                DataTable dt = new DataTable();
                for (int j = 1; j < q_count[num] + 3; j++)
                {
                    dt.Columns.Add(j.ToString(), typeof(string));
                }
                //progressBar.Value += progressBar.Step * 10;
                foreach (var doc in document)
                {
                    DataRow row = dt.NewRow();
                    row[0] = doc["num"];
                    for (int k = 1; k < q_count[num] + 1; k++)
                    {
                        //int x = Int32.Parse(arrayList[k].ToString());
                        row[k] = doc[k];
                    }
                    row[q_count[num] + 1] = doc["date"];
                    dt.Rows.Add(row);
                    //progressBar.Value += progressBar.Step * 1;
                   //if (progressBar.Value > 100)
                        //progressBar.Value = 0;
                }
                //progressBar.Value += progressBar.Step * 1;
                dataGridView.DataSource = dt;
                //progressBar.Value = 90;
            }
            else
            {
                setShow("無資料");
                dataGridView.DataSource = null;
            }
        }
        private void showOnDatagrid_Click(object sender, EventArgs e)
        {
            try
            {
                show_one_on_datagrid(show_which_qn.Value);
            }
            catch (Exception et)
            {
                setShow(et.Message);
            }
            show.Text += "資料顯示第" + show_which_qn.Value.ToString() + "成功\r\n";
            outCSV_one.Enabled = true;
            outCSV_all.Enabled = false;
            //progressBar.Value = 100;
        }

        //private void Button5_Click(object sender, EventArgs e)
        //{
        //    MongoClient dbClient_local = new MongoClient("mongodb://127.0.0.1:27017");
        //    var table = dbClient_local.GetDatabase("qn").GetCollection<BsonDocument>("qn0");
        //    var list = table.Find(new BsonDocument()).ToList();
        //    String strSQL = "DELETE FROM page0";
        //    SqlConnection sqlConn = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
        //    "AttachDbFilename=|DataDirectory|Database.mdf;" + "Initial Catalog = MyNotAutoNamedDb;" +
        //    "Integrated Security=True");
        //    sqlConn.Open();
        //    SqlCommand sqlcommand = new SqlCommand(strSQL, sqlConn);
        //    sqlcommand.ExecuteNonQuery();
        //    sqlConn.Close();
        //}
        ArrayList delete_same(ArrayList ListT)
        {
            int n = 0;
            for (int ii = 0; ii < ListT.Count; ii++)
            {
                for (int jj = ii + 1; jj < ListT.Count; jj++)
                {
                    n = ListT.IndexOf(ListT[ii], jj);
                    if (n > 0)
                    {
                        ListT.RemoveAt(n);
                        jj--;
                    }
                }
            }
            return ListT;
        }
        ArrayList show_which(ArrayList arrayList)
        {
            arrayList.Add(1);
            for (int i = 0; i < show_whichForAll.Text.Length; i++)
            {
                switch (Int32.Parse(show_whichForAll.Text[i].ToString()))
                {
                    case 0://19
                        for (int j = 0; j < q_count[0]; j++)
                        {
                            arrayList.Add(2 + j);
                        }
                        break;
                    case 1://28
                        for (int j = 0; j < q_count[1]; j++)
                        {
                            arrayList.Add(21 + j);
                        }
                        break;
                    case 2://31
                        for (int j = 0; j < q_count[2]; j++)
                        {
                            arrayList.Add(49 + j);
                        }
                        break;
                    case 3://21
                        for (int j = 0; j < q_count[3]; j++)
                        {
                            arrayList.Add(80 + j);
                        }
                        break;
                    case 4://18
                        for (int j = 0; j < q_count[4]; j++)
                        {
                            arrayList.Add(101 + j);
                        }
                        break;
                    case 5://25
                        for (int j = 0; j < q_count[5]; j++)
                        {
                            arrayList.Add(119 + j);
                        }
                        break;
                    case 6://14
                        for (int j = 0; j < q_count[6]; j++)
                        {
                            arrayList.Add(144 + j);
                        }
                        break;
                    case 7://16
                        for (int j = 0; j < q_count[7]; j++)
                        {
                            arrayList.Add(158 + j);
                        }
                        break;
                    case 8://76
                        for (int j = 0; j < q_count[8]; j++)
                        {
                            arrayList.Add(174 + j);
                        }
                        break;
                    default:
                        break;
                }
            }
            arrayList.Sort();
            return delete_same(arrayList);
        }
        void show_all_on_datagrid(ArrayList arrayList)
        {
            progress_word.Text = "顯示進度:";
            //progressBar.Value = 0;
            MongoClient dbClient_local = new MongoClient(uri);
            //progressBar.Value += progressBar.Step * 1;
            var table = dbClient_local.GetDatabase("personq").GetCollection<BsonDocument>("personall");
            var document = table.Find(new BsonDocument()).ToList();
            //progressBar.Value += progressBar.Step * 1;
            if (document.Count > 0)
            {
                DataTable dt = new DataTable();
                for (int j = 1; j < arrayList.Count + 1; j++)
                {
                    dt.Columns.Add(j.ToString(), typeof(string));
                }
                //progressBar.Value += progressBar.Step * 10;
                foreach (var doc in document)
                {
                    DataRow row = dt.NewRow();
                    for (int k = 0; k < arrayList.Count; k++)
                    {
                        int x = Int32.Parse(arrayList[k].ToString());
                        row[k] = doc[x];
                    }
                    dt.Rows.Add(row);
                    //progressBar.Value += progressBar.Step * 1;
                    //if (progressBar.Value > 100)
                        //progressBar.Value = 0;
                }
                //progressBar.Value += progressBar.Step * 1;
                dataGridView.DataSource = dt;
                //progressBar.Value = 100;
            }
        }
        private void showData_all_Click(object sender, EventArgs e)
        {
            //static int[] q_count = new int[9] { 19, 28, 31, 21, 18, 25, 14, 16, 76 };
            try
            {
                if (show_whichForAll.Text.Length > 0)
                {
                    ArrayList arrayList = new ArrayList();
                    show_all_on_datagrid(show_which(arrayList));
                    show.Text += "輸出關聯圖成功\r\n";
                    outCSV_one.Enabled = false;
                    outCSV_all.Enabled = true;
                }
                else
                {
                    show.Text += "請填入想關聯哪幾號問卷\r\n";
                }
            }
            catch (Exception et)
            {
                setShow(et.Message);
            }
        }
        bool haveSelectQ(char a)
        {
            for (int i = 0; i < show_whichForAll.Text.Length; i++)
            {
                if ((int)show_whichForAll.Text[i] - 48 == (int)a)
                    return true;
            }
            return false;
        }
        private void outCSV_all_Click(object sender, EventArgs e)
        {
            string input_date2 = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                input_date2 = folderBrowserDialog1.SelectedPath;
            }
            string strValue = string.Empty;
            //CSV 匯出的標題 要先塞一樣的格式字串 充當標題
            strValue = "編號,";
            for (int i = 0; i < csv_title.Length; i++)
            {
                if (haveSelectQ((char)i))
                    strValue += csv_title[i];
            }
            strValue = getOutPut(strValue);
            //存成檔案（注意！！當有中文字的時候 存檔案一定要用 UTF8）
            string strFile = input_date2 + "/allpage" + ".csv";
            try
            {
                if (!string.IsNullOrEmpty(strValue))
                {
                    File.WriteAllText(strFile, HttpUtility.UrlDecode(strValue), Encoding.UTF8);
                    setShow("關聯圖CSV輸出成功");
                }
            }
            catch (Exception et)
            {
                setShow(et.Message);
            }
        }

        private void Show_which_qn_ValueChanged(object sender, EventArgs e)
        {
            show_qn_name.Text = "顯示第" + show_which_qn.Value.ToString() + "份問卷";
        }

        private void Show_whichForAll_Enter(object sender, EventArgs e)
        {
            show_whichForAll.Text = "";
            show_whichForAll.ForeColor = Color.Black;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            show.Text = "";
        }

        private void Show_which_qn_Scroll(object sender, EventArgs e)
        {
            outCSV_one.Enabled = false;
        }

        //private void Delete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        String strSQL = "";
        //        SqlConnection sqlConn = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
        //            "AttachDbFilename=|DataDirectory|Database.mdf;" + "Initial Catalog = MyNotAutoNamedDb;" +
        //            "Integrated Security=True");
        //        sqlConn.Open();
        //        for (int i = 0; i < q_count.Length; i++)
        //        {
        //            strSQL = "DELETE FROM page" + i.ToString();
        //            SqlCommand sqlcommand = new SqlCommand(strSQL, sqlConn);
        //            sqlcommand.ExecuteNonQuery();
        //            setShow("刪除第"+i +"個SQL完成");
        //        }
        //        sqlConn.Close();
        //    }
        //    catch (Exception et)
        //    {
        //        setShow(et.Message);
        //    }
        //}
        void delete_mongo(MongoClient dbClient_cloud,string db,string table)
        {
            try
            {
                var collection = dbClient_cloud.GetDatabase(db).GetCollection<BsonDocument>(table);
                var documents = collection.Find(new BsonDocument()).ToList();
                foreach (var i in documents)
                {
                    collection.DeleteManyAsync(i);
                }
            }catch(Exception et)
            {
                setShow(et.Message);
            }
        }
        private void Delete_middle_Click(object sender, EventArgs e)
        {
            MongoClient dbClient_cloud = new MongoClient(uri);
            for(int i = 0; i < q_count.Length; i++)
            {
                delete_mongo(dbClient_cloud, "qn", "qn" + i.ToString());
                setShow("刪除第" + i + "個mongodb's qn完成");
            }
            delete_mongo(dbClient_cloud, "personq", "personall");
            setShow("刪除連結資料完成");
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            try
            {
                progress_word.Text = "復原進度:";
                //progressBar.Value = 0;
                //獲取雲資料
                MongoClient dbClient_cloud = new MongoClient(uri);
                MongoClient dbClient_local = new MongoClient(uri);
                //progressBar.Value += progressBar.Step * 10;
                for (int i = 0; i < q_count.Length; i++)
                {
                    backupOne(dbClient_cloud, dbClient_local, "qn_b", "qn", "qn" + i);
                    //progressBar.Value += progressBar.Step * 10;
                }
                backupOne(dbClient_cloud, dbClient_local, "personq_b", "personq", "personall");
                //progressBar.Value = 100;
                setShow("完成資料回復");
            }
            catch (Exception et)
            {
                setShow(et.Message);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                progress_word.Text = "備份進度:";
                //progressBar.Value = 0;
                //獲取雲資料
                MongoClient dbClient_cloud = new MongoClient(path_to_server.Text);
                MongoClient dbClient_local = new MongoClient(uri);
                //progressBar.Value += progressBar.Step * 10;
                for (int i = 0; i < q_count.Length; i++)
                {
                    backupOne(dbClient_cloud, dbClient_local, "qn", "qn_b", "qn" + i);
                    //progressBar.Value += progressBar.Step * 10;
                }
                backupOne(dbClient_cloud, dbClient_local, "personq", "personq_b", "personall");
                //progressBar.Value = 100;
                setShow("完成資料傳輸");
            }
            catch (Exception et)
            {
                setShow(et.Message);
            }
        }

        private void Edit_text_Click(object sender, EventArgs e)
        {
            setShow("修改文字檔,儲存後關閉, 下次開啟本應用程式就會更改問卷說明內容");
            try
            {
                System.Diagnostics.Process.Start("ListNumber.txt");
            }
            catch (Exception et)
            {
                setShow(et.Message);
            }
        }

        private void Manual_Click(object sender, EventArgs e)
        {
            setShow("修改文字檔,儲存後關閉, 下次開啟本應用程式就會更改問卷說明內容");
            try
            {
                System.Diagnostics.Process.Start("Manual.pdf");
            }
            catch (Exception et)
            {
                setShow(et.Message);
            }
        }

        //private void Open_server_Click(object sender, EventArgs e)
        //{
        //    string now_path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        //    ProcessStartInfo cmd = new System.Diagnostics.ProcessStartInfo("cmd.exe");
        //    cmd.RedirectStandardInput = true;
        //    cmd.RedirectStandardOutput = true;
        //    cmd.RedirectStandardError = true;
        //    cmd.UseShellExecute = false;
        //    Process console = Process.Start(cmd);
        //    console.StandardInput.WriteLine("mongod --dbpath " + now_path + "mongoDB_local");
        //}
    }
}
