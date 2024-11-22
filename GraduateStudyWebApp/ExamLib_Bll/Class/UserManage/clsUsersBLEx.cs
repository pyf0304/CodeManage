
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;


using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using GeneralPlatform.Entity;
using GeneralPlatform4WApi;
using GP4WApi;
using SpecData;
using clsQxUsersEN = GeneralPlatform.Entity.clsQxUsersEN;
using clsSysParaEN = ExamLib.Entity.clsSysParaEN;

namespace ExamLib.BusinessLogicEx
{
    public static class clsUsersBLEx_Static
    {
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx2)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsUsersEN objUsersEN)
        {
            //操作步骤:
            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //2、检查唯一性
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
                            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsUsersBL.IsExist(objUsersEN.UserId))  //判断是否有相同的关键字
            {
                strMsg = "(errid:BlEx000004)关键字字段已有相同的值";
                throw new Exception(strMsg);
            }
            try
            {
                //2、检查传进去的对象属性是否合法
                objUsersEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objUsersEN.AddNewRecord();
            }
            catch (Exception objException)
            {
                strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_UpdateRecordEx2)
        /// </summary>
        /// <param name = "objUsersEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsUsersEN objUsersEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objUsersEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objUsersEN.Update();
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_EditRecordEx)
        /// </summary>
        /// <param name = "objUsers">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx(this clsUsersEN objUsers)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsUsersEN objUsers_Cond = new clsUsersEN();
            string strCondition = objUsers_Cond
            .SetUserId(objUsers.UserId, "=")
            .GetCombineCondition();
            objUsers._IsCheckProperty = true;
            bool bolIsExist = clsUsersBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objUsers.UserId = clsUsersBL.GetFirstID_S(strCondition);
                objUsers.UpdateWithCondition(strCondition);
            }
            else
            {
                objUsers.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objUsersENS">源对象</param>
        /// <returns>目标对象=>clsUsersEN:objUsersENT</returns>
        public static clsUsersENEx CopyToEx(this clsUsersEN objUsersENS)
        {
            try
            {
                clsUsersENEx objUsersENT = new clsUsersENEx();
                clsUsersBL.UsersDA.CopyTo(objUsersENS, objUsersENT);
                return objUsersENT;
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
        /// <param name = "objUsersENS">源对象</param>
        /// <returns>目标对象=>clsUsersEN:objUsersENT</returns>
        public static clsUsersEN CopyTo(this clsUsersENEx objUsersENS)
        {
            try
            {
                clsUsersEN objUsersENT = new clsUsersEN();
                clsUsersBL.UsersDA.CopyTo(objUsersENS, objUsersENT);
                return objUsersENT;
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
    /// 用户表(Users)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsUsersBLEx : clsUsersBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsUsersDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsUsersDAEx UsersDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsUsersDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strUserId">表关键字</param>
        /// <returns></returns>
        public static bool DelRecordExBak(string strUserId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUsersDA.GetSpecSQLObj();
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
                //删除与表:[Users]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conUsers.UserId,
                //strUserId);
                //        clsUsersBL.DelUserssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsUsersBL.DelRecord(strUserId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsUsersBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strUserId, clsStackTrace.GetCurrClassFunction());
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

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsUsersENEx> GetObjExLst(string strCondition)
        {
            List<clsUsersEN> arrObjLst = clsUsersBL.GetObjLst(strCondition);
            List<clsUsersENEx> arrObjExLst = new List<clsUsersENEx>();
            foreach (clsUsersEN objInFor in arrObjLst)
            {
                clsUsersENEx objUsersENEx = new clsUsersENEx();
                clsUsersBL.CopyTo(objInFor, objUsersENEx);
                arrObjExLst.Add(objUsersENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strUserId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsUsersENEx GetObjExByUserId(string strUserId)
        {
            clsUsersEN objUsersEN = clsUsersBL.GetObjByUserId(strUserId);
            clsUsersENEx objUsersENEx = new clsUsersENEx();
            clsUsersBL.CopyTo(objUsersEN, objUsersENEx);
            return objUsersENEx;
        }

        public static DataTable dtStudent = new DataTable();
        public static DataTable dtTeacher = new DataTable();
        /// <summary>
        /// 同步用户到用户权限统一平台
        /// </summary>
        /// <param name="objUsers4Local">本地的一个用户</param>
        /// <returns></returns>
        public static bool SynchUserToPlatformBak(clsUsersEN objUsers4Local)
        {

            string strCurrDate = clsDateTime_Db.GetDataBaseDate8();

            clsQxUsersEN objUsers4Plat = new clsQxUsersEN();

            objUsers4Plat.UserId = objUsers4Local.UserId;

            objUsers4Plat.UserName = objUsers4Local.UserName;

            objUsers4Plat.UserStateId = objUsers4Local.UserStateId;
            //string strDepartmentIdInGP = clsDepartmentInfoBLEx.GetDepartmentIdInGPByLocalId(objUsers4Local.DepartmentId);
            //if (string.IsNullOrEmpty(strDepartmentIdInGP) == true)
            //{
            //    objUsers4Plat.DepartmentId = "000000";
            //}
            //else
            //{
            //    objUsers4Plat.DepartmentId = strDepartmentIdInGP;
            //}
            //objUsers4Plat.IdentityID = "00"; ;

            //objUsers4Plat.StuIdTeacherId = "00";

            objUsers4Plat.Password = objUsers4Local.Password;

            objUsers4Plat.Memo = "由任务管理系统导入到统一平台:" + strCurrDate;

            clsQxUsersExWApi.AddNewUsers(objUsers4Plat, "0101", "01010009");
            objUsers4Local.Memo = "已经同步到统一平台：" + strCurrDate;
            objUsers4Local.IsGpUser = true;
            clsUsersBL.UpdateBySql2(objUsers4Local);
            return true;
        }
        /// <summary>
        /// 功能：获取某一条件的相关表视图(View)
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetUsersVWithGroup(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUsersDA.GetSpecSQLObj();
            strSQL.Append("Select vUsersWithGroup.* ");
            strSQL.Append(" from vUsersWithGroup ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static new bool DelRecordEx(string strUserId)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQL objSQL = new clsSpecSQL();
            //删除Users本表中与当前对象有关的记录
            
            //  strSQL = strSQL + "Delete from UserVisit where UserId=" + "'" + strUserId + "';";
            strSQL = strSQL + string.Format("Delete from {0} where UserId='{1}';", clsUsers_JTEN._CurrTabName, strUserId);
            strSQL = strSQL + string.Format("Delete from {0} where UserId='{1}';", clsUsersEN._CurrTabName, strUserId);
            return objSQL.ExecSql(strSQL);
        }
        #region 根据用户ID，获取该用户的角色列表
        /// <summary>
        /// 根据用户ID，获取该用户的角色列表
        /// </summary>
        /// <param name="UserId">学号（教职工号）</param>
        /// <returns>数据间用,号隔开</returns>
        public static string GetRoleList(string UserId)
        {
            //DataTable dtRole = new DataTable();
            if (!String.IsNullOrEmpty(UserId))
            {
                //                List<string> lstRoleId = clsPubVar4BLEx_Local.objMenuAndPotence.Get_RoleIdList2(clsSysParaEN.CurrPrjId, UserId);
                List<string> lstRoleId = MenuAndPotence.Get_RoleIdList2(clsSysParaEN.CurrPrjId, UserId);
                string strRoleIds = clsArray.GetSqlInStrByArray(lstRoleId, false);
                //                    return ConvertDataTableToString(dtRole);
                return strRoleIds;
            }
            return "";
        }
        #endregion



        #region 判断给定的UserId是否为教师的流水号
        /// <summary>
        /// 判断给定的教职工号是否为教师的
        /// </summary>
        /// <param name="UserId">教职工号</param>
        /// <returns>1 是 0 否</returns>
        public static bool IsTeacher(string strUserId)
        {
            bool result = false;
            try
            {
                string strCondition = string.Format("{0}='{1}'", conTeacherInfo.TeacherId, strUserId);
                bool bolIsExist = clsTeacherInfoBL.IsExistRecord(strCondition);
                if (bolIsExist == true) return true;
                else return false;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsUserBLEx", "IsTeacher", objException.Message, "");
                result = false;
            }
            return result;
        }
        #endregion
        #region 判断给定的UserId是否为教师的流水号
        /// <summary>
        /// 判断给定的教职工号是否为教师的
        /// </summary>
        /// <param name="UserId">教职工号</param>
        /// <returns>1 是 0 否</returns>
        public static bool IsStudent(string strUserId)
        {
            bool result = false;
            try
            {
                string strCondition = string.Format("{0}='{1}'", conStudentInfo.StuId, strUserId);
                bool bolIsExist = clsStudentInfoBL.IsExistRecord(strCondition);
                if (bolIsExist == true) return true;
                else return false;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsUserBLEx", "IsStudent", objException.Message, "");
                result = false;
            }
            return result;
        }
        #endregion
        #region 检查 OriginalData 数据中是否包含CompareData，如包含为TRUE，否为FALSE
        /// <summary>
        /// 检查 OriginalData 数据中是否包含CompareData，如包含为TRUE，否为FALSE
        /// </summary>
        /// <param name="OriginalData"></param>
        /// <param name="CompareData"></param>
        /// <returns></returns>
        public static bool IsContain(string[] OriginalData, string CompareData)
        {
            StringBuilder Result = new StringBuilder();
            for (int i = 0; i < OriginalData.Length; i++)
            {
                if (OriginalData[i].Equals(CompareData))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion



        public static int SynchUsersToStudentAndPlatform(List<string> arrUserIdLst, string strIdSchool, string strOpUserId)
        {
            int intCount = 0;
            string strCurrDate = clsDateTime.getTodayStr(0);
            string strCondition = string.Format("{0} in ({1})", conUsers.UserId, clsArray.GetSqlInStrByArray(arrUserIdLst, true));
            List<clsUsersEN> arrUserObjLst = clsUsersBL.GetObjLst(strCondition);
            foreach (clsUsersEN objUsersEN in arrUserObjLst)
            {

                if (objUsersEN.IsAudit == true)
                {
                    continue;
                    //objUsersEN.UserId = strUserId;

                    //objUsersEN.IsAudit = false;
                    //clsUsersBL.UpdateBySql2(objUsersEN);
                }
                else
                {
                    Entity.clsQxUserIdentityEN objUserIdentityEN = clsQxUserIdentityBL.GetObjByIdentityIdCache(objUsersEN.IdentityId);
                    clsStudentInfoEN objStudentInfoEN = null;
                    switch (objUserIdentityEN.IdentityDesc)
                    {
                        case "大学学生":
                        case "大学学生(包括研究生)":
                            objStudentInfoEN = clsStudentInfoBLEx.SynchUsersToStudent(objUsersEN);
                            //clsStudentInfoBLEx.SynchStudentToPlatform(objStudentInfoEN.IdStudentInfo, strIdSchool, objUserIdentityEN.IdentityDesc, strOpUserId);
                            intCount++;
                            break;
                        case "中小学学生":
                            objStudentInfoEN = clsStudentInfoBLEx.SynchUsersToStudent(objUsersEN);
                            //clsStudentInfoBLEx.SynchStudentToPlatform(objStudentInfoEN.IdStudentInfo, strIdSchool, objUserIdentityEN.IdentityDesc, strOpUserId);
                            intCount++;
                            break;
                        case "教师":
                        case "大学教师":
                            clsTeacherInfoEN objTeacherInfoEN = clsTeacherInfoBLEx.SynchUsersToTeacher(objUsersEN, strOpUserId);
                            clsTeacherInfoBLEx.SynchTeacherToPlatform(objTeacherInfoEN.IdTeacher, strIdSchool, objUserIdentityEN.IdentityDesc, strOpUserId);
                            intCount++;
                            break;
                        case "中小学教师":
                            clsTeacherInfoEN objTeacherInfoEN_PS = clsTeacherInfoBLEx.SynchUsersToTeacher_PrimaryAndSecondary(objUsersEN, strOpUserId);
                            clsTeacherInfoBLEx.SynchTeacherToPlatform(objTeacherInfoEN_PS.IdTeacher, strIdSchool, objUserIdentityEN.IdentityDesc, strOpUserId);
                            intCount++;
                            break;
                        default:
                            string strMsg = $"身份:{objUserIdentityEN.IdentityDesc}在switch中没有被处理！({clsStackTrace.GetCurrFunction()})";
                            throw new Exception(strMsg);
//                            break;
                    }
                    objUsersEN.IsAudit = true;
                    objUsersEN.AuditDate = strCurrDate;
                    objUsersEN.AuditUser = strOpUserId;
                    clsUsersBL.UpdateBySql2(objUsersEN);

                }

            }
            return intCount;
        }

        #region 根据学号（教职工号）获取相应的流水号
        /// <summary>
        /// 根据学号（教职工号）获取相应的流水号
        /// </summary>
        /// <param name="UserId">学号</param>
        /// <returns>流水号</returns>
        public static string GetUserIDByID(string UserId)
        {
            string result = String.Empty;
            DataTable dtResult = new DataTable();
            try
            {
                if (HasTeacherIDByID(UserId))
                {
                    if (dtTeacher.Rows.Count == 0)
                    {
                        dtTeacher = clsvTeacherInfoBL.GetDataTable("1=1");
                    }
                    if (dtTeacher.Rows.Count > 0)
                    {
                        DataRow[] dr = dtTeacher.Select("TeacherID='" + UserId + "'");
                        if (dr.Length > 0) result = dr[0]["IdTeacher"].ToString().Trim();
                    }
                }
                else
                {
                    if (dtStudent.Rows.Count == 0)
                    {
                        dtStudent = clsvTeacherInfoBL.GetDataTable("1=1");
                    }
                    if (dtStudent.Rows.Count > 0)
                    {
                        DataRow[] dr = dtStudent.Select("StuID='" + UserId + "'");
                        if (dr.Length > 0) result = dr[0]["IdStudentInfo"].ToString().Trim();
                    }
                }
            }
            catch
            { }
            return result;
        }
        #endregion
        #region 返回一个BOOL值，检查现教师表中是否存在该ID
        /// <summary>
        /// 返回一个BOOL值，检查现教师表中是否存在该ID
        /// </summary>
        /// <param name="TeacherID"></param>
        /// <returns></returns>
        public static bool HasTeacherIDByID(string TeacherID)
        {
            bool result = false;
            try
            {

                if (!String.IsNullOrEmpty(TeacherID))
                {
                    if (dtTeacher.Rows.Count == 0)
                    {
                        dtTeacher = clsvTeacherInfoBL.GetDataTable("1=1");
                    }
                    DataRow[] drResult = dtTeacher.Select("TeacherID='" + TeacherID + "'");
                    if (drResult.Length > 0) result = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
        #endregion

        #region 修改密码
        /// <summary>
        ///  修改密码
        /// </summary>
        /// <param name="CurrentPassword">修改后密码</param>
        /// <param name="OriginalPassword">原密码</param>
        /// <returns></returns>
        public static bool ChangePassword(string strUserId, string CurrentPassword, string OriginalPassword)
        {
            bool result = false;
            string UpdateSQL = String.Empty;
            try
            {
                if (!String.IsNullOrEmpty(CurrentPassword))
                {
                    //if (IsTeacher(Admin.UserId))
                    //{
                    //    UpdateSQL = UpdateTeacherPasswordSql + CurrentPassword + ConditionTeacherSQL + Admin.UserId;
                    //}
                    //else
                    //{
                    //    UpdateSQL = UpdateStudentPasswordSql + CurrentPassword + ConditionStudentSQL + Admin.UserId;
                    //}
                    clsSpecSQL objSql = new clsSpecSQL();
                    if (MenuAndPotence.Change_CurrentUserPassword(strUserId, OriginalPassword, CurrentPassword))
                    {
                        result = true;
                        //if (clsPubVar4LogicEx.objMenuAndPotence != null)
                        //{
                        //    if (objSql.ExecSql(UpdateSQL))
                        //    {

                        //    } 
                        //}
                    }

                }
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsUserEx", "ChangePassword", objException.Message, strUserId);
            }
            return result;
        }
        #endregion

        private static void ArrangeHomeWork(string strid_StudentInfo, string strDefaId_CurrEduCls, string strOpUserId)
        {
            clscc_ExamPaperStuRelationBLEx.ArrangeHomeWork(strDefaId_CurrEduCls, strid_StudentInfo, strOpUserId);
            clscc_WorkStuRelationBLEx.GetHomeWork(strid_StudentInfo);
        }


        private static clsCurrEduClsEN InsertToDefaCurrEduCls(clsUsersEN objUsersEN, string strDefaId_CurrEduCls, bool spIsAutoAudit4Register, string strOpUserId, ref string strId_StudentInfo)
        {
            //string strDefaId_CurrEduCls = clsMyConfig.spDefaId_CurrEduCls;
            if (string.IsNullOrEmpty(strDefaId_CurrEduCls) == true) return null;
            var objUserIdentity = clsQxUserIdentityBL.GetObjByIdentityIdCache(objUsersEN.IdentityId);
            if (objUserIdentity == null)
            {
                string strMsg = $"用户:{objUsersEN.UserId}身份:[{objUsersEN.IdentityId}]不正确！";
                throw new Exception(strMsg);
            }
            //string strIdStu = clsStudentInfoBLEx.Getid_StuByStuId_CacheEx(objUsersEN.UserId);
            clsStudentInfoEN objStudentInfoEN = clsStudentInfoBLEx.SynchUsersToStudent(objUsersEN);
            bool bolIsAudit = false;
            //if (spIsAutoAudit4Register == true)
            //{
            //    bolIsAudit = clsStudentInfoBLEx.SynchStudentToPlatform(objStudentInfoEN.IdStudentInfo, clsMyConfig.spSchool, objUserIdentity.IdentityDesc, objUsersEN.UserId);
            //}
            clsCurrEduClsStuBLEx.AddId_Stu4EduCls(objStudentInfoEN.IdStudentInfo, strDefaId_CurrEduCls, objUsersEN.UserId);

            clsCurrEduClsEN objCurrEduClsEN = clsCurrEduClsBL.GetObjByIdCurrEduCls(strDefaId_CurrEduCls);
            if (bolIsAudit == true)
            {
                objCurrEduClsEN._StrTag = "IsAudit";
            }
            ArrangeHomeWork(objStudentInfoEN.IdStudentInfo, strDefaId_CurrEduCls, strOpUserId);
            strId_StudentInfo = objStudentInfoEN.IdStudentInfo;
            return objCurrEduClsEN;
        }

        public static bool RegisterUser(clsUsersEN objUsersEN, string strDefaId_CurrEduCls, bool spIsAutoAudit4Register, string strOpUserId, ref string strReturnInfo)
        {
            var objUserIdentity = clsQxUserIdentityBL.GetObjByIdentityIdCache(objUsersEN.IdentityId);
            if (objUserIdentity == null)
            {
                string strMsg0 = $"用户:{objUsersEN.UserId}身份:[{objUsersEN.IdentityId}]不正确！";
                throw new Exception(strMsg0);
            }
            string strMsg = "";
            

            try
            {
                bool bolResult = objUsersEN.EditRecordEx();
                
                if (bolResult == false)
                {
                    throw new Exception("注册失败！");
                }
                //添加用户到学生表中

                clsStudentInfoEN objStudentInfoEN = clsStudentInfoBLEx.SynchUsersToStudent(objUsersEN);
                //同步到统一平台，
                bool bolIsAudit = false;
                //if (clsMyConfig.spIsAutoAudit4Register == true)
                //if (spIsAutoAudit4Register == true)
                //{
                //    bolIsAudit = clsStudentInfoBLEx.SynchStudentToPlatform(objStudentInfoEN.IdStudentInfo, clsMyConfig.spSchool, objUserIdentity.IdentityDesc , objUsersEN.UserId);
                //}

                if (string.IsNullOrEmpty(strDefaId_CurrEduCls) == true) return true;

                clsCurrEduClsEN objCurrEduClsEN = clsCurrEduClsBL.GetObjByIdCurrEduCls(strDefaId_CurrEduCls);
                if (objCurrEduClsEN == null)
                {
                    strMsg = string.Format("注册成功！", objCurrEduClsEN.EduClsName);
                    strReturnInfo = strMsg;
                    return true;
                }
                clsCurrEduClsStuBLEx.AddId_Stu4EduCls(objStudentInfoEN.IdStudentInfo, strDefaId_CurrEduCls, objUsersEN.UserId);
                ArrangeHomeWork(objStudentInfoEN.IdStudentInfo, strDefaId_CurrEduCls, strOpUserId);

                //clsCurrEduClsEN objCurrEduClsEN = InsertToDefaCurrEduCls(objUsersEN, ref strId_StudentInfo);

                if (bolIsAudit == true)
                {
                    strMsg = string.Format("注册成功！并且已经插入到学习班:[{0}],现在就可以参加网上学习并完成作业！", objCurrEduClsEN.EduClsName);
                }
                else
                {
                    strMsg = string.Format("注册成功！并且已经插入到学习班:[{0}],明天就可以参加网上学习并完成作业！", objCurrEduClsEN.EduClsName);
                }
                strReturnInfo = strMsg;

            }
            catch (Exception objException)
            {
                throw objException;
            }
            return true;
        }
    }
}