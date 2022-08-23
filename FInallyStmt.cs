using System;
using System.IO;
class FinallyDemo
{
    static void Main(string[] args)
    {
        FileStream outStream = null;
        FileStream inStream = null;
        try
        {
            //mo File de ghi du lieu
            outStream = File.OpenWrite("DestinationFile.txt");
            //mo File de doc du lieu
            inStream = File.OpenRead("BogusInputFile.txt");
            //cac cau lenh doc du lieu tu file
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            if(outStream != null)
            {
                outStream.Close();
                Console.WriteLine("outStream closed.");
            }
            if(inStream != null)
            {
                inStream.Close();
                Console.WriteLine("inStream closed.");
            }
        }
    }
}