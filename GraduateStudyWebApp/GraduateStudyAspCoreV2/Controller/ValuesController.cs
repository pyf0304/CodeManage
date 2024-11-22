using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApiInCore2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    //.Net Core2.0(VS2017)下默认继承自Controller，且上面没有打[ApiController]特性
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet("{a},{b}")]
        public ActionResult<int> Plus(int a, int b)
        {
            //Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("a", a.ToString());
            //dictParam.Add("b", b.ToString());
            //clsPubFun_WebApi.Log4Debug(this, "Plus", dictParam);
            var c = a + b;
            return c;
           
        }
        [HttpGet("Test")]
        public ActionResult<string> Test()
        {
            //Dictionary<string, string> dictParam = new Dictionary<string, string>();
            //dictParam.Add("a", a.ToString());
            //dictParam.Add("b", b.ToString());
            //clsPubFun_WebApi.Log4Debug(this, "Plus", dictParam);
            //var c = a + b;
            return "测试成功";
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

    }

}
