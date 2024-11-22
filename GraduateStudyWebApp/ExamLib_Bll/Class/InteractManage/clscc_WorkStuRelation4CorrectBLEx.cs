
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelation4CorrectBLEx
 表名:cc_WorkStuRelation4Correct(01120182)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 19:18:58
 生成者:yy
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
public static class clscc_WorkStuRelation4CorrectBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkStuRelation4CorrectEN:objcc_WorkStuRelation4CorrectENT</returns>
 public static clscc_WorkStuRelation4CorrectENEx CopyToEx(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectENS)
{
try
{
 clscc_WorkStuRelation4CorrectENEx objcc_WorkStuRelation4CorrectENT = new clscc_WorkStuRelation4CorrectENEx();
clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.CopyTo(objcc_WorkStuRelation4CorrectENS, objcc_WorkStuRelation4CorrectENT);
 return objcc_WorkStuRelation4CorrectENT;
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
 /// <param name = "objcc_WorkStuRelation4CorrectENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkStuRelation4CorrectEN:objcc_WorkStuRelation4CorrectENT</returns>
 public static clscc_WorkStuRelation4CorrectEN CopyTo(this clscc_WorkStuRelation4CorrectENEx objcc_WorkStuRelation4CorrectENS)
{
try
{
 clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectENT = new clscc_WorkStuRelation4CorrectEN();
clscc_WorkStuRelation4CorrectBL.CopyTo(objcc_WorkStuRelation4CorrectENS, objcc_WorkStuRelation4CorrectENT);
 return objcc_WorkStuRelation4CorrectENT;
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
 /// 学生批改作业关系(cc_WorkStuRelation4Correct)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_WorkStuRelation4CorrectBLEx : clscc_WorkStuRelation4CorrectBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_WorkStuRelation4CorrectDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_WorkStuRelation4CorrectDAEx cc_WorkStuRelation4CorrectDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_WorkStuRelation4CorrectDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkStuRelation4CorrectEN:objcc_WorkStuRelation4CorrectENT</returns>
 public static clscc_WorkStuRelation4CorrectENEx CopyToEx(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectENS)
{
try
{
 clscc_WorkStuRelation4CorrectENEx objcc_WorkStuRelation4CorrectENT = new clscc_WorkStuRelation4CorrectENEx();
clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.CopyTo(objcc_WorkStuRelation4CorrectENS, objcc_WorkStuRelation4CorrectENT);
 return objcc_WorkStuRelation4CorrectENT;
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
public static List<clscc_WorkStuRelation4CorrectENEx> GetObjExLst(string strCondition)
{
List <clscc_WorkStuRelation4CorrectEN> arrObjLst = clscc_WorkStuRelation4CorrectBL.GetObjLst(strCondition);
List <clscc_WorkStuRelation4CorrectENEx> arrObjExLst = new List<clscc_WorkStuRelation4CorrectENEx>();
foreach (clscc_WorkStuRelation4CorrectEN objInFor in arrObjLst)
{
clscc_WorkStuRelation4CorrectENEx objcc_WorkStuRelation4CorrectENEx = new clscc_WorkStuRelation4CorrectENEx();
clscc_WorkStuRelation4CorrectBL.CopyTo(objInFor, objcc_WorkStuRelation4CorrectENEx);
arrObjExLst.Add(objcc_WorkStuRelation4CorrectENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_WorkStuRelation4CorrectENEx GetObjExBymId(long lngmId)
{
clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = clscc_WorkStuRelation4CorrectBL.GetObjBymId(lngmId);
clscc_WorkStuRelation4CorrectENEx objcc_WorkStuRelation4CorrectENEx = new clscc_WorkStuRelation4CorrectENEx();
clscc_WorkStuRelation4CorrectBL.CopyTo(objcc_WorkStuRelation4CorrectEN, objcc_WorkStuRelation4CorrectENEx);
return objcc_WorkStuRelation4CorrectENEx;
}
}
}