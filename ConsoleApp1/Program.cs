using System;

namespace kdv.hesaplama;

class Program


{
    static void Main(string[] args)

    {
        Console.WriteLine("1.NOTU GİRİNİZ");
        int not1 = int.Parse(Console.ReadLine());

        Console.WriteLine("2.NOTU GİRİNİZ");
        int not2 = int.Parse(Console.ReadLine());

        Console.WriteLine("SÖZLÜ NOTU GİRİNİZ");
        int sozlu = int.Parse(Console.ReadLine());

        var islem = not1 + not2 + sozlu;

        var sonuc = islem / 3;

        if (sonuc >= 50)
        {
            Console.WriteLine("ÖĞRENCİ" + "   " + sonuc + "   " + "ORTALAMASI İLE GEÇTİ");
        }
        else
        {
            Console.WriteLine("ÖĞRENCİ" + "   " + sonuc + "   " + "ORTALAMASI İLE KALDI");
        }


        Console.ReadKey();
    }

}