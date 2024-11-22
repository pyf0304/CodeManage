
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLiteratureTypeDA
 表名:LiteratureType(01120557)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 文献类型(LiteratureType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsLiteratureTypeDA : clsCommBase4DA
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
 return clsLiteratureTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsLiteratureTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsLiteratureTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsLiteratureTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsLiteratureTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strLiteratureTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strLiteratureTypeId)
{
strLiteratureTypeId = strLiteratureTypeId.Replace("'", "''");
if (strLiteratureTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:LiteratureType中,检查关键字,长度不正确!(clsLiteratureTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strLiteratureTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:LiteratureType中,关键字不能为空 或 null!(clsLiteratureTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strLiteratureTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsLiteratureTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsLiteratureTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
strSQL = "Select * from LiteratureType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_LiteratureType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsLiteratureTypeDA: GetDataTable_LiteratureType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
strSQL = "Select * from LiteratureType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsLiteratureTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsLiteratureTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
strSQL = "Select * from LiteratureType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsLiteratureTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsLiteratureTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LiteratureType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LiteratureType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsLiteratureTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from LiteratureType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsLiteratureTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} LiteratureType.* from LiteratureType Left Join {1} on {2} where {3} and LiteratureType.LiteratureTypeId not in (Select top {5} LiteratureType.LiteratureTypeId from LiteratureType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LiteratureType where {1} and LiteratureTypeId not in (Select top {2} LiteratureTypeId from LiteratureType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LiteratureType where {1} and LiteratureTypeId not in (Select top {3} LiteratureTypeId from LiteratureType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsLiteratureTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} LiteratureType.* from LiteratureType Left Join {1} on {2} where {3} and LiteratureType.LiteratureTypeId not in (Select top {5} LiteratureType.LiteratureTypeId from LiteratureType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LiteratureType where {1} and LiteratureTypeId not in (Select top {2} LiteratureTypeId from LiteratureType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LiteratureType where {1} and LiteratureTypeId not in (Select top {3} LiteratureTypeId from LiteratureType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsLiteratureTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsLiteratureTypeDA:GetObjLst)", objException.Message));
}
List<clsLiteratureTypeEN> arrObjLst = new List<clsLiteratureTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
strSQL = "Select * from LiteratureType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLiteratureTypeEN objLiteratureTypeEN = new clsLiteratureTypeEN();
try
{
objLiteratureTypeEN.LiteratureTypeId = objRow[conLiteratureType.LiteratureTypeId].ToString().Trim(); //文献类型Id
objLiteratureTypeEN.LiteratureTypeName = objRow[conLiteratureType.LiteratureTypeName].ToString().Trim(); //文献类型名
objLiteratureTypeEN.LiteratureTypeENName = objRow[conLiteratureType.LiteratureTypeENName].ToString().Trim(); //文献类型英文名
objLiteratureTypeEN.UpdUserId = objRow[conLiteratureType.UpdUserId] == DBNull.Value ? null : objRow[conLiteratureType.UpdUserId].ToString().Trim(); //修改用户Id
objLiteratureTypeEN.UpdDate = objRow[conLiteratureType.UpdDate] == DBNull.Value ? null : objRow[conLiteratureType.UpdDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLiteratureTypeDA: GetObjLst)", objException.Message));
}
objLiteratureTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLiteratureTypeEN);
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
public List<clsLiteratureTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsLiteratureTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsLiteratureTypeEN> arrObjLst = new List<clsLiteratureTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLiteratureTypeEN objLiteratureTypeEN = new clsLiteratureTypeEN();
try
{
objLiteratureTypeEN.LiteratureTypeId = objRow[conLiteratureType.LiteratureTypeId].ToString().Trim(); //文献类型Id
objLiteratureTypeEN.LiteratureTypeName = objRow[conLiteratureType.LiteratureTypeName].ToString().Trim(); //文献类型名
objLiteratureTypeEN.LiteratureTypeENName = objRow[conLiteratureType.LiteratureTypeENName].ToString().Trim(); //文献类型英文名
objLiteratureTypeEN.UpdUserId = objRow[conLiteratureType.UpdUserId] == DBNull.Value ? null : objRow[conLiteratureType.UpdUserId].ToString().Trim(); //修改用户Id
objLiteratureTypeEN.UpdDate = objRow[conLiteratureType.UpdDate] == DBNull.Value ? null : objRow[conLiteratureType.UpdDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLiteratureTypeDA: GetObjLst)", objException.Message));
}
objLiteratureTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLiteratureTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objLiteratureTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetLiteratureType(ref clsLiteratureTypeEN objLiteratureTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
strSQL = "Select * from LiteratureType where LiteratureTypeId = " + "'"+ objLiteratureTypeEN.LiteratureTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objLiteratureTypeEN.LiteratureTypeId = objDT.Rows[0][conLiteratureType.LiteratureTypeId].ToString().Trim(); //文献类型Id(字段类型:char,字段长度:2,是否可空:False)
 objLiteratureTypeEN.LiteratureTypeName = objDT.Rows[0][conLiteratureType.LiteratureTypeName].ToString().Trim(); //文献类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objLiteratureTypeEN.LiteratureTypeENName = objDT.Rows[0][conLiteratureType.LiteratureTypeENName].ToString().Trim(); //文献类型英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objLiteratureTypeEN.UpdUserId = objDT.Rows[0][conLiteratureType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objLiteratureTypeEN.UpdDate = objDT.Rows[0][conLiteratureType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsLiteratureTypeDA: GetLiteratureType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strLiteratureTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsLiteratureTypeEN GetObjByLiteratureTypeId(string strLiteratureTypeId)
{
CheckPrimaryKey(strLiteratureTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
strSQL = "Select * from LiteratureType where LiteratureTypeId = " + "'"+ strLiteratureTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsLiteratureTypeEN objLiteratureTypeEN = new clsLiteratureTypeEN();
try
{
 objLiteratureTypeEN.LiteratureTypeId = objRow[conLiteratureType.LiteratureTypeId].ToString().Trim(); //文献类型Id(字段类型:char,字段长度:2,是否可空:False)
 objLiteratureTypeEN.LiteratureTypeName = objRow[conLiteratureType.LiteratureTypeName].ToString().Trim(); //文献类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objLiteratureTypeEN.LiteratureTypeENName = objRow[conLiteratureType.LiteratureTypeENName].ToString().Trim(); //文献类型英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objLiteratureTypeEN.UpdUserId = objRow[conLiteratureType.UpdUserId] == DBNull.Value ? null : objRow[conLiteratureType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objLiteratureTypeEN.UpdDate = objRow[conLiteratureType.UpdDate] == DBNull.Value ? null : objRow[conLiteratureType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsLiteratureTypeDA: GetObjByLiteratureTypeId)", objException.Message));
}
return objLiteratureTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsLiteratureTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsLiteratureTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
strSQL = "Select * from LiteratureType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsLiteratureTypeEN objLiteratureTypeEN = new clsLiteratureTypeEN()
{
LiteratureTypeId = objRow[conLiteratureType.LiteratureTypeId].ToString().Trim(), //文献类型Id
LiteratureTypeName = objRow[conLiteratureType.LiteratureTypeName].ToString().Trim(), //文献类型名
LiteratureTypeENName = objRow[conLiteratureType.LiteratureTypeENName].ToString().Trim(), //文献类型英文名
UpdUserId = objRow[conLiteratureType.UpdUserId] == DBNull.Value ? null : objRow[conLiteratureType.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[conLiteratureType.UpdDate] == DBNull.Value ? null : objRow[conLiteratureType.UpdDate].ToString().Trim() //修改日期
};
objLiteratureTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLiteratureTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsLiteratureTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsLiteratureTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLiteratureTypeEN objLiteratureTypeEN = new clsLiteratureTypeEN();
try
{
objLiteratureTypeEN.LiteratureTypeId = objRow[conLiteratureType.LiteratureTypeId].ToString().Trim(); //文献类型Id
objLiteratureTypeEN.LiteratureTypeName = objRow[conLiteratureType.LiteratureTypeName].ToString().Trim(); //文献类型名
objLiteratureTypeEN.LiteratureTypeENName = objRow[conLiteratureType.LiteratureTypeENName].ToString().Trim(); //文献类型英文名
objLiteratureTypeEN.UpdUserId = objRow[conLiteratureType.UpdUserId] == DBNull.Value ? null : objRow[conLiteratureType.UpdUserId].ToString().Trim(); //修改用户Id
objLiteratureTypeEN.UpdDate = objRow[conLiteratureType.UpdDate] == DBNull.Value ? null : objRow[conLiteratureType.UpdDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsLiteratureTypeDA: GetObjByDataRowLiteratureType)", objException.Message));
}
objLiteratureTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLiteratureTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsLiteratureTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLiteratureTypeEN objLiteratureTypeEN = new clsLiteratureTypeEN();
try
{
objLiteratureTypeEN.LiteratureTypeId = objRow[conLiteratureType.LiteratureTypeId].ToString().Trim(); //文献类型Id
objLiteratureTypeEN.LiteratureTypeName = objRow[conLiteratureType.LiteratureTypeName].ToString().Trim(); //文献类型名
objLiteratureTypeEN.LiteratureTypeENName = objRow[conLiteratureType.LiteratureTypeENName].ToString().Trim(); //文献类型英文名
objLiteratureTypeEN.UpdUserId = objRow[conLiteratureType.UpdUserId] == DBNull.Value ? null : objRow[conLiteratureType.UpdUserId].ToString().Trim(); //修改用户Id
objLiteratureTypeEN.UpdDate = objRow[conLiteratureType.UpdDate] == DBNull.Value ? null : objRow[conLiteratureType.UpdDate].ToString().Trim(); //修改日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsLiteratureTypeDA: GetObjByDataRow)", objException.Message));
}
objLiteratureTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLiteratureTypeEN;
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
objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLiteratureTypeEN._CurrTabName, conLiteratureType.LiteratureTypeId, 2, "");
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
objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLiteratureTypeEN._CurrTabName, conLiteratureType.LiteratureTypeId, 2, strPrefix);
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
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select LiteratureTypeId from LiteratureType where " + strCondition;
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
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select LiteratureTypeId from LiteratureType where " + strCondition;
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
 /// <param name = "strLiteratureTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strLiteratureTypeId)
{
CheckPrimaryKey(strLiteratureTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("LiteratureType", "LiteratureTypeId = " + "'"+ strLiteratureTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsLiteratureTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("LiteratureType", strCondition))
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
objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("LiteratureType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsLiteratureTypeEN objLiteratureTypeEN)
 {
 objLiteratureTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objLiteratureTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLiteratureTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
strSQL = "Select * from LiteratureType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "LiteratureType");
objRow = objDS.Tables["LiteratureType"].NewRow();
objRow[conLiteratureType.LiteratureTypeId] = objLiteratureTypeEN.LiteratureTypeId; //文献类型Id
objRow[conLiteratureType.LiteratureTypeName] = objLiteratureTypeEN.LiteratureTypeName; //文献类型名
objRow[conLiteratureType.LiteratureTypeENName] = objLiteratureTypeEN.LiteratureTypeENName; //文献类型英文名
 if (objLiteratureTypeEN.UpdUserId !=  "")
 {
objRow[conLiteratureType.UpdUserId] = objLiteratureTypeEN.UpdUserId; //修改用户Id
 }
 if (objLiteratureTypeEN.UpdDate !=  "")
 {
objRow[conLiteratureType.UpdDate] = objLiteratureTypeEN.UpdDate; //修改日期
 }
objDS.Tables[clsLiteratureTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsLiteratureTypeEN._CurrTabName);
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
 /// <param name = "objLiteratureTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLiteratureTypeEN objLiteratureTypeEN)
{
 objLiteratureTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objLiteratureTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLiteratureTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objLiteratureTypeEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeId);
 var strLiteratureTypeId = objLiteratureTypeEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objLiteratureTypeEN.LiteratureTypeName !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeName);
 var strLiteratureTypeName = objLiteratureTypeEN.LiteratureTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeName + "'");
 }
 
 if (objLiteratureTypeEN.LiteratureTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeENName);
 var strLiteratureTypeENName = objLiteratureTypeEN.LiteratureTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeENName + "'");
 }
 
 if (objLiteratureTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.UpdUserId);
 var strUpdUserId = objLiteratureTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objLiteratureTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.UpdDate);
 var strUpdDate = objLiteratureTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LiteratureType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objLiteratureTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLiteratureTypeEN objLiteratureTypeEN)
{
 objLiteratureTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objLiteratureTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLiteratureTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objLiteratureTypeEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeId);
 var strLiteratureTypeId = objLiteratureTypeEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objLiteratureTypeEN.LiteratureTypeName !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeName);
 var strLiteratureTypeName = objLiteratureTypeEN.LiteratureTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeName + "'");
 }
 
 if (objLiteratureTypeEN.LiteratureTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeENName);
 var strLiteratureTypeENName = objLiteratureTypeEN.LiteratureTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeENName + "'");
 }
 
 if (objLiteratureTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.UpdUserId);
 var strUpdUserId = objLiteratureTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objLiteratureTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.UpdDate);
 var strUpdDate = objLiteratureTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LiteratureType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objLiteratureTypeEN.LiteratureTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objLiteratureTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLiteratureTypeEN objLiteratureTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objLiteratureTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objLiteratureTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLiteratureTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objLiteratureTypeEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeId);
 var strLiteratureTypeId = objLiteratureTypeEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objLiteratureTypeEN.LiteratureTypeName !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeName);
 var strLiteratureTypeName = objLiteratureTypeEN.LiteratureTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeName + "'");
 }
 
 if (objLiteratureTypeEN.LiteratureTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeENName);
 var strLiteratureTypeENName = objLiteratureTypeEN.LiteratureTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeENName + "'");
 }
 
 if (objLiteratureTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.UpdUserId);
 var strUpdUserId = objLiteratureTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objLiteratureTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.UpdDate);
 var strUpdDate = objLiteratureTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LiteratureType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objLiteratureTypeEN.LiteratureTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objLiteratureTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLiteratureTypeEN objLiteratureTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objLiteratureTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objLiteratureTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLiteratureTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objLiteratureTypeEN.LiteratureTypeId !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeId);
 var strLiteratureTypeId = objLiteratureTypeEN.LiteratureTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeId + "'");
 }
 
 if (objLiteratureTypeEN.LiteratureTypeName !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeName);
 var strLiteratureTypeName = objLiteratureTypeEN.LiteratureTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeName + "'");
 }
 
 if (objLiteratureTypeEN.LiteratureTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.LiteratureTypeENName);
 var strLiteratureTypeENName = objLiteratureTypeEN.LiteratureTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiteratureTypeENName + "'");
 }
 
 if (objLiteratureTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.UpdUserId);
 var strUpdUserId = objLiteratureTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objLiteratureTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conLiteratureType.UpdDate);
 var strUpdDate = objLiteratureTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LiteratureType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewLiteratureTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
strSQL = "Select * from LiteratureType where LiteratureTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "LiteratureType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strLiteratureTypeId = oRow[conLiteratureType.LiteratureTypeId].ToString().Trim();
if (IsExist(strLiteratureTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("LiteratureTypeId = {0}", strLiteratureTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsLiteratureTypeEN._CurrTabName ].NewRow();
objRow[conLiteratureType.LiteratureTypeId] = oRow[conLiteratureType.LiteratureTypeId].ToString().Trim(); //文献类型Id
objRow[conLiteratureType.LiteratureTypeName] = oRow[conLiteratureType.LiteratureTypeName].ToString().Trim(); //文献类型名
objRow[conLiteratureType.LiteratureTypeENName] = oRow[conLiteratureType.LiteratureTypeENName].ToString().Trim(); //文献类型英文名
objRow[conLiteratureType.UpdUserId] = oRow[conLiteratureType.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conLiteratureType.UpdDate] = oRow[conLiteratureType.UpdDate].ToString().Trim(); //修改日期
 objDS.Tables[clsLiteratureTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsLiteratureTypeEN._CurrTabName);
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
 /// <param name = "objLiteratureTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsLiteratureTypeEN objLiteratureTypeEN)
{
 objLiteratureTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objLiteratureTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLiteratureTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
strSQL = "Select * from LiteratureType where LiteratureTypeId = " + "'"+ objLiteratureTypeEN.LiteratureTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsLiteratureTypeEN._CurrTabName);
if (objDS.Tables[clsLiteratureTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:LiteratureTypeId = " + "'"+ objLiteratureTypeEN.LiteratureTypeId+"'");
return false;
}
objRow = objDS.Tables[clsLiteratureTypeEN._CurrTabName].Rows[0];
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.LiteratureTypeId))
 {
objRow[conLiteratureType.LiteratureTypeId] = objLiteratureTypeEN.LiteratureTypeId; //文献类型Id
 }
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.LiteratureTypeName))
 {
objRow[conLiteratureType.LiteratureTypeName] = objLiteratureTypeEN.LiteratureTypeName; //文献类型名
 }
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.LiteratureTypeENName))
 {
objRow[conLiteratureType.LiteratureTypeENName] = objLiteratureTypeEN.LiteratureTypeENName; //文献类型英文名
 }
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.UpdUserId))
 {
objRow[conLiteratureType.UpdUserId] = objLiteratureTypeEN.UpdUserId; //修改用户Id
 }
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.UpdDate))
 {
objRow[conLiteratureType.UpdDate] = objLiteratureTypeEN.UpdDate; //修改日期
 }
try
{
objDA.Update(objDS, clsLiteratureTypeEN._CurrTabName);
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
 /// <param name = "objLiteratureTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLiteratureTypeEN objLiteratureTypeEN)
{
 objLiteratureTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objLiteratureTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLiteratureTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update LiteratureType Set ");
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.LiteratureTypeName))
 {
 if (objLiteratureTypeEN.LiteratureTypeName !=  null)
 {
 var strLiteratureTypeName = objLiteratureTypeEN.LiteratureTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureTypeName, conLiteratureType.LiteratureTypeName); //文献类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiteratureType.LiteratureTypeName); //文献类型名
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.LiteratureTypeENName))
 {
 if (objLiteratureTypeEN.LiteratureTypeENName !=  null)
 {
 var strLiteratureTypeENName = objLiteratureTypeEN.LiteratureTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureTypeENName, conLiteratureType.LiteratureTypeENName); //文献类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiteratureType.LiteratureTypeENName); //文献类型英文名
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.UpdUserId))
 {
 if (objLiteratureTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objLiteratureTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conLiteratureType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiteratureType.UpdUserId); //修改用户Id
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.UpdDate))
 {
 if (objLiteratureTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objLiteratureTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conLiteratureType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiteratureType.UpdDate); //修改日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LiteratureTypeId = '{0}'", objLiteratureTypeEN.LiteratureTypeId); 
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
 /// <param name = "objLiteratureTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsLiteratureTypeEN objLiteratureTypeEN, string strCondition)
{
 objLiteratureTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objLiteratureTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLiteratureTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LiteratureType Set ");
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.LiteratureTypeName))
 {
 if (objLiteratureTypeEN.LiteratureTypeName !=  null)
 {
 var strLiteratureTypeName = objLiteratureTypeEN.LiteratureTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureTypeName = '{0}',", strLiteratureTypeName); //文献类型名
 }
 else
 {
 sbSQL.Append(" LiteratureTypeName = null,"); //文献类型名
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.LiteratureTypeENName))
 {
 if (objLiteratureTypeEN.LiteratureTypeENName !=  null)
 {
 var strLiteratureTypeENName = objLiteratureTypeEN.LiteratureTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureTypeENName = '{0}',", strLiteratureTypeENName); //文献类型英文名
 }
 else
 {
 sbSQL.Append(" LiteratureTypeENName = null,"); //文献类型英文名
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.UpdUserId))
 {
 if (objLiteratureTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objLiteratureTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.UpdDate))
 {
 if (objLiteratureTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objLiteratureTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
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
 /// <param name = "objLiteratureTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsLiteratureTypeEN objLiteratureTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objLiteratureTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objLiteratureTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLiteratureTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LiteratureType Set ");
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.LiteratureTypeName))
 {
 if (objLiteratureTypeEN.LiteratureTypeName !=  null)
 {
 var strLiteratureTypeName = objLiteratureTypeEN.LiteratureTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureTypeName = '{0}',", strLiteratureTypeName); //文献类型名
 }
 else
 {
 sbSQL.Append(" LiteratureTypeName = null,"); //文献类型名
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.LiteratureTypeENName))
 {
 if (objLiteratureTypeEN.LiteratureTypeENName !=  null)
 {
 var strLiteratureTypeENName = objLiteratureTypeEN.LiteratureTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiteratureTypeENName = '{0}',", strLiteratureTypeENName); //文献类型英文名
 }
 else
 {
 sbSQL.Append(" LiteratureTypeENName = null,"); //文献类型英文名
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.UpdUserId))
 {
 if (objLiteratureTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objLiteratureTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.UpdDate))
 {
 if (objLiteratureTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objLiteratureTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
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
 /// <param name = "objLiteratureTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLiteratureTypeEN objLiteratureTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objLiteratureTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objLiteratureTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLiteratureTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LiteratureType Set ");
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.LiteratureTypeName))
 {
 if (objLiteratureTypeEN.LiteratureTypeName !=  null)
 {
 var strLiteratureTypeName = objLiteratureTypeEN.LiteratureTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureTypeName, conLiteratureType.LiteratureTypeName); //文献类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiteratureType.LiteratureTypeName); //文献类型名
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.LiteratureTypeENName))
 {
 if (objLiteratureTypeEN.LiteratureTypeENName !=  null)
 {
 var strLiteratureTypeENName = objLiteratureTypeEN.LiteratureTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiteratureTypeENName, conLiteratureType.LiteratureTypeENName); //文献类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiteratureType.LiteratureTypeENName); //文献类型英文名
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.UpdUserId))
 {
 if (objLiteratureTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objLiteratureTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conLiteratureType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiteratureType.UpdUserId); //修改用户Id
 }
 }
 
 if (objLiteratureTypeEN.IsUpdated(conLiteratureType.UpdDate))
 {
 if (objLiteratureTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objLiteratureTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conLiteratureType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiteratureType.UpdDate); //修改日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LiteratureTypeId = '{0}'", objLiteratureTypeEN.LiteratureTypeId); 
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
 /// <param name = "strLiteratureTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strLiteratureTypeId) 
{
CheckPrimaryKey(strLiteratureTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strLiteratureTypeId,
};
 objSQL.ExecSP("LiteratureType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strLiteratureTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strLiteratureTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strLiteratureTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
//删除LiteratureType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LiteratureType where LiteratureTypeId = " + "'"+ strLiteratureTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelLiteratureType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
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
//删除LiteratureType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LiteratureType where LiteratureTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strLiteratureTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strLiteratureTypeId) 
{
CheckPrimaryKey(strLiteratureTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
//删除LiteratureType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LiteratureType where LiteratureTypeId = " + "'"+ strLiteratureTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelLiteratureType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsLiteratureTypeDA: DelLiteratureType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from LiteratureType where " + strCondition ;
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
public bool DelLiteratureTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsLiteratureTypeDA: DelLiteratureTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from LiteratureType where " + strCondition ;
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
 /// <param name = "objLiteratureTypeENS">源对象</param>
 /// <param name = "objLiteratureTypeENT">目标对象</param>
public void CopyTo(clsLiteratureTypeEN objLiteratureTypeENS, clsLiteratureTypeEN objLiteratureTypeENT)
{
objLiteratureTypeENT.LiteratureTypeId = objLiteratureTypeENS.LiteratureTypeId; //文献类型Id
objLiteratureTypeENT.LiteratureTypeName = objLiteratureTypeENS.LiteratureTypeName; //文献类型名
objLiteratureTypeENT.LiteratureTypeENName = objLiteratureTypeENS.LiteratureTypeENName; //文献类型英文名
objLiteratureTypeENT.UpdUserId = objLiteratureTypeENS.UpdUserId; //修改用户Id
objLiteratureTypeENT.UpdDate = objLiteratureTypeENS.UpdDate; //修改日期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsLiteratureTypeEN objLiteratureTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objLiteratureTypeEN.LiteratureTypeName, conLiteratureType.LiteratureTypeName);
clsCheckSql.CheckFieldNotNull(objLiteratureTypeEN.LiteratureTypeENName, conLiteratureType.LiteratureTypeENName);
//检查字段长度
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.LiteratureTypeId, 2, conLiteratureType.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.LiteratureTypeName, 100, conLiteratureType.LiteratureTypeName);
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.LiteratureTypeENName, 100, conLiteratureType.LiteratureTypeENName);
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.UpdUserId, 20, conLiteratureType.UpdUserId);
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.UpdDate, 20, conLiteratureType.UpdDate);
//检查字段外键固定长度
 objLiteratureTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsLiteratureTypeEN objLiteratureTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.LiteratureTypeName, 100, conLiteratureType.LiteratureTypeName);
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.LiteratureTypeENName, 100, conLiteratureType.LiteratureTypeENName);
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.UpdUserId, 20, conLiteratureType.UpdUserId);
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.UpdDate, 20, conLiteratureType.UpdDate);
//检查外键字段长度
 objLiteratureTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsLiteratureTypeEN objLiteratureTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.LiteratureTypeId, 2, conLiteratureType.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.LiteratureTypeName, 100, conLiteratureType.LiteratureTypeName);
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.LiteratureTypeENName, 100, conLiteratureType.LiteratureTypeENName);
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.UpdUserId, 20, conLiteratureType.UpdUserId);
clsCheckSql.CheckFieldLen(objLiteratureTypeEN.UpdDate, 20, conLiteratureType.UpdDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objLiteratureTypeEN.LiteratureTypeId, conLiteratureType.LiteratureTypeId);
clsCheckSql.CheckSqlInjection4Field(objLiteratureTypeEN.LiteratureTypeName, conLiteratureType.LiteratureTypeName);
clsCheckSql.CheckSqlInjection4Field(objLiteratureTypeEN.LiteratureTypeENName, conLiteratureType.LiteratureTypeENName);
clsCheckSql.CheckSqlInjection4Field(objLiteratureTypeEN.UpdUserId, conLiteratureType.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objLiteratureTypeEN.UpdDate, conLiteratureType.UpdDate);
//检查外键字段长度
 objLiteratureTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetLiteratureTypeId()
{
//获取某学院所有专业信息
string strSQL = "select LiteratureTypeId, LiteratureTypeName from LiteratureType ";
 clsSpecSQLforSql mySql = clsLiteratureTypeDA.GetSpecSQLObj();
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
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
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
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
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
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLiteratureTypeEN._CurrTabName);
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
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLiteratureTypeEN._CurrTabName, strCondition);
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
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
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
 objSQL = clsLiteratureTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}