using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;


namespace Document_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_open = new OpenFileDialog();

            file_open.Filter = "Rich Text File (*.rtf)|*.rtf|Plain Text File (*.txt)|*.txt";
            file_open.FilterIndex = 1;
            file_open.Title = "Open text or RTF file";

            RichTextBoxStreamType stream_type;
            stream_type = RichTextBoxStreamType.RichText;
            if (DialogResult.OK == file_open.ShowDialog())
            {

                if (string.IsNullOrEmpty(file_open.FileName))
                    return;
                if (file_open.FilterIndex == 2)
                    stream_type = RichTextBoxStreamType.PlainText;

                richTextBox1.LoadFile(file_open.FileName, stream_type);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDig = new SaveFileDialog();
            string filename = "";

            saveDig.Filter = "Rich Text File (*.rtf)|*.rtf|Plain Text File (*.txt)|*.txt";
            saveDig.DefaultExt = "*.rtf";
            saveDig.FilterIndex = 1;
            saveDig.Title = "Save the contents";

            DialogResult retval = saveDig.ShowDialog();
            if (retval == DialogResult.OK)
                filename = saveDig.FileName;
            else
                return;

            RichTextBoxStreamType stream_type;
            if (saveDig.FilterIndex == 2)
                stream_type = RichTextBoxStreamType.PlainText;
            else
                stream_type = RichTextBoxStreamType.RichText;

            richTextBox1.SaveFile(filename, stream_type);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = richTextBox1.SelectionFont;
            if (SelectedText_Font != null)
                richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style | FontStyle.Bold);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = richTextBox1.SelectionFont;
            if (SelectedText_Font != null)
                richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style | FontStyle.Italic);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = richTextBox1.SelectionFont;
            if (SelectedText_Font != null)
                richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style | FontStyle.Underline);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                string rtf = richTextBox1.Rtf;

                rtf = rtf.Replace(@"\qc", @"\qj");
                rtf = rtf.Replace(@"\ql", @"\qj"); 
                rtf = rtf.Replace(@"\qr", @"\qj"); 

                richTextBox1.Rtf = rtf;
            }
            else
            {
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (richTextBox1.Text.Length > 0)
            {
              
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (richTextBox1.Text.Length > 0)
            {
            
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
            else
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            if (richTextBox1.Text.Length > 0)
            {
            
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }
    }
}
