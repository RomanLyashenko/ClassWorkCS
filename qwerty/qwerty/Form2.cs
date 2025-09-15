using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qwerty
{
    public partial class Form2 : Form
    {

        logger log = new logger();
        public Form2(Form1 mainForm)
        {
            if (this.IsDisposed)
            {
                mainForm.Close();
            }
            InitializeComponent();
            
        }

        private void open_test(char num)
        {
            string path = ("C:\\Users\\Взрослая академия\\source\\repos\\qwerty\\qwerty\\Tests\\test_0.txt");
            
            path = path.Replace('0', num);     
            
            Process.Start(path);  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            open_test('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            open_test('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();   
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
            }
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine();
            }
        }
    }
}
