// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Working with file information

// Make sure the example file exists
const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file
Console.WriteLine("File Information using File class:");
Console.WriteLine($"File exists: {File.Exists(filename)}");
Console.WriteLine($"File size: {new FileInfo(filename).Length} bytes");

// TODO: We can also get general information using a FileInfo 
FileInfo fileInfo = new FileInfo(filename);
Console.WriteLine("\nFile Information using FileInfo class:");
Console.WriteLine($"Full path: {fileInfo.FullName}");
Console.WriteLine($"Directory: {fileInfo.DirectoryName}");

// TODO: File information can also be manipulated
Console.WriteLine("\nManipulating file information:");
fileInfo.IsReadOnly = false; // Remove read-only attribute if set
File.SetLastWriteTime(filename, DateTime.Now); // Update the last write time
Console.WriteLine("File last write time updated to now.");