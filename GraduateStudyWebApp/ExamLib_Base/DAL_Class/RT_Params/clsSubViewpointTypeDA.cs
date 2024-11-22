
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSubViewpointTypeDA
 表名:SubViewpointType(01120533)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:33
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
 /// 子观点类型表(SubViewpointType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSubViewpointTypeDA : clsCommBase4DA
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
 return clsSubViewpointTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSubViewpointTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSubViewpointTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSubViewpointTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSubViewpointTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strSubViewpointTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strSubViewpointTypeId)
{
strSubViewpointTypeId = strSubViewpointTypeId.Replace("'", "''");
if (strSubViewpointTypeId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:SubViewpointType中,检查关键字,长度不正确!(clsSubViewpointTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strSubViewpointTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SubViewpointType中,关键字不能为空 或 null!(clsSubViewpointTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSubViewpointTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSubViewpointTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
strSQL = "Select * from SubViewpointType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SubViewpointType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA: GetDataTable_SubViewpointType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
strSQL = "Select * from SubViewpointType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
strSQL = "Select * from SubViewpointType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SubViewpointType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SubViewpointType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SubViewpointType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSubViewpointTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SubViewpointType.* from SubViewpointType Left Join {1} on {2} where {3} and SubViewpointType.SubViewpointTypeId not in (Select top {5} SubViewpointType.SubViewpointTypeId from SubViewpointType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SubViewpointType where {1} and SubViewpointTypeId not in (Select top {2} SubViewpointTypeId from SubViewpointType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SubViewpointType where {1} and SubViewpointTypeId not in (Select top {3} SubViewpointTypeId from SubViewpointType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSubViewpointTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SubViewpointType.* from SubViewpointType Left Join {1} on {2} where {3} and SubViewpointType.SubViewpointTypeId not in (Select top {5} SubViewpointType.SubViewpointTypeId from SubViewpointType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SubViewpointType where {1} and SubViewpointTypeId not in (Select top {2} SubViewpointTypeId from SubViewpointType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SubViewpointType where {1} and SubViewpointTypeId not in (Select top {3} SubViewpointTypeId from SubViewpointType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSubViewpointTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA:GetObjLst)", objException.Message));
}
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
strSQL = "Select * from SubViewpointType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSubViewpointTypeDA: GetObjLst)", objException.Message));
}
objSubViewpointTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSubViewpointTypeEN);
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
public List<clsSubViewpointTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSubViewpointTypeDA: GetObjLst)", objException.Message));
}
objSubViewpointTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSubViewpointTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSubViewpointType(ref clsSubViewpointTypeEN objSubViewpointTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
strSQL = "Select * from SubViewpointType where SubViewpointTypeId = " + "'"+ objSubViewpointTypeEN.SubViewpointTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSubViewpointTypeEN.SubViewpointTypeId = objDT.Rows[0][conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id(字段类型:char,字段长度:8,是否可空:False)
 objSubViewpointTypeEN.SubViewpointTypeName = objDT.Rows[0][conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objSubViewpointTypeEN.SubViewpointTypeENName = objDT.Rows[0][conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objSubViewpointTypeEN.DefaTitle = objDT.Rows[0][conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题(字段类型:varchar,字段长度:20,是否可空:True)
 objSubViewpointTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conSubViewpointType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objSubViewpointTypeEN.UpdDate = objDT.Rows[0][conSubViewpointType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSubViewpointTypeEN.UpdUserId = objDT.Rows[0][conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSubViewpointTypeEN.Memo = objDT.Rows[0][conSubViewpointType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSubViewpointTypeDA: GetSubViewpointType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSubViewpointTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsSubViewpointTypeEN GetObjBySubViewpointTypeId(string strSubViewpointTypeId)
{
CheckPrimaryKey(strSubViewpointTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
strSQL = "Select * from SubViewpointType where SubViewpointTypeId = " + "'"+ strSubViewpointTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
 objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id(字段类型:char,字段长度:8,是否可空:False)
 objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题(字段类型:varchar,字段长度:20,是否可空:True)
 objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSubViewpointTypeDA: GetObjBySubViewpointTypeId)", objException.Message));
}
return objSubViewpointTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSubViewpointTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
strSQL = "Select * from SubViewpointType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN()
{
SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(), //类型Id
SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(), //类型名称
SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(), //类型英文名
DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(), //默认标题
OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSubViewpointType.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim() //备注
};
objSubViewpointTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSubViewpointTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSubViewpointTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSubViewpointTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSubViewpointTypeDA: GetObjByDataRowSubViewpointType)", objException.Message));
}
objSubViewpointTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSubViewpointTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSubViewpointTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSubViewpointTypeDA: GetObjByDataRow)", objException.Message));
}
objSubViewpointTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSubViewpointTypeEN;
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
objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSubViewpointTypeEN._CurrTabName, conSubViewpointType.SubViewpointTypeId, 8, "");
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
objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSubViewpointTypeEN._CurrTabName, conSubViewpointType.SubViewpointTypeId, 8, strPrefix);
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
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SubViewpointTypeId from SubViewpointType where " + strCondition;
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
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SubViewpointTypeId from SubViewpointType where " + strCondition;
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
 /// <param name = "strSubViewpointTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strSubViewpointTypeId)
{
CheckPrimaryKey(strSubViewpointTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SubViewpointType", "SubViewpointTypeId = " + "'"+ strSubViewpointTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SubViewpointType", strCondition))
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
objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SubViewpointType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSubViewpointTypeEN objSubViewpointTypeEN)
 {
 objSubViewpointTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSubViewpointTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSubViewpointTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
strSQL = "Select * from SubViewpointType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SubViewpointType");
objRow = objDS.Tables["SubViewpointType"].NewRow();
objRow[conSubViewpointType.SubViewpointTypeId] = objSubViewpointTypeEN.SubViewpointTypeId; //类型Id
 if (objSubViewpointTypeEN.SubViewpointTypeName !=  "")
 {
objRow[conSubViewpointType.SubViewpointTypeName] = objSubViewpointTypeEN.SubViewpointTypeName; //类型名称
 }
 if (objSubViewpointTypeEN.SubViewpointTypeENName !=  "")
 {
objRow[conSubViewpointType.SubViewpointTypeENName] = objSubViewpointTypeEN.SubViewpointTypeENName; //类型英文名
 }
 if (objSubViewpointTypeEN.DefaTitle !=  "")
 {
objRow[conSubViewpointType.DefaTitle] = objSubViewpointTypeEN.DefaTitle; //默认标题
 }
objRow[conSubViewpointType.OrderNum] = objSubViewpointTypeEN.OrderNum; //序号
 if (objSubViewpointTypeEN.UpdDate !=  "")
 {
objRow[conSubViewpointType.UpdDate] = objSubViewpointTypeEN.UpdDate; //修改日期
 }
 if (objSubViewpointTypeEN.UpdUserId !=  "")
 {
objRow[conSubViewpointType.UpdUserId] = objSubViewpointTypeEN.UpdUserId; //修改用户Id
 }
 if (objSubViewpointTypeEN.Memo !=  "")
 {
objRow[conSubViewpointType.Memo] = objSubViewpointTypeEN.Memo; //备注
 }
objDS.Tables[clsSubViewpointTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSubViewpointTypeEN._CurrTabName);
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
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
 objSubViewpointTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSubViewpointTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSubViewpointTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSubViewpointTypeEN.SubViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeId);
 var strSubViewpointTypeId = objSubViewpointTypeEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeId + "'");
 }
 
 if (objSubViewpointTypeEN.SubViewpointTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeName);
 var strSubViewpointTypeName = objSubViewpointTypeEN.SubViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeName + "'");
 }
 
 if (objSubViewpointTypeEN.SubViewpointTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeENName);
 var strSubViewpointTypeENName = objSubViewpointTypeEN.SubViewpointTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeENName + "'");
 }
 
 if (objSubViewpointTypeEN.DefaTitle !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.DefaTitle);
 var strDefaTitle = objSubViewpointTypeEN.DefaTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaTitle + "'");
 }
 
 if (objSubViewpointTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.OrderNum);
 arrValueListForInsert.Add(objSubViewpointTypeEN.OrderNum.ToString());
 }
 
 if (objSubViewpointTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.UpdDate);
 var strUpdDate = objSubViewpointTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSubViewpointTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.UpdUserId);
 var strUpdUserId = objSubViewpointTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSubViewpointTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.Memo);
 var strMemo = objSubViewpointTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SubViewpointType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
 objSubViewpointTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSubViewpointTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSubViewpointTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSubViewpointTypeEN.SubViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeId);
 var strSubViewpointTypeId = objSubViewpointTypeEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeId + "'");
 }
 
 if (objSubViewpointTypeEN.SubViewpointTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeName);
 var strSubViewpointTypeName = objSubViewpointTypeEN.SubViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeName + "'");
 }
 
 if (objSubViewpointTypeEN.SubViewpointTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeENName);
 var strSubViewpointTypeENName = objSubViewpointTypeEN.SubViewpointTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeENName + "'");
 }
 
 if (objSubViewpointTypeEN.DefaTitle !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.DefaTitle);
 var strDefaTitle = objSubViewpointTypeEN.DefaTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaTitle + "'");
 }
 
 if (objSubViewpointTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.OrderNum);
 arrValueListForInsert.Add(objSubViewpointTypeEN.OrderNum.ToString());
 }
 
 if (objSubViewpointTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.UpdDate);
 var strUpdDate = objSubViewpointTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSubViewpointTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.UpdUserId);
 var strUpdUserId = objSubViewpointTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSubViewpointTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.Memo);
 var strMemo = objSubViewpointTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SubViewpointType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSubViewpointTypeEN.SubViewpointTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSubViewpointTypeEN objSubViewpointTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSubViewpointTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSubViewpointTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSubViewpointTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSubViewpointTypeEN.SubViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeId);
 var strSubViewpointTypeId = objSubViewpointTypeEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeId + "'");
 }
 
 if (objSubViewpointTypeEN.SubViewpointTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeName);
 var strSubViewpointTypeName = objSubViewpointTypeEN.SubViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeName + "'");
 }
 
 if (objSubViewpointTypeEN.SubViewpointTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeENName);
 var strSubViewpointTypeENName = objSubViewpointTypeEN.SubViewpointTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeENName + "'");
 }
 
 if (objSubViewpointTypeEN.DefaTitle !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.DefaTitle);
 var strDefaTitle = objSubViewpointTypeEN.DefaTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaTitle + "'");
 }
 
 if (objSubViewpointTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.OrderNum);
 arrValueListForInsert.Add(objSubViewpointTypeEN.OrderNum.ToString());
 }
 
 if (objSubViewpointTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.UpdDate);
 var strUpdDate = objSubViewpointTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSubViewpointTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.UpdUserId);
 var strUpdUserId = objSubViewpointTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSubViewpointTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.Memo);
 var strMemo = objSubViewpointTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SubViewpointType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSubViewpointTypeEN.SubViewpointTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSubViewpointTypeEN objSubViewpointTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSubViewpointTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSubViewpointTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSubViewpointTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSubViewpointTypeEN.SubViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeId);
 var strSubViewpointTypeId = objSubViewpointTypeEN.SubViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeId + "'");
 }
 
 if (objSubViewpointTypeEN.SubViewpointTypeName !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeName);
 var strSubViewpointTypeName = objSubViewpointTypeEN.SubViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeName + "'");
 }
 
 if (objSubViewpointTypeEN.SubViewpointTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.SubViewpointTypeENName);
 var strSubViewpointTypeENName = objSubViewpointTypeEN.SubViewpointTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubViewpointTypeENName + "'");
 }
 
 if (objSubViewpointTypeEN.DefaTitle !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.DefaTitle);
 var strDefaTitle = objSubViewpointTypeEN.DefaTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaTitle + "'");
 }
 
 if (objSubViewpointTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.OrderNum);
 arrValueListForInsert.Add(objSubViewpointTypeEN.OrderNum.ToString());
 }
 
 if (objSubViewpointTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.UpdDate);
 var strUpdDate = objSubViewpointTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSubViewpointTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.UpdUserId);
 var strUpdUserId = objSubViewpointTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSubViewpointTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSubViewpointType.Memo);
 var strMemo = objSubViewpointTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SubViewpointType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSubViewpointTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
strSQL = "Select * from SubViewpointType where SubViewpointTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SubViewpointType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strSubViewpointTypeId = oRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim();
if (IsExist(strSubViewpointTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("SubViewpointTypeId = {0}", strSubViewpointTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSubViewpointTypeEN._CurrTabName ].NewRow();
objRow[conSubViewpointType.SubViewpointTypeId] = oRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objRow[conSubViewpointType.SubViewpointTypeName] = oRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objRow[conSubViewpointType.SubViewpointTypeENName] = oRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objRow[conSubViewpointType.DefaTitle] = oRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objRow[conSubViewpointType.OrderNum] = oRow[conSubViewpointType.OrderNum].ToString().Trim(); //序号
objRow[conSubViewpointType.UpdDate] = oRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objRow[conSubViewpointType.UpdUserId] = oRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conSubViewpointType.Memo] = oRow[conSubViewpointType.Memo].ToString().Trim(); //备注
 objDS.Tables[clsSubViewpointTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSubViewpointTypeEN._CurrTabName);
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
 /// <param name = "objSubViewpointTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
 objSubViewpointTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSubViewpointTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSubViewpointTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
strSQL = "Select * from SubViewpointType where SubViewpointTypeId = " + "'"+ objSubViewpointTypeEN.SubViewpointTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSubViewpointTypeEN._CurrTabName);
if (objDS.Tables[clsSubViewpointTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SubViewpointTypeId = " + "'"+ objSubViewpointTypeEN.SubViewpointTypeId+"'");
return false;
}
objRow = objDS.Tables[clsSubViewpointTypeEN._CurrTabName].Rows[0];
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.SubViewpointTypeId))
 {
objRow[conSubViewpointType.SubViewpointTypeId] = objSubViewpointTypeEN.SubViewpointTypeId; //类型Id
 }
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.SubViewpointTypeName))
 {
objRow[conSubViewpointType.SubViewpointTypeName] = objSubViewpointTypeEN.SubViewpointTypeName; //类型名称
 }
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.SubViewpointTypeENName))
 {
objRow[conSubViewpointType.SubViewpointTypeENName] = objSubViewpointTypeEN.SubViewpointTypeENName; //类型英文名
 }
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.DefaTitle))
 {
objRow[conSubViewpointType.DefaTitle] = objSubViewpointTypeEN.DefaTitle; //默认标题
 }
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.OrderNum))
 {
objRow[conSubViewpointType.OrderNum] = objSubViewpointTypeEN.OrderNum; //序号
 }
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.UpdDate))
 {
objRow[conSubViewpointType.UpdDate] = objSubViewpointTypeEN.UpdDate; //修改日期
 }
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.UpdUserId))
 {
objRow[conSubViewpointType.UpdUserId] = objSubViewpointTypeEN.UpdUserId; //修改用户Id
 }
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.Memo))
 {
objRow[conSubViewpointType.Memo] = objSubViewpointTypeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsSubViewpointTypeEN._CurrTabName);
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
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
 objSubViewpointTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSubViewpointTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSubViewpointTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SubViewpointType Set ");
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.SubViewpointTypeName))
 {
 if (objSubViewpointTypeEN.SubViewpointTypeName !=  null)
 {
 var strSubViewpointTypeName = objSubViewpointTypeEN.SubViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubViewpointTypeName, conSubViewpointType.SubViewpointTypeName); //类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.SubViewpointTypeName); //类型名称
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.SubViewpointTypeENName))
 {
 if (objSubViewpointTypeEN.SubViewpointTypeENName !=  null)
 {
 var strSubViewpointTypeENName = objSubViewpointTypeEN.SubViewpointTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubViewpointTypeENName, conSubViewpointType.SubViewpointTypeENName); //类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.SubViewpointTypeENName); //类型英文名
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.DefaTitle))
 {
 if (objSubViewpointTypeEN.DefaTitle !=  null)
 {
 var strDefaTitle = objSubViewpointTypeEN.DefaTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaTitle, conSubViewpointType.DefaTitle); //默认标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.DefaTitle); //默认标题
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.OrderNum))
 {
 if (objSubViewpointTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSubViewpointTypeEN.OrderNum, conSubViewpointType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.OrderNum); //序号
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.UpdDate))
 {
 if (objSubViewpointTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objSubViewpointTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSubViewpointType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.UpdDate); //修改日期
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.UpdUserId))
 {
 if (objSubViewpointTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSubViewpointTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSubViewpointType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.UpdUserId); //修改用户Id
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.Memo))
 {
 if (objSubViewpointTypeEN.Memo !=  null)
 {
 var strMemo = objSubViewpointTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSubViewpointType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SubViewpointTypeId = '{0}'", objSubViewpointTypeEN.SubViewpointTypeId); 
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
 /// <param name = "objSubViewpointTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSubViewpointTypeEN objSubViewpointTypeEN, string strCondition)
{
 objSubViewpointTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSubViewpointTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSubViewpointTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SubViewpointType Set ");
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.SubViewpointTypeName))
 {
 if (objSubViewpointTypeEN.SubViewpointTypeName !=  null)
 {
 var strSubViewpointTypeName = objSubViewpointTypeEN.SubViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubViewpointTypeName = '{0}',", strSubViewpointTypeName); //类型名称
 }
 else
 {
 sbSQL.Append(" SubViewpointTypeName = null,"); //类型名称
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.SubViewpointTypeENName))
 {
 if (objSubViewpointTypeEN.SubViewpointTypeENName !=  null)
 {
 var strSubViewpointTypeENName = objSubViewpointTypeEN.SubViewpointTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubViewpointTypeENName = '{0}',", strSubViewpointTypeENName); //类型英文名
 }
 else
 {
 sbSQL.Append(" SubViewpointTypeENName = null,"); //类型英文名
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.DefaTitle))
 {
 if (objSubViewpointTypeEN.DefaTitle !=  null)
 {
 var strDefaTitle = objSubViewpointTypeEN.DefaTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaTitle = '{0}',", strDefaTitle); //默认标题
 }
 else
 {
 sbSQL.Append(" DefaTitle = null,"); //默认标题
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.OrderNum))
 {
 if (objSubViewpointTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSubViewpointTypeEN.OrderNum, conSubViewpointType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.OrderNum); //序号
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.UpdDate))
 {
 if (objSubViewpointTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objSubViewpointTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.UpdUserId))
 {
 if (objSubViewpointTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSubViewpointTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.Memo))
 {
 if (objSubViewpointTypeEN.Memo !=  null)
 {
 var strMemo = objSubViewpointTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSubViewpointTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSubViewpointTypeEN objSubViewpointTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSubViewpointTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSubViewpointTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSubViewpointTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SubViewpointType Set ");
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.SubViewpointTypeName))
 {
 if (objSubViewpointTypeEN.SubViewpointTypeName !=  null)
 {
 var strSubViewpointTypeName = objSubViewpointTypeEN.SubViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubViewpointTypeName = '{0}',", strSubViewpointTypeName); //类型名称
 }
 else
 {
 sbSQL.Append(" SubViewpointTypeName = null,"); //类型名称
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.SubViewpointTypeENName))
 {
 if (objSubViewpointTypeEN.SubViewpointTypeENName !=  null)
 {
 var strSubViewpointTypeENName = objSubViewpointTypeEN.SubViewpointTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubViewpointTypeENName = '{0}',", strSubViewpointTypeENName); //类型英文名
 }
 else
 {
 sbSQL.Append(" SubViewpointTypeENName = null,"); //类型英文名
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.DefaTitle))
 {
 if (objSubViewpointTypeEN.DefaTitle !=  null)
 {
 var strDefaTitle = objSubViewpointTypeEN.DefaTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaTitle = '{0}',", strDefaTitle); //默认标题
 }
 else
 {
 sbSQL.Append(" DefaTitle = null,"); //默认标题
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.OrderNum))
 {
 if (objSubViewpointTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSubViewpointTypeEN.OrderNum, conSubViewpointType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.OrderNum); //序号
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.UpdDate))
 {
 if (objSubViewpointTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objSubViewpointTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.UpdUserId))
 {
 if (objSubViewpointTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSubViewpointTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.Memo))
 {
 if (objSubViewpointTypeEN.Memo !=  null)
 {
 var strMemo = objSubViewpointTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSubViewpointTypeEN objSubViewpointTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSubViewpointTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSubViewpointTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSubViewpointTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SubViewpointType Set ");
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.SubViewpointTypeName))
 {
 if (objSubViewpointTypeEN.SubViewpointTypeName !=  null)
 {
 var strSubViewpointTypeName = objSubViewpointTypeEN.SubViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubViewpointTypeName, conSubViewpointType.SubViewpointTypeName); //类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.SubViewpointTypeName); //类型名称
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.SubViewpointTypeENName))
 {
 if (objSubViewpointTypeEN.SubViewpointTypeENName !=  null)
 {
 var strSubViewpointTypeENName = objSubViewpointTypeEN.SubViewpointTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubViewpointTypeENName, conSubViewpointType.SubViewpointTypeENName); //类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.SubViewpointTypeENName); //类型英文名
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.DefaTitle))
 {
 if (objSubViewpointTypeEN.DefaTitle !=  null)
 {
 var strDefaTitle = objSubViewpointTypeEN.DefaTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaTitle, conSubViewpointType.DefaTitle); //默认标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.DefaTitle); //默认标题
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.OrderNum))
 {
 if (objSubViewpointTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSubViewpointTypeEN.OrderNum, conSubViewpointType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.OrderNum); //序号
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.UpdDate))
 {
 if (objSubViewpointTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objSubViewpointTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSubViewpointType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.UpdDate); //修改日期
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.UpdUserId))
 {
 if (objSubViewpointTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSubViewpointTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSubViewpointType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.UpdUserId); //修改用户Id
 }
 }
 
 if (objSubViewpointTypeEN.IsUpdated(conSubViewpointType.Memo))
 {
 if (objSubViewpointTypeEN.Memo !=  null)
 {
 var strMemo = objSubViewpointTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSubViewpointType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSubViewpointType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SubViewpointTypeId = '{0}'", objSubViewpointTypeEN.SubViewpointTypeId); 
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
 /// <param name = "strSubViewpointTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strSubViewpointTypeId) 
{
CheckPrimaryKey(strSubViewpointTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strSubViewpointTypeId,
};
 objSQL.ExecSP("SubViewpointType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strSubViewpointTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strSubViewpointTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strSubViewpointTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
//删除SubViewpointType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SubViewpointType where SubViewpointTypeId = " + "'"+ strSubViewpointTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSubViewpointType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
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
//删除SubViewpointType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SubViewpointType where SubViewpointTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strSubViewpointTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strSubViewpointTypeId) 
{
CheckPrimaryKey(strSubViewpointTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
//删除SubViewpointType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SubViewpointType where SubViewpointTypeId = " + "'"+ strSubViewpointTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSubViewpointType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA: DelSubViewpointType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SubViewpointType where " + strCondition ;
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
public bool DelSubViewpointTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSubViewpointTypeDA: DelSubViewpointTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SubViewpointType where " + strCondition ;
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
 /// <param name = "objSubViewpointTypeENS">源对象</param>
 /// <param name = "objSubViewpointTypeENT">目标对象</param>
public void CopyTo(clsSubViewpointTypeEN objSubViewpointTypeENS, clsSubViewpointTypeEN objSubViewpointTypeENT)
{
objSubViewpointTypeENT.SubViewpointTypeId = objSubViewpointTypeENS.SubViewpointTypeId; //类型Id
objSubViewpointTypeENT.SubViewpointTypeName = objSubViewpointTypeENS.SubViewpointTypeName; //类型名称
objSubViewpointTypeENT.SubViewpointTypeENName = objSubViewpointTypeENS.SubViewpointTypeENName; //类型英文名
objSubViewpointTypeENT.DefaTitle = objSubViewpointTypeENS.DefaTitle; //默认标题
objSubViewpointTypeENT.OrderNum = objSubViewpointTypeENS.OrderNum; //序号
objSubViewpointTypeENT.UpdDate = objSubViewpointTypeENS.UpdDate; //修改日期
objSubViewpointTypeENT.UpdUserId = objSubViewpointTypeENS.UpdUserId; //修改用户Id
objSubViewpointTypeENT.Memo = objSubViewpointTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.SubViewpointTypeId, 8, conSubViewpointType.SubViewpointTypeId);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.SubViewpointTypeName, 50, conSubViewpointType.SubViewpointTypeName);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.SubViewpointTypeENName, 100, conSubViewpointType.SubViewpointTypeENName);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.DefaTitle, 20, conSubViewpointType.DefaTitle);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.UpdDate, 20, conSubViewpointType.UpdDate);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.UpdUserId, 20, conSubViewpointType.UpdUserId);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.Memo, 1000, conSubViewpointType.Memo);
//检查字段外键固定长度
 objSubViewpointTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.SubViewpointTypeName, 50, conSubViewpointType.SubViewpointTypeName);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.SubViewpointTypeENName, 100, conSubViewpointType.SubViewpointTypeENName);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.DefaTitle, 20, conSubViewpointType.DefaTitle);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.UpdDate, 20, conSubViewpointType.UpdDate);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.UpdUserId, 20, conSubViewpointType.UpdUserId);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.Memo, 1000, conSubViewpointType.Memo);
//检查外键字段长度
 objSubViewpointTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.SubViewpointTypeId, 8, conSubViewpointType.SubViewpointTypeId);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.SubViewpointTypeName, 50, conSubViewpointType.SubViewpointTypeName);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.SubViewpointTypeENName, 100, conSubViewpointType.SubViewpointTypeENName);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.DefaTitle, 20, conSubViewpointType.DefaTitle);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.UpdDate, 20, conSubViewpointType.UpdDate);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.UpdUserId, 20, conSubViewpointType.UpdUserId);
clsCheckSql.CheckFieldLen(objSubViewpointTypeEN.Memo, 1000, conSubViewpointType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSubViewpointTypeEN.SubViewpointTypeId, conSubViewpointType.SubViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objSubViewpointTypeEN.SubViewpointTypeName, conSubViewpointType.SubViewpointTypeName);
clsCheckSql.CheckSqlInjection4Field(objSubViewpointTypeEN.SubViewpointTypeENName, conSubViewpointType.SubViewpointTypeENName);
clsCheckSql.CheckSqlInjection4Field(objSubViewpointTypeEN.DefaTitle, conSubViewpointType.DefaTitle);
clsCheckSql.CheckSqlInjection4Field(objSubViewpointTypeEN.UpdDate, conSubViewpointType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSubViewpointTypeEN.UpdUserId, conSubViewpointType.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objSubViewpointTypeEN.Memo, conSubViewpointType.Memo);
//检查外键字段长度
 objSubViewpointTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetSubViewpointTypeId()
{
//获取某学院所有专业信息
string strSQL = "select SubViewpointTypeId, SubViewpointTypeName from SubViewpointType ";
 clsSpecSQLforSql mySql = clsSubViewpointTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SubViewpointType(子观点类型表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objSubViewpointTypeEN.SubViewpointTypeName == null)
{
 sbCondition.AppendFormat(" and SubViewpointTypeName is null");
}
else
{
 sbCondition.AppendFormat(" and SubViewpointTypeName = '{0}'", objSubViewpointTypeEN.SubViewpointTypeName);
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
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
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
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
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
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSubViewpointTypeEN._CurrTabName);
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
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSubViewpointTypeEN._CurrTabName, strCondition);
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
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
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
 objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}