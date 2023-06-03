using System.IO;
using System;


public static class DirExt
{
    static void Main(string[] args)
    {
        string[] dirs = Directory.GetDirectories(Directory.GetCurrentDirectory());
        char[] numb = { '(', ')' };
        foreach (string dir in dirs)
        {
            string old_name = dir;
            //Remove do ano pra frente
            int pos = old_name.IndexOfAny(numb);
            if (pos >= 0)
            {
                string new_name = old_name.Remove(pos);
                Directory.Move(old_name, new_name);
            }
        }
    }
}















