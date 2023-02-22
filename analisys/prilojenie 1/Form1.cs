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

namespace prilojenie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StoinostiTB_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Result.txt", true))
               
            //string text = stoinostiTB.Text;
            if (ON.Checked)
                {
                    double res = stoinostiTB.Text.Split(' ')
                        .Select(x => double.Parse(x))
                        .Max();
                    
                    resultlbl.Text = $"Comlete\nCheck result on Result.txt";
                    writer.WriteLine($"Inserted numbers is::{stoinostiTB.Text}");
                    writer.WriteLine($"Max number is:{res:F2}");

                    double res1 = stoinostiTB.Text.Split(' ')
                        .Select(x => double.Parse(x))
                        .Min(); 
                    writer.WriteLine($"MIN number is:{res1:F2}");

                    double res2 = stoinostiTB.Text.Split(' ')
                    .Select(x => double.Parse(x))
                    .Average();
                    writer.WriteLine($"Average number is:{res2:F2}");
                }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
