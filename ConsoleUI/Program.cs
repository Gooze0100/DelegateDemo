using DemoLibrary;

class Program
{

    static ShoppingCartModel cart = new();

    static void Main()
    {
        PopulateCartWithDemoData();

        // :C2 means dollar sign
        // no open or close parentases because it is delegate it will be call in that function
        // with delegates you don't use parentases
        // we cannot pass parameter in those parentases because we do not have it
        // this is how delegates work, even that SubTotalAlert is in this application ConsoleUI it was called in DemoLibrary and there executed
        // delegates are essentially methods you pass around and can execute in another locations
        // it essentially matters just about signature what return and what gets
        Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, AlertUser):C2}");

        Console.WriteLine();

        // this is anonymous delegate, and we are not giving actually name for method
        // delegate just thinks about input type and output type
        var total = cart.GenerateTotal((subtotal) => Console.WriteLine($"The subtotal for cart 2 is {subtotal:C2}"),
            (products, subTotal) => {
                // this is where we would do all that calculation with if statements
                if (products.Count > 3)
                {
                    return subTotal * 0.5M;
                }
                else
                {
                    return subTotal;
                }
            },
            (message) => Console.WriteLine($"Cart alert: {message}"));

        Console.WriteLine($"The total for cart 2 is {total:C2}");

        Console.WriteLine();
        Console.WriteLine("Please press any key to exit the application...");
        Console.ReadKey();
    }

    // so for this method it really matters just that it returns void and takes in decimal as for delegate
    // if that fits that structure that can be used
    // this is not thread safe, and it is fine unless you do asynchronous programming, with this piece
    private static void SubTotalAlert(decimal subTotal)
    {
        Console.WriteLine($"The subtotal is {subTotal:C2}");
    }

    private static void AlertUser(string message)
    {
        Console.WriteLine(message);
    }

    // so we are running this method now instead of GenerateTotal in Library
    private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal subTotal)
    {
        if (subTotal > 100)
        {
            return subTotal * 0.80M;
        }
        else if (subTotal > 50)
        {
            return subTotal * 0.85M;
        }
        else if (subTotal > 10)
        {
            return subTotal * 0.90M;
        }
        else
        {
            return subTotal;
        }
    }

    private static void PopulateCartWithDemoData()
    {
        // M to numbers means it is decimal not double
        cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
        cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.29M });
        cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
        cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
    }
}


// Delegate - as foundation is you pass in method insead a property
// Delegate is the same kinda thing as function just instead propery it accepts functions

// microsoft created for us to use shotcuts Action and Func for Delegates

// Func returns a value and Action does not

// so delegates are really simple that just methods just put as parameters
// So you can create a delegate explicitly with delegate keyword
// Func - is a inline delegate that return value
// Action - is a inline delegate that do not return value
// and either way we can call them somewhere else
// so with delegates you let others to call them and you do not call it by yourself