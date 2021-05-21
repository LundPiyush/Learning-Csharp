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
using System.Threading;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async  Task<int> CountCharactersAsync()
        {
            int count = 0;
            string filename = @"D:\sites.txt";
            using (StreamReader reader = new StreamReader(filename))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
            private async void button1_Click(object sender, EventArgs e)
            {
            Task<int> task = await CountCharactersAsync();
            lblCount.Text = "Processing file.Please wait ";
            int count = await task;
            lblCount.Text = count.ToString() + " characters in file";


            }
        }
    }
