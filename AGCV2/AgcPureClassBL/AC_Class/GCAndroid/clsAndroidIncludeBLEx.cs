﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidIncludeBLEx
表名:AndroidInclude
生成代码版本:2018.03.11.1
生成日期:2018/03/12 23:02:23
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:生成Android
模块英文名:GCAndroid
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;

using com.taishsoft.comm_db_obj;

using AGC.PureClass;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using AgcCommBase;
using AGC.Entity;

namespace AGC.PureClassEx
{
    public static class clsAndroidIncludeBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidIncludeENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this AndroidIncludeEx objAndroidIncludeENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
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
            string strActionId = AgcPubFun.getAndroidID();
            string strKey = "";
            if (string.IsNullOrEmpty(objAndroidIncludeENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objAndroidIncludeENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<include");
            //strCodeForCs.AppendFormat("\r\n" + "android:id=\"@android:id/{0}\"",
            //    objAndroidIncludeENEx.CtrlId);
            ////生成控件的尺寸-高、宽
            //clsAndroidControlBLEx.GC4Size(objAndroidIncludeENEx, strCodeForCs);

            ////生成控件的边界尺寸-即与四周的距离
            //clsAndroidControlBLEx.GC4Margin(objAndroidIncludeENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            if (string.IsNullOrEmpty(objAndroidIncludeENEx.layout) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "layout=\"@layout/{0}\"",
                    objAndroidIncludeENEx.layout);
            }
            if (objAndroidIncludeENEx.arrSubAndroidControlLst2.Count == 0)
            {
                strCodeForCs.AppendFormat("/>");
            }
            else
            {
                strCodeForCs.AppendFormat(">");

                foreach (AndroidControlEx objSubAndroidControlENEx in objAndroidIncludeENEx.arrSubAndroidControlLst2)
                {
                    //if (objSubAndroidControlENEx.CtlTypeId != enumCtlType.AndroidAutoresizingMask) continue;
                    objSubAndroidControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                }
                strCodeForCs.AppendFormat("\r\n" + "</Include>");
            }
        }
    }
        /// <summary>
        /// Android包含(AndroidInclude)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidIncludeBLEx 
    {


        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidIncludeENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(AndroidIncludeEx objAndroidIncludeENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private Include inc{0};",
                objAndroidIncludeENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidIncludeENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(AndroidIncludeEx objAndroidIncludeENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "inc{0} = (Include)findViewById(R.id.inc{0}); ",
                objAndroidIncludeENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidIncludeENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(AndroidIncludeEx objAndroidIncludeENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "inc{0} = (Include)view.findViewById(R.id.inc{0}); ",
                objAndroidIncludeENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidTextViewENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(AndroidTextViewEx objAndroidTextViewENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objAndroidTextViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidTextViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objAndroidTextViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidTextViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.ObjOutRelaTab().TabName,
               objAndroidTextViewENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);
            //strCodeForCs.Append("\r\n }");
        }
    }
}