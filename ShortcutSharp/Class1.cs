using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ShortcutSharp
{
    public static class Functions
    {
        public static void CreateShortcut(string ShortcutName, string Icon, string Executable, string Description, string WorkingDirectory)
        {
            string strTXT = ShortcutName;

            object shortcutDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            strTXT = Executable.Substring(Executable.LastIndexOf('\\'));
            string ShortcutPath = (String)shell.SpecialFolders.Item(ref shortcutDesktop) + @"\" + ShortcutName + ".lnk";
            IWshShortcut shortcut = shell.CreateShortcut(ShortcutPath);

            shortcut.Description = Description;
            shortcut.WorkingDirectory = WorkingDirectory;
            shortcut.TargetPath = Executable;
            shortcut.IconLocation = Icon;
            shortcut.Save();
        }
        public static void DeleteShortcut(string ShortcutName)
        {
            object shortcutDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string ShortcutPath = (String)shell.SpecialFolders.Item(ref shortcutDesktop) + @"\" + ShortcutName + ".lnk"; 
            FileInfo INFO = new FileInfo(@ShortcutPath);
            if (INFO.Extension == ".lnk")
            {
                System.IO.File.Delete(@ShortcutPath);
            }
            else
            {
                return;
            }
        }
    }
}
