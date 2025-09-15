using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace qwerty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;

            string csvLine = $"{name}:{password}";

            string filePath = ("DataBase.csv");

            if(checkUser(name) == false)
            {
                File.AppendAllText(filePath, csvLine + "\n");
            }
            else
            {
                MessageBox.Show("The name is taken. Please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        public bool checkUser(string name)
        {
            bool resultCheck = false;
            using (StreamReader reader = new StreamReader("DataBase.csv"))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] str = line.Split(':');
                    if (resultCheck) { break; }
                    if (str[0] == name)
                    {
                        resultCheck = true;
                    }
                }
            }
            return resultCheck;
        }

        public bool CheckLogin(string name, string password)
        {
            using (StreamReader reader = new StreamReader("DataBase.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        if (parts[0] == name && parts[1] == password)
                        {
                            return true; 
                        }
                    }
                }
            }
            return false;
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;

            if (CheckLogin(name, password))
            {
                this.Hide();
                Form2 form2 = new Form2(this);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void readFile(string path)
        {
            try
            {
                
            }
            catch (Exception ex)
            { 

            }
            finally
            {

            }
        }
    }
}
