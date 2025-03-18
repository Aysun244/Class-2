namespace Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Say");
            int count = Convert.ToInt32(Console.ReadLine());
            Book[] books = new Book[count];
            for (int i=0;i<count;i++)
            {
                Console.WriteLine($"No");
                int no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Name");
                int name = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Price");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Genre");
                int genre = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<count;i++)
            {
                Console.WriteLine($"Name:{books[i].Name},Price:{books[i].Price}");
            }
        }
    }
}
