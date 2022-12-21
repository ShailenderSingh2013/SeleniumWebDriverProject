using AutomationHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleTests
{
    internal class Pages
    {
        public static HomePage home => PagesGenerator.GetPage<HomePage>();
    }
}
