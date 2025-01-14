using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NameMaker
{
    public partial class Form1 : Form
    {
        public static string namelistfolder = @"D:\Ling\NoK\Namn\";

        private transitiontableclass ttc = new transitiontableclass();
        private List<string> namelist = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Quitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void memo(string s)
        {
            richTextBox1.AppendText(s + "\n");
            richTextBox1.ScrollToCaret();
        }

        private void Transitionbutton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = namelistfolder;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                int n = 0;
                using (StreamReader sr = new StreamReader(fn))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        n++;
                        string[] words = line.Split('\t');
                        namelist.Add(words[0]);
                        double w = -1;
                        if (words.Length > 1)
                            w = util.tryconvert(words[1]);
                        if (w <= 0)
                            w = 1;
                        if (Cbsquare.Checked)
                            w = w * w;
                        string namestring = transitiontableclass.startchar + words[0] + transitiontableclass.endchar;
                        char[] name = namestring.ToCharArray();
                        if (n % 100 == 0)
                            memo(words[0]);
                        for (int i = 0; i < name.Length - 1; i++)
                            ttc.addpair(name[i], name[i + 1],w);
                        for (int i = 0; i < name.Length - 2; i++)
                            ttc.addpair(namestring.Substring(i,2), name[i + 2],w);
                    }
                }
                memo("Normalizing...");
                ttc.normalize();
                Generatebutton.Enabled = true;
                memo("===Done!===");

            }

        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            char c = ttc.get_next(transitiontableclass.startchar);
            //string c2 = transitiontableclass.startchar.ToString() + c;
            StringBuilder sb2 = new StringBuilder();
            //do
            //{
            //    sb.Clear();
            //    c = ttc.get_next(transitiontableclass.startchar);
            //    while (c != transitiontableclass.endchar)
            //    {
            //        sb.Append(c);
            //        c = ttc.get_next(c);
            //        if (sb.Length > 15)
            //            break;
            //    }
            //}
            //while(namelist.Contains(sb.ToString()));
            //namelist.Add(sb.ToString());

            do
            {
                c = ttc.get_next(transitiontableclass.startchar);
                string c2 = transitiontableclass.startchar.ToString() + c;
                sb2.Clear();
                sb2.Append(c2);
                c = ttc.get_next(c2);
                c2 = c2.Substring(1) + c;
                while (c != transitiontableclass.endchar)
                {
                    sb2.Append(c);
                    c = ttc.get_next(c2);
                    c2 = c2.Substring(1) + c;
                    if (sb2.Length > 15)
                        break;
                }
            }
            while (namelist.Contains(sb2.ToString().Trim('#')));
            //memo(sb.ToString() + "\t" + sb2.ToString().Trim('#'));
            memo(sb2.ToString().Trim('#'));
            namelist.Add(sb2.ToString().Trim('#'));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
