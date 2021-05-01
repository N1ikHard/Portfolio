
namespace Portfolio.Clicker
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.start_button = new System.Windows.Forms.Button();
            this.Click_label = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.start_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_button.Location = new System.Drawing.Point(0, 0);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(302, 69);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Начать игру";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // Click_label
            // 
            this.Click_label.AutoSize = true;
            this.Click_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Click_label.Location = new System.Drawing.Point(2, 63);
            this.Click_label.MaximumSize = new System.Drawing.Size(300, 200);
            this.Click_label.MinimumSize = new System.Drawing.Size(300, 200);
            this.Click_label.Name = "Click_label";
            this.Click_label.Size = new System.Drawing.Size(300, 200);
            this.Click_label.TabIndex = 2;
            this.Click_label.Text = "Click";
            this.Click_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Click_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Click_label_MouseDown);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_info.Location = new System.Drawing.Point(49, 261);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(220, 28);
            this.label_info.TabIndex = 3;
            this.label_info.Text = "Информация о авторе";
            this.label_info.Click += new System.EventHandler(this.label_info_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 289);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.Click_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label Click_label;
        private System.Windows.Forms.Label label_info;
    }
}

