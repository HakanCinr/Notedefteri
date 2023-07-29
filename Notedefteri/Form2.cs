using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notedefteri
{
    public partial class Form2 : Form
    {
        List<string> lines = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string fileName = "notepad.txt";
            string textToAdd = textBox1.Text;

            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(textToAdd);
                listBox1.Items.Add(textToAdd);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string fileName = "notepad.txt"; // okunacak dosyanın adı ve yolu
          

            // Dosyayı açın ve satırları okuyun
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line); // okunan satırı listeye ekleyin
                }
            }

            // Listede bulunan satırları yazdırın
            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
