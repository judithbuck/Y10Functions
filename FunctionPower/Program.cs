namespace FunctionPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // complete the code below for a function 'Raise To Power' to calculate
            // result of 7 ^ 2 by replacing the '?' with the appropriate C# code
            // test with other 'power' calculations eg 8 ^ 3,  5 ^ 1, 15 ^ 0
            int myresult = raisetoPower();
            Console.WriteLine("7 to the power 2  = " + myresult);
        }

        static int raisetoPower()
        {
            int num = 7;
            int power = 2;

            int result = ?;

            for (int i = ?; i <= ?; i++)


        }
        // answer below

        static int raiseToPowerComplete(int num, int power)
        {
            //int num = 7;
            //int power = 1;

            int result = 1;

            for (int i = 1; i <= power; i++)
            {
                result = result * num;
            }

            return result;
        }
    }
}
