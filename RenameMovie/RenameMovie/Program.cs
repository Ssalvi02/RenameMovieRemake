using System.IO;
using System;


public static class DirExt
{
    public static void RenameDir()
    {
        string[] dirs = Directory.GetDirectories(Directory.GetCurrentDirectory());
        char[] numb = {'1', '2'};
        foreach (string dir in dirs)
        {
            string old_name = dir;
            //Remove pontos
            string space_name = old_name.Replace('.', ' ');
            //Remove do ano pra frente
            int pos = space_name.IndexOfAny(numb);
            if (pos >= 0) 
            {
                string new_name = space_name.Remove(pos);
                Directory.Move(old_name, new_name);
            }
        }
    }
    static void Main(string[] args)
    {
        RenameDir();
    }
}















