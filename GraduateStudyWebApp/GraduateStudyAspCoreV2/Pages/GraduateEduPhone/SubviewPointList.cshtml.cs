using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GraduateStudyWebApp.FunClass;

namespace GraduateStudyWebApp.Pages.GraduateEduEx
{
    public class SubviewPointListModel : PageModel
    {
        /// <summary>
        /// 获取Session属性
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_GetSession)
        /// </summary>
        /// <param name="strKey">关键字-Session属性名</param>
        /// <returns>返回当前关键字的值</returns>
        public string GetSession(string strKey)
        {
            var strValue = HttpContext.Session.GetString(strKey);
            return strValue;
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
        /// <summary>
        /// Session属性-论文Id
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_seCourseId)
        /// </summary>
        public string seThesisId
        {
            get
            {
                var strValue = HttpContext.Session.GetString("ThesisId");
                return strValue;
            }
            set
            {
                HttpContext.Session.SetString("ThesisId", value);
            }
        }

        /// <summary>
        /// Session属性-子观点模块Id
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_seCourseId)
        /// </summary>
        public string seSubViewpointTypeId
        {
            get
            {
                var strValue = HttpContext.Session.GetString("SubViewpointTypeId");
                return strValue;
            }
            set
            {
                HttpContext.Session.SetString("SubViewpointTypeId", value);
            }
        }
        
        /// <summary>
        /// Session属性-课程Id
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_seCourseId)
        /// </summary>
        public string seCourseId
        {
            get
            {
                var strValue = HttpContext.Session.GetString("CourseId");
                return strValue;
            }
            set
            {
                HttpContext.Session.SetString("CourseId", value);
            }
        }
        /// <summary>
        /// Session属性-用户Id
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_SeUserId)
        /// </summary>
        public string seUserId
        {
            get
            {
                var strValue = HttpContext.Session.GetString("UserId");
                return strValue;
            }
            set
            {
                HttpContext.Session.SetString("UserId", value);
            }
        }

        /// <summary>
        /// 设置Session属性
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_SetSession)
        /// </summary>
        /// <param name="strKey"></param>
        /// <param name="strValue"></param>
        public void SetSession(string strKey, string strValue)
        {
            HttpContext.Session.SetString(strKey, strValue);
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
        public string AddressAndPort
        {
            get
            {
                //
                return clsPubVar.IPAddressAndPort + WebRoot + "/Upload";
            }
        }
    }
}