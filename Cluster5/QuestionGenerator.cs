using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cluster5
{
    internal class QuestionGenerator
    {

        private int RandomGen()
        {
            Random random = new Random();
            return random.Next(0, 11);;
        }

        private int op()
        {
            Random random = new Random();
            return random.Next(0, 4); ;
        }

        public void question(out string Question, out double answer)
        {
            int OpSign = op();

            int number1 = RandomGen();
            System.Threading.Thread.Sleep(1);
            int number2 = RandomGen();

            switch (OpSign)
            {
                case 0:
                    Question = number1.ToString() + " + " + number2.ToString() + " = ";
                    answer = number1 + number2;

                    break;
                case 1:
                    Question = number1.ToString() + " - " + number2.ToString() + " = ";
                    answer = number1 - number2;

                    break;
                case 2:
                    Question = number1.ToString() + " x " + number2.ToString() + " = ";
                    answer = number1 * number2;

                    break;
                default:
                    while (number2 == 0)
                    {
                        number2 = RandomGen();
                    }

                    while (number1 % number2 != 0)
                    {
                        number1 = RandomGen();
                    }

                    answer = number1 / number2;
                    Question = number1.ToString() + " ÷ " + number2.ToString() + " = ";
                    break;
            }

        }
    }
}