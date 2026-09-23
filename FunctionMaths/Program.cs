namespace FunctionMaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double answer = choiceMaths(, , );
            Console.WriteLine(answer); 
        }

        static double choiceMaths(?)
        {
            ? result = 0;

            if (? == "add")
            {
                result = ?  + ?
            }
            else if (? == ?)
            {
                ;
            }
            else if ()
            {
                ;
            }

            ?

            else
            {
                ;
            }
            return result;
        }


        static double choiceMathsFull(int n1, int n2, string math)
        {
            double result = 0;

            if (math == "divide") 
            {
                result = Convert.ToDouble(n1) / n2;          
            }
            else if (math == "multiply")
            {
                result = n1 * n2;
            }
            else if (math == "subtract")
            {
                result = n1 - n2;
            }
            else if(math == "add")
            {
                result = n1 + n2;
            }
            else
            {
                Console.WriteLine("Enter a valid 'math' request");
            }
            return result;
        }
        int firstnum = Convert.ToInt32(Console.ReadLine());
        int secndnum = Convert.ToInt32(Console.ReadLine());
        string action = Console.ReadLine();
    }
}
