/*-- -- -- -- -- -- -- -- -- -- --
����:WApiUsers_QUDI_TS
������:spaUsersCRUD(00070054)
���ɴ���汾:2019.08.30.1
��������:2019/09/26 01:05:19
������:
��������:�������
����ID:0007
������ݿ�:101.251.68.133,9433TaskManage
PrjDataBaseId:0007
ģ��������:�û�����
ģ��Ӣ����:UserManage
���-����:WA_����ű���̨ģ��_TS(WA_ViewScriptCSModel_TS)
�������:CSharp
ע��:1����Ҫ���ݵײ�(PubDataBase.dll)�İ汾:2019.03.07.01
     2����Ҫ����������(TzPubFunction.dll)�İ汾:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GraduateStudyWebApp.FunClass;
namespace GraduateStudyWebApp.Pages.UserManage
{
    /// <summary>
    /// WApiUsers_QUDI_TS ��ժҪ˵��������Q�����ѯ,U�����޸�
    /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:GeneCode)
    /// </summary>
    public class Users_QUDIModel : PageModel
    {

        public string Message { get; set; }
        public void OnGet()
        {
            Message = "spaUsersCRUD(�û�CRUD)(00070054)ҳ��.";
        }

        /// <summary>
        /// Session����-�û�Id
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
        /// ����Session����
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_SetSession)
        /// </summary>
        /// <param name="strKey"></param>
        /// <param name="strValue"></param>
        public void SetSession(string strKey, string strValue)
        {
            HttpContext.Session.SetString(strKey, strValue);
        }

        /// <summary>
        /// ��ȡSession����
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_GetSession)
        /// </summary>
        /// <param name="strKey">�ؼ���-Session������</param>
        /// <returns>���ص�ǰ�ؼ��ֵ�ֵ</returns>
        public string GetSession(string strKey)
        {
            var strValue = HttpContext.Session.GetString(strKey);
            return strValue;
        }

        /// <summary>
        /// ��ȡSession���Եĵ�ַ
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_Url_Session_GetString)
        /// </summary>
        public string Url_Session_GetString
        {
            get
            {
                return clsPubVar.Url_Session_GetString;
            }
        }

        /// <summary>
        /// ����Session���Եĵ�ַ
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_Url_Session_SetString)
        /// </summary>
        public string Url_Session_SetString
        {
            get
            {
                return clsPubVar.Url_Session_SetString;
            }
        }

        /// <summary>
        /// ��ǰ�Ĺ���Id
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_CurrPrjId)
        /// </summary>
        public string CurrPrjId
        {
            get
            {
                //��ȡ����������CurrPrjId
                return clsPubVar.CurrPrjId;
            }
        }

        /// <summary>
        /// ��ǰ�������Ŀ¼����appsettings.json���ã�environmentVariables:ASPNETCORE_PATHBASE
        /// (AutoGCLib.WA_ViewScriptCSModel_TS4CSharp:Gen_WApi_Model_WebRoot)
        /// </summary>
        public string WebRoot
        {
            get
            {
                //����·��
                string strPhysicalRoot = AppContext.BaseDirectory;
                //��ȡ���ã������Ŀ¼
                var pathBase = Environment.GetEnvironmentVariable("ASPNETCORE_PATHBASE");
                //��ȡ����������WebRoot
                return clsPubVar.WebRoot;
            }
        }

    }
}