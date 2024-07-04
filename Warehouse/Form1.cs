using System.Diagnostics;
using System;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Label : Form
    {

        /// <summary>
        /// Приватное поле таймера
        /// </summary>
        private System.Windows.Forms.Timer timer;

        /// <summary>
        /// Приватоное целочисленное поле секунд для отсчета времени
        /// </summary>
        private int second = 10;

        /// <summary>
        /// Функция для инициаллизации формы и её объектов
        /// </summary>
        public Label()
        {
            InitializeComponent();
            URLforGit.LinkClicked += URLforGit_LinkClicked;

            TimerLabel.Text = second.ToString();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// Функция для перехода по ссылке на Git
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void URLforGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/p4shok/Warehouse");
        }

        /// <summary>
        /// Функция для открытия формы пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersButton_Click(object sender, EventArgs e)
        {
            Users userClick = new Users();
            userClick.Show();
            timer.Stop();
        }

        /// <summary>
        /// Функция для открытия формы товаров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StorageButton_Click(object sender, EventArgs e)
        {
            Storage storageClick = new Storage();
            storageClick.Show();
            timer.Stop();
        }

        /// <summary>
        /// Функция для закрытия формы по истечению времени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {

            second--;
            TimerLabel.Text = second.ToString();

            if(second == 0)
                this.Close();
        }

    }
}
