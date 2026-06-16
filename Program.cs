using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryAutomation
{
    enum MakineDurumu : byte { Bos, Calısıyor, Arızalı }
    struct Saat
    {
        public int saat;
        public int dakika;
    }
    class Ogrenci
    {
        public string Isim;
    }
    class CamasirMakinesi
    {
        public Ogrenci KullananKisi;
        public Saat zaman;
        public MakineDurumu durum;
        public static bool operator true(CamasirMakinesi a)
        {
            return a.durum == MakineDurumu.Bos;
        }
        public static bool operator false(CamasirMakinesi a)
        {
            return a.durum != MakineDurumu.Bos;
        }
        public static bool operator !(CamasirMakinesi a)
        {
            return a.durum == MakineDurumu.Arızalı;
        }
        public void Calistir(Ogrenci isim, Saat süre)
        {
            if ((durum == MakineDurumu.Bos) && (YurtYonetimi.DeterjanStok > 0))
            {
                KullananKisi = isim;
                zaman.saat = süre.saat;
                zaman.dakika = süre.dakika;
                zaman.saat += 1;
                zaman.dakika += 30;
                if (zaman.dakika >= 60)
                {
                    zaman.dakika -= 60;
                    zaman.saat += 1;
                }
                if (zaman.saat >= 24)
                {
                    zaman.saat -= 24;
                }
                durum = MakineDurumu.Calısıyor;
                YurtYonetimi.DeterjanStok--;
                Console.WriteLine("Sayın {0} makine {1}:{2:00} itibariyle çalıştı ve deterjan alındı.", KullananKisi.Isim, zaman.saat, zaman.dakika);
            }
            else
                Console.WriteLine("Hata! Makine çalışamıyor. ");
        }
    }
    static class YurtYonetimi
    {
        public static int DeterjanStok = 100;
    }
    class Program
    {
        static void Main(string[] args)
        {
            CamasirMakinesi m1 = new CamasirMakinesi();
            m1.durum = MakineDurumu.Bos;
            if (m1)
                Console.WriteLine("Makine müsait, çamaşırları doldur!!!");
            if (!m1)
                Console.WriteLine("Usta çağırın, makine bozuk!!!");
            Ogrenci o1 = new Ogrenci();
            o1.Isim = "Alperen";
            m1.Calistir(o1, new Saat { saat = 12, dakika = 30 });
            Console.WriteLine(YurtYonetimi.DeterjanStok);
        }
    }
}
