// See https://aka.ms/new-console-template for more information
using System;
using tpmod6_103022300065;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Belajar Design by Contract di C#");
            video1.PrintVideoDetails();

            video1.IncreasePlayCount(10000000); // Valid
            video1.PrintVideoDetails();

            video1.IncreasePlayCount(int.MaxValue); // Akan menyebabkan overflow
            video1.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi kesalahan: " + ex.Message);
        }
    }
}
