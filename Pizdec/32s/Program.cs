// Decompiled with JetBrains decompiler
// Type: CommomUpper_32Series.Program
// Assembly: CommomUpper_32Series, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42CF0887-5F6A-48FD-8C8C-D2FBE0111198
// Assembly location: D:\BSM\Хранение\32s.exe

using System;
using System.Windows.Forms;

namespace CommomUpper_32Series
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
