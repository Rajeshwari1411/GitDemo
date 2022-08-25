using System;
using System.IO;
public class Exercise4
{
    public static void Main()
    {
        DriveInfo[] drivelist = DriveInfo.GetDrives();
        foreach (DriveInfo d in drivelist)
        {
            Console.WriteLine("Drive {0}", d.Name);
        }
    }
}

