
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeTypeDA
 表名:KnowledgeType(01120890)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:37
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
 /// 知识点类型(KnowledgeType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsKnowledgeTypeDA : clsCommBase4DA
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
 return clsKnowledgeTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsKnowledgeTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsKnowledgeTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsKnowledgeTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsKnowledgeTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strKnowledgeTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strKnowledgeTypeId)
{
strKnowledgeTypeId = strKnowledgeTypeId.Replace("'", "''");
if (strKnowledgeTypeId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:KnowledgeType中,检查关键字,长度不正确!(clsKnowledgeTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strKnowledgeTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:KnowledgeType中,关键字不能为空 或 null!(clsKnowledgeTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKnowledgeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsKnowledgeTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_KnowledgeType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA: GetDataTable_KnowledgeType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from KnowledgeType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsKnowledgeTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} KnowledgeType.* from KnowledgeType Left Join {1} on {2} where {3} and KnowledgeType.KnowledgeTypeId not in (Select top {5} KnowledgeType.KnowledgeTypeId from KnowledgeType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeType where {1} and KnowledgeTypeId not in (Select top {2} KnowledgeTypeId from KnowledgeType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeType where {1} and KnowledgeTypeId not in (Select top {3} KnowledgeTypeId from KnowledgeType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsKnowledgeTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} KnowledgeType.* from KnowledgeType Left Join {1} on {2} where {3} and KnowledgeType.KnowledgeTypeId not in (Select top {5} KnowledgeType.KnowledgeTypeId from KnowledgeType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeType where {1} and KnowledgeTypeId not in (Select top {2} KnowledgeTypeId from KnowledgeType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeType where {1} and KnowledgeTypeId not in (Select top {3} KnowledgeTypeId from KnowledgeType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsKnowledgeTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA:GetObjLst)", objException.Message));
}
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsKnowledgeTypeDA: GetObjLst)", objException.Message));
}
objKnowledgeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objKnowledgeTypeEN);
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
public List<clsKnowledgeTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsKnowledgeTypeDA: GetObjLst)", objException.Message));
}
objKnowledgeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objKnowledgeTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetKnowledgeType(ref clsKnowledgeTypeEN objKnowledgeTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeType where KnowledgeTypeId = " + "'"+ objKnowledgeTypeEN.KnowledgeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objKnowledgeTypeEN.KnowledgeTypeId = objDT.Rows[0][conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objKnowledgeTypeEN.KnowledgeTypeName = objDT.Rows[0][conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objKnowledgeTypeEN.CourseId = objDT.Rows[0][conKnowledgeType.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objKnowledgeTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conKnowledgeType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objKnowledgeTypeEN.UpdDate = objDT.Rows[0][conKnowledgeType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeTypeEN.UpdUser = objDT.Rows[0][conKnowledgeType.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeTypeEN.Memo = objDT.Rows[0][conKnowledgeType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsKnowledgeTypeDA: GetKnowledgeType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strKnowledgeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsKnowledgeTypeEN GetObjByKnowledgeTypeId(string strKnowledgeTypeId)
{
CheckPrimaryKey(strKnowledgeTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeType where KnowledgeTypeId = " + "'"+ strKnowledgeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
 objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsKnowledgeTypeDA: GetObjByKnowledgeTypeId)", objException.Message));
}
return objKnowledgeTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsKnowledgeTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN()
{
KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(), //知识点类型Id
KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(), //知识点类型名
CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(), //课程Id
OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeType.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim() //备注
};
objKnowledgeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsKnowledgeTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsKnowledgeTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsKnowledgeTypeDA: GetObjByDataRowKnowledgeType)", objException.Message));
}
objKnowledgeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsKnowledgeTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsKnowledgeTypeDA: GetObjByDataRow)", objException.Message));
}
objKnowledgeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeTypeEN;
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
objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsKnowledgeTypeEN._CurrTabName, conKnowledgeType.KnowledgeTypeId, 4, "");
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
objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsKnowledgeTypeEN._CurrTabName, conKnowledgeType.KnowledgeTypeId, 4, strPrefix);
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
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select KnowledgeTypeId from KnowledgeType where " + strCondition;
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
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select KnowledgeTypeId from KnowledgeType where " + strCondition;
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
 /// <param name = "strKnowledgeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strKnowledgeTypeId)
{
CheckPrimaryKey(strKnowledgeTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("KnowledgeType", "KnowledgeTypeId = " + "'"+ strKnowledgeTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("KnowledgeType", strCondition))
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
objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("KnowledgeType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsKnowledgeTypeEN objKnowledgeTypeEN)
 {
 objKnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "KnowledgeType");
objRow = objDS.Tables["KnowledgeType"].NewRow();
objRow[conKnowledgeType.KnowledgeTypeId] = objKnowledgeTypeEN.KnowledgeTypeId; //知识点类型Id
objRow[conKnowledgeType.KnowledgeTypeName] = objKnowledgeTypeEN.KnowledgeTypeName; //知识点类型名
objRow[conKnowledgeType.CourseId] = objKnowledgeTypeEN.CourseId; //课程Id
objRow[conKnowledgeType.OrderNum] = objKnowledgeTypeEN.OrderNum; //序号
 if (objKnowledgeTypeEN.UpdDate !=  "")
 {
objRow[conKnowledgeType.UpdDate] = objKnowledgeTypeEN.UpdDate; //修改日期
 }
 if (objKnowledgeTypeEN.UpdUser !=  "")
 {
objRow[conKnowledgeType.UpdUser] = objKnowledgeTypeEN.UpdUser; //修改人
 }
 if (objKnowledgeTypeEN.Memo !=  "")
 {
objRow[conKnowledgeType.Memo] = objKnowledgeTypeEN.Memo; //备注
 }
objDS.Tables[clsKnowledgeTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsKnowledgeTypeEN._CurrTabName);
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
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
 objKnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objKnowledgeTypeEN.KnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.KnowledgeTypeId);
 var strKnowledgeTypeId = objKnowledgeTypeEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeId + "'");
 }
 
 if (objKnowledgeTypeEN.KnowledgeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.KnowledgeTypeName);
 var strKnowledgeTypeName = objKnowledgeTypeEN.KnowledgeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeName + "'");
 }
 
 if (objKnowledgeTypeEN.CourseId  ==  "")
 {
 objKnowledgeTypeEN.CourseId = null;
 }
 if (objKnowledgeTypeEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.CourseId);
 var strCourseId = objKnowledgeTypeEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.OrderNum);
 arrValueListForInsert.Add(objKnowledgeTypeEN.OrderNum.ToString());
 }
 
 if (objKnowledgeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.UpdDate);
 var strUpdDate = objKnowledgeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.UpdUser);
 var strUpdUser = objKnowledgeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.Memo);
 var strMemo = objKnowledgeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
 objKnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objKnowledgeTypeEN.KnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.KnowledgeTypeId);
 var strKnowledgeTypeId = objKnowledgeTypeEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeId + "'");
 }
 
 if (objKnowledgeTypeEN.KnowledgeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.KnowledgeTypeName);
 var strKnowledgeTypeName = objKnowledgeTypeEN.KnowledgeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeName + "'");
 }
 
 if (objKnowledgeTypeEN.CourseId  ==  "")
 {
 objKnowledgeTypeEN.CourseId = null;
 }
 if (objKnowledgeTypeEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.CourseId);
 var strCourseId = objKnowledgeTypeEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.OrderNum);
 arrValueListForInsert.Add(objKnowledgeTypeEN.OrderNum.ToString());
 }
 
 if (objKnowledgeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.UpdDate);
 var strUpdDate = objKnowledgeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.UpdUser);
 var strUpdUser = objKnowledgeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.Memo);
 var strMemo = objKnowledgeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objKnowledgeTypeEN.KnowledgeTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsKnowledgeTypeEN objKnowledgeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objKnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objKnowledgeTypeEN.KnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.KnowledgeTypeId);
 var strKnowledgeTypeId = objKnowledgeTypeEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeId + "'");
 }
 
 if (objKnowledgeTypeEN.KnowledgeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.KnowledgeTypeName);
 var strKnowledgeTypeName = objKnowledgeTypeEN.KnowledgeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeName + "'");
 }
 
 if (objKnowledgeTypeEN.CourseId  ==  "")
 {
 objKnowledgeTypeEN.CourseId = null;
 }
 if (objKnowledgeTypeEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.CourseId);
 var strCourseId = objKnowledgeTypeEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.OrderNum);
 arrValueListForInsert.Add(objKnowledgeTypeEN.OrderNum.ToString());
 }
 
 if (objKnowledgeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.UpdDate);
 var strUpdDate = objKnowledgeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.UpdUser);
 var strUpdUser = objKnowledgeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.Memo);
 var strMemo = objKnowledgeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objKnowledgeTypeEN.KnowledgeTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsKnowledgeTypeEN objKnowledgeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objKnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objKnowledgeTypeEN.KnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.KnowledgeTypeId);
 var strKnowledgeTypeId = objKnowledgeTypeEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeId + "'");
 }
 
 if (objKnowledgeTypeEN.KnowledgeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.KnowledgeTypeName);
 var strKnowledgeTypeName = objKnowledgeTypeEN.KnowledgeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeName + "'");
 }
 
 if (objKnowledgeTypeEN.CourseId  ==  "")
 {
 objKnowledgeTypeEN.CourseId = null;
 }
 if (objKnowledgeTypeEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.CourseId);
 var strCourseId = objKnowledgeTypeEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.OrderNum);
 arrValueListForInsert.Add(objKnowledgeTypeEN.OrderNum.ToString());
 }
 
 if (objKnowledgeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.UpdDate);
 var strUpdDate = objKnowledgeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.UpdUser);
 var strUpdUser = objKnowledgeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeType.Memo);
 var strMemo = objKnowledgeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewKnowledgeTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeType where KnowledgeTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "KnowledgeType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strKnowledgeTypeId = oRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim();
if (IsExist(strKnowledgeTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("KnowledgeTypeId = {0}", strKnowledgeTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsKnowledgeTypeEN._CurrTabName ].NewRow();
objRow[conKnowledgeType.KnowledgeTypeId] = oRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objRow[conKnowledgeType.KnowledgeTypeName] = oRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objRow[conKnowledgeType.CourseId] = oRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objRow[conKnowledgeType.OrderNum] = oRow[conKnowledgeType.OrderNum].ToString().Trim(); //序号
objRow[conKnowledgeType.UpdDate] = oRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objRow[conKnowledgeType.UpdUser] = oRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objRow[conKnowledgeType.Memo] = oRow[conKnowledgeType.Memo].ToString().Trim(); //备注
 objDS.Tables[clsKnowledgeTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsKnowledgeTypeEN._CurrTabName);
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
 /// <param name = "objKnowledgeTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
 objKnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeType where KnowledgeTypeId = " + "'"+ objKnowledgeTypeEN.KnowledgeTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsKnowledgeTypeEN._CurrTabName);
if (objDS.Tables[clsKnowledgeTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:KnowledgeTypeId = " + "'"+ objKnowledgeTypeEN.KnowledgeTypeId+"'");
return false;
}
objRow = objDS.Tables[clsKnowledgeTypeEN._CurrTabName].Rows[0];
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.KnowledgeTypeId))
 {
objRow[conKnowledgeType.KnowledgeTypeId] = objKnowledgeTypeEN.KnowledgeTypeId; //知识点类型Id
 }
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.KnowledgeTypeName))
 {
objRow[conKnowledgeType.KnowledgeTypeName] = objKnowledgeTypeEN.KnowledgeTypeName; //知识点类型名
 }
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.CourseId))
 {
objRow[conKnowledgeType.CourseId] = objKnowledgeTypeEN.CourseId; //课程Id
 }
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.OrderNum))
 {
objRow[conKnowledgeType.OrderNum] = objKnowledgeTypeEN.OrderNum; //序号
 }
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.UpdDate))
 {
objRow[conKnowledgeType.UpdDate] = objKnowledgeTypeEN.UpdDate; //修改日期
 }
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.UpdUser))
 {
objRow[conKnowledgeType.UpdUser] = objKnowledgeTypeEN.UpdUser; //修改人
 }
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.Memo))
 {
objRow[conKnowledgeType.Memo] = objKnowledgeTypeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsKnowledgeTypeEN._CurrTabName);
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
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
 objKnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update KnowledgeType Set ");
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.KnowledgeTypeName))
 {
 if (objKnowledgeTypeEN.KnowledgeTypeName !=  null)
 {
 var strKnowledgeTypeName = objKnowledgeTypeEN.KnowledgeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeTypeName, conKnowledgeType.KnowledgeTypeName); //知识点类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.KnowledgeTypeName); //知识点类型名
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.CourseId))
 {
 if (objKnowledgeTypeEN.CourseId  ==  "")
 {
 objKnowledgeTypeEN.CourseId = null;
 }
 if (objKnowledgeTypeEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeTypeEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conKnowledgeType.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.CourseId); //课程Id
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.OrderNum))
 {
 if (objKnowledgeTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeTypeEN.OrderNum, conKnowledgeType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.OrderNum); //序号
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.UpdDate))
 {
 if (objKnowledgeTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conKnowledgeType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.UpdDate); //修改日期
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.UpdUser))
 {
 if (objKnowledgeTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conKnowledgeType.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.UpdUser); //修改人
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.Memo))
 {
 if (objKnowledgeTypeEN.Memo !=  null)
 {
 var strMemo = objKnowledgeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conKnowledgeType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where KnowledgeTypeId = '{0}'", objKnowledgeTypeEN.KnowledgeTypeId); 
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
 /// <param name = "objKnowledgeTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsKnowledgeTypeEN objKnowledgeTypeEN, string strCondition)
{
 objKnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeType Set ");
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.KnowledgeTypeName))
 {
 if (objKnowledgeTypeEN.KnowledgeTypeName !=  null)
 {
 var strKnowledgeTypeName = objKnowledgeTypeEN.KnowledgeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeTypeName = '{0}',", strKnowledgeTypeName); //知识点类型名
 }
 else
 {
 sbSQL.Append(" KnowledgeTypeName = null,"); //知识点类型名
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.CourseId))
 {
 if (objKnowledgeTypeEN.CourseId  ==  "")
 {
 objKnowledgeTypeEN.CourseId = null;
 }
 if (objKnowledgeTypeEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeTypeEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.OrderNum))
 {
 if (objKnowledgeTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeTypeEN.OrderNum, conKnowledgeType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.OrderNum); //序号
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.UpdDate))
 {
 if (objKnowledgeTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.UpdUser))
 {
 if (objKnowledgeTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.Memo))
 {
 if (objKnowledgeTypeEN.Memo !=  null)
 {
 var strMemo = objKnowledgeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objKnowledgeTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsKnowledgeTypeEN objKnowledgeTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objKnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeType Set ");
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.KnowledgeTypeName))
 {
 if (objKnowledgeTypeEN.KnowledgeTypeName !=  null)
 {
 var strKnowledgeTypeName = objKnowledgeTypeEN.KnowledgeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeTypeName = '{0}',", strKnowledgeTypeName); //知识点类型名
 }
 else
 {
 sbSQL.Append(" KnowledgeTypeName = null,"); //知识点类型名
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.CourseId))
 {
 if (objKnowledgeTypeEN.CourseId  ==  "")
 {
 objKnowledgeTypeEN.CourseId = null;
 }
 if (objKnowledgeTypeEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeTypeEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.OrderNum))
 {
 if (objKnowledgeTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeTypeEN.OrderNum, conKnowledgeType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.OrderNum); //序号
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.UpdDate))
 {
 if (objKnowledgeTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.UpdUser))
 {
 if (objKnowledgeTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.Memo))
 {
 if (objKnowledgeTypeEN.Memo !=  null)
 {
 var strMemo = objKnowledgeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsKnowledgeTypeEN objKnowledgeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objKnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeType Set ");
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.KnowledgeTypeName))
 {
 if (objKnowledgeTypeEN.KnowledgeTypeName !=  null)
 {
 var strKnowledgeTypeName = objKnowledgeTypeEN.KnowledgeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeTypeName, conKnowledgeType.KnowledgeTypeName); //知识点类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.KnowledgeTypeName); //知识点类型名
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.CourseId))
 {
 if (objKnowledgeTypeEN.CourseId  ==  "")
 {
 objKnowledgeTypeEN.CourseId = null;
 }
 if (objKnowledgeTypeEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeTypeEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conKnowledgeType.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.CourseId); //课程Id
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.OrderNum))
 {
 if (objKnowledgeTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeTypeEN.OrderNum, conKnowledgeType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.OrderNum); //序号
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.UpdDate))
 {
 if (objKnowledgeTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conKnowledgeType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.UpdDate); //修改日期
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.UpdUser))
 {
 if (objKnowledgeTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conKnowledgeType.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.UpdUser); //修改人
 }
 }
 
 if (objKnowledgeTypeEN.IsUpdated(conKnowledgeType.Memo))
 {
 if (objKnowledgeTypeEN.Memo !=  null)
 {
 var strMemo = objKnowledgeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conKnowledgeType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where KnowledgeTypeId = '{0}'", objKnowledgeTypeEN.KnowledgeTypeId); 
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
 /// <param name = "strKnowledgeTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strKnowledgeTypeId) 
{
CheckPrimaryKey(strKnowledgeTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strKnowledgeTypeId,
};
 objSQL.ExecSP("KnowledgeType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strKnowledgeTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strKnowledgeTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strKnowledgeTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
//删除KnowledgeType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeType where KnowledgeTypeId = " + "'"+ strKnowledgeTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelKnowledgeType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
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
//删除KnowledgeType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeType where KnowledgeTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strKnowledgeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strKnowledgeTypeId) 
{
CheckPrimaryKey(strKnowledgeTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
//删除KnowledgeType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeType where KnowledgeTypeId = " + "'"+ strKnowledgeTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelKnowledgeType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA: DelKnowledgeType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from KnowledgeType where " + strCondition ;
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
public bool DelKnowledgeTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsKnowledgeTypeDA: DelKnowledgeTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from KnowledgeType where " + strCondition ;
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
 /// <param name = "objKnowledgeTypeENS">源对象</param>
 /// <param name = "objKnowledgeTypeENT">目标对象</param>
public void CopyTo(clsKnowledgeTypeEN objKnowledgeTypeENS, clsKnowledgeTypeEN objKnowledgeTypeENT)
{
objKnowledgeTypeENT.KnowledgeTypeId = objKnowledgeTypeENS.KnowledgeTypeId; //知识点类型Id
objKnowledgeTypeENT.KnowledgeTypeName = objKnowledgeTypeENS.KnowledgeTypeName; //知识点类型名
objKnowledgeTypeENT.CourseId = objKnowledgeTypeENS.CourseId; //课程Id
objKnowledgeTypeENT.OrderNum = objKnowledgeTypeENS.OrderNum; //序号
objKnowledgeTypeENT.UpdDate = objKnowledgeTypeENS.UpdDate; //修改日期
objKnowledgeTypeENT.UpdUser = objKnowledgeTypeENS.UpdUser; //修改人
objKnowledgeTypeENT.Memo = objKnowledgeTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objKnowledgeTypeEN.KnowledgeTypeName, conKnowledgeType.KnowledgeTypeName);
clsCheckSql.CheckFieldNotNull(objKnowledgeTypeEN.CourseId, conKnowledgeType.CourseId);
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.KnowledgeTypeId, 4, conKnowledgeType.KnowledgeTypeId);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.KnowledgeTypeName, 50, conKnowledgeType.KnowledgeTypeName);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.CourseId, 8, conKnowledgeType.CourseId);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.UpdDate, 20, conKnowledgeType.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.UpdUser, 20, conKnowledgeType.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.Memo, 1000, conKnowledgeType.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objKnowledgeTypeEN.CourseId, 8, conKnowledgeType.CourseId);
 objKnowledgeTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.KnowledgeTypeName, 50, conKnowledgeType.KnowledgeTypeName);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.CourseId, 8, conKnowledgeType.CourseId);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.UpdDate, 20, conKnowledgeType.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.UpdUser, 20, conKnowledgeType.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.Memo, 1000, conKnowledgeType.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objKnowledgeTypeEN.CourseId, 8, conKnowledgeType.CourseId);
 objKnowledgeTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.KnowledgeTypeId, 4, conKnowledgeType.KnowledgeTypeId);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.KnowledgeTypeName, 50, conKnowledgeType.KnowledgeTypeName);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.CourseId, 8, conKnowledgeType.CourseId);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.UpdDate, 20, conKnowledgeType.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.UpdUser, 20, conKnowledgeType.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeTypeEN.Memo, 1000, conKnowledgeType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objKnowledgeTypeEN.KnowledgeTypeId, conKnowledgeType.KnowledgeTypeId);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeTypeEN.KnowledgeTypeName, conKnowledgeType.KnowledgeTypeName);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeTypeEN.CourseId, conKnowledgeType.CourseId);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeTypeEN.UpdDate, conKnowledgeType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeTypeEN.UpdUser, conKnowledgeType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeTypeEN.Memo, conKnowledgeType.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objKnowledgeTypeEN.CourseId, 8, conKnowledgeType.CourseId);
 objKnowledgeTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetKnowledgeTypeId()
{
//获取某学院所有专业信息
string strSQL = "select KnowledgeTypeId, KnowledgeTypeName from KnowledgeType ";
 clsSpecSQLforSql mySql = clsKnowledgeTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--KnowledgeType(知识点类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and KnowledgeTypeName = '{0}'", objKnowledgeTypeEN.KnowledgeTypeName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objKnowledgeTypeEN.CourseId);
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
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsKnowledgeTypeEN._CurrTabName);
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
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsKnowledgeTypeEN._CurrTabName, strCondition);
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
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}