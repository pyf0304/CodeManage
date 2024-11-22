using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AGC.FunClass;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AGC.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
        /// <summary>
        /// 当前的虚拟根目录，在appsettings.json设置：environmentVariables:ASPNETCORE_PATHBASE
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_WebRoot)
        /// </summary>
        public string WebRoot
        {
            get
            {
                //物理路径
                string strPhysicalRoot = AppContext.BaseDirectory;
                //获取设置：虚拟根目录
                var pathBase = Environment.GetEnvironmentVariable("ASPNETCORE_PATHBASE");
                //获取公共变量：WebRoot
                return clsPubVar.WebRoot;
            }
        }
    }
}
