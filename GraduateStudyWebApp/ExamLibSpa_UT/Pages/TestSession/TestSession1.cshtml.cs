using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using AGC.FunClass;

namespace AGC.Pages
{
    public class TestSession1Model : PageModel
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
        //public void SetSession4(string strKey, string strValue)
        //{
        //    ViewBag.strKey = strValue;
        //}
        public void SetSession3(string strKey, string strValue)
        {
            ViewData.Add(strKey, strValue);    
        }
        public void SetSession2(string strKey, string strValue)
        {
            HttpContext.Session.SetString(strKey, strValue);
        }
        public string GetSession2(string strKey)
        {
            var strValue = HttpContext.Session.GetString(strKey);
            return strValue;
        }
        public void SetSession(string strKey, string strValue)
        {
          
            byte[] byteArray = System.Text.Encoding.Default.GetBytes(strValue);
            Request.HttpContext.Session.Set(strKey, byteArray);
 

//            byte[] byteArray = 通过某种方式获取到的字节数组
//string str = System.Text.Encoding.Default.GetString(byteArray);
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