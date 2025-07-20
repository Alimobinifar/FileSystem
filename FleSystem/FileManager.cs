using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FleSystem
{
    public static class FileManager
    {
        public static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Folder created", path);
            }
            else
            {
                Console.WriteLine(path, "is already exists");
            }
        }

        public static void ListFilesAndFolders(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine($"path {path} does not exists");
                return;
            }

            Console.WriteLine("Files : ");

            foreach (var file in Directory.GetFiles(path))
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            Console.WriteLine("Folders : ");

            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine(Path.GetFileName(folder));
            }
        }

        public static void CreateAndWriteFile(string path, string content)
        {
            try
            {
                string directory = Path.GetDirectoryName(path);

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Console.WriteLine($"Directory {directory} created.");
                }

                File.WriteAllText(path, content);
                Console.WriteLine($"File {path} has been created and content written successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while creating/writing the file: {ex.Message}");
            }
        }


        public static void ReadFile(string path)
        {
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                Console.WriteLine("content:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File does not exists.");
            }
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File has been deleted successfully");
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }

        public static void MoveFile(string sourcePath, string destinationPath)
        {
            if (Directory.Exists(sourcePath))
            {
                File.Move(sourcePath, destinationPath);
                Console.WriteLine("File has been moved successfully");
            }
            else
            {
                Console.WriteLine($"{sourcePath} Does not exists");
            }
        }

        public static void ShowFileInfo(string filePath)
        {
            if (File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                Console.WriteLine($"File Name {fileInfo.Name}");
                Console.WriteLine($"File Size {fileInfo.Length}");
                Console.WriteLine($"Created date {fileInfo.CreationTime}");
                Console.WriteLine($"Last Change {fileInfo.LastWriteTime}");
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }
    }
}