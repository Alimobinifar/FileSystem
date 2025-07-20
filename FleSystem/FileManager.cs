using System;
using System.IO;

namespace FileSystem
{
    public static class FileManager
    {
        public static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"✅ Folder created: {path}");
            }
            else
            {
                Console.WriteLine($"ℹ️ Folder already exists: {path}");
            }
        }

        public static void ListFilesAndFolders(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine($"❌ Path does not exist: {path}");
                return;
            }

            Console.WriteLine($"\n📁 Listing contents of: {path}");

            Console.WriteLine("\nFiles:");
            foreach (var file in Directory.GetFiles(path))
            {
                Console.WriteLine($"- {Path.GetFileName(file)}");
            }

            Console.WriteLine("\nDirectories:");
            foreach (var dir in Directory.GetDirectories(path))
            {
                Console.WriteLine($"- {Path.GetFileName(dir)}");
            }
        }

        public static void CreateAndWriteFile(string path, string content)
        {
            try
            {
                string? directory = Path.GetDirectoryName(path);

                if (!string.IsNullOrWhiteSpace(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Console.WriteLine($"📁 Directory created: {directory}");
                }

                File.WriteAllText(path, content);
                Console.WriteLine($"✅ File created and content written: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Failed to create/write file: {ex.Message}");
            }
        }

        public static void ReadFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"❌ File not found: {path}");
                return;
            }

            try
            {
                string content = File.ReadAllText(path);
                Console.WriteLine($"\n📄 File content ({path}):\n");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error reading file: {ex.Message}");
            }
        }

        public static void DeleteFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"❌ File not found: {path}");
                return;
            }

            try
            {
                File.Delete(path);
                Console.WriteLine($"🗑️ File deleted: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error deleting file: {ex.Message}");
            }
        }

        public static void MoveFile(string sourcePath, string destinationPath)
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine($"❌ Source file not found: {sourcePath}");
                return;
            }

            try
            {
                string? destinationDir = Path.GetDirectoryName(destinationPath);
                if (!string.IsNullOrWhiteSpace(destinationDir) && !Directory.Exists(destinationDir))
                {
                    Directory.CreateDirectory(destinationDir);
                    Console.WriteLine($"📁 Destination directory created: {destinationDir}");
                }

                File.Move(sourcePath, destinationPath);
                Console.WriteLine($"✅ File moved to: {destinationPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Failed to move file: {ex.Message}");
            }
        }

        public static void ShowFileInfo(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"❌ File not found: {filePath}");
                return;
            }

            FileInfo fileInfo = new FileInfo(filePath);

            Console.WriteLine($"\n📄 File Info for: {filePath}");
            Console.WriteLine($"- Name:         {fileInfo.Name}");
            Console.WriteLine($"- Size:         {fileInfo.Length} bytes");
            Console.WriteLine($"- Created At:   {fileInfo.CreationTime}");
            Console.WriteLine($"- Last Modified:{fileInfo.LastWriteTime}");
        }
    }
}
