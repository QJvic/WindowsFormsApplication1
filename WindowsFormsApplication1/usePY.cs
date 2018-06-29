using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class usePY
    {
        public static void RunPythonScript(string sArgName, string args = "", params string[] teps)

        {

            Process p = new Process();

            string path = sArgName;// 待处理python文件的路径

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

            p.StartInfo.CreateNoWindow = false;

            p.Start();//启动进程 

            string pyOut = p.StandardOutput.ReadToEnd();
            Console.WriteLine(pyOut);

        }
    }
}
