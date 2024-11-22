
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperRelationshipEN
 表名:cc_CourseExamPaperRelationship(01120076)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:09
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
 /// 表cc_CourseExamPaperRelationship的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_cc_CourseExamPaperRelationship
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
public K_mId_cc_CourseExamPaperRelationship(long lngmId)
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
 /// <returns>返回:[K_mId_cc_CourseExamPaperRelationship]类型的对象</returns>
public static implicit operator K_mId_cc_CourseExamPaperRelationship(long value)
{
return new K_mId_cc_CourseExamPaperRelationship(value);
}
}
 /// <summary>
 /// 题目与试卷关系(cc_CourseExamPaperRelationship)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseExamPaperRelationshipEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_CourseExamPaperRelationship"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"mId", "CourseExamPaperId", "CourseId", "QuestionId", "UserId", "StartTime", "PapersBigTopicId", "TopicOrderNum", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrCourseId;    //课程Id
protected long mlngQuestionId;    //题目Id
protected string mstrUserId;    //用户ID
protected double? mdblStartTime;    //开始时间(s)
protected string mstrPapersBigTopicId;    //试卷大题目Id
protected int? mintTopicOrderNum;    //TopicOrderNum
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseExamPaperRelationshipEN()
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
public clscc_CourseExamPaperRelationshipEN(long lngmId)
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
if (strAttributeName  ==  concc_CourseExamPaperRelationship.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.StartTime)
{
return mdblStartTime;
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.PapersBigTopicId)
{
return mstrPapersBigTopicId;
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.TopicOrderNum)
{
return mintTopicOrderNum;
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_CourseExamPaperRelationship.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperRelationship.mId);
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.CourseExamPaperId);
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.CourseId);
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperRelationship.QuestionId);
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.UserId);
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.StartTime)
{
mdblStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperRelationship.StartTime);
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.PapersBigTopicId)
{
mstrPapersBigTopicId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.PapersBigTopicId);
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.TopicOrderNum)
{
mintTopicOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperRelationship.TopicOrderNum);
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperRelationship.OrderNum);
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.UpdDate);
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.UpdUser);
}
else if (strAttributeName  ==  concc_CourseExamPaperRelationship.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_CourseExamPaperRelationship.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (concc_CourseExamPaperRelationship.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (concc_CourseExamPaperRelationship.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_CourseExamPaperRelationship.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (concc_CourseExamPaperRelationship.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (concc_CourseExamPaperRelationship.StartTime  ==  AttributeName[intIndex])
{
return mdblStartTime;
}
else if (concc_CourseExamPaperRelationship.PapersBigTopicId  ==  AttributeName[intIndex])
{
return mstrPapersBigTopicId;
}
else if (concc_CourseExamPaperRelationship.TopicOrderNum  ==  AttributeName[intIndex])
{
return mintTopicOrderNum;
}
else if (concc_CourseExamPaperRelationship.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (concc_CourseExamPaperRelationship.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_CourseExamPaperRelationship.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concc_CourseExamPaperRelationship.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_CourseExamPaperRelationship.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperRelationship.mId);
}
else if (concc_CourseExamPaperRelationship.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.CourseExamPaperId);
}
else if (concc_CourseExamPaperRelationship.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.CourseId);
}
else if (concc_CourseExamPaperRelationship.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperRelationship.QuestionId);
}
else if (concc_CourseExamPaperRelationship.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.UserId);
}
else if (concc_CourseExamPaperRelationship.StartTime  ==  AttributeName[intIndex])
{
mdblStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperRelationship.StartTime);
}
else if (concc_CourseExamPaperRelationship.PapersBigTopicId  ==  AttributeName[intIndex])
{
mstrPapersBigTopicId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.PapersBigTopicId);
}
else if (concc_CourseExamPaperRelationship.TopicOrderNum  ==  AttributeName[intIndex])
{
mintTopicOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperRelationship.TopicOrderNum);
}
else if (concc_CourseExamPaperRelationship.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperRelationship.OrderNum);
}
else if (concc_CourseExamPaperRelationship.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.UpdDate);
}
else if (concc_CourseExamPaperRelationship.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.UpdUser);
}
else if (concc_CourseExamPaperRelationship.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperRelationship.Memo);
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
 AddUpdatedFld(concc_CourseExamPaperRelationship.mId);
}
}
/// <summary>
/// 考卷流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseExamPaperId
{
get
{
return mstrCourseExamPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseExamPaperId = value;
}
else
{
 mstrCourseExamPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperRelationship.CourseExamPaperId);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperRelationship.CourseId);
}
}
/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperRelationship.QuestionId);
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
 AddUpdatedFld(concc_CourseExamPaperRelationship.UserId);
}
}
/// <summary>
/// 开始时间(s)(说明:;字段类型:decimal;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? StartTime
{
get
{
return mdblStartTime;
}
set
{
 mdblStartTime = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperRelationship.StartTime);
}
}
/// <summary>
/// 试卷大题目Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PapersBigTopicId
{
get
{
return mstrPapersBigTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPapersBigTopicId = value;
}
else
{
 mstrPapersBigTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperRelationship.PapersBigTopicId);
}
}
/// <summary>
/// TopicOrderNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TopicOrderNum
{
get
{
return mintTopicOrderNum;
}
set
{
 mintTopicOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperRelationship.TopicOrderNum);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperRelationship.OrderNum);
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
 AddUpdatedFld(concc_CourseExamPaperRelationship.UpdDate);
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
 AddUpdatedFld(concc_CourseExamPaperRelationship.UpdUser);
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
 AddUpdatedFld(concc_CourseExamPaperRelationship.Memo);
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
 /// 题目与试卷关系(cc_CourseExamPaperRelationship)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_CourseExamPaperRelationship
{
public const string _CurrTabName = "cc_CourseExamPaperRelationship"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseExamPaperId", "CourseId", "QuestionId", "UserId", "StartTime", "PapersBigTopicId", "TopicOrderNum", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"StartTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartTime = "StartTime";    //开始时间(s)

 /// <summary>
 /// 常量:"PapersBigTopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PapersBigTopicId = "PapersBigTopicId";    //试卷大题目Id

 /// <summary>
 /// 常量:"TopicOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicOrderNum = "TopicOrderNum";    //TopicOrderNum

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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