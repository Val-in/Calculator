namespace Calculator
{

    public class Program
    {
        static void Main(string[] args)
        {
            Calculator_Logic calculator = new Calculator_Logic();
            var additionalResult = calculator.Additional(5, 7);
            Console.WriteLine("Additional: {0}", additionalResult);

            var subtractionResult = calculator.Subtraction(2, 8);
            Console.WriteLine("Subtraction: {0}", subtractionResult);

            var multiplicationResult = calculator.Multiplication(6, 3);
            Console.WriteLine("Multiplication: {0}", multiplicationResult);

            var divisionResult = calculator.Division(6, 3);
            Console.WriteLine("Division: {0}", divisionResult);

            Console.ReadKey();
        }
    }
}
