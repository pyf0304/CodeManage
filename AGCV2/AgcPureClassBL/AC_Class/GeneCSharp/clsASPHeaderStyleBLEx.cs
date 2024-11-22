﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPHeaderStyleBLEx
表名:ASPNETHeaderStyle(00050232)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:55:55
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
using AGC.Entity;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNETHeaderStyle(ASPNETHeaderStyle)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPHeaderStyleBLEx_Static
    {

        public static void GeneCode(this ASPHeaderStyleEx objASPHeaderStyleENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
            //<asp:HeaderStyle ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:HeaderStyle>
            strCodeForCs.AppendFormat("\r\n" + "<HeaderStyle ", objASPHeaderStyleENEx.AspControlId);

            if (objASPHeaderStyleENEx.Width > 0)
            {
                strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objASPHeaderStyleENEx.Width);
            }



            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPHeaderStyleENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</HeaderStyle>");

        }
        //public static void GeneCode4Html(this ASPHeaderStyleEx objASPHeaderStyleENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        //{
        //    //<asp:HeaderStyle ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
        //    //       </asp:HeaderStyle>
        //    strCodeForCs.AppendFormat("\r\n" + "<HeaderStyle ", objASPHeaderStyleENEx.AspControlId);

        //    if (objASPHeaderStyleENEx.Width > 0)
        //    {
        //        strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objASPHeaderStyleENEx.Width);
        //    }



        //    strCodeForCs.Append(">");

        //    foreach (ASPControlEx objSubASPControlENEx in objASPHeaderStyleENEx.arrSubAspControlLst2)
        //    {
        //        objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
        //    }
        //    strCodeForCs.Append("\r\n" + "</HeaderStyle>");

        //}
    }
    /// <summary>
    /// ASPNETHeaderStyle(ASPNETHeaderStyle)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPHeaderStyleBLEx 
        {
        

        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPHeaderStyleENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPHeaderStyleEx objASPHeaderStyleENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private HeaderStyle inc{0};",
                objASPHeaderStyleENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPHeaderStyleENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPHeaderStyleEx objASPHeaderStyleENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "inc{0} = (HeaderStyle)findViewById(R.id.inc{0}); ",
                objASPHeaderStyleENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPHeaderStyleENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPHeaderStyleEx objASPHeaderStyleENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "inc{0} = (HeaderStyle)view.findViewById(R.id.inc{0}); ",
                objASPHeaderStyleENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPLabelENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPLabelEx objASPLabelENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPLabelENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPLabelENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objASPLabelENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPLabelENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.ObjOutRelaTab().TabName,
               objASPLabelENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);
            //strCodeForCs.Append("\r\n }");
        }

        //<asp:TemplateField HeaderText = "全选">
        //                             <HeaderStyle Width = "30px" />
        //                             <HeaderTemplate>
        //                                 <asp:LinkButton ID = "lbSelAll" CommandName = "lbSelAll" runat = "server" CssClass = "DgSelAll">全选</asp:LinkButton>
        //                             </HeaderTemplate>
        //                             <ItemTemplate>
        //                                 <asp:CheckBox ID = "chkCheckRec" runat = "server"></asp:CheckBox>
        //                             </ItemTemplate>
        //                         </asp:TemplateField>

        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPHeaderStyleENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCodeBak(ASPHeaderStyleEx objASPHeaderStyleENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPHeaderStyleENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPHeaderStyleENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<include");
            //strCodeForCs.AppendFormat("\r\n" + "android:id=\"@android:id/{0}\"",
            //    objASPHeaderStyleENEx.CtrlId);
            ////生成控件的尺寸-高、宽
            //clsASPControlBLEx.GC4Size(objASPHeaderStyleENEx, strCodeForCs);

            ////生成控件的边界尺寸-即与四周的距离
            //clsASPControlBLEx.GC4Margin(objASPHeaderStyleENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            if (string.IsNullOrEmpty(objASPHeaderStyleENEx.layout) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "layout=\"@layout/{0}\"",
                    objASPHeaderStyleENEx.layout);
            }
            if (objASPHeaderStyleENEx.arrSubAspControlLst2.Count == 0)
            {
                strCodeForCs.AppendFormat("/>");
            }
            else
            {
                strCodeForCs.AppendFormat(">");

                foreach (ASPControlEx objSubASPControlENEx in objASPHeaderStyleENEx.arrSubAspControlLst2)
                {
                    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                }
                strCodeForCs.AppendFormat("\r\n" + "</HeaderStyle>");
            }
        }


    }

}