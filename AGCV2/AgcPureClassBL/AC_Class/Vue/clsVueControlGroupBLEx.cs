﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsVueControlGroupBLEx
表名:ASPNETControlGroup(00050220)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:55:32
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
using System.Web.UI.HtmlControls;
using AGC.Entity;

namespace AGC.PureClassEx
{
    public static class clsVueControlGroupBLEx_Static
    {
        public static void GeneCode(this VueControlGroupEx objASPControlGroupENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeId_Cache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }
            //strCodeForCs.Append("\r\n" + "<td>");
            if (objASPControlGroupENEx.arrSubAspControlLst2.Count > 1 && string.IsNullOrEmpty( objASPControlGroupENEx.GroupName) == false)
            {
                strCodeForCs.Append("\r\n" + "<div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">");
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                }
                strCodeForCs.Append("\r\n" + "</div>");
            }
            else
            {
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                }
            }
            //strCodeForCs.Append("\r\n" + "</td>");

        }

        public static void GeneCode4Html(this VueControlGroupEx objASPControlGroupENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            //strCodeForCs.Append("\r\n" + "<td>");
            if (objASPControlGroupENEx.arrSubAspControlLst2.Count > 1 && string.IsNullOrEmpty(objASPControlGroupENEx.GroupName) == false)
            {
                strCodeForCs.Append("\r\n" + "<div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">");
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
                }
                strCodeForCs.Append("\r\n" + "</div>");
            }
            else
            {
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
                }
            }
            //strCodeForCs.Append("\r\n" + "</td>");

        }


        public static void GeneCode4Mvc(this VueControlGroupEx objASPControlGroupENEx, StringBuilder strCodeForCs)
        {
            //strCodeForCs.Append("\r\n" + "<td>");
            if (objASPControlGroupENEx.arrSubAspControlLst2.Count > 1 && string.IsNullOrEmpty(objASPControlGroupENEx.GroupName) == false)
            {
                strCodeForCs.Append("\r\n" + "<div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">");
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneCode4Mvc(strCodeForCs);
                }
                strCodeForCs.Append("\r\n" + "</div>");
            }
            else
            {
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneCode4Mvc(strCodeForCs);
                }
            }
            //strCodeForCs.Append("\r\n" + "</td>");

        }

        public static void GeneHtmlControl(this VueControlGroupEx objASPControlGroupENEx, HtmlContainerControl objContainer)
        {
            //strCodeForCs.Append("\r\n" + "<td>");
            if (objASPControlGroupENEx.arrSubAspControlLst2.Count > 1 && string.IsNullOrEmpty(objASPControlGroupENEx.GroupName) == false)
            {
                HtmlGenericControl objDiv = new HtmlGenericControl("div");
                objDiv.Attributes["class"] = "btn-group";
                objDiv.Attributes["role"] = "group";
                objDiv.Attributes["aria-label"] = "Basic example";
                objContainer.Controls.Add(objDiv);
                //strCodeForCs.Append("\r\n" + "<div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">");
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    //               objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    objSubASPControlENEx.GeneHtmlControl(objDiv);
                    //objDiv.Controls.Add(objControl);
                }
                //return objDiv;
                //strCodeForCs.Append("\r\n" + "</div>");
            }
            else
            {
                foreach (ASPControlEx objSubASPControlENEx in objASPControlGroupENEx.arrSubAspControlLst2)
                {
                    objSubASPControlENEx.GeneHtmlControl(objContainer);
                    //HtmlControl objControl = objSubASPControlENEx.GeneHtmlControl();
                    //objDiv.Controls.Add(objControl);
                    //return objSubASPControlENEx.GeneHtmlControl(objDiv);
                }
            }
            //return null;
            //strCodeForCs.Append("\r\n" + "</td>");

        }

    }
    /// <summary>
    /// ASPNET列(ASPNETControlGroup)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsVueControlGroupBLEx
    {

        /// <summary>
        /// 生成CheckBox控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public static ASPCheckBoxEx GenCheckBoxNoPosition(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {


            //生成CheckBox的代码;

            //生成控件的<Id>

            ASPCheckBoxEx objControl = new ASPCheckBoxEx();
            objControl.CtrlId = strCheckId;

            //生成<控件样式Style>
            //生成<高度>和<宽度>
            objControl.Width = objCheckStyle.Width;
            objControl.Height = objCheckStyle.Height;
            //strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{1}px; Height:{2}px;\" ",
            //  objCheckStyle.Style_Zindex,
            //  objCheckStyle.Width, objCheckStyle.Height);
            //生成运行模式是否在服务器运行
            objControl.Runat = objCheckStyle.Runat;
            //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
            //  objCheckStyle.Runat);


            //生成<显示文本> 
            objControl.Text = strCheckText;
            //strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" ", strCheckText);


            //生成<样式>
            objControl.CssClass = "Check_Defa";
            //strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");
            return objControl;


        }
      
            public static VueControlGroupEx PackageTd(VueControlGroupEx objGroup)
        {
            ASPColEx objCol_Prev = null;
         VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();
            objASPControlGroupENEx.ColSpan_Ctrl = objGroup.ColSpan_Ctrl;
            objASPControlGroupENEx.KeyId = objGroup.KeyId;
            objASPControlGroupENEx.ColIndex = objGroup.ColIndex;
            objASPControlGroupENEx.FldName = objGroup.FldName;
            foreach (ASPControlEx objInfor in objGroup.arrSubAspControlLst2)
            {
                if (objInfor.IsMergeToPreviousControl)
                {
                    if (objCol_Prev == null) continue;
                    objCol_Prev.arrSubAspControlLst2.Add(objInfor);
                    continue;
                }
                ASPColEx objCol = clsASPColBLEx.GetEmptyTd();
                if (objInfor.ColSpan_Ctrl > 1)
                {
                    objCol.ColSpan_Ctrl = objInfor.ColSpan_Ctrl * 2 - 1;
                }
                else
                {
                    if (objInfor.CtlTypeId == enumCtlTypeAbbr.CheckBox_02)
                    {
                        objCol.ColSpan_Ctrl = 2;
                    }
                    else
                    {
                        objCol.ColSpan_Ctrl = 1;
                    }
                }
                objCol.arrSubAspControlLst2.Add(objInfor);
                if (objInfor.IsCaption)
                {
                    objCol.Class = "text-right";
                }
                else
                {
                    objCol.Class = "text-left";
                }
                objASPControlGroupENEx.arrSubAspControlLst2.Add(objCol);
                objCol_Prev = objCol;
            }
            return objASPControlGroupENEx;
        }

        public static VueControlGroupEx PackageLi(VueControlGroupEx objGroup)
        {
            ASPLiEx objLi_Prev = null;
            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();
            objASPControlGroupENEx.ColSpan_Ctrl = objGroup.ColSpan_Ctrl;
            objASPControlGroupENEx.KeyId = objGroup.KeyId;
            objASPControlGroupENEx.ColIndex = objGroup.ColIndex;

            foreach (ASPControlEx objInfor in objGroup.arrSubAspControlLst2)
            {                
                ASPLiEx objLi = clsASPLiBLEx.GetEmptyLi();
                objLi.IsCaption = objInfor.IsCaption;
                objLi.arrSubAspControlLst2.Add(objInfor);
                objASPControlGroupENEx.arrSubAspControlLst2.Add(objLi);
                objLi_Prev = objLi;
            }
            return objASPControlGroupENEx;
        }

        public static VueControlGroupEx PackageDiv(VueControlGroupEx objGroup)
        {
            
            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();
            objASPControlGroupENEx.ColSpan_Ctrl = objGroup.ColSpan_Ctrl;
            objASPControlGroupENEx.KeyId = objGroup.KeyId;
            objASPControlGroupENEx.ColIndex = objGroup.ColIndex;
            ASPDivEx objDiv_Prev = clsASPDivBLEx.GetEmptyDiv();
            foreach (ASPControlEx objInfor in objGroup.arrSubAspControlLst2)
            {
                if (objInfor.IsMergeToPreviousControl == true)
                {
                    objDiv_Prev.arrSubAspControlLst2.Add(objInfor);
                    continue;
                }
                ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
                objDiv.IsCaption = objInfor.IsCaption;
                objDiv.arrSubAspControlLst2.Add(objInfor);
                if (objInfor.ColSpan_Ctrl > 1)
                {
                    objDiv.ColSpan_Ctrl = objInfor.ColSpan_Ctrl * 2 - 1;
                }
                else
                {
                    if (objInfor.CtlTypeId == enumCtlTypeAbbr.CheckBox_02)
                    {
                        objDiv.ColSpan_Ctrl = 2;
                    }
                    else
                    {
                        objDiv.ColSpan_Ctrl = 1;
                    }
                }

                objASPControlGroupENEx.arrSubAspControlLst2.Add(objDiv);
                objDiv_Prev = objDiv;
            }
            return objASPControlGroupENEx;
        }

        public static VueControlGroupEx PackageTr(VueControlGroupEx objGroup)
        {

            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();
            ASPRowEx objRow = clsASPRowBLEx.GetEmptyTr();
            objASPControlGroupENEx.arrSubAspControlLst2.Add(objRow);

            foreach (ASPControlEx objInfor in objGroup.arrSubAspControlLst2)
            {
                ASPColEx objCol = clsASPColBLEx.GetEmptyTd();
                objCol.arrSubAspControlLst2.Add(objInfor);
                objRow.arrSubAspControlLst2.Add(objCol);
            }
            int intCount = objGroup.arrSubAspControlLst2.Count;
            while (intCount<=4)
            {
                ASPColEx objCol = clsASPColBLEx.GetEmptyTd();
              
                objRow.arrSubAspControlLst2.Add(objCol);
                intCount++;
            }
            return objASPControlGroupENEx;
        }
        public static VueControlGroupEx PackageTr4Wuc(VueControlGroupEx objGroup)
        {

            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();
            ASPRowEx objRow = clsASPRowBLEx.GetEmptyTr();
            objASPControlGroupENEx.arrSubAspControlLst2.Add(objRow);
            int intCount = 0;
            List<string> arrClass = new List<string>() { "NameTD", "ValueTD", "", "" };
            foreach (ASPControlEx objInfor in objGroup.arrSubAspControlLst2)
            {
                ASPColEx objCol = clsASPColBLEx.GetEmptyTd();
                objCol.Class = arrClass[intCount++];

                if (objInfor.GetType() == typeof(ASPCheckBoxEx))           
                {
                    
                    objRow.arrSubAspControlLst2.Add(objCol);

                    objCol = clsASPColBLEx.GetEmptyTd();
                    objCol.Class = arrClass[intCount++];
                    objCol.arrSubAspControlLst2.Add(objInfor);
                    objRow.arrSubAspControlLst2.Add(objCol);

                }
                else
                {
                    objCol.arrSubAspControlLst2.Add(objInfor);
                    objRow.arrSubAspControlLst2.Add(objCol);
                }
            }
            //intCount = objGroup.arrSubAspControlLst2.Count;
            while (intCount < 4)
            {
                ASPColEx objCol = clsASPColBLEx.GetEmptyTd();
                objCol.Class = arrClass[intCount++];
                objRow.arrSubAspControlLst2.Add(objCol);
        
            }
            return objASPControlGroupENEx;
        }
      

        public static VueControlGroupEx GetControlGroup_Asp(clsQryRegionFldsEN objQryRegionFldsEx, string strItemName4MultiModel = "", bool bolIs4PureHtml = false)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();

            ASPLabelEx objLabel = new ASPLabelEx();
            objLabel.Is4PureHtml = bolIs4PureHtml;
            objLabel.IsCaption = true;
            objLabel.ColSpan_Ctrl = 1;
            objLabel.CtrlId = string.Format("lbl{0}_q", objQryRegionFldsEx.FldName());
            objLabel.OnClick4Html = string.Format("lbl_Click('{0}')", objLabel.CtrlId);
            objLabel.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objLabel.Height = ASPControlEx.objLabelStyle_Text.Height;
            objLabel.FldName = objQryRegionFldsEx.FldName();
            objLabel.ItemName4MultiModel = strItemName4MultiModel;

            objLabel.TabName = objQryRegionFldsEx.ObjPrjTab().TabName;
            objLabel.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            objLabel.CssClass = "col-form-label text-right";

            //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
            //  objLabelStyle.Runat);
            objLabel.Text = objQryRegionFldsEx.LabelCaption;

            switch (objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeId)
            {

                case enumCtlTypeAbbr.CheckBox_02:
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPCheckBoxENEx.ColSpan_Ctrl = objQryRegionFldsEx.ColSpan;
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}_q", objQryRegionFldsEx.FldName());
                    objASPCheckBoxENEx.OnClick4Html = string.Format("chk_Click('{0}')", objASPCheckBoxENEx.CtrlId);
                    objASPCheckBoxENEx.FldName = objQryRegionFldsEx.FldName();
                    objASPCheckBoxENEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPCheckBoxENEx.TabName = objQryRegionFldsEx.ObjPrjTab().TabName;

                    objASPCheckBoxENEx.Width = 200;
                    if (objQryRegionFldsEx.Width > 0)
                    {
                        objASPCheckBoxENEx.Width = objQryRegionFldsEx.Width;
                    }
                    //objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.CssClass = "form-control-sm";

                    objASPCheckBoxENEx.Text = objQryRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPCheckBoxENEx);
                    break;


                case enumCtlTypeAbbr.TextBox_16:
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPTextBoxENEx.ColSpan_Ctrl = objQryRegionFldsEx.ColSpan;

                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}_q", objQryRegionFldsEx.FldName());
                    objASPTextBoxENEx.OnClick4Html = string.Format("txt_Click('{0}')", objASPTextBoxENEx.CtrlId);
                    objASPTextBoxENEx.FldName = objQryRegionFldsEx.FldName();
                    objASPTextBoxENEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPTextBoxENEx.TabName = objQryRegionFldsEx.ObjPrjTab().TabName;

                    objASPTextBoxENEx.Width = 200;
                    if (objQryRegionFldsEx.Width > 0)
                    {
                        objASPTextBoxENEx.Width = objQryRegionFldsEx.Width;
                    }
                    else if (objASPTextBoxENEx.ColSpan_Ctrl > 1) objASPTextBoxENEx.Width = 150 * objASPTextBoxENEx.ColSpan_Ctrl;
                    //objASPTextBoxENEx.Height = 22;
                    if (objASPTextBoxENEx.ColSpan_Ctrl > 1)
                    {
                        objASPTextBoxENEx.placeholder = string.Format("width:{0}px;ColSpan:{1}", objASPTextBoxENEx.Width, objASPTextBoxENEx.ColSpan_Ctrl);
                    }
                    else
                    {
                        objASPTextBoxENEx.placeholder = string.Format("width:{0}px;", objASPTextBoxENEx.Width);
                    }

                    objASPTextBoxENEx.CssClass = "form-control-sm";
                    objASPTextBoxENEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPTextBoxENEx);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();
                    objASPDropDownListEx.Is4PureHtml = bolIs4PureHtml;
                    objASPDropDownListEx.ColSpan_Ctrl = objQryRegionFldsEx.ColSpan;

                    objASPDropDownListEx.CtrlId = string.Format("ddl{0}_q", objQryRegionFldsEx.FldName());
                    objASPDropDownListEx.OnClick4Html = string.Format("ddl_Click('{0}')", objASPDropDownListEx.CtrlId);
                    objASPDropDownListEx.FldName = objQryRegionFldsEx.FldName();
                    objASPDropDownListEx.ItemName4MultiModel = strItemName4MultiModel;

                    objASPDropDownListEx.TabName = objQryRegionFldsEx.ObjPrjTab().TabName;
                    objASPDropDownListEx.DDLItemsOptionId = objQryRegionFldsEx.DDLItemsOptionId;
                    objASPDropDownListEx.DS_TabName = objQryRegionFldsEx.DS_TabName();

                    objASPDropDownListEx.Width = 200;
                    if (objQryRegionFldsEx.Width > 0)
                    {
                        objASPDropDownListEx.Width = objQryRegionFldsEx.Width;
                    }
                    //objASPDropDownListEx.Height = 22;
                    objASPDropDownListEx.CssClass = "form-control-sm";
                    objASPDropDownListEx.objQryRegionFldsEN = objQryRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPDropDownListEx);
                    break;
                case enumCtlTypeAbbr.CacheClassifyField_37:
                case enumCtlTypeAbbr.DefaultValue_36:
                case enumCtlTypeAbbr.GivenValue_35:
                case enumCtlTypeAbbr.ViewVariable_38:

                    break;
                default:
                    string strMsg = string.Format("查询区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objQryRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
            if (objQryRegionFldsEx.ColSpan>1)
            {
                objASPControlGroupENEx.ColSpan_Ctrl = objQryRegionFldsEx.ColSpan;
            }
            else
            {
                objASPControlGroupENEx.ColSpan_Ctrl = 1;
            }
            return objASPControlGroupENEx;
        }

        public static VueControlGroupEx GetControlGroup_Asp(clsDetailRegionFldsEN objDetailRegionFldsEx, bool bolIs4PureHtml = false)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();

            ASPSpanEx objSpan = new ASPSpanEx();
            objSpan.Is4PureHtml = bolIs4PureHtml;
            objSpan.IsCaption = true;
            objSpan.ColSpan_Ctrl = 1;

            objSpan.CtrlId = string.Format("spn{0}_d", objDetailRegionFldsEx.FldName());
            objSpan.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objSpan.Height = ASPControlEx.objLabelStyle_Text.Height;

            objSpan.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            //  objSpan.CssClass = "text-secondary text-right";
            objSpan.CssClass = "col-form-label text-right";

            //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
            //  objLabelStyle.Runat);
            objSpan.Text = objDetailRegionFldsEx.LabelCaption;

            switch (objDetailRegionFldsEx.CtlTypeId)
            {

                case enumCtlTypeAbbr.CheckBox_02:
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPCheckBoxENEx.IsCaption = false;
                    objASPCheckBoxENEx.ColSpan_Ctrl = objDetailRegionFldsEx.ColSpan;
                    objASPCheckBoxENEx.KeyId = objDetailRegionFldsEx.mId;
                    objASPCheckBoxENEx.ColIndex = objDetailRegionFldsEx.ColIndex;
                    objASPCheckBoxENEx.CtlTypeId = objDetailRegionFldsEx.CtlTypeId;
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}_d", objDetailRegionFldsEx.FldName());

                    objASPCheckBoxENEx.Width = 0;
                    if (objDetailRegionFldsEx.Width > 0)
                    {
                        objASPCheckBoxENEx.Width = objDetailRegionFldsEx.Width;
                    }
                    //objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.CssClass = "form-control-sm";
                    objASPCheckBoxENEx.Text = objDetailRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.objDetailRegionFldsEN = objDetailRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPCheckBoxENEx);
                    break;
                case enumCtlTypeAbbr.Label_10:
                    ASPLabelEx objASPLabelEx = new ASPLabelEx();
                    objASPLabelEx.Is4PureHtml = bolIs4PureHtml;
                    objASPLabelEx.IsCaption = false;
                    objASPLabelEx.ColSpan_Ctrl = objDetailRegionFldsEx.ColSpan;
                    objASPLabelEx.KeyId = objDetailRegionFldsEx.mId;
                    objASPLabelEx.ColIndex = objDetailRegionFldsEx.ColIndex;
                    objASPLabelEx.CtlTypeId = objDetailRegionFldsEx.CtlTypeId;

                    objASPLabelEx.CtrlId = string.Format("lbl{0}_d", objDetailRegionFldsEx.FldName());
                    objASPLabelEx.Width = 0;
                    if (objDetailRegionFldsEx.Width > 0)
                    {
                        objASPLabelEx.Width = objDetailRegionFldsEx.Width;
                    }
                    else if (objASPLabelEx.ColSpan_Ctrl > 1)
                    {
                        objASPLabelEx.Width = 200 * objASPLabelEx.ColSpan_Ctrl;
                    }
                    //objASPLabelEx.Height = 22;
                    objASPLabelEx.CssClass = "text-primary";
                    objASPLabelEx.objDetailRegionFldsEN = objDetailRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objSpan);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPLabelEx);
                    break;

                case enumCtlTypeAbbr.TextBox_16:
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPTextBoxENEx.IsCaption = false;
                    objASPTextBoxENEx.ColSpan_Ctrl = objDetailRegionFldsEx.ColSpan;
                    objASPTextBoxENEx.KeyId = objDetailRegionFldsEx.mId;
                    objASPTextBoxENEx.ColIndex = objDetailRegionFldsEx.ColIndex;
                    objASPTextBoxENEx.CtlTypeId = objDetailRegionFldsEx.CtlTypeId;

                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}_d", objDetailRegionFldsEx.FldName());
                    objASPTextBoxENEx.Width = 200;
                    if (objDetailRegionFldsEx.Width > 0)
                    {
                        objASPTextBoxENEx.Width = objDetailRegionFldsEx.Width;
                    }
                    else if (objASPTextBoxENEx.ColSpan_Ctrl > 1)
                    {
                        objASPTextBoxENEx.Width = 200 * objASPTextBoxENEx.ColSpan_Ctrl;
                    }
                    //objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.CssClass = "form-control-sm";
                    objASPTextBoxENEx.objDetailRegionFldsEN = objDetailRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objSpan);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPTextBoxENEx);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    ASPLabelEx objASPDropDownListEx = new ASPLabelEx();
                    objASPDropDownListEx.Is4PureHtml = bolIs4PureHtml;
                    objASPDropDownListEx.IsCaption = false;
                    objASPDropDownListEx.ColSpan_Ctrl = objDetailRegionFldsEx.ColSpan;
                    objASPDropDownListEx.KeyId = objDetailRegionFldsEx.mId;
                    objASPDropDownListEx.ColIndex = objDetailRegionFldsEx.ColIndex;
                    objASPDropDownListEx.CtlTypeId = objDetailRegionFldsEx.CtlTypeId;

                    objASPDropDownListEx.CtrlId = string.Format("ddl{0}_d", objDetailRegionFldsEx.FldName());
                    objASPDropDownListEx.Width = 0;
                    if (objDetailRegionFldsEx.Width > 0)
                    {
                        objASPDropDownListEx.Width = objDetailRegionFldsEx.Width;
                    }
                    //objASPDropDownListEx.Height = 22;
                    objASPDropDownListEx.CssClass = "form-control-sm";
                    objASPDropDownListEx.objDetailRegionFldsEN = objDetailRegionFldsEx;
                    objASPDropDownListEx.FldName = objDetailRegionFldsEx.FldName();
                    objASPDropDownListEx.TabName = objDetailRegionFldsEx.ObjPrjTab().TabName;
                    
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objSpan);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPDropDownListEx);
                    break;
                case enumCtlTypeAbbr.CacheClassifyField_37:

                    break;
                case enumCtlTypeAbbr.GivenValue_35:

                    break;

                default:
                    string strMsg = string.Format("编辑区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objDetailRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
            if (objDetailRegionFldsEx.CtlTypeId == enumCtlTypeAbbr.TextBox_16)
            {
                ASPCompareValidatorEx objCompareValidator = new ASPCompareValidatorEx();
                objCompareValidator.CtrlId = string.Format("ComValid_{0}_d", objDetailRegionFldsEx.FldName());
                objCompareValidator.IsCaption = false;
                objCompareValidator.ColSpan_Ctrl = 1;
                objCompareValidator.IsMergeToPreviousControl = true;
                objCompareValidator.Runat = "server";
                objCompareValidator.CssClass = "ErrMsg";
                objCompareValidator.ControlToValidate = objDetailRegionFldsEx.CtrlId();
                objCompareValidator.Operator = "DataTypeCheck";
                objCompareValidator.EnableClientScript = "false";
                //objCompareValidator.Runat = "server";

                switch (objDetailRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().CSType)
                {
                    case "int":
                    case "short":
                    case "long":
                        objCompareValidator.type = "Integer";
                        objCompareValidator.ErrorMessage = "请输入整型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入整型数值!\" ControlToValidate = \"{1}\" ",
                        //    objDetailRegionFldsEx.FldName(), objDetailRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Integer\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;
                    case "DateTime":
                        objCompareValidator.type = "Date";
                        objCompareValidator.ErrorMessage = "请输入日期型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入日期型数值!\" ControlToValidate = \"{1}\" ",
                        //    objDetailRegionFldsEx.FldName(), objDetailRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Date\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;
                    case "double":
                        objCompareValidator.type = "Double";
                        objCompareValidator.ErrorMessage = "请输入浮点型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                        //    objDetailRegionFldsEx.FldName(), objDetailRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;

                    case "float":
                        objCompareValidator.type = "Double";
                        objCompareValidator.ErrorMessage = "请输入浮点型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                        //    objDetailRegionFldsEx.FldName(), objDetailRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;
                }
            }
            return objASPControlGroupENEx;
        }


        public static VueControlGroupEx GetControlGroup_Asp(clsEditRegionFldsEN objEditRegionFldsEx, bool bolIs4PureHtml = false)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();
            objASPControlGroupENEx.FldName = objEditRegionFldsEx.FldName();
            ASPLabelEx objLabel = new ASPLabelEx();
            objLabel.Is4PureHtml = bolIs4PureHtml;
            objLabel.IsCaption = true;
            objLabel.ColSpan_Ctrl = 1;

            objLabel.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.FldName());
            objLabel.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objLabel.Height = ASPControlEx.objLabelStyle_Text.Height;

            objLabel.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            //  objLabel.CssClass = "text-secondary text-right";
            objLabel.CssClass = "col-form-label text-right";

            //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
            //  objLabelStyle.Runat);
            objLabel.Text = objEditRegionFldsEx.LabelCaption;

            switch (objEditRegionFldsEx.CtlTypeId)
            {

                case enumCtlTypeAbbr.CheckBox_02:
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPCheckBoxENEx.IsCaption = false;
                    objASPCheckBoxENEx.ColSpan_Ctrl = objEditRegionFldsEx.ColSpan;
                    objASPCheckBoxENEx.KeyId = objEditRegionFldsEx.mId;
                    objASPCheckBoxENEx.ColIndex = objEditRegionFldsEx.ColIndex;
                    objASPCheckBoxENEx.CtlTypeId = objEditRegionFldsEx.CtlTypeId;
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}", objEditRegionFldsEx.FldName());

                    objASPCheckBoxENEx.Width = 200;
                    if (objEditRegionFldsEx.Width > 0)
                    {
                        objASPCheckBoxENEx.Width = objEditRegionFldsEx.Width;
                    }
                    //objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.CssClass = "form-control-sm";
                    objASPCheckBoxENEx.Text = objEditRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPCheckBoxENEx);
                    break;


                case enumCtlTypeAbbr.TextBox_16:
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPTextBoxENEx.IsCaption = false;
                    objASPTextBoxENEx.ColSpan_Ctrl = objEditRegionFldsEx.ColSpan;
                    objASPTextBoxENEx.KeyId = objEditRegionFldsEx.mId;
                    objASPTextBoxENEx.ColIndex = objEditRegionFldsEx.ColIndex;
                    objASPTextBoxENEx.CtlTypeId = objEditRegionFldsEx.CtlTypeId;

                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objEditRegionFldsEx.FldName());
                    objASPTextBoxENEx.Width = 200;
                    if (objEditRegionFldsEx.Width > 0)
                    {
                        objASPTextBoxENEx.Width = objEditRegionFldsEx.Width;
                    }
                    else if (objASPTextBoxENEx.ColSpan_Ctrl>1)
                    {
                        objASPTextBoxENEx.Width = 200 * objASPTextBoxENEx.ColSpan_Ctrl;
                    }
                        //objASPTextBoxENEx.Height = 22;
                        objASPTextBoxENEx.CssClass = "form-control-sm";
                    objASPTextBoxENEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPTextBoxENEx);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();
                    objASPDropDownListEx.Is4PureHtml = bolIs4PureHtml;
                    objASPDropDownListEx.IsCaption = false;
                    objASPDropDownListEx.ColSpan_Ctrl = objEditRegionFldsEx.ColSpan;
                    objASPDropDownListEx.KeyId = objEditRegionFldsEx.mId;
                    objASPDropDownListEx.ColIndex = objEditRegionFldsEx.ColIndex;
                    objASPDropDownListEx.CtlTypeId = objEditRegionFldsEx.CtlTypeId;

                    objASPDropDownListEx.CtrlId = string.Format("ddl{0}", objEditRegionFldsEx.FldName());
                    objASPDropDownListEx.Width = 200;
                    if (objEditRegionFldsEx.Width > 0)
                    {
                        objASPDropDownListEx.Width = objEditRegionFldsEx.Width;
                    }
                    //objASPDropDownListEx.Height = 22;
                    objASPDropDownListEx.CssClass = "form-control-sm";
                    objASPDropDownListEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    objASPDropDownListEx.FldName = objEditRegionFldsEx.FldName();
                    objASPDropDownListEx.TabName = objEditRegionFldsEx.ObjPrjTab().TabName;
                    objASPDropDownListEx.DDLItemsOptionId = objEditRegionFldsEx.DDLItemsOptionId;
                    objASPDropDownListEx.DS_TabName = objEditRegionFldsEx.DS_TabName();

                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPDropDownListEx);
                    break;
                case enumCtlTypeAbbr.DefaultValue_36:

                    break;
                case enumCtlTypeAbbr.CacheClassifyField_37:

                    break;
                case enumCtlTypeAbbr.GivenValue_35:

                    break;
                case enumCtlTypeAbbr.ViewVariable_38:

                    break;
                default:
                    string strMsg = string.Format("编辑区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
            if (objEditRegionFldsEx.CtlTypeId == enumCtlTypeAbbr.TextBox_16 && bolIs4PureHtml == false)
            {
                ASPCompareValidatorEx objCompareValidator = new ASPCompareValidatorEx();
                objCompareValidator.CtrlId = string.Format("ComValid_{0}", objEditRegionFldsEx.FldName());
                objCompareValidator.IsCaption = false;
                objCompareValidator.ColSpan_Ctrl = 1;
                objCompareValidator.IsMergeToPreviousControl = true;
                objCompareValidator.Runat = "server";
                objCompareValidator.CssClass = "ErrMsg";
                objCompareValidator.ControlToValidate = objEditRegionFldsEx.CtrlId();
                objCompareValidator.Operator = "DataTypeCheck";
                objCompareValidator.EnableClientScript = "false";
                //objCompareValidator.Runat = "server";

                switch (objEditRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().CSType)
                {
                    case "int":
                    case "short":
                    case "long":
                        objCompareValidator.type = "Integer";
                        objCompareValidator.ErrorMessage = "请输入整型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入整型数值!\" ControlToValidate = \"{1}\" ",
                        //    objEditRegionFldsEx.FldName(), objEditRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Integer\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;
                    case "DateTime":
                        objCompareValidator.type = "Date";
                        objCompareValidator.ErrorMessage = "请输入日期型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入日期型数值!\" ControlToValidate = \"{1}\" ",
                        //    objEditRegionFldsEx.FldName(), objEditRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Date\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;
                    case "double":
                        objCompareValidator.type = "Double";
                        objCompareValidator.ErrorMessage = "请输入浮点型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                        //    objEditRegionFldsEx.FldName(), objEditRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;

                    case "float":
                        objCompareValidator.type = "Double";
                        objCompareValidator.ErrorMessage = "请输入浮点型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                        //    objEditRegionFldsEx.FldName(), objEditRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;
                }
            }
            return objASPControlGroupENEx;
        }

        public static VueControlGroupEx GetControlGroup_Asp(clsEditRegionFldsEN objEditRegionFldsEx, string strItemName4MultiModel = "", bool bolIs4PureHtml = false)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();

            objASPControlGroupENEx.FldName = objEditRegionFldsEx.FldName();

            objASPControlGroupENEx.KeyId = objEditRegionFldsEx.mId;
            objASPControlGroupENEx.ColIndex = objEditRegionFldsEx.ColIndex;

            ASPLabelEx objLabel = new ASPLabelEx();
            objLabel.Is4PureHtml = bolIs4PureHtml;
            objLabel.IsCaption = true;
            objLabel.ColSpan_Ctrl = 1;
            objLabel.CtrlId = string.Format("lbl{0}", objEditRegionFldsEx.FldName());
            objLabel.OnClick4Html = string.Format("lbl_Click('{0}')", objLabel.CtrlId);
            objLabel.CtlTypeId = enumCtlTypeAbbr.Label_10;
            objLabel.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objLabel.Height = ASPControlEx.objLabelStyle_Text.Height;

            objLabel.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            //  objLabel.CssClass = "text-secondary text-right";
            objLabel.CssClass = "col-form-label";

            //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
            //  objLabelStyle.Runat);
            objLabel.Text = objEditRegionFldsEx.LabelCaption;

            switch (objEditRegionFldsEx.ObjCtlTypeAbbr().CtlTypeId)
            {

                case enumCtlTypeAbbr.CheckBox_02:
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPCheckBoxENEx.IsCaption = false;
                    objASPCheckBoxENEx.ColSpan_Ctrl = objEditRegionFldsEx.ColSpan;
                    if ( objASPCheckBoxENEx.ColSpan_Ctrl>1)
                    {
                        //string ss = "";
                    }
                    objASPCheckBoxENEx.KeyId = objEditRegionFldsEx.mId;
                    objASPCheckBoxENEx.ColIndex = objEditRegionFldsEx.ColIndex;
                    objASPCheckBoxENEx.CtlTypeId = objEditRegionFldsEx.CtlTypeId;
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}", objEditRegionFldsEx.FldName());
                    objASPCheckBoxENEx.OnClick4Html = string.Format("chk_Click('{0}')", objASPCheckBoxENEx.CtrlId);
                    objASPCheckBoxENEx.Width = 200;
                    if (objEditRegionFldsEx.Width>0)
                    {
                        objASPCheckBoxENEx.Width = objEditRegionFldsEx.Width;
                    }
                    //objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.CssClass = "form-control-sm";
                    objASPCheckBoxENEx.Text = objEditRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPCheckBoxENEx);
                    break;


                case enumCtlTypeAbbr.TextBox_16:
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPTextBoxENEx.IsCaption = false;
                    objASPTextBoxENEx.ColSpan_Ctrl = objEditRegionFldsEx.ColSpan;
                    objASPTextBoxENEx.KeyId = objEditRegionFldsEx.mId;
                    objASPTextBoxENEx.ColIndex = objEditRegionFldsEx.ColIndex;
                    objASPTextBoxENEx.CtlTypeId = objEditRegionFldsEx.CtlTypeId;
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objEditRegionFldsEx.FldName());
                    objASPTextBoxENEx.Width = 200;
                    if (objEditRegionFldsEx.Width > 0)
                    {
                        objASPTextBoxENEx.Width = objEditRegionFldsEx.Width;
                    }
                    else if (objASPTextBoxENEx.ColSpan_Ctrl>1) objASPTextBoxENEx.Width = 200 * objASPTextBoxENEx.ColSpan_Ctrl;
                    if (objEditRegionFldsEx.IsMultiRow) objASPTextBoxENEx.TextMode = "MultiLine";
                    if (objASPTextBoxENEx.ColSpan_Ctrl > 1)
                    {
                        objASPTextBoxENEx.placeholder = string.Format("width:{0}px;ColSpan:{1}", objASPTextBoxENEx.Width, objASPTextBoxENEx.ColSpan_Ctrl);
                    }
                    else
                    {
                        objASPTextBoxENEx.placeholder = string.Format("width:{0}px;", objASPTextBoxENEx.Width);
                    }
                    //objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.CssClass = "form-control-sm";
                    objASPTextBoxENEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    objASPTextBoxENEx.OnClick4Html = string.Format("txt_Click('{0}')", objASPTextBoxENEx.CtrlId);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPTextBoxENEx);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    ASPDropDownListEx objASPDropDownListEx = new ASPDropDownListEx();
                    objASPDropDownListEx.Is4PureHtml = bolIs4PureHtml;
                    objASPDropDownListEx.IsCaption = false;
                    objASPDropDownListEx.ColSpan_Ctrl = objEditRegionFldsEx.ColSpan;
                    objASPDropDownListEx.KeyId = objEditRegionFldsEx.mId;
                    objASPDropDownListEx.ColIndex = objEditRegionFldsEx.ColIndex;
                    objASPDropDownListEx.CtlTypeId = objEditRegionFldsEx.CtlTypeId;
                    objASPDropDownListEx.CtrlId = string.Format("ddl{0}", objEditRegionFldsEx.FldName());
                    objASPDropDownListEx.OnClick4Html =        string.Format("ddl_Click('{0}')", objASPDropDownListEx.CtrlId);
                    objASPDropDownListEx.Width = 200;
                    if (objEditRegionFldsEx.Width > 0)
                    {
                        objASPDropDownListEx.Width = objEditRegionFldsEx.Width;
                    }
                    //objASPDropDownListEx.Height = 22;
                    objASPDropDownListEx.CssClass = "form-control-sm";
                    objASPDropDownListEx.objEditRegionFldsEN = objEditRegionFldsEx;
                    objASPDropDownListEx.FldName = objEditRegionFldsEx.FldName();
                    objASPDropDownListEx.TabName = objEditRegionFldsEx.ObjPrjTab().TabName;
                    objASPDropDownListEx.DDLItemsOptionId = objEditRegionFldsEx.DDLItemsOptionId;
                    objASPDropDownListEx.DS_TabName = objEditRegionFldsEx.DS_TabName();

                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objLabel);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPDropDownListEx);
                    break;

                case enumCtlTypeAbbr.CacheClassifyField_37:
                case enumCtlTypeAbbr.DefaultValue_36:
                case enumCtlTypeAbbr.GivenValue_35:
                case enumCtlTypeAbbr.ViewVariable_38:

                    break;
                default:
                    string strMsg = string.Format("编辑区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objEditRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
            if (objEditRegionFldsEx.CtlTypeId == enumCtlTypeAbbr.TextBox_16 && bolIs4PureHtml == false)
            {
                ASPCompareValidatorEx objCompareValidator = new ASPCompareValidatorEx();
                objCompareValidator.CtrlId = string.Format("ComValid_{0}", objEditRegionFldsEx.FldName());
                objCompareValidator.Runat = "server";
                objCompareValidator.CssClass = "ErrMsg";
                objCompareValidator.ColSpan_Ctrl = 1;
                objCompareValidator.IsMergeToPreviousControl = true;
                objCompareValidator.ControlToValidate = objEditRegionFldsEx.CtrlId();
                objCompareValidator.Operator = "DataTypeCheck";
                objCompareValidator.EnableClientScript = "false";
                objCompareValidator.IsMergeToPreviousControl = true;
                //objCompareValidator.Runat = "server";

                switch (objEditRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().CSType)
                {
                    case "int":
                    case "short":
                    case "long":
                        objCompareValidator.type = "Integer";
                        objCompareValidator.ErrorMessage = "请输入整型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入整型数值!\" ControlToValidate = \"{1}\" ",
                        //    objEditRegionFldsEx.FldName(), objEditRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Integer\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;
                    case "DateTime":
                        objCompareValidator.type = "Date";
                        objCompareValidator.ErrorMessage = "请输入日期型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入日期型数值!\" ControlToValidate = \"{1}\" ",
                        //    objEditRegionFldsEx.FldName(), objEditRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Date\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;
                    case "double":
                        objCompareValidator.type = "Double";
                        objCompareValidator.ErrorMessage = "请输入浮点型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                        //    objEditRegionFldsEx.FldName(), objEditRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;

                    case "float":
                        objCompareValidator.type = "Double";
                        objCompareValidator.ErrorMessage = "请输入浮点型数值!";
                        objASPControlGroupENEx.arrSubAspControlLst2.Add(objCompareValidator);
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"ErrMsg\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                        //    objEditRegionFldsEx.FldName(), objEditRegionFldsEx.CtrlId());
                        //strCodeForCs.AppendFormat("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                        //strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                        break;
                }
            }
            return objASPControlGroupENEx;
        }


        public static VueControlGroupEx GetControlGroup_Asp(clsDetailRegionFldsEN objDetailRegionFldsEx, DataRow objDR = null,  string strItemName4MultiModel = "", bool bolIs4PureHtml = false)
        {
            if (ASPControlEx.objCheckStyle == null) clsASPControlBLEx.InitStyleObj();
            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();
            objASPControlGroupENEx.KeyId = objDetailRegionFldsEx.mId;
            objASPControlGroupENEx.ColIndex = objDetailRegionFldsEx.ColIndex;

            ASPSpanEx objSpan = new ASPSpanEx();
            objSpan.Is4PureHtml = bolIs4PureHtml;
            objSpan.IsCaption = true;
            objSpan.ColSpan_Ctrl = 1;
            objSpan.CtrlId = string.Format("spn{0}", objDetailRegionFldsEx.FldName());
            objSpan.OnClick4Html = string.Format("lbl_Click('{0}')", objSpan.CtrlId);
            objSpan.CtlTypeId = enumCtlTypeAbbr.Label_10;
            objSpan.Width = ASPControlEx.objLabelStyle_Text.Width;
            //objSpan.Height = ASPControlEx.objLabelStyle_Text.Height;

            objSpan.Runat = ASPControlEx.objLabelStyle_Text.Runat;
            //  objSpan.CssClass = "text-secondary text-right";
            objSpan.CssClass = "col-form-label text-right";

            //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
            //  objLabelStyle.Runat);
            objSpan.Text = objDetailRegionFldsEx.LabelCaption;

            switch (objDetailRegionFldsEx.ObjCtlTypeAbbr().CtlTypeId)
            {

                case enumCtlTypeAbbr.CheckBox_02:
                    ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
                    objASPCheckBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPCheckBoxENEx.IsCaption = false;
                    objASPCheckBoxENEx.ColSpan_Ctrl = objDetailRegionFldsEx.ColSpan;
                    if (objASPCheckBoxENEx.ColSpan_Ctrl > 1)
                    {
                        //string ss = "";
                    }
                    objASPCheckBoxENEx.KeyId = objDetailRegionFldsEx.mId;
                    objASPCheckBoxENEx.ColIndex = objDetailRegionFldsEx.ColIndex;
                    objASPCheckBoxENEx.CtlTypeId = objDetailRegionFldsEx.CtlTypeId;
                    objASPCheckBoxENEx.CtrlId = string.Format("chk{0}", objDetailRegionFldsEx.FldName());
                    objASPCheckBoxENEx.OnClick4Html = string.Format("chk_Click('{0}')", objASPCheckBoxENEx.CtrlId);
                    objASPCheckBoxENEx.Width = 200;
                    if (objDetailRegionFldsEx.Width > 0)
                    {
                        objASPCheckBoxENEx.Width = objDetailRegionFldsEx.Width;
                    }
                    //objASPCheckBoxENEx.Height = 22;
                    objASPCheckBoxENEx.CssClass = "form-control-sm";
                    objASPCheckBoxENEx.Text = objDetailRegionFldsEx.LabelCaption;
                    objASPCheckBoxENEx.objDetailRegionFldsEN = objDetailRegionFldsEx;
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPCheckBoxENEx);
                    break;
                case enumCtlTypeAbbr.Label_10:
                    ASPLabelEx objASPLabelENEx = new ASPLabelEx();
                    objASPLabelENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPLabelENEx.IsCaption = false;
                    objASPLabelENEx.ColSpan_Ctrl = objDetailRegionFldsEx.ColSpan;
                    objASPLabelENEx.KeyId = objDetailRegionFldsEx.mId;
                    objASPLabelENEx.ColIndex = objDetailRegionFldsEx.ColIndex;
                    objASPLabelENEx.CtlTypeId = objDetailRegionFldsEx.CtlTypeId;
                    string strFldName = objDetailRegionFldsEx.FldName();
                    objASPLabelENEx.CtrlId = string.Format("lbl{0}", strFldName);
                    try
                    {
                        if (objDR != null)
                        {
                            objASPLabelENEx.Text = objDR[strFldName].ToString();
                        }
                    }
                    catch(Exception objException)
                    {
                        throw objException;
                    }
                    if (string.IsNullOrEmpty( objASPLabelENEx.Text) == true)
                    {
                        objASPLabelENEx.Text = "[None]";
                    }
                    objASPLabelENEx.Width = 200;
                    if (objDetailRegionFldsEx.Width > 0)
                    {
                        objASPLabelENEx.Width = objDetailRegionFldsEx.Width;
                    }
                    else if (objASPLabelENEx.ColSpan_Ctrl > 1) objASPLabelENEx.Width = 200 * objASPLabelENEx.ColSpan_Ctrl;
                    //if (objDetailRegionFldsEx.IsMultiRow) objASPLabelENEx.TextMode = "MultiLine";
                    //if (objASPLabelENEx.ColSpan_Ctrl > 1)
                    //{
                    //    objASPLabelENEx.placeholder = string.Format("width:{0}px;ColSpan:{1}", objASPLabelENEx.Width, objASPLabelENEx.ColSpan_Ctrl);
                    //}
                    //else
                    //{
                    //    objASPLabelENEx.placeholder = string.Format("width:{0}px;", objASPLabelENEx.Width);
                    //}
                    //objASPLabelENEx.Height = 22;
                    objASPLabelENEx.CssClass = "text-primary";
                    if (objASPLabelENEx.Text ==  "[None]")
                    {
                        objASPLabelENEx.CssClass = "text-info";
                    }
                    objASPLabelENEx.objDetailRegionFldsEN = objDetailRegionFldsEx;
                    objASPLabelENEx.OnClick4Html = string.Format("lbl_Click('{0}')", objASPLabelENEx.CtrlId);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objSpan);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPLabelENEx);
                    break;

                case enumCtlTypeAbbr.TextBox_16:
                    ASPTextBoxEx objASPTextBoxENEx = new ASPTextBoxEx();
                    objASPTextBoxENEx.Is4PureHtml = bolIs4PureHtml;
                    objASPTextBoxENEx.IsCaption = false;
                    objASPTextBoxENEx.ColSpan_Ctrl = objDetailRegionFldsEx.ColSpan;
                    objASPTextBoxENEx.KeyId = objDetailRegionFldsEx.mId;
                    objASPTextBoxENEx.ColIndex = objDetailRegionFldsEx.ColIndex;
                    objASPTextBoxENEx.CtlTypeId = objDetailRegionFldsEx.CtlTypeId;
                    //                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objDetailRegionFldsEx.FldName());
                    objASPTextBoxENEx.CtrlId = string.Format("txt{0}", objDetailRegionFldsEx.FldName());
                    objASPTextBoxENEx.Width = 200;
                    if (objDetailRegionFldsEx.Width > 0)
                    {
                        objASPTextBoxENEx.Width = objDetailRegionFldsEx.Width;
                    }
                    else if (objASPTextBoxENEx.ColSpan_Ctrl > 1) objASPTextBoxENEx.Width = 200 * objASPTextBoxENEx.ColSpan_Ctrl;
                    if (objDetailRegionFldsEx.IsMultiRow) objASPTextBoxENEx.TextMode = "MultiLine";
                    if (objASPTextBoxENEx.ColSpan_Ctrl > 1)
                    {
                        objASPTextBoxENEx.placeholder = string.Format("width:{0}px;ColSpan:{1}", objASPTextBoxENEx.Width, objASPTextBoxENEx.ColSpan_Ctrl);
                    }
                    else
                    {
                        objASPTextBoxENEx.placeholder = string.Format("width:{0}px;", objASPTextBoxENEx.Width);
                    }
                    //objASPTextBoxENEx.Height = 22;
                    objASPTextBoxENEx.CssClass = "form-control-sm";
                    objASPTextBoxENEx.objDetailRegionFldsEN = objDetailRegionFldsEx;
                    objASPTextBoxENEx.OnClick4Html = string.Format("txt_Click('{0}')", objASPTextBoxENEx.CtrlId);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objSpan);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPTextBoxENEx);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    ASPLabelEx objASPDropDownListEx = new ASPLabelEx();
                    objASPDropDownListEx.Is4PureHtml = bolIs4PureHtml;
                    objASPDropDownListEx.IsCaption = false;
                    objASPDropDownListEx.ColSpan_Ctrl = objDetailRegionFldsEx.ColSpan;
                    objASPDropDownListEx.KeyId = objDetailRegionFldsEx.mId;
                    objASPDropDownListEx.ColIndex = objDetailRegionFldsEx.ColIndex;
                    objASPDropDownListEx.CtlTypeId = objDetailRegionFldsEx.CtlTypeId;
                    objASPDropDownListEx.CtrlId = string.Format("ddl{0}", objDetailRegionFldsEx.FldName());
                    objASPDropDownListEx.OnClick4Html = string.Format("ddl_Click('{0}')", objASPDropDownListEx.CtrlId);
                    objASPDropDownListEx.Width = 200;
                    if (objDetailRegionFldsEx.Width > 0)
                    {
                        objASPDropDownListEx.Width = objDetailRegionFldsEx.Width;
                    }
                    //objASPDropDownListEx.Height = 22;
                    objASPDropDownListEx.CssClass = "form-control-sm";
                    objASPDropDownListEx.objDetailRegionFldsEN = objDetailRegionFldsEx;
                    objASPDropDownListEx.FldName = objDetailRegionFldsEx.FldName();
                    objASPDropDownListEx.TabName = objDetailRegionFldsEx.ObjPrjTab().TabName;
                    
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objSpan);
                    objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPDropDownListEx);
                    break;

                case enumCtlTypeAbbr.CacheClassifyField_37:
                case enumCtlTypeAbbr.DefaultValue_36:
                case enumCtlTypeAbbr.GivenValue_35:

                    break;
                default:
                    string strMsg = string.Format("编辑区域字段转换成Asp控件时，类型：[{0}]没有处理！({1})",
                        objDetailRegionFldsEx.ObjCtlTypeAbbr().CtlTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
                
            return objASPControlGroupENEx;
        }



        /// <summary>
        /// 建立[空行td]
        /// </summary>
        /// <returns></returns>
        public static VueControlGroupEx GetEmptyTd()
        {
            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();
            //objASPControlGroupENEx.CtrlId = "tr1";         
            //objASPControlGroupENEx.Style = "width: 100%; height: 32px; ";
            //objASPControlGroupENEx.Class = "msgtable";
            return objASPControlGroupENEx;
        }

        public static VueControlGroupEx GetbtnQuery(bool bolIs4Mvc = false, bool bolIs4Ajax = false)
        {
            VueButtonEx objASPButtonENEx = clsVueButtonBLEx.GetbtnQuery(bolIs4Mvc, bolIs4Ajax);

            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();
            objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPButtonENEx);
            return objASPControlGroupENEx;
        }
        public static VueControlGroupEx GetControlGroup(ASPControlEx objASPButtonENEx)
        {
            VueControlGroupEx objASPControlGroupENEx = new VueControlGroupEx();
            objASPControlGroupENEx.OrderNum = objASPButtonENEx.OrderNum;
            objASPControlGroupENEx.GroupName = objASPButtonENEx.GroupName;

            objASPControlGroupENEx.arrSubAspControlLst2.Add(objASPButtonENEx);
            return objASPControlGroupENEx;
        }
        /// <summary>
        /// 合并控件组，即把组名一样的控件，合并成一个组
        /// </summary>
        /// <param name="arrControlGroupLst"></param>
        /// <returns></returns>
        public static IEnumerable<VueControlGroupEx> MergeControlGroup(List<VueControlGroupEx> arrControlGroupLst)
        {
            int iLen = arrControlGroupLst.Count;
            //在设置字段值的按钮前按需要添加一个输入控件，用于输入一个值
            //for (int i = 0; i < iLen; i++)
            //{
            //    VueControlGroupEx objInFor = arrControlGroupLst[i];
            //    ASPControlEx objASPButtonENEx = objInFor.arrSubAspControlLst2[0] as ASPControlEx;
            //    if (objASPButtonENEx.FeatureId == enumPrjFeature.SetFieldValue_0148
            //      && objASPButtonENEx.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
            //    {
            //        List<clsvViewFeatureFldsEN> arrViewFeatureFlds_Sub = arrvViewFeatureFlds.Where(x =>
            //        x.ViewFeatureId == objASPButtonENEx.ViewFeatureId).ToList();
            //        if (arrViewFeatureFlds_Sub.Count > 0)
            //        {
            //            clsvViewFeatureFldsEN objViewFeatureFlds = arrViewFeatureFlds_Sub[0];
            //            ASPDropDownListEx objASPDropDownListEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
            //            objInFor.arrSubAspControlLst2.Insert(0, objASPDropDownListEx);
            //        }
            //    }
            //}
            for (int i = 0; i < iLen; i++)
            {
                VueControlGroupEx objInFor = arrControlGroupLst[i];
                if (objInFor._StrTag == "Delete") continue;
                if (string.IsNullOrEmpty(objInFor.GroupName) == false)
                {
                    for (int j = i + 1; j < iLen; j++)
                    {
                        VueControlGroupEx objInFor_J = arrControlGroupLst[j];
                        if (objInFor_J.GroupName == objInFor.GroupName)
                        {
                            if (objInFor_J.OrderNum > objInFor.OrderNum) objInFor.OrderNum = objInFor_J.OrderNum;
                            foreach (ASPControlEx objInFor_Sub in objInFor_J.arrSubAspControlLst2)
                            {
                                objInFor.arrSubAspControlLst2.Add(objInFor_Sub);
                            }
                            objInFor_J._StrTag = "Delete";
                        }
                    }
                }
            }
            IEnumerable<VueControlGroupEx> arrControlGroupLst_New = arrControlGroupLst.Where(x => x._StrTag != "Delete").OrderBy(x => x.OrderNum);
            return arrControlGroupLst_New;
        }
    }
}