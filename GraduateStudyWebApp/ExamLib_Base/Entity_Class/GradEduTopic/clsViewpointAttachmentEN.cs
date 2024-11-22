
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewpointAttachmentEN
 表名:ViewpointAttachment(01120591)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:35
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
 /// 表ViewpointAttachment的关键字(ViewpointAttachmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointAttachmentId_ViewpointAttachment
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngViewpointAttachmentId">表关键字</param>
public K_ViewpointAttachmentId_ViewpointAttachment(long lngViewpointAttachmentId)
{
if (IsValid(lngViewpointAttachmentId)) Value = lngViewpointAttachmentId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngViewpointAttachmentId)
{
if (lngViewpointAttachmentId == 0) return false;
if (lngViewpointAttachmentId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewpointAttachmentId_ViewpointAttachment]类型的对象</returns>
public static implicit operator K_ViewpointAttachmentId_ViewpointAttachment(long value)
{
return new K_ViewpointAttachmentId_ViewpointAttachment(value);
}
}
 /// <summary>
 /// 观点附件表(ViewpointAttachment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewpointAttachmentEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewpointAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"ViewpointAttachmentId", "ViewpointAttachmentName", "ViewpointId", "FilePath", "UpdUserId", "UpdDate", "Memo", "IdCurrEduCls"};

protected long mlngViewpointAttachmentId;    //主键Id
protected string mstrViewpointAttachmentName;    //附件名称
protected string mstrViewpointId;    //观点Id
protected string mstrFilePath;    //文件路径
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsViewpointAttachmentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointAttachmentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngViewpointAttachmentId">关键字:主键Id</param>
public clsViewpointAttachmentEN(long lngViewpointAttachmentId)
 {
 if (lngViewpointAttachmentId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngViewpointAttachmentId = lngViewpointAttachmentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointAttachmentId");
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
if (strAttributeName  ==  conViewpointAttachment.ViewpointAttachmentId)
{
return mlngViewpointAttachmentId;
}
else if (strAttributeName  ==  conViewpointAttachment.ViewpointAttachmentName)
{
return mstrViewpointAttachmentName;
}
else if (strAttributeName  ==  conViewpointAttachment.ViewpointId)
{
return mstrViewpointId;
}
else if (strAttributeName  ==  conViewpointAttachment.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conViewpointAttachment.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conViewpointAttachment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conViewpointAttachment.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conViewpointAttachment.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  conViewpointAttachment.ViewpointAttachmentId)
{
mlngViewpointAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewpointAttachment.ViewpointAttachmentId);
}
else if (strAttributeName  ==  conViewpointAttachment.ViewpointAttachmentName)
{
mstrViewpointAttachmentName = value.ToString();
 AddUpdatedFld(conViewpointAttachment.ViewpointAttachmentName);
}
else if (strAttributeName  ==  conViewpointAttachment.ViewpointId)
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(conViewpointAttachment.ViewpointId);
}
else if (strAttributeName  ==  conViewpointAttachment.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conViewpointAttachment.FilePath);
}
else if (strAttributeName  ==  conViewpointAttachment.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conViewpointAttachment.UpdUserId);
}
else if (strAttributeName  ==  conViewpointAttachment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewpointAttachment.UpdDate);
}
else if (strAttributeName  ==  conViewpointAttachment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewpointAttachment.Memo);
}
else if (strAttributeName  ==  conViewpointAttachment.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conViewpointAttachment.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewpointAttachment.ViewpointAttachmentId  ==  AttributeName[intIndex])
{
return mlngViewpointAttachmentId;
}
else if (conViewpointAttachment.ViewpointAttachmentName  ==  AttributeName[intIndex])
{
return mstrViewpointAttachmentName;
}
else if (conViewpointAttachment.ViewpointId  ==  AttributeName[intIndex])
{
return mstrViewpointId;
}
else if (conViewpointAttachment.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conViewpointAttachment.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conViewpointAttachment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conViewpointAttachment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conViewpointAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (conViewpointAttachment.ViewpointAttachmentId  ==  AttributeName[intIndex])
{
mlngViewpointAttachmentId = TransNullToInt(value.ToString());
 AddUpdatedFld(conViewpointAttachment.ViewpointAttachmentId);
}
else if (conViewpointAttachment.ViewpointAttachmentName  ==  AttributeName[intIndex])
{
mstrViewpointAttachmentName = value.ToString();
 AddUpdatedFld(conViewpointAttachment.ViewpointAttachmentName);
}
else if (conViewpointAttachment.ViewpointId  ==  AttributeName[intIndex])
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(conViewpointAttachment.ViewpointId);
}
else if (conViewpointAttachment.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conViewpointAttachment.FilePath);
}
else if (conViewpointAttachment.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conViewpointAttachment.UpdUserId);
}
else if (conViewpointAttachment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conViewpointAttachment.UpdDate);
}
else if (conViewpointAttachment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewpointAttachment.Memo);
}
else if (conViewpointAttachment.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conViewpointAttachment.IdCurrEduCls);
}
}
}

/// <summary>
/// 主键Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ViewpointAttachmentId
{
get
{
return mlngViewpointAttachmentId;
}
set
{
 mlngViewpointAttachmentId = value;
//记录修改过的字段
 AddUpdatedFld(conViewpointAttachment.ViewpointAttachmentId);
}
}
/// <summary>
/// 附件名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointAttachmentName
{
get
{
return mstrViewpointAttachmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointAttachmentName = value;
}
else
{
 mstrViewpointAttachmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewpointAttachment.ViewpointAttachmentName);
}
}
/// <summary>
/// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointId
{
get
{
return mstrViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointId = value;
}
else
{
 mstrViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewpointAttachment.ViewpointId);
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
 AddUpdatedFld(conViewpointAttachment.FilePath);
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
 AddUpdatedFld(conViewpointAttachment.UpdUserId);
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
 AddUpdatedFld(conViewpointAttachment.UpdDate);
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
 AddUpdatedFld(conViewpointAttachment.Memo);
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
 AddUpdatedFld(conViewpointAttachment.IdCurrEduCls);
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
  return mlngViewpointAttachmentId.ToString();
 }
 }
}
 /// <summary>
 /// 观点附件表(ViewpointAttachment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewpointAttachment
{
public const string _CurrTabName = "ViewpointAttachment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewpointAttachmentId", "ViewpointAttachmentName", "ViewpointId", "FilePath", "UpdUserId", "UpdDate", "Memo", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewpointAttachmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointAttachmentId = "ViewpointAttachmentId";    //主键Id

 /// <summary>
 /// 常量:"ViewpointAttachmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointAttachmentName = "ViewpointAttachmentName";    //附件名称

 /// <summary>
 /// 常量:"ViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointId = "ViewpointId";    //观点Id

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}