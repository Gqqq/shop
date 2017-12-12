using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Common
{
    public class JsHelper
    {
        static string jsStart="<script>";
        static string jsEnd = "</script>";

        public static void Alert(string mess)
        {
            string js = $"{jsStart}alert('{mess}'){jsEnd}";
            HttpContext.Current.Response.Write(js);
        }
    }
}
