
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRTViewpointRelaDA
 表名:RTViewpointRela(01120545)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 主题观点关系表(RTViewpointRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsRTViewpointRelaDA : clsCommBase4DA
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
 return clsRTViewpointRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsRTViewpointRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRTViewpointRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsRTViewpointRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsRTViewpointRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTViewpointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_RTViewpointRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA: GetDataTable_RTViewpointRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTViewpointRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTViewpointRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RTViewpointRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RTViewpointRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from RTViewpointRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsRTViewpointRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} RTViewpointRela.* from RTViewpointRela Left Join {1} on {2} where {3} and RTViewpointRela.mId not in (Select top {5} RTViewpointRela.mId from RTViewpointRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RTViewpointRela where {1} and mId not in (Select top {2} mId from RTViewpointRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RTViewpointRela where {1} and mId not in (Select top {3} mId from RTViewpointRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsRTViewpointRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} RTViewpointRela.* from RTViewpointRela Left Join {1} on {2} where {3} and RTViewpointRela.mId not in (Select top {5} RTViewpointRela.mId from RTViewpointRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RTViewpointRela where {1} and mId not in (Select top {2} mId from RTViewpointRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RTViewpointRela where {1} and mId not in (Select top {3} mId from RTViewpointRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsRTViewpointRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA:GetObjLst)", objException.Message));
}
List<clsRTViewpointRelaEN> arrObjLst = new List<clsRTViewpointRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTViewpointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTViewpointRelaEN objRTViewpointRelaEN = new clsRTViewpointRelaEN();
try
{
objRTViewpointRelaEN.mId = TransNullToInt(objRow[conRTViewpointRela.mId].ToString().Trim()); //mId
objRTViewpointRelaEN.TopicId = objRow[conRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[conRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objRTViewpointRelaEN.ViewpointId = objRow[conRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[conRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objRTViewpointRelaEN.ProposePeople = objRow[conRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[conRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objRTViewpointRelaEN.UpdDate = objRow[conRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objRTViewpointRelaEN.UpdUser = objRow[conRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objRTViewpointRelaEN.Memo = objRow[conRTViewpointRela.Memo] == DBNull.Value ? null : objRow[conRTViewpointRela.Memo].ToString().Trim(); //备注
objRTViewpointRelaEN.ClassificationId = objRow[conRTViewpointRela.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conRTViewpointRela.ClassificationId].ToString().Trim()); //分类Id
objRTViewpointRelaEN.IdCurrEduCls = objRow[conRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsRTViewpointRelaDA: GetObjLst)", objException.Message));
}
objRTViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objRTViewpointRelaEN);
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
public List<clsRTViewpointRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsRTViewpointRelaEN> arrObjLst = new List<clsRTViewpointRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTViewpointRelaEN objRTViewpointRelaEN = new clsRTViewpointRelaEN();
try
{
objRTViewpointRelaEN.mId = TransNullToInt(objRow[conRTViewpointRela.mId].ToString().Trim()); //mId
objRTViewpointRelaEN.TopicId = objRow[conRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[conRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objRTViewpointRelaEN.ViewpointId = objRow[conRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[conRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objRTViewpointRelaEN.ProposePeople = objRow[conRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[conRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objRTViewpointRelaEN.UpdDate = objRow[conRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objRTViewpointRelaEN.UpdUser = objRow[conRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objRTViewpointRelaEN.Memo = objRow[conRTViewpointRela.Memo] == DBNull.Value ? null : objRow[conRTViewpointRela.Memo].ToString().Trim(); //备注
objRTViewpointRelaEN.ClassificationId = objRow[conRTViewpointRela.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conRTViewpointRela.ClassificationId].ToString().Trim()); //分类Id
objRTViewpointRelaEN.IdCurrEduCls = objRow[conRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsRTViewpointRelaDA: GetObjLst)", objException.Message));
}
objRTViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objRTViewpointRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objRTViewpointRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetRTViewpointRela(ref clsRTViewpointRelaEN objRTViewpointRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTViewpointRela where mId = " + ""+ objRTViewpointRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objRTViewpointRelaEN.mId = TransNullToInt(objDT.Rows[0][conRTViewpointRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objRTViewpointRelaEN.TopicId = objDT.Rows[0][conRTViewpointRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objRTViewpointRelaEN.ViewpointId = objDT.Rows[0][conRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objRTViewpointRelaEN.ProposePeople = objDT.Rows[0][conRTViewpointRela.ProposePeople].ToString().Trim(); //提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objRTViewpointRelaEN.UpdDate = objDT.Rows[0][conRTViewpointRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objRTViewpointRelaEN.UpdUser = objDT.Rows[0][conRTViewpointRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objRTViewpointRelaEN.Memo = objDT.Rows[0][conRTViewpointRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objRTViewpointRelaEN.ClassificationId = TransNullToInt(objDT.Rows[0][conRTViewpointRela.ClassificationId].ToString().Trim()); //分类Id(字段类型:bigint,字段长度:8,是否可空:False)
 objRTViewpointRelaEN.IdCurrEduCls = objDT.Rows[0][conRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsRTViewpointRelaDA: GetRTViewpointRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsRTViewpointRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTViewpointRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsRTViewpointRelaEN objRTViewpointRelaEN = new clsRTViewpointRelaEN();
try
{
 objRTViewpointRelaEN.mId = Int32.Parse(objRow[conRTViewpointRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objRTViewpointRelaEN.TopicId = objRow[conRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[conRTViewpointRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objRTViewpointRelaEN.ViewpointId = objRow[conRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[conRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objRTViewpointRelaEN.ProposePeople = objRow[conRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[conRTViewpointRela.ProposePeople].ToString().Trim(); //提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objRTViewpointRelaEN.UpdDate = objRow[conRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objRTViewpointRelaEN.UpdUser = objRow[conRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objRTViewpointRelaEN.Memo = objRow[conRTViewpointRela.Memo] == DBNull.Value ? null : objRow[conRTViewpointRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objRTViewpointRelaEN.ClassificationId = objRow[conRTViewpointRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTViewpointRela.ClassificationId].ToString().Trim()); //分类Id(字段类型:bigint,字段长度:8,是否可空:False)
 objRTViewpointRelaEN.IdCurrEduCls = objRow[conRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsRTViewpointRelaDA: GetObjBymId)", objException.Message));
}
return objRTViewpointRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsRTViewpointRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTViewpointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsRTViewpointRelaEN objRTViewpointRelaEN = new clsRTViewpointRelaEN()
{
mId = TransNullToInt(objRow[conRTViewpointRela.mId].ToString().Trim()), //mId
TopicId = objRow[conRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[conRTViewpointRela.TopicId].ToString().Trim(), //主题Id
ViewpointId = objRow[conRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[conRTViewpointRela.ViewpointId].ToString().Trim(), //观点Id
ProposePeople = objRow[conRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[conRTViewpointRela.ProposePeople].ToString().Trim(), //提出人
UpdDate = objRow[conRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conRTViewpointRela.Memo] == DBNull.Value ? null : objRow[conRTViewpointRela.Memo].ToString().Trim(), //备注
ClassificationId = objRow[conRTViewpointRela.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conRTViewpointRela.ClassificationId].ToString().Trim()), //分类Id
IdCurrEduCls = objRow[conRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTViewpointRela.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objRTViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRTViewpointRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsRTViewpointRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsRTViewpointRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsRTViewpointRelaEN objRTViewpointRelaEN = new clsRTViewpointRelaEN();
try
{
objRTViewpointRelaEN.mId = TransNullToInt(objRow[conRTViewpointRela.mId].ToString().Trim()); //mId
objRTViewpointRelaEN.TopicId = objRow[conRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[conRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objRTViewpointRelaEN.ViewpointId = objRow[conRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[conRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objRTViewpointRelaEN.ProposePeople = objRow[conRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[conRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objRTViewpointRelaEN.UpdDate = objRow[conRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objRTViewpointRelaEN.UpdUser = objRow[conRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objRTViewpointRelaEN.Memo = objRow[conRTViewpointRela.Memo] == DBNull.Value ? null : objRow[conRTViewpointRela.Memo].ToString().Trim(); //备注
objRTViewpointRelaEN.ClassificationId = objRow[conRTViewpointRela.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conRTViewpointRela.ClassificationId].ToString().Trim()); //分类Id
objRTViewpointRelaEN.IdCurrEduCls = objRow[conRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsRTViewpointRelaDA: GetObjByDataRowRTViewpointRela)", objException.Message));
}
objRTViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRTViewpointRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsRTViewpointRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsRTViewpointRelaEN objRTViewpointRelaEN = new clsRTViewpointRelaEN();
try
{
objRTViewpointRelaEN.mId = TransNullToInt(objRow[conRTViewpointRela.mId].ToString().Trim()); //mId
objRTViewpointRelaEN.TopicId = objRow[conRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[conRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objRTViewpointRelaEN.ViewpointId = objRow[conRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[conRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objRTViewpointRelaEN.ProposePeople = objRow[conRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[conRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objRTViewpointRelaEN.UpdDate = objRow[conRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objRTViewpointRelaEN.UpdUser = objRow[conRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[conRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objRTViewpointRelaEN.Memo = objRow[conRTViewpointRela.Memo] == DBNull.Value ? null : objRow[conRTViewpointRela.Memo].ToString().Trim(); //备注
objRTViewpointRelaEN.ClassificationId = objRow[conRTViewpointRela.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conRTViewpointRela.ClassificationId].ToString().Trim()); //分类Id
objRTViewpointRelaEN.IdCurrEduCls = objRow[conRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsRTViewpointRelaDA: GetObjByDataRow)", objException.Message));
}
objRTViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRTViewpointRelaEN;
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
objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsRTViewpointRelaEN._CurrTabName, conRTViewpointRela.mId, 8, "");
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
objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsRTViewpointRelaEN._CurrTabName, conRTViewpointRela.mId, 8, strPrefix);
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from RTViewpointRela where " + strCondition;
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from RTViewpointRela where " + strCondition;
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("RTViewpointRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("RTViewpointRela", strCondition))
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
objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("RTViewpointRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsRTViewpointRelaEN objRTViewpointRelaEN)
 {
 objRTViewpointRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTViewpointRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRTViewpointRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTViewpointRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "RTViewpointRela");
objRow = objDS.Tables["RTViewpointRela"].NewRow();
 if (objRTViewpointRelaEN.TopicId !=  "")
 {
objRow[conRTViewpointRela.TopicId] = objRTViewpointRelaEN.TopicId; //主题Id
 }
 if (objRTViewpointRelaEN.ViewpointId !=  "")
 {
objRow[conRTViewpointRela.ViewpointId] = objRTViewpointRelaEN.ViewpointId; //观点Id
 }
 if (objRTViewpointRelaEN.ProposePeople !=  "")
 {
objRow[conRTViewpointRela.ProposePeople] = objRTViewpointRelaEN.ProposePeople; //提出人
 }
 if (objRTViewpointRelaEN.UpdDate !=  "")
 {
objRow[conRTViewpointRela.UpdDate] = objRTViewpointRelaEN.UpdDate; //修改日期
 }
 if (objRTViewpointRelaEN.UpdUser !=  "")
 {
objRow[conRTViewpointRela.UpdUser] = objRTViewpointRelaEN.UpdUser; //修改人
 }
 if (objRTViewpointRelaEN.Memo !=  "")
 {
objRow[conRTViewpointRela.Memo] = objRTViewpointRelaEN.Memo; //备注
 }
objRow[conRTViewpointRela.ClassificationId] = objRTViewpointRelaEN.ClassificationId; //分类Id
 if (objRTViewpointRelaEN.IdCurrEduCls !=  "")
 {
objRow[conRTViewpointRela.IdCurrEduCls] = objRTViewpointRelaEN.IdCurrEduCls; //教学班流水号
 }
objDS.Tables[clsRTViewpointRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsRTViewpointRelaEN._CurrTabName);
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
 /// <param name = "objRTViewpointRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsRTViewpointRelaEN objRTViewpointRelaEN)
{
 objRTViewpointRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTViewpointRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRTViewpointRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objRTViewpointRelaEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.TopicId);
 var strTopicId = objRTViewpointRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objRTViewpointRelaEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ViewpointId);
 var strViewpointId = objRTViewpointRelaEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objRTViewpointRelaEN.ProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ProposePeople);
 var strProposePeople = objRTViewpointRelaEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProposePeople + "'");
 }
 
 if (objRTViewpointRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.UpdDate);
 var strUpdDate = objRTViewpointRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objRTViewpointRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.UpdUser);
 var strUpdUser = objRTViewpointRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objRTViewpointRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.Memo);
 var strMemo = objRTViewpointRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objRTViewpointRelaEN.ClassificationId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ClassificationId);
 arrValueListForInsert.Add(objRTViewpointRelaEN.ClassificationId.ToString());
 }
 
 if (objRTViewpointRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.IdCurrEduCls);
 var strIdCurrEduCls = objRTViewpointRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RTViewpointRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objRTViewpointRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsRTViewpointRelaEN objRTViewpointRelaEN)
{
 objRTViewpointRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTViewpointRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRTViewpointRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objRTViewpointRelaEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.TopicId);
 var strTopicId = objRTViewpointRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objRTViewpointRelaEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ViewpointId);
 var strViewpointId = objRTViewpointRelaEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objRTViewpointRelaEN.ProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ProposePeople);
 var strProposePeople = objRTViewpointRelaEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProposePeople + "'");
 }
 
 if (objRTViewpointRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.UpdDate);
 var strUpdDate = objRTViewpointRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objRTViewpointRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.UpdUser);
 var strUpdUser = objRTViewpointRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objRTViewpointRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.Memo);
 var strMemo = objRTViewpointRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objRTViewpointRelaEN.ClassificationId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ClassificationId);
 arrValueListForInsert.Add(objRTViewpointRelaEN.ClassificationId.ToString());
 }
 
 if (objRTViewpointRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.IdCurrEduCls);
 var strIdCurrEduCls = objRTViewpointRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RTViewpointRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objRTViewpointRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsRTViewpointRelaEN objRTViewpointRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objRTViewpointRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTViewpointRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRTViewpointRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objRTViewpointRelaEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.TopicId);
 var strTopicId = objRTViewpointRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objRTViewpointRelaEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ViewpointId);
 var strViewpointId = objRTViewpointRelaEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objRTViewpointRelaEN.ProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ProposePeople);
 var strProposePeople = objRTViewpointRelaEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProposePeople + "'");
 }
 
 if (objRTViewpointRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.UpdDate);
 var strUpdDate = objRTViewpointRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objRTViewpointRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.UpdUser);
 var strUpdUser = objRTViewpointRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objRTViewpointRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.Memo);
 var strMemo = objRTViewpointRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objRTViewpointRelaEN.ClassificationId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ClassificationId);
 arrValueListForInsert.Add(objRTViewpointRelaEN.ClassificationId.ToString());
 }
 
 if (objRTViewpointRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.IdCurrEduCls);
 var strIdCurrEduCls = objRTViewpointRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RTViewpointRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objRTViewpointRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsRTViewpointRelaEN objRTViewpointRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objRTViewpointRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTViewpointRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRTViewpointRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objRTViewpointRelaEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.TopicId);
 var strTopicId = objRTViewpointRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objRTViewpointRelaEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ViewpointId);
 var strViewpointId = objRTViewpointRelaEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objRTViewpointRelaEN.ProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ProposePeople);
 var strProposePeople = objRTViewpointRelaEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProposePeople + "'");
 }
 
 if (objRTViewpointRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.UpdDate);
 var strUpdDate = objRTViewpointRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objRTViewpointRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.UpdUser);
 var strUpdUser = objRTViewpointRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objRTViewpointRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.Memo);
 var strMemo = objRTViewpointRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objRTViewpointRelaEN.ClassificationId !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.ClassificationId);
 arrValueListForInsert.Add(objRTViewpointRelaEN.ClassificationId.ToString());
 }
 
 if (objRTViewpointRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conRTViewpointRela.IdCurrEduCls);
 var strIdCurrEduCls = objRTViewpointRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RTViewpointRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewRTViewpointRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTViewpointRela where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "RTViewpointRela");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsRTViewpointRelaEN._CurrTabName ].NewRow();
objRow[conRTViewpointRela.TopicId] = oRow[conRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objRow[conRTViewpointRela.ViewpointId] = oRow[conRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objRow[conRTViewpointRela.ProposePeople] = oRow[conRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objRow[conRTViewpointRela.UpdDate] = oRow[conRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objRow[conRTViewpointRela.UpdUser] = oRow[conRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objRow[conRTViewpointRela.Memo] = oRow[conRTViewpointRela.Memo].ToString().Trim(); //备注
objRow[conRTViewpointRela.ClassificationId] = oRow[conRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
objRow[conRTViewpointRela.IdCurrEduCls] = oRow[conRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
 objDS.Tables[clsRTViewpointRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsRTViewpointRelaEN._CurrTabName);
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
 /// <param name = "objRTViewpointRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsRTViewpointRelaEN objRTViewpointRelaEN)
{
 objRTViewpointRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTViewpointRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRTViewpointRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from RTViewpointRela where mId = " + ""+ objRTViewpointRelaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsRTViewpointRelaEN._CurrTabName);
if (objDS.Tables[clsRTViewpointRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objRTViewpointRelaEN.mId+"");
return false;
}
objRow = objDS.Tables[clsRTViewpointRelaEN._CurrTabName].Rows[0];
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.TopicId))
 {
objRow[conRTViewpointRela.TopicId] = objRTViewpointRelaEN.TopicId; //主题Id
 }
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ViewpointId))
 {
objRow[conRTViewpointRela.ViewpointId] = objRTViewpointRelaEN.ViewpointId; //观点Id
 }
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ProposePeople))
 {
objRow[conRTViewpointRela.ProposePeople] = objRTViewpointRelaEN.ProposePeople; //提出人
 }
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.UpdDate))
 {
objRow[conRTViewpointRela.UpdDate] = objRTViewpointRelaEN.UpdDate; //修改日期
 }
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.UpdUser))
 {
objRow[conRTViewpointRela.UpdUser] = objRTViewpointRelaEN.UpdUser; //修改人
 }
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.Memo))
 {
objRow[conRTViewpointRela.Memo] = objRTViewpointRelaEN.Memo; //备注
 }
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ClassificationId))
 {
objRow[conRTViewpointRela.ClassificationId] = objRTViewpointRelaEN.ClassificationId; //分类Id
 }
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.IdCurrEduCls))
 {
objRow[conRTViewpointRela.IdCurrEduCls] = objRTViewpointRelaEN.IdCurrEduCls; //教学班流水号
 }
try
{
objDA.Update(objDS, clsRTViewpointRelaEN._CurrTabName);
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
 /// <param name = "objRTViewpointRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsRTViewpointRelaEN objRTViewpointRelaEN)
{
 objRTViewpointRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTViewpointRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRTViewpointRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update RTViewpointRela Set ");
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.TopicId))
 {
 if (objRTViewpointRelaEN.TopicId !=  null)
 {
 var strTopicId = objRTViewpointRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, conRTViewpointRela.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.TopicId); //主题Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ViewpointId))
 {
 if (objRTViewpointRelaEN.ViewpointId !=  null)
 {
 var strViewpointId = objRTViewpointRelaEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointId, conRTViewpointRela.ViewpointId); //观点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.ViewpointId); //观点Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ProposePeople))
 {
 if (objRTViewpointRelaEN.ProposePeople !=  null)
 {
 var strProposePeople = objRTViewpointRelaEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProposePeople, conRTViewpointRela.ProposePeople); //提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.ProposePeople); //提出人
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.UpdDate))
 {
 if (objRTViewpointRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objRTViewpointRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conRTViewpointRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.UpdDate); //修改日期
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.UpdUser))
 {
 if (objRTViewpointRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objRTViewpointRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conRTViewpointRela.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.UpdUser); //修改人
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.Memo))
 {
 if (objRTViewpointRelaEN.Memo !=  null)
 {
 var strMemo = objRTViewpointRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conRTViewpointRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.Memo); //备注
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ClassificationId))
 {
 if (objRTViewpointRelaEN.ClassificationId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTViewpointRelaEN.ClassificationId, conRTViewpointRela.ClassificationId); //分类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.ClassificationId); //分类Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.IdCurrEduCls))
 {
 if (objRTViewpointRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objRTViewpointRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conRTViewpointRela.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objRTViewpointRelaEN.mId); 
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
 /// <param name = "objRTViewpointRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsRTViewpointRelaEN objRTViewpointRelaEN, string strCondition)
{
 objRTViewpointRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTViewpointRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRTViewpointRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RTViewpointRela Set ");
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.TopicId))
 {
 if (objRTViewpointRelaEN.TopicId !=  null)
 {
 var strTopicId = objRTViewpointRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ViewpointId))
 {
 if (objRTViewpointRelaEN.ViewpointId !=  null)
 {
 var strViewpointId = objRTViewpointRelaEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointId = '{0}',", strViewpointId); //观点Id
 }
 else
 {
 sbSQL.Append(" ViewpointId = null,"); //观点Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ProposePeople))
 {
 if (objRTViewpointRelaEN.ProposePeople !=  null)
 {
 var strProposePeople = objRTViewpointRelaEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProposePeople = '{0}',", strProposePeople); //提出人
 }
 else
 {
 sbSQL.Append(" ProposePeople = null,"); //提出人
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.UpdDate))
 {
 if (objRTViewpointRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objRTViewpointRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.UpdUser))
 {
 if (objRTViewpointRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objRTViewpointRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.Memo))
 {
 if (objRTViewpointRelaEN.Memo !=  null)
 {
 var strMemo = objRTViewpointRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ClassificationId))
 {
 if (objRTViewpointRelaEN.ClassificationId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTViewpointRelaEN.ClassificationId, conRTViewpointRela.ClassificationId); //分类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.ClassificationId); //分类Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.IdCurrEduCls))
 {
 if (objRTViewpointRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objRTViewpointRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objRTViewpointRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsRTViewpointRelaEN objRTViewpointRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objRTViewpointRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTViewpointRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRTViewpointRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RTViewpointRela Set ");
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.TopicId))
 {
 if (objRTViewpointRelaEN.TopicId !=  null)
 {
 var strTopicId = objRTViewpointRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ViewpointId))
 {
 if (objRTViewpointRelaEN.ViewpointId !=  null)
 {
 var strViewpointId = objRTViewpointRelaEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointId = '{0}',", strViewpointId); //观点Id
 }
 else
 {
 sbSQL.Append(" ViewpointId = null,"); //观点Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ProposePeople))
 {
 if (objRTViewpointRelaEN.ProposePeople !=  null)
 {
 var strProposePeople = objRTViewpointRelaEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProposePeople = '{0}',", strProposePeople); //提出人
 }
 else
 {
 sbSQL.Append(" ProposePeople = null,"); //提出人
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.UpdDate))
 {
 if (objRTViewpointRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objRTViewpointRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.UpdUser))
 {
 if (objRTViewpointRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objRTViewpointRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.Memo))
 {
 if (objRTViewpointRelaEN.Memo !=  null)
 {
 var strMemo = objRTViewpointRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ClassificationId))
 {
 if (objRTViewpointRelaEN.ClassificationId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTViewpointRelaEN.ClassificationId, conRTViewpointRela.ClassificationId); //分类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.ClassificationId); //分类Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.IdCurrEduCls))
 {
 if (objRTViewpointRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objRTViewpointRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objRTViewpointRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsRTViewpointRelaEN objRTViewpointRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objRTViewpointRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objRTViewpointRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRTViewpointRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RTViewpointRela Set ");
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.TopicId))
 {
 if (objRTViewpointRelaEN.TopicId !=  null)
 {
 var strTopicId = objRTViewpointRelaEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, conRTViewpointRela.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.TopicId); //主题Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ViewpointId))
 {
 if (objRTViewpointRelaEN.ViewpointId !=  null)
 {
 var strViewpointId = objRTViewpointRelaEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointId, conRTViewpointRela.ViewpointId); //观点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.ViewpointId); //观点Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ProposePeople))
 {
 if (objRTViewpointRelaEN.ProposePeople !=  null)
 {
 var strProposePeople = objRTViewpointRelaEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProposePeople, conRTViewpointRela.ProposePeople); //提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.ProposePeople); //提出人
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.UpdDate))
 {
 if (objRTViewpointRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objRTViewpointRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conRTViewpointRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.UpdDate); //修改日期
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.UpdUser))
 {
 if (objRTViewpointRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objRTViewpointRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conRTViewpointRela.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.UpdUser); //修改人
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.Memo))
 {
 if (objRTViewpointRelaEN.Memo !=  null)
 {
 var strMemo = objRTViewpointRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conRTViewpointRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.Memo); //备注
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.ClassificationId))
 {
 if (objRTViewpointRelaEN.ClassificationId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objRTViewpointRelaEN.ClassificationId, conRTViewpointRela.ClassificationId); //分类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.ClassificationId); //分类Id
 }
 }
 
 if (objRTViewpointRelaEN.IsUpdated(conRTViewpointRela.IdCurrEduCls))
 {
 if (objRTViewpointRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objRTViewpointRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conRTViewpointRela.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRTViewpointRela.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objRTViewpointRelaEN.mId); 
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("RTViewpointRela_Delete", values);
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
//删除RTViewpointRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RTViewpointRela where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelRTViewpointRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
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
//删除RTViewpointRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RTViewpointRela where mId in (" + strKeyList + ")";
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
//删除RTViewpointRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RTViewpointRela where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelRTViewpointRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA: DelRTViewpointRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from RTViewpointRela where " + strCondition ;
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
public bool DelRTViewpointRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsRTViewpointRelaDA: DelRTViewpointRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from RTViewpointRela where " + strCondition ;
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
 /// <param name = "objRTViewpointRelaENS">源对象</param>
 /// <param name = "objRTViewpointRelaENT">目标对象</param>
public void CopyTo(clsRTViewpointRelaEN objRTViewpointRelaENS, clsRTViewpointRelaEN objRTViewpointRelaENT)
{
objRTViewpointRelaENT.mId = objRTViewpointRelaENS.mId; //mId
objRTViewpointRelaENT.TopicId = objRTViewpointRelaENS.TopicId; //主题Id
objRTViewpointRelaENT.ViewpointId = objRTViewpointRelaENS.ViewpointId; //观点Id
objRTViewpointRelaENT.ProposePeople = objRTViewpointRelaENS.ProposePeople; //提出人
objRTViewpointRelaENT.UpdDate = objRTViewpointRelaENS.UpdDate; //修改日期
objRTViewpointRelaENT.UpdUser = objRTViewpointRelaENS.UpdUser; //修改人
objRTViewpointRelaENT.Memo = objRTViewpointRelaENS.Memo; //备注
objRTViewpointRelaENT.ClassificationId = objRTViewpointRelaENS.ClassificationId; //分类Id
objRTViewpointRelaENT.IdCurrEduCls = objRTViewpointRelaENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsRTViewpointRelaEN objRTViewpointRelaEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.TopicId, 8, conRTViewpointRela.TopicId);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.ViewpointId, 8, conRTViewpointRela.ViewpointId);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.ProposePeople, 50, conRTViewpointRela.ProposePeople);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.UpdDate, 20, conRTViewpointRela.UpdDate);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.UpdUser, 20, conRTViewpointRela.UpdUser);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.Memo, 1000, conRTViewpointRela.Memo);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.IdCurrEduCls, 8, conRTViewpointRela.IdCurrEduCls);
//检查字段外键固定长度
 objRTViewpointRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsRTViewpointRelaEN objRTViewpointRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.TopicId, 8, conRTViewpointRela.TopicId);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.ViewpointId, 8, conRTViewpointRela.ViewpointId);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.ProposePeople, 50, conRTViewpointRela.ProposePeople);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.UpdDate, 20, conRTViewpointRela.UpdDate);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.UpdUser, 20, conRTViewpointRela.UpdUser);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.Memo, 1000, conRTViewpointRela.Memo);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.IdCurrEduCls, 8, conRTViewpointRela.IdCurrEduCls);
//检查外键字段长度
 objRTViewpointRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsRTViewpointRelaEN objRTViewpointRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.TopicId, 8, conRTViewpointRela.TopicId);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.ViewpointId, 8, conRTViewpointRela.ViewpointId);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.ProposePeople, 50, conRTViewpointRela.ProposePeople);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.UpdDate, 20, conRTViewpointRela.UpdDate);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.UpdUser, 20, conRTViewpointRela.UpdUser);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.Memo, 1000, conRTViewpointRela.Memo);
clsCheckSql.CheckFieldLen(objRTViewpointRelaEN.IdCurrEduCls, 8, conRTViewpointRela.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objRTViewpointRelaEN.TopicId, conRTViewpointRela.TopicId);
clsCheckSql.CheckSqlInjection4Field(objRTViewpointRelaEN.ViewpointId, conRTViewpointRela.ViewpointId);
clsCheckSql.CheckSqlInjection4Field(objRTViewpointRelaEN.ProposePeople, conRTViewpointRela.ProposePeople);
clsCheckSql.CheckSqlInjection4Field(objRTViewpointRelaEN.UpdDate, conRTViewpointRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objRTViewpointRelaEN.UpdUser, conRTViewpointRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objRTViewpointRelaEN.Memo, conRTViewpointRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objRTViewpointRelaEN.IdCurrEduCls, conRTViewpointRela.IdCurrEduCls);
//检查外键字段长度
 objRTViewpointRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--RTViewpointRela(主题观点关系表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objRTViewpointRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsRTViewpointRelaEN objRTViewpointRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objRTViewpointRelaEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null");
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objRTViewpointRelaEN.TopicId);
}
 if (objRTViewpointRelaEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null");
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objRTViewpointRelaEN.ViewpointId);
}
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsRTViewpointRelaEN._CurrTabName);
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsRTViewpointRelaEN._CurrTabName, strCondition);
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
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
 objSQL = clsRTViewpointRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}