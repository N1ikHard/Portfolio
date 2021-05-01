using System;
using System.Windows.Forms;

namespace Portfolio.Clicker
{
    public partial class GameForm : Form
    {
        long start_time;        //Поле , для записи времени начала игры
        long finish_time;       //Поле , для записи времени конца игры
        byte max_counter=10;    //Поле , полного состояние счетчика
        byte click_counter;     //Поле-счетчик
        bool mode = false;      //Поле для режима игры "активный/неактивный" режим
        public GameForm()
        {
            InitializeComponent();
        }
        void StartGame()        //Метод , для начала игры
        {
            start_button.Enabled = false;   //Отключение кнопки "Начать игру"
            mode = true;                    //Режим игры в активное состояние
            click_counter = max_counter;    //Счетчик переводится в полное состояние
            Click_label.Text = click_counter.ToString(); //Вывод счетчика на экран
        }

        private void start_button_Click(object sender, EventArgs e) //Событие , для начала игры
        {
            StartGame();
        }
        void PlayGame() //Метод , для начала игры
        {
            if (mode)       //Если режим "активный" , заход
            {
                if (click_counter == 10) start_time = DateTime.Now.Ticks; //При полном счетчике , сохраняем время начала              
                click_counter--;                                    //отнимаем от счетчика
                Click_label.Text = click_counter.ToString();       //Выводим состояние счетчика
                if (click_counter == 0)                            //Условие для окончания игры
                {
                    FinishGame();
                }
            }
            else return;             
        }
        void FinishGame()           //Метод , для окончания игры
        {
            mode = false;           //Режим игры деактивирован
            finish_time = DateTime.Now.Ticks;       //Запись конечного времени
            double times = max_counter / TimeSpan.FromTicks(finish_time - start_time).TotalSeconds;    //Подсчет секунд между началом и концом
            Click_label.Text =times.ToString("#.#")+" clicks \nper seconds";    //Вывод информации
            start_button.Enabled = true;                                       //Включение кнопки "Начать игру"
        }
        private void Click_label_MouseDown(object sender, MouseEventArgs e)
        {
            PlayGame();                 //Событие для запуска метода PlayGame()
        }

        private void label_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: N1ikHard\nCreation time: 19.04.21", "Information");  //Вывод информации
        }
    }
}
