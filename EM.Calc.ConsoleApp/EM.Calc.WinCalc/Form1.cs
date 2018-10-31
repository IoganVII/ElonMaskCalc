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
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            // Получить операнды
            var values = tbinput.Text
                .Split(' ')
                .Select(Convert.ToDouble)
                .ToArray();

            // Получить операции
            var operation = cboperation.Text;
            // Выполнить расчёт
            var result = Calc.Execute(operation, values);
            //Вывод результат
            lblresult.Text = $"{result}";
        }
    }
}
