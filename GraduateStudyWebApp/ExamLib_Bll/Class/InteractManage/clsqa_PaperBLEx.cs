
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_PaperBLEx
 表名:qa_Paper(01120643)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/12 21:50:05
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
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
public static class clsqa_PaperBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objqa_PaperENS">源对象</param>
 /// <returns>目标对象=>clsqa_PaperEN:objqa_PaperENT</returns>
 public static clsqa_PaperENEx CopyToEx(this clsqa_PaperEN objqa_PaperENS)
{
try
{
 clsqa_PaperENEx objqa_PaperENT = new clsqa_PaperENEx();
clsqa_PaperBL.qa_PaperDA.CopyTo(objqa_PaperENS, objqa_PaperENT);
 return objqa_PaperENT;
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
 /// <param name = "objqa_PaperENS">源对象</param>
 /// <returns>目标对象=>clsqa_PaperEN:objqa_PaperENT</returns>
 public static clsqa_PaperEN CopyTo(this clsqa_PaperENEx objqa_PaperENS)
{
try
{
 clsqa_PaperEN objqa_PaperENT = new clsqa_PaperEN();
clsqa_PaperBL.CopyTo(objqa_PaperENS, objqa_PaperENT);
 return objqa_PaperENT;
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
 /// 论文答疑表(qa_Paper)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsqa_PaperBLEx : clsqa_PaperBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsqa_PaperDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsqa_PaperDAEx qa_PaperDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsqa_PaperDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objqa_PaperENS">源对象</param>
 /// <returns>目标对象=>clsqa_PaperEN:objqa_PaperENT</returns>
 public static clsqa_PaperENEx CopyToEx(clsqa_PaperEN objqa_PaperENS)
{
try
{
 clsqa_PaperENEx objqa_PaperENT = new clsqa_PaperENEx();
clsqa_PaperBL.qa_PaperDA.CopyTo(objqa_PaperENS, objqa_PaperENT);
 return objqa_PaperENT;
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
public static List<clsqa_PaperENEx> GetObjExLst(string strCondition)
{
List <clsqa_PaperEN> arrObjLst = clsqa_PaperBL.GetObjLst(strCondition);
List <clsqa_PaperENEx> arrObjExLst = new List<clsqa_PaperENEx>();
foreach (clsqa_PaperEN objInFor in arrObjLst)
{
clsqa_PaperENEx objqa_PaperENEx = new clsqa_PaperENEx();
clsqa_PaperBL.CopyTo(objInFor, objqa_PaperENEx);
arrObjExLst.Add(objqa_PaperENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strqa_PaperId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsqa_PaperENEx GetObjExByqa_PaperId(string strqa_PaperId)
{
clsqa_PaperEN objqa_PaperEN = clsqa_PaperBL.GetObjByQaPaperId(strqa_PaperId);
clsqa_PaperENEx objqa_PaperENEx = new clsqa_PaperENEx();
clsqa_PaperBL.CopyTo(objqa_PaperEN, objqa_PaperENEx);
return objqa_PaperENEx;
}
}
}