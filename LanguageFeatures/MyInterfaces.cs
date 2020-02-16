﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures
{
    public class MyInterfaces
    {
    }

    public interface IMonthProvider
    {
        string GetCurrent();
    }

    public interface IYearProvider
    {
        string GetCurrent();
    }

    public class TimeProvider : IMonthProvider, IYearProvider
    {
        private DateTime now = DateTime.Now;
        string IMonthProvider.GetCurrent()
        {
            return now.ToString("MMM");
        }
        string IYearProvider.GetCurrent()
        {
            return now.Year.ToString();
        }
    }
}