
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperCount2DA
 表名:vPaperCount2(01120596)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:16
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
 /// vPaperCount2(vPaperCount2)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPaperCount2DA : clsCommBase4DA
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
 return clsvPaperCount2EN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPaperCount2EN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperCount2EN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPaperCount2EN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPaperCount2EN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPaperId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPaperId)
{
strPaperId = strPaperId.Replace("'", "''");
if (strPaperId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vPaperCount2中,检查关键字,长度不正确!(clsvPaperCount2DA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPaperCount2中,关键字不能为空 或 null!(clsvPaperCount2DA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPaperCount2DA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperCount2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPaperCount2(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPaperCount2DA: GetDataTable_vPaperCount2)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPaperCount2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPaperCount2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount2 where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPaperCount2DA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPaperCount2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount2 where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount2 where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPaperCount2DA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPaperCount2 where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPaperCount2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperCount2.* from vPaperCount2 Left Join {1} on {2} where {3} and vPaperCount2.PaperId not in (Select top {5} vPaperCount2.PaperId from vPaperCount2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount2 where {1} and PaperId not in (Select top {2} PaperId from vPaperCount2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount2 where {1} and PaperId not in (Select top {3} PaperId from vPaperCount2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPaperCount2DA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperCount2.* from vPaperCount2 Left Join {1} on {2} where {3} and vPaperCount2.PaperId not in (Select top {5} vPaperCount2.PaperId from vPaperCount2 Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount2 where {1} and PaperId not in (Select top {2} PaperId from vPaperCount2 where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperCount2 where {1} and PaperId not in (Select top {3} PaperId from vPaperCount2 where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPaperCount2EN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPaperCount2DA:GetObjLst)", objException.Message));
}
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperCount2DA: GetObjLst)", objException.Message));
}
objvPaperCount2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperCount2EN);
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
public List<clsvPaperCount2EN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPaperCount2DA:GetObjLstByTabName)", objException.Message));
}
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperCount2DA: GetObjLst)", objException.Message));
}
objvPaperCount2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperCount2EN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPaperCount2(ref clsvPaperCount2EN objvPaperCount2EN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount2 where PaperId = " + "'"+ objvPaperCount2EN.PaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPaperCount2EN.PaperId = objDT.Rows[0][convPaperCount2.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperCount2EN.Pcount = TransNullToInt(objDT.Rows[0][convPaperCount2.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCount2EN.OkCount = TransNullToInt(objDT.Rows[0][convPaperCount2.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCount2EN.AppraiseCount = TransNullToInt(objDT.Rows[0][convPaperCount2.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCount2EN.CollectionCount = TransNullToInt(objDT.Rows[0][convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperCount2EN.DownloadCount = TransNullToInt(objDT.Rows[0][convPaperCount2.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCount2EN.Score = TransNullToFloat(objDT.Rows[0][convPaperCount2.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperCount2EN.AttachmentCount = TransNullToInt(objDT.Rows[0][convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCount2EN.UpdUser = objDT.Rows[0][convPaperCount2.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPaperCount2DA: GetvPaperCount2)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPaperCount2EN GetObjByPaperId(string strPaperId)
{
CheckPrimaryKey(strPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount2 where PaperId = " + "'"+ strPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
 objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount2.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPaperCount2DA: GetObjByPaperId)", objException.Message));
}
return objvPaperCount2EN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPaperCount2EN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPaperCount2DA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
strSQL = "Select * from vPaperCount2 where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN()
{
PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(), //论文Id
Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.Pcount].ToString().Trim()), //读写数
OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.OkCount].ToString().Trim()), //点赞统计
AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.AppraiseCount].ToString().Trim()), //评论数
CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperCount2.CollectionCount].ToString().Trim()), //收藏数量
DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.DownloadCount].ToString().Trim()), //下载数
Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount2.Score].ToString().Trim()), //评分
AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.AttachmentCount].ToString().Trim()), //附件计数
UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim() //修改人
};
objvPaperCount2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperCount2EN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPaperCount2DA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPaperCount2EN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPaperCount2DA: GetObjByDataRowvPaperCount2)", objException.Message));
}
objvPaperCount2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperCount2EN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPaperCount2EN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPaperCount2DA: GetObjByDataRow)", objException.Message));
}
objvPaperCount2EN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperCount2EN;
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
objSQL = clsvPaperCount2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperCount2EN._CurrTabName, convPaperCount2.PaperId, 8, "");
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
objSQL = clsvPaperCount2DA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperCount2EN._CurrTabName, convPaperCount2.PaperId, 8, strPrefix);
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
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperId from vPaperCount2 where " + strCondition;
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
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperId from vPaperCount2 where " + strCondition;
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
 /// <param name = "strPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPaperId)
{
CheckPrimaryKey(strPaperId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperCount2", "PaperId = " + "'"+ strPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPaperCount2DA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperCount2", strCondition))
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
objSQL = clsvPaperCount2DA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPaperCount2");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPaperCount2ENS">源对象</param>
 /// <param name = "objvPaperCount2ENT">目标对象</param>
public void CopyTo(clsvPaperCount2EN objvPaperCount2ENS, clsvPaperCount2EN objvPaperCount2ENT)
{
objvPaperCount2ENT.PaperId = objvPaperCount2ENS.PaperId; //论文Id
objvPaperCount2ENT.Pcount = objvPaperCount2ENS.Pcount; //读写数
objvPaperCount2ENT.OkCount = objvPaperCount2ENS.OkCount; //点赞统计
objvPaperCount2ENT.AppraiseCount = objvPaperCount2ENS.AppraiseCount; //评论数
objvPaperCount2ENT.CollectionCount = objvPaperCount2ENS.CollectionCount; //收藏数量
objvPaperCount2ENT.DownloadCount = objvPaperCount2ENS.DownloadCount; //下载数
objvPaperCount2ENT.Score = objvPaperCount2ENS.Score; //评分
objvPaperCount2ENT.AttachmentCount = objvPaperCount2ENS.AttachmentCount; //附件计数
objvPaperCount2ENT.UpdUser = objvPaperCount2ENS.UpdUser; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPaperCount2EN objvPaperCount2EN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPaperCount2EN.PaperId, 8, convPaperCount2.PaperId);
clsCheckSql.CheckFieldLen(objvPaperCount2EN.UpdUser, 20, convPaperCount2.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPaperCount2EN.PaperId, convPaperCount2.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvPaperCount2EN.UpdUser, convPaperCount2.UpdUser);
//检查外键字段长度
 objvPaperCount2EN._IsCheckProperty = true;
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
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
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
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
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
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperCount2EN._CurrTabName);
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
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperCount2EN._CurrTabName, strCondition);
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
 objSQL = clsvPaperCount2DA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}