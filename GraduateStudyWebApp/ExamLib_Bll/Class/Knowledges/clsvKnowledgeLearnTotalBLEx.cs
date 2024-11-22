
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvKnowledgeLearnTotalBLEx
 表名:vKnowledgeLearnTotal(01120156)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 18:51:37
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsvKnowledgeLearnTotalBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalENS">源对象</param>
 /// <returns>目标对象=>clsvKnowledgeLearnTotalEN:objvKnowledgeLearnTotalENT</returns>
 public static clsvKnowledgeLearnTotalENEx CopyToEx(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalENS)
{
try
{
 clsvKnowledgeLearnTotalENEx objvKnowledgeLearnTotalENT = new clsvKnowledgeLearnTotalENEx();
clsvKnowledgeLearnTotalBL.vKnowledgeLearnTotalDA.CopyTo(objvKnowledgeLearnTotalENS, objvKnowledgeLearnTotalENT);
 return objvKnowledgeLearnTotalENT;
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
 /// <param name = "objvKnowledgeLearnTotalENS">源对象</param>
 /// <returns>目标对象=>clsvKnowledgeLearnTotalEN:objvKnowledgeLearnTotalENT</returns>
 public static clsvKnowledgeLearnTotalEN CopyTo(this clsvKnowledgeLearnTotalENEx objvKnowledgeLearnTotalENS)
{
try
{
 clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalENT = new clsvKnowledgeLearnTotalEN();
clsvKnowledgeLearnTotalBL.CopyTo(objvKnowledgeLearnTotalENS, objvKnowledgeLearnTotalENT);
 return objvKnowledgeLearnTotalENT;
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
 /// v知识点学习汇总表(vKnowledgeLearnTotal)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvKnowledgeLearnTotalBLEx : clsvKnowledgeLearnTotalBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvKnowledgeLearnTotalDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvKnowledgeLearnTotalDAEx vKnowledgeLearnTotalDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvKnowledgeLearnTotalDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvKnowledgeLearnTotalENEx> GetObjExLst(string strCondition)
{
List <clsvKnowledgeLearnTotalEN> arrObjLst = clsvKnowledgeLearnTotalBL.GetObjLst(strCondition);
List <clsvKnowledgeLearnTotalENEx> arrObjExLst = new List<clsvKnowledgeLearnTotalENEx>();
foreach (clsvKnowledgeLearnTotalEN objInFor in arrObjLst)
{
clsvKnowledgeLearnTotalENEx objvKnowledgeLearnTotalENEx = new clsvKnowledgeLearnTotalENEx();
clsvKnowledgeLearnTotalBL.CopyTo(objInFor, objvKnowledgeLearnTotalENEx);
arrObjExLst.Add(objvKnowledgeLearnTotalENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvKnowledgeLearnTotalENEx GetObjExBymId(long lngmId)
{
clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = clsvKnowledgeLearnTotalBL.GetObjBymId(lngmId);
clsvKnowledgeLearnTotalENEx objvKnowledgeLearnTotalENEx = new clsvKnowledgeLearnTotalENEx();
clsvKnowledgeLearnTotalBL.CopyTo(objvKnowledgeLearnTotalEN, objvKnowledgeLearnTotalENEx);
return objvKnowledgeLearnTotalENEx;
}
}
}