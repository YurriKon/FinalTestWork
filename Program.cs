// See https://aka.ms/new-console-template for more information

Console.WriteLine();

string[] array = {"cat", "dog", "zebra", "elefant", "fox", ":)", "A"};
Console.WriteLine("Из следующих элементов массива:");
for (int i = 0; i < array.Length; i = i + 1)
{
    Console.Write(array[i] + "\t");
}
Console.WriteLine();
Console.WriteLine("Из трех и менее символов состоят:");
for (int i = 0; i < array.Length; i = i + 1)
{
    string[] array2 = new string[array.Length];
    if (array[i].Length < 4)
    {
        Array.Copy(array, array2, array.Length);
        Console.Write(array2[i] + "\t");
    }  
}