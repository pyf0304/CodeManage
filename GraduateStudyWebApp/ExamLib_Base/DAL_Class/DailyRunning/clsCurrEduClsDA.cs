
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsDA
 表名:CurrEduCls(01120123)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
 框架-层名:数据处理层(CS)(DALCode,0002)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using ExamLib.Entity;

namespace ExamLib.DAL
{
 /// <summary>
 /// 当前教学班(CurrEduCls)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCurrEduClsDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clsCurrEduClsEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsCurrEduClsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduClsEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsCurrEduClsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCurrEduClsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCurrEduCls)
{
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("(errid:Data000001)在表:CurrEduCls中,检查关键字,长度不正确!(clsCurrEduClsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CurrEduCls中,关键字不能为空 或 null!(clsCurrEduClsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCurrEduClsDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCurrEduClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CurrEduCls(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCurrEduClsDA: GetDataTable_CurrEduCls)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCurrEduClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCurrEduClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCurrEduClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCurrEduClsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCurrEduClsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CurrEduCls where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCurrEduClsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} CurrEduCls.* from CurrEduCls Left Join {1} on {2} where {3} and CurrEduCls.IdCurrEduCls not in (Select top {5} CurrEduCls.IdCurrEduCls from CurrEduCls Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from CurrEduCls where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from CurrEduCls where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCurrEduClsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} CurrEduCls.* from CurrEduCls Left Join {1} on {2} where {3} and CurrEduCls.IdCurrEduCls not in (Select top {5} CurrEduCls.IdCurrEduCls from CurrEduCls Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from CurrEduCls where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from CurrEduCls where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsCurrEduClsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCurrEduClsDA:GetObjLst)", objException.Message));
}
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = TransNullToBool(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = TransNullToBool(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = TransNullToBool(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduClsDA: GetObjLst)", objException.Message));
}
objCurrEduClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsCurrEduClsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCurrEduClsDA:GetObjLstByTabName)", objException.Message));
}
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = TransNullToBool(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = TransNullToBool(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = TransNullToBool(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduClsDA: GetObjLst)", objException.Message));
}
objCurrEduClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduClsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCurrEduCls(ref clsCurrEduClsEN objCurrEduClsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls where IdCurrEduCls = " + "'"+ objCurrEduClsEN.IdCurrEduCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCurrEduClsEN.IdCurrEduCls = objDT.Rows[0][conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsEN.CurrEduClsId = objDT.Rows[0][conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objCurrEduClsEN.EduClsName = objDT.Rows[0][conCurrEduCls.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objCurrEduClsEN.EduClsTypeId = objDT.Rows[0][conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.CourseId = objDT.Rows[0][conCurrEduCls.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduClsEN.TeachingSolutionId = objDT.Rows[0][conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsEN.IdXzCollege = objDT.Rows[0][conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduClsEN.IdXzMajor = objDT.Rows[0][conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsEN.IdEduWay = objDT.Rows[0][conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.IdClassRoomType = objDT.Rows[0][conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.TotalLessonQty = TransNullToInt(objDT.Rows[0][conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objCurrEduClsEN.MaxStuQty = TransNullToInt(objDT.Rows[0][conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsEN.WeekQty = TransNullToInt(objDT.Rows[0][conCurrEduCls.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsEN.ScheUnitPW = TransNullToShort(objDT.Rows[0][conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduClsEN.WeekStatusId = objDT.Rows[0][conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduClsEN.CustomerWeek = objDT.Rows[0][conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduClsEN.LessonQtyPerWeek = TransNullToShort(objDT.Rows[0][conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objCurrEduClsEN.Mark = TransNullToDouble(objDT.Rows[0][conCurrEduCls.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objCurrEduClsEN.IdUniZone = objDT.Rows[0][conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.IdGradeBase = objDT.Rows[0][conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduClsEN.IsEffective = TransNullToBool(objDT.Rows[0][conCurrEduCls.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduClsEN.IsForPaperReading = TransNullToBool(objDT.Rows[0][conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduClsEN.SchoolYear = objDT.Rows[0][conCurrEduCls.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduClsEN.SchoolTerm = objDT.Rows[0][conCurrEduCls.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduClsEN.IdCourseType = objDT.Rows[0][conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.IsDegree = TransNullToBool(objDT.Rows[0][conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduClsEN.IdScoreType = objDT.Rows[0][conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.GetScoreWayId = objDT.Rows[0][conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduClsEN.IsProportionalCtrl = TransNullToBool(objDT.Rows[0][conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduClsEN.IdExamType = objDT.Rows[0][conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.ExamTime = objDT.Rows[0][conCurrEduCls.ExamTime].ToString().Trim(); //考试时间(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduClsEN.BeginWeek = TransNullToShort(objDT.Rows[0][conCurrEduCls.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduClsEN.UserType = objDT.Rows[0][conCurrEduCls.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduClsEN.ModifyDate = objDT.Rows[0][conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsEN.ModifyUserId = objDT.Rows[0][conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduClsEN.Memo = objDT.Rows[0][conCurrEduCls.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCurrEduClsDA: GetCurrEduCls)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public clsCurrEduClsEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
{
CheckPrimaryKey(strIdCurrEduCls);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
 objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCurrEduClsDA: GetObjByIdCurrEduCls)", objException.Message));
}
return objCurrEduClsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCurrEduClsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCurrEduClsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN()
{
IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(), //教学班流水号
CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(), //教学班Id
EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(), //教学班名
EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(), //教学班类型Id
CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(), //课程Id
TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(), //教学方案Id
IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(), //专业流水号
IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(), //教学方式流水号
IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(), //教室类型流水号
TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()), //总课时数
MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()), //最大学生数
WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.WeekQty].ToString().Trim()), //总周数
ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()), //周排课次数
WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(), //周状态编号(单,双,全周)
CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(), //自定义上课周
LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()), //周课时数
Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls.Mark].ToString().Trim()), //获得学分
IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(), //校区流水号
IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(), //年级流水号
IsEffective = TransNullToBool(objRow[conCurrEduCls.IsEffective].ToString().Trim()), //是否有效
IsForPaperReading = TransNullToBool(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()), //是否参与论文阅读
SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(), //学期
IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(), //课程类型流水号
IsDegree = TransNullToBool(objRow[conCurrEduCls.IsDegree].ToString().Trim()), //是否学位课
IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(), //成绩类型流水号
GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(), //获得成绩方式Id
IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()), //是否比例控制
IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(), //考试方式流水号
ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(), //考试时间
BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.BeginWeek].ToString().Trim()), //开始周
UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(), //用户类型
ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(), //修改人
Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim() //备注
};
objCurrEduClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCurrEduClsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCurrEduClsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = TransNullToBool(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = TransNullToBool(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = TransNullToBool(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCurrEduClsDA: GetObjByDataRowCurrEduCls)", objException.Message));
}
objCurrEduClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCurrEduClsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = TransNullToBool(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = TransNullToBool(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = TransNullToBool(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCurrEduClsDA: GetObjByDataRow)", objException.Message));
}
objCurrEduClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduClsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduClsEN._CurrTabName, conCurrEduCls.IdCurrEduCls, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduClsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduClsEN._CurrTabName, conCurrEduCls.IdCurrEduCls, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCurrEduCls from CurrEduCls where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCurrEduCls from CurrEduCls where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCurrEduCls)
{
CheckPrimaryKey(strIdCurrEduCls);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduCls", "IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'"))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCurrEduClsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduCls", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduClsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CurrEduCls");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCurrEduClsEN objCurrEduClsEN)
 {
 objCurrEduClsEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduCls");
objRow = objDS.Tables["CurrEduCls"].NewRow();
objRow[conCurrEduCls.IdCurrEduCls] = objCurrEduClsEN.IdCurrEduCls; //教学班流水号
objRow[conCurrEduCls.CurrEduClsId] = objCurrEduClsEN.CurrEduClsId; //教学班Id
objRow[conCurrEduCls.EduClsName] = objCurrEduClsEN.EduClsName; //教学班名
 if (objCurrEduClsEN.EduClsTypeId !=  "")
 {
objRow[conCurrEduCls.EduClsTypeId] = objCurrEduClsEN.EduClsTypeId; //教学班类型Id
 }
 if (objCurrEduClsEN.CourseId !=  "")
 {
objRow[conCurrEduCls.CourseId] = objCurrEduClsEN.CourseId; //课程Id
 }
 if (objCurrEduClsEN.TeachingSolutionId !=  "")
 {
objRow[conCurrEduCls.TeachingSolutionId] = objCurrEduClsEN.TeachingSolutionId; //教学方案Id
 }
 if (objCurrEduClsEN.IdXzCollege !=  "")
 {
objRow[conCurrEduCls.IdXzCollege] = objCurrEduClsEN.IdXzCollege; //学院流水号
 }
 if (objCurrEduClsEN.IdXzMajor !=  "")
 {
objRow[conCurrEduCls.IdXzMajor] = objCurrEduClsEN.IdXzMajor; //专业流水号
 }
 if (objCurrEduClsEN.IdEduWay !=  "")
 {
objRow[conCurrEduCls.IdEduWay] = objCurrEduClsEN.IdEduWay; //教学方式流水号
 }
 if (objCurrEduClsEN.IdClassRoomType !=  "")
 {
objRow[conCurrEduCls.IdClassRoomType] = objCurrEduClsEN.IdClassRoomType; //教室类型流水号
 }
objRow[conCurrEduCls.TotalLessonQty] = objCurrEduClsEN.TotalLessonQty; //总课时数
objRow[conCurrEduCls.MaxStuQty] = objCurrEduClsEN.MaxStuQty; //最大学生数
objRow[conCurrEduCls.WeekQty] = objCurrEduClsEN.WeekQty; //总周数
objRow[conCurrEduCls.ScheUnitPW] = objCurrEduClsEN.ScheUnitPW; //周排课次数
 if (objCurrEduClsEN.WeekStatusId !=  "")
 {
objRow[conCurrEduCls.WeekStatusId] = objCurrEduClsEN.WeekStatusId; //周状态编号(单,双,全周)
 }
 if (objCurrEduClsEN.CustomerWeek !=  "")
 {
objRow[conCurrEduCls.CustomerWeek] = objCurrEduClsEN.CustomerWeek; //自定义上课周
 }
objRow[conCurrEduCls.LessonQtyPerWeek] = objCurrEduClsEN.LessonQtyPerWeek; //周课时数
objRow[conCurrEduCls.Mark] = objCurrEduClsEN.Mark; //获得学分
 if (objCurrEduClsEN.IdUniZone !=  "")
 {
objRow[conCurrEduCls.IdUniZone] = objCurrEduClsEN.IdUniZone; //校区流水号
 }
 if (objCurrEduClsEN.IdGradeBase !=  "")
 {
objRow[conCurrEduCls.IdGradeBase] = objCurrEduClsEN.IdGradeBase; //年级流水号
 }
objRow[conCurrEduCls.IsEffective] = objCurrEduClsEN.IsEffective; //是否有效
objRow[conCurrEduCls.IsForPaperReading] = objCurrEduClsEN.IsForPaperReading; //是否参与论文阅读
 if (objCurrEduClsEN.SchoolYear !=  "")
 {
objRow[conCurrEduCls.SchoolYear] = objCurrEduClsEN.SchoolYear; //学年
 }
 if (objCurrEduClsEN.SchoolTerm !=  "")
 {
objRow[conCurrEduCls.SchoolTerm] = objCurrEduClsEN.SchoolTerm; //学期
 }
 if (objCurrEduClsEN.IdCourseType !=  "")
 {
objRow[conCurrEduCls.IdCourseType] = objCurrEduClsEN.IdCourseType; //课程类型流水号
 }
objRow[conCurrEduCls.IsDegree] = objCurrEduClsEN.IsDegree; //是否学位课
 if (objCurrEduClsEN.IdScoreType !=  "")
 {
objRow[conCurrEduCls.IdScoreType] = objCurrEduClsEN.IdScoreType; //成绩类型流水号
 }
 if (objCurrEduClsEN.GetScoreWayId !=  "")
 {
objRow[conCurrEduCls.GetScoreWayId] = objCurrEduClsEN.GetScoreWayId; //获得成绩方式Id
 }
objRow[conCurrEduCls.IsProportionalCtrl] = objCurrEduClsEN.IsProportionalCtrl; //是否比例控制
 if (objCurrEduClsEN.IdExamType !=  "")
 {
objRow[conCurrEduCls.IdExamType] = objCurrEduClsEN.IdExamType; //考试方式流水号
 }
 if (objCurrEduClsEN.ExamTime !=  "")
 {
objRow[conCurrEduCls.ExamTime] = objCurrEduClsEN.ExamTime; //考试时间
 }
objRow[conCurrEduCls.BeginWeek] = objCurrEduClsEN.BeginWeek; //开始周
 if (objCurrEduClsEN.UserType !=  "")
 {
objRow[conCurrEduCls.UserType] = objCurrEduClsEN.UserType; //用户类型
 }
 if (objCurrEduClsEN.ModifyDate !=  "")
 {
objRow[conCurrEduCls.ModifyDate] = objCurrEduClsEN.ModifyDate; //修改日期
 }
 if (objCurrEduClsEN.ModifyUserId !=  "")
 {
objRow[conCurrEduCls.ModifyUserId] = objCurrEduClsEN.ModifyUserId; //修改人
 }
 if (objCurrEduClsEN.Memo !=  "")
 {
objRow[conCurrEduCls.Memo] = objCurrEduClsEN.Memo; //备注
 }
objDS.Tables[clsCurrEduClsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCurrEduClsEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduClsEN objCurrEduClsEN)
{
 objCurrEduClsEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCurrEduClsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CurrEduClsId);
 var strCurrEduClsId = objCurrEduClsEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduClsEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.EduClsName);
 var strEduClsName = objCurrEduClsEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduClsEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.EduClsTypeId);
 var strEduClsTypeId = objCurrEduClsEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduClsEN.CourseId  ==  "")
 {
 objCurrEduClsEN.CourseId = null;
 }
 if (objCurrEduClsEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CourseId);
 var strCourseId = objCurrEduClsEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduClsEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduClsEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduClsEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdXzCollege);
 var strIdXzCollege = objCurrEduClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduClsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdXzMajor);
 var strIdXzMajor = objCurrEduClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCurrEduClsEN.IdEduWay  ==  "")
 {
 objCurrEduClsEN.IdEduWay = null;
 }
 if (objCurrEduClsEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdEduWay);
 var strIdEduWay = objCurrEduClsEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduClsEN.IdClassRoomType  ==  "")
 {
 objCurrEduClsEN.IdClassRoomType = null;
 }
 if (objCurrEduClsEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdClassRoomType);
 var strIdClassRoomType = objCurrEduClsEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduClsEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduClsEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduClsEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduClsEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduClsEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.WeekQty);
 arrValueListForInsert.Add(objCurrEduClsEN.WeekQty.ToString());
 }
 
 if (objCurrEduClsEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduClsEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduClsEN.WeekStatusId  ==  "")
 {
 objCurrEduClsEN.WeekStatusId = null;
 }
 if (objCurrEduClsEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.WeekStatusId);
 var strWeekStatusId = objCurrEduClsEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduClsEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CustomerWeek);
 var strCustomerWeek = objCurrEduClsEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 if (objCurrEduClsEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduClsEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduClsEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.Mark);
 arrValueListForInsert.Add(objCurrEduClsEN.Mark.ToString());
 }
 
 if (objCurrEduClsEN.IdUniZone  ==  "")
 {
 objCurrEduClsEN.IdUniZone = null;
 }
 if (objCurrEduClsEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdUniZone);
 var strIdUniZone = objCurrEduClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objCurrEduClsEN.IdGradeBase  ==  "")
 {
 objCurrEduClsEN.IdGradeBase = null;
 }
 if (objCurrEduClsEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdGradeBase);
 var strIdGradeBase = objCurrEduClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls.IsForPaperReading);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsForPaperReading  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.SchoolYear);
 var strSchoolYear = objCurrEduClsEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.SchoolTerm);
 var strSchoolTerm = objCurrEduClsEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdCourseType);
 var strIdCourseType = objCurrEduClsEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdScoreType);
 var strIdScoreType = objCurrEduClsEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduClsEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.GetScoreWayId);
 var strGetScoreWayId = objCurrEduClsEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdExamType);
 var strIdExamType = objCurrEduClsEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduClsEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ExamTime);
 var strExamTime = objCurrEduClsEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 if (objCurrEduClsEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.BeginWeek);
 arrValueListForInsert.Add(objCurrEduClsEN.BeginWeek.ToString());
 }
 
 if (objCurrEduClsEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.UserType);
 var strUserType = objCurrEduClsEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objCurrEduClsEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ModifyDate);
 var strModifyDate = objCurrEduClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ModifyUserId);
 var strModifyUserId = objCurrEduClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduClsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.Memo);
 var strMemo = objCurrEduClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduClsEN objCurrEduClsEN)
{
 objCurrEduClsEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCurrEduClsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CurrEduClsId);
 var strCurrEduClsId = objCurrEduClsEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduClsEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.EduClsName);
 var strEduClsName = objCurrEduClsEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduClsEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.EduClsTypeId);
 var strEduClsTypeId = objCurrEduClsEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduClsEN.CourseId  ==  "")
 {
 objCurrEduClsEN.CourseId = null;
 }
 if (objCurrEduClsEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CourseId);
 var strCourseId = objCurrEduClsEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduClsEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduClsEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduClsEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdXzCollege);
 var strIdXzCollege = objCurrEduClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduClsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdXzMajor);
 var strIdXzMajor = objCurrEduClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCurrEduClsEN.IdEduWay  ==  "")
 {
 objCurrEduClsEN.IdEduWay = null;
 }
 if (objCurrEduClsEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdEduWay);
 var strIdEduWay = objCurrEduClsEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduClsEN.IdClassRoomType  ==  "")
 {
 objCurrEduClsEN.IdClassRoomType = null;
 }
 if (objCurrEduClsEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdClassRoomType);
 var strIdClassRoomType = objCurrEduClsEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduClsEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduClsEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduClsEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduClsEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduClsEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.WeekQty);
 arrValueListForInsert.Add(objCurrEduClsEN.WeekQty.ToString());
 }
 
 if (objCurrEduClsEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduClsEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduClsEN.WeekStatusId  ==  "")
 {
 objCurrEduClsEN.WeekStatusId = null;
 }
 if (objCurrEduClsEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.WeekStatusId);
 var strWeekStatusId = objCurrEduClsEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduClsEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CustomerWeek);
 var strCustomerWeek = objCurrEduClsEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 if (objCurrEduClsEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduClsEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduClsEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.Mark);
 arrValueListForInsert.Add(objCurrEduClsEN.Mark.ToString());
 }
 
 if (objCurrEduClsEN.IdUniZone  ==  "")
 {
 objCurrEduClsEN.IdUniZone = null;
 }
 if (objCurrEduClsEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdUniZone);
 var strIdUniZone = objCurrEduClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objCurrEduClsEN.IdGradeBase  ==  "")
 {
 objCurrEduClsEN.IdGradeBase = null;
 }
 if (objCurrEduClsEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdGradeBase);
 var strIdGradeBase = objCurrEduClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls.IsForPaperReading);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsForPaperReading  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.SchoolYear);
 var strSchoolYear = objCurrEduClsEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.SchoolTerm);
 var strSchoolTerm = objCurrEduClsEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdCourseType);
 var strIdCourseType = objCurrEduClsEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdScoreType);
 var strIdScoreType = objCurrEduClsEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduClsEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.GetScoreWayId);
 var strGetScoreWayId = objCurrEduClsEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdExamType);
 var strIdExamType = objCurrEduClsEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduClsEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ExamTime);
 var strExamTime = objCurrEduClsEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 if (objCurrEduClsEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.BeginWeek);
 arrValueListForInsert.Add(objCurrEduClsEN.BeginWeek.ToString());
 }
 
 if (objCurrEduClsEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.UserType);
 var strUserType = objCurrEduClsEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objCurrEduClsEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ModifyDate);
 var strModifyDate = objCurrEduClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ModifyUserId);
 var strModifyUserId = objCurrEduClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduClsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.Memo);
 var strMemo = objCurrEduClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCurrEduClsEN.IdCurrEduCls;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduClsEN objCurrEduClsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCurrEduClsEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCurrEduClsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CurrEduClsId);
 var strCurrEduClsId = objCurrEduClsEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduClsEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.EduClsName);
 var strEduClsName = objCurrEduClsEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduClsEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.EduClsTypeId);
 var strEduClsTypeId = objCurrEduClsEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduClsEN.CourseId  ==  "")
 {
 objCurrEduClsEN.CourseId = null;
 }
 if (objCurrEduClsEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CourseId);
 var strCourseId = objCurrEduClsEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduClsEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduClsEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduClsEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdXzCollege);
 var strIdXzCollege = objCurrEduClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduClsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdXzMajor);
 var strIdXzMajor = objCurrEduClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCurrEduClsEN.IdEduWay  ==  "")
 {
 objCurrEduClsEN.IdEduWay = null;
 }
 if (objCurrEduClsEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdEduWay);
 var strIdEduWay = objCurrEduClsEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduClsEN.IdClassRoomType  ==  "")
 {
 objCurrEduClsEN.IdClassRoomType = null;
 }
 if (objCurrEduClsEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdClassRoomType);
 var strIdClassRoomType = objCurrEduClsEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduClsEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduClsEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduClsEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduClsEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduClsEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.WeekQty);
 arrValueListForInsert.Add(objCurrEduClsEN.WeekQty.ToString());
 }
 
 if (objCurrEduClsEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduClsEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduClsEN.WeekStatusId  ==  "")
 {
 objCurrEduClsEN.WeekStatusId = null;
 }
 if (objCurrEduClsEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.WeekStatusId);
 var strWeekStatusId = objCurrEduClsEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduClsEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CustomerWeek);
 var strCustomerWeek = objCurrEduClsEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 if (objCurrEduClsEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduClsEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduClsEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.Mark);
 arrValueListForInsert.Add(objCurrEduClsEN.Mark.ToString());
 }
 
 if (objCurrEduClsEN.IdUniZone  ==  "")
 {
 objCurrEduClsEN.IdUniZone = null;
 }
 if (objCurrEduClsEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdUniZone);
 var strIdUniZone = objCurrEduClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objCurrEduClsEN.IdGradeBase  ==  "")
 {
 objCurrEduClsEN.IdGradeBase = null;
 }
 if (objCurrEduClsEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdGradeBase);
 var strIdGradeBase = objCurrEduClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls.IsForPaperReading);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsForPaperReading  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.SchoolYear);
 var strSchoolYear = objCurrEduClsEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.SchoolTerm);
 var strSchoolTerm = objCurrEduClsEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdCourseType);
 var strIdCourseType = objCurrEduClsEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdScoreType);
 var strIdScoreType = objCurrEduClsEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduClsEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.GetScoreWayId);
 var strGetScoreWayId = objCurrEduClsEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdExamType);
 var strIdExamType = objCurrEduClsEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduClsEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ExamTime);
 var strExamTime = objCurrEduClsEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 if (objCurrEduClsEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.BeginWeek);
 arrValueListForInsert.Add(objCurrEduClsEN.BeginWeek.ToString());
 }
 
 if (objCurrEduClsEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.UserType);
 var strUserType = objCurrEduClsEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objCurrEduClsEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ModifyDate);
 var strModifyDate = objCurrEduClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ModifyUserId);
 var strModifyUserId = objCurrEduClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduClsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.Memo);
 var strMemo = objCurrEduClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCurrEduClsEN.IdCurrEduCls;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduClsEN objCurrEduClsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCurrEduClsEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCurrEduClsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CurrEduClsId);
 var strCurrEduClsId = objCurrEduClsEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduClsEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.EduClsName);
 var strEduClsName = objCurrEduClsEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduClsEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.EduClsTypeId);
 var strEduClsTypeId = objCurrEduClsEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduClsEN.CourseId  ==  "")
 {
 objCurrEduClsEN.CourseId = null;
 }
 if (objCurrEduClsEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CourseId);
 var strCourseId = objCurrEduClsEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduClsEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduClsEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduClsEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdXzCollege);
 var strIdXzCollege = objCurrEduClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduClsEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdXzMajor);
 var strIdXzMajor = objCurrEduClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCurrEduClsEN.IdEduWay  ==  "")
 {
 objCurrEduClsEN.IdEduWay = null;
 }
 if (objCurrEduClsEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdEduWay);
 var strIdEduWay = objCurrEduClsEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduClsEN.IdClassRoomType  ==  "")
 {
 objCurrEduClsEN.IdClassRoomType = null;
 }
 if (objCurrEduClsEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdClassRoomType);
 var strIdClassRoomType = objCurrEduClsEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduClsEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduClsEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduClsEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduClsEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduClsEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.WeekQty);
 arrValueListForInsert.Add(objCurrEduClsEN.WeekQty.ToString());
 }
 
 if (objCurrEduClsEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduClsEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduClsEN.WeekStatusId  ==  "")
 {
 objCurrEduClsEN.WeekStatusId = null;
 }
 if (objCurrEduClsEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.WeekStatusId);
 var strWeekStatusId = objCurrEduClsEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduClsEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.CustomerWeek);
 var strCustomerWeek = objCurrEduClsEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 if (objCurrEduClsEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduClsEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduClsEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.Mark);
 arrValueListForInsert.Add(objCurrEduClsEN.Mark.ToString());
 }
 
 if (objCurrEduClsEN.IdUniZone  ==  "")
 {
 objCurrEduClsEN.IdUniZone = null;
 }
 if (objCurrEduClsEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdUniZone);
 var strIdUniZone = objCurrEduClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objCurrEduClsEN.IdGradeBase  ==  "")
 {
 objCurrEduClsEN.IdGradeBase = null;
 }
 if (objCurrEduClsEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdGradeBase);
 var strIdGradeBase = objCurrEduClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls.IsForPaperReading);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsForPaperReading  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.SchoolYear);
 var strSchoolYear = objCurrEduClsEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.SchoolTerm);
 var strSchoolTerm = objCurrEduClsEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdCourseType);
 var strIdCourseType = objCurrEduClsEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdScoreType);
 var strIdScoreType = objCurrEduClsEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduClsEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.GetScoreWayId);
 var strGetScoreWayId = objCurrEduClsEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduClsEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.IdExamType);
 var strIdExamType = objCurrEduClsEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduClsEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ExamTime);
 var strExamTime = objCurrEduClsEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 if (objCurrEduClsEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.BeginWeek);
 arrValueListForInsert.Add(objCurrEduClsEN.BeginWeek.ToString());
 }
 
 if (objCurrEduClsEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.UserType);
 var strUserType = objCurrEduClsEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objCurrEduClsEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ModifyDate);
 var strModifyDate = objCurrEduClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.ModifyUserId);
 var strModifyUserId = objCurrEduClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduClsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls.Memo);
 var strMemo = objCurrEduClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCurrEduClss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls where IdCurrEduCls = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduCls");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdCurrEduCls = oRow[conCurrEduCls.IdCurrEduCls].ToString().Trim();
if (IsExist(strIdCurrEduCls))
{
 string strResult = "关键字变量值为:" + string.Format("IdCurrEduCls = {0}", strIdCurrEduCls) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCurrEduClsEN._CurrTabName ].NewRow();
objRow[conCurrEduCls.IdCurrEduCls] = oRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conCurrEduCls.CurrEduClsId] = oRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objRow[conCurrEduCls.EduClsName] = oRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objRow[conCurrEduCls.EduClsTypeId] = oRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objRow[conCurrEduCls.CourseId] = oRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objRow[conCurrEduCls.TeachingSolutionId] = oRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objRow[conCurrEduCls.IdXzCollege] = oRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conCurrEduCls.IdXzMajor] = oRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conCurrEduCls.IdEduWay] = oRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objRow[conCurrEduCls.IdClassRoomType] = oRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objRow[conCurrEduCls.TotalLessonQty] = oRow[conCurrEduCls.TotalLessonQty].ToString().Trim(); //总课时数
objRow[conCurrEduCls.MaxStuQty] = oRow[conCurrEduCls.MaxStuQty].ToString().Trim(); //最大学生数
objRow[conCurrEduCls.WeekQty] = oRow[conCurrEduCls.WeekQty].ToString().Trim(); //总周数
objRow[conCurrEduCls.ScheUnitPW] = oRow[conCurrEduCls.ScheUnitPW].ToString().Trim(); //周排课次数
objRow[conCurrEduCls.WeekStatusId] = oRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objRow[conCurrEduCls.CustomerWeek] = oRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objRow[conCurrEduCls.LessonQtyPerWeek] = oRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim(); //周课时数
objRow[conCurrEduCls.Mark] = oRow[conCurrEduCls.Mark].ToString().Trim(); //获得学分
objRow[conCurrEduCls.IdUniZone] = oRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objRow[conCurrEduCls.IdGradeBase] = oRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objRow[conCurrEduCls.IsEffective] = oRow[conCurrEduCls.IsEffective].ToString().Trim(); //是否有效
objRow[conCurrEduCls.IsForPaperReading] = oRow[conCurrEduCls.IsForPaperReading].ToString().Trim(); //是否参与论文阅读
objRow[conCurrEduCls.SchoolYear] = oRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objRow[conCurrEduCls.SchoolTerm] = oRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objRow[conCurrEduCls.IdCourseType] = oRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objRow[conCurrEduCls.IsDegree] = oRow[conCurrEduCls.IsDegree].ToString().Trim(); //是否学位课
objRow[conCurrEduCls.IdScoreType] = oRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objRow[conCurrEduCls.GetScoreWayId] = oRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objRow[conCurrEduCls.IsProportionalCtrl] = oRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim(); //是否比例控制
objRow[conCurrEduCls.IdExamType] = oRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objRow[conCurrEduCls.ExamTime] = oRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objRow[conCurrEduCls.BeginWeek] = oRow[conCurrEduCls.BeginWeek].ToString().Trim(); //开始周
objRow[conCurrEduCls.UserType] = oRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objRow[conCurrEduCls.ModifyDate] = oRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objRow[conCurrEduCls.ModifyUserId] = oRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objRow[conCurrEduCls.Memo] = oRow[conCurrEduCls.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCurrEduClsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCurrEduClsEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCurrEduClsEN objCurrEduClsEN)
{
 objCurrEduClsEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls where IdCurrEduCls = " + "'"+ objCurrEduClsEN.IdCurrEduCls+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCurrEduClsEN._CurrTabName);
if (objDS.Tables[clsCurrEduClsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCurrEduCls = " + "'"+ objCurrEduClsEN.IdCurrEduCls+"'");
return false;
}
objRow = objDS.Tables[clsCurrEduClsEN._CurrTabName].Rows[0];
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdCurrEduCls))
 {
objRow[conCurrEduCls.IdCurrEduCls] = objCurrEduClsEN.IdCurrEduCls; //教学班流水号
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CurrEduClsId))
 {
objRow[conCurrEduCls.CurrEduClsId] = objCurrEduClsEN.CurrEduClsId; //教学班Id
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.EduClsName))
 {
objRow[conCurrEduCls.EduClsName] = objCurrEduClsEN.EduClsName; //教学班名
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.EduClsTypeId))
 {
objRow[conCurrEduCls.EduClsTypeId] = objCurrEduClsEN.EduClsTypeId; //教学班类型Id
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CourseId))
 {
objRow[conCurrEduCls.CourseId] = objCurrEduClsEN.CourseId; //课程Id
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.TeachingSolutionId))
 {
objRow[conCurrEduCls.TeachingSolutionId] = objCurrEduClsEN.TeachingSolutionId; //教学方案Id
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdXzCollege))
 {
objRow[conCurrEduCls.IdXzCollege] = objCurrEduClsEN.IdXzCollege; //学院流水号
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdXzMajor))
 {
objRow[conCurrEduCls.IdXzMajor] = objCurrEduClsEN.IdXzMajor; //专业流水号
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdEduWay))
 {
objRow[conCurrEduCls.IdEduWay] = objCurrEduClsEN.IdEduWay; //教学方式流水号
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdClassRoomType))
 {
objRow[conCurrEduCls.IdClassRoomType] = objCurrEduClsEN.IdClassRoomType; //教室类型流水号
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.TotalLessonQty))
 {
objRow[conCurrEduCls.TotalLessonQty] = objCurrEduClsEN.TotalLessonQty; //总课时数
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.MaxStuQty))
 {
objRow[conCurrEduCls.MaxStuQty] = objCurrEduClsEN.MaxStuQty; //最大学生数
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.WeekQty))
 {
objRow[conCurrEduCls.WeekQty] = objCurrEduClsEN.WeekQty; //总周数
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ScheUnitPW))
 {
objRow[conCurrEduCls.ScheUnitPW] = objCurrEduClsEN.ScheUnitPW; //周排课次数
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.WeekStatusId))
 {
objRow[conCurrEduCls.WeekStatusId] = objCurrEduClsEN.WeekStatusId; //周状态编号(单,双,全周)
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CustomerWeek))
 {
objRow[conCurrEduCls.CustomerWeek] = objCurrEduClsEN.CustomerWeek; //自定义上课周
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.LessonQtyPerWeek))
 {
objRow[conCurrEduCls.LessonQtyPerWeek] = objCurrEduClsEN.LessonQtyPerWeek; //周课时数
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.Mark))
 {
objRow[conCurrEduCls.Mark] = objCurrEduClsEN.Mark; //获得学分
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdUniZone))
 {
objRow[conCurrEduCls.IdUniZone] = objCurrEduClsEN.IdUniZone; //校区流水号
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdGradeBase))
 {
objRow[conCurrEduCls.IdGradeBase] = objCurrEduClsEN.IdGradeBase; //年级流水号
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsEffective))
 {
objRow[conCurrEduCls.IsEffective] = objCurrEduClsEN.IsEffective; //是否有效
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsForPaperReading))
 {
objRow[conCurrEduCls.IsForPaperReading] = objCurrEduClsEN.IsForPaperReading; //是否参与论文阅读
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.SchoolYear))
 {
objRow[conCurrEduCls.SchoolYear] = objCurrEduClsEN.SchoolYear; //学年
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.SchoolTerm))
 {
objRow[conCurrEduCls.SchoolTerm] = objCurrEduClsEN.SchoolTerm; //学期
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdCourseType))
 {
objRow[conCurrEduCls.IdCourseType] = objCurrEduClsEN.IdCourseType; //课程类型流水号
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsDegree))
 {
objRow[conCurrEduCls.IsDegree] = objCurrEduClsEN.IsDegree; //是否学位课
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdScoreType))
 {
objRow[conCurrEduCls.IdScoreType] = objCurrEduClsEN.IdScoreType; //成绩类型流水号
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.GetScoreWayId))
 {
objRow[conCurrEduCls.GetScoreWayId] = objCurrEduClsEN.GetScoreWayId; //获得成绩方式Id
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsProportionalCtrl))
 {
objRow[conCurrEduCls.IsProportionalCtrl] = objCurrEduClsEN.IsProportionalCtrl; //是否比例控制
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdExamType))
 {
objRow[conCurrEduCls.IdExamType] = objCurrEduClsEN.IdExamType; //考试方式流水号
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ExamTime))
 {
objRow[conCurrEduCls.ExamTime] = objCurrEduClsEN.ExamTime; //考试时间
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.BeginWeek))
 {
objRow[conCurrEduCls.BeginWeek] = objCurrEduClsEN.BeginWeek; //开始周
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.UserType))
 {
objRow[conCurrEduCls.UserType] = objCurrEduClsEN.UserType; //用户类型
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ModifyDate))
 {
objRow[conCurrEduCls.ModifyDate] = objCurrEduClsEN.ModifyDate; //修改日期
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ModifyUserId))
 {
objRow[conCurrEduCls.ModifyUserId] = objCurrEduClsEN.ModifyUserId; //修改人
 }
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.Memo))
 {
objRow[conCurrEduCls.Memo] = objCurrEduClsEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCurrEduClsEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduClsEN objCurrEduClsEN)
{
 objCurrEduClsEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CurrEduCls Set ");
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CurrEduClsId))
 {
 if (objCurrEduClsEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduClsEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCurrEduClsId, conCurrEduCls.CurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.CurrEduClsId); //教学班Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.EduClsName))
 {
 if (objCurrEduClsEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduClsEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsName, conCurrEduCls.EduClsName); //教学班名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.EduClsName); //教学班名
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.EduClsTypeId))
 {
 if (objCurrEduClsEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduClsEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsTypeId, conCurrEduCls.EduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.EduClsTypeId); //教学班类型Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CourseId))
 {
 if (objCurrEduClsEN.CourseId  ==  "")
 {
 objCurrEduClsEN.CourseId = null;
 }
 if (objCurrEduClsEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduClsEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCurrEduCls.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.CourseId); //课程Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.TeachingSolutionId))
 {
 if (objCurrEduClsEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduClsEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingSolutionId, conCurrEduCls.TeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.TeachingSolutionId); //教学方案Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdXzCollege))
 {
 if (objCurrEduClsEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCurrEduCls.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdXzCollege); //学院流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdXzMajor))
 {
 if (objCurrEduClsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCurrEduClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conCurrEduCls.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdXzMajor); //专业流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdEduWay))
 {
 if (objCurrEduClsEN.IdEduWay  ==  "")
 {
 objCurrEduClsEN.IdEduWay = null;
 }
 if (objCurrEduClsEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduClsEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduWay, conCurrEduCls.IdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdEduWay); //教学方式流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdClassRoomType))
 {
 if (objCurrEduClsEN.IdClassRoomType  ==  "")
 {
 objCurrEduClsEN.IdClassRoomType = null;
 }
 if (objCurrEduClsEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduClsEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdClassRoomType, conCurrEduCls.IdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdClassRoomType); //教室类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.TotalLessonQty))
 {
 if (objCurrEduClsEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.TotalLessonQty, conCurrEduCls.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.MaxStuQty))
 {
 if (objCurrEduClsEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.MaxStuQty, conCurrEduCls.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.WeekQty))
 {
 if (objCurrEduClsEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.WeekQty, conCurrEduCls.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.WeekQty); //总周数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ScheUnitPW))
 {
 if (objCurrEduClsEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.ScheUnitPW, conCurrEduCls.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.WeekStatusId))
 {
 if (objCurrEduClsEN.WeekStatusId  ==  "")
 {
 objCurrEduClsEN.WeekStatusId = null;
 }
 if (objCurrEduClsEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduClsEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekStatusId, conCurrEduCls.WeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.WeekStatusId); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CustomerWeek))
 {
 if (objCurrEduClsEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduClsEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCustomerWeek, conCurrEduCls.CustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.CustomerWeek); //自定义上课周
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.LessonQtyPerWeek))
 {
 if (objCurrEduClsEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.LessonQtyPerWeek, conCurrEduCls.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.Mark))
 {
 if (objCurrEduClsEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.Mark, conCurrEduCls.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.Mark); //获得学分
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdUniZone))
 {
 if (objCurrEduClsEN.IdUniZone  ==  "")
 {
 objCurrEduClsEN.IdUniZone = null;
 }
 if (objCurrEduClsEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conCurrEduCls.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdUniZone); //校区流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdGradeBase))
 {
 if (objCurrEduClsEN.IdGradeBase  ==  "")
 {
 objCurrEduClsEN.IdGradeBase = null;
 }
 if (objCurrEduClsEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conCurrEduCls.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdGradeBase); //年级流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsEffective))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsEN.IsEffective == true?"1":"0", conCurrEduCls.IsEffective); //是否有效
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsForPaperReading))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsEN.IsForPaperReading == true?"1":"0", conCurrEduCls.IsForPaperReading); //是否参与论文阅读
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.SchoolYear))
 {
 if (objCurrEduClsEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduCls.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.SchoolYear); //学年
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.SchoolTerm))
 {
 if (objCurrEduClsEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduCls.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdCourseType))
 {
 if (objCurrEduClsEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduClsEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCourseType, conCurrEduCls.IdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdCourseType); //课程类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsDegree))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsEN.IsDegree == true?"1":"0", conCurrEduCls.IsDegree); //是否学位课
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdScoreType))
 {
 if (objCurrEduClsEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduClsEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdScoreType, conCurrEduCls.IdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdScoreType); //成绩类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.GetScoreWayId))
 {
 if (objCurrEduClsEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduClsEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetScoreWayId, conCurrEduCls.GetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.GetScoreWayId); //获得成绩方式Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsEN.IsProportionalCtrl == true?"1":"0", conCurrEduCls.IsProportionalCtrl); //是否比例控制
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdExamType))
 {
 if (objCurrEduClsEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduClsEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExamType, conCurrEduCls.IdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdExamType); //考试方式流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ExamTime))
 {
 if (objCurrEduClsEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduClsEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamTime, conCurrEduCls.ExamTime); //考试时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.ExamTime); //考试时间
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.BeginWeek))
 {
 if (objCurrEduClsEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.BeginWeek, conCurrEduCls.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.UserType))
 {
 if (objCurrEduClsEN.UserType !=  null)
 {
 var strUserType = objCurrEduClsEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserType, conCurrEduCls.UserType); //用户类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.UserType); //用户类型
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ModifyDate))
 {
 if (objCurrEduClsEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conCurrEduCls.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.ModifyDate); //修改日期
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ModifyUserId))
 {
 if (objCurrEduClsEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conCurrEduCls.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.ModifyUserId); //修改人
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.Memo))
 {
 if (objCurrEduClsEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduCls.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCurrEduCls = '{0}'", objCurrEduClsEN.IdCurrEduCls); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCurrEduClsEN objCurrEduClsEN, string strCondition)
{
 objCurrEduClsEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduCls Set ");
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CurrEduClsId))
 {
 if (objCurrEduClsEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduClsEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CurrEduClsId = '{0}',", strCurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.Append(" CurrEduClsId = null,"); //教学班Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.EduClsName))
 {
 if (objCurrEduClsEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduClsEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsName = '{0}',", strEduClsName); //教学班名
 }
 else
 {
 sbSQL.Append(" EduClsName = null,"); //教学班名
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.EduClsTypeId))
 {
 if (objCurrEduClsEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduClsEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsTypeId = '{0}',", strEduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.Append(" EduClsTypeId = null,"); //教学班类型Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CourseId))
 {
 if (objCurrEduClsEN.CourseId  ==  "")
 {
 objCurrEduClsEN.CourseId = null;
 }
 if (objCurrEduClsEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduClsEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.TeachingSolutionId))
 {
 if (objCurrEduClsEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduClsEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingSolutionId = '{0}',", strTeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.Append(" TeachingSolutionId = null,"); //教学方案Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdXzCollege))
 {
 if (objCurrEduClsEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdXzMajor))
 {
 if (objCurrEduClsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCurrEduClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdEduWay))
 {
 if (objCurrEduClsEN.IdEduWay  ==  "")
 {
 objCurrEduClsEN.IdEduWay = null;
 }
 if (objCurrEduClsEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduClsEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduWay = '{0}',", strIdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.Append(" IdEduWay = null,"); //教学方式流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdClassRoomType))
 {
 if (objCurrEduClsEN.IdClassRoomType  ==  "")
 {
 objCurrEduClsEN.IdClassRoomType = null;
 }
 if (objCurrEduClsEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduClsEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdClassRoomType = '{0}',", strIdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.Append(" IdClassRoomType = null,"); //教室类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.TotalLessonQty))
 {
 if (objCurrEduClsEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.TotalLessonQty, conCurrEduCls.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.MaxStuQty))
 {
 if (objCurrEduClsEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.MaxStuQty, conCurrEduCls.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.WeekQty))
 {
 if (objCurrEduClsEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.WeekQty, conCurrEduCls.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.WeekQty); //总周数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ScheUnitPW))
 {
 if (objCurrEduClsEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.ScheUnitPW, conCurrEduCls.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.WeekStatusId))
 {
 if (objCurrEduClsEN.WeekStatusId  ==  "")
 {
 objCurrEduClsEN.WeekStatusId = null;
 }
 if (objCurrEduClsEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduClsEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekStatusId = '{0}',", strWeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.Append(" WeekStatusId = null,"); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CustomerWeek))
 {
 if (objCurrEduClsEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduClsEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CustomerWeek = '{0}',", strCustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.Append(" CustomerWeek = null,"); //自定义上课周
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.LessonQtyPerWeek))
 {
 if (objCurrEduClsEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.LessonQtyPerWeek, conCurrEduCls.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.Mark))
 {
 if (objCurrEduClsEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.Mark, conCurrEduCls.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.Mark); //获得学分
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdUniZone))
 {
 if (objCurrEduClsEN.IdUniZone  ==  "")
 {
 objCurrEduClsEN.IdUniZone = null;
 }
 if (objCurrEduClsEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdGradeBase))
 {
 if (objCurrEduClsEN.IdGradeBase  ==  "")
 {
 objCurrEduClsEN.IdGradeBase = null;
 }
 if (objCurrEduClsEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsEffective))
 {
 sbSQL.AppendFormat(" IsEffective = '{0}',", objCurrEduClsEN.IsEffective == true?"1":"0"); //是否有效
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsForPaperReading))
 {
 sbSQL.AppendFormat(" IsForPaperReading = '{0}',", objCurrEduClsEN.IsForPaperReading == true?"1":"0"); //是否参与论文阅读
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.SchoolYear))
 {
 if (objCurrEduClsEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.SchoolTerm))
 {
 if (objCurrEduClsEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdCourseType))
 {
 if (objCurrEduClsEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduClsEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCourseType = '{0}',", strIdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.Append(" IdCourseType = null,"); //课程类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsDegree))
 {
 sbSQL.AppendFormat(" IsDegree = '{0}',", objCurrEduClsEN.IsDegree == true?"1":"0"); //是否学位课
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdScoreType))
 {
 if (objCurrEduClsEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduClsEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdScoreType = '{0}',", strIdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.Append(" IdScoreType = null,"); //成绩类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.GetScoreWayId))
 {
 if (objCurrEduClsEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduClsEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetScoreWayId = '{0}',", strGetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.Append(" GetScoreWayId = null,"); //获得成绩方式Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" IsProportionalCtrl = '{0}',", objCurrEduClsEN.IsProportionalCtrl == true?"1":"0"); //是否比例控制
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdExamType))
 {
 if (objCurrEduClsEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduClsEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExamType = '{0}',", strIdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.Append(" IdExamType = null,"); //考试方式流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ExamTime))
 {
 if (objCurrEduClsEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduClsEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamTime = '{0}',", strExamTime); //考试时间
 }
 else
 {
 sbSQL.Append(" ExamTime = null,"); //考试时间
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.BeginWeek))
 {
 if (objCurrEduClsEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.BeginWeek, conCurrEduCls.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.UserType))
 {
 if (objCurrEduClsEN.UserType !=  null)
 {
 var strUserType = objCurrEduClsEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserType = '{0}',", strUserType); //用户类型
 }
 else
 {
 sbSQL.Append(" UserType = null,"); //用户类型
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ModifyDate))
 {
 if (objCurrEduClsEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ModifyUserId))
 {
 if (objCurrEduClsEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.Memo))
 {
 if (objCurrEduClsEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCurrEduClsEN objCurrEduClsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCurrEduClsEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduCls Set ");
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CurrEduClsId))
 {
 if (objCurrEduClsEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduClsEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CurrEduClsId = '{0}',", strCurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.Append(" CurrEduClsId = null,"); //教学班Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.EduClsName))
 {
 if (objCurrEduClsEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduClsEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsName = '{0}',", strEduClsName); //教学班名
 }
 else
 {
 sbSQL.Append(" EduClsName = null,"); //教学班名
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.EduClsTypeId))
 {
 if (objCurrEduClsEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduClsEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsTypeId = '{0}',", strEduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.Append(" EduClsTypeId = null,"); //教学班类型Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CourseId))
 {
 if (objCurrEduClsEN.CourseId  ==  "")
 {
 objCurrEduClsEN.CourseId = null;
 }
 if (objCurrEduClsEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduClsEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.TeachingSolutionId))
 {
 if (objCurrEduClsEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduClsEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingSolutionId = '{0}',", strTeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.Append(" TeachingSolutionId = null,"); //教学方案Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdXzCollege))
 {
 if (objCurrEduClsEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdXzMajor))
 {
 if (objCurrEduClsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCurrEduClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdEduWay))
 {
 if (objCurrEduClsEN.IdEduWay  ==  "")
 {
 objCurrEduClsEN.IdEduWay = null;
 }
 if (objCurrEduClsEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduClsEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduWay = '{0}',", strIdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.Append(" IdEduWay = null,"); //教学方式流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdClassRoomType))
 {
 if (objCurrEduClsEN.IdClassRoomType  ==  "")
 {
 objCurrEduClsEN.IdClassRoomType = null;
 }
 if (objCurrEduClsEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduClsEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdClassRoomType = '{0}',", strIdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.Append(" IdClassRoomType = null,"); //教室类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.TotalLessonQty))
 {
 if (objCurrEduClsEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.TotalLessonQty, conCurrEduCls.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.MaxStuQty))
 {
 if (objCurrEduClsEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.MaxStuQty, conCurrEduCls.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.WeekQty))
 {
 if (objCurrEduClsEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.WeekQty, conCurrEduCls.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.WeekQty); //总周数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ScheUnitPW))
 {
 if (objCurrEduClsEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.ScheUnitPW, conCurrEduCls.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.WeekStatusId))
 {
 if (objCurrEduClsEN.WeekStatusId  ==  "")
 {
 objCurrEduClsEN.WeekStatusId = null;
 }
 if (objCurrEduClsEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduClsEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekStatusId = '{0}',", strWeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.Append(" WeekStatusId = null,"); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CustomerWeek))
 {
 if (objCurrEduClsEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduClsEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CustomerWeek = '{0}',", strCustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.Append(" CustomerWeek = null,"); //自定义上课周
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.LessonQtyPerWeek))
 {
 if (objCurrEduClsEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.LessonQtyPerWeek, conCurrEduCls.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.Mark))
 {
 if (objCurrEduClsEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.Mark, conCurrEduCls.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.Mark); //获得学分
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdUniZone))
 {
 if (objCurrEduClsEN.IdUniZone  ==  "")
 {
 objCurrEduClsEN.IdUniZone = null;
 }
 if (objCurrEduClsEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdGradeBase))
 {
 if (objCurrEduClsEN.IdGradeBase  ==  "")
 {
 objCurrEduClsEN.IdGradeBase = null;
 }
 if (objCurrEduClsEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsEffective))
 {
 sbSQL.AppendFormat(" IsEffective = '{0}',", objCurrEduClsEN.IsEffective == true?"1":"0"); //是否有效
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsForPaperReading))
 {
 sbSQL.AppendFormat(" IsForPaperReading = '{0}',", objCurrEduClsEN.IsForPaperReading == true?"1":"0"); //是否参与论文阅读
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.SchoolYear))
 {
 if (objCurrEduClsEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.SchoolTerm))
 {
 if (objCurrEduClsEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdCourseType))
 {
 if (objCurrEduClsEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduClsEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCourseType = '{0}',", strIdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.Append(" IdCourseType = null,"); //课程类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsDegree))
 {
 sbSQL.AppendFormat(" IsDegree = '{0}',", objCurrEduClsEN.IsDegree == true?"1":"0"); //是否学位课
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdScoreType))
 {
 if (objCurrEduClsEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduClsEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdScoreType = '{0}',", strIdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.Append(" IdScoreType = null,"); //成绩类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.GetScoreWayId))
 {
 if (objCurrEduClsEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduClsEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetScoreWayId = '{0}',", strGetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.Append(" GetScoreWayId = null,"); //获得成绩方式Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" IsProportionalCtrl = '{0}',", objCurrEduClsEN.IsProportionalCtrl == true?"1":"0"); //是否比例控制
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdExamType))
 {
 if (objCurrEduClsEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduClsEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExamType = '{0}',", strIdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.Append(" IdExamType = null,"); //考试方式流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ExamTime))
 {
 if (objCurrEduClsEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduClsEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamTime = '{0}',", strExamTime); //考试时间
 }
 else
 {
 sbSQL.Append(" ExamTime = null,"); //考试时间
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.BeginWeek))
 {
 if (objCurrEduClsEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.BeginWeek, conCurrEduCls.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.UserType))
 {
 if (objCurrEduClsEN.UserType !=  null)
 {
 var strUserType = objCurrEduClsEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserType = '{0}',", strUserType); //用户类型
 }
 else
 {
 sbSQL.Append(" UserType = null,"); //用户类型
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ModifyDate))
 {
 if (objCurrEduClsEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ModifyUserId))
 {
 if (objCurrEduClsEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.Memo))
 {
 if (objCurrEduClsEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduClsEN objCurrEduClsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCurrEduClsEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduCls Set ");
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CurrEduClsId))
 {
 if (objCurrEduClsEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduClsEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCurrEduClsId, conCurrEduCls.CurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.CurrEduClsId); //教学班Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.EduClsName))
 {
 if (objCurrEduClsEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduClsEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsName, conCurrEduCls.EduClsName); //教学班名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.EduClsName); //教学班名
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.EduClsTypeId))
 {
 if (objCurrEduClsEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduClsEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsTypeId, conCurrEduCls.EduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.EduClsTypeId); //教学班类型Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CourseId))
 {
 if (objCurrEduClsEN.CourseId  ==  "")
 {
 objCurrEduClsEN.CourseId = null;
 }
 if (objCurrEduClsEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduClsEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCurrEduCls.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.CourseId); //课程Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.TeachingSolutionId))
 {
 if (objCurrEduClsEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduClsEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingSolutionId, conCurrEduCls.TeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.TeachingSolutionId); //教学方案Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdXzCollege))
 {
 if (objCurrEduClsEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduClsEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCurrEduCls.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdXzCollege); //学院流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdXzMajor))
 {
 if (objCurrEduClsEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCurrEduClsEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conCurrEduCls.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdXzMajor); //专业流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdEduWay))
 {
 if (objCurrEduClsEN.IdEduWay  ==  "")
 {
 objCurrEduClsEN.IdEduWay = null;
 }
 if (objCurrEduClsEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduClsEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduWay, conCurrEduCls.IdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdEduWay); //教学方式流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdClassRoomType))
 {
 if (objCurrEduClsEN.IdClassRoomType  ==  "")
 {
 objCurrEduClsEN.IdClassRoomType = null;
 }
 if (objCurrEduClsEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduClsEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdClassRoomType, conCurrEduCls.IdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdClassRoomType); //教室类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.TotalLessonQty))
 {
 if (objCurrEduClsEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.TotalLessonQty, conCurrEduCls.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.MaxStuQty))
 {
 if (objCurrEduClsEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.MaxStuQty, conCurrEduCls.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.WeekQty))
 {
 if (objCurrEduClsEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.WeekQty, conCurrEduCls.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.WeekQty); //总周数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ScheUnitPW))
 {
 if (objCurrEduClsEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.ScheUnitPW, conCurrEduCls.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.WeekStatusId))
 {
 if (objCurrEduClsEN.WeekStatusId  ==  "")
 {
 objCurrEduClsEN.WeekStatusId = null;
 }
 if (objCurrEduClsEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduClsEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekStatusId, conCurrEduCls.WeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.WeekStatusId); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.CustomerWeek))
 {
 if (objCurrEduClsEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduClsEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCustomerWeek, conCurrEduCls.CustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.CustomerWeek); //自定义上课周
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.LessonQtyPerWeek))
 {
 if (objCurrEduClsEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.LessonQtyPerWeek, conCurrEduCls.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.Mark))
 {
 if (objCurrEduClsEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.Mark, conCurrEduCls.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.Mark); //获得学分
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdUniZone))
 {
 if (objCurrEduClsEN.IdUniZone  ==  "")
 {
 objCurrEduClsEN.IdUniZone = null;
 }
 if (objCurrEduClsEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduClsEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conCurrEduCls.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdUniZone); //校区流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdGradeBase))
 {
 if (objCurrEduClsEN.IdGradeBase  ==  "")
 {
 objCurrEduClsEN.IdGradeBase = null;
 }
 if (objCurrEduClsEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduClsEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conCurrEduCls.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdGradeBase); //年级流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsEffective))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsEN.IsEffective == true?"1":"0", conCurrEduCls.IsEffective); //是否有效
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsForPaperReading))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsEN.IsForPaperReading == true?"1":"0", conCurrEduCls.IsForPaperReading); //是否参与论文阅读
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.SchoolYear))
 {
 if (objCurrEduClsEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduCls.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.SchoolYear); //学年
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.SchoolTerm))
 {
 if (objCurrEduClsEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduCls.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdCourseType))
 {
 if (objCurrEduClsEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduClsEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCourseType, conCurrEduCls.IdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdCourseType); //课程类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsDegree))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsEN.IsDegree == true?"1":"0", conCurrEduCls.IsDegree); //是否学位课
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdScoreType))
 {
 if (objCurrEduClsEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduClsEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdScoreType, conCurrEduCls.IdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdScoreType); //成绩类型流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.GetScoreWayId))
 {
 if (objCurrEduClsEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduClsEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetScoreWayId, conCurrEduCls.GetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.GetScoreWayId); //获得成绩方式Id
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsEN.IsProportionalCtrl == true?"1":"0", conCurrEduCls.IsProportionalCtrl); //是否比例控制
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.IdExamType))
 {
 if (objCurrEduClsEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduClsEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExamType, conCurrEduCls.IdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.IdExamType); //考试方式流水号
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ExamTime))
 {
 if (objCurrEduClsEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduClsEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamTime, conCurrEduCls.ExamTime); //考试时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.ExamTime); //考试时间
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.BeginWeek))
 {
 if (objCurrEduClsEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsEN.BeginWeek, conCurrEduCls.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.UserType))
 {
 if (objCurrEduClsEN.UserType !=  null)
 {
 var strUserType = objCurrEduClsEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserType, conCurrEduCls.UserType); //用户类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.UserType); //用户类型
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ModifyDate))
 {
 if (objCurrEduClsEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conCurrEduCls.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.ModifyDate); //修改日期
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.ModifyUserId))
 {
 if (objCurrEduClsEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduClsEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conCurrEduCls.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.ModifyUserId); //修改人
 }
 }
 
 if (objCurrEduClsEN.IsUpdated(conCurrEduCls.Memo))
 {
 if (objCurrEduClsEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduCls.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCurrEduCls = '{0}'", objCurrEduClsEN.IdCurrEduCls); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdCurrEduCls) 
{
CheckPrimaryKey(strIdCurrEduCls);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdCurrEduCls,
};
 objSQL.ExecSP("CurrEduCls_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdCurrEduCls);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
//删除CurrEduCls本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduCls where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCurrEduCls(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除CurrEduCls本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduCls where IdCurrEduCls in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdCurrEduCls) 
{
CheckPrimaryKey(strIdCurrEduCls);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
//删除CurrEduCls本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduCls where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCurrEduCls(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCurrEduClsDA: DelCurrEduCls)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduCls where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelCurrEduClsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCurrEduClsDA: DelCurrEduClsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduCls where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objCurrEduClsENS">源对象</param>
 /// <param name = "objCurrEduClsENT">目标对象</param>
public void CopyTo(clsCurrEduClsEN objCurrEduClsENS, clsCurrEduClsEN objCurrEduClsENT)
{
objCurrEduClsENT.IdCurrEduCls = objCurrEduClsENS.IdCurrEduCls; //教学班流水号
objCurrEduClsENT.CurrEduClsId = objCurrEduClsENS.CurrEduClsId; //教学班Id
objCurrEduClsENT.EduClsName = objCurrEduClsENS.EduClsName; //教学班名
objCurrEduClsENT.EduClsTypeId = objCurrEduClsENS.EduClsTypeId; //教学班类型Id
objCurrEduClsENT.CourseId = objCurrEduClsENS.CourseId; //课程Id
objCurrEduClsENT.TeachingSolutionId = objCurrEduClsENS.TeachingSolutionId; //教学方案Id
objCurrEduClsENT.IdXzCollege = objCurrEduClsENS.IdXzCollege; //学院流水号
objCurrEduClsENT.IdXzMajor = objCurrEduClsENS.IdXzMajor; //专业流水号
objCurrEduClsENT.IdEduWay = objCurrEduClsENS.IdEduWay; //教学方式流水号
objCurrEduClsENT.IdClassRoomType = objCurrEduClsENS.IdClassRoomType; //教室类型流水号
objCurrEduClsENT.TotalLessonQty = objCurrEduClsENS.TotalLessonQty; //总课时数
objCurrEduClsENT.MaxStuQty = objCurrEduClsENS.MaxStuQty; //最大学生数
objCurrEduClsENT.WeekQty = objCurrEduClsENS.WeekQty; //总周数
objCurrEduClsENT.ScheUnitPW = objCurrEduClsENS.ScheUnitPW; //周排课次数
objCurrEduClsENT.WeekStatusId = objCurrEduClsENS.WeekStatusId; //周状态编号(单,双,全周)
objCurrEduClsENT.CustomerWeek = objCurrEduClsENS.CustomerWeek; //自定义上课周
objCurrEduClsENT.LessonQtyPerWeek = objCurrEduClsENS.LessonQtyPerWeek; //周课时数
objCurrEduClsENT.Mark = objCurrEduClsENS.Mark; //获得学分
objCurrEduClsENT.IdUniZone = objCurrEduClsENS.IdUniZone; //校区流水号
objCurrEduClsENT.IdGradeBase = objCurrEduClsENS.IdGradeBase; //年级流水号
objCurrEduClsENT.IsEffective = objCurrEduClsENS.IsEffective; //是否有效
objCurrEduClsENT.IsForPaperReading = objCurrEduClsENS.IsForPaperReading; //是否参与论文阅读
objCurrEduClsENT.SchoolYear = objCurrEduClsENS.SchoolYear; //学年
objCurrEduClsENT.SchoolTerm = objCurrEduClsENS.SchoolTerm; //学期
objCurrEduClsENT.IdCourseType = objCurrEduClsENS.IdCourseType; //课程类型流水号
objCurrEduClsENT.IsDegree = objCurrEduClsENS.IsDegree; //是否学位课
objCurrEduClsENT.IdScoreType = objCurrEduClsENS.IdScoreType; //成绩类型流水号
objCurrEduClsENT.GetScoreWayId = objCurrEduClsENS.GetScoreWayId; //获得成绩方式Id
objCurrEduClsENT.IsProportionalCtrl = objCurrEduClsENS.IsProportionalCtrl; //是否比例控制
objCurrEduClsENT.IdExamType = objCurrEduClsENS.IdExamType; //考试方式流水号
objCurrEduClsENT.ExamTime = objCurrEduClsENS.ExamTime; //考试时间
objCurrEduClsENT.BeginWeek = objCurrEduClsENS.BeginWeek; //开始周
objCurrEduClsENT.UserType = objCurrEduClsENS.UserType; //用户类型
objCurrEduClsENT.ModifyDate = objCurrEduClsENS.ModifyDate; //修改日期
objCurrEduClsENT.ModifyUserId = objCurrEduClsENS.ModifyUserId; //修改人
objCurrEduClsENT.Memo = objCurrEduClsENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCurrEduClsEN objCurrEduClsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCurrEduClsEN.CurrEduClsId, conCurrEduCls.CurrEduClsId);
clsCheckSql.CheckFieldNotNull(objCurrEduClsEN.EduClsName, conCurrEduCls.EduClsName);
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdCurrEduCls, 8, conCurrEduCls.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.CurrEduClsId, 15, conCurrEduCls.CurrEduClsId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.EduClsName, 100, conCurrEduCls.EduClsName);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.EduClsTypeId, 4, conCurrEduCls.EduClsTypeId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.CourseId, 8, conCurrEduCls.CourseId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.TeachingSolutionId, 8, conCurrEduCls.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdXzCollege, 4, conCurrEduCls.IdXzCollege);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdXzMajor, 8, conCurrEduCls.IdXzMajor);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdEduWay, 4, conCurrEduCls.IdEduWay);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdClassRoomType, 4, conCurrEduCls.IdClassRoomType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.WeekStatusId, 2, conCurrEduCls.WeekStatusId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.CustomerWeek, 50, conCurrEduCls.CustomerWeek);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdUniZone, 4, conCurrEduCls.IdUniZone);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdGradeBase, 4, conCurrEduCls.IdGradeBase);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.SchoolYear, 10, conCurrEduCls.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.SchoolTerm, 1, conCurrEduCls.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdCourseType, 4, conCurrEduCls.IdCourseType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdScoreType, 4, conCurrEduCls.IdScoreType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.GetScoreWayId, 2, conCurrEduCls.GetScoreWayId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdExamType, 4, conCurrEduCls.IdExamType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.ExamTime, 8, conCurrEduCls.ExamTime);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.UserType, 50, conCurrEduCls.UserType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.ModifyDate, 20, conCurrEduCls.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.ModifyUserId, 18, conCurrEduCls.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.Memo, 1000, conCurrEduCls.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.CourseId, 8, conCurrEduCls.CourseId);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdEduWay, 4, conCurrEduCls.IdEduWay);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdClassRoomType, 4, conCurrEduCls.IdClassRoomType);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.WeekStatusId, 2, conCurrEduCls.WeekStatusId);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdUniZone, 4, conCurrEduCls.IdUniZone);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdGradeBase, 4, conCurrEduCls.IdGradeBase);
 objCurrEduClsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCurrEduClsEN objCurrEduClsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsEN.CurrEduClsId, 15, conCurrEduCls.CurrEduClsId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.EduClsName, 100, conCurrEduCls.EduClsName);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.EduClsTypeId, 4, conCurrEduCls.EduClsTypeId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.CourseId, 8, conCurrEduCls.CourseId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.TeachingSolutionId, 8, conCurrEduCls.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdXzCollege, 4, conCurrEduCls.IdXzCollege);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdXzMajor, 8, conCurrEduCls.IdXzMajor);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdEduWay, 4, conCurrEduCls.IdEduWay);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdClassRoomType, 4, conCurrEduCls.IdClassRoomType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.WeekStatusId, 2, conCurrEduCls.WeekStatusId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.CustomerWeek, 50, conCurrEduCls.CustomerWeek);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdUniZone, 4, conCurrEduCls.IdUniZone);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdGradeBase, 4, conCurrEduCls.IdGradeBase);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.SchoolYear, 10, conCurrEduCls.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.SchoolTerm, 1, conCurrEduCls.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdCourseType, 4, conCurrEduCls.IdCourseType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdScoreType, 4, conCurrEduCls.IdScoreType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.GetScoreWayId, 2, conCurrEduCls.GetScoreWayId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdExamType, 4, conCurrEduCls.IdExamType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.ExamTime, 8, conCurrEduCls.ExamTime);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.UserType, 50, conCurrEduCls.UserType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.ModifyDate, 20, conCurrEduCls.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.ModifyUserId, 18, conCurrEduCls.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.Memo, 1000, conCurrEduCls.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.CourseId, 8, conCurrEduCls.CourseId);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdEduWay, 4, conCurrEduCls.IdEduWay);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdClassRoomType, 4, conCurrEduCls.IdClassRoomType);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.WeekStatusId, 2, conCurrEduCls.WeekStatusId);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdUniZone, 4, conCurrEduCls.IdUniZone);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdGradeBase, 4, conCurrEduCls.IdGradeBase);
 objCurrEduClsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCurrEduClsEN objCurrEduClsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdCurrEduCls, 8, conCurrEduCls.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.CurrEduClsId, 15, conCurrEduCls.CurrEduClsId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.EduClsName, 100, conCurrEduCls.EduClsName);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.EduClsTypeId, 4, conCurrEduCls.EduClsTypeId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.CourseId, 8, conCurrEduCls.CourseId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.TeachingSolutionId, 8, conCurrEduCls.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdXzCollege, 4, conCurrEduCls.IdXzCollege);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdXzMajor, 8, conCurrEduCls.IdXzMajor);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdEduWay, 4, conCurrEduCls.IdEduWay);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdClassRoomType, 4, conCurrEduCls.IdClassRoomType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.WeekStatusId, 2, conCurrEduCls.WeekStatusId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.CustomerWeek, 50, conCurrEduCls.CustomerWeek);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdUniZone, 4, conCurrEduCls.IdUniZone);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdGradeBase, 4, conCurrEduCls.IdGradeBase);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.SchoolYear, 10, conCurrEduCls.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.SchoolTerm, 1, conCurrEduCls.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdCourseType, 4, conCurrEduCls.IdCourseType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdScoreType, 4, conCurrEduCls.IdScoreType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.GetScoreWayId, 2, conCurrEduCls.GetScoreWayId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.IdExamType, 4, conCurrEduCls.IdExamType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.ExamTime, 8, conCurrEduCls.ExamTime);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.UserType, 50, conCurrEduCls.UserType);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.ModifyDate, 20, conCurrEduCls.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.ModifyUserId, 18, conCurrEduCls.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduClsEN.Memo, 1000, conCurrEduCls.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.IdCurrEduCls, conCurrEduCls.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.CurrEduClsId, conCurrEduCls.CurrEduClsId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.EduClsName, conCurrEduCls.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.EduClsTypeId, conCurrEduCls.EduClsTypeId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.CourseId, conCurrEduCls.CourseId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.TeachingSolutionId, conCurrEduCls.TeachingSolutionId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.IdXzCollege, conCurrEduCls.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.IdXzMajor, conCurrEduCls.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.IdEduWay, conCurrEduCls.IdEduWay);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.IdClassRoomType, conCurrEduCls.IdClassRoomType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.WeekStatusId, conCurrEduCls.WeekStatusId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.CustomerWeek, conCurrEduCls.CustomerWeek);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.IdUniZone, conCurrEduCls.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.IdGradeBase, conCurrEduCls.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.SchoolYear, conCurrEduCls.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.SchoolTerm, conCurrEduCls.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.IdCourseType, conCurrEduCls.IdCourseType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.IdScoreType, conCurrEduCls.IdScoreType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.GetScoreWayId, conCurrEduCls.GetScoreWayId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.IdExamType, conCurrEduCls.IdExamType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.ExamTime, conCurrEduCls.ExamTime);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.UserType, conCurrEduCls.UserType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.ModifyDate, conCurrEduCls.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.ModifyUserId, conCurrEduCls.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsEN.Memo, conCurrEduCls.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.CourseId, 8, conCurrEduCls.CourseId);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdEduWay, 4, conCurrEduCls.IdEduWay);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdClassRoomType, 4, conCurrEduCls.IdClassRoomType);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.WeekStatusId, 2, conCurrEduCls.WeekStatusId);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdUniZone, 4, conCurrEduCls.IdUniZone);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsEN.IdGradeBase, 4, conCurrEduCls.IdGradeBase);
 objCurrEduClsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdCurrEduCls()
{
//获取某学院所有专业信息
string strSQL = "select IdCurrEduCls, EduClsName from CurrEduCls ";
 clsSpecSQLforSql mySql = clsCurrEduClsDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CurrEduCls(当前教学班),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCurrEduClsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCurrEduClsEN objCurrEduClsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and EduClsName = '{0}'", objCurrEduClsEN.EduClsName);
return sbCondition.ToString();
}

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduClsEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduClsEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}