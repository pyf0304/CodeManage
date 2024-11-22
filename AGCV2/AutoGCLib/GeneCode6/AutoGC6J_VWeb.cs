using System;
using System.Text;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using AGC_CSV7.Entity;
using AGC_CSV7.BusinessLogic;


namespace AGC_CSV7.BusinessLogic.GeneCode2
{
    /// <summary>
    /// 
    /// </summary>
    public class AutoGC6J_VWeb : clsViewInfoBLEx
    {

        int intZIndex;		///控件焦点序号
        //		int intCurrLeft; ///控件的左边空;
        //		int intCurrTop; ///控件的顶面空;
        //		private string strFolder;	//私有临时变量
        //		private mstrFileName;		//生成的文件名；
        #region 构造函数
        public AutoGC6J_VWeb()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }

        public AutoGC6J_VWeb(string strViewId)
            : base(strViewId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        #endregion
        /// <summary>
        /// 初始化页面设置
        /// </summary>
        public void InitPageSetup()
        {
            intZIndex = 100;		///控件焦点序号
            //			intCurrLeft = 10; ///控件的左边空;
            //			intCurrTop = 10;
        }

        public string GenInsRecViewCode(clsViewInfoENEx objViewInfoENEx)
        {
            ///让用户设置属性;
            string strFolder;
            StringBuilder strCode = new StringBuilder(); ///用来存放WebForm的代码;
            string strTemp; ///临时变量;
            clsProjectsEN objProjects = clsProjectsBL.GetProjectsByPrjId(objViewInfoENEx.PrjId);
            objViewInfoENEx.WebFormName = objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_add";
            objViewInfoENEx.WebFormFName = mstrFolderName + objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_add.jsp";
            mstrFileName = objViewInfoENEx.WebFormFName;
            //clsProjectsENEx objProjects = new clsProjectsENEx(objViewInfoENEx.PrjId, true);
            try
            {
                ///生成插入记录的界面代码;
                /// strCode.Append("///生成插入记录的界面代码");
                /// 


                //<%@ page contentType="text/html; charset=gb2312"%>
                strCode.Append("\r\n" + "<%@ page contentType=\"text/html; charset=GBK\" %>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-bean.tld\" prefix=\"bean\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-logic.tld\" prefix=\"logic\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-html.tld\" prefix=\"html\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-nested.tld\" prefix=\"nested\"%>");

                //strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/taglib/ecnuidc\" prefix=\"ecnuidc\" %>");
                strCode.AppendFormat("\r\n" + "<%@ page import=\"{0}.{1}Form\"%>",
                objViewInfoENEx.objViewGroupEx_Java.PrjDomain,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstUcase);
                strCode.AppendFormat("\r\n" + "<%@ page import=\"{0}\"%>",
                objViewInfoENEx.objViewGroupEx_Java.StutsManagerClass);
                //strCode.Append("\r\n" + "<%@ page import=\"com.neusoft.util.DateTool\" %>");
                strCode.Append("\r\n" + "<%@ page import=\"java.util.Date\"%>");
                strCode.Append("\r\n" + "<%");
                strCode.Append("\r\n" + "");
                strCode.AppendFormat("\r\n {1}Form form=({1}Form)request.getAttribute(\"{0}\");",
                            objViewInfoENEx.objViewGroupEx_Java.StutsActionFormObject,
                            objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + "if (form != null) {");
                // String zgh = UserToken.getUserid(request);

                ///生成专门用于传值的FORM字段变量
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strTemp = objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                        objComm.FstUcase(ref strTemp);
                        //						strCode.AppendFormat("\r\n {0} {1} = form.get{2}(\"{1}\");", 
                        //							objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                        //							objEditRegionFldsEx.FldName_Java, strTemp);
                        strCode.AppendFormat("\r\n {0} {3} = form.get{1}();",
                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType,
                        objComm.FirstUcase(objEditRegionFldsEx.FldName_Java),
                        strTemp,
                        objEditRegionFldsEx.FldName_Java);
                    }
                }

                strCode.Append("\r\n" + "}");

                strCode.Append("\r\n" + "%>");


                strCode.Append("\r\n" + "<html:html>");
                strCode.Append("\r\n" + "<head>");

                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/Globals.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/Common.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/DatePicker.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/validation.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/DWNameRule.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=gb2312\" />");

                //<META http-equiv="Content-Type" Content="text/html;charset=GBK">");
                strCode.AppendFormat("\r\n" + "<link href=\"{0}/js/style.css\" rel=\"stylesheet\" type=\"text/css\">",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/common.js\"></script>",
                    objProjects.VirtualDirectory);

                //strCode.Append("\r\n" + "<html:base />");
                //strCode.Append("\r\n" + "<html:meta />");
                //				strCode.Append("\r\n" + "<html:usercss cssName=\"styleoa\" />");
                //strCode.Append("\r\n" + "<html:usercss />");
                //strCode.Append("\r\n" + "<html:commonjs />");
                string strTabId = clsPrjTabBL.GetFirstID_S("TabName = '" + objViewInfoENEx.objMainPrjTab.TabName + "'");
                string strTabCnName = clsPrjTabBL.GetPrjTabByTabId(strTabId).TabCnName;

                strCode.AppendFormat("\r\n" + "<title> {0} ->添加</title>",
                strTabCnName);
                strCode.Append("\r\n" + "<link href=\"style.css\" rel=\"stylesheet\" type=\"text/css\">");

                strCode.Append("\r\n" + "<script type=\"text/javascript\" language=\"javascript\">");
                strCode.Append("\r\n" + "function submit()");
                strCode.Append("\r\n" + "{");
                ///生成专门用于传值的FORM字段变量
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCode.AppendFormat("\r\n" + "var j{0} = document.forms[0].{0}.value;",
                        objEditRegionFldsEx.FldName_Java);
                        if (objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
                        {
                            strCode.AppendFormat("\r\n" + "var j{0}xx = document.forms[0].{0}xx.value;",
                            objEditRegionFldsEx.FldName_Java);
                        }
                    }
                }
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        ///检查属性是否可为NULL;
                        if (objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable == false)
                        {
                            strCode.AppendFormat("\r\n if (\"\" == j{0})",
                            objEditRegionFldsEx.FldName_Java);
                            strCode.Append("\r\n {");
                            strCode.AppendFormat("\r\n alert(\"对不起! 字段[{0}]不能为空(NULL)!\");",
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                            strCode.Append("\r\nreturn false;");

                            strCode.Append("\r\n }");
                        }
                        ///检查属性长度代码;
                        if (objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                        && objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "String"
                        && objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength > 0)
                        {
                            strCode.AppendFormat("\r\nif (j{0}.length > {1})",
                            objEditRegionFldsEx.FldName_Java,
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim());
                            strCode.Append("\r\n{");
                            strCode.AppendFormat("\r\n alert(\"对不起! 字段[{0}]的长度不能超过{1}!\");",
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim());
                            strCode.Append("\r\n return false;");
                            strCode.Append("\r\n }");
                        }
                    }
                }
                strCode.Append("\r\nreturn true;");
                strCode.Append("\r\n }");

                strCode.Append("\r\n function check()");
                strCode.Append("\r\n {");
                strCode.Append("\r\n if(checkValue()==true&&submit()==true)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n var m = window.confirm(\"您确定要提交吗？\");");
                strCode.Append("\r\n if (m!=1)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n return false;");
                strCode.Append("\r\n }");
                strCode.AppendFormat("\r\n document.forms[0].method.value=\"{0}\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_AddSave);
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.Append("\r\n }");
                strCode.Append("\r\n }");
                strCode.Append("\r\n function check2()");
                strCode.Append("\r\n {");
                strCode.Append("\r\n if(checkValue()==true&&submit()==true)");
                strCode.Append("\r\n {");

                strCode.Append("\r\n document.forms[0].method.value=\"deletePublicInfo\";");
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.AppendFormat("\r\n document.forms[0].method.value=\"{0}2\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_AddSave);
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.Append("\r\n }");
                strCode.Append("\r\n }");
                strCode.Append("\r\n </script>");


                strCode.Append("\r\n" + "</head>");
                strCode.Append("\r\n" + "<body >");

                //<form id="EAPForm" name="com.taishsoft.shnu.humansys.baseinfo.abroadbiography.abroadBiographyForm" method="POST" action="{0}/humansys/baseinfo/abroadbiography/abroadBiographyAction.do" onsubmit="if(checkValue()){objViewInfoENEx.submit()}">

                strCode.AppendFormat("\r\n" + "<html:form action=\"{0}.do\">",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);

                //strCode.Append("\r\n" + "onsubmit=\"if(checkValue()){objViewInfoENEx.submit()}\">");

                //<script language="javascript">
                //formBak="addAbroadBiographySave";
                //</script>
                //<input type="hidden" id="method" name="method" value="addAbroadBiographySave"/>
                //<input type="hidden" name="com.neusoft.ecnuidc.html.TOKEN" value="4b7d21cacd7e08b9cc7e85d1cdc803d9">

                strCode.Append("\r\n" + "<script type=\"text/javascript\" language=\"javascript\">");
                strCode.AppendFormat("\r\n" + "formBak=\"{0}\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_AddSave);
                strCode.Append("\r\n" + "</script>");
                strCode.AppendFormat("\r\n" + "<input type=\"hidden\" id=\"method\" name=\"method\" value=\"{0}\"/>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_AddSave);
                strCode.Append("\r\n" + "<input type=\"hidden\" name=\"com.neusoft.ecnuidc.html.TOKEN\" value=\"4b7d21cacd7e08b9cc7e85d1cdc803d9\">");

                //<table border="0" id=table>
                //<tr>
                // <td width="25" height="23">&nbsp;</td>
                // <td class="HEADER ">

                //<a href="{0}/humansys/baseinfo/abroadbiography/abroadBiographyAction.do?method=listAbroadBiography&needinit=true">出国履历-列表</a>
                // </td>
                //</tr>

                //<tr> 
                // <td height="10" colspan="2"><img src="{0}/images/clear.gif" width="1" height="1"></td> 
                //</tr> 
                //<tr> 
                // <td><img src="/ywxt2/images/clear.gif" width="1" height="1"></td> 
                // <td> 

                strCode.Append("\r\n" + "<table border=\"0\" id=\"table\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td width=\"25\" height=\"23\">&nbsp;</td>");
                strCode.Append("\r\n" + "<td class=\"HEADER\">");
                strCode.AppendFormat("\r\n" + "<a href=\"{1}.do?method={2}&needinit=true\">{0}-列表</a>",
                        strTabCnName,
                        objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                        objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.AppendFormat("\r\n" + "<td height=\"10\" colspan=\"2\"><img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\"></td> ",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "</tr> ");
                strCode.Append("\r\n" + "<tr>");
                strCode.AppendFormat("\r\n" + "<td><img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\"></td>",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "<td>");

                //strCode.Append("\r\n" + "<html:frame>");
                //strCode.Append("\r\n" + "<html:frametitle>");
                //strCode.AppendFormat("\r\n" + "<html:link href=\"{2}/{1}Action.do?method=list{1}&needinit=true\" text=\"{0}-添加\" />",
                // strTabCnName, objViewInfoENEx.objViewGroupEx_Java.TableNameForProg,
                // objViewInfoENEx.objViewGroupEx_Java.ActionPath);
                //strCode.Append("\r\n" + "</html:frametitle>");


                //<table width="100%" border="0" cellpadding="0" cellspacing="0" class="deepa"> 
                // <tr> 
                // <th><table width="100%" border="0" cellpadding="0" cellspacing="3" ><tr><td> 出国履历 ->添加</td></tr></table></th> 
                // <th>&nbsp;</th> 
                // <th>&nbsp;</th> 
                // </tr> 
                // <tr> 
                // <td height=5 colspan="3" class="little"> <img src="/ywxt2/images/clear.gif" width="1" height="1"></td> 
                // </tr>
                // <tr>
                // <td colspan="3" class="lightcell">


                strCode.Append("\r\n" + "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"deepa\"> ");
                strCode.Append("\r\n" + "<tr> ");
                strCode.AppendFormat("\r\n" + "<th><table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"3\" ><tr><td> {0} ->添加</td></tr></table></th> ",
                strTabCnName);
                strCode.Append("\r\n" + "<th>&nbsp;</th> ");
                strCode.Append("\r\n" + "<th>&nbsp;</th> ");
                strCode.Append("\r\n" + "</tr> ");
                strCode.Append("\r\n" + "<tr> ");
                strCode.Append("\r\n" + "<td height=\"5\" colspan=\"3\" class=\"little\">");
                strCode.AppendFormat("\r\n" + "<img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\">",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "</td> ");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td colspan=\"3\" class=\"lightcell\">");

                //strCode.Append("\r\n" + "<html:framemain >");
                //strCode.AppendFormat("\r\n" + "<html:frametable comment=\"{0} ->添加\">",
                // strTabCnName);

                //<table width="100%" border=0 cellSpacing=1 cellPadding=3 class=deep>
                strCode.Append("\r\n" + "<table width=\"100%\" border=\"0\" cellSpacing=\"1\" cellPadding=\"3\" class=\"deep\">");
                string strStar = "";
                int intInd = 1;
                bool bolIsClosed = true;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        if (intInd % 2 == 1)
                        {
                            strCode.Append("\r\n" + "<tr>");
                            bolIsClosed = false;
                        }
                        strStar = objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable == false ? "*" : "";
                        if (objEditRegionFldsEx.INOUTTypeId == clsINOUTTypeENEx.IN_Type
                        || objEditRegionFldsEx.INOUTTypeId == clsINOUTTypeENEx.OUTIN_Type
                        )
                        {
                            switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                            {
                                case "CheckBox":
                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                    strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    strCode.AppendFormat("\r\n" + "<html:checkbox property=\"{0}\" />",
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName_Java);

                                    break;
                                case "":
                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                    strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    break;
                                case "TextBox":

                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    if (objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
                                    {
                                        // <td width="15%" class="cellLabel">
                                        // 回国入境日期*
                                        //</td>
                                        //<td width="35%" class="lightcell">
                                        // <ecnuidc:input id="hgrq" name="hgrq" htcname="Date"
                                        // prompt="回国入境日期" maxlength="10" isnullable="false" />
                                        //</td>
                                        //<td width="15%" class="cellLabel">回国入境日期*</td>
                                        //<td width="35%" class="lightcell">
                                        //<input type="text" value="" class="NEUHTCInput" onkeydown="javascript:enterToTab()" onkeypress="javascript:OnlyDate(this)" htcname="Date" prompt="回国入境日期" name="hgrq" maxlength="10" isnullable="false" id="hgrq" dateformat="yyyy-MM-dd" title="日期类型
                                        //格式为yyyy-MM-dd
                                        //如：2004-05-01代表2004年5月1日"/> 
                                        //<img alt="弹出日历下拉菜单" align="middle" style="cursor:hand;" src="/ywxt2/images/time.gif" onclick="show_calendar(document.forms[0].hgrq,'','',document.forms[0].hgrq.dateformat)"/>
                                        //<font color=red>*<font>
                                        //</td>

                                        strCode.AppendFormat("\r\n" + "<html:text property=\"{0}\" class=\"NEUHTCInput\" ",
                                        objEditRegionFldsEx.FldName_Java,
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                                        objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false",
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                                        strCode.Append("\r\n" + " onkeydown=\"javascript:enterToTab()\" onkeypress=\"javascript:OnlyDate(this)\" ");

                                        strCode.Append("\r\n" + " dateformat=\"yyyy-MM-dd\" title=\"日期类型格式为yyyy-MM-dd 如：2004-05-01代表2004年5月1日\" />");

                                        strCode.AppendFormat("\r\n" + " <img alt=\"弹出日历下拉菜单\" align=\"middle\" style=\"cursor:hand;\" src=\"{0}/images/time.gif\" onclick=\"show_calendar(document.forms[0].hgrq,\'\',\'\',document.forms[0].hgrq.dateformat)\"/>",
                                            objProjects.VirtualDirectory);
                                        strCode.Append("\r\n" + " <font color=red>*<font>");

                                        strCode.AppendFormat("\r\n" + "<html:text property=\"{0}\" value=\"8:00\" maxlength=\"5\" />（填写格式：HH:mm）",
                                        objEditRegionFldsEx.FldName_Java,
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                        objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false");
                                    }
                                    else
                                    {
                                        //<td width="15%" class="cellLabel">姓名</td>
                                        //<td width="35%" class="lightcell">
                                        //<input type="text" value="" class="NEUHTCReadOnly" readonly="readonly" onkeydown="javascript:enterToTab()" htcname="Text" prompt="姓名" readonly="true" name="xm" maxlength="30" isnullable="true" id="xm" title=""/>
                                        //</td>
                                        // <td width="35%" class="lightcell">
                                        // <ecnuidc:input id="pcdw" name="pcdw" htcname="Text"
                                        // prompt="派出单位" maxlength="60" isnullable="false" />
                                        //</td>
                                        //<td width="15%" class="cellLabel">派出单位*</td>
                                        //<td width="35%" class="lightcell">
                                        //<input type="text" value="" class="NEUHTCInput" onkeydown="javascript:enterToTab()" htcname="Text" prompt="派出单位" name="pcdw" maxlength="60" isnullable="false" id="pcdw" title=""/><font color=red>*<font>
                                        //</td>


                                        strCode.AppendFormat("\r\n" + "<html:text property=\"{0}\" maxlength=\"{2}\" />",
                                        objEditRegionFldsEx.FldName_Java,
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength,
                                        objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false");
                                    }
                                    break;
                                case "DropDownList":
                                    // <td width="15%" class="cellLabel">
                                    // 出国目的*
                                    //</td>
                                    //<td width="35%" class="lightcell">
                                    // <ecnuidc:dict id="cgmdm" name="cgmdm" prompt="出国目的"
                                    // attname="dsCGMDM" isnullable="false" />
                                    //</td>

                                    //<td width="15%" class="cellLabel">
                                    // 出国目的*</td>
                                    //<td width="35%" class="lightcell">
                                    // <select style="behavior: url(/ywxt2/htc/ecnuidc/Base.htc) url(/ywxt2/htc/ecnuidc/QuickSelect.htc)"
                                    // name="cgmdm" id="cgmdm" isnullable="false" prompt="出国目的 ">
                                    // <option value="">请选择</option>
                                    // <option value="01">常驻国外使馆、领事馆</option>
                                    // </select>
                                    // <font color="red">*<font>
                                    //</td>

                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    // <html:select property="part_type">												
                                    //    <html:options collection="arrPART_TYPE" property="pat_type_id" labelProperty="part_type_name" />
                                    //</html:select>

                                    strCode.AppendFormat("\r\n" + "<html:select property=\"{0}\">",
                                    objEditRegionFldsEx.FldName_Java,
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName);
                                    strCode.AppendFormat("\r\n" + "<html:options collection=\"arr{0}\" property=\"{1}\" labelProperty=\"{2}\"/>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.CodeTab,
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.CodeTab_Code.ToLower(),
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.CodeTab_Name.ToLower());
                                    strCode.Append("\r\n" + "</html:select>;");
                                    break;
                                case "RadioButton_Bool":
                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    strCode.AppendFormat("\r\n" + "是<INPUT TYPE=\"radio\" NAME=\"{0}\" value=\"yes\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",
                                    objEditRegionFldsEx.FldName_Java);
                                    strCode.AppendFormat("\r\n" + "否<INPUT TYPE=\"radio\" NAME=\"{0}\" value=\"no\" checked=\"checked\" >",
                                    objEditRegionFldsEx.FldName_Java);
                                    break;
                            }
                            strCode.AppendFormat("\r\n" + "</td>");
                        }
                        else
                        {
                            strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                            strCode.AppendFormat("\r\n" + "<input type=\"hidden\" id=\"{0}\" name=\"{0}\" value=\"<%={0}%>\"/>",
                            objEditRegionFldsEx.FldName_Java);

                            strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                            strCode.AppendFormat("\r\n" + "<%={0}%></td>",
                            objEditRegionFldsEx.FldName_Java);
                        }
                        if (intInd % 2 == 0)
                        {
                            strCode.Append("\r\n" + "</tr>");
                            bolIsClosed = true;
                        }
                        intInd++;
                    }
                }
                if (bolIsClosed == false)
                {
                    strCode.Append("\r\n" + "</tr>");

                }


                strCode.Append("\r\n" + "</table>");

                // </td>
                // </tr>
                // </table>
                // </td>
                //</tr>
                //<tr>
                // <td>
                // &nbsp;</td>
                // <td align="center">
                // &nbsp;</td>
                //</tr>
                //<tr>
                // <td>
                // &nbsp;</td>
                // <td align="center">

                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td>");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "<td align=\"center\">");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td>");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "<td align=\"center\">");

                // strCode.Append("\r\n" + "</html:frametable>");
                //strCode.Append("\r\n" + "</html:framemain>");
                //strCode.Append("\r\n" + "<html:framebottom>");
                //<table border="0">
                // <tr>
                // <td align="center" width="10%">
                // <input class="sbutton" type="button" value="提 交" onclick="check()">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                // <input class="sbutton" type="button" value="返 回" onclick="javascript:location.href='/ywxt2/humansys/baseinfo/abroadbiography/abroadBiographyAction.do?method=listAbroadBiography' ">
                // </td>
                // </tr>
                //</table>


                strCode.Append("\r\n" + "<table border=\"0\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td align=\"center\" width=\"10%\">");
                // <input class="sbutton" type="button" value="提 交" onclick="check()">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                // <input class="sbutton" type="button" value="返 回" onclick="javascript:location.href='/ywxt2/humansys/baseinfo/abroadbiography/abroadBiographyAction.do?method=listAbroadBiography' ">

                //strCode.AppendFormat("\r\n" + "<html:submit method=\"add{0}Save\" label=\"提 交\" onclick=\"check()\" confirm=\"确定提交吗？\"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",
                // objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);
                //strCode.AppendFormat("\r\n" + "<html:link likeSubmitStyle=\"true\" href=\"{1}/{0}Action.do?method=list{2}\" text=\"返 回\"/>",
                // objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase,
                // objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                // objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);

                strCode.AppendFormat("\r\n" + "<input type=\"button\" value=\"提 交\" onclick=\"check()\"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);
                strCode.AppendFormat("\r\n" + "<html:link href=\"{0}.do?method={2}\">返 回</html:link>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);

                strCode.Append("\r\n" + "</td >");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");

                // </td>
                // </tr>
                // </table>
                // </form>
                //</body>
                //</html>
                //strCode.Append("\r\n" + "</html:framebottom>");
                //strCode.Append("\r\n" + "</html:frame>");


                strCode.Append("\r\n" + " </td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</html:form>");

                strCode.Append("\r\n" + "</body>");
                strCode.Append("\r\n" + "</html:html>");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //检查该文件名的文件夹名，并判断是否存在;
            strFolder = objComm.ParentDir(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCode.ToString());
            return strCode.ToString();
        }


        public string GenUpdRecViewCode(clsViewInfoENEx objViewInfoENEx)
        {
            ///让用户设置属性;
            string strFolder;
            StringBuilder strCode = new StringBuilder(); ///用来存放WebForm的代码;
            string strTemp; ///临时变量;
            clsProjectsEN objProjects = clsProjectsBL.GetProjectsByPrjId(objViewInfoENEx.PrjId);
            objViewInfoENEx.WebFormName = objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_update";
            objViewInfoENEx.WebFormFName = mstrFolderName + objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_update.jsp";
            mstrFileName = objViewInfoENEx.WebFormFName;
            //clsProjectsENEx objProjects = new clsProjectsENEx(objViewInfoENEx.PrjId, true);
            try
            {
                ///生成插入记录的界面代码;
                /// strCode.Append("///生成插入记录的界面代码");
                /// 


                //<%@ page contentType="text/html; charset=gb2312"%>
                strCode.Append("\r\n" + "<%@ page contentType=\"text/html; charset=GBK\" %>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-bean.tld\" prefix=\"bean\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-logic.tld\" prefix=\"logic\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-html.tld\" prefix=\"html\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-nested.tld\" prefix=\"nested\"%>");

                //strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/taglib/ecnuidc\" prefix=\"ecnuidc\" %>");
                strCode.AppendFormat("\r\n" + "<%@ page import=\"{0}.{1}Form\"%>",
                objViewInfoENEx.objViewGroupEx_Java.PrjDomain,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstUcase);
                strCode.AppendFormat("\r\n" + "<%@ page import=\"{0}\"%>",
                objViewInfoENEx.objViewGroupEx_Java.StutsManagerClass);
                //strCode.Append("\r\n" + "<%@ page import=\"com.neusoft.util.DateTool\" %>");
                strCode.Append("\r\n" + "<%@ page import=\"java.util.Date\"%>");
                strCode.Append("\r\n" + "<%");
                strCode.Append("\r\n" + "");
                strCode.AppendFormat("\r\n {1}Form form=({1}Form)request.getAttribute(\"{0}\");",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionFormObject,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstUcase);
                ///生成专门用于传值的FORM字段变量
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strTemp = objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                        objComm.FstUcase(ref strTemp);
                        //						strCode.AppendFormat("\r\n {0} {1} = form.get{2}(\"{1}\");", 
                        //							objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                        //							objEditRegionFldsEx.FldName_Java, strTemp);
                        strCode.AppendFormat("\r\n {0} {1} = null;",
                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType,
                        objEditRegionFldsEx.FldName_Java, strTemp);
                    }
                }


                strCode.Append("\r\n" + "if (form != null) {");
                // String zgh = UserToken.getUserid(request);

                ///生成专门用于传值的FORM字段变量
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strTemp = objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                        objComm.FstUcase(ref strTemp);
                        //						strCode.AppendFormat("\r\n {0} {1} = form.get{2}(\"{1}\");", 
                        //							objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                        //							objEditRegionFldsEx.FldName_Java, strTemp);
                        strCode.AppendFormat("\r\n {3} = form.get{1}();",
                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objComm.FirstUcase(objEditRegionFldsEx.FldName_Java),
                        strTemp,
                        objEditRegionFldsEx.FldName_Java);
                    }
                }

                strCode.Append("\r\n" + "}");

                strCode.Append("\r\n" + "%>");


                strCode.Append("\r\n" + "<html:html>");
                strCode.Append("\r\n" + "<head>");

                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/Globals.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/Common.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/DatePicker.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/validation.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/DWNameRule.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=gb2312\" />");

                //<META http-equiv="Content-Type" Content="text/html;charset=GBK">");
                strCode.AppendFormat("\r\n" + "<link href=\"{0}/js/style.css\" rel=\"stylesheet\" type=\"text/css\">",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/common.js\"></script>",
                    objProjects.VirtualDirectory);

                //strCode.Append("\r\n" + "<html:base />");
                //strCode.Append("\r\n" + "<html:meta />");
                //				strCode.Append("\r\n" + "<html:usercss cssName=\"styleoa\" />");
                //strCode.Append("\r\n" + "<html:usercss />");
                //strCode.Append("\r\n" + "<html:commonjs />");
                string strTabId = clsPrjTabBL.GetFirstID_S("TabName = '" + objViewInfoENEx.objMainPrjTab.TabName + "'");
                string strTabCnName = clsPrjTabBL.GetPrjTabByTabId(strTabId).TabCnName;

                strCode.AppendFormat("\r\n" + "<title> {0} ->修改</title>",
                strTabCnName);
                strCode.Append("\r\n" + "<link href=\"style.css\" rel=\"stylesheet\" type=\"text/css\">");

                strCode.Append("\r\n" + "<script type=\"text/javascript\" language=\"javascript\">");
                strCode.Append("\r\n" + "function submit()");
                strCode.Append("\r\n" + "{");
                ///生成专门用于传值的FORM字段变量
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCode.AppendFormat("\r\n" + "var j{0} = document.forms[0].{0}.value;",
                        objEditRegionFldsEx.FldName_Java);
                        if (objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
                        {
                            strCode.AppendFormat("\r\n" + "var j{0}xx = document.forms[0].{0}xx.value;",
                            objEditRegionFldsEx.FldName_Java);
                        }
                    }
                }
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        ///检查属性是否可为NULL;
                        if (objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable == false)
                        {
                            strCode.AppendFormat("\r\n if (\"\" == j{0})",
                            objEditRegionFldsEx.FldName_Java);
                            strCode.Append("\r\n {");
                            strCode.AppendFormat("\r\n alert(\"对不起! 字段[{0}]不能为空(NULL)!\");",
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                            strCode.Append("\r\nreturn false;");

                            strCode.Append("\r\n }");
                        }
                        ///检查属性长度代码;
                        if (objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                        && objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "String"
                        && objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength > 0)
                        {
                            strCode.AppendFormat("\r\nif (j{0}.length > {1})",
                            objEditRegionFldsEx.FldName_Java,
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim());
                            strCode.Append("\r\n{");
                            strCode.AppendFormat("\r\n alert(\"对不起! 字段[{0}]的长度不能超过{1}!\");",
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim());
                            strCode.Append("\r\n return false;");
                            strCode.Append("\r\n }");
                        }
                    }
                }
                strCode.Append("\r\nreturn true;");
                strCode.Append("\r\n }");

                strCode.Append("\r\n function check()");
                strCode.Append("\r\n {");
                strCode.Append("\r\n if(checkValue()==true&&submit()==true)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n var m = window.confirm(\"您确定要提交吗？\");");
                strCode.Append("\r\n if (m!=1)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n return false;");
                strCode.Append("\r\n }");
                strCode.AppendFormat("\r\n document.forms[0].method.value=\"{0}\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.Append("\r\n }");
                strCode.Append("\r\n }");
                strCode.Append("\r\n function check2()");
                strCode.Append("\r\n {");
                strCode.Append("\r\n if(checkValue()==true&&submit()==true)");
                strCode.Append("\r\n {");

                strCode.Append("\r\n document.forms[0].method.value=\"deletePublicInfo\";");
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.AppendFormat("\r\n document.forms[0].method.value=\"{0}2\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.Append("\r\n }");
                strCode.Append("\r\n }");
                strCode.Append("\r\n </script>");


                strCode.Append("\r\n" + "</head>");
                strCode.Append("\r\n" + "<body >");

                //<form id="EAPForm" name="com.taishsoft.shnu.humansys.baseinfo.abroadbiography.abroadBiographyForm" method="POST" action="/ywxt2/humansys/baseinfo/abroadbiography/abroadBiographyAction.do" onsubmit="if(checkValue()){objViewInfoENEx.submit()}">

                strCode.AppendFormat("\r\n" + "<html:form action=\"{0}.do\"> ",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);
                strCode.AppendFormat("\r\n" + "<html:hidden property=\"{0}\"/>",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.FldName_Java);

                //strCode.Append("\r\n" + "onsubmit=\"if(checkValue()){objViewInfoENEx.submit()}\">");

                //<script language="javascript">
                //formBak="addAbroadBiographySave";
                //</script>
                //<input type="hidden" id="method" name="method" value="addAbroadBiographySave"/>
                //<input type="hidden" name="com.neusoft.ecnuidc.html.TOKEN" value="4b7d21cacd7e08b9cc7e85d1cdc803d9">

                strCode.Append("\r\n" + "<script type=\"text/javascript\" language=\"javascript\">");
                strCode.AppendFormat("\r\n" + "formBak=\"{0}\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n" + "</script>");
                strCode.AppendFormat("\r\n" + "<input type=\"hidden\" id=\"method\" name=\"method\" value=\"{0}\"/>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n" + "<input type=\"hidden\" name=\"com.neusoft.ecnuidc.html.TOKEN\" value=\"4b7d21cacd7e08b9cc7e85d1cdc803d9\">");

                //<table border="0" id=table>
                //<tr>
                // <td width="25" height="23">&nbsp;</td>
                // <td class="HEADER ">

                //<a href="/ywxt2/humansys/baseinfo/abroadbiography/abroadBiographyAction.do?method=listAbroadBiography&needinit=true">出国履历-列表</a>
                // </td>
                //</tr>

                //<tr> 
                // <td height="10" colspan="2"><img src="/ywxt2/images/clear.gif" width="1" height="1"></td> 
                //</tr> 
                //<tr> 
                // <td><img src="/ywxt2/images/clear.gif" width="1" height="1"></td> 
                // <td> 

                strCode.Append("\r\n" + "<table border=\"0\" id=\"table\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td width=\"25\" height=\"23\">&nbsp;</td>");
                strCode.Append("\r\n" + "<td class=\"HEADER\">");
                strCode.AppendFormat("\r\n" + "<a href=\"{1}.do?method={2}&needinit=true\">{0}-列表</a>",
                        strTabCnName,
                        objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                        objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.AppendFormat("\r\n" + "<td height=\"10\" colspan=\"2\"><img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\"></td> ",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "</tr> ");
                strCode.Append("\r\n" + "<tr>");
                strCode.AppendFormat("\r\n" + "<td><img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\"></td>",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "<td>");

                //strCode.Append("\r\n" + "<html:frame>");
                //strCode.Append("\r\n" + "<html:frametitle>");
                //strCode.AppendFormat("\r\n" + "<html:link href=\"{2}/{1}Action.do?method=list{1}&needinit=true\" text=\"{0}-添加\" />",
                // strTabCnName, objViewInfoENEx.objViewGroupEx_Java.TableNameForProg,
                // objViewInfoENEx.objViewGroupEx_Java.ActionPath);
                //strCode.Append("\r\n" + "</html:frametitle>");


                //<table width="100%" border="0" cellpadding="0" cellspacing="0" class="deepa"> 
                // <tr> 
                // <th><table width="100%" border="0" cellpadding="0" cellspacing="3" ><tr><td> 出国履历 ->添加</td></tr></table></th> 
                // <th>&nbsp;</th> 
                // <th>&nbsp;</th> 
                // </tr> 
                // <tr> 
                // <td height=5 colspan="3" class="little"> <img src="/ywxt2/images/clear.gif" width="1" height="1"></td> 
                // </tr>
                // <tr>
                // <td colspan="3" class="lightcell">


                strCode.Append("\r\n" + "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"deepa\"> ");
                strCode.Append("\r\n" + "<tr> ");
                strCode.Append("\r\n" + "<th><table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"3\" >");
                strCode.AppendFormat("\r\n" + "<tr><td> {0} ->修改</td></tr>",
                strTabCnName);
                strCode.Append("\r\n" + "</table></th> ");
                strCode.Append("\r\n" + "<th>&nbsp;</th> ");
                strCode.Append("\r\n" + "<th>&nbsp;</th> ");
                strCode.Append("\r\n" + "</tr> ");
                strCode.Append("\r\n" + "<tr> ");
                strCode.Append("\r\n" + "<td height=\"5\" colspan=\"3\" class=\"little\">");
                strCode.AppendFormat("\r\n" + "<img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\">",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "</td> ");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td colspan=\"3\" class=\"lightcell\">");

                //strCode.Append("\r\n" + "<html:framemain >");
                //strCode.AppendFormat("\r\n" + "<html:frametable comment=\"{0} ->添加\">",
                // strTabCnName);
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.IsTabPrimary == true)
                    {
                        strCode.AppendFormat("\r\n" + "<input type=\"hidden\" id=\"{0}\" name=\"{0}\" value=\"<%={0}%>\"/>",
                        objEditRegionFldsEx.FldName_Java);
                    }
                }
                //<table width="100%" border=0 cellSpacing=1 cellPadding=3 class=deep>
                strCode.Append("\r\n" + "<table width=\"100%\" border=\"0\" cellSpacing=\"1\" cellPadding=\"3\" class=\"deep\">");
                string strStar = "";
                int intInd = 1;
                bool bolIsClosed = true;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        if (intInd % 2 == 1)
                        {
                            strCode.Append("\r\n" + "<tr>");
                            bolIsClosed = false;
                        }
                        strStar = objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable == false ? "*" : "";
                        if (objEditRegionFldsEx.INOUTTypeId == clsINOUTTypeENEx.IN_Type
                        || objEditRegionFldsEx.INOUTTypeId == clsINOUTTypeENEx.OUTIN_Type
                        )
                        {
                            switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                            {
                                case "CheckBox":
                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                    strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    strCode.AppendFormat("\r\n" + "<html:checkbox property=\"{0}\" />",
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName_Java);

                                    break;
                                case "":
                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                    strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    break;
                                case "TextBox":

                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    if (objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
                                    {
                                        // <td width="15%" class="cellLabel">
                                        // 回国入境日期*
                                        //</td>
                                        //<td width="35%" class="lightcell">
                                        // <ecnuidc:input id="hgrq" name="hgrq" htcname="Date"
                                        // prompt="回国入境日期" maxlength="10" isnullable="false" />
                                        //</td>
                                        //<td width="15%" class="cellLabel">回国入境日期*</td>
                                        //<td width="35%" class="lightcell">
                                        //<input type="text" value="" class="NEUHTCInput" onkeydown="javascript:enterToTab()" onkeypress="javascript:OnlyDate(this)" htcname="Date" prompt="回国入境日期" name="hgrq" maxlength="10" isnullable="false" id="hgrq" dateformat="yyyy-MM-dd" title="日期类型
                                        //格式为yyyy-MM-dd
                                        //如：2004-05-01代表2004年5月1日"/> 
                                        //<img alt="弹出日历下拉菜单" align="middle" style="cursor:hand;" src="/ywxt2/images/time.gif" onclick="show_calendar(document.forms[0].hgrq,'','',document.forms[0].hgrq.dateformat)"/>
                                        //<font color=red>*<font>
                                        //</td>

                                        strCode.AppendFormat("\r\n" + "<html:text property=\"{0}\" class=\"NEUHTCInput\" ",
                                        objEditRegionFldsEx.FldName_Java,
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                                        objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false",
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                                        strCode.Append("\r\n" + " onkeydown=\"javascript:enterToTab()\" onkeypress=\"javascript:OnlyDate(this)\" ");

                                        strCode.Append("\r\n" + " dateformat=\"yyyy-MM-dd\" title=\"日期类型格式为yyyy-MM-dd 如：2004-05-01代表2004年5月1日\" />");

                                        strCode.AppendFormat("\r\n" + " <img alt=\"弹出日历下拉菜单\" align=\"middle\" style=\"cursor:hand;\" src=\"{0}/images/time.gif\" onclick=\"show_calendar(document.forms[0].hgrq,\'\',\'\',document.forms[0].hgrq.dateformat)\"/>",
                                            objProjects.VirtualDirectory);
                                        strCode.Append("\r\n" + " <font color=red>*<font>");

                                        strCode.AppendFormat("\r\n" + "<html:text property=\"{0}\" value=\"8:00\" maxlength=\"5\" />（填写格式：HH:mm）",
                                        objEditRegionFldsEx.FldName_Java,
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                        objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false");
                                    }
                                    else
                                    {
                                        //<td width="15%" class="cellLabel">姓名</td>
                                        //<td width="35%" class="lightcell">
                                        //<input type="text" value="" class="NEUHTCReadOnly" readonly="readonly" onkeydown="javascript:enterToTab()" htcname="Text" prompt="姓名" readonly="true" name="xm" maxlength="30" isnullable="true" id="xm" title=""/>
                                        //</td>
                                        // <td width="35%" class="lightcell">
                                        // <ecnuidc:input id="pcdw" name="pcdw" htcname="Text"
                                        // prompt="派出单位" maxlength="60" isnullable="false" />
                                        //</td>
                                        //<td width="15%" class="cellLabel">派出单位*</td>
                                        //<td width="35%" class="lightcell">
                                        //<input type="text" value="" class="NEUHTCInput" onkeydown="javascript:enterToTab()" htcname="Text" prompt="派出单位" name="pcdw" maxlength="60" isnullable="false" id="pcdw" title=""/><font color=red>*<font>
                                        //</td>


                                        strCode.AppendFormat("\r\n" + "<html:text property=\"{0}\" maxlength=\"{2}\"/>",
                                        objEditRegionFldsEx.FldName_Java,
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength,
                                        objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false");
                                    }
                                    break;
                                case "DropDownList":
                                    // <td width="15%" class="cellLabel">
                                    // 出国目的*
                                    //</td>
                                    //<td width="35%" class="lightcell">
                                    // <ecnuidc:dict id="cgmdm" name="cgmdm" prompt="出国目的"
                                    // attname="dsCGMDM" isnullable="false" />
                                    //</td>

                                    //<td width="15%" class="cellLabel">
                                    // 出国目的*</td>
                                    //<td width="35%" class="lightcell">
                                    // <select style="behavior: url(/ywxt2/htc/ecnuidc/Base.htc) url(/ywxt2/htc/ecnuidc/QuickSelect.htc)"
                                    // name="cgmdm" id="cgmdm" isnullable="false" prompt="出国目的 ">
                                    // <option value="">请选择</option>
                                    // <option value="01">常驻国外使馆、领事馆</option>
                                    // </select>
                                    // <font color="red">*<font>
                                    //</td>

                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    // <html:select property="part_type">												
                                    //    <html:options collection="arrPART_TYPE" property="pat_type_id" labelProperty="part_type_name" />
                                    //</html:select>

                                    strCode.AppendFormat("\r\n" + "<html:select property=\"{0}\">",
                                    objEditRegionFldsEx.FldName_Java,
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName);
                                    strCode.AppendFormat("\r\n" + "<html:options collection=\"arr{0}\" property=\"{1}\" labelProperty=\"{2}\"/>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.CodeTab,
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.CodeTab_Code.ToLower(),
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.CodeTab_Name.ToLower());
                                    strCode.Append("\r\n" + "</html:select>;");
                                    break;
                                case "RadioButton_Bool":
                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    strCode.AppendFormat("\r\n" + "是<INPUT TYPE=\"radio\" NAME=\"{0}\" value=\"yes\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",
                                    objEditRegionFldsEx.FldName_Java);
                                    strCode.AppendFormat("\r\n" + "否<INPUT TYPE=\"radio\" NAME=\"{0}\" value=\"no\" checked=\"checked\" >",
                                    objEditRegionFldsEx.FldName_Java);
                                    break;
                            }
                            strCode.AppendFormat("\r\n" + "</td>");
                        }
                        else
                        {
                            strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                            strCode.AppendFormat("\r\n" + "<input type=\"hidden\" id=\"{0}\" name=\"{0}\" value=\"<%={0}%>\"/>",
                            objEditRegionFldsEx.FldName_Java);

                            strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                            strCode.AppendFormat("\r\n" + "<%={0}%></td>",
                            objEditRegionFldsEx.FldName_Java);
                        }
                        if (intInd % 2 == 0)
                        {
                            strCode.Append("\r\n" + "</tr>");
                            bolIsClosed = true;
                        }
                        intInd++;
                    }
                }
                if (bolIsClosed == false)
                {
                    strCode.Append("\r\n" + "</tr>");
                }
                strCode.Append("\r\n" + "</table>");

                // </td>
                // </tr>
                // </table>
                // </td>
                //</tr>
                //<tr>
                // <td>
                // &nbsp;</td>
                // <td align="center">
                // &nbsp;</td>
                //</tr>
                //<tr>
                // <td>
                // &nbsp;</td>
                // <td align="center">

                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td>");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "<td align=\"center\">");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td>");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "<td align=\"center\">");

                // strCode.Append("\r\n" + "</html:frametable>");
                //strCode.Append("\r\n" + "</html:framemain>");
                //strCode.Append("\r\n" + "<html:framebottom>");
                //<table border="0">
                // <tr>
                // <td align="center" width="10%">
                // <input class="sbutton" type="button" value="提 交" onclick="check()">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                // <input class="sbutton" type="button" value="返 回" onclick="javascript:location.href='/ywxt2/humansys/baseinfo/abroadbiography/abroadBiographyAction.do?method=listAbroadBiography' ">
                // </td>
                // </tr>
                //</table>


                strCode.Append("\r\n" + "<table border=\"0\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td align=\"center\" width=\"10%\">");
                // <input class="sbutton" type="button" value="提 交" onclick="check()">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                // <input class="sbutton" type="button" value="返 回" onclick="javascript:location.href='/ywxt2/humansys/baseinfo/abroadbiography/abroadBiographyAction.do?method=listAbroadBiography' ">

                //strCode.AppendFormat("\r\n" + "<html:submit method=\"update{0}Save\" label=\"提 交\" onclick=\"check()\" confirm=\"确定提交吗？\"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",
                // objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);
                //strCode.AppendFormat("\r\n" + "<html:link likeSubmitStyle=\"true\" href=\"{1}/{0}Action.do?method=list{2}\" text=\"返 回\"/>",
                // objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase,
                // objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                // objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);

                strCode.AppendFormat("\r\n" + "<html:submit value=\"提 交\" onclick=\"check()\"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);
                strCode.AppendFormat("\r\n" + "<html:link href=\"{0}.do?method={2}\">返 回</html:link>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);

                strCode.Append("\r\n" + "</td >");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");

                // </td>
                // </tr>
                // </table>
                // </form>
                //</body>
                //</html>
                //strCode.Append("\r\n" + "</html:framebottom>");
                //strCode.Append("\r\n" + "</html:frame>");


                strCode.Append("\r\n" + " </td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</html:form>");

                strCode.Append("\r\n" + "</body>");
                strCode.Append("\r\n" + "</html:html>");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //检查该文件名的文件夹名，并判断是否存在;
            strFolder = objComm.ParentDir(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCode.ToString());
            return strCode.ToString();
        }


        private string GenViewTitle(string strTitle)
        {
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetTitleStyleByTitleStyleId(objViewInfoENEx.TitleStyleId);
            StringBuilder strCode = new StringBuilder(); ///用来存放WebForm的代码;
            //			string strTemp; ///临时变量;
            ///生成Label的代码;
            switch (objTitleStyle.TitleTypeId)
            {
                case "01":
                    strCode.AppendFormat("\r\n" + "<table id=\"tabTitle\" style=\"z-index: 102; left: 8px; position: absolute; top: 1px\" cellSpacing=\"1\" ");
                    strCode.AppendFormat("\r\n" + "cellPadding=\"1\" width=\"100%\" bgColor=\"{0}\" border=\"0\">",
                    objTitleStyle.BackColor);
                    strCode.AppendFormat("\r\n" + "<tr>");
                    strCode.AppendFormat("\r\n" + "<td bgColor=\"{0}\">",
                    objTitleStyle.BackColor);
                    strCode.AppendFormat("\r\n" + "<asp:Label id=\"lblViewTile\" runat=\"server\" Font-Size=\"Small\" Font-Names=\"宋体\" ForeColor=\"{1}\" Font-Bold=\"True\">{0}</asp:Label>",
                    strTitle, objTitleStyle.ForeColor);
                    strCode.AppendFormat("\r\n" + "</td>");
                    strCode.AppendFormat("\r\n" + "</tr>");
                    strCode.AppendFormat("\r\n" + "</table>");
                    break;
                case "02":
                    strCode.AppendFormat("\r\n" + "<IMG style=\"z-index: 105; left: 8px; position: absolute; top: 1px\" height=\"{0}\" alt=\"\" ",
                    objTitleStyle.TabHeight);
                    strCode.AppendFormat("\r\n" + "src=\"{0}\" width=\"840\"> ",
                    objTitleStyle.ImgFile);
                    strCode.AppendFormat("\r\n" + "<DIV style=\"DISPLAY: inline; FONT-SIZE: x-small; z-index: 106; left: 16px; width: 300px; COLOR: #000066; position: absolute; top: 16px; height: 15px\" ");
                    strCode.AppendFormat("\r\n" + "	ms_positioning=\"FlowLayout\">{0}",
                    strTitle);
                    strCode.AppendFormat("\r\n" + "	</DIV>");
                    break;
                case "03":
                    strCode.AppendFormat("\r\n" + "<asp:label id=\"lblViewTitle\" style=\"z-index: 114; left: 8px; position: absolute; top: 1px\" runat=\"server\" ");
                    strCode.AppendFormat("\r\n" + "Font-Size=\"Larger\" Font-Names=\"黑体\" Height=\"{0}px\" Width=\"{3}px\" ForeColor=\"{1}\">{2}</asp:label>",
                    objTitleStyle.TabHeight, objTitleStyle.ForeColor, strTitle, objTitleStyle.TabWidth);
                    break;
            }

            intZIndex += 1;
            return strCode.ToString();


        }
        private string gfunRadioClick(clsViewInfoENEx objViewInfoENEx)
        {
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetTitleStyleByTitleStyleId(objViewInfoENEx.TitleStyleId);
            StringBuilder strCode = new StringBuilder(); ///用来存放WebForm的代码;
            //			string strTemp; ///临时变量;
            ///生成Label的代码;
            strCode.Append("\r\n" + "<script language=\"javascript\">");
            strCode.Append("\r\n" + "<!--");
            strCode.Append("\r\n" + "function radioClick()");
            strCode.Append("\r\n" + "{");
            strCode.Append("\r\n" + "if (document.Form1.RadioName !=null)");
            strCode.Append("\r\n" + "{");
            strCode.Append("\r\n" + "for (i=0; i<document.Form1.RadioName.length; i++)");
            strCode.Append("\r\n" + "{");
            strCode.Append("\r\n" + "if (document.Form1.RadioName[i].checked == true)");
            strCode.Append("\r\n" + "{");
            strCode.Append("\r\n" + "document.Form1.rd.value = document.Form1.RadioName[i].value;");
            //document.getElementById("TextBox1").value = document.Form1.rd.value;
            strCode.Append("\r\n" + "}");
            strCode.Append("\r\n" + "}");
            strCode.Append("\r\n" + "}");
            strCode.Append("\r\n" + "}");
            strCode.Append("\r\n" + "//-->");
            strCode.Append("\r\n" + "</script>");

            intZIndex += 1;
            return strCode.ToString();


        }


        /// <summary>
        /// 生成表列表界面代码
        /// </summary>
        /// <returns></returns>
        public string GenListRecViewCode(clsViewInfoENEx objViewInfoENEx)
        {
            ///让用户设置属性;
            string strFolder;
            StringBuilder strCode = new StringBuilder(); ///用来存放WebForm的代码;

            objViewInfoENEx.WebFormName = objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_list";
            objViewInfoENEx.WebFormFName = mstrFolderName + objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_list.jsp";
            mstrFileName = objViewInfoENEx.WebFormFName;
            clsProjectsENEx objProjects = new clsProjectsENEx(objViewInfoENEx.PrjId, true);

            try
            {
                ///生成插入记录的界面代码;
                /// strCode.Append("///生成插入记录的界面代码");
                strCode.Append("\r\n" + "<%@ page contentType=\"text/html; charset=GBK\" %>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-bean.tld\" prefix=\"bean\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-logic.tld\" prefix=\"logic\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-html.tld\" prefix=\"html\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-nested.tld\" prefix=\"nested\"%>");

                // strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/taglib/ecnuidc\" prefix=\"ecnuidc\" %>");
                //strCode.Append("\r\n" + "<html>");
                //strCode.Append("\r\n" + "<head>");
                //strCode.Append("\r\n" + "<html:base />");
                //strCode.Append("\r\n" + "<html:meta />");
                //strCode.Append("\r\n" + "<html:usercss cssName=\"styleoa\" />");
                //strCode.Append("\r\n" + "<html:commonjs />");

                strCode.Append("\r\n" + "<html:html>");
                strCode.Append("\r\n" + "<head>");

                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/Globals.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/Common.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/DatePicker.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/validation.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/DWNameRule.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/common.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=gb2312\" />");
                strCode.AppendFormat("\r\n" + "<link href=\"{0}/js/style.css\" rel=\"stylesheet\" type=\"text/css\">",
                    objProjects.VirtualDirectory);


                strCode.Append("\r\n" + "<script type=\"text/javascript\" language=\"javascript\">");
                strCode.Append("\r\n" + "sortNumberArray = new Array(1);");
                strCode.Append("\r\n" + "sortNumberArray[0] = \"ID\";");
                strCode.Append("\r\n" + "function getAccess()");
                strCode.Append("\r\n" + "{");
                strCode.Append("\r\n" + "return 'true';");
                strCode.Append("\r\n" + "}");
                strCode.Append("\r\n" + "function checkupdate()");
                strCode.Append("\r\n" + "{");
                strCode.Append("\r\n" + "}");
                strCode.Append("\r\n" + "</script>");

                string strTabId = clsPrjTabBL.GetFirstID_S("TabName = '" + objViewInfoENEx.objMainPrjTab.TabName + "'");
                string strTabCnName = clsPrjTabBL.GetPrjTabByTabId(strTabId).TabCnName;

                strCode.AppendFormat("\r\n" + "<title> {0} ->列表</title>",
                strTabCnName);
                strCode.Append("\r\n" + "</head>");
                strCode.Append("\r\n" + "<body onload=\"window_onload()\">");
                //strCode.Append("\r\n" + "<html:frame>");
                strCode.Append("\r\n" + "<table border=\"0\" id=\"table\">");
                strCode.AppendFormat("\r\n" + "<html:form action=\"{0}.do\">",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);
                strCode.Append("\r\n" + "<script type=\"text/javascript\" language=\"javascript\">");
                strCode.Append("\r\n" + "formBak=\"listWorkBiography\";");
                strCode.Append("\r\n" + "</script>");
                strCode.Append("\r\n" + "<input type=\"hidden\" id=\"method\" name=\"method\" value=\"listWorkBiography\"/>");
                strCode.Append("\r\n" + "<input type=\"hidden\" name=\"com.neusoft.ecnuidc.html.TOKEN\" value=\"3816d5f73180422758a22143582b0585\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td width=\"25\" height=\"23\">&nbsp;</td>");
                strCode.Append("\r\n" + "<td class=\"HEADER \">");

                //strCode.Append("\r\n" + "<html:frametitle>");
                strCode.AppendFormat("\r\n" + "<html:link href=\"{0}.do?method={2}&needinit=true\">{1}-列表</html:link>",
                        objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                        strTabCnName,
                        objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.AppendFormat("\r\n" + "<td height=\"10\" colspan=\"2\"><img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\"></td> ",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "</tr> ");
                strCode.Append("\r\n" + "<tr>");
                strCode.AppendFormat("\r\n" + "<td><img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\"></td>",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "<td>");

                //strCode.Append("\r\n" + "</html:frametitle>");
                //strCode.Append("\r\n" + "<html:framemain >");

                strCode.Append("\r\n" + "<table width=\"100%\" border=\"0\" cellpadding=\"1\" cellspacing=\"1\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td > <script type=\"text/javascript\" language=\"JavaScript\" >");
                strCode.Append("\r\n" + "doCheckAllBox();");
                strCode.Append("\r\n" + "</script>");
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "<td align=\"right\">");
                strCode.Append("\r\n" + "<table border=\"0\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td>");


                //strCode.Append("\r\n" + "<html:frametoolbar hasAllSelect=\"false\">");
                strCode.AppendFormat("\r\n" + "<td><input type=\"button\" value=\"添 加\" onclick=\"javascript:submit_form(\'\',\'\',\'\',\'{0}\',\'\')\" /></td>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_Add);
                strCode.AppendFormat("\r\n" + "<td><input type=\"button\" value=\"修 改\" onclick=\"javascript:submit_form(\'\',\'true\',\'\',\'{0}\',\'\')\" /></td>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_Update);
                strCode.AppendFormat("\r\n" + "<td><input type=\"button\" value=\"删 除\" onclick=\"javascript:submit_form(\'\',\'\',\'确定要删除吗？\',\'{0}\',\'true\')\" /></td>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_Delete);
                strCode.AppendFormat("\r\n" + "<td><input type=\"button\" value=\"查 询\" onclick=\"javascript:submit_form(\'\',\'\',\'\',\'{0}\',\'\')\" /></td>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_Query);
                strCode.AppendFormat("\r\n" + "<td><input type=\"button\" name=\"util_export_config\" class=\"sbutton\" onclick=\"javascript:window.open(\'{0}/util/export_config.do\',\'export_config_window\')\" value=\"导 出\"/></td>",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr> ");
                strCode.Append("\r\n" + "</table> ");
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr> ");
                strCode.Append("\r\n" + "</table> ");
                strCode.Append("\r\n" + "<script type=\"text/javascript\" language=\"javascript\">");
                strCode.Append("\r\n" + "intTotalRecords=3;");
                strCode.Append("\r\n" + "intRecordsPerPage=10;");
                strCode.Append("\r\n" + "intCurrentPage=1;");
                strCode.Append("\r\n" + "intCurrentBlock=0;");
                strCode.Append("\r\n" + "intCursor=0;");
                strCode.Append("\r\n" + "intMaxrows=100");
                strCode.Append("\r\n" + "</script>");

                //strCode.Append("\r\n" + "</html:frametoolbar>");
                //strCode.AppendFormat("\r\n" + "<html:framelist result=\"result\" xslfile=\"/xsl{1}/{0}_list.xsl\" />",
                // objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase,
                // objViewInfoENEx.objViewGroupEx_Java.ActionPath);
                strCode.Append("\r\n" + "<table width=\"100%\" border=\"1\" cellpadding=\"0\" cellspacing=\"0\">");
                strCode.Append("\r\n" + "						<tr>");
                strCode.Append("\r\n" + "<td>");
                strCode.Append("\r\n" + "&nbsp;");
                strCode.Append("\r\n" + "</td>");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {

                    strCode.AppendFormat("\r\n" + "<td>{1}</td>",
                    objDGRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                    objDGRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                }
                strCode.Append("\r\n" + "<td>&nbsp;</td>");
                strCode.Append("\r\n" + "<td>&nbsp;</td>");
                strCode.Append("\r\n" + "<td>&nbsp;</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.AppendFormat("\r\n" + "<logic:iterate id=\"element\" property=\"selectList\" name=\"{0}.{1}Form\" indexId=\"i\">",
                objViewInfoENEx.objViewGroupEx_Java.PrjDomain,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase);
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td>");
                strCode.AppendFormat("\r\n" + "<bean:define id=\"id\" name=\"element\" property=\"{0}\"></bean:define>",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.FldName_Java);
                strCode.Append("\r\n" + "<input type=\"checkbox\" name=\"<%=\"chk[\" + i.intValue() + \"]\"%>\"");
                strCode.Append("\r\n" + "value=\"<%=id%>\">");
                strCode.Append("\r\n" + "</td>");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    strCode.AppendFormat("\r\n" + "<td><bean:write name=\"element\" property=\"{0}\" /></td>",
                    objDGRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName_Java,
                    objDGRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                }
                strCode.Append("\r\n" + "<td>");
                strCode.AppendFormat("\r\n" + "	<html:link action=\"{0}.do?method={1}\" paramId=\"id\" paramName=\"element\" paramProperty=\"{2}\">remove</html:link>",
                    objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                    objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_Delete,
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.FldName_Java);
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "<td>");
                strCode.AppendFormat("\r\n" + "		<html:link action=\"{0}.do?method={1}\" paramId=\"id\" paramName=\"element\" paramProperty=\"{2}\">Update</html:link>",
                    objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                    objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_Update,
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.FldName_Java);
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "<td>");
                strCode.AppendFormat("\r\n" + "	<html:link action=\"{0}.do?method={1}\" paramId=\"id\" paramName=\"element\" paramProperty=\"{2}\">Add</html:link>",
                    objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                    objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_Add,
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.FldName_Java);
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</logic:iterate>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td colspan=\"7\">");
                strCode.Append("\r\n" + "分页");
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");
                //strCode.Append("\r\n" + "</html:framemain>");

                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td>&nbsp;</td>");
                strCode.Append("\r\n" + "<td align=\"center\">&nbsp;</td>");

                strCode.Append("\r\n" + "</tr>");

                strCode.Append("\r\n" + "</html:form>");
                strCode.Append("\r\n" + "</table>");
                //strCode.Append("\r\n" + "</html:frame>");
                strCode.Append("\r\n" + "</body>");
                strCode.Append("\r\n" + "</html:html>");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //检查该文件名的文件夹名，并判断是否存在;
            strFolder = objComm.ParentDir(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCode.ToString());
            return strCode.ToString();

        }


        public string GenQueryRecViewCode(clsViewInfoENEx objViewInfoENEx)
        {
            ///让用户设置属性;
            string strFolder;
            StringBuilder strCode = new StringBuilder(); ///用来存放WebForm的代码;

            objViewInfoENEx.WebFormName = objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_query";
            objViewInfoENEx.WebFormFName = mstrFolderName + objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_query.jsp";
            mstrFileName = objViewInfoENEx.WebFormFName;
            clsProjectsENEx objProjects = new clsProjectsENEx(objViewInfoENEx.PrjId, true);
            try
            {
                ///生成插入记录的界面代码;
                /// strCode.Append("///生成插入记录的界面代码");
                /// 


                //<%@ page contentType="text/html; charset=gb2312"%>
                strCode.Append("\r\n" + "<%@ page contentType=\"text/html; charset=GBK\" %>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-bean.tld\" prefix=\"bean\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-logic.tld\" prefix=\"logic\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-html.tld\" prefix=\"html\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-nested.tld\" prefix=\"nested\"%>");

                //strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/taglib/ecnuidc\" prefix=\"ecnuidc\" %>");
                strCode.AppendFormat("\r\n" + "<%@ page import=\"{0}.{1}Form\"%>",
                objViewInfoENEx.objViewGroupEx_Java.PrjDomain,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstUcase);
                strCode.AppendFormat("\r\n" + "<%@ page import=\"{0}\"%>",
                objViewInfoENEx.objViewGroupEx_Java.StutsManagerClass);
                //strCode.Append("\r\n" + "<%@ page import=\"com.neusoft.util.DateTool\" %>");
                strCode.Append("\r\n" + "<%@ page import=\"java.util.Date\"%>");
                strCode.Append("\r\n" + "<%");
                strCode.Append("\r\n" + "");

                strCode.Append("\r\n" + "%>");


                strCode.Append("\r\n" + "<html:html>");
                strCode.Append("\r\n" + "<head>");

                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/Globals.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/Common.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/DatePicker.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/validation.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/DWNameRule.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=gb2312\" />");

                //<META http-equiv="Content-Type" Content="text/html;charset=GBK">");
                strCode.AppendFormat("\r\n" + "<link href=\"{0}/js/style.css\" rel=\"stylesheet\" type=\"text/css\">",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/common.js\"></script>",
                    objProjects.VirtualDirectory);

                //strCode.Append("\r\n" + "<html:base />");
                //strCode.Append("\r\n" + "<html:meta />");
                //				strCode.Append("\r\n" + "<html:usercss cssName=\"styleoa\" />");
                //strCode.Append("\r\n" + "<html:usercss />");
                //strCode.Append("\r\n" + "<html:commonjs />");
                string strTabId = clsPrjTabBL.GetFirstID_S("TabName = '" + objViewInfoENEx.objMainPrjTab.TabName + "'");
                string strTabCnName = clsPrjTabBL.GetPrjTabByTabId(strTabId).TabCnName;

                strCode.AppendFormat("\r\n" + "<title> {0} ->查询</title>",
                strTabCnName);
                strCode.Append("\r\n" + "<link href=\"style.css\" rel=\"stylesheet\" type=\"text/css\">");

                strCode.Append("\r\n" + "<script type=\"text/javascript\" language=\"javascript\">");
                strCode.Append("\r\n" + "function submit()");
                strCode.Append("\r\n" + "{");
                ///生成专门用于传值的FORM字段变量
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCode.AppendFormat("\r\n" + "var j{0} = document.forms[0].{0}.value;",
                        objQryRegionFldsEx.FldName_Java);
                        if (objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
                        {
                            strCode.AppendFormat("\r\n" + "var j{0}xx = document.forms[0].{0}xx.value;",
                            objQryRegionFldsEx.FldName_Java);
                        }
                    }
                }
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        ///检查属性是否可为NULL;
                        if (objQryRegionFldsEx.objPrjTabFldENEx.IsTabNullable == false)
                        {
                            strCode.AppendFormat("\r\n if (\"\" == j{0})",
                            objQryRegionFldsEx.FldName_Java);
                            strCode.Append("\r\n {");
                            strCode.AppendFormat("\r\n alert(\"对不起! 字段[{0}]不能为空(NULL)!\");",
                            objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                            strCode.Append("\r\nreturn false;");

                            strCode.Append("\r\n }");
                        }
                        ///检查属性长度代码;
                        if (objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                        && objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "String"
                        && objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength > 0)
                        {
                            strCode.AppendFormat("\r\nif (j{0}.length > {1})",
                            objQryRegionFldsEx.FldName_Java,
                            objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim());
                            strCode.Append("\r\n{");
                            strCode.AppendFormat("\r\n alert(\"对不起! 字段[{0}]的长度不能超过{1}!\");",
                            objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                            objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim());
                            strCode.Append("\r\n return false;");
                            strCode.Append("\r\n }");
                        }
                    }
                }
                strCode.Append("\r\nreturn true;");
                strCode.Append("\r\n }");

                strCode.Append("\r\n function check()");
                strCode.Append("\r\n {");
                strCode.Append("\r\n if(checkValue()==true&&submit()==true)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n var m = window.confirm(\"您确定要提交吗？\");");
                strCode.Append("\r\n if (m!=1)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n return false;");
                strCode.Append("\r\n }");
                strCode.AppendFormat("\r\n document.forms[0].method.value=\"{0}\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.Append("\r\n }");
                strCode.Append("\r\n }");
                strCode.Append("\r\n function check2()");
                strCode.Append("\r\n {");
                strCode.Append("\r\n if(checkValue()==true&&submit()==true)");
                strCode.Append("\r\n {");

                strCode.Append("\r\n document.forms[0].method.value=\"deletePublicInfo\";");
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.AppendFormat("\r\n document.forms[0].method.value=\"{0}2\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.Append("\r\n }");
                strCode.Append("\r\n }");
                strCode.Append("\r\n </script>");


                strCode.Append("\r\n" + "</head>");
                strCode.Append("\r\n" + "<body >");

                //<form id="EAPForm" name="com.taishsoft.shnu.humansys.baseinfo.abroadbiography.abroadBiographyForm" method="POST" action="/ywxt2/humansys/baseinfo/abroadbiography/abroadBiographyAction.do" onsubmit="if(checkValue()){objViewInfoENEx.submit()}">

                strCode.AppendFormat("\r\n" + "<html:form action=\"{0}.do\"> ",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);


                //<script language="javascript">
                //formBak="addAbroadBiographySave";
                //</script>
                //<input type="hidden" id="method" name="method" value="addAbroadBiographySave"/>
                //<input type="hidden" name="com.neusoft.ecnuidc.html.TOKEN" value="4b7d21cacd7e08b9cc7e85d1cdc803d9">

                strCode.Append("\r\n" + "<script type=\"text/javascript\" language=\"javascript\">");
                strCode.AppendFormat("\r\n" + "formBak=\"{0}\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "</script>");
                strCode.AppendFormat("\r\n" + "<input type=\"hidden\" id=\"method\" name=\"method\" value=\"{0}\"/>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "<input type=\"hidden\" name=\"com.neusoft.ecnuidc.html.TOKEN\" value=\"4b7d21cacd7e08b9cc7e85d1cdc803d9\">");

                //<table border="0" id=table>
                //<tr>
                // <td width="25" height="23">&nbsp;</td>
                // <td class="HEADER ">

                //<a href="/ywxt2/humansys/baseinfo/abroadbiography/abroadBiographyAction.do?method=listAbroadBiography&needinit=true">出国履历-列表</a>
                // </td>
                //</tr>

                //<tr> 
                // <td height="10" colspan="2"><img src="/ywxt2/images/clear.gif" width="1" height="1"></td> 
                //</tr> 
                //<tr> 
                // <td><img src="/ywxt2/images/clear.gif" width="1" height="1"></td> 
                // <td> 

                strCode.Append("\r\n" + "<table border=\"0\" id=\"table\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td width=\"25\" height=\"23\">&nbsp;</td>");
                strCode.Append("\r\n" + "<td class=\"HEADER\">");
                strCode.AppendFormat("\r\n" + "<a href=\"{1}.do?method={2}&needinit=true\">{0}-查询</a>",
                        strTabCnName,
                        objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                        objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.AppendFormat("\r\n" + "<td height=\"10\" colspan=\"2\"><img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\"></td> ",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "</tr> ");
                strCode.Append("\r\n" + "<tr>");
                strCode.AppendFormat("\r\n" + "<td><img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\"></td>",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "<td>");

                //strCode.Append("\r\n" + "<html:frame>");
                //strCode.Append("\r\n" + "<html:frametitle>");
                //strCode.AppendFormat("\r\n" + "<html:link href=\"{2}/{1}Action.do?method=list{1}&needinit=true\" text=\"{0}-添加\" />",
                // strTabCnName, objViewInfoENEx.objViewGroupEx_Java.TableNameForProg,
                // objViewInfoENEx.objViewGroupEx_Java.ActionPath);
                //strCode.Append("\r\n" + "</html:frametitle>");


                //<table width="100%" border="0" cellpadding="0" cellspacing="0" class="deepa"> 
                // <tr> 
                // <th><table width="100%" border="0" cellpadding="0" cellspacing="3" ><tr><td> 出国履历 ->添加</td></tr></table></th> 
                // <th>&nbsp;</th> 
                // <th>&nbsp;</th> 
                // </tr> 
                // <tr> 
                // <td height=5 colspan="3" class="little"> <img src="/ywxt2/images/clear.gif" width="1" height="1"></td> 
                // </tr>
                // <tr>
                // <td colspan="3" class="lightcell">


                strCode.Append("\r\n" + "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"deepa\"> ");
                strCode.Append("\r\n" + "<tr> ");
                strCode.Append("\r\n" + "<th><table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"3\" >");
                strCode.AppendFormat("\r\n" + "<tr><td> {0} ->查询</td></tr>",
                strTabCnName);
                strCode.Append("\r\n" + "</table></th> ");
                strCode.Append("\r\n" + "<th>&nbsp;</th> ");
                strCode.Append("\r\n" + "<th>&nbsp;</th> ");
                strCode.Append("\r\n" + "</tr> ");
                strCode.Append("\r\n" + "<tr> ");
                strCode.Append("\r\n" + "<td height=\"5\" colspan=\"3\" class=\"little\">");
                strCode.AppendFormat("\r\n" + "<img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\">",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "</td> ");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td colspan=\"3\" class=\"lightcell\">");


                //<table width="100%" border=0 cellSpacing=1 cellPadding=3 class=deep>
                strCode.Append("\r\n" + "<table width=\"100%\" border=\"0\" cellSpacing=\"1\" cellPadding=\"3\" class=\"deep\">");
                string strStar = "";
                int intInd = 1;
                bool bolIsClosed = true;
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        if (intInd % 2 == 1)
                        {
                            strCode.Append("\r\n" + "<tr>");
                            bolIsClosed = false;
                        }
                        strStar = objQryRegionFldsEx.objPrjTabFldENEx.IsTabNullable == false ? "*" : "";

                        switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                        {
                            case "CheckBox":
                                strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                strStar);
                                strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                break;
                            case "":
                                strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                strStar);
                                strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                break;
                            case "TextBox":

                                strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                if (objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
                                {
                                    // <td width="15%" class="cellLabel">
                                    // 回国入境日期*
                                    //</td>
                                    //<td width="35%" class="lightcell">
                                    // <ecnuidc:input id="hgrq" name="hgrq" htcname="Date"
                                    // prompt="回国入境日期" maxlength="10" isnullable="false" />
                                    //</td>
                                    //<td width="15%" class="cellLabel">回国入境日期*</td>
                                    //<td width="35%" class="lightcell">
                                    //<input type="text" value="" class="NEUHTCInput" onkeydown="javascript:enterToTab()" onkeypress="javascript:OnlyDate(this)" htcname="Date" prompt="回国入境日期" name="hgrq" maxlength="10" isnullable="false" id="hgrq" dateformat="yyyy-MM-dd" title="日期类型
                                    //格式为yyyy-MM-dd
                                    //如：2004-05-01代表2004年5月1日"/> 
                                    //<img alt="弹出日历下拉菜单" align="middle" style="cursor:hand;" src="/ywxt2/images/time.gif" onclick="show_calendar(document.forms[0].hgrq,'','',document.forms[0].hgrq.dateformat)"/>
                                    //<font color=red>*<font>
                                    //</td>

                                    strCode.AppendFormat("\r\n" + "<html:text property=\"{0}_query\" class=\"NEUHTCInput\" ",
                                    objQryRegionFldsEx.FldName_Java,
                                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                                    objQryRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false",
                                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                                    strCode.Append("\r\n" + " onkeydown=\"javascript:enterToTab()\" onkeypress=\"javascript:OnlyDate(this)\" ");

                                    strCode.Append("\r\n" + " dateformat=\"yyyy-MM-dd\" title=\"日期类型格式为yyyy-MM-dd 如：2004-05-01代表2004年5月1日\" />");

                                    strCode.AppendFormat("\r\n" + " <img alt=\"弹出日历下拉菜单\" align=\"middle\" style=\"cursor:hand;\" src=\"{0}/images/time.gif\" onclick=\"show_calendar(document.forms[0].hgrq,\'\',\'\',document.forms[0].hgrq.dateformat)\"/>",
                                        objProjects.VirtualDirectory);
                                    strCode.Append("\r\n" + " <font color=red>*<font>");

                                    strCode.AppendFormat("\r\n" + "<html:text property=\"{0}\" value=\"8:00\" maxlength=\"5\" />（填写格式：HH:mm）",
                                    objQryRegionFldsEx.FldName_Java,
                                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                    objQryRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false");
                                }
                                else
                                {
                                    //<td width="15%" class="cellLabel">姓名</td>
                                    //<td width="35%" class="lightcell">
                                    //<input type="text" value="" class="NEUHTCReadOnly" readonly="readonly" onkeydown="javascript:enterToTab()" htcname="Text" prompt="姓名" readonly="true" name="xm" maxlength="30" isnullable="true" id="xm" title=""/>
                                    //</td>
                                    // <td width="35%" class="lightcell">
                                    // <ecnuidc:input id="pcdw" name="pcdw" htcname="Text"
                                    // prompt="派出单位" maxlength="60" isnullable="false" />
                                    //</td>
                                    //<td width="15%" class="cellLabel">派出单位*</td>
                                    //<td width="35%" class="lightcell">
                                    //<input type="text" value="" class="NEUHTCInput" onkeydown="javascript:enterToTab()" htcname="Text" prompt="派出单位" name="pcdw" maxlength="60" isnullable="false" id="pcdw" title=""/><font color=red>*<font>
                                    //</td>


                                    strCode.AppendFormat("\r\n" + "<html:text property=\"{0}_query\" maxlength=\"{2}\" />",
                                    objQryRegionFldsEx.FldName_Java,
                                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength,
                                    objQryRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false");
                                }
                                break;
                            case "DropDownList":
                                // <td width="15%" class="cellLabel">
                                // 出国目的*
                                //</td>
                                //<td width="35%" class="lightcell">
                                // <ecnuidc:dict id="cgmdm" name="cgmdm" prompt="出国目的"
                                // attname="dsCGMDM" isnullable="false" />
                                //</td>

                                //<td width="15%" class="cellLabel">
                                // 出国目的*</td>
                                //<td width="35%" class="lightcell">
                                // <select style="behavior: url(/ywxt2/htc/ecnuidc/Base.htc) url(/ywxt2/htc/ecnuidc/QuickSelect.htc)"
                                // name="cgmdm" id="cgmdm" isnullable="false" prompt="出国目的 ">
                                // <option value="">请选择</option>
                                // <option value="01">常驻国外使馆、领事馆</option>
                                // </select>
                                // <font color="red">*<font>
                                //</td>

                                strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                // <html:select property="part_type">												
                                //    <html:options collection="arrPART_TYPE" property="pat_type_id" labelProperty="part_type_name" />
                                //</html:select>

                                strCode.AppendFormat("\r\n" + "<html:select property=\"{0}_query\">",
                                objQryRegionFldsEx.FldName_Java,
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName);
                                strCode.AppendFormat("\r\n" + "<html:options collection=\"arr{0}\" property=\"{1}\" labelProperty=\"{2}\"/>",
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.CodeTab,
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.CodeTab_Code.ToLower(),
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.CodeTab_Name.ToLower());
                                strCode.Append("\r\n" + "</html:select>;");
                                break;
                            case "RadioButton_Bool":
                                strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                strCode.AppendFormat("\r\n" + "是<INPUT TYPE=\"radio\" NAME=\"{0}\" value=\"yes\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",
                                objQryRegionFldsEx.FldName_Java);
                                strCode.AppendFormat("\r\n" + "否<INPUT TYPE=\"radio\" NAME=\"{0}\" value=\"no\" checked=\"checked\" >",
                                objQryRegionFldsEx.FldName_Java);
                                break;
                        }
                        strCode.AppendFormat("\r\n" + "</td>");

                        if (intInd % 2 == 0)
                        {
                            strCode.Append("\r\n" + "</tr>");
                            bolIsClosed = true;
                        }
                        intInd++;
                    }
                }
                if (bolIsClosed == false)
                {
                    strCode.Append("\r\n" + "</tr>");
                }
                strCode.Append("\r\n" + "</table>");

                // </td>
                // </tr>
                // </table>
                // </td>
                //</tr>
                //<tr>
                // <td>
                // &nbsp;</td>
                // <td align="center">
                // &nbsp;</td>
                //</tr>
                //<tr>
                // <td>
                // &nbsp;</td>
                // <td align="center">

                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td>");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "<td align=\"center\">");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td>");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "<td align=\"center\">");

                // strCode.Append("\r\n" + "</html:frametable>");
                //strCode.Append("\r\n" + "</html:framemain>");
                //strCode.Append("\r\n" + "<html:framebottom>");
                //<table border="0">
                // <tr>
                // <td align="center" width="10%">
                // <input class="sbutton" type="button" value="提 交" onclick="check()">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                // <input class="sbutton" type="button" value="返 回" onclick="javascript:location.href='/ywxt2/humansys/baseinfo/abroadbiography/abroadBiographyAction.do?method=listAbroadBiography' ">
                // </td>
                // </tr>
                //</table>


                strCode.Append("\r\n" + "<table border=\"0\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td align=\"center\" width=\"10%\">");
                // <input class="sbutton" type="button" value="提 交" onclick="check()">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                // <input class="sbutton" type="button" value="返 回" onclick="javascript:location.href='/ywxt2/humansys/baseinfo/abroadbiography/abroadBiographyAction.do?method=listAbroadBiography' ">

                //strCode.AppendFormat("\r\n" + "<html:submit method=\"update{0}Save\" label=\"提 交\" onclick=\"check()\" confirm=\"确定提交吗？\"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",
                // objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);
                //strCode.AppendFormat("\r\n" + "<html:link likeSubmitStyle=\"true\" href=\"{1}/{0}Action.do?method=list{2}\" text=\"返 回\"/>",
                // objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase,
                // objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                // objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);

                strCode.AppendFormat("\r\n" + "<html:submit value=\"提 交\" onclick=\"check()\"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg);
                strCode.AppendFormat("\r\n" + "<html:link href=\"{0}.do?method={2}\">返 回</html:link>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);

                strCode.Append("\r\n" + "</td >");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");

                // </td>
                // </tr>
                // </table>
                // </form>
                //</body>
                //</html>
                //strCode.Append("\r\n" + "</html:framebottom>");
                //strCode.Append("\r\n" + "</html:frame>");


                strCode.Append("\r\n" + " </td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</html:form>");

                strCode.Append("\r\n" + "</body>");
                strCode.Append("\r\n" + "</html:html>");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //检查该文件名的文件夹名，并判断是否存在;
            strFolder = objComm.ParentDir(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCode.ToString());
            return strCode.ToString();
        }


        /// <summary>
        /// 查询记录的生成代码
        /// </summary>
        /// <returns></returns>

        public string GenQueryRecViewCodeBak(clsViewInfoENEx objViewInfoENEx)
        {
            ///让用户设置属性;
            string strFolder;
            StringBuilder strCode = new StringBuilder(); ///用来存放WebForm的代码;

            objViewInfoENEx.WebFormName = objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_query";
            objViewInfoENEx.WebFormFName = mstrFolderName + objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_query.jsp";
            mstrFileName = objViewInfoENEx.WebFormFName;

            try
            {
                ///生成插入记录的界面代码;
                /// strCode.Append("///生成插入记录的界面代码");
                strCode.Append("\r\n" + "<%@ page contentType=\"text/html; charset=GBK\" %>");
                strCode.Append("\r\n" + "<html>");
                strCode.Append("\r\n" + "<head>");
                strCode.Append("\r\n" + "<html:base />");
                strCode.Append("\r\n" + "<html:meta />");
                //				strCode.Append("\r\n" + "<html:usercss cssName=\"styleoa\" />");
                strCode.Append("\r\n" + "<html:usercss />");
                strCode.Append("\r\n" + "<html:commonjs />");
                string strTabId = clsPrjTabBL.GetFirstID_S("TabName = '" + objViewInfoENEx.objMainPrjTab.TabName + "'");
                string strTabCnName = clsPrjTabBL.GetPrjTabByTabId(strTabId).TabCnName;

                strCode.AppendFormat("\r\n" + "<title> {0} ->查询</title>",
                strTabCnName);
                strCode.Append("\r\n" + "</head>");
                strCode.Append("\r\n" + "<body >");
                strCode.AppendFormat("\r\n" + "<html:form action=\"{0}.do\" actionMethod=\"{2}\">",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "<html:frame>");
                strCode.Append("\r\n" + "<html:frametitle>");
                strCode.AppendFormat("\r\n" + "<html:link href=\"{1}.do?method={2}&needinit=true\" text=\"{0}-查询\" />",
                strTabCnName,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);

                strCode.Append("\r\n" + "</html:frametitle>");
                strCode.Append("\r\n" + "<html:framemain >");
                strCode.AppendFormat("\r\n" + "<html:frametable comment=\"{0} ->查询\">",
                strTabCnName);

                strCode.Append("\r\n" + "<table width=\"100%\" border=0 cellSpacing=1 cellPadding=3 class=deep>");
                string strStar = "";
                int intInd = 1;
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        if (intInd % 2 == 1)
                        {
                            strCode.Append("\r\n" + "<tr>");
                        }
                        strStar = objQryRegionFldsEx.objPrjTabFldENEx.IsTabNullable == false ? "*" : "";
                        switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                        {
                            case "CheckBox":
                                strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                strStar);
                                strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                break;
                            case "":
                                strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                strStar);
                                strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                break;
                            case "TextBox":
                                strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                if (objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
                                {
                                    strCode.AppendFormat("\r\n" + "<html:input id=\"{0}_query\" name=\"{0}_query\" htcname=\"Date\" prompt=\"{3}\" />",
                                    objQryRegionFldsEx.FldName_Java,
                                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                                    objQryRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false",
                                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                                }
                                else
                                {
                                    strCode.AppendFormat("\r\n" + "<html:input id=\"{0}_query\" name=\"{0}_query\" htcname=\"Text\" prompt=\"{3}\" maxlength = \"{4}\" />",
                                    objQryRegionFldsEx.FldName_Java,
                                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                                    objQryRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false",
                                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength);
                                }
                                break;
                            case "DropDownList":
                                strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                strCode.AppendFormat("\r\n" + "<html:dict id=\"{0}_query\" name=\"{0}_query\" attname=\"ds{3}\" />",
                                objQryRegionFldsEx.FldName_Java,
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                objQryRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false",
                                objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName);
                                break;
                        }
                        strCode.AppendFormat("\r\n" + "</td>");

                        if (intInd % 2 == 0)
                        {
                            strCode.Append("\r\n" + "</tr>");
                        }
                        intInd++;
                    }
                }

                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</html:frametable>");
                strCode.Append("\r\n" + "</html:framemain>");
                strCode.Append("\r\n" + "<html:framebottom>");
                strCode.Append("\r\n" + "<table border=\"0\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td align=\"center\" width=\"10%\">");
                strCode.AppendFormat("\r\n" + "<html:submit label=\"提 交\" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase);
                strCode.AppendFormat("\r\n" + "<html:link likeSubmitStyle=\"true\" href=\"{0}.do?method={2}\" text=\"返 回\"/>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "</td >");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</html:framebottom>");
                strCode.Append("\r\n" + "</html:frame>");
                strCode.Append("\r\n" + "</html:form>");
                strCode.Append("\r\n" + "</body>");
                strCode.Append("\r\n" + "</html>");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //检查该文件名的文件夹名，并判断是否存在;
            strFolder = objComm.ParentDir(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCode.ToString());
            return strCode.ToString();

        }


        public bool DispQryRegionCtrl(clsViewInfoENEx objViewInfoENEx)
        {

            return true;
        }
        //修改记录
        public string GenUpdRecViewCodeBak(clsViewInfoENEx objViewInfoENEx)
        {
            ///让用户设置属性;
            string strFolder;
            StringBuilder strCode = new StringBuilder(); ///用来存放WebForm的代码;
            string strTemp; ///临时变量;

            objViewInfoENEx.WebFormName = objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_update";
            objViewInfoENEx.WebFormFName = mstrFolderName + objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_update.jsp";
            mstrFileName = objViewInfoENEx.WebFormFName;
            try
            {
                ///生成插入记录的界面代码;
                /// strCode.Append("///生成插入记录的界面代码");
                strCode.Append("\r\n" + "<%@ page contentType=\"text/html; charset=GBK\" %>");
                strCode.AppendFormat("\r\n" + "<%@ page import=\"{0}\"%>",
                objViewInfoENEx.objViewGroupEx_Java.StutsManagerClass);
                strCode.Append("\r\n" + "<%@ page import=\"java.util.Date\"%>");
                strCode.Append("\r\n" + "<%");
                strCode.Append("\r\n" + "");
                strCode.AppendFormat("\r\n GeneralDynaActionForm form=(GeneralDynaActionForm)request.getAttribute(\"{0}\");",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionFormObject,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase);
                // String zgh = UserToken.getUserid(request);

                ///生成专门用于传值的FORM字段变量
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    strTemp = objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                    objComm.FstUcase(ref strTemp);
                    //						strCode.AppendFormat("\r\n {0} {1} = form.get{2}(\"{1}\");", 
                    //							objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                    //							objEditRegionFldsEx.FldName_Java, strTemp);
                    strCode.AppendFormat("\r\n String {1} = form.getString(\"{1}\");",
                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objEditRegionFldsEx.FldName_Java, strTemp);
                }

                strCode.Append("\r\n" + "%>");
                strCode.Append("\r\n" + "<html>");
                strCode.Append("\r\n" + "<head>");
                strCode.Append("\r\n" + "<html:base />");
                strCode.Append("\r\n" + "<html:meta />");
                strCode.Append("\r\n" + "<html:usercss cssName=\"styleoa\" />");
                strCode.Append("\r\n" + "<html:commonjs />");
                string strTabId = clsPrjTabBL.GetFirstID_S("TabName = '" + objViewInfoENEx.objMainPrjTab.TabName + "'");
                string strTabCnName = clsPrjTabBL.GetPrjTabByTabId(strTabId).TabCnName;

                strCode.AppendFormat("\r\n" + "<title> {0} ->修改</title>",
                strTabCnName);


                strCode.Append("\r\n" + "<script language=\"javascript\">");
                strCode.Append("\r\n" + "function submit()");
                strCode.Append("\r\n" + "{");
                ///生成专门用于传值的FORM字段变量
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCode.AppendFormat("\r\n" + "var j{0} = document.forms[0].{0}.value;",
                        objEditRegionFldsEx.FldName_Java);
                        if (objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
                        {
                            strCode.AppendFormat("\r\n" + "var j{0}xx = document.forms[0].{0}xx.value;",
                            objEditRegionFldsEx.FldName_Java);
                        }
                    }
                }
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        ///检查属性是否可为NULL;
                        if (objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable == false)
                        {
                            strCode.AppendFormat("\r\n if (\"\" == j{0})",
                            objEditRegionFldsEx.FldName_Java);
                            strCode.Append("\r\n{");

                            strCode.AppendFormat("\r\n alert(\"对不起! 字段[{0}]不能为空(NULL)!\");",
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                            strCode.Append("\r\nreturn false;");

                            strCode.Append("\r\n}");
                        }
                        ///检查属性长度代码;
                        if (objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                        && objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "String" && objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength > 0)
                        {
                            strCode.AppendFormat("\r\nif (j{0}.length > {1})",
                            objEditRegionFldsEx.FldName_Java, objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim());
                            strCode.Append("\r\n{");
                            strCode.AppendFormat("\r\n alert(\"对不起! 字段[{0}]的长度不能超过{1}!\")",
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim());
                            strCode.Append("\r\n return false;");
                            strCode.Append("\r\n }");
                        }

                    }

                }
                strCode.Append("\r\nreturn true;");
                strCode.Append("\r\n }");

                strCode.Append("\r\n function check()");
                strCode.Append("\r\n {");
                strCode.Append("\r\n if(checkValue()==true&&submit()==true)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n var m = window.confirm(\"您确定要提交吗？\");");
                strCode.Append("\r\n if (m!=1)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n return false;");
                strCode.Append("\r\n }");
                strCode.AppendFormat("\r\n document.forms[0].method.value=\"{0}\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.Append("\r\n }");
                strCode.Append("\r\n }");
                strCode.Append("\r\n function check2()");
                strCode.Append("\r\n {");
                strCode.Append("\r\n if(checkValue()==true&&submit()==true)");
                strCode.Append("\r\n {");

                strCode.Append("\r\n document.forms[0].method.value=\"deletePublicInfo\";");
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.AppendFormat("\r\n document.forms[0].method.value=\"{0}2\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n document.forms[0].submit();");
                strCode.Append("\r\n }");
                strCode.Append("\r\n }");
                strCode.Append("\r\n </script>");


                strCode.Append("\r\n" + "</head>");
                strCode.Append("\r\n" + "<body >");
                strCode.AppendFormat("\r\n" + "<html:form action=\"{0}.do\" actionMethod=\"{2}\">",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n" + "<html:frame>");
                strCode.Append("\r\n" + "<html:frametitle>");
                strCode.AppendFormat("\r\n" + "<html:link href=\"{1}.do?method={2}&needinit=true\" text=\"{0}-修改\" />",
                strTabCnName, objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "</html:frametitle>");
                strCode.Append("\r\n" + "<html:framemain >");
                strCode.AppendFormat("\r\n" + "<html:frametable comment=\"{0} ->修改\">",
                strTabCnName);
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.IsTabPrimary == true)
                    {
                        strCode.AppendFormat("\r\n" + "<input type=\"hidden\" id=\"{0}\" name=\"{0}\" value=\"<%={0}%>\"/>",
                        objEditRegionFldsEx.FldName_Java);
                    }
                }
                strCode.Append("\r\n" + "<table width=\"100%\" border=0 cellSpacing=1 cellPadding=3 class=deep>");
                string strStar = "";
                int intInd = 1;
                bool bolIsClosed = true;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.IsTabPrimary == false)
                    {
                        if (intInd % 2 == 1)
                        {
                            strCode.Append("\r\n" + "<tr>");
                            bolIsClosed = false;
                        }
                        strStar = objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable == false ? "*" : "";
                        if (objEditRegionFldsEx.INOUTTypeId == clsINOUTTypeENEx.IN_Type
                        || objEditRegionFldsEx.INOUTTypeId == clsINOUTTypeENEx.OUTIN_Type
                        )
                        {
                            switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                            {
                                case "CheckBox":
                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    break;
                                case "":
                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    break;
                                case "TextBox":
                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    if (objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
                                    {
                                        strCode.AppendFormat("\r\n" + "<html:input id=\"{0}\" name=\"{0}\" htcname=\"{1}\" prompt=\"{3}\" isnullable=\"{2}\"/>",
                                        objEditRegionFldsEx.FldName_Java,
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                                        objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false",
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                                        strCode.AppendFormat("\r\n" + "<html:input id=\"{0}xx\" name=\"{0}xx\" htcname=\"Text\" prompt=\"{1}\" value=\"8:00\" isnullable=\"{2}\" maxlength=\"5\" />（填写格式：HH:mm）",
                                        objEditRegionFldsEx.FldName_Java,
                                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                        objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false");
                                    }
                                    else
                                    {
                                        strCode.AppendFormat("\r\n" + "<html:input id=\"{0}\" name=\"{0}\" htcname=\"Text\" prompt=\"{1}\" maxlength=\"{2}\" isnullable=\"{3}\" value=\"<%={0} %>\"/>",
                                        objEditRegionFldsEx.FldName_Java, objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldLength, objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false");
                                    }
                                    break;
                                case "DropDownList":

                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    strCode.AppendFormat("\r\n" + "<html:dict id=\"{0}\" name=\"{0}\" attname=\"ds{3}\" selected=\"<%={0}%>\"/>",
                                    objEditRegionFldsEx.FldName_Java,
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                                    objEditRegionFldsEx.objPrjTabFldENEx.IsTabNullable ? "true" : "false",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName);
                                    break;
                                case "RadioButton_Bool":
                                    strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                                    strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                                    strCode.AppendFormat("\r\n" + "是<INPUT TYPE=\"radio\" NAME=\"{0}\" value=\"yes\" <%if(\"yes\".equals({0}))",
                                    objEditRegionFldsEx.FldName_Java);
                                    strCode.Append("{%>checked<%}%> >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
                                    strCode.AppendFormat("\r\n" + "否<INPUT TYPE=\"radio\" NAME=\"{0}\" value=\"no\" <%if(\"no\".equals({0}))",
                                    objEditRegionFldsEx.FldName_Java);
                                    strCode.Append("{%>checked<%}%> >");
                                    break;

                            }
                            strCode.AppendFormat("\r\n" + "</td>");
                        }
                        else
                        {
                            strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}{1}</td>",
                            objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption, strStar);
                            strCode.AppendFormat("\r\n" + "<input type=\"hidden\" id=\"{0}\" name=\"{0}\" value=\"<%={0}%>\"/>",
                            objEditRegionFldsEx.FldName_Java);

                            strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");
                            strCode.AppendFormat("\r\n" + "<%={0}%></td>",
                            objEditRegionFldsEx.FldName_Java);
                        }
                        if (intInd % 2 == 0)
                        {
                            strCode.Append("\r\n" + "</tr>");
                            bolIsClosed = true;
                        }
                        intInd++;
                    }
                }
                if (bolIsClosed == false)
                {
                    strCode.Append("\r\n" + "</tr>");
                    bolIsClosed = true;
                }
                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</html:frametable>");
                strCode.Append("\r\n" + "</html:framemain>");
                strCode.Append("\r\n" + "<html:framebottom>");
                strCode.Append("\r\n" + "<table border=\"0\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td align=\"center\" width=\"10%\">");
                strCode.AppendFormat("\r\n" + "<html:submit method=\"{0}\" label=\"提 交\" onclick=\"check()\" confirm=\"确定提交吗？\"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.AppendFormat("\r\n" + "<html:link likeSubmitStyle=\"true\" href=\"{0}.do?method={2}\" text=\"返 回\"/>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "</td >");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</html:framebottom>");
                strCode.Append("\r\n" + "</html:frame>");
                strCode.Append("\r\n" + "</html:form>");
                strCode.Append("\r\n" + "</body>");
                strCode.Append("\r\n" + "</html>");
            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //检查该文件名的文件夹名，并判断是否存在;
            strFolder = objComm.ParentDir(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCode.ToString());
            return strCode.ToString();
        }

        //显示记录的详细信息
        public string GenDetailRecViewCode(clsViewInfoENEx objViewInfoENEx)
        {
            ///让用户设置属性;
            string strFolder;
            StringBuilder strCode = new StringBuilder(); ///用来存放WebForm的代码;
            string strTemp; ///临时变量;

            objViewInfoENEx.WebFormName = objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_detail";
            objViewInfoENEx.WebFormFName = mstrFolderName + objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstLcase + "_detail.jsp";
            mstrFileName = objViewInfoENEx.WebFormFName;
            clsProjectsENEx objProjects = new clsProjectsENEx(objViewInfoENEx.PrjId, true);
            try
            {
                if (objViewInfoENEx.arrDetailRegionFldSet == null || objViewInfoENEx.arrDetailRegionFldSet.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("当前所选界面名称：{0}，在该界面中没有详细信息区域，或者详细信息区域没有字段。请检查!", strViewName);
                    throw new clsDbObjException(sbMessage.ToString());
                }


                ///生成插入记录的界面代码;
                /// strCode.Append("///生成插入记录的界面代码");
                strCode.Append("\r\n" + "<%@ page contentType=\"text/html; charset=GBK\" %>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-bean.tld\" prefix=\"bean\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-logic.tld\" prefix=\"logic\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-html.tld\" prefix=\"html\"%>");
                strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/struts-nested.tld\" prefix=\"nested\"%>");

                //strCode.Append("\r\n" + "<%@ taglib uri=\"/WEB-INF/taglib/ecnuidc\" prefix=\"ecnuidc\" %>");
                strCode.AppendFormat("\r\n" + "<%@ page import=\"{0}.{1}Form\"%>",
                objViewInfoENEx.objViewGroupEx_Java.PrjDomain,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstUcase);
                strCode.AppendFormat("\r\n" + "<%@ page import=\"{0}\"%>",
                objViewInfoENEx.objViewGroupEx_Java.StutsManagerClass);
                //strCode.Append("\r\n" + "<%@ page import=\"com.neusoft.util.DateTool\" %>");
                strCode.Append("\r\n" + "<%@ page import=\"java.util.Date\"%>");

                strCode.Append("\r\n" + "<%");
                strCode.Append("\r\n" + "");
                strCode.AppendFormat("\r\n {1}Form form=({1}Form)request.getAttribute(\"{0}\");",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionFormObject,
                objViewInfoENEx.objViewGroupEx_Java.TableNameForProg_FstUcase);
                // String zgh = UserToken.getUserid(request);

                ///生成专门用于传值的FORM字段变量
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strTemp = objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                        objComm.FstUcase(ref strTemp);
                        //						strCode.AppendFormat("\r\n {0} {1} = form.get{2}(\"{1}\");", 
                        //							objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                        //							objEditRegionFldsEx.FldName_Java, strTemp);
                        strCode.AppendFormat("\r\n {0} {1} = null;",
                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType,
                        objEditRegionFldsEx.FldName_Java, strTemp);
                    }
                }


                strCode.Append("\r\n" + "if (form != null) {");
                // String zgh = UserToken.getUserid(request);

                ///生成专门用于传值的FORM字段变量
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strTemp = objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                        objComm.FstUcase(ref strTemp);
                        //						strCode.AppendFormat("\r\n {0} {1} = form.get{2}(\"{1}\");", 
                        //							objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType, 
                        //							objEditRegionFldsEx.FldName_Java, strTemp);
                        strCode.AppendFormat("\r\n {3} = form.get{1}();",
                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objComm.FirstUcase(objEditRegionFldsEx.FldName_Java),
                        strTemp,
                        objEditRegionFldsEx.FldName_Java);
                    }
                }
                strCode.Append("\r\n" + "}");

                strCode.Append("\r\n" + "%>");
                strCode.Append("\r\n" + "<html>");
                strCode.Append("\r\n" + "<head>");
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/Globals.js\"></script>",
    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/Common.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/DatePicker.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/validation.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/unieap/DWNameRule.js\"></script>",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=gb2312\" />");

                //<META http-equiv="Content-Type" Content="text/html;charset=GBK">");
                strCode.AppendFormat("\r\n" + "<link href=\"{0}/js/style.css\" rel=\"stylesheet\" type=\"text/css\">",
                    objProjects.VirtualDirectory);
                strCode.AppendFormat("\r\n" + "<script type=\"text/javascript\" language=\"javascript\" src=\"{0}/js/common.js\"></script>",
    objProjects.VirtualDirectory);



                //strCode.Append("\r\n" + "<html:base />");
                //strCode.Append("\r\n" + "<html:meta />");
                ////				strCode.Append("\r\n" + "<html:usercss cssName=\"styleoa\" />");
                //strCode.Append("\r\n" + "<html:usercss />");
                //strCode.Append("\r\n" + "<html:commonjs />");
                string strTabId = clsPrjTabBL.GetFirstID_S("TabName = '" + objViewInfoENEx.objMainPrjTab.TabName + "'");
                string strTabCnName = clsPrjTabBL.GetPrjTabByTabId(strTabId).TabCnName;

                strCode.AppendFormat("\r\n" + "<title> {0} ->详细</title>",
                strTabCnName);
                strCode.Append("\r\n" + "</head>");
                strCode.Append("\r\n" + "<body >");
                strCode.AppendFormat("\r\n" + "<html:form action=\"{0}.do\">",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);

                strCode.Append("\r\n" + "<script type=\"text/javascript\" language=\"javascript\">");
                strCode.AppendFormat("\r\n" + "formBak=\"{0}\";",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n" + "</script>");
                strCode.AppendFormat("\r\n" + "<input type=\"hidden\" id=\"method\" name=\"method\" value=\"{0}\"/>",
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n" + "<input type=\"hidden\" name=\"com.neusoft.ecnuidc.html.TOKEN\" value=\"4b7d21cacd7e08b9cc7e85d1cdc803d9\">");
                strCode.Append("\r\n" + "<table border=\"0\" id=\"table\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td width=\"25\" height=\"23\">&nbsp;</td>");
                strCode.Append("\r\n" + "<td class=\"HEADER\">");

                strCode.AppendFormat("\r\n" + "<a href=\"{1}.do?method={2}&needinit=true\">{0}-列表</a>",
                        strTabCnName,
                        objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                        objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");

                strCode.Append("\r\n" + "<tr>");
                strCode.AppendFormat("\r\n" + "<td height=\"10\" colspan=\"2\"><img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\"></td> ",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "</tr> ");
                strCode.Append("\r\n" + "<tr>");
                strCode.AppendFormat("\r\n" + "<td><img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\"></td>",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "<td>");


                //strCode.Append("\r\n" + "<html:frame>");
                //strCode.Append("\r\n" + "<html:frametitle>");
                //strCode.AppendFormat("\r\n" + "<html:link href=\"{1}.do?method={2}&needinit=true\" text=\"{0}-详细\" />",
                //strTabCnName, objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                //objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                //strCode.Append("\r\n" + "</html:frametitle>");
                //strCode.Append("\r\n" + "<html:framemain >");


                strCode.Append("\r\n" + "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"deepa\"> ");
                strCode.Append("\r\n" + "<tr> ");
                strCode.Append("\r\n" + "<th><table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"3\" >");
                strCode.AppendFormat("\r\n" + "<tr><td> {0} ->详细</td></tr>",
                strTabCnName);
                strCode.Append("\r\n" + "</table></th> ");
                strCode.Append("\r\n" + "<th>&nbsp;</th> ");
                strCode.Append("\r\n" + "<th>&nbsp;</th> ");
                strCode.Append("\r\n" + "</tr> ");
                strCode.Append("\r\n" + "<tr> ");
                strCode.Append("\r\n" + "<td height=\"5\" colspan=\"3\" class=\"little\">");
                strCode.AppendFormat("\r\n" + "<img src=\"{0}/images/clear.gif\" width=\"1\" height=\"1\">",
                    objProjects.VirtualDirectory);
                strCode.Append("\r\n" + "</td> ");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td colspan=\"3\" class=\"lightcell\">");

                //strCode.AppendFormat("\r\n" + "<html:frametable comment=\"{0} ->详细\">",
                //strTabCnName);
                strCode.Append("\r\n" + "<table width=\"100%\" border=0 cellSpacing=1 cellPadding=3 class=deep>");
                int intInd = 1;
                bool bolIsClosed = true;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet)
                {
                    if (objEditRegionFldsEx.objPrjTabFldENEx.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        if (intInd % 2 == 1)
                        {
                            strCode.Append("\r\n" + "<tr>");
                            bolIsClosed = false;
                        }
                        strCode.AppendFormat("\r\n" + "<td width=\"15%\" class=\"cellLabel\">{0}</td>",
                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                        strCode.Append("\r\n" + "<td width=\"35%\" class=\"lightcell\">");

                        strCode.AppendFormat("\r\n" + "<bean:write property=\"{0}\" name=\"{1}\"/>",
                        objEditRegionFldsEx.FldName_Java,
                        objViewInfoENEx.objViewGroupEx_Java.StutsActionFormObject);
                        strCode.AppendFormat("\r\n" + "</td>");

                        if (intInd % 2 == 0)
                        {
                            strCode.Append("\r\n" + "</tr>");
                            bolIsClosed = true;
                        }
                        intInd++;
                    }
                }
                if (bolIsClosed == false)
                {
                    strCode.Append("\r\n" + "</tr>");
                }
                strCode.Append("\r\n" + "</table>");


                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td>");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "<td align=\"center\">");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td>");
                strCode.Append("\r\n" + "&nbsp;</td>");
                strCode.Append("\r\n" + "<td align=\"center\">");

                //strCode.Append("\r\n" + "</html:frametable>");
                //strCode.Append("\r\n" + "</html:framemain>");
                //strCode.Append("\r\n" + "<html:framebottom>");
                strCode.Append("\r\n" + "<table border=\"0\">");
                strCode.Append("\r\n" + "<tr>");
                strCode.Append("\r\n" + "<td align=\"center\" width=\"10%\">");
                //<input class="sbutton" type=button    value="返 回"  onclick="javascript:location.href='/ywxt2/humansys/baseinfo/edubiography/eduBiographyAction.do?method=listEduBiography' " >

                strCode.AppendFormat("\r\n" + "<input class=\"sbutton\" type=\"button\" value=\"返 回\" onclick=\"javascript:location.href='{0}{1}.do?method={3}'\" />",
                    objProjects.VirtualDirectory,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionObject,
                objViewInfoENEx.objViewGroupEx_Java.ActionPath,
                objViewInfoENEx.objViewGroupEx_Java.StutsActionMethod_List);
                strCode.Append("\r\n" + "</td >");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");

                strCode.Append("\r\n" + " </td>");
                strCode.Append("\r\n" + "</tr>");
                strCode.Append("\r\n" + "</table>");
                strCode.Append("\r\n" + "</html:form>");

                strCode.Append("\r\n" + "</body>");
                strCode.Append("\r\n" + "</html>");
            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //检查该文件名的文件夹名，并判断是否存在;
            strFolder = objComm.ParentDir(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCode.ToString());
            return strCode.ToString();
        }


        #region 生成单个控件的生成函数




        #endregion

        ///以下均是界面层内容(VIEW)=====

        public string A_GenViewCode(clsViewInfoENEx objViewInfoENEx)
        {
            switch (objViewInfoENEx.ViewTypeCode)
            {
                case "0013":	//单表插入
                    return GenInsRecViewCode(objViewInfoENEx);
                case "0014":	//单表的列表界面
                    return GenListRecViewCode(objViewInfoENEx);
                case "0015":	//单表查询
                    return GenQueryRecViewCode(objViewInfoENEx);
                case "0016":	//单表修改
                    return GenUpdRecViewCode(objViewInfoENEx);
                case "0017":	//详细信息界面
                    return GenDetailRecViewCode(objViewInfoENEx);
                //					break;
            }
            return "";
        }
    }
}
