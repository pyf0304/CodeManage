
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvConceptCitationEN
 表名:vConceptCitation(01120611)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:19
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
 /// 表vConceptCitation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vConceptCitation
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
public K_mId_vConceptCitation(long lngmId)
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
 /// <returns>返回:[K_mId_vConceptCitation]类型的对象</returns>
public static implicit operator K_mId_vConceptCitation(long value)
{
return new K_mId_vConceptCitation(value);
}
}
 /// <summary>
 /// vConceptCitation(vConceptCitation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvConceptCitationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vConceptCitation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"ConceptContent", "ConceptId", "ConceptName", "UpdDate", "mId", "PaperId", "PaperTitle", "PaperContent", "UserName", "UpdUserId", "TopicId", "TopicName"};

protected string mstrConceptContent;    //概念内容
protected string mstrConceptId;    //概念Id
protected string mstrConceptName;    //概念名称
protected string mstrUpdDate;    //修改日期
protected long mlngmId;    //mId
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperContent;    //主题内容
protected string mstrUserName;    //用户名
protected string mstrUpdUserId;    //修改用户Id
protected string mstrTopicId;    //主题Id
protected string mstrTopicName;    //栏目主题

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvConceptCitationEN()
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
public clsvConceptCitationEN(long lngmId)
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
if (strAttributeName  ==  convConceptCitation.ConceptContent)
{
return mstrConceptContent;
}
else if (strAttributeName  ==  convConceptCitation.ConceptId)
{
return mstrConceptId;
}
else if (strAttributeName  ==  convConceptCitation.ConceptName)
{
return mstrConceptName;
}
else if (strAttributeName  ==  convConceptCitation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convConceptCitation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convConceptCitation.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convConceptCitation.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convConceptCitation.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convConceptCitation.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convConceptCitation.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convConceptCitation.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convConceptCitation.TopicName)
{
return mstrTopicName;
}
return null;
}
set
{
if (strAttributeName  ==  convConceptCitation.ConceptContent)
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convConceptCitation.ConceptContent);
}
else if (strAttributeName  ==  convConceptCitation.ConceptId)
{
mstrConceptId = value.ToString();
 AddUpdatedFld(convConceptCitation.ConceptId);
}
else if (strAttributeName  ==  convConceptCitation.ConceptName)
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convConceptCitation.ConceptName);
}
else if (strAttributeName  ==  convConceptCitation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convConceptCitation.UpdDate);
}
else if (strAttributeName  ==  convConceptCitation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convConceptCitation.mId);
}
else if (strAttributeName  ==  convConceptCitation.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convConceptCitation.PaperId);
}
else if (strAttributeName  ==  convConceptCitation.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convConceptCitation.PaperTitle);
}
else if (strAttributeName  ==  convConceptCitation.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convConceptCitation.PaperContent);
}
else if (strAttributeName  ==  convConceptCitation.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convConceptCitation.UserName);
}
else if (strAttributeName  ==  convConceptCitation.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convConceptCitation.UpdUserId);
}
else if (strAttributeName  ==  convConceptCitation.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convConceptCitation.TopicId);
}
else if (strAttributeName  ==  convConceptCitation.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convConceptCitation.TopicName);
}
}
}
public object this[int intIndex]
{
get
{
if (convConceptCitation.ConceptContent  ==  AttributeName[intIndex])
{
return mstrConceptContent;
}
else if (convConceptCitation.ConceptId  ==  AttributeName[intIndex])
{
return mstrConceptId;
}
else if (convConceptCitation.ConceptName  ==  AttributeName[intIndex])
{
return mstrConceptName;
}
else if (convConceptCitation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convConceptCitation.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convConceptCitation.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convConceptCitation.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convConceptCitation.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convConceptCitation.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convConceptCitation.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convConceptCitation.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convConceptCitation.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
return null;
}
set
{
if (convConceptCitation.ConceptContent  ==  AttributeName[intIndex])
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convConceptCitation.ConceptContent);
}
else if (convConceptCitation.ConceptId  ==  AttributeName[intIndex])
{
mstrConceptId = value.ToString();
 AddUpdatedFld(convConceptCitation.ConceptId);
}
else if (convConceptCitation.ConceptName  ==  AttributeName[intIndex])
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convConceptCitation.ConceptName);
}
else if (convConceptCitation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convConceptCitation.UpdDate);
}
else if (convConceptCitation.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convConceptCitation.mId);
}
else if (convConceptCitation.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convConceptCitation.PaperId);
}
else if (convConceptCitation.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convConceptCitation.PaperTitle);
}
else if (convConceptCitation.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convConceptCitation.PaperContent);
}
else if (convConceptCitation.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convConceptCitation.UserName);
}
else if (convConceptCitation.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convConceptCitation.UpdUserId);
}
else if (convConceptCitation.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convConceptCitation.TopicId);
}
else if (convConceptCitation.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convConceptCitation.TopicName);
}
}
}

/// <summary>
/// 概念内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptContent
{
get
{
return mstrConceptContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptContent = value;
}
else
{
 mstrConceptContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptCitation.ConceptContent);
}
}
/// <summary>
/// 概念Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptId
{
get
{
return mstrConceptId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptId = value;
}
else
{
 mstrConceptId = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptCitation.ConceptId);
}
}
/// <summary>
/// 概念名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptName
{
get
{
return mstrConceptName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptName = value;
}
else
{
 mstrConceptName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptCitation.ConceptName);
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
 AddUpdatedFld(convConceptCitation.UpdDate);
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
 AddUpdatedFld(convConceptCitation.mId);
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
 AddUpdatedFld(convConceptCitation.PaperId);
}
}
/// <summary>
/// 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTitle
{
get
{
return mstrPaperTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTitle = value;
}
else
{
 mstrPaperTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptCitation.PaperTitle);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperContent
{
get
{
return mstrPaperContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperContent = value;
}
else
{
 mstrPaperContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptCitation.PaperContent);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptCitation.UserName);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptCitation.UpdUserId);
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
 AddUpdatedFld(convConceptCitation.TopicId);
}
}
/// <summary>
/// 栏目主题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicName
{
get
{
return mstrTopicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicName = value;
}
else
{
 mstrTopicName = value;
}
//记录修改过的字段
 AddUpdatedFld(convConceptCitation.TopicName);
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
 /// vConceptCitation(vConceptCitation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convConceptCitation
{
public const string _CurrTabName = "vConceptCitation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ConceptContent", "ConceptId", "ConceptName", "UpdDate", "mId", "PaperId", "PaperTitle", "PaperContent", "UserName", "UpdUserId", "TopicId", "TopicName"};
//以下是属性变量


 /// <summary>
 /// 常量:"ConceptContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptContent = "ConceptContent";    //概念内容

 /// <summary>
 /// 常量:"ConceptId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptId = "ConceptId";    //概念Id

 /// <summary>
 /// 常量:"ConceptName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptName = "ConceptName";    //概念名称

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

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
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"PaperContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperContent = "PaperContent";    //主题内容

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"TopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicName = "TopicName";    //栏目主题
}

}