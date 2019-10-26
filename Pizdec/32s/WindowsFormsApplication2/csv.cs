// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication2.csv
// Assembly: CommomUpper_32Series, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42CF0887-5F6A-48FD-8C8C-D2FBE0111198
// Assembly location: D:\BSM\Хранение\32s.exe

using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WindowsFormsApplication2
{
  internal class csv
  {
    private csv()
    {
    }

    public static void WriteCSV(string filePathName, ushort line, string[][] ls)
    {
      csv.WriteCSV(filePathName, false, line, ls);
    }

    public static void WriteCSV(string filePathName, bool append, ushort line, string[][] ls)
    {
      StreamWriter streamWriter = new StreamWriter(filePathName, append, Encoding.Default);
      for (int index = 0; index < (int) line; ++index)
        streamWriter.WriteLine(string.Join(",", ls[index]));
      streamWriter.Flush();
      streamWriter.Close();
    }

    public static List<string[]> ReadCSV(string filePathName)
    {
      List<string[]> strArrayList = new List<string[]>();
      StreamReader streamReader = new StreamReader(filePathName);
      string str = "";
      while (str != null)
      {
        str = streamReader.ReadLine();
        if (str != null && str.Length > 0)
          strArrayList.Add(str.Split(','));
      }
      streamReader.Close();
      return strArrayList;
    }
  }
}
