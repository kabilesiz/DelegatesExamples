// See https://aka.ms/new-console-template for more information

using DelegateExamples;

var products = new List<Products>()
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
// Assigning action delegate
Action<List<Products>, int> actionDelegate = Delegates.GetTotalPriceAsAction;
// Assigning action delegate
Func<List<Products>, int> funcDelegate = Delegates.GetTotalPriceAsFunc;
// Assigning predicate delegate in Delegate class 
// running predicate delegate
    // products.IsExistAsPredicate("MacBook Pro");
// running func delegate
resultForFunc = funcDelegate(products);
// running action delegate
actionDelegate(products, resultForAction);

// getting info about delegate via console
Console.WriteLine($"Result of Action Delegate : {resultForAction}");
Console.WriteLine($"Result of Func Delegate : {resultForFunc}");
Console.WriteLine($"Result of Predicate Delegate for Macbook Pro [must be true] : {products.IsExistAsPredicate("MacBook Pro")}");
Console.WriteLine($"Result of Predicate Delegate for Monster Tulpar [must be false] : {products.IsExistAsPredicate("Monster Tulpar")}");
