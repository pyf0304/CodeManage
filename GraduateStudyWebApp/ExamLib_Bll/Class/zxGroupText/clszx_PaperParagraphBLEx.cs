
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_PaperParagraphBLEx
 表名:zx_PaperParagraph(01120759)
 生成代码版本:2020.09.24.1
 生成日期:2020/11/08 00:56:44
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文
 模块英文名:zxGroupText
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
public static class clszx_PaperParagraphBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperParagraphEN:objzx_PaperParagraphENT</returns>
 public static clszx_PaperParagraphENEx CopyToEx(this clszx_PaperParagraphEN objzx_PaperParagraphENS)
{
try
{
 clszx_PaperParagraphENEx objzx_PaperParagraphENT = new clszx_PaperParagraphENEx();
clszx_PaperParagraphBL.zx_PaperParagraphDA.CopyTo(objzx_PaperParagraphENS, objzx_PaperParagraphENT);
 return objzx_PaperParagraphENT;
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
 /// <param name = "objzx_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperParagraphEN:objzx_PaperParagraphENT</returns>
 public static clszx_PaperParagraphEN CopyTo(this clszx_PaperParagraphENEx objzx_PaperParagraphENS)
{
try
{
 clszx_PaperParagraphEN objzx_PaperParagraphENT = new clszx_PaperParagraphEN();
clszx_PaperParagraphBL.CopyTo(objzx_PaperParagraphENS, objzx_PaperParagraphENT);
 return objzx_PaperParagraphENT;
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
 /// 作文段落表(zx_PaperParagraph)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_PaperParagraphBLEx : clszx_PaperParagraphBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_PaperParagraphDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_PaperParagraphDAEx zx_PaperParagraphDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_PaperParagraphDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperParagraphEN:objzx_PaperParagraphENT</returns>
 public static clszx_PaperParagraphENEx CopyToEx(clszx_PaperParagraphEN objzx_PaperParagraphENS)
{
try
{
 clszx_PaperParagraphENEx objzx_PaperParagraphENT = new clszx_PaperParagraphENEx();
clszx_PaperParagraphBL.zx_PaperParagraphDA.CopyTo(objzx_PaperParagraphENS, objzx_PaperParagraphENT);
 return objzx_PaperParagraphENT;
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
public static List<clszx_PaperParagraphENEx> GetObjExLst(string strCondition)
{
List <clszx_PaperParagraphEN> arrObjLst = clszx_PaperParagraphBL.GetObjLst(strCondition);
List <clszx_PaperParagraphENEx> arrObjExLst = new List<clszx_PaperParagraphENEx>();
foreach (clszx_PaperParagraphEN objInFor in arrObjLst)
{
clszx_PaperParagraphENEx objzx_PaperParagraphENEx = new clszx_PaperParagraphENEx();
clszx_PaperParagraphBL.CopyTo(objInFor, objzx_PaperParagraphENEx);
arrObjExLst.Add(objzx_PaperParagraphENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strParagraphId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_PaperParagraphENEx GetObjExByParagraphId(string strParagraphId)
{
clszx_PaperParagraphEN objzx_PaperParagraphEN = clszx_PaperParagraphBL.GetObjByzxParagraphId(strParagraphId);
clszx_PaperParagraphENEx objzx_PaperParagraphENEx = new clszx_PaperParagraphENEx();
clszx_PaperParagraphBL.CopyTo(objzx_PaperParagraphEN, objzx_PaperParagraphENEx);
return objzx_PaperParagraphENEx;
}
}
}