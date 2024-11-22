﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAndroidSpinnerBLEx
表名:AndroidSpinner
生成代码版本:2018.03.11.1
生成日期:2018/03/13 12:01:52
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
    public static class clsAndroidSpinnerBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objAndroidSpinnerENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this AndroidSpinnerEx objAndroidSpinnerENEx, enumApplicationType intApplicationTypeId,
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
            if (string.IsNullOrEmpty(objAndroidSpinnerENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objAndroidSpinnerENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<Spinner");
            strCodeForCs.AppendFormat("\r\n" + "android:id=\"@+id/{0}\"",
                objAndroidSpinnerENEx.CtrlId);
            //生成控件的Tag
            clsAndroidControlBLEx.GC4Tag(objAndroidSpinnerENEx, strCodeForCs);

            //生成控件的样式
            clsAndroidControlBLEx.GC4Style(objAndroidSpinnerENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsAndroidControlBLEx.GC4Size(objAndroidSpinnerENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsAndroidControlBLEx.GC4Margin(objAndroidSpinnerENEx, strCodeForCs);

            //if (string.IsNullOrEmpty(objAndroidSpinnerENEx.OnClick) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
            //        objAndroidSpinnerENEx.OnClick);
            //}
            strCodeForCs.AppendFormat("\r\n" + "android:text=\"{0}\"",
                objAndroidSpinnerENEx.Text);
            if (string.IsNullOrEmpty(objAndroidSpinnerENEx.entries) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:entries=\"{0}\"",
                    objAndroidSpinnerENEx.entries);
            }
            //if (objAndroidSpinnerENEx.ems > 0)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:ems=\"{0}\"",
            //        objAndroidSpinnerENEx.ems);
            //}
            //生成控件的约束-即与四周控件的约束关系
            clsAndroidControlBLEx.GC4Constraint(objAndroidSpinnerENEx, strCodeForCs);

            strCodeForCs.AppendFormat("/>");

            //foreach (AndroidControlEx objSubAndroidControlENEx in objAndroidSpinnerENEx.arrSubAndroidControlLst2)
            //{
            //    //if (objSubAndroidControlENEx.CtlTypeId != enumCtlType.AndroidAutoresizingMask) continue;
            //    objSubAndroidControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            //}


        }
    }
        /// <summary>
        /// Android下拉框(AndroidSpinner)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsAndroidSpinnerBLEx 
    {
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(AndroidSpinnerEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private Spinner {0};",
                objAndroidSpinnerENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(AndroidSpinnerEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Spinner)findViewById(R.id.{0}); ",
                objAndroidSpinnerENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(AndroidSpinnerEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Spinner)view.findViewById(R.id.{0}); ",
                objAndroidSpinnerENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(AndroidSpinnerEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;
            string strDdlTabName = objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTabName();

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, 
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n" + "String {0} = mobjddlBind{1}.getDdlAdapter{1}().get{2}((int){3}.getSelectedItemId());",
                             objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().PrivFuncName(),
                             strDdlTabName,
                             objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName,
                         objAndroidSpinnerENEx.CtrlId);

            //strCodeForCs.AppendFormat("\r\n" + "String {0} = (String){1}.getSelectedItem();",
            //  objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().PrivFuncName(),
            //  objAndroidSpinnerENEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n" + " if ({0} == null) return \"\";",
              objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().PrivFuncName());
            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                              string.Format("{0}", objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().PrivFuncName())));


            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(AndroidSpinnerEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName;
            string strDdlTabName = objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTabName();
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, 
                strTemp);
            strCodeForCs.Append("\r\n {");
            //String strCollegeId = mobjddlBindCollege.getDdlAdapterCollege().getCollegeId((int)spnCollegeId.getSelectedItemId());

            strCodeForCs.AppendFormat("\r\n" + "String {0} = mobjddlBind{1}.getDdlAdapter{1}().get{2}((int){3}.getSelectedItemId());",
                                objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().PrivFuncName(),
                                strDdlTabName,
                                objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName,
                            objAndroidSpinnerENEx.CtrlId);
            strCodeForCs.AppendFormat("\r\n" + " if ({0} == null) return \"\";",
                objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().PrivFuncName());

            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                              string.Format("{0}", objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().PrivFuncName())));

            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(AndroidSpinnerEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;
           
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setSelection(1);",
                objAndroidSpinnerENEx.CtrlId,
                AgcPubFun.getToStringCode4DataType4Java(objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(AndroidSpinnerEx objAndroidSpinnerENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName;
            
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setSelection(1);",
 objAndroidSpinnerENEx.CtrlId,
 AgcPubFun.getToStringCode4DataType4Java(objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(AndroidSpinnerEx objAndroidSpinnerENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.ObjOutRelaTab().TabName,
               objAndroidSpinnerENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);
            //strCodeForCs.Append("\r\n }");
        }
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdlBak20180403(AndroidSpinnerEx objAndroidSpinnerENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objAndroidSpinnerENEx.objEditRegionFldsEN != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                strCodeForCs.AppendFormat("\r\n" + "ac{0}_UnitTestEx.BindDdl{1}(spn{1}, this);",
                   strTabName_Ddl,
                   objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);
            }
            if (objAndroidSpinnerENEx.objQryRegionFldsEN != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                strCodeForCs.AppendFormat("\r\n" + "ac{0}_UnitTestEx.BindDdl{1}(spn{1}, this);",
                   strTabName_Ddl,
                   objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);
            }

        }

        /// <summary>
        /// 绑定下拉框 
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdl(AndroidSpinnerEx objAndroidSpinnerENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objAndroidSpinnerENEx.objEditRegionFldsEN != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTabName();

                strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindDdl{0}\", {1}, mobjddlBind{0});",
                   strTabName_Ddl,
                   objAndroidSpinnerENEx.CtrlId);

            }
            if (objAndroidSpinnerENEx.objQryRegionFldsEN != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                
                strCodeForCs.AppendFormat("\r\n" + "AddTask(\"BindDdl{0}_q\", {1}, mobjddlBind{0});",
                   strTabName_Ddl,
                   objAndroidSpinnerENEx.CtrlId);

            }

        }

        /// <summary>
        /// 绑定下拉框, 在任务队列中 
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_BindDdlInTaskQueue(AndroidSpinnerEx objAndroidSpinnerENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            if (objAndroidSpinnerENEx.objEditRegionFldsEN != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                string strValueFld = objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTab_Code();
                strCodeForCs.AppendFormat("\r\n" + "case \"BindDdl{0}\":", strTabName_Ddl);

                strCodeForCs.AppendFormat("\r\n" + "ddlBind{0} objDdlBind{0} = (ddlBind{0})myTask.getDdlBind();",
                    strTabName_Ddl);                
                strCodeForCs.AppendFormat("\r\n" + "objDdlBind{0}.BindDdl{1}(myTask.getSpinner(), myTask.getActivity());",
                    strTabName_Ddl, strValueFld);
                strCodeForCs.Append("\r\n" + "break;");


            }
            if (objAndroidSpinnerENEx.objQryRegionFldsEN != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                string strValueFld = objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTab_Code();

                strCodeForCs.AppendFormat("\r\n" + "case \"BindDdl{0}_q\":", strTabName_Ddl);

                strCodeForCs.AppendFormat("\r\n" + "ddlBind{0} objDdlBind{0}_q = (ddlBind{0})myTask.getDdlBind();",
                    strTabName_Ddl);
                strCodeForCs.AppendFormat("\r\n" + "objDdlBind{0}_q.BindDdl{1}(myTask.getSpinner(), myTask.getActivity());",
                    strTabName_Ddl, strValueFld);
                strCodeForCs.Append("\r\n" + "break;");


            }

        }


        /// <summary>
        /// 绑定下拉框 
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>        
        /// <param name="strCodeForCs"></param>
        /// <param name="arrDdlBindObjLst"></param>
        public static void Gen_DefDdlBindObj(AndroidSpinnerEx objAndroidSpinnerENEx, StringBuilder strCodeForCs, List<string> arrDdlBindObjLst)
        {
            if (objAndroidSpinnerENEx.objEditRegionFldsEN != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                string strDdlBindObjName = string.Format("mobjddlBind{0}", strTabName_Ddl);
                if (arrDdlBindObjLst.Contains(strDdlBindObjName) == false)
                {
                    arrDdlBindObjLst.Add(strDdlBindObjName);
                    strCodeForCs.AppendFormat("\r\n" + "private ddlBind{0} {1} = null;",
                       strTabName_Ddl,
                       strDdlBindObjName);
                }
            }
            if (objAndroidSpinnerENEx.objQryRegionFldsEN != null)
            {
                string strTabName_Ddl = objAndroidSpinnerENEx.objQryRegionFldsEN.ObjFieldTab_PC().CodeTabName();
                string strDdlBindObjName = string.Format("mobjddlBind{0}", strTabName_Ddl);
                if (arrDdlBindObjLst.Contains(strDdlBindObjName) == false)
                {
                    arrDdlBindObjLst.Add(strDdlBindObjName);
                    strCodeForCs.AppendFormat("\r\n" + "private ddlBind{0} {1} = null;",
                       strTabName_Ddl,
                       strDdlBindObjName);
                }
            }

        }


        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objAndroidSpinnerENEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(AndroidSpinnerEx objAndroidSpinnerENEx, StringBuilder strCodeForCs, string strCmPrjId)
        {
            strCodeForCs.AppendFormat("\r\n" + "{0}.setSelection(0);",
               objAndroidSpinnerENEx.CtrlId);
            strCodeForCs.AppendFormat("// {0}", objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().DataTypeName,
            objAndroidSpinnerENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldLength,
            objAndroidSpinnerENEx.objEditRegionFldsEN.IsTabNullable(strCmPrjId),
            objAndroidSpinnerENEx.objEditRegionFldsEN.MemoInTab(strCmPrjId));

        }
    }
}