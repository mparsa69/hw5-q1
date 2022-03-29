// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

string sourcePath = @"E:\Projects\CopyFile\CopyFile";
string destPath = @"E:\Projects\CopyFile\CopyFile\Archive";
string SourceFileName = "Class1.cs";
string destinationFileName = DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";
string sourceFile = Path.Combine(sourcePath, SourceFileName);
string destinationFile = Path.Combine(destPath, destinationFileName);
//if (!Directory.Exists(sourcePath))
//{
//    throw new DirectoryNotFoundException("Sourxe Path Does Not Exist");
    
//}
//if (!Directory.Exists(destPath))
//{
//    throw new DirectoryNotFoundException("Destination Path Does Not Exist");
//}
//if (!File.Exists(SourceFileName))
//{
//    throw new FileNotFoundException("Sourth File  Does Not Exist");
//}
try
{
    File.Copy(sourceFile, destinationFile, true);
    Console.WriteLine("File Copied. Everything is OK");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine("Directory Does Not Found");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("File Does Not Found");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("You do not have permission.");
}
