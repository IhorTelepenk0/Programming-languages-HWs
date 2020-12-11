namespace WindowsForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.totalByNamesButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.readButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "By Date\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalByNamesButton
            // 
            this.totalByNamesButton.Location = new System.Drawing.Point(120, 72);
            this.totalByNamesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalByNamesButton.Name = "totalByNamesButton";
            this.totalByNamesButton.Size = new System.Drawing.Size(130, 35);
            this.totalByNamesButton.TabIndex = 10;
            this.totalByNamesButton.Text = "Total by names";
            this.totalByNamesButton.UseVisualStyleBackColor = true;
            this.totalByNamesButton.Click += new System.EventHandler(this.totalByNamesButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(13, 131);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(763, 305);
            this.resultTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "File path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(13, 36);
            this.pathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(763, 26);
            this.pathTextBox.TabIndex = 7;
            this.pathTextBox.Text = "D:\\help folder if needed\\invoices.txt";
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(17, 72);
            this.readButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(95, 35);
            this.readButton.TabIndex = 6;
            this.readButton.Text = "Read file";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalByNamesButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.readButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button totalByNamesButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button readButton;
    }
}

