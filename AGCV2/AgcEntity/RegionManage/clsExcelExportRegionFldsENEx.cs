using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsExcelExportRegionFldsENEx : clsExcelExportRegionFldsEN
    {
        public clsExcelExportRegionFldsENEx()
            : base()
        {
        }
        private clsPrjTabFldENEx objPrjTabFldENEx = null;
        public clsCtlTypeAbbrEN objCtlTypeAbbr = null;
        public string FldName_Java
        {
            get
            {
                return CommProgramSet.clsComm.FstLcaseS(this.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName.ToLower());
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

        public clsPrjTabFldENEx ObjPrjTabFldENEx
        {
            get
            {
                if (objPrjTabFldENEx == null)
                {
                    string strMsg = "表字段扩展(PrjTabFldEx)对象没有被初始化！";
                    throw new Exception(strMsg);
                }
                return objPrjTabFldENEx;

            }
            set => objPrjTabFldENEx = value;
        }
       
    }
}
