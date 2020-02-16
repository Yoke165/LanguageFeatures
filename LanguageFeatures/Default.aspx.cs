using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LanguageFeatures
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string GetMessage()
        {
            /*Product myProduct = new Product()
            {
                ProductID = 1,
                Name = "Kayak",
                Decription = "A boat",
                Price = 253M,
                Category = "Watersports"
            };
            return myProduct.Category;*/
            //上述为类的初始化方法
            /*ShoppingCart cart = new ShoppingCart() {
                Products = new List<Product> {
                new Product { Name ="Kayak",Price =275M},
                new Product{Name = "Lifejacket",Price = 48.95M },
                new Product{Name = "Soccer ball",Price = 19.50M },
                new Product{Name = "Corner",Price = 34.95M },
                }
            };
            decimal cartTotal = cart.TolPrice();
            return String.Format("Total:{0:C}", cartTotal);*/
            //上述为扩展方法的调用

            IEnumerable<Product> products = new ShoppingCart()
            {
                Products = new List<Product>
                {
                    new Product{Name = "Kayak", Category = "Watersports", Price = 275M},
                    new Product{Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                    new Product{Name = "Scoll ball", Category = "Soccer", Price = 19.50M},
                    new Product{Name = "Corner flag", Category = "Soccer", Price = 34.95M},
                }
            };
            /* decimal total = products.FilterByCategory("Soccer").TolPrice();
             return String.Format("Soccer Total:{0:c}", total);*/
            /*Func<Product, bool> categoryFilter = delegate (Product prod)
             {
                 return prod.Category == "Soccer";
             };
            decimal total = products.Filter(categoryFilter).TolPrice();
            return String.Format("Soccer Total:{0:c}", total);*/
            //上述代码明确了过滤器过滤函数Func过滤条件，但代码过于臃肿，采用lambda表达式
            /* decimal total = products.Filter(prod => prod.Category == "Soccer").TolPrice();
             return String.Format("Soccer Total:{0:c}", total);*/
            //lambda表达式条件扩展
            /*decimal total = products.Filter(prod => prod.Category == "Soccer" && prod.Price > 20).TolPrice();
            return String.Format("Soccer Total:{0:c}", total);*/

            /* StringContainer stringContainer = new StringContainer() { Value = "Hello" };
             DateTimeContainer dateTimeContainer = new DateTimeContainer() { Value = DateTime.Now };
             if(stringContainer.HasValue && dateTimeContainer.HasValue)
             {
                 return String.Format("Char:{0},Year:{1}", stringContainer.Value.ToCharArray().First(), dateTimeContainer.Value.Year);
             } 
             else
             {
                 return "No Values";
             }*/

            //泛型容器调用
            /*ValueContainer<String> stringValue = new ValueContainer<string> { Value = "Hello" };
            ValueContainer<DateTime> dateTime = new ValueContainer<DateTime> { Value = DateTime.Now };
            if(stringValue.HasValue && dateTime.HasValue)
            {
                return String.Format("Char:{0},Year:{1}", stringValue.Value.ToCharArray().First(), dateTime.Value.Year);
            }
            else
            {
                return "NO Value";
            }*/

            //接口的调用
            /*TimeProvider time = new TimeProvider();
            IMonthProvider month = (IMonthProvider)time;
            IYearProvider year = (IYearProvider)time;
            return String.Format("Month:{0},Year:{1}", month.GetCurrent(), year.GetCurrent());*/

            Product[] myProducts =
            {
                new Product{Name = "Kayak", Category = "Watersports", Price = 275M},
                new Product{Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                new Product{Name = "Scoll ball", Category = "Soccer", Price = 19.50M},
                new Product{Name = "Corner flag", Category = "Soccer", Price = 34.95M},
            };
            Product[] foundProducts = new Product[3];
            Array.Sort(myProducts, (item1, item2) => {
                return Comparer<decimal>.Default.Compare(item1.Price, item2.Price);
            });
            Array.Copy(myProducts, foundProducts, 3);
            StringBuilder result = new StringBuilder();
            foreach(Product p in foundProducts)
            {
                result.AppendFormat("Price:{0}", p.Price);
            }
            return result.ToString();
        }
    }
}