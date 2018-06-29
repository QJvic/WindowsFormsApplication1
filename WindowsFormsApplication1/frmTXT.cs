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
    public partial class frmTXT : Form
    {
        public frmTXT()
        {
            InitializeComponent();
        }
        string path;
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
            this.path = path;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = this.textBox1.Text;
            if(!Directory.Exists(folderPath))
            {
                MessageBox.Show("不存在文件夹，请检查");
                return;
            }
            string sArguments = @"py/joinName.py";//这里是python的文件名字 
            string[] strArr = { path };
            usePY.RunPythonScript(sArguments, "-u", strArr);//运行脚本文件 
            Console.Write("finished");
            MessageBox.Show("生成成功");
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
    }
}
