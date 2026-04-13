using StudentGradeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 成绩可视化分析
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Table();
            Table2();
            Table3();
            UpdatePieChart(); // 加载时更新饼状图
            chart1_Click(null, null); // 加载时更新图表
            chart3_Click(null, null); // 加载时更新图表
            chart4_Click(null, null);
            chart5_Click(null, null);
            chart6_Click(null, null);
        }
        //显示班级成绩表
        private void Table()
        {
            string sql = "select *from 成绩表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d,e,f,g;
                a = dr["Class"].ToString();
                b = dr["Name"].ToString();
                c = dr["Course"].ToString();
                d = dr["Grade"].ToString();
                e = dr["Total"].ToString();
                f = dr["Avg"].ToString();
                g = dr["Rank"].ToString();
                string[] str = { a, b, c, d ,e,f,g};
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }
        //显示个人成绩表
        private void Table2()
        {
            string sql = "select *from 成绩表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, e,f;
                a = dr["Class"].ToString();
                b = dr["Name"].ToString();
                c = dr["Course"].ToString();
                d = dr["Grade"].ToString();
                e = dr["Total"].ToString();
                f = dr["Rank"].ToString();
                string[] str = { a, b, c, d, e,f };
                dataGridView2.Rows.Add(str);
            }
            dr.Close();
        }
        //显示科目成绩表
        private void Table3()
        {
            string sql = "select *from 成绩表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, e, f,g;
                a = dr["Class"].ToString();
                b = dr["Name"].ToString();
                c = dr["Course"].ToString();
                d = dr["Grade"].ToString();
                e = dr["Total"].ToString();
                f = dr["Avg"].ToString();
                g = dr["CourseRank"].ToString();
                string[] str = { a, b, c, d, e, f,g };
                dataGridView3.Rows.Add(str);
            }
            dr.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 确保 chart1 有两个系列
            //if (chart1.Series.Count < 2)
            //{
            //    chart1.Series.Add(new Series("Series1"));
            //    chart1.Series.Add(new Series("Series2"));
            //}

            // 清除现有的数据点
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

        }
        private void chart1_Click(object sender, EventArgs e)
        {
            // 清除现有数据点
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!dataGridView1.Rows[i].IsNewRow) // 确保不是新行
                {
                    // 获取学生姓名
                    string studentName = dataGridView1.Rows[i].Cells[1].Value?.ToString() ?? "Unknown";

                    // 将前10行的成绩添加到 C#
                    if (i < 10)
                    {
                        if (dataGridView1.Rows[i].Cells[3].Value != null && double.TryParse(dataGridView1.Rows[i].Cells[3].Value.ToString(), out double cSharpGrade))
                        {
                            chart1.Series[0].Points.AddXY(studentName, cSharpGrade); // 添加到 C#
                            chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].ToolTip = "#VALX#,#VALY#"; // 设置提示
                        }
                    }
                    // 从第11行开始添加 CAD 成绩
                    else
                    {
                        if (dataGridView1.Rows[i].Cells[3].Value != null && double.TryParse(dataGridView1.Rows[i].Cells[3].Value.ToString(), out double cadGrade))
                        {
                            chart1.Series[1].Points.AddXY(studentName, cadGrade); // 添加到 CAD
                            chart1.Series[1].Points[chart1.Series[1].Points.Count - 1].ToolTip = "#VALX#,#VALY#"; // 设置提示
                        }
                    }
                }
            }

            // 设置图表标题和轴标签
            chart1.Titles.Clear();
            chart1.Titles.Add("成绩分布图");
            chart1.ChartAreas[0].AxisX.Title = "学生姓名";
            chart1.ChartAreas[0].AxisY.Title = "成绩";
            // 设置 X 轴标签格式
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1; // 标记每个 X 值
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // 设置标签倾斜
        }


        // 更新饼状图
        private void UpdatePieChart()
        {
            // 清除现有数据点
            chart2.Series.Clear();
            chart2.Legends.Clear();

            // 创建新的系列
            Series series = new Series("成绩分布")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true // 显示数值标签
            };
            // 定义成绩区间
            string[] categories = { "50-60", "60-65", "65-70", "70-80", "80-90" };
            int[] counts = new int[categories.Length];

            // 遍历 dataGridView1 计算每个区间的数量
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!dataGridView1.Rows[i].IsNewRow)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value != null && double.TryParse(dataGridView1.Rows[i].Cells[3].Value.ToString(), out double grade))
                    {
                        if (grade >= 50 && grade < 60) counts[0]++;
                        else if (grade >= 60 && grade < 65) counts[1]++;
                        else if (grade >= 65 && grade < 70) counts[2]++;
                        else if (grade >= 70 && grade < 80) counts[3]++;
                        else if (grade >= 80 && grade < 90) counts[4]++;
                    }
                }
            }
            // 添加数据点到饼状图
            for (int j = 0; j < categories.Length; j++)
            {
                if (counts[j] > 0)
                {
                    series.Points.AddXY(categories[j], counts[j]);
                    // 设置数据点的标签显示百分比
                    series.Points[j].Label = $"{counts[j]} ({(counts[j] * 100.0 / dataGridView1.Rows.Count):F1}%)";
                }
            }
            // 添加系列到图表
            chart2.Series.Add(series);
            //配置图表
            chart2.Titles.Clear();
            chart2.Titles.Add("成绩分布饼状图");
            chart2.Legends.Add(new Legend("Legend"));
        }


        private void chart2_Click(object sender, EventArgs e)
        {
            

        }

        //按班级查询显示
        private void TableClass()
        {
            string sql = "select*from 成绩表 where Class='" + textBox1.Text + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, e, f, g;
                a = dr["Class"].ToString();
                b = dr["Name"].ToString();
                c = dr["Course"].ToString();
                d = dr["Grade"].ToString();
                e = dr["Total"].ToString();
                f = dr["Avg"].ToString();
                g = dr["Rank"].ToString();
                string[] str = { a, b, c, d, e, f, g };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }

        //显示个人科目统计图
        private void chart3_Click(object sender, EventArgs e)
        {

            // 清除现有数据点
            chart3.Series.Clear();
            // 添加所需的Series，每个科目一个Series
            string[] subjects = { "C#", "CAD", "EDA", "电子应用技术", "SQL数据库" };
            for (int i = 0; i < subjects.Length; i++)
            {
                Series series = chart3.Series.Add(subjects[i]);
                series.ChartType = SeriesChartType.Column; // 设置为柱状图
            }
            // 遍历 dataGridView2 获取数据
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (!dataGridView2.Rows[i].IsNewRow)
                {
                    string subject = dataGridView2.Rows[i].Cells[2]?.Value?.ToString(); // 科目在第三列
                    string score = dataGridView2.Rows[i].Cells[3]?.Value?.ToString(); // 姓名在第二列

                    // 根据科目将成绩添加到对应的Series中
                    switch (subject)
                    {
                        case "C#":
                            chart3.Series[0].Points.AddXY(subject, score);
                            chart3.Series[0].Points[chart3.Series[0].Points.Count - 1].ToolTip = "#VALX#,#VALY#"; // 设置提示
                            break;
                        case "CAD":
                            chart3.Series[1].Points.AddXY(subject, score);
                            chart3.Series[1].Points[chart3.Series[1].Points.Count - 1].ToolTip = "#VALX#,#VALY#"; // 设置提示
                            break;
                        case "EDA":
                            chart3.Series[2].Points.AddXY(subject, score);
                            chart3.Series[2].Points[chart3.Series[2].Points.Count - 1].ToolTip = "#VALX#,#VALY#"; // 设置提示
                            break;
                        case "电子应用技术":
                            chart3.Series[3].Points.AddXY(subject, score);
                            chart3.Series[3].Points[chart3.Series[3].Points.Count - 1].ToolTip = "#VALX#,#VALY#"; // 设置提示
                            break;
                        case "SQL数据库":
                            chart3.Series[4].Points.AddXY(subject, score);
                            chart3.Series[4].Points[chart3.Series[4].Points.Count - 1].ToolTip = "#VALX#,#VALY#"; // 设置提示
                            break;
                    }
                }
            }

            // 设置X轴的标签，确保显示所有科目
            chart3.ChartAreas[0].AxisX.Title = "科目";
            chart3.ChartAreas[0].AxisY.Title = "成绩";
            // 设置 X 轴标签格式
            chart3.ChartAreas[0].AxisX.LabelStyle.Interval = 1; // 标记每个 X 值
            chart3.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // 设置标签倾斜
        }



        //按个人名字查询显示


        //private void chart3_Click(object sender, EventArgs e)
        //{
        //    // 清除现有数据点
        //    chart3.Series.Clear();

        //    // 使用字典存储学生及其对应的成绩
        //    Dictionary<string, Dictionary<string, float>> scoresDict = new Dictionary<string, Dictionary<string, float>>();

        //    // 遍历 dataGridView2 获取数据
        //    for (int i = 0; i < dataGridView2.Rows.Count; i++)
        //    {
        //        if (!dataGridView2.Rows[i].IsNewRow)
        //        {
        //            string subject = dataGridView2.Rows[i].Cells[2]?.Value?.ToString();        // 科目在第三列
        //            string studentName = dataGridView2.Rows[i].Cells[1]?.Value?.ToString();  // 学生姓名在第二列


        //            float score;

        //            if (float.TryParse(dataGridView2.Rows[i].Cells[3]?.Value?.ToString(), out score)) // 成绩在第四列
        //            {
        //                // 如果字典中不存在该科目，则添加一个新的字典来存储学生成绩
        //                if (!scoresDict.ContainsKey(subject))
        //                {
        //                    scoresDict[subject] = new Dictionary<string, float>();
        //                }

        //                // 将学生的成绩添加到对应的科目字典中
        //                scoresDict[subject][studentName] = score;
        //            }
        //        }
        //    }

        //    // 设置图表标题和轴标签
        //    chart3.ChartAreas[0].AxisX.Title = "科目";
        //    chart3.ChartAreas[0].AxisY.Title = "成绩";

        //    // 按照科目创建 Series
        //    foreach (var kvp in scoresDict)
        //    {
        //        string subject = kvp.Key; // 科目
        //        Dictionary<string, float> studentScores = kvp.Value;

        //        // 创建一个新的 Series，用于每个科目的成绩显示
        //        Series series = new Series(subject)
        //        {
        //            ChartType = SeriesChartType.Column // 设置塔型图
        //        };

        //        // 添加数据点到 Series
        //        foreach (var studentKvp in studentScores)
        //        {
        //            string studentName = studentKvp.Key; // 学生姓名
        //            float studentScore = studentKvp.Value; // 学生成绩
        //            series.Points.AddXY(subject, studentScore); // 添加到 Series，X 值为科目，Y 值为成绩
        //            series.Points[series.Points.Count - 1].ToolTip = $"{studentName}: {studentScore}"; // 设置提示
        //        }

        //        chart3.Series.Add(series); // 将 Series 添加到图表中

        //    }

        //    // 设置X轴标签
        //    chart3.ChartAreas[0].AxisX.Interval = 1; // 确保每个标签都有显示
        //    chart3.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true; // 使标签错开
        //    chart3.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // 设置标签倾斜

        //    // 显示数值标签
        //    foreach (Series series in chart3.Series)
        //    {
        //        series.IsValueShownAsLabel = true; // 显示数值标签
        //    }
        //}


        private void chart4_Click(object sender, EventArgs e)
        {
            // 清除当前图表的所有系列
           

            // 使用 List 来存储科目和对应的成绩
            List<string> subjects = new List<string>();
            List<float> scores = new List<float>();

            // 遍历 dataGridView2 获取科目和成绩
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (!dataGridView2.Rows[i].IsNewRow) // 排除空行
                {
                    string subject = dataGridView2.Rows[i].Cells[2]?.Value?.ToString(); // 科目在第三列
                    float score;

                    if (float.TryParse(dataGridView2.Rows[i].Cells[3]?.Value?.ToString(), out score)) // 成绩在第四列
                    {
                        // 添加科目和成绩到列表中
                        subjects.Add(subject);
                        scores.Add(score);
                    }
                }
            }
            //// 创建一个新的 Series 只用于一个学生的成绩
            Series series = chart4.Series["Series1"];
            series.ChartType = SeriesChartType.Spline;// 设置为曲线图
            series.IsValueShownAsLabel = true; // 显示数值标签
            //将成绩添加到该 Series
            for (int j = 0; j < subjects.Count; j++)
            {
                series.Points.AddXY(subjects[j], scores[j]);
                series.Points[j].ToolTip = $"{subjects[j]}: {scores[j]}"; // 设置提示
            }
            // 设置图表标题和轴标签
            chart4.ChartAreas[0].AxisX.Title = "科目";
            chart4.ChartAreas[0].AxisY.Title = "成绩";

            // 确保X轴上每个标签都有显示
            chart4.ChartAreas[0].AxisX.Interval = 1;
            chart4.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;
            chart4.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

        }
        private void TableName()
        {
            string sql = "select*from 成绩表 where Name='" + textBox2.Text + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, e, f;
                a = dr["Class"].ToString();
                b = dr["Name"].ToString();
                c = dr["Course"].ToString();
                d = dr["Grade"].ToString();
                e = dr["Total"].ToString();
                f = dr["Rank"].ToString();
                string[] str = { a, b, c, d, e, f };
                dataGridView2.Rows.Add(str);
            }
            dr.Close();
        }
        //按科目查询显示
        private void TableCourse()
        {
            string sql = "select*from 成绩表 where Course='" + textBox3.Text + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, e, f, g;
                a = dr["Class"].ToString();
                b = dr["Name"].ToString();
                c = dr["Course"].ToString();
                d = dr["Grade"].ToString();
                e = dr["Total"].ToString();
                f = dr["Avg"].ToString();
                g = dr["CourseRank"].ToString();
                string[] str = { a, b, c, d, e, f, g };
                dataGridView3.Rows.Add(str);
            }
            dr.Close();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //按班级显示
            //先清空表格
            dataGridView1.Rows.Clear();
            TableClass();
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //按个人名字显示
            dataGridView2.Rows.Clear();
            TableName();
            chart3_Click(null, null);
            chart4_Click(null, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //按科目显示
            dataGridView3.Rows.Clear();
            TableCourse();
        }


        //全班科目统计图
        //private void chart5_Click(object sender, EventArgs e)
        //{
        //    // 清除现有数据点
        //   // chart5.Series.Clear();
        //    for (int i = 0; i < dataGridView3.Rows.Count; i++)
        //    {
        //        if (!dataGridView3.Rows[i].IsNewRow) // 确保不是新行
        //        {
        //            // 获取学生姓名
        //           string studentName = dataGridView3.Rows[i].Cells[1].Value?.ToString() ?? "Unknown";
        //           string subject = dataGridView3.Rows[i].Cells[2].Value?.ToString() ?? "Unknown";

        //            // 使用TryParse进行安全的数据转换
        //            if (float.TryParse(dataGridView3.Rows[i].Cells[3].Value?.ToString() ?? "0", out float Grade) &&
        //                float.TryParse(dataGridView3.Rows[i].Cells[4].Value?.ToString() ?? "0", out float Total) &&
        //                float.TryParse(dataGridView3.Rows[i].Cells[5].Value?.ToString() ?? "0", out float Avg) &&
        //                float.TryParse(dataGridView3.Rows[i].Cells[6].Value?.ToString() ?? "0", out float Rank))
        //            {
        //                chart5.Series[1].Points.AddXY(studentName, Grade);
        //                chart5.Series[1].Points[chart5.Series[1].Points.Count - 1].ToolTip = "#VALX#,#VALY#"; // 设置提示

        //                chart5.Series[2].Points.AddXY(studentName, Total);
        //                chart5.Series[2].Points[chart5.Series[2].Points.Count - 1].ToolTip = "#VALX#,#VALY#"; // 设置提示

        //                chart5.Series[3].Points.AddXY(studentName, Avg);
        //                chart5.Series[3].Points[chart5.Series[3].Points.Count - 1].ToolTip = "#VALX#,#VALY#"; // 设置提示

        //               chart5.Series[4].Points.AddXY(studentName, Rank);
        //               chart5.Series[4].Points[chart5.Series[4].Points.Count - 1].ToolTip = "#VALX#,#VALY#"; // 设置提示
        //            }
        //        }
        //        // 设置 X 轴标签格式
        //        chart5.ChartAreas[0].AxisX.LabelStyle.Interval = 1; // 标记每个 X 值
        //        chart5.ChartAreas[0].AxisX.LabelStyle.IntervalOffset = 0; // 确保从第一个标签开始
        //        chart5.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // 设置标签倾斜

        //    }

        //}



        private void chart5_Click(object sender, EventArgs e)
        {
            // 清除现有数据点
            chart5.Series.Clear();

            // 添加Series到chart5
            var gradeSeries = new Series("科目成绩") { ChartType = SeriesChartType.Column };
            var totalSeries = new Series("总分") { ChartType = SeriesChartType.Column };
            var avgSeries = new Series("平均分") { ChartType = SeriesChartType.Column };
            var rankSeries = new Series("排名") { ChartType = SeriesChartType.Column };

            chart5.Series.Add(gradeSeries);
            chart5.Series.Add(totalSeries);
            chart5.Series.Add(avgSeries);
            chart5.Series.Add(rankSeries);

            // 提示Series数量
            Console.WriteLine($"Series Count: {chart5.Series.Count}");

            // 设置Y轴最大值
            chart5.ChartAreas[0].AxisY.Minimum = 0;
            chart5.ChartAreas[0].AxisY.Maximum = 200;
            //显示数值标签
            gradeSeries.IsValueShownAsLabel = true;
            totalSeries.IsValueShownAsLabel = true;
            avgSeries.IsValueShownAsLabel = true;
            rankSeries.IsValueShownAsLabel = true;
            //显示提示
            gradeSeries.ToolTip = "#VALX#,#VALY#";
            totalSeries.ToolTip = "#VALX#,#VALY#";
            avgSeries.ToolTip = "#VALX#,#VALY#";
            rankSeries.ToolTip = "#VALX#,#VALY#";

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                if (!dataGridView3.Rows[i].IsNewRow) // 确保不是新行
                {
                    string studentName = dataGridView3.Rows[i].Cells[1].Value?.ToString() ?? "Unknown";

                    if (float.TryParse(dataGridView3.Rows[i].Cells[3].Value?.ToString(), out float Grade) &&
                        float.TryParse(dataGridView3.Rows[i].Cells[4].Value?.ToString(), out float Total) &&
                        float.TryParse(dataGridView3.Rows[i].Cells[5].Value?.ToString(), out float Avg) &&
                        float.TryParse(dataGridView3.Rows[i].Cells[6].Value?.ToString(), out float Rank))
                    {
                        // 添加数据点
                        gradeSeries.Points.AddXY(studentName, Grade);
                        totalSeries.Points.AddXY(studentName, Total);
                        avgSeries.Points.AddXY(studentName, Avg);
                        rankSeries.Points.AddXY(studentName, Rank);
                    }
                }
            }

            // 设置X轴选项
            chart5.ChartAreas[0].AxisX.LabelStyle.Interval = 1; // 显示每个标签
            chart5.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // 标签倾斜
        }

        private void chart6_Click(object sender, EventArgs e)
        {
            // 清空现有数据
            chart6.Series.Clear();
            chart6.ChartAreas.Clear();

            // 创建新的 ChartArea
            var chartArea = new ChartArea("MainArea");
            chart6.ChartAreas.Add(chartArea);

            // 创建雷达图的Series
            var series = new Series("Scores")
            {
                ChartType = SeriesChartType.Radar // 设置为雷达图
            };
            //显示数值标签
            series.IsValueShownAsLabel = true;
            //设置提示
            series.ToolTip = "#VALX#,#VALY#";
            // 假设你从 dataGridView3 获得成绩
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                if (!dataGridView3.Rows[i].IsNewRow) // 确保不是新行
                {
                    string studentName = dataGridView3.Rows[i].Cells[1].Value?.ToString() ?? "Unknown";

                    // 获取总分（第5列）
                    if (float.TryParse(dataGridView3.Rows[i].Cells[4].Value?.ToString(), out float totalScore))
                    {
                        // 添加数据点
                        series.Points.AddXY(studentName, totalScore);
                        series.Points.Last().Label = studentName; // 设置每个点的标签为学生姓名
                    }
                }
            }

            // 将Series添加到Chart
            chart6.Series.Add(series);

            // 设置图表标题
            chart6.Titles.Clear();
            chart6.Titles.Add("学生总分雷达图"); // 设置图表标题
        }

    }
}
