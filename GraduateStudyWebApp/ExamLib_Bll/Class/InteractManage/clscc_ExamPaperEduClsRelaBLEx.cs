
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperEduClsRelaBLEx
 表名:cc_ExamPaperEduClsRela(01120233)
 生成代码版本:2021.06.19.1
 生成日期:2021/06/19 17:51:50
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
public static class clscc_ExamPaperEduClsRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_ExamPaperEduClsRelaEN:objcc_ExamPaperEduClsRelaENT</returns>
 public static clscc_ExamPaperEduClsRelaENEx CopyToEx(this clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaENS)
{
try
{
 clscc_ExamPaperEduClsRelaENEx objcc_ExamPaperEduClsRelaENT = new clscc_ExamPaperEduClsRelaENEx();
clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.CopyTo(objcc_ExamPaperEduClsRelaENS, objcc_ExamPaperEduClsRelaENT);
 return objcc_ExamPaperEduClsRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_ExamPaperEduClsRelaEN:objcc_ExamPaperEduClsRelaENT</returns>
 public static clscc_ExamPaperEduClsRelaEN CopyTo(this clscc_ExamPaperEduClsRelaENEx objcc_ExamPaperEduClsRelaENS)
{
try
{
 clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaENT = new clscc_ExamPaperEduClsRelaEN();
clscc_ExamPaperEduClsRelaBL.CopyTo(objcc_ExamPaperEduClsRelaENS, objcc_ExamPaperEduClsRelaENT);
 return objcc_ExamPaperEduClsRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 考卷教学班关系(cc_ExamPaperEduClsRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_ExamPaperEduClsRelaBLEx : clscc_ExamPaperEduClsRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_ExamPaperEduClsRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_ExamPaperEduClsRelaDAEx cc_ExamPaperEduClsRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_ExamPaperEduClsRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_ExamPaperEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_ExamPaperEduClsRelaEN:objcc_ExamPaperEduClsRelaENT</returns>
 public static clscc_ExamPaperEduClsRelaENEx CopyToEx(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaENS)
{
try
{
 clscc_ExamPaperEduClsRelaENEx objcc_ExamPaperEduClsRelaENT = new clscc_ExamPaperEduClsRelaENEx();
clscc_ExamPaperEduClsRelaBL.cc_ExamPaperEduClsRelaDA.CopyTo(objcc_ExamPaperEduClsRelaENS, objcc_ExamPaperEduClsRelaENT);
 return objcc_ExamPaperEduClsRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
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
public static List<clscc_ExamPaperEduClsRelaENEx> GetObjExLst(string strCondition)
{
List <clscc_ExamPaperEduClsRelaEN> arrObjLst = clscc_ExamPaperEduClsRelaBL.GetObjLst(strCondition);
List <clscc_ExamPaperEduClsRelaENEx> arrObjExLst = new List<clscc_ExamPaperEduClsRelaENEx>();
foreach (clscc_ExamPaperEduClsRelaEN objInFor in arrObjLst)
{
clscc_ExamPaperEduClsRelaENEx objcc_ExamPaperEduClsRelaENEx = new clscc_ExamPaperEduClsRelaENEx();
clscc_ExamPaperEduClsRelaBL.CopyTo(objInFor, objcc_ExamPaperEduClsRelaENEx);
arrObjExLst.Add(objcc_ExamPaperEduClsRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngId_ExamPaperEduClsRela">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_ExamPaperEduClsRelaENEx GetObjExById_ExamPaperEduClsRela(long lngId_ExamPaperEduClsRela)
{
clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN = clscc_ExamPaperEduClsRelaBL.GetObjByIdExamPaperEduClsRela(lngId_ExamPaperEduClsRela);
clscc_ExamPaperEduClsRelaENEx objcc_ExamPaperEduClsRelaENEx = new clscc_ExamPaperEduClsRelaENEx();
clscc_ExamPaperEduClsRelaBL.CopyTo(objcc_ExamPaperEduClsRelaEN, objcc_ExamPaperEduClsRelaENEx);
return objcc_ExamPaperEduClsRelaENEx;
}
}
}