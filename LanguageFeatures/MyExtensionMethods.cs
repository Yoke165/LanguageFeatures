using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures
{
    public static class MyExtensionMethods
    {
        /*public static decimal ToalPrice(this ShoppingCart cartParam) {
            decimal total = 0;
            foreach (Product prod in cartParam.Products) {
                total += prod.Price;
            }
            return total;
        }*/
        //此处定义一个扩展方法，扩展方法必须在静态类中定义，其方法也需为静态，第一个参数前的this将其标注为
        //扩展方法，其后为扩展的方法的类，扩展类的成员需可访问才行

        public static decimal TolPrice(this IEnumerable<Product> productEnum)
        {
            decimal total = 0;
            foreach (Product pord in productEnum)
            {
                total += pord.Price;
            }
            return total;
        }
        //过滤器
        public static IEnumerable<Product> FilterByCategory(this IEnumerable<Product> productEnum, string categoryParam)
        {
            foreach(Product prod in productEnum)
            {
                if(prod.Category == categoryParam)
                {
                    yield return prod;
                }
            }
        }
        //通用性过滤器
        public static IEnumerable<Product> Filter(this IEnumerable<Product> productEnum, Func<Product, bool> selectorParam)
        {
            foreach(Product prod in productEnum)
            {
                if (selectorParam(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}