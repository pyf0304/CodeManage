﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Webform_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string url = @"//AGC//AGC//Upload//fac621e5-a6b2-4d10-8f93-d04a753b46ae.wmv";
        //string strPath = string.Empty;
        //string FileName = string.Empty;
        //strPath = System.IO.Path.GetDirectoryName(url);
        //strPath = HttpContext.Current.Server.MapPath(strPath) ;
        //FileName = System.IO.Path.GetFileNameWithoutExtension(url) + System.IO.Path.GetExtension(url);

        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("<OBJECT id=mediaplayer classid='clsid:DF4584ED-2BDB-4AA3-99F2-6F07184BB5AA' width=400 height=320></OBJECT>");
        sb.Append("<script language='javascript'> var obj=document.getElementById(\"mediaplayer\");");
        sb.Append("OpenA2AClick();");
        sb.Append("function OpenA2AClick()try{var name =\"");
        sb.Append(url);
        sb.Append("\"");
        sb.Append("obj.OpenFile(name);}catch(e){if (confirm('请先安装播放器')){window.open('./AvsPlayerActiveXSetup.exe');	}}}");
        sb.Append("OpenA2AClick();</script>");
        this.Label1.Text = sb.ToString();
        //Response.Write(sb.ToString());
    }
}
