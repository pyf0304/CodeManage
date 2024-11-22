
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_RTqa_PaperRelaBLEx
表名:gs_RTqa_PaperRela(01120696)
生成代码版本:2020.07.06.1
生成日期:2020/07/07 22:45:14
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;

namespace ExamLib.BusinessLogicEx
{
    public static class clsgs_RTqa_PaperRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_RTqa_PaperRelaENS">源对象</param>
        /// <returns>目标对象=>clsgs_RTqa_PaperRelaEN:objgs_RTqa_PaperRelaENT</returns>
        public static clsgs_RTqa_PaperRelaENEx CopyToEx(this clsgs_RTqa_PaperRelaEN objgs_RTqa_PaperRelaENS)
        {
            try
            {
                clsgs_RTqa_PaperRelaENEx objgs_RTqa_PaperRelaENT = new clsgs_RTqa_PaperRelaENEx();
                clsgs_RTqa_PaperRelaBL.gs_RTqa_PaperRelaDA.CopyTo(objgs_RTqa_PaperRelaENS, objgs_RTqa_PaperRelaENT);
                return objgs_RTqa_PaperRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objgs_RTqa_PaperRelaENS">源对象</param>
        /// <returns>目标对象=>clsgs_RTqa_PaperRelaEN:objgs_RTqa_PaperRelaENT</returns>
        public static clsgs_RTqa_PaperRelaEN CopyTo(this clsgs_RTqa_PaperRelaENEx objgs_RTqa_PaperRelaENS)
        {
            try
            {
                clsgs_RTqa_PaperRelaEN objgs_RTqa_PaperRelaENT = new clsgs_RTqa_PaperRelaEN();
                clsgs_RTqa_PaperRelaBL.CopyTo(objgs_RTqa_PaperRelaENS, objgs_RTqa_PaperRelaENT);
                return objgs_RTqa_PaperRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 答疑关系表(gs_RTqa_PaperRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_RTqa_PaperRelaBLEx : clsgs_RTqa_PaperRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_RTqa_PaperRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_RTqa_PaperRelaDAEx gs_RTqa_PaperRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_RTqa_PaperRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_RTqa_PaperRelaENS">源对象</param>
        /// <returns>目标对象=>clsgs_RTqa_PaperRelaEN:objgs_RTqa_PaperRelaENT</returns>
        public static clsgs_RTqa_PaperRelaENEx CopyToEx(clsgs_RTqa_PaperRelaEN objgs_RTqa_PaperRelaENS)
        {
            try
            {
                clsgs_RTqa_PaperRelaENEx objgs_RTqa_PaperRelaENT = new clsgs_RTqa_PaperRelaENEx();
                clsgs_RTqa_PaperRelaBL.gs_RTqa_PaperRelaDA.CopyTo(objgs_RTqa_PaperRelaENS, objgs_RTqa_PaperRelaENT);
                return objgs_RTqa_PaperRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsgs_RTqa_PaperRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_RTqa_PaperRelaEN> arrObjLst = clsgs_RTqa_PaperRelaBL.GetObjLst(strCondition);
            List<clsgs_RTqa_PaperRelaENEx> arrObjExLst = new List<clsgs_RTqa_PaperRelaENEx>();
            foreach (clsgs_RTqa_PaperRelaEN objInFor in arrObjLst)
            {
                clsgs_RTqa_PaperRelaENEx objgs_RTqa_PaperRelaENEx = new clsgs_RTqa_PaperRelaENEx();
                clsgs_RTqa_PaperRelaBL.CopyTo(objInFor, objgs_RTqa_PaperRelaENEx);
                arrObjExLst.Add(objgs_RTqa_PaperRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_RTqa_PaperRelaENEx GetObjExBymId(long lngmId)
        {
            clsgs_RTqa_PaperRelaEN objgs_RTqa_PaperRelaEN = clsgs_RTqa_PaperRelaBL.GetObjBymId(lngmId);
            clsgs_RTqa_PaperRelaENEx objgs_RTqa_PaperRelaENEx = new clsgs_RTqa_PaperRelaENEx();
            clsgs_RTqa_PaperRelaBL.CopyTo(objgs_RTqa_PaperRelaEN, objgs_RTqa_PaperRelaENEx);
            return objgs_RTqa_PaperRelaENEx;
        }




    }
}