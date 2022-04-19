// See https://aka.ms/new-console-template for more information

using DelegateExamples;

var products = new List<Product>()
{
    new()
    {
        Name = "MacBook Pro",
        Price = 35000
    },
    new()
    {
        Name = "Hp Pavilion",
        Price = 22000
    },
    new()
    {
        Name = "Lenovo Thinkpad",
        Price = 62500
    }
};

var resultForAction = 0;
var resultForFunc = 0;
var isExistMacbook = false;
// Assigning action delegate
Action<List<Product>, int> actionDelegate = Delegates.GetTotalPriceAsAction;
// Assigning action delegate
Func<List<Product>, int> funcDelegate = Delegates.GetTotalPriceAsFunc;
// Assigning predicate delegate in Delegate class
Predicate<string> predicateDelegate = Delegates.IsMacbookProAsPredicate;

// running predicate delegate
isExistMacbook = products.IsExistAsPredicate(predicateDelegate);
// running func delegate
resultForFunc = funcDelegate(products);
// running action delegate
actionDelegate(products, resultForAction);

// getting info about delegate via console
Console.WriteLine($"Result of Action Delegate : {resultForAction}");
Console.WriteLine($"Result of Func Delegate : {resultForFunc}");
Console.WriteLine($"Result of Predicate Delegate for Macbook Pro [must be true] : {isExistMacbook}");
products.RemoveAt(0);
Console.WriteLine($"After removing MacBook Pro from the product list");
isExistMacbook = products.IsExistAsPredicate(predicateDelegate);
Console.WriteLine($"Result of Predicate Delegate for Macbook Pro [must be false] : {isExistMacbook}");