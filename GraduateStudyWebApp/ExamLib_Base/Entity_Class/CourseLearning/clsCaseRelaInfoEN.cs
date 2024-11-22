
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseRelaInfoEN
 表名:CaseRelaInfo(01120389)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:07:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表CaseRelaInfo的关键字(IdCaseRelaInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseRelaInfo_CaseRelaInfo
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdCaseRelaInfo">表关键字</param>
public K_IdCaseRelaInfo_CaseRelaInfo(long lngIdCaseRelaInfo)
{
if (IsValid(lngIdCaseRelaInfo)) Value = lngIdCaseRelaInfo;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdCaseRelaInfo)
{
if (lngIdCaseRelaInfo == 0) return false;
if (lngIdCaseRelaInfo == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCaseRelaInfo_CaseRelaInfo]类型的对象</returns>
public static implicit operator K_IdCaseRelaInfo_CaseRelaInfo(long value)
{
return new K_IdCaseRelaInfo_CaseRelaInfo(value);
}
}
 /// <summary>
 /// 案例相关信息(CaseRelaInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseRelaInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"IdCaseRelaInfo", "FuncModuleId1", "CaseId1", "CaseName1", "OwnerId1", "FuncModuleId2", "CaseId2", "CaseName2", "OwnerId2", "RelationsDegree", "IdCaseRelaInfoType", "BrowseCount", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdCaseRelaInfo;    //案例相关信息流水号
protected string mstrFuncModuleId1;    //功能模块Id1
protected string mstrCaseId1;    //案例Id1
protected string mstrCaseName1;    //案例名称1
protected string mstrOwnerId1;    //拥有者Id1
protected string mstrFuncModuleId2;    //功能模块Id2
protected string mstrCaseId2;    //案例Id2
protected string mstrCaseName2;    //案例名称2
protected string mstrOwnerId2;    //拥有者Id2
protected int mintRelationsDegree;    //关系度
protected string mstrIdCaseRelaInfoType;    //案例相关信息类型流水号
protected int mintBrowseCount;    //浏览次数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCaseRelaInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseRelaInfo");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdCaseRelaInfo">关键字:案例相关信息流水号</param>
public clsCaseRelaInfoEN(long lngIdCaseRelaInfo)
 {
 if (lngIdCaseRelaInfo  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdCaseRelaInfo = lngIdCaseRelaInfo;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseRelaInfo");
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
if (strAttributeName  ==  conCaseRelaInfo.IdCaseRelaInfo)
{
return mlngIdCaseRelaInfo;
}
else if (strAttributeName  ==  conCaseRelaInfo.FuncModuleId1)
{
return mstrFuncModuleId1;
}
else if (strAttributeName  ==  conCaseRelaInfo.CaseId1)
{
return mstrCaseId1;
}
else if (strAttributeName  ==  conCaseRelaInfo.CaseName1)
{
return mstrCaseName1;
}
else if (strAttributeName  ==  conCaseRelaInfo.OwnerId1)
{
return mstrOwnerId1;
}
else if (strAttributeName  ==  conCaseRelaInfo.FuncModuleId2)
{
return mstrFuncModuleId2;
}
else if (strAttributeName  ==  conCaseRelaInfo.CaseId2)
{
return mstrCaseId2;
}
else if (strAttributeName  ==  conCaseRelaInfo.CaseName2)
{
return mstrCaseName2;
}
else if (strAttributeName  ==  conCaseRelaInfo.OwnerId2)
{
return mstrOwnerId2;
}
else if (strAttributeName  ==  conCaseRelaInfo.RelationsDegree)
{
return mintRelationsDegree;
}
else if (strAttributeName  ==  conCaseRelaInfo.IdCaseRelaInfoType)
{
return mstrIdCaseRelaInfoType;
}
else if (strAttributeName  ==  conCaseRelaInfo.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conCaseRelaInfo.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCaseRelaInfo.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conCaseRelaInfo.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseRelaInfo.IdCaseRelaInfo)
{
mlngIdCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseRelaInfo.IdCaseRelaInfo);
}
else if (strAttributeName  ==  conCaseRelaInfo.FuncModuleId1)
{
mstrFuncModuleId1 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.FuncModuleId1);
}
else if (strAttributeName  ==  conCaseRelaInfo.CaseId1)
{
mstrCaseId1 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.CaseId1);
}
else if (strAttributeName  ==  conCaseRelaInfo.CaseName1)
{
mstrCaseName1 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.CaseName1);
}
else if (strAttributeName  ==  conCaseRelaInfo.OwnerId1)
{
mstrOwnerId1 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.OwnerId1);
}
else if (strAttributeName  ==  conCaseRelaInfo.FuncModuleId2)
{
mstrFuncModuleId2 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.FuncModuleId2);
}
else if (strAttributeName  ==  conCaseRelaInfo.CaseId2)
{
mstrCaseId2 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.CaseId2);
}
else if (strAttributeName  ==  conCaseRelaInfo.CaseName2)
{
mstrCaseName2 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.CaseName2);
}
else if (strAttributeName  ==  conCaseRelaInfo.OwnerId2)
{
mstrOwnerId2 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.OwnerId2);
}
else if (strAttributeName  ==  conCaseRelaInfo.RelationsDegree)
{
mintRelationsDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseRelaInfo.RelationsDegree);
}
else if (strAttributeName  ==  conCaseRelaInfo.IdCaseRelaInfoType)
{
mstrIdCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.IdCaseRelaInfoType);
}
else if (strAttributeName  ==  conCaseRelaInfo.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseRelaInfo.BrowseCount);
}
else if (strAttributeName  ==  conCaseRelaInfo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.UpdDate);
}
else if (strAttributeName  ==  conCaseRelaInfo.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.UpdUserId);
}
else if (strAttributeName  ==  conCaseRelaInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseRelaInfo.IdCaseRelaInfo  ==  AttributeName[intIndex])
{
return mlngIdCaseRelaInfo;
}
else if (conCaseRelaInfo.FuncModuleId1  ==  AttributeName[intIndex])
{
return mstrFuncModuleId1;
}
else if (conCaseRelaInfo.CaseId1  ==  AttributeName[intIndex])
{
return mstrCaseId1;
}
else if (conCaseRelaInfo.CaseName1  ==  AttributeName[intIndex])
{
return mstrCaseName1;
}
else if (conCaseRelaInfo.OwnerId1  ==  AttributeName[intIndex])
{
return mstrOwnerId1;
}
else if (conCaseRelaInfo.FuncModuleId2  ==  AttributeName[intIndex])
{
return mstrFuncModuleId2;
}
else if (conCaseRelaInfo.CaseId2  ==  AttributeName[intIndex])
{
return mstrCaseId2;
}
else if (conCaseRelaInfo.CaseName2  ==  AttributeName[intIndex])
{
return mstrCaseName2;
}
else if (conCaseRelaInfo.OwnerId2  ==  AttributeName[intIndex])
{
return mstrOwnerId2;
}
else if (conCaseRelaInfo.RelationsDegree  ==  AttributeName[intIndex])
{
return mintRelationsDegree;
}
else if (conCaseRelaInfo.IdCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdCaseRelaInfoType;
}
else if (conCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conCaseRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCaseRelaInfo.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseRelaInfo.IdCaseRelaInfo  ==  AttributeName[intIndex])
{
mlngIdCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseRelaInfo.IdCaseRelaInfo);
}
else if (conCaseRelaInfo.FuncModuleId1  ==  AttributeName[intIndex])
{
mstrFuncModuleId1 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.FuncModuleId1);
}
else if (conCaseRelaInfo.CaseId1  ==  AttributeName[intIndex])
{
mstrCaseId1 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.CaseId1);
}
else if (conCaseRelaInfo.CaseName1  ==  AttributeName[intIndex])
{
mstrCaseName1 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.CaseName1);
}
else if (conCaseRelaInfo.OwnerId1  ==  AttributeName[intIndex])
{
mstrOwnerId1 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.OwnerId1);
}
else if (conCaseRelaInfo.FuncModuleId2  ==  AttributeName[intIndex])
{
mstrFuncModuleId2 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.FuncModuleId2);
}
else if (conCaseRelaInfo.CaseId2  ==  AttributeName[intIndex])
{
mstrCaseId2 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.CaseId2);
}
else if (conCaseRelaInfo.CaseName2  ==  AttributeName[intIndex])
{
mstrCaseName2 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.CaseName2);
}
else if (conCaseRelaInfo.OwnerId2  ==  AttributeName[intIndex])
{
mstrOwnerId2 = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.OwnerId2);
}
else if (conCaseRelaInfo.RelationsDegree  ==  AttributeName[intIndex])
{
mintRelationsDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseRelaInfo.RelationsDegree);
}
else if (conCaseRelaInfo.IdCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.IdCaseRelaInfoType);
}
else if (conCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseRelaInfo.BrowseCount);
}
else if (conCaseRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.UpdDate);
}
else if (conCaseRelaInfo.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.UpdUserId);
}
else if (conCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseRelaInfo.Memo);
}
}
}

/// <summary>
/// 案例相关信息流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdCaseRelaInfo
{
get
{
return mlngIdCaseRelaInfo;
}
set
{
 mlngIdCaseRelaInfo = value;
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.IdCaseRelaInfo);
}
}
/// <summary>
/// 功能模块Id1(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId1
{
get
{
return mstrFuncModuleId1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId1 = value;
}
else
{
 mstrFuncModuleId1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.FuncModuleId1);
}
}
/// <summary>
/// 案例Id1(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseId1
{
get
{
return mstrCaseId1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseId1 = value;
}
else
{
 mstrCaseId1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.CaseId1);
}
}
/// <summary>
/// 案例名称1(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseName1
{
get
{
return mstrCaseName1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseName1 = value;
}
else
{
 mstrCaseName1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.CaseName1);
}
}
/// <summary>
/// 拥有者Id1(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerId1
{
get
{
return mstrOwnerId1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerId1 = value;
}
else
{
 mstrOwnerId1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.OwnerId1);
}
}
/// <summary>
/// 功能模块Id2(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId2
{
get
{
return mstrFuncModuleId2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId2 = value;
}
else
{
 mstrFuncModuleId2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.FuncModuleId2);
}
}
/// <summary>
/// 案例Id2(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseId2
{
get
{
return mstrCaseId2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseId2 = value;
}
else
{
 mstrCaseId2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.CaseId2);
}
}
/// <summary>
/// 案例名称2(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseName2
{
get
{
return mstrCaseName2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseName2 = value;
}
else
{
 mstrCaseName2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.CaseName2);
}
}
/// <summary>
/// 拥有者Id2(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerId2
{
get
{
return mstrOwnerId2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerId2 = value;
}
else
{
 mstrOwnerId2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.OwnerId2);
}
}
/// <summary>
/// 关系度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int RelationsDegree
{
get
{
return mintRelationsDegree;
}
set
{
 mintRelationsDegree = value;
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.RelationsDegree);
}
}
/// <summary>
/// 案例相关信息类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseRelaInfoType
{
get
{
return mstrIdCaseRelaInfoType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseRelaInfoType = value;
}
else
{
 mstrIdCaseRelaInfoType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.IdCaseRelaInfoType);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(conCaseRelaInfo.BrowseCount);
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
 AddUpdatedFld(conCaseRelaInfo.UpdDate);
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
 AddUpdatedFld(conCaseRelaInfo.UpdUserId);
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
 AddUpdatedFld(conCaseRelaInfo.Memo);
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
  return mlngIdCaseRelaInfo.ToString();
 }
 }
}
 /// <summary>
 /// 案例相关信息(CaseRelaInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseRelaInfo
{
public const string _CurrTabName = "CaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseRelaInfo", "FuncModuleId1", "CaseId1", "CaseName1", "OwnerId1", "FuncModuleId2", "CaseId2", "CaseName2", "OwnerId2", "RelationsDegree", "IdCaseRelaInfoType", "BrowseCount", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCaseRelaInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseRelaInfo = "IdCaseRelaInfo";    //案例相关信息流水号

 /// <summary>
 /// 常量:"FuncModuleId1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId1 = "FuncModuleId1";    //功能模块Id1

 /// <summary>
 /// 常量:"CaseId1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseId1 = "CaseId1";    //案例Id1

 /// <summary>
 /// 常量:"CaseName1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseName1 = "CaseName1";    //案例名称1

 /// <summary>
 /// 常量:"OwnerId1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId1 = "OwnerId1";    //拥有者Id1

 /// <summary>
 /// 常量:"FuncModuleId2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId2 = "FuncModuleId2";    //功能模块Id2

 /// <summary>
 /// 常量:"CaseId2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseId2 = "CaseId2";    //案例Id2

 /// <summary>
 /// 常量:"CaseName2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseName2 = "CaseName2";    //案例名称2

 /// <summary>
 /// 常量:"OwnerId2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId2 = "OwnerId2";    //拥有者Id2

 /// <summary>
 /// 常量:"RelationsDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationsDegree = "RelationsDegree";    //关系度

 /// <summary>
 /// 常量:"IdCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseRelaInfoType = "IdCaseRelaInfoType";    //案例相关信息类型流水号

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}