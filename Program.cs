using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1) Open calculator\n2) Open notepad\n3) Open paint\nChoice: ");
        int select = Convert.ToInt32(Console.ReadLine());

        switch (select)
        {
            case 1:
                Process.Start("win32calc.exe");
                break;

            case 2:
                Process.Start("notepad.exe");
                break;

            case 3:
                Process.Start("mspaint.exe");
                break;
        }
    }
}