
namespace Baryshev6Listing41_50
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lnkSearchUrl = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.lnkCommon = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnkSearchUrl
            // 
            this.lnkSearchUrl.AutoSize = true;
            this.lnkSearchUrl.Location = new System.Drawing.Point(633, 52);
            this.lnkSearchUrl.Name = "lnkSearchUrl";
            this.lnkSearchUrl.Size = new System.Drawing.Size(55, 13);
            this.lnkSearchUrl.TabIndex = 0;
            this.lnkSearchUrl.TabStop = true;
            this.lnkSearchUrl.Text = "linkLabel1";
            this.lnkSearchUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSearchUrl_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = " 6.41. Управление ссылками в LinkLabel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnkCommon
            // 
            this.lnkCommon.AutoSize = true;
            this.lnkCommon.Location = new System.Drawing.Point(633, 77);
            this.lnkCommon.Name = "lnkCommon";
            this.lnkCommon.Size = new System.Drawing.Size(55, 13);
            this.lnkCommon.TabIndex = 2;
            this.lnkCommon.TabStop = true;
            this.lnkCommon.Text = "linkLabel2";
            this.lnkCommon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCommon_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "6.42. Прячем приложение с панели задач ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 64);
            this.button3.TabIndex = 4;
            this.button3.Text = "6.43. Обработка двойного щелчка";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 64);
            this.button4.TabIndex = 5;
            this.button4.Text = " 6.44. Создание мигающего значка ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 64);
            this.button5.TabIndex = 6;
            this.button5.Text = "6.45. Анимация значка ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 64);
            this.button6.TabIndex = 7;
            this.button6.Text = "6.46. Сворачивание вместо закрытия";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(154, 26);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 64);
            this.button7.TabIndex = 8;
            this.button7.Text = "6.47. Снятие выделения с элемента ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(576, 109);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(212, 329);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(154, 96);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 64);
            this.button8.TabIndex = 10;
            this.button8.Text = "6.48. Программное выделение элемента в ListView";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(154, 166);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 64);
            this.button9.TabIndex = 11;
            this.button9.Text = " 6.49. Код, добавляемый в конструктор формы";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(154, 236);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(136, 64);
            this.button10.TabIndex = 12;
            this.button10.Text = "6.50. Код, добавляемый в обработчик события Load";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lnkCommon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnkSearchUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkSearchUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lnkCommon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

