# 🗂️ پروژه مدیریت فایل (File Manager Console App)

این پروژه یک اپلیکیشن کنسولی ساده نوشته‌شده با زبان #C (سی‌شارپ) است که عملیات پایه‌ای کار با فایل سیستم را انجام می‌دهد.

---

## ✨ امکانات برنامه

این برنامه از طریق منوهای ساده به کاربر اجازه می‌دهد که:

1. 📁 ایجاد پوشه
2. 📄 نمایش فایل‌ها و پوشه‌ها در یک مسیر مشخص
3. ✍️ ایجاد و نوشتن در فایل متنی
4. 📖 خواندن محتوای فایل
5. 🗑️ حذف فایل
6. 🔁 انتقال فایل به مسیر دیگر
7. ℹ️ نمایش اطلاعات فایل (نام، حجم، تاریخ ساخت)
8. ❌ خروج از برنامه

---

## 🛠️ نحوه اجرا

1. ابتدا پروژه را با Visual Studio یا Visual Studio Code باز کنید.
2. اطمینان حاصل کنید که فایل‌های زیر در پروژه موجود باشند:
   - `Program.cs`
   - `FileManager.cs`
3. پروژه را اجرا کرده و از طریق منوها، عملیات دلخواه را روی فایل سیستم انجام دهید.

---

## 📦 ساختار فایل‌ها
FileManagerApp/
├── Program.cs // فایل اصلی برنامه و منوی کاربر
└── FileManager.cs // کلاس کمکی برای انجام عملیات روی فایل‌ها و پوشه‌ها

---

## 📄 نمونه کد (CreateAndWriteFile)

در کلاس `FileManager` یکی از متدهای اصلی به صورت زیر پیاده‌سازی شده است:

```csharp
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

برای درک بهتر این پروژه، پیشنهاد می‌شود با موارد زیر آشنا باشید:

اصول پایه برنامه‌نویسی به زبان #C

فضای نام System.IO

متدهای کلاس‌های File, Directory, Path, FileInfo

🤝 مشارکت
اگر دوست دارید ویژگی جدیدی به برنامه اضافه کنید (مثل کپی فایل، جستجو در محتویات، ویرایش فایل‌ها و...) خوشحال می‌شوم Pull Request ارسال کنید.

🧑‍💻 توسعه‌دهنده
👤 Ali Mobinifar

📧 Email: mobinifarAli62@gmail.com
