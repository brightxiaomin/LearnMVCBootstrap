using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBootstrap.Helper
{
    public class Bootstrap
    {
        public const string BundleBase = "~/Content/css/";

        public class Theme
        {
            public const string Stock = "Stock";
            public const string United = "United";
            public const string Darkly = "Darkly";
        }

        public static HashSet<string> Themes = new HashSet<string>
        {
            Theme.Stock,
            Theme.United,
            Theme.Darkly
        };

        public static string Bundle(string themename)
        {
            return BundleBase + themename;
        }
    }
}