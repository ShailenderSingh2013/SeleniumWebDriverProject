
using System;

namespace AutomationHelper
{
    public static class PagesGenerator
    {
        public static T GetPage<T>() where T : new()
        {
            var page = new T();
            return page;
        }

    }
}
