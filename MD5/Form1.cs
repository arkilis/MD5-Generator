using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MD5
{
    delegate void SetValueCallback(int value);

    public partial class Form1 : Form
    {

        // global variable
        public string szMD5Path;
        public ArrayList ay_list;

        public Form1()
        {
            InitializeComponent();
            ay_list = new ArrayList();
        }

        // help button
        private void button3_Click(object sender, EventArgs e)
        {
            string cmts = "1. First you need to add files that you want to do md5 check;\n";
            cmts += "2, It will take a while to generate the md5 file which depends on the file size;";
            MessageBox.Show(cmts);
            
        }

        // get file's md5 signature
        public static string GetMD5HashFromFile(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            System.Security.Cryptography.MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }

        private void but_addfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog1 = new OpenFileDialog();
            //fileDialog1.InitialDirectory = "d://";
            //fileDialog1.Filter = "gz files (*.xls)|*.xls|All files (*.*)|*.*";
            fileDialog1.Filter = "gz files (*.gz)|*.gz";
            fileDialog1.FilterIndex = 1;
            fileDialog1.RestoreDirectory = true;
            if (fileDialog1.ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Add(fileDialog1.FileName);
                ay_list.Add(fileDialog1.FileName);
            }

        }


        // generate md5 signature
        private void but_gen_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
                MessageBox.Show("Please add files");
            else
            {
                // get the path of data.md5

                SaveFileDialog saveFileDialog=new SaveFileDialog();
                saveFileDialog.FileName = "data.md5";
                saveFileDialog.Filter="MD5 file|*.md5"; 
                saveFileDialog.RestoreDirectory=true;
                if(saveFileDialog.ShowDialog()==DialogResult.OK)
                    szMD5Path=saveFileDialog.FileName;

                // set md5 job and progress bar
                progressBar1.Maximum = ay_list.Count;

                Thread t = new Thread(new ThreadStart(doCalMD5));
                t.Start();

                
            }
        }

        // generate md5
        private void doCalMD5()
        {
            if (szMD5Path != "")
            {

                // create md5 signature file
                FileStream fs = new FileStream(szMD5Path, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < ay_list.Count; i++)
                {
                    // 
                    string szMd5Temp = GetMD5HashFromFile((string)ay_list[i]);

                    // update progress bar
                    SetProcessBarValue(i+1);

                    //MessageBox.Show(szMd5Temp);
                    string szfilename = System.IO.Path.GetFileName((string)ay_list[i]);
                    string szTemp = szMd5Temp + "  " + szfilename;
                    sw.WriteLine(szTemp);
                    sw.Flush();
                }

                sw.Close();
                fs.Close();
            }
            else
                MessageBox.Show("Can't find MD5 file name!");
        }

        private void SetProcessBarValue(int value)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.progressBar1.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetProcessBarValue);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                this.progressBar1.Value = value;
            }
        }

    }
}
