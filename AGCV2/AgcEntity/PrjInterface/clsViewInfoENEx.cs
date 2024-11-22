﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.common;
using AgcCommBase;
using AGC.Entity;

namespace AGC.Entity
{
    public class clsViewInfoENEx : clsViewInfoEN
    {
        public clsViewGroupENEx objViewGroupEx_Java = null;
        //public List<clsFieldTabENEx> arrFieldTabExObjLst1Bak = null;			//界面相关详细表字段集合

        public List<clsPrjTabFldENEx> arrKeyPrjTabFldSet = null;

        public IEnumerable<clsPrjTabFldENEx> arrRelaMainTabFldSet = null;
        public List<clsPrjTabFldENEx> arrRelaDetailTabFldSet = null;
        //public List<clsListViewRegionFldsENEx> arrListViewRegionFldSet = null;
        public List<clsQryRegionFldsENEx> arrQryRegionFldSet = null;
        public List<clsDGRegionFldsENEx> arrDGRegionFldSet = null;
        public List<clsEditRegionFldsENEx> arrEditRegionFldSet = null;

        public List<clsExcelExportRegionFldsENEx> arrExcelExportRegionFldSet = null;
        public List<clsEditRegionFldsENEx> arrDetailRegionFldSet = null;
        public List<clsFeatureRegionFldsENEx> arrFeatureRegionFlds = null;
        public List<clsvViewFeatureFldsENEx> arrvViewFeatureFlds = null;
        public List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeSetByFeatureLst = null;

        public List<clsPrjFeatureENEx> arrPrjFeature = null;
        public List<clsButtonTabENEx> arrButtonTab = null;
        public List<clsvViewReferFilesENEx> arrvViewReferFiles = null;
        public List<clsViewRegionENEx> arrViewRegion = null;

        public List<string> arrFeatureId = null;

        public clsViewGroupEN objViewGroupEx = null;
        public clsViewStyleEN objViewStyleEN = null;

        public clsPrjTabEN objMainPrjTab = null;
        public clsPrjTabEN objInRelaTab = null;
        public clsPrjTabEN objOutRelaTab = null;

        public clsPrjTabFldENEx objMainTabKeyField = null;
        public clsPrjTabFldENEx objMainOrderNumField = null;
        public clsPrjTabFldENEx objSortField_Out = null;

        public clsPrjTabFldENEx objMainDelSignField = null;
        public clsPrjTabFldENEx objMainNameField = null;

        public clsPrjTabFldENEx objDetailTabKeyField = null;

        public clsViewTypeCodeTabEN objViewTypeCodeTab = null;


        public clsDGRegionENEx objDGRegionENEx = null;
        public clsQueryRegionENEx objQueryRegionENEx = null;
        public clsEditRegionENEx objEditRegionENEx = null;
        //public clsListViewRegionENEx objListViewRegionENEx = null;
        public clsFeatureRegionENEx objFeatureRegionENEx = null;
        public clsExcelExportRegionENEx objExcelExportRegionENEx = null;
        
        public clsProjectsEN objProjectsEN = null;
        public clsFuncModule_AgcEN objFuncModuleEN = null;

        public clsViewInfoENEx(string strViewId)
            : base(strViewId)
        {

        }
        /// <summary>
        /// 输入表的关键字
        /// </summary>
        public string KeyName_In { get; set; }
        /// <summary>
        /// 输出表的关键字
        /// </summary>
        public string KeyName_Out { get; set; }
        /// <summary>
        /// 代码类型Id
        /// </summary>
        public string CodeTypeId { get; set; }
        public clsCodeTypeEN objCodeType { get; set; }

        public int ErrNo { get; set; }

        protected string mstrBackupFolderName; // '文件目录名
        /// <summary>
        /// 备份的文件目录
        /// </summary>
        public string BackupFolderName
        {
            get { return mstrBackupFolderName; }
            set { mstrBackupFolderName = value; }
        }

        //private string mstrNetVersion;//NET的版本，主要区分NET2003和NET2005
        private bool mbolIsDesign;//针对NET2005有设计文件

        public bool IsDesign
        {
            get { return mbolIsDesign; }
            set { mbolIsDesign = value; }
        }
        private clsPubConst.LangType mstrLangType = clsPubConst.LangType.CSharp;// "C#.NET";

        public clsPubConst.LangType LangType
        {
            get { return mstrLangType; }
            set { mstrLangType = value; }
        }

       
        //public string NetVersion
        //{
        //    get { return mstrNetVersion; }
        //    set { mstrNetVersion = value; }
        //}

        private bool mbolIsUseCtl;
        public bool IsUseCtl
        {
            set
            {
                mbolIsUseCtl = value;
            }
            get
            {
                return mbolIsUseCtl;
            }
        }


        private clsPubConst.MainSubViewType mstrMainSubViewType;
        public clsPubConst.MainSubViewType MainSubViewType
        {
            set
            {
                mstrMainSubViewType = value;
            }
            get
            {
                return mstrMainSubViewType;
            }
        }

        private string mstrFirstSortField;  //第一个排序的字段

        public string FirstSortField
        {
            get
            {
                return mstrFirstSortField;
            }
            set
            {
                mstrFirstSortField = value;
            }
        }
        
        public string ApplicationTypeId2 { get; set; }
                     

        public string WinUserCtlCsFName { get; set; }
       

        private string mstrWebUserCtlFName = "";

        public string WebUserCtlFName { get; set; }
               
        public string WebUserCtlClassName { get; set; }
             
        public string WebFormName { get; set; }

        public string MvcControllerName { get; set; }
        public string MvcModelExName { get; set; }

        public string MvcModel4QueryName { get; set; }
        public string MvcModel4FeatureName { get; set; }


        private string mstrWebFormFName;

        public string WebFormFName
        {
            get { return mstrWebFormFName; }
            set { mstrWebFormFName = value; }
        }

        private string mstrFolderName;
        /// <summary>
        /// 目录名
        /// </summary>
        public string FolderName
        {
            get { return mstrFolderName; }
            set { mstrFolderName = value; }
        }

        /// <summary>
        /// 用于输出的表名
        /// </summary>
        public string TabName_Out
        {
            get { return this.objOutRelaTab.TabName; }
        }
        /// <summary>
        /// 用户于输入的表名
        /// </summary>
        public string TabName_In
        {
            get { return this.objInRelaTab.TabName; }
        }
        /// <summary>
        /// 界面的主表名称
        /// </summary>
        public string TabName
        {
            get { return this.objMainPrjTab.TabName; }
        }
        /// <summary>
        /// 界面的主表中文名
        /// </summary>
        public string TabCnName
        {
            get { return this.objMainPrjTab.TabCnName; }
        }

        private string mstrWebUserCtlCsFName;

        public string WebUserCtlCsFName
        {
            get { return mstrWebUserCtlCsFName; }
            set { mstrWebUserCtlCsFName = value; }
        }


        private string mstrNameSpace;

        public string NameSpace
        {
            get { return mstrNameSpace; }
            set { mstrNameSpace = value; }
        }
        private string mstrClsName;

        public string ClsName
        {
            get { return mstrClsName; }
            set { mstrClsName = value; }
        }
        public string BaseClsName { get; set; }
        //private string mstrWebFormCsFName;

        //public string WebFormCsFName
        //{
        //    get { return mstrWebFormCsFName; }
        //    set { mstrWebFormCsFName = value; }
        //}
        private string mstrFolderName_Root;

        public string FolderName_Root
        {
            get { return mstrFolderName_Root; }
            set { mstrFolderName_Root = value; }
        }
        private string mstrCurrDate;

        public string CurrDate
        {
            get { return mstrCurrDate; }
            set { mstrCurrDate = value; }
        }

        private string mstrCurrUserName;

        public string CurrUserName
        {
            get { return mstrCurrUserName; }
            set { mstrCurrUserName = value; }
        }

        /// <summary>
        /// 关键字字段名的列表串,附带双引号
        /// </summary>
        public string KeyFldNameLstStrWithQuote
        {
            get
            {
                List<string> arrKeyFldNameLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyPrjTabFldSet)
                {
                    arrKeyFldNameLst.Add(string.Format("\"{0}\"", objField.ObjFieldTabENEx.FldName));
                }
                string strKeyFldNameLst = clsArray.GetSqlInStrByArray(arrKeyFldNameLst, false);
                return strKeyFldNameLst;
            }
        }

        /// <summary>
        /// 关键字函数变量的列表串
        /// </summary>
        public string KeyPrivFuncFldNameLstStr
        {
            get
            {
                List<string> arrKeyPrivFuncFldNameLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyPrjTabFldSet)
                {
                    arrKeyPrivFuncFldNameLst.Add(objField.ObjFieldTabENEx.PrivFuncName);
                }
                string strKeyPrivFuncFldNameLst = clsArray.GetSqlInStrByArray(arrKeyPrivFuncFldNameLst, false);
                return strKeyPrivFuncFldNameLst;
            }
        }
        /// <summary>
        /// 关键字字段名的列表串
        /// </summary>
        public string KeyFldNameLstStr
        {
            get
            {
                List<string> arrKeyFldNameLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyPrjTabFldSet)
                {
                    arrKeyFldNameLst.Add(objField.ObjFieldTabENEx.FldName);
                }
                string strKeyFldNameLst = clsArray.GetSqlInStrByArray(arrKeyFldNameLst, false);
                return strKeyFldNameLst;
            }
        }

        private int mintTabKeyFldNum;

        public int TabKeyFldNum
        {
            get { return mintTabKeyFldNum; }
            set { mintTabKeyFldNum = value; }
        }

        /// <summary>
        /// 关键字变量定义的列表串
        /// </summary>
        public string KeyVarDefineLstStr
        {
            get
            {
                List<string> arrKeyVarDefLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyPrjTabFldSet)
                {
                    arrKeyVarDefLst.Add(objField.ObjFieldTabENEx.KeyVarDefineStr);
                }
                string strKeyVarDefLst = clsArray.GetSqlInStrByArray(arrKeyVarDefLst, false);
                return strKeyVarDefLst;
            }
        }

        /// <summary>
        /// 关键字变量定义的列表串
        /// </summary>
        public string MainTabPrimaryField_PrivFuncVar
        {
            get
            {
                List<string> arrKeyVarDefLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyPrjTabFldSet)
                {
                    arrKeyVarDefLst.Add(objField.ObjFieldTabENEx.PrivFuncName);
                }
                string strKeyVarDefLst = clsArray.GetSqlInStrByArray(arrKeyVarDefLst, false);
                return strKeyVarDefLst;
            }
        }

        protected int intViewFldNum;
        protected int intTabKeyFldNum;      //相关表的关键字段数

        /// <summary>
        /// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)      
        /// </summary>
        public string SQLDSTypeId
        {
            get
            {
                return this.objMainPrjTab.SQLDSTypeId;
            }
        }

        private string mstrFunctionTemplateId;
        /// <summary>
        /// 模板Id
        /// </summary>
        public string FunctionTemplateId
        {
            get
            {
                return mstrFunctionTemplateId;
            }

            set
            {
                mstrFunctionTemplateId = value;
            }
        }
        private string mstrPrjDataBaseId;

        /// <summary>
        /// 工程数据库Id
        /// </summary>
        public string PrjDataBaseId
        {
            get { return mstrPrjDataBaseId; }
            set { mstrPrjDataBaseId = value; }
        }
        #region 属性函数

        //public int TabKeyFldNum
        //{
        //    get
        //    {
        //        return intTabKeyFldNum;
        //    }
        //}
        public int ViewFldNum
        {
            get
            {
                return intViewFldNum;
            }
            set
            {
                intViewFldNum = value;
            }
        }
        #endregion
    }
}
