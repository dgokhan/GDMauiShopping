using GDMauiShopping.Resources.Models;

namespace GDMauiShopping;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        BindingContext = new MainPageViewModel
        {
            Products = new List<Product>() {
                 new Product
                 {
                     Title = "Russ Shirt",
                     ImageUrl = "img1.png",
                     Price=19.99,
                     OldPrice=25.99
                 },
                 new Product
                 {
                     Title = "Comfort Jacket",
                     ImageUrl = "img2.png",
                     Price=50.99,
                     OldPrice=60.99
                 },
                 new Product
                 {
                     Title = "Eywa Holt",
                     ImageUrl = "img3.png",
                     Price=30.99,
                     OldPrice=40.99
                 },
                 new Product
                 {
                     Title = "Russ Shirt",
                     ImageUrl = "img1.png",
                     Price=19.99,
                     OldPrice=25.99
                 }
            }
        };
    }
}

