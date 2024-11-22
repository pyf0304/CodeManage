
using CommFunc4WebForm;
using ExamLib.DAL;
using ExamLib.Entity;
 
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
    public class clsResourceTypeBLEx : clsResourceTypeBL
    {
        public static List<clsResourceTypeEN> arrResourceTypeObjLst = null;

        //public clsResourceTypeBLEx()
        //    : base()
        //{
        //}
        //public clsResourceTypeBLEx(string strid_ResourceType)
        //    : base(strid_ResourceType)
        //{
        //}
        //public clsResourceTypeBLEx(string strid_ResourceType, bool bolIsGetResourceType)
        //    : base(strid_ResourceType, bolIsGetResourceType)
        //{
        //}

        /// <summary>
        /// 绑定基于Web的下拉框-使用Cache
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindChk_id_ResourceType_Cache(System.Web.UI.WebControls.CheckBoxList objDDL)
        {
            //为数据源于表的下拉框设置内容
            //System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            List<clsResourceTypeEN> arrResourceTypeObjLst = clsResourceTypeBL.GetObjLstCache();
            objDDL.DataValueField = conResourceType.IdResourceType;
            objDDL.DataTextField = conResourceType.ResourceTypeName;
            objDDL.DataSource = arrResourceTypeObjLst;
            objDDL.DataBind();
            //objDDL.Items.Insert(0, li);
            //objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 根据资源类型ID获取相应的类型名称
        /// </summary>
        /// <param name="TypeID">类型ID</param>
        /// <returns></returns>
        public static string GetResourceTypeNameByID(string TypeID)
        {
            string TypeName = String.Empty;
            DataTable dtType = new DataTable();
            try
            {
                if (!String.IsNullOrEmpty(TypeID))
                {
                    dtType = clsResourceTypeBL.GetDataTable_ResourceType("IdResourceType=" + TypeID);
                    if (dtType.Rows.Count > 0)
                    {
                        TypeName = dtType.Rows[0]["ResourceTypeName"].ToString();
                    }
                }
            }
            catch
            { }
            return TypeName;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strid_ResourceType">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsResourceTypeEN GetResourceTypeObjByid_ResourceType(string strid_ResourceType)
        {
            if (arrResourceTypeObjLst == null)
            {
                arrResourceTypeObjLst = new clsResourceTypeDA().GetObjLst("1=1");
            }
            foreach (clsResourceTypeEN objResourceType in arrResourceTypeObjLst)
            {
                if (objResourceType.IdResourceType == strid_ResourceType)
                {
                    return objResourceType;
                }
            }
            return null;
        }

        /// <summary>
        /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strid_ResourceType">所给的关键字</param>
        /// <returns>根据关键字获取的名称</returns>
        public static string GetResourceTypeNameByid_ResourceType(string strid_ResourceType)
        {
            if (arrResourceTypeObjLst == null)
            {
                arrResourceTypeObjLst = new clsResourceTypeDA().GetObjLst("1=1");
            }
            foreach (clsResourceTypeEN objResourceType in arrResourceTypeObjLst)
            {
                if (objResourceType.IdResourceType == strid_ResourceType)
                {
                    return objResourceType.ResourceTypeName;
                }
            }
            return null;
        }


        /// <summary>
        /// 类型与文件后缀是否一致
        /// </summary>
        /// <param name="fileextent">后缀</param>
        /// <param name="strid_ResourceType">资源类型流水号</param>
        /// <returns>是否一致</returns>
        public static bool IsAccordofResourceType(string fileextent, string strid_ResourceType)
        {
            bool result = false;
            if (!String.IsNullOrEmpty(fileextent))
            {
                fileextent = fileextent.ToString().ToLower().Trim();
                clsResourceTypeEN objResourceType = clsResourceTypeBL.GetObjByIdResourceTypeCache(strid_ResourceType);
                string[] strFileExtentNameLsts = objResourceType.FileExtentNameLst.Split(',');
                List<string> arrFileExtentNameLsts = new List<string>(strFileExtentNameLsts);
                if (arrFileExtentNameLsts.Contains(fileextent) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                //if (Type == 1)
                //{
                //    if (fileextent.Equals(".mpg") || fileextent.Equals(".avi") || fileextent.Equals(".mpeg") || fileextent.Equals(".asf") || fileextent.Equals(".wmv") || fileextent.Equals(".mp4") || fileextent.Equals(".rm") || fileextent.Equals(".rmvb") || fileextent.Equals(".3gp") || fileextent.Equals(".3gpp") || fileextent.Equals(".avms") || fileextent.Equals(".avds") || fileextent.Equals(".avc"))
                //    {
                //        result = true;
                //    }
                //}
                //else if (Type == 2)
                //{
                //    if (fileextent.Equals(".mid") || fileextent.Equals(".mmf") || fileextent.Equals(".mp3") || fileextent.Equals(".wav") || fileextent.Equals(".midi") || fileextent.Equals(".wav") || fileextent.Equals(".amr") || fileextent.Equals("..avms") || fileextent.Equals(".avds") || fileextent.Equals(".avc"))
                //    {
                //        result = true;
                //    }
                //}
                //else if (Type == 3)
                //{
                //    if (fileextent.Equals(".swf"))
                //    {
                //        result = true;
                //    }
                //}
                //else if (Type == 4)
                //{
                //    if (fileextent.Equals(".jpg") || fileextent.Equals(".gif"))
                //    {
                //        result = true;
                //    }
                //}
                //else if (Type == 5)
                //{
                //    if (fileextent.Equals(".doc") || fileextent.Equals(".txt") || fileextent.Equals(".xls") || fileextent.Equals(".ppt") || fileextent.Equals(".rar"))
                //    {
                //        result = true;
                //    }
                //}
            }
            return result;
        }
        /// <summary>
        /// 检测该资源是否与后缀一致
        /// </summary>
        /// <param name="fileextent">后缀</param>
        /// <param name="resourcetypeid">资源ID</param>
        /// <returns></returns>
        public static bool CheckResourceType(string fileextent, string resourcetypeid)
        {
            bool result = false;
            try
            {
                result = IsAccordofResourceType(fileextent, resourcetypeid);
            }
            catch
            {

            }
            return result;
        }
        ///// <summary>
        ///// 根据关键字获取相关名称, 从缓存的对象列表中获取.
        ///// </summary>
        ///// <param name="strid_ResourceType">所给的关键字</param>
        ///// <returns>根据关键字获取的名称</returns>
        //public static List<clsResourceTypeEN> GetResourceTypeObjLstByFileExtent(string fileextent)
        //{
        //    fileextent = fileextent.ToLower();
        //    List<clsResourceTypeEN> arrResourceTypeObjLstP = new List<clsResourceTypeEN>();
        //    if (clsResourceTypeBL.arrResourceTypeObjLst_Cache == null)
        //    {
        //        clsResourceTypeBL.arrResourceTypeObjLst_Cache = new clsResourceTypeDA().GetObjLst("1=1");
        //    }
        //    foreach (clsResourceTypeEN objResourceType in clsResourceTypeBL.arrResourceTypeObjLst_Cache)
        //    {
        //        string[] strFileExtentNameLsts = objResourceType.FileExtentNameLst.Split(',');
        //        List<string> arrFileExtentNameLsts = new List<string>(strFileExtentNameLsts);
        //        if (arrFileExtentNameLsts.Contains(fileextent) == true)
        //        {
        //            arrResourceTypeObjLstP.Add(objResourceType);
        //        }
        //    }
        //    return arrResourceTypeObjLstP;
        //}



        /// <summary>
        /// 类型与文件后缀是否一致
        /// </summary>
        /// <param name="fileextent">后缀</param>
        /// <param name="Type">类型</param>
        /// <returns></returns>
        private static bool IsAccordofResourceTypeBak20130314pyf(string fileextent, int Type)
        {
            bool result = false;
            if (!String.IsNullOrEmpty(fileextent))
            {
                fileextent = fileextent.ToString().ToLower().Trim();
                if (Type == 1)
                {
                    if (fileextent.Equals(".mpg") || fileextent.Equals(".avi") || fileextent.Equals(".mpeg") || fileextent.Equals(".asf") || fileextent.Equals(".wmv") || fileextent.Equals(".mp4") || fileextent.Equals(".rm") || fileextent.Equals(".rmvb") || fileextent.Equals(".3gp") || fileextent.Equals(".3gpp") || fileextent.Equals(".avms") || fileextent.Equals(".avds") || fileextent.Equals(".avc"))
                    {
                        result = true;
                    }
                }
                else if (Type == 2)
                {
                    if (fileextent.Equals(".mid") || fileextent.Equals(".mmf") || fileextent.Equals(".mp3") || fileextent.Equals(".wav") || fileextent.Equals(".midi") || fileextent.Equals(".wav") || fileextent.Equals(".amr") || fileextent.Equals("..avms") || fileextent.Equals(".avds") || fileextent.Equals(".avc"))
                    {
                        result = true;
                    }
                }
                else if (Type == 3)
                {
                    if (fileextent.Equals(".swf"))
                    {
                        result = true;
                    }
                }
                else if (Type == 4)
                {
                    if (fileextent.Equals(".jpg") || fileextent.Equals(".gif"))
                    {
                        result = true;
                    }
                }
                else if (Type == 5)
                {
                    if (fileextent.Equals(".doc") || fileextent.Equals(".txt") || fileextent.Equals(".xls") || fileextent.Equals(".ppt") || fileextent.Equals(".rar"))
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 获取复选框列表中多选的值，用“|”分隔
        /// </summary>
        /// <param name="pobjCkbl">复选框列表</param>
        /// <returns></returns>
        public static string GetResourceTypeMultiValue(CheckBoxList pobjCkbl)
        {
            //return sbAnswerMultiOptions.ToString();
            return clsCheckBoxList.GetCheckBoxLstMultiSelectedValue(pobjCkbl);
        }
        /// <summary>
        /// 设置复选框列表中多选的值，原值用“|”分隔
        /// </summary>
        /// <param name="pobjCkbl">复选框列表</param>
        /// <param name="strMultiSelectedValue">多选值</param>
        /// <returns></returns>
        public static void SetResourceTypeMultiValue(CheckBoxList pobjCkbl, string strMultiSelectedValue)
        {
            clsCheckBoxList.SetCheckBoxLstMultiSelectedValue(pobjCkbl, strMultiSelectedValue);
        }

        /// <summary>
        /// 设置复选框列表中多选的值，原值用“|”分隔
        /// </summary>
        /// <param name="pobjCkbl">复选框列表</param>
        /// <param name="strMultiSelectedValue">多选值</param>
        /// <returns></returns>
        public static string GetResourceTypeMultiName(string strMultiSelectedValue)
        {
            string[] strOptionItems = strMultiSelectedValue.Split('|');
            List<string> arrOptionItems = new List<string>(strOptionItems);
            StringBuilder sbAnswerMultiOptions = new StringBuilder();
            foreach (string strItemValue in arrOptionItems)
            {
                if (string.IsNullOrEmpty(strItemValue) == true) continue;
                string strItemName = clsResourceTypeBL.GetResourceTypeNameByIdResourceTypeCache(strItemValue);
                
                sbAnswerMultiOptions.AppendFormat("{0}|", strItemName);
            }
            if (sbAnswerMultiOptions.Length > 1)
            {
                sbAnswerMultiOptions.Remove(sbAnswerMultiOptions.Length - 1, 1);
            }
            return sbAnswerMultiOptions.ToString();
        }
    }
}
