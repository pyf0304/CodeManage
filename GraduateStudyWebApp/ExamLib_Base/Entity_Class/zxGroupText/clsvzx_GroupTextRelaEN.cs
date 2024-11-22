
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_GroupTextRelaEN
 表名:vzx_GroupTextRela(01120867)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 表vzx_GroupTextRela的关键字(GroupTextRelaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GroupTextRelaId_vzx_GroupTextRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGroupTextRelaId">表关键字</param>
public K_GroupTextRelaId_vzx_GroupTextRela(string strGroupTextRelaId)
{
if (IsValid(strGroupTextRelaId)) Value = strGroupTextRelaId;
else
{
Value = null;
}
}
private static bool IsValid(string strGroupTextRelaId)
{
if (string.IsNullOrEmpty(strGroupTextRelaId) == true) return false;
if (strGroupTextRelaId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GroupTextRelaId_vzx_GroupTextRela]类型的对象</returns>
public static implicit operator K_GroupTextRelaId_vzx_GroupTextRela(string value)
{
return new K_GroupTextRelaId_vzx_GroupTextRela(value);
}
}
 /// <summary>
 /// 小组课文关系视图(vzx_GroupTextRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_GroupTextRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_GroupTextRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GroupTextRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"UpdDate", "Memo", "UpdUser", "TextId", "GroupTextId", "GroupTextRelaId", "GroupTextName", "IdCurrEduCls", "zxShareId", "TextTitle", "TextContent", "Author", "IsSubmit", "TextTypeId", "TextStatusId", "TextDate", "TextUserId"};

protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrUpdUser;    //修改人
protected string mstrTextId;    //课件Id
protected string mstrGroupTextId;    //小组Id
protected string mstrGroupTextRelaId;    //主键
protected string mstrGroupTextName;    //小组名称
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrzxShareId;    //分享Id
protected string mstrTextTitle;    //TextTitle
protected string mstrTextContent;    //TextContent
protected string mstrAuthor;    //作者
protected bool mbolIsSubmit;    //是否提交
protected string mstrTextTypeId;    //TextTypeId
protected string mstrTextStatusId;    //TextStatusId
protected string mstrTextDate;    //TextDate
protected string mstrTextUserId;    //TextUserId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_GroupTextRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GroupTextRelaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strGroupTextRelaId">关键字:主键</param>
public clsvzx_GroupTextRelaEN(string strGroupTextRelaId)
 {
strGroupTextRelaId = strGroupTextRelaId.Replace("'", "''");
if (strGroupTextRelaId.Length > 8)
{
throw new Exception("在表:vzx_GroupTextRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGroupTextRelaId)  ==  true)
{
throw new Exception("在表:vzx_GroupTextRela中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGroupTextRelaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGroupTextRelaId = strGroupTextRelaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GroupTextRelaId");
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
if (strAttributeName  ==  convzx_GroupTextRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_GroupTextRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_GroupTextRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_GroupTextRela.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  convzx_GroupTextRela.GroupTextRelaId)
{
return mstrGroupTextRelaId;
}
else if (strAttributeName  ==  convzx_GroupTextRela.GroupTextName)
{
return mstrGroupTextName;
}
else if (strAttributeName  ==  convzx_GroupTextRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_GroupTextRela.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextContent)
{
return mstrTextContent;
}
else if (strAttributeName  ==  convzx_GroupTextRela.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convzx_GroupTextRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextTypeId)
{
return mstrTextTypeId;
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextStatusId)
{
return mstrTextStatusId;
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextDate)
{
return mstrTextDate;
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextUserId)
{
return mstrTextUserId;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_GroupTextRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.UpdDate);
}
else if (strAttributeName  ==  convzx_GroupTextRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.Memo);
}
else if (strAttributeName  ==  convzx_GroupTextRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.UpdUser);
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextId);
}
else if (strAttributeName  ==  convzx_GroupTextRela.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.GroupTextId);
}
else if (strAttributeName  ==  convzx_GroupTextRela.GroupTextRelaId)
{
mstrGroupTextRelaId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.GroupTextRelaId);
}
else if (strAttributeName  ==  convzx_GroupTextRela.GroupTextName)
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.GroupTextName);
}
else if (strAttributeName  ==  convzx_GroupTextRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_GroupTextRela.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.zxShareId);
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextTitle);
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextContent)
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextContent);
}
else if (strAttributeName  ==  convzx_GroupTextRela.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.Author);
}
else if (strAttributeName  ==  convzx_GroupTextRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_GroupTextRela.IsSubmit);
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextTypeId)
{
mstrTextTypeId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextTypeId);
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextStatusId)
{
mstrTextStatusId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextStatusId);
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextDate)
{
mstrTextDate = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextDate);
}
else if (strAttributeName  ==  convzx_GroupTextRela.TextUserId)
{
mstrTextUserId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_GroupTextRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_GroupTextRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_GroupTextRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_GroupTextRela.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_GroupTextRela.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (convzx_GroupTextRela.GroupTextRelaId  ==  AttributeName[intIndex])
{
return mstrGroupTextRelaId;
}
else if (convzx_GroupTextRela.GroupTextName  ==  AttributeName[intIndex])
{
return mstrGroupTextName;
}
else if (convzx_GroupTextRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_GroupTextRela.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (convzx_GroupTextRela.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_GroupTextRela.TextContent  ==  AttributeName[intIndex])
{
return mstrTextContent;
}
else if (convzx_GroupTextRela.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convzx_GroupTextRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_GroupTextRela.TextTypeId  ==  AttributeName[intIndex])
{
return mstrTextTypeId;
}
else if (convzx_GroupTextRela.TextStatusId  ==  AttributeName[intIndex])
{
return mstrTextStatusId;
}
else if (convzx_GroupTextRela.TextDate  ==  AttributeName[intIndex])
{
return mstrTextDate;
}
else if (convzx_GroupTextRela.TextUserId  ==  AttributeName[intIndex])
{
return mstrTextUserId;
}
return null;
}
set
{
if (convzx_GroupTextRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.UpdDate);
}
else if (convzx_GroupTextRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.Memo);
}
else if (convzx_GroupTextRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.UpdUser);
}
else if (convzx_GroupTextRela.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextId);
}
else if (convzx_GroupTextRela.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.GroupTextId);
}
else if (convzx_GroupTextRela.GroupTextRelaId  ==  AttributeName[intIndex])
{
mstrGroupTextRelaId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.GroupTextRelaId);
}
else if (convzx_GroupTextRela.GroupTextName  ==  AttributeName[intIndex])
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.GroupTextName);
}
else if (convzx_GroupTextRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.IdCurrEduCls);
}
else if (convzx_GroupTextRela.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.zxShareId);
}
else if (convzx_GroupTextRela.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextTitle);
}
else if (convzx_GroupTextRela.TextContent  ==  AttributeName[intIndex])
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextContent);
}
else if (convzx_GroupTextRela.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.Author);
}
else if (convzx_GroupTextRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_GroupTextRela.IsSubmit);
}
else if (convzx_GroupTextRela.TextTypeId  ==  AttributeName[intIndex])
{
mstrTextTypeId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextTypeId);
}
else if (convzx_GroupTextRela.TextStatusId  ==  AttributeName[intIndex])
{
mstrTextStatusId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextStatusId);
}
else if (convzx_GroupTextRela.TextDate  ==  AttributeName[intIndex])
{
mstrTextDate = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextDate);
}
else if (convzx_GroupTextRela.TextUserId  ==  AttributeName[intIndex])
{
mstrTextUserId = value.ToString();
 AddUpdatedFld(convzx_GroupTextRela.TextUserId);
}
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
 AddUpdatedFld(convzx_GroupTextRela.UpdDate);
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
 AddUpdatedFld(convzx_GroupTextRela.Memo);
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
 AddUpdatedFld(convzx_GroupTextRela.UpdUser);
}
}
/// <summary>
/// 课件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextId
{
get
{
return mstrTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextId = value;
}
else
{
 mstrTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupTextRela.TextId);
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
 AddUpdatedFld(convzx_GroupTextRela.GroupTextId);
}
}
/// <summary>
/// 主键(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextRelaId
{
get
{
return mstrGroupTextRelaId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextRelaId = value;
}
else
{
 mstrGroupTextRelaId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupTextRela.GroupTextRelaId);
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
 AddUpdatedFld(convzx_GroupTextRela.GroupTextName);
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
 AddUpdatedFld(convzx_GroupTextRela.IdCurrEduCls);
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
 AddUpdatedFld(convzx_GroupTextRela.zxShareId);
}
}
/// <summary>
/// TextTitle(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextTitle
{
get
{
return mstrTextTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextTitle = value;
}
else
{
 mstrTextTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupTextRela.TextTitle);
}
}
/// <summary>
/// TextContent(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextContent
{
get
{
return mstrTextContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextContent = value;
}
else
{
 mstrTextContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupTextRela.TextContent);
}
}
/// <summary>
/// 作者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Author
{
get
{
return mstrAuthor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuthor = value;
}
else
{
 mstrAuthor = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupTextRela.Author);
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
 AddUpdatedFld(convzx_GroupTextRela.IsSubmit);
}
}
/// <summary>
/// TextTypeId(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextTypeId
{
get
{
return mstrTextTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextTypeId = value;
}
else
{
 mstrTextTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupTextRela.TextTypeId);
}
}
/// <summary>
/// TextStatusId(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextStatusId
{
get
{
return mstrTextStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextStatusId = value;
}
else
{
 mstrTextStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupTextRela.TextStatusId);
}
}
/// <summary>
/// TextDate(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextDate
{
get
{
return mstrTextDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextDate = value;
}
else
{
 mstrTextDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupTextRela.TextDate);
}
}
/// <summary>
/// TextUserId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextUserId
{
get
{
return mstrTextUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextUserId = value;
}
else
{
 mstrTextUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupTextRela.TextUserId);
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
  return mstrGroupTextRelaId;
 }
 }
}
 /// <summary>
 /// 小组课文关系视图(vzx_GroupTextRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_GroupTextRela
{
public const string _CurrTabName = "vzx_GroupTextRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GroupTextRelaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UpdDate", "Memo", "UpdUser", "TextId", "GroupTextId", "GroupTextRelaId", "GroupTextName", "IdCurrEduCls", "zxShareId", "TextTitle", "TextContent", "Author", "IsSubmit", "TextTypeId", "TextStatusId", "TextDate", "TextUserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"GroupTextRelaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextRelaId = "GroupTextRelaId";    //主键

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
 /// 常量:"TextTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTitle = "TextTitle";    //TextTitle

 /// <summary>
 /// 常量:"TextContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextContent = "TextContent";    //TextContent

 /// <summary>
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"TextTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTypeId = "TextTypeId";    //TextTypeId

 /// <summary>
 /// 常量:"TextStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextStatusId = "TextStatusId";    //TextStatusId

 /// <summary>
 /// 常量:"TextDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextDate = "TextDate";    //TextDate

 /// <summary>
 /// 常量:"TextUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextUserId = "TextUserId";    //TextUserId
}

}