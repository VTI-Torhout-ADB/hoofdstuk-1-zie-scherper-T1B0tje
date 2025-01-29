using System.Runtime.InteropServices;

namespace Rommel_Zin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je favoriete kleur:");
            string kleur = Console.ReadLine();
            Console.WriteLine("Geef je favoriete eten:");
            string eten = Console.ReadLine();
            Console.WriteLine("Geef je favoriete auto:");
            string auto = Console.ReadLine();
            Console.WriteLine("Geef je favoriete boek:");
            string boek = Console.ReadLine();
            Console.WriteLine($"Je favoriete kleur is {eten}. Je eet graag {auto}. Je lievelingsfilm is {boek} en je favoriete boek is {kleur}.");
        }
    }
}
