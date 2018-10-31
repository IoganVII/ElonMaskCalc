using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM.Calc.WinCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Core.Calc Calc;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Calc = new Core.Calc();
            string[] operations = Calc.Operations
                .Select(o => o.Name)
                .ToArray();

            cboperation.Items.AddRange(operations);
            cboperation.SelectedItem = cboperation.Items[0];
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            // Получить операции
            var operation = cboperation.Text;
            // Проверка на наличие операндов
            if (tbinput.Text != "")
            {
                //Проверка на последний символ
                if (tbinput.Text[tbinput.Text.Length-1]==32)
                {
                    tbinput.Text = tbinput.Text.Remove(tbinput.Text.Length - 1,1);
                }
                // Получить операнды
                var values = tbinput.Text
                    .Split(' ')
                    .Select(Convert.ToDouble)
                    .ToArray();

                // Выполнить расчёт
                var result = Calc.Execute(operation, values);
                //Вывод результат
                lblresult.ForeColor = Color.Black;
                lblresult.Text = "Результат: " + $"{result}";
            }
            else
            {
                lblresult.ForeColor = Color.Red;
                lblresult.Text = "Ошибка: Отсутствуют операнды";
            }
        }

        private void tbinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            // Блокировка если цифра
            if (!Char.IsDigit(number) && number != 8 && number != 32)
            {
                e.Handled = true;
            }
            // Блокировка если пустое поле и введён символ пробела
            if (tbinput.Text.Length == 0 && number == 32)
            {
                e.Handled = true;
            }
            // Блокировка если после пробела введён пробел
            if (tbinput.Text.Length > 0)
            {
                if (!Char.IsDigit(tbinput.Text[tbinput.Text.Length-1]) && number == 32)
                {
                    e.Handled = true;
                }
            }
        }

        private void tbinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
