
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperAttentionEN
 表名:gs_PaperAttention(01120748)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:57
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
 /// 表gs_PaperAttention的关键字(PaperAttentionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperAttentionId_gs_PaperAttention
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperAttentionId">表关键字</param>
public K_PaperAttentionId_gs_PaperAttention(long lngPaperAttentionId)
{
if (IsValid(lngPaperAttentionId)) Value = lngPaperAttentionId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperAttentionId)
{
if (lngPaperAttentionId == 0) return false;
if (lngPaperAttentionId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperAttentionId_gs_PaperAttention]类型的对象</returns>
public static implicit operator K_PaperAttentionId_gs_PaperAttention(long value)
{
return new K_PaperAttentionId_gs_PaperAttention(value);
}
}
 /// <summary>
 /// 论文关注(gs_PaperAttention)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_PaperAttentionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_PaperAttention"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperAttentionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"PaperAttentionId", "PaperId", "UserId", "PaperGroupId", "UpdUser", "UpdDate", "Meno"};

protected long mlngPaperAttentionId;    //论文收藏Id
protected string mstrPaperId;    //论文Id
protected string mstrUserId;    //用户ID
protected string mstrPaperGroupId;    //组Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMeno;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_PaperAttentionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperAttentionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperAttentionId">关键字:论文收藏Id</param>
public clsgs_PaperAttentionEN(long lngPaperAttentionId)
 {
 if (lngPaperAttentionId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperAttentionId = lngPaperAttentionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperAttentionId");
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
if (strAttributeName  ==  congs_PaperAttention.PaperAttentionId)
{
return mlngPaperAttentionId;
}
else if (strAttributeName  ==  congs_PaperAttention.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  congs_PaperAttention.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  congs_PaperAttention.PaperGroupId)
{
return mstrPaperGroupId;
}
else if (strAttributeName  ==  congs_PaperAttention.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_PaperAttention.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_PaperAttention.Meno)
{
return mstrMeno;
}
return null;
}
set
{
if (strAttributeName  ==  congs_PaperAttention.PaperAttentionId)
{
mlngPaperAttentionId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperAttention.PaperAttentionId);
}
else if (strAttributeName  ==  congs_PaperAttention.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_PaperAttention.PaperId);
}
else if (strAttributeName  ==  congs_PaperAttention.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(congs_PaperAttention.UserId);
}
else if (strAttributeName  ==  congs_PaperAttention.PaperGroupId)
{
mstrPaperGroupId = value.ToString();
 AddUpdatedFld(congs_PaperAttention.PaperGroupId);
}
else if (strAttributeName  ==  congs_PaperAttention.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PaperAttention.UpdUser);
}
else if (strAttributeName  ==  congs_PaperAttention.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PaperAttention.UpdDate);
}
else if (strAttributeName  ==  congs_PaperAttention.Meno)
{
mstrMeno = value.ToString();
 AddUpdatedFld(congs_PaperAttention.Meno);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_PaperAttention.PaperAttentionId  ==  AttributeName[intIndex])
{
return mlngPaperAttentionId;
}
else if (congs_PaperAttention.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (congs_PaperAttention.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (congs_PaperAttention.PaperGroupId  ==  AttributeName[intIndex])
{
return mstrPaperGroupId;
}
else if (congs_PaperAttention.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_PaperAttention.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_PaperAttention.Meno  ==  AttributeName[intIndex])
{
return mstrMeno;
}
return null;
}
set
{
if (congs_PaperAttention.PaperAttentionId  ==  AttributeName[intIndex])
{
mlngPaperAttentionId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperAttention.PaperAttentionId);
}
else if (congs_PaperAttention.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_PaperAttention.PaperId);
}
else if (congs_PaperAttention.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(congs_PaperAttention.UserId);
}
else if (congs_PaperAttention.PaperGroupId  ==  AttributeName[intIndex])
{
mstrPaperGroupId = value.ToString();
 AddUpdatedFld(congs_PaperAttention.PaperGroupId);
}
else if (congs_PaperAttention.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PaperAttention.UpdUser);
}
else if (congs_PaperAttention.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PaperAttention.UpdDate);
}
else if (congs_PaperAttention.Meno  ==  AttributeName[intIndex])
{
mstrMeno = value.ToString();
 AddUpdatedFld(congs_PaperAttention.Meno);
}
}
}

/// <summary>
/// 论文收藏Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperAttentionId
{
get
{
return mlngPaperAttentionId;
}
set
{
 mlngPaperAttentionId = value;
//记录修改过的字段
 AddUpdatedFld(congs_PaperAttention.PaperAttentionId);
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
 AddUpdatedFld(congs_PaperAttention.PaperId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperAttention.UserId);
}
}
/// <summary>
/// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperGroupId
{
get
{
return mstrPaperGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperGroupId = value;
}
else
{
 mstrPaperGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperAttention.PaperGroupId);
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
 AddUpdatedFld(congs_PaperAttention.UpdUser);
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
 AddUpdatedFld(congs_PaperAttention.UpdDate);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Meno
{
get
{
return mstrMeno;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMeno = value;
}
else
{
 mstrMeno = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperAttention.Meno);
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
  return mlngPaperAttentionId.ToString();
 }
 }
}
 /// <summary>
 /// 论文关注(gs_PaperAttention)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_PaperAttention
{
public const string _CurrTabName = "gs_PaperAttention"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperAttentionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperAttentionId", "PaperId", "UserId", "PaperGroupId", "UpdUser", "UpdDate", "Meno"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperAttentionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperAttentionId = "PaperAttentionId";    //论文收藏Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"PaperGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperGroupId = "PaperGroupId";    //组Id

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
 /// 常量:"Meno"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Meno = "Meno";    //备注
}

}