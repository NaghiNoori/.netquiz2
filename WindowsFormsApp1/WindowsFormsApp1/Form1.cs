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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void register_Click(object sender, EventArgs e)
        {
            
            String firstname = fname.Text;
            String lastname= lname.Text;
            String phone = tel.Text;

                MessageBox.Show(firstname + " " + lastname + " " + phone);

                FileStream myFile = new FileStream("C:\\Users\\0836092\\Desktop\\users.txt", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(myFile))
                {
                    writer.Write(firstname +"\t");
                    writer.Write(lastname + "\t");
                    writer.Write(phone + "\t"+"\n");
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fname.Text = string.Empty;
            lname.Text = string.Empty;
            tel.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var lineCounter = 0L;
            //using (var reader = new StreamReader(myfile.fname))
            //{
            //    while (reader.ReadLine() != null)
            //    {
            //        lineCounter++;
            //    }
            //    MessageBox.Show (lineCounter);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        //    File.Delete(myFile);
        }
    }
}
