// See https://aka.ms/new-console-template for more information

using StructuralPatterns;

Shop.AddProduct(Product.New("butter", 100, 33, DateTime.Now.AddMonths(3)));
Shop.AddProduct(Product.New("butter", 150, 10, DateTime.Now.AddMonths(3)));
Shop.AddProduct(Product.New("broad", 20, 100, DateTime.Now.AddMonths(1)));
Shop.ChangeQuantity("butter", -40);

Store.Add(Furniture.Create("sofa", 100500));
Store.Add(Furniture.Create("slab", 234));

var products = new List<CommonProduct>();

foreach (var item in Shop.GetAll())
{
    products.Add(Combiner.Convert(item));
}

foreach (var item in Store.GetAll())
{
    products.Add(Combiner.Convert(item));
}

foreach (var item in products)
{
    Console.WriteLine(item);
}
