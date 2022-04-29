// See https://aka.ms/new-console-template for more information

using Helpers;
using Data;


var catalogoPath = @"C:\Users\zibet\Documents\Prova.txt";
var prodottoPath = @"C:\Users\zibet\Documents\ProvaProdotto.txt";

var helperProdotto = new ProdottoHelpers(prodottoPath);

var prod = helperProdotto.DisplayProdotto();

var helperCatalogo = new CatalogoHelpers(catalogoPath);

var cata = helperCatalogo.DisplayCatalogo();
Console.WriteLine("*********************");

foreach (var prodotto in prod)
{
    Console.WriteLine($"ID PRODOTTO: {prodotto.IdProdotto} - Nome PROD: {prodotto.NomeProdotto} - Giacenza: {prodotto.QntInMagazzino} ");
}

Console.WriteLine("\n");

foreach (var catalogo in cata)
{
    Console.WriteLine($"ID CATALOGO: {catalogo.IdCatalogo} - Nome CAT: {catalogo.NomeCatalogo} - ID PRODOTTO: {catalogo.IdProdotto} - Prezzo : {catalogo.Prezzo}€");
}

Console.WriteLine("*********************");

Console.WriteLine("Inserisci ID PRODOTTO");
var IDPROD = Console.ReadLine();
Console.WriteLine("Inserisci Nome_Prodotto");
var NOMEPROD = Console.ReadLine();
Console.WriteLine("Giacenza_in_Magazzino");
var QNTMAGAZZINO = Console.ReadLine();


var prodottonew = new Prodotto();
prodottonew.IdProdotto = IDPROD;
prodottonew.NomeProdotto = NOMEPROD;
prodottonew.QntInMagazzino = QNTMAGAZZINO;

Console.WriteLine("\n");

Console.WriteLine("Inserisci ID CATALOGO");
var IDCATALOGO = Console.ReadLine();
Console.WriteLine("Inserisci Nome_Catalogo");
var NOMECATALOGO = Console.ReadLine();
Console.WriteLine("ID_PRODOTTO");
var IDPRODOTTO = Console.ReadLine();
Console.WriteLine("Prezzo_catalogo");
var PREZZO = Console.ReadLine();


var catalogonew = new Catalogo();
catalogonew.IdCatalogo = IDCATALOGO;
catalogonew.NomeCatalogo = NOMECATALOGO;
catalogonew.IdProdotto = IDPRODOTTO;
catalogonew.Prezzo = PREZZO;

Console.WriteLine("*********************");

foreach (var prodotto in prod)
{
    Console.WriteLine($"ID PRODOTTO: {prodotto.IdProdotto} - Nome PROD: {prodotto.NomeProdotto} - Giacenza: {prodotto.QntInMagazzino} ");
}

Console.WriteLine("\n");

foreach (var catalogo in cata)
{
    Console.WriteLine($"ID CATALOGO: {catalogo.IdCatalogo} - Nome CAT: {catalogo.NomeCatalogo} - ID PRODOTTO: {catalogo.IdProdotto} - Prezzo : {catalogo.Prezzo}€");
}
Console.WriteLine("*********************");

=======
﻿// See https://aka.ms/new-console-template for more information

using Helpers;
using Data;


var catalogoPath = "";
var prodottoPath = "";


var helperProdotto = new ProdottoHelper(prodottoPath);


var prod = helperProdotto.DisplayProdotto();
//var rub = Prod.Display();//TODO

Console.WriteLine("*********************");

foreach (var prodotto in prod)
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


