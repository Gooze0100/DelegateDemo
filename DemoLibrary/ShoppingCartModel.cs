using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary;

public class ShoppingCartModel
{
    // so this is the definition of delegate
    // think like this is an interface
    // this is a contract whenever you use this it is gonna work like a parameter
    // and it is going to return void the method and it is going to take one decimal
    public delegate void MentionDiscount(decimal subTotal);
    public List<ProductModel> Items { get; set; } = new();

    // so we pass in delegate whatever method we pass in is going into this variable mentionDiscount
    // Func<> is Generic and it get something with OUT at least fist overload
    // you can pass 16 different variables in Func, this is limitation and you would need to create a delegate instead of this
    // it is good to have a list in there if you would like to do something
    // so this is one of those limitations that you do not name passed parameters
    // first is a list of items, middle decimal is total and always the last one parameter is OUT result or in this case subtotal
    // Func is a method that has a return value other then void 
    // for Delegate you need to declare it like above, but for Func you dont need to create a signature
    // and what it does mean that any time we use this we have to declare all this line instead of MentionDiscount
    // which does not have return type or input type
    // so this is how you want to use and how complicated your application is, so for you to decide which one to use
    // Also Func does not work OUT parameters if you want to use that decimal to be out it cannot be, if you want to use it you need to use delegate
    public object GenerateTotal(MentionDiscount mentionSubtotal, 
        Func<List<ProductModel>, decimal, decimal> calculateDiscountedTotal,
        // action return a void
        // you can pass 0 or more of these
        // this can be an alert
        // we would have all three delegates in one delegate not in 3 different
        Action<string> tellUserWeAreDiscounting
        )
    {
        // adds all the prices
        // this SUM is taking Func<ProductModel, decimal>, so this calls delegate Func, this is special type of delegate
        // so this now gets a subtotal
        // this is going to loop trhough entire list and check if there is any in stock
        // this is quite unique code to the caller type code, that we checking discount, so this can be a little bit different for other employees with a tweek
        decimal subTotal = Items.Sum(x => x.Price);

        // it call the method that we passed in and it passes in the decimal value
        // besides that this class has no idea what that does, so we get loosly coupled application here
        // this method GenerateTotal does not have any clue what this method mentionDiscount does or where it is located
        // mentiones in somme kinda alerting system
        mentionSubtotal(subTotal);


        tellUserWeAreDiscounting("We are applying your discount.");

        /*
        // this code is going to change quite often
        if (subTotal > 100)
        {
            // give 20 percent of their order
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
        */

        // this is return decimal
        // and then returns the calculation we passed in
        return calculateDiscountedTotal(Items, subTotal);
    }
}

// Tuple is like two different return values than one
// also we can use out variable in function and return value
// these cases is like when you want to tell user something, like message box, or error or something like that

// mostly libraries is used for more than one developers and it is used in company

// SOLID open/close principle sais that we should be making changes to this class or this application if we can help it

// In delegate you would not do all of the most of the work, usually you do just a tweeks compared to overall the main method
// 