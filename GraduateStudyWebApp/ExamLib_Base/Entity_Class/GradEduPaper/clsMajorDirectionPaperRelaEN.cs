
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMajorDirectionPaperRelaEN
 表名:MajorDirectionPaperRela(01120554)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:01
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
 /// 表MajorDirectionPaperRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_MajorDirectionPaperRela
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
public K_mId_MajorDirectionPaperRela(long lngmId)
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
 /// <returns>返回:[K_mId_MajorDirectionPaperRela]类型的对象</returns>
public static implicit operator K_mId_MajorDirectionPaperRela(long value)
{
return new K_mId_MajorDirectionPaperRela(value);
}
}
 /// <summary>
 /// 专业方向论文关系(MajorDirectionPaperRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMajorDirectionPaperRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MajorDirectionPaperRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "MajorDirectionId in (select MajorDirectionId From XzMajorDirection where id_Major='{0}')"; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"mId", "MajorDirectionId", "PaperId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrMajorDirectionId;    //研究方向Id
protected string mstrPaperId;    //论文Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMajorDirectionPaperRelaEN()
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
public clsMajorDirectionPaperRelaEN(long lngmId)
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
if (strAttributeName  ==  conMajorDirectionPaperRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conMajorDirectionPaperRela.MajorDirectionId)
{
return mstrMajorDirectionId;
}
else if (strAttributeName  ==  conMajorDirectionPaperRela.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conMajorDirectionPaperRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conMajorDirectionPaperRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conMajorDirectionPaperRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conMajorDirectionPaperRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conMajorDirectionPaperRela.mId);
}
else if (strAttributeName  ==  conMajorDirectionPaperRela.MajorDirectionId)
{
mstrMajorDirectionId = value.ToString();
 AddUpdatedFld(conMajorDirectionPaperRela.MajorDirectionId);
}
else if (strAttributeName  ==  conMajorDirectionPaperRela.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conMajorDirectionPaperRela.PaperId);
}
else if (strAttributeName  ==  conMajorDirectionPaperRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conMajorDirectionPaperRela.UpdDate);
}
else if (strAttributeName  ==  conMajorDirectionPaperRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conMajorDirectionPaperRela.UpdUser);
}
else if (strAttributeName  ==  conMajorDirectionPaperRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMajorDirectionPaperRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conMajorDirectionPaperRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conMajorDirectionPaperRela.MajorDirectionId  ==  AttributeName[intIndex])
{
return mstrMajorDirectionId;
}
else if (conMajorDirectionPaperRela.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conMajorDirectionPaperRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conMajorDirectionPaperRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conMajorDirectionPaperRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conMajorDirectionPaperRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conMajorDirectionPaperRela.mId);
}
else if (conMajorDirectionPaperRela.MajorDirectionId  ==  AttributeName[intIndex])
{
mstrMajorDirectionId = value.ToString();
 AddUpdatedFld(conMajorDirectionPaperRela.MajorDirectionId);
}
else if (conMajorDirectionPaperRela.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conMajorDirectionPaperRela.PaperId);
}
else if (conMajorDirectionPaperRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conMajorDirectionPaperRela.UpdDate);
}
else if (conMajorDirectionPaperRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conMajorDirectionPaperRela.UpdUser);
}
else if (conMajorDirectionPaperRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMajorDirectionPaperRela.Memo);
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
 AddUpdatedFld(conMajorDirectionPaperRela.mId);
}
}
/// <summary>
/// 研究方向Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionId
{
get
{
return mstrMajorDirectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionId = value;
}
else
{
 mstrMajorDirectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conMajorDirectionPaperRela.MajorDirectionId);
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
 AddUpdatedFld(conMajorDirectionPaperRela.PaperId);
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
 AddUpdatedFld(conMajorDirectionPaperRela.UpdDate);
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
 AddUpdatedFld(conMajorDirectionPaperRela.UpdUser);
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
 AddUpdatedFld(conMajorDirectionPaperRela.Memo);
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
 /// 专业方向论文关系(MajorDirectionPaperRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMajorDirectionPaperRela
{
public const string _CurrTabName = "MajorDirectionPaperRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "MajorDirectionId", "PaperId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"MajorDirectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionId = "MajorDirectionId";    //研究方向Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

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