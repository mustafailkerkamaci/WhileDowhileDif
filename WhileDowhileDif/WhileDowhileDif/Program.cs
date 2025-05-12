// While dongusu
//int sayac = 0; // sayac 0 dan basliyor
//Console.WriteLine("Lutfen  Bir limit Degeri Giriniz:");
//int limit = int.Parse(Console.ReadLine()); // kullanicidan limit degeri aliyoruz


//while(sayac <=limit) // while dongusu sayac<= limit olana kadar calisacak.
//{
//    Console.WriteLine("Ben bir Patika'liyim!");
//    sayac++;
//}

//-------------------------------------------------------------------------------------------

//Do while dongusu negatif limit

using System.Reflection.Metadata;

int sayac1 = 0;
Console.WriteLine("Lutfen negatif Bir limit Degeri Giriniz:");
int limit1 =int.Parse(Console.ReadLine()); // kullanicidan limit degeri aliyoruz
do
{
    Console.WriteLine("Ben bir Patika'liyim!");
    sayac1--; // negatif limit koydugumuz icin sayac birer birer azalacak o nedenle -- yaptim.

} while (sayac1 >= limit1); // ayni zamanda pozitif orenkete <= kulnairken negatifte sayilar 0'a dogru artacagi icin >= kullaniyoruz.


// While Ile Do-While arasindaki farklar
//1-- while once kosulu konrtol eder yanlissa, dongu hic calismaz.Yani limiti -5 verip kosulu sayac<limit yaparsak(0<-5) olacagi icin dongu hic calismaz.
//Do-While donguyu bir kez calistirir, sonra kosulu kontrol eder.Yani kosul yanlis olsa dahi dongu bir kez calisir.
