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
    public partial class frmReName : Form
    {
        public frmReName()
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

        private void button3_Click(object sender, EventArgs e)
        {
            string folderPath = this.textBox1.Text;
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("不存在文件夹，请检查");
                return;
            }
            System.Diagnostics.Process.Start(this.textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = this.textBox1.Text;
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("不存在文件夹，请检查");
                return;
            }
            string sArguments = @"py/reName.py";//这里是python的文件名字 
            string[] strArr = { this.textBox1.Text,this.textBox2.Text };
            usePY.RunPythonScript(sArguments, "-u", strArr);//运行脚本文件 
            Console.Write("finished");
            MessageBox.Show("删除成功");
        }
    }
}
