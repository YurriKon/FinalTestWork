
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        
        string[] array = { "cat", "dog", "zebra", "elefant", "fox", ":)", "A" };
        Console.WriteLine("Из следующих элементов массива:");
        for (int i = 0; i < array.Length; i = i + 1)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
        string[] array2 = new string[array.Length];
        Console.WriteLine("Из трех и менее символов состоят:");
        for (int i = 0; i < array.Length; i = i + 1)
        {
            
            if (array[i].Length < 4)
            {
                Array.Copy(array, array2, array.Length);
                Console.Write(array2[i] + "\t");
            }
        }
    }
}