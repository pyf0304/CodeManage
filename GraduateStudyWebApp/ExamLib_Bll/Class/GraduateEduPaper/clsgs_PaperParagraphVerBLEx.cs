
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_PaperParagraphVerBLEx
表名:gs_PaperParagraphV(01120743)
生成代码版本:2020.09.09.1
生成日期:2020/09/23 19:04:51
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data;
using System.Data.SqlClient;
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
    public static class clsgs_PaperParagraphVerBLEx_Static
    {
        //private static string strMsg = "";
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_PaperParagraphVerENS">源对象</param>
        /// <returns>目标对象=>clsgs_PaperParagraphVerEN:objgs_PaperParagraphVerENT</returns>
        public static clsgs_PaperParagraphVerENEx CopyToEx(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerENS)
        {
            try
            {
                clsgs_PaperParagraphVerENEx objgs_PaperParagraphVerENT = new clsgs_PaperParagraphVerENEx();
                clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.CopyTo(objgs_PaperParagraphVerENS, objgs_PaperParagraphVerENT);
                return objgs_PaperParagraphVerENT;
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
        /// <param name = "objgs_PaperParagraphVerENS">源对象</param>
        /// <returns>目标对象=>clsgs_PaperParagraphVerEN:objgs_PaperParagraphVerENT</returns>
        public static clsgs_PaperParagraphVerEN CopyTo(this clsgs_PaperParagraphVerENEx objgs_PaperParagraphVerENS)
        {
            try
            {
                clsgs_PaperParagraphVerEN objgs_PaperParagraphVerENT = new clsgs_PaperParagraphVerEN();
                clsgs_PaperParagraphVerBL.CopyTo(objgs_PaperParagraphVerENS, objgs_PaperParagraphVerENT);
                return objgs_PaperParagraphVerENT;
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
    /// 论文段落版本(gs_PaperParagraphV)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_PaperParagraphVerBLEx : clsgs_PaperParagraphVerBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_PaperParagraphVerDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_PaperParagraphVerDAEx gs_PaperParagraphVerDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_PaperParagraphVerDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_PaperParagraphVerENS">源对象</param>
        /// <returns>目标对象=>clsgs_PaperParagraphVerEN:objgs_PaperParagraphVerENT</returns>
        public static clsgs_PaperParagraphVerENEx CopyToEx(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerENS)
        {
            try
            {
                clsgs_PaperParagraphVerENEx objgs_PaperParagraphVerENT = new clsgs_PaperParagraphVerENEx();
                clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.CopyTo(objgs_PaperParagraphVerENS, objgs_PaperParagraphVerENT);
                return objgs_PaperParagraphVerENT;
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
        public static List<clsgs_PaperParagraphVerENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_PaperParagraphVerEN> arrObjLst = clsgs_PaperParagraphVerBL.GetObjLst(strCondition);
            List<clsgs_PaperParagraphVerENEx> arrObjExLst = new List<clsgs_PaperParagraphVerENEx>();
            foreach (clsgs_PaperParagraphVerEN objInFor in arrObjLst)
            {
                clsgs_PaperParagraphVerENEx objgs_PaperParagraphVerENEx = new clsgs_PaperParagraphVerENEx();
                clsgs_PaperParagraphVerBL.CopyTo(objInFor, objgs_PaperParagraphVerENEx);
                arrObjExLst.Add(objgs_PaperParagraphVerENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngParagraphVId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_PaperParagraphVerENEx GetObjExByParagraphVId(long lngParagraphVId)
        {
            clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = clsgs_PaperParagraphVerBL.GetObjByParagraphVId(lngParagraphVId);
            clsgs_PaperParagraphVerENEx objgs_PaperParagraphVerENEx = new clsgs_PaperParagraphVerENEx();
            clsgs_PaperParagraphVerBL.CopyTo(objgs_PaperParagraphVerEN, objgs_PaperParagraphVerENEx);
            return objgs_PaperParagraphVerENEx;
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static List<clsgs_PaperParagraphVerEN> GetObjLstEx(string strWhereCond)
        {
            List<clsgs_PaperParagraphVerEN> arrObjLst = new List<clsgs_PaperParagraphVerEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTableEx(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN();
                try
                {
                   objgs_PaperParagraphVerEN.ParagraphVId = Int32.Parse(objRow[congs_PaperParagraphVer.ParagraphVId].ToString().Trim()); //段落版本Id
                    objgs_PaperParagraphVerEN.ParagraphId = objRow[congs_PaperParagraphVer.ParagraphId].ToString().Trim(); //段落Id
                    //objgs_PaperParagraphVerEN.SectionId = objRow[congs_PaperParagraphVer.SectionId].ToString().Trim(); //节Id
                    //objgs_PaperParagraphVerEN.ParagraphTypeId = objRow[congs_PaperParagraphVer.ParagraphTypeId].ToString().Trim(); //段落类型Id
                    //objgs_PaperParagraphVerEN.ParagraphContent = objRow[congs_PaperParagraphVer.ParagraphContent].ToString().Trim(); //段落内容
                    //objgs_PaperParagraphVerEN.UpdDate = objRow[congs_PaperParagraphVer.UpdDate].ToString().Trim(); //修改日期
                    objgs_PaperParagraphVerEN.UpdUser = objRow[congs_PaperParagraphVer.UpdUser].ToString().Trim(); //修改人
                   // objgs_PaperParagraphVerEN.Memo = objRow[congs_PaperParagraphVer.Memo].ToString().Trim(); //备注
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objgs_PaperParagraphVerEN.ParagraphVId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objgs_PaperParagraphVerEN);
            }
            objDT = null;
            return arrObjLst;
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回数据表,用DataTable表示</returns>
        public static DataTable GetDataTableEx(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsgs_PaperParagraphVerDAEx.GetDataTableEx(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
               clsStackTrace.GetCurrClassFunction(),
               strWhereCond,
               objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}