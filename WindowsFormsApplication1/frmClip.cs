using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmClip : Form
    {
        public frmClip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            textBox1.Clear();
            textBox1.Text = path;
            Console.Write(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = this.textBox1.Text;
            if (!Directory.Exists(this.textBox1.Text) || !File.Exists(this.textBox2.Text) || !Directory.Exists(this.textBox3.Text))
            {
                MessageBox.Show("不存在文件夹或文件夹，请检查");
                return;
            }
            string sArguments = @"py/MASK.py";//这里是python的文件名字 
            string[] strArr = { this.textBox1.Text,this.textBox2.Text, this.textBox3.Text ,"文件夹"};
            usePY.RunPythonScript(sArguments, "-u", strArr);//运行脚本文件 
            Console.Write("finished");
            MessageBox.Show("裁剪成功");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                textBox2.Clear();
                textBox2.Text = file;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            textBox3.Clear();
            textBox3.Text = path;
            Console.Write(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.textBox3.Text))
            {
                MessageBox.Show("不存在文件夹或文件夹，请检查");
                return;
            }
            System.Diagnostics.Process.Start(this.textBox3.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string folderPath = this.textBox1.Text;
            if (!Directory.Exists(this.textBox4.Text) || !File.Exists(this.textBox5.Text) || !Directory.Exists(this.textBox6.Text))
            {
                MessageBox.Show("不存在文件夹或文件夹，请检查");
                return;
            }
            string sArguments = @"py/MASK.py";//这里是python的文件名字 
            string[] strArr = { this.textBox6.Text, this.textBox5.Text, this.textBox4.Text ,"单个"};
            usePY.RunPythonScript(sArguments, "-u", strArr);//运行脚本文件 
            Console.Write("finished");
            MessageBox.Show("裁剪成功");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            textBox6.Clear();
            textBox6.Text = path;
            Console.Write(path);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                textBox5.Clear();
                textBox5.Text = file;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            textBox4.Clear();
            textBox4.Text = path;
            Console.Write(path);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.textBox4.Text))
            {
                MessageBox.Show("不存在文件夹或文件夹，请检查");
                return;
            }
            System.Diagnostics.Process.Start(this.textBox4.Text);
        }
    }
}
