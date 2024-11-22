
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperEduClsRelaDA
 表名:vPaperEduClsRela(01120932)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// vPaperEduClsRela(vPaperEduClsRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPaperEduClsRelaDA : clsCommBase4DA
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
 return clsvPaperEduClsRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPaperEduClsRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperEduClsRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPaperEduClsRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPaperEduClsRelaEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPaperEduClsRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPaperEduClsRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA: GetDataTable_vPaperEduClsRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPaperEduClsRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPaperEduClsRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperEduClsRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperEduClsRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPaperEduClsRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperEduClsRela.* from vPaperEduClsRela Left Join {1} on {2} where {3} and vPaperEduClsRela.mId not in (Select top {5} vPaperEduClsRela.mId from vPaperEduClsRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperEduClsRela where {1} and mId not in (Select top {2} mId from vPaperEduClsRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperEduClsRela where {1} and mId not in (Select top {3} mId from vPaperEduClsRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperEduClsRela.* from vPaperEduClsRela Left Join {1} on {2} where {3} and vPaperEduClsRela.mId not in (Select top {5} vPaperEduClsRela.mId from vPaperEduClsRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperEduClsRela where {1} and mId not in (Select top {2} mId from vPaperEduClsRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperEduClsRela where {1} and mId not in (Select top {3} mId from vPaperEduClsRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPaperEduClsRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA:GetObjLst)", objException.Message));
}
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPaperEduClsRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = TransNullToInt(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperEduClsRelaDA: GetObjLst)", objException.Message));
}
objvPaperEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperEduClsRelaEN);
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
public List<clsvPaperEduClsRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPaperEduClsRelaEN> arrObjLst = new List<clsvPaperEduClsRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = TransNullToInt(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperEduClsRelaDA: GetObjLst)", objException.Message));
}
objvPaperEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperEduClsRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPaperEduClsRela(ref clsvPaperEduClsRelaEN objvPaperEduClsRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPaperEduClsRela where mId = " + ""+ objvPaperEduClsRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPaperEduClsRelaEN.mId = TransNullToInt(objDT.Rows[0][convPaperEduClsRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperEduClsRelaEN.PaperId = objDT.Rows[0][convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperEduClsRelaEN.PaperTitle = objDT.Rows[0][convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperEduClsRelaEN.Author = objDT.Rows[0][convPaperEduClsRela.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperEduClsRelaEN.IdCurrEduCls = objDT.Rows[0][convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPaperEduClsRelaEN.UpdUser = objDT.Rows[0][convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEduClsRelaEN.UpdDate = objDT.Rows[0][convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEduClsRelaEN.Memo = objDT.Rows[0][convPaperEduClsRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPaperEduClsRelaDA: GetvPaperEduClsRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPaperEduClsRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPaperEduClsRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
 objvPaperEduClsRelaEN.mId = Int32.Parse(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPaperEduClsRelaDA: GetObjBymId)", objException.Message));
}
return objvPaperEduClsRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPaperEduClsRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
strSQL = "Select * from vPaperEduClsRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN()
{
mId = TransNullToInt(objRow[convPaperEduClsRela.mId].ToString().Trim()), //mId
PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(), //论文标题
Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(), //作者
IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim() //备注
};
objvPaperEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperEduClsRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPaperEduClsRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPaperEduClsRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = TransNullToInt(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPaperEduClsRelaDA: GetObjByDataRowvPaperEduClsRela)", objException.Message));
}
objvPaperEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperEduClsRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPaperEduClsRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperEduClsRelaEN objvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
try
{
objvPaperEduClsRelaEN.mId = TransNullToInt(objRow[convPaperEduClsRela.mId].ToString().Trim()); //mId
objvPaperEduClsRelaEN.PaperId = objRow[convPaperEduClsRela.PaperId] == DBNull.Value ? null : objRow[convPaperEduClsRela.PaperId].ToString().Trim(); //论文Id
objvPaperEduClsRelaEN.PaperTitle = objRow[convPaperEduClsRela.PaperTitle].ToString().Trim(); //论文标题
objvPaperEduClsRelaEN.Author = objRow[convPaperEduClsRela.Author] == DBNull.Value ? null : objRow[convPaperEduClsRela.Author].ToString().Trim(); //作者
objvPaperEduClsRelaEN.IdCurrEduCls = objRow[convPaperEduClsRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperEduClsRelaEN.UpdUser = objRow[convPaperEduClsRela.UpdUser] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdUser].ToString().Trim(); //修改人
objvPaperEduClsRelaEN.UpdDate = objRow[convPaperEduClsRela.UpdDate] == DBNull.Value ? null : objRow[convPaperEduClsRela.UpdDate].ToString().Trim(); //修改日期
objvPaperEduClsRelaEN.Memo = objRow[convPaperEduClsRela.Memo] == DBNull.Value ? null : objRow[convPaperEduClsRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPaperEduClsRelaDA: GetObjByDataRow)", objException.Message));
}
objvPaperEduClsRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperEduClsRelaEN;
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
objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperEduClsRelaEN._CurrTabName, convPaperEduClsRela.mId, 8, "");
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
objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperEduClsRelaEN._CurrTabName, convPaperEduClsRela.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vPaperEduClsRela where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vPaperEduClsRela where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperEduClsRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPaperEduClsRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperEduClsRela", strCondition))
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
objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPaperEduClsRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPaperEduClsRelaENS">源对象</param>
 /// <param name = "objvPaperEduClsRelaENT">目标对象</param>
public void CopyTo(clsvPaperEduClsRelaEN objvPaperEduClsRelaENS, clsvPaperEduClsRelaEN objvPaperEduClsRelaENT)
{
objvPaperEduClsRelaENT.mId = objvPaperEduClsRelaENS.mId; //mId
objvPaperEduClsRelaENT.PaperId = objvPaperEduClsRelaENS.PaperId; //论文Id
objvPaperEduClsRelaENT.PaperTitle = objvPaperEduClsRelaENS.PaperTitle; //论文标题
objvPaperEduClsRelaENT.Author = objvPaperEduClsRelaENS.Author; //作者
objvPaperEduClsRelaENT.IdCurrEduCls = objvPaperEduClsRelaENS.IdCurrEduCls; //教学班流水号
objvPaperEduClsRelaENT.UpdUser = objvPaperEduClsRelaENS.UpdUser; //修改人
objvPaperEduClsRelaENT.UpdDate = objvPaperEduClsRelaENS.UpdDate; //修改日期
objvPaperEduClsRelaENT.Memo = objvPaperEduClsRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPaperEduClsRelaEN objvPaperEduClsRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPaperEduClsRelaEN.PaperId, 8, convPaperEduClsRela.PaperId);
clsCheckSql.CheckFieldLen(objvPaperEduClsRelaEN.PaperTitle, 500, convPaperEduClsRela.PaperTitle);
clsCheckSql.CheckFieldLen(objvPaperEduClsRelaEN.Author, 200, convPaperEduClsRela.Author);
clsCheckSql.CheckFieldLen(objvPaperEduClsRelaEN.IdCurrEduCls, 8, convPaperEduClsRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvPaperEduClsRelaEN.UpdUser, 20, convPaperEduClsRela.UpdUser);
clsCheckSql.CheckFieldLen(objvPaperEduClsRelaEN.UpdDate, 20, convPaperEduClsRela.UpdDate);
clsCheckSql.CheckFieldLen(objvPaperEduClsRelaEN.Memo, 1000, convPaperEduClsRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPaperEduClsRelaEN.PaperId, convPaperEduClsRela.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvPaperEduClsRelaEN.PaperTitle, convPaperEduClsRela.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvPaperEduClsRelaEN.Author, convPaperEduClsRela.Author);
clsCheckSql.CheckSqlInjection4Field(objvPaperEduClsRelaEN.IdCurrEduCls, convPaperEduClsRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvPaperEduClsRelaEN.UpdUser, convPaperEduClsRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvPaperEduClsRelaEN.UpdDate, convPaperEduClsRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPaperEduClsRelaEN.Memo, convPaperEduClsRela.Memo);
//检查外键字段长度
 objvPaperEduClsRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

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
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
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
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
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
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperEduClsRelaEN._CurrTabName);
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
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperEduClsRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvPaperEduClsRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}