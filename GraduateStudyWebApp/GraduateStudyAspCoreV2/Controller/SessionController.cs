

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GraduateStudyWebApp.Controllers
{
    public class SessionController : Controller
    {
        [HttpGet]
        // GET: /<controller>/
        /// <summary>
        /// 测试Session
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var username = "lyl";
            var bytes = System.Text.Encoding.UTF8.GetBytes(username);
            HttpContext.Session.Set("username", bytes);

            Byte[] bytesTemp;
            HttpContext.Session.TryGetValue("username", out bytesTemp);
            var usernameTemp = System.Text.Encoding.UTF8.GetString(bytesTemp);

            //扩展方法的使用
            HttpContext.Session.SetString("password", "123456");
            var password = HttpContext.Session.GetString("password");

            var data = new
            {
                usernameTemp,
                password
            };

            return Json(data);
        }

        /// <summary>
        /// 有效，可正确使用
        /// </summary>
        /// <param name="Key">关键字</param>
        /// <param name="Value">值</param>
        /// <returns>Json对象，包含属性：key,value</returns>
        [HttpGet]
        public IActionResult SetString(string Key, string Value)
        {
            HttpContext.Session.SetString(Key, Value);

            var value = HttpContext.Session.GetString(Key);

            var data = new
            {
                key = Key,
                value = value
            };
            return Json(data);

        }
        /// <summary>
        /// 有效，可正确使用
        /// </summary>
        /// <param name="Key">关键字</param>
        /// <param name="Value">值</param>
        /// <returns>Json对象，包含属性：key,value</returns>
        [HttpGet]
        public IActionResult SetObject<T>(string Key, T Value)
        {
            HttpContext.Session.SetString(Key, JsonConvert.SerializeObject(Value));

            var value = HttpContext.Session.GetString(Key);

            var data = new
            {
                key = Key,
                value = value
            };
            return Json(data);

        }
        /// <summary>
        /// 有效，可正确使用
        /// </summary>
        /// <param name="Key">关键字</param>     
        /// <returns>Json对象，包含属性：key,value</returns>
        [HttpGet]
        public IActionResult GetString(string Key)
        {
            var value = HttpContext.Session.GetString(Key);// + Key;
            var arrKey = HttpContext.Session.Keys;
            var data = new
            {
                key = Key,
                value = value
            };
            return Json(data);
        }

        //[HttpPost]
        [HttpGet]
        public IActionResult strSetSession(string strKey, string strValue)
        {
            HttpContext.Session.SetString(strKey, strValue);
            var value = HttpContext.Session.GetString(strKey);

            var data = new
            {
                strKey,
                value
            };
            return Json(data);
        }


        [HttpGet]
        public IActionResult strGetSession(string strKey)
        {

            var value = HttpContext.Session.GetString(strKey);

            var data = new
            {
                strKey,
                value
            };
            return Json(data);
        }

        /// <summary>
        /// 设置Session
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        //protected void SetSession(string key, string value)
        //{
        //    HttpContext.Session.SetString(key, value);
        //}


        [HttpGet]
        /// <summary>
        /// 获取Session
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>返回对应的值</returns>
        protected string GetSession(string key)
        {

            var value = HttpContext.Session.GetString(key);
            if (string.IsNullOrEmpty(value))
                value = string.Empty;
            return value;
        }

        /// <summary>
        /// 清空session
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        protected bool RemoveSession(string key)
        {

            HttpContext.Session.Remove(key);
            return true;
        }


    }
}
