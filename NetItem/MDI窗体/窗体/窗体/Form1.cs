using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //if (MessageBox.Show("是否查看了窗体!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            //{ }

            button1.Text = "清空";

            //this.AcceptButton = button1;
            this.CancelButton = button1;
            //button1.Enabled = false;

            //textBox1.ReadOnly = true;//不能编辑文本框,只显示
            textBox1.PasswordChar = '*';
            textBox1.UseSystemPasswordChar = true;

            textBox2.Multiline = true;
            //textBox2.Text = "停止无谓的祈祷,抛弃诱发的眼泪,举杯畅饮,只剩下美妙的事物.";
            //textBox2.Height = 100;
            textBox2.SelectionStart = 5;
            textBox2.SelectionLength = 5;

            richTextBox1.Multiline = true;
            richTextBox1.Text = "欢迎登陆http://www.cccxy.com编程体验网";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.SelectionFont = new Font("楷体",12,FontStyle.Bold);
            richTextBox1.SelectionColor = System.Drawing.Color.Blue;
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 8;
            richTextBox1.SelectionRightIndent = 12;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;//||DropDownList
            comboBox1.Items.Add("土味情话");
            comboBox1.Items.Add("却也中意");

            numericUpDown1.Maximum = 20;
            numericUpDown1.Minimum = 1;
            numericUpDown1.DecimalPlaces = 2;//显示小数点后两位

            //listBox1.HorizontalScrollbar = true;
            //listBox1.ScrollAlwaysVisible = true;
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            richTextBox2.Text = "姓名: 王盈盈\n性别:女 \n年龄:27\n民族: 汉\n职业:前台";
            panel1.Visible = false;

            groupBox1.Text = "诗词:";

            // tabControl1.ImageList = 
            Button but01 = new Button();
            but01.Text = "赋予";
            tabPage1.Controls.Add(but01);


            toolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr = MessageBox.Show("是否关闭提示", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if (dr == DialogResult.Yes)//使用if语句判断是否单击"是"按钮
            //{
            //    e.Cancel = false;//如果单击"是"按钮则关闭窗体
            //}
            //else
            //{
            //    e.Cancel = true;//不执行操作
            //}

        }

        private void 加载子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            frm2.MdiParent = this;
            Form3 frm3 = new Form3();
            frm3.Show();
            frm3.MdiParent = this;
            Form4 frm4 = new Form4();
            frm4.Show();
            frm4.MdiParent = this;
            Form5 frm5 = new Form5();
            frm5.Show();
            frm5.MdiParent = this;
        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 层叠排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("引发了接受按钮");

            //comboBox1.SelectAll();
           
            label1.Text = "开始清空";
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 5000;
            toolStripProgressBar1.Step = 2;
            for (int i = 0; i < 4999; i++)
            {
                toolStripProgressBar1.PerformStep();
            }

        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)//文本网页链接 
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            //if (checkBox1.CheckState== CheckState.Checked)
            //{
            //    MessageBox.Show("checkBox控件被选中");
            //}
            //else
            //{
            //    MessageBox.Show("checkBox控件选择被取消");
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("选着状态改变了");
            if (checkBox1.Checked)//判断是否被选中
            {

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text+= " " + numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="")
            {
                MessageBox.Show("请输入添加的数据");
                label1.Text += "一共选着了" + listBox1.SelectedItems.Count;
            }
            else
            {
                listBox1.Items.Add(textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count==0)
            {
                MessageBox.Show("请选着想要删除的目录");
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text=="")
            {
                MessageBox.Show("请输入姓名");
                textBox3.Focus();
            }
            else
            {
                if (textBox3.Text.Trim()=="王盈盈")
                {
                    panel1.Show();
                }
                else
                {
                    MessageBox.Show("查无此人");
                    textBox3.Text = "";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Title = "新增选项卡" + (tabControl1.TabCount + 1);
            TabPage MyTabPage = new TabPage(Title);
            tabControl1.TabPages.Add(MyTabPage);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==0)
            {
                //MessageBox.Show("");
            }
            else
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
               // tabControl1.TabPages.Clear();//删除所有选项
            }
        }
    }
}
