using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures
{
    public class StringContainer
    {
        public string Value { get; set; }
        public bool HasValue {
            get { return Value != null; }
        }
    }

    public class DateTimeContainer
    {
        public DateTime Value { get; set; }
        public bool HasValue
        {
            get { return Value != null; }
        }
    }
    //上述两个容器代码重复率高，通过泛型可以编写通用型容器，减少代码的重复率以及提高后期的维护效率
    public class ValueContainer<T>
    {
        public T Value { get; set; }
        public bool HasValue
        {
            get { return Value != null; }
        }
    }
}