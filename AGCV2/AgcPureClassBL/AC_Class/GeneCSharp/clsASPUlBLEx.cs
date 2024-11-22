﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPUlBLEx
表名:ASPNETUl(00050434)
生成代码版本:2019.03.09.1
生成日期:2019/03/13 01:11:53
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCSharp
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
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
using System.Web.UI.HtmlControls;
using AGC.Entity;


namespace AGC.PureClassEx
{
    public static class clsASPUlBLEx_Static
    {

        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPUlENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPUlEx objASPUlENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();

            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                    strCodeForCs.AppendFormat("\r\n" + "<ul");

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPUlENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Style(objASPUlENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPUlENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPUlENEx, strCodeForCs);

                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPUlENEx, strCodeForCs);
                    //生成线性布局的子控件的布局方向-横向、纵向
                    //if (string.IsNullOrEmpty(objASPUlENEx.orientation) == false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
                    //        objASPUlENEx.orientation);
                    //}
                    strCodeForCs.AppendFormat(">");

                    foreach (ASPControlEx objSubASPControlENEx in objASPUlENEx.arrSubAspControlLst2)
                    {
                        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "</ul>");

                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
               
                    strCodeForCs.AppendFormat("\r\n" + "<ul");

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPUlENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Style(objASPUlENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPUlENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPUlENEx, strCodeForCs);

                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPUlENEx, strCodeForCs);
                    //生成线性布局的子控件的布局方向-横向、纵向
                    //if (string.IsNullOrEmpty(objASPUlENEx.orientation) == false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
                    //        objASPUlENEx.orientation);
                    //}
                    strCodeForCs.AppendFormat(">");

                    foreach (ASPControlEx objSubASPControlENEx in objASPUlENEx.arrSubAspControlLst2)
                    {
                        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "</ul>");

                    break;
                case enumApplicationType.SpaAppInCore_TS_18:
                case enumApplicationType.VueAppInCore_TS_30:
                    strCodeForCs.AppendFormat("\r\n" + "<ul");

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPUlENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Style(objASPUlENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPUlENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPUlENEx, strCodeForCs);

                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPUlENEx, strCodeForCs);
                    //生成线性布局的子控件的布局方向-横向、纵向
                    //if (string.IsNullOrEmpty(objASPUlENEx.orientation) == false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
                    //        objASPUlENEx.orientation);
                    //}
                    strCodeForCs.AppendFormat(">");

                    foreach (ASPControlEx objSubASPControlENEx in objASPUlENEx.arrSubAspControlLst2)
                    {
                        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "</ul>");

                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }

   
        }

        //public static void GeneCode4Html(this ASPUlEx objASPUlENEx, enumApplicationType intApplicationTypeId,
        //   StringBuilder strCodeForCs)
        //{
        //    string strActionId = AgcPubFun.getASPNETID();

        //    strCodeForCs.AppendFormat("\r\n" + "<ul");

        //    //生成控件的Id、Name
        //    clsASPControlBLEx.GC4IdName(objASPUlENEx, strCodeForCs);

        //    //生成控件的Tag
        //    clsASPControlBLEx.GC4Style(objASPUlENEx, strCodeForCs);

        //    //生成控件的Tag
        //    clsASPControlBLEx.GC4Tag(objASPUlENEx, strCodeForCs);

        //    //生成控件的尺寸-高、宽
        //    clsASPControlBLEx.GC4Size(objASPUlENEx, strCodeForCs);

        //    //生成控件的边界尺寸-即与四周的距离
        //    clsASPControlBLEx.GC4Margin(objASPUlENEx, strCodeForCs);
        //    //生成线性布局的子控件的布局方向-横向、纵向
        //    //if (string.IsNullOrEmpty(objASPUlENEx.orientation) == false)
        //    //{
        //    //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
        //    //        objASPUlENEx.orientation);
        //    //}
        //    strCodeForCs.AppendFormat(">");

        //    foreach (ASPControlEx objSubASPControlENEx in objASPUlENEx.arrSubAspControlLst2)
        //    {
        //        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
        //        objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
        //    }
        //    strCodeForCs.AppendFormat("\r\n" + "</ul>");

        //}

        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPUlENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode4Mvc(this ASPUlEx objASPUlENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();

            strCodeForCs.AppendFormat("\r\n" + "<ul");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPUlENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Style(objASPUlENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPUlENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPUlENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPUlENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            //if (string.IsNullOrEmpty(objASPUlENEx.orientation) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
            //        objASPUlENEx.orientation);
            //}
            strCodeForCs.AppendFormat(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPUlENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode4Mvc(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</ul>");

        }



        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPUlENEx">编辑文本框对象</param>      
        public static void GeneHtmlControl(this ASPUlEx objASPUlENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();

            HtmlGenericControl objUl = new HtmlGenericControl("ul");
            objUl.Attributes["class"] = objASPUlENEx.Class;
            objUl.ID = objASPUlENEx.CtrlId;
            objContainer.Controls.Add(objUl);
            foreach (ASPControlEx objSubASPControlENEx in objASPUlENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneHtmlControl(objUl);

            }
            //return objUl;
        }

    }
    /// <summary>
    /// ASPNET无序列表(ASPNETUl)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsASPUlBLEx
    {

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPUlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPUlEx objASPUlENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private Div tw{0};",
                objASPUlENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPUlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPUlEx objASPUlENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "tw{0} = (Div)findViewById(R.id.tw{0}); ",
                objASPUlENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPUlENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPUlEx objASPUlENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "tw{0} = (Div)view.findViewById(R.id.tw{0}); ",
                objASPUlENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPUlENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPUlEx objASPUlENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPUlENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPUlENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objASPUlENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPUlENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.ObjOutRelaTab().TabName,
               objASPUlENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);
            //strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 建立[空Ul]
        /// </summary>
        /// <returns></returns>
        public static ASPUlEx GetEmptyUl()
        {
            ASPUlEx objASPUlENEx = new ASPUlEx();
            //objASPUlENEx.CtrlId = "tr1";         
            //objASPUlENEx.Style = "width: 100%; height: 32px; ";
            //objASPUlENEx.Class = "msgtable";
            return objASPUlENEx;
        }

        public static ASPUlEx GetObj4DetailRegion()
        {
            ASPUlEx objASPUlENEx = new ASPUlEx();
            objASPUlENEx.CtrlId = "ulDetail";
            objASPUlENEx.Class = "nav";
            return objASPUlENEx;
        }
        public static ASPUlEx GetObj4DetailRegion_V()
        {
            ASPUlEx objASPUlENEx = new ASPUlEx();
            objASPUlENEx.CtrlId = "ulDetail";
            objASPUlENEx.Class = "";//"nav";
            return objASPUlENEx;
        }



        public static ASPUlEx PackageByUl4DetailRegion_H(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion();
            //封装Td
            List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageLi).ToList();

            //int intCount = 0;
            //ASPLiEx objLi = new ASPLiEx();
            Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor2.IsCaption == true)
                    {
                        objInFor2.Class += " nav-item ml-1";
                    }
                    else
                    {
                        objInFor2.Class += " nav-item ml-2";
                    }
                    objUl.arrSubAspControlLst2.Add(objInFor2);
                }
            }
           
            return objUl;
        }

        //public static ASPUlEx PackageByUl4DetailRegion_H(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion();
        //    //封装Td
        //    List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsVueControlGroupBLEx.PackageLi).ToList();

        //    //int intCount = 0;
        //    //ASPLiEx objLi = new ASPLiEx();
        //    Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
        //    foreach (VueControlGroupEx objInFor in arrASPControlGroupObjLst)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objInFor2.Class += " nav-item ml-1";
        //            }
        //            else
        //            {
        //                objInFor2.Class += " nav-item ml-2";
        //            }
        //            objUl.arrSubAspControlLst2.Add(objInFor2);
        //        }
        //    }

        //    return objUl;
        //}


        public static ASPUlEx PackageByUl4EditRegion_H(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion();
            //封装Td
            List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageLi).ToList();

            //int intCount = 0;
            //ASPLiEx objLi = new ASPLiEx();
            Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor2.IsCaption == true)
                    {
                        objInFor2.Class += " nav-item ml-1";
                    }
                    else
                    {
                        objInFor2.Class += " nav-item ml-2";
                    }
                    objUl.arrSubAspControlLst2.Add(objInFor2);
                }
            }

            return objUl;
        }
        //public static ASPUlEx PackageByUl4EditRegion_H(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion();
        //    //封装Td
        //    List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsVueControlGroupBLEx.PackageLi).ToList();

        //    //int intCount = 0;
        //    //ASPLiEx objLi = new ASPLiEx();
        //    Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
        //    foreach (VueControlGroupEx objInFor in arrASPControlGroupObjLst)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objInFor2.Class += " nav-item ml-1";
        //            }
        //            else
        //            {
        //                objInFor2.Class += " nav-item ml-2";
        //            }
        //            objUl.arrSubAspControlLst2.Add(objInFor2);
        //        }
        //    }

        //    return objUl;
        //}



        public static ASPUlEx PackageByUl4QueryRegion_H(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion();
            //封装Td
            List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageLi).ToList();

            //int intCount = 0;
            //ASPLiEx objLi = new ASPLiEx();
            Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor2.IsCaption == true)
                    {
                        objInFor2.Class += " nav-item ml-1";
                    }
                    else
                    {
                        objInFor2.Class += " nav-item ml-2";
                    }
                    objUl.arrSubAspControlLst2.Add(objInFor2);
                }
            }

            return objUl;
        }

        //public static ASPUlEx PackageByUl4QueryRegion_H(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion();
        //    //封装Td
        //    List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsVueControlGroupBLEx.PackageLi).ToList();

        //    //int intCount = 0;
        //    //ASPLiEx objLi = new ASPLiEx();
        //    Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
        //    foreach (VueControlGroupEx objInFor in arrASPControlGroupObjLst)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objInFor2.Class += " nav-item ml-1";
        //            }
        //            else
        //            {
        //                objInFor2.Class += " nav-item ml-2";
        //            }
        //            objUl.arrSubAspControlLst2.Add(objInFor2);
        //        }
        //    }

        //    return objUl;
        //}


        public static ASPUlEx PackageByUl4DetailRegion_V(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion_V();
            objUl.Class = "list-unstyled";
            //封装Td
            List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageLi).ToList();

            Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    objUl.arrSubAspControlLst2.Add(objInFor2);
                    if (objInFor2.IsCaption == true)
                    {
                        objInFor2.Class += " mt-2";
                    }
                    else
                    {
                        objInFor2.Class += " mt-0";
                    }
                }
            }

            return objUl;
        }

        //public static ASPUlEx PackageByUl4DetailRegion_V(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion_V();
        //    objUl.Class = "list-unstyled";
        //    //封装Td
        //    List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsVueControlGroupBLEx.PackageLi).ToList();

        //    Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
        //    foreach (VueControlGroupEx objInFor in arrASPControlGroupObjLst)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            objUl.arrSubAspControlLst2.Add(objInFor2);
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objInFor2.Class += " mt-2";
        //            }
        //            else
        //            {
        //                objInFor2.Class += " mt-0";
        //            }
        //        }
        //    }

        //    return objUl;
        //}


        public static ASPUlEx PackageByUl4EditRegion_V(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion_V();
            objUl.Class = "list-unstyled";
            //封装Td
            List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageLi).ToList();

            Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor.arrSubAspControlLst2.Count == 1)
                    {
                        objUl.arrSubAspControlLst2.Add(objInFor2);
                        objInFor2.Class += " mt-2";
                        continue;
                    }
                    objUl.arrSubAspControlLst2.Add(objInFor2);
                    if (objInFor2.IsCaption == true)
                    {
                        objInFor2.Class += " mt-2";
                    }
                    else
                    {
                        objInFor2.Class += " mt-0";
                    }
                }
            }

            return objUl;
        }
        //public static ASPUlEx PackageByUl4EditRegion_V(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion_V();
        //    objUl.Class = "list-unstyled";
        //    //封装Td
        //    List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsVueControlGroupBLEx.PackageLi).ToList();

        //    Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
        //    foreach (VueControlGroupEx objInFor in arrASPControlGroupObjLst)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor.arrSubAspControlLst2.Count == 1)
        //            {
        //                objUl.arrSubAspControlLst2.Add(objInFor2);
        //                objInFor2.Class += " mt-2";
        //                continue;
        //            }
        //            objUl.arrSubAspControlLst2.Add(objInFor2);
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objInFor2.Class += " mt-2";
        //            }
        //            else
        //            {
        //                objInFor2.Class += " mt-0";
        //            }
        //        }
        //    }

        //    return objUl;
        //}


        public static ASPUlEx PackageByUl4QueryRegion_V(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion_V();
            objUl.Class = "list-unstyled";
            //封装Td
            List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageLi).ToList();

            Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor.arrSubAspControlLst2.Count == 1)
                    {
                        objUl.arrSubAspControlLst2.Add(objInFor2);
                        objInFor2.Class += " mt-2";
                        continue;
                    }
                    objUl.arrSubAspControlLst2.Add(objInFor2);
                    if (objInFor2.IsCaption == true)
                    {
                        objInFor2.Class += " mt-2";
                    }
                    else
                    {
                        objInFor2.Class += " mt-0";
                    }
                }
            }

            return objUl;
        }

        //public static ASPUlEx PackageByUl4QueryRegion_V(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPUlEx objUl = clsASPUlBLEx.GetObj4DetailRegion_V();
        //    objUl.Class = "list-unstyled";
        //    //封装Td
        //    List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsVueControlGroupBLEx.PackageLi).ToList();

        //    Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
        //    foreach (VueControlGroupEx objInFor in arrASPControlGroupObjLst)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor.arrSubAspControlLst2.Count == 1)
        //            {
        //                objUl.arrSubAspControlLst2.Add(objInFor2);
        //                objInFor2.Class += " mt-2";
        //                continue;
        //            }
        //            objUl.arrSubAspControlLst2.Add(objInFor2);
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objInFor2.Class += " mt-2";
        //            }
        //            else
        //            {
        //                objInFor2.Class += " mt-0";
        //            }
        //        }
        //    }

        //    return objUl;
        //}

    }
}