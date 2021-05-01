
namespace Portfolio.Clicker.TextRedactor
{
    partial class PortfolioForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortfolioForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabSoft = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabAuthor = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxClicker = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Disign_panel = new System.Windows.Forms.Panel();
            this.Design_labelX = new System.Windows.Forms.Label();
            this.Design_label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabSoft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Disign_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGame);
            this.tabControl1.Controls.Add(this.tabSoft);
            this.tabControl1.Controls.Add(this.tabAuthor);
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGame
            // 
            this.tabGame.Controls.Add(this.textBox1);
            this.tabGame.Controls.Add(this.pictureBox2);
            this.tabGame.Location = new System.Drawing.Point(4, 29);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabGame.Size = new System.Drawing.Size(430, 374);
            this.tabGame.TabIndex = 0;
            this.tabGame.Text = "Game";
            this.tabGame.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(158, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(264, 154);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Кликер. Игра для подсчета количества кликов в секунду. Ваша задача как можно быст" +
    "рей кликать мышкой по кнопке , чтобы игра закончилась , после будет объявлен рез" +
    "ультат.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::Portfolio.Properties.Resources.clicker;
            this.pictureBox2.Location = new System.Drawing.Point(8, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tabSoft
            // 
            this.tabSoft.Controls.Add(this.textBox2);
            this.tabSoft.Controls.Add(this.pictureBox3);
            this.tabSoft.Location = new System.Drawing.Point(4, 29);
            this.tabSoft.Name = "tabSoft";
            this.tabSoft.Padding = new System.Windows.Forms.Padding(3);
            this.tabSoft.Size = new System.Drawing.Size(430, 374);
            this.tabSoft.TabIndex = 1;
            this.tabSoft.Text = "Soft";
            this.tabSoft.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(158, 14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(264, 154);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Небольшой текстовый редактор с некоторыми функциями:\r\nПоиск слова\r\nЗамена слова\r\n" +
    "Шифрование";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::Portfolio.Properties.Resources.ТекстРедактор;
            this.pictureBox3.Location = new System.Drawing.Point(8, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 154);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // tabAuthor
            // 
            this.tabAuthor.Controls.Add(this.linkLabel1);
            this.tabAuthor.Controls.Add(this.textBoxClicker);
            this.tabAuthor.Controls.Add(this.pictureBox1);
            this.tabAuthor.Location = new System.Drawing.Point(4, 29);
            this.tabAuthor.Name = "tabAuthor";
            this.tabAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuthor.Size = new System.Drawing.Size(430, 374);
            this.tabAuthor.TabIndex = 2;
            this.tabAuthor.Tag = "https://vk.com/nikitaizotov";
            this.tabAuthor.Text = "Author";
            this.tabAuthor.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(50, 183);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "https://vk.com/nikitaizotov";
            this.linkLabel1.Text = "Вконтакте";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxClicker
            // 
            this.textBoxClicker.BackColor = System.Drawing.Color.White;
            this.textBoxClicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClicker.Location = new System.Drawing.Point(175, 26);
            this.textBoxClicker.Multiline = true;
            this.textBoxClicker.Name = "textBoxClicker";
            this.textBoxClicker.ReadOnly = true;
            this.textBoxClicker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxClicker.Size = new System.Drawing.Size(230, 326);
            this.textBoxClicker.TabIndex = 1;
            this.textBoxClicker.Text = resources.GetString("textBoxClicker.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Portfolio.Properties.Resources.photo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Disign_panel
            // 
            this.Disign_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Disign_panel.Controls.Add(this.Design_labelX);
            this.Disign_panel.Controls.Add(this.Design_label);
            this.Disign_panel.Location = new System.Drawing.Point(0, -1);
            this.Disign_panel.Name = "Disign_panel";
            this.Disign_panel.Size = new System.Drawing.Size(434, 38);
            this.Disign_panel.TabIndex = 1;
            // 
            // Design_labelX
            // 
            this.Design_labelX.AutoSize = true;
            this.Design_labelX.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Design_labelX.ForeColor = System.Drawing.Color.Red;
            this.Design_labelX.Location = new System.Drawing.Point(387, 1);
            this.Design_labelX.Name = "Design_labelX";
            this.Design_labelX.Size = new System.Drawing.Size(39, 37);
            this.Design_labelX.TabIndex = 5;
            this.Design_labelX.Text = "X";
            this.Design_labelX.Click += new System.EventHandler(this.Design_labelX_Click);
            // 
            // Design_label
            // 
            this.Design_label.AutoSize = true;
            this.Design_label.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Design_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Design_label.Location = new System.Drawing.Point(0, 6);
            this.Design_label.Name = "Design_label";
            this.Design_label.Size = new System.Drawing.Size(177, 29);
            this.Design_label.TabIndex = 0;
            this.Design_label.Text = "MyPortfolio";
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.Disign_panel);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortfolioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabSoft.ResumeLayout(false);
            this.tabSoft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabAuthor.ResumeLayout(false);
            this.tabAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Disign_panel.ResumeLayout(false);
            this.Disign_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.TabPage tabSoft;
        private System.Windows.Forms.TabPage tabAuthor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxClicker;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel Disign_panel;
        private System.Windows.Forms.Label Design_label;
        private System.Windows.Forms.Label Design_labelX;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

