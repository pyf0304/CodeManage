using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.commexception;
using com.taishsoft.common;
using AGC.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public partial class clsEditRegionBLEx 
    {
     
        /// <summary>
        /// ��������Id��ȡ�û������������ر�Id
        /// </summary>
        /// <param name="lngRegionId"></param>
        /// <returns></returns>
        public static List<string> getRelaTabId4Ddl(string lngRegionId, bool bolIsFstLcase, string strCmPrjId)
        {
            string strCondition = string.Format("{0}={1}", 
                conEditRegionFlds.RegionId, lngRegionId);

            List<string> arrTabId = new List<string>();
            List<clsEditRegionFldsENEx> arrObjENExList = clsEditRegionFldsBLEx.GetObjExLstByRegionId4InUse1(lngRegionId, bolIsFstLcase, strCmPrjId);
            
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in arrObjENExList)
            {
                if (objEditRegionFldsENEx.CtlTypeId != enumCtlType.DropDownList_06) continue;
                string strTabId = objEditRegionFldsENEx.DsTabId;
                if (string.IsNullOrEmpty(strTabId) == true) continue;
                if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
            }

            return arrTabId;
        }

        //public void InitViewRegion(clsEditRegionENEx objEditRegionENEx)
        //{
        //    objEditRegionENEx.objViewRegionEN = clsViewRegionBL.GetObjByRegionId(objEditRegionENEx.RegionId);
        //}


    }
}