internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Çalışan sayısı:{0}",Calisan.Calisan_sayisi1);
        Calisan calisan=new Calisan("ali","koral","İK");
        Console.WriteLine("Çalışan sayısı:{0}",Calisan.Calisan_sayisi1);
        Console.WriteLine("*******************************");

        Calisan calisan1=new Calisan("Ayşe","Yılmaz","İK");
        Calisan calisan2=new Calisan("Ahmet","Öksüz","SA");
        Console.WriteLine("Çalışan sayısı:{0}",Calisan.Calisan_sayisi1);
        Console.WriteLine("*******************************");

      
        Console.WriteLine("Toplama İşlemi Sonucu:{0}",  İslemler.Topla(100,200));
         Console.WriteLine("Toplama İşlemi Sonucu:{0}",  İslemler.Cikar(500,123));
        
        
    }
}
class Calisan 
{

    private static int Calisan_sayisi;

    public static int Calisan_sayisi1 { get => Calisan_sayisi; }

    private string isim;

    private string Soyisim;

    private string Department;

   
    static Calisan()
    {
        Calisan_sayisi=0;
    }

     public Calisan(string isim, string soyisim,string department)
    {
        this.isim = isim;
        this.Soyisim = soyisim;
        this.Department=department;
        Calisan_sayisi++;
        
    }

    

}

public static class İslemler
{

    public static long Topla(int sayi1,int sayi2)
    {
        return sayi1+sayi2;
    }
    public static long Cikar(int sayi1,int sayi2)
    {

        return sayi1-sayi2;
    }
}