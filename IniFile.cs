using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace BDOServerRatesEditor
{
  internal class IniFile
  {
    private static readonly Regex sWhitespace = new Regex("\\s+");
    private string EXE = Assembly.GetExecutingAssembly().GetName().Name;
    private string Path;

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    private static extern long WritePrivateProfileString(
      string Section,
      string Key,
      string Value,
      string FilePath);

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    private static extern int GetPrivateProfileString(
      string Section,
      string Key,
      string Default,
      StringBuilder RetVal,
      int Size,
      string FilePath);

    public IniFile(string IniPath = null)
    {
      this.Path = new FileInfo(IniPath ?? this.EXE + ".ini").FullName.ToString();
    }

    public static string ReplaceWhitespace(string input, string replacement)
    {
      return IniFile.sWhitespace.Replace(input, replacement);
    }

    public static string GetIniProperty(string IniFileName, string SearchKey)
    {
      string str = (string) null;
      using (StreamReader streamReader = new StreamReader(IniFileName))
      {
        string input;
        while ((input = streamReader.ReadLine()) != null)
        {
          IniFile.ReplaceWhitespace(input, "");
          string[] strArray = input.Split('=');
          if (strArray.Length == 2 && strArray[0] == SearchKey)
          {
            strArray[1] = strArray[1].Replace(" ", "");
            str = strArray[1];
          }
        }
      }
      return str;
    }

    public static List<string> GetEnchantArray(string IniFileName, string SearchKey)
    {
      List<string> stringList = new List<string>();
      using (StreamReader streamReader = new StreamReader(IniFileName))
      {
        string input;
        while ((input = streamReader.ReadLine()) != null)
        {
          IniFile.ReplaceWhitespace(input, "");
          if (input.Split('=')[0] == SearchKey)
          {
            string[] strArray = input.Split('=', ',');
            for (int index = 1; index < strArray.Length; ++index)
            {
              strArray[index] = strArray[index].Replace(" ", "");
              stringList.Add(strArray[index]);
            }
          }
        }
      }
      return stringList;
    }

    public static string WriteIniProperty(string IniFileName, string SearchKey)
    {
      string str1 = (string) null;
      List<string> stringList = new List<string>();
      using (StreamReader streamReader = new StreamReader(IniFileName))
      {
        string str2;
        while ((str2 = streamReader.ReadLine()) != null)
        {
          string[] strArray = str2.Split('=');
          if (strArray.Length == 2 && strArray[0] == SearchKey)
            str1 = strArray[1];
        }
      }
      return str1;
    }

    public string Read(string Key, string Section = null)
    {
      StringBuilder RetVal = new StringBuilder((int) byte.MaxValue);
      IniFile.GetPrivateProfileString(Section ?? this.EXE, Key, "", RetVal, (int) byte.MaxValue, this.Path);
      return RetVal.ToString();
    }

    public void Write(string Key, string Value, string Section = null)
    {
      IniFile.WritePrivateProfileString(Section ?? this.EXE, Key, Value, this.Path);
    }

    public void DeleteKey(string Key, string Section = null)
    {
      this.Write(Key, (string) null, Section ?? this.EXE);
    }

    public void DeleteSection(string Section = null)
    {
      this.Write((string) null, (string) null, Section ?? this.EXE);
    }

    public bool KeyExists(string Key, string Section = null)
    {
      return this.Read(Key, Section).Length > 0;
    }
  }
}
