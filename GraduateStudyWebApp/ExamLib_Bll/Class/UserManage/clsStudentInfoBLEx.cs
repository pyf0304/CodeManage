using com.taishsoft.commdb;
using ExamLib.DAL;
using ExamLib.Entity;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExamLib.BusinessLogic;
using GeneralPlatform.Entity;
using System.Data;


namespace ExamLib.BusinessLogicEx
{
    public class clsStudentInfoBLEx
    {
        /// <summary>
        /// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        /// </summary>
        public static List<clsStudentInfoEN> arrStudentInfoObjLstOrderByStuId_Cache = null;

        /// <summary>
        /// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        /// </summary>
        public static List<clsStudentInfoEN> arrStudentInfoObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        private static int intFindFailCount = 0;
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strIdStu">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsStudentInfoEN GetStudentInfoObjByStuId_CacheEx(string strStuId)
        {
            if (string.IsNullOrEmpty(strStuId) == true)
            {
                return null;
            }
            string strCondition = string.Format("1=1 order by StuId");
            if (arrStudentInfoObjLstOrderByStuId_Cache == null)
            {
                arrStudentInfoObjLstOrderByStuId_Cache = new clsStudentInfoDA().GetObjLst(strCondition);
            }
            int intStart = 0;
            int intEnd = arrStudentInfoObjLstOrderByStuId_Cache.Count - 1;
            int intMid = 0;
            clsStudentInfoEN objStudentInfoEN = null;
            while (intEnd >= intStart)
            {
                intMid = (intStart + intEnd) / 2;
                objStudentInfoEN = arrStudentInfoObjLstOrderByStuId_Cache[intMid];
                if (objStudentInfoEN.StuId == strStuId)
                {
                    intFindFailCount = 0;
                    return objStudentInfoEN;
                }
                else if (objStudentInfoEN.StuId.CompareTo(strStuId) > 0)
                {
                    intEnd = intMid - 1;
                }
                else
                {
                    intStart = intMid + 1;
                }
            }
            intFindFailCount++;
            // 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
            arrStudentInfoObjLstOrderByStuId_Cache = null;
            if (intFindFailCount == 1) return GetStudentInfoObjByStuId_CacheEx(strStuId);
            string strErrMsgForGetObjById = string.Format("在StudentInfo对象缓存列表中，找不到记录[StuId={0}][intFindFailCount={1}](函数:GetStudentInfoObjByStuId_CacheEx)", strStuId, intFindFailCount);
            if (objStudentInfoEN != null)
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid={1}]", objStudentInfoEN.StuId, intMid);
            }
            else
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查！[intMid={0}]", intMid);
            }
            clsGeneralTab2.LogErrorS2("clsStudentInfoBL", "GetStudentInfoObjByStuId_CacheEx", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }


        /// <summary>
        /// 根据工号获取相关学院流水号
        /// </summary>
        /// <param name="strStuId">工号</param>
        /// <returns>返回IdXzCollege</returns>
        public static string GetId_CollegeByStuId_CacheEx(string strStuId)
        {
            clsStudentInfoEN objStudentInfoEN = GetStudentInfoObjByStuId_CacheEx(strStuId);
            return objStudentInfoEN.IdXzCollege;
        }

        /// <summary>
        /// 根据工号获取相关教师流水号
        /// </summary>
        /// <param name="strStuId">工号</param>
        /// <returns>返回IdStu</returns>
        public static string Getid_StuByStuId_CacheEx(string strStuId)
        {
            clsStudentInfoEN objStudentInfoEN = GetStudentInfoObjByStuId_CacheEx(strStuId);
            return objStudentInfoEN.IdStudentInfo;
        }

        /// <summary>
        /// 同步一个用户对象到学生对象
        /// </summary>
        /// <param name="objUsersEN">用户对象</param>
        /// <param name="strOpUserId">操作用户Id</param>
        /// <returns>学生对象(clsStudentInfoEN)</returns>
        public static clsStudentInfoEN SynchUsersToStudent(clsUsersEN objUsersEN)
        {
            string strCondition = string.Format("{0}='{1}'", conStudentInfo.StuId, objUsersEN.UserId);
            clsStudentInfoEN objStudentInfoEN = clsStudentInfoBL.GetFirstObj_S(strCondition);
            if (objStudentInfoEN != null) return objStudentInfoEN;
            objStudentInfoEN = new clsStudentInfoEN();
            objStudentInfoEN.IdStudentInfo = clsStudentInfoBL.GetMaxStrId_S();
            objStudentInfoEN.StuId = objUsersEN.UserId;
            objStudentInfoEN.StuName = objUsersEN.UserName;
            objStudentInfoEN.IdXzCollege = objUsersEN.IdXzCollege;
            objStudentInfoEN.IdXzMajor = objUsersEN.IdXzMajor;
            objStudentInfoEN.IdGradeBase = objUsersEN.IdGradeBase;
            objStudentInfoEN.IdGrade = objUsersEN.IdGrade;
            var objQxUserIdentity = clsQxUserIdentityBL.GetObjByIdentityIdCache(objUsersEN.IdentityId);
            objStudentInfoEN.UserType = objQxUserIdentity.UserType;

            objStudentInfoEN.RegisterPassword = objUsersEN.Password;

            objStudentInfoEN.UpdDate = objUsersEN.UpdDate;
            objStudentInfoEN.UpdUser = objUsersEN.UpdUser;
            clsStudentInfoBL.AddNewRecordBySql2(objStudentInfoEN);


            return objStudentInfoEN;
        }


        //判断学生表中当前用户是否存在
        public static bool GetStuID(string UserId)
        {
            bool bolIsExist = clsStudentInfoBL.IsExistRecord("StuId='" + UserId + "'");
            return bolIsExist;
        }

        /// <summary>
        /// 功能：同时删除多条记录
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <returns>返回删除是否成功?</returns>
        public static bool DelStudentInfoEx(List<string> lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsStudentInfoDA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //删除StudentInfo本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from GeneralQuality where IdStudentInfo in (" + strKeyList + ")";
            strSQL = strSQL + "Delete from PracticeScore where IdStudentInfo in (" + strKeyList + ")";
            strSQL = strSQL + "Delete from 	cc_WorkStuRelation where IdStudentInfo in (" + strKeyList + ")";
            strSQL = strSQL + $"Delete from {concc_ExamPaperStuRelation._CurrTabName} where {concc_ExamPaperStuRelation.IdStudentInfo} in (" + strKeyList + ")";
            strSQL = strSQL + "Delete from StudentInfo where IdStudentInfo in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }
    }
}
