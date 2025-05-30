﻿namespace Pr5
{
    public partial class Pr5_6 : Form
    {
        public Pr5_6()
        {
            InitializeComponent();
        }
      
        public static int[] FindMinMax(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return [0, 0]; 
            }

            int min = numbers[0];
            int max = numbers[0];

            foreach (int num in numbers)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            return [min, max];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inputs = textBox.Text.Split([' ', ','], StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = Array.ConvertAll(inputs, int.Parse);

                if (numbers.Length == 0)
                {
                    MessageBox.Show(
                        "Введите хотя бы один элемент",
                        "Ошибка ввода",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                //один аргумент-массив
                int[] result = FindMinMax(numbers);
                labelResult.Text = $"Минимальное: {result[0]}, Максимальное: {result[1]}";

                //2 аргумента мин и макс
                result = FindMinMax(100, 3);
                labelResult.Text += $"\nМинимальное: {result[0]}, Максимальное: {result[1]}";

                //4 аргумента, 1 мин и несколько макс подряд
                result = FindMinMax(0, 9, 89, 89);
                labelResult.Text += $"\nМинимальное: {result[0]}, Максимальное: {result[1]}";

                //4 аргумента, 1 макс и несколько мин подряд
                result = FindMinMax(0, -4, -4, 8);
                labelResult.Text += $"\nМинимальное: {result[0]}, Максимальное: {result[1]}";

                //3 аргумента, одинаковые знач
                result = FindMinMax(0, 0, 0);
                labelResult.Text += $"\nМинимальное: {result[0]}, Максимальное: {result[1]}";

                //8 аргумента, несколько макс и мин вперемешку
                result = FindMinMax(1, 2, 5, -8, 5, -8, 3, 0);
                labelResult.Text += $"\nМинимальное: {result[0]}, Максимальное: {result[1]}";


            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Введите только целые числа, разделенные пробелами или запятыми",
                    "Ошибка ввода", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "Введено слишком большое или слишком маленькое число",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Произошла ошибка: {ex.Message}",
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            labelResult.Text = "";
        }

        private void btnTransition_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain mainForm = new FormMain();
            mainForm.Show();
        } 
    }
}
