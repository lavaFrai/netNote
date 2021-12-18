
namespace windows
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.open_file = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.user_icon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.encoding_selector = new System.Windows.Forms.ToolStripComboBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_icon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 570);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.encoding_selector});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_file,
            this.open_file,
            this.save,
            this.save_as});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // new_file
            // 
            this.new_file.Name = "new_file";
            this.new_file.Size = new System.Drawing.Size(180, 22);
            this.new_file.Text = "Создать";
            this.new_file.Click += new System.EventHandler(this.new_file_Click);
            // 
            // open_file
            // 
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(180, 22);
            this.open_file.Text = "Открыть";
            this.open_file.Click += new System.EventHandler(this.open_file_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(180, 22);
            this.save.Text = "Сохранить";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // save_as
            // 
            this.save_as.Name = "save_as";
            this.save_as.Size = new System.Drawing.Size(180, 22);
            this.save_as.Text = "Сохранить как...";
            this.save_as.Click += new System.EventHandler(this.save_as_Click);
            // 
            // user_icon
            // 
            this.user_icon.BackgroundImage = global::windows.Properties.Resources.user_icon;
            this.user_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.user_icon.Image = global::windows.Properties.Resources.user_icon_dark;
            this.user_icon.Location = new System.Drawing.Point(450, 10);
            this.user_icon.Name = "user_icon";
            this.user_icon.Size = new System.Drawing.Size(30, 30);
            this.user_icon.TabIndex = 1;
            this.user_icon.TabStop = false;
            this.user_icon.Click += new System.EventHandler(this.user_icon_Click);
            this.user_icon.MouseEnter += new System.EventHandler(this.user_icon_MouseEnter);
            this.user_icon.MouseLeave += new System.EventHandler(this.user_icon_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.user_icon);
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 50);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.textArea);
            this.panel3.Location = new System.Drawing.Point(300, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 550);
            this.panel3.TabIndex = 1;
            // 
            // textArea
            // 
            this.textArea.BackColor = System.Drawing.SystemColors.Control;
            this.textArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textArea.EnableAutoDragDrop = true;
            this.textArea.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArea.Location = new System.Drawing.Point(7, 10);
            this.textArea.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textArea.Name = "textArea";
            this.textArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textArea.Size = new System.Drawing.Size(477, 489);
            this.textArea.TabIndex = 0;
            this.textArea.Text = "";
            // 
            // encoding_selector
            // 
            this.encoding_selector.Items.AddRange(new object[] {
            "UTF8",
            "Unicode",
            "ASCII",
            "UTF7",
            "UTF32",
            "BigEndianUnicode"});
            this.encoding_selector.Name = "encoding_selector";
            this.encoding_selector.Size = new System.Drawing.Size(121, 23);
            this.encoding_selector.Text = "UTF8";
            this.encoding_selector.SelectedIndexChanged += new System.EventHandler(this.encoding_selector_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_icon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox user_icon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_file;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem save_as;
        private System.Windows.Forms.ToolStripMenuItem new_file;
        private System.Windows.Forms.ToolStripComboBox encoding_selector;
    }
}

