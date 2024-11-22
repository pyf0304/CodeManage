
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_UserCreditsLogBLEx
表名:ge_UserCreditsLog(01120883)
生成代码版本:2021.02.21.1
生成日期:2021/02/24 18:51:00
生成者:yy
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:游戏化学习
模块英文名:GameLearn
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
using com.taishsoft.datetime;

namespace ExamLib.BusinessLogicEx
{
    public static class clsge_UserCreditsLogBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objge_UserCreditsLogENS">源对象</param>
        /// <returns>目标对象=>clsge_UserCreditsLogEN:objge_UserCreditsLogENT</returns>
        public static clsge_UserCreditsLogENEx CopyToEx(this clsge_UserCreditsLogEN objge_UserCreditsLogENS)
        {
            try
            {
                clsge_UserCreditsLogENEx objge_UserCreditsLogENT = new clsge_UserCreditsLogENEx();
                clsge_UserCreditsLogBL.ge_UserCreditsLogDA.CopyTo(objge_UserCreditsLogENS, objge_UserCreditsLogENT);
                return objge_UserCreditsLogENT;
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
        /// <param name = "objge_UserCreditsLogENS">源对象</param>
        /// <returns>目标对象=>clsge_UserCreditsLogEN:objge_UserCreditsLogENT</returns>
        public static clsge_UserCreditsLogEN CopyTo(this clsge_UserCreditsLogENEx objge_UserCreditsLogENS)
        {
            try
            {
                clsge_UserCreditsLogEN objge_UserCreditsLogENT = new clsge_UserCreditsLogEN();
                clsge_UserCreditsLogBL.CopyTo(objge_UserCreditsLogENS, objge_UserCreditsLogENT);
                return objge_UserCreditsLogENT;
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
    /// 用户积分日志(ge_UserCreditsLog)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsge_UserCreditsLogBLEx : clsge_UserCreditsLogBL
    {
        #region 生成

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsge_UserCreditsLogDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsge_UserCreditsLogDAEx ge_UserCreditsLogDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsge_UserCreditsLogDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objge_UserCreditsLogENS">源对象</param>
        /// <returns>目标对象=>clsge_UserCreditsLogEN:objge_UserCreditsLogENT</returns>
        public static clsge_UserCreditsLogENEx CopyToEx(clsge_UserCreditsLogEN objge_UserCreditsLogENS)
        {
            try
            {
                clsge_UserCreditsLogENEx objge_UserCreditsLogENT = new clsge_UserCreditsLogENEx();
                clsge_UserCreditsLogBL.ge_UserCreditsLogDA.CopyTo(objge_UserCreditsLogENS, objge_UserCreditsLogENT);
                return objge_UserCreditsLogENT;
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
        public static List<clsge_UserCreditsLogENEx> GetObjExLst(string strCondition)
        {
            List<clsge_UserCreditsLogEN> arrObjLst = clsge_UserCreditsLogBL.GetObjLst(strCondition);
            List<clsge_UserCreditsLogENEx> arrObjExLst = new List<clsge_UserCreditsLogENEx>();
            foreach (clsge_UserCreditsLogEN objInFor in arrObjLst)
            {
                clsge_UserCreditsLogENEx objge_UserCreditsLogENEx = new clsge_UserCreditsLogENEx();
                clsge_UserCreditsLogBL.CopyTo(objInFor, objge_UserCreditsLogENEx);
                arrObjExLst.Add(objge_UserCreditsLogENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsge_UserCreditsLogENEx GetObjExBymId(long lngmId)
        {
            clsge_UserCreditsLogEN objge_UserCreditsLogEN = clsge_UserCreditsLogBL.GetObjBymId(lngmId);
            clsge_UserCreditsLogENEx objge_UserCreditsLogENEx = new clsge_UserCreditsLogENEx();
            clsge_UserCreditsLogBL.CopyTo(objge_UserCreditsLogEN, objge_UserCreditsLogENEx);
            return objge_UserCreditsLogENEx;
        }

        #endregion




        /// <summary>
        /// 根据条件获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static List<clsge_UserCreditsLogEN> Getge_UserCreditsObjLstEx(string strUserId, string stridCurrEduCls)
        {
            List<clsge_UserCreditsLogEN> arrObjLst = new List<clsge_UserCreditsLogEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTableEx(strUserId, stridCurrEduCls);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsge_UserCreditsLogEN objge_UserCreditsLogEN = new clsge_UserCreditsLogEN();
                try
                {
                    // objge_UserCreditsLogEN.mId = clsEntityBase2.TransNullToInt_S(objRow[conge_UserCreditsLog.mId].ToString().Trim()); //mId
                    objge_UserCreditsLogEN.UserId = objRow[conge_UserCreditsLog.UserId].ToString().Trim(); //用户ID
                    objge_UserCreditsLogEN.GameLevelId = objRow[conge_UserCreditsLog.GameLevelId].ToString().Trim(); //学习关号
                    objge_UserCreditsLogEN.Credits = clsEntityBase2.TransNullToInt_S(objRow[conge_UserCreditsLog.Credits].ToString().Trim()); //积分
                                                                                                                                              //  objge_UserCreditsLogEN.GetInstructions = objRow[conge_UserCreditsLog.GetInstructions].ToString().Trim(); //获取说明
                                                                                                                                              //   objge_UserCreditsLogEN.GetDate = objRow[conge_UserCreditsLog.GetDate].ToString().Trim(); //获取日期
                    objge_UserCreditsLogEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserCreditsLog.Passed].ToString().Trim()); //是否合格
                    objge_UserCreditsLogEN.IdCurrEduCls = objRow[conge_UserCreditsLog.IdCurrEduCls].ToString().Trim(); //当前教学班流水号
                                                                                                                       //    objge_UserCreditsLogEN.UpdDate = objRow[conge_UserCreditsLog.UpdDate].ToString().Trim(); //修改日期
                                                                                                                       //    objge_UserCreditsLogEN.UpdUser = objRow[conge_UserCreditsLog.UpdUser].ToString().Trim(); //修改人
                                                                                                                       //    objge_UserCreditsLogEN.Memo = objRow[conge_UserCreditsLog.Memo].ToString().Trim(); //备注
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objge_UserCreditsLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objge_UserCreditsLogEN);
            }
            objDT = null;
            return arrObjLst;
        }
        public static List<clsge_UserCreditsLogEN> GetObjLstByIdCurrEduClsEx(string stridCurrEduCls)
        {
            List<clsge_UserCreditsLogEN> arrObjLst = new List<clsge_UserCreditsLogEN>();

            string strCondition = string.Format("{0}='{1}'", conge_UserCreditsLog.IdCurrEduCls, stridCurrEduCls);
            arrObjLst = clsge_UserCreditsLogBL.GetObjLst(strCondition);

            return arrObjLst;
        }




        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回数据表,用DataTable表示</returns>
        public static DataTable GetDataTableEx(string strUserId, string stridCurrEduCls)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsge_UserCreditsLogDAEx.GetDataTableEx(strUserId, stridCurrEduCls);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})", strUserId + stridCurrEduCls,
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }








        /// <summary>
        ///   获取用户每关总分排名的方法
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static List<clsge_UserCreditsLogEN> Getge_UserCreditsRankLstEx(string stridCurrEduCls)
        {
            List<clsge_UserCreditsLogEN> arrObjLst = new List<clsge_UserCreditsLogEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTableByWhere(stridCurrEduCls);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsge_UserCreditsLogEN objge_UserCreditsLogEN = new clsge_UserCreditsLogEN();
                try
                {
                    // objge_UserCreditsLogEN.mId = clsEntityBase2.TransNullToInt_S(objRow[conge_UserCreditsLog.mId].ToString().Trim()); //mId
                    objge_UserCreditsLogEN.UserId = objRow[conge_UserCreditsLog.UserId].ToString().Trim(); //用户ID
                    objge_UserCreditsLogEN.GameLevelId = objRow[conge_UserCreditsLog.GameLevelId].ToString().Trim(); //学习关号
                    objge_UserCreditsLogEN.Credits = clsEntityBase2.TransNullToInt_S(objRow[conge_UserCreditsLog.Credits].ToString().Trim()); //积分
                    //objge_UserCreditsLogEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserCreditsLog.Passed].ToString().Trim()); //是否合格
                    objge_UserCreditsLogEN.CourseId = objRow[conge_UserCreditsLog.CourseId].ToString().Trim(); //获取日期
                    objge_UserCreditsLogEN.IdCurrEduCls = objRow[conge_UserCreditsLog.IdCurrEduCls].ToString().Trim(); //当前教学班流水号
                                                                                                                       //    objge_UserCreditsLogEN.UpdDate = objRow[conge_UserCreditsLog.UpdDate].ToString().Trim(); //修改日期
                                                                                                                       //    objge_UserCreditsLogEN.UpdUser = objRow[conge_UserCreditsLog.UpdUser].ToString().Trim(); //修改人
                                                                                                                       //    objge_UserCreditsLogEN.Memo = objRow[conge_UserCreditsLog.Memo].ToString().Trim(); //备注
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objge_UserCreditsLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objge_UserCreditsLogEN);
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
        public static DataTable GetDataTableByWhere(string strWhere)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsge_UserCreditsLogDAEx.GetDataTableByWhere(strWhere);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})", strWhere,
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 汇总每个教学班用户的积分
        /// </summary>
        /// <param name="strIdCurrEduCls"></param>
        /// <param name="strOpUser"></param>
        /// <returns></returns>
        public static bool CalcCreditLog(string strIdCurrEduCls, string strOpUser)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            //clsge_UserCreditsLogBLEx.CalcUserLevelScore(strIdCurrEduCls, strOpUser);

            string strCondition0 = string.Format("{0}='{1}'", conge_StuBatchQuesRela.IdCurrEduCls, strIdCurrEduCls);
            var arrge_StuBatchQuesRela = clsge_StuBatchQuesRelaBL.GetObjLst(strCondition0);

            var arrge_StuBatchQuesRela_Group = arrge_StuBatchQuesRela.GroupBy(x => new { x.UserId, x.GameLevelId, x.ExamBatchNo }).ToList();

            foreach (var list in arrge_StuBatchQuesRela_Group)
            {
                Console.WriteLine(list.Key + ":");
                foreach (var objInfor in list)
                {

                    double fltCredits = list.Sum(x => x.Score ?? 0);
                    bool bolIsPassed = clsge_GameLevelBLEx.IsPassed(fltCredits, objInfor.GameLevelId, objInfor.CourseId);

                    clsge_UserCreditsLogEN objge_UserCreditsLog = new clsge_UserCreditsLogEN();
                    objge_UserCreditsLog.IdCurrEduCls = strIdCurrEduCls;
                    objge_UserCreditsLog.UserId = objInfor.UserId;
                    objge_UserCreditsLog.GameLevelId = objInfor.GameLevelId;
                    objge_UserCreditsLog.ExamBatchNo = objInfor.ExamBatchNo;

                    objge_UserCreditsLog.CourseId = objInfor.CourseId;
                    objge_UserCreditsLog.Credits = (int)fltCredits;
                    objge_UserCreditsLog.Passed = bolIsPassed;
                    //objge_UserCreditsLog.CourseChapterId = objge_GameLevel.cou.
                    objge_UserCreditsLog.UpdDate = strCurrDate;
                    objge_UserCreditsLog.UpdUser = strOpUser;
                    string strCondition = objge_UserCreditsLog.GetUniCondStr();
                    if (clsge_UserCreditsLogBL.IsExistRecord(strCondition) == false)
                    {
                        objge_UserCreditsLog.AddNewRecord();
                    }
                    else
                    {
                        objge_UserCreditsLog.UpdateWithCondition(strCondition);
                    }
                }
            }

            return true;
        }


        public static bool CalcCreditLogByUserId(string strIdCurrEduCls,
            string strGameLevelId, string strExamBatchNo, string strUserId, string strOpUser)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            //clsge_UserCreditsLogBLEx.CalcUserLevelScoreByUserId(strIdCurrEduCls, strUserId, strOpUser);
            if (strGameLevelId == "") throw new Exception("所给strGameLevelId为空，请检查！");
            string strCondition0 = string.Format("{0}='{1}'", conge_StuBatchQuesRela.IdCurrEduCls, strIdCurrEduCls);
            strCondition0 += string.Format(" and {0}='{1}'", conge_StuBatchQuesRela.GameLevelId, strGameLevelId);
            strCondition0 += string.Format(" and {0}='{1}'", conge_StuBatchQuesRela.ExamBatchNo, strExamBatchNo);
            strCondition0 += string.Format(" and {0}='{1}'", conge_StuBatchQuesRela.UserId, strUserId);
            var arrge_StuBatchQuesRela = clsge_StuBatchQuesRelaBL.GetObjLst(strCondition0);

            //var arrge_StuBatchQuesRela_Group = arrge_StuBatchQuesRela.GroupBy(x => new { x.UserId, x.GameLevelId, x.ExamBatchNo }).ToList();
            if (arrge_StuBatchQuesRela.Count == 0) throw new Exception($"所给strGameLevelId:{strGameLevelId}, 批次:{strExamBatchNo}所做题为空，请检查！");

            double fltCredits = arrge_StuBatchQuesRela.Sum(x => x.Score ?? 0);
            string strCourseId = arrge_StuBatchQuesRela[0].CourseId;
            bool bolIsPassed = clsge_GameLevelBLEx.IsPassed(fltCredits, strGameLevelId, strCourseId);

            clsge_UserCreditsLogEN objge_UserCreditsLog = new clsge_UserCreditsLogEN();
            objge_UserCreditsLog.IdCurrEduCls = strIdCurrEduCls;
            objge_UserCreditsLog.UserId = strUserId;
            objge_UserCreditsLog.GameLevelId = strGameLevelId;
            objge_UserCreditsLog.ExamBatchNo = strExamBatchNo;
            objge_UserCreditsLog.CourseId = strCourseId;
            objge_UserCreditsLog.Credits = (int)fltCredits;
            objge_UserCreditsLog.Passed = bolIsPassed;
            objge_UserCreditsLog.UpdDate = strCurrDate;
            objge_UserCreditsLog.UpdUser = strOpUser;
            string strCondition = objge_UserCreditsLog.GetUniCondStr();
            if (clsge_UserCreditsLogBL.IsExistRecord(strCondition) == false)
            {
                objge_UserCreditsLog.AddNewRecord();
            }
            else
            {
                objge_UserCreditsLog.UpdateWithCondition(strCondition);
            }

            return true;
        }



        //3.根据问题ID 和批次号 查询学生问题批次表；获取闯关关卡号；、然后根据参数把用户得分数据存入到闯关纪录日志表；
        public static bool Addge_UserCreditsLog(string strGameLevelId, string strExamBatchNo, bool bolIsSubmit, string UserId, string IdCurrEduCls)
        {

            try
            {
                clsge_UserCreditsLogBLEx.CalcCreditLogByUserId(IdCurrEduCls, strGameLevelId, strExamBatchNo, UserId, UserId);
                clsge_UserLevelScoreBLEx.CalcUserLevelScoreByGameLevelIdUserId(IdCurrEduCls, strGameLevelId, UserId, UserId);
                clsge_UserCreditsTtlBLEx.CalcCreditTtlByUserId(IdCurrEduCls, UserId, UserId);

                if (bolIsSubmit == true)
                {
                    clsge_StuBatchQuesRelaBLEx.Submit_ge_StuBatchQuesRela(UserId, strExamBatchNo);
                }
                return true;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("批次添加用户积分日志出错:[{0}]。{1}. (In {2})",
                strExamBatchNo, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //return true;
        }

        public static bool Addge_UserCreditsLog_Marker(string strGameLevelId, string strExamBatchNo, bool bolIsSubmit, string UserId, string IdCurrEduCls)
        {
            try
            {

                clsge_UserCreditsLogBLEx.CalcCreditLogByUserId(IdCurrEduCls, strGameLevelId, strExamBatchNo, UserId, UserId);
                clsge_UserLevelScoreBLEx.CalcUserLevelScoreByGameLevelIdUserId( IdCurrEduCls, strGameLevelId, UserId, UserId);
                clsge_UserCreditsTtlBLEx.CalcCreditTtlByUserId(IdCurrEduCls, UserId, UserId);
                if (bolIsSubmit == true)
                {
                    clsge_StuBatchQuesRelaBLEx.Submit_ge_StuBatchQuesRela(UserId, strExamBatchNo);
                }
                return true;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("用户批次日志添加出错:[{0}]。{1}. (In {2})",
                strExamBatchNo, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //return true;
        }


    }
}
