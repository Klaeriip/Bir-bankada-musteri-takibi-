using System;
using System.Collections.Generic;

class Musteri
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public override string ToString()
    {
        return $"ID: {Id}, Ad: {Ad}, Soyad: {Soyad}";
    }
}

class MusteriManager
{
    private List<Musteri> musteriler = new List<Musteri>();

    public void MusteriEkle(Musteri musteri)
    {
        musteriler.Add(musteri);
        Console.WriteLine("Müşteri eklendi: " + musteri);
    }

    public void MusteriListele()
    {
        foreach (var musteri in musteriler)
        {
            Console.WriteLine(musteri);
        }
    }

    public void MusteriSil(int musteriId)
    {
        Musteri silinecekMusteri = musteriler.Find(musteri => musteriId == musteriId);
        if (silinecekMusteri != null)
        {
            musteriler.Remove(silinecekMusteri);
            Console.WriteLine("Müşteri silindi: " + silinecekMusteri);
        }
        else
        {
            Console.WriteLine("Müşteri bulunamadı.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MusteriManager musteriManager = new MusteriManager();

        Musteri musteri1 = new Musteri { Id = 1, Ad = "Ahmet", Soyad = "Yılmaz" };
        Musteri musteri2 = new Musteri { Id = 2, Ad = "Ayşe", Soyad = "Kara" };

        musteriManager.MusteriEkle(musteri1);
        musteriManager.MusteriEkle(musteri2);

        Console.WriteLine("Müşteriler:");
        musteriManager.MusteriListele();

        musteriManager.MusteriSil(1);

        Console.WriteLine("Müşteriler:");
        musteriManager.MusteriListele();
    }
}