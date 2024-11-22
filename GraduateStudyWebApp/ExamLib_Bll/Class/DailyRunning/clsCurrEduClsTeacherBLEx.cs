
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCurrEduClsTeacherBLEx
表名:CurrEduClsTeacher(01120124)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 14:52:00
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:日常运行
模块英文名:DailyRunning
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
    public static class clsCurrEduClsTeacherBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCurrEduClsTeacherENS">源对象</param>
        /// <returns>目标对象=>clsCurrEduClsTeacherEN:objCurrEduClsTeacherENT</returns>
        public static clsCurrEduClsTeacherENEx CopyToEx(this clsCurrEduClsTeacherEN objCurrEduClsTeacherENS)
        {
            try
            {
                clsCurrEduClsTeacherENEx objCurrEduClsTeacherENT = new clsCurrEduClsTeacherENEx();
                clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.CopyTo(objCurrEduClsTeacherENS, objCurrEduClsTeacherENT);
                return objCurrEduClsTeacherENT;
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
        /// <param name = "objCurrEduClsTeacherENS">源对象</param>
        /// <returns>目标对象=>clsCurrEduClsTeacherEN:objCurrEduClsTeacherENT</returns>
        public static clsCurrEduClsTeacherEN CopyTo(this clsCurrEduClsTeacherENEx objCurrEduClsTeacherENS)
        {
            try
            {
                clsCurrEduClsTeacherEN objCurrEduClsTeacherENT = new clsCurrEduClsTeacherEN();
                clsCurrEduClsTeacherBL.CopyTo(objCurrEduClsTeacherENS, objCurrEduClsTeacherENT);
                return objCurrEduClsTeacherENT;
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
    /// 当前教学班教师(CurrEduClsTeacher)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCurrEduClsTeacherBLEx : clsCurrEduClsTeacherBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCurrEduClsTeacherDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCurrEduClsTeacherDAEx CurrEduClsTeacherDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCurrEduClsTeacherDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objCurrEduClsTeacherENS">源对象</param>
        /// <returns>目标对象=>clsCurrEduClsTeacherEN:objCurrEduClsTeacherENT</returns>
        public static clsCurrEduClsTeacherENEx CopyToEx(clsCurrEduClsTeacherEN objCurrEduClsTeacherENS)
        {
            try
            {
                clsCurrEduClsTeacherENEx objCurrEduClsTeacherENT = new clsCurrEduClsTeacherENEx();
                clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.CopyTo(objCurrEduClsTeacherENS, objCurrEduClsTeacherENT);
                return objCurrEduClsTeacherENT;
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
        public static List<clsCurrEduClsTeacherENEx> GetObjExLst(string strCondition)
        {
            List<clsCurrEduClsTeacherEN> arrObjLst = clsCurrEduClsTeacherBL.GetObjLst(strCondition);
            List<clsCurrEduClsTeacherENEx> arrObjExLst = new List<clsCurrEduClsTeacherENEx>();
            foreach (clsCurrEduClsTeacherEN objInFor in arrObjLst)
            {
                clsCurrEduClsTeacherENEx objCurrEduClsTeacherENEx = new clsCurrEduClsTeacherENEx();
                clsCurrEduClsTeacherBL.CopyTo(objInFor, objCurrEduClsTeacherENEx);
                arrObjExLst.Add(objCurrEduClsTeacherENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngid_EduClsTeacher">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCurrEduClsTeacherENEx GetObjExByid_EduClsTeacher(long lngid_EduClsTeacher)
        {
            clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = clsCurrEduClsTeacherBL.GetObjByIdEduClsTeacher(lngid_EduClsTeacher);
            clsCurrEduClsTeacherENEx objCurrEduClsTeacherENEx = new clsCurrEduClsTeacherENEx();
            clsCurrEduClsTeacherBL.CopyTo(objCurrEduClsTeacherEN, objCurrEduClsTeacherENEx);
            return objCurrEduClsTeacherENEx;
        }

        /// <summary>
        /// 根据学生Id获取教学班流水号列表
        /// </summary>
        /// <param name="strTeacherId">学号</param>
        /// <returns>教学班流水号列表</returns>
        public static List<string> GetidCurrEduClsListByTeacherId(string strTeacherId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}' And {2}='1'",
                convCurrEduClsTeacher.TeacherId, strTeacherId,
                convCurrEduClsTeacher.IsEffective);
            return clsvCurrEduClsTeacherBL.GetFldValue(convCurrEduClsTeacher.IdCurrEduCls, sbCondition.ToString());
        }

        /// <summary>
        /// 根据工号获取教学班教师对象列表
        /// </summary>
        /// <param name="strTeacherId">学号</param>
        /// <returns>教学班教师对象列表</returns>
        public static List<clsCurrEduClsTeacherEN> GetObjListByTeacherId(string strTeacherId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} in (Select {0} from {1} Where {2}='{3}') ",
                conCurrEduClsTeacher.IdTeacher, 
                conTeacherInfo._CurrTabName, conTeacherInfo.TeacherId, strTeacherId);
            var arrCurrEduClsTeacher = clsCurrEduClsTeacherBL.GetObjLst(sbCondition.ToString());
            return arrCurrEduClsTeacher;
        }

        /// <summary>
        /// 根据教学班流水号获取教师Id列表
        /// </summary>
        /// <param name="strIdCurrEduCls">教学班流水号</param>
        /// <returns>教师Id列表</returns>
        public static List<string> GetTeacherIdLstByIdCurrEduCls(string strIdCurrEduCls)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}'",
                convCurrEduClsTeacher.IdCurrEduCls, strIdCurrEduCls);
            return clsvCurrEduClsTeacherBL.GetFldValue(convCurrEduClsTeacher.TeacherId, sbCondition.ToString());
        }

        /// <summary>
        /// 根据学生流水号获取教学班流水号列表
        /// </summary>
        /// <param name="strId_Teacher">学号</param>
        /// <returns>教学班流水号列表</returns>
        public static List<string> GetidCurrEduClsListById_Teacher(string strId_Teacher)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}'",
                conCurrEduClsTeacher.IdTeacher, strId_Teacher);
            return clsCurrEduClsTeacherBL.GetFldValue(conCurrEduClsTeacher.IdCurrEduCls, sbCondition.ToString());
        }


    }
}