namespace MenuKotaUYG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menüler.TavukDürüm(); Menüler.EtDürüm(); Menüler.Sütlaç(); Menüler.EtDürüm(); Menüler.Cola(); Menüler.Cola();
            Menüler.Sütlaç(); Menüler.Sütlaç(); Menüler.TavukDürüm(); Menüler.Sütlaç(); Menüler.TavukDürüm(); Menüler.EtDürüm();
            Menüler.Cola(); Menüler.Sütlaç(); Menüler.EtDürüm(); Menüler.Sütlaç(); Menüler.TavukDürüm(); Menüler.Sütlaç();
            Menüler.EtDürüm(); Menüler.EtDürüm(); Menüler.EtDürüm(); Menüler.Cola(); Menüler.Cola(); Menüler.Sütlaç();

        }
    }
    class Menüler
    {
        static int eds = 4; static int tds = 4; static int ss = 4; static int cs = 4;
        static public void EtDürüm()
        {
            eds = eds - 1;
            if (eds < 0) Console.WriteLine("ET DÜRÜM SATIN ALINAMADI KOTA YOK...");
            else Console.WriteLine("ET DÜRÜM SATIN ALINDI... YENİ KOTA :{0}  ", eds);
        }
        static public void TavukDürüm()
        {
            tds = tds - 1;
            if (tds < 0) Console.WriteLine("TAVUK DÜRÜM SATIN ALINAMADI KOTA YOK...");
            else Console.WriteLine("TAVUK DÜRÜM SATIN ALINDI... YENİ KOTA :{0}  ", tds);
        }
        static public void Cola()
        {
            cs = cs - 1;
            if (cs < 0) Console.WriteLine("COLA SATIN ALINAMADI KOTA YOK...");
            else Console.WriteLine("COLA SATIN ALINDI... YENİ KOTA :{0}  ", cs);
        }
        static public void Sütlaç()
        {
            ss = ss - 1;
            if (ss < 0) Console.WriteLine("SÜTLAÇ SATIN ALINAMADI KOTA YOK...");
            else Console.WriteLine("SÜTLAÇ SATIN ALINDI... YENİ KOTA :{0}  ", ss);
        }
    }

}
