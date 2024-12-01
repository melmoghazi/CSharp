namespace CSharpAdvanced.Delegates
{
    internal class Program
    {
       delegate int CalculateDelegate(int num1, int num2);
        /// <summary>
        /// Delegate and its method must have same return type, same parameters (type, order, count).
        /// </summary>
        /// <param name="args"></param>
        static void Main1(string[] args)
        {
            int n1 = 10;
            int n2 = 2;
            //create new instance from delegate
            CalculateDelegate del = new CalculateDelegate(Add);
            CalculateWithDelegate(n1, n2, del);
            //create new instance from delete with the method name directly
            CalculateDelegate del2 = Add;
            CalculateWithDelegate(n1, n2, del2);

            //send the method name that match the delegate directly
            CalculateWithDelegate(n1, n2, Add);
            CalculateWithDelegate(n1, n2, Subtraction);
            CalculateWithDelegate(n1, n2, Multiply);
            CalculateWithDelegate(n1, n2, Divide);

            Console.ReadKey();
        }
        static void CalculateWithDelegate(int num1, int num2,CalculateDelegate del)
        {
            var result = del(num1, num2);
            Console.WriteLine($"result = {result}");
        }

        static int Add(int numb1,int numb2)
        {
            Console.WriteLine("Add");
            return numb1 + numb2;
        }
        static int Subtraction(int numb1, int numb2)
        {
            Console.WriteLine("Subtraction");
            return numb1 - numb2;
        }
        static int Multiply(int numb1, int numb2)
        {
            Console.WriteLine("Multiply");
            return numb1 * numb2;
        }
        static int Divide(int numb1, int numb2)
        {
            Console.WriteLine("Divide");
            return numb1 / numb2;
        }
        
    }
}
