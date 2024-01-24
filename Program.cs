namespace First_HW
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number ended by 5 -> ");
            int Num = Convert.ToInt32(Console.ReadLine());
            int NewNum = 0;
            if (Num % 10 == 5)
            {
                NewNum = ((Num / 10) * ((Num / 10) + 1) * 100 + 25);
            }
            else
            {
                Console.WriteLine("There isnt 5 at the end of the number!!!");
            }
            Console.WriteLine($"You got: {NewNum}");
            // No extra tasks because I have no time nowadays. Sorry!
        }
    }
}
