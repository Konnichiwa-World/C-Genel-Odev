using System;

namespace Genel_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("İlk önce hangi ödevi seçmeli: 1. 2. 3. 4.");
            Int32 y =Int32.Parse(Console.ReadLine());
            switch(y){
            case 1:
            Console.WriteLine("Rica etsem pozitif tamsayi girer misiniz?");
            Int32 x =Int32.Parse(Console.ReadLine());
            if(x>=0){System.Console.WriteLine("Güzel, devam edelim.");
            Console.Write("Kaç sayi gireceksiniz? ");
            Int32 sayisayisi = Convert.ToInt32(Console.ReadLine());
            int[] seri = new int[sayisayisi];
            for(int i=0;i<sayisayisi;i++)
            {
                seri[i]=Int32.Parse(Console.ReadLine());
                if(seri[i]%2==0){System.Console.WriteLine(seri[i]+": sayiniz çifttir.");}
                if(seri[i]%2==1){System.Console.WriteLine(seri[i]+ ": sayiniz tektir.");}
            }}
            else{System.Console.WriteLine("Sıfırdan büyük birşey girmediniz.");
            }break;
            case 2:
            System.Console.WriteLine("2 adet pozitif sayi giriniz:");
            Int32 a =Int32.Parse(Console.ReadLine());
            Int32 b =Int32.Parse(Console.ReadLine());
            if(a>0 && b>0){
            System.Console.WriteLine("Lutfen kaç adet sayi gireceğinizi yaziniz:");
            Int32 sayisayisi2 =Int32.Parse(Console.ReadLine());
            int[] seri1 = new int [sayisayisi2];
            for(int c=0;c<sayisayisi2;c++){
            seri1[c]=Int32.Parse(Console.ReadLine());
            if(seri1[c]==b){System.Console.WriteLine("2. sayiyi tekrar girdiniz.");}
            else if(seri1[c]%b==0){System.Console.WriteLine("sayiniz 2. girdiğiniz sayiya tam bölünüyor.");}
            }}break;
            case 3: System.Console.WriteLine("Lütfen bir pozitif tamsayi giriniz:");
            Int32 d =Int32.Parse(Console.ReadLine());
            if(d>0){
                System.Console.WriteLine("Kaç adet isim gireceksiniz?");
                Int32 e =Int32.Parse(Console.ReadLine());
                int[] isimlidizi = new int [e];
                for(int f=0;f<e;f++){
                    System.Console.WriteLine("Lutfen kelimeler giriniz:");
                      isimlidizi[f]=Int32.Parse(Console.ReadLine());
                      for(int g=e-1;g>=0;g--){System.Console.WriteLine(isimlidizi[f]);}
                }
            }
            else if(d==0){System.Console.WriteLine("pozitif tamsayi girmediniz.");}
            break;

            case 4:string[] kelimeler; //https://github.com/necati1054/patika/blob/main/c%23/Odev1/Program.cs - Arkadaşa teşekkürler :)
Console.WriteLine("lütfen bir cümle giriniz");
string cümle = Console.ReadLine();
kelimeler = cümle.Split(" ");

Console.WriteLine("cümlede {0} kelime var",kelimeler.Length);
Console.WriteLine("cümlede {0} tane harf var",cümle.Length);     
break;}}}}