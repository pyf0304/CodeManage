
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTViewpointRelaDA
 表名:vRTViewpointRela(01120541)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// v主题观点关系(vRTViewpointRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvRTViewpointRelaDA : clsCommBase4DA
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
 return clsvRTViewpointRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvRTViewpointRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTViewpointRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvRTViewpointRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvRTViewpointRelaEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvRTViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vRTViewpointRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvRTViewpointRelaDA: GetDataTable_vRTViewpointRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpointRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvRTViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvRTViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpointRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvRTViewpointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvRTViewpointRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpointRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpointRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvRTViewpointRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vRTViewpointRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvRTViewpointRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTViewpointRela.* from vRTViewpointRela Left Join {1} on {2} where {3} and vRTViewpointRela.mId not in (Select top {5} vRTViewpointRela.mId from vRTViewpointRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpointRela where {1} and mId not in (Select top {2} mId from vRTViewpointRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpointRela where {1} and mId not in (Select top {3} mId from vRTViewpointRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvRTViewpointRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTViewpointRela.* from vRTViewpointRela Left Join {1} on {2} where {3} and vRTViewpointRela.mId not in (Select top {5} vRTViewpointRela.mId from vRTViewpointRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpointRela where {1} and mId not in (Select top {2} mId from vRTViewpointRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpointRela where {1} and mId not in (Select top {3} mId from vRTViewpointRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvRTViewpointRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvRTViewpointRelaDA:GetObjLst)", objException.Message));
}
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = TransNullToInt(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = TransNullToBool(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = TransNullToBool(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTViewpointRelaDA: GetObjLst)", objException.Message));
}
objvRTViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTViewpointRelaEN);
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
public List<clsvRTViewpointRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvRTViewpointRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = TransNullToInt(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = TransNullToBool(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = TransNullToBool(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTViewpointRelaDA: GetObjLst)", objException.Message));
}
objvRTViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTViewpointRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvRTViewpointRela(ref clsvRTViewpointRelaEN objvRTViewpointRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpointRela where mId = " + ""+ objvRTViewpointRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvRTViewpointRelaEN.mId = TransNullToInt(objDT.Rows[0][convRTViewpointRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.ViewpointName = objDT.Rows[0][convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvRTViewpointRelaEN.ViewpointContent = objDT.Rows[0][convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTViewpointRelaEN.ViewpointId = objDT.Rows[0][convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.ProposePeople = objDT.Rows[0][convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointRelaEN.ViewpointTypeId = objDT.Rows[0][convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.ViewpointTypeName = objDT.Rows[0][convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointRelaEN.Reason = objDT.Rows[0][convRTViewpointRela.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTViewpointRelaEN.Source = objDT.Rows[0][convRTViewpointRela.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objvRTViewpointRelaEN.TopicId = objDT.Rows[0][convRTViewpointRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.TopicName = objDT.Rows[0][convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTViewpointRelaEN.TopicContent = objDT.Rows[0][convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTViewpointRelaEN.TopicProposePeople = objDT.Rows[0][convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointRelaEN.UpdDate = objDT.Rows[0][convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.UpdUser = objDT.Rows[0][convRTViewpointRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.Memo = objDT.Rows[0][convRTViewpointRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTViewpointRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTViewpointRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.OkCount = TransNullToInt(objDT.Rows[0][convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.Score = TransNullToFloat(objDT.Rows[0][convRTViewpointRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.UserTypeId = objDT.Rows[0][convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTViewpointRelaEN.UserTypeName = objDT.Rows[0][convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.CitationCount = TransNullToInt(objDT.Rows[0][convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.CitationId = objDT.Rows[0][convRTViewpointRela.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.ViewsDate = objDT.Rows[0][convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.ViewsUserId = objDT.Rows[0][convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.IdCurrEduCls = objDT.Rows[0][convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTViewpointRelaEN.PdfContent = objDT.Rows[0][convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTViewpointRelaEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.VersionCount = TransNullToInt(objDT.Rows[0][convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.CreateDate = objDT.Rows[0][convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.ShareId = objDT.Rows[0][convRTViewpointRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTViewpointRelaEN.IsRecommend = TransNullToBool(objDT.Rows[0][convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objvRTViewpointRelaEN.ClassificationId = objDT.Rows[0][convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvRTViewpointRelaDA: GetvRTViewpointRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvRTViewpointRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpointRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
 objvRTViewpointRelaEN.mId = Int32.Parse(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTViewpointRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvRTViewpointRelaDA: GetObjBymId)", objException.Message));
}
return objvRTViewpointRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvRTViewpointRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvRTViewpointRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN()
{
mId = TransNullToInt(objRow[convRTViewpointRela.mId].ToString().Trim()), //mId
ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(), //观点名称
ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(), //观点内容
ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(), //观点Id
ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(), //提出人
ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(), //观点类型Id
ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(), //观点类型名
Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(), //理由
Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(), //来源
TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(), //主题Id
TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(), //栏目主题
TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(), //主题内容
TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(), //主题提出人
UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(), //备注
IsSubmit = TransNullToBool(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()), //评论数
OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.OkCount].ToString().Trim()), //点赞统计
Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.Score].ToString().Trim()), //评分
UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(), //用户类型名称
CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.CitationCount].ToString().Trim()), //引用统计
CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(), //引用Id
StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.TeaScore].ToString().Trim()), //教师评分
ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(), //ViewsDate
ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(), //ViewsUserId
IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()), //Pdf页码
VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.VersionCount].ToString().Trim()), //版本统计
CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(), //分享Id
IsRecommend = TransNullToBool(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()), //是否推荐
ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim() //分类Id
};
objvRTViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTViewpointRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvRTViewpointRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvRTViewpointRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = TransNullToInt(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = TransNullToBool(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = TransNullToBool(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvRTViewpointRelaDA: GetObjByDataRowvRTViewpointRela)", objException.Message));
}
objvRTViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTViewpointRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvRTViewpointRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = TransNullToInt(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = TransNullToBool(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = TransNullToBool(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvRTViewpointRelaDA: GetObjByDataRow)", objException.Message));
}
objvRTViewpointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTViewpointRelaEN;
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
objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTViewpointRelaEN._CurrTabName, convRTViewpointRela.mId, 8, "");
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
objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTViewpointRelaEN._CurrTabName, convRTViewpointRela.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vRTViewpointRela where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vRTViewpointRela where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTViewpointRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvRTViewpointRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTViewpointRela", strCondition))
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
objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vRTViewpointRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvRTViewpointRelaENS">源对象</param>
 /// <param name = "objvRTViewpointRelaENT">目标对象</param>
public void CopyTo(clsvRTViewpointRelaEN objvRTViewpointRelaENS, clsvRTViewpointRelaEN objvRTViewpointRelaENT)
{
objvRTViewpointRelaENT.mId = objvRTViewpointRelaENS.mId; //mId
objvRTViewpointRelaENT.ViewpointName = objvRTViewpointRelaENS.ViewpointName; //观点名称
objvRTViewpointRelaENT.ViewpointContent = objvRTViewpointRelaENS.ViewpointContent; //观点内容
objvRTViewpointRelaENT.ViewpointId = objvRTViewpointRelaENS.ViewpointId; //观点Id
objvRTViewpointRelaENT.ProposePeople = objvRTViewpointRelaENS.ProposePeople; //提出人
objvRTViewpointRelaENT.ViewpointTypeId = objvRTViewpointRelaENS.ViewpointTypeId; //观点类型Id
objvRTViewpointRelaENT.ViewpointTypeName = objvRTViewpointRelaENS.ViewpointTypeName; //观点类型名
objvRTViewpointRelaENT.Reason = objvRTViewpointRelaENS.Reason; //理由
objvRTViewpointRelaENT.Source = objvRTViewpointRelaENS.Source; //来源
objvRTViewpointRelaENT.TopicId = objvRTViewpointRelaENS.TopicId; //主题Id
objvRTViewpointRelaENT.TopicName = objvRTViewpointRelaENS.TopicName; //栏目主题
objvRTViewpointRelaENT.TopicContent = objvRTViewpointRelaENS.TopicContent; //主题内容
objvRTViewpointRelaENT.TopicProposePeople = objvRTViewpointRelaENS.TopicProposePeople; //主题提出人
objvRTViewpointRelaENT.UpdDate = objvRTViewpointRelaENS.UpdDate; //修改日期
objvRTViewpointRelaENT.UpdUser = objvRTViewpointRelaENS.UpdUser; //修改人
objvRTViewpointRelaENT.Memo = objvRTViewpointRelaENS.Memo; //备注
objvRTViewpointRelaENT.IsSubmit = objvRTViewpointRelaENS.IsSubmit; //是否提交
objvRTViewpointRelaENT.AppraiseCount = objvRTViewpointRelaENS.AppraiseCount; //评论数
objvRTViewpointRelaENT.OkCount = objvRTViewpointRelaENS.OkCount; //点赞统计
objvRTViewpointRelaENT.Score = objvRTViewpointRelaENS.Score; //评分
objvRTViewpointRelaENT.UserTypeId = objvRTViewpointRelaENS.UserTypeId; //用户类型Id
objvRTViewpointRelaENT.UserTypeName = objvRTViewpointRelaENS.UserTypeName; //用户类型名称
objvRTViewpointRelaENT.CitationCount = objvRTViewpointRelaENS.CitationCount; //引用统计
objvRTViewpointRelaENT.CitationId = objvRTViewpointRelaENS.CitationId; //引用Id
objvRTViewpointRelaENT.StuScore = objvRTViewpointRelaENS.StuScore; //学生平均分
objvRTViewpointRelaENT.TeaScore = objvRTViewpointRelaENS.TeaScore; //教师评分
objvRTViewpointRelaENT.ViewsDate = objvRTViewpointRelaENS.ViewsDate; //ViewsDate
objvRTViewpointRelaENT.ViewsUserId = objvRTViewpointRelaENS.ViewsUserId; //ViewsUserId
objvRTViewpointRelaENT.IdCurrEduCls = objvRTViewpointRelaENS.IdCurrEduCls; //教学班流水号
objvRTViewpointRelaENT.PdfContent = objvRTViewpointRelaENS.PdfContent; //Pdf内容
objvRTViewpointRelaENT.PdfPageNum = objvRTViewpointRelaENS.PdfPageNum; //Pdf页码
objvRTViewpointRelaENT.VersionCount = objvRTViewpointRelaENS.VersionCount; //版本统计
objvRTViewpointRelaENT.CreateDate = objvRTViewpointRelaENS.CreateDate; //建立日期
objvRTViewpointRelaENT.ShareId = objvRTViewpointRelaENS.ShareId; //分享Id
objvRTViewpointRelaENT.IsRecommend = objvRTViewpointRelaENS.IsRecommend; //是否推荐
objvRTViewpointRelaENT.ClassificationId = objvRTViewpointRelaENS.ClassificationId; //分类Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvRTViewpointRelaEN objvRTViewpointRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.ViewpointName, 500, convRTViewpointRela.ViewpointName);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.ViewpointId, 8, convRTViewpointRela.ViewpointId);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.ProposePeople, 50, convRTViewpointRela.ProposePeople);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.ViewpointTypeId, 4, convRTViewpointRela.ViewpointTypeId);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.ViewpointTypeName, 50, convRTViewpointRela.ViewpointTypeName);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.Source, 500, convRTViewpointRela.Source);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.TopicId, 8, convRTViewpointRela.TopicId);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.TopicName, 200, convRTViewpointRela.TopicName);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.TopicProposePeople, 50, convRTViewpointRela.TopicProposePeople);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.UpdDate, 20, convRTViewpointRela.UpdDate);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.UpdUser, 20, convRTViewpointRela.UpdUser);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.Memo, 1000, convRTViewpointRela.Memo);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.UserTypeId, 2, convRTViewpointRela.UserTypeId);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.UserTypeName, 20, convRTViewpointRela.UserTypeName);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.CitationId, 8, convRTViewpointRela.CitationId);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.ViewsDate, 20, convRTViewpointRela.ViewsDate);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.ViewsUserId, 20, convRTViewpointRela.ViewsUserId);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.IdCurrEduCls, 8, convRTViewpointRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.PdfContent, 2000, convRTViewpointRela.PdfContent);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.CreateDate, 20, convRTViewpointRela.CreateDate);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.ShareId, 2, convRTViewpointRela.ShareId);
clsCheckSql.CheckFieldLen(objvRTViewpointRelaEN.ClassificationId, 10, convRTViewpointRela.ClassificationId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.ViewpointName, convRTViewpointRela.ViewpointName);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.ViewpointId, convRTViewpointRela.ViewpointId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.ProposePeople, convRTViewpointRela.ProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.ViewpointTypeId, convRTViewpointRela.ViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.ViewpointTypeName, convRTViewpointRela.ViewpointTypeName);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.Source, convRTViewpointRela.Source);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.TopicId, convRTViewpointRela.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.TopicName, convRTViewpointRela.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.TopicProposePeople, convRTViewpointRela.TopicProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.UpdDate, convRTViewpointRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.UpdUser, convRTViewpointRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.Memo, convRTViewpointRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.UserTypeId, convRTViewpointRela.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.UserTypeName, convRTViewpointRela.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.CitationId, convRTViewpointRela.CitationId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.ViewsDate, convRTViewpointRela.ViewsDate);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.ViewsUserId, convRTViewpointRela.ViewsUserId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.IdCurrEduCls, convRTViewpointRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.PdfContent, convRTViewpointRela.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.CreateDate, convRTViewpointRela.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.ShareId, convRTViewpointRela.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointRelaEN.ClassificationId, convRTViewpointRela.ClassificationId);
//检查外键字段长度
 objvRTViewpointRelaEN._IsCheckProperty = true;
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
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTViewpointRelaEN._CurrTabName);
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
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTViewpointRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvRTViewpointRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}