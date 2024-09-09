using System;
using System.Collections.Generic;

public abstract class Prod
{
    public abstract string Name { get; set; }
    public virtual decimal Price { get; set; }
    public abstract string GetInformation();
}
public class Toy : Prod
{
    public override string Name { get; set; }
    public override decimal Price { get; set; }
    public string AgeGroup { get; set; }
    public override string GetInformation()
    {
        return $"Toy: {Name}, Price: {Price:C}, Age Group: {AgeGroup}";
    }
}
public class Condiment : Prod
{
    public override string Name { get; set; }
    public override decimal Price { get; set; }
    public DateTime ExpirationDate { get; set; }
    public override string GetInformation()
    {
        return $"Condiment: {Name}, Price: {Price:C}, Expiration Date: {ExpirationDate:MM/dd/yyyy}";
    }
}
public class Drink : Prod
{
    public override string Name { get; set; }
    public override decimal Price { get; set; }
    public double Volume { get; set; }
    public override string GetInformation()
    {
        return $"Drink: {Name}, Price: {Price:C}, Volume: {Volume}L";
    }
}
public class Book : Prod
{
    public override string Name { get; set; }
    public override decimal Price { get; set; }
    public string Author { get; set; }
    public override string GetInformation()
    {
        return $"Book: {Name}, Price: {Price:C}, Author: {Author}";
    }
}
public class Electronics : Prod
{
    public override string Name { get; set; }
    public override decimal Price { get; set; }
    public int WarrantyPeriod { get; set; }
    public override string GetInformation()
    {
        return $"Electronics: {Name}, Price: {Price:C}, Warranty: {WarrantyPeriod} months";
    }
}
public class DisManag
{
    public static void ApplyDiscount(List<Prod> products, decimal discountPercentage)
    {
        foreach (var product in products)
        {
            product.Price -= product.Price * (discountPercentage / 100);
        }
    }
}
class Program
{
    static void Main()
    {
        var products = new List<Prod>
        {
            new Toy { Name = "Barbie Doll", Price = 12.99m, AgeGroup = "0-3" },
            new Condiment { Name = "Coriander", Price = 2.99m, ExpirationDate = DateTime.Now.AddDays(7) },
            new Book { Name = "Sherlock Holmes", Price = 29.99m, Author = "Arthur Conan Doyle" },
            new Electronics { Name = "Fridge", Price = 4324.99m, WarrantyPeriod = 240 },
            new Drink { Name = "Adrenaline", Price = 10.49m, Volume = 1.5 },
        };
        DisManag.ApplyDiscount(products, 10);
        foreach (var product in products)
        {
            Console.WriteLine(product.GetInformation());
        }
    }
}
