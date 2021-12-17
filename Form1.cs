using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows
{
    public partial class Form1 : Form
    {
        private string _path = "Null";

        public Form1()
        {
            InitializeComponent();
        }

        private void user_icon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debug information message");
        }

        private void user_icon_MouseEnter(object sender, EventArgs e)
        {
            user_icon.BackgroundImage = Properties.Resources.user_icon_dark;
        }

        private void user_icon_MouseLeave(object sender, EventArgs e)
        {
            user_icon.BackgroundImage = Properties.Resources.user_icon;
        }

        private void open_file_Click(object sender, EventArgs e)
        {
            string path;
            string fileContent;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    _path = path;
                    fileContent = File.ReadAllText(_path, Encoding.Unicode);
                    textArea.Text = fileContent;
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (_path == "Null")
            {
                save_as_Click(sender, e);
            }
            else
            {
                using (FileStream fstream = new FileStream(_path, FileMode.OpenOrCreate))
                {
                    fstream.Write(Encoding.Unicode.GetBytes(textArea.Text), 0, Encoding.Unicode.GetBytes(textArea.Text).Length);
                    fstream.Close();
                }
            }
        }

        private void save_as_Click(object sender, EventArgs e)
        {
            string path;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                    _path = path;
                    save_Click(sender, e);
                }
            }
        }

        private void new_file_Click(object sender, EventArgs e)
        {
            _path = "Null";
            textArea.Text = "";
        }
    }
}
