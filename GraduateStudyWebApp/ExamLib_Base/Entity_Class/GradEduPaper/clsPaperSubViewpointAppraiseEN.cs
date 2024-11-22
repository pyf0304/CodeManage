
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubViewpointAppraiseEN
 表名:PaperSubViewpointAppraise(01120561)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:37
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
 /// 表PaperSubViewpointAppraise的关键字(PaperSubViewpointAppraiseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperSubViewpointAppraiseId_PaperSubViewpointAppraise
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperSubViewpointAppraiseId">表关键字</param>
public K_PaperSubViewpointAppraiseId_PaperSubViewpointAppraise(long lngPaperSubViewpointAppraiseId)
{
if (IsValid(lngPaperSubViewpointAppraiseId)) Value = lngPaperSubViewpointAppraiseId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperSubViewpointAppraiseId)
{
if (lngPaperSubViewpointAppraiseId == 0) return false;
if (lngPaperSubViewpointAppraiseId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperSubViewpointAppraiseId_PaperSubViewpointAppraise]类型的对象</returns>
public static implicit operator K_PaperSubViewpointAppraiseId_PaperSubViewpointAppraise(long value)
{
return new K_PaperSubViewpointAppraiseId_PaperSubViewpointAppraise(value);
}
}
 /// <summary>
 /// 子观点评论表(PaperSubViewpointAppraise)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperSubViewpointAppraiseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperSubViewpointAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperSubViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"PaperSubViewpointAppraiseId", "SubViewpointId", "AppraiseScore", "AppraiseContent", "UpdDate", "Meno", "UpdUser"};

protected long mlngPaperSubViewpointAppraiseId;    //子观点评价Id
protected long mlngSubViewpointId;    //子观点Id
protected float? mfltAppraiseScore;    //打分
protected string mstrAppraiseContent;    //评议内容
protected string mstrUpdDate;    //修改日期
protected string mstrMeno;    //备注
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperSubViewpointAppraiseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubViewpointAppraiseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperSubViewpointAppraiseId">关键字:子观点评价Id</param>
public clsPaperSubViewpointAppraiseEN(long lngPaperSubViewpointAppraiseId)
 {
 if (lngPaperSubViewpointAppraiseId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperSubViewpointAppraiseId = lngPaperSubViewpointAppraiseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubViewpointAppraiseId");
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
if (strAttributeName  ==  conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId)
{
return mlngPaperSubViewpointAppraiseId;
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.SubViewpointId)
{
return mlngSubViewpointId;
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.AppraiseScore)
{
return mfltAppraiseScore;
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.AppraiseContent)
{
return mstrAppraiseContent;
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.Meno)
{
return mstrMeno;
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId)
{
mlngPaperSubViewpointAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId);
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.SubViewpointId)
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpointAppraise.SubViewpointId);
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.AppraiseScore)
{
mfltAppraiseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaperSubViewpointAppraise.AppraiseScore);
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.AppraiseContent)
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(conPaperSubViewpointAppraise.AppraiseContent);
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubViewpointAppraise.UpdDate);
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.Meno)
{
mstrMeno = value.ToString();
 AddUpdatedFld(conPaperSubViewpointAppraise.Meno);
}
else if (strAttributeName  ==  conPaperSubViewpointAppraise.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperSubViewpointAppraise.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId  ==  AttributeName[intIndex])
{
return mlngPaperSubViewpointAppraiseId;
}
else if (conPaperSubViewpointAppraise.SubViewpointId  ==  AttributeName[intIndex])
{
return mlngSubViewpointId;
}
else if (conPaperSubViewpointAppraise.AppraiseScore  ==  AttributeName[intIndex])
{
return mfltAppraiseScore;
}
else if (conPaperSubViewpointAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
return mstrAppraiseContent;
}
else if (conPaperSubViewpointAppraise.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperSubViewpointAppraise.Meno  ==  AttributeName[intIndex])
{
return mstrMeno;
}
else if (conPaperSubViewpointAppraise.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId  ==  AttributeName[intIndex])
{
mlngPaperSubViewpointAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId);
}
else if (conPaperSubViewpointAppraise.SubViewpointId  ==  AttributeName[intIndex])
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpointAppraise.SubViewpointId);
}
else if (conPaperSubViewpointAppraise.AppraiseScore  ==  AttributeName[intIndex])
{
mfltAppraiseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaperSubViewpointAppraise.AppraiseScore);
}
else if (conPaperSubViewpointAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(conPaperSubViewpointAppraise.AppraiseContent);
}
else if (conPaperSubViewpointAppraise.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubViewpointAppraise.UpdDate);
}
else if (conPaperSubViewpointAppraise.Meno  ==  AttributeName[intIndex])
{
mstrMeno = value.ToString();
 AddUpdatedFld(conPaperSubViewpointAppraise.Meno);
}
else if (conPaperSubViewpointAppraise.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperSubViewpointAppraise.UpdUser);
}
}
}

/// <summary>
/// 子观点评价Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperSubViewpointAppraiseId
{
get
{
return mlngPaperSubViewpointAppraiseId;
}
set
{
 mlngPaperSubViewpointAppraiseId = value;
//记录修改过的字段
 AddUpdatedFld(conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId);
}
}
/// <summary>
/// 子观点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SubViewpointId
{
get
{
return mlngSubViewpointId;
}
set
{
 mlngSubViewpointId = value;
//记录修改过的字段
 AddUpdatedFld(conPaperSubViewpointAppraise.SubViewpointId);
}
}
/// <summary>
/// 打分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? AppraiseScore
{
get
{
return mfltAppraiseScore;
}
set
{
 mfltAppraiseScore = value;
//记录修改过的字段
 AddUpdatedFld(conPaperSubViewpointAppraise.AppraiseScore);
}
}
/// <summary>
/// 评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseContent
{
get
{
return mstrAppraiseContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseContent = value;
}
else
{
 mstrAppraiseContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperSubViewpointAppraise.AppraiseContent);
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
 AddUpdatedFld(conPaperSubViewpointAppraise.UpdDate);
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
 AddUpdatedFld(conPaperSubViewpointAppraise.Meno);
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
 AddUpdatedFld(conPaperSubViewpointAppraise.UpdUser);
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
  return mlngPaperSubViewpointAppraiseId.ToString();
 }
 }
}
 /// <summary>
 /// 子观点评论表(PaperSubViewpointAppraise)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperSubViewpointAppraise
{
public const string _CurrTabName = "PaperSubViewpointAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperSubViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperSubViewpointAppraiseId", "SubViewpointId", "AppraiseScore", "AppraiseContent", "UpdDate", "Meno", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperSubViewpointAppraiseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubViewpointAppraiseId = "PaperSubViewpointAppraiseId";    //子观点评价Id

 /// <summary>
 /// 常量:"SubViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointId = "SubViewpointId";    //子观点Id

 /// <summary>
 /// 常量:"AppraiseScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseScore = "AppraiseScore";    //打分

 /// <summary>
 /// 常量:"AppraiseContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseContent = "AppraiseContent";    //评议内容

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

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}