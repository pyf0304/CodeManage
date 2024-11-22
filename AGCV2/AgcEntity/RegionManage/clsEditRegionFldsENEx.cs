using com.taishsoft.commexception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsEditRegionFldsENEx : clsEditRegionFldsEN
    {

        public clsEditRegionFldsENEx()
            : base()
        {
        }
        //public List<clsFieldTabENEx> arrFieldTabExObjLst1Bak = null;			//界面相关详细表字段集合

        private clsPrjTabFldENEx objPrjTabFldENEx = null;
        public clsCtlTypeAbbrEN objCtlTypeAbbr = null;

        public string FieldTypeId
        {
            get
            {
                return this.ObjPrjTabFldENEx.FieldTypeId;
            }
        }
        public bool IsLogUpdDateOrUpdUser
        {
            get
            {
                if (FieldTypeId == "13") return true;
                if (FieldTypeId == "14") return true;
                return false;
            }
        }
        public bool IsPrimaryKey_Identity
        {
            get
            {
                if (this.ObjPrjTabFldENEx.PrimaryTypeId == "02") return true;
                return false;
            }
        }
        public string CtrlName
        {
            get
            {
                return string.Format("btn{0}", this.mId);
            }
        }
        public string ButtonValue
        {
            get
            {
                if (InUse == true)
                {
                    return string.Format("D:{0}", this.LabelCaption);
                }
                else
                {
                    return string.Format("A:{0}", this.LabelCaption);
                }
            }
        }

        public string FldName_Java
        {
            get
            {
                return CommProgramSet.clsComm.FstLcaseS(this.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName.ToLower());
            }
        }

        public string FldName
        {
            get
            {
                return this.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
            }
        }
        public string CtrlId4Win
        {
            get
            {
                mstrCtrlId = this.objCtlTypeAbbr.CtlTypeAbbr + this.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;

                return mstrCtrlId.Replace("ddl", "cbo");
            }
            set
            {
                mstrCtrlId = value;
            }
        }
        public string SelectListItemName
        {
            get; set;
        }
        private string mstrCtrlId;

        public string CtrlId
        {
            get
            {
                mstrCtrlId = this.objCtlTypeAbbr.CtlTypeAbbr + this.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
                return mstrCtrlId;
            }
            set { mstrCtrlId = value; }
        }

        public string CtlTypeENName
        {
            get
            {
                return this.objCtlTypeAbbr.CtlTypeENName;
            }
        }
        public string CtlTypeName
        {
            get
            {
                return this.objCtlTypeAbbr.CtlTypeName;    
            }
        }
   
        /// <summary>
        /// 转换代码表
        /// </summary>
        public string CodeTab;
        ///// <summary>
        ///// 转换代码表
        ///// </summary>
        
        public string DS_TabName { get; set; }

        public string TabName
        {
            get
            {
                return this.ObjPrjTabFldENEx.TabName;
            }
        }

        public clsPrjTabFldENEx ObjPrjTabFldENEx {
            get {
                if (objPrjTabFldENEx == null)
                {
                    string strMsg = "表字段扩展(PrjTabFldEx)对象没有被初始化！";
                    throw new Exception(strMsg);
                }
                return objPrjTabFldENEx;
               
            }
            set => objPrjTabFldENEx = value; }
    }
}
