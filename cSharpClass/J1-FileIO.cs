using System.IO;
using System;

public class FileIO
{
    public void Do()
    {
        //string folderPath = @"D:\Test"; //better way
        string filePath = @"D:\Test\test1.txt"; //better way
        //or
        //string folderPath ="D:\\Test";
       // File.Create(filePath);
        //File.WriteAllText(filePath,"This is test to replace file content" );
        //File.AppendAllText(filePath,"This is test to append file content" );
        //Console.WriteLine("File Creatd successfully");

        var textFile = File.ReadAllText(filePath);
        Console.WriteLine($"File Content is : {textFile}");

        //Directory.CreateDirectory(@"D:\Test\TestDirectory");

        FileInfo fi =new(filePath);
        Console.WriteLine("Created Date :" +fi.CreationTime);
        Console.WriteLine("last update date:" + fi.LastWriteTime);
        Console.WriteLine("file size : "+ (float)fi.Length/1024 +"KB");

    }
}