using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SysConsole = System.Console;

namespace Consolex
{
    public static class Console
    {

        public enum MessageType
        {
            Error = 0,
            Success = 1,
            Information = 2,
            Question = 3
        }

        //  Output
        public static void WriteLine(string text)
        {
            SysConsole.WriteLine(text);
        }

        public static void CustomWriteLine(this MessageType messagetype, string text)
        {
            if (messagetype == MessageType.Error)
            {
                SysConsole.ForegroundColor = ConsoleColor.Red;
                SysConsole.Write("[ERROR]");
                SysConsole.ForegroundColor = ConsoleColor.Gray;
                SysConsole.Write(text);
                SysConsole.WriteLine();
            }

            if(messagetype == MessageType.Success)
            {
                SysConsole.ForegroundColor = ConsoleColor.Green;
                SysConsole.Write("[SUCCESS]");
                SysConsole.ForegroundColor = ConsoleColor.Gray;
                SysConsole.Write(text);
                SysConsole.WriteLine();
            }

            if (messagetype == MessageType.Question)
            {
                SysConsole.ForegroundColor = ConsoleColor.Cyan;
                SysConsole.Write("[QUESTION]");
                SysConsole.ForegroundColor = ConsoleColor.Gray;
                SysConsole.Write(text);
                SysConsole.WriteLine();
            }

            if (messagetype == MessageType.Information)
            {
                SysConsole.ForegroundColor = ConsoleColor.Blue;
                SysConsole.Write("[INFO]");
                SysConsole.ForegroundColor = ConsoleColor.Gray;
                SysConsole.Write(text);
                SysConsole.WriteLine();
            }
        }

        public static void Write(string text)
        {
            SysConsole.Write(text);
        }

        //  Visuals
        public static void SetConsoleFont(string fontName, short fontSize)
        {
            Helper.SetCurrentFont(fontName, fontSize);
        }

        public static void SetForegroundColor(ConsoleColor color)
        {
            SysConsole.ForegroundColor = color;
        }

        public static void SetBackgroundColor(ConsoleColor color)
        {
            SysConsole.BackgroundColor = color;
        }

        public static void CustomForegroundColor(Color color)
        {
            Colors.SetScreenColors(color, Color.Black);
        }

        //  Input
        public static void ReadKey()
        {
            SysConsole.ReadKey();
        }

        public static string ReadLine()
        {
            string read = SysConsole.ReadLine();
            return read;
        }
    }
}
