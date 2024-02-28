using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Papyrus
{
    public partial class Form1 : Form
    {
        private int lastLineCount = 1;
        int lineNum = 1;
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
            txtLineNums.Text = $" | {lineNum}\n";
            LoadFileFromCommandLine();
        }

        private void LoadFileFromCommandLine()
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                try
                {
                    string filePath = args[1]; // The first command line argument is the file path

                    using (System.IO.StreamReader sr = new System.IO.StreamReader(filePath))
                    {
                        string fileContents = sr.ReadToEnd();
                        txtMain.Text = fileContents;
                    }

                    printLineNums();
                    saveBar.Value = 100;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void printLineNums()
        {
            string[] lines = txtMain.Lines;

            while (lines.Length > lastLineCount)
            {
                lineNum++;
                txtLineNums.Text += $" | {lineNum}\n";
                lastLineCount++;
            }

            while (lines.Length+1 <= lastLineCount && lastLineCount != 1)
            {
                if (lineNum > 1)
                {
                    string delLineNum = txtLineNums.Text.Replace($" | {lineNum}\n", "");
                    txtLineNums.Text = delLineNum;
                }
                if (lineNum != 1)
                {
                    lineNum--;
                }
                if (lastLineCount != 1)
                {
                    lastLineCount--;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            saveBar.Value = 0;

            printLineNums();

            txtLineNums.SelectionStart = txtLineNums.Text.Length;
            txtLineNums.ScrollToCaret();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void fontSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = fontSelect.SelectedItem.ToString();

            switch (selectedFontName)
            {
                case "Agency FB":
                    txtMain.Font = new Font("Agency FB", txtMain.Font.Size);
                    break;
                case "Arial":
                    txtMain.Font = new Font("Arial", txtMain.Font.Size);
                    break;
                case "Consolas":
                    txtMain.Font = new Font("Consolas", txtMain.Font.Size);
                    break;
                default:
                    txtMain.Font = new Font("Consolas", 10);
                    break;
            }
        }

        private void fontSizeSelect_IndexChanged(Object sender, EventArgs e)
        {
            string selectedFontSize = fontSizeSelect.SelectedItem.ToString();

            switch (selectedFontSize)
            {
                case "2":
                    txtMain.Font = new Font("txtMain.Font", 2);
                    txtLineNums.Font = new Font("txtLineNums.Font", 2);
                    break;
                case "4":
                    txtMain.Font = new Font("txtMain.Font", 4);
                    txtLineNums.Font = new Font("txtLineNums.Font", 4);
                    break;
                case "6":
                    txtMain.Font = new Font("txtMain.Font", 6);
                    txtLineNums.Font = new Font("txtLineNums.Font", 6);
                    break;
                case "8":
                    txtMain.Font = new Font("txtMain.Font", 8);
                    txtLineNums.Font = new Font("txtLineNums.Font", 8);
                    break;
                case "10":
                    txtMain.Font = new Font("txtMain.Font", 10);
                    txtLineNums.Font = new Font("txtLineNums.Font", 10);
                    break;
                case "12":
                    txtMain.Font = new Font("txtMain.Font", 12);
                    txtLineNums.Font = new Font("txtLineNums.Font", 12);
                    break;
                case "14":
                    txtMain.Font = new Font("txtMain.Font", 14);
                    txtLineNums.Font = new Font("txtLineNums.Font", 14);
                    break;
                case "16":
                    txtMain.Font = new Font("txtMain.Font", 16);
                    txtLineNums.Font = new Font("txtLineNums.Font", 16);
                    break;
                case "18":
                    txtMain.Font = new Font("txtMain.Font", 18);
                    txtLineNums.Font = new Font("txtLineNums.Font", 18);
                    break;
                case "20":
                    txtMain.Font = new Font("txtMain.Font", 20);
                    txtLineNums.Font = new Font("txtLineNums.Font", 20);
                    break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (File.Exists(openFileDialog1.FileName))
            {
                saveFileDialog1.FileName = openFileDialog1.FileName;
            }
            else
            {
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            try
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(txtMain.Text);
                }

                saveBar.Value = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName))
                    {
                        string fileContents = sr.ReadToEnd();
                        txtMain.Text = fileContents;
                    }

                    printLineNums();
                    saveBar.Value = 100;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}