namespace ConsoleApp
{
  class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int sum, sub, div, mul,a,b;

            a = 1; b = 2;   

            calculator.Sum(a,b);
            calculator.Sub(a,b);
            calculator.div(a,b);
            calculator.mul(a,b);
        }
    }
}