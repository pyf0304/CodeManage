
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TextReadEN
 表名:zx_TextRead(01120716)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表zx_TextRead的关键字(TextRId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TextRId_zx_TextRead
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
public K_TextRId_zx_TextRead(string strTextRId)
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
 /// <returns>返回:[K_TextRId_zx_TextRead]类型的对象</returns>
public static implicit operator K_TextRId_zx_TextRead(string value)
{
return new K_TextRId_zx_TextRead(value);
}
}
 /// <summary>
 /// 课文阅读(zx_TextRead)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TextReadEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TextRead"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TextRId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"TextId", "ReadTypeId", "IsSubmit", "IsPublic", "Submitter", "IdCurrEduCls", "QuestionCount", "CreateDate", "UpdUser", "UpdDate", "Memo", "TextRId", "ReaderUserId"};

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
protected string mstrTextRId;    //TextRId
protected string mstrReaderUserId;    //ReaderUserId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TextReadEN()
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
public clszx_TextReadEN(string strTextRId)
 {
strTextRId = strTextRId.Replace("'", "''");
if (strTextRId.Length > 10)
{
throw new Exception("在表:zx_TextRead中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTextRId)  ==  true)
{
throw new Exception("在表:zx_TextRead中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conzx_TextRead.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_TextRead.ReadTypeId)
{
return mstrReadTypeId;
}
else if (strAttributeName  ==  conzx_TextRead.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_TextRead.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  conzx_TextRead.Submitter)
{
return mstrSubmitter;
}
else if (strAttributeName  ==  conzx_TextRead.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_TextRead.QuestionCount)
{
return mintQuestionCount;
}
else if (strAttributeName  ==  conzx_TextRead.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conzx_TextRead.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_TextRead.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_TextRead.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_TextRead.TextRId)
{
return mstrTextRId;
}
else if (strAttributeName  ==  conzx_TextRead.ReaderUserId)
{
return mstrReaderUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TextRead.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_TextRead.TextId);
}
else if (strAttributeName  ==  conzx_TextRead.ReadTypeId)
{
mstrReadTypeId = value.ToString();
 AddUpdatedFld(conzx_TextRead.ReadTypeId);
}
else if (strAttributeName  ==  conzx_TextRead.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_TextRead.IsSubmit);
}
else if (strAttributeName  ==  conzx_TextRead.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_TextRead.IsPublic);
}
else if (strAttributeName  ==  conzx_TextRead.Submitter)
{
mstrSubmitter = value.ToString();
 AddUpdatedFld(conzx_TextRead.Submitter);
}
else if (strAttributeName  ==  conzx_TextRead.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_TextRead.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_TextRead.QuestionCount)
{
mintQuestionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TextRead.QuestionCount);
}
else if (strAttributeName  ==  conzx_TextRead.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_TextRead.CreateDate);
}
else if (strAttributeName  ==  conzx_TextRead.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TextRead.UpdUser);
}
else if (strAttributeName  ==  conzx_TextRead.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TextRead.UpdDate);
}
else if (strAttributeName  ==  conzx_TextRead.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TextRead.Memo);
}
else if (strAttributeName  ==  conzx_TextRead.TextRId)
{
mstrTextRId = value.ToString();
 AddUpdatedFld(conzx_TextRead.TextRId);
}
else if (strAttributeName  ==  conzx_TextRead.ReaderUserId)
{
mstrReaderUserId = value.ToString();
 AddUpdatedFld(conzx_TextRead.ReaderUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TextRead.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_TextRead.ReadTypeId  ==  AttributeName[intIndex])
{
return mstrReadTypeId;
}
else if (conzx_TextRead.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_TextRead.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (conzx_TextRead.Submitter  ==  AttributeName[intIndex])
{
return mstrSubmitter;
}
else if (conzx_TextRead.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_TextRead.QuestionCount  ==  AttributeName[intIndex])
{
return mintQuestionCount;
}
else if (conzx_TextRead.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conzx_TextRead.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_TextRead.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_TextRead.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_TextRead.TextRId  ==  AttributeName[intIndex])
{
return mstrTextRId;
}
else if (conzx_TextRead.ReaderUserId  ==  AttributeName[intIndex])
{
return mstrReaderUserId;
}
return null;
}
set
{
if (conzx_TextRead.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_TextRead.TextId);
}
else if (conzx_TextRead.ReadTypeId  ==  AttributeName[intIndex])
{
mstrReadTypeId = value.ToString();
 AddUpdatedFld(conzx_TextRead.ReadTypeId);
}
else if (conzx_TextRead.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_TextRead.IsSubmit);
}
else if (conzx_TextRead.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_TextRead.IsPublic);
}
else if (conzx_TextRead.Submitter  ==  AttributeName[intIndex])
{
mstrSubmitter = value.ToString();
 AddUpdatedFld(conzx_TextRead.Submitter);
}
else if (conzx_TextRead.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_TextRead.IdCurrEduCls);
}
else if (conzx_TextRead.QuestionCount  ==  AttributeName[intIndex])
{
mintQuestionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TextRead.QuestionCount);
}
else if (conzx_TextRead.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_TextRead.CreateDate);
}
else if (conzx_TextRead.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TextRead.UpdUser);
}
else if (conzx_TextRead.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TextRead.UpdDate);
}
else if (conzx_TextRead.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TextRead.Memo);
}
else if (conzx_TextRead.TextRId  ==  AttributeName[intIndex])
{
mstrTextRId = value.ToString();
 AddUpdatedFld(conzx_TextRead.TextRId);
}
else if (conzx_TextRead.ReaderUserId  ==  AttributeName[intIndex])
{
mstrReaderUserId = value.ToString();
 AddUpdatedFld(conzx_TextRead.ReaderUserId);
}
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
 AddUpdatedFld(conzx_TextRead.TextId);
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
 AddUpdatedFld(conzx_TextRead.ReadTypeId);
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
 AddUpdatedFld(conzx_TextRead.IsSubmit);
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
 AddUpdatedFld(conzx_TextRead.IsPublic);
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
 AddUpdatedFld(conzx_TextRead.Submitter);
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
 AddUpdatedFld(conzx_TextRead.IdCurrEduCls);
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
 AddUpdatedFld(conzx_TextRead.QuestionCount);
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
 AddUpdatedFld(conzx_TextRead.CreateDate);
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
 AddUpdatedFld(conzx_TextRead.UpdUser);
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
 AddUpdatedFld(conzx_TextRead.UpdDate);
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
 AddUpdatedFld(conzx_TextRead.Memo);
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
 AddUpdatedFld(conzx_TextRead.TextRId);
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
 AddUpdatedFld(conzx_TextRead.ReaderUserId);
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
}
 /// <summary>
 /// 课文阅读(zx_TextRead)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TextRead
{
public const string _CurrTabName = "zx_TextRead"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextRId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TextId", "ReadTypeId", "IsSubmit", "IsPublic", "Submitter", "IdCurrEduCls", "QuestionCount", "CreateDate", "UpdUser", "UpdDate", "Memo", "TextRId", "ReaderUserId"};
//以下是属性变量


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
}

}