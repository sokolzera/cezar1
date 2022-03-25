Console.WriteLine("Napisz wiadomość do zakodowania");
string wiadomość = Console.ReadLine();
char[] achar = wiadomość.ToCharArray();
int x;
Console.WriteLine("O ile chcesz przesunac?");
x = Int32.Parse(Console.ReadLine());
for (int i = 0; i < achar.Length; i++)
{
    achar[i] = (char)((achar[i] + x));
    if (achar[i] > 90)
    {
        achar[i] = (char)((char)achar[i] - 26);
    }

}
string wiadomość2 = new string(achar);
Console.WriteLine("Wiadomość zaszyfrowana to:");
Console.WriteLine(wiadomość2);
