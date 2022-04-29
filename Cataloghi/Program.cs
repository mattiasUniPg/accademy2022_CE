// See https://aka.ms/new-console-template for more information

using Helpers;
using Helper;


var helper = new ProdottoHelper();


var Prod = new Prodotto();
var rub = Prod.Display();//TODO

Console.WriteLine("*********************");

foreach (var prodotto in rub)
{
    Console.WriteLine($"ID: {prodotto.IdProdotto} - Nome: {prodotto.NomeProdotto} - Giacenza: {prodotto.QntInMagazzino} ");
}


Console.WriteLine("*********************");

Console.WriteLine("Inserisci ID");
var IDPROD = Console.ReadLine();
Console.WriteLine("Inserisci Nome_Prodotto");
var NOMEPROD = Console.ReadLine();
Console.WriteLine("Giacenza_in_Magazzino");
var QNTMAGAZZINO = Console.ReadLine();


var prodottonew = new Prodotto();
prodottonew.IdProdotto = IDPROD;
prodottonew.NomeProdotto = NOMEPROD;
prodottonew.QntInMagazzino = QNTMAGAZZINO;




Console.WriteLine("*********************");

foreach (var prodotto in rub)
{
    Console.WriteLine($"nome: {prodotto.IdProdotto} - Nome: {prodotto.NomeProdotto} - Giacenza: {prodotto.QntInMagazzino}");
}

Console.WriteLine("*********************");


