
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewpointDA
 表名:Viewpoint(01120542)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:41
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
 /// 观点表(Viewpoint)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewpointDA : clsCommBase4DA
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
 return clsViewpointEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewpointEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewpointEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewpointEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewpointEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:Viewpoint中,检查关键字,长度不正确!(clsViewpointDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewpointId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Viewpoint中,关键字不能为空 或 null!(clsViewpointDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewpointId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsViewpointDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
strSQL = "Select * from Viewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Viewpoint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewpointDA: GetDataTable_Viewpoint)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
strSQL = "Select * from Viewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
strSQL = "Select * from Viewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Viewpoint where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Viewpoint where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Viewpoint where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Viewpoint.* from Viewpoint Left Join {1} on {2} where {3} and Viewpoint.ViewpointId not in (Select top {5} Viewpoint.ViewpointId from Viewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Viewpoint where {1} and ViewpointId not in (Select top {2} ViewpointId from Viewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Viewpoint where {1} and ViewpointId not in (Select top {3} ViewpointId from Viewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Viewpoint.* from Viewpoint Left Join {1} on {2} where {3} and Viewpoint.ViewpointId not in (Select top {5} Viewpoint.ViewpointId from Viewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Viewpoint where {1} and ViewpointId not in (Select top {2} ViewpointId from Viewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Viewpoint where {1} and ViewpointId not in (Select top {3} ViewpointId from Viewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewpointEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewpointDA:GetObjLst)", objException.Message));
}
List<clsViewpointEN> arrObjLst = new List<clsViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
strSQL = "Select * from Viewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointEN objViewpointEN = new clsViewpointEN();
try
{
objViewpointEN.ViewpointId = objRow[conViewpoint.ViewpointId].ToString().Trim(); //观点Id
objViewpointEN.ViewpointName = objRow[conViewpoint.ViewpointName] == DBNull.Value ? null : objRow[conViewpoint.ViewpointName].ToString().Trim(); //观点名称
objViewpointEN.ViewpointContent = objRow[conViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objViewpointEN.ViewpointTypeId = objRow[conViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointEN.Reason = objRow[conViewpoint.Reason] == DBNull.Value ? null : objRow[conViewpoint.Reason].ToString().Trim(); //理由
objViewpointEN.Source = objRow[conViewpoint.Source] == DBNull.Value ? null : objRow[conViewpoint.Source].ToString().Trim(); //来源
objViewpointEN.VPProposePeople = objRow[conViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointEN.IsSubmit = TransNullToBool(objRow[conViewpoint.IsSubmit].ToString().Trim()); //是否提交
objViewpointEN.UserTypeId = objRow[conViewpoint.UserTypeId] == DBNull.Value ? null : objRow[conViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointEN.CitationId = objRow[conViewpoint.CitationId] == DBNull.Value ? null : objRow[conViewpoint.CitationId].ToString().Trim(); //引用Id
objViewpointEN.AppraiseCount = objRow[conViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.AppraiseCount].ToString().Trim()); //评论数
objViewpointEN.OkCount = objRow[conViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.OkCount].ToString().Trim()); //点赞统计
objViewpointEN.Score = objRow[conViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.Score].ToString().Trim()); //评分
objViewpointEN.StuScore = objRow[conViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.StuScore].ToString().Trim()); //学生平均分
objViewpointEN.TeaScore = objRow[conViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.TeaScore].ToString().Trim()); //教师评分
objViewpointEN.PdfContent = objRow[conViewpoint.PdfContent] == DBNull.Value ? null : objRow[conViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objViewpointEN.PdfPageNum = objRow[conViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointEN.CitationCount = objRow[conViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.CitationCount].ToString().Trim()); //引用统计
objViewpointEN.VersionCount = objRow[conViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.VersionCount].ToString().Trim()); //版本统计
objViewpointEN.CreateDate = objRow[conViewpoint.CreateDate] == DBNull.Value ? null : objRow[conViewpoint.CreateDate].ToString().Trim(); //建立日期
objViewpointEN.ShareId = objRow[conViewpoint.ShareId] == DBNull.Value ? null : objRow[conViewpoint.ShareId].ToString().Trim(); //分享Id
objViewpointEN.IsRecommend = TransNullToBool(objRow[conViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objViewpointEN.IdCurrEduCls = objRow[conViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointEN.CourseId = objRow[conViewpoint.CourseId] == DBNull.Value ? null : objRow[conViewpoint.CourseId].ToString().Trim(); //课程Id
objViewpointEN.UpdUser = objRow[conViewpoint.UpdUser] == DBNull.Value ? null : objRow[conViewpoint.UpdUser].ToString().Trim(); //修改人
objViewpointEN.UpdDate = objRow[conViewpoint.UpdDate] == DBNull.Value ? null : objRow[conViewpoint.UpdDate].ToString().Trim(); //修改日期
objViewpointEN.Memo = objRow[conViewpoint.Memo] == DBNull.Value ? null : objRow[conViewpoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewpointDA: GetObjLst)", objException.Message));
}
objViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewpointEN);
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
public List<clsViewpointEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewpointDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewpointEN> arrObjLst = new List<clsViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointEN objViewpointEN = new clsViewpointEN();
try
{
objViewpointEN.ViewpointId = objRow[conViewpoint.ViewpointId].ToString().Trim(); //观点Id
objViewpointEN.ViewpointName = objRow[conViewpoint.ViewpointName] == DBNull.Value ? null : objRow[conViewpoint.ViewpointName].ToString().Trim(); //观点名称
objViewpointEN.ViewpointContent = objRow[conViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objViewpointEN.ViewpointTypeId = objRow[conViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointEN.Reason = objRow[conViewpoint.Reason] == DBNull.Value ? null : objRow[conViewpoint.Reason].ToString().Trim(); //理由
objViewpointEN.Source = objRow[conViewpoint.Source] == DBNull.Value ? null : objRow[conViewpoint.Source].ToString().Trim(); //来源
objViewpointEN.VPProposePeople = objRow[conViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointEN.IsSubmit = TransNullToBool(objRow[conViewpoint.IsSubmit].ToString().Trim()); //是否提交
objViewpointEN.UserTypeId = objRow[conViewpoint.UserTypeId] == DBNull.Value ? null : objRow[conViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointEN.CitationId = objRow[conViewpoint.CitationId] == DBNull.Value ? null : objRow[conViewpoint.CitationId].ToString().Trim(); //引用Id
objViewpointEN.AppraiseCount = objRow[conViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.AppraiseCount].ToString().Trim()); //评论数
objViewpointEN.OkCount = objRow[conViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.OkCount].ToString().Trim()); //点赞统计
objViewpointEN.Score = objRow[conViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.Score].ToString().Trim()); //评分
objViewpointEN.StuScore = objRow[conViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.StuScore].ToString().Trim()); //学生平均分
objViewpointEN.TeaScore = objRow[conViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.TeaScore].ToString().Trim()); //教师评分
objViewpointEN.PdfContent = objRow[conViewpoint.PdfContent] == DBNull.Value ? null : objRow[conViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objViewpointEN.PdfPageNum = objRow[conViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointEN.CitationCount = objRow[conViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.CitationCount].ToString().Trim()); //引用统计
objViewpointEN.VersionCount = objRow[conViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.VersionCount].ToString().Trim()); //版本统计
objViewpointEN.CreateDate = objRow[conViewpoint.CreateDate] == DBNull.Value ? null : objRow[conViewpoint.CreateDate].ToString().Trim(); //建立日期
objViewpointEN.ShareId = objRow[conViewpoint.ShareId] == DBNull.Value ? null : objRow[conViewpoint.ShareId].ToString().Trim(); //分享Id
objViewpointEN.IsRecommend = TransNullToBool(objRow[conViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objViewpointEN.IdCurrEduCls = objRow[conViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointEN.CourseId = objRow[conViewpoint.CourseId] == DBNull.Value ? null : objRow[conViewpoint.CourseId].ToString().Trim(); //课程Id
objViewpointEN.UpdUser = objRow[conViewpoint.UpdUser] == DBNull.Value ? null : objRow[conViewpoint.UpdUser].ToString().Trim(); //修改人
objViewpointEN.UpdDate = objRow[conViewpoint.UpdDate] == DBNull.Value ? null : objRow[conViewpoint.UpdDate].ToString().Trim(); //修改日期
objViewpointEN.Memo = objRow[conViewpoint.Memo] == DBNull.Value ? null : objRow[conViewpoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewpointDA: GetObjLst)", objException.Message));
}
objViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewpointEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewpointEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewpoint(ref clsViewpointEN objViewpointEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
strSQL = "Select * from Viewpoint where ViewpointId = " + "'"+ objViewpointEN.ViewpointId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewpointEN.ViewpointId = objDT.Rows[0][conViewpoint.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objViewpointEN.ViewpointName = objDT.Rows[0][conViewpoint.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objViewpointEN.ViewpointContent = objDT.Rows[0][conViewpoint.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objViewpointEN.ViewpointTypeId = objDT.Rows[0][conViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objViewpointEN.Reason = objDT.Rows[0][conViewpoint.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objViewpointEN.Source = objDT.Rows[0][conViewpoint.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objViewpointEN.VPProposePeople = objDT.Rows[0][conViewpoint.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objViewpointEN.IsSubmit = TransNullToBool(objDT.Rows[0][conViewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objViewpointEN.UserTypeId = objDT.Rows[0][conViewpoint.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objViewpointEN.CitationId = objDT.Rows[0][conViewpoint.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objViewpointEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conViewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objViewpointEN.OkCount = TransNullToInt(objDT.Rows[0][conViewpoint.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objViewpointEN.Score = TransNullToFloat(objDT.Rows[0][conViewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objViewpointEN.StuScore = TransNullToFloat(objDT.Rows[0][conViewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objViewpointEN.TeaScore = TransNullToFloat(objDT.Rows[0][conViewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objViewpointEN.PdfContent = objDT.Rows[0][conViewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objViewpointEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objViewpointEN.CitationCount = TransNullToInt(objDT.Rows[0][conViewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objViewpointEN.VersionCount = TransNullToInt(objDT.Rows[0][conViewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objViewpointEN.CreateDate = objDT.Rows[0][conViewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewpointEN.ShareId = objDT.Rows[0][conViewpoint.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objViewpointEN.IsRecommend = TransNullToBool(objDT.Rows[0][conViewpoint.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objViewpointEN.IdCurrEduCls = objDT.Rows[0][conViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objViewpointEN.CourseId = objDT.Rows[0][conViewpoint.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objViewpointEN.UpdUser = objDT.Rows[0][conViewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objViewpointEN.UpdDate = objDT.Rows[0][conViewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewpointEN.Memo = objDT.Rows[0][conViewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewpointDA: GetViewpoint)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewpointEN GetObjByViewpointId(string strViewpointId)
{
CheckPrimaryKey(strViewpointId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
strSQL = "Select * from Viewpoint where ViewpointId = " + "'"+ strViewpointId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewpointEN objViewpointEN = new clsViewpointEN();
try
{
 objViewpointEN.ViewpointId = objRow[conViewpoint.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objViewpointEN.ViewpointName = objRow[conViewpoint.ViewpointName] == DBNull.Value ? null : objRow[conViewpoint.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objViewpointEN.ViewpointContent = objRow[conViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conViewpoint.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objViewpointEN.ViewpointTypeId = objRow[conViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objViewpointEN.Reason = objRow[conViewpoint.Reason] == DBNull.Value ? null : objRow[conViewpoint.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objViewpointEN.Source = objRow[conViewpoint.Source] == DBNull.Value ? null : objRow[conViewpoint.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objViewpointEN.VPProposePeople = objRow[conViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conViewpoint.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conViewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objViewpointEN.UserTypeId = objRow[conViewpoint.UserTypeId] == DBNull.Value ? null : objRow[conViewpoint.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objViewpointEN.CitationId = objRow[conViewpoint.CitationId] == DBNull.Value ? null : objRow[conViewpoint.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objViewpointEN.AppraiseCount = objRow[conViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objViewpointEN.OkCount = objRow[conViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpoint.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objViewpointEN.Score = objRow[conViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conViewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objViewpointEN.StuScore = objRow[conViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conViewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objViewpointEN.TeaScore = objRow[conViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conViewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objViewpointEN.PdfContent = objRow[conViewpoint.PdfContent] == DBNull.Value ? null : objRow[conViewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objViewpointEN.PdfPageNum = objRow[conViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objViewpointEN.CitationCount = objRow[conViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objViewpointEN.VersionCount = objRow[conViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objViewpointEN.CreateDate = objRow[conViewpoint.CreateDate] == DBNull.Value ? null : objRow[conViewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewpointEN.ShareId = objRow[conViewpoint.ShareId] == DBNull.Value ? null : objRow[conViewpoint.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conViewpoint.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objViewpointEN.IdCurrEduCls = objRow[conViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objViewpointEN.CourseId = objRow[conViewpoint.CourseId] == DBNull.Value ? null : objRow[conViewpoint.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objViewpointEN.UpdUser = objRow[conViewpoint.UpdUser] == DBNull.Value ? null : objRow[conViewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objViewpointEN.UpdDate = objRow[conViewpoint.UpdDate] == DBNull.Value ? null : objRow[conViewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewpointEN.Memo = objRow[conViewpoint.Memo] == DBNull.Value ? null : objRow[conViewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewpointDA: GetObjByViewpointId)", objException.Message));
}
return objViewpointEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewpointEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewpointDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
strSQL = "Select * from Viewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewpointEN objViewpointEN = new clsViewpointEN()
{
ViewpointId = objRow[conViewpoint.ViewpointId].ToString().Trim(), //观点Id
ViewpointName = objRow[conViewpoint.ViewpointName] == DBNull.Value ? null : objRow[conViewpoint.ViewpointName].ToString().Trim(), //观点名称
ViewpointContent = objRow[conViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conViewpoint.ViewpointContent].ToString().Trim(), //观点内容
ViewpointTypeId = objRow[conViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpoint.ViewpointTypeId].ToString().Trim(), //观点类型Id
Reason = objRow[conViewpoint.Reason] == DBNull.Value ? null : objRow[conViewpoint.Reason].ToString().Trim(), //理由
Source = objRow[conViewpoint.Source] == DBNull.Value ? null : objRow[conViewpoint.Source].ToString().Trim(), //来源
VPProposePeople = objRow[conViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conViewpoint.VPProposePeople].ToString().Trim(), //观点提出人
IsSubmit = TransNullToBool(objRow[conViewpoint.IsSubmit].ToString().Trim()), //是否提交
UserTypeId = objRow[conViewpoint.UserTypeId] == DBNull.Value ? null : objRow[conViewpoint.UserTypeId].ToString().Trim(), //用户类型Id
CitationId = objRow[conViewpoint.CitationId] == DBNull.Value ? null : objRow[conViewpoint.CitationId].ToString().Trim(), //引用Id
AppraiseCount = objRow[conViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.AppraiseCount].ToString().Trim()), //评论数
OkCount = objRow[conViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.OkCount].ToString().Trim()), //点赞统计
Score = objRow[conViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.Score].ToString().Trim()), //评分
StuScore = objRow[conViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.TeaScore].ToString().Trim()), //教师评分
PdfContent = objRow[conViewpoint.PdfContent] == DBNull.Value ? null : objRow[conViewpoint.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.VersionCount].ToString().Trim()), //版本统计
CreateDate = objRow[conViewpoint.CreateDate] == DBNull.Value ? null : objRow[conViewpoint.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[conViewpoint.ShareId] == DBNull.Value ? null : objRow[conViewpoint.ShareId].ToString().Trim(), //分享Id
IsRecommend = TransNullToBool(objRow[conViewpoint.IsRecommend].ToString().Trim()), //是否推荐
IdCurrEduCls = objRow[conViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpoint.IdCurrEduCls].ToString().Trim(), //教学班流水号
CourseId = objRow[conViewpoint.CourseId] == DBNull.Value ? null : objRow[conViewpoint.CourseId].ToString().Trim(), //课程Id
UpdUser = objRow[conViewpoint.UpdUser] == DBNull.Value ? null : objRow[conViewpoint.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conViewpoint.UpdDate] == DBNull.Value ? null : objRow[conViewpoint.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conViewpoint.Memo] == DBNull.Value ? null : objRow[conViewpoint.Memo].ToString().Trim() //备注
};
objViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewpointEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewpointDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewpointEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewpointEN objViewpointEN = new clsViewpointEN();
try
{
objViewpointEN.ViewpointId = objRow[conViewpoint.ViewpointId].ToString().Trim(); //观点Id
objViewpointEN.ViewpointName = objRow[conViewpoint.ViewpointName] == DBNull.Value ? null : objRow[conViewpoint.ViewpointName].ToString().Trim(); //观点名称
objViewpointEN.ViewpointContent = objRow[conViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objViewpointEN.ViewpointTypeId = objRow[conViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointEN.Reason = objRow[conViewpoint.Reason] == DBNull.Value ? null : objRow[conViewpoint.Reason].ToString().Trim(); //理由
objViewpointEN.Source = objRow[conViewpoint.Source] == DBNull.Value ? null : objRow[conViewpoint.Source].ToString().Trim(); //来源
objViewpointEN.VPProposePeople = objRow[conViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointEN.IsSubmit = TransNullToBool(objRow[conViewpoint.IsSubmit].ToString().Trim()); //是否提交
objViewpointEN.UserTypeId = objRow[conViewpoint.UserTypeId] == DBNull.Value ? null : objRow[conViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointEN.CitationId = objRow[conViewpoint.CitationId] == DBNull.Value ? null : objRow[conViewpoint.CitationId].ToString().Trim(); //引用Id
objViewpointEN.AppraiseCount = objRow[conViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.AppraiseCount].ToString().Trim()); //评论数
objViewpointEN.OkCount = objRow[conViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.OkCount].ToString().Trim()); //点赞统计
objViewpointEN.Score = objRow[conViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.Score].ToString().Trim()); //评分
objViewpointEN.StuScore = objRow[conViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.StuScore].ToString().Trim()); //学生平均分
objViewpointEN.TeaScore = objRow[conViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.TeaScore].ToString().Trim()); //教师评分
objViewpointEN.PdfContent = objRow[conViewpoint.PdfContent] == DBNull.Value ? null : objRow[conViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objViewpointEN.PdfPageNum = objRow[conViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointEN.CitationCount = objRow[conViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.CitationCount].ToString().Trim()); //引用统计
objViewpointEN.VersionCount = objRow[conViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.VersionCount].ToString().Trim()); //版本统计
objViewpointEN.CreateDate = objRow[conViewpoint.CreateDate] == DBNull.Value ? null : objRow[conViewpoint.CreateDate].ToString().Trim(); //建立日期
objViewpointEN.ShareId = objRow[conViewpoint.ShareId] == DBNull.Value ? null : objRow[conViewpoint.ShareId].ToString().Trim(); //分享Id
objViewpointEN.IsRecommend = TransNullToBool(objRow[conViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objViewpointEN.IdCurrEduCls = objRow[conViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointEN.CourseId = objRow[conViewpoint.CourseId] == DBNull.Value ? null : objRow[conViewpoint.CourseId].ToString().Trim(); //课程Id
objViewpointEN.UpdUser = objRow[conViewpoint.UpdUser] == DBNull.Value ? null : objRow[conViewpoint.UpdUser].ToString().Trim(); //修改人
objViewpointEN.UpdDate = objRow[conViewpoint.UpdDate] == DBNull.Value ? null : objRow[conViewpoint.UpdDate].ToString().Trim(); //修改日期
objViewpointEN.Memo = objRow[conViewpoint.Memo] == DBNull.Value ? null : objRow[conViewpoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewpointDA: GetObjByDataRowViewpoint)", objException.Message));
}
objViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewpointEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewpointEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewpointEN objViewpointEN = new clsViewpointEN();
try
{
objViewpointEN.ViewpointId = objRow[conViewpoint.ViewpointId].ToString().Trim(); //观点Id
objViewpointEN.ViewpointName = objRow[conViewpoint.ViewpointName] == DBNull.Value ? null : objRow[conViewpoint.ViewpointName].ToString().Trim(); //观点名称
objViewpointEN.ViewpointContent = objRow[conViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objViewpointEN.ViewpointTypeId = objRow[conViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointEN.Reason = objRow[conViewpoint.Reason] == DBNull.Value ? null : objRow[conViewpoint.Reason].ToString().Trim(); //理由
objViewpointEN.Source = objRow[conViewpoint.Source] == DBNull.Value ? null : objRow[conViewpoint.Source].ToString().Trim(); //来源
objViewpointEN.VPProposePeople = objRow[conViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointEN.IsSubmit = TransNullToBool(objRow[conViewpoint.IsSubmit].ToString().Trim()); //是否提交
objViewpointEN.UserTypeId = objRow[conViewpoint.UserTypeId] == DBNull.Value ? null : objRow[conViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointEN.CitationId = objRow[conViewpoint.CitationId] == DBNull.Value ? null : objRow[conViewpoint.CitationId].ToString().Trim(); //引用Id
objViewpointEN.AppraiseCount = objRow[conViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.AppraiseCount].ToString().Trim()); //评论数
objViewpointEN.OkCount = objRow[conViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.OkCount].ToString().Trim()); //点赞统计
objViewpointEN.Score = objRow[conViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.Score].ToString().Trim()); //评分
objViewpointEN.StuScore = objRow[conViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.StuScore].ToString().Trim()); //学生平均分
objViewpointEN.TeaScore = objRow[conViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conViewpoint.TeaScore].ToString().Trim()); //教师评分
objViewpointEN.PdfContent = objRow[conViewpoint.PdfContent] == DBNull.Value ? null : objRow[conViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objViewpointEN.PdfPageNum = objRow[conViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointEN.CitationCount = objRow[conViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.CitationCount].ToString().Trim()); //引用统计
objViewpointEN.VersionCount = objRow[conViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewpoint.VersionCount].ToString().Trim()); //版本统计
objViewpointEN.CreateDate = objRow[conViewpoint.CreateDate] == DBNull.Value ? null : objRow[conViewpoint.CreateDate].ToString().Trim(); //建立日期
objViewpointEN.ShareId = objRow[conViewpoint.ShareId] == DBNull.Value ? null : objRow[conViewpoint.ShareId].ToString().Trim(); //分享Id
objViewpointEN.IsRecommend = TransNullToBool(objRow[conViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objViewpointEN.IdCurrEduCls = objRow[conViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointEN.CourseId = objRow[conViewpoint.CourseId] == DBNull.Value ? null : objRow[conViewpoint.CourseId].ToString().Trim(); //课程Id
objViewpointEN.UpdUser = objRow[conViewpoint.UpdUser] == DBNull.Value ? null : objRow[conViewpoint.UpdUser].ToString().Trim(); //修改人
objViewpointEN.UpdDate = objRow[conViewpoint.UpdDate] == DBNull.Value ? null : objRow[conViewpoint.UpdDate].ToString().Trim(); //修改日期
objViewpointEN.Memo = objRow[conViewpoint.Memo] == DBNull.Value ? null : objRow[conViewpoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewpointDA: GetObjByDataRow)", objException.Message));
}
objViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewpointEN;
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
objSQL = clsViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewpointEN._CurrTabName, conViewpoint.ViewpointId, 8, "");
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
objSQL = clsViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewpointEN._CurrTabName, conViewpoint.ViewpointId, 8, strPrefix);
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
 objSQL = clsViewpointDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewpointId from Viewpoint where " + strCondition;
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
 objSQL = clsViewpointDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewpointId from Viewpoint where " + strCondition;
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
 objSQL = clsViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Viewpoint", "ViewpointId = " + "'"+ strViewpointId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewpointDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Viewpoint", strCondition))
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
objSQL = clsViewpointDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Viewpoint");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewpointEN objViewpointEN)
 {
 if (objViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewpointEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
strSQL = "Select * from Viewpoint where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Viewpoint");
objRow = objDS.Tables["Viewpoint"].NewRow();
objRow[conViewpoint.ViewpointId] = objViewpointEN.ViewpointId; //观点Id
 if (objViewpointEN.ViewpointName !=  "")
 {
objRow[conViewpoint.ViewpointName] = objViewpointEN.ViewpointName; //观点名称
 }
 if (objViewpointEN.ViewpointContent !=  "")
 {
objRow[conViewpoint.ViewpointContent] = objViewpointEN.ViewpointContent; //观点内容
 }
 if (objViewpointEN.ViewpointTypeId !=  "")
 {
objRow[conViewpoint.ViewpointTypeId] = objViewpointEN.ViewpointTypeId; //观点类型Id
 }
 if (objViewpointEN.Reason !=  "")
 {
objRow[conViewpoint.Reason] = objViewpointEN.Reason; //理由
 }
 if (objViewpointEN.Source !=  "")
 {
objRow[conViewpoint.Source] = objViewpointEN.Source; //来源
 }
 if (objViewpointEN.VPProposePeople !=  "")
 {
objRow[conViewpoint.VPProposePeople] = objViewpointEN.VPProposePeople; //观点提出人
 }
objRow[conViewpoint.IsSubmit] = objViewpointEN.IsSubmit; //是否提交
 if (objViewpointEN.UserTypeId !=  "")
 {
objRow[conViewpoint.UserTypeId] = objViewpointEN.UserTypeId; //用户类型Id
 }
 if (objViewpointEN.CitationId !=  "")
 {
objRow[conViewpoint.CitationId] = objViewpointEN.CitationId; //引用Id
 }
objRow[conViewpoint.AppraiseCount] = objViewpointEN.AppraiseCount; //评论数
objRow[conViewpoint.OkCount] = objViewpointEN.OkCount; //点赞统计
objRow[conViewpoint.Score] = objViewpointEN.Score; //评分
objRow[conViewpoint.StuScore] = objViewpointEN.StuScore; //学生平均分
objRow[conViewpoint.TeaScore] = objViewpointEN.TeaScore; //教师评分
 if (objViewpointEN.PdfContent !=  "")
 {
objRow[conViewpoint.PdfContent] = objViewpointEN.PdfContent; //Pdf内容
 }
objRow[conViewpoint.PdfPageNum] = objViewpointEN.PdfPageNum; //Pdf页码
objRow[conViewpoint.CitationCount] = objViewpointEN.CitationCount; //引用统计
objRow[conViewpoint.VersionCount] = objViewpointEN.VersionCount; //版本统计
 if (objViewpointEN.CreateDate !=  "")
 {
objRow[conViewpoint.CreateDate] = objViewpointEN.CreateDate; //建立日期
 }
 if (objViewpointEN.ShareId !=  "")
 {
objRow[conViewpoint.ShareId] = objViewpointEN.ShareId; //分享Id
 }
objRow[conViewpoint.IsRecommend] = objViewpointEN.IsRecommend; //是否推荐
 if (objViewpointEN.IdCurrEduCls !=  "")
 {
objRow[conViewpoint.IdCurrEduCls] = objViewpointEN.IdCurrEduCls; //教学班流水号
 }
 if (objViewpointEN.CourseId !=  "")
 {
objRow[conViewpoint.CourseId] = objViewpointEN.CourseId; //课程Id
 }
 if (objViewpointEN.UpdUser !=  "")
 {
objRow[conViewpoint.UpdUser] = objViewpointEN.UpdUser; //修改人
 }
 if (objViewpointEN.UpdDate !=  "")
 {
objRow[conViewpoint.UpdDate] = objViewpointEN.UpdDate; //修改日期
 }
 if (objViewpointEN.Memo !=  "")
 {
objRow[conViewpoint.Memo] = objViewpointEN.Memo; //备注
 }
objDS.Tables[clsViewpointEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewpointEN._CurrTabName);
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
 /// <param name = "objViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewpointEN objViewpointEN)
{
 if (objViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewpointEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewpointEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointId);
 var strViewpointId = objViewpointEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objViewpointEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointName);
 var strViewpointName = objViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objViewpointEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointContent);
 var strViewpointContent = objViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objViewpointEN.ViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointTypeId);
 var strViewpointTypeId = objViewpointEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeId + "'");
 }
 
 if (objViewpointEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Reason);
 var strReason = objViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objViewpointEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Source);
 var strSource = objViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objViewpointEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.VPProposePeople);
 var strVPProposePeople = objViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conViewpoint.IsSubmit);
 arrValueListForInsert.Add("'" + (objViewpointEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objViewpointEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UserTypeId);
 var strUserTypeId = objViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objViewpointEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CitationId);
 var strCitationId = objViewpointEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.AppraiseCount);
 arrValueListForInsert.Add(objViewpointEN.AppraiseCount.ToString());
 }
 
 if (objViewpointEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.OkCount);
 arrValueListForInsert.Add(objViewpointEN.OkCount.ToString());
 }
 
 if (objViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Score);
 arrValueListForInsert.Add(objViewpointEN.Score.ToString());
 }
 
 if (objViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.StuScore);
 arrValueListForInsert.Add(objViewpointEN.StuScore.ToString());
 }
 
 if (objViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.TeaScore);
 arrValueListForInsert.Add(objViewpointEN.TeaScore.ToString());
 }
 
 if (objViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.PdfContent);
 var strPdfContent = objViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objViewpointEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.PdfPageNum);
 arrValueListForInsert.Add(objViewpointEN.PdfPageNum.ToString());
 }
 
 if (objViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CitationCount);
 arrValueListForInsert.Add(objViewpointEN.CitationCount.ToString());
 }
 
 if (objViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.VersionCount);
 arrValueListForInsert.Add(objViewpointEN.VersionCount.ToString());
 }
 
 if (objViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CreateDate);
 var strCreateDate = objViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objViewpointEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ShareId);
 var strShareId = objViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 arrFieldListForInsert.Add(conViewpoint.IsRecommend);
 arrValueListForInsert.Add("'" + (objViewpointEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objViewpointEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CourseId);
 var strCourseId = objViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UpdUser);
 var strUpdUser = objViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UpdDate);
 var strUpdDate = objViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Memo);
 var strMemo = objViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Viewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewpointEN objViewpointEN)
{
 if (objViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewpointEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewpointEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointId);
 var strViewpointId = objViewpointEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objViewpointEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointName);
 var strViewpointName = objViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objViewpointEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointContent);
 var strViewpointContent = objViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objViewpointEN.ViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointTypeId);
 var strViewpointTypeId = objViewpointEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeId + "'");
 }
 
 if (objViewpointEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Reason);
 var strReason = objViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objViewpointEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Source);
 var strSource = objViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objViewpointEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.VPProposePeople);
 var strVPProposePeople = objViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conViewpoint.IsSubmit);
 arrValueListForInsert.Add("'" + (objViewpointEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objViewpointEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UserTypeId);
 var strUserTypeId = objViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objViewpointEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CitationId);
 var strCitationId = objViewpointEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.AppraiseCount);
 arrValueListForInsert.Add(objViewpointEN.AppraiseCount.ToString());
 }
 
 if (objViewpointEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.OkCount);
 arrValueListForInsert.Add(objViewpointEN.OkCount.ToString());
 }
 
 if (objViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Score);
 arrValueListForInsert.Add(objViewpointEN.Score.ToString());
 }
 
 if (objViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.StuScore);
 arrValueListForInsert.Add(objViewpointEN.StuScore.ToString());
 }
 
 if (objViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.TeaScore);
 arrValueListForInsert.Add(objViewpointEN.TeaScore.ToString());
 }
 
 if (objViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.PdfContent);
 var strPdfContent = objViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objViewpointEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.PdfPageNum);
 arrValueListForInsert.Add(objViewpointEN.PdfPageNum.ToString());
 }
 
 if (objViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CitationCount);
 arrValueListForInsert.Add(objViewpointEN.CitationCount.ToString());
 }
 
 if (objViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.VersionCount);
 arrValueListForInsert.Add(objViewpointEN.VersionCount.ToString());
 }
 
 if (objViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CreateDate);
 var strCreateDate = objViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objViewpointEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ShareId);
 var strShareId = objViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 arrFieldListForInsert.Add(conViewpoint.IsRecommend);
 arrValueListForInsert.Add("'" + (objViewpointEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objViewpointEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CourseId);
 var strCourseId = objViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UpdUser);
 var strUpdUser = objViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UpdDate);
 var strUpdDate = objViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Memo);
 var strMemo = objViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Viewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objViewpointEN.ViewpointId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objViewpointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewpointEN objViewpointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewpointEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewpointEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointId);
 var strViewpointId = objViewpointEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objViewpointEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointName);
 var strViewpointName = objViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objViewpointEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointContent);
 var strViewpointContent = objViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objViewpointEN.ViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointTypeId);
 var strViewpointTypeId = objViewpointEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeId + "'");
 }
 
 if (objViewpointEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Reason);
 var strReason = objViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objViewpointEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Source);
 var strSource = objViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objViewpointEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.VPProposePeople);
 var strVPProposePeople = objViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conViewpoint.IsSubmit);
 arrValueListForInsert.Add("'" + (objViewpointEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objViewpointEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UserTypeId);
 var strUserTypeId = objViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objViewpointEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CitationId);
 var strCitationId = objViewpointEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.AppraiseCount);
 arrValueListForInsert.Add(objViewpointEN.AppraiseCount.ToString());
 }
 
 if (objViewpointEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.OkCount);
 arrValueListForInsert.Add(objViewpointEN.OkCount.ToString());
 }
 
 if (objViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Score);
 arrValueListForInsert.Add(objViewpointEN.Score.ToString());
 }
 
 if (objViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.StuScore);
 arrValueListForInsert.Add(objViewpointEN.StuScore.ToString());
 }
 
 if (objViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.TeaScore);
 arrValueListForInsert.Add(objViewpointEN.TeaScore.ToString());
 }
 
 if (objViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.PdfContent);
 var strPdfContent = objViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objViewpointEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.PdfPageNum);
 arrValueListForInsert.Add(objViewpointEN.PdfPageNum.ToString());
 }
 
 if (objViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CitationCount);
 arrValueListForInsert.Add(objViewpointEN.CitationCount.ToString());
 }
 
 if (objViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.VersionCount);
 arrValueListForInsert.Add(objViewpointEN.VersionCount.ToString());
 }
 
 if (objViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CreateDate);
 var strCreateDate = objViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objViewpointEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ShareId);
 var strShareId = objViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 arrFieldListForInsert.Add(conViewpoint.IsRecommend);
 arrValueListForInsert.Add("'" + (objViewpointEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objViewpointEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CourseId);
 var strCourseId = objViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UpdUser);
 var strUpdUser = objViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UpdDate);
 var strUpdDate = objViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Memo);
 var strMemo = objViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Viewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objViewpointEN.ViewpointId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewpointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewpointEN objViewpointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewpointEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewpointEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointId);
 var strViewpointId = objViewpointEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objViewpointEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointName);
 var strViewpointName = objViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objViewpointEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointContent);
 var strViewpointContent = objViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objViewpointEN.ViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ViewpointTypeId);
 var strViewpointTypeId = objViewpointEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeId + "'");
 }
 
 if (objViewpointEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Reason);
 var strReason = objViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objViewpointEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Source);
 var strSource = objViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objViewpointEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.VPProposePeople);
 var strVPProposePeople = objViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conViewpoint.IsSubmit);
 arrValueListForInsert.Add("'" + (objViewpointEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objViewpointEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UserTypeId);
 var strUserTypeId = objViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objViewpointEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CitationId);
 var strCitationId = objViewpointEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.AppraiseCount);
 arrValueListForInsert.Add(objViewpointEN.AppraiseCount.ToString());
 }
 
 if (objViewpointEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.OkCount);
 arrValueListForInsert.Add(objViewpointEN.OkCount.ToString());
 }
 
 if (objViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Score);
 arrValueListForInsert.Add(objViewpointEN.Score.ToString());
 }
 
 if (objViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.StuScore);
 arrValueListForInsert.Add(objViewpointEN.StuScore.ToString());
 }
 
 if (objViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.TeaScore);
 arrValueListForInsert.Add(objViewpointEN.TeaScore.ToString());
 }
 
 if (objViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.PdfContent);
 var strPdfContent = objViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objViewpointEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.PdfPageNum);
 arrValueListForInsert.Add(objViewpointEN.PdfPageNum.ToString());
 }
 
 if (objViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CitationCount);
 arrValueListForInsert.Add(objViewpointEN.CitationCount.ToString());
 }
 
 if (objViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.VersionCount);
 arrValueListForInsert.Add(objViewpointEN.VersionCount.ToString());
 }
 
 if (objViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CreateDate);
 var strCreateDate = objViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objViewpointEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.ShareId);
 var strShareId = objViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 arrFieldListForInsert.Add(conViewpoint.IsRecommend);
 arrValueListForInsert.Add("'" + (objViewpointEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objViewpointEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.CourseId);
 var strCourseId = objViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UpdUser);
 var strUpdUser = objViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.UpdDate);
 var strUpdDate = objViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewpoint.Memo);
 var strMemo = objViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Viewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewpoints(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
strSQL = "Select * from Viewpoint where ViewpointId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Viewpoint");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strViewpointId = oRow[conViewpoint.ViewpointId].ToString().Trim();
if (IsExist(strViewpointId))
{
 string strResult = "关键字变量值为:" + string.Format("ViewpointId = {0}", strViewpointId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewpointEN._CurrTabName ].NewRow();
objRow[conViewpoint.ViewpointId] = oRow[conViewpoint.ViewpointId].ToString().Trim(); //观点Id
objRow[conViewpoint.ViewpointName] = oRow[conViewpoint.ViewpointName].ToString().Trim(); //观点名称
objRow[conViewpoint.ViewpointContent] = oRow[conViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objRow[conViewpoint.ViewpointTypeId] = oRow[conViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objRow[conViewpoint.Reason] = oRow[conViewpoint.Reason].ToString().Trim(); //理由
objRow[conViewpoint.Source] = oRow[conViewpoint.Source].ToString().Trim(); //来源
objRow[conViewpoint.VPProposePeople] = oRow[conViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objRow[conViewpoint.IsSubmit] = oRow[conViewpoint.IsSubmit].ToString().Trim(); //是否提交
objRow[conViewpoint.UserTypeId] = oRow[conViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conViewpoint.CitationId] = oRow[conViewpoint.CitationId].ToString().Trim(); //引用Id
objRow[conViewpoint.AppraiseCount] = oRow[conViewpoint.AppraiseCount].ToString().Trim(); //评论数
objRow[conViewpoint.OkCount] = oRow[conViewpoint.OkCount].ToString().Trim(); //点赞统计
objRow[conViewpoint.Score] = oRow[conViewpoint.Score].ToString().Trim(); //评分
objRow[conViewpoint.StuScore] = oRow[conViewpoint.StuScore].ToString().Trim(); //学生平均分
objRow[conViewpoint.TeaScore] = oRow[conViewpoint.TeaScore].ToString().Trim(); //教师评分
objRow[conViewpoint.PdfContent] = oRow[conViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objRow[conViewpoint.PdfPageNum] = oRow[conViewpoint.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conViewpoint.CitationCount] = oRow[conViewpoint.CitationCount].ToString().Trim(); //引用统计
objRow[conViewpoint.VersionCount] = oRow[conViewpoint.VersionCount].ToString().Trim(); //版本统计
objRow[conViewpoint.CreateDate] = oRow[conViewpoint.CreateDate].ToString().Trim(); //建立日期
objRow[conViewpoint.ShareId] = oRow[conViewpoint.ShareId].ToString().Trim(); //分享Id
objRow[conViewpoint.IsRecommend] = oRow[conViewpoint.IsRecommend].ToString().Trim(); //是否推荐
objRow[conViewpoint.IdCurrEduCls] = oRow[conViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conViewpoint.CourseId] = oRow[conViewpoint.CourseId].ToString().Trim(); //课程Id
objRow[conViewpoint.UpdUser] = oRow[conViewpoint.UpdUser].ToString().Trim(); //修改人
objRow[conViewpoint.UpdDate] = oRow[conViewpoint.UpdDate].ToString().Trim(); //修改日期
objRow[conViewpoint.Memo] = oRow[conViewpoint.Memo].ToString().Trim(); //备注
 objDS.Tables[clsViewpointEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewpointEN._CurrTabName);
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
 /// <param name = "objViewpointEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewpointEN objViewpointEN)
{
 if (objViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewpointEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
strSQL = "Select * from Viewpoint where ViewpointId = " + "'"+ objViewpointEN.ViewpointId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewpointEN._CurrTabName);
if (objDS.Tables[clsViewpointEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ViewpointId = " + "'"+ objViewpointEN.ViewpointId+"'");
return false;
}
objRow = objDS.Tables[clsViewpointEN._CurrTabName].Rows[0];
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointId))
 {
objRow[conViewpoint.ViewpointId] = objViewpointEN.ViewpointId; //观点Id
 }
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointName))
 {
objRow[conViewpoint.ViewpointName] = objViewpointEN.ViewpointName; //观点名称
 }
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointContent))
 {
objRow[conViewpoint.ViewpointContent] = objViewpointEN.ViewpointContent; //观点内容
 }
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointTypeId))
 {
objRow[conViewpoint.ViewpointTypeId] = objViewpointEN.ViewpointTypeId; //观点类型Id
 }
 if (objViewpointEN.IsUpdated(conViewpoint.Reason))
 {
objRow[conViewpoint.Reason] = objViewpointEN.Reason; //理由
 }
 if (objViewpointEN.IsUpdated(conViewpoint.Source))
 {
objRow[conViewpoint.Source] = objViewpointEN.Source; //来源
 }
 if (objViewpointEN.IsUpdated(conViewpoint.VPProposePeople))
 {
objRow[conViewpoint.VPProposePeople] = objViewpointEN.VPProposePeople; //观点提出人
 }
 if (objViewpointEN.IsUpdated(conViewpoint.IsSubmit))
 {
objRow[conViewpoint.IsSubmit] = objViewpointEN.IsSubmit; //是否提交
 }
 if (objViewpointEN.IsUpdated(conViewpoint.UserTypeId))
 {
objRow[conViewpoint.UserTypeId] = objViewpointEN.UserTypeId; //用户类型Id
 }
 if (objViewpointEN.IsUpdated(conViewpoint.CitationId))
 {
objRow[conViewpoint.CitationId] = objViewpointEN.CitationId; //引用Id
 }
 if (objViewpointEN.IsUpdated(conViewpoint.AppraiseCount))
 {
objRow[conViewpoint.AppraiseCount] = objViewpointEN.AppraiseCount; //评论数
 }
 if (objViewpointEN.IsUpdated(conViewpoint.OkCount))
 {
objRow[conViewpoint.OkCount] = objViewpointEN.OkCount; //点赞统计
 }
 if (objViewpointEN.IsUpdated(conViewpoint.Score))
 {
objRow[conViewpoint.Score] = objViewpointEN.Score; //评分
 }
 if (objViewpointEN.IsUpdated(conViewpoint.StuScore))
 {
objRow[conViewpoint.StuScore] = objViewpointEN.StuScore; //学生平均分
 }
 if (objViewpointEN.IsUpdated(conViewpoint.TeaScore))
 {
objRow[conViewpoint.TeaScore] = objViewpointEN.TeaScore; //教师评分
 }
 if (objViewpointEN.IsUpdated(conViewpoint.PdfContent))
 {
objRow[conViewpoint.PdfContent] = objViewpointEN.PdfContent; //Pdf内容
 }
 if (objViewpointEN.IsUpdated(conViewpoint.PdfPageNum))
 {
objRow[conViewpoint.PdfPageNum] = objViewpointEN.PdfPageNum; //Pdf页码
 }
 if (objViewpointEN.IsUpdated(conViewpoint.CitationCount))
 {
objRow[conViewpoint.CitationCount] = objViewpointEN.CitationCount; //引用统计
 }
 if (objViewpointEN.IsUpdated(conViewpoint.VersionCount))
 {
objRow[conViewpoint.VersionCount] = objViewpointEN.VersionCount; //版本统计
 }
 if (objViewpointEN.IsUpdated(conViewpoint.CreateDate))
 {
objRow[conViewpoint.CreateDate] = objViewpointEN.CreateDate; //建立日期
 }
 if (objViewpointEN.IsUpdated(conViewpoint.ShareId))
 {
objRow[conViewpoint.ShareId] = objViewpointEN.ShareId; //分享Id
 }
 if (objViewpointEN.IsUpdated(conViewpoint.IsRecommend))
 {
objRow[conViewpoint.IsRecommend] = objViewpointEN.IsRecommend; //是否推荐
 }
 if (objViewpointEN.IsUpdated(conViewpoint.IdCurrEduCls))
 {
objRow[conViewpoint.IdCurrEduCls] = objViewpointEN.IdCurrEduCls; //教学班流水号
 }
 if (objViewpointEN.IsUpdated(conViewpoint.CourseId))
 {
objRow[conViewpoint.CourseId] = objViewpointEN.CourseId; //课程Id
 }
 if (objViewpointEN.IsUpdated(conViewpoint.UpdUser))
 {
objRow[conViewpoint.UpdUser] = objViewpointEN.UpdUser; //修改人
 }
 if (objViewpointEN.IsUpdated(conViewpoint.UpdDate))
 {
objRow[conViewpoint.UpdDate] = objViewpointEN.UpdDate; //修改日期
 }
 if (objViewpointEN.IsUpdated(conViewpoint.Memo))
 {
objRow[conViewpoint.Memo] = objViewpointEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsViewpointEN._CurrTabName);
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
 /// <param name = "objViewpointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewpointEN objViewpointEN)
{
 if (objViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Viewpoint Set ");
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointName))
 {
 if (objViewpointEN.ViewpointName !=  null)
 {
 var strViewpointName = objViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointName, conViewpoint.ViewpointName); //观点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.ViewpointName); //观点名称
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointContent))
 {
 if (objViewpointEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointContent, conViewpoint.ViewpointContent); //观点内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.ViewpointContent); //观点内容
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointTypeId))
 {
 if (objViewpointEN.ViewpointTypeId !=  null)
 {
 var strViewpointTypeId = objViewpointEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointTypeId, conViewpoint.ViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.ViewpointTypeId); //观点类型Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Reason))
 {
 if (objViewpointEN.Reason !=  null)
 {
 var strReason = objViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReason, conViewpoint.Reason); //理由
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.Reason); //理由
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Source))
 {
 if (objViewpointEN.Source !=  null)
 {
 var strSource = objViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSource, conViewpoint.Source); //来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.Source); //来源
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.VPProposePeople))
 {
 if (objViewpointEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVPProposePeople, conViewpoint.VPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.VPProposePeople); //观点提出人
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewpointEN.IsSubmit == true?"1":"0", conViewpoint.IsSubmit); //是否提交
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UserTypeId))
 {
 if (objViewpointEN.UserTypeId !=  null)
 {
 var strUserTypeId = objViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conViewpoint.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.UserTypeId); //用户类型Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CitationId))
 {
 if (objViewpointEN.CitationId !=  null)
 {
 var strCitationId = objViewpointEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conViewpoint.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.CitationId); //引用Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.AppraiseCount))
 {
 if (objViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.AppraiseCount, conViewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.OkCount))
 {
 if (objViewpointEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.OkCount, conViewpoint.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.OkCount); //点赞统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Score))
 {
 if (objViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.Score, conViewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.Score); //评分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.StuScore))
 {
 if (objViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.StuScore, conViewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.StuScore); //学生平均分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.TeaScore))
 {
 if (objViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.TeaScore, conViewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.TeaScore); //教师评分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.PdfContent))
 {
 if (objViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conViewpoint.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.PdfContent); //Pdf内容
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.PdfPageNum))
 {
 if (objViewpointEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.PdfPageNum, conViewpoint.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.PdfPageNum); //Pdf页码
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CitationCount))
 {
 if (objViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.CitationCount, conViewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.CitationCount); //引用统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.VersionCount))
 {
 if (objViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.VersionCount, conViewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.VersionCount); //版本统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CreateDate))
 {
 if (objViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conViewpoint.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.CreateDate); //建立日期
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ShareId))
 {
 if (objViewpointEN.ShareId !=  null)
 {
 var strShareId = objViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conViewpoint.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.ShareId); //分享Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewpointEN.IsRecommend == true?"1":"0", conViewpoint.IsRecommend); //是否推荐
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IdCurrEduCls))
 {
 if (objViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conViewpoint.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CourseId))
 {
 if (objViewpointEN.CourseId !=  null)
 {
 var strCourseId = objViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conViewpoint.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.CourseId); //课程Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UpdUser))
 {
 if (objViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewpoint.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.UpdUser); //修改人
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UpdDate))
 {
 if (objViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewpoint.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.UpdDate); //修改日期
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Memo))
 {
 if (objViewpointEN.Memo !=  null)
 {
 var strMemo = objViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewpoint.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewpointId = '{0}'", objViewpointEN.ViewpointId); 
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
 /// <param name = "objViewpointEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewpointEN objViewpointEN, string strCondition)
{
 if (objViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Viewpoint Set ");
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointName))
 {
 if (objViewpointEN.ViewpointName !=  null)
 {
 var strViewpointName = objViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointName = '{0}',", strViewpointName); //观点名称
 }
 else
 {
 sbSQL.Append(" ViewpointName = null,"); //观点名称
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointContent))
 {
 if (objViewpointEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointContent = '{0}',", strViewpointContent); //观点内容
 }
 else
 {
 sbSQL.Append(" ViewpointContent = null,"); //观点内容
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointTypeId))
 {
 if (objViewpointEN.ViewpointTypeId !=  null)
 {
 var strViewpointTypeId = objViewpointEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointTypeId = '{0}',", strViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.Append(" ViewpointTypeId = null,"); //观点类型Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Reason))
 {
 if (objViewpointEN.Reason !=  null)
 {
 var strReason = objViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Reason = '{0}',", strReason); //理由
 }
 else
 {
 sbSQL.Append(" Reason = null,"); //理由
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Source))
 {
 if (objViewpointEN.Source !=  null)
 {
 var strSource = objViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Source = '{0}',", strSource); //来源
 }
 else
 {
 sbSQL.Append(" Source = null,"); //来源
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.VPProposePeople))
 {
 if (objViewpointEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VPProposePeople = '{0}',", strVPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.Append(" VPProposePeople = null,"); //观点提出人
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objViewpointEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UserTypeId))
 {
 if (objViewpointEN.UserTypeId !=  null)
 {
 var strUserTypeId = objViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CitationId))
 {
 if (objViewpointEN.CitationId !=  null)
 {
 var strCitationId = objViewpointEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.AppraiseCount))
 {
 if (objViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.AppraiseCount, conViewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.OkCount))
 {
 if (objViewpointEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.OkCount, conViewpoint.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.OkCount); //点赞统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Score))
 {
 if (objViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.Score, conViewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.Score); //评分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.StuScore))
 {
 if (objViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.StuScore, conViewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.StuScore); //学生平均分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.TeaScore))
 {
 if (objViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.TeaScore, conViewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.TeaScore); //教师评分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.PdfContent))
 {
 if (objViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.PdfPageNum))
 {
 if (objViewpointEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.PdfPageNum, conViewpoint.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.PdfPageNum); //Pdf页码
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CitationCount))
 {
 if (objViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.CitationCount, conViewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.CitationCount); //引用统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.VersionCount))
 {
 if (objViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.VersionCount, conViewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.VersionCount); //版本统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CreateDate))
 {
 if (objViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ShareId))
 {
 if (objViewpointEN.ShareId !=  null)
 {
 var strShareId = objViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objViewpointEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IdCurrEduCls))
 {
 if (objViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CourseId))
 {
 if (objViewpointEN.CourseId !=  null)
 {
 var strCourseId = objViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UpdUser))
 {
 if (objViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UpdDate))
 {
 if (objViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Memo))
 {
 if (objViewpointEN.Memo !=  null)
 {
 var strMemo = objViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewpointEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewpointEN objViewpointEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Viewpoint Set ");
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointName))
 {
 if (objViewpointEN.ViewpointName !=  null)
 {
 var strViewpointName = objViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointName = '{0}',", strViewpointName); //观点名称
 }
 else
 {
 sbSQL.Append(" ViewpointName = null,"); //观点名称
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointContent))
 {
 if (objViewpointEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointContent = '{0}',", strViewpointContent); //观点内容
 }
 else
 {
 sbSQL.Append(" ViewpointContent = null,"); //观点内容
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointTypeId))
 {
 if (objViewpointEN.ViewpointTypeId !=  null)
 {
 var strViewpointTypeId = objViewpointEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointTypeId = '{0}',", strViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.Append(" ViewpointTypeId = null,"); //观点类型Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Reason))
 {
 if (objViewpointEN.Reason !=  null)
 {
 var strReason = objViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Reason = '{0}',", strReason); //理由
 }
 else
 {
 sbSQL.Append(" Reason = null,"); //理由
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Source))
 {
 if (objViewpointEN.Source !=  null)
 {
 var strSource = objViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Source = '{0}',", strSource); //来源
 }
 else
 {
 sbSQL.Append(" Source = null,"); //来源
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.VPProposePeople))
 {
 if (objViewpointEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VPProposePeople = '{0}',", strVPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.Append(" VPProposePeople = null,"); //观点提出人
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objViewpointEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UserTypeId))
 {
 if (objViewpointEN.UserTypeId !=  null)
 {
 var strUserTypeId = objViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CitationId))
 {
 if (objViewpointEN.CitationId !=  null)
 {
 var strCitationId = objViewpointEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.AppraiseCount))
 {
 if (objViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.AppraiseCount, conViewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.OkCount))
 {
 if (objViewpointEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.OkCount, conViewpoint.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.OkCount); //点赞统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Score))
 {
 if (objViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.Score, conViewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.Score); //评分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.StuScore))
 {
 if (objViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.StuScore, conViewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.StuScore); //学生平均分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.TeaScore))
 {
 if (objViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.TeaScore, conViewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.TeaScore); //教师评分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.PdfContent))
 {
 if (objViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.PdfPageNum))
 {
 if (objViewpointEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.PdfPageNum, conViewpoint.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.PdfPageNum); //Pdf页码
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CitationCount))
 {
 if (objViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.CitationCount, conViewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.CitationCount); //引用统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.VersionCount))
 {
 if (objViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.VersionCount, conViewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.VersionCount); //版本统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CreateDate))
 {
 if (objViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ShareId))
 {
 if (objViewpointEN.ShareId !=  null)
 {
 var strShareId = objViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objViewpointEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IdCurrEduCls))
 {
 if (objViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CourseId))
 {
 if (objViewpointEN.CourseId !=  null)
 {
 var strCourseId = objViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UpdUser))
 {
 if (objViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UpdDate))
 {
 if (objViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Memo))
 {
 if (objViewpointEN.Memo !=  null)
 {
 var strMemo = objViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewpointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewpointEN objViewpointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Viewpoint Set ");
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointName))
 {
 if (objViewpointEN.ViewpointName !=  null)
 {
 var strViewpointName = objViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointName, conViewpoint.ViewpointName); //观点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.ViewpointName); //观点名称
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointContent))
 {
 if (objViewpointEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointContent, conViewpoint.ViewpointContent); //观点内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.ViewpointContent); //观点内容
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ViewpointTypeId))
 {
 if (objViewpointEN.ViewpointTypeId !=  null)
 {
 var strViewpointTypeId = objViewpointEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointTypeId, conViewpoint.ViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.ViewpointTypeId); //观点类型Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Reason))
 {
 if (objViewpointEN.Reason !=  null)
 {
 var strReason = objViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReason, conViewpoint.Reason); //理由
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.Reason); //理由
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Source))
 {
 if (objViewpointEN.Source !=  null)
 {
 var strSource = objViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSource, conViewpoint.Source); //来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.Source); //来源
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.VPProposePeople))
 {
 if (objViewpointEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVPProposePeople, conViewpoint.VPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.VPProposePeople); //观点提出人
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewpointEN.IsSubmit == true?"1":"0", conViewpoint.IsSubmit); //是否提交
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UserTypeId))
 {
 if (objViewpointEN.UserTypeId !=  null)
 {
 var strUserTypeId = objViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conViewpoint.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.UserTypeId); //用户类型Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CitationId))
 {
 if (objViewpointEN.CitationId !=  null)
 {
 var strCitationId = objViewpointEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conViewpoint.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.CitationId); //引用Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.AppraiseCount))
 {
 if (objViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.AppraiseCount, conViewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.OkCount))
 {
 if (objViewpointEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.OkCount, conViewpoint.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.OkCount); //点赞统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Score))
 {
 if (objViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.Score, conViewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.Score); //评分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.StuScore))
 {
 if (objViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.StuScore, conViewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.StuScore); //学生平均分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.TeaScore))
 {
 if (objViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.TeaScore, conViewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.TeaScore); //教师评分
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.PdfContent))
 {
 if (objViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conViewpoint.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.PdfContent); //Pdf内容
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.PdfPageNum))
 {
 if (objViewpointEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.PdfPageNum, conViewpoint.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.PdfPageNum); //Pdf页码
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CitationCount))
 {
 if (objViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.CitationCount, conViewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.CitationCount); //引用统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.VersionCount))
 {
 if (objViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewpointEN.VersionCount, conViewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.VersionCount); //版本统计
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CreateDate))
 {
 if (objViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conViewpoint.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.CreateDate); //建立日期
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.ShareId))
 {
 if (objViewpointEN.ShareId !=  null)
 {
 var strShareId = objViewpointEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conViewpoint.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.ShareId); //分享Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewpointEN.IsRecommend == true?"1":"0", conViewpoint.IsRecommend); //是否推荐
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.IdCurrEduCls))
 {
 if (objViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conViewpoint.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.CourseId))
 {
 if (objViewpointEN.CourseId !=  null)
 {
 var strCourseId = objViewpointEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conViewpoint.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.CourseId); //课程Id
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UpdUser))
 {
 if (objViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewpoint.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.UpdUser); //修改人
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.UpdDate))
 {
 if (objViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewpoint.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.UpdDate); //修改日期
 }
 }
 
 if (objViewpointEN.IsUpdated(conViewpoint.Memo))
 {
 if (objViewpointEN.Memo !=  null)
 {
 var strMemo = objViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewpoint.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewpoint.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewpointId = '{0}'", objViewpointEN.ViewpointId); 
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
 /// <param name = "strViewpointId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strViewpointId) 
{
CheckPrimaryKey(strViewpointId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strViewpointId,
};
 objSQL.ExecSP("Viewpoint_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strViewpointId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strViewpointId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strViewpointId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
//删除Viewpoint本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Viewpoint where ViewpointId = " + "'"+ strViewpointId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewpoint(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
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
//删除Viewpoint本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Viewpoint where ViewpointId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strViewpointId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strViewpointId) 
{
CheckPrimaryKey(strViewpointId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
//删除Viewpoint本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Viewpoint where ViewpointId = " + "'"+ strViewpointId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewpoint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewpointDA: DelViewpoint)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Viewpoint where " + strCondition ;
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
public bool DelViewpointWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewpointDA: DelViewpointWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewpointDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Viewpoint where " + strCondition ;
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
 /// <param name = "objViewpointENS">源对象</param>
 /// <param name = "objViewpointENT">目标对象</param>
public void CopyTo(clsViewpointEN objViewpointENS, clsViewpointEN objViewpointENT)
{
objViewpointENT.ViewpointId = objViewpointENS.ViewpointId; //观点Id
objViewpointENT.ViewpointName = objViewpointENS.ViewpointName; //观点名称
objViewpointENT.ViewpointContent = objViewpointENS.ViewpointContent; //观点内容
objViewpointENT.ViewpointTypeId = objViewpointENS.ViewpointTypeId; //观点类型Id
objViewpointENT.Reason = objViewpointENS.Reason; //理由
objViewpointENT.Source = objViewpointENS.Source; //来源
objViewpointENT.VPProposePeople = objViewpointENS.VPProposePeople; //观点提出人
objViewpointENT.IsSubmit = objViewpointENS.IsSubmit; //是否提交
objViewpointENT.UserTypeId = objViewpointENS.UserTypeId; //用户类型Id
objViewpointENT.CitationId = objViewpointENS.CitationId; //引用Id
objViewpointENT.AppraiseCount = objViewpointENS.AppraiseCount; //评论数
objViewpointENT.OkCount = objViewpointENS.OkCount; //点赞统计
objViewpointENT.Score = objViewpointENS.Score; //评分
objViewpointENT.StuScore = objViewpointENS.StuScore; //学生平均分
objViewpointENT.TeaScore = objViewpointENS.TeaScore; //教师评分
objViewpointENT.PdfContent = objViewpointENS.PdfContent; //Pdf内容
objViewpointENT.PdfPageNum = objViewpointENS.PdfPageNum; //Pdf页码
objViewpointENT.CitationCount = objViewpointENS.CitationCount; //引用统计
objViewpointENT.VersionCount = objViewpointENS.VersionCount; //版本统计
objViewpointENT.CreateDate = objViewpointENS.CreateDate; //建立日期
objViewpointENT.ShareId = objViewpointENS.ShareId; //分享Id
objViewpointENT.IsRecommend = objViewpointENS.IsRecommend; //是否推荐
objViewpointENT.IdCurrEduCls = objViewpointENS.IdCurrEduCls; //教学班流水号
objViewpointENT.CourseId = objViewpointENS.CourseId; //课程Id
objViewpointENT.UpdUser = objViewpointENS.UpdUser; //修改人
objViewpointENT.UpdDate = objViewpointENS.UpdDate; //修改日期
objViewpointENT.Memo = objViewpointENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewpointEN objViewpointEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objViewpointEN.ViewpointId, 8, conViewpoint.ViewpointId);
clsCheckSql.CheckFieldLen(objViewpointEN.ViewpointName, 500, conViewpoint.ViewpointName);
clsCheckSql.CheckFieldLen(objViewpointEN.ViewpointTypeId, 4, conViewpoint.ViewpointTypeId);
clsCheckSql.CheckFieldLen(objViewpointEN.Source, 500, conViewpoint.Source);
clsCheckSql.CheckFieldLen(objViewpointEN.VPProposePeople, 50, conViewpoint.VPProposePeople);
clsCheckSql.CheckFieldLen(objViewpointEN.UserTypeId, 2, conViewpoint.UserTypeId);
clsCheckSql.CheckFieldLen(objViewpointEN.CitationId, 8, conViewpoint.CitationId);
clsCheckSql.CheckFieldLen(objViewpointEN.PdfContent, 2000, conViewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objViewpointEN.CreateDate, 20, conViewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objViewpointEN.ShareId, 2, conViewpoint.ShareId);
clsCheckSql.CheckFieldLen(objViewpointEN.IdCurrEduCls, 8, conViewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objViewpointEN.CourseId, 8, conViewpoint.CourseId);
clsCheckSql.CheckFieldLen(objViewpointEN.UpdUser, 20, conViewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objViewpointEN.UpdDate, 20, conViewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objViewpointEN.Memo, 1000, conViewpoint.Memo);
//检查字段外键固定长度
 objViewpointEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewpointEN objViewpointEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewpointEN.ViewpointName, 500, conViewpoint.ViewpointName);
clsCheckSql.CheckFieldLen(objViewpointEN.ViewpointTypeId, 4, conViewpoint.ViewpointTypeId);
clsCheckSql.CheckFieldLen(objViewpointEN.Source, 500, conViewpoint.Source);
clsCheckSql.CheckFieldLen(objViewpointEN.VPProposePeople, 50, conViewpoint.VPProposePeople);
clsCheckSql.CheckFieldLen(objViewpointEN.UserTypeId, 2, conViewpoint.UserTypeId);
clsCheckSql.CheckFieldLen(objViewpointEN.CitationId, 8, conViewpoint.CitationId);
clsCheckSql.CheckFieldLen(objViewpointEN.PdfContent, 2000, conViewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objViewpointEN.CreateDate, 20, conViewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objViewpointEN.ShareId, 2, conViewpoint.ShareId);
clsCheckSql.CheckFieldLen(objViewpointEN.IdCurrEduCls, 8, conViewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objViewpointEN.CourseId, 8, conViewpoint.CourseId);
clsCheckSql.CheckFieldLen(objViewpointEN.UpdUser, 20, conViewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objViewpointEN.UpdDate, 20, conViewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objViewpointEN.Memo, 1000, conViewpoint.Memo);
//检查外键字段长度
 objViewpointEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewpointEN objViewpointEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewpointEN.ViewpointId, 8, conViewpoint.ViewpointId);
clsCheckSql.CheckFieldLen(objViewpointEN.ViewpointName, 500, conViewpoint.ViewpointName);
clsCheckSql.CheckFieldLen(objViewpointEN.ViewpointTypeId, 4, conViewpoint.ViewpointTypeId);
clsCheckSql.CheckFieldLen(objViewpointEN.Source, 500, conViewpoint.Source);
clsCheckSql.CheckFieldLen(objViewpointEN.VPProposePeople, 50, conViewpoint.VPProposePeople);
clsCheckSql.CheckFieldLen(objViewpointEN.UserTypeId, 2, conViewpoint.UserTypeId);
clsCheckSql.CheckFieldLen(objViewpointEN.CitationId, 8, conViewpoint.CitationId);
clsCheckSql.CheckFieldLen(objViewpointEN.PdfContent, 2000, conViewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objViewpointEN.CreateDate, 20, conViewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objViewpointEN.ShareId, 2, conViewpoint.ShareId);
clsCheckSql.CheckFieldLen(objViewpointEN.IdCurrEduCls, 8, conViewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objViewpointEN.CourseId, 8, conViewpoint.CourseId);
clsCheckSql.CheckFieldLen(objViewpointEN.UpdUser, 20, conViewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objViewpointEN.UpdDate, 20, conViewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objViewpointEN.Memo, 1000, conViewpoint.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.ViewpointId, conViewpoint.ViewpointId);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.ViewpointName, conViewpoint.ViewpointName);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.ViewpointTypeId, conViewpoint.ViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.Source, conViewpoint.Source);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.VPProposePeople, conViewpoint.VPProposePeople);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.UserTypeId, conViewpoint.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.CitationId, conViewpoint.CitationId);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.PdfContent, conViewpoint.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.CreateDate, conViewpoint.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.ShareId, conViewpoint.ShareId);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.IdCurrEduCls, conViewpoint.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.CourseId, conViewpoint.CourseId);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.UpdUser, conViewpoint.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.UpdDate, conViewpoint.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objViewpointEN.Memo, conViewpoint.Memo);
//检查外键字段长度
 objViewpointEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetViewpointId()
{
//获取某学院所有专业信息
string strSQL = "select ViewpointId, ViewpointName from Viewpoint ";
 clsSpecSQLforSql mySql = clsViewpointDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Viewpoint(观点表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewpointEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsViewpointEN objViewpointEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objViewpointEN.ViewpointId);
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
 objSQL = clsViewpointDA.GetSpecSQLObj();
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
 objSQL = clsViewpointDA.GetSpecSQLObj();
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
 objSQL = clsViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewpointEN._CurrTabName);
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
 objSQL = clsViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewpointEN._CurrTabName, strCondition);
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
 objSQL = clsViewpointDA.GetSpecSQLObj();
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
 objSQL = clsViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}