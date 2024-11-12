using System.Linq;
using Varosok;

List<Adatok> adatoks = new List<Adatok>();
using StreamReader sr = new($"../../../src/varosok.csv", encoding: System.Text.Encoding.UTF8);
string w = sr.ReadLine();
while (!sr.EndOfStream)
{
    adatoks.Add(new Adatok(sr.ReadLine()));
}

var f1 = adatoks.Where(v=>v.OrszagNeve == "Kína").Sum(v=>v.Nepesseg);
Console.WriteLine($"ennyi ember él a Kínai nagyvárosokban: {f1}");


var f2 = adatoks.Where(v => v.OrszagNeve == "India").Average(v => v.Nepesseg);
Console.WriteLine($"ennyi az indiai nagyvárosok átlaglélekszáma: {f2}");

var f3 = adatoks.MaxBy(v => v.Nepesseg);
Console.WriteLine($"ez a nagyvárosa a legnépesebb: {f3.VarosNeve}");

var f4 = adatoks.Where(v => v.Nepesseg > 20000000).OrderByDescending(v => v.Nepesseg).ToList();



foreach (var item in f4)
{
    Console.WriteLine($"{item.VarosNeve} - {item.Nepesseg}");
}


var f5 = adatoks.GroupBy(v => v.OrszagNeve).Where(v => v.Count() > 1).Count();
Console.WriteLine($"Azon oszágok száma hol több nagyváros is szerepel: {f5}");


var f6 = adatoks.GroupBy(v => v.VarosNeve[0]).OrderByDescending(g => g.Count()).First();

Console.WriteLine($"A legtöbb nagyváros neve {f6.Key}-vel kezdődik, összesen {f6.Count()} város.");



