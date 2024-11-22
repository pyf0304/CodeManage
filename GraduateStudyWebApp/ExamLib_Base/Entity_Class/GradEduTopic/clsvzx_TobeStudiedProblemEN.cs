
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TobeStudiedProblemEN
 表名:vzx_TobeStudiedProblem(01120840)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
 框架-层名:实体层(CS)(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表vzx_TobeStudiedProblem的关键字(ProblemId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ProblemId_vzx_TobeStudiedProblem
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strProblemId">表关键字</param>
public K_ProblemId_vzx_TobeStudiedProblem(string strProblemId)
{
if (IsValid(strProblemId)) Value = strProblemId;
else
{
Value = null;
}
}
private static bool IsValid(string strProblemId)
{
if (string.IsNullOrEmpty(strProblemId) == true) return false;
if (strProblemId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ProblemId_vzx_TobeStudiedProblem]类型的对象</returns>
public static implicit operator K_ProblemId_vzx_TobeStudiedProblem(string value)
{
return new K_ProblemId_vzx_TobeStudiedProblem(value);
}
}
 /// <summary>
 /// vzx_TobeStudiedProblem(vzx_TobeStudiedProblem)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_TobeStudiedProblemEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_TobeStudiedProblem"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ProblemId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"GroupTextId", "GroupTextName", "IdCurrEduCls", "zxShareId", "Memo", "Participant", "VersionCount", "IsSubmit", "ProblemId", "ProblemTitle", "ProblemContent", "ProblemDate", "UpdDate", "UpdUser", "Year", "Month"};

protected string mstrGroupTextId;    //小组Id
protected string mstrGroupTextName;    //小组名称
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrzxShareId;    //分享Id
protected string mstrMemo;    //备注
protected string mstrParticipant;    //参与者
protected int? mintVersionCount;    //版本统计
protected bool mbolIsSubmit;    //是否提交
protected string mstrProblemId;    //问题Id
protected string mstrProblemTitle;    //问题标题
protected string mstrProblemContent;    //问题内容
protected string mstrProblemDate;    //问题日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrYear;    //年
protected string mstrMonth;    //月

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_TobeStudiedProblemEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ProblemId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strProblemId">关键字:问题Id</param>
public clsvzx_TobeStudiedProblemEN(string strProblemId)
 {
strProblemId = strProblemId.Replace("'", "''");
if (strProblemId.Length > 10)
{
throw new Exception("在表:vzx_TobeStudiedProblem中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strProblemId)  ==  true)
{
throw new Exception("在表:vzx_TobeStudiedProblem中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProblemId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrProblemId = strProblemId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ProblemId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convzx_TobeStudiedProblem.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.GroupTextName)
{
return mstrGroupTextName;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.Participant)
{
return mstrParticipant;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.ProblemId)
{
return mstrProblemId;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.ProblemTitle)
{
return mstrProblemTitle;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.ProblemContent)
{
return mstrProblemContent;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.ProblemDate)
{
return mstrProblemDate;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.Year)
{
return mstrYear;
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.Month)
{
return mstrMonth;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_TobeStudiedProblem.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.GroupTextId);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.GroupTextName)
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.GroupTextName);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.zxShareId);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.Memo);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.Participant)
{
mstrParticipant = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.Participant);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TobeStudiedProblem.VersionCount);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_TobeStudiedProblem.IsSubmit);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.ProblemId)
{
mstrProblemId = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemId);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.ProblemTitle)
{
mstrProblemTitle = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemTitle);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.ProblemContent)
{
mstrProblemContent = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemContent);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.ProblemDate)
{
mstrProblemDate = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemDate);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.UpdDate);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.UpdUser);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.Year)
{
mstrYear = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.Year);
}
else if (strAttributeName  ==  convzx_TobeStudiedProblem.Month)
{
mstrMonth = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.Month);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_TobeStudiedProblem.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (convzx_TobeStudiedProblem.GroupTextName  ==  AttributeName[intIndex])
{
return mstrGroupTextName;
}
else if (convzx_TobeStudiedProblem.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_TobeStudiedProblem.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (convzx_TobeStudiedProblem.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_TobeStudiedProblem.Participant  ==  AttributeName[intIndex])
{
return mstrParticipant;
}
else if (convzx_TobeStudiedProblem.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convzx_TobeStudiedProblem.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_TobeStudiedProblem.ProblemId  ==  AttributeName[intIndex])
{
return mstrProblemId;
}
else if (convzx_TobeStudiedProblem.ProblemTitle  ==  AttributeName[intIndex])
{
return mstrProblemTitle;
}
else if (convzx_TobeStudiedProblem.ProblemContent  ==  AttributeName[intIndex])
{
return mstrProblemContent;
}
else if (convzx_TobeStudiedProblem.ProblemDate  ==  AttributeName[intIndex])
{
return mstrProblemDate;
}
else if (convzx_TobeStudiedProblem.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_TobeStudiedProblem.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_TobeStudiedProblem.Year  ==  AttributeName[intIndex])
{
return mstrYear;
}
else if (convzx_TobeStudiedProblem.Month  ==  AttributeName[intIndex])
{
return mstrMonth;
}
return null;
}
set
{
if (convzx_TobeStudiedProblem.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.GroupTextId);
}
else if (convzx_TobeStudiedProblem.GroupTextName  ==  AttributeName[intIndex])
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.GroupTextName);
}
else if (convzx_TobeStudiedProblem.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.IdCurrEduCls);
}
else if (convzx_TobeStudiedProblem.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.zxShareId);
}
else if (convzx_TobeStudiedProblem.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.Memo);
}
else if (convzx_TobeStudiedProblem.Participant  ==  AttributeName[intIndex])
{
mstrParticipant = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.Participant);
}
else if (convzx_TobeStudiedProblem.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TobeStudiedProblem.VersionCount);
}
else if (convzx_TobeStudiedProblem.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_TobeStudiedProblem.IsSubmit);
}
else if (convzx_TobeStudiedProblem.ProblemId  ==  AttributeName[intIndex])
{
mstrProblemId = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemId);
}
else if (convzx_TobeStudiedProblem.ProblemTitle  ==  AttributeName[intIndex])
{
mstrProblemTitle = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemTitle);
}
else if (convzx_TobeStudiedProblem.ProblemContent  ==  AttributeName[intIndex])
{
mstrProblemContent = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemContent);
}
else if (convzx_TobeStudiedProblem.ProblemDate  ==  AttributeName[intIndex])
{
mstrProblemDate = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemDate);
}
else if (convzx_TobeStudiedProblem.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.UpdDate);
}
else if (convzx_TobeStudiedProblem.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.UpdUser);
}
else if (convzx_TobeStudiedProblem.Year  ==  AttributeName[intIndex])
{
mstrYear = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.Year);
}
else if (convzx_TobeStudiedProblem.Month  ==  AttributeName[intIndex])
{
mstrMonth = value.ToString();
 AddUpdatedFld(convzx_TobeStudiedProblem.Month);
}
}
}

/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.GroupTextId);
}
}
/// <summary>
/// 小组名称(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextName
{
get
{
return mstrGroupTextName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextName = value;
}
else
{
 mstrGroupTextName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.GroupTextName);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.IdCurrEduCls);
}
}
/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxShareId
{
get
{
return mstrzxShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxShareId = value;
}
else
{
 mstrzxShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.zxShareId);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.Memo);
}
}
/// <summary>
/// 参与者(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Participant
{
get
{
return mstrParticipant;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParticipant = value;
}
else
{
 mstrParticipant = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.Participant);
}
}
/// <summary>
/// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionCount
{
get
{
return mintVersionCount;
}
set
{
 mintVersionCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.VersionCount);
}
}
/// <summary>
/// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSubmit
{
get
{
return mbolIsSubmit;
}
set
{
 mbolIsSubmit = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.IsSubmit);
}
}
/// <summary>
/// 问题Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProblemId
{
get
{
return mstrProblemId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProblemId = value;
}
else
{
 mstrProblemId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemId);
}
}
/// <summary>
/// 问题标题(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProblemTitle
{
get
{
return mstrProblemTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProblemTitle = value;
}
else
{
 mstrProblemTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemTitle);
}
}
/// <summary>
/// 问题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProblemContent
{
get
{
return mstrProblemContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProblemContent = value;
}
else
{
 mstrProblemContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemContent);
}
}
/// <summary>
/// 问题日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProblemDate
{
get
{
return mstrProblemDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProblemDate = value;
}
else
{
 mstrProblemDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.ProblemDate);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.UpdUser);
}
}
/// <summary>
/// 年(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Year
{
get
{
return mstrYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYear = value;
}
else
{
 mstrYear = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.Year);
}
}
/// <summary>
/// 月(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Month
{
get
{
return mstrMonth;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMonth = value;
}
else
{
 mstrMonth = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TobeStudiedProblem.Month);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrProblemId;
 }
 }
}
 /// <summary>
 /// vzx_TobeStudiedProblem(vzx_TobeStudiedProblem)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_TobeStudiedProblem
{
public const string _CurrTabName = "vzx_TobeStudiedProblem"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ProblemId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GroupTextId", "GroupTextName", "IdCurrEduCls", "zxShareId", "Memo", "Participant", "VersionCount", "IsSubmit", "ProblemId", "ProblemTitle", "ProblemContent", "ProblemDate", "UpdDate", "UpdUser", "Year", "Month"};
//以下是属性变量


 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"GroupTextName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextName = "GroupTextName";    //小组名称

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"Participant"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Participant = "Participant";    //参与者

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"ProblemId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemId = "ProblemId";    //问题Id

 /// <summary>
 /// 常量:"ProblemTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemTitle = "ProblemTitle";    //问题标题

 /// <summary>
 /// 常量:"ProblemContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemContent = "ProblemContent";    //问题内容

 /// <summary>
 /// 常量:"ProblemDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemDate = "ProblemDate";    //问题日期

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Year"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Year = "Year";    //年

 /// <summary>
 /// 常量:"Month"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Month = "Month";    //月
}

}