double toplam = 0, sayac = 0, ortalama = 0;
int i = 1;
while (i <= 100)
{
    if (i % 2 == 0)
    {
        toplam = toplam + i;
        sayac++;
    }
    i++;
}
ortalama = toplam / sayac;
Console.WriteLine("Çift sayıların toplamı={0}\nAdet={1} Ortalaması={2}", toplam, sayac, ortalama);
Console.ReadKey();