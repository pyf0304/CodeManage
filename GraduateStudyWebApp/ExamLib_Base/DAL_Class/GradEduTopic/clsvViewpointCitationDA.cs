
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointCitationDA
 表名:vViewpointCitation(01120594)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:40
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
 /// v观点引用(vViewpointCitation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewpointCitationDA : clsCommBase4DA
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
 return clsvViewpointCitationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewpointCitationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewpointCitationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvViewpointCitationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewpointCitationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewpointCitationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointCitation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewpointCitation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewpointCitationDA: GetDataTable_vViewpointCitation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointCitation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewpointCitationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewpointCitationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointCitation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewpointCitationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewpointCitationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewpointCitation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewpointCitation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewpointCitationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewpointCitation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewpointCitationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vViewpointCitation.* from vViewpointCitation Left Join {1} on {2} where {3} and vViewpointCitation.mId not in (Select top {5} vViewpointCitation.mId from vViewpointCitation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewpointCitation where {1} and mId not in (Select top {2} mId from vViewpointCitation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewpointCitation where {1} and mId not in (Select top {3} mId from vViewpointCitation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewpointCitationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vViewpointCitation.* from vViewpointCitation Left Join {1} on {2} where {3} and vViewpointCitation.mId not in (Select top {5} vViewpointCitation.mId from vViewpointCitation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewpointCitation where {1} and mId not in (Select top {2} mId from vViewpointCitation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewpointCitation where {1} and mId not in (Select top {3} mId from vViewpointCitation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvViewpointCitationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewpointCitationDA:GetObjLst)", objException.Message));
}
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointCitation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = TransNullToInt(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewpointCitationDA: GetObjLst)", objException.Message));
}
objvViewpointCitationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewpointCitationEN);
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
public List<clsvViewpointCitationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewpointCitationDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = TransNullToInt(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewpointCitationDA: GetObjLst)", objException.Message));
}
objvViewpointCitationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewpointCitationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewpointCitation(ref clsvViewpointCitationEN objvViewpointCitationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointCitation where mId = " + ""+ objvViewpointCitationEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewpointCitationEN.Memo = objDT.Rows[0][convViewpointCitation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewpointCitationEN.mId = TransNullToInt(objDT.Rows[0][convViewpointCitation.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvViewpointCitationEN.PaperContent = objDT.Rows[0][convViewpointCitation.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointCitationEN.PaperId = objDT.Rows[0][convViewpointCitation.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointCitationEN.PaperTitle = objDT.Rows[0][convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewpointCitationEN.Reason = objDT.Rows[0][convViewpointCitation.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointCitationEN.UpdUserId = objDT.Rows[0][convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointCitationEN.UserName = objDT.Rows[0][convViewpointCitation.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewpointCitationEN.ViewpointId = objDT.Rows[0][convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointCitationEN.ViewpointName = objDT.Rows[0][convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointCitationEN.ViewpointTypeId = objDT.Rows[0][convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvViewpointCitationEN.ViewpointTypeName = objDT.Rows[0][convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointCitationEN.UpdDate = objDT.Rows[0][convViewpointCitation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointCitationEN.ProposePeople = objDT.Rows[0][convViewpointCitation.ProposePeople].ToString().Trim(); //提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointCitationEN.Source = objDT.Rows[0][convViewpointCitation.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointCitationEN.TopicId = objDT.Rows[0][convViewpointCitation.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointCitationEN.TopicName = objDT.Rows[0][convViewpointCitation.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewpointCitationDA: GetvViewpointCitation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewpointCitationEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointCitation where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
 objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewpointCitationEN.mId = Int32.Parse(objRow[convViewpointCitation.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewpointCitationDA: GetObjBymId)", objException.Message));
}
return objvViewpointCitationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewpointCitationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewpointCitationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointCitation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN()
{
Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(), //备注
mId = TransNullToInt(objRow[convViewpointCitation.mId].ToString().Trim()), //mId
PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(), //主题内容
PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(), //论文标题
Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(), //理由
UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(), //修改用户Id
UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(), //用户名
ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(), //观点Id
ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(), //观点名称
ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(), //观点类型Id
ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(), //观点类型名
UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(), //修改日期
ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(), //提出人
Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(), //来源
TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(), //主题Id
TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim() //栏目主题
};
objvViewpointCitationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewpointCitationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewpointCitationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewpointCitationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = TransNullToInt(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewpointCitationDA: GetObjByDataRowvViewpointCitation)", objException.Message));
}
objvViewpointCitationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewpointCitationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewpointCitationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = TransNullToInt(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewpointCitationDA: GetObjByDataRow)", objException.Message));
}
objvViewpointCitationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewpointCitationEN;
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
objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewpointCitationEN._CurrTabName, convViewpointCitation.mId, 8, "");
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
objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewpointCitationEN._CurrTabName, convViewpointCitation.mId, 8, strPrefix);
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
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vViewpointCitation where " + strCondition;
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
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vViewpointCitation where " + strCondition;
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
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewpointCitation", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewpointCitationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewpointCitation", strCondition))
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
objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewpointCitation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsvViewpointCitationEN objvViewpointCitationEN)
 {
 objvViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objvViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objvViewpointCitationEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointCitation where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "vViewpointCitation");
objRow = objDS.Tables["vViewpointCitation"].NewRow();
 if (objvViewpointCitationEN.Memo !=  "")
 {
objRow[convViewpointCitation.Memo] = objvViewpointCitationEN.Memo; //备注
 }
 if (objvViewpointCitationEN.PaperContent !=  "")
 {
objRow[convViewpointCitation.PaperContent] = objvViewpointCitationEN.PaperContent; //主题内容
 }
 if (objvViewpointCitationEN.PaperId !=  "")
 {
objRow[convViewpointCitation.PaperId] = objvViewpointCitationEN.PaperId; //论文Id
 }
 if (objvViewpointCitationEN.PaperTitle !=  "")
 {
objRow[convViewpointCitation.PaperTitle] = objvViewpointCitationEN.PaperTitle; //论文标题
 }
 if (objvViewpointCitationEN.Reason !=  "")
 {
objRow[convViewpointCitation.Reason] = objvViewpointCitationEN.Reason; //理由
 }
 if (objvViewpointCitationEN.UpdUserId !=  "")
 {
objRow[convViewpointCitation.UpdUserId] = objvViewpointCitationEN.UpdUserId; //修改用户Id
 }
 if (objvViewpointCitationEN.UserName !=  "")
 {
objRow[convViewpointCitation.UserName] = objvViewpointCitationEN.UserName; //用户名
 }
 if (objvViewpointCitationEN.ViewpointId !=  "")
 {
objRow[convViewpointCitation.ViewpointId] = objvViewpointCitationEN.ViewpointId; //观点Id
 }
 if (objvViewpointCitationEN.ViewpointName !=  "")
 {
objRow[convViewpointCitation.ViewpointName] = objvViewpointCitationEN.ViewpointName; //观点名称
 }
 if (objvViewpointCitationEN.ViewpointTypeId !=  "")
 {
objRow[convViewpointCitation.ViewpointTypeId] = objvViewpointCitationEN.ViewpointTypeId; //观点类型Id
 }
 if (objvViewpointCitationEN.ViewpointTypeName !=  "")
 {
objRow[convViewpointCitation.ViewpointTypeName] = objvViewpointCitationEN.ViewpointTypeName; //观点类型名
 }
 if (objvViewpointCitationEN.UpdDate !=  "")
 {
objRow[convViewpointCitation.UpdDate] = objvViewpointCitationEN.UpdDate; //修改日期
 }
 if (objvViewpointCitationEN.ProposePeople !=  "")
 {
objRow[convViewpointCitation.ProposePeople] = objvViewpointCitationEN.ProposePeople; //提出人
 }
 if (objvViewpointCitationEN.Source !=  "")
 {
objRow[convViewpointCitation.Source] = objvViewpointCitationEN.Source; //来源
 }
 if (objvViewpointCitationEN.TopicId !=  "")
 {
objRow[convViewpointCitation.TopicId] = objvViewpointCitationEN.TopicId; //主题Id
 }
 if (objvViewpointCitationEN.TopicName !=  "")
 {
objRow[convViewpointCitation.TopicName] = objvViewpointCitationEN.TopicName; //栏目主题
 }
objDS.Tables[clsvViewpointCitationEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsvViewpointCitationEN._CurrTabName);
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
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsvViewpointCitationEN objvViewpointCitationEN)
{
 objvViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objvViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objvViewpointCitationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objvViewpointCitationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Memo);
 var strMemo = objvViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 
 if (objvViewpointCitationEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperContent);
 var strPaperContent = objvViewpointCitationEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objvViewpointCitationEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperId);
 var strPaperId = objvViewpointCitationEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objvViewpointCitationEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperTitle);
 var strPaperTitle = objvViewpointCitationEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objvViewpointCitationEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Reason);
 var strReason = objvViewpointCitationEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objvViewpointCitationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UpdUserId);
 var strUpdUserId = objvViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objvViewpointCitationEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UserName);
 var strUserName = objvViewpointCitationEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointId);
 var strViewpointId = objvViewpointCitationEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointName);
 var strViewpointName = objvViewpointCitationEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointTypeId);
 var strViewpointTypeId = objvViewpointCitationEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeId + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointTypeName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointTypeName);
 var strViewpointTypeName = objvViewpointCitationEN.ViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeName + "'");
 }
 
 if (objvViewpointCitationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UpdDate);
 var strUpdDate = objvViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objvViewpointCitationEN.ProposePeople !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ProposePeople);
 var strProposePeople = objvViewpointCitationEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProposePeople + "'");
 }
 
 if (objvViewpointCitationEN.Source !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Source);
 var strSource = objvViewpointCitationEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objvViewpointCitationEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.TopicId);
 var strTopicId = objvViewpointCitationEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objvViewpointCitationEN.TopicName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.TopicName);
 var strTopicName = objvViewpointCitationEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into vViewpointCitation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsvViewpointCitationEN objvViewpointCitationEN)
{
 objvViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objvViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objvViewpointCitationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objvViewpointCitationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Memo);
 var strMemo = objvViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 
 if (objvViewpointCitationEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperContent);
 var strPaperContent = objvViewpointCitationEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objvViewpointCitationEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperId);
 var strPaperId = objvViewpointCitationEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objvViewpointCitationEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperTitle);
 var strPaperTitle = objvViewpointCitationEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objvViewpointCitationEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Reason);
 var strReason = objvViewpointCitationEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objvViewpointCitationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UpdUserId);
 var strUpdUserId = objvViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objvViewpointCitationEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UserName);
 var strUserName = objvViewpointCitationEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointId);
 var strViewpointId = objvViewpointCitationEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointName);
 var strViewpointName = objvViewpointCitationEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointTypeId);
 var strViewpointTypeId = objvViewpointCitationEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeId + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointTypeName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointTypeName);
 var strViewpointTypeName = objvViewpointCitationEN.ViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeName + "'");
 }
 
 if (objvViewpointCitationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UpdDate);
 var strUpdDate = objvViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objvViewpointCitationEN.ProposePeople !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ProposePeople);
 var strProposePeople = objvViewpointCitationEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProposePeople + "'");
 }
 
 if (objvViewpointCitationEN.Source !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Source);
 var strSource = objvViewpointCitationEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objvViewpointCitationEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.TopicId);
 var strTopicId = objvViewpointCitationEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objvViewpointCitationEN.TopicName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.TopicName);
 var strTopicName = objvViewpointCitationEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into vViewpointCitation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsvViewpointCitationEN objvViewpointCitationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objvViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objvViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objvViewpointCitationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objvViewpointCitationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Memo);
 var strMemo = objvViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 
 if (objvViewpointCitationEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperContent);
 var strPaperContent = objvViewpointCitationEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objvViewpointCitationEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperId);
 var strPaperId = objvViewpointCitationEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objvViewpointCitationEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperTitle);
 var strPaperTitle = objvViewpointCitationEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objvViewpointCitationEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Reason);
 var strReason = objvViewpointCitationEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objvViewpointCitationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UpdUserId);
 var strUpdUserId = objvViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objvViewpointCitationEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UserName);
 var strUserName = objvViewpointCitationEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointId);
 var strViewpointId = objvViewpointCitationEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointName);
 var strViewpointName = objvViewpointCitationEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointTypeId);
 var strViewpointTypeId = objvViewpointCitationEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeId + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointTypeName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointTypeName);
 var strViewpointTypeName = objvViewpointCitationEN.ViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeName + "'");
 }
 
 if (objvViewpointCitationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UpdDate);
 var strUpdDate = objvViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objvViewpointCitationEN.ProposePeople !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ProposePeople);
 var strProposePeople = objvViewpointCitationEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProposePeople + "'");
 }
 
 if (objvViewpointCitationEN.Source !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Source);
 var strSource = objvViewpointCitationEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objvViewpointCitationEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.TopicId);
 var strTopicId = objvViewpointCitationEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objvViewpointCitationEN.TopicName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.TopicName);
 var strTopicName = objvViewpointCitationEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into vViewpointCitation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsvViewpointCitationEN objvViewpointCitationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objvViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objvViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objvViewpointCitationEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objvViewpointCitationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Memo);
 var strMemo = objvViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 
 if (objvViewpointCitationEN.PaperContent !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperContent);
 var strPaperContent = objvViewpointCitationEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperContent + "'");
 }
 
 if (objvViewpointCitationEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperId);
 var strPaperId = objvViewpointCitationEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objvViewpointCitationEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.PaperTitle);
 var strPaperTitle = objvViewpointCitationEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objvViewpointCitationEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Reason);
 var strReason = objvViewpointCitationEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objvViewpointCitationEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UpdUserId);
 var strUpdUserId = objvViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objvViewpointCitationEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UserName);
 var strUserName = objvViewpointCitationEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointId);
 var strViewpointId = objvViewpointCitationEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointId + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointName);
 var strViewpointName = objvViewpointCitationEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointTypeId);
 var strViewpointTypeId = objvViewpointCitationEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeId + "'");
 }
 
 if (objvViewpointCitationEN.ViewpointTypeName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ViewpointTypeName);
 var strViewpointTypeName = objvViewpointCitationEN.ViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointTypeName + "'");
 }
 
 if (objvViewpointCitationEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.UpdDate);
 var strUpdDate = objvViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objvViewpointCitationEN.ProposePeople !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.ProposePeople);
 var strProposePeople = objvViewpointCitationEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProposePeople + "'");
 }
 
 if (objvViewpointCitationEN.Source !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.Source);
 var strSource = objvViewpointCitationEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objvViewpointCitationEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.TopicId);
 var strTopicId = objvViewpointCitationEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objvViewpointCitationEN.TopicName !=  null)
 {
 arrFieldListForInsert.Add(convViewpointCitation.TopicName);
 var strTopicName = objvViewpointCitationEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into vViewpointCitation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewvViewpointCitations(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointCitation where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "vViewpointCitation");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsvViewpointCitationEN._CurrTabName ].NewRow();
objRow[convViewpointCitation.Memo] = oRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objRow[convViewpointCitation.PaperContent] = oRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objRow[convViewpointCitation.PaperId] = oRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objRow[convViewpointCitation.PaperTitle] = oRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objRow[convViewpointCitation.Reason] = oRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objRow[convViewpointCitation.UpdUserId] = oRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objRow[convViewpointCitation.UserName] = oRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objRow[convViewpointCitation.ViewpointId] = oRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objRow[convViewpointCitation.ViewpointName] = oRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objRow[convViewpointCitation.ViewpointTypeId] = oRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objRow[convViewpointCitation.ViewpointTypeName] = oRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objRow[convViewpointCitation.UpdDate] = oRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objRow[convViewpointCitation.ProposePeople] = oRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objRow[convViewpointCitation.Source] = oRow[convViewpointCitation.Source].ToString().Trim(); //来源
objRow[convViewpointCitation.TopicId] = oRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objRow[convViewpointCitation.TopicName] = oRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
 objDS.Tables[clsvViewpointCitationEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsvViewpointCitationEN._CurrTabName);
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
 /// <param name = "objvViewpointCitationEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsvViewpointCitationEN objvViewpointCitationEN)
{
 objvViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objvViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objvViewpointCitationEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointCitation where mId = " + ""+ objvViewpointCitationEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsvViewpointCitationEN._CurrTabName);
if (objDS.Tables[clsvViewpointCitationEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objvViewpointCitationEN.mId+"");
return false;
}
objRow = objDS.Tables[clsvViewpointCitationEN._CurrTabName].Rows[0];
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Memo))
 {
objRow[convViewpointCitation.Memo] = objvViewpointCitationEN.Memo; //备注
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperContent))
 {
objRow[convViewpointCitation.PaperContent] = objvViewpointCitationEN.PaperContent; //主题内容
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperId))
 {
objRow[convViewpointCitation.PaperId] = objvViewpointCitationEN.PaperId; //论文Id
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperTitle))
 {
objRow[convViewpointCitation.PaperTitle] = objvViewpointCitationEN.PaperTitle; //论文标题
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Reason))
 {
objRow[convViewpointCitation.Reason] = objvViewpointCitationEN.Reason; //理由
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UpdUserId))
 {
objRow[convViewpointCitation.UpdUserId] = objvViewpointCitationEN.UpdUserId; //修改用户Id
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UserName))
 {
objRow[convViewpointCitation.UserName] = objvViewpointCitationEN.UserName; //用户名
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointId))
 {
objRow[convViewpointCitation.ViewpointId] = objvViewpointCitationEN.ViewpointId; //观点Id
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointName))
 {
objRow[convViewpointCitation.ViewpointName] = objvViewpointCitationEN.ViewpointName; //观点名称
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointTypeId))
 {
objRow[convViewpointCitation.ViewpointTypeId] = objvViewpointCitationEN.ViewpointTypeId; //观点类型Id
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointTypeName))
 {
objRow[convViewpointCitation.ViewpointTypeName] = objvViewpointCitationEN.ViewpointTypeName; //观点类型名
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UpdDate))
 {
objRow[convViewpointCitation.UpdDate] = objvViewpointCitationEN.UpdDate; //修改日期
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ProposePeople))
 {
objRow[convViewpointCitation.ProposePeople] = objvViewpointCitationEN.ProposePeople; //提出人
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Source))
 {
objRow[convViewpointCitation.Source] = objvViewpointCitationEN.Source; //来源
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.TopicId))
 {
objRow[convViewpointCitation.TopicId] = objvViewpointCitationEN.TopicId; //主题Id
 }
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.TopicName))
 {
objRow[convViewpointCitation.TopicName] = objvViewpointCitationEN.TopicName; //栏目主题
 }
try
{
objDA.Update(objDS, clsvViewpointCitationEN._CurrTabName);
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
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsvViewpointCitationEN objvViewpointCitationEN)
{
 objvViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objvViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objvViewpointCitationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update vViewpointCitation Set ");
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Memo))
 {
 if (objvViewpointCitationEN.Memo !=  null)
 {
 var strMemo = objvViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, convViewpointCitation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.Memo); //备注
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperContent))
 {
 if (objvViewpointCitationEN.PaperContent !=  null)
 {
 var strPaperContent = objvViewpointCitationEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperContent, convViewpointCitation.PaperContent); //主题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.PaperContent); //主题内容
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperId))
 {
 if (objvViewpointCitationEN.PaperId !=  null)
 {
 var strPaperId = objvViewpointCitationEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, convViewpointCitation.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.PaperId); //论文Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperTitle))
 {
 if (objvViewpointCitationEN.PaperTitle !=  null)
 {
 var strPaperTitle = objvViewpointCitationEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTitle, convViewpointCitation.PaperTitle); //论文标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.PaperTitle); //论文标题
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Reason))
 {
 if (objvViewpointCitationEN.Reason !=  null)
 {
 var strReason = objvViewpointCitationEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReason, convViewpointCitation.Reason); //理由
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.Reason); //理由
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UpdUserId))
 {
 if (objvViewpointCitationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objvViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, convViewpointCitation.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.UpdUserId); //修改用户Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UserName))
 {
 if (objvViewpointCitationEN.UserName !=  null)
 {
 var strUserName = objvViewpointCitationEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, convViewpointCitation.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.UserName); //用户名
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointId))
 {
 if (objvViewpointCitationEN.ViewpointId !=  null)
 {
 var strViewpointId = objvViewpointCitationEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointId, convViewpointCitation.ViewpointId); //观点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.ViewpointId); //观点Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointName))
 {
 if (objvViewpointCitationEN.ViewpointName !=  null)
 {
 var strViewpointName = objvViewpointCitationEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointName, convViewpointCitation.ViewpointName); //观点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.ViewpointName); //观点名称
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointTypeId))
 {
 if (objvViewpointCitationEN.ViewpointTypeId !=  null)
 {
 var strViewpointTypeId = objvViewpointCitationEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointTypeId, convViewpointCitation.ViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.ViewpointTypeId); //观点类型Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointTypeName))
 {
 if (objvViewpointCitationEN.ViewpointTypeName !=  null)
 {
 var strViewpointTypeName = objvViewpointCitationEN.ViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointTypeName, convViewpointCitation.ViewpointTypeName); //观点类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.ViewpointTypeName); //观点类型名
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UpdDate))
 {
 if (objvViewpointCitationEN.UpdDate !=  null)
 {
 var strUpdDate = objvViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, convViewpointCitation.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.UpdDate); //修改日期
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ProposePeople))
 {
 if (objvViewpointCitationEN.ProposePeople !=  null)
 {
 var strProposePeople = objvViewpointCitationEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProposePeople, convViewpointCitation.ProposePeople); //提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.ProposePeople); //提出人
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Source))
 {
 if (objvViewpointCitationEN.Source !=  null)
 {
 var strSource = objvViewpointCitationEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSource, convViewpointCitation.Source); //来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.Source); //来源
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.TopicId))
 {
 if (objvViewpointCitationEN.TopicId !=  null)
 {
 var strTopicId = objvViewpointCitationEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, convViewpointCitation.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.TopicId); //主题Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.TopicName))
 {
 if (objvViewpointCitationEN.TopicName !=  null)
 {
 var strTopicName = objvViewpointCitationEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicName, convViewpointCitation.TopicName); //栏目主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.TopicName); //栏目主题
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objvViewpointCitationEN.mId); 
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
 /// <param name = "objvViewpointCitationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsvViewpointCitationEN objvViewpointCitationEN, string strCondition)
{
 objvViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objvViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objvViewpointCitationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update vViewpointCitation Set ");
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Memo))
 {
 if (objvViewpointCitationEN.Memo !=  null)
 {
 var strMemo = objvViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperContent))
 {
 if (objvViewpointCitationEN.PaperContent !=  null)
 {
 var strPaperContent = objvViewpointCitationEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperContent = '{0}',", strPaperContent); //主题内容
 }
 else
 {
 sbSQL.Append(" PaperContent = null,"); //主题内容
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperId))
 {
 if (objvViewpointCitationEN.PaperId !=  null)
 {
 var strPaperId = objvViewpointCitationEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperTitle))
 {
 if (objvViewpointCitationEN.PaperTitle !=  null)
 {
 var strPaperTitle = objvViewpointCitationEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTitle = '{0}',", strPaperTitle); //论文标题
 }
 else
 {
 sbSQL.Append(" PaperTitle = null,"); //论文标题
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Reason))
 {
 if (objvViewpointCitationEN.Reason !=  null)
 {
 var strReason = objvViewpointCitationEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Reason = '{0}',", strReason); //理由
 }
 else
 {
 sbSQL.Append(" Reason = null,"); //理由
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UpdUserId))
 {
 if (objvViewpointCitationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objvViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UserName))
 {
 if (objvViewpointCitationEN.UserName !=  null)
 {
 var strUserName = objvViewpointCitationEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointId))
 {
 if (objvViewpointCitationEN.ViewpointId !=  null)
 {
 var strViewpointId = objvViewpointCitationEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointId = '{0}',", strViewpointId); //观点Id
 }
 else
 {
 sbSQL.Append(" ViewpointId = null,"); //观点Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointName))
 {
 if (objvViewpointCitationEN.ViewpointName !=  null)
 {
 var strViewpointName = objvViewpointCitationEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointName = '{0}',", strViewpointName); //观点名称
 }
 else
 {
 sbSQL.Append(" ViewpointName = null,"); //观点名称
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointTypeId))
 {
 if (objvViewpointCitationEN.ViewpointTypeId !=  null)
 {
 var strViewpointTypeId = objvViewpointCitationEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointTypeId = '{0}',", strViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.Append(" ViewpointTypeId = null,"); //观点类型Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointTypeName))
 {
 if (objvViewpointCitationEN.ViewpointTypeName !=  null)
 {
 var strViewpointTypeName = objvViewpointCitationEN.ViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointTypeName = '{0}',", strViewpointTypeName); //观点类型名
 }
 else
 {
 sbSQL.Append(" ViewpointTypeName = null,"); //观点类型名
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UpdDate))
 {
 if (objvViewpointCitationEN.UpdDate !=  null)
 {
 var strUpdDate = objvViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ProposePeople))
 {
 if (objvViewpointCitationEN.ProposePeople !=  null)
 {
 var strProposePeople = objvViewpointCitationEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProposePeople = '{0}',", strProposePeople); //提出人
 }
 else
 {
 sbSQL.Append(" ProposePeople = null,"); //提出人
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Source))
 {
 if (objvViewpointCitationEN.Source !=  null)
 {
 var strSource = objvViewpointCitationEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Source = '{0}',", strSource); //来源
 }
 else
 {
 sbSQL.Append(" Source = null,"); //来源
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.TopicId))
 {
 if (objvViewpointCitationEN.TopicId !=  null)
 {
 var strTopicId = objvViewpointCitationEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.TopicName))
 {
 if (objvViewpointCitationEN.TopicName !=  null)
 {
 var strTopicName = objvViewpointCitationEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicName = '{0}',", strTopicName); //栏目主题
 }
 else
 {
 sbSQL.Append(" TopicName = null,"); //栏目主题
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
 /// <param name = "objvViewpointCitationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsvViewpointCitationEN objvViewpointCitationEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objvViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objvViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objvViewpointCitationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update vViewpointCitation Set ");
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Memo))
 {
 if (objvViewpointCitationEN.Memo !=  null)
 {
 var strMemo = objvViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperContent))
 {
 if (objvViewpointCitationEN.PaperContent !=  null)
 {
 var strPaperContent = objvViewpointCitationEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperContent = '{0}',", strPaperContent); //主题内容
 }
 else
 {
 sbSQL.Append(" PaperContent = null,"); //主题内容
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperId))
 {
 if (objvViewpointCitationEN.PaperId !=  null)
 {
 var strPaperId = objvViewpointCitationEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperTitle))
 {
 if (objvViewpointCitationEN.PaperTitle !=  null)
 {
 var strPaperTitle = objvViewpointCitationEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTitle = '{0}',", strPaperTitle); //论文标题
 }
 else
 {
 sbSQL.Append(" PaperTitle = null,"); //论文标题
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Reason))
 {
 if (objvViewpointCitationEN.Reason !=  null)
 {
 var strReason = objvViewpointCitationEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Reason = '{0}',", strReason); //理由
 }
 else
 {
 sbSQL.Append(" Reason = null,"); //理由
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UpdUserId))
 {
 if (objvViewpointCitationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objvViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UserName))
 {
 if (objvViewpointCitationEN.UserName !=  null)
 {
 var strUserName = objvViewpointCitationEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointId))
 {
 if (objvViewpointCitationEN.ViewpointId !=  null)
 {
 var strViewpointId = objvViewpointCitationEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointId = '{0}',", strViewpointId); //观点Id
 }
 else
 {
 sbSQL.Append(" ViewpointId = null,"); //观点Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointName))
 {
 if (objvViewpointCitationEN.ViewpointName !=  null)
 {
 var strViewpointName = objvViewpointCitationEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointName = '{0}',", strViewpointName); //观点名称
 }
 else
 {
 sbSQL.Append(" ViewpointName = null,"); //观点名称
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointTypeId))
 {
 if (objvViewpointCitationEN.ViewpointTypeId !=  null)
 {
 var strViewpointTypeId = objvViewpointCitationEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointTypeId = '{0}',", strViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.Append(" ViewpointTypeId = null,"); //观点类型Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointTypeName))
 {
 if (objvViewpointCitationEN.ViewpointTypeName !=  null)
 {
 var strViewpointTypeName = objvViewpointCitationEN.ViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointTypeName = '{0}',", strViewpointTypeName); //观点类型名
 }
 else
 {
 sbSQL.Append(" ViewpointTypeName = null,"); //观点类型名
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UpdDate))
 {
 if (objvViewpointCitationEN.UpdDate !=  null)
 {
 var strUpdDate = objvViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ProposePeople))
 {
 if (objvViewpointCitationEN.ProposePeople !=  null)
 {
 var strProposePeople = objvViewpointCitationEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProposePeople = '{0}',", strProposePeople); //提出人
 }
 else
 {
 sbSQL.Append(" ProposePeople = null,"); //提出人
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Source))
 {
 if (objvViewpointCitationEN.Source !=  null)
 {
 var strSource = objvViewpointCitationEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Source = '{0}',", strSource); //来源
 }
 else
 {
 sbSQL.Append(" Source = null,"); //来源
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.TopicId))
 {
 if (objvViewpointCitationEN.TopicId !=  null)
 {
 var strTopicId = objvViewpointCitationEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.TopicName))
 {
 if (objvViewpointCitationEN.TopicName !=  null)
 {
 var strTopicName = objvViewpointCitationEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicName = '{0}',", strTopicName); //栏目主题
 }
 else
 {
 sbSQL.Append(" TopicName = null,"); //栏目主题
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
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsvViewpointCitationEN objvViewpointCitationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objvViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objvViewpointCitationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objvViewpointCitationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update vViewpointCitation Set ");
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Memo))
 {
 if (objvViewpointCitationEN.Memo !=  null)
 {
 var strMemo = objvViewpointCitationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, convViewpointCitation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.Memo); //备注
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperContent))
 {
 if (objvViewpointCitationEN.PaperContent !=  null)
 {
 var strPaperContent = objvViewpointCitationEN.PaperContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperContent, convViewpointCitation.PaperContent); //主题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.PaperContent); //主题内容
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperId))
 {
 if (objvViewpointCitationEN.PaperId !=  null)
 {
 var strPaperId = objvViewpointCitationEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, convViewpointCitation.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.PaperId); //论文Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.PaperTitle))
 {
 if (objvViewpointCitationEN.PaperTitle !=  null)
 {
 var strPaperTitle = objvViewpointCitationEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTitle, convViewpointCitation.PaperTitle); //论文标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.PaperTitle); //论文标题
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Reason))
 {
 if (objvViewpointCitationEN.Reason !=  null)
 {
 var strReason = objvViewpointCitationEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReason, convViewpointCitation.Reason); //理由
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.Reason); //理由
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UpdUserId))
 {
 if (objvViewpointCitationEN.UpdUserId !=  null)
 {
 var strUpdUserId = objvViewpointCitationEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, convViewpointCitation.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.UpdUserId); //修改用户Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UserName))
 {
 if (objvViewpointCitationEN.UserName !=  null)
 {
 var strUserName = objvViewpointCitationEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, convViewpointCitation.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.UserName); //用户名
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointId))
 {
 if (objvViewpointCitationEN.ViewpointId !=  null)
 {
 var strViewpointId = objvViewpointCitationEN.ViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointId, convViewpointCitation.ViewpointId); //观点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.ViewpointId); //观点Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointName))
 {
 if (objvViewpointCitationEN.ViewpointName !=  null)
 {
 var strViewpointName = objvViewpointCitationEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointName, convViewpointCitation.ViewpointName); //观点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.ViewpointName); //观点名称
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointTypeId))
 {
 if (objvViewpointCitationEN.ViewpointTypeId !=  null)
 {
 var strViewpointTypeId = objvViewpointCitationEN.ViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointTypeId, convViewpointCitation.ViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.ViewpointTypeId); //观点类型Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ViewpointTypeName))
 {
 if (objvViewpointCitationEN.ViewpointTypeName !=  null)
 {
 var strViewpointTypeName = objvViewpointCitationEN.ViewpointTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointTypeName, convViewpointCitation.ViewpointTypeName); //观点类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.ViewpointTypeName); //观点类型名
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.UpdDate))
 {
 if (objvViewpointCitationEN.UpdDate !=  null)
 {
 var strUpdDate = objvViewpointCitationEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, convViewpointCitation.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.UpdDate); //修改日期
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.ProposePeople))
 {
 if (objvViewpointCitationEN.ProposePeople !=  null)
 {
 var strProposePeople = objvViewpointCitationEN.ProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProposePeople, convViewpointCitation.ProposePeople); //提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.ProposePeople); //提出人
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.Source))
 {
 if (objvViewpointCitationEN.Source !=  null)
 {
 var strSource = objvViewpointCitationEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSource, convViewpointCitation.Source); //来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.Source); //来源
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.TopicId))
 {
 if (objvViewpointCitationEN.TopicId !=  null)
 {
 var strTopicId = objvViewpointCitationEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, convViewpointCitation.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.TopicId); //主题Id
 }
 }
 
 if (objvViewpointCitationEN.IsUpdated(convViewpointCitation.TopicName))
 {
 if (objvViewpointCitationEN.TopicName !=  null)
 {
 var strTopicName = objvViewpointCitationEN.TopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicName, convViewpointCitation.TopicName); //栏目主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",convViewpointCitation.TopicName); //栏目主题
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objvViewpointCitationEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("vViewpointCitation_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
//删除vViewpointCitation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from vViewpointCitation where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelvViewpointCitation(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除vViewpointCitation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from vViewpointCitation where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
//删除vViewpointCitation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from vViewpointCitation where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelvViewpointCitation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsvViewpointCitationDA: DelvViewpointCitation)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from vViewpointCitation where " + strCondition ;
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
public bool DelvViewpointCitationWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsvViewpointCitationDA: DelvViewpointCitationWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from vViewpointCitation where " + strCondition ;
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
 /// <param name = "objvViewpointCitationENS">源对象</param>
 /// <param name = "objvViewpointCitationENT">目标对象</param>
public void CopyTo(clsvViewpointCitationEN objvViewpointCitationENS, clsvViewpointCitationEN objvViewpointCitationENT)
{
objvViewpointCitationENT.Memo = objvViewpointCitationENS.Memo; //备注
objvViewpointCitationENT.mId = objvViewpointCitationENS.mId; //mId
objvViewpointCitationENT.PaperContent = objvViewpointCitationENS.PaperContent; //主题内容
objvViewpointCitationENT.PaperId = objvViewpointCitationENS.PaperId; //论文Id
objvViewpointCitationENT.PaperTitle = objvViewpointCitationENS.PaperTitle; //论文标题
objvViewpointCitationENT.Reason = objvViewpointCitationENS.Reason; //理由
objvViewpointCitationENT.UpdUserId = objvViewpointCitationENS.UpdUserId; //修改用户Id
objvViewpointCitationENT.UserName = objvViewpointCitationENS.UserName; //用户名
objvViewpointCitationENT.ViewpointId = objvViewpointCitationENS.ViewpointId; //观点Id
objvViewpointCitationENT.ViewpointName = objvViewpointCitationENS.ViewpointName; //观点名称
objvViewpointCitationENT.ViewpointTypeId = objvViewpointCitationENS.ViewpointTypeId; //观点类型Id
objvViewpointCitationENT.ViewpointTypeName = objvViewpointCitationENS.ViewpointTypeName; //观点类型名
objvViewpointCitationENT.UpdDate = objvViewpointCitationENS.UpdDate; //修改日期
objvViewpointCitationENT.ProposePeople = objvViewpointCitationENS.ProposePeople; //提出人
objvViewpointCitationENT.Source = objvViewpointCitationENS.Source; //来源
objvViewpointCitationENT.TopicId = objvViewpointCitationENS.TopicId; //主题Id
objvViewpointCitationENT.TopicName = objvViewpointCitationENS.TopicName; //栏目主题
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsvViewpointCitationEN objvViewpointCitationEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.Memo, 1000, convViewpointCitation.Memo);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.PaperId, 8, convViewpointCitation.PaperId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.PaperTitle, 500, convViewpointCitation.PaperTitle);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.UpdUserId, 20, convViewpointCitation.UpdUserId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.UserName, 30, convViewpointCitation.UserName);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointId, 8, convViewpointCitation.ViewpointId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointName, 500, convViewpointCitation.ViewpointName);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointTypeId, 4, convViewpointCitation.ViewpointTypeId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointTypeName, 50, convViewpointCitation.ViewpointTypeName);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.UpdDate, 20, convViewpointCitation.UpdDate);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ProposePeople, 50, convViewpointCitation.ProposePeople);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.Source, 500, convViewpointCitation.Source);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.TopicId, 8, convViewpointCitation.TopicId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.TopicName, 200, convViewpointCitation.TopicName);
//检查字段外键固定长度
 objvViewpointCitationEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsvViewpointCitationEN objvViewpointCitationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.Memo, 1000, convViewpointCitation.Memo);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.PaperId, 8, convViewpointCitation.PaperId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.PaperTitle, 500, convViewpointCitation.PaperTitle);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.UpdUserId, 20, convViewpointCitation.UpdUserId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.UserName, 30, convViewpointCitation.UserName);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointId, 8, convViewpointCitation.ViewpointId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointName, 500, convViewpointCitation.ViewpointName);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointTypeId, 4, convViewpointCitation.ViewpointTypeId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointTypeName, 50, convViewpointCitation.ViewpointTypeName);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.UpdDate, 20, convViewpointCitation.UpdDate);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ProposePeople, 50, convViewpointCitation.ProposePeople);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.Source, 500, convViewpointCitation.Source);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.TopicId, 8, convViewpointCitation.TopicId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.TopicName, 200, convViewpointCitation.TopicName);
//检查外键字段长度
 objvViewpointCitationEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewpointCitationEN objvViewpointCitationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.Memo, 1000, convViewpointCitation.Memo);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.PaperId, 8, convViewpointCitation.PaperId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.PaperTitle, 500, convViewpointCitation.PaperTitle);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.UpdUserId, 20, convViewpointCitation.UpdUserId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.UserName, 30, convViewpointCitation.UserName);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointId, 8, convViewpointCitation.ViewpointId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointName, 500, convViewpointCitation.ViewpointName);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointTypeId, 4, convViewpointCitation.ViewpointTypeId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ViewpointTypeName, 50, convViewpointCitation.ViewpointTypeName);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.UpdDate, 20, convViewpointCitation.UpdDate);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.ProposePeople, 50, convViewpointCitation.ProposePeople);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.Source, 500, convViewpointCitation.Source);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.TopicId, 8, convViewpointCitation.TopicId);
clsCheckSql.CheckFieldLen(objvViewpointCitationEN.TopicName, 200, convViewpointCitation.TopicName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.Memo, convViewpointCitation.Memo);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.PaperId, convViewpointCitation.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.PaperTitle, convViewpointCitation.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.UpdUserId, convViewpointCitation.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.UserName, convViewpointCitation.UserName);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.ViewpointId, convViewpointCitation.ViewpointId);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.ViewpointName, convViewpointCitation.ViewpointName);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.ViewpointTypeId, convViewpointCitation.ViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.ViewpointTypeName, convViewpointCitation.ViewpointTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.UpdDate, convViewpointCitation.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.ProposePeople, convViewpointCitation.ProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.Source, convViewpointCitation.Source);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.TopicId, convViewpointCitation.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvViewpointCitationEN.TopicName, convViewpointCitation.TopicName);
//检查外键字段长度
 objvViewpointCitationEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vViewpointCitation(v观点引用),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvViewpointCitationEN objvViewpointCitationEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvViewpointCitationEN.mId);
 if (objvViewpointCitationEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null");
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objvViewpointCitationEN.PaperId);
}
 if (objvViewpointCitationEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null");
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointCitationEN.ViewpointId);
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
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
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
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
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
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewpointCitationEN._CurrTabName);
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
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewpointCitationEN._CurrTabName, strCondition);
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
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
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
 objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}