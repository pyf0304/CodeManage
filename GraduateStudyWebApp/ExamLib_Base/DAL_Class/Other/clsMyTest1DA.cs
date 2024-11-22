
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMyTest1DA
 表名:MyTest1(01120220)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:14
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他(Other)
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
 /// 测试表1(MyTest1)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsMyTest1DA : clsCommBase4DA
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
 return clsMyTest1EN._CurrTabName;
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
if (string.IsNullOrEmpty(clsMyTest1EN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMyTest1EN._ConnectString);
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
 if (string.IsNullOrEmpty(clsMyTest1EN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsMyTest1EN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strStrKey">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strStrKey)
{
strStrKey = strStrKey.Replace("'", "''");
if (strStrKey.Length > 4)
{
throw new Exception("(errid:Data000001)在表:MyTest1中,检查关键字,长度不正确!(clsMyTest1DA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strStrKey)  ==  true)
{
throw new Exception("(errid:Data000002)在表:MyTest1中,关键字不能为空 或 null!(clsMyTest1DA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStrKey);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsMyTest1DA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsMyTest1DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
strSQL = "Select * from MyTest1 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_MyTest1(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsMyTest1DA: GetDataTable_MyTest1)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
strSQL = "Select * from MyTest1 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsMyTest1DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsMyTest1DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
strSQL = "Select * from MyTest1 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsMyTest1DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsMyTest1DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MyTest1 where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MyTest1 where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsMyTest1DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from MyTest1 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsMyTest1DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MyTest1.* from MyTest1 Left Join {1} on {2} where {3} and MyTest1.StrKey not in (Select top {5} MyTest1.StrKey from MyTest1 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MyTest1 where {1} and StrKey not in (Select top {2} StrKey from MyTest1 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MyTest1 where {1} and StrKey not in (Select top {3} StrKey from MyTest1 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsMyTest1DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MyTest1.* from MyTest1 Left Join {1} on {2} where {3} and MyTest1.StrKey not in (Select top {5} MyTest1.StrKey from MyTest1 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MyTest1 where {1} and StrKey not in (Select top {2} StrKey from MyTest1 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MyTest1 where {1} and StrKey not in (Select top {3} StrKey from MyTest1 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsMyTest1EN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsMyTest1DA:GetObjLst)", objException.Message));
}
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
strSQL = "Select * from MyTest1 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = TransNullToInt(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = TransNullToInt(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = TransNullToBool(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMyTest1DA: GetObjLst)", objException.Message));
}
objMyTest1EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMyTest1EN);
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
public List<clsMyTest1EN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsMyTest1DA:GetObjLstByTabName)", objException.Message));
}
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = TransNullToInt(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = TransNullToInt(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = TransNullToBool(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMyTest1DA: GetObjLst)", objException.Message));
}
objMyTest1EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMyTest1EN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objMyTest1EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetMyTest1(ref clsMyTest1EN objMyTest1EN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
strSQL = "Select * from MyTest1 where StrKey = " + "'"+ objMyTest1EN.StrKey+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objMyTest1EN.StrKey = objDT.Rows[0][conMyTest1.StrKey].ToString().Trim(); //s主键(字段类型:char,字段长度:4,是否可空:False)
 objMyTest1EN.myInt = TransNullToInt(objDT.Rows[0][conMyTest1.myInt].ToString().Trim()); //my整型(字段类型:int,字段长度:4,是否可空:False)
 objMyTest1EN.myLong = TransNullToInt(objDT.Rows[0][conMyTest1.myLong].ToString().Trim()); //my长整型(字段类型:bigint,字段长度:8,是否可空:False)
 objMyTest1EN.myString = objDT.Rows[0][conMyTest1.myString].ToString().Trim(); //my字符串(字段类型:varchar,字段长度:50,是否可空:False)
 objMyTest1EN.myBool = TransNullToBool(objDT.Rows[0][conMyTest1.myBool].ToString().Trim()); //my布尔型(字段类型:bit,字段长度:1,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsMyTest1DA: GetMyTest1)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strStrKey">表关键字</param>
 /// <returns>表对象</returns>
public clsMyTest1EN GetObjByStrKey(string strStrKey)
{
CheckPrimaryKey(strStrKey);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
strSQL = "Select * from MyTest1 where StrKey = " + "'"+ strStrKey+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
 objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键(字段类型:char,字段长度:4,是否可空:False)
 objMyTest1EN.myInt = Int32.Parse(objRow[conMyTest1.myInt].ToString().Trim()); //my整型(字段类型:int,字段长度:4,是否可空:False)
 objMyTest1EN.myLong = Int32.Parse(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型(字段类型:bigint,字段长度:8,是否可空:False)
 objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串(字段类型:varchar,字段长度:50,是否可空:False)
 objMyTest1EN.myBool = clsEntityBase2.TransNullToBool_S(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型(字段类型:bit,字段长度:1,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsMyTest1DA: GetObjByStrKey)", objException.Message));
}
return objMyTest1EN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsMyTest1EN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsMyTest1DA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
strSQL = "Select * from MyTest1 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN()
{
StrKey = objRow[conMyTest1.StrKey].ToString().Trim(), //s主键
myInt = TransNullToInt(objRow[conMyTest1.myInt].ToString().Trim()), //my整型
myLong = TransNullToInt(objRow[conMyTest1.myLong].ToString().Trim()), //my长整型
myString = objRow[conMyTest1.myString].ToString().Trim(), //my字符串
myBool = TransNullToBool(objRow[conMyTest1.myBool].ToString().Trim()) //my布尔型
};
objMyTest1EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMyTest1EN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsMyTest1DA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsMyTest1EN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = TransNullToInt(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = TransNullToInt(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = TransNullToBool(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsMyTest1DA: GetObjByDataRowMyTest1)", objException.Message));
}
objMyTest1EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMyTest1EN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsMyTest1EN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = TransNullToInt(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = TransNullToInt(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = TransNullToBool(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsMyTest1DA: GetObjByDataRow)", objException.Message));
}
objMyTest1EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMyTest1EN;
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
objSQL = clsMyTest1DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMyTest1EN._CurrTabName, conMyTest1.StrKey, 4, "");
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
objSQL = clsMyTest1DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMyTest1EN._CurrTabName, conMyTest1.StrKey, 4, strPrefix);
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
 objSQL = clsMyTest1DA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select StrKey from MyTest1 where " + strCondition;
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
 objSQL = clsMyTest1DA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select StrKey from MyTest1 where " + strCondition;
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
 /// <param name = "strStrKey">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strStrKey)
{
CheckPrimaryKey(strStrKey);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MyTest1", "StrKey = " + "'"+ strStrKey+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsMyTest1DA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MyTest1", strCondition))
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
objSQL = clsMyTest1DA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("MyTest1");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsMyTest1EN objMyTest1EN)
 {
 if (objMyTest1EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMyTest1EN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
strSQL = "Select * from MyTest1 where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MyTest1");
objRow = objDS.Tables["MyTest1"].NewRow();
objRow[conMyTest1.StrKey] = objMyTest1EN.StrKey; //s主键
objRow[conMyTest1.myInt] = objMyTest1EN.myInt; //my整型
objRow[conMyTest1.myLong] = objMyTest1EN.myLong; //my长整型
objRow[conMyTest1.myString] = objMyTest1EN.myString; //my字符串
objRow[conMyTest1.myBool] = objMyTest1EN.myBool; //my布尔型
objDS.Tables[clsMyTest1EN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsMyTest1EN._CurrTabName);
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
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMyTest1EN objMyTest1EN)
{
 if (objMyTest1EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMyTest1EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMyTest1EN.StrKey !=  null)
 {
 arrFieldListForInsert.Add(conMyTest1.StrKey);
 var strStrKey = objMyTest1EN.StrKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStrKey + "'");
 }
 
 arrFieldListForInsert.Add(conMyTest1.myInt);
 arrValueListForInsert.Add(objMyTest1EN.myInt.ToString());
 
 arrFieldListForInsert.Add(conMyTest1.myLong);
 arrValueListForInsert.Add(objMyTest1EN.myLong.ToString());
 
 if (objMyTest1EN.myString !=  null)
 {
 arrFieldListForInsert.Add(conMyTest1.myString);
 var strmyString = objMyTest1EN.myString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmyString + "'");
 }
 
 arrFieldListForInsert.Add(conMyTest1.myBool);
 arrValueListForInsert.Add("'" + (objMyTest1EN.myBool  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MyTest1");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMyTest1EN objMyTest1EN)
{
 if (objMyTest1EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMyTest1EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMyTest1EN.StrKey !=  null)
 {
 arrFieldListForInsert.Add(conMyTest1.StrKey);
 var strStrKey = objMyTest1EN.StrKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStrKey + "'");
 }
 
 arrFieldListForInsert.Add(conMyTest1.myInt);
 arrValueListForInsert.Add(objMyTest1EN.myInt.ToString());
 
 arrFieldListForInsert.Add(conMyTest1.myLong);
 arrValueListForInsert.Add(objMyTest1EN.myLong.ToString());
 
 if (objMyTest1EN.myString !=  null)
 {
 arrFieldListForInsert.Add(conMyTest1.myString);
 var strmyString = objMyTest1EN.myString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmyString + "'");
 }
 
 arrFieldListForInsert.Add(conMyTest1.myBool);
 arrValueListForInsert.Add("'" + (objMyTest1EN.myBool  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MyTest1");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objMyTest1EN.StrKey;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMyTest1EN objMyTest1EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMyTest1EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMyTest1EN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMyTest1EN.StrKey !=  null)
 {
 arrFieldListForInsert.Add(conMyTest1.StrKey);
 var strStrKey = objMyTest1EN.StrKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStrKey + "'");
 }
 
 arrFieldListForInsert.Add(conMyTest1.myInt);
 arrValueListForInsert.Add(objMyTest1EN.myInt.ToString());
 
 arrFieldListForInsert.Add(conMyTest1.myLong);
 arrValueListForInsert.Add(objMyTest1EN.myLong.ToString());
 
 if (objMyTest1EN.myString !=  null)
 {
 arrFieldListForInsert.Add(conMyTest1.myString);
 var strmyString = objMyTest1EN.myString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmyString + "'");
 }
 
 arrFieldListForInsert.Add(conMyTest1.myBool);
 arrValueListForInsert.Add("'" + (objMyTest1EN.myBool  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MyTest1");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objMyTest1EN.StrKey;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMyTest1EN objMyTest1EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objMyTest1EN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMyTest1EN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMyTest1EN.StrKey !=  null)
 {
 arrFieldListForInsert.Add(conMyTest1.StrKey);
 var strStrKey = objMyTest1EN.StrKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStrKey + "'");
 }
 
 arrFieldListForInsert.Add(conMyTest1.myInt);
 arrValueListForInsert.Add(objMyTest1EN.myInt.ToString());
 
 arrFieldListForInsert.Add(conMyTest1.myLong);
 arrValueListForInsert.Add(objMyTest1EN.myLong.ToString());
 
 if (objMyTest1EN.myString !=  null)
 {
 arrFieldListForInsert.Add(conMyTest1.myString);
 var strmyString = objMyTest1EN.myString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmyString + "'");
 }
 
 arrFieldListForInsert.Add(conMyTest1.myBool);
 arrValueListForInsert.Add("'" + (objMyTest1EN.myBool  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MyTest1");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewMyTest1s(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
strSQL = "Select * from MyTest1 where StrKey = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MyTest1");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strStrKey = oRow[conMyTest1.StrKey].ToString().Trim();
if (IsExist(strStrKey))
{
 string strResult = "关键字变量值为:" + string.Format("StrKey = {0}", strStrKey) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsMyTest1EN._CurrTabName ].NewRow();
objRow[conMyTest1.StrKey] = oRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objRow[conMyTest1.myInt] = oRow[conMyTest1.myInt].ToString().Trim(); //my整型
objRow[conMyTest1.myLong] = oRow[conMyTest1.myLong].ToString().Trim(); //my长整型
objRow[conMyTest1.myString] = oRow[conMyTest1.myString].ToString().Trim(); //my字符串
objRow[conMyTest1.myBool] = oRow[conMyTest1.myBool].ToString().Trim(); //my布尔型
 objDS.Tables[clsMyTest1EN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsMyTest1EN._CurrTabName);
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
 /// <param name = "objMyTest1EN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsMyTest1EN objMyTest1EN)
{
 if (objMyTest1EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMyTest1EN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
strSQL = "Select * from MyTest1 where StrKey = " + "'"+ objMyTest1EN.StrKey+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsMyTest1EN._CurrTabName);
if (objDS.Tables[clsMyTest1EN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:StrKey = " + "'"+ objMyTest1EN.StrKey+"'");
return false;
}
objRow = objDS.Tables[clsMyTest1EN._CurrTabName].Rows[0];
 if (objMyTest1EN.IsUpdated(conMyTest1.StrKey))
 {
objRow[conMyTest1.StrKey] = objMyTest1EN.StrKey; //s主键
 }
 if (objMyTest1EN.IsUpdated(conMyTest1.myInt))
 {
objRow[conMyTest1.myInt] = objMyTest1EN.myInt; //my整型
 }
 if (objMyTest1EN.IsUpdated(conMyTest1.myLong))
 {
objRow[conMyTest1.myLong] = objMyTest1EN.myLong; //my长整型
 }
 if (objMyTest1EN.IsUpdated(conMyTest1.myString))
 {
objRow[conMyTest1.myString] = objMyTest1EN.myString; //my字符串
 }
 if (objMyTest1EN.IsUpdated(conMyTest1.myBool))
 {
objRow[conMyTest1.myBool] = objMyTest1EN.myBool; //my布尔型
 }
try
{
objDA.Update(objDS, clsMyTest1EN._CurrTabName);
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
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMyTest1EN objMyTest1EN)
{
 if (objMyTest1EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMyTest1EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update MyTest1 Set ");
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myInt))
 {
 sbSQL.AppendFormat("{1} = {0},",objMyTest1EN.myInt, conMyTest1.myInt); //my整型
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myLong))
 {
 sbSQL.AppendFormat("{1} = {0},",objMyTest1EN.myLong, conMyTest1.myLong); //my长整型
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myString))
 {
 if (objMyTest1EN.myString !=  null)
 {
 var strmyString = objMyTest1EN.myString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strmyString, conMyTest1.myString); //my字符串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMyTest1.myString); //my字符串
 }
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myBool))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMyTest1EN.myBool == true?"1":"0", conMyTest1.myBool); //my布尔型
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where StrKey = '{0}'", objMyTest1EN.StrKey); 
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
 /// <param name = "objMyTest1EN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsMyTest1EN objMyTest1EN, string strCondition)
{
 if (objMyTest1EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMyTest1EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MyTest1 Set ");
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myInt))
 {
 sbSQL.AppendFormat(" myInt = {0},", objMyTest1EN.myInt); //my整型
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myLong))
 {
 sbSQL.AppendFormat(" myLong = {0},", objMyTest1EN.myLong); //my长整型
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myString))
 {
 if (objMyTest1EN.myString !=  null)
 {
 var strmyString = objMyTest1EN.myString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" myString = '{0}',", strmyString); //my字符串
 }
 else
 {
 sbSQL.Append(" myString = null,"); //my字符串
 }
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myBool))
 {
 sbSQL.AppendFormat(" myBool = '{0}',", objMyTest1EN.myBool == true?"1":"0"); //my布尔型
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
 /// <param name = "objMyTest1EN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsMyTest1EN objMyTest1EN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMyTest1EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMyTest1EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MyTest1 Set ");
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myInt))
 {
 sbSQL.AppendFormat(" myInt = {0},", objMyTest1EN.myInt); //my整型
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myLong))
 {
 sbSQL.AppendFormat(" myLong = {0},", objMyTest1EN.myLong); //my长整型
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myString))
 {
 if (objMyTest1EN.myString !=  null)
 {
 var strmyString = objMyTest1EN.myString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" myString = '{0}',", strmyString); //my字符串
 }
 else
 {
 sbSQL.Append(" myString = null,"); //my字符串
 }
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myBool))
 {
 sbSQL.AppendFormat(" myBool = '{0}',", objMyTest1EN.myBool == true?"1":"0"); //my布尔型
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
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMyTest1EN objMyTest1EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objMyTest1EN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMyTest1EN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MyTest1 Set ");
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myInt))
 {
 sbSQL.AppendFormat("{1} = {0},",objMyTest1EN.myInt, conMyTest1.myInt); //my整型
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myLong))
 {
 sbSQL.AppendFormat("{1} = {0},",objMyTest1EN.myLong, conMyTest1.myLong); //my长整型
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myString))
 {
 if (objMyTest1EN.myString !=  null)
 {
 var strmyString = objMyTest1EN.myString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strmyString, conMyTest1.myString); //my字符串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMyTest1.myString); //my字符串
 }
 }
 
 if (objMyTest1EN.IsUpdated(conMyTest1.myBool))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMyTest1EN.myBool == true?"1":"0", conMyTest1.myBool); //my布尔型
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where StrKey = '{0}'", objMyTest1EN.StrKey); 
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
 /// <param name = "strStrKey">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strStrKey) 
{
CheckPrimaryKey(strStrKey);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strStrKey,
};
 objSQL.ExecSP("MyTest1_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strStrKey">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strStrKey, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strStrKey);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
//删除MyTest1本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MyTest1 where StrKey = " + "'"+ strStrKey+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelMyTest1(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
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
//删除MyTest1本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MyTest1 where StrKey in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strStrKey">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strStrKey) 
{
CheckPrimaryKey(strStrKey);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
//删除MyTest1本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MyTest1 where StrKey = " + "'"+ strStrKey+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelMyTest1(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsMyTest1DA: DelMyTest1)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MyTest1 where " + strCondition ;
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
public bool DelMyTest1WithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsMyTest1DA: DelMyTest1WithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMyTest1DA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MyTest1 where " + strCondition ;
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
 /// <param name = "objMyTest1ENS">源对象</param>
 /// <param name = "objMyTest1ENT">目标对象</param>
public void CopyTo(clsMyTest1EN objMyTest1ENS, clsMyTest1EN objMyTest1ENT)
{
objMyTest1ENT.StrKey = objMyTest1ENS.StrKey; //s主键
objMyTest1ENT.myInt = objMyTest1ENS.myInt; //my整型
objMyTest1ENT.myLong = objMyTest1ENS.myLong; //my长整型
objMyTest1ENT.myString = objMyTest1ENS.myString; //my字符串
objMyTest1ENT.myBool = objMyTest1ENS.myBool; //my布尔型
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsMyTest1EN objMyTest1EN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objMyTest1EN.myInt, conMyTest1.myInt);
clsCheckSql.CheckFieldNotNull(objMyTest1EN.myLong, conMyTest1.myLong);
clsCheckSql.CheckFieldNotNull(objMyTest1EN.myString, conMyTest1.myString);
clsCheckSql.CheckFieldNotNull(objMyTest1EN.myBool, conMyTest1.myBool);
//检查字段长度
clsCheckSql.CheckFieldLen(objMyTest1EN.StrKey, 4, conMyTest1.StrKey);
clsCheckSql.CheckFieldLen(objMyTest1EN.myString, 50, conMyTest1.myString);
//检查字段外键固定长度
 objMyTest1EN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsMyTest1EN objMyTest1EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMyTest1EN.myString, 50, conMyTest1.myString);
//检查外键字段长度
 objMyTest1EN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsMyTest1EN objMyTest1EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMyTest1EN.StrKey, 4, conMyTest1.StrKey);
clsCheckSql.CheckFieldLen(objMyTest1EN.myString, 50, conMyTest1.myString);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objMyTest1EN.StrKey, conMyTest1.StrKey);
clsCheckSql.CheckSqlInjection4Field(objMyTest1EN.myString, conMyTest1.myString);
//检查外键字段长度
 objMyTest1EN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--MyTest1(测试表1),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMyTest1EN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsMyTest1EN objMyTest1EN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and myInt = '{0}'", objMyTest1EN.myInt);
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
 objSQL = clsMyTest1DA.GetSpecSQLObj();
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
 objSQL = clsMyTest1DA.GetSpecSQLObj();
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
 objSQL = clsMyTest1DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMyTest1EN._CurrTabName);
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
 objSQL = clsMyTest1DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMyTest1EN._CurrTabName, strCondition);
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
 objSQL = clsMyTest1DA.GetSpecSQLObj();
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
 objSQL = clsMyTest1DA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}