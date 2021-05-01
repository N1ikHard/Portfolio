using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Clicker;
using Porfolio.TextRedactor;


namespace Portfolio.Clicker.TextRedactor
{
    public partial class PortfolioForm : Form
    {
        public PortfolioForm()
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
        }

        private void Design_labelX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RedactorForm redactorForm = new RedactorForm();
            redactorForm.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Internet Explorer\\iexplore.exe",linkLabel1.Tag.ToString());
        }
    }
}
