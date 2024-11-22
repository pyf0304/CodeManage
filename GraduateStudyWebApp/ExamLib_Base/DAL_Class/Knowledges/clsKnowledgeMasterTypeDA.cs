
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeMasterTypeDA
 表名:KnowledgeMasterType(01120893)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:47
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
 /// 知识点掌握类型(KnowledgeMasterType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsKnowledgeMasterTypeDA : clsCommBase4DA
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
 return clsKnowledgeMasterTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsKnowledgeMasterTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsKnowledgeMasterTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsKnowledgeMasterTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsKnowledgeMasterTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strMasterTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strMasterTypeId)
{
strMasterTypeId = strMasterTypeId.Replace("'", "''");
if (strMasterTypeId.Length > 1)
{
throw new Exception("(errid:Data000001)在表:KnowledgeMasterType中,检查关键字,长度不正确!(clsKnowledgeMasterTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMasterTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:KnowledgeMasterType中,关键字不能为空 或 null!(clsKnowledgeMasterTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMasterTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsKnowledgeMasterTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeMasterType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_KnowledgeMasterType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: GetDataTable_KnowledgeMasterType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeMasterType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeMasterType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeMasterType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeMasterType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from KnowledgeMasterType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} KnowledgeMasterType.* from KnowledgeMasterType Left Join {1} on {2} where {3} and KnowledgeMasterType.MasterTypeId not in (Select top {5} KnowledgeMasterType.MasterTypeId from KnowledgeMasterType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeMasterType where {1} and MasterTypeId not in (Select top {2} MasterTypeId from KnowledgeMasterType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeMasterType where {1} and MasterTypeId not in (Select top {3} MasterTypeId from KnowledgeMasterType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} KnowledgeMasterType.* from KnowledgeMasterType Left Join {1} on {2} where {3} and KnowledgeMasterType.MasterTypeId not in (Select top {5} KnowledgeMasterType.MasterTypeId from KnowledgeMasterType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeMasterType where {1} and MasterTypeId not in (Select top {2} MasterTypeId from KnowledgeMasterType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeMasterType where {1} and MasterTypeId not in (Select top {3} MasterTypeId from KnowledgeMasterType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsKnowledgeMasterTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA:GetObjLst)", objException.Message));
}
List<clsKnowledgeMasterTypeEN> arrObjLst = new List<clsKnowledgeMasterTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeMasterType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN = new clsKnowledgeMasterTypeEN();
try
{
objKnowledgeMasterTypeEN.MasterTypeId = objRow[conKnowledgeMasterType.MasterTypeId].ToString().Trim(); //掌握类型Id
objKnowledgeMasterTypeEN.MasterTypeName = objRow[conKnowledgeMasterType.MasterTypeName].ToString().Trim(); //掌握类型名
objKnowledgeMasterTypeEN.MasterTypeENName = objRow[conKnowledgeMasterType.MasterTypeENName] == DBNull.Value ? null : objRow[conKnowledgeMasterType.MasterTypeENName].ToString().Trim(); //掌握类型英文名
objKnowledgeMasterTypeEN.UpdDate = objRow[conKnowledgeMasterType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeMasterTypeEN.UpdUser = objRow[conKnowledgeMasterType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdUser].ToString().Trim(); //修改人
objKnowledgeMasterTypeEN.Memo = objRow[conKnowledgeMasterType.Memo] == DBNull.Value ? null : objRow[conKnowledgeMasterType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsKnowledgeMasterTypeDA: GetObjLst)", objException.Message));
}
objKnowledgeMasterTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objKnowledgeMasterTypeEN);
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
public List<clsKnowledgeMasterTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsKnowledgeMasterTypeEN> arrObjLst = new List<clsKnowledgeMasterTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN = new clsKnowledgeMasterTypeEN();
try
{
objKnowledgeMasterTypeEN.MasterTypeId = objRow[conKnowledgeMasterType.MasterTypeId].ToString().Trim(); //掌握类型Id
objKnowledgeMasterTypeEN.MasterTypeName = objRow[conKnowledgeMasterType.MasterTypeName].ToString().Trim(); //掌握类型名
objKnowledgeMasterTypeEN.MasterTypeENName = objRow[conKnowledgeMasterType.MasterTypeENName] == DBNull.Value ? null : objRow[conKnowledgeMasterType.MasterTypeENName].ToString().Trim(); //掌握类型英文名
objKnowledgeMasterTypeEN.UpdDate = objRow[conKnowledgeMasterType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeMasterTypeEN.UpdUser = objRow[conKnowledgeMasterType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdUser].ToString().Trim(); //修改人
objKnowledgeMasterTypeEN.Memo = objRow[conKnowledgeMasterType.Memo] == DBNull.Value ? null : objRow[conKnowledgeMasterType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsKnowledgeMasterTypeDA: GetObjLst)", objException.Message));
}
objKnowledgeMasterTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objKnowledgeMasterTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetKnowledgeMasterType(ref clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeMasterType where MasterTypeId = " + "'"+ objKnowledgeMasterTypeEN.MasterTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objKnowledgeMasterTypeEN.MasterTypeId = objDT.Rows[0][conKnowledgeMasterType.MasterTypeId].ToString().Trim(); //掌握类型Id(字段类型:char,字段长度:1,是否可空:True)
 objKnowledgeMasterTypeEN.MasterTypeName = objDT.Rows[0][conKnowledgeMasterType.MasterTypeName].ToString().Trim(); //掌握类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objKnowledgeMasterTypeEN.MasterTypeENName = objDT.Rows[0][conKnowledgeMasterType.MasterTypeENName].ToString().Trim(); //掌握类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objKnowledgeMasterTypeEN.UpdDate = objDT.Rows[0][conKnowledgeMasterType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeMasterTypeEN.UpdUser = objDT.Rows[0][conKnowledgeMasterType.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeMasterTypeEN.Memo = objDT.Rows[0][conKnowledgeMasterType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsKnowledgeMasterTypeDA: GetKnowledgeMasterType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMasterTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsKnowledgeMasterTypeEN GetObjByMasterTypeId(string strMasterTypeId)
{
CheckPrimaryKey(strMasterTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeMasterType where MasterTypeId = " + "'"+ strMasterTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN = new clsKnowledgeMasterTypeEN();
try
{
 objKnowledgeMasterTypeEN.MasterTypeId = objRow[conKnowledgeMasterType.MasterTypeId].ToString().Trim(); //掌握类型Id(字段类型:char,字段长度:1,是否可空:True)
 objKnowledgeMasterTypeEN.MasterTypeName = objRow[conKnowledgeMasterType.MasterTypeName].ToString().Trim(); //掌握类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objKnowledgeMasterTypeEN.MasterTypeENName = objRow[conKnowledgeMasterType.MasterTypeENName] == DBNull.Value ? null : objRow[conKnowledgeMasterType.MasterTypeENName].ToString().Trim(); //掌握类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objKnowledgeMasterTypeEN.UpdDate = objRow[conKnowledgeMasterType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeMasterTypeEN.UpdUser = objRow[conKnowledgeMasterType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeMasterTypeEN.Memo = objRow[conKnowledgeMasterType.Memo] == DBNull.Value ? null : objRow[conKnowledgeMasterType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsKnowledgeMasterTypeDA: GetObjByMasterTypeId)", objException.Message));
}
return objKnowledgeMasterTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsKnowledgeMasterTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeMasterType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN = new clsKnowledgeMasterTypeEN()
{
MasterTypeId = objRow[conKnowledgeMasterType.MasterTypeId].ToString().Trim(), //掌握类型Id
MasterTypeName = objRow[conKnowledgeMasterType.MasterTypeName].ToString().Trim(), //掌握类型名
MasterTypeENName = objRow[conKnowledgeMasterType.MasterTypeENName] == DBNull.Value ? null : objRow[conKnowledgeMasterType.MasterTypeENName].ToString().Trim(), //掌握类型英文名
UpdDate = objRow[conKnowledgeMasterType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conKnowledgeMasterType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conKnowledgeMasterType.Memo] == DBNull.Value ? null : objRow[conKnowledgeMasterType.Memo].ToString().Trim() //备注
};
objKnowledgeMasterTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeMasterTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsKnowledgeMasterTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsKnowledgeMasterTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN = new clsKnowledgeMasterTypeEN();
try
{
objKnowledgeMasterTypeEN.MasterTypeId = objRow[conKnowledgeMasterType.MasterTypeId].ToString().Trim(); //掌握类型Id
objKnowledgeMasterTypeEN.MasterTypeName = objRow[conKnowledgeMasterType.MasterTypeName].ToString().Trim(); //掌握类型名
objKnowledgeMasterTypeEN.MasterTypeENName = objRow[conKnowledgeMasterType.MasterTypeENName] == DBNull.Value ? null : objRow[conKnowledgeMasterType.MasterTypeENName].ToString().Trim(); //掌握类型英文名
objKnowledgeMasterTypeEN.UpdDate = objRow[conKnowledgeMasterType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeMasterTypeEN.UpdUser = objRow[conKnowledgeMasterType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdUser].ToString().Trim(); //修改人
objKnowledgeMasterTypeEN.Memo = objRow[conKnowledgeMasterType.Memo] == DBNull.Value ? null : objRow[conKnowledgeMasterType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsKnowledgeMasterTypeDA: GetObjByDataRowKnowledgeMasterType)", objException.Message));
}
objKnowledgeMasterTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeMasterTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsKnowledgeMasterTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN = new clsKnowledgeMasterTypeEN();
try
{
objKnowledgeMasterTypeEN.MasterTypeId = objRow[conKnowledgeMasterType.MasterTypeId].ToString().Trim(); //掌握类型Id
objKnowledgeMasterTypeEN.MasterTypeName = objRow[conKnowledgeMasterType.MasterTypeName].ToString().Trim(); //掌握类型名
objKnowledgeMasterTypeEN.MasterTypeENName = objRow[conKnowledgeMasterType.MasterTypeENName] == DBNull.Value ? null : objRow[conKnowledgeMasterType.MasterTypeENName].ToString().Trim(); //掌握类型英文名
objKnowledgeMasterTypeEN.UpdDate = objRow[conKnowledgeMasterType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeMasterTypeEN.UpdUser = objRow[conKnowledgeMasterType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeMasterType.UpdUser].ToString().Trim(); //修改人
objKnowledgeMasterTypeEN.Memo = objRow[conKnowledgeMasterType.Memo] == DBNull.Value ? null : objRow[conKnowledgeMasterType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsKnowledgeMasterTypeDA: GetObjByDataRow)", objException.Message));
}
objKnowledgeMasterTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeMasterTypeEN;
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
objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsKnowledgeMasterTypeEN._CurrTabName, conKnowledgeMasterType.MasterTypeId, 1, "");
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
objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsKnowledgeMasterTypeEN._CurrTabName, conKnowledgeMasterType.MasterTypeId, 1, strPrefix);
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
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MasterTypeId from KnowledgeMasterType where " + strCondition;
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
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MasterTypeId from KnowledgeMasterType where " + strCondition;
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
 /// <param name = "strMasterTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strMasterTypeId)
{
CheckPrimaryKey(strMasterTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("KnowledgeMasterType", "MasterTypeId = " + "'"+ strMasterTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("KnowledgeMasterType", strCondition))
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
objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("KnowledgeMasterType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
 {
 objKnowledgeMasterTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeMasterTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeMasterTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeMasterType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "KnowledgeMasterType");
objRow = objDS.Tables["KnowledgeMasterType"].NewRow();
objRow[conKnowledgeMasterType.MasterTypeId] = objKnowledgeMasterTypeEN.MasterTypeId; //掌握类型Id
objRow[conKnowledgeMasterType.MasterTypeName] = objKnowledgeMasterTypeEN.MasterTypeName; //掌握类型名
 if (objKnowledgeMasterTypeEN.MasterTypeENName !=  "")
 {
objRow[conKnowledgeMasterType.MasterTypeENName] = objKnowledgeMasterTypeEN.MasterTypeENName; //掌握类型英文名
 }
 if (objKnowledgeMasterTypeEN.UpdDate !=  "")
 {
objRow[conKnowledgeMasterType.UpdDate] = objKnowledgeMasterTypeEN.UpdDate; //修改日期
 }
 if (objKnowledgeMasterTypeEN.UpdUser !=  "")
 {
objRow[conKnowledgeMasterType.UpdUser] = objKnowledgeMasterTypeEN.UpdUser; //修改人
 }
 if (objKnowledgeMasterTypeEN.Memo !=  "")
 {
objRow[conKnowledgeMasterType.Memo] = objKnowledgeMasterTypeEN.Memo; //备注
 }
objDS.Tables[clsKnowledgeMasterTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsKnowledgeMasterTypeEN._CurrTabName);
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
 /// <param name = "objKnowledgeMasterTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
 objKnowledgeMasterTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeMasterTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeMasterTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objKnowledgeMasterTypeEN.MasterTypeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeId);
 var strMasterTypeId = objKnowledgeMasterTypeEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeId + "'");
 }
 
 if (objKnowledgeMasterTypeEN.MasterTypeName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeName);
 var strMasterTypeName = objKnowledgeMasterTypeEN.MasterTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeName + "'");
 }
 
 if (objKnowledgeMasterTypeEN.MasterTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeENName);
 var strMasterTypeENName = objKnowledgeMasterTypeEN.MasterTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeENName + "'");
 }
 
 if (objKnowledgeMasterTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.UpdDate);
 var strUpdDate = objKnowledgeMasterTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeMasterTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.UpdUser);
 var strUpdUser = objKnowledgeMasterTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeMasterTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.Memo);
 var strMemo = objKnowledgeMasterTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeMasterType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
 objKnowledgeMasterTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeMasterTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeMasterTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objKnowledgeMasterTypeEN.MasterTypeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeId);
 var strMasterTypeId = objKnowledgeMasterTypeEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeId + "'");
 }
 
 if (objKnowledgeMasterTypeEN.MasterTypeName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeName);
 var strMasterTypeName = objKnowledgeMasterTypeEN.MasterTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeName + "'");
 }
 
 if (objKnowledgeMasterTypeEN.MasterTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeENName);
 var strMasterTypeENName = objKnowledgeMasterTypeEN.MasterTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeENName + "'");
 }
 
 if (objKnowledgeMasterTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.UpdDate);
 var strUpdDate = objKnowledgeMasterTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeMasterTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.UpdUser);
 var strUpdUser = objKnowledgeMasterTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeMasterTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.Memo);
 var strMemo = objKnowledgeMasterTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeMasterType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objKnowledgeMasterTypeEN.MasterTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objKnowledgeMasterTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeMasterTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeMasterTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objKnowledgeMasterTypeEN.MasterTypeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeId);
 var strMasterTypeId = objKnowledgeMasterTypeEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeId + "'");
 }
 
 if (objKnowledgeMasterTypeEN.MasterTypeName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeName);
 var strMasterTypeName = objKnowledgeMasterTypeEN.MasterTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeName + "'");
 }
 
 if (objKnowledgeMasterTypeEN.MasterTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeENName);
 var strMasterTypeENName = objKnowledgeMasterTypeEN.MasterTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeENName + "'");
 }
 
 if (objKnowledgeMasterTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.UpdDate);
 var strUpdDate = objKnowledgeMasterTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeMasterTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.UpdUser);
 var strUpdUser = objKnowledgeMasterTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeMasterTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.Memo);
 var strMemo = objKnowledgeMasterTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeMasterType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objKnowledgeMasterTypeEN.MasterTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objKnowledgeMasterTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeMasterTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeMasterTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objKnowledgeMasterTypeEN.MasterTypeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeId);
 var strMasterTypeId = objKnowledgeMasterTypeEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeId + "'");
 }
 
 if (objKnowledgeMasterTypeEN.MasterTypeName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeName);
 var strMasterTypeName = objKnowledgeMasterTypeEN.MasterTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeName + "'");
 }
 
 if (objKnowledgeMasterTypeEN.MasterTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.MasterTypeENName);
 var strMasterTypeENName = objKnowledgeMasterTypeEN.MasterTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeENName + "'");
 }
 
 if (objKnowledgeMasterTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.UpdDate);
 var strUpdDate = objKnowledgeMasterTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeMasterTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.UpdUser);
 var strUpdUser = objKnowledgeMasterTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeMasterTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeMasterType.Memo);
 var strMemo = objKnowledgeMasterTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeMasterType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewKnowledgeMasterTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeMasterType where MasterTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "KnowledgeMasterType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strMasterTypeId = oRow[conKnowledgeMasterType.MasterTypeId].ToString().Trim();
if (IsExist(strMasterTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("MasterTypeId = {0}", strMasterTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsKnowledgeMasterTypeEN._CurrTabName ].NewRow();
objRow[conKnowledgeMasterType.MasterTypeId] = oRow[conKnowledgeMasterType.MasterTypeId].ToString().Trim(); //掌握类型Id
objRow[conKnowledgeMasterType.MasterTypeName] = oRow[conKnowledgeMasterType.MasterTypeName].ToString().Trim(); //掌握类型名
objRow[conKnowledgeMasterType.MasterTypeENName] = oRow[conKnowledgeMasterType.MasterTypeENName].ToString().Trim(); //掌握类型英文名
objRow[conKnowledgeMasterType.UpdDate] = oRow[conKnowledgeMasterType.UpdDate].ToString().Trim(); //修改日期
objRow[conKnowledgeMasterType.UpdUser] = oRow[conKnowledgeMasterType.UpdUser].ToString().Trim(); //修改人
objRow[conKnowledgeMasterType.Memo] = oRow[conKnowledgeMasterType.Memo].ToString().Trim(); //备注
 objDS.Tables[clsKnowledgeMasterTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsKnowledgeMasterTypeEN._CurrTabName);
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
 /// <param name = "objKnowledgeMasterTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
 objKnowledgeMasterTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeMasterTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeMasterTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeMasterType where MasterTypeId = " + "'"+ objKnowledgeMasterTypeEN.MasterTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsKnowledgeMasterTypeEN._CurrTabName);
if (objDS.Tables[clsKnowledgeMasterTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:MasterTypeId = " + "'"+ objKnowledgeMasterTypeEN.MasterTypeId+"'");
return false;
}
objRow = objDS.Tables[clsKnowledgeMasterTypeEN._CurrTabName].Rows[0];
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.MasterTypeId))
 {
objRow[conKnowledgeMasterType.MasterTypeId] = objKnowledgeMasterTypeEN.MasterTypeId; //掌握类型Id
 }
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.MasterTypeName))
 {
objRow[conKnowledgeMasterType.MasterTypeName] = objKnowledgeMasterTypeEN.MasterTypeName; //掌握类型名
 }
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.MasterTypeENName))
 {
objRow[conKnowledgeMasterType.MasterTypeENName] = objKnowledgeMasterTypeEN.MasterTypeENName; //掌握类型英文名
 }
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.UpdDate))
 {
objRow[conKnowledgeMasterType.UpdDate] = objKnowledgeMasterTypeEN.UpdDate; //修改日期
 }
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.UpdUser))
 {
objRow[conKnowledgeMasterType.UpdUser] = objKnowledgeMasterTypeEN.UpdUser; //修改人
 }
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.Memo))
 {
objRow[conKnowledgeMasterType.Memo] = objKnowledgeMasterTypeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsKnowledgeMasterTypeEN._CurrTabName);
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
 /// <param name = "objKnowledgeMasterTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
 objKnowledgeMasterTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeMasterTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeMasterTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update KnowledgeMasterType Set ");
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.MasterTypeName))
 {
 if (objKnowledgeMasterTypeEN.MasterTypeName !=  null)
 {
 var strMasterTypeName = objKnowledgeMasterTypeEN.MasterTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMasterTypeName, conKnowledgeMasterType.MasterTypeName); //掌握类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeMasterType.MasterTypeName); //掌握类型名
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.MasterTypeENName))
 {
 if (objKnowledgeMasterTypeEN.MasterTypeENName !=  null)
 {
 var strMasterTypeENName = objKnowledgeMasterTypeEN.MasterTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMasterTypeENName, conKnowledgeMasterType.MasterTypeENName); //掌握类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeMasterType.MasterTypeENName); //掌握类型英文名
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.UpdDate))
 {
 if (objKnowledgeMasterTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeMasterTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conKnowledgeMasterType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeMasterType.UpdDate); //修改日期
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.UpdUser))
 {
 if (objKnowledgeMasterTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeMasterTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conKnowledgeMasterType.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeMasterType.UpdUser); //修改人
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.Memo))
 {
 if (objKnowledgeMasterTypeEN.Memo !=  null)
 {
 var strMemo = objKnowledgeMasterTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conKnowledgeMasterType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeMasterType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MasterTypeId = '{0}'", objKnowledgeMasterTypeEN.MasterTypeId); 
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
 /// <param name = "objKnowledgeMasterTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, string strCondition)
{
 objKnowledgeMasterTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeMasterTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeMasterTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeMasterType Set ");
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.MasterTypeName))
 {
 if (objKnowledgeMasterTypeEN.MasterTypeName !=  null)
 {
 var strMasterTypeName = objKnowledgeMasterTypeEN.MasterTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MasterTypeName = '{0}',", strMasterTypeName); //掌握类型名
 }
 else
 {
 sbSQL.Append(" MasterTypeName = null,"); //掌握类型名
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.MasterTypeENName))
 {
 if (objKnowledgeMasterTypeEN.MasterTypeENName !=  null)
 {
 var strMasterTypeENName = objKnowledgeMasterTypeEN.MasterTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MasterTypeENName = '{0}',", strMasterTypeENName); //掌握类型英文名
 }
 else
 {
 sbSQL.Append(" MasterTypeENName = null,"); //掌握类型英文名
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.UpdDate))
 {
 if (objKnowledgeMasterTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeMasterTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.UpdUser))
 {
 if (objKnowledgeMasterTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeMasterTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.Memo))
 {
 if (objKnowledgeMasterTypeEN.Memo !=  null)
 {
 var strMemo = objKnowledgeMasterTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objKnowledgeMasterTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objKnowledgeMasterTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeMasterTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeMasterTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeMasterType Set ");
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.MasterTypeName))
 {
 if (objKnowledgeMasterTypeEN.MasterTypeName !=  null)
 {
 var strMasterTypeName = objKnowledgeMasterTypeEN.MasterTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MasterTypeName = '{0}',", strMasterTypeName); //掌握类型名
 }
 else
 {
 sbSQL.Append(" MasterTypeName = null,"); //掌握类型名
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.MasterTypeENName))
 {
 if (objKnowledgeMasterTypeEN.MasterTypeENName !=  null)
 {
 var strMasterTypeENName = objKnowledgeMasterTypeEN.MasterTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MasterTypeENName = '{0}',", strMasterTypeENName); //掌握类型英文名
 }
 else
 {
 sbSQL.Append(" MasterTypeENName = null,"); //掌握类型英文名
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.UpdDate))
 {
 if (objKnowledgeMasterTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeMasterTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.UpdUser))
 {
 if (objKnowledgeMasterTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeMasterTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.Memo))
 {
 if (objKnowledgeMasterTypeEN.Memo !=  null)
 {
 var strMemo = objKnowledgeMasterTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objKnowledgeMasterTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objKnowledgeMasterTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeMasterTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeMasterTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeMasterType Set ");
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.MasterTypeName))
 {
 if (objKnowledgeMasterTypeEN.MasterTypeName !=  null)
 {
 var strMasterTypeName = objKnowledgeMasterTypeEN.MasterTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMasterTypeName, conKnowledgeMasterType.MasterTypeName); //掌握类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeMasterType.MasterTypeName); //掌握类型名
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.MasterTypeENName))
 {
 if (objKnowledgeMasterTypeEN.MasterTypeENName !=  null)
 {
 var strMasterTypeENName = objKnowledgeMasterTypeEN.MasterTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMasterTypeENName, conKnowledgeMasterType.MasterTypeENName); //掌握类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeMasterType.MasterTypeENName); //掌握类型英文名
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.UpdDate))
 {
 if (objKnowledgeMasterTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeMasterTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conKnowledgeMasterType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeMasterType.UpdDate); //修改日期
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.UpdUser))
 {
 if (objKnowledgeMasterTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeMasterTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conKnowledgeMasterType.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeMasterType.UpdUser); //修改人
 }
 }
 
 if (objKnowledgeMasterTypeEN.IsUpdated(conKnowledgeMasterType.Memo))
 {
 if (objKnowledgeMasterTypeEN.Memo !=  null)
 {
 var strMemo = objKnowledgeMasterTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conKnowledgeMasterType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeMasterType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MasterTypeId = '{0}'", objKnowledgeMasterTypeEN.MasterTypeId); 
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
 /// <param name = "strMasterTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strMasterTypeId) 
{
CheckPrimaryKey(strMasterTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strMasterTypeId,
};
 objSQL.ExecSP("KnowledgeMasterType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strMasterTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strMasterTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strMasterTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
//删除KnowledgeMasterType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeMasterType where MasterTypeId = " + "'"+ strMasterTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelKnowledgeMasterType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
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
//删除KnowledgeMasterType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeMasterType where MasterTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strMasterTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strMasterTypeId) 
{
CheckPrimaryKey(strMasterTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
//删除KnowledgeMasterType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeMasterType where MasterTypeId = " + "'"+ strMasterTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelKnowledgeMasterType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: DelKnowledgeMasterType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from KnowledgeMasterType where " + strCondition ;
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
public bool DelKnowledgeMasterTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsKnowledgeMasterTypeDA: DelKnowledgeMasterTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from KnowledgeMasterType where " + strCondition ;
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
 /// <param name = "objKnowledgeMasterTypeENS">源对象</param>
 /// <param name = "objKnowledgeMasterTypeENT">目标对象</param>
public void CopyTo(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeENS, clsKnowledgeMasterTypeEN objKnowledgeMasterTypeENT)
{
objKnowledgeMasterTypeENT.MasterTypeId = objKnowledgeMasterTypeENS.MasterTypeId; //掌握类型Id
objKnowledgeMasterTypeENT.MasterTypeName = objKnowledgeMasterTypeENS.MasterTypeName; //掌握类型名
objKnowledgeMasterTypeENT.MasterTypeENName = objKnowledgeMasterTypeENS.MasterTypeENName; //掌握类型英文名
objKnowledgeMasterTypeENT.UpdDate = objKnowledgeMasterTypeENS.UpdDate; //修改日期
objKnowledgeMasterTypeENT.UpdUser = objKnowledgeMasterTypeENS.UpdUser; //修改人
objKnowledgeMasterTypeENT.Memo = objKnowledgeMasterTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objKnowledgeMasterTypeEN.MasterTypeName, conKnowledgeMasterType.MasterTypeName);
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.MasterTypeId, 1, conKnowledgeMasterType.MasterTypeId);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.MasterTypeName, 50, conKnowledgeMasterType.MasterTypeName);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.MasterTypeENName, 50, conKnowledgeMasterType.MasterTypeENName);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.UpdDate, 20, conKnowledgeMasterType.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.UpdUser, 20, conKnowledgeMasterType.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.Memo, 1000, conKnowledgeMasterType.Memo);
//检查字段外键固定长度
 objKnowledgeMasterTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.MasterTypeName, 50, conKnowledgeMasterType.MasterTypeName);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.MasterTypeENName, 50, conKnowledgeMasterType.MasterTypeENName);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.UpdDate, 20, conKnowledgeMasterType.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.UpdUser, 20, conKnowledgeMasterType.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.Memo, 1000, conKnowledgeMasterType.Memo);
//检查外键字段长度
 objKnowledgeMasterTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.MasterTypeId, 1, conKnowledgeMasterType.MasterTypeId);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.MasterTypeName, 50, conKnowledgeMasterType.MasterTypeName);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.MasterTypeENName, 50, conKnowledgeMasterType.MasterTypeENName);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.UpdDate, 20, conKnowledgeMasterType.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.UpdUser, 20, conKnowledgeMasterType.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeMasterTypeEN.Memo, 1000, conKnowledgeMasterType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objKnowledgeMasterTypeEN.MasterTypeId, conKnowledgeMasterType.MasterTypeId);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeMasterTypeEN.MasterTypeName, conKnowledgeMasterType.MasterTypeName);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeMasterTypeEN.MasterTypeENName, conKnowledgeMasterType.MasterTypeENName);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeMasterTypeEN.UpdDate, conKnowledgeMasterType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeMasterTypeEN.UpdUser, conKnowledgeMasterType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeMasterTypeEN.Memo, conKnowledgeMasterType.Memo);
//检查外键字段长度
 objKnowledgeMasterTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetMasterTypeId()
{
//获取某学院所有专业信息
string strSQL = "select MasterTypeId, MasterTypeName from KnowledgeMasterType ";
 clsSpecSQLforSql mySql = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--KnowledgeMasterType(知识点掌握类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MasterTypeName = '{0}'", objKnowledgeMasterTypeEN.MasterTypeName);
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
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsKnowledgeMasterTypeEN._CurrTabName);
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
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsKnowledgeMasterTypeEN._CurrTabName, strCondition);
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
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeMasterTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}