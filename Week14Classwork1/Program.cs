// See https://aka.ms/new-console-template for more information

using Domain.Models;

Market Productsinfo = new(12);


#region Indexing 
Productsinfo[1] = new Product
{
    Name = "Baliq konservasi"
};

Productsinfo[2] = new Product
{
    Name = "Tomat"
};

Console.WriteLine(Productsinfo[1].Id);
Console.WriteLine(Productsinfo[2].Name);
#endregion