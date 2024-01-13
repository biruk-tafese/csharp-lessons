using System.IO;

string path = "\\myfile.text";

using (StreamReader sr = new StreamReader(path))
{    
    while(sr.EndOfStream != true)
    {  
      Console.WriteLine(sr.ReadLine());
    }
    sr.Close();
}