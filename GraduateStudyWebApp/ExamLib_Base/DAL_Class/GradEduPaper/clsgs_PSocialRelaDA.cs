
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PSocialRelaDA
 表名:gs_PSocialRela(01120671)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 论文社会关系(gs_PSocialRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_PSocialRelaDA : clsCommBase4DA
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
 return clsgs_PSocialRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_PSocialRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_PSocialRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_PSocialRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_PSocialRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from gs_PSocialRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_PSocialRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: GetDataTable_gs_PSocialRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from gs_PSocialRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from gs_PSocialRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_PSocialRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_PSocialRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_PSocialRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_PSocialRela.* from gs_PSocialRela Left Join {1} on {2} where {3} and gs_PSocialRela.mId not in (Select top {5} gs_PSocialRela.mId from gs_PSocialRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_PSocialRela where {1} and mId not in (Select top {2} mId from gs_PSocialRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_PSocialRela where {1} and mId not in (Select top {3} mId from gs_PSocialRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_PSocialRela.* from gs_PSocialRela Left Join {1} on {2} where {3} and gs_PSocialRela.mId not in (Select top {5} gs_PSocialRela.mId from gs_PSocialRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_PSocialRela where {1} and mId not in (Select top {2} mId from gs_PSocialRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_PSocialRela where {1} and mId not in (Select top {3} mId from gs_PSocialRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_PSocialRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA:GetObjLst)", objException.Message));
}
List<clsgs_PSocialRelaEN> arrObjLst = new List<clsgs_PSocialRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from gs_PSocialRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PSocialRelaEN objgs_PSocialRelaEN = new clsgs_PSocialRelaEN();
try
{
objgs_PSocialRelaEN.mId = TransNullToInt(objRow[congs_PSocialRela.mId].ToString().Trim()); //mId
objgs_PSocialRelaEN.PaperId = objRow[congs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objgs_PSocialRelaEN.SectionId = objRow[congs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[congs_PSocialRela.SectionId].ToString().Trim(); //节Id
objgs_PSocialRelaEN.SocialId = objRow[congs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objgs_PSocialRelaEN.UpdDate = objRow[congs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objgs_PSocialRelaEN.UpdUser = objRow[congs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objgs_PSocialRelaEN.Memo = objRow[congs_PSocialRela.Memo] == DBNull.Value ? null : objRow[congs_PSocialRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_PSocialRelaDA: GetObjLst)", objException.Message));
}
objgs_PSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_PSocialRelaEN);
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
public List<clsgs_PSocialRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_PSocialRelaEN> arrObjLst = new List<clsgs_PSocialRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PSocialRelaEN objgs_PSocialRelaEN = new clsgs_PSocialRelaEN();
try
{
objgs_PSocialRelaEN.mId = TransNullToInt(objRow[congs_PSocialRela.mId].ToString().Trim()); //mId
objgs_PSocialRelaEN.PaperId = objRow[congs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objgs_PSocialRelaEN.SectionId = objRow[congs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[congs_PSocialRela.SectionId].ToString().Trim(); //节Id
objgs_PSocialRelaEN.SocialId = objRow[congs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objgs_PSocialRelaEN.UpdDate = objRow[congs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objgs_PSocialRelaEN.UpdUser = objRow[congs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objgs_PSocialRelaEN.Memo = objRow[congs_PSocialRela.Memo] == DBNull.Value ? null : objRow[congs_PSocialRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_PSocialRelaDA: GetObjLst)", objException.Message));
}
objgs_PSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_PSocialRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_PSocialRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_PSocialRela(ref clsgs_PSocialRelaEN objgs_PSocialRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from gs_PSocialRela where mId = " + ""+ objgs_PSocialRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_PSocialRelaEN.mId = TransNullToInt(objDT.Rows[0][congs_PSocialRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objgs_PSocialRelaEN.PaperId = objDT.Rows[0][congs_PSocialRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PSocialRelaEN.SectionId = objDT.Rows[0][congs_PSocialRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PSocialRelaEN.SocialId = objDT.Rows[0][congs_PSocialRela.SocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_PSocialRelaEN.UpdDate = objDT.Rows[0][congs_PSocialRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PSocialRelaEN.UpdUser = objDT.Rows[0][congs_PSocialRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PSocialRelaEN.Memo = objDT.Rows[0][congs_PSocialRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_PSocialRelaDA: Getgs_PSocialRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_PSocialRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from gs_PSocialRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_PSocialRelaEN objgs_PSocialRelaEN = new clsgs_PSocialRelaEN();
try
{
 objgs_PSocialRelaEN.mId = Int32.Parse(objRow[congs_PSocialRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objgs_PSocialRelaEN.PaperId = objRow[congs_PSocialRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PSocialRelaEN.SectionId = objRow[congs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[congs_PSocialRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PSocialRelaEN.SocialId = objRow[congs_PSocialRela.SocialId].ToString().Trim(); //社会Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_PSocialRelaEN.UpdDate = objRow[congs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PSocialRelaEN.UpdUser = objRow[congs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PSocialRelaEN.Memo = objRow[congs_PSocialRela.Memo] == DBNull.Value ? null : objRow[congs_PSocialRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_PSocialRelaDA: GetObjBymId)", objException.Message));
}
return objgs_PSocialRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_PSocialRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from gs_PSocialRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_PSocialRelaEN objgs_PSocialRelaEN = new clsgs_PSocialRelaEN()
{
mId = TransNullToInt(objRow[congs_PSocialRela.mId].ToString().Trim()), //mId
PaperId = objRow[congs_PSocialRela.PaperId].ToString().Trim(), //论文Id
SectionId = objRow[congs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[congs_PSocialRela.SectionId].ToString().Trim(), //节Id
SocialId = objRow[congs_PSocialRela.SocialId].ToString().Trim(), //社会Id
UpdDate = objRow[congs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[congs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[congs_PSocialRela.Memo] == DBNull.Value ? null : objRow[congs_PSocialRela.Memo].ToString().Trim() //备注
};
objgs_PSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_PSocialRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_PSocialRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_PSocialRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_PSocialRelaEN objgs_PSocialRelaEN = new clsgs_PSocialRelaEN();
try
{
objgs_PSocialRelaEN.mId = TransNullToInt(objRow[congs_PSocialRela.mId].ToString().Trim()); //mId
objgs_PSocialRelaEN.PaperId = objRow[congs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objgs_PSocialRelaEN.SectionId = objRow[congs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[congs_PSocialRela.SectionId].ToString().Trim(); //节Id
objgs_PSocialRelaEN.SocialId = objRow[congs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objgs_PSocialRelaEN.UpdDate = objRow[congs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objgs_PSocialRelaEN.UpdUser = objRow[congs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objgs_PSocialRelaEN.Memo = objRow[congs_PSocialRela.Memo] == DBNull.Value ? null : objRow[congs_PSocialRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_PSocialRelaDA: GetObjByDataRowgs_PSocialRela)", objException.Message));
}
objgs_PSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_PSocialRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_PSocialRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_PSocialRelaEN objgs_PSocialRelaEN = new clsgs_PSocialRelaEN();
try
{
objgs_PSocialRelaEN.mId = TransNullToInt(objRow[congs_PSocialRela.mId].ToString().Trim()); //mId
objgs_PSocialRelaEN.PaperId = objRow[congs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objgs_PSocialRelaEN.SectionId = objRow[congs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[congs_PSocialRela.SectionId].ToString().Trim(); //节Id
objgs_PSocialRelaEN.SocialId = objRow[congs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objgs_PSocialRelaEN.UpdDate = objRow[congs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objgs_PSocialRelaEN.UpdUser = objRow[congs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[congs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objgs_PSocialRelaEN.Memo = objRow[congs_PSocialRela.Memo] == DBNull.Value ? null : objRow[congs_PSocialRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_PSocialRelaDA: GetObjByDataRow)", objException.Message));
}
objgs_PSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_PSocialRelaEN;
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
objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_PSocialRelaEN._CurrTabName, congs_PSocialRela.mId, 8, "");
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
objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_PSocialRelaEN._CurrTabName, congs_PSocialRela.mId, 8, strPrefix);
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
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from gs_PSocialRela where " + strCondition;
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
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from gs_PSocialRela where " + strCondition;
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
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_PSocialRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_PSocialRela", strCondition))
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
objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_PSocialRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_PSocialRelaEN objgs_PSocialRelaEN)
 {
 if (objgs_PSocialRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PSocialRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from gs_PSocialRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_PSocialRela");
objRow = objDS.Tables["gs_PSocialRela"].NewRow();
objRow[congs_PSocialRela.PaperId] = objgs_PSocialRelaEN.PaperId; //论文Id
 if (objgs_PSocialRelaEN.SectionId !=  "")
 {
objRow[congs_PSocialRela.SectionId] = objgs_PSocialRelaEN.SectionId; //节Id
 }
objRow[congs_PSocialRela.SocialId] = objgs_PSocialRelaEN.SocialId; //社会Id
 if (objgs_PSocialRelaEN.UpdDate !=  "")
 {
objRow[congs_PSocialRela.UpdDate] = objgs_PSocialRelaEN.UpdDate; //修改日期
 }
 if (objgs_PSocialRelaEN.UpdUser !=  "")
 {
objRow[congs_PSocialRela.UpdUser] = objgs_PSocialRelaEN.UpdUser; //修改人
 }
 if (objgs_PSocialRelaEN.Memo !=  "")
 {
objRow[congs_PSocialRela.Memo] = objgs_PSocialRelaEN.Memo; //备注
 }
objDS.Tables[clsgs_PSocialRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_PSocialRelaEN._CurrTabName);
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
 /// <param name = "objgs_PSocialRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_PSocialRelaEN objgs_PSocialRelaEN)
{
 if (objgs_PSocialRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PSocialRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_PSocialRelaEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.PaperId);
 var strPaperId = objgs_PSocialRelaEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PSocialRelaEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.SectionId);
 var strSectionId = objgs_PSocialRelaEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objgs_PSocialRelaEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.SocialId);
 var strSocialId = objgs_PSocialRelaEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objgs_PSocialRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.UpdDate);
 var strUpdDate = objgs_PSocialRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PSocialRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.UpdUser);
 var strUpdUser = objgs_PSocialRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PSocialRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.Memo);
 var strMemo = objgs_PSocialRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PSocialRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_PSocialRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_PSocialRelaEN objgs_PSocialRelaEN)
{
 if (objgs_PSocialRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PSocialRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_PSocialRelaEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.PaperId);
 var strPaperId = objgs_PSocialRelaEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PSocialRelaEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.SectionId);
 var strSectionId = objgs_PSocialRelaEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objgs_PSocialRelaEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.SocialId);
 var strSocialId = objgs_PSocialRelaEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objgs_PSocialRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.UpdDate);
 var strUpdDate = objgs_PSocialRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PSocialRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.UpdUser);
 var strUpdUser = objgs_PSocialRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PSocialRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.Memo);
 var strMemo = objgs_PSocialRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PSocialRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_PSocialRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_PSocialRelaEN objgs_PSocialRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_PSocialRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PSocialRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_PSocialRelaEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.PaperId);
 var strPaperId = objgs_PSocialRelaEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PSocialRelaEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.SectionId);
 var strSectionId = objgs_PSocialRelaEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objgs_PSocialRelaEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.SocialId);
 var strSocialId = objgs_PSocialRelaEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objgs_PSocialRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.UpdDate);
 var strUpdDate = objgs_PSocialRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PSocialRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.UpdUser);
 var strUpdUser = objgs_PSocialRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PSocialRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.Memo);
 var strMemo = objgs_PSocialRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PSocialRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_PSocialRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_PSocialRelaEN objgs_PSocialRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_PSocialRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PSocialRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_PSocialRelaEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.PaperId);
 var strPaperId = objgs_PSocialRelaEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PSocialRelaEN.SectionId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.SectionId);
 var strSectionId = objgs_PSocialRelaEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionId + "'");
 }
 
 if (objgs_PSocialRelaEN.SocialId !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.SocialId);
 var strSocialId = objgs_PSocialRelaEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSocialId + "'");
 }
 
 if (objgs_PSocialRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.UpdDate);
 var strUpdDate = objgs_PSocialRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PSocialRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.UpdUser);
 var strUpdUser = objgs_PSocialRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PSocialRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PSocialRela.Memo);
 var strMemo = objgs_PSocialRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PSocialRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_PSocialRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from gs_PSocialRela where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_PSocialRela");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_PSocialRelaEN._CurrTabName ].NewRow();
objRow[congs_PSocialRela.PaperId] = oRow[congs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objRow[congs_PSocialRela.SectionId] = oRow[congs_PSocialRela.SectionId].ToString().Trim(); //节Id
objRow[congs_PSocialRela.SocialId] = oRow[congs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objRow[congs_PSocialRela.UpdDate] = oRow[congs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objRow[congs_PSocialRela.UpdUser] = oRow[congs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objRow[congs_PSocialRela.Memo] = oRow[congs_PSocialRela.Memo].ToString().Trim(); //备注
 objDS.Tables[clsgs_PSocialRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_PSocialRelaEN._CurrTabName);
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
 /// <param name = "objgs_PSocialRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_PSocialRelaEN objgs_PSocialRelaEN)
{
 if (objgs_PSocialRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PSocialRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from gs_PSocialRela where mId = " + ""+ objgs_PSocialRelaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_PSocialRelaEN._CurrTabName);
if (objDS.Tables[clsgs_PSocialRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objgs_PSocialRelaEN.mId+"");
return false;
}
objRow = objDS.Tables[clsgs_PSocialRelaEN._CurrTabName].Rows[0];
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.PaperId))
 {
objRow[congs_PSocialRela.PaperId] = objgs_PSocialRelaEN.PaperId; //论文Id
 }
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.SectionId))
 {
objRow[congs_PSocialRela.SectionId] = objgs_PSocialRelaEN.SectionId; //节Id
 }
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.SocialId))
 {
objRow[congs_PSocialRela.SocialId] = objgs_PSocialRelaEN.SocialId; //社会Id
 }
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.UpdDate))
 {
objRow[congs_PSocialRela.UpdDate] = objgs_PSocialRelaEN.UpdDate; //修改日期
 }
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.UpdUser))
 {
objRow[congs_PSocialRela.UpdUser] = objgs_PSocialRelaEN.UpdUser; //修改人
 }
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.Memo))
 {
objRow[congs_PSocialRela.Memo] = objgs_PSocialRelaEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsgs_PSocialRelaEN._CurrTabName);
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
 /// <param name = "objgs_PSocialRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_PSocialRelaEN objgs_PSocialRelaEN)
{
 if (objgs_PSocialRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PSocialRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_PSocialRela Set ");
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.PaperId))
 {
 if (objgs_PSocialRelaEN.PaperId !=  null)
 {
 var strPaperId = objgs_PSocialRelaEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_PSocialRela.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.PaperId); //论文Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.SectionId))
 {
 if (objgs_PSocialRelaEN.SectionId !=  null)
 {
 var strSectionId = objgs_PSocialRelaEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionId, congs_PSocialRela.SectionId); //节Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.SectionId); //节Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.SocialId))
 {
 if (objgs_PSocialRelaEN.SocialId !=  null)
 {
 var strSocialId = objgs_PSocialRelaEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSocialId, congs_PSocialRela.SocialId); //社会Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.SocialId); //社会Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.UpdDate))
 {
 if (objgs_PSocialRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PSocialRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_PSocialRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.UpdDate); //修改日期
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.UpdUser))
 {
 if (objgs_PSocialRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PSocialRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_PSocialRela.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.UpdUser); //修改人
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.Memo))
 {
 if (objgs_PSocialRelaEN.Memo !=  null)
 {
 var strMemo = objgs_PSocialRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_PSocialRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objgs_PSocialRelaEN.mId); 
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
 /// <param name = "objgs_PSocialRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_PSocialRelaEN objgs_PSocialRelaEN, string strCondition)
{
 if (objgs_PSocialRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PSocialRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_PSocialRela Set ");
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.PaperId))
 {
 if (objgs_PSocialRelaEN.PaperId !=  null)
 {
 var strPaperId = objgs_PSocialRelaEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.SectionId))
 {
 if (objgs_PSocialRelaEN.SectionId !=  null)
 {
 var strSectionId = objgs_PSocialRelaEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionId = '{0}',", strSectionId); //节Id
 }
 else
 {
 sbSQL.Append(" SectionId = null,"); //节Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.SocialId))
 {
 if (objgs_PSocialRelaEN.SocialId !=  null)
 {
 var strSocialId = objgs_PSocialRelaEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SocialId = '{0}',", strSocialId); //社会Id
 }
 else
 {
 sbSQL.Append(" SocialId = null,"); //社会Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.UpdDate))
 {
 if (objgs_PSocialRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PSocialRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.UpdUser))
 {
 if (objgs_PSocialRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PSocialRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.Memo))
 {
 if (objgs_PSocialRelaEN.Memo !=  null)
 {
 var strMemo = objgs_PSocialRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_PSocialRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_PSocialRelaEN objgs_PSocialRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_PSocialRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PSocialRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_PSocialRela Set ");
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.PaperId))
 {
 if (objgs_PSocialRelaEN.PaperId !=  null)
 {
 var strPaperId = objgs_PSocialRelaEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.SectionId))
 {
 if (objgs_PSocialRelaEN.SectionId !=  null)
 {
 var strSectionId = objgs_PSocialRelaEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionId = '{0}',", strSectionId); //节Id
 }
 else
 {
 sbSQL.Append(" SectionId = null,"); //节Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.SocialId))
 {
 if (objgs_PSocialRelaEN.SocialId !=  null)
 {
 var strSocialId = objgs_PSocialRelaEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SocialId = '{0}',", strSocialId); //社会Id
 }
 else
 {
 sbSQL.Append(" SocialId = null,"); //社会Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.UpdDate))
 {
 if (objgs_PSocialRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PSocialRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.UpdUser))
 {
 if (objgs_PSocialRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PSocialRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.Memo))
 {
 if (objgs_PSocialRelaEN.Memo !=  null)
 {
 var strMemo = objgs_PSocialRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_PSocialRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_PSocialRelaEN objgs_PSocialRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_PSocialRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PSocialRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_PSocialRela Set ");
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.PaperId))
 {
 if (objgs_PSocialRelaEN.PaperId !=  null)
 {
 var strPaperId = objgs_PSocialRelaEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_PSocialRela.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.PaperId); //论文Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.SectionId))
 {
 if (objgs_PSocialRelaEN.SectionId !=  null)
 {
 var strSectionId = objgs_PSocialRelaEN.SectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionId, congs_PSocialRela.SectionId); //节Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.SectionId); //节Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.SocialId))
 {
 if (objgs_PSocialRelaEN.SocialId !=  null)
 {
 var strSocialId = objgs_PSocialRelaEN.SocialId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSocialId, congs_PSocialRela.SocialId); //社会Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.SocialId); //社会Id
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.UpdDate))
 {
 if (objgs_PSocialRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PSocialRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_PSocialRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.UpdDate); //修改日期
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.UpdUser))
 {
 if (objgs_PSocialRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PSocialRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_PSocialRela.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.UpdUser); //修改人
 }
 }
 
 if (objgs_PSocialRelaEN.IsUpdated(congs_PSocialRela.Memo))
 {
 if (objgs_PSocialRelaEN.Memo !=  null)
 {
 var strMemo = objgs_PSocialRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_PSocialRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PSocialRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objgs_PSocialRelaEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("gs_PSocialRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
//删除gs_PSocialRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_PSocialRela where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_PSocialRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除gs_PSocialRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_PSocialRela where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
//删除gs_PSocialRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_PSocialRela where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_PSocialRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: Delgs_PSocialRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_PSocialRela where " + strCondition ;
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
public bool Delgs_PSocialRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_PSocialRelaDA: Delgs_PSocialRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_PSocialRela where " + strCondition ;
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
 /// <param name = "objgs_PSocialRelaENS">源对象</param>
 /// <param name = "objgs_PSocialRelaENT">目标对象</param>
public void CopyTo(clsgs_PSocialRelaEN objgs_PSocialRelaENS, clsgs_PSocialRelaEN objgs_PSocialRelaENT)
{
objgs_PSocialRelaENT.mId = objgs_PSocialRelaENS.mId; //mId
objgs_PSocialRelaENT.PaperId = objgs_PSocialRelaENS.PaperId; //论文Id
objgs_PSocialRelaENT.SectionId = objgs_PSocialRelaENS.SectionId; //节Id
objgs_PSocialRelaENT.SocialId = objgs_PSocialRelaENS.SocialId; //社会Id
objgs_PSocialRelaENT.UpdDate = objgs_PSocialRelaENS.UpdDate; //修改日期
objgs_PSocialRelaENT.UpdUser = objgs_PSocialRelaENS.UpdUser; //修改人
objgs_PSocialRelaENT.Memo = objgs_PSocialRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_PSocialRelaEN objgs_PSocialRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objgs_PSocialRelaEN.PaperId, congs_PSocialRela.PaperId);
clsCheckSql.CheckFieldNotNull(objgs_PSocialRelaEN.SocialId, congs_PSocialRela.SocialId);
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.PaperId, 8, congs_PSocialRela.PaperId);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.SectionId, 8, congs_PSocialRela.SectionId);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.SocialId, 10, congs_PSocialRela.SocialId);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.UpdDate, 20, congs_PSocialRela.UpdDate);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.UpdUser, 20, congs_PSocialRela.UpdUser);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.Memo, 1000, congs_PSocialRela.Memo);
//检查字段外键固定长度
 objgs_PSocialRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_PSocialRelaEN objgs_PSocialRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.PaperId, 8, congs_PSocialRela.PaperId);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.SectionId, 8, congs_PSocialRela.SectionId);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.SocialId, 10, congs_PSocialRela.SocialId);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.UpdDate, 20, congs_PSocialRela.UpdDate);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.UpdUser, 20, congs_PSocialRela.UpdUser);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.Memo, 1000, congs_PSocialRela.Memo);
//检查外键字段长度
 objgs_PSocialRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_PSocialRelaEN objgs_PSocialRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.PaperId, 8, congs_PSocialRela.PaperId);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.SectionId, 8, congs_PSocialRela.SectionId);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.SocialId, 10, congs_PSocialRela.SocialId);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.UpdDate, 20, congs_PSocialRela.UpdDate);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.UpdUser, 20, congs_PSocialRela.UpdUser);
clsCheckSql.CheckFieldLen(objgs_PSocialRelaEN.Memo, 1000, congs_PSocialRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_PSocialRelaEN.PaperId, congs_PSocialRela.PaperId);
clsCheckSql.CheckSqlInjection4Field(objgs_PSocialRelaEN.SectionId, congs_PSocialRela.SectionId);
clsCheckSql.CheckSqlInjection4Field(objgs_PSocialRelaEN.SocialId, congs_PSocialRela.SocialId);
clsCheckSql.CheckSqlInjection4Field(objgs_PSocialRelaEN.UpdDate, congs_PSocialRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_PSocialRelaEN.UpdUser, congs_PSocialRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_PSocialRelaEN.Memo, congs_PSocialRela.Memo);
//检查外键字段长度
 objgs_PSocialRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_PSocialRela(论文社会关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_PSocialRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_PSocialRelaEN objgs_PSocialRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_PSocialRelaEN.mId);
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
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
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
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
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
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_PSocialRelaEN._CurrTabName);
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
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_PSocialRelaEN._CurrTabName, strCondition);
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
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
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
 objSQL = clsgs_PSocialRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}