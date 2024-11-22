using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.common;
using AgcCommBase;
using AGC.Entity;

namespace AGC.Entity
{
    public class clsPrjTabENEx : clsPrjTabEN
    {
        public List<clsFieldTabENEx> arrFieldTabExObjLst = null;			//界面相关详细表字段集合

        public List<clsPrjTabFldENEx> arrFldSet = null;
        public List<clsPrjTabFldENEx> arrFldSetAll = null;
        public List<clsPrjTabFldENEx> arrKeyFldSet = null;
        public List<clsPrjConstraintENEx> arrPrjConstraintSet = null;
        public List<clsConstraintFieldsENEx> arrConstraintFieldsSet = null;
        public List<clsTabFeatureENEx> arrTabFeatureSet = null;

        /// <summary>
        /// 关键字段的表字段对象
        /// </summary>
        public clsPrjTabFldENEx objKeyField0 = null;
        public clsPrjTabFldENEx objNameField = null;
        public clsPrjTabFldENEx objOrderNumField = null;
        public clsPrjTabFldENEx objDelSignField = null;
        public clsPrjTabFldENEx objSortField = null;

        /// <summary>
        /// 名称字段的表字段对象
        /// </summary>
        public clsPrjTabFldENEx objPrjTabFld4NameFld = null;//名称字段的表字段对象

        public clsProjectsEN objProjectsEN = null;
        public clsFuncModule_AgcEN objFuncModuleEN = null;

        private string mstrFunctionTemplateId;

        //    private string mstrProgLevelTypeId;

        //private string mstrModuleName;

        public string ModuleName { get; set; }

        public int ApplicationTypeId { get; set; }

        private string mstrClsName;

        public string ClsName
        {
            get { return mstrClsName;
                               
                    }
            set { mstrClsName = value; }
        }
        private string mstrClsNameEx;

        public string ClsNameEx
        {
            get { return mstrClsNameEx; }
            set { mstrClsNameEx = value; }
        }

        private string mstrCurrUserName;

        public string CurrUserName
        {
            get {
                return mstrCurrUserName;
            }
            set {
                mstrCurrUserName = value;
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

        //protected bool mbolIsForSilverLight;//是否针对SliverLight
        ///// <summary>
        ///// 是否针对SliverLight
        ///// </summary>
        //public bool IsForSilverLight
        //{
        //    get { return mbolIsForSilverLight; }
        //    set { mbolIsForSilverLight = value; }
        //}
        private int mintTabFldNum;

        /// <summary>
        /// 表字段数
        /// </summary>
        public int TabFldNum
        {
            get { return mintTabFldNum; }
            set { mintTabFldNum = value; }
        }
        private string mstrTabSpace;

        public string TabSpace
        {
            get { return mstrTabSpace; }
            set { mstrTabSpace = value; }
        }
        private clsPubConst.LangType mstrLangType = clsPubConst.LangType.CSharp;// "C#.NET";

        public clsPubConst.LangType LangType
        {
            get { return mstrLangType; }
            set { mstrLangType = value; }
        }


        private int mintKeyFldNum;
        /// <summary>
        /// 关键字段数
        /// </summary>
        public int KeyFldNum
        {
            get { return mintKeyFldNum; }
            set { mintKeyFldNum = value; }
        }
        public List<clsPrjTabFldENEx> arrPrjTabFldENExObjLst = null;
        public clsPrjTabENEx(string strTabId):base(strTabId)
        {

        }
        public clsPrjTabENEx(clsPrjTabEN objPrjTabEN)
        {
            this.TabId = objPrjTabEN.TabId; //表ID
            this.TabName = objPrjTabEN.TabName; //表名
            this.TabCnName = objPrjTabEN.TabCnName; //表中文名
            this.PrjId = objPrjTabEN.PrjId; //工程ID
            //this.ObjId = objPrjTabEN.ObjId; //所属对象
            this.IsNeedTransCode = objPrjTabEN.IsNeedTransCode; //是否需要转换代码
            this.SQLDSTypeId = objPrjTabEN.SQLDSTypeId; //数据源类型
            this.TabStateId = objPrjTabEN.TabStateId; //表状态ID
            this.TabName_B = objPrjTabEN.TabName_B; //表名_后备
            this.IsParaTab = objPrjTabEN.IsParaTab; //是否参数表
            this.IsNationStandard = objPrjTabEN.IsNationStandard; //是否国标
            this.IsArchive = objPrjTabEN.IsArchive; //是否存档
            this.IsChecked = objPrjTabEN.IsChecked; //是否核实
            //this.ErrMsg = objPrjTabEN.ErrMsg; //错误信息
            this.FuncModuleAgcId = objPrjTabEN.FuncModuleAgcId; //功能模块Id
            this.DataBaseName = objPrjTabEN.DataBaseName; //数据库名
            this.Owner = objPrjTabEN.Owner; //拥有者
            this.RelaTabId4View = objPrjTabEN.RelaTabId4View; //相关视图ID
            this.UpdUserId = objPrjTabEN.UpdUserId; //修改用户Id
            this.UpdDate = objPrjTabEN.UpdDate; //修改日期
            //this.GeneCodeDate = objPrjTabEN.GeneCodeDate; //生成代码日期
            this.Memo = objPrjTabEN.Memo; //说明

        }
        private string mstrCurrDate;

        public string CurrDate
        {
            get { return mstrCurrDate; }
            set { mstrCurrDate = value; }
        }

        private string mstrUserId;

        public string UserId
        {
            get { return mstrUserId; }
            set { mstrUserId = value; }
        }
        /// <summary>
        /// 字段名列表串
        /// </summary>
        public string FieldNameLstStr
        {
            get
            {
                return GetFieldNameLstStrByFieldObjLst(arrFldSet);
            }
        }
        /// <summary>
        /// 通过字段对象列表获取字段名列表串
        /// </summary>
        /// <param name="arrFieldSet">字段对象列表</param>
        /// <returns>字段名列表串</returns>
        public string GetFieldNameLstStrByFieldObjLst(List<clsPrjTabFldENEx> arrFieldSet)
        {
            List<string> arrFieldNameLst = GetFieldNameLstByFieldObjLst(arrFieldSet);
            string strFieldNameLst = clsArray.GetSqlInStrByArray(arrFieldNameLst, false);
            return strFieldNameLst;
        }

        /// <summary>
        /// 通过字段对象列表获取字段名列表
        /// </summary>
        /// <param name="arrFieldSet">字段对象列表</param>
        /// <returns>字段名列表</returns>
        public List<string> GetFieldNameLstByFieldObjLst(List<clsPrjTabFldENEx> arrFieldSet)
        {
            List<string> arrFieldNameLst = new List<string>();
            foreach (clsPrjTabFldENEx objField in arrFieldSet)
            {
                arrFieldNameLst.Add(objField.ObjFieldTabENEx.FldName);
            }
            return arrFieldNameLst;
        }

        /// <summary>
        /// 关键字字段名的列表串
        /// </summary>
        public string KeyFldNameLstStr
        {
            get
            {
                List<string> arrKeyFldNameLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    arrKeyFldNameLst.Add(objField.ObjFieldTabENEx.FldName);
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
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    arrKeyPrivFuncFldNameLst.Add(objField.ObjFieldTabENEx.PrivFuncName);
                }
                string strKeyPrivFuncFldNameLst = clsArray.GetSqlInStrByArray(arrKeyPrivFuncFldNameLst, false);
                return strKeyPrivFuncFldNameLst;
            }
        }
        /// <summary>
        /// 关键字变量定义的列表串
        /// </summary>
        public string KeyVarDefineLstStr
        {
            get
            {
                List<string> arrKeyVarDefLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    arrKeyVarDefLst.Add(objField.ObjFieldTabENEx.KeyVarDefineStr);
                }
                string strKeyVarDefLst = clsArray.GetSqlInStrByArray(arrKeyVarDefLst, false);
                return strKeyVarDefLst;
            }
        }

        public string Keys
        {
            get
            {
                string strT;
                int i = 0;
                strT = "";
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    if (i == 0)//是否是第一次
                    {

                        strT += objField.ObjFieldTabENEx.FldName;
                    }
                    else
                    {
                        strT += "," + objField.ObjFieldTabENEx.FldName;
                    }
                    i++;
                }
                return strT;

            }
        }


        protected int intViewFldNum;
        protected int intTabKeyFldNum;		//相关表的关键字段数
        #region 属性函数

        public int TabKeyFldNum
        {
            get
            {
                return intTabKeyFldNum;
            }
        }
        public int ViewFldNum
        {
            get
            {
                return intViewFldNum;
            }
        }

        protected string mstrFolderName_Root; // '根文件目录名

        public string FolderName_Root
        {
            get { return mstrFolderName_Root; }
            set { mstrFolderName_Root = value; }
        }

        protected string mstrBackupFolderName; // '文件目录名
        /// <summary>
        /// 备份的文件目录
        /// </summary>
        public string BackupFolderName
        {
            get { return mstrBackupFolderName; }
            set { mstrBackupFolderName = value; }
        }


        private bool mbolIsHaveImageField;

        public bool IsHaveImageField
        {
            get { return mbolIsHaveImageField; }
            set { mbolIsHaveImageField = value; }
        }


        private string mstrImageFieldName;

        public string ImageFieldName
        {
            get { return mstrImageFieldName; }
            set { mstrImageFieldName = value; }
        }

        private string mstrSimpleFileName;

        public string SimpleFileName
        {
            get { return mstrSimpleFileName; }
            set { mstrSimpleFileName = value; }
        }


        private string mstrFolderName;
        public string FolderName
        {
            get
            {
                return mstrFolderName; // '文件目录名
            }
            set
            {
                mstrFolderName = value;
            }
        }
        private string mstrFileName;
        public string FileName
        {
            get
            {
                return mstrFileName;
            }
            set
            {
                mstrFileName = value;
            }
        }
        public string TabName_Java
        {
            get
            {
                return CommProgramSet.clsComm.FstLcaseS(mstrTabName);
            }
        }

    
        /// <summary>
        /// 编程层类型
        /// 日期：20160530
        /// 作者：潘以锋
        /// </summary>
        public string CodeTypeId
        {
            get;
            set;
        }
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
        #endregion


    }
}
