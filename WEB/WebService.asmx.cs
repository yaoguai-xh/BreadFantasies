using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        //[WebMethod]
        //public Student GetStudent(int  ID)
        //{
            //if (ID == 1)
            //{
                //return new Student() { ID = 1, Name = "Byron" };
           // }
            //else
            //{
                //return new Student() { ID = 2, Name = "Frank" };
            //}
        //}

        [WebMethod]
        public string GetDateTime(bool isLong)
        {
            if (isLong)
            {
                return DateTime.Now.ToLongDateString();
            }
            else
            {
                return DateTime.Now.ToShortDateString();
            }
        }
    }
}
