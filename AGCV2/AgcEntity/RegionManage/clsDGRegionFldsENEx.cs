using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsDGRegionFldsENEx : clsDGRegionFldsEN
    {

        public clsDGRegionFldsENEx()
            : base()
        {
        }
        //public List<clsFieldTabENEx> arrFieldTabExObjLst1Bak = null;			//界面相关详细表字段集合

        private clsPrjTabFldENEx objPrjTabFldENEx = null;
        public clsCtlTypeAbbrEN objCtlTypeAbbr = null;
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
                    return string.Format("D:{0}", this.ColCaption);
                }
                else
                {
                    return string.Format("A:{0}", this.ColCaption);
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
        private string mstrCtlName;
        public string CtlName
        {
            get
            {
                mstrCtlName = this.objCtlTypeAbbr.CtlTypeAbbr + this.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;
                return mstrCtlName;
            }
            set
            {
                mstrCtlName = value;
            }
        }
        public string CtlName4Win
        {
            get
            {
                mstrCtlName = this.objCtlTypeAbbr.CtlTypeAbbr + this.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName;

                return mstrCtlName.Replace("ddl", "cbo");
            }
            set
            {
                mstrCtlName = value;
            }
        }
     
        public string DS_TabName { get; set; }

        public string TabName
        {
            get
            {
                return this.ObjPrjTabFldENEx.TabName;
            }
        }


        public clsPrjTabFldENEx ObjPrjTabFldENEx
        {
            get
            {
                //if (objPrjTabFldENEx == null)
                //{
                //    string strMsg = "表字段扩展(PrjTabFldEx)对象没有被初始化！";
                //    throw new Exception(strMsg);
                //}
                return objPrjTabFldENEx;

            }
            set => objPrjTabFldENEx = value;
        }
    }
}
