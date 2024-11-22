
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_ViewpointDA
 表名:vzx_Viewpoint(01120856)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// vzx_Viewpoint(vzx_Viewpoint)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_ViewpointDA : clsCommBase4DA
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
 return clsvzx_ViewpointEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_ViewpointEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_ViewpointEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_ViewpointEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_ViewpointEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxViewpointId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxViewpointId)
{
strzxViewpointId = strzxViewpointId.Replace("'", "''");
if (strzxViewpointId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vzx_Viewpoint中,检查关键字,长度不正确!(clsvzx_ViewpointDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxViewpointId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_Viewpoint中,关键字不能为空 或 null!(clsvzx_ViewpointDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxViewpointId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_ViewpointDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_ViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Viewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_Viewpoint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_ViewpointDA: GetDataTable_vzx_Viewpoint)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Viewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_ViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_ViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Viewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_ViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_ViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Viewpoint where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Viewpoint where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_ViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_Viewpoint where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_ViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Viewpoint.* from vzx_Viewpoint Left Join {1} on {2} where {3} and vzx_Viewpoint.zxViewpointId not in (Select top {5} vzx_Viewpoint.zxViewpointId from vzx_Viewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Viewpoint where {1} and zxViewpointId not in (Select top {2} zxViewpointId from vzx_Viewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Viewpoint where {1} and zxViewpointId not in (Select top {3} zxViewpointId from vzx_Viewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_ViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Viewpoint.* from vzx_Viewpoint Left Join {1} on {2} where {3} and vzx_Viewpoint.zxViewpointId not in (Select top {5} vzx_Viewpoint.zxViewpointId from vzx_Viewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Viewpoint where {1} and zxViewpointId not in (Select top {2} zxViewpointId from vzx_Viewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Viewpoint where {1} and zxViewpointId not in (Select top {3} zxViewpointId from vzx_Viewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_ViewpointEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_ViewpointDA:GetObjLst)", objException.Message));
}
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Viewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = TransNullToBool(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_ViewpointDA: GetObjLst)", objException.Message));
}
objvzx_ViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_ViewpointEN);
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
public List<clsvzx_ViewpointEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_ViewpointDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = TransNullToBool(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_ViewpointDA: GetObjLst)", objException.Message));
}
objvzx_ViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_ViewpointEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_Viewpoint(ref clsvzx_ViewpointEN objvzx_ViewpointEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Viewpoint where zxViewpointId = " + "'"+ objvzx_ViewpointEN.zxViewpointId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_ViewpointEN.ViewpointTypeName = objDT.Rows[0][convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.zxViewpointId = objDT.Rows[0][convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvzx_ViewpointEN.ViewpointName = objDT.Rows[0][convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_ViewpointEN.ViewpointContent = objDT.Rows[0][convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_ViewpointEN.zxViewpointTypeId = objDT.Rows[0][convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.Reason = objDT.Rows[0][convzx_Viewpoint.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_ViewpointEN.Source = objDT.Rows[0][convzx_Viewpoint.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_ViewpointEN.VPProposePeople = objDT.Rows[0][convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_ViewpointEN.UserTypeId = objDT.Rows[0][convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvzx_ViewpointEN.TextId = objDT.Rows[0][convzx_Viewpoint.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ViewpointEN.VoteCount = TransNullToInt(objDT.Rows[0][convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.Score = TransNullToFloat(objDT.Rows[0][convzx_Viewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ViewpointEN.StuScore = TransNullToFloat(objDT.Rows[0][convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ViewpointEN.TeaScore = TransNullToFloat(objDT.Rows[0][convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ViewpointEN.IdCurrEduCls = objDT.Rows[0][convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ViewpointEN.PdfContent = objDT.Rows[0][convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_ViewpointEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.CitationCount = TransNullToInt(objDT.Rows[0][convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.VersionCount = TransNullToInt(objDT.Rows[0][convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.zxShareId = objDT.Rows[0][convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_ViewpointEN.CreateDate = objDT.Rows[0][convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ViewpointEN.UpdDate = objDT.Rows[0][convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ViewpointEN.UpdUser = objDT.Rows[0][convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ViewpointEN.Memo = objDT.Rows[0][convzx_Viewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_ViewpointEN.TeammenberId = objDT.Rows[0][convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ViewpointEN.PdfDivLet = objDT.Rows[0][convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.PdfDivTop = objDT.Rows[0][convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.PdfPageNumIn = objDT.Rows[0][convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.PdfPageTop = TransNullToInt(objDT.Rows[0][convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.PdfZoom = objDT.Rows[0][convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.GroupTextId = objDT.Rows[0][convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ViewpointEN.TextContent = objDT.Rows[0][convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_ViewpointEN.Author = objDT.Rows[0][convzx_Viewpoint.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_ViewpointEN.Keyword = objDT.Rows[0][convzx_Viewpoint.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_ViewpointDA: Getvzx_Viewpoint)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_ViewpointEN GetObjByzxViewpointId(string strzxViewpointId)
{
CheckPrimaryKey(strzxViewpointId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Viewpoint where zxViewpointId = " + "'"+ strzxViewpointId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
 objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_ViewpointDA: GetObjByzxViewpointId)", objException.Message));
}
return objvzx_ViewpointEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_ViewpointEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_ViewpointDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Viewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN()
{
ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(), //观点类型名
zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(), //观点Id
ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(), //观点名称
ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(), //观点内容
zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(), //观点类型Id
Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(), //理由
Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(), //来源
VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(), //观点提出人
IsSubmit = TransNullToBool(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()), //是否提交
UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(), //用户类型Id
TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(), //课件Id
VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()), //点赞计数
AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.Score].ToString().Trim()), //评分
StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()), //版本统计
zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(), //分享Id
CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(), //备注
TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(), //主键
PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(), //小组Id
TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(), //TextContent
Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(), //作者
Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim() //关键字
};
objvzx_ViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_ViewpointEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_ViewpointDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_ViewpointEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = TransNullToBool(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_ViewpointDA: GetObjByDataRowvzx_Viewpoint)", objException.Message));
}
objvzx_ViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_ViewpointEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_ViewpointEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = TransNullToBool(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_ViewpointDA: GetObjByDataRow)", objException.Message));
}
objvzx_ViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_ViewpointEN;
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
objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_ViewpointEN._CurrTabName, convzx_Viewpoint.zxViewpointId, 8, "");
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
objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_ViewpointEN._CurrTabName, convzx_Viewpoint.zxViewpointId, 8, strPrefix);
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
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxViewpointId from vzx_Viewpoint where " + strCondition;
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
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxViewpointId from vzx_Viewpoint where " + strCondition;
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
 /// <param name = "strzxViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxViewpointId)
{
CheckPrimaryKey(strzxViewpointId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Viewpoint", "zxViewpointId = " + "'"+ strzxViewpointId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_ViewpointDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Viewpoint", strCondition))
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
objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_Viewpoint");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_ViewpointENS">源对象</param>
 /// <param name = "objvzx_ViewpointENT">目标对象</param>
public void CopyTo(clsvzx_ViewpointEN objvzx_ViewpointENS, clsvzx_ViewpointEN objvzx_ViewpointENT)
{
objvzx_ViewpointENT.ViewpointTypeName = objvzx_ViewpointENS.ViewpointTypeName; //观点类型名
objvzx_ViewpointENT.zxViewpointId = objvzx_ViewpointENS.zxViewpointId; //观点Id
objvzx_ViewpointENT.ViewpointName = objvzx_ViewpointENS.ViewpointName; //观点名称
objvzx_ViewpointENT.ViewpointContent = objvzx_ViewpointENS.ViewpointContent; //观点内容
objvzx_ViewpointENT.zxViewpointTypeId = objvzx_ViewpointENS.zxViewpointTypeId; //观点类型Id
objvzx_ViewpointENT.Reason = objvzx_ViewpointENS.Reason; //理由
objvzx_ViewpointENT.Source = objvzx_ViewpointENS.Source; //来源
objvzx_ViewpointENT.VPProposePeople = objvzx_ViewpointENS.VPProposePeople; //观点提出人
objvzx_ViewpointENT.IsSubmit = objvzx_ViewpointENS.IsSubmit; //是否提交
objvzx_ViewpointENT.UserTypeId = objvzx_ViewpointENS.UserTypeId; //用户类型Id
objvzx_ViewpointENT.TextId = objvzx_ViewpointENS.TextId; //课件Id
objvzx_ViewpointENT.VoteCount = objvzx_ViewpointENS.VoteCount; //点赞计数
objvzx_ViewpointENT.AppraiseCount = objvzx_ViewpointENS.AppraiseCount; //评论数
objvzx_ViewpointENT.Score = objvzx_ViewpointENS.Score; //评分
objvzx_ViewpointENT.StuScore = objvzx_ViewpointENS.StuScore; //学生平均分
objvzx_ViewpointENT.TeaScore = objvzx_ViewpointENS.TeaScore; //教师评分
objvzx_ViewpointENT.IdCurrEduCls = objvzx_ViewpointENS.IdCurrEduCls; //教学班流水号
objvzx_ViewpointENT.PdfContent = objvzx_ViewpointENS.PdfContent; //Pdf内容
objvzx_ViewpointENT.PdfPageNum = objvzx_ViewpointENS.PdfPageNum; //Pdf页码
objvzx_ViewpointENT.CitationCount = objvzx_ViewpointENS.CitationCount; //引用统计
objvzx_ViewpointENT.VersionCount = objvzx_ViewpointENS.VersionCount; //版本统计
objvzx_ViewpointENT.zxShareId = objvzx_ViewpointENS.zxShareId; //分享Id
objvzx_ViewpointENT.CreateDate = objvzx_ViewpointENS.CreateDate; //建立日期
objvzx_ViewpointENT.UpdDate = objvzx_ViewpointENS.UpdDate; //修改日期
objvzx_ViewpointENT.UpdUser = objvzx_ViewpointENS.UpdUser; //修改人
objvzx_ViewpointENT.Memo = objvzx_ViewpointENS.Memo; //备注
objvzx_ViewpointENT.TeammenberId = objvzx_ViewpointENS.TeammenberId; //主键
objvzx_ViewpointENT.PdfDivLet = objvzx_ViewpointENS.PdfDivLet; //PdfDivLet
objvzx_ViewpointENT.PdfDivTop = objvzx_ViewpointENS.PdfDivTop; //PdfDivTop
objvzx_ViewpointENT.PdfPageNumIn = objvzx_ViewpointENS.PdfPageNumIn; //PdfPageNumIn
objvzx_ViewpointENT.PdfPageTop = objvzx_ViewpointENS.PdfPageTop; //pdf页面顶部位置
objvzx_ViewpointENT.PdfZoom = objvzx_ViewpointENS.PdfZoom; //PdfZoom
objvzx_ViewpointENT.GroupTextId = objvzx_ViewpointENS.GroupTextId; //小组Id
objvzx_ViewpointENT.TextContent = objvzx_ViewpointENS.TextContent; //TextContent
objvzx_ViewpointENT.Author = objvzx_ViewpointENS.Author; //作者
objvzx_ViewpointENT.Keyword = objvzx_ViewpointENS.Keyword; //关键字
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_ViewpointEN objvzx_ViewpointEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.ViewpointTypeName, 50, convzx_Viewpoint.ViewpointTypeName);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.zxViewpointId, 8, convzx_Viewpoint.zxViewpointId);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.ViewpointName, 500, convzx_Viewpoint.ViewpointName);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.zxViewpointTypeId, 4, convzx_Viewpoint.zxViewpointTypeId);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.Source, 500, convzx_Viewpoint.Source);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.VPProposePeople, 50, convzx_Viewpoint.VPProposePeople);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.UserTypeId, 2, convzx_Viewpoint.UserTypeId);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.TextId, 8, convzx_Viewpoint.TextId);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.IdCurrEduCls, 8, convzx_Viewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.PdfContent, 2000, convzx_Viewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.zxShareId, 2, convzx_Viewpoint.zxShareId);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.CreateDate, 20, convzx_Viewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.UpdDate, 20, convzx_Viewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.UpdUser, 20, convzx_Viewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.Memo, 1000, convzx_Viewpoint.Memo);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.TeammenberId, 8, convzx_Viewpoint.TeammenberId);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.PdfDivLet, 50, convzx_Viewpoint.PdfDivLet);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.PdfDivTop, 50, convzx_Viewpoint.PdfDivTop);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.PdfPageNumIn, 50, convzx_Viewpoint.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.PdfZoom, 50, convzx_Viewpoint.PdfZoom);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.GroupTextId, 8, convzx_Viewpoint.GroupTextId);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.Author, 200, convzx_Viewpoint.Author);
clsCheckSql.CheckFieldLen(objvzx_ViewpointEN.Keyword, 1000, convzx_Viewpoint.Keyword);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.ViewpointTypeName, convzx_Viewpoint.ViewpointTypeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.zxViewpointId, convzx_Viewpoint.zxViewpointId);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.ViewpointName, convzx_Viewpoint.ViewpointName);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.zxViewpointTypeId, convzx_Viewpoint.zxViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.Source, convzx_Viewpoint.Source);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.VPProposePeople, convzx_Viewpoint.VPProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.UserTypeId, convzx_Viewpoint.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.TextId, convzx_Viewpoint.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.IdCurrEduCls, convzx_Viewpoint.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.PdfContent, convzx_Viewpoint.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.zxShareId, convzx_Viewpoint.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.CreateDate, convzx_Viewpoint.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.UpdDate, convzx_Viewpoint.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.UpdUser, convzx_Viewpoint.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.Memo, convzx_Viewpoint.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.TeammenberId, convzx_Viewpoint.TeammenberId);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.PdfDivLet, convzx_Viewpoint.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.PdfDivTop, convzx_Viewpoint.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.PdfPageNumIn, convzx_Viewpoint.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.PdfZoom, convzx_Viewpoint.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.GroupTextId, convzx_Viewpoint.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.Author, convzx_Viewpoint.Author);
clsCheckSql.CheckSqlInjection4Field(objvzx_ViewpointEN.Keyword, convzx_Viewpoint.Keyword);
//检查外键字段长度
 objvzx_ViewpointEN._IsCheckProperty = true;
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
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
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
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
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
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_ViewpointEN._CurrTabName);
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
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_ViewpointEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_ViewpointDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}