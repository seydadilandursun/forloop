//Ekrandan girilen sayiya kadar olan tek sayilarini ekrana yazir
Console.WriteLine("Lutfen bir sayi giriniz:");
int sayac=int.Parse(Console.ReadLine());
for(int i=1;i<=sayac;i++)
{
  if(i%2==1)
    Console.WriteLine(i);
}

//1 ile 1000 arasindaki tek ve cift sayilarin toplamlarini kendi icinde yazdir
int tekToplam=0;
int ciftToplam=0;
for (int i = 0; i <=1000; i++)
{
    if(i%2 == 1)
      tekToplam+=i;//tekToplam=tekToplam+i
    else
      ciftToplam+=i;
}
Console.WriteLine("Tektoplam="+tekToplam);
Console.WriteLine("Cifttoplam="+ciftToplam);