
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointDA
 表名:vViewpoint(01120543)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:37:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// v观点表视图(vViewpoint)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewpointDA : clsCommBase4DA
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
 return clsvViewpointEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewpointEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewpointEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvViewpointEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewpointEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strViewpointId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strViewpointId)
{
strViewpointId = strViewpointId.Replace("'", "''");
if (strViewpointId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vViewpoint中,检查关键字,长度不正确!(clsvViewpointDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewpointId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vViewpoint中,关键字不能为空 或 null!(clsvViewpointDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewpointId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvViewpointDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewpoint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewpointDA: GetDataTable_vViewpoint)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vViewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vViewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewpoint where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewpoint where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewpoint where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vViewpoint.* from vViewpoint Left Join {1} on {2} where {3} and vViewpoint.ViewpointId not in (Select top {5} vViewpoint.ViewpointId from vViewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewpoint where {1} and ViewpointId not in (Select top {2} ViewpointId from vViewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewpoint where {1} and ViewpointId not in (Select top {3} ViewpointId from vViewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vViewpoint.* from vViewpoint Left Join {1} on {2} where {3} and vViewpoint.ViewpointId not in (Select top {5} vViewpoint.ViewpointId from vViewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewpoint where {1} and ViewpointId not in (Select top {2} ViewpointId from vViewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewpoint where {1} and ViewpointId not in (Select top {3} ViewpointId from vViewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvViewpointEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewpointDA:GetObjLst)", objException.Message));
}
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = TransNullToBool(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = TransNullToBool(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewpointDA: GetObjLst)", objException.Message));
}
objvViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewpointEN);
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
public List<clsvViewpointEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewpointDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = TransNullToBool(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = TransNullToBool(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewpointDA: GetObjLst)", objException.Message));
}
objvViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewpointEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewpointEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewpoint(ref clsvViewpointEN objvViewpointEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vViewpoint where ViewpointId = " + "'"+ objvViewpointEN.ViewpointId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewpointEN.ViewpointId = objDT.Rows[0][convViewpoint.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointEN.ViewpointName = objDT.Rows[0][convViewpoint.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointEN.ViewpointContent = objDT.Rows[0][convViewpoint.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointEN.ViewpointTypeId = objDT.Rows[0][convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvViewpointEN.ViewpointTypeName = objDT.Rows[0][convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointEN.Reason = objDT.Rows[0][convViewpoint.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointEN.Source = objDT.Rows[0][convViewpoint.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointEN.VPProposePeople = objDT.Rows[0][convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointEN.UpdDate = objDT.Rows[0][convViewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointEN.UpdUser = objDT.Rows[0][convViewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointEN.Memo = objDT.Rows[0][convViewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewpointEN.IsSubmit = TransNullToBool(objDT.Rows[0][convViewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvViewpointEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convViewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvViewpointEN.Score = TransNullToFloat(objDT.Rows[0][convViewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvViewpointEN.OkCount = TransNullToInt(objDT.Rows[0][convViewpoint.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvViewpointEN.UserTypeId = objDT.Rows[0][convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvViewpointEN.UserTypeName = objDT.Rows[0][convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointEN.Author = objDT.Rows[0][convViewpoint.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvViewpointEN.CitationId = objDT.Rows[0][convViewpoint.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointEN.Keyword = objDT.Rows[0][convViewpoint.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewpointEN.PaperTitle = objDT.Rows[0][convViewpoint.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewpointEN.Periodical = objDT.Rows[0][convViewpoint.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewpointEN.ResearchQuestion = objDT.Rows[0][convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvViewpointEN.UploadfileUrl = objDT.Rows[0][convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewpointEN.CitationCount = TransNullToInt(objDT.Rows[0][convViewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvViewpointEN.StuScore = TransNullToFloat(objDT.Rows[0][convViewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvViewpointEN.TeaScore = TransNullToFloat(objDT.Rows[0][convViewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvViewpointEN.IdCurrEduCls = objDT.Rows[0][convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvViewpointEN.PdfContent = objDT.Rows[0][convViewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvViewpointEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvViewpointEN.VersionCount = TransNullToInt(objDT.Rows[0][convViewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvViewpointEN.CreateDate = objDT.Rows[0][convViewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointEN.ShareId = objDT.Rows[0][convViewpoint.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvViewpointEN.IsRecommend = TransNullToBool(objDT.Rows[0][convViewpoint.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewpointDA: GetvViewpoint)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewpointEN GetObjByViewpointId(string strViewpointId)
{
CheckPrimaryKey(strViewpointId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vViewpoint where ViewpointId = " + "'"+ strViewpointId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
 objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewpointDA: GetObjByViewpointId)", objException.Message));
}
return objvViewpointEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewpointEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewpointDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN()
{
ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(), //观点Id
ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(), //观点名称
ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(), //观点内容
ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(), //观点类型Id
ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(), //观点类型名
Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(), //理由
Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(), //来源
VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(), //观点提出人
UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(), //备注
IsSubmit = TransNullToBool(objRow[convViewpoint.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.Score].ToString().Trim()), //评分
OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.OkCount].ToString().Trim()), //点赞统计
UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(), //用户类型名称
Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(), //作者
CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(), //引用Id
Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(), //关键字
PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(), //论文标题
Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(), //期刊
ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(), //研究问题
UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(), //文件地址
CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.CitationCount].ToString().Trim()), //引用统计
StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.PdfPageNum].ToString().Trim()), //Pdf页码
VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.VersionCount].ToString().Trim()), //版本统计
CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(), //分享Id
IsRecommend = TransNullToBool(objRow[convViewpoint.IsRecommend].ToString().Trim()) //是否推荐
};
objvViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewpointEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewpointDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewpointEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = TransNullToBool(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = TransNullToBool(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewpointDA: GetObjByDataRowvViewpoint)", objException.Message));
}
objvViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewpointEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewpointEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = TransNullToBool(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = TransNullToBool(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewpointDA: GetObjByDataRow)", objException.Message));
}
objvViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewpointEN;
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
objSQL = clsvViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewpointEN._CurrTabName, convViewpoint.ViewpointId, 8, "");
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
objSQL = clsvViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewpointEN._CurrTabName, convViewpoint.ViewpointId, 8, strPrefix);
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
 objSQL = clsvViewpointDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewpointId from vViewpoint where " + strCondition;
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
 objSQL = clsvViewpointDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewpointId from vViewpoint where " + strCondition;
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
 /// <param name = "strViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strViewpointId)
{
CheckPrimaryKey(strViewpointId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewpoint", "ViewpointId = " + "'"+ strViewpointId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewpointDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewpoint", strCondition))
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
objSQL = clsvViewpointDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewpoint");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvViewpointENS">源对象</param>
 /// <param name = "objvViewpointENT">目标对象</param>
public void CopyTo(clsvViewpointEN objvViewpointENS, clsvViewpointEN objvViewpointENT)
{
objvViewpointENT.ViewpointId = objvViewpointENS.ViewpointId; //观点Id
objvViewpointENT.ViewpointName = objvViewpointENS.ViewpointName; //观点名称
objvViewpointENT.ViewpointContent = objvViewpointENS.ViewpointContent; //观点内容
objvViewpointENT.ViewpointTypeId = objvViewpointENS.ViewpointTypeId; //观点类型Id
objvViewpointENT.ViewpointTypeName = objvViewpointENS.ViewpointTypeName; //观点类型名
objvViewpointENT.Reason = objvViewpointENS.Reason; //理由
objvViewpointENT.Source = objvViewpointENS.Source; //来源
objvViewpointENT.VPProposePeople = objvViewpointENS.VPProposePeople; //观点提出人
objvViewpointENT.UpdDate = objvViewpointENS.UpdDate; //修改日期
objvViewpointENT.UpdUser = objvViewpointENS.UpdUser; //修改人
objvViewpointENT.Memo = objvViewpointENS.Memo; //备注
objvViewpointENT.IsSubmit = objvViewpointENS.IsSubmit; //是否提交
objvViewpointENT.AppraiseCount = objvViewpointENS.AppraiseCount; //评论数
objvViewpointENT.Score = objvViewpointENS.Score; //评分
objvViewpointENT.OkCount = objvViewpointENS.OkCount; //点赞统计
objvViewpointENT.UserTypeId = objvViewpointENS.UserTypeId; //用户类型Id
objvViewpointENT.UserTypeName = objvViewpointENS.UserTypeName; //用户类型名称
objvViewpointENT.Author = objvViewpointENS.Author; //作者
objvViewpointENT.CitationId = objvViewpointENS.CitationId; //引用Id
objvViewpointENT.Keyword = objvViewpointENS.Keyword; //关键字
objvViewpointENT.PaperTitle = objvViewpointENS.PaperTitle; //论文标题
objvViewpointENT.Periodical = objvViewpointENS.Periodical; //期刊
objvViewpointENT.ResearchQuestion = objvViewpointENS.ResearchQuestion; //研究问题
objvViewpointENT.UploadfileUrl = objvViewpointENS.UploadfileUrl; //文件地址
objvViewpointENT.CitationCount = objvViewpointENS.CitationCount; //引用统计
objvViewpointENT.StuScore = objvViewpointENS.StuScore; //学生平均分
objvViewpointENT.TeaScore = objvViewpointENS.TeaScore; //教师评分
objvViewpointENT.IdCurrEduCls = objvViewpointENS.IdCurrEduCls; //教学班流水号
objvViewpointENT.PdfContent = objvViewpointENS.PdfContent; //Pdf内容
objvViewpointENT.PdfPageNum = objvViewpointENS.PdfPageNum; //Pdf页码
objvViewpointENT.VersionCount = objvViewpointENS.VersionCount; //版本统计
objvViewpointENT.CreateDate = objvViewpointENS.CreateDate; //建立日期
objvViewpointENT.ShareId = objvViewpointENS.ShareId; //分享Id
objvViewpointENT.IsRecommend = objvViewpointENS.IsRecommend; //是否推荐
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewpointEN objvViewpointEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewpointEN.ViewpointId, 8, convViewpoint.ViewpointId);
clsCheckSql.CheckFieldLen(objvViewpointEN.ViewpointName, 500, convViewpoint.ViewpointName);
clsCheckSql.CheckFieldLen(objvViewpointEN.ViewpointTypeId, 4, convViewpoint.ViewpointTypeId);
clsCheckSql.CheckFieldLen(objvViewpointEN.ViewpointTypeName, 50, convViewpoint.ViewpointTypeName);
clsCheckSql.CheckFieldLen(objvViewpointEN.Source, 500, convViewpoint.Source);
clsCheckSql.CheckFieldLen(objvViewpointEN.VPProposePeople, 50, convViewpoint.VPProposePeople);
clsCheckSql.CheckFieldLen(objvViewpointEN.UpdDate, 20, convViewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objvViewpointEN.UpdUser, 20, convViewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objvViewpointEN.Memo, 1000, convViewpoint.Memo);
clsCheckSql.CheckFieldLen(objvViewpointEN.UserTypeId, 2, convViewpoint.UserTypeId);
clsCheckSql.CheckFieldLen(objvViewpointEN.UserTypeName, 20, convViewpoint.UserTypeName);
clsCheckSql.CheckFieldLen(objvViewpointEN.Author, 200, convViewpoint.Author);
clsCheckSql.CheckFieldLen(objvViewpointEN.CitationId, 8, convViewpoint.CitationId);
clsCheckSql.CheckFieldLen(objvViewpointEN.Keyword, 1000, convViewpoint.Keyword);
clsCheckSql.CheckFieldLen(objvViewpointEN.PaperTitle, 500, convViewpoint.PaperTitle);
clsCheckSql.CheckFieldLen(objvViewpointEN.Periodical, 100, convViewpoint.Periodical);
clsCheckSql.CheckFieldLen(objvViewpointEN.ResearchQuestion, 2000, convViewpoint.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvViewpointEN.UploadfileUrl, 1000, convViewpoint.UploadfileUrl);
clsCheckSql.CheckFieldLen(objvViewpointEN.IdCurrEduCls, 8, convViewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvViewpointEN.PdfContent, 2000, convViewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objvViewpointEN.CreateDate, 20, convViewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objvViewpointEN.ShareId, 2, convViewpoint.ShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.ViewpointId, convViewpoint.ViewpointId);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.ViewpointName, convViewpoint.ViewpointName);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.ViewpointTypeId, convViewpoint.ViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.ViewpointTypeName, convViewpoint.ViewpointTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.Source, convViewpoint.Source);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.VPProposePeople, convViewpoint.VPProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.UpdDate, convViewpoint.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.UpdUser, convViewpoint.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.Memo, convViewpoint.Memo);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.UserTypeId, convViewpoint.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.UserTypeName, convViewpoint.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.Author, convViewpoint.Author);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.CitationId, convViewpoint.CitationId);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.Keyword, convViewpoint.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.PaperTitle, convViewpoint.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.Periodical, convViewpoint.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.ResearchQuestion, convViewpoint.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.UploadfileUrl, convViewpoint.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.IdCurrEduCls, convViewpoint.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.PdfContent, convViewpoint.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.CreateDate, convViewpoint.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvViewpointEN.ShareId, convViewpoint.ShareId);
//检查外键字段长度
 objvViewpointEN._IsCheckProperty = true;
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
 objSQL = clsvViewpointDA.GetSpecSQLObj();
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
 objSQL = clsvViewpointDA.GetSpecSQLObj();
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
 objSQL = clsvViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewpointEN._CurrTabName);
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
 objSQL = clsvViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewpointEN._CurrTabName, strCondition);
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
 objSQL = clsvViewpointDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}