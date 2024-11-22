
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseAddiSiteRela_YTCaseEN
 表名:vCaseAddiSiteRela_YTCase(01120518)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:附加网站(AddiSite)
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
 /// 表vCaseAddiSiteRela_YTCase的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vCaseAddiSiteRela_YTCase
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
public K_mId_vCaseAddiSiteRela_YTCase(long lngmId)
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
 /// <returns>返回:[K_mId_vCaseAddiSiteRela_YTCase]类型的对象</returns>
public static implicit operator K_mId_vCaseAddiSiteRela_YTCase(long value)
{
return new K_mId_vCaseAddiSiteRela_YTCase(value);
}
}
 /// <summary>
 /// v案例和附加网站关系_青教评优(vCaseAddiSiteRela_YTCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCaseAddiSiteRela_YTCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCaseAddiSiteRela_YTCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"mId", "IdDecompressionFile", "FileName", "IdCase", "TeacherID", "TeacherName", "CollegeName", "CollegeNameA", "FuncModuleId", "FuncModuleName", "UpdDate", "UpdUser", "Memo", "CaseId", "CaseName"};

protected long mlngmId;    //mId
protected long mlngIdDecompressionFile;    //解压缩文件流水号
protected string mstrFileName;    //文件名称
protected string mstrIdCase;    //案例流水号
protected string mstrTeacherID;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrCaseId;    //案例Id
protected string mstrCaseName;    //案例名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCaseAddiSiteRela_YTCaseEN()
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
public clsvCaseAddiSiteRela_YTCaseEN(long lngmId)
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
if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.IdDecompressionFile)
{
return mlngIdDecompressionFile;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.IdCase)
{
return mstrIdCase;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.TeacherID)
{
return mstrTeacherID;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.CaseName)
{
return mstrCaseName;
}
return null;
}
set
{
if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.mId);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.IdDecompressionFile)
{
mlngIdDecompressionFile = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.IdDecompressionFile);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.FileName);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.IdCase)
{
mstrIdCase = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.IdCase);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.TeacherID)
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.TeacherID);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.TeacherName);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CollegeName);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CollegeNameA);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.FuncModuleId);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.FuncModuleName);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.UpdDate);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.UpdUser);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.Memo);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CaseId);
}
else if (strAttributeName  ==  convCaseAddiSiteRela_YTCase.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CaseName);
}
}
}
public object this[int intIndex]
{
get
{
if (convCaseAddiSiteRela_YTCase.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convCaseAddiSiteRela_YTCase.IdDecompressionFile  ==  AttributeName[intIndex])
{
return mlngIdDecompressionFile;
}
else if (convCaseAddiSiteRela_YTCase.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convCaseAddiSiteRela_YTCase.IdCase  ==  AttributeName[intIndex])
{
return mstrIdCase;
}
else if (convCaseAddiSiteRela_YTCase.TeacherID  ==  AttributeName[intIndex])
{
return mstrTeacherID;
}
else if (convCaseAddiSiteRela_YTCase.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convCaseAddiSiteRela_YTCase.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convCaseAddiSiteRela_YTCase.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convCaseAddiSiteRela_YTCase.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCaseAddiSiteRela_YTCase.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCaseAddiSiteRela_YTCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCaseAddiSiteRela_YTCase.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCaseAddiSiteRela_YTCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCaseAddiSiteRela_YTCase.CaseId  ==  AttributeName[intIndex])
{
return mstrCaseId;
}
else if (convCaseAddiSiteRela_YTCase.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
return null;
}
set
{
if (convCaseAddiSiteRela_YTCase.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.mId);
}
else if (convCaseAddiSiteRela_YTCase.IdDecompressionFile  ==  AttributeName[intIndex])
{
mlngIdDecompressionFile = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.IdDecompressionFile);
}
else if (convCaseAddiSiteRela_YTCase.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.FileName);
}
else if (convCaseAddiSiteRela_YTCase.IdCase  ==  AttributeName[intIndex])
{
mstrIdCase = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.IdCase);
}
else if (convCaseAddiSiteRela_YTCase.TeacherID  ==  AttributeName[intIndex])
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.TeacherID);
}
else if (convCaseAddiSiteRela_YTCase.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.TeacherName);
}
else if (convCaseAddiSiteRela_YTCase.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CollegeName);
}
else if (convCaseAddiSiteRela_YTCase.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CollegeNameA);
}
else if (convCaseAddiSiteRela_YTCase.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.FuncModuleId);
}
else if (convCaseAddiSiteRela_YTCase.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.FuncModuleName);
}
else if (convCaseAddiSiteRela_YTCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.UpdDate);
}
else if (convCaseAddiSiteRela_YTCase.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.UpdUser);
}
else if (convCaseAddiSiteRela_YTCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.Memo);
}
else if (convCaseAddiSiteRela_YTCase.CaseId  ==  AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CaseId);
}
else if (convCaseAddiSiteRela_YTCase.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CaseName);
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
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.mId);
}
}
/// <summary>
/// 解压缩文件流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdDecompressionFile
{
get
{
return mlngIdDecompressionFile;
}
set
{
 mlngIdDecompressionFile = value;
//记录修改过的字段
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.IdDecompressionFile);
}
}
/// <summary>
/// 文件名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.FileName);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCase
{
get
{
return mstrIdCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCase = value;
}
else
{
 mstrIdCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.IdCase);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherID
{
get
{
return mstrTeacherID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherID = value;
}
else
{
 mstrTeacherID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.TeacherID);
}
}
/// <summary>
/// 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherName
{
get
{
return mstrTeacherName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherName = value;
}
else
{
 mstrTeacherName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.TeacherName);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CollegeName);
}
}
/// <summary>
/// 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameA
{
get
{
return mstrCollegeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameA = value;
}
else
{
 mstrCollegeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CollegeNameA);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.FuncModuleName);
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
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.UpdDate);
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
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.UpdUser);
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
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.Memo);
}
}
/// <summary>
/// 案例Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseId
{
get
{
return mstrCaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseId = value;
}
else
{
 mstrCaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CaseId);
}
}
/// <summary>
/// 案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseName
{
get
{
return mstrCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseName = value;
}
else
{
 mstrCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseAddiSiteRela_YTCase.CaseName);
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
 /// v案例和附加网站关系_青教评优(vCaseAddiSiteRela_YTCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCaseAddiSiteRela_YTCase
{
public const string _CurrTabName = "vCaseAddiSiteRela_YTCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdDecompressionFile", "FileName", "IdCase", "TeacherID", "TeacherName", "CollegeName", "CollegeNameA", "FuncModuleId", "FuncModuleName", "UpdDate", "UpdUser", "Memo", "CaseId", "CaseName"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IdDecompressionFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDecompressionFile = "IdDecompressionFile";    //解压缩文件流水号

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名称

 /// <summary>
 /// 常量:"IdCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCase = "IdCase";    //案例流水号

 /// <summary>
 /// 常量:"TeacherID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherID = "TeacherID";    //教师工号

 /// <summary>
 /// 常量:"TeacherName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherName = "TeacherName";    //教师姓名

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

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

 /// <summary>
 /// 常量:"CaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseId = "CaseId";    //案例Id

 /// <summary>
 /// 常量:"CaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseName = "CaseName";    //案例名称
}

}