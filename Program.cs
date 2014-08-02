using System;
using System.Reflection;
using System.Text;

public class Program
{
    public static void Main()
    {
        p (ConsoleColor.Red, "Hello K Runtime !");

        p (ConsoleColor.Red, "Environment Vars");
        p ("Environment.OSVersion: {0}", Environment.OSVersion);
        p ("Environment.Version: {0}", Environment.Version);
        p ("Environment.UserName: {0}/{1}", Environment.UserDomainName, Environment.UserName);
        p ("{0}", dump(Environment.GetEnvironmentVariables ()));

        p (ConsoleColor.Red, "ExecutingAssembly info");
        var asm = Assembly.GetExecutingAssembly();
        p ("Assembly.FullName: {0}", asm.FullName);
        p ("Assembly.Location: {0}", asm.Location);
        p ("Assembly.CodeBase: {0}", asm.CodeBase);
        p ("Assembly.ImageRuntimeVersion: {0}", asm.ImageRuntimeVersion);

        p (ConsoleColor.Red, "EntryAssembly info");
        asm = Assembly.GetEntryAssembly();
        p ("Assembly.FullName: {0}", asm.FullName);
        p ("Assembly.Location: {0}", asm.Location);
        p ("Assembly.CodeBase: {0}", asm.CodeBase);
        p ("Assembly.ImageRuntimeVersion: {0}", asm.ImageRuntimeVersion);
    }
    private static void p(string text, params object[] args)
    {
        Console.WriteLine (text, args);
    }
    private static void p(ConsoleColor color, string text, params object[] args)
    {
        Console.ForegroundColor = color;
        p (text, args);
        Console.ResetColor ();
    }
    private static string dump(System.Collections.IDictionary dic)
    {
        var sb = new StringBuilder();
        foreach (System.Collections.DictionaryEntry x in dic) 
        {
            sb.AppendFormat("{0}: {1}", x.Key.ToString(), x.Value.ToString());
            sb.AppendLine ();
        }
        return sb.ToString();
    }
}