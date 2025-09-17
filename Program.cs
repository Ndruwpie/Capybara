using System;
public class Capybara
{
    public string Nama { get; private set; }
    public int Kenyang { get; private set; }
    public int Senang { get; private set; }

    public Capybara(string nama)
    {
        Nama = nama;
        Kenyang = 50;
        Senang = 50;
    }

    public void BeriMakan()
    {
        Console.WriteLine($"{Nama} mamam teyoy guyunggg...");
        Kenyang += 20;
        if (Kenyang > 100) Kenyang = 100;
    }

    public void AjakMain()
    {
        Console.WriteLine($"{Nama} halan halan dulss.");
        Senang += 20;
        Kenyang -= 10; 
        if (Senang > 100) Senang = 100;
    }

    public void LaluiWaktu()
    {
        Kenyang -= 5;
        Senang -= 5;
    }

    public void TampilkanStatus()
    {
        Console.WriteLine($"\n--- Status {Nama} ---");
        Console.WriteLine($"Kenyang: {Kenyang}/100");
        Console.WriteLine($"Senang : {Senang}/100");
        Console.WriteLine("--------------------");
    }

    public bool ApaMasihHidup()
    {
        return Kenyang > 0 && Senang > 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- ~~~~CAPYBARA~~~~ ---");
        Console.Write("Beri nama sayang capybaramu: ");
        string namaPeliharaan = Console.ReadLine();

        // Membuat OBJECT dari class Capybara
        Capybara masbro = new Capybara(namaPeliharaan);
        Console.WriteLine($"Kamu memelihara seekor capybara bernama {masbro.Nama}. CIHUYY");


        while (masbro.ApaMasihHidup())
        {
            masbro.TampilkanStatus();

            Console.WriteLine("\nPilih Aksi:");
            Console.WriteLine("1. Mamamm");
            Console.WriteLine("2. Halan - halann");
            Console.WriteLine("3. EH...");
            Console.Write("Pilihan: ");
            string pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                masbro.BeriMakan(); 
            }
            else if (pilihan == "2")
            {
                masbro.AjakMain(); 
            }
            else
            {
                Console.WriteLine("Kenapa?...Sibuk Kah?");
                Console.WriteLine("Jahat...Setelah momen kita...");
                Console.WriteLine("*Kamu meninggalkan capybara sendirian...");
                break; 
            }


            masbro.LaluiWaktu();
        }

        Console.WriteLine("\nGame Over.");
        if (!masbro.ApaMasihHidup())
        {
            if (masbro.Kenyang <= 0)
                Console.WriteLine($"{masbro.Nama} kelaparan dan pergi mencari makanan sendiwrih...");
            else if (masbro.Senang <= 0)
                Console.WriteLine($"{masbro.Nama} bosan dan pergi mencari petualangan balu...");
        }
        Console.WriteLine($"{masbro.Nama} sudah tidak senang lagi dan pergi...");
    }
}