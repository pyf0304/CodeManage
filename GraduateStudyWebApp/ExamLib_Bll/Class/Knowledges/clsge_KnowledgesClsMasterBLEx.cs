
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_KnowledgesClsMasterBLEx
表名:ge_KnowledgesClsMaster(01120962)
* 版本:2024.03.11.1(服务器:WIN-SRV103-116)
日期:2024/03/12 01:01:53
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:知识点相关(Knowledges)
框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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

using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data;
using System.Data.SqlClient;
using ExamLib.DAL;
using ExamLib.BusinessLogic;
using com.taishsoft.datetime;
using System.Runtime.Remoting;

namespace ExamLib.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_ge_KnowledgesClsMasterEx : RelatedActions_ge_KnowledgesClsMaster
    {
        public override bool UpdRelaTabDate(string strIdCurrEduCls, string strCourseKnowledgeId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsge_KnowledgesClsMasterBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objge_KnowledgesClsMasterENS">源对象</param>
        /// <returns>目标对象=>clsge_KnowledgesClsMasterEN:objge_KnowledgesClsMasterENT</returns>
        public static clsge_KnowledgesClsMasterENEx CopyToEx(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterENS)
        {
            try
            {
                clsge_KnowledgesClsMasterENEx objge_KnowledgesClsMasterENT = new clsge_KnowledgesClsMasterENEx();
                clsge_KnowledgesClsMasterBL.ge_KnowledgesClsMasterDA.CopyTo(objge_KnowledgesClsMasterENS, objge_KnowledgesClsMasterENT);
                return objge_KnowledgesClsMasterENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objge_KnowledgesClsMasterENS">源对象</param>
        /// <returns>目标对象=>clsge_KnowledgesClsMasterEN:objge_KnowledgesClsMasterENT</returns>
        public static clsge_KnowledgesClsMasterEN CopyTo(this clsge_KnowledgesClsMasterENEx objge_KnowledgesClsMasterENS)
        {
            try
            {
                clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterENT = new clsge_KnowledgesClsMasterEN();
                clsge_KnowledgesClsMasterBL.CopyTo(objge_KnowledgesClsMasterENS, objge_KnowledgesClsMasterENT);
                return objge_KnowledgesClsMasterENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 知识点教学班掌握度(ge_KnowledgesClsMaster)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsge_KnowledgesClsMasterBLEx : clsge_KnowledgesClsMasterBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsge_KnowledgesClsMasterDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsge_KnowledgesClsMasterDAEx ge_KnowledgesClsMasterDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsge_KnowledgesClsMasterDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objge_KnowledgesClsMasterENS">源对象</param>
        /// <returns>目标对象=>clsge_KnowledgesClsMasterEN:objge_KnowledgesClsMasterENT</returns>
        public static clsge_KnowledgesClsMasterENEx CopyToEx(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterENS)
        {
            try
            {
                clsge_KnowledgesClsMasterENEx objge_KnowledgesClsMasterENT = new clsge_KnowledgesClsMasterENEx();
                clsge_KnowledgesClsMasterBL.ge_KnowledgesClsMasterDA.CopyTo(objge_KnowledgesClsMasterENS, objge_KnowledgesClsMasterENT);
                return objge_KnowledgesClsMasterENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
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
        public static List<clsge_KnowledgesClsMasterENEx> GetObjExLst(string strCondition)
        {
            List<clsge_KnowledgesClsMasterEN> arrObjLst = clsge_KnowledgesClsMasterBL.GetObjLst(strCondition);
            List<clsge_KnowledgesClsMasterENEx> arrObjExLst = new List<clsge_KnowledgesClsMasterENEx>();
            foreach (clsge_KnowledgesClsMasterEN objInFor in arrObjLst)
            {
                clsge_KnowledgesClsMasterENEx objge_KnowledgesClsMasterENEx = new clsge_KnowledgesClsMasterENEx();
                clsge_KnowledgesClsMasterBL.CopyTo(objInFor, objge_KnowledgesClsMasterENEx);
                arrObjExLst.Add(objge_KnowledgesClsMasterENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strIdCurrEduCls">表关键字</param>
        /// <param name = "strCourseKnowledgeId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsge_KnowledgesClsMasterENEx GetObjExByKeyLst(string strIdCurrEduCls, string strCourseKnowledgeId)
        {
            clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = clsge_KnowledgesClsMasterBL.GetObjByKeyLst(strIdCurrEduCls, strCourseKnowledgeId);
            clsge_KnowledgesClsMasterENEx objge_KnowledgesClsMasterENEx = new clsge_KnowledgesClsMasterENEx();
            clsge_KnowledgesClsMasterBL.CopyTo(objge_KnowledgesClsMasterEN, objge_KnowledgesClsMasterENEx);
            return objge_KnowledgesClsMasterENEx;
        }

        /// <summary>
        /// 计算教学班每个知识点的掌握度
        /// </summary>
        /// <param name="strIdCurrEduCls"></param>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int CalcKnowledgesClsMaster(string strIdCurrEduCls)
        {
            //获取用户回答结果数据源
            var objCurrEduCls = clsCurrEduClsBL.GetObjByIdCurrEduCls(strIdCurrEduCls);
            string CourseId = objCurrEduCls.CourseId;
            string strWhere = $"{conge_KnowledgesUserMaster.UserId} in (select StuId From {convCurrEduClsStu._CurrTabName} where {convCurrEduClsStu.IdCurrEduCls} = '{strIdCurrEduCls}') " +
                $" And {conge_KnowledgesUserMaster.CourseId}='{CourseId}'";
            List<clsge_KnowledgesUserMasterEN> arrge_KnowledgesUserMasterList = clsge_KnowledgesUserMasterBL.GetObjLst(strWhere);
         
            List<string> arrCourseKnowledgeId = arrge_KnowledgesUserMasterList.Select(x => x.CourseKnowledgeId)
                .Distinct()
                .ToList();
            try
            {
                //循环知识点
                foreach (string strCourseKnowledgeId in arrCourseKnowledgeId)
                {
                    var dblMasteryValue_Cls = arrge_KnowledgesUserMasterList
                        .Where(x => x.CourseKnowledgeId == strCourseKnowledgeId)
                        .Average(x => x.MasteryValue) ?? 0.0;
                    //得到掌握等级；
                    string MasterLevelId = clsKnowledgeMasterLevelBLEx.GetMasteryLevelId(dblMasteryValue_Cls);

                    //8知识点数据掌握表导入； 先查询该用户知识点掌握表数据是否存在，存在则修改，不存在则添加；
                    string strWhereKnowledgesUserMaster = $" {conge_KnowledgesClsMaster.IdCurrEduCls} ='{strIdCurrEduCls}' " +
                    $" And CourseKnowledgeId='" + strCourseKnowledgeId + "'";
                    clsge_KnowledgesClsMasterEN objge_KnowledgesClsMaster = clsge_KnowledgesClsMasterBL.GetFirstObj_S(strWhereKnowledgesUserMaster);
                    if (objge_KnowledgesClsMaster != null)
                    {
                        objge_KnowledgesClsMaster.MasteryValue = dblMasteryValue_Cls;
                        objge_KnowledgesClsMaster.MasterLevelId = MasterLevelId;
                        objge_KnowledgesClsMaster.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objge_KnowledgesClsMaster.UpdUser = "SysCalc";
                        clsge_KnowledgesClsMasterBL.UpdateBySql2(objge_KnowledgesClsMaster);
                    }
                    else
                    {
                        clsge_KnowledgesClsMasterEN objNew = new clsge_KnowledgesClsMasterEN();

                        objNew.CourseId = CourseId;
                        objNew.IdCurrEduCls = strIdCurrEduCls;
                        objNew.CourseKnowledgeId = strCourseKnowledgeId;
                        objNew.MasteryValue = dblMasteryValue_Cls;
                        objNew.MasterLevelId = MasterLevelId;
                        objNew.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objNew.UpdUser = "SysCalc";
                        clsge_KnowledgesClsMasterBL.AddNewRecordBySql2(objNew);
                    }

                    
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID获取出错:[{0}]。{1}. (In {2})",
                CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            return arrCourseKnowledgeId.Count;
        }

    }
}