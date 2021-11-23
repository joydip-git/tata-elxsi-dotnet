using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace OldWebApp
{
    /// <summary>
    /// Summary description for CalculationService
    /// </summary>
    [WebService(Namespace = "http://tataelxsi.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculationService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
