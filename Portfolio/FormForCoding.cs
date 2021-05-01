using System;
using System.Windows.Forms;

namespace Portfolio.TextRedactor
{
    public partial class FormForCoding : Form
    {
        public FormForCoding()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Свойство для передачи ключа
        /// </summary>
        public int GetNum
        {
            get
            {
                return Int32.Parse((TextBoxForKey.Text));
            }
        }
        /// <summary>
        /// Событие активизации кодирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Coding_Click(object sender, EventArgs e)
        {
            if (TextBoxForKey.Text == "") this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        /// <summary>
        /// Событие для ввода в поле только десячиных чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxForKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
          
        }
        /// <summary>
        /// Скрытие формы по клику на "Х"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
