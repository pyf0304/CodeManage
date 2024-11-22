
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCase_BaseDA
 表名:vClsRmTeachingCase_Base(01120488)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
 框架-层名:数据处理层(CS)(DALCode)
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
 /// v课堂教学案例_Base(vClsRmTeachingCase_Base)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvClsRmTeachingCase_BaseDA : clsCommBase4DA
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
 return clsvClsRmTeachingCase_BaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvClsRmTeachingCase_BaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvClsRmTeachingCase_BaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvClsRmTeachingCase_BaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvClsRmTeachingCase_BaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdClsRmTeachingCase)
{
strIdClsRmTeachingCase = strIdClsRmTeachingCase.Replace("'", "''");
if (strIdClsRmTeachingCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vClsRmTeachingCase_Base中,检查关键字,长度不正确!(clsvClsRmTeachingCase_BaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdClsRmTeachingCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vClsRmTeachingCase_Base中,关键字不能为空 或 null!(clsvClsRmTeachingCase_BaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdClsRmTeachingCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvClsRmTeachingCase_BaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vClsRmTeachingCase_Base(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetDataTable_vClsRmTeachingCase_Base)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase_Base where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase_Base where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase_Base where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClsRmTeachingCase_Base.* from vClsRmTeachingCase_Base Left Join {1} on {2} where {3} and vClsRmTeachingCase_Base.IdClsRmTeachingCase not in (Select top {5} vClsRmTeachingCase_Base.IdClsRmTeachingCase from vClsRmTeachingCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase_Base where {1} and IdClsRmTeachingCase not in (Select top {2} IdClsRmTeachingCase from vClsRmTeachingCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase_Base where {1} and IdClsRmTeachingCase not in (Select top {3} IdClsRmTeachingCase from vClsRmTeachingCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClsRmTeachingCase_Base.* from vClsRmTeachingCase_Base Left Join {1} on {2} where {3} and vClsRmTeachingCase_Base.IdClsRmTeachingCase not in (Select top {5} vClsRmTeachingCase_Base.IdClsRmTeachingCase from vClsRmTeachingCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase_Base where {1} and IdClsRmTeachingCase not in (Select top {2} IdClsRmTeachingCase from vClsRmTeachingCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase_Base where {1} and IdClsRmTeachingCase not in (Select top {3} IdClsRmTeachingCase from vClsRmTeachingCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvClsRmTeachingCase_BaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA:GetObjLst)", objException.Message));
}
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetObjLst)", objException.Message));
}
objvClsRmTeachingCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
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
public List<clsvClsRmTeachingCase_BaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvClsRmTeachingCase_BaseEN> arrObjLst = new List<clsvClsRmTeachingCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetObjLst)", objException.Message));
}
objvClsRmTeachingCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClsRmTeachingCase_BaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvClsRmTeachingCase_Base(ref clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase_Base where IdClsRmTeachingCase = " + "'"+ objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objDT.Rows[0][convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objDT.Rows[0][convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objDT.Rows[0][convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objDT.Rows[0][convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objDT.Rows[0][convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objDT.Rows[0][convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objDT.Rows[0][convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objDT.Rows[0][convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objDT.Rows[0][convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objDT.Rows[0][convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objDT.Rows[0][convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdStudyLevel = objDT.Rows[0][convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.StudyLevelName = objDT.Rows[0][convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objDT.Rows[0][convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdCaseType = objDT.Rows[0][convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdDiscipline = objDT.Rows[0][convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.DisciplineID = objDT.Rows[0][convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdSchoolPs = objDT.Rows[0][convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.SchoolId = objDT.Rows[0][convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvClsRmTeachingCase_BaseEN.SchoolName = objDT.Rows[0][convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objDT.Rows[0][convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.DisciplineName = objDT.Rows[0][convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdGradeBase = objDT.Rows[0][convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objDT.Rows[0][convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objDT.Rows[0][convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objDT.Rows[0][convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdTeachSkill = objDT.Rows[0][convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.TeachSkillID = objDT.Rows[0][convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.SkillTypeName = objDT.Rows[0][convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.TeachSkillName = objDT.Rows[0][convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objDT.Rows[0][convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objDT.Rows[0][convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdSkillType = objDT.Rows[0][convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.SkillTypeID = objDT.Rows[0][convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.CaseLevelId = objDT.Rows[0][convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvClsRmTeachingCase_BaseEN.CaseLevelName = objDT.Rows[0][convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCase_BaseEN.DocFile = objDT.Rows[0][convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCase_BaseEN.WordCreateDate = objDT.Rows[0][convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCase_BaseEN.OwnerId = objDT.Rows[0][convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdStudentInfo = objDT.Rows[0][convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.StuName = objDT.Rows[0][convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCase_BaseEN.StuId = objDT.Rows[0][convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCase_BaseEN.PoliticsName = objDT.Rows[0][convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCase_BaseEN.SexDesc = objDT.Rows[0][convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvClsRmTeachingCase_BaseEN.EthnicName = objDT.Rows[0][convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCase_BaseEN.UniZoneDesc = objDT.Rows[0][convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvClsRmTeachingCase_BaseEN.StuTypeDesc = objDT.Rows[0][convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdXzCollege = objDT.Rows[0][convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.CollegeId = objDT.Rows[0][convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.CollegeName = objDT.Rows[0][convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCase_BaseEN.CollegeNameA = objDT.Rows[0][convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdXzMajor = objDT.Rows[0][convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.MajorName = objDT.Rows[0][convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCase_BaseEN.GradeBaseName = objDT.Rows[0][convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdAdminCls = objDT.Rows[0][convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.AdminClsId = objDT.Rows[0][convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.AdminClsName = objDT.Rows[0][convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvClsRmTeachingCase_BaseEN.Birthday = objDT.Rows[0][convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.NativePlace = objDT.Rows[0][convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCase_BaseEN.Duty = objDT.Rows[0][convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdCardNo = objDT.Rows[0][convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCase_BaseEN.StuCardNo = objDT.Rows[0][convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCase_BaseEN.LiveAddress = objDT.Rows[0][convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCase_BaseEN.HomePhone = objDT.Rows[0][convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCase_BaseEN.EnrollmentDate = objDT.Rows[0][convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.PostCode = objDT.Rows[0][convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCase_BaseEN.UserKindId = objDT.Rows[0][convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvClsRmTeachingCase_BaseEN.UserKindName = objDT.Rows[0][convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCase_BaseEN.UserTypeId = objDT.Rows[0][convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objDT.Rows[0][convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objDT.Rows[0][convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCase_BaseEN.Memo = objDT.Rows[0][convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objDT.Rows[0][convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCase_BaseEN.GradeNamePs = objDT.Rows[0][convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdGradePs = objDT.Rows[0][convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.OwnerName = objDT.Rows[0][convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objDT.Rows[0][convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvClsRmTeachingCase_BaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.CaseTypeName = objDT.Rows[0][convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ftpFileType = objDT.Rows[0][convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IsUse = TransNullToBool(objDT.Rows[0][convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetvClsRmTeachingCase_Base)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvClsRmTeachingCase_BaseEN GetObjByIdClsRmTeachingCase(string strIdClsRmTeachingCase)
{
CheckPrimaryKey(strIdClsRmTeachingCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase_Base where IdClsRmTeachingCase = " + "'"+ strIdClsRmTeachingCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
 objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCase_BaseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetObjByIdClsRmTeachingCase)", objException.Message));
}
return objvClsRmTeachingCase_BaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvClsRmTeachingCase_BaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN()
{
IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(), //课堂教学案例流水号
ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(), //课堂教学案例ID
ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(), //课堂教学案例名称
ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(), //课堂教学案例主题词
IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(), //课堂案例类型流水号
ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(), //课堂案例类型名称
ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(), //案例文本内容
ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(), //课堂教学日期
ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(), //课堂教学时间
ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(), //案例入库日期
ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(), //教案流水号
IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(), //学科ID
IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(), //学校流水号
SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(), //学校编号
SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(), //学校名称
IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(), //学科流水号
DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(), //学科名称
IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(), //年级流水号
IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(), //拥有者Id
IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(), //学生流水号
StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(), //姓名
StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(), //学号
PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(), //政治面貌
SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(), //性别名称
EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(), //民族名称
UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(), //校区名称
StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(), //专业名称
GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(), //年级名称
IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(), //行政班流水号
AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(), //行政班代号
AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(), //行政班名称
Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(), //出生日期
NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(), //籍贯
Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(), //职位
IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(), //身份证号
StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(), //学生证号
LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(), //居住地址
HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(), //住宅电话
EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(), //入校日期
PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(), //邮编
UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(), //用户类别名
UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(), //用户类型Id
IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(), //推荐度名称
Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(), //备注
DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(), //学科
GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(), //年级
IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(), //年级流水号
OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()), //课例浏览次数
CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(), //案例类型名称
ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(), //ftp文件类型
IsUse = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()) //是否使用
};
objvClsRmTeachingCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCase_BaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvClsRmTeachingCase_BaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetObjByDataRowvClsRmTeachingCase_Base)", objException.Message));
}
objvClsRmTeachingCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCase_BaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvClsRmTeachingCase_BaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN = new clsvClsRmTeachingCase_BaseEN();
try
{
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase_Base.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCase_BaseEN.IdStudyLevel = objRow[convClsRmTeachingCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCase_BaseEN.StudyLevelName = objRow[convClsRmTeachingCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCase_BaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCase_BaseEN.IdCaseType = objRow[convClsRmTeachingCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCase_BaseEN.IdDiscipline = objRow[convClsRmTeachingCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineID = objRow[convClsRmTeachingCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCase_BaseEN.IdSchoolPs = objRow[convClsRmTeachingCase_Base.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCase_BaseEN.SchoolId = objRow[convClsRmTeachingCase_Base.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCase_BaseEN.SchoolName = objRow[convClsRmTeachingCase_Base.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCase_BaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase_Base.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCase_BaseEN.DisciplineName = objRow[convClsRmTeachingCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCase_BaseEN.IdGradeBase = objRow[convClsRmTeachingCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCase_BaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCase_BaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCase_BaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCase_BaseEN.VersionNo = objRow[convClsRmTeachingCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase_Base.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCase_BaseEN.IdTeachSkill = objRow[convClsRmTeachingCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCase_BaseEN.TeachSkillID = objRow[convClsRmTeachingCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCase_BaseEN.SkillTypeName = objRow[convClsRmTeachingCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCase_BaseEN.TeachSkillName = objRow[convClsRmTeachingCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCase_BaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCase_BaseEN.IdSkillType = objRow[convClsRmTeachingCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCase_BaseEN.SkillTypeID = objRow[convClsRmTeachingCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCase_BaseEN.CaseLevelId = objRow[convClsRmTeachingCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCase_BaseEN.CaseLevelName = objRow[convClsRmTeachingCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCase_BaseEN.DocFile = objRow[convClsRmTeachingCase_Base.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCase_BaseEN.WordCreateDate = objRow[convClsRmTeachingCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCase_BaseEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCase_BaseEN.OwnerId = objRow[convClsRmTeachingCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCase_BaseEN.IdStudentInfo = objRow[convClsRmTeachingCase_Base.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCase_BaseEN.StuName = objRow[convClsRmTeachingCase_Base.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCase_BaseEN.StuId = objRow[convClsRmTeachingCase_Base.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuId].ToString().Trim(); //学号
objvClsRmTeachingCase_BaseEN.PoliticsName = objRow[convClsRmTeachingCase_Base.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCase_BaseEN.SexDesc = objRow[convClsRmTeachingCase_Base.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCase_BaseEN.EthnicName = objRow[convClsRmTeachingCase_Base.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCase_BaseEN.UniZoneDesc = objRow[convClsRmTeachingCase_Base.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCase_BaseEN.StuTypeDesc = objRow[convClsRmTeachingCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCase_BaseEN.IdXzCollege = objRow[convClsRmTeachingCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCase_BaseEN.CollegeId = objRow[convClsRmTeachingCase_Base.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCase_BaseEN.CollegeName = objRow[convClsRmTeachingCase_Base.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCase_BaseEN.CollegeNameA = objRow[convClsRmTeachingCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCase_BaseEN.IdXzMajor = objRow[convClsRmTeachingCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCase_BaseEN.MajorName = objRow[convClsRmTeachingCase_Base.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCase_BaseEN.GradeBaseName = objRow[convClsRmTeachingCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCase_BaseEN.IdAdminCls = objRow[convClsRmTeachingCase_Base.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCase_BaseEN.AdminClsId = objRow[convClsRmTeachingCase_Base.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCase_BaseEN.AdminClsName = objRow[convClsRmTeachingCase_Base.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCase_BaseEN.Birthday = objRow[convClsRmTeachingCase_Base.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCase_BaseEN.NativePlace = objRow[convClsRmTeachingCase_Base.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCase_BaseEN.Duty = objRow[convClsRmTeachingCase_Base.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Duty].ToString().Trim(); //职位
objvClsRmTeachingCase_BaseEN.IdCardNo = objRow[convClsRmTeachingCase_Base.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCase_BaseEN.StuCardNo = objRow[convClsRmTeachingCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCase_BaseEN.LiveAddress = objRow[convClsRmTeachingCase_Base.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCase_BaseEN.HomePhone = objRow[convClsRmTeachingCase_Base.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCase_BaseEN.EnrollmentDate = objRow[convClsRmTeachingCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCase_BaseEN.PostCode = objRow[convClsRmTeachingCase_Base.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCase_BaseEN.UserKindId = objRow[convClsRmTeachingCase_Base.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCase_BaseEN.UserKindName = objRow[convClsRmTeachingCase_Base.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCase_BaseEN.UserTypeId = objRow[convClsRmTeachingCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCase_BaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCase_BaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCase_BaseEN.Memo = objRow[convClsRmTeachingCase_Base.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.Memo].ToString().Trim(); //备注
objvClsRmTeachingCase_BaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase_Base.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCase_BaseEN.GradeNamePs = objRow[convClsRmTeachingCase_Base.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCase_BaseEN.IdGradePs = objRow[convClsRmTeachingCase_Base.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCase_BaseEN.OwnerName = objRow[convClsRmTeachingCase_Base.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCase_BaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCase_BaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCase_BaseEN.CaseTypeName = objRow[convClsRmTeachingCase_Base.CaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.CaseTypeName].ToString().Trim(); //案例类型名称
objvClsRmTeachingCase_BaseEN.ftpFileType = objRow[convClsRmTeachingCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvClsRmTeachingCase_BaseEN.IsUse = TransNullToBool(objRow[convClsRmTeachingCase_Base.IsUse].ToString().Trim()); //是否使用
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvClsRmTeachingCase_BaseDA: GetObjByDataRow)", objException.Message));
}
objvClsRmTeachingCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCase_BaseEN;
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
objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClsRmTeachingCase_BaseEN._CurrTabName, convClsRmTeachingCase_Base.IdClsRmTeachingCase, 8, "");
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
objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClsRmTeachingCase_BaseEN._CurrTabName, convClsRmTeachingCase_Base.IdClsRmTeachingCase, 8, strPrefix);
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
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdClsRmTeachingCase from vClsRmTeachingCase_Base where " + strCondition;
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
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdClsRmTeachingCase from vClsRmTeachingCase_Base where " + strCondition;
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
 /// <param name = "strIdClsRmTeachingCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdClsRmTeachingCase)
{
CheckPrimaryKey(strIdClsRmTeachingCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClsRmTeachingCase_Base", "IdClsRmTeachingCase = " + "'"+ strIdClsRmTeachingCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvClsRmTeachingCase_BaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClsRmTeachingCase_Base", strCondition))
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
objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vClsRmTeachingCase_Base");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvClsRmTeachingCase_BaseENS">源对象</param>
 /// <param name = "objvClsRmTeachingCase_BaseENT">目标对象</param>
public void CopyTo(clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENS, clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseENT)
{
objvClsRmTeachingCase_BaseENT.IdClsRmTeachingCase = objvClsRmTeachingCase_BaseENS.IdClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseID = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseID; //课堂教学案例ID
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseName = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTheme = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objvClsRmTeachingCase_BaseENT.IdClsRmTeachingCaseType = objvClsRmTeachingCase_BaseENS.IdClsRmTeachingCaseType; //课堂案例类型流水号
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTypeName = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTypeName; //课堂案例类型名称
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseText = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseText; //案例文本内容
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseDate = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseDate; //课堂教学日期
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTime = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTime; //课堂教学时间
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseDateIn = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseDateIn; //案例入库日期
objvClsRmTeachingCase_BaseENT.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCase_BaseENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objvClsRmTeachingCase_BaseENT.IdStudyLevel = objvClsRmTeachingCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvClsRmTeachingCase_BaseENT.StudyLevelName = objvClsRmTeachingCase_BaseENS.StudyLevelName; //学段名称
objvClsRmTeachingCase_BaseENT.IdTeachingPlan = objvClsRmTeachingCase_BaseENS.IdTeachingPlan; //教案流水号
objvClsRmTeachingCase_BaseENT.IdCaseType = objvClsRmTeachingCase_BaseENS.IdCaseType; //案例类型流水号
objvClsRmTeachingCase_BaseENT.IdDiscipline = objvClsRmTeachingCase_BaseENS.IdDiscipline; //学科流水号
objvClsRmTeachingCase_BaseENT.DisciplineID = objvClsRmTeachingCase_BaseENS.DisciplineID; //学科ID
objvClsRmTeachingCase_BaseENT.IdSchoolPs = objvClsRmTeachingCase_BaseENS.IdSchoolPs; //学校流水号
objvClsRmTeachingCase_BaseENT.SchoolId = objvClsRmTeachingCase_BaseENS.SchoolId; //学校编号
objvClsRmTeachingCase_BaseENT.SchoolName = objvClsRmTeachingCase_BaseENS.SchoolName; //学校名称
objvClsRmTeachingCase_BaseENT.IdDisciplinePs = objvClsRmTeachingCase_BaseENS.IdDisciplinePs; //学科流水号
objvClsRmTeachingCase_BaseENT.DisciplineName = objvClsRmTeachingCase_BaseENS.DisciplineName; //学科名称
objvClsRmTeachingCase_BaseENT.IdGradeBase = objvClsRmTeachingCase_BaseENS.IdGradeBase; //年级流水号
objvClsRmTeachingCase_BaseENT.IdSenateGaugeVersion = objvClsRmTeachingCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvClsRmTeachingCase_BaseENT.senateGaugeVersionID = objvClsRmTeachingCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvClsRmTeachingCase_BaseENT.senateGaugeVersionName = objvClsRmTeachingCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvClsRmTeachingCase_BaseENT.senateGaugeVersionTtlScore = objvClsRmTeachingCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvClsRmTeachingCase_BaseENT.VersionNo = objvClsRmTeachingCase_BaseENS.VersionNo; //版本号
objvClsRmTeachingCase_BaseENT.IdTeachSkill = objvClsRmTeachingCase_BaseENS.IdTeachSkill; //教学技能流水号
objvClsRmTeachingCase_BaseENT.TeachSkillID = objvClsRmTeachingCase_BaseENS.TeachSkillID; //教学技能ID
objvClsRmTeachingCase_BaseENT.SkillTypeName = objvClsRmTeachingCase_BaseENS.SkillTypeName; //技能类型名称
objvClsRmTeachingCase_BaseENT.TeachSkillName = objvClsRmTeachingCase_BaseENS.TeachSkillName; //教学技能名称
objvClsRmTeachingCase_BaseENT.TeachSkillTheory = objvClsRmTeachingCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvClsRmTeachingCase_BaseENT.TeachSkillOperMethod = objvClsRmTeachingCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvClsRmTeachingCase_BaseENT.IdSkillType = objvClsRmTeachingCase_BaseENS.IdSkillType; //技能类型流水号
objvClsRmTeachingCase_BaseENT.SkillTypeID = objvClsRmTeachingCase_BaseENS.SkillTypeID; //技能类型ID
objvClsRmTeachingCase_BaseENT.CaseLevelId = objvClsRmTeachingCase_BaseENS.CaseLevelId; //课例等级Id
objvClsRmTeachingCase_BaseENT.CaseLevelName = objvClsRmTeachingCase_BaseENS.CaseLevelName; //案例等级名称
objvClsRmTeachingCase_BaseENT.DocFile = objvClsRmTeachingCase_BaseENS.DocFile; //生成的Word文件名
objvClsRmTeachingCase_BaseENT.IsNeedGeneWord = objvClsRmTeachingCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvClsRmTeachingCase_BaseENT.WordCreateDate = objvClsRmTeachingCase_BaseENS.WordCreateDate; //Word生成日期
objvClsRmTeachingCase_BaseENT.IsVisible = objvClsRmTeachingCase_BaseENS.IsVisible; //是否显示
objvClsRmTeachingCase_BaseENT.OwnerId = objvClsRmTeachingCase_BaseENS.OwnerId; //拥有者Id
objvClsRmTeachingCase_BaseENT.IdStudentInfo = objvClsRmTeachingCase_BaseENS.IdStudentInfo; //学生流水号
objvClsRmTeachingCase_BaseENT.StuName = objvClsRmTeachingCase_BaseENS.StuName; //姓名
objvClsRmTeachingCase_BaseENT.StuId = objvClsRmTeachingCase_BaseENS.StuId; //学号
objvClsRmTeachingCase_BaseENT.PoliticsName = objvClsRmTeachingCase_BaseENS.PoliticsName; //政治面貌
objvClsRmTeachingCase_BaseENT.SexDesc = objvClsRmTeachingCase_BaseENS.SexDesc; //性别名称
objvClsRmTeachingCase_BaseENT.EthnicName = objvClsRmTeachingCase_BaseENS.EthnicName; //民族名称
objvClsRmTeachingCase_BaseENT.UniZoneDesc = objvClsRmTeachingCase_BaseENS.UniZoneDesc; //校区名称
objvClsRmTeachingCase_BaseENT.StuTypeDesc = objvClsRmTeachingCase_BaseENS.StuTypeDesc; //学生类别名称
objvClsRmTeachingCase_BaseENT.IdXzCollege = objvClsRmTeachingCase_BaseENS.IdXzCollege; //学院流水号
objvClsRmTeachingCase_BaseENT.CollegeId = objvClsRmTeachingCase_BaseENS.CollegeId; //学院ID
objvClsRmTeachingCase_BaseENT.CollegeName = objvClsRmTeachingCase_BaseENS.CollegeName; //学院名称
objvClsRmTeachingCase_BaseENT.CollegeNameA = objvClsRmTeachingCase_BaseENS.CollegeNameA; //学院名称简写
objvClsRmTeachingCase_BaseENT.IdXzMajor = objvClsRmTeachingCase_BaseENS.IdXzMajor; //专业流水号
objvClsRmTeachingCase_BaseENT.MajorName = objvClsRmTeachingCase_BaseENS.MajorName; //专业名称
objvClsRmTeachingCase_BaseENT.GradeBaseName = objvClsRmTeachingCase_BaseENS.GradeBaseName; //年级名称
objvClsRmTeachingCase_BaseENT.IdAdminCls = objvClsRmTeachingCase_BaseENS.IdAdminCls; //行政班流水号
objvClsRmTeachingCase_BaseENT.AdminClsId = objvClsRmTeachingCase_BaseENS.AdminClsId; //行政班代号
objvClsRmTeachingCase_BaseENT.AdminClsName = objvClsRmTeachingCase_BaseENS.AdminClsName; //行政班名称
objvClsRmTeachingCase_BaseENT.Birthday = objvClsRmTeachingCase_BaseENS.Birthday; //出生日期
objvClsRmTeachingCase_BaseENT.NativePlace = objvClsRmTeachingCase_BaseENS.NativePlace; //籍贯
objvClsRmTeachingCase_BaseENT.Duty = objvClsRmTeachingCase_BaseENS.Duty; //职位
objvClsRmTeachingCase_BaseENT.IdCardNo = objvClsRmTeachingCase_BaseENS.IdCardNo; //身份证号
objvClsRmTeachingCase_BaseENT.StuCardNo = objvClsRmTeachingCase_BaseENS.StuCardNo; //学生证号
objvClsRmTeachingCase_BaseENT.LiveAddress = objvClsRmTeachingCase_BaseENS.LiveAddress; //居住地址
objvClsRmTeachingCase_BaseENT.HomePhone = objvClsRmTeachingCase_BaseENS.HomePhone; //住宅电话
objvClsRmTeachingCase_BaseENT.EnrollmentDate = objvClsRmTeachingCase_BaseENS.EnrollmentDate; //入校日期
objvClsRmTeachingCase_BaseENT.PostCode = objvClsRmTeachingCase_BaseENS.PostCode; //邮编
objvClsRmTeachingCase_BaseENT.UserKindId = objvClsRmTeachingCase_BaseENS.UserKindId; //用户类别Id
objvClsRmTeachingCase_BaseENT.UserKindName = objvClsRmTeachingCase_BaseENS.UserKindName; //用户类别名
objvClsRmTeachingCase_BaseENT.UserTypeId = objvClsRmTeachingCase_BaseENS.UserTypeId; //用户类型Id
objvClsRmTeachingCase_BaseENT.IsDualVideo = objvClsRmTeachingCase_BaseENS.IsDualVideo; //是否双视频
objvClsRmTeachingCase_BaseENT.RecommendedDegreeId = objvClsRmTeachingCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvClsRmTeachingCase_BaseENT.RecommendedDegreeName = objvClsRmTeachingCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvClsRmTeachingCase_BaseENT.Memo = objvClsRmTeachingCase_BaseENS.Memo; //备注
objvClsRmTeachingCase_BaseENT.DisciplineNamePs = objvClsRmTeachingCase_BaseENS.DisciplineNamePs; //学科
objvClsRmTeachingCase_BaseENT.GradeNamePs = objvClsRmTeachingCase_BaseENS.GradeNamePs; //年级
objvClsRmTeachingCase_BaseENT.IdGradePs = objvClsRmTeachingCase_BaseENS.IdGradePs; //年级流水号
objvClsRmTeachingCase_BaseENT.OwnerName = objvClsRmTeachingCase_BaseENS.OwnerName; //拥有者姓名
objvClsRmTeachingCase_BaseENT.OwnerNameWithId = objvClsRmTeachingCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvClsRmTeachingCase_BaseENT.BrowseCount4Case = objvClsRmTeachingCase_BaseENS.BrowseCount4Case; //课例浏览次数
objvClsRmTeachingCase_BaseENT.CaseTypeName = objvClsRmTeachingCase_BaseENS.CaseTypeName; //案例类型名称
objvClsRmTeachingCase_BaseENT.ftpFileType = objvClsRmTeachingCase_BaseENS.ftpFileType; //ftp文件类型
objvClsRmTeachingCase_BaseENT.IsUse = objvClsRmTeachingCase_BaseENS.IsUse; //是否使用
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvClsRmTeachingCase_BaseEN objvClsRmTeachingCase_BaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, 8, convClsRmTeachingCase_Base.IdClsRmTeachingCase);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName, 100, convClsRmTeachingCase_Base.ClsRmTeachingCaseName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme, 200, convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType, 4, convClsRmTeachingCase_Base.IdClsRmTeachingCaseType);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName, 30, convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText, 8000, convClsRmTeachingCase_Base.ClsRmTeachingCaseText);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseDate);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime, 6, convClsRmTeachingCase_Base.ClsRmTeachingCaseTime);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdStudyLevel, 4, convClsRmTeachingCase_Base.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.StudyLevelName, 50, convClsRmTeachingCase_Base.StudyLevelName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdTeachingPlan, 8, convClsRmTeachingCase_Base.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdCaseType, 4, convClsRmTeachingCase_Base.IdCaseType);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdDiscipline, 4, convClsRmTeachingCase_Base.IdDiscipline);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.DisciplineID, 4, convClsRmTeachingCase_Base.DisciplineID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdSchoolPs, 4, convClsRmTeachingCase_Base.IdSchoolPs);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.SchoolId, 10, convClsRmTeachingCase_Base.SchoolId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.SchoolName, 50, convClsRmTeachingCase_Base.SchoolName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdDisciplinePs, 4, convClsRmTeachingCase_Base.IdDisciplinePs);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.DisciplineName, 50, convClsRmTeachingCase_Base.DisciplineName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdGradeBase, 4, convClsRmTeachingCase_Base.IdGradeBase);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion, 4, convClsRmTeachingCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.senateGaugeVersionID, 4, convClsRmTeachingCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.senateGaugeVersionName, 200, convClsRmTeachingCase_Base.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdTeachSkill, 8, convClsRmTeachingCase_Base.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.TeachSkillID, 8, convClsRmTeachingCase_Base.TeachSkillID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.SkillTypeName, 50, convClsRmTeachingCase_Base.SkillTypeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.TeachSkillName, 50, convClsRmTeachingCase_Base.TeachSkillName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.TeachSkillTheory, 8000, convClsRmTeachingCase_Base.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod, 2000, convClsRmTeachingCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdSkillType, 4, convClsRmTeachingCase_Base.IdSkillType);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.SkillTypeID, 4, convClsRmTeachingCase_Base.SkillTypeID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.CaseLevelId, 2, convClsRmTeachingCase_Base.CaseLevelId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.CaseLevelName, 30, convClsRmTeachingCase_Base.CaseLevelName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.DocFile, 200, convClsRmTeachingCase_Base.DocFile);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.WordCreateDate, 14, convClsRmTeachingCase_Base.WordCreateDate);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.OwnerId, 20, convClsRmTeachingCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdStudentInfo, 8, convClsRmTeachingCase_Base.IdStudentInfo);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.StuName, 50, convClsRmTeachingCase_Base.StuName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.StuId, 20, convClsRmTeachingCase_Base.StuId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.PoliticsName, 30, convClsRmTeachingCase_Base.PoliticsName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.SexDesc, 10, convClsRmTeachingCase_Base.SexDesc);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.EthnicName, 30, convClsRmTeachingCase_Base.EthnicName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.UniZoneDesc, 20, convClsRmTeachingCase_Base.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.StuTypeDesc, 50, convClsRmTeachingCase_Base.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdXzCollege, 4, convClsRmTeachingCase_Base.IdXzCollege);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.CollegeId, 4, convClsRmTeachingCase_Base.CollegeId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.CollegeName, 100, convClsRmTeachingCase_Base.CollegeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.CollegeNameA, 12, convClsRmTeachingCase_Base.CollegeNameA);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdXzMajor, 8, convClsRmTeachingCase_Base.IdXzMajor);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.MajorName, 100, convClsRmTeachingCase_Base.MajorName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.GradeBaseName, 50, convClsRmTeachingCase_Base.GradeBaseName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdAdminCls, 8, convClsRmTeachingCase_Base.IdAdminCls);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.AdminClsId, 8, convClsRmTeachingCase_Base.AdminClsId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.AdminClsName, 100, convClsRmTeachingCase_Base.AdminClsName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.Birthday, 8, convClsRmTeachingCase_Base.Birthday);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.NativePlace, 200, convClsRmTeachingCase_Base.NativePlace);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.Duty, 30, convClsRmTeachingCase_Base.Duty);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdCardNo, 20, convClsRmTeachingCase_Base.IdCardNo);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.StuCardNo, 20, convClsRmTeachingCase_Base.StuCardNo);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.LiveAddress, 200, convClsRmTeachingCase_Base.LiveAddress);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.HomePhone, 20, convClsRmTeachingCase_Base.HomePhone);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.EnrollmentDate, 8, convClsRmTeachingCase_Base.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.PostCode, 6, convClsRmTeachingCase_Base.PostCode);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.UserKindId, 2, convClsRmTeachingCase_Base.UserKindId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.UserKindName, 30, convClsRmTeachingCase_Base.UserKindName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.UserTypeId, 2, convClsRmTeachingCase_Base.UserTypeId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.RecommendedDegreeId, 2, convClsRmTeachingCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.RecommendedDegreeName, 30, convClsRmTeachingCase_Base.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.Memo, 1000, convClsRmTeachingCase_Base.Memo);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.DisciplineNamePs, 50, convClsRmTeachingCase_Base.DisciplineNamePs);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.GradeNamePs, 50, convClsRmTeachingCase_Base.GradeNamePs);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.IdGradePs, 4, convClsRmTeachingCase_Base.IdGradePs);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.OwnerName, 30, convClsRmTeachingCase_Base.OwnerName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.OwnerNameWithId, 51, convClsRmTeachingCase_Base.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.CaseTypeName, 50, convClsRmTeachingCase_Base.CaseTypeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCase_BaseEN.ftpFileType, 30, convClsRmTeachingCase_Base.ftpFileType);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCase, convClsRmTeachingCase_Base.IdClsRmTeachingCase);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseID, convClsRmTeachingCase_Base.ClsRmTeachingCaseID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseName, convClsRmTeachingCase_Base.ClsRmTeachingCaseName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTheme, convClsRmTeachingCase_Base.ClsRmTeachingCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdClsRmTeachingCaseType, convClsRmTeachingCase_Base.IdClsRmTeachingCaseType);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTypeName, convClsRmTeachingCase_Base.ClsRmTeachingCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseText, convClsRmTeachingCase_Base.ClsRmTeachingCaseText);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDate, convClsRmTeachingCase_Base.ClsRmTeachingCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTime, convClsRmTeachingCase_Base.ClsRmTeachingCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseDateIn, convClsRmTeachingCase_Base.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.ClsRmTeachingCaseTimeIn, convClsRmTeachingCase_Base.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdStudyLevel, convClsRmTeachingCase_Base.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.StudyLevelName, convClsRmTeachingCase_Base.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdTeachingPlan, convClsRmTeachingCase_Base.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdCaseType, convClsRmTeachingCase_Base.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdDiscipline, convClsRmTeachingCase_Base.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.DisciplineID, convClsRmTeachingCase_Base.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdSchoolPs, convClsRmTeachingCase_Base.IdSchoolPs);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.SchoolId, convClsRmTeachingCase_Base.SchoolId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.SchoolName, convClsRmTeachingCase_Base.SchoolName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdDisciplinePs, convClsRmTeachingCase_Base.IdDisciplinePs);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.DisciplineName, convClsRmTeachingCase_Base.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdGradeBase, convClsRmTeachingCase_Base.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdSenateGaugeVersion, convClsRmTeachingCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.senateGaugeVersionID, convClsRmTeachingCase_Base.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.senateGaugeVersionName, convClsRmTeachingCase_Base.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdTeachSkill, convClsRmTeachingCase_Base.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.TeachSkillID, convClsRmTeachingCase_Base.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.SkillTypeName, convClsRmTeachingCase_Base.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.TeachSkillName, convClsRmTeachingCase_Base.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.TeachSkillTheory, convClsRmTeachingCase_Base.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.TeachSkillOperMethod, convClsRmTeachingCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdSkillType, convClsRmTeachingCase_Base.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.SkillTypeID, convClsRmTeachingCase_Base.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.CaseLevelId, convClsRmTeachingCase_Base.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.CaseLevelName, convClsRmTeachingCase_Base.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.DocFile, convClsRmTeachingCase_Base.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.WordCreateDate, convClsRmTeachingCase_Base.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.OwnerId, convClsRmTeachingCase_Base.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdStudentInfo, convClsRmTeachingCase_Base.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.StuName, convClsRmTeachingCase_Base.StuName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.StuId, convClsRmTeachingCase_Base.StuId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.PoliticsName, convClsRmTeachingCase_Base.PoliticsName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.SexDesc, convClsRmTeachingCase_Base.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.EthnicName, convClsRmTeachingCase_Base.EthnicName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.UniZoneDesc, convClsRmTeachingCase_Base.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.StuTypeDesc, convClsRmTeachingCase_Base.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdXzCollege, convClsRmTeachingCase_Base.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.CollegeId, convClsRmTeachingCase_Base.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.CollegeName, convClsRmTeachingCase_Base.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.CollegeNameA, convClsRmTeachingCase_Base.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdXzMajor, convClsRmTeachingCase_Base.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.MajorName, convClsRmTeachingCase_Base.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.GradeBaseName, convClsRmTeachingCase_Base.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdAdminCls, convClsRmTeachingCase_Base.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.AdminClsId, convClsRmTeachingCase_Base.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.AdminClsName, convClsRmTeachingCase_Base.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.Birthday, convClsRmTeachingCase_Base.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.NativePlace, convClsRmTeachingCase_Base.NativePlace);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.Duty, convClsRmTeachingCase_Base.Duty);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdCardNo, convClsRmTeachingCase_Base.IdCardNo);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.StuCardNo, convClsRmTeachingCase_Base.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.LiveAddress, convClsRmTeachingCase_Base.LiveAddress);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.HomePhone, convClsRmTeachingCase_Base.HomePhone);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.EnrollmentDate, convClsRmTeachingCase_Base.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.PostCode, convClsRmTeachingCase_Base.PostCode);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.UserKindId, convClsRmTeachingCase_Base.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.UserKindName, convClsRmTeachingCase_Base.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.UserTypeId, convClsRmTeachingCase_Base.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.RecommendedDegreeId, convClsRmTeachingCase_Base.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.RecommendedDegreeName, convClsRmTeachingCase_Base.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.Memo, convClsRmTeachingCase_Base.Memo);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.DisciplineNamePs, convClsRmTeachingCase_Base.DisciplineNamePs);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.GradeNamePs, convClsRmTeachingCase_Base.GradeNamePs);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.IdGradePs, convClsRmTeachingCase_Base.IdGradePs);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.OwnerName, convClsRmTeachingCase_Base.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.OwnerNameWithId, convClsRmTeachingCase_Base.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.CaseTypeName, convClsRmTeachingCase_Base.CaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCase_BaseEN.ftpFileType, convClsRmTeachingCase_Base.ftpFileType);
//检查外键字段长度
 objvClsRmTeachingCase_BaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdClsRmTeachingCase()
{
//获取某学院所有专业信息
string strSQL = "select IdClsRmTeachingCase, ClsRmTeachingCaseName from vClsRmTeachingCase_Base ";
 clsSpecSQLforSql mySql = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

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
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClsRmTeachingCase_BaseEN._CurrTabName);
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
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClsRmTeachingCase_BaseEN._CurrTabName, strCondition);
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
 objSQL = clsvClsRmTeachingCase_BaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}