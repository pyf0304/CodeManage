﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;
using com.taishsoft.common;

namespace AGC.PureClassEx
{
    public static class clsISOviewControllerLayoutGuideBLEx_Static
    {
        public static void GeneCode(this ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                    break;
                case enumApplicationType.SpaAppInCore_TS_18:
                case enumApplicationType.VueAppInCore_TS_30:
                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }
            //string strviewControllerLayoutGuideId = AgcPubFun.getSwiftID();

            strCodeForCs.AppendFormat("\r\n" + "<viewControllerLayoutGuide type=\"{1}\" id=\"{0}\"/>",
                objISOviewControllerLayoutGuideENEx.IsoControlId,
                objISOviewControllerLayoutGuideENEx.type);
            foreach (ISOControlEx objSubISOControlENEx in objISOviewControllerLayoutGuideENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            
        }
    }
}