using FleSystem;
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- File Manager ---");
            Console.WriteLine("1. Create folder");
            Console.WriteLine("2. List files and folders");
            Console.WriteLine("3. Create and write to a file");
            Console.WriteLine("4. Read a file");
            Console.WriteLine("5. Delete a file");
            Console.WriteLine("6. Move a file");
            Console.WriteLine("7. Show file info");
            Console.WriteLine("8. Exit");
            Console.Write("Your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the path for the new folder: ");
                    string folderPath = Console.ReadLine();
                    FileManager.CreateFolder(folderPath);
                    break;

                case "2":
                    Console.Write("Enter the path to list files and folders: ");
                    string listPath = Console.ReadLine();
                    FileManager.ListFilesAndFolders(listPath);
                    break;

                case "3":
                    Console.Write("Enter the full file path: ");
                    string filePath = Console.ReadLine();
                    Console.Write("Enter the text to write into the file: ");
                    string content = Console.ReadLine();
                    FileManager.CreateAndWriteFile(filePath, content);
                    break;

                case "4":
                    Console.Write("Enter the file path to read: ");
                    string readPath = Console.ReadLine();
                    FileManager.ReadFile(readPath);
                    break;

                case "5":
                    Console.Write("Enter the file path to delete: ");
                    string deletePath = Console.ReadLine();
                    FileManager.DeleteFile(deletePath);
                    break;

                case "6":
                    Console.Write("Enter the source file path: ");
                    string source = Console.ReadLine();
                    Console.Write("Enter the destination file path: ");
                    string destination = Console.ReadLine();
                    FileManager.MoveFile(source, destination);
                    break;

                case "7":
                    Console.Write("Enter the file path to show info: ");
                    string infoPath = Console.ReadLine();
                    FileManager.ShowFileInfo(infoPath);
                    break;

                case "8":
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
