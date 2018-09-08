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

namespace L0517FileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        internal void RunString()
        {
            string str = "MSIT119";
            
        }

        private void btnSTRfileCompare_Click(object sender, EventArgs e)
        {
            string[] array = { "micro.jpg", "wtf.Jpg", "lol.jpG", "Helloworld.JPG","ggwp.txt","Jinni.jPg" };

            

            foreach(string s in array)
            {

                if(".jpg" == Path.GetExtension(s).ToLower()   )
                {
                    listBox1.Items.Add(s);
                    if(s.StartsWith("Jinni"))
                    {
                        listBox1.Items.Add(s);
                    }


                }
                else
                {
                    MessageBox.Show(s + " doesn't exist");
                }
                
            }

        }

        private void btnStrCompare_Click(object sender, EventArgs e)
        {
            string str1 = "hello";
            string str2 = "Hello";
            
            if(string.CompareOrdinal(str1,str2)==0)
            {
                MessageBox.Show("str1 == str2");
            }
            else if(string.CompareOrdinal(str1, str2)>0)
            {
                MessageBox.Show("str1 >= str2");
            }
            else
            {
                MessageBox.Show("str1 <= str2");
            }

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string str = "Hello 12345, abcd:09 ,11, :last";


            string[] vs = str.Split(' ', ',', ':');

            
            for(int i=0;i<vs.Length;i++)
            {
                MessageBox.Show(vs[i]);
                //Console.WriteLine(vs[i]); 
            }
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string str = "       Hi ma'am i'm Adam        ";
            str.Trim();
            MessageBox.Show(str);
            MessageBox.Show(str.Trim());

            MessageBox.Show(str.Trim('i'));
        }

        private void btnSTRBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for(int i =0;i<10;i++)
            {
                sb.Append(i.ToString());
            }

            MessageBox.Show(sb.ToString());
            Console.WriteLine(StringBuilder.Equals(sb, "0123456789"));
        }

        private void btnToForm2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
