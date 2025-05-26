using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Новый документ - блокнот";

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        }
    }
}
