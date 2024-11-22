using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsQryRegionFldsENEx : clsQryRegionFldsEN
    {
        public clsQryRegionFldsENEx()
            : base()
        {
        }
        //public List<clsFieldTabENEx> arrFieldTabExObjLst1Bak = null;			//界面相关详细表字段集合

        public clsPrjTabFldENEx objPrjTabFldENEx = null;
        public clsCtlTypeAbbrEN objCtlTypeAbbr = null;
        private string mstrCtlName4Win;

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
                return CommProgramSet.clsComm.FstLcaseS(this.objPrjTabFldENEx.ObjFieldTabENEx.FldName.ToLower());
            }
        }
        public string SelectListItemName
        {
            get; set;
        }

        public string CtlTypeENName
        {
            get
            {
                return this.objCtlTypeAbbr.CtlTypeENName;
            }
        }
        public string CtrlId4Win
        {
            get
            {
                mstrCtrlId = this.objCtlTypeAbbr.CtlTypeAbbr + this.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

                return mstrCtrlId.Replace("ddl", "cbo");
            }
            set
            {
                mstrCtrlId = value;
            }
        }

        private string mstrCtrlId;

        public string CtrlId
        {
            get
            {
                mstrCtrlId = this.objCtlTypeAbbr.CtlTypeAbbr + this.objPrjTabFldENEx.ObjFieldTabENEx.FldName + "_q";
                return mstrCtrlId;
            }
            set { mstrCtrlId = value; }
        }
        public string FldName
        {
            get
            {
                return this.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
            }
        }
        public string PropertyName
        {
            get
            {
                return this.objPrjTabFldENEx.ObjFieldTabENEx.FldName + "_q";
            }
        }
        public string TabName
        {
            get
            {
                return this.objPrjTabFldENEx.TabName;
            }
        }
       
        public string DS_TabName { get; set; }
    }
}
