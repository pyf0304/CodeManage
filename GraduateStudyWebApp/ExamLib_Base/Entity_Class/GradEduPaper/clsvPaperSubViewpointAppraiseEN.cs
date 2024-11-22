
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubViewpointAppraiseEN
 表名:vPaperSubViewpointAppraise(01120562)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表vPaperSubViewpointAppraise的关键字(PaperSubViewpointAppraiseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperSubViewpointAppraiseId_vPaperSubViewpointAppraise
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
public K_PaperSubViewpointAppraiseId_vPaperSubViewpointAppraise(long lngPaperSubViewpointAppraiseId)
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
 /// <returns>返回:[K_PaperSubViewpointAppraiseId_vPaperSubViewpointAppraise]类型的对象</returns>
public static implicit operator K_PaperSubViewpointAppraiseId_vPaperSubViewpointAppraise(long value)
{
return new K_PaperSubViewpointAppraiseId_vPaperSubViewpointAppraise(value);
}
}
 /// <summary>
 /// v子观点评论表(vPaperSubViewpointAppraise)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperSubViewpointAppraiseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperSubViewpointAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperSubViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"PaperSubViewpointAppraiseId", "SubViewpointId", "AppraiseScore", "AppraiseContent", "UpdDate", "Meno", "RWTitle", "SubViewpointContent", "ExplainContent", "PaperRWId", "UpdUser"};

protected long mlngPaperSubViewpointAppraiseId;    //子观点评价Id
protected long mlngSubViewpointId;    //子观点Id
protected float? mfltAppraiseScore;    //打分
protected string mstrAppraiseContent;    //评议内容
protected string mstrUpdDate;    //修改日期
protected string mstrMeno;    //备注
protected string mstrRWTitle;    //读写标题
protected string mstrSubViewpointContent;    //详情内容
protected string mstrExplainContent;    //说明内容
protected string mstrPaperRWId;    //课文阅读
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperSubViewpointAppraiseEN()
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
public clsvPaperSubViewpointAppraiseEN(long lngPaperSubViewpointAppraiseId)
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
if (strAttributeName  ==  convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId)
{
return mlngPaperSubViewpointAppraiseId;
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.SubViewpointId)
{
return mlngSubViewpointId;
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.AppraiseScore)
{
return mfltAppraiseScore;
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.AppraiseContent)
{
return mstrAppraiseContent;
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.Meno)
{
return mstrMeno;
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.RWTitle)
{
return mstrRWTitle;
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.SubViewpointContent)
{
return mstrSubViewpointContent;
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.ExplainContent)
{
return mstrExplainContent;
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.PaperRWId)
{
return mstrPaperRWId;
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId)
{
mlngPaperSubViewpointAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId);
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.SubViewpointId)
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpointAppraise.SubViewpointId);
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.AppraiseScore)
{
mfltAppraiseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSubViewpointAppraise.AppraiseScore);
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.AppraiseContent)
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.AppraiseContent);
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.UpdDate);
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.Meno)
{
mstrMeno = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.Meno);
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.RWTitle)
{
mstrRWTitle = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.RWTitle);
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.SubViewpointContent)
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.SubViewpointContent);
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.ExplainContent)
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.ExplainContent);
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.PaperRWId)
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.PaperRWId);
}
else if (strAttributeName  ==  convPaperSubViewpointAppraise.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId  ==  AttributeName[intIndex])
{
return mlngPaperSubViewpointAppraiseId;
}
else if (convPaperSubViewpointAppraise.SubViewpointId  ==  AttributeName[intIndex])
{
return mlngSubViewpointId;
}
else if (convPaperSubViewpointAppraise.AppraiseScore  ==  AttributeName[intIndex])
{
return mfltAppraiseScore;
}
else if (convPaperSubViewpointAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
return mstrAppraiseContent;
}
else if (convPaperSubViewpointAppraise.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaperSubViewpointAppraise.Meno  ==  AttributeName[intIndex])
{
return mstrMeno;
}
else if (convPaperSubViewpointAppraise.RWTitle  ==  AttributeName[intIndex])
{
return mstrRWTitle;
}
else if (convPaperSubViewpointAppraise.SubViewpointContent  ==  AttributeName[intIndex])
{
return mstrSubViewpointContent;
}
else if (convPaperSubViewpointAppraise.ExplainContent  ==  AttributeName[intIndex])
{
return mstrExplainContent;
}
else if (convPaperSubViewpointAppraise.PaperRWId  ==  AttributeName[intIndex])
{
return mstrPaperRWId;
}
else if (convPaperSubViewpointAppraise.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId  ==  AttributeName[intIndex])
{
mlngPaperSubViewpointAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId);
}
else if (convPaperSubViewpointAppraise.SubViewpointId  ==  AttributeName[intIndex])
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpointAppraise.SubViewpointId);
}
else if (convPaperSubViewpointAppraise.AppraiseScore  ==  AttributeName[intIndex])
{
mfltAppraiseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSubViewpointAppraise.AppraiseScore);
}
else if (convPaperSubViewpointAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.AppraiseContent);
}
else if (convPaperSubViewpointAppraise.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.UpdDate);
}
else if (convPaperSubViewpointAppraise.Meno  ==  AttributeName[intIndex])
{
mstrMeno = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.Meno);
}
else if (convPaperSubViewpointAppraise.RWTitle  ==  AttributeName[intIndex])
{
mstrRWTitle = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.RWTitle);
}
else if (convPaperSubViewpointAppraise.SubViewpointContent  ==  AttributeName[intIndex])
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.SubViewpointContent);
}
else if (convPaperSubViewpointAppraise.ExplainContent  ==  AttributeName[intIndex])
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.ExplainContent);
}
else if (convPaperSubViewpointAppraise.PaperRWId  ==  AttributeName[intIndex])
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.PaperRWId);
}
else if (convPaperSubViewpointAppraise.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperSubViewpointAppraise.UpdUser);
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
 AddUpdatedFld(convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId);
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
 AddUpdatedFld(convPaperSubViewpointAppraise.SubViewpointId);
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
 AddUpdatedFld(convPaperSubViewpointAppraise.AppraiseScore);
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
 AddUpdatedFld(convPaperSubViewpointAppraise.AppraiseContent);
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
 AddUpdatedFld(convPaperSubViewpointAppraise.UpdDate);
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
 AddUpdatedFld(convPaperSubViewpointAppraise.Meno);
}
}
/// <summary>
/// 读写标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RWTitle
{
get
{
return mstrRWTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRWTitle = value;
}
else
{
 mstrRWTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpointAppraise.RWTitle);
}
}
/// <summary>
/// 详情内容(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubViewpointContent
{
get
{
return mstrSubViewpointContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubViewpointContent = value;
}
else
{
 mstrSubViewpointContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpointAppraise.SubViewpointContent);
}
}
/// <summary>
/// 说明内容(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExplainContent
{
get
{
return mstrExplainContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExplainContent = value;
}
else
{
 mstrExplainContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpointAppraise.ExplainContent);
}
}
/// <summary>
/// 课文阅读(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperRWId
{
get
{
return mstrPaperRWId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperRWId = value;
}
else
{
 mstrPaperRWId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpointAppraise.PaperRWId);
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
 AddUpdatedFld(convPaperSubViewpointAppraise.UpdUser);
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
 /// v子观点评论表(vPaperSubViewpointAppraise)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperSubViewpointAppraise
{
public const string _CurrTabName = "vPaperSubViewpointAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperSubViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperSubViewpointAppraiseId", "SubViewpointId", "AppraiseScore", "AppraiseContent", "UpdDate", "Meno", "RWTitle", "SubViewpointContent", "ExplainContent", "PaperRWId", "UpdUser"};
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
 /// 常量:"RWTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RWTitle = "RWTitle";    //读写标题

 /// <summary>
 /// 常量:"SubViewpointContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointContent = "SubViewpointContent";    //详情内容

 /// <summary>
 /// 常量:"ExplainContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExplainContent = "ExplainContent";    //说明内容

 /// <summary>
 /// 常量:"PaperRWId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperRWId = "PaperRWId";    //课文阅读

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}