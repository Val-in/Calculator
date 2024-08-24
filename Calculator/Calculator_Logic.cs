namespace Calculator
{
    public class Calculator_Logic
    {
        /// <summary>
        /// Метод возвращает корректный результат после сложения двух положительных чисел. 
        /// </summary>
        /// <param name="a">  первое слагаемое </param>  
        /// <param name="b">  второе слагаемое </param>   
        /// <returns>  ожидаемый результат после сложения </returns> 
        public int Additional(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
