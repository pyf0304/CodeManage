
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PTopicObjectiveRelaEN
 表名:gs_PTopicObjectiveRela(01120673)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表gs_PTopicObjectiveRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_gs_PTopicObjectiveRela
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
public K_mId_gs_PTopicObjectiveRela(long lngmId)
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
 /// <returns>返回:[K_mId_gs_PTopicObjectiveRela]类型的对象</returns>
public static implicit operator K_mId_gs_PTopicObjectiveRela(long value)
{
return new K_mId_gs_PTopicObjectiveRela(value);
}
}
 /// <summary>
 /// 论文客观关系表(gs_PTopicObjectiveRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_PTopicObjectiveRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_PTopicObjectiveRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "PaperId", "SectionId", "TopicObjectiveId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrPaperId;    //论文Id
protected string mstrSectionId;    //节Id
protected string mstrTopicObjectiveId;    //客观Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_PTopicObjectiveRelaEN()
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
public clsgs_PTopicObjectiveRelaEN(long lngmId)
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
if (strAttributeName  ==  congs_PTopicObjectiveRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.TopicObjectiveId)
{
return mstrTopicObjectiveId;
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_PTopicObjectiveRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PTopicObjectiveRela.mId);
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.PaperId);
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.SectionId);
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.TopicObjectiveId)
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.TopicObjectiveId);
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.UpdDate);
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.UpdUser);
}
else if (strAttributeName  ==  congs_PTopicObjectiveRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_PTopicObjectiveRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (congs_PTopicObjectiveRela.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (congs_PTopicObjectiveRela.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (congs_PTopicObjectiveRela.TopicObjectiveId  ==  AttributeName[intIndex])
{
return mstrTopicObjectiveId;
}
else if (congs_PTopicObjectiveRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_PTopicObjectiveRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_PTopicObjectiveRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_PTopicObjectiveRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PTopicObjectiveRela.mId);
}
else if (congs_PTopicObjectiveRela.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.PaperId);
}
else if (congs_PTopicObjectiveRela.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.SectionId);
}
else if (congs_PTopicObjectiveRela.TopicObjectiveId  ==  AttributeName[intIndex])
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.TopicObjectiveId);
}
else if (congs_PTopicObjectiveRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.UpdDate);
}
else if (congs_PTopicObjectiveRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.UpdUser);
}
else if (congs_PTopicObjectiveRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_PTopicObjectiveRela.Memo);
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
 AddUpdatedFld(congs_PTopicObjectiveRela.mId);
}
}
/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperId
{
get
{
return mstrPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperId = value;
}
else
{
 mstrPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PTopicObjectiveRela.PaperId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PTopicObjectiveRela.SectionId);
}
}
/// <summary>
/// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicObjectiveId
{
get
{
return mstrTopicObjectiveId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicObjectiveId = value;
}
else
{
 mstrTopicObjectiveId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PTopicObjectiveRela.TopicObjectiveId);
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
 AddUpdatedFld(congs_PTopicObjectiveRela.UpdDate);
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
 AddUpdatedFld(congs_PTopicObjectiveRela.UpdUser);
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
 AddUpdatedFld(congs_PTopicObjectiveRela.Memo);
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
 /// 论文客观关系表(gs_PTopicObjectiveRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_PTopicObjectiveRela
{
public const string _CurrTabName = "gs_PTopicObjectiveRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "PaperId", "SectionId", "TopicObjectiveId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"TopicObjectiveId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicObjectiveId = "TopicObjectiveId";    //客观Id

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