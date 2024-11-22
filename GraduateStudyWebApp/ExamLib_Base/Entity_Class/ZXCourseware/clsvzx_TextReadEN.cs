
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TextReadEN
 表名:vzx_TextRead(01120732)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表vzx_TextRead的关键字(TextRId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TextRId_vzx_TextRead
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTextRId">表关键字</param>
public K_TextRId_vzx_TextRead(string strTextRId)
{
if (IsValid(strTextRId)) Value = strTextRId;
else
{
Value = null;
}
}
private static bool IsValid(string strTextRId)
{
if (string.IsNullOrEmpty(strTextRId) == true) return false;
if (strTextRId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TextRId_vzx_TextRead]类型的对象</returns>
public static implicit operator K_TextRId_vzx_TextRead(string value)
{
return new K_TextRId_vzx_TextRead(value);
}
}
 /// <summary>
 /// vzx_TextRead(vzx_TextRead)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_TextReadEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_TextRead"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TextRId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"TextTitle", "TextRId", "ReaderUserId", "TextId", "ReadTypeId", "IsSubmit", "IsPublic", "Submitter", "IdCurrEduCls", "QuestionCount", "CreateDate", "UpdUser", "UpdDate", "Memo"};

protected string mstrTextTitle;    //TextTitle
protected string mstrTextRId;    //TextRId
protected string mstrReaderUserId;    //ReaderUserId
protected string mstrTextId;    //课件Id
protected string mstrReadTypeId;    //阅读类型
protected bool mbolIsSubmit;    //是否提交
protected bool mbolIsPublic;    //是否公开
protected string mstrSubmitter;    //提交人
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintQuestionCount;    //问题数
protected string mstrCreateDate;    //建立日期
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_TextReadEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextRId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTextRId">关键字:TextRId</param>
public clsvzx_TextReadEN(string strTextRId)
 {
strTextRId = strTextRId.Replace("'", "''");
if (strTextRId.Length > 10)
{
throw new Exception("在表:vzx_TextRead中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTextRId)  ==  true)
{
throw new Exception("在表:vzx_TextRead中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextRId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTextRId = strTextRId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextRId");
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
if (strAttributeName  ==  convzx_TextRead.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_TextRead.TextRId)
{
return mstrTextRId;
}
else if (strAttributeName  ==  convzx_TextRead.ReaderUserId)
{
return mstrReaderUserId;
}
else if (strAttributeName  ==  convzx_TextRead.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_TextRead.ReadTypeId)
{
return mstrReadTypeId;
}
else if (strAttributeName  ==  convzx_TextRead.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_TextRead.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convzx_TextRead.Submitter)
{
return mstrSubmitter;
}
else if (strAttributeName  ==  convzx_TextRead.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_TextRead.QuestionCount)
{
return mintQuestionCount;
}
else if (strAttributeName  ==  convzx_TextRead.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convzx_TextRead.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_TextRead.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_TextRead.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_TextRead.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_TextRead.TextTitle);
}
else if (strAttributeName  ==  convzx_TextRead.TextRId)
{
mstrTextRId = value.ToString();
 AddUpdatedFld(convzx_TextRead.TextRId);
}
else if (strAttributeName  ==  convzx_TextRead.ReaderUserId)
{
mstrReaderUserId = value.ToString();
 AddUpdatedFld(convzx_TextRead.ReaderUserId);
}
else if (strAttributeName  ==  convzx_TextRead.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_TextRead.TextId);
}
else if (strAttributeName  ==  convzx_TextRead.ReadTypeId)
{
mstrReadTypeId = value.ToString();
 AddUpdatedFld(convzx_TextRead.ReadTypeId);
}
else if (strAttributeName  ==  convzx_TextRead.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_TextRead.IsSubmit);
}
else if (strAttributeName  ==  convzx_TextRead.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_TextRead.IsPublic);
}
else if (strAttributeName  ==  convzx_TextRead.Submitter)
{
mstrSubmitter = value.ToString();
 AddUpdatedFld(convzx_TextRead.Submitter);
}
else if (strAttributeName  ==  convzx_TextRead.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_TextRead.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_TextRead.QuestionCount)
{
mintQuestionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextRead.QuestionCount);
}
else if (strAttributeName  ==  convzx_TextRead.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_TextRead.CreateDate);
}
else if (strAttributeName  ==  convzx_TextRead.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_TextRead.UpdUser);
}
else if (strAttributeName  ==  convzx_TextRead.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_TextRead.UpdDate);
}
else if (strAttributeName  ==  convzx_TextRead.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_TextRead.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_TextRead.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_TextRead.TextRId  ==  AttributeName[intIndex])
{
return mstrTextRId;
}
else if (convzx_TextRead.ReaderUserId  ==  AttributeName[intIndex])
{
return mstrReaderUserId;
}
else if (convzx_TextRead.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_TextRead.ReadTypeId  ==  AttributeName[intIndex])
{
return mstrReadTypeId;
}
else if (convzx_TextRead.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_TextRead.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convzx_TextRead.Submitter  ==  AttributeName[intIndex])
{
return mstrSubmitter;
}
else if (convzx_TextRead.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_TextRead.QuestionCount  ==  AttributeName[intIndex])
{
return mintQuestionCount;
}
else if (convzx_TextRead.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convzx_TextRead.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_TextRead.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_TextRead.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convzx_TextRead.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_TextRead.TextTitle);
}
else if (convzx_TextRead.TextRId  ==  AttributeName[intIndex])
{
mstrTextRId = value.ToString();
 AddUpdatedFld(convzx_TextRead.TextRId);
}
else if (convzx_TextRead.ReaderUserId  ==  AttributeName[intIndex])
{
mstrReaderUserId = value.ToString();
 AddUpdatedFld(convzx_TextRead.ReaderUserId);
}
else if (convzx_TextRead.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_TextRead.TextId);
}
else if (convzx_TextRead.ReadTypeId  ==  AttributeName[intIndex])
{
mstrReadTypeId = value.ToString();
 AddUpdatedFld(convzx_TextRead.ReadTypeId);
}
else if (convzx_TextRead.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_TextRead.IsSubmit);
}
else if (convzx_TextRead.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_TextRead.IsPublic);
}
else if (convzx_TextRead.Submitter  ==  AttributeName[intIndex])
{
mstrSubmitter = value.ToString();
 AddUpdatedFld(convzx_TextRead.Submitter);
}
else if (convzx_TextRead.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_TextRead.IdCurrEduCls);
}
else if (convzx_TextRead.QuestionCount  ==  AttributeName[intIndex])
{
mintQuestionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextRead.QuestionCount);
}
else if (convzx_TextRead.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_TextRead.CreateDate);
}
else if (convzx_TextRead.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_TextRead.UpdUser);
}
else if (convzx_TextRead.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_TextRead.UpdDate);
}
else if (convzx_TextRead.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_TextRead.Memo);
}
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
 AddUpdatedFld(convzx_TextRead.TextTitle);
}
}
/// <summary>
/// TextRId(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextRId
{
get
{
return mstrTextRId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextRId = value;
}
else
{
 mstrTextRId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TextRead.TextRId);
}
}
/// <summary>
/// ReaderUserId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReaderUserId
{
get
{
return mstrReaderUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReaderUserId = value;
}
else
{
 mstrReaderUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TextRead.ReaderUserId);
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
 AddUpdatedFld(convzx_TextRead.TextId);
}
}
/// <summary>
/// 阅读类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReadTypeId
{
get
{
return mstrReadTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReadTypeId = value;
}
else
{
 mstrReadTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TextRead.ReadTypeId);
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
 AddUpdatedFld(convzx_TextRead.IsSubmit);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPublic
{
get
{
return mbolIsPublic;
}
set
{
 mbolIsPublic = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextRead.IsPublic);
}
}
/// <summary>
/// 提交人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Submitter
{
get
{
return mstrSubmitter;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubmitter = value;
}
else
{
 mstrSubmitter = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TextRead.Submitter);
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
 AddUpdatedFld(convzx_TextRead.IdCurrEduCls);
}
}
/// <summary>
/// 问题数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionCount
{
get
{
return mintQuestionCount;
}
set
{
 mintQuestionCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextRead.QuestionCount);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TextRead.CreateDate);
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
 AddUpdatedFld(convzx_TextRead.UpdUser);
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
 AddUpdatedFld(convzx_TextRead.UpdDate);
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
 AddUpdatedFld(convzx_TextRead.Memo);
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
  return mstrTextRId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrReadTypeId;
 }
 }
}
 /// <summary>
 /// vzx_TextRead(vzx_TextRead)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_TextRead
{
public const string _CurrTabName = "vzx_TextRead"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextRId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TextTitle", "TextRId", "ReaderUserId", "TextId", "ReadTypeId", "IsSubmit", "IsPublic", "Submitter", "IdCurrEduCls", "QuestionCount", "CreateDate", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TextTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTitle = "TextTitle";    //TextTitle

 /// <summary>
 /// 常量:"TextRId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextRId = "TextRId";    //TextRId

 /// <summary>
 /// 常量:"ReaderUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReaderUserId = "ReaderUserId";    //ReaderUserId

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"ReadTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReadTypeId = "ReadTypeId";    //阅读类型

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"Submitter"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Submitter = "Submitter";    //提交人

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"QuestionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionCount = "QuestionCount";    //问题数

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

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
}

}