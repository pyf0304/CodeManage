
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsJournalSubjectBLEx
表名:JournalSubject(01120930)
生成代码版本:2021.06.19.1
生成日期:2021/06/20 00:37:01
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
    public static class clsJournalSubjectBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objJournalSubjectENS">源对象</param>
        /// <returns>目标对象=>clsJournalSubjectEN:objJournalSubjectENT</returns>
        public static clsJournalSubjectENEx CopyToEx(this clsJournalSubjectEN objJournalSubjectENS)
        {
            try
            {
                clsJournalSubjectENEx objJournalSubjectENT = new clsJournalSubjectENEx();
                clsJournalSubjectBL.JournalSubjectDA.CopyTo(objJournalSubjectENS, objJournalSubjectENT);
                return objJournalSubjectENT;
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
        /// <param name = "objJournalSubjectENS">源对象</param>
        /// <returns>目标对象=>clsJournalSubjectEN:objJournalSubjectENT</returns>
        public static clsJournalSubjectEN CopyTo(this clsJournalSubjectENEx objJournalSubjectENS)
        {
            try
            {
                clsJournalSubjectEN objJournalSubjectENT = new clsJournalSubjectEN();
                clsJournalSubjectBL.CopyTo(objJournalSubjectENS, objJournalSubjectENT);
                return objJournalSubjectENT;
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
    /// 期刊学科(JournalSubject)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsJournalSubjectBLEx : clsJournalSubjectBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsJournalSubjectDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsJournalSubjectDAEx JournalSubjectDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsJournalSubjectDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objJournalSubjectENS">源对象</param>
        /// <returns>目标对象=>clsJournalSubjectEN:objJournalSubjectENT</returns>
        public static clsJournalSubjectENEx CopyToEx(clsJournalSubjectEN objJournalSubjectENS)
        {
            try
            {
                clsJournalSubjectENEx objJournalSubjectENT = new clsJournalSubjectENEx();
                clsJournalSubjectBL.JournalSubjectDA.CopyTo(objJournalSubjectENS, objJournalSubjectENT);
                return objJournalSubjectENT;
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
        public static List<clsJournalSubjectENEx> GetObjExLst(string strCondition)
        {
            List<clsJournalSubjectEN> arrObjLst = clsJournalSubjectBL.GetObjLst(strCondition);
            List<clsJournalSubjectENEx> arrObjExLst = new List<clsJournalSubjectENEx>();
            foreach (clsJournalSubjectEN objInFor in arrObjLst)
            {
                clsJournalSubjectENEx objJournalSubjectENEx = new clsJournalSubjectENEx();
                clsJournalSubjectBL.CopyTo(objInFor, objJournalSubjectENEx);
                arrObjExLst.Add(objJournalSubjectENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strJournalSubjectId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsJournalSubjectENEx GetObjExByJournalSubjectId(string strJournalSubjectId)
        {
            clsJournalSubjectEN objJournalSubjectEN = clsJournalSubjectBL.GetObjByJournalSubjectId(strJournalSubjectId);
            clsJournalSubjectENEx objJournalSubjectENEx = new clsJournalSubjectENEx();
            clsJournalSubjectBL.CopyTo(objJournalSubjectEN, objJournalSubjectENEx);
            return objJournalSubjectENEx;
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
                    intCount = clsPubFun4DataImport.AddDateExcelToJournalSubject(dtable, strOpUserId, ref lblmess);
                    if (intCount >= 0)
                    {
                        string strMsg = string.Format("操作成功！共导入了{0}门学科。", intCount);
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

        public static clsJournalSubjectEN GetObjByJournalSubjectNameEx(string strJournalSubjectName)
        {
            var arrJournalSubjectObjLst_Cache = GetObjLstCache();

            foreach (clsJournalSubjectEN objJournalSubjectEN in arrJournalSubjectObjLst_Cache)
            {
                if (objJournalSubjectEN.JournalSubjectName.Contains(strJournalSubjectName) == true)
                {
                    return objJournalSubjectEN;
                }
            }
            return null;
        }

    }
}