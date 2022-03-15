using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baryshev6Listing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Rtf;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Устанавливаем фокус на richTextBox
            richTextBox1.Focus();
            // Устанавливаем цвет для выделенного текста
            richTextBox1.SelectionColor = Color.Red;
            // Устанавливаем шрифт
            richTextBox1.SelectionFont = new Font("Courier", 10, FontStyle.Bold);
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.AllowDrop = true;
            this.richTextBox1.DragEnter +=
            new System.Windows.Forms.DragEventHandler(
            this.richTextBox1_DragEnter);
            this.richTextBox1.DragDrop +=
            new System.Windows.Forms.DragEventHandler(
            this.richTextBox1_DragEnter);
        }
        private void richTextBox1_DragEnter(object sender,
 System.Windows.Forms.DragEventArgs e)
        {
            if (((DragEventArgs)e).Data.GetDataPresent(DataFormats.Text))
                ((DragEventArgs)e).Effect = DragDropEffects.Move;
            else
                ((DragEventArgs)e).Effect = DragDropEffects.None;
        }
        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            richTextBox1.LoadFile((String)e.Data.GetData("Text"),
            System.Windows.Forms.RichTextBoxStreamType.RichText);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RichTextBoxEx rboxex = new RichTextBoxEx();
            rboxex.Parent = this;
            rboxex.Top = 400;
        }
        class RichTextBoxEx : RichTextBox
        {
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                //Проверяем на нажатие Shift+Insert и Ctrl+V
                if ((keyData & (Keys.Shift | Keys.Insert)) ==
                (Keys.Shift | Keys.Insert)
                || ((keyData & (Keys.Control | Keys.V)) ==
                (Keys.Control | Keys.V))) return true;
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Устанавливаем фокус
            dateTimePicker1.Focus();
            // Посылаем команду
            SendKeys.Send("{F4}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(60, 255, 192, 192);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lnkMySite.Text = "На нашем сайте вы найдете дополнительную информацию";
            lnkMySite.LinkArea = new LinkArea(3, 11);

        }

        private void lnkMySite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://rusproject.narod.ru/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lnkCommon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
