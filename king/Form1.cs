using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace king
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string cmd;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = Application.StartupPath;
            textBox3.Text = "cd " + a + "&&" + @"NetReactorSlayer-x64.exe" + " " + textBox1.Text;
            ExcuteDosCommand(textBox3.Text);
        }



        private void ExcuteDosCommand(string cmd)
        {
            MessageBox.Show("这个按钮用不了，自己打开cmd，把上面的第二个框里面的代码复制进去！！(记得先选.NET程序，选完后按一下这个按钮)");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            using (var process = new Process())
            {
                try
                {
                    cmd = "cd" + " " + Application.StartupPath + "&&" + "de4dot.exe" + " " + textBox1.Text + "&exit";
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();
                    process.StandardInput.AutoFlush = true;
                    process.StandardInput.WriteLine(cmd);

                    textBox2.Text = process.StandardOutput.ReadToEnd();


                    process.WaitForExit();
                    process.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n跟踪;" + ex.StackTrace);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";   //@是取消转义字符的意思
            fdlg.Filter = null;
            /*
             * FilterIndex 属性用于选择了何种文件类型,缺省设置为0,系统取Filter属性设置第一项
             * ,相当于FilterIndex 属性设置为1.如果你编了3个文件类型，当FilterIndex ＝2时是指第2个.
             */
            fdlg.FilterIndex = 2;
            /*
             *如果值为false，那么下一次选择文件的初始目录是上一次你选择的那个目录，
             *不固定；如果值为true，每次打开这个对话框初始目录不随你的选择而改变，是固定的  
             */
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = System.IO.Path.GetFullPath(fdlg.FileName);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var process = new Process())
            {
                try
                {
                    cmd = "cd" + " " + Application.StartupPath + @"\FinGu-Cleaner" + "&&" + "FinGu-Cleaner.exe" + " " + textBox1.Text + "&exit";
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();
                    process.StandardInput.AutoFlush = true;
                    process.StandardInput.WriteLine(cmd);

                    textBox2.Text = process.StandardOutput.ReadToEnd();


                    process.WaitForExit();
                    process.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n跟踪;" + ex.StackTrace);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var process = new Process())
            {
                try
                {
                    cmd = "cd" + " " + Application.StartupPath + @"\ExeinfoPe" +  "&&" +"exeinfope.exe" + " " + textBox1.Text +"&exit";
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();
                    process.StandardInput.AutoFlush = true;
                    process.StandardInput.WriteLine(cmd);

                    string lines = System.IO.File.ReadAllText(Application.StartupPath + @"\ExeinfoPe\Exeinfo.log");
                    textBox2.Text = cmd + "\n" + lines;

                    process.WaitForExit();
                    process.Close();

                    FileStream fs = File.Create(Application.StartupPath + @"\ExeinfoPe\Exeinfo.log");
                    fs.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n跟踪;" + ex.StackTrace);

                }
            }
        }
    }
}

