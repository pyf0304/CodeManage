
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PaperStuBatchQuesRelaBLEx
 表名:cc_PaperStuBatchQuesRela(01120240)
 生成代码版本:2022.11.19.1
 生成日期:2022/11/23 04:25:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;

using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_cc_PaperStuBatchQuesRelaEx: RelatedActions_cc_PaperStuBatchQuesRela
{
public override bool UpdRelaTabDate(long lngId_PaperStuBatchQuesRela, string strOpUser)
{
return true;
}
}
public static class clscc_PaperStuBatchQuesRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_PaperStuBatchQuesRelaEN:objcc_PaperStuBatchQuesRelaENT</returns>
 public static clscc_PaperStuBatchQuesRelaENEx CopyToEx(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENS)
{
try
{
 clscc_PaperStuBatchQuesRelaENEx objcc_PaperStuBatchQuesRelaENT = new clscc_PaperStuBatchQuesRelaENEx();
clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.CopyTo(objcc_PaperStuBatchQuesRelaENS, objcc_PaperStuBatchQuesRelaENT);
 return objcc_PaperStuBatchQuesRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_PaperStuBatchQuesRelaEN:objcc_PaperStuBatchQuesRelaENT</returns>
 public static clscc_PaperStuBatchQuesRelaEN CopyTo(this clscc_PaperStuBatchQuesRelaENEx objcc_PaperStuBatchQuesRelaENS)
{
try
{
 clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENT = new clscc_PaperStuBatchQuesRelaEN();
clscc_PaperStuBatchQuesRelaBL.CopyTo(objcc_PaperStuBatchQuesRelaENS, objcc_PaperStuBatchQuesRelaENT);
 return objcc_PaperStuBatchQuesRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 学生批次题目关系(cc_PaperStuBatchQuesRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_PaperStuBatchQuesRelaBLEx : clscc_PaperStuBatchQuesRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_PaperStuBatchQuesRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_PaperStuBatchQuesRelaDAEx cc_PaperStuBatchQuesRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_PaperStuBatchQuesRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_PaperStuBatchQuesRelaEN:objcc_PaperStuBatchQuesRelaENT</returns>
 public static clscc_PaperStuBatchQuesRelaENEx CopyToEx(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENS)
{
try
{
 clscc_PaperStuBatchQuesRelaENEx objcc_PaperStuBatchQuesRelaENT = new clscc_PaperStuBatchQuesRelaENEx();
clscc_PaperStuBatchQuesRelaBL.cc_PaperStuBatchQuesRelaDA.CopyTo(objcc_PaperStuBatchQuesRelaENS, objcc_PaperStuBatchQuesRelaENT);
 return objcc_PaperStuBatchQuesRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clscc_PaperStuBatchQuesRelaENEx> GetObjExLst(string strCondition)
{
List <clscc_PaperStuBatchQuesRelaEN> arrObjLst = clscc_PaperStuBatchQuesRelaBL.GetObjLst(strCondition);
List <clscc_PaperStuBatchQuesRelaENEx> arrObjExLst = new List<clscc_PaperStuBatchQuesRelaENEx>();
foreach (clscc_PaperStuBatchQuesRelaEN objInFor in arrObjLst)
{
clscc_PaperStuBatchQuesRelaENEx objcc_PaperStuBatchQuesRelaENEx = new clscc_PaperStuBatchQuesRelaENEx();
clscc_PaperStuBatchQuesRelaBL.CopyTo(objInFor, objcc_PaperStuBatchQuesRelaENEx);
arrObjExLst.Add(objcc_PaperStuBatchQuesRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngId_PaperStuBatchQuesRela">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_PaperStuBatchQuesRelaENEx GetObjExById_PaperStuBatchQuesRela(long lngId_PaperStuBatchQuesRela)
{
clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = clscc_PaperStuBatchQuesRelaBL.GetObjById_PaperStuBatchQuesRela(lngId_PaperStuBatchQuesRela);
clscc_PaperStuBatchQuesRelaENEx objcc_PaperStuBatchQuesRelaENEx = new clscc_PaperStuBatchQuesRelaENEx();
clscc_PaperStuBatchQuesRelaBL.CopyTo(objcc_PaperStuBatchQuesRelaEN, objcc_PaperStuBatchQuesRelaENEx);
return objcc_PaperStuBatchQuesRelaENEx;
}
}
}