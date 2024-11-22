
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_PaperStatusDA
 表名:zx_PaperStatus(01120818)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 中学论文状态表(zx_PaperStatus)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_PaperStatusDA : clsCommBase4DA
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
 return clszx_PaperStatusEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_PaperStatusEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_PaperStatusEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_PaperStatusEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_PaperStatusEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxPaperStatusId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxPaperStatusId)
{
strzxPaperStatusId = strzxPaperStatusId.Replace("'", "''");
if (strzxPaperStatusId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:zx_PaperStatus中,检查关键字,长度不正确!(clszx_PaperStatusDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxPaperStatusId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_PaperStatus中,关键字不能为空 或 null!(clszx_PaperStatusDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxPaperStatusId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_PaperStatusDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_PaperStatusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperStatus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_PaperStatus(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_PaperStatusDA: GetDataTable_zx_PaperStatus)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperStatus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_PaperStatusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_PaperStatusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperStatus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_PaperStatusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_PaperStatusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperStatus where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperStatus where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_PaperStatusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_PaperStatus where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_PaperStatusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_PaperStatus.* from zx_PaperStatus Left Join {1} on {2} where {3} and zx_PaperStatus.zxPaperStatusId not in (Select top {5} zx_PaperStatus.zxPaperStatusId from zx_PaperStatus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperStatus where {1} and zxPaperStatusId not in (Select top {2} zxPaperStatusId from zx_PaperStatus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperStatus where {1} and zxPaperStatusId not in (Select top {3} zxPaperStatusId from zx_PaperStatus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_PaperStatusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_PaperStatus.* from zx_PaperStatus Left Join {1} on {2} where {3} and zx_PaperStatus.zxPaperStatusId not in (Select top {5} zx_PaperStatus.zxPaperStatusId from zx_PaperStatus Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperStatus where {1} and zxPaperStatusId not in (Select top {2} zxPaperStatusId from zx_PaperStatus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_PaperStatus where {1} and zxPaperStatusId not in (Select top {3} zxPaperStatusId from zx_PaperStatus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_PaperStatusEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_PaperStatusDA:GetObjLst)", objException.Message));
}
List<clszx_PaperStatusEN> arrObjLst = new List<clszx_PaperStatusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperStatus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperStatusEN objzx_PaperStatusEN = new clszx_PaperStatusEN();
try
{
objzx_PaperStatusEN.zxPaperStatusId = objRow[conzx_PaperStatus.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_PaperStatusEN.PaperStatusName = objRow[conzx_PaperStatus.PaperStatusName] == DBNull.Value ? null : objRow[conzx_PaperStatus.PaperStatusName].ToString().Trim(); //论文状态名
objzx_PaperStatusEN.UpdUser = objRow[conzx_PaperStatus.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdUser].ToString().Trim(); //修改人
objzx_PaperStatusEN.UpdDate = objRow[conzx_PaperStatus.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdDate].ToString().Trim(); //修改日期
objzx_PaperStatusEN.Memo = objRow[conzx_PaperStatus.Memo] == DBNull.Value ? null : objRow[conzx_PaperStatus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_PaperStatusDA: GetObjLst)", objException.Message));
}
objzx_PaperStatusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_PaperStatusEN);
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
public List<clszx_PaperStatusEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_PaperStatusDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_PaperStatusEN> arrObjLst = new List<clszx_PaperStatusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_PaperStatusEN objzx_PaperStatusEN = new clszx_PaperStatusEN();
try
{
objzx_PaperStatusEN.zxPaperStatusId = objRow[conzx_PaperStatus.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_PaperStatusEN.PaperStatusName = objRow[conzx_PaperStatus.PaperStatusName] == DBNull.Value ? null : objRow[conzx_PaperStatus.PaperStatusName].ToString().Trim(); //论文状态名
objzx_PaperStatusEN.UpdUser = objRow[conzx_PaperStatus.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdUser].ToString().Trim(); //修改人
objzx_PaperStatusEN.UpdDate = objRow[conzx_PaperStatus.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdDate].ToString().Trim(); //修改日期
objzx_PaperStatusEN.Memo = objRow[conzx_PaperStatus.Memo] == DBNull.Value ? null : objRow[conzx_PaperStatus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_PaperStatusDA: GetObjLst)", objException.Message));
}
objzx_PaperStatusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_PaperStatusEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_PaperStatusEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_PaperStatus(ref clszx_PaperStatusEN objzx_PaperStatusEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperStatus where zxPaperStatusId = " + "'"+ objzx_PaperStatusEN.zxPaperStatusId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_PaperStatusEN.zxPaperStatusId = objDT.Rows[0][conzx_PaperStatus.zxPaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_PaperStatusEN.PaperStatusName = objDT.Rows[0][conzx_PaperStatus.PaperStatusName].ToString().Trim(); //论文状态名(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_PaperStatusEN.UpdUser = objDT.Rows[0][conzx_PaperStatus.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_PaperStatusEN.UpdDate = objDT.Rows[0][conzx_PaperStatus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_PaperStatusEN.Memo = objDT.Rows[0][conzx_PaperStatus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_PaperStatusDA: Getzx_PaperStatus)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxPaperStatusId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_PaperStatusEN GetObjByzxPaperStatusId(string strzxPaperStatusId)
{
CheckPrimaryKey(strzxPaperStatusId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperStatus where zxPaperStatusId = " + "'"+ strzxPaperStatusId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_PaperStatusEN objzx_PaperStatusEN = new clszx_PaperStatusEN();
try
{
 objzx_PaperStatusEN.zxPaperStatusId = objRow[conzx_PaperStatus.zxPaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_PaperStatusEN.PaperStatusName = objRow[conzx_PaperStatus.PaperStatusName] == DBNull.Value ? null : objRow[conzx_PaperStatus.PaperStatusName].ToString().Trim(); //论文状态名(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_PaperStatusEN.UpdUser = objRow[conzx_PaperStatus.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_PaperStatusEN.UpdDate = objRow[conzx_PaperStatus.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_PaperStatusEN.Memo = objRow[conzx_PaperStatus.Memo] == DBNull.Value ? null : objRow[conzx_PaperStatus.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_PaperStatusDA: GetObjByzxPaperStatusId)", objException.Message));
}
return objzx_PaperStatusEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_PaperStatusEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_PaperStatusDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperStatus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_PaperStatusEN objzx_PaperStatusEN = new clszx_PaperStatusEN()
{
zxPaperStatusId = objRow[conzx_PaperStatus.zxPaperStatusId].ToString().Trim(), //论文状态Id
PaperStatusName = objRow[conzx_PaperStatus.PaperStatusName] == DBNull.Value ? null : objRow[conzx_PaperStatus.PaperStatusName].ToString().Trim(), //论文状态名
UpdUser = objRow[conzx_PaperStatus.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conzx_PaperStatus.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conzx_PaperStatus.Memo] == DBNull.Value ? null : objRow[conzx_PaperStatus.Memo].ToString().Trim() //备注
};
objzx_PaperStatusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_PaperStatusEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_PaperStatusDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_PaperStatusEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_PaperStatusEN objzx_PaperStatusEN = new clszx_PaperStatusEN();
try
{
objzx_PaperStatusEN.zxPaperStatusId = objRow[conzx_PaperStatus.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_PaperStatusEN.PaperStatusName = objRow[conzx_PaperStatus.PaperStatusName] == DBNull.Value ? null : objRow[conzx_PaperStatus.PaperStatusName].ToString().Trim(); //论文状态名
objzx_PaperStatusEN.UpdUser = objRow[conzx_PaperStatus.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdUser].ToString().Trim(); //修改人
objzx_PaperStatusEN.UpdDate = objRow[conzx_PaperStatus.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdDate].ToString().Trim(); //修改日期
objzx_PaperStatusEN.Memo = objRow[conzx_PaperStatus.Memo] == DBNull.Value ? null : objRow[conzx_PaperStatus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_PaperStatusDA: GetObjByDataRowzx_PaperStatus)", objException.Message));
}
objzx_PaperStatusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_PaperStatusEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_PaperStatusEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_PaperStatusEN objzx_PaperStatusEN = new clszx_PaperStatusEN();
try
{
objzx_PaperStatusEN.zxPaperStatusId = objRow[conzx_PaperStatus.zxPaperStatusId].ToString().Trim(); //论文状态Id
objzx_PaperStatusEN.PaperStatusName = objRow[conzx_PaperStatus.PaperStatusName] == DBNull.Value ? null : objRow[conzx_PaperStatus.PaperStatusName].ToString().Trim(); //论文状态名
objzx_PaperStatusEN.UpdUser = objRow[conzx_PaperStatus.UpdUser] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdUser].ToString().Trim(); //修改人
objzx_PaperStatusEN.UpdDate = objRow[conzx_PaperStatus.UpdDate] == DBNull.Value ? null : objRow[conzx_PaperStatus.UpdDate].ToString().Trim(); //修改日期
objzx_PaperStatusEN.Memo = objRow[conzx_PaperStatus.Memo] == DBNull.Value ? null : objRow[conzx_PaperStatus.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_PaperStatusDA: GetObjByDataRow)", objException.Message));
}
objzx_PaperStatusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_PaperStatusEN;
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
objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_PaperStatusEN._CurrTabName, conzx_PaperStatus.zxPaperStatusId, 2, "");
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
objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_PaperStatusEN._CurrTabName, conzx_PaperStatus.zxPaperStatusId, 2, strPrefix);
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
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxPaperStatusId from zx_PaperStatus where " + strCondition;
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
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxPaperStatusId from zx_PaperStatus where " + strCondition;
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
 /// <param name = "strzxPaperStatusId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxPaperStatusId)
{
CheckPrimaryKey(strzxPaperStatusId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_PaperStatus", "zxPaperStatusId = " + "'"+ strzxPaperStatusId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_PaperStatusDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_PaperStatus", strCondition))
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
objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_PaperStatus");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_PaperStatusEN objzx_PaperStatusEN)
 {
 if (objzx_PaperStatusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_PaperStatusEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperStatus where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_PaperStatus");
objRow = objDS.Tables["zx_PaperStatus"].NewRow();
objRow[conzx_PaperStatus.zxPaperStatusId] = objzx_PaperStatusEN.zxPaperStatusId; //论文状态Id
 if (objzx_PaperStatusEN.PaperStatusName !=  "")
 {
objRow[conzx_PaperStatus.PaperStatusName] = objzx_PaperStatusEN.PaperStatusName; //论文状态名
 }
 if (objzx_PaperStatusEN.UpdUser !=  "")
 {
objRow[conzx_PaperStatus.UpdUser] = objzx_PaperStatusEN.UpdUser; //修改人
 }
 if (objzx_PaperStatusEN.UpdDate !=  "")
 {
objRow[conzx_PaperStatus.UpdDate] = objzx_PaperStatusEN.UpdDate; //修改日期
 }
 if (objzx_PaperStatusEN.Memo !=  "")
 {
objRow[conzx_PaperStatus.Memo] = objzx_PaperStatusEN.Memo; //备注
 }
objDS.Tables[clszx_PaperStatusEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_PaperStatusEN._CurrTabName);
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
 /// <param name = "objzx_PaperStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_PaperStatusEN objzx_PaperStatusEN)
{
 if (objzx_PaperStatusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_PaperStatusEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_PaperStatusEN.zxPaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.zxPaperStatusId);
 var strzxPaperStatusId = objzx_PaperStatusEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperStatusId + "'");
 }
 
 if (objzx_PaperStatusEN.PaperStatusName !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.PaperStatusName);
 var strPaperStatusName = objzx_PaperStatusEN.PaperStatusName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusName + "'");
 }
 
 if (objzx_PaperStatusEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.UpdUser);
 var strUpdUser = objzx_PaperStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_PaperStatusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.UpdDate);
 var strUpdDate = objzx_PaperStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_PaperStatusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.Memo);
 var strMemo = objzx_PaperStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_PaperStatus");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_PaperStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_PaperStatusEN objzx_PaperStatusEN)
{
 if (objzx_PaperStatusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_PaperStatusEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_PaperStatusEN.zxPaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.zxPaperStatusId);
 var strzxPaperStatusId = objzx_PaperStatusEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperStatusId + "'");
 }
 
 if (objzx_PaperStatusEN.PaperStatusName !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.PaperStatusName);
 var strPaperStatusName = objzx_PaperStatusEN.PaperStatusName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusName + "'");
 }
 
 if (objzx_PaperStatusEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.UpdUser);
 var strUpdUser = objzx_PaperStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_PaperStatusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.UpdDate);
 var strUpdDate = objzx_PaperStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_PaperStatusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.Memo);
 var strMemo = objzx_PaperStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_PaperStatus");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_PaperStatusEN.zxPaperStatusId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_PaperStatusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_PaperStatusEN objzx_PaperStatusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_PaperStatusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_PaperStatusEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_PaperStatusEN.zxPaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.zxPaperStatusId);
 var strzxPaperStatusId = objzx_PaperStatusEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperStatusId + "'");
 }
 
 if (objzx_PaperStatusEN.PaperStatusName !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.PaperStatusName);
 var strPaperStatusName = objzx_PaperStatusEN.PaperStatusName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusName + "'");
 }
 
 if (objzx_PaperStatusEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.UpdUser);
 var strUpdUser = objzx_PaperStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_PaperStatusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.UpdDate);
 var strUpdDate = objzx_PaperStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_PaperStatusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.Memo);
 var strMemo = objzx_PaperStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_PaperStatus");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_PaperStatusEN.zxPaperStatusId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_PaperStatusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_PaperStatusEN objzx_PaperStatusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_PaperStatusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_PaperStatusEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_PaperStatusEN.zxPaperStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.zxPaperStatusId);
 var strzxPaperStatusId = objzx_PaperStatusEN.zxPaperStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPaperStatusId + "'");
 }
 
 if (objzx_PaperStatusEN.PaperStatusName !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.PaperStatusName);
 var strPaperStatusName = objzx_PaperStatusEN.PaperStatusName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperStatusName + "'");
 }
 
 if (objzx_PaperStatusEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.UpdUser);
 var strUpdUser = objzx_PaperStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_PaperStatusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.UpdDate);
 var strUpdDate = objzx_PaperStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_PaperStatusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_PaperStatus.Memo);
 var strMemo = objzx_PaperStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_PaperStatus");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_PaperStatuss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperStatus where zxPaperStatusId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_PaperStatus");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxPaperStatusId = oRow[conzx_PaperStatus.zxPaperStatusId].ToString().Trim();
if (IsExist(strzxPaperStatusId))
{
 string strResult = "关键字变量值为:" + string.Format("zxPaperStatusId = {0}", strzxPaperStatusId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_PaperStatusEN._CurrTabName ].NewRow();
objRow[conzx_PaperStatus.zxPaperStatusId] = oRow[conzx_PaperStatus.zxPaperStatusId].ToString().Trim(); //论文状态Id
objRow[conzx_PaperStatus.PaperStatusName] = oRow[conzx_PaperStatus.PaperStatusName].ToString().Trim(); //论文状态名
objRow[conzx_PaperStatus.UpdUser] = oRow[conzx_PaperStatus.UpdUser].ToString().Trim(); //修改人
objRow[conzx_PaperStatus.UpdDate] = oRow[conzx_PaperStatus.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_PaperStatus.Memo] = oRow[conzx_PaperStatus.Memo].ToString().Trim(); //备注
 objDS.Tables[clszx_PaperStatusEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_PaperStatusEN._CurrTabName);
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
 /// <param name = "objzx_PaperStatusEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_PaperStatusEN objzx_PaperStatusEN)
{
 if (objzx_PaperStatusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_PaperStatusEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
strSQL = "Select * from zx_PaperStatus where zxPaperStatusId = " + "'"+ objzx_PaperStatusEN.zxPaperStatusId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_PaperStatusEN._CurrTabName);
if (objDS.Tables[clszx_PaperStatusEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxPaperStatusId = " + "'"+ objzx_PaperStatusEN.zxPaperStatusId+"'");
return false;
}
objRow = objDS.Tables[clszx_PaperStatusEN._CurrTabName].Rows[0];
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.zxPaperStatusId))
 {
objRow[conzx_PaperStatus.zxPaperStatusId] = objzx_PaperStatusEN.zxPaperStatusId; //论文状态Id
 }
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.PaperStatusName))
 {
objRow[conzx_PaperStatus.PaperStatusName] = objzx_PaperStatusEN.PaperStatusName; //论文状态名
 }
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.UpdUser))
 {
objRow[conzx_PaperStatus.UpdUser] = objzx_PaperStatusEN.UpdUser; //修改人
 }
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.UpdDate))
 {
objRow[conzx_PaperStatus.UpdDate] = objzx_PaperStatusEN.UpdDate; //修改日期
 }
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.Memo))
 {
objRow[conzx_PaperStatus.Memo] = objzx_PaperStatusEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clszx_PaperStatusEN._CurrTabName);
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
 /// <param name = "objzx_PaperStatusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_PaperStatusEN objzx_PaperStatusEN)
{
 if (objzx_PaperStatusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_PaperStatusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_PaperStatus Set ");
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.PaperStatusName))
 {
 if (objzx_PaperStatusEN.PaperStatusName !=  null)
 {
 var strPaperStatusName = objzx_PaperStatusEN.PaperStatusName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperStatusName, conzx_PaperStatus.PaperStatusName); //论文状态名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperStatus.PaperStatusName); //论文状态名
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.UpdUser))
 {
 if (objzx_PaperStatusEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_PaperStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_PaperStatus.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperStatus.UpdUser); //修改人
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.UpdDate))
 {
 if (objzx_PaperStatusEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_PaperStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_PaperStatus.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperStatus.UpdDate); //修改日期
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.Memo))
 {
 if (objzx_PaperStatusEN.Memo !=  null)
 {
 var strMemo = objzx_PaperStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_PaperStatus.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperStatus.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxPaperStatusId = '{0}'", objzx_PaperStatusEN.zxPaperStatusId); 
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
 /// <param name = "objzx_PaperStatusEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_PaperStatusEN objzx_PaperStatusEN, string strCondition)
{
 if (objzx_PaperStatusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_PaperStatusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_PaperStatus Set ");
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.PaperStatusName))
 {
 if (objzx_PaperStatusEN.PaperStatusName !=  null)
 {
 var strPaperStatusName = objzx_PaperStatusEN.PaperStatusName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperStatusName = '{0}',", strPaperStatusName); //论文状态名
 }
 else
 {
 sbSQL.Append(" PaperStatusName = null,"); //论文状态名
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.UpdUser))
 {
 if (objzx_PaperStatusEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_PaperStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.UpdDate))
 {
 if (objzx_PaperStatusEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_PaperStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.Memo))
 {
 if (objzx_PaperStatusEN.Memo !=  null)
 {
 var strMemo = objzx_PaperStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_PaperStatusEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_PaperStatusEN objzx_PaperStatusEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_PaperStatusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_PaperStatusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_PaperStatus Set ");
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.PaperStatusName))
 {
 if (objzx_PaperStatusEN.PaperStatusName !=  null)
 {
 var strPaperStatusName = objzx_PaperStatusEN.PaperStatusName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperStatusName = '{0}',", strPaperStatusName); //论文状态名
 }
 else
 {
 sbSQL.Append(" PaperStatusName = null,"); //论文状态名
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.UpdUser))
 {
 if (objzx_PaperStatusEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_PaperStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.UpdDate))
 {
 if (objzx_PaperStatusEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_PaperStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.Memo))
 {
 if (objzx_PaperStatusEN.Memo !=  null)
 {
 var strMemo = objzx_PaperStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_PaperStatusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_PaperStatusEN objzx_PaperStatusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_PaperStatusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_PaperStatusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_PaperStatus Set ");
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.PaperStatusName))
 {
 if (objzx_PaperStatusEN.PaperStatusName !=  null)
 {
 var strPaperStatusName = objzx_PaperStatusEN.PaperStatusName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperStatusName, conzx_PaperStatus.PaperStatusName); //论文状态名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperStatus.PaperStatusName); //论文状态名
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.UpdUser))
 {
 if (objzx_PaperStatusEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_PaperStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_PaperStatus.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperStatus.UpdUser); //修改人
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.UpdDate))
 {
 if (objzx_PaperStatusEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_PaperStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_PaperStatus.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperStatus.UpdDate); //修改日期
 }
 }
 
 if (objzx_PaperStatusEN.IsUpdated(conzx_PaperStatus.Memo))
 {
 if (objzx_PaperStatusEN.Memo !=  null)
 {
 var strMemo = objzx_PaperStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_PaperStatus.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_PaperStatus.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxPaperStatusId = '{0}'", objzx_PaperStatusEN.zxPaperStatusId); 
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
 /// <param name = "strzxPaperStatusId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxPaperStatusId) 
{
CheckPrimaryKey(strzxPaperStatusId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxPaperStatusId,
};
 objSQL.ExecSP("zx_PaperStatus_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxPaperStatusId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxPaperStatusId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxPaperStatusId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
//删除zx_PaperStatus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_PaperStatus where zxPaperStatusId = " + "'"+ strzxPaperStatusId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_PaperStatus(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
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
//删除zx_PaperStatus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_PaperStatus where zxPaperStatusId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxPaperStatusId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxPaperStatusId) 
{
CheckPrimaryKey(strzxPaperStatusId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
//删除zx_PaperStatus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_PaperStatus where zxPaperStatusId = " + "'"+ strzxPaperStatusId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_PaperStatus(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_PaperStatusDA: Delzx_PaperStatus)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_PaperStatus where " + strCondition ;
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
public bool Delzx_PaperStatusWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_PaperStatusDA: Delzx_PaperStatusWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_PaperStatus where " + strCondition ;
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
 /// <param name = "objzx_PaperStatusENS">源对象</param>
 /// <param name = "objzx_PaperStatusENT">目标对象</param>
public void CopyTo(clszx_PaperStatusEN objzx_PaperStatusENS, clszx_PaperStatusEN objzx_PaperStatusENT)
{
objzx_PaperStatusENT.zxPaperStatusId = objzx_PaperStatusENS.zxPaperStatusId; //论文状态Id
objzx_PaperStatusENT.PaperStatusName = objzx_PaperStatusENS.PaperStatusName; //论文状态名
objzx_PaperStatusENT.UpdUser = objzx_PaperStatusENS.UpdUser; //修改人
objzx_PaperStatusENT.UpdDate = objzx_PaperStatusENS.UpdDate; //修改日期
objzx_PaperStatusENT.Memo = objzx_PaperStatusENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_PaperStatusEN objzx_PaperStatusEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.zxPaperStatusId, 2, conzx_PaperStatus.zxPaperStatusId);
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.PaperStatusName, 50, conzx_PaperStatus.PaperStatusName);
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.UpdUser, 20, conzx_PaperStatus.UpdUser);
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.UpdDate, 20, conzx_PaperStatus.UpdDate);
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.Memo, 1000, conzx_PaperStatus.Memo);
//检查字段外键固定长度
 objzx_PaperStatusEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_PaperStatusEN objzx_PaperStatusEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.PaperStatusName, 50, conzx_PaperStatus.PaperStatusName);
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.UpdUser, 20, conzx_PaperStatus.UpdUser);
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.UpdDate, 20, conzx_PaperStatus.UpdDate);
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.Memo, 1000, conzx_PaperStatus.Memo);
//检查外键字段长度
 objzx_PaperStatusEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_PaperStatusEN objzx_PaperStatusEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.zxPaperStatusId, 2, conzx_PaperStatus.zxPaperStatusId);
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.PaperStatusName, 50, conzx_PaperStatus.PaperStatusName);
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.UpdUser, 20, conzx_PaperStatus.UpdUser);
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.UpdDate, 20, conzx_PaperStatus.UpdDate);
clsCheckSql.CheckFieldLen(objzx_PaperStatusEN.Memo, 1000, conzx_PaperStatus.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_PaperStatusEN.zxPaperStatusId, conzx_PaperStatus.zxPaperStatusId);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperStatusEN.PaperStatusName, conzx_PaperStatus.PaperStatusName);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperStatusEN.UpdUser, conzx_PaperStatus.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperStatusEN.UpdDate, conzx_PaperStatus.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_PaperStatusEN.Memo, conzx_PaperStatus.Memo);
//检查外键字段长度
 objzx_PaperStatusEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_PaperStatus(中学论文状态表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_PaperStatusEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_PaperStatusEN objzx_PaperStatusEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objzx_PaperStatusEN.PaperStatusName == null)
{
 sbCondition.AppendFormat(" and PaperStatusName is null");
}
else
{
 sbCondition.AppendFormat(" and PaperStatusName = '{0}'", objzx_PaperStatusEN.PaperStatusName);
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
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
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
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
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
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_PaperStatusEN._CurrTabName);
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
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_PaperStatusEN._CurrTabName, strCondition);
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
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
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
 objSQL = clszx_PaperStatusDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}