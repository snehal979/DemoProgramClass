namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 4, 3, 5 };
            double[] doubleArray = { 1.1, 2.1, 2.2 };
            char[] charArray = { 'a', 's', 'd', 'f' };
            Console.WriteLine("Hint Print Method 2.Generic Method 3.Generic Class 4.FindMax");
            PrintArray printArray = new PrintArray();
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    printArray.ToPrint(array);
                    printArray.ToPrint(doubleArray);
                    printArray.ToPrint(charArray);
                    break;
                case 2:
                    GnericsArray.ToPrint(array);
                    GnericsArray.ToPrint(doubleArray);
                    GnericsArray.ToPrint(charArray);
                    break;
                case 3:
                    GenericClass<int> genericClass = new GenericClass<int>(array);
                    genericClass.ToPrint();
                    break;
                case 4:
                    FindMax.FindMaxNumber(30, 40, 50);
                    FindMax.FindMaxNumber("Snehal", "Sneha", "SnehalB");

                    break;
            }
           
        }
    }
}