using System;
using System.Windows.Forms;
namespace Portfolio.TextRedactor
{
    public partial class FormForSearch : Form
    {
        public FormForSearch()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Свойство , возрвращающее слово для поиска
        /// </summary>
        public string GetWord
        {
            get { return textBoxForSearch.Text; } 
        }
        /// <summary>
        /// Кнока , активизирующая поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonForSearch_Click(object sender, EventArgs e)
        {
            if (textBoxForSearch.Text == "") this.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        /// <summary>
        /// Скрытие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
