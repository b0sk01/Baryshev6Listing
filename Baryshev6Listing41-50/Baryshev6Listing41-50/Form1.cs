using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baryshev6Listing41_50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Вставьте код в конструктор формы после вызова
            // метода InitializeComponent
            // Создаем экземпляр ListViewColumnSorter и связываем его с ListView
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
        }

        private ListViewColumnSorter lvwColumnSorter;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lnkSearchUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel lnk = new LinkLabel();
            lnk = (LinkLabel)sender;
            lnk.Links[lnk.Links.IndexOf(e.Link)].Visited = true;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lnkSearchUrl.Text = "Yandex Google Rambler GoGo";
            lnkSearchUrl.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkSearchUrl.Links.Add(0, 6, "www.yandex.ru");
            lnkSearchUrl.Links.Add(7, 6, "www.google.ru");
            lnkSearchUrl.Links.Add(14, 7, "www.rambler.ru");
            lnkSearchUrl.Links.Add(22, 4, "www.gogo.ru");
            lnkSearchUrl.LinkClicked +=
            new LinkLabelLinkClickedEventHandler(lnkCommon_LinkClicked);
        }

        private void lnkCommon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (FormWindowState.Minimized == WindowState)
                    Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (notifyIcon1.Visible)
                notifyIcon1.Visible = false;
            else
                notifyIcon1.Visible = true;

            notifyIcon1.Icon = aIcons[curIcon];
            curIcon++;
            if (curIcon > 7) curIcon = 0;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            notifyIcon1.Visible = true;
            MessageBox.Show("Мигание приостановлено");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        // Массив, содержащий серию значков для создания анимации
        private Icon[] aIcons = new Icon[8];
        // текущий значок
        int curIcon = 0;
        private void button5_Click(object sender, EventArgs e)
        {
        }

        private bool m_CloseOK = false;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Пользователь выходит из программы не через контекстное меню
            if (m_CloseOK == false)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
        // выходим из программы по-настоящему
         m_CloseOK = true;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Убираем выделение с нужного элемента
            this.listView1.SelectedItems.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Установим фокус
            listView1.Focus();
            // Выбираем второй элемент
            listView1.Items[1].Selected = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Вставьте следующий код в обработчик события Load формы
            // Используется для создания заголовков
            ColumnHeader columnheader;
            // Используется для создания элементов в ListView
            ListViewItem listviewitem;
            // Устанавливаем нужный вид
            listView1.View = View.Details;
            // Создаем несколько элементов, содержащих имена и фамилии
            listviewitem = new ListViewItem("Александр");
            listviewitem.SubItems.Add("Суворов");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Наполеон");
            listviewitem.SubItems.Add("Бонапарт");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Михаил");
            listviewitem.SubItems.Add("Кутузов");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Юлий");
            listviewitem.SubItems.Add("Цезарь");
            this.listView1.Items.Add(listviewitem);
            // Создаем колонки
            columnheader = new ColumnHeader();
            columnheader.Text = "Имя";
            this.listView1.Columns.Add(columnheader);
            columnheader = new ColumnHeader();
            columnheader.Text = "Фамилия";
            this.listView1.Columns.Add(columnheader);
 // Проходим через все элементы и устанавливаем размер каждого
 // заголовка колонки равным тексту
            foreach (ColumnHeader ch in this.listView1.Columns) { ch.Width = -2; }
        }
    }
}
