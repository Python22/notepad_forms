using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad_forms
{
    public partial class Form1 : Form
    {
        private string current_file_name;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Новый документ - блокнот";

        }

        private bool is_need_save()
        {
            var result = MessageBox.Show("Сохранить текущий файл?", "Внимание", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(current_file_name) == false)
                {
                    var editor = this.Controls["richTextBox1"];
                    File.WriteAllText(current_file_name, editor.Text);
                    return false;                // ПОТОМ ДОДЕЛАЕМ
                }
            }
            else if (result == DialogResult.No)
            {
                return false;
            }
            return true;    
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editor = this.Controls["richTextBox1"];
            if (is_need_save() == false) 
            {
                using (var ofd = new OpenFileDialog()) 
                {
                    ofd.Filter = "текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    if (ofd.ShowDialog() == DialogResult.OK) { 
                        editor.Text = File.ReadAllText(ofd.FileName);
                        current_file_name = ofd.FileName;
                        this.Text = ofd.FileName + " - блокнот";
                    }
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(current_file_name) == false) 
            {
                var editor = this.Controls["richTextBox1"];
                File.WriteAllText(current_file_name, editor.Text);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editor = this.Controls["richTextBox1"];
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, editor.Text);
                }
            }

        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editor = this.Controls["richTextBox1"];
            editor.Text = "";
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    current_file_name = sfd.FileName;
                    this.Text = sfd.FileName;
                }
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editor = this.Controls["richTextBox1"];
            using (ColorDialog color_dialog = new ColorDialog()) 
            {
                color_dialog.Color = editor.ForeColor;
                if (color_dialog.ShowDialog() == DialogResult.OK) 
                { 
                    editor.ForeColor = color_dialog.Color;
                }
            }
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editor = this.Controls["richTextBox1"];
            using (ColorDialog color_dialog = new ColorDialog())
            {
                color_dialog.Color = editor.BackColor;
                if (color_dialog.ShowDialog() == DialogResult.OK)
                {
                    editor.BackColor = color_dialog.Color;
                }
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editor = this.Controls["richTextBox1"];
            using (FontDialog font_dialog = new FontDialog())
            {
                font_dialog.Font = editor.Font;
                if (font_dialog.ShowDialog() == DialogResult.OK)
                {
                    editor.Font = font_dialog.Font;
                }
            }
        }


    }
}
