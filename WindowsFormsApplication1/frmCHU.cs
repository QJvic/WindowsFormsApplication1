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
    public partial class frmCHU : Form
    {
        public frmCHU()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            string path = string.Empty;
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            textBox2.Clear();
            textBox2.Text = path;
            Console.Write(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string folderPath = this.textBox1.Text;
            if (!Directory.Exists(this.textBox1.Text) || !Directory.Exists(this.textBox2.Text) )
            {
                MessageBox.Show("不存在文件夹或文件夹，请检查");
                return;
            }
            string sArguments = @"py/CHU10000.py";//这里是python的文件名字 
            string[] strArr = { this.textBox1.Text, this.textBox2.Text };
            usePY.RunPythonScript(sArguments, "-u", strArr);//运行脚本文件 
            Console.Write("finished");
            MessageBox.Show("裁剪成功");
        }
    }
}
