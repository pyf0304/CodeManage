
//类名:clsNoticeEN
 ///----------------------
 ///生成代码版本:2016.10.07.1
 ///生成日期:2016/12/04
 ///生成者:潘以锋
 ///工程名称:问卷调查
 ///工程ID:0112
 ///模块中文名:日志管理
 ///模块英文名:LogManage
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.09.04.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.09.04.01
 /// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace ExamLib.Entity
{
 /// <summary>
 /// Notice(Notice)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsNoticeEN : clsEntityBase2
{
public const string _CurrTabName_S = "Notice"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "NoticeID"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"NoticeID", "NoticeTitle", "NoticeContent", "NoticeDate", "BrowseTime", "publisher", "Memo"};
//以下是属性变量

protected long mlngNoticeID;    //NoticeID
protected string mstrNoticeTitle;    //NoticeTitle
protected string mstrNoticeContent;    //NoticeContent
protected string mstrNoticeDate;    //NoticeDate
protected int mintBrowseTime;    //BrowseTime
protected string mstrpublisher;    //发布者Id
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"NoticeID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_NoticeID  =  "NoticeID";    //NoticeID

 /// <summary>
 /// 常量:"NoticeTitle"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_NoticeTitle  =  "NoticeTitle";    //NoticeTitle

 /// <summary>
 /// 常量:"NoticeContent"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_NoticeContent  =  "NoticeContent";    //NoticeContent

 /// <summary>
 /// 常量:"NoticeDate"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_NoticeDate  =  "NoticeDate";    //NoticeDate

 /// <summary>
 /// 常量:"BrowseTime"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_BrowseTime  =  "BrowseTime";    //BrowseTime

 /// <summary>
 /// 常量:"publisher"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_publisher  =  "publisher";    //发布者Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsNoticeEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "Notice";
 lstKeyFldNames.Add("NoticeID");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngNoticeID">关键字:NoticeID</param>
public clsNoticeEN(long lngNoticeID)
 {
 if (lngNoticeID  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngNoticeID = lngNoticeID;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "Notice";
 lstKeyFldNames.Add("NoticeID");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_NoticeID)
{
return mlngNoticeID;
}
else if (strAttributeName  ==  con_NoticeTitle)
{
return mstrNoticeTitle;
}
else if (strAttributeName  ==  con_NoticeContent)
{
return mstrNoticeContent;
}
else if (strAttributeName  ==  con_NoticeDate)
{
return mstrNoticeDate;
}
else if (strAttributeName  ==  con_BrowseTime)
{
return mintBrowseTime;
}
else if (strAttributeName  ==  con_publisher)
{
return mstrpublisher;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_NoticeID)
{
mlngNoticeID  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_NoticeID);
}
else if (strAttributeName  ==  con_NoticeTitle)
{
mstrNoticeTitle  =  value.ToString();
 AddUpdatedFld(con_NoticeTitle);
}
else if (strAttributeName  ==  con_NoticeContent)
{
mstrNoticeContent  =  value.ToString();
 AddUpdatedFld(con_NoticeContent);
}
else if (strAttributeName  ==  con_NoticeDate)
{
mstrNoticeDate  =  value.ToString();
 AddUpdatedFld(con_NoticeDate);
}
else if (strAttributeName  ==  con_BrowseTime)
{
mintBrowseTime  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_BrowseTime);
}
else if (strAttributeName  ==  con_publisher)
{
mstrpublisher  =  value.ToString();
 AddUpdatedFld(con_publisher);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_NoticeID  ==  AttributeName[intIndex])
{
return mlngNoticeID;
}
else if (con_NoticeTitle  ==  AttributeName[intIndex])
{
return mstrNoticeTitle;
}
else if (con_NoticeContent  ==  AttributeName[intIndex])
{
return mstrNoticeContent;
}
else if (con_NoticeDate  ==  AttributeName[intIndex])
{
return mstrNoticeDate;
}
else if (con_BrowseTime  ==  AttributeName[intIndex])
{
return mintBrowseTime;
}
else if (con_publisher  ==  AttributeName[intIndex])
{
return mstrpublisher;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_NoticeID  ==  AttributeName[intIndex])
{
mlngNoticeID  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_NoticeID);
}
else if (con_NoticeTitle  ==  AttributeName[intIndex])
{
mstrNoticeTitle  =  value.ToString();
 AddUpdatedFld(con_NoticeTitle);
}
else if (con_NoticeContent  ==  AttributeName[intIndex])
{
mstrNoticeContent  =  value.ToString();
 AddUpdatedFld(con_NoticeContent);
}
else if (con_NoticeDate  ==  AttributeName[intIndex])
{
mstrNoticeDate  =  value.ToString();
 AddUpdatedFld(con_NoticeDate);
}
else if (con_BrowseTime  ==  AttributeName[intIndex])
{
mintBrowseTime  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_BrowseTime);
}
else if (con_publisher  ==  AttributeName[intIndex])
{
mstrpublisher  =  value.ToString();
 AddUpdatedFld(con_publisher);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// NoticeID(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public long NoticeID
{
get
{
return mlngNoticeID;
}
set
{
 mlngNoticeID  =  value;
//记录修改过的字段
 AddUpdatedFld(con_NoticeID);
}
}
/// <summary>
/// NoticeTitle(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string NoticeTitle
{
get
{
return mstrNoticeTitle;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrNoticeTitle  =  value;
}
else
{
 mstrNoticeTitle  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_NoticeTitle);
}
}
/// <summary>
/// NoticeContent(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string NoticeContent
{
get
{
return mstrNoticeContent;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrNoticeContent  =  value;
}
else
{
 mstrNoticeContent  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_NoticeContent);
}
}
/// <summary>
/// NoticeDate(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string NoticeDate
{
get
{
return mstrNoticeDate;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrNoticeDate  =  value;
}
else
{
 mstrNoticeDate  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_NoticeDate);
}
}
/// <summary>
/// BrowseTime(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int BrowseTime
{
get
{
return mintBrowseTime;
}
set
{
 mintBrowseTime  =  value;
//记录修改过的字段
 AddUpdatedFld(con_BrowseTime);
}
}
/// <summary>
/// 发布者Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string publisher
{
get
{
return mstrpublisher;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrpublisher  =  value;
}
else
{
 mstrpublisher  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_publisher);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrMemo  =  value;
}
else
{
 mstrMemo  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_Memo);
}
}
}
}