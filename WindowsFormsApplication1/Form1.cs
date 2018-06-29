using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string sArguments = @"merge.py";//这里是python的文件名字 

            List<string> listArr = new List<string>();
            listArr.Add("666");
            string[] strArr = listArr.ToArray();
            RunPythonScript(sArguments, "-u", strArr);//运行脚本文件 
            Console.Write("finished");
        }


        public static void RunPythonScript(string sArgName, string args = "", params string[] teps)

        {

            Process p = new Process();

            string path = "test.py";// 待处理python文件的路径

            string sArguments = path;

            foreach (string sigstr in teps)//添加参数

            {

                sArguments += " " + sigstr;//传递参数

            }

            //下面为启动一个进程来执行脚本文件设置参数 

            p.StartInfo.FileName = @"D:\Python27\python.exe"; //注意路径 

            p.StartInfo.Arguments = sArguments;//这样参数就是merge.py 路径1 路径2 路径3....

            Console.WriteLine(sArguments);

            p.StartInfo.UseShellExecute = false;

            p.StartInfo.RedirectStandardOutput = true;

            p.StartInfo.RedirectStandardInput = true;

            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.CreateNoWindow = true;

            p.Start();//启动进程 

        }
    }
}
