namespace EM.Calc.WinCalc
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
            this.cboperation = new System.Windows.Forms.ComboBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.tbinput = new System.Windows.Forms.TextBox();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboperation
            // 
            this.cboperation.FormattingEnabled = true;
            this.cboperation.Location = new System.Drawing.Point(61, 28);
            this.cboperation.Name = "cboperation";
            this.cboperation.Size = new System.Drawing.Size(121, 21);
            this.cboperation.TabIndex = 0;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(58, 225);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(59, 13);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "Результат";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(61, 141);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(115, 59);
            this.btnExec.TabIndex = 2;
            this.btnExec.Text = "Вычислить";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // tbinput
            // 
            this.tbinput.Location = new System.Drawing.Point(61, 100);
            this.tbinput.Name = "tbinput";
            this.tbinput.Size = new System.Drawing.Size(100, 20);
            this.tbinput.TabIndex = 3;
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(61, 71);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "button2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(142, 71);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "button3";
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(223, 71);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 23);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "button4";
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(304, 71);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 23);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "button5";
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 436);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.tbinput);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.cboperation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboperation;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.TextBox tbinput;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
    }
}

