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

namespace QuizPlatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text; 
            string path = @"C:\Users\Взрослая академия\Desktop\DataBase.csv";

            bool isUnique = true;

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        int separatorIndex = line.IndexOf(':');
                        if (separatorIndex >= 0)
                        {
                            string existingUsername = line.Substring(0, separatorIndex);
                            if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                            {
                                isUnique = false;
                                break;
                            }
                        }
                    }
                }
            }

            if (isUnique)
            {
                string lineToWrite = $"{username}:{password}";
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(lineToWrite);
                }
                MessageBox.Show("User successfully added.");
            }
            else
            {
                MessageBox.Show("This username already exists. Please choose a different one.");
            }
        }
    }
}
