
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsKnowledgeMasterLevelBLEx
表名:KnowledgeMasterLevel(01120891)
生成代码版本:2021.03.07.1
生成日期:2021/03/10 14:31:04
生成者:yy
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:知识点相关
模块英文名:Knowledges
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
    public static class clsKnowledgeMasterLevelBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objKnowledgeMasterLevelENS">源对象</param>
        /// <returns>目标对象=>clsKnowledgeMasterLevelEN:objKnowledgeMasterLevelENT</returns>
        public static clsKnowledgeMasterLevelENEx CopyToEx(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelENS)
        {
            try
            {
                clsKnowledgeMasterLevelENEx objKnowledgeMasterLevelENT = new clsKnowledgeMasterLevelENEx();
                clsKnowledgeMasterLevelBL.KnowledgeMasterLevelDA.CopyTo(objKnowledgeMasterLevelENS, objKnowledgeMasterLevelENT);
                return objKnowledgeMasterLevelENT;
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
        /// <param name = "objKnowledgeMasterLevelENS">源对象</param>
        /// <returns>目标对象=>clsKnowledgeMasterLevelEN:objKnowledgeMasterLevelENT</returns>
        public static clsKnowledgeMasterLevelEN CopyTo(this clsKnowledgeMasterLevelENEx objKnowledgeMasterLevelENS)
        {
            try
            {
                clsKnowledgeMasterLevelEN objKnowledgeMasterLevelENT = new clsKnowledgeMasterLevelEN();
                clsKnowledgeMasterLevelBL.CopyTo(objKnowledgeMasterLevelENS, objKnowledgeMasterLevelENT);
                return objKnowledgeMasterLevelENT;
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
    /// 知识点掌握度(KnowledgeMasterLevel)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsKnowledgeMasterLevelBLEx : clsKnowledgeMasterLevelBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsKnowledgeMasterLevelDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsKnowledgeMasterLevelDAEx KnowledgeMasterLevelDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsKnowledgeMasterLevelDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objKnowledgeMasterLevelENS">源对象</param>
        /// <returns>目标对象=>clsKnowledgeMasterLevelEN:objKnowledgeMasterLevelENT</returns>
        public static clsKnowledgeMasterLevelENEx CopyToEx(clsKnowledgeMasterLevelEN objKnowledgeMasterLevelENS)
        {
            try
            {
                clsKnowledgeMasterLevelENEx objKnowledgeMasterLevelENT = new clsKnowledgeMasterLevelENEx();
                clsKnowledgeMasterLevelBL.KnowledgeMasterLevelDA.CopyTo(objKnowledgeMasterLevelENS, objKnowledgeMasterLevelENT);
                return objKnowledgeMasterLevelENT;
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
        public static List<clsKnowledgeMasterLevelENEx> GetObjExLst(string strCondition)
        {
            List<clsKnowledgeMasterLevelEN> arrObjLst = clsKnowledgeMasterLevelBL.GetObjLst(strCondition);
            List<clsKnowledgeMasterLevelENEx> arrObjExLst = new List<clsKnowledgeMasterLevelENEx>();
            foreach (clsKnowledgeMasterLevelEN objInFor in arrObjLst)
            {
                clsKnowledgeMasterLevelENEx objKnowledgeMasterLevelENEx = new clsKnowledgeMasterLevelENEx();
                clsKnowledgeMasterLevelBL.CopyTo(objInFor, objKnowledgeMasterLevelENEx);
                arrObjExLst.Add(objKnowledgeMasterLevelENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strMasterLevelId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsKnowledgeMasterLevelENEx GetObjExByMasterLevelId(string strMasterLevelId)
        {
            clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN = clsKnowledgeMasterLevelBL.GetObjByMasterLevelId(strMasterLevelId);
            clsKnowledgeMasterLevelENEx objKnowledgeMasterLevelENEx = new clsKnowledgeMasterLevelENEx();
            clsKnowledgeMasterLevelBL.CopyTo(objKnowledgeMasterLevelEN, objKnowledgeMasterLevelENEx);
            return objKnowledgeMasterLevelENEx;
        }
        public static double CalcMasteryLevel(List<clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetail,
            string strCourseKnowledgeId,
            double dblPositiveCorrelation,    //正相关度        
            double dblNegativeCorrelation)    //负相关度)
        {
            // 初始掌握程度为0
            double masteryLevel = 0;
            double increaseFactor = 1; // 初始的增长因子
                                       // 遍历每次做题结果
            int i = 0;
            foreach (var objInFor in arrKnowledgeLearnDetail)
            {
                // 如果回答正确，则增加掌握程度，增加的程度由增长因子决定
                if (objInFor.IsRight == true)
                {
                    increaseFactor = (1 - masteryLevel) * 0.5 * dblPositiveCorrelation;
                    //                    double increaseAmount = Math.Min(increaseFactor, 1 - masteryLevel); // 考虑增长上限
                    masteryLevel += increaseFactor;
                    //increaseFactor *= 1.2; // 每次正确回答后增长因子增加
                }
                // 如果回答错误，则重置增长因子并减少掌握程度
                else
                {
                    increaseFactor = masteryLevel * 0.5 * dblNegativeCorrelation; // 重置增长因子
                    masteryLevel -= increaseFactor;
                }
                // 输出每次做题后的掌握程度
                Console.WriteLine("做题" + (i + 1) + "后的掌握程度：" + masteryLevel);
                i++;
            }
            return masteryLevel;
        }
        //通过掌握值比对，返回对应的ID
        public static string GetMasteryLevelId(double MasteryValue)
        {
            string MasterLevelId = string.Empty;

            try
            {
                List<clsKnowledgeMasterLevelEN> objKnowledgeMasterLevelList = clsKnowledgeMasterLevelBL.GetObjLst("1=1");
                foreach (clsKnowledgeMasterLevelEN obj in objKnowledgeMasterLevelList)
                {
                    //大于最小值，小于等于最大值；
                    if (MasteryValue > obj.LevelMinValue && MasteryValue <= obj.LevelMaxValue)
                    {
                        MasterLevelId = obj.MasterLevelId;
                    }
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID获取出错:[{0}]。{1}. (In {2})",
                MasteryValue, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return MasterLevelId;
        }

    }
}