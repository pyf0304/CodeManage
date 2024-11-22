using com.taishsoft.commdb;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using SpecData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace ExamLib.BusinessLogicEx
{
    public class clsXzClgBLEx: clsXzClgBL
    {

        /// <summary>
        /// 获取学院
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable GetCollegeID()
        {
            System.Data.DataTable objDT = null;

            string strSQL = string.Format("select IdXzCollege, CollegeName from XzClg where Isvisible='1' order by {0}", conXzClg.OrderNum);

            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            objDT = mySql.GetDataTable(strSQL);
            //  }
            return objDT;

        }
        public static void BindDdl_id_XzCollegeEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetCollegeID();
            objDDL.DataValueField = "IdXzCollege";
            objDDL.DataTextField = "CollegeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;

        }
        public static string GetDepartmentIdInGPByIdCollege(string strIdCollege)
        {
            string strDepartmentName = GetDepartmentNameById(strIdCollege);
            if (string.IsNullOrEmpty(strDepartmentName) == true) return "";
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("DepartmentName='{0}'", strDepartmentName);
            List<Entity.clsQxDepartmentInfoEN> arrDepartmentInfoObjLst = clsQxDepartmentInfoBL.GetObjLst(sbCondition.ToString());
            if (arrDepartmentInfoObjLst.Count == 0) return "";
            Entity.clsQxDepartmentInfoEN objDepartmentInfo4Plat = arrDepartmentInfoObjLst[0] as Entity.clsQxDepartmentInfoEN;
            return objDepartmentInfo4Plat.DepartmentId;
        }
        public static string GetDepartmentNameById(string strIdCollege)
        {
            clsXzClgEN objDepartmentInfo = GetObjByIdXzCollegeCache(strIdCollege);
            return objDepartmentInfo.CollegeName;
        }
        public static System.Data.DataTable GetClgId()
        {
            //获取某学院所有专业信息
            string strSQL = "select IdXzCollege, CollegeId+CollegeName as CollegeName from XzClg where IsVisible='1' And CollegeId<>'0000' order by CollegeId ";
            clsSpecSQL mySql = new clsSpecSQL();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        ///绑定下拉框的函数代码
        public static void BindDdl_id_XzClgEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetClgId();
            objDDL.DataValueField = "IdXzCollege";
            objDDL.DataTextField = "CollegeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strid_XzClg">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        //public static clsXzClgEN GetXzClgObjByXzClgName(string strXzClgName)
        //{
            
        //    if (arrXzClgObjLst_Cache == null)
        //    {

        //        arrXzClgObjLst_Cache = new clsXzClgDA().GetObjLst("1=1");
        //    }
        //    foreach (clsXzClgEN objXzClgEN in arrXzClgObjLst_Cache)
        //    {
        //        if (objXzClgEN.CollegeName.Equals(strXzClgName, StringComparison.CurrentCultureIgnoreCase) == true)
        //        {
        //            return objXzClgEN;
        //        }
        //    }
        //    return null;
        //}
        /// <summary>
        /// 功能:删除关键字所指定的记录
        /// (AutoGCLib.AutoGCPubFuncV6:GenDelRecord_S)
        /// </summary>
        /// <param name = "strid_XzCollege">给定的关键字值</param>
        /// <returns>返回删除的记录数</returns>
        public static int DelRecordEx2(string strid_XzCollege)
        {
            //CheckPrimaryKey(strid_XzCollege);
            //删除单条记录
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsXzClgDA.GetSpecSQLObj();
            //删除XzClg本表中与当前对象有关的记录
            strSQL = strSQL + string.Format("Delete from {0} where {1} = '{2}'",
                clsXzMajorEN._CurrTabName,
                conXzMajor.IdXzCollege,
                strid_XzCollege);
            strSQL = strSQL + "Delete from XzClg where IdXzCollege = " + "'" + strid_XzCollege + "'";
            return objSQL.ExecSql2(strSQL);
        }
        /// <summary>
        /// 同步本地的一个部门到用户权限统一平台
        /// </summary>
        /// <param name="objDepartmentInfo4Local"></param>
        /// <returns></returns>
        public static bool SynchDepartmentToPlatform(clsXzClgEN objXzClg4Local)
        {

            string strCurrDate = clsDateTime_Db.GetDataBaseDate8();
            Entity.clsQxDepartmentInfoEN objDepartmentInfo4Plat = new Entity.clsQxDepartmentInfoEN();
            objDepartmentInfo4Plat.DepartmentId = objXzClg4Local.CollegeId;
            objDepartmentInfo4Plat.DepartmentName = objXzClg4Local.CollegeName;
            //objDepartmentInfo4Plat.DepartMentId4Card = objXzClg4Local.CollegeId;
            objDepartmentInfo4Plat.DepartmentTypeId = ""; //objXzClg4Local.DepartmentTypeId;
            //objDepartmentInfo4Plat.IsAcademy = true;// objXzClg4Local.IsAcademy; ;
            objDepartmentInfo4Plat.OrderNum = objXzClg4Local.OrderNum;
            objDepartmentInfo4Plat.InUse = true;

            //objDepartmentInfo4Plat.SubjectTypeId = ""; //objXzClg4Local.SubjectTypeId;
            objDepartmentInfo4Plat.UpDepartmentId = ""; //objXzClg4Local.UpDepartmentId;
            objDepartmentInfo4Plat.Memo = "由教育高地平台导入到统一平台:" + strCurrDate;
            if (clsQxDepartmentInfoBL.IsExist(objXzClg4Local.CollegeId) == false)
            {
                clsQxDepartmentInfoBL.AddNewRecordBySql2(objDepartmentInfo4Plat);
            }
            else
            {
                clsQxDepartmentInfoBL.UpdateBySql2(objDepartmentInfo4Plat);

            }
            objXzClg4Local.Memo = "已经同步到统一平台：" + strCurrDate;
            clsXzClgBL.UpdateBySql2(objXzClg4Local);
            return true;
        }

        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsXzClgDAEx().GoTop(arrKeyId);
                bolResult = new clsXzClgDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }

        public static bool GoTop(string strKeyId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsXzClgDAEx().GoTop(arrKeyId);
                bolResult = new clsXzClgDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsXzClgDAEx().GoBottom(arrKeyId);
                bolResult = new clsXzClgDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(string strKeyId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsXzClgDAEx().GoBottom(arrKeyId);
                bolResult = new clsXzClgDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }


        public static bool AdjustSequenceNumber(string strDirect, string strid_XzClg)
        {
            try
            {
                bool bolResult = new clsXzClgDAEx().AdjustSequenceNumber(strDirect, strid_XzClg);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错！\r\n" + objException.Message);
            }
        }
        public static bool ReOrder()
        {
            try
            {
                bool bolResult = new clsXzClgDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错！\r\n" + objException.Message);
            }

        }
    }
}
