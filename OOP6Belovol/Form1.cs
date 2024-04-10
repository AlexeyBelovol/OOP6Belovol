using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP6Belovol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);

                double result = -b / a;

                labelResult.Text = $"Результат: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Невірний формат числа. Введіть числове значення.", "Помилка");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Помилка: ділення на нуль.", "Помилка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка");
            }
            finally
            {

            }
        }
    }
}
