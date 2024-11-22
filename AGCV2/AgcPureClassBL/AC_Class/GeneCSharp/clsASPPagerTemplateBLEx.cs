﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPPagerTemplateBLEx
表名:ASPNETPagerTemplate(00050228)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:56:25
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCode
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.05.31.01
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

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET分页模板(ASPNETPagerTemplate)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPPagerTemplateBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPPagerTemplateENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPPagerTemplateEx objASPPagerTemplateENEx, enumApplicationType intApplicationTypeId,
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
            string strActionId = AgcPubFun.getASPNETID();
            //string strKey = "";
            //< android.support.v7.widget.PagerTemplate
            // android: id = "@+id/toolbar"
            // android: layout_width = "match_parent"
            // android: layout_height = "?attr/actionBarSize"
            // android: background = "?attr/colorPrimary"
            // app: popupTheme = "@style/AppTheme.PopupOverlay" />

            strCodeForCs.AppendFormat("\r\n" + "<android.support.v7.widget.PagerTemplate");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPPagerTemplateENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPPagerTemplateENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPPagerTemplateENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPPagerTemplateENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            if (string.IsNullOrEmpty(objASPPagerTemplateENEx.background) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:background=\"{0}\"",
                    objASPPagerTemplateENEx.background);
            }
            if (string.IsNullOrEmpty(objASPPagerTemplateENEx.popupTheme) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:popupTheme=\"{0}\"",
                    objASPPagerTemplateENEx.popupTheme);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPPagerTemplateENEx, strCodeForCs);

            strCodeForCs.AppendFormat(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPPagerTemplateENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</android.support.v7.widget.PagerTemplate>");
        }

       // public static void GeneCode4Html(this ASPPagerTemplateEx objASPPagerTemplateENEx, enumApplicationType intApplicationTypeId,
       //StringBuilder strCodeForCs)
       // {
       //     string strActionId = AgcPubFun.getASPNETID();
       //     //string strKey = "";
       //     //< android.support.v7.widget.PagerTemplate
       //     // android: id = "@+id/toolbar"
       //     // android: layout_width = "match_parent"
       //     // android: layout_height = "?attr/actionBarSize"
       //     // android: background = "?attr/colorPrimary"
       //     // app: popupTheme = "@style/AppTheme.PopupOverlay" />

       //     strCodeForCs.AppendFormat("\r\n" + "<android.support.v7.widget.PagerTemplate");

       //     //生成控件的Id、Name
       //     clsASPControlBLEx.GC4IdName(objASPPagerTemplateENEx, strCodeForCs);

       //     //生成控件的Tag
       //     clsASPControlBLEx.GC4Tag(objASPPagerTemplateENEx, strCodeForCs);

       //     //生成控件的尺寸-高、宽
       //     clsASPControlBLEx.GC4Size(objASPPagerTemplateENEx, strCodeForCs);

       //     //生成控件的边界尺寸-即与四周的距离
       //     clsASPControlBLEx.GC4Margin(objASPPagerTemplateENEx, strCodeForCs);
       //     //生成线性布局的子控件的布局方向-横向、纵向
       //     if (string.IsNullOrEmpty(objASPPagerTemplateENEx.background) == false)
       //     {
       //         strCodeForCs.AppendFormat("\r\n" + "android:background=\"{0}\"",
       //             objASPPagerTemplateENEx.background);
       //     }
       //     if (string.IsNullOrEmpty(objASPPagerTemplateENEx.popupTheme) == false)
       //     {
       //         strCodeForCs.AppendFormat("\r\n" + "android:popupTheme=\"{0}\"",
       //             objASPPagerTemplateENEx.popupTheme);
       //     }
       //     //生成控件的约束-即与四周控件的约束关系
       //     clsASPControlBLEx.GC4Constraint(objASPPagerTemplateENEx, strCodeForCs);

       //     strCodeForCs.AppendFormat(">");

       //     foreach (ASPControlEx objSubASPControlENEx in objASPPagerTemplateENEx.arrSubAspControlLst2)
       //     {
       //         //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
       //         objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
       //     }
       //     strCodeForCs.AppendFormat("\r\n" + "</android.support.v7.widget.PagerTemplate>");
       // }
    }
        /// <summary>
        /// ASPNET分页模板(ASPNETPagerTemplate)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsASPPagerTemplateBLEx 
        {

       
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPPagerTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPPagerTemplateEx objASPPagerTemplateENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private TabHost th{0};",
                objASPPagerTemplateENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPPagerTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPPagerTemplateEx objASPPagerTemplateENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "th{0} = (TabHost)findViewById(R.id.th{0}); ",
                objASPPagerTemplateENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPPagerTemplateENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPPagerTemplateEx objASPPagerTemplateENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "th{0} = (TabHost)view.findViewById(R.id.th{0}); ",
                objASPPagerTemplateENEx.CtrlId);

        }
    }
}
