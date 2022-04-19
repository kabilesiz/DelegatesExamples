namespace DelegateExamples;

public static class Delegates
{
    public static int GetTotalPriceAsFunc(List<Product> productsList)
    {
        var toReturn = 0;
        productsList.ForEach(x => toReturn += x.Price);
        return toReturn;
    }
    
    public static void GetTotalPriceAsAction(List<Product> productsList, int result)
    {
        productsList.ForEach(x=> result += x.Price);
    }
    
    public static bool IsMacbookProAsPredicate(string checkName)
    {
        return string.Equals("MacBook Pro", checkName);
    }
    
    public static bool IsExistAsPredicate(this List<Product> products, Predicate<string> predicateFunc)
    {
        return products.Any(x => predicateFunc(x.Name));
    }
}

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}