
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperAppraiseEN
 表名:PaperAppraise(01120567)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:27
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
 /// 表PaperAppraise的关键字(PaperAppraiseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperAppraiseId_PaperAppraise
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperAppraiseId">表关键字</param>
public K_PaperAppraiseId_PaperAppraise(long lngPaperAppraiseId)
{
if (IsValid(lngPaperAppraiseId)) Value = lngPaperAppraiseId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperAppraiseId)
{
if (lngPaperAppraiseId == 0) return false;
if (lngPaperAppraiseId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperAppraiseId_PaperAppraise]类型的对象</returns>
public static implicit operator K_PaperAppraiseId_PaperAppraise(long value)
{
return new K_PaperAppraiseId_PaperAppraise(value);
}
}
 /// <summary>
 /// 论文评论表(PaperAppraise)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperAppraiseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"PaperAppraiseId", "PaperAppraiseContent", "AppraiseScore", "PaperId", "UpdUser", "UpdDate", "Memo"};

protected long mlngPaperAppraiseId;    //论文评论Id
protected string mstrPaperAppraiseContent;    //论文评论内容
protected float? mfltAppraiseScore;    //打分
protected string mstrPaperId;    //论文Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperAppraiseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperAppraiseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperAppraiseId">关键字:论文评论Id</param>
public clsPaperAppraiseEN(long lngPaperAppraiseId)
 {
 if (lngPaperAppraiseId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperAppraiseId = lngPaperAppraiseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperAppraiseId");
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
if (strAttributeName  ==  conPaperAppraise.PaperAppraiseId)
{
return mlngPaperAppraiseId;
}
else if (strAttributeName  ==  conPaperAppraise.PaperAppraiseContent)
{
return mstrPaperAppraiseContent;
}
else if (strAttributeName  ==  conPaperAppraise.AppraiseScore)
{
return mfltAppraiseScore;
}
else if (strAttributeName  ==  conPaperAppraise.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conPaperAppraise.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPaperAppraise.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperAppraise.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperAppraise.PaperAppraiseId)
{
mlngPaperAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperAppraise.PaperAppraiseId);
}
else if (strAttributeName  ==  conPaperAppraise.PaperAppraiseContent)
{
mstrPaperAppraiseContent = value.ToString();
 AddUpdatedFld(conPaperAppraise.PaperAppraiseContent);
}
else if (strAttributeName  ==  conPaperAppraise.AppraiseScore)
{
mfltAppraiseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaperAppraise.AppraiseScore);
}
else if (strAttributeName  ==  conPaperAppraise.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperAppraise.PaperId);
}
else if (strAttributeName  ==  conPaperAppraise.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperAppraise.UpdUser);
}
else if (strAttributeName  ==  conPaperAppraise.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperAppraise.UpdDate);
}
else if (strAttributeName  ==  conPaperAppraise.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperAppraise.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperAppraise.PaperAppraiseId  ==  AttributeName[intIndex])
{
return mlngPaperAppraiseId;
}
else if (conPaperAppraise.PaperAppraiseContent  ==  AttributeName[intIndex])
{
return mstrPaperAppraiseContent;
}
else if (conPaperAppraise.AppraiseScore  ==  AttributeName[intIndex])
{
return mfltAppraiseScore;
}
else if (conPaperAppraise.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conPaperAppraise.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPaperAppraise.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperAppraise.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPaperAppraise.PaperAppraiseId  ==  AttributeName[intIndex])
{
mlngPaperAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperAppraise.PaperAppraiseId);
}
else if (conPaperAppraise.PaperAppraiseContent  ==  AttributeName[intIndex])
{
mstrPaperAppraiseContent = value.ToString();
 AddUpdatedFld(conPaperAppraise.PaperAppraiseContent);
}
else if (conPaperAppraise.AppraiseScore  ==  AttributeName[intIndex])
{
mfltAppraiseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaperAppraise.AppraiseScore);
}
else if (conPaperAppraise.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperAppraise.PaperId);
}
else if (conPaperAppraise.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperAppraise.UpdUser);
}
else if (conPaperAppraise.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperAppraise.UpdDate);
}
else if (conPaperAppraise.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperAppraise.Memo);
}
}
}

/// <summary>
/// 论文评论Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperAppraiseId
{
get
{
return mlngPaperAppraiseId;
}
set
{
 mlngPaperAppraiseId = value;
//记录修改过的字段
 AddUpdatedFld(conPaperAppraise.PaperAppraiseId);
}
}
/// <summary>
/// 论文评论内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperAppraiseContent
{
get
{
return mstrPaperAppraiseContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperAppraiseContent = value;
}
else
{
 mstrPaperAppraiseContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperAppraise.PaperAppraiseContent);
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
 AddUpdatedFld(conPaperAppraise.AppraiseScore);
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
 AddUpdatedFld(conPaperAppraise.PaperId);
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
 AddUpdatedFld(conPaperAppraise.UpdUser);
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
 AddUpdatedFld(conPaperAppraise.UpdDate);
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
 AddUpdatedFld(conPaperAppraise.Memo);
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
  return mlngPaperAppraiseId.ToString();
 }
 }
}
 /// <summary>
 /// 论文评论表(PaperAppraise)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperAppraise
{
public const string _CurrTabName = "PaperAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperAppraiseId", "PaperAppraiseContent", "AppraiseScore", "PaperId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperAppraiseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperAppraiseId = "PaperAppraiseId";    //论文评论Id

 /// <summary>
 /// 常量:"PaperAppraiseContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperAppraiseContent = "PaperAppraiseContent";    //论文评论内容

 /// <summary>
 /// 常量:"AppraiseScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseScore = "AppraiseScore";    //打分

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

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