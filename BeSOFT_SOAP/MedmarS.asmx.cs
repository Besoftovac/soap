﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BeSOFT_SOAP
{
    /// <summary>
    /// Summary description for MedmarS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]//ovo je junik ajdentifajer :D dakle treba mu dat ime domene + naziv--tempuri org je svuđe
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MedmarS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Pero()
        {
            return "Pero";
        }
    }
}
