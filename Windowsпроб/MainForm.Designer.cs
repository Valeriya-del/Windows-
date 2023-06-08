
namespace Windowsпроб
{
    partial class MainForm
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
            this.StudentsButton = new System.Windows.Forms.Button();
            this.ResultsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentsButton
            // 
            this.StudentsButton.Location = new System.Drawing.Point(66, 60);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(195, 58);
            this.StudentsButton.TabIndex = 0;
            this.StudentsButton.Text = "Студенты";
            this.StudentsButton.UseVisualStyleBackColor = true;
            this.StudentsButton.Click += new System.EventHandler(this.StudentsButton_Click);
            // 
            // ResultsButton
            // 
            this.ResultsButton.Location = new System.Drawing.Point(66, 124);
            this.ResultsButton.Name = "ResultsButton";
            this.ResultsButton.Size = new System.Drawing.Size(195, 59);
            this.ResultsButton.TabIndex = 1;
            this.ResultsButton.Text = "Результаты";
            this.ResultsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 289);
            this.Controls.Add(this.ResultsButton);
            this.Controls.Add(this.StudentsButton);
            this.Name = "MainForm";
            this.Text = "Заглавная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentsButton;
        private System.Windows.Forms.Button ResultsButton;
    }
}

