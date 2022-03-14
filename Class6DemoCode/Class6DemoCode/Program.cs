using System;
using System.IO;

namespace Class6DemoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo myFile = new FileInfo(@"..\..\..\SampleTextFile.txt");
            Console.WriteLine($"The full filename is: {myFile.FullName}");
            Console.WriteLine($"Length: {myFile.Length}");
            Console.WriteLine($"CreationTime: {myFile.CreationTime}");
            Console.WriteLine($"CreationTime: {myFile.LastAccessTime}");
            Console.WriteLine($"LastWriteTime: {myFile.LastWriteTime}");
            Console.WriteLine($"Attributes: {myFile.Attributes}");

            DirectoryInfo myDirectory = new DirectoryInfo(@".");
            Console.WriteLine($"\n\n\n------Directory Info------");
            Console.WriteLine($"Name: {myDirectory.Name}");
            Console.WriteLine($"Parent: {myDirectory.Parent}");
            Console.WriteLine($"Root: {myDirectory.Root}");

        }
    }
}
