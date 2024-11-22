﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wucReferFilesB
 界面名:wfmReferFiles_QUDI(00050224)
 生成代码版本:2019.05.05.1
 生成日期:2019/05/07 01:30:49
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码
 模块英文名:GeneCode
 框架-层名:Web用户控件后台(WebCtlControlCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
//生成与表相关的控件控制层代码
namespace AGC.Webform
{
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commdb;
using CommFunc4WebForm;

using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;

 /// <summary>
 ///		wucReferFilesB 的摘要说明。
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public partial class wucReferFilesB : System.Web.UI.UserControl
{

 /// <summary>
 /// 函数功能:页面导入,当页面开始运行时所发生的事件
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Page_Load)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面

}


 /// <summary>
 /// 引用文件Id
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string ReferFileId
{
get
{
return txtReferFileId.Text.Trim();
}
set
{
txtReferFileId.Text = value.ToString();
}
}

 /// <summary>
 /// 文件名
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string FileName
{
get
{
return txtFileName.Text.Trim();
}
set
{
txtFileName.Text = value.ToString();
}
}

 /// <summary>
 /// 文件路径
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string FilePath
{
get
{
return txtFilePath.Text.Trim();
}
set
{
txtFilePath.Text = value.ToString();
}
}

 /// <summary>
 /// 是否需要下载
 /// (AGC.BusinessLogicEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public bool IsNeedDownLoad
{
get
{
return chkIsNeedDownLoad.Checked;
}
set
{
chkIsNeedDownLoad.Checked = value;
}
}

 /// <summary>
 /// 版本
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string Version
{
get
{
return txtVersion.Text.Trim();
}
set
{
txtVersion.Text = value.ToString();
}
}

 /// <summary>
 /// 是否在用
 /// (AGC.BusinessLogicEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public bool InUse
{
get
{
return chkInUse.Checked;
}
set
{
chkInUse.Checked = value;
}
}

 /// <summary>
 /// 序号
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public int OrderNum
{
get
{
return int.Parse(txtOrderNum.Text.Trim());
}
set
{
txtOrderNum.Text = value.ToString();
}
}

 /// <summary>
 /// 说明
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string Memo
{
get
{
return txtMemo.Text.Trim();
}
set
{
txtMemo.Text = value.ToString();
}
}


/// <summary>
/// 在用户自定义控件中，设置关键字的值，是否只读
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_SetKeyReadOnly)
/// </summary>
/// <param name = "bolReadonly">是否只读</param>
public void SetKeyReadOnly(bool bolReadonly)
{
txtReferFileId.ReadOnly = bolReadonly;
}


/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
/// </summary>	
public void Clear()
{
txtReferFileId.Text = "";
txtFileName.Text = "";
txtFilePath.Text = "";
chkIsNeedDownLoad.Checked = false;
txtVersion.Text = "";
chkInUse.Checked = false;
txtOrderNum.Text = "0";
txtMemo.Text = "";
}


 /// <summary>
 /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
 /// 一般规则:
 ///		1、首先校验类型:整型、浮点型、日期型等,
 ///			这些代码由自动生成代码帮助生成
 ///		2、校验最值,即最大值和最小值等
 ///			这些代码由自动生成代码帮助生成
 ///		这些生成内容可以修改
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_IsValid)
 /// </summary>
 /// <returns></returns>
public bool IsValid(ref string strResult)
{
ComValid_OrderNum.Validate();
if (!ComValid_OrderNum.IsValid) return false;
if (clsString.IsNumeric(txtOrderNum.Text)  ==  false)
{
strResult = "请输入正确的整型!";
return false;
}
return true;
}


 /// <summary>
 /// 设置该控件在插入状态下的缺省值
 /// 一般规则:
 ///		1、如果是整型就默认为0；
 ///		2、如果是浮点型不默认为0.0；
 ///		3、如果是日期型就默认为当前的日期；
 ///		4、如果是位(bit)型就默认为false;
 ///		这些默认值可以再行修改
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_SetDefaultValue)
 /// </summary>
public void SetDefaultValue()
{
txtReferFileId.Text = "";
txtFileName.Text = "";
txtFilePath.Text = "";
chkIsNeedDownLoad.Checked = false;
txtVersion.Text = "";
chkInUse.Checked = false;
txtOrderNum.Text = "0";
txtMemo.Text = "";
}

}
}