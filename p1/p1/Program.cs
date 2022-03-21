string address = @"G:\MAKTAB\HomeWork5\p1\Demo_file.txt";
string fAddress = @"G:\MAKTAB\HomeWork5\p1\Archive";
File.WriteAllText(address, "Hello!");
bool error = false;
string message = "";
try
{
    if (!Directory.Exists(fAddress))
        throw new Exception("Archive folder doesn't exist!");
    else if (Directory.GetFiles(fAddress).Count() != 0)
        throw new Exception("There's already a file in the Archive folder");
    try
    {
        File.Copy(address, fAddress + @"\Demo_file.txt", false);
    }
    catch (Exception e)
    {
        message = e.Message;
        throw;
    }
    if (!Directory.Exists(fAddress) && Directory.GetFiles(fAddress).Count() != 0)
        Console.WriteLine($"Archive folder doesn't exist! -- There's already a file in the Archive folder -- {message}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    error = true;
}

if (!error)
    Console.WriteLine("File copied successfuly!");