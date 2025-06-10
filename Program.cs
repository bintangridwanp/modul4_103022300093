using System.Net.Http.Headers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace modul4_103022300093
{    class Program
    {
        static void Main(string[] args)
        {
            KodeProduk kodeProduk = new KodeProduk();

            //Memasukan Nama produk
            Console.WriteLine("Masukkan nama produk: ");
            string kodeProdukVar = Console.ReadLine();
            Console.WriteLine(kodeProduk.getKodeProduk(kodeProdukVar));

            //Memasukan kode produk.
            FanLaptop fanLaptop = new FanLaptop();
            Console.WriteLine("Masukkan state awal: ");
            string stateAwal = Console.ReadLine();
            Console.WriteLine("Masukkan trigger: ");
            string trigger = Console.ReadLine();
            FanLaptop.State state = (FanLaptop.State)Enum.Parse(typeof(FanLaptop.State), stateAwal);
            FanLaptop.Trigger triggerEnum = (FanLaptop.Trigger)Enum.Parse(typeof(FanLaptop.Trigger), trigger);
            Console.WriteLine(fanLaptop.GetNextState(state, triggerEnum));
        }
    }
}