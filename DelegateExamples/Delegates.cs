namespace DelegateExamples;

public static class Delegates
{
    public static int GetTotalPriceAsFunc(List<Products> productsList)
    {
        var toReturn = 0;
        productsList.ForEach(x => toReturn += x.Price);
        return toReturn;
    }
    
    public static void GetTotalPriceAsAction(List<Products> productsList, int result)
    {
        productsList.ForEach(x=> result += x.Price);
    }
    
    public static bool IsExistAsPredicate(this List<Products> productsList, string name)
    {
        return productsList.Exists(x => x.Name == name);
    }
}

public class Products
{
    public string Name { get; set; }
    public int Price { get; set; }
}