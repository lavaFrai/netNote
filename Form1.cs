using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace windows
{
    public partial class Form1 : Form
    {
        private string _path = "Новый документ";
        Encoding encoding = Encoding.UTF8;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update_title();
            //for (int i = 0; i < 1000; i++)
            //{
            //    TextBox tempTextBox = new TextBox();
            //    tempTextBox.Location = new Point(10, 10+24*i);
            //    tempTextBox.Text = i.ToString();
            //    this.panel_list.Controls.Add(tempTextBox);

            //    tempTextBox.Text = (i+100).ToString();
            //}
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
                    update_title();
                    fileContent = File.ReadAllText(_path, encoding);
                    textArea.Text = fileContent;
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (_path == "Новый документ")
            {
                save_as_Click(sender, e);
            }
            else
            {
                using (FileStream fstream = new FileStream(_path, FileMode.OpenOrCreate))
                {
                    fstream.Write(encoding.GetBytes(textArea.Text), 0, encoding.GetBytes(textArea.Text).Length);
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
                    update_title();
                    save_Click(sender, e);
                }
            }
        }

        private void new_file_Click(object sender, EventArgs e)
        {
            _path = "Новый документ";
            update_title();
            textArea.Text = "";
        }

        private void encoding_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (encoding_selector.Text)
            {
                case "UTF8":
                    encoding = Encoding.UTF8;
                    break;
                case "Unicode":
                    encoding = Encoding.Unicode;
                    break;
                case "ASCII":
                    encoding = Encoding.ASCII;
                    break;
                case "UTF7":
                    encoding = Encoding.UTF7;
                    break;
                case "UTF32":
                    encoding = Encoding.UTF32;
                    break;
                case "BigEndianUnicode":
                    encoding = Encoding.BigEndianUnicode;
                    break;
            }
            if (_path != "Новый документ")
            {
                textArea.Text = File.ReadAllText(_path, encoding);
            }
        }

        private void update_title()
        {
            this.Text = "netNote  |  " + _path;
        }
    }
}
