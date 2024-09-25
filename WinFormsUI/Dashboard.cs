using DemoLibrary;

namespace WinFormsUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            PopulateCartWithDemoData();
        }

        ShoppingCartModel cart = new();

        private void PopulateCartWithDemoData()
        {
            // M to numbers means it is decimal not double
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.29M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }

        private void messageBoxDemo_Click(object sender, EventArgs e)
        {
            var total = cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, PrintOutDiscountAlert);
            
            MessageBox.Show($"The total is {total:C2}");
        }

        // this method is wired up as delegate
        private void textBoxDemo_Click(object sender, EventArgs e)
        {
            var total = cart.GenerateTotal((subTotal)=> subtotalTextBox.Text = $"{subTotal:C2}",
                // this is Func and we do not capture any return value, that is because it does not return to win forms or console app, it return in shopping cart model in the return value.
                (products, subtotal) => subtotal - (products.Count * 2),
                // passing empty function to not alert anything
                (message) => { });

            totalTextBox.Text = $"{total:C2}";
        }

        private void PrintOutDiscountAlert(string message)
        {
            MessageBox.Show(message);
        }

        private void SubTotalAlert(decimal subTotal)
        {
            MessageBox.Show($"The subtotal is {subTotal:C2}");
        }

        private decimal CalculateLeveledDiscount(List<ProductModel> products, decimal subTotal)
        {
            return subTotal - products.Count();
        }
    }
}
