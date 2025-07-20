using System;
using FileSystem;

class Program
{
    static void Main()
    {
        Console.Title = "📁 File Manager Console App";

        while (true)
        {
            PrintMenu();

            Console.Write("👉 Enter your choice: ");
            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    Console.Write("📂 Enter folder path to create: ");
                    FileManager.CreateFolder(Console.ReadLine());
                    break;

                case "2":
                    Console.Write("📁 Enter path to list contents: ");
                    FileManager.ListFilesAndFolders(Console.ReadLine());
                    break;

                case "3":
                    Console.Write("📄 Enter file path to create/write: ");
                    string filePath = Console.ReadLine();
                    Console.Write("📝 Enter content to write: ");
                    string content = Console.ReadLine();
                    FileManager.CreateAndWriteFile(filePath, content);
                    break;

                case "4":
                    Console.Write("📖 Enter file path to read: ");
                    FileManager.ReadFile(Console.ReadLine());
                    break;

                case "5":
                    Console.Write("🗑️ Enter file path to delete: ");
                    FileManager.DeleteFile(Console.ReadLine());
                    break;

                case "6":
                    Console.Write("📦 Enter source file path: ");
                    string source = Console.ReadLine();
                    Console.Write("📥 Enter destination file path: ");
                    string destination = Console.ReadLine();
                    FileManager.MoveFile(source, destination);
                    break;

                case "7":
                    Console.Write("ℹ️ Enter file path to view info: ");
                    FileManager.ShowFileInfo(Console.ReadLine());
                    break;

                case "8":
                    Console.WriteLine("\n👋 Exiting the File Manager. Goodbye!\n");
                    return;

                default:
                    Console.WriteLine("⚠️ Invalid input. Please enter a number between 1 and 8.");
                    break;
            }

            Console.WriteLine("\n-----------------------------------------\n");
        }
    }

    private static void PrintMenu()
    {
        Console.WriteLine("\n=== 📁 File Manager ===");
        Console.WriteLine("1. Create folder");
        Console.WriteLine("2. List files and folders");
        Console.WriteLine("3. Create and write to a file");
        Console.WriteLine("4. Read a file");
        Console.WriteLine("5. Delete a file");
        Console.WriteLine("6. Move a file");
        Console.WriteLine("7. Show file info");
        Console.WriteLine("8. Exit");
    }
}
