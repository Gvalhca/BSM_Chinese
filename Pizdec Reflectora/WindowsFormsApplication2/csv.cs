namespace WindowsFormsApplication2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    internal class csv
    {
        private csv()
        {
        }

        public static List<string[]> ReadCSV(string filePathName)
        {
            List<string[]> list = new List<string[]>();
            StreamReader reader = new StreamReader(filePathName);
            string str = "";
            while (str != null)
            {
                str = reader.ReadLine();
                if ((str != null) && (str.Length > 0))
                {
                    char[] separator = new char[] { ',' };
                    list.Add(str.Split(separator));
                }
            }
            reader.Close();
            return list;
        }

        public static void WriteCSV(string filePathName, ushort line, string[][] ls)
        {
            WriteCSV(filePathName, false, line, ls);
        }

        public static void WriteCSV(string filePathName, bool append, ushort line, string[][] ls)
        {
            StreamWriter writer = new StreamWriter(filePathName, append, Encoding.Default);
            for (int i = 0; i < line; i++)
            {
                writer.WriteLine(string.Join(",", ls[i]));
            }
            writer.Flush();
            writer.Close();
        }
    }
}

