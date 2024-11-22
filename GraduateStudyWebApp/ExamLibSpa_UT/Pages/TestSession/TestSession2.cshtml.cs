using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AGC.FunClass;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AGC.Pages
{
    public class TestSession2Model : PageModel
    {
        public void OnGet()
        {

        }
        public string Url_Session_SetString
        {
            get
            {
                //获取公共变量：WebRoot
                return clsPubVar.Url_Session_SetString;
            }
        }
        public string Url_Session_GetString
        {
            get
            {
                //获取公共变量：WebRoot
                return clsPubVar.Url_Session_GetString;
            }
        }
        public string GetSession3(string strKey)
        {
            if (ViewData[strKey] == null) return "";
            string strValue = ViewData[strKey].ToString();
            return strValue;
        }

        public string sePyf2()
        {
            var strValue = HttpContext.Session.GetString("pyf2");
            return strValue;
        }
        public string GetSession2(string strKey)
        {
            var strValue = HttpContext.Session.GetString(strKey);
            return strValue;
        }
            public string GetSession(string strKey)
        {
//var strValue = Request.HttpContext.Session[strKey];
            
//            , byteArray);

            Byte[] bytesTemp;
            HttpContext.Session.TryGetValue(strKey, out bytesTemp);
            if (bytesTemp == null) return "";
            string strValue = System.Text.Encoding.Default.GetString(bytesTemp);
            return strValue;
            //, string strValue
            //byte[] byteArray = System.Text.Encoding.Default.GetBytes(strValue);
            
            //var value = HttpContext.Session.GetString(Key);

            //var data = new
            //{
            //    Key,
            //    value
            //};
            //return Json(data);
        }
    }
}