
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_LevelModeTypeDA
 表名:ge_LevelModeType(01120907)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 关卡模式类型(ge_LevelModeType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_LevelModeTypeDA : clsCommBase4DA
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
 return clsge_LevelModeTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_LevelModeTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_LevelModeTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_LevelModeTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_LevelModeTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strLevelModeTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strLevelModeTypeId)
{
strLevelModeTypeId = strLevelModeTypeId.Replace("'", "''");
if (strLevelModeTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:ge_LevelModeType中,检查关键字,长度不正确!(clsge_LevelModeTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strLevelModeTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ge_LevelModeType中,关键字不能为空 或 null!(clsge_LevelModeTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strLevelModeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsge_LevelModeTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
strSQL = "Select * from ge_LevelModeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_LevelModeType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: GetDataTable_ge_LevelModeType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
strSQL = "Select * from ge_LevelModeType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
strSQL = "Select * from ge_LevelModeType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_LevelModeType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_LevelModeType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_LevelModeType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_LevelModeType.* from ge_LevelModeType Left Join {1} on {2} where {3} and ge_LevelModeType.LevelModeTypeId not in (Select top {5} ge_LevelModeType.LevelModeTypeId from ge_LevelModeType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_LevelModeType where {1} and LevelModeTypeId not in (Select top {2} LevelModeTypeId from ge_LevelModeType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_LevelModeType where {1} and LevelModeTypeId not in (Select top {3} LevelModeTypeId from ge_LevelModeType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_LevelModeType.* from ge_LevelModeType Left Join {1} on {2} where {3} and ge_LevelModeType.LevelModeTypeId not in (Select top {5} ge_LevelModeType.LevelModeTypeId from ge_LevelModeType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_LevelModeType where {1} and LevelModeTypeId not in (Select top {2} LevelModeTypeId from ge_LevelModeType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_LevelModeType where {1} and LevelModeTypeId not in (Select top {3} LevelModeTypeId from ge_LevelModeType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_LevelModeTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA:GetObjLst)", objException.Message));
}
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
strSQL = "Select * from ge_LevelModeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_LevelModeTypeDA: GetObjLst)", objException.Message));
}
objge_LevelModeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_LevelModeTypeEN);
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
public List<clsge_LevelModeTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_LevelModeTypeDA: GetObjLst)", objException.Message));
}
objge_LevelModeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_LevelModeTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_LevelModeType(ref clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
strSQL = "Select * from ge_LevelModeType where LevelModeTypeId = " + "'"+ objge_LevelModeTypeEN.LevelModeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_LevelModeTypeEN.LevelModeTypeId = objDT.Rows[0][conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id(字段类型:char,字段长度:2,是否可空:False)
 objge_LevelModeTypeEN.LevelModeTypeName = objDT.Rows[0][conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名(字段类型:varchar,字段长度:100,是否可空:True)
 objge_LevelModeTypeEN.LevelModeTypeENName = objDT.Rows[0][conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objge_LevelModeTypeEN.UpdUser = objDT.Rows[0][conge_LevelModeType.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_LevelModeTypeEN.UpdDate = objDT.Rows[0][conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_LevelModeTypeEN.Memo = objDT.Rows[0][conge_LevelModeType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_LevelModeTypeDA: Getge_LevelModeType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strLevelModeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_LevelModeTypeEN GetObjByLevelModeTypeId(string strLevelModeTypeId)
{
CheckPrimaryKey(strLevelModeTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
strSQL = "Select * from ge_LevelModeType where LevelModeTypeId = " + "'"+ strLevelModeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
 objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id(字段类型:char,字段长度:2,是否可空:False)
 objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名(字段类型:varchar,字段长度:100,是否可空:True)
 objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_LevelModeTypeDA: GetObjByLevelModeTypeId)", objException.Message));
}
return objge_LevelModeTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_LevelModeTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
strSQL = "Select * from ge_LevelModeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN()
{
LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(), //模式Id
LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(), //模式名
LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(), //模式英文名
UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim() //备注
};
objge_LevelModeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_LevelModeTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_LevelModeTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_LevelModeTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_LevelModeTypeDA: GetObjByDataRowge_LevelModeType)", objException.Message));
}
objge_LevelModeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_LevelModeTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_LevelModeTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_LevelModeTypeDA: GetObjByDataRow)", objException.Message));
}
objge_LevelModeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_LevelModeTypeEN;
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
objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_LevelModeTypeEN._CurrTabName, conge_LevelModeType.LevelModeTypeId, 2, "");
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
objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_LevelModeTypeEN._CurrTabName, conge_LevelModeType.LevelModeTypeId, 2, strPrefix);
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
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select LevelModeTypeId from ge_LevelModeType where " + strCondition;
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
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select LevelModeTypeId from ge_LevelModeType where " + strCondition;
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
 /// <param name = "strLevelModeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strLevelModeTypeId)
{
CheckPrimaryKey(strLevelModeTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_LevelModeType", "LevelModeTypeId = " + "'"+ strLevelModeTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_LevelModeType", strCondition))
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
objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_LevelModeType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
 {
 objge_LevelModeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_LevelModeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_LevelModeTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
strSQL = "Select * from ge_LevelModeType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_LevelModeType");
objRow = objDS.Tables["ge_LevelModeType"].NewRow();
objRow[conge_LevelModeType.LevelModeTypeId] = objge_LevelModeTypeEN.LevelModeTypeId; //模式Id
 if (objge_LevelModeTypeEN.LevelModeTypeName !=  "")
 {
objRow[conge_LevelModeType.LevelModeTypeName] = objge_LevelModeTypeEN.LevelModeTypeName; //模式名
 }
 if (objge_LevelModeTypeEN.LevelModeTypeENName !=  "")
 {
objRow[conge_LevelModeType.LevelModeTypeENName] = objge_LevelModeTypeEN.LevelModeTypeENName; //模式英文名
 }
 if (objge_LevelModeTypeEN.UpdUser !=  "")
 {
objRow[conge_LevelModeType.UpdUser] = objge_LevelModeTypeEN.UpdUser; //修改人
 }
 if (objge_LevelModeTypeEN.UpdDate !=  "")
 {
objRow[conge_LevelModeType.UpdDate] = objge_LevelModeTypeEN.UpdDate; //修改日期
 }
 if (objge_LevelModeTypeEN.Memo !=  "")
 {
objRow[conge_LevelModeType.Memo] = objge_LevelModeTypeEN.Memo; //备注
 }
objDS.Tables[clsge_LevelModeTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_LevelModeTypeEN._CurrTabName);
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
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
 objge_LevelModeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_LevelModeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_LevelModeTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_LevelModeTypeEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeId);
 var strLevelModeTypeId = objge_LevelModeTypeEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 if (objge_LevelModeTypeEN.LevelModeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeName);
 var strLevelModeTypeName = objge_LevelModeTypeEN.LevelModeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeName + "'");
 }
 
 if (objge_LevelModeTypeEN.LevelModeTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeENName);
 var strLevelModeTypeENName = objge_LevelModeTypeEN.LevelModeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeENName + "'");
 }
 
 if (objge_LevelModeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.UpdUser);
 var strUpdUser = objge_LevelModeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_LevelModeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.UpdDate);
 var strUpdDate = objge_LevelModeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_LevelModeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.Memo);
 var strMemo = objge_LevelModeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_LevelModeType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
 objge_LevelModeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_LevelModeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_LevelModeTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_LevelModeTypeEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeId);
 var strLevelModeTypeId = objge_LevelModeTypeEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 if (objge_LevelModeTypeEN.LevelModeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeName);
 var strLevelModeTypeName = objge_LevelModeTypeEN.LevelModeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeName + "'");
 }
 
 if (objge_LevelModeTypeEN.LevelModeTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeENName);
 var strLevelModeTypeENName = objge_LevelModeTypeEN.LevelModeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeENName + "'");
 }
 
 if (objge_LevelModeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.UpdUser);
 var strUpdUser = objge_LevelModeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_LevelModeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.UpdDate);
 var strUpdDate = objge_LevelModeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_LevelModeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.Memo);
 var strMemo = objge_LevelModeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_LevelModeType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objge_LevelModeTypeEN.LevelModeTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_LevelModeTypeEN objge_LevelModeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_LevelModeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_LevelModeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_LevelModeTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_LevelModeTypeEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeId);
 var strLevelModeTypeId = objge_LevelModeTypeEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 if (objge_LevelModeTypeEN.LevelModeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeName);
 var strLevelModeTypeName = objge_LevelModeTypeEN.LevelModeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeName + "'");
 }
 
 if (objge_LevelModeTypeEN.LevelModeTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeENName);
 var strLevelModeTypeENName = objge_LevelModeTypeEN.LevelModeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeENName + "'");
 }
 
 if (objge_LevelModeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.UpdUser);
 var strUpdUser = objge_LevelModeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_LevelModeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.UpdDate);
 var strUpdDate = objge_LevelModeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_LevelModeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.Memo);
 var strMemo = objge_LevelModeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_LevelModeType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objge_LevelModeTypeEN.LevelModeTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_LevelModeTypeEN objge_LevelModeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_LevelModeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_LevelModeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_LevelModeTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_LevelModeTypeEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeId);
 var strLevelModeTypeId = objge_LevelModeTypeEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 if (objge_LevelModeTypeEN.LevelModeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeName);
 var strLevelModeTypeName = objge_LevelModeTypeEN.LevelModeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeName + "'");
 }
 
 if (objge_LevelModeTypeEN.LevelModeTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.LevelModeTypeENName);
 var strLevelModeTypeENName = objge_LevelModeTypeEN.LevelModeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeENName + "'");
 }
 
 if (objge_LevelModeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.UpdUser);
 var strUpdUser = objge_LevelModeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_LevelModeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.UpdDate);
 var strUpdDate = objge_LevelModeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_LevelModeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_LevelModeType.Memo);
 var strMemo = objge_LevelModeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_LevelModeType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_LevelModeTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
strSQL = "Select * from ge_LevelModeType where LevelModeTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_LevelModeType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strLevelModeTypeId = oRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim();
if (IsExist(strLevelModeTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("LevelModeTypeId = {0}", strLevelModeTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_LevelModeTypeEN._CurrTabName ].NewRow();
objRow[conge_LevelModeType.LevelModeTypeId] = oRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objRow[conge_LevelModeType.LevelModeTypeName] = oRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objRow[conge_LevelModeType.LevelModeTypeENName] = oRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objRow[conge_LevelModeType.UpdUser] = oRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objRow[conge_LevelModeType.UpdDate] = oRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objRow[conge_LevelModeType.Memo] = oRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
 objDS.Tables[clsge_LevelModeTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_LevelModeTypeEN._CurrTabName);
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
 /// <param name = "objge_LevelModeTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
 objge_LevelModeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_LevelModeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_LevelModeTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
strSQL = "Select * from ge_LevelModeType where LevelModeTypeId = " + "'"+ objge_LevelModeTypeEN.LevelModeTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_LevelModeTypeEN._CurrTabName);
if (objDS.Tables[clsge_LevelModeTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:LevelModeTypeId = " + "'"+ objge_LevelModeTypeEN.LevelModeTypeId+"'");
return false;
}
objRow = objDS.Tables[clsge_LevelModeTypeEN._CurrTabName].Rows[0];
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.LevelModeTypeId))
 {
objRow[conge_LevelModeType.LevelModeTypeId] = objge_LevelModeTypeEN.LevelModeTypeId; //模式Id
 }
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.LevelModeTypeName))
 {
objRow[conge_LevelModeType.LevelModeTypeName] = objge_LevelModeTypeEN.LevelModeTypeName; //模式名
 }
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.LevelModeTypeENName))
 {
objRow[conge_LevelModeType.LevelModeTypeENName] = objge_LevelModeTypeEN.LevelModeTypeENName; //模式英文名
 }
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.UpdUser))
 {
objRow[conge_LevelModeType.UpdUser] = objge_LevelModeTypeEN.UpdUser; //修改人
 }
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.UpdDate))
 {
objRow[conge_LevelModeType.UpdDate] = objge_LevelModeTypeEN.UpdDate; //修改日期
 }
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.Memo))
 {
objRow[conge_LevelModeType.Memo] = objge_LevelModeTypeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsge_LevelModeTypeEN._CurrTabName);
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
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
 objge_LevelModeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_LevelModeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_LevelModeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_LevelModeType Set ");
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.LevelModeTypeName))
 {
 if (objge_LevelModeTypeEN.LevelModeTypeName !=  null)
 {
 var strLevelModeTypeName = objge_LevelModeTypeEN.LevelModeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelModeTypeName, conge_LevelModeType.LevelModeTypeName); //模式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_LevelModeType.LevelModeTypeName); //模式名
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.LevelModeTypeENName))
 {
 if (objge_LevelModeTypeEN.LevelModeTypeENName !=  null)
 {
 var strLevelModeTypeENName = objge_LevelModeTypeEN.LevelModeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelModeTypeENName, conge_LevelModeType.LevelModeTypeENName); //模式英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_LevelModeType.LevelModeTypeENName); //模式英文名
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.UpdUser))
 {
 if (objge_LevelModeTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_LevelModeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_LevelModeType.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_LevelModeType.UpdUser); //修改人
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.UpdDate))
 {
 if (objge_LevelModeTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_LevelModeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_LevelModeType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_LevelModeType.UpdDate); //修改日期
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.Memo))
 {
 if (objge_LevelModeTypeEN.Memo !=  null)
 {
 var strMemo = objge_LevelModeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_LevelModeType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_LevelModeType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LevelModeTypeId = '{0}'", objge_LevelModeTypeEN.LevelModeTypeId); 
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
 /// <param name = "objge_LevelModeTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_LevelModeTypeEN objge_LevelModeTypeEN, string strCondition)
{
 objge_LevelModeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_LevelModeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_LevelModeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_LevelModeType Set ");
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.LevelModeTypeName))
 {
 if (objge_LevelModeTypeEN.LevelModeTypeName !=  null)
 {
 var strLevelModeTypeName = objge_LevelModeTypeEN.LevelModeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelModeTypeName = '{0}',", strLevelModeTypeName); //模式名
 }
 else
 {
 sbSQL.Append(" LevelModeTypeName = null,"); //模式名
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.LevelModeTypeENName))
 {
 if (objge_LevelModeTypeEN.LevelModeTypeENName !=  null)
 {
 var strLevelModeTypeENName = objge_LevelModeTypeEN.LevelModeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelModeTypeENName = '{0}',", strLevelModeTypeENName); //模式英文名
 }
 else
 {
 sbSQL.Append(" LevelModeTypeENName = null,"); //模式英文名
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.UpdUser))
 {
 if (objge_LevelModeTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_LevelModeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.UpdDate))
 {
 if (objge_LevelModeTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_LevelModeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.Memo))
 {
 if (objge_LevelModeTypeEN.Memo !=  null)
 {
 var strMemo = objge_LevelModeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objge_LevelModeTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_LevelModeTypeEN objge_LevelModeTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_LevelModeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_LevelModeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_LevelModeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_LevelModeType Set ");
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.LevelModeTypeName))
 {
 if (objge_LevelModeTypeEN.LevelModeTypeName !=  null)
 {
 var strLevelModeTypeName = objge_LevelModeTypeEN.LevelModeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelModeTypeName = '{0}',", strLevelModeTypeName); //模式名
 }
 else
 {
 sbSQL.Append(" LevelModeTypeName = null,"); //模式名
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.LevelModeTypeENName))
 {
 if (objge_LevelModeTypeEN.LevelModeTypeENName !=  null)
 {
 var strLevelModeTypeENName = objge_LevelModeTypeEN.LevelModeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelModeTypeENName = '{0}',", strLevelModeTypeENName); //模式英文名
 }
 else
 {
 sbSQL.Append(" LevelModeTypeENName = null,"); //模式英文名
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.UpdUser))
 {
 if (objge_LevelModeTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_LevelModeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.UpdDate))
 {
 if (objge_LevelModeTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_LevelModeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.Memo))
 {
 if (objge_LevelModeTypeEN.Memo !=  null)
 {
 var strMemo = objge_LevelModeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_LevelModeTypeEN objge_LevelModeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_LevelModeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_LevelModeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_LevelModeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_LevelModeType Set ");
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.LevelModeTypeName))
 {
 if (objge_LevelModeTypeEN.LevelModeTypeName !=  null)
 {
 var strLevelModeTypeName = objge_LevelModeTypeEN.LevelModeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelModeTypeName, conge_LevelModeType.LevelModeTypeName); //模式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_LevelModeType.LevelModeTypeName); //模式名
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.LevelModeTypeENName))
 {
 if (objge_LevelModeTypeEN.LevelModeTypeENName !=  null)
 {
 var strLevelModeTypeENName = objge_LevelModeTypeEN.LevelModeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelModeTypeENName, conge_LevelModeType.LevelModeTypeENName); //模式英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_LevelModeType.LevelModeTypeENName); //模式英文名
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.UpdUser))
 {
 if (objge_LevelModeTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_LevelModeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_LevelModeType.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_LevelModeType.UpdUser); //修改人
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.UpdDate))
 {
 if (objge_LevelModeTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_LevelModeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_LevelModeType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_LevelModeType.UpdDate); //修改日期
 }
 }
 
 if (objge_LevelModeTypeEN.IsUpdated(conge_LevelModeType.Memo))
 {
 if (objge_LevelModeTypeEN.Memo !=  null)
 {
 var strMemo = objge_LevelModeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_LevelModeType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_LevelModeType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LevelModeTypeId = '{0}'", objge_LevelModeTypeEN.LevelModeTypeId); 
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
 /// <param name = "strLevelModeTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strLevelModeTypeId) 
{
CheckPrimaryKey(strLevelModeTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strLevelModeTypeId,
};
 objSQL.ExecSP("ge_LevelModeType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strLevelModeTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strLevelModeTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strLevelModeTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
//删除ge_LevelModeType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_LevelModeType where LevelModeTypeId = " + "'"+ strLevelModeTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_LevelModeType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
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
//删除ge_LevelModeType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_LevelModeType where LevelModeTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strLevelModeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strLevelModeTypeId) 
{
CheckPrimaryKey(strLevelModeTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
//删除ge_LevelModeType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_LevelModeType where LevelModeTypeId = " + "'"+ strLevelModeTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_LevelModeType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: Delge_LevelModeType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_LevelModeType where " + strCondition ;
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
public bool Delge_LevelModeTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_LevelModeTypeDA: Delge_LevelModeTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_LevelModeType where " + strCondition ;
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
 /// <param name = "objge_LevelModeTypeENS">源对象</param>
 /// <param name = "objge_LevelModeTypeENT">目标对象</param>
public void CopyTo(clsge_LevelModeTypeEN objge_LevelModeTypeENS, clsge_LevelModeTypeEN objge_LevelModeTypeENT)
{
objge_LevelModeTypeENT.LevelModeTypeId = objge_LevelModeTypeENS.LevelModeTypeId; //模式Id
objge_LevelModeTypeENT.LevelModeTypeName = objge_LevelModeTypeENS.LevelModeTypeName; //模式名
objge_LevelModeTypeENT.LevelModeTypeENName = objge_LevelModeTypeENS.LevelModeTypeENName; //模式英文名
objge_LevelModeTypeENT.UpdUser = objge_LevelModeTypeENS.UpdUser; //修改人
objge_LevelModeTypeENT.UpdDate = objge_LevelModeTypeENS.UpdDate; //修改日期
objge_LevelModeTypeENT.Memo = objge_LevelModeTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.LevelModeTypeId, 2, conge_LevelModeType.LevelModeTypeId);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.LevelModeTypeName, 100, conge_LevelModeType.LevelModeTypeName);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.LevelModeTypeENName, 100, conge_LevelModeType.LevelModeTypeENName);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.UpdUser, 20, conge_LevelModeType.UpdUser);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.UpdDate, 20, conge_LevelModeType.UpdDate);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.Memo, 1000, conge_LevelModeType.Memo);
//检查字段外键固定长度
 objge_LevelModeTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.LevelModeTypeName, 100, conge_LevelModeType.LevelModeTypeName);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.LevelModeTypeENName, 100, conge_LevelModeType.LevelModeTypeENName);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.UpdUser, 20, conge_LevelModeType.UpdUser);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.UpdDate, 20, conge_LevelModeType.UpdDate);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.Memo, 1000, conge_LevelModeType.Memo);
//检查外键字段长度
 objge_LevelModeTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.LevelModeTypeId, 2, conge_LevelModeType.LevelModeTypeId);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.LevelModeTypeName, 100, conge_LevelModeType.LevelModeTypeName);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.LevelModeTypeENName, 100, conge_LevelModeType.LevelModeTypeENName);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.UpdUser, 20, conge_LevelModeType.UpdUser);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.UpdDate, 20, conge_LevelModeType.UpdDate);
clsCheckSql.CheckFieldLen(objge_LevelModeTypeEN.Memo, 1000, conge_LevelModeType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_LevelModeTypeEN.LevelModeTypeId, conge_LevelModeType.LevelModeTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_LevelModeTypeEN.LevelModeTypeName, conge_LevelModeType.LevelModeTypeName);
clsCheckSql.CheckSqlInjection4Field(objge_LevelModeTypeEN.LevelModeTypeENName, conge_LevelModeType.LevelModeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objge_LevelModeTypeEN.UpdUser, conge_LevelModeType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_LevelModeTypeEN.UpdDate, conge_LevelModeType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_LevelModeTypeEN.Memo, conge_LevelModeType.Memo);
//检查外键字段长度
 objge_LevelModeTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetLevelModeTypeId()
{
//获取某学院所有专业信息
string strSQL = "select LevelModeTypeId, LevelModeTypeName from ge_LevelModeType ";
 clsSpecSQLforSql mySql = clsge_LevelModeTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_LevelModeType(关卡模式类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objge_LevelModeTypeEN.LevelModeTypeName == null)
{
 sbCondition.AppendFormat(" and LevelModeTypeName is null");
}
else
{
 sbCondition.AppendFormat(" and LevelModeTypeName = '{0}'", objge_LevelModeTypeEN.LevelModeTypeName);
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
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
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
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
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
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_LevelModeTypeEN._CurrTabName);
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
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_LevelModeTypeEN._CurrTabName, strCondition);
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
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
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
 objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}