
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseRelaInfoEN
 表名:vCaseRelaInfo(01120390)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:43
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
 /// 表vCaseRelaInfo的关键字(IdCaseRelaInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseRelaInfo_vCaseRelaInfo
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
public K_IdCaseRelaInfo_vCaseRelaInfo(long lngIdCaseRelaInfo)
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
 /// <returns>返回:[K_IdCaseRelaInfo_vCaseRelaInfo]类型的对象</returns>
public static implicit operator K_IdCaseRelaInfo_vCaseRelaInfo(long value)
{
return new K_IdCaseRelaInfo_vCaseRelaInfo(value);
}
}
 /// <summary>
 /// v案例相关信息(vCaseRelaInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCaseRelaInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"IdCaseRelaInfo", "FuncModuleId1", "FuncModuleName1", "CaseId1", "CaseName1", "OwnerId1", "OwnerName1", "FuncModuleId2", "FuncModuleName2", "CaseId2", "CaseName2", "OwnerId2", "OwnerName2", "IdCaseRelaInfoType", "CaseRelaInfoTypeName", "RelationsDegree", "BrowseCount", "UpdUserId", "UpdDate", "Memo"};

protected long mlngIdCaseRelaInfo;    //案例相关信息流水号
protected string mstrFuncModuleId1;    //功能模块Id1
protected string mstrFuncModuleName1;    //功能模块名称1
protected string mstrCaseId1;    //案例Id1
protected string mstrCaseName1;    //案例名称1
protected string mstrOwnerId1;    //拥有者Id1
protected string mstrOwnerName1;    //拥有者姓名1
protected string mstrFuncModuleId2;    //功能模块Id2
protected string mstrFuncModuleName2;    //功能模块名称2
protected string mstrCaseId2;    //案例Id2
protected string mstrCaseName2;    //案例名称2
protected string mstrOwnerId2;    //拥有者Id2
protected string mstrOwnerName2;    //拥有者姓名2
protected string mstrIdCaseRelaInfoType;    //案例相关信息类型流水号
protected string mstrCaseRelaInfoTypeName;    //案例相关信息类型名称
protected int mintRelationsDegree;    //关系度
protected int? mintBrowseCount;    //浏览次数
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCaseRelaInfoEN()
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
public clsvCaseRelaInfoEN(long lngIdCaseRelaInfo)
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
if (strAttributeName  ==  convCaseRelaInfo.IdCaseRelaInfo)
{
return mlngIdCaseRelaInfo;
}
else if (strAttributeName  ==  convCaseRelaInfo.FuncModuleId1)
{
return mstrFuncModuleId1;
}
else if (strAttributeName  ==  convCaseRelaInfo.FuncModuleName1)
{
return mstrFuncModuleName1;
}
else if (strAttributeName  ==  convCaseRelaInfo.CaseId1)
{
return mstrCaseId1;
}
else if (strAttributeName  ==  convCaseRelaInfo.CaseName1)
{
return mstrCaseName1;
}
else if (strAttributeName  ==  convCaseRelaInfo.OwnerId1)
{
return mstrOwnerId1;
}
else if (strAttributeName  ==  convCaseRelaInfo.OwnerName1)
{
return mstrOwnerName1;
}
else if (strAttributeName  ==  convCaseRelaInfo.FuncModuleId2)
{
return mstrFuncModuleId2;
}
else if (strAttributeName  ==  convCaseRelaInfo.FuncModuleName2)
{
return mstrFuncModuleName2;
}
else if (strAttributeName  ==  convCaseRelaInfo.CaseId2)
{
return mstrCaseId2;
}
else if (strAttributeName  ==  convCaseRelaInfo.CaseName2)
{
return mstrCaseName2;
}
else if (strAttributeName  ==  convCaseRelaInfo.OwnerId2)
{
return mstrOwnerId2;
}
else if (strAttributeName  ==  convCaseRelaInfo.OwnerName2)
{
return mstrOwnerName2;
}
else if (strAttributeName  ==  convCaseRelaInfo.IdCaseRelaInfoType)
{
return mstrIdCaseRelaInfoType;
}
else if (strAttributeName  ==  convCaseRelaInfo.CaseRelaInfoTypeName)
{
return mstrCaseRelaInfoTypeName;
}
else if (strAttributeName  ==  convCaseRelaInfo.RelationsDegree)
{
return mintRelationsDegree;
}
else if (strAttributeName  ==  convCaseRelaInfo.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convCaseRelaInfo.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convCaseRelaInfo.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCaseRelaInfo.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCaseRelaInfo.IdCaseRelaInfo)
{
mlngIdCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseRelaInfo.IdCaseRelaInfo);
}
else if (strAttributeName  ==  convCaseRelaInfo.FuncModuleId1)
{
mstrFuncModuleId1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.FuncModuleId1);
}
else if (strAttributeName  ==  convCaseRelaInfo.FuncModuleName1)
{
mstrFuncModuleName1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.FuncModuleName1);
}
else if (strAttributeName  ==  convCaseRelaInfo.CaseId1)
{
mstrCaseId1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.CaseId1);
}
else if (strAttributeName  ==  convCaseRelaInfo.CaseName1)
{
mstrCaseName1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.CaseName1);
}
else if (strAttributeName  ==  convCaseRelaInfo.OwnerId1)
{
mstrOwnerId1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.OwnerId1);
}
else if (strAttributeName  ==  convCaseRelaInfo.OwnerName1)
{
mstrOwnerName1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.OwnerName1);
}
else if (strAttributeName  ==  convCaseRelaInfo.FuncModuleId2)
{
mstrFuncModuleId2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.FuncModuleId2);
}
else if (strAttributeName  ==  convCaseRelaInfo.FuncModuleName2)
{
mstrFuncModuleName2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.FuncModuleName2);
}
else if (strAttributeName  ==  convCaseRelaInfo.CaseId2)
{
mstrCaseId2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.CaseId2);
}
else if (strAttributeName  ==  convCaseRelaInfo.CaseName2)
{
mstrCaseName2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.CaseName2);
}
else if (strAttributeName  ==  convCaseRelaInfo.OwnerId2)
{
mstrOwnerId2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.OwnerId2);
}
else if (strAttributeName  ==  convCaseRelaInfo.OwnerName2)
{
mstrOwnerName2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.OwnerName2);
}
else if (strAttributeName  ==  convCaseRelaInfo.IdCaseRelaInfoType)
{
mstrIdCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.IdCaseRelaInfoType);
}
else if (strAttributeName  ==  convCaseRelaInfo.CaseRelaInfoTypeName)
{
mstrCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.CaseRelaInfoTypeName);
}
else if (strAttributeName  ==  convCaseRelaInfo.RelationsDegree)
{
mintRelationsDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseRelaInfo.RelationsDegree);
}
else if (strAttributeName  ==  convCaseRelaInfo.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseRelaInfo.BrowseCount);
}
else if (strAttributeName  ==  convCaseRelaInfo.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.UpdUserId);
}
else if (strAttributeName  ==  convCaseRelaInfo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.UpdDate);
}
else if (strAttributeName  ==  convCaseRelaInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCaseRelaInfo.IdCaseRelaInfo  ==  AttributeName[intIndex])
{
return mlngIdCaseRelaInfo;
}
else if (convCaseRelaInfo.FuncModuleId1  ==  AttributeName[intIndex])
{
return mstrFuncModuleId1;
}
else if (convCaseRelaInfo.FuncModuleName1  ==  AttributeName[intIndex])
{
return mstrFuncModuleName1;
}
else if (convCaseRelaInfo.CaseId1  ==  AttributeName[intIndex])
{
return mstrCaseId1;
}
else if (convCaseRelaInfo.CaseName1  ==  AttributeName[intIndex])
{
return mstrCaseName1;
}
else if (convCaseRelaInfo.OwnerId1  ==  AttributeName[intIndex])
{
return mstrOwnerId1;
}
else if (convCaseRelaInfo.OwnerName1  ==  AttributeName[intIndex])
{
return mstrOwnerName1;
}
else if (convCaseRelaInfo.FuncModuleId2  ==  AttributeName[intIndex])
{
return mstrFuncModuleId2;
}
else if (convCaseRelaInfo.FuncModuleName2  ==  AttributeName[intIndex])
{
return mstrFuncModuleName2;
}
else if (convCaseRelaInfo.CaseId2  ==  AttributeName[intIndex])
{
return mstrCaseId2;
}
else if (convCaseRelaInfo.CaseName2  ==  AttributeName[intIndex])
{
return mstrCaseName2;
}
else if (convCaseRelaInfo.OwnerId2  ==  AttributeName[intIndex])
{
return mstrOwnerId2;
}
else if (convCaseRelaInfo.OwnerName2  ==  AttributeName[intIndex])
{
return mstrOwnerName2;
}
else if (convCaseRelaInfo.IdCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdCaseRelaInfoType;
}
else if (convCaseRelaInfo.CaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
return mstrCaseRelaInfoTypeName;
}
else if (convCaseRelaInfo.RelationsDegree  ==  AttributeName[intIndex])
{
return mintRelationsDegree;
}
else if (convCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convCaseRelaInfo.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convCaseRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCaseRelaInfo.IdCaseRelaInfo  ==  AttributeName[intIndex])
{
mlngIdCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseRelaInfo.IdCaseRelaInfo);
}
else if (convCaseRelaInfo.FuncModuleId1  ==  AttributeName[intIndex])
{
mstrFuncModuleId1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.FuncModuleId1);
}
else if (convCaseRelaInfo.FuncModuleName1  ==  AttributeName[intIndex])
{
mstrFuncModuleName1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.FuncModuleName1);
}
else if (convCaseRelaInfo.CaseId1  ==  AttributeName[intIndex])
{
mstrCaseId1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.CaseId1);
}
else if (convCaseRelaInfo.CaseName1  ==  AttributeName[intIndex])
{
mstrCaseName1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.CaseName1);
}
else if (convCaseRelaInfo.OwnerId1  ==  AttributeName[intIndex])
{
mstrOwnerId1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.OwnerId1);
}
else if (convCaseRelaInfo.OwnerName1  ==  AttributeName[intIndex])
{
mstrOwnerName1 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.OwnerName1);
}
else if (convCaseRelaInfo.FuncModuleId2  ==  AttributeName[intIndex])
{
mstrFuncModuleId2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.FuncModuleId2);
}
else if (convCaseRelaInfo.FuncModuleName2  ==  AttributeName[intIndex])
{
mstrFuncModuleName2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.FuncModuleName2);
}
else if (convCaseRelaInfo.CaseId2  ==  AttributeName[intIndex])
{
mstrCaseId2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.CaseId2);
}
else if (convCaseRelaInfo.CaseName2  ==  AttributeName[intIndex])
{
mstrCaseName2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.CaseName2);
}
else if (convCaseRelaInfo.OwnerId2  ==  AttributeName[intIndex])
{
mstrOwnerId2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.OwnerId2);
}
else if (convCaseRelaInfo.OwnerName2  ==  AttributeName[intIndex])
{
mstrOwnerName2 = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.OwnerName2);
}
else if (convCaseRelaInfo.IdCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.IdCaseRelaInfoType);
}
else if (convCaseRelaInfo.CaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
mstrCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.CaseRelaInfoTypeName);
}
else if (convCaseRelaInfo.RelationsDegree  ==  AttributeName[intIndex])
{
mintRelationsDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseRelaInfo.RelationsDegree);
}
else if (convCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseRelaInfo.BrowseCount);
}
else if (convCaseRelaInfo.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.UpdUserId);
}
else if (convCaseRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.UpdDate);
}
else if (convCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseRelaInfo.Memo);
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
 AddUpdatedFld(convCaseRelaInfo.IdCaseRelaInfo);
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
 AddUpdatedFld(convCaseRelaInfo.FuncModuleId1);
}
}
/// <summary>
/// 功能模块名称1(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName1
{
get
{
return mstrFuncModuleName1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName1 = value;
}
else
{
 mstrFuncModuleName1 = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseRelaInfo.FuncModuleName1);
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
 AddUpdatedFld(convCaseRelaInfo.CaseId1);
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
 AddUpdatedFld(convCaseRelaInfo.CaseName1);
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
 AddUpdatedFld(convCaseRelaInfo.OwnerId1);
}
}
/// <summary>
/// 拥有者姓名1(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerName1
{
get
{
return mstrOwnerName1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerName1 = value;
}
else
{
 mstrOwnerName1 = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseRelaInfo.OwnerName1);
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
 AddUpdatedFld(convCaseRelaInfo.FuncModuleId2);
}
}
/// <summary>
/// 功能模块名称2(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName2
{
get
{
return mstrFuncModuleName2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName2 = value;
}
else
{
 mstrFuncModuleName2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseRelaInfo.FuncModuleName2);
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
 AddUpdatedFld(convCaseRelaInfo.CaseId2);
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
 AddUpdatedFld(convCaseRelaInfo.CaseName2);
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
 AddUpdatedFld(convCaseRelaInfo.OwnerId2);
}
}
/// <summary>
/// 拥有者姓名2(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerName2
{
get
{
return mstrOwnerName2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerName2 = value;
}
else
{
 mstrOwnerName2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseRelaInfo.OwnerName2);
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
 AddUpdatedFld(convCaseRelaInfo.IdCaseRelaInfoType);
}
}
/// <summary>
/// 案例相关信息类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseRelaInfoTypeName
{
get
{
return mstrCaseRelaInfoTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseRelaInfoTypeName = value;
}
else
{
 mstrCaseRelaInfoTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseRelaInfo.CaseRelaInfoTypeName);
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
 AddUpdatedFld(convCaseRelaInfo.RelationsDegree);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(convCaseRelaInfo.BrowseCount);
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
 AddUpdatedFld(convCaseRelaInfo.UpdUserId);
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
 AddUpdatedFld(convCaseRelaInfo.UpdDate);
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
 AddUpdatedFld(convCaseRelaInfo.Memo);
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
 /// v案例相关信息(vCaseRelaInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCaseRelaInfo
{
public const string _CurrTabName = "vCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseRelaInfo", "FuncModuleId1", "FuncModuleName1", "CaseId1", "CaseName1", "OwnerId1", "OwnerName1", "FuncModuleId2", "FuncModuleName2", "CaseId2", "CaseName2", "OwnerId2", "OwnerName2", "IdCaseRelaInfoType", "CaseRelaInfoTypeName", "RelationsDegree", "BrowseCount", "UpdUserId", "UpdDate", "Memo"};
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
 /// 常量:"FuncModuleName1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName1 = "FuncModuleName1";    //功能模块名称1

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
 /// 常量:"OwnerName1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName1 = "OwnerName1";    //拥有者姓名1

 /// <summary>
 /// 常量:"FuncModuleId2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId2 = "FuncModuleId2";    //功能模块Id2

 /// <summary>
 /// 常量:"FuncModuleName2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName2 = "FuncModuleName2";    //功能模块名称2

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
 /// 常量:"OwnerName2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName2 = "OwnerName2";    //拥有者姓名2

 /// <summary>
 /// 常量:"IdCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseRelaInfoType = "IdCaseRelaInfoType";    //案例相关信息类型流水号

 /// <summary>
 /// 常量:"CaseRelaInfoTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseRelaInfoTypeName = "CaseRelaInfoTypeName";    //案例相关信息类型名称

 /// <summary>
 /// 常量:"RelationsDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationsDegree = "RelationsDegree";    //关系度

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

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
}

}