﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ResearchResultAttachmentEN
 表名:gs_ResearchResultAttachment(01120779)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
 框架-层名:实体层(CS)(EntityLayer,0001)
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
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表gs_ResearchResultAttachment的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_gs_ResearchResultAttachment
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_gs_ResearchResultAttachment(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_gs_ResearchResultAttachment]类型的对象</returns>
public static implicit operator K_mId_gs_ResearchResultAttachment(long value)
{
return new K_mId_gs_ResearchResultAttachment(value);
}
}
 /// <summary>
 /// 研究成果附件表(gs_ResearchResultAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_ResearchResultAttachmentEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_ResearchResultAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "ResultId", "TopicId", "FileName", "FilePath", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrResultId;    //成果Id
protected string mstrTopicId;    //主题Id
protected string mstrFileName;    //文件名称
protected string mstrFilePath;    //文件路径
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_ResearchResultAttachmentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsgs_ResearchResultAttachmentEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  congs_ResearchResultAttachment.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.ResultId)
{
return mstrResultId;
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_ResearchResultAttachment.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_ResearchResultAttachment.mId);
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.ResultId)
{
mstrResultId = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.ResultId);
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.TopicId);
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.FileName);
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.FilePath);
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.UpdDate);
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.UpdUser);
}
else if (strAttributeName  ==  congs_ResearchResultAttachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_ResearchResultAttachment.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (congs_ResearchResultAttachment.ResultId  ==  AttributeName[intIndex])
{
return mstrResultId;
}
else if (congs_ResearchResultAttachment.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (congs_ResearchResultAttachment.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (congs_ResearchResultAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (congs_ResearchResultAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_ResearchResultAttachment.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_ResearchResultAttachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_ResearchResultAttachment.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_ResearchResultAttachment.mId);
}
else if (congs_ResearchResultAttachment.ResultId  ==  AttributeName[intIndex])
{
mstrResultId = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.ResultId);
}
else if (congs_ResearchResultAttachment.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.TopicId);
}
else if (congs_ResearchResultAttachment.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.FileName);
}
else if (congs_ResearchResultAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.FilePath);
}
else if (congs_ResearchResultAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.UpdDate);
}
else if (congs_ResearchResultAttachment.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.UpdUser);
}
else if (congs_ResearchResultAttachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_ResearchResultAttachment.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(congs_ResearchResultAttachment.mId);
}
}
/// <summary>
/// 成果Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResultId
{
get
{
return mstrResultId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResultId = value;
}
else
{
 mstrResultId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ResearchResultAttachment.ResultId);
}
}
/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicId
{
get
{
return mstrTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicId = value;
}
else
{
 mstrTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ResearchResultAttachment.TopicId);
}
}
/// <summary>
/// 文件名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ResearchResultAttachment.FileName);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ResearchResultAttachment.FilePath);
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
 AddUpdatedFld(congs_ResearchResultAttachment.UpdDate);
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
 AddUpdatedFld(congs_ResearchResultAttachment.UpdUser);
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
 AddUpdatedFld(congs_ResearchResultAttachment.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 研究成果附件表(gs_ResearchResultAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_ResearchResultAttachment
{
public const string _CurrTabName = "gs_ResearchResultAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "ResultId", "TopicId", "FileName", "FilePath", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ResultId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResultId = "ResultId";    //成果Id

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名称

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}