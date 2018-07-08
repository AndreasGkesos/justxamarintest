using System;
using System.Collections.Generic;
using System.Text;

namespace testxamarin.Helpers
{
    static class Constants
    {
        public static Dictionary<string, string> GetUrls()
        {
            Dictionary<string, string> urls = new Dictionary<string, string>();

            urls.Add("getEmployees", "http://dummy.restapiexample.com/api/v1/employees");
            urls.Add("login", "http://www.mocky.io/v2/5b4274f62e00008c00222f8f"); // 5b3b853b330000d008599cf8 <- ok 5b4274f62e00008c00222f8f <- error

            return urls;
        }
    }
}
