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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboperation
            // 
            this.cboperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboperation.FormattingEnabled = true;
            this.cboperation.Location = new System.Drawing.Point(61, 65);
            this.cboperation.Name = "cboperation";
            this.cboperation.Size = new System.Drawing.Size(121, 28);
            this.cboperation.TabIndex = 0;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblresult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblresult.Location = new System.Drawing.Point(52, 326);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(124, 25);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "Результат";
            // 
            // btnExec
            // 
            this.btnExec.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExec.Location = new System.Drawing.Point(57, 239);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(115, 61);
            this.btnExec.TabIndex = 2;
            this.btnExec.Text = "Вычислить";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // tbinput
            // 
            this.tbinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbinput.Location = new System.Drawing.Point(57, 197);
            this.tbinput.Name = "tbinput";
            this.tbinput.Size = new System.Drawing.Size(322, 23);
            this.tbinput.TabIndex = 3;
            this.tbinput.TextChanged += new System.EventHandler(this.tbinput_TextChanged);
            this.tbinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbinput_KeyPress);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt2.Location = new System.Drawing.Point(61, 111);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "button2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt3.Location = new System.Drawing.Point(142, 111);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "button3";
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt4.Location = new System.Drawing.Point(223, 111);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 23);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "button4";
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt5.Location = new System.Drawing.Point(304, 111);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 23);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "button5";
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите операцию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите операнды через пробел";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

