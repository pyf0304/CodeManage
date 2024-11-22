
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_GroupTextRelaDA
 表名:vzx_GroupTextRela(01120867)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 小组课文关系视图(vzx_GroupTextRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_GroupTextRelaDA : clsCommBase4DA
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
 return clsvzx_GroupTextRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_GroupTextRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_GroupTextRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_GroupTextRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_GroupTextRelaEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strGroupTextRelaId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strGroupTextRelaId)
{
strGroupTextRelaId = strGroupTextRelaId.Replace("'", "''");
if (strGroupTextRelaId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vzx_GroupTextRela中,检查关键字,长度不正确!(clsvzx_GroupTextRelaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strGroupTextRelaId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_GroupTextRela中,关键字不能为空 或 null!(clsvzx_GroupTextRelaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGroupTextRelaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_GroupTextRelaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupTextRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_GroupTextRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA: GetDataTable_vzx_GroupTextRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupTextRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupTextRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupTextRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupTextRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_GroupTextRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_GroupTextRela.* from vzx_GroupTextRela Left Join {1} on {2} where {3} and vzx_GroupTextRela.GroupTextRelaId not in (Select top {5} vzx_GroupTextRela.GroupTextRelaId from vzx_GroupTextRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupTextRela where {1} and GroupTextRelaId not in (Select top {2} GroupTextRelaId from vzx_GroupTextRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupTextRela where {1} and GroupTextRelaId not in (Select top {3} GroupTextRelaId from vzx_GroupTextRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_GroupTextRela.* from vzx_GroupTextRela Left Join {1} on {2} where {3} and vzx_GroupTextRela.GroupTextRelaId not in (Select top {5} vzx_GroupTextRela.GroupTextRelaId from vzx_GroupTextRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupTextRela where {1} and GroupTextRelaId not in (Select top {2} GroupTextRelaId from vzx_GroupTextRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_GroupTextRela where {1} and GroupTextRelaId not in (Select top {3} GroupTextRelaId from vzx_GroupTextRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_GroupTextRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA:GetObjLst)", objException.Message));
}
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupTextRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = TransNullToBool(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_GroupTextRelaDA: GetObjLst)", objException.Message));
}
objvzx_GroupTextRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_GroupTextRelaEN);
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
public List<clsvzx_GroupTextRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = TransNullToBool(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_GroupTextRelaDA: GetObjLst)", objException.Message));
}
objvzx_GroupTextRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_GroupTextRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_GroupTextRela(ref clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupTextRela where GroupTextRelaId = " + "'"+ objvzx_GroupTextRelaEN.GroupTextRelaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_GroupTextRelaEN.UpdDate = objDT.Rows[0][convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_GroupTextRelaEN.Memo = objDT.Rows[0][convzx_GroupTextRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_GroupTextRelaEN.UpdUser = objDT.Rows[0][convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_GroupTextRelaEN.TextId = objDT.Rows[0][convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_GroupTextRelaEN.GroupTextId = objDT.Rows[0][convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_GroupTextRelaEN.GroupTextRelaId = objDT.Rows[0][convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键(字段类型:char,字段长度:8,是否可空:True)
 objvzx_GroupTextRelaEN.GroupTextName = objDT.Rows[0][convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_GroupTextRelaEN.IdCurrEduCls = objDT.Rows[0][convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_GroupTextRelaEN.zxShareId = objDT.Rows[0][convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_GroupTextRelaEN.TextTitle = objDT.Rows[0][convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_GroupTextRelaEN.TextContent = objDT.Rows[0][convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_GroupTextRelaEN.Author = objDT.Rows[0][convzx_GroupTextRela.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_GroupTextRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_GroupTextRelaEN.TextTypeId = objDT.Rows[0][convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId(字段类型:char,字段长度:2,是否可空:True)
 objvzx_GroupTextRelaEN.TextStatusId = objDT.Rows[0][convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId(字段类型:char,字段长度:2,是否可空:True)
 objvzx_GroupTextRelaEN.TextDate = objDT.Rows[0][convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_GroupTextRelaEN.TextUserId = objDT.Rows[0][convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_GroupTextRelaDA: Getvzx_GroupTextRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strGroupTextRelaId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_GroupTextRelaEN GetObjByGroupTextRelaId(string strGroupTextRelaId)
{
CheckPrimaryKey(strGroupTextRelaId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupTextRela where GroupTextRelaId = " + "'"+ strGroupTextRelaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
 objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键(字段类型:char,字段长度:8,是否可空:True)
 objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_GroupTextRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId(字段类型:char,字段长度:2,是否可空:True)
 objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId(字段类型:char,字段长度:2,是否可空:True)
 objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_GroupTextRelaDA: GetObjByGroupTextRelaId)", objException.Message));
}
return objvzx_GroupTextRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_GroupTextRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
strSQL = "Select * from vzx_GroupTextRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN()
{
UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(), //备注
UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(), //修改人
TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(), //课件Id
GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(), //小组Id
GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(), //主键
GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(), //小组名称
IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(), //分享Id
TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(), //TextTitle
TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(), //TextContent
Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(), //作者
IsSubmit = TransNullToBool(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()), //是否提交
TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(), //TextTypeId
TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(), //TextStatusId
TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(), //TextDate
TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim() //TextUserId
};
objvzx_GroupTextRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_GroupTextRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_GroupTextRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_GroupTextRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = TransNullToBool(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_GroupTextRelaDA: GetObjByDataRowvzx_GroupTextRela)", objException.Message));
}
objvzx_GroupTextRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_GroupTextRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_GroupTextRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = TransNullToBool(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_GroupTextRelaDA: GetObjByDataRow)", objException.Message));
}
objvzx_GroupTextRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_GroupTextRelaEN;
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
objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_GroupTextRelaEN._CurrTabName, convzx_GroupTextRela.GroupTextRelaId, 8, "");
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
objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_GroupTextRelaEN._CurrTabName, convzx_GroupTextRela.GroupTextRelaId, 8, strPrefix);
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
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select GroupTextRelaId from vzx_GroupTextRela where " + strCondition;
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
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select GroupTextRelaId from vzx_GroupTextRela where " + strCondition;
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
 /// <param name = "strGroupTextRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strGroupTextRelaId)
{
CheckPrimaryKey(strGroupTextRelaId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_GroupTextRela", "GroupTextRelaId = " + "'"+ strGroupTextRelaId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_GroupTextRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_GroupTextRela", strCondition))
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
objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_GroupTextRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaENS">源对象</param>
 /// <param name = "objvzx_GroupTextRelaENT">目标对象</param>
public void CopyTo(clsvzx_GroupTextRelaEN objvzx_GroupTextRelaENS, clsvzx_GroupTextRelaEN objvzx_GroupTextRelaENT)
{
objvzx_GroupTextRelaENT.UpdDate = objvzx_GroupTextRelaENS.UpdDate; //修改日期
objvzx_GroupTextRelaENT.Memo = objvzx_GroupTextRelaENS.Memo; //备注
objvzx_GroupTextRelaENT.UpdUser = objvzx_GroupTextRelaENS.UpdUser; //修改人
objvzx_GroupTextRelaENT.TextId = objvzx_GroupTextRelaENS.TextId; //课件Id
objvzx_GroupTextRelaENT.GroupTextId = objvzx_GroupTextRelaENS.GroupTextId; //小组Id
objvzx_GroupTextRelaENT.GroupTextRelaId = objvzx_GroupTextRelaENS.GroupTextRelaId; //主键
objvzx_GroupTextRelaENT.GroupTextName = objvzx_GroupTextRelaENS.GroupTextName; //小组名称
objvzx_GroupTextRelaENT.IdCurrEduCls = objvzx_GroupTextRelaENS.IdCurrEduCls; //教学班流水号
objvzx_GroupTextRelaENT.zxShareId = objvzx_GroupTextRelaENS.zxShareId; //分享Id
objvzx_GroupTextRelaENT.TextTitle = objvzx_GroupTextRelaENS.TextTitle; //TextTitle
objvzx_GroupTextRelaENT.TextContent = objvzx_GroupTextRelaENS.TextContent; //TextContent
objvzx_GroupTextRelaENT.Author = objvzx_GroupTextRelaENS.Author; //作者
objvzx_GroupTextRelaENT.IsSubmit = objvzx_GroupTextRelaENS.IsSubmit; //是否提交
objvzx_GroupTextRelaENT.TextTypeId = objvzx_GroupTextRelaENS.TextTypeId; //TextTypeId
objvzx_GroupTextRelaENT.TextStatusId = objvzx_GroupTextRelaENS.TextStatusId; //TextStatusId
objvzx_GroupTextRelaENT.TextDate = objvzx_GroupTextRelaENS.TextDate; //TextDate
objvzx_GroupTextRelaENT.TextUserId = objvzx_GroupTextRelaENS.TextUserId; //TextUserId
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.UpdDate, 20, convzx_GroupTextRela.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.Memo, 1000, convzx_GroupTextRela.Memo);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.UpdUser, 20, convzx_GroupTextRela.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.TextId, 8, convzx_GroupTextRela.TextId);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.GroupTextId, 8, convzx_GroupTextRela.GroupTextId);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.GroupTextRelaId, 8, convzx_GroupTextRela.GroupTextRelaId);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.GroupTextName, 2000, convzx_GroupTextRela.GroupTextName);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.IdCurrEduCls, 8, convzx_GroupTextRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.zxShareId, 2, convzx_GroupTextRela.zxShareId);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.TextTitle, 500, convzx_GroupTextRela.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.Author, 200, convzx_GroupTextRela.Author);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.TextTypeId, 2, convzx_GroupTextRela.TextTypeId);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.TextStatusId, 2, convzx_GroupTextRela.TextStatusId);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.TextDate, 50, convzx_GroupTextRela.TextDate);
clsCheckSql.CheckFieldLen(objvzx_GroupTextRelaEN.TextUserId, 20, convzx_GroupTextRela.TextUserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.UpdDate, convzx_GroupTextRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.Memo, convzx_GroupTextRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.UpdUser, convzx_GroupTextRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.TextId, convzx_GroupTextRela.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.GroupTextId, convzx_GroupTextRela.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.GroupTextRelaId, convzx_GroupTextRela.GroupTextRelaId);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.GroupTextName, convzx_GroupTextRela.GroupTextName);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.IdCurrEduCls, convzx_GroupTextRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.zxShareId, convzx_GroupTextRela.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.TextTitle, convzx_GroupTextRela.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.Author, convzx_GroupTextRela.Author);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.TextTypeId, convzx_GroupTextRela.TextTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.TextStatusId, convzx_GroupTextRela.TextStatusId);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.TextDate, convzx_GroupTextRela.TextDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_GroupTextRelaEN.TextUserId, convzx_GroupTextRela.TextUserId);
//检查外键字段长度
 objvzx_GroupTextRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vzx_GroupTextRela(小组课文关系视图),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and GroupTextRelaId = '{0}'", objvzx_GroupTextRelaEN.GroupTextRelaId);
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
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
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
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
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
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_GroupTextRelaEN._CurrTabName);
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
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_GroupTextRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_GroupTextRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}