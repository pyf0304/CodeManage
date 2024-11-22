
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsJournalSubjectCategoryBLEx
表名:JournalSubjectCategory(01120931)
生成代码版本:2021.06.19.1
生成日期:2021/06/20 00:37:08
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
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
    public static class clsJournalSubjectCategoryBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objJournalSubjectCategoryENS">源对象</param>
        /// <returns>目标对象=>clsJournalSubjectCategoryEN:objJournalSubjectCategoryENT</returns>
        public static clsJournalSubjectCategoryENEx CopyToEx(this clsJournalSubjectCategoryEN objJournalSubjectCategoryENS)
        {
            try
            {
                clsJournalSubjectCategoryENEx objJournalSubjectCategoryENT = new clsJournalSubjectCategoryENEx();
                clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.CopyTo(objJournalSubjectCategoryENS, objJournalSubjectCategoryENT);
                return objJournalSubjectCategoryENT;
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
        /// <param name = "objJournalSubjectCategoryENS">源对象</param>
        /// <returns>目标对象=>clsJournalSubjectCategoryEN:objJournalSubjectCategoryENT</returns>
        public static clsJournalSubjectCategoryEN CopyTo(this clsJournalSubjectCategoryENEx objJournalSubjectCategoryENS)
        {
            try
            {
                clsJournalSubjectCategoryEN objJournalSubjectCategoryENT = new clsJournalSubjectCategoryEN();
                clsJournalSubjectCategoryBL.CopyTo(objJournalSubjectCategoryENS, objJournalSubjectCategoryENT);
                return objJournalSubjectCategoryENT;
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
    /// 期刊学科门类(JournalSubjectCategory)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsJournalSubjectCategoryBLEx : clsJournalSubjectCategoryBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsJournalSubjectCategoryDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsJournalSubjectCategoryDAEx JournalSubjectCategoryDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsJournalSubjectCategoryDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objJournalSubjectCategoryENS">源对象</param>
        /// <returns>目标对象=>clsJournalSubjectCategoryEN:objJournalSubjectCategoryENT</returns>
        public static clsJournalSubjectCategoryENEx CopyToEx(clsJournalSubjectCategoryEN objJournalSubjectCategoryENS)
        {
            try
            {
                clsJournalSubjectCategoryENEx objJournalSubjectCategoryENT = new clsJournalSubjectCategoryENEx();
                clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.CopyTo(objJournalSubjectCategoryENS, objJournalSubjectCategoryENT);
                return objJournalSubjectCategoryENT;
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
        public static List<clsJournalSubjectCategoryENEx> GetObjExLst(string strCondition)
        {
            List<clsJournalSubjectCategoryEN> arrObjLst = clsJournalSubjectCategoryBL.GetObjLst(strCondition);
            List<clsJournalSubjectCategoryENEx> arrObjExLst = new List<clsJournalSubjectCategoryENEx>();
            foreach (clsJournalSubjectCategoryEN objInFor in arrObjLst)
            {
                clsJournalSubjectCategoryENEx objJournalSubjectCategoryENEx = new clsJournalSubjectCategoryENEx();
                clsJournalSubjectCategoryBL.CopyTo(objInFor, objJournalSubjectCategoryENEx);
                arrObjExLst.Add(objJournalSubjectCategoryENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strJournalSubjectCategoryId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsJournalSubjectCategoryENEx GetObjExByJournalSubjectCategoryId(string strJournalSubjectCategoryId)
        {
            clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = clsJournalSubjectCategoryBL.GetObjByJournalSubjectCategoryId(strJournalSubjectCategoryId);
            clsJournalSubjectCategoryENEx objJournalSubjectCategoryENEx = new clsJournalSubjectCategoryENEx();
            clsJournalSubjectCategoryBL.CopyTo(objJournalSubjectCategoryEN, objJournalSubjectCategoryENEx);
            return objJournalSubjectCategoryENEx;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strJournalSubjectCategoryName">所给的名称</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsJournalSubjectCategoryEN GetObjByJournalSubjectCategoryNameEx(string strJournalSubjectCategoryName)
        {
            var arrJournalSubjectCategoryObjLst_Cache = GetObjLstCache();

            foreach (clsJournalSubjectCategoryEN objJournalSubjectCategoryEN in arrJournalSubjectCategoryObjLst_Cache)
            {
                if (objJournalSubjectCategoryEN.JournalSubjectCategoryName.Contains(strJournalSubjectCategoryName) == true)
                {
                    return objJournalSubjectCategoryEN;
                }
            }
            return null;
        }

        public static int ImportDataFromCsv(string strCsv, string strOpUserId)
        {
            //System.Data.DataTable dtable = BindGv_Excel();
            ////删除空行
            //removeEmpty(dtable);

            //clsPubFun.AddDateExcelToTeacherInfo(dtable);

            string lblmess = "";
            int intCount = 0;
            System.Data.DataTable dtable = clsPubFun4DataImport.csv2table(strCsv);
            if (dtable.Rows.Count > 0)
            {
                //删除空行
                //removeEmpty(dtable);
                try
                {
                    intCount = clsPubFun4DataImport.AddDateExcelToJournalSubjectCategory(dtable, strOpUserId, ref lblmess);
                    if (intCount >= 0)
                    {
                        string strMsg = string.Format("操作成功！共导入了{0}位学科门类。", intCount);
                        clsSysParaEN.objLog.WriteDebugLog(strMsg);
                    }
                    //this.lblMessFalse.Text = lblmess;
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("导入Excel时出错。错误:{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                //Response1.Write(this.lblMessFalse.Text);
            }
            else
            {
                throw new Exception("当前没有数据可导入，请先上传有数据的Excel文件！");
            }
            return intCount;
        }

    }
}