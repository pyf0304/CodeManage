
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ConnectLookNodeRelaEN
 表名:ge_ConnectLookNodeRela(01120918)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表ge_ConnectLookNodeRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ge_ConnectLookNodeRela
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
public K_mId_ge_ConnectLookNodeRela(long lngmId)
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
 /// <returns>返回:[K_mId_ge_ConnectLookNodeRela]类型的对象</returns>
public static implicit operator K_mId_ge_ConnectLookNodeRela(long value)
{
return new K_mId_ge_ConnectLookNodeRela(value);
}
}
 /// <summary>
 /// 连连看节点关系(ge_ConnectLookNodeRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_ConnectLookNodeRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_ConnectLookNodeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "SourceId", "TargetId", "ConnectLookChartId", "SourceAnchor", "TargetAnchor", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrSourceId;    //来源Id
protected string mstrTargetId;    //目标Id
protected string mstrConnectLookChartId;    //连连看图Id
protected string mstrSourceAnchor;    //源锚点
protected string mstrTargetAnchor;    //目标锚点
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_ConnectLookNodeRelaEN()
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
public clsge_ConnectLookNodeRelaEN(long lngmId)
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
if (strAttributeName  ==  conge_ConnectLookNodeRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.SourceId)
{
return mstrSourceId;
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.TargetId)
{
return mstrTargetId;
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.ConnectLookChartId)
{
return mstrConnectLookChartId;
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.SourceAnchor)
{
return mstrSourceAnchor;
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.TargetAnchor)
{
return mstrTargetAnchor;
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_ConnectLookNodeRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_ConnectLookNodeRela.mId);
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.SourceId)
{
mstrSourceId = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.SourceId);
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.TargetId)
{
mstrTargetId = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.TargetId);
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.ConnectLookChartId)
{
mstrConnectLookChartId = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.ConnectLookChartId);
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.SourceAnchor)
{
mstrSourceAnchor = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.SourceAnchor);
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.TargetAnchor)
{
mstrTargetAnchor = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.TargetAnchor);
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.UpdDate);
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.UpdUser);
}
else if (strAttributeName  ==  conge_ConnectLookNodeRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_ConnectLookNodeRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conge_ConnectLookNodeRela.SourceId  ==  AttributeName[intIndex])
{
return mstrSourceId;
}
else if (conge_ConnectLookNodeRela.TargetId  ==  AttributeName[intIndex])
{
return mstrTargetId;
}
else if (conge_ConnectLookNodeRela.ConnectLookChartId  ==  AttributeName[intIndex])
{
return mstrConnectLookChartId;
}
else if (conge_ConnectLookNodeRela.SourceAnchor  ==  AttributeName[intIndex])
{
return mstrSourceAnchor;
}
else if (conge_ConnectLookNodeRela.TargetAnchor  ==  AttributeName[intIndex])
{
return mstrTargetAnchor;
}
else if (conge_ConnectLookNodeRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_ConnectLookNodeRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_ConnectLookNodeRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_ConnectLookNodeRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_ConnectLookNodeRela.mId);
}
else if (conge_ConnectLookNodeRela.SourceId  ==  AttributeName[intIndex])
{
mstrSourceId = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.SourceId);
}
else if (conge_ConnectLookNodeRela.TargetId  ==  AttributeName[intIndex])
{
mstrTargetId = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.TargetId);
}
else if (conge_ConnectLookNodeRela.ConnectLookChartId  ==  AttributeName[intIndex])
{
mstrConnectLookChartId = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.ConnectLookChartId);
}
else if (conge_ConnectLookNodeRela.SourceAnchor  ==  AttributeName[intIndex])
{
mstrSourceAnchor = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.SourceAnchor);
}
else if (conge_ConnectLookNodeRela.TargetAnchor  ==  AttributeName[intIndex])
{
mstrTargetAnchor = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.TargetAnchor);
}
else if (conge_ConnectLookNodeRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.UpdDate);
}
else if (conge_ConnectLookNodeRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.UpdUser);
}
else if (conge_ConnectLookNodeRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ConnectLookNodeRela.Memo);
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
 AddUpdatedFld(conge_ConnectLookNodeRela.mId);
}
}
/// <summary>
/// 来源Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceId
{
get
{
return mstrSourceId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceId = value;
}
else
{
 mstrSourceId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookNodeRela.SourceId);
}
}
/// <summary>
/// 目标Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TargetId
{
get
{
return mstrTargetId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTargetId = value;
}
else
{
 mstrTargetId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookNodeRela.TargetId);
}
}
/// <summary>
/// 连连看图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConnectLookChartId
{
get
{
return mstrConnectLookChartId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConnectLookChartId = value;
}
else
{
 mstrConnectLookChartId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookNodeRela.ConnectLookChartId);
}
}
/// <summary>
/// 源锚点(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceAnchor
{
get
{
return mstrSourceAnchor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceAnchor = value;
}
else
{
 mstrSourceAnchor = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookNodeRela.SourceAnchor);
}
}
/// <summary>
/// 目标锚点(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TargetAnchor
{
get
{
return mstrTargetAnchor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTargetAnchor = value;
}
else
{
 mstrTargetAnchor = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookNodeRela.TargetAnchor);
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
 AddUpdatedFld(conge_ConnectLookNodeRela.UpdDate);
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
 AddUpdatedFld(conge_ConnectLookNodeRela.UpdUser);
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
 AddUpdatedFld(conge_ConnectLookNodeRela.Memo);
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
 /// 连连看节点关系(ge_ConnectLookNodeRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_ConnectLookNodeRela
{
public const string _CurrTabName = "ge_ConnectLookNodeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "SourceId", "TargetId", "ConnectLookChartId", "SourceAnchor", "TargetAnchor", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"SourceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceId = "SourceId";    //来源Id

 /// <summary>
 /// 常量:"TargetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetId = "TargetId";    //目标Id

 /// <summary>
 /// 常量:"ConnectLookChartId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConnectLookChartId = "ConnectLookChartId";    //连连看图Id

 /// <summary>
 /// 常量:"SourceAnchor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceAnchor = "SourceAnchor";    //源锚点

 /// <summary>
 /// 常量:"TargetAnchor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetAnchor = "TargetAnchor";    //目标锚点

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