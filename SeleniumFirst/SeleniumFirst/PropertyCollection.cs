﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst



{
    enum PropertyType
    {
    Id,
    Name,
    LinkText,
    CssName,
    ClassName
}
class PropertyCollection

  
    {
        // Auto-implement Property

        public static IWebDriver driver { get; set; }
    }
}
