
using com.taishsoft.commdb;
using com.taishsoft.common;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ExamLib.BusinessLogicEx
{
    public static class clsTeacherInfoBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objTeacherInfoENS">源对象</param>
        /// <returns>目标对象=>clsTeacherInfoEN:objTeacherInfoENT</returns>
        public static clsTeacherInfoENEx CopyToEx(this clsTeacherInfoEN objTeacherInfoENS)
        {
            try
            {
                clsTeacherInfoENEx objTeacherInfoENT = new clsTeacherInfoENEx();
                clsTeacherInfoBL.TeacherInfoDA.CopyTo(objTeacherInfoENS, objTeacherInfoENT);
                return objTeacherInfoENT;
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
        /// <param name = "objTeacherInfoENS">源对象</param>
        /// <returns>目标对象=>clsTeacherInfoEN:objTeacherInfoENT</returns>
        public static clsTeacherInfoEN CopyTo(this clsTeacherInfoENEx objTeacherInfoENS)
        {
            try
            {
                clsTeacherInfoEN objTeacherInfoENT = new clsTeacherInfoEN();
                clsTeacherInfoBL.CopyTo(objTeacherInfoENS, objTeacherInfoENT);
                return objTeacherInfoENT;
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
    /// 教师(TeacherInfo)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsTeacherInfoBLEx : clsTeacherInfoBL
    {
        protected static int intFindFailCount = 0;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsTeacherInfoDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsTeacherInfoDAEx TeacherInfoDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsTeacherInfoDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objTeacherInfoENS">源对象</param>
        /// <returns>目标对象=>clsTeacherInfoEN:objTeacherInfoENT</returns>
        public static clsTeacherInfoENEx CopyToEx(clsTeacherInfoEN objTeacherInfoENS)
        {
            try
            {
                clsTeacherInfoENEx objTeacherInfoENT = new clsTeacherInfoENEx();
                clsTeacherInfoBL.TeacherInfoDA.CopyTo(objTeacherInfoENS, objTeacherInfoENT);
                return objTeacherInfoENT;
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
        public static List<clsTeacherInfoENEx> GetObjExLst(string strCondition)
        {
            List<clsTeacherInfoEN> arrObjLst = clsTeacherInfoBL.GetObjLst(strCondition);
            List<clsTeacherInfoENEx> arrObjExLst = new List<clsTeacherInfoENEx>();
            foreach (clsTeacherInfoEN objInFor in arrObjLst)
            {
                clsTeacherInfoENEx objTeacherInfoENEx = new clsTeacherInfoENEx();
                clsTeacherInfoBL.CopyTo(objInFor, objTeacherInfoENEx);
                arrObjExLst.Add(objTeacherInfoENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strIdTeacher">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsTeacherInfoENEx GetObjExByIdTeacher(string strIdTeacher)
        {
            clsTeacherInfoEN objTeacherInfoEN = clsTeacherInfoBL.GetObjByIdTeacher(strIdTeacher);
            clsTeacherInfoENEx objTeacherInfoENEx = new clsTeacherInfoENEx();
            clsTeacherInfoBL.CopyTo(objTeacherInfoEN, objTeacherInfoENEx);
            return objTeacherInfoENEx;
        }

        /// <summary>
        /// 学位表, 从缓存的对象列表中获取.2015-08-10
        /// </summary>
        /// <param name="strid_Ethnic">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsTeacherInfoEN GetObjByTeacherName_Cache(string strTeacherName)
        {
            string strTeacherNameP = strTeacherName.Replace("*", "").Trim();
            var arrTeacherInfoObjLstOrderByTeacherId_Cache = clsTeacherInfoBL.GetObjLst("1=1");
            foreach (clsTeacherInfoEN objTeacherInfoEN in arrTeacherInfoObjLstOrderByTeacherId_Cache)
            {
                if (objTeacherInfoEN.TeacherName == strTeacherNameP)
                {
                    return objTeacherInfoEN; //缓存取ID
                }
            }
            return null;
        }




        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strIdTeacher">表关键字</param>
        /// <returns></returns>
        public static new bool DelRecordEx(string strIdTeacher)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsTeacherInfoDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[TeacherInfo]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conTeacherInfo.IdTeacher,
                //strIdTeacher);
                //        clsTeacherInfoBL.DelTeacherInfosByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsTeacherInfoBL.DelRecord(strIdTeacher, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTeacherInfoBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strIdTeacher, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }



        ///// <summary>
        ///// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        ///// </summary>
        //public static List<clsTeacherInfoEN> arrTeacherInfoObjLst_Cache = null;
        ///// <summary>
        ///// 从缓存中查找失败的次数
        ///// </summary>
        //private static int intFindFailCount = 0;

        /// <summary>
        /// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        /// </summary>
        public static List<clsTeacherInfoEN> arrTeacherInfoObjLstOrderByTeacherId_Cache = null;



        /// <summary>
        /// 根据工号获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strTeacherId">所给的工号</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsTeacherInfoEN GetTeacherInfoObjByTeacherId(string strTeacherId)
        {
            var arrTeacherInfoObjLst_Cache = clsTeacherInfoBL.GetObjLstCache();
            clsTeacherInfoEN objTeacherInfoEN = arrTeacherInfoObjLst_Cache.Find(x => x.TeacherId == strTeacherId);
            return objTeacherInfoEN;
        }


        public static List<clsTeacherInfoEN> arrTeacherInfo = new List<clsTeacherInfoEN>();
        /// <summary>
        /// 在教师对象列表中添加新教师对象，并返回该对象，如果已经存在该教师对象，不能重复添加同流水号的教师对象
        ///   如果已经存在同流水号对象就返回该对象
        /// </summary>
        /// <param name="strIdTeacher">教师流水号</param>
        /// <returns>与教师流水号相关的教师对象</returns>
        public static clsTeacherInfoEN InsertNewTeacherInfoAndRetnObj(string strIdTeacher)
        {
            foreach (clsTeacherInfoEN objTeacherInfo in arrTeacherInfo)
            {
                if (objTeacherInfo.IdTeacher == strIdTeacher)
                {
                    return objTeacherInfo;
                }
            }
            //clsTeacherInfoEN objTeacherInfo1 = new clsTeacherInfoEN(strIdTeacher);
            //clsTeacherInfoBL.GetTeacherInfo(ref objTeacherInfo1);
            clsTeacherInfoEN objTeacherInfo1 = clsTeacherInfoBL.GetObjByIdTeacherCache(strIdTeacher);
            arrTeacherInfo.Add(objTeacherInfo1);
            return objTeacherInfo1;
        }

        /// <summary>
        /// 根据教师Id获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strTeacherId">教师Id</param>
        /// <returns>根据教师Id获取的教师对象</returns>
        public static clsTeacherInfoEN GetTeacherInfoObjByTeacherId_CacheExBak20141026(string strTeacherId)
        {
            if (arrTeacherInfoObjLstOrderByTeacherId_Cache == null)
            {
                arrTeacherInfoObjLstOrderByTeacherId_Cache = new clsTeacherInfoDA().GetObjLst("1=1");
            }
            foreach (clsTeacherInfoEN objTeacherInfoEN in arrTeacherInfoObjLstOrderByTeacherId_Cache)
            {
                if (objTeacherInfoEN.TeacherId.Equals(strTeacherId, StringComparison.InvariantCultureIgnoreCase))
                {
                    return objTeacherInfoEN;
                }
            }
            return null;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strIdTeacher">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsTeacherInfoEN GetTeacherInfoObjByTeacherId_CacheEx(string strTeacherId)
        {
            if (string.IsNullOrEmpty(strTeacherId) == true)
            {
                return null;
            }
            string strCondition = string.Format("1=1 order by TeacherId");
            if (arrTeacherInfoObjLstOrderByTeacherId_Cache == null)
            {
                arrTeacherInfoObjLstOrderByTeacherId_Cache = new clsTeacherInfoDA().GetObjLst(strCondition);
            }
            int intStart = 0;
            int intEnd = arrTeacherInfoObjLstOrderByTeacherId_Cache.Count - 1;
            int intMid = 0;
            clsTeacherInfoEN objTeacherInfoEN = null;
            while (intEnd >= intStart)
            {
                intMid = (intStart + intEnd) / 2;
                objTeacherInfoEN = arrTeacherInfoObjLstOrderByTeacherId_Cache[intMid];
                if (objTeacherInfoEN.TeacherId == strTeacherId)
                {
                    intFindFailCount = 0;
                    return objTeacherInfoEN;
                }
                else if (objTeacherInfoEN.TeacherId.CompareTo(strTeacherId) > 0)
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
            arrTeacherInfoObjLstOrderByTeacherId_Cache = null;
            if (intFindFailCount == 1) return GetTeacherInfoObjByTeacherId_CacheEx(strTeacherId);
            string strErrMsgForGetObjById = string.Format("在TeacherInfo对象缓存列表中，找不到记录[TeacherId={0}][intFindFailCount={1}](函数:GetTeacherInfoObjByTeacherId_CacheEx)", strTeacherId, intFindFailCount);
            if (objTeacherInfoEN != null)
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid={1}]", objTeacherInfoEN.TeacherId, intMid);
            }
            else
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查！[intMid={0}]", intMid);
            }
            clsGeneralTab2.LogErrorS2("clsTeacherInfoBL", "GetTeacherInfoObjByTeacherId_CacheEx", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strIdTeacher">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static string GetId_TeacherByTeacherId_CacheEx2(string strTeacherId)
        {
            string strCondition = string.Format("1=1 order by TeacherId");
            if (arrTeacherInfoObjLstOrderByTeacherId_Cache == null)
            {
                arrTeacherInfoObjLstOrderByTeacherId_Cache = new clsTeacherInfoDA().GetObjLst(strCondition);
            }
            int intStart = 0;
            int intEnd = arrTeacherInfoObjLstOrderByTeacherId_Cache.Count - 1;
            int intMid = 0;
            clsTeacherInfoEN objTeacherInfoEN = null;
            while (intEnd >= intStart)
            {
                intMid = (intStart + intEnd) / 2;
                objTeacherInfoEN = arrTeacherInfoObjLstOrderByTeacherId_Cache[intMid];
                if (objTeacherInfoEN.TeacherId == strTeacherId)
                {
                    intFindFailCount = 0;
                    return objTeacherInfoEN.IdTeacher;
                }
                else if (objTeacherInfoEN.TeacherId.CompareTo(strTeacherId) > 0)
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
            arrTeacherInfoObjLstOrderByTeacherId_Cache = null;
            if (intFindFailCount == 1) return GetId_TeacherByTeacherId_CacheEx2(strTeacherId);
            string strErrMsgForGetObjById = string.Format("在TeacherInfo对象缓存列表中，找不到记录[TeacherId={0}][intFindFailCount={1}](函数:GetTeacherInfoObjByTeacherId_CacheEx)", strTeacherId, intFindFailCount);
            if (objTeacherInfoEN != null)
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid={1}]", objTeacherInfoEN.TeacherId, intMid);
            }
            else
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查！[intMid={0}]", intMid);
            }
            clsGeneralTab2.LogErrorS2("clsTeacherInfoBL", "GetTeacherInfoObjByTeacherId_CacheEx", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        /// <summary>
        /// 根据工号获取相关学院流水号
        /// </summary>
        /// <param name="strTeacherId">工号</param>
        /// <returns>返回IdXzCollege</returns>
        public static string GetId_CollegeByTeacherId_CacheEx(string strTeacherId)
        {
            clsTeacherInfoEN objTeacherInfoEN = GetTeacherInfoObjByTeacherId_CacheEx(strTeacherId);
            return objTeacherInfoEN.IdXzCollege;
        }

        /// <summary>
        /// 根据工号获取相关教师流水号
        /// </summary>
        /// <param name="strTeacherId">工号</param>
        /// <returns>返回IdTeacher</returns>
        public static string GetId_TeacherByTeacherId_CacheEx(string strTeacherId)
        {
            clsTeacherInfoEN objTeacherInfoEN = GetTeacherInfoObjByTeacherId_CacheEx(strTeacherId);
            return objTeacherInfoEN.IdTeacher;
        }
        //根据教师的登陆ID号获取教师的姓名
        public static bool IsExistTeacherId(string strTeacherId)
        {
            bool bolisTeacher = clsTeacherInfoDAEx.IsExistTeacherId(strTeacherId);
            return bolisTeacher;
        }

        /// <summary>
        /// 同步用户到用户权限统一平台
        /// </summary>
        /// <param name="strId_Teacher">本地的一名教师流水号</param>
        /// <returns></returns>
        //public static bool SynchUserToPlatform(string strId_Teacher)
        //{

        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();

        //    //同步教学班教师
        //    if (string.IsNullOrEmpty(strId_Teacher) == true)
        //    {
        //        throw new Exception("教师流水号不能为空！");
        //    }
        //    clsTeacherInfoEN objTeacherInfo = clsTeacherInfoBL.GetObjByIdTeacherCache(strId_Teacher);

        //    clsUsersEN objUsers4Plat = new clsUsersEN();

        //    objUsers4Plat.UserId = objTeacherInfo.TeacherId;

        //    objUsers4Plat.UserName = objTeacherInfo.TeacherName;

        //    objUsers4Plat.UserStateId = "01";
        //    string strCollegeName4Teacher = clsXzClgBL.GetCollegeNameByid_College_Cache(objTeacherInfo.IdXzCollege);
        //    string strCondition = string.Format("DepartmentName='{0}'", strCollegeName4Teacher);
        //    //Edu_ArrangeCourse.ServiceReferenceDepartmentInfo.clsDepartmentInfoEN.

        //    List<clsDepartmentInfoEN> arrDepartmentInfoObjLst = clsDepartmentInfoWS.GetObjLst(strCondition);

        //    string strDepartmentIdInGP;
        //    if (arrDepartmentInfoObjLst.Count == 0)
        //    {
        //        strDepartmentIdInGP = "000000";
        //    }
        //    else
        //    {
        //        clsDepartmentInfoEN objDepartmentInfoEN = arrDepartmentInfoObjLst[0];
        //        strDepartmentIdInGP = objDepartmentInfoEN.DepartmentId;
        //    }

        //    objUsers4Plat.DepartmentId = strDepartmentIdInGP;

        //    objUsers4Plat.IdentityID = "03";

        //    objUsers4Plat.StuIdTeacherId = objTeacherInfo.TeacherId;
        //    //if (string.IsNullOrEmpty(objTeacherInfo.PassWord) == false)
        //    //{
        //    //    objUsers4Plat.Password = objTeacherInfo.PassWord;
        //    //}
        //    if (string.IsNullOrEmpty(objTeacherInfo.CitizenID) == false)
        //    {
        //        objUsers4Plat.Password = objTeacherInfo.CitizenID.Substring(objTeacherInfo.CitizenID.Length - 6);
        //        objTeacherInfo.PassWord = objUsers4Plat.Password;
        //    }
        //    else
        //    {
        //        objUsers4Plat.Password = "111111";
        //        objTeacherInfo.PassWord = objUsers4Plat.Password;
        //    }
        //    objUsers4Plat.Memo = "由教务管理系统导入到统一平台:" + strCurrDate14;

        //    clsUsersExWS.AddNewUsersAndUpdate(objUsers4Plat, "0115", "01150004");


        //    objTeacherInfo.Memo = "已经同步到统一平台：" + strCurrDate14;
        //    objTeacherInfo.IsGpUser = true;


        //    objTeacherInfo.ModifyDate = strCurrDate14;
        //    objTeacherInfo.ModifyUserId = clsSysParaEN.strUserId;

        //    clsTeacherInfoBL.UpdateBySql2(objTeacherInfo);



        //    return true;
        //}
        /// <summary>
        /// 同步教师对象到用户权限统一平台
        /// </summary>
        /// <param name="strId_Teacher">教师流水号</param>
        /// <param name="strSchoolId">学校Id</param>
        /// <param name="strOpUserId">操作用户Id</param>
        /// <returns>是否成功?</returns>
        public static bool SynchTeacherToPlatform(string strId_Teacher, string strSchoolId, string strPersonType, string strOpUserId)
        {
            clsvTeacherInfoEN objTeacherInfo = clsvTeacherInfoBL.GetObjByIdTeacher(strId_Teacher);

            string strCondition = "";
            if (objTeacherInfo.IdStaffType ==  clsRsStaffTypeBLEx.StaffType_PrimaryAndSecondary)
            {
                strCondition = $"{convPlatDefaRole.IdSchool}='{strSchoolId}' And PersonType='{strPersonType}' order by PrjId";
            }
            else
            {
                strCondition = $"{convPlatDefaRole.IdSchool}='{strSchoolId}' And PersonType='{strPersonType}' order by PrjId";
            }
            List<clsvPlatDefaRoleEN> arrvPlatDefaRoleobjLst = clsvPlatDefaRoleBL.GetObjLst(strCondition);

            List<string> arrPrjIdLst = new List<string>();
            foreach (clsvPlatDefaRoleEN objvPlatDefaRoleEN in arrvPlatDefaRoleobjLst)
            {
                if (arrPrjIdLst.Contains(objvPlatDefaRoleEN.PrjId) == false)
                {
                    arrPrjIdLst.Add(objvPlatDefaRoleEN.PrjId);
                }
            }

            if (arrPrjIdLst.Count == 0)
            {
                clsRsStaffTypeEN objStaffTypeEN = clsRsStaffTypeBL.GetObjByIdStaffTypeCache(objTeacherInfo.IdStaffType);
                string strMsg = string.Format("没有为[教师]:[{0}]在统一平台中设置相应的角色，请联系管理员!", objStaffTypeEN.StaffTypeName);
                throw new Exception(strMsg);
            }

            string strCurrDate = clsDateTime_Db.GetDataBaseDate8();
            clsQxUsersEN objUsersEN = new clsQxUsersEN();


            objUsersEN.UserId = objTeacherInfo.TeacherId;
            objUsersEN.UserName = objTeacherInfo.TeacherName;
            objUsersEN.UserStateId = "01";

            if (objTeacherInfo.IdStaffType == clsRsStaffTypeBLEx.StaffType_PrimaryAndSecondary)
            {
                if (string.IsNullOrEmpty(objTeacherInfo.IdSchoolPs) == true)
                {
                    string strMsg = string.Format("该教师：{0}({1})没有中小学学校，请设置学校后再同步到统一平台！", objTeacherInfo.TeacherName, objTeacherInfo.TeacherId);
                    throw new Exception(strMsg);
                }
                objUsersEN.DepartmentId = "999";
            }
            else
            {
                //objUsersEN.IdentityID = "04";
                if (string.IsNullOrEmpty(objTeacherInfo.CollegeId) == true)
                {
                    objUsersEN.DepartmentId = "000000";
                }
                else
                {
                    string strDepartmentIdInGP = clsXzClgBLEx.GetDepartmentIdInGPByIdCollege(objTeacherInfo.IdXzCollege);
                    if (string.IsNullOrEmpty(strDepartmentIdInGP) == true)
                    {
                        objUsersEN.DepartmentId = "000000";
                    }
                    else
                    {
                        objUsersEN.DepartmentId = strDepartmentIdInGP;
                    }
                }
            }

            objUsersEN.StuTeacherId = objTeacherInfo.TeacherId;
            if (string.IsNullOrEmpty(objTeacherInfo.RegisterPassword) == true)
            {
                objUsersEN.Password = "111111";
            }
            else
            {
                objUsersEN.Password = objTeacherInfo.RegisterPassword;
            }

            objUsersEN.UpdDate = strCurrDate;
            objUsersEN.UpdUser = strOpUserId;
            objUsersEN.Memo = "由教育高地导入到统一平台:" + strCurrDate;

            foreach (string strPrjId in arrPrjIdLst)
            {
                bool bolIsFirst = true;
                var arrRoleId = arrvPlatDefaRoleobjLst.Where(x => x.PrjId == strPrjId).Select(x => x.RoleId).Distinct().ToList();
                foreach (var strRoleId in arrRoleId)
                {
                    clsQxUsersBLEx.AddNewUsers(objUsersEN, strPrjId, strRoleId);
                    clsQxUsersBLEx.AddUserRoleRelation(objUsersEN.UserId, strRoleId);
                }
            }
            clsTeacherInfoEN objTeacherInfo1 = clsTeacherInfoBL.GetObjByIdTeacher(strId_Teacher);
            objTeacherInfo1.IsGpUser = true;
            clsTeacherInfoBL.UpdateBySql2(objTeacherInfo1);
            return true;
        }
        /// <summary>
        /// 同步一个用户对象到教师对象
        /// </summary>
        /// <param name="objUsersEN">用户对象</param>
        /// <param name="strOpUserId">操作用户Id</param>
        /// <returns>教师对象(clsTeacherInfoEN)</returns>
        public static clsTeacherInfoEN SynchUsersToTeacher(clsUsersEN objUsersEN, string strOpUserId)
        {
            string strCondition = string.Format("{0}='{1}'", conTeacherInfo.TeacherId, objUsersEN.UserId);
            clsTeacherInfoEN objTeacherInfoEN = clsTeacherInfoBL.GetFirstObj_S(strCondition);
            if (objTeacherInfoEN != null) return objTeacherInfoEN;
            objTeacherInfoEN = new clsTeacherInfoEN();
            objTeacherInfoEN.IdTeacher = clsTeacherInfoBL.GetMaxStrId_S();
            objTeacherInfoEN.TeacherId = objUsersEN.UserId;
            objTeacherInfoEN.TeacherName = objUsersEN.UserName;
            objTeacherInfoEN.IdXzCollege = objUsersEN.IdXzCollege;
            objTeacherInfoEN.IdStaffType = clsRsStaffTypeBLEx.StaffType_University;
            objTeacherInfoEN.RegisterPassword = objUsersEN.Password;
            objTeacherInfoEN.IdSex = "0001";

            objTeacherInfoEN.ModifyDate = objUsersEN.UpdDate;
            objTeacherInfoEN.ModifyUserId = strOpUserId;
            clsTeacherInfoBL.AddNewRecordBySql2(objTeacherInfoEN);

            return objTeacherInfoEN;
        }

        /// <summary>
        /// 同步一个用户对象到中小学教师对象
        /// </summary>
        /// <param name="objUsersEN">用户对象</param>
        /// <param name="strOpUserId">操作用户Id</param>
        /// <returns>教师对象(clsTeacherInfoEN)</returns>
        public static clsTeacherInfoEN SynchUsersToTeacher_PrimaryAndSecondary(clsUsersEN objUsersEN, string strOpUserId)
        {
            string strCondition = string.Format("{0}='{1}'", conTeacherInfo.TeacherId, objUsersEN.UserId);
            clsTeacherInfoEN objTeacherInfoEN = clsTeacherInfoBL.GetFirstObj_S(strCondition);
            if (objTeacherInfoEN != null) return objTeacherInfoEN;
            objTeacherInfoEN = new clsTeacherInfoEN();
            objTeacherInfoEN.IdTeacher = clsTeacherInfoBL.GetMaxStrId_S();
            objTeacherInfoEN.TeacherId = objUsersEN.UserId;
            objTeacherInfoEN.TeacherName = objUsersEN.UserName;
            objTeacherInfoEN.IdXzCollege = objUsersEN.IdXzCollege;
            objTeacherInfoEN.IdStaffType = clsRsStaffTypeBLEx.StaffType_PrimaryAndSecondary;
            objTeacherInfoEN.RegisterPassword = objUsersEN.Password;

            objTeacherInfoEN.ModifyDate = objUsersEN.UpdDate;
            objTeacherInfoEN.ModifyUserId = strOpUserId;
            clsTeacherInfoBL.AddNewRecordBySql2(objTeacherInfoEN);

            return objTeacherInfoEN;
        }
        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// 这里仅仅是演示函数，使用时请复制到扩展类:[TeacherInfo]中改名为:[DelRecord4MultiTab]使用
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DelRecord4MultiTab)
        /// </summary>
        /// <param name="strIdTeacher">表关键字</param>
        /// <returns></returns>
        public static bool DelRecord4MultiTabEx(string strIdTeacher, string strCourseId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsTeacherInfoDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[TeacherInfo]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'",
                concc_CourseTeacherRelation.IdTeacher,
                strIdTeacher);
                clscc_CourseTeacherRelationBL.Delcc_CourseTeacherRelationsByCondWithTransaction_S(strCondition, strCourseId, objConnection, objSqlTransaction);

                clsTeacherInfoBL.DelRecord(strIdTeacher, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTeacherInfoBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("删除多表记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strIdTeacher, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }
    }
}
