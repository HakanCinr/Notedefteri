using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices;

namespace Notedefteri
{
    public partial class Form1 : Form
    {
        List<login> loginpass = new List<login>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txt1.Text == "" & txt2.Text == "")
            {
                MessageBox.Show("Bilgileri doldurun");
            }
            else
            { 
             
                foreach (login login in loginpass)
                {
                    if (login.names == txt1.Text & login.passwords == txt2.Text)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        Hide();
                    }
                    else if (login.names != txt1.Text & login.passwords != txt2.Text)
                    {
                        MessageBox.Show("bilgiler yanlýþ");
                    }

                    else
                    {
                        MessageBox.Show("hatalý");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            login logi = new login();
            logi.names = txt1.Text;
            logi.passwords = txt2.Text;
            loginpass.Add(logi);
            MessageBox.Show("kayýt baþarýlý");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}