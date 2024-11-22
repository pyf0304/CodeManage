
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeDA
 表名:SenateGauge(01120529)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 评价量规(SenateGauge)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSenateGaugeDA : clsCommBase4DA
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
 return clsSenateGaugeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSenateGaugeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSenateGaugeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSenateGaugeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSenateGaugeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdsenateGauge">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdsenateGauge)
{
strIdsenateGauge = strIdsenateGauge.Replace("'", "''");
if (strIdsenateGauge.Length > 4)
{
throw new Exception("(errid:Data000001)在表:SenateGauge中,检查关键字,长度不正确!(clsSenateGaugeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdsenateGauge)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SenateGauge中,关键字不能为空 或 null!(clsSenateGaugeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdsenateGauge);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSenateGaugeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSenateGaugeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
strSQL = "Select * from SenateGauge where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SenateGauge(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSenateGaugeDA: GetDataTable_SenateGauge)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
strSQL = "Select * from SenateGauge where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSenateGaugeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSenateGaugeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
strSQL = "Select * from SenateGauge where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSenateGaugeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSenateGaugeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGauge where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGauge where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSenateGaugeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SenateGauge where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSenateGaugeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SenateGauge.* from SenateGauge Left Join {1} on {2} where {3} and SenateGauge.IdsenateGauge not in (Select top {5} SenateGauge.IdsenateGauge from SenateGauge Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGauge where {1} and IdsenateGauge not in (Select top {2} IdsenateGauge from SenateGauge where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGauge where {1} and IdsenateGauge not in (Select top {3} IdsenateGauge from SenateGauge where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSenateGaugeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SenateGauge.* from SenateGauge Left Join {1} on {2} where {3} and SenateGauge.IdsenateGauge not in (Select top {5} SenateGauge.IdsenateGauge from SenateGauge Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGauge where {1} and IdsenateGauge not in (Select top {2} IdsenateGauge from SenateGauge where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGauge where {1} and IdsenateGauge not in (Select top {3} IdsenateGauge from SenateGauge where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSenateGaugeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSenateGaugeDA:GetObjLst)", objException.Message));
}
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
strSQL = "Select * from SenateGauge where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSenateGaugeDA: GetObjLst)", objException.Message));
}
objSenateGaugeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSenateGaugeEN);
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
public List<clsSenateGaugeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSenateGaugeDA:GetObjLstByTabName)", objException.Message));
}
List<clsSenateGaugeEN> arrObjLst = new List<clsSenateGaugeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSenateGaugeDA: GetObjLst)", objException.Message));
}
objSenateGaugeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSenateGaugeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSenateGauge(ref clsSenateGaugeEN objSenateGaugeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
strSQL = "Select * from SenateGauge where IdsenateGauge = " + "'"+ objSenateGaugeEN.IdsenateGauge+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSenateGaugeEN.IdsenateGauge = objDT.Rows[0][conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeEN.senateGaugeID = objDT.Rows[0][conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeEN.senateGaugeName = objDT.Rows[0][conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称(字段类型:varchar,字段长度:200,是否可空:False)
 objSenateGaugeEN.senateGaugeScore = TransNullToFloat(objDT.Rows[0][conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值(字段类型:float,字段长度:8,是否可空:True)
 objSenateGaugeEN.SenateGaugeWeight = TransNullToFloat(objDT.Rows[0][conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重(字段类型:float,字段长度:8,是否可空:True)
 objSenateGaugeEN.senateGaugeMemo = objDT.Rows[0][conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objDT.Rows[0][conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeEN.OrderNum = TransNullToInt(objDT.Rows[0][conSenateGauge.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objSenateGaugeEN.UpdDate = objDT.Rows[0][conSenateGauge.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeEN.UpdUserId = objDT.Rows[0][conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSenateGaugeDA: GetSenateGauge)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdsenateGauge">表关键字</param>
 /// <returns>表对象</returns>
public clsSenateGaugeEN GetObjByIdsenateGauge(string strIdsenateGauge)
{
CheckPrimaryKey(strIdsenateGauge);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
strSQL = "Select * from SenateGauge where IdsenateGauge = " + "'"+ strIdsenateGauge+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
 objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称(字段类型:varchar,字段长度:200,是否可空:False)
 objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值(字段类型:float,字段长度:8,是否可空:True)
 objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重(字段类型:float,字段长度:8,是否可空:True)
 objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSenateGaugeDA: GetObjByIdsenateGauge)", objException.Message));
}
return objSenateGaugeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSenateGaugeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSenateGaugeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
strSQL = "Select * from SenateGauge where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN()
{
IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(), //评价量规流水号
senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(), //评价量规ID
senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(), //评价量规名称
senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()), //评价量规分值
SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()), //评价量规权重
senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(), //评价量规指标与说明
IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(), //公开课量表版本流水号
OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGauge.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim() //修改用户Id
};
objSenateGaugeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSenateGaugeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSenateGaugeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSenateGaugeDA: GetObjByDataRowSenateGauge)", objException.Message));
}
objSenateGaugeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSenateGaugeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSenateGaugeEN objSenateGaugeEN = new clsSenateGaugeEN();
try
{
objSenateGaugeEN.IdsenateGauge = objRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objSenateGaugeEN.senateGaugeID = objRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objSenateGaugeEN.senateGaugeName = objRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objSenateGaugeEN.senateGaugeScore = objRow[conSenateGauge.senateGaugeScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGauge.senateGaugeScore].ToString().Trim()); //评价量规分值
objSenateGaugeEN.SenateGaugeWeight = objRow[conSenateGauge.SenateGaugeWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGauge.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objSenateGaugeEN.senateGaugeMemo = objRow[conSenateGauge.senateGaugeMemo] == DBNull.Value ? null : objRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion = objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objSenateGaugeEN.OrderNum = objRow[conSenateGauge.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGauge.OrderNum].ToString().Trim()); //序号
objSenateGaugeEN.UpdDate = objRow[conSenateGauge.UpdDate] == DBNull.Value ? null : objRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeEN.UpdUserId = objRow[conSenateGauge.UpdUserId] == DBNull.Value ? null : objRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSenateGaugeDA: GetObjByDataRow)", objException.Message));
}
objSenateGaugeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeEN;
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
objSQL = clsSenateGaugeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSenateGaugeEN._CurrTabName, conSenateGauge.IdsenateGauge, 4, "");
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
objSQL = clsSenateGaugeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSenateGaugeEN._CurrTabName, conSenateGauge.IdsenateGauge, 4, strPrefix);
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
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdsenateGauge from SenateGauge where " + strCondition;
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
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdsenateGauge from SenateGauge where " + strCondition;
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
 /// <param name = "strIdsenateGauge">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdsenateGauge)
{
CheckPrimaryKey(strIdsenateGauge);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SenateGauge", "IdsenateGauge = " + "'"+ strIdsenateGauge+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSenateGaugeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SenateGauge", strCondition))
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
objSQL = clsSenateGaugeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SenateGauge");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSenateGaugeEN objSenateGaugeEN)
 {
 objSenateGaugeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
strSQL = "Select * from SenateGauge where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SenateGauge");
objRow = objDS.Tables["SenateGauge"].NewRow();
objRow[conSenateGauge.IdsenateGauge] = objSenateGaugeEN.IdsenateGauge; //评价量规流水号
objRow[conSenateGauge.senateGaugeID] = objSenateGaugeEN.senateGaugeID; //评价量规ID
objRow[conSenateGauge.senateGaugeName] = objSenateGaugeEN.senateGaugeName; //评价量规名称
objRow[conSenateGauge.senateGaugeScore] = objSenateGaugeEN.senateGaugeScore; //评价量规分值
objRow[conSenateGauge.SenateGaugeWeight] = objSenateGaugeEN.SenateGaugeWeight; //评价量规权重
 if (objSenateGaugeEN.senateGaugeMemo !=  "")
 {
objRow[conSenateGauge.senateGaugeMemo] = objSenateGaugeEN.senateGaugeMemo; //评价量规指标与说明
 }
objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion] = objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objRow[conSenateGauge.OrderNum] = objSenateGaugeEN.OrderNum; //序号
 if (objSenateGaugeEN.UpdDate !=  "")
 {
objRow[conSenateGauge.UpdDate] = objSenateGaugeEN.UpdDate; //修改日期
 }
 if (objSenateGaugeEN.UpdUserId !=  "")
 {
objRow[conSenateGauge.UpdUserId] = objSenateGaugeEN.UpdUserId; //修改用户Id
 }
objDS.Tables[clsSenateGaugeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSenateGaugeEN._CurrTabName);
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
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSenateGaugeEN objSenateGaugeEN)
{
 objSenateGaugeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeEN.IdsenateGauge !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.IdsenateGauge);
 var strIdsenateGauge = objSenateGaugeEN.IdsenateGauge.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdsenateGauge + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeID);
 var strsenateGaugeID = objSenateGaugeEN.senateGaugeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeID + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeName);
 var strsenateGaugeName = objSenateGaugeEN.senateGaugeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeName + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeScore !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeScore);
 arrValueListForInsert.Add(objSenateGaugeEN.senateGaugeScore.ToString());
 }
 
 if (objSenateGaugeEN.SenateGaugeWeight !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.SenateGaugeWeight);
 arrValueListForInsert.Add(objSenateGaugeEN.SenateGaugeWeight.ToString());
 }
 
 if (objSenateGaugeEN.senateGaugeMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeMemo);
 var strsenateGaugeMemo = objSenateGaugeEN.senateGaugeMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeMemo + "'");
 }
 
 if (objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.OrderNum);
 arrValueListForInsert.Add(objSenateGaugeEN.OrderNum.ToString());
 }
 
 if (objSenateGaugeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.UpdDate);
 var strUpdDate = objSenateGaugeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.UpdUserId);
 var strUpdUserId = objSenateGaugeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGauge");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSenateGaugeEN objSenateGaugeEN)
{
 objSenateGaugeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeEN.IdsenateGauge !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.IdsenateGauge);
 var strIdsenateGauge = objSenateGaugeEN.IdsenateGauge.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdsenateGauge + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeID);
 var strsenateGaugeID = objSenateGaugeEN.senateGaugeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeID + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeName);
 var strsenateGaugeName = objSenateGaugeEN.senateGaugeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeName + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeScore !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeScore);
 arrValueListForInsert.Add(objSenateGaugeEN.senateGaugeScore.ToString());
 }
 
 if (objSenateGaugeEN.SenateGaugeWeight !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.SenateGaugeWeight);
 arrValueListForInsert.Add(objSenateGaugeEN.SenateGaugeWeight.ToString());
 }
 
 if (objSenateGaugeEN.senateGaugeMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeMemo);
 var strsenateGaugeMemo = objSenateGaugeEN.senateGaugeMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeMemo + "'");
 }
 
 if (objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.OrderNum);
 arrValueListForInsert.Add(objSenateGaugeEN.OrderNum.ToString());
 }
 
 if (objSenateGaugeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.UpdDate);
 var strUpdDate = objSenateGaugeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.UpdUserId);
 var strUpdUserId = objSenateGaugeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGauge");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSenateGaugeEN.IdsenateGauge;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSenateGaugeEN objSenateGaugeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSenateGaugeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeEN.IdsenateGauge !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.IdsenateGauge);
 var strIdsenateGauge = objSenateGaugeEN.IdsenateGauge.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdsenateGauge + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeID);
 var strsenateGaugeID = objSenateGaugeEN.senateGaugeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeID + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeName);
 var strsenateGaugeName = objSenateGaugeEN.senateGaugeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeName + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeScore !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeScore);
 arrValueListForInsert.Add(objSenateGaugeEN.senateGaugeScore.ToString());
 }
 
 if (objSenateGaugeEN.SenateGaugeWeight !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.SenateGaugeWeight);
 arrValueListForInsert.Add(objSenateGaugeEN.SenateGaugeWeight.ToString());
 }
 
 if (objSenateGaugeEN.senateGaugeMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeMemo);
 var strsenateGaugeMemo = objSenateGaugeEN.senateGaugeMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeMemo + "'");
 }
 
 if (objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.OrderNum);
 arrValueListForInsert.Add(objSenateGaugeEN.OrderNum.ToString());
 }
 
 if (objSenateGaugeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.UpdDate);
 var strUpdDate = objSenateGaugeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.UpdUserId);
 var strUpdUserId = objSenateGaugeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGauge");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSenateGaugeEN.IdsenateGauge;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSenateGaugeEN objSenateGaugeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSenateGaugeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeEN.IdsenateGauge !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.IdsenateGauge);
 var strIdsenateGauge = objSenateGaugeEN.IdsenateGauge.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdsenateGauge + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeID);
 var strsenateGaugeID = objSenateGaugeEN.senateGaugeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeID + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeName);
 var strsenateGaugeName = objSenateGaugeEN.senateGaugeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeName + "'");
 }
 
 if (objSenateGaugeEN.senateGaugeScore !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeScore);
 arrValueListForInsert.Add(objSenateGaugeEN.senateGaugeScore.ToString());
 }
 
 if (objSenateGaugeEN.SenateGaugeWeight !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.SenateGaugeWeight);
 arrValueListForInsert.Add(objSenateGaugeEN.SenateGaugeWeight.ToString());
 }
 
 if (objSenateGaugeEN.senateGaugeMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.senateGaugeMemo);
 var strsenateGaugeMemo = objSenateGaugeEN.senateGaugeMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeMemo + "'");
 }
 
 if (objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.OrderNum);
 arrValueListForInsert.Add(objSenateGaugeEN.OrderNum.ToString());
 }
 
 if (objSenateGaugeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.UpdDate);
 var strUpdDate = objSenateGaugeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGauge.UpdUserId);
 var strUpdUserId = objSenateGaugeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGauge");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSenateGauges(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
strSQL = "Select * from SenateGauge where IdsenateGauge = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SenateGauge");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdsenateGauge = oRow[conSenateGauge.IdsenateGauge].ToString().Trim();
if (IsExist(strIdsenateGauge))
{
 string strResult = "关键字变量值为:" + string.Format("IdsenateGauge = {0}", strIdsenateGauge) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSenateGaugeEN._CurrTabName ].NewRow();
objRow[conSenateGauge.IdsenateGauge] = oRow[conSenateGauge.IdsenateGauge].ToString().Trim(); //评价量规流水号
objRow[conSenateGauge.senateGaugeID] = oRow[conSenateGauge.senateGaugeID].ToString().Trim(); //评价量规ID
objRow[conSenateGauge.senateGaugeName] = oRow[conSenateGauge.senateGaugeName].ToString().Trim(); //评价量规名称
objRow[conSenateGauge.senateGaugeScore] = oRow[conSenateGauge.senateGaugeScore].ToString().Trim(); //评价量规分值
objRow[conSenateGauge.SenateGaugeWeight] = oRow[conSenateGauge.SenateGaugeWeight].ToString().Trim(); //评价量规权重
objRow[conSenateGauge.senateGaugeMemo] = oRow[conSenateGauge.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion] = oRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objRow[conSenateGauge.OrderNum] = oRow[conSenateGauge.OrderNum].ToString().Trim(); //序号
objRow[conSenateGauge.UpdDate] = oRow[conSenateGauge.UpdDate].ToString().Trim(); //修改日期
objRow[conSenateGauge.UpdUserId] = oRow[conSenateGauge.UpdUserId].ToString().Trim(); //修改用户Id
 objDS.Tables[clsSenateGaugeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSenateGaugeEN._CurrTabName);
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
 /// <param name = "objSenateGaugeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSenateGaugeEN objSenateGaugeEN)
{
 objSenateGaugeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
strSQL = "Select * from SenateGauge where IdsenateGauge = " + "'"+ objSenateGaugeEN.IdsenateGauge+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSenateGaugeEN._CurrTabName);
if (objDS.Tables[clsSenateGaugeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdsenateGauge = " + "'"+ objSenateGaugeEN.IdsenateGauge+"'");
return false;
}
objRow = objDS.Tables[clsSenateGaugeEN._CurrTabName].Rows[0];
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.IdsenateGauge))
 {
objRow[conSenateGauge.IdsenateGauge] = objSenateGaugeEN.IdsenateGauge; //评价量规流水号
 }
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeID))
 {
objRow[conSenateGauge.senateGaugeID] = objSenateGaugeEN.senateGaugeID; //评价量规ID
 }
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeName))
 {
objRow[conSenateGauge.senateGaugeName] = objSenateGaugeEN.senateGaugeName; //评价量规名称
 }
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeScore))
 {
objRow[conSenateGauge.senateGaugeScore] = objSenateGaugeEN.senateGaugeScore; //评价量规分值
 }
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.SenateGaugeWeight))
 {
objRow[conSenateGauge.SenateGaugeWeight] = objSenateGaugeEN.SenateGaugeWeight; //评价量规权重
 }
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeMemo))
 {
objRow[conSenateGauge.senateGaugeMemo] = objSenateGaugeEN.senateGaugeMemo; //评价量规指标与说明
 }
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.IdPubClassCaseSenateGaugeVersion))
 {
objRow[conSenateGauge.IdPubClassCaseSenateGaugeVersion] = objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
 }
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.OrderNum))
 {
objRow[conSenateGauge.OrderNum] = objSenateGaugeEN.OrderNum; //序号
 }
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.UpdDate))
 {
objRow[conSenateGauge.UpdDate] = objSenateGaugeEN.UpdDate; //修改日期
 }
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.UpdUserId))
 {
objRow[conSenateGauge.UpdUserId] = objSenateGaugeEN.UpdUserId; //修改用户Id
 }
try
{
objDA.Update(objDS, clsSenateGaugeEN._CurrTabName);
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
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSenateGaugeEN objSenateGaugeEN)
{
 objSenateGaugeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SenateGauge Set ");
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeID))
 {
 if (objSenateGaugeEN.senateGaugeID !=  null)
 {
 var strsenateGaugeID = objSenateGaugeEN.senateGaugeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeID, conSenateGauge.senateGaugeID); //评价量规ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.senateGaugeID); //评价量规ID
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeName))
 {
 if (objSenateGaugeEN.senateGaugeName !=  null)
 {
 var strsenateGaugeName = objSenateGaugeEN.senateGaugeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeName, conSenateGauge.senateGaugeName); //评价量规名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.senateGaugeName); //评价量规名称
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeScore))
 {
 if (objSenateGaugeEN.senateGaugeScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.senateGaugeScore, conSenateGauge.senateGaugeScore); //评价量规分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.senateGaugeScore); //评价量规分值
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.SenateGaugeWeight))
 {
 if (objSenateGaugeEN.SenateGaugeWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.SenateGaugeWeight, conSenateGauge.SenateGaugeWeight); //评价量规权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.SenateGaugeWeight); //评价量规权重
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeMemo))
 {
 if (objSenateGaugeEN.senateGaugeMemo !=  null)
 {
 var strsenateGaugeMemo = objSenateGaugeEN.senateGaugeMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeMemo, conSenateGauge.senateGaugeMemo); //评价量规指标与说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.senateGaugeMemo); //评价量规指标与说明
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.IdPubClassCaseSenateGaugeVersion))
 {
 if (objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 var strIdPubClassCaseSenateGaugeVersion = objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubClassCaseSenateGaugeVersion, conSenateGauge.IdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.IdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.OrderNum))
 {
 if (objSenateGaugeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.OrderNum, conSenateGauge.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.OrderNum); //序号
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.UpdDate))
 {
 if (objSenateGaugeEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSenateGauge.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.UpdDate); //修改日期
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.UpdUserId))
 {
 if (objSenateGaugeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSenateGauge.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.UpdUserId); //修改用户Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdsenateGauge = '{0}'", objSenateGaugeEN.IdsenateGauge); 
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
 /// <param name = "objSenateGaugeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSenateGaugeEN objSenateGaugeEN, string strCondition)
{
 objSenateGaugeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGauge Set ");
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeID))
 {
 if (objSenateGaugeEN.senateGaugeID !=  null)
 {
 var strsenateGaugeID = objSenateGaugeEN.senateGaugeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeID = '{0}',", strsenateGaugeID); //评价量规ID
 }
 else
 {
 sbSQL.Append(" senateGaugeID = null,"); //评价量规ID
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeName))
 {
 if (objSenateGaugeEN.senateGaugeName !=  null)
 {
 var strsenateGaugeName = objSenateGaugeEN.senateGaugeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeName = '{0}',", strsenateGaugeName); //评价量规名称
 }
 else
 {
 sbSQL.Append(" senateGaugeName = null,"); //评价量规名称
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeScore))
 {
 if (objSenateGaugeEN.senateGaugeScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.senateGaugeScore, conSenateGauge.senateGaugeScore); //评价量规分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.senateGaugeScore); //评价量规分值
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.SenateGaugeWeight))
 {
 if (objSenateGaugeEN.SenateGaugeWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.SenateGaugeWeight, conSenateGauge.SenateGaugeWeight); //评价量规权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.SenateGaugeWeight); //评价量规权重
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeMemo))
 {
 if (objSenateGaugeEN.senateGaugeMemo !=  null)
 {
 var strsenateGaugeMemo = objSenateGaugeEN.senateGaugeMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeMemo = '{0}',", strsenateGaugeMemo); //评价量规指标与说明
 }
 else
 {
 sbSQL.Append(" senateGaugeMemo = null,"); //评价量规指标与说明
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.IdPubClassCaseSenateGaugeVersion))
 {
 if (objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 var strIdPubClassCaseSenateGaugeVersion = objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubClassCaseSenateGaugeVersion = '{0}',", strIdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdPubClassCaseSenateGaugeVersion = null,"); //公开课量表版本流水号
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.OrderNum))
 {
 if (objSenateGaugeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.OrderNum, conSenateGauge.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.OrderNum); //序号
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.UpdDate))
 {
 if (objSenateGaugeEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.UpdUserId))
 {
 if (objSenateGaugeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
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
 /// <param name = "objSenateGaugeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSenateGaugeEN objSenateGaugeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSenateGaugeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGauge Set ");
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeID))
 {
 if (objSenateGaugeEN.senateGaugeID !=  null)
 {
 var strsenateGaugeID = objSenateGaugeEN.senateGaugeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeID = '{0}',", strsenateGaugeID); //评价量规ID
 }
 else
 {
 sbSQL.Append(" senateGaugeID = null,"); //评价量规ID
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeName))
 {
 if (objSenateGaugeEN.senateGaugeName !=  null)
 {
 var strsenateGaugeName = objSenateGaugeEN.senateGaugeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeName = '{0}',", strsenateGaugeName); //评价量规名称
 }
 else
 {
 sbSQL.Append(" senateGaugeName = null,"); //评价量规名称
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeScore))
 {
 if (objSenateGaugeEN.senateGaugeScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.senateGaugeScore, conSenateGauge.senateGaugeScore); //评价量规分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.senateGaugeScore); //评价量规分值
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.SenateGaugeWeight))
 {
 if (objSenateGaugeEN.SenateGaugeWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.SenateGaugeWeight, conSenateGauge.SenateGaugeWeight); //评价量规权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.SenateGaugeWeight); //评价量规权重
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeMemo))
 {
 if (objSenateGaugeEN.senateGaugeMemo !=  null)
 {
 var strsenateGaugeMemo = objSenateGaugeEN.senateGaugeMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeMemo = '{0}',", strsenateGaugeMemo); //评价量规指标与说明
 }
 else
 {
 sbSQL.Append(" senateGaugeMemo = null,"); //评价量规指标与说明
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.IdPubClassCaseSenateGaugeVersion))
 {
 if (objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 var strIdPubClassCaseSenateGaugeVersion = objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubClassCaseSenateGaugeVersion = '{0}',", strIdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdPubClassCaseSenateGaugeVersion = null,"); //公开课量表版本流水号
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.OrderNum))
 {
 if (objSenateGaugeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.OrderNum, conSenateGauge.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.OrderNum); //序号
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.UpdDate))
 {
 if (objSenateGaugeEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.UpdUserId))
 {
 if (objSenateGaugeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
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
 /// <param name = "objSenateGaugeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSenateGaugeEN objSenateGaugeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSenateGaugeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGauge Set ");
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeID))
 {
 if (objSenateGaugeEN.senateGaugeID !=  null)
 {
 var strsenateGaugeID = objSenateGaugeEN.senateGaugeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeID, conSenateGauge.senateGaugeID); //评价量规ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.senateGaugeID); //评价量规ID
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeName))
 {
 if (objSenateGaugeEN.senateGaugeName !=  null)
 {
 var strsenateGaugeName = objSenateGaugeEN.senateGaugeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeName, conSenateGauge.senateGaugeName); //评价量规名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.senateGaugeName); //评价量规名称
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeScore))
 {
 if (objSenateGaugeEN.senateGaugeScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.senateGaugeScore, conSenateGauge.senateGaugeScore); //评价量规分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.senateGaugeScore); //评价量规分值
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.SenateGaugeWeight))
 {
 if (objSenateGaugeEN.SenateGaugeWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.SenateGaugeWeight, conSenateGauge.SenateGaugeWeight); //评价量规权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.SenateGaugeWeight); //评价量规权重
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.senateGaugeMemo))
 {
 if (objSenateGaugeEN.senateGaugeMemo !=  null)
 {
 var strsenateGaugeMemo = objSenateGaugeEN.senateGaugeMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeMemo, conSenateGauge.senateGaugeMemo); //评价量规指标与说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.senateGaugeMemo); //评价量规指标与说明
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.IdPubClassCaseSenateGaugeVersion))
 {
 if (objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 var strIdPubClassCaseSenateGaugeVersion = objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubClassCaseSenateGaugeVersion, conSenateGauge.IdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.IdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.OrderNum))
 {
 if (objSenateGaugeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeEN.OrderNum, conSenateGauge.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.OrderNum); //序号
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.UpdDate))
 {
 if (objSenateGaugeEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSenateGauge.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.UpdDate); //修改日期
 }
 }
 
 if (objSenateGaugeEN.IsUpdated(conSenateGauge.UpdUserId))
 {
 if (objSenateGaugeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSenateGauge.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGauge.UpdUserId); //修改用户Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdsenateGauge = '{0}'", objSenateGaugeEN.IdsenateGauge); 
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
 /// <param name = "strIdsenateGauge">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdsenateGauge) 
{
CheckPrimaryKey(strIdsenateGauge);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdsenateGauge,
};
 objSQL.ExecSP("SenateGauge_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdsenateGauge">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdsenateGauge, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdsenateGauge);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
//删除SenateGauge本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGauge where IdsenateGauge = " + "'"+ strIdsenateGauge+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSenateGauge(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
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
//删除SenateGauge本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGauge where IdsenateGauge in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdsenateGauge">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdsenateGauge) 
{
CheckPrimaryKey(strIdsenateGauge);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
//删除SenateGauge本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGauge where IdsenateGauge = " + "'"+ strIdsenateGauge+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSenateGauge(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSenateGaugeDA: DelSenateGauge)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SenateGauge where " + strCondition ;
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
public bool DelSenateGaugeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSenateGaugeDA: DelSenateGaugeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SenateGauge where " + strCondition ;
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
 /// <param name = "objSenateGaugeENS">源对象</param>
 /// <param name = "objSenateGaugeENT">目标对象</param>
public void CopyTo(clsSenateGaugeEN objSenateGaugeENS, clsSenateGaugeEN objSenateGaugeENT)
{
objSenateGaugeENT.IdsenateGauge = objSenateGaugeENS.IdsenateGauge; //评价量规流水号
objSenateGaugeENT.senateGaugeID = objSenateGaugeENS.senateGaugeID; //评价量规ID
objSenateGaugeENT.senateGaugeName = objSenateGaugeENS.senateGaugeName; //评价量规名称
objSenateGaugeENT.senateGaugeScore = objSenateGaugeENS.senateGaugeScore; //评价量规分值
objSenateGaugeENT.SenateGaugeWeight = objSenateGaugeENS.SenateGaugeWeight; //评价量规权重
objSenateGaugeENT.senateGaugeMemo = objSenateGaugeENS.senateGaugeMemo; //评价量规指标与说明
objSenateGaugeENT.IdPubClassCaseSenateGaugeVersion = objSenateGaugeENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objSenateGaugeENT.OrderNum = objSenateGaugeENS.OrderNum; //序号
objSenateGaugeENT.UpdDate = objSenateGaugeENS.UpdDate; //修改日期
objSenateGaugeENT.UpdUserId = objSenateGaugeENS.UpdUserId; //修改用户Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSenateGaugeEN objSenateGaugeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSenateGaugeEN.senateGaugeID, conSenateGauge.senateGaugeID);
clsCheckSql.CheckFieldNotNull(objSenateGaugeEN.senateGaugeName, conSenateGauge.senateGaugeName);
clsCheckSql.CheckFieldNotNull(objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion, conSenateGauge.IdPubClassCaseSenateGaugeVersion);
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeEN.IdsenateGauge, 4, conSenateGauge.IdsenateGauge);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.senateGaugeID, 4, conSenateGauge.senateGaugeID);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.senateGaugeName, 200, conSenateGauge.senateGaugeName);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.senateGaugeMemo, 1000, conSenateGauge.senateGaugeMemo);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion, 4, conSenateGauge.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.UpdDate, 20, conSenateGauge.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.UpdUserId, 20, conSenateGauge.UpdUserId);
//检查字段外键固定长度
 objSenateGaugeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSenateGaugeEN objSenateGaugeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeEN.senateGaugeID, 4, conSenateGauge.senateGaugeID);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.senateGaugeName, 200, conSenateGauge.senateGaugeName);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.senateGaugeMemo, 1000, conSenateGauge.senateGaugeMemo);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion, 4, conSenateGauge.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.UpdDate, 20, conSenateGauge.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.UpdUserId, 20, conSenateGauge.UpdUserId);
//检查外键字段长度
 objSenateGaugeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSenateGaugeEN objSenateGaugeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeEN.IdsenateGauge, 4, conSenateGauge.IdsenateGauge);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.senateGaugeID, 4, conSenateGauge.senateGaugeID);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.senateGaugeName, 200, conSenateGauge.senateGaugeName);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.senateGaugeMemo, 1000, conSenateGauge.senateGaugeMemo);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion, 4, conSenateGauge.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.UpdDate, 20, conSenateGauge.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeEN.UpdUserId, 20, conSenateGauge.UpdUserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeEN.IdsenateGauge, conSenateGauge.IdsenateGauge);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeEN.senateGaugeID, conSenateGauge.senateGaugeID);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeEN.senateGaugeName, conSenateGauge.senateGaugeName);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeEN.senateGaugeMemo, conSenateGauge.senateGaugeMemo);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeEN.IdPubClassCaseSenateGaugeVersion, conSenateGauge.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeEN.UpdDate, conSenateGauge.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeEN.UpdUserId, conSenateGauge.UpdUserId);
//检查外键字段长度
 objSenateGaugeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdsenateGauge()
{
//获取某学院所有专业信息
string strSQL = "select IdsenateGauge, senateGaugeName from SenateGauge ";
 clsSpecSQLforSql mySql = clsSenateGaugeDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSenateGaugeEN._CurrTabName);
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
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSenateGaugeEN._CurrTabName, strCondition);
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
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}