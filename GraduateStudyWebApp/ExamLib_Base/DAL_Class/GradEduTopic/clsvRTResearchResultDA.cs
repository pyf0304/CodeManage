﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTResearchResultDA
 表名:vRTResearchResult(01120621)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:32
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
 /// 主题研究结果关系(vRTResearchResult)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvRTResearchResultDA : clsCommBase4DA
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
 return clsvRTResearchResultEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvRTResearchResultEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTResearchResultEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvRTResearchResultEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvRTResearchResultEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvRTResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vRTResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vRTResearchResult(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvRTResearchResultDA: GetDataTable_vRTResearchResult)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vRTResearchResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvRTResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvRTResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vRTResearchResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvRTResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvRTResearchResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTResearchResult where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTResearchResult where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvRTResearchResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vRTResearchResult where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvRTResearchResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTResearchResult.* from vRTResearchResult Left Join {1} on {2} where {3} and vRTResearchResult.mId not in (Select top {5} vRTResearchResult.mId from vRTResearchResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTResearchResult where {1} and mId not in (Select top {2} mId from vRTResearchResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTResearchResult where {1} and mId not in (Select top {3} mId from vRTResearchResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvRTResearchResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTResearchResult.* from vRTResearchResult Left Join {1} on {2} where {3} and vRTResearchResult.mId not in (Select top {5} vRTResearchResult.mId from vRTResearchResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTResearchResult where {1} and mId not in (Select top {2} mId from vRTResearchResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTResearchResult where {1} and mId not in (Select top {3} mId from vRTResearchResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvRTResearchResultEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvRTResearchResultDA:GetObjLst)", objException.Message));
}
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vRTResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = TransNullToInt(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTResearchResultDA: GetObjLst)", objException.Message));
}
objvRTResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTResearchResultEN);
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
public List<clsvRTResearchResultEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvRTResearchResultDA:GetObjLstByTabName)", objException.Message));
}
List<clsvRTResearchResultEN> arrObjLst = new List<clsvRTResearchResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = TransNullToInt(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTResearchResultDA: GetObjLst)", objException.Message));
}
objvRTResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTResearchResultEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvRTResearchResultEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvRTResearchResult(ref clsvRTResearchResultEN objvRTResearchResultEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vRTResearchResult where mId = " + ""+ objvRTResearchResultEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvRTResearchResultEN.TopicId = objDT.Rows[0][convRTResearchResult.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTResearchResultEN.PaperId = objDT.Rows[0][convRTResearchResult.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTResearchResultEN.UpdDate = objDT.Rows[0][convRTResearchResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTResearchResultEN.UpdUser = objDT.Rows[0][convRTResearchResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTResearchResultEN.Memo = objDT.Rows[0][convRTResearchResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTResearchResultEN.mId = TransNullToInt(objDT.Rows[0][convRTResearchResult.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTResearchResultEN.UserName = objDT.Rows[0][convRTResearchResult.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvRTResearchResultEN.PaperTitle = objDT.Rows[0][convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvRTResearchResultEN.PaperContent = objDT.Rows[0][convRTResearchResult.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTResearchResultEN.TopicName = objDT.Rows[0][convRTResearchResult.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTResearchResultEN.TopicContent = objDT.Rows[0][convRTResearchResult.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTResearchResultEN.TopicProposePeople = objDT.Rows[0][convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTResearchResultEN.Periodical = objDT.Rows[0][convRTResearchResult.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvRTResearchResultEN.Author = objDT.Rows[0][convRTResearchResult.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvRTResearchResultDA: GetvRTResearchResult)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvRTResearchResultEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vRTResearchResult where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
 objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTResearchResultEN.mId = Int32.Parse(objRow[convRTResearchResult.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvRTResearchResultDA: GetObjBymId)", objException.Message));
}
return objvRTResearchResultEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvRTResearchResultEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvRTResearchResultDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from vRTResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN()
{
TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(), //主题Id
PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(), //论文Id
UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(), //备注
mId = TransNullToInt(objRow[convRTResearchResult.mId].ToString().Trim()), //mId
UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(), //用户名
PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(), //论文标题
PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(), //主题内容
TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(), //栏目主题
TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(), //主题内容
TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(), //主题提出人
Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(), //期刊
Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim() //作者
};
objvRTResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTResearchResultEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvRTResearchResultDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvRTResearchResultEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = TransNullToInt(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvRTResearchResultDA: GetObjByDataRowvRTResearchResult)", objException.Message));
}
objvRTResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTResearchResultEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvRTResearchResultEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTResearchResultEN objvRTResearchResultEN = new clsvRTResearchResultEN();
try
{
objvRTResearchResultEN.TopicId = objRow[convRTResearchResult.TopicId] == DBNull.Value ? null : objRow[convRTResearchResult.TopicId].ToString().Trim(); //主题Id
objvRTResearchResultEN.PaperId = objRow[convRTResearchResult.PaperId] == DBNull.Value ? null : objRow[convRTResearchResult.PaperId].ToString().Trim(); //论文Id
objvRTResearchResultEN.UpdDate = objRow[convRTResearchResult.UpdDate] == DBNull.Value ? null : objRow[convRTResearchResult.UpdDate].ToString().Trim(); //修改日期
objvRTResearchResultEN.UpdUser = objRow[convRTResearchResult.UpdUser].ToString().Trim(); //修改人
objvRTResearchResultEN.Memo = objRow[convRTResearchResult.Memo] == DBNull.Value ? null : objRow[convRTResearchResult.Memo].ToString().Trim(); //备注
objvRTResearchResultEN.mId = TransNullToInt(objRow[convRTResearchResult.mId].ToString().Trim()); //mId
objvRTResearchResultEN.UserName = objRow[convRTResearchResult.UserName] == DBNull.Value ? null : objRow[convRTResearchResult.UserName].ToString().Trim(); //用户名
objvRTResearchResultEN.PaperTitle = objRow[convRTResearchResult.PaperTitle] == DBNull.Value ? null : objRow[convRTResearchResult.PaperTitle].ToString().Trim(); //论文标题
objvRTResearchResultEN.PaperContent = objRow[convRTResearchResult.PaperContent] == DBNull.Value ? null : objRow[convRTResearchResult.PaperContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicName = objRow[convRTResearchResult.TopicName] == DBNull.Value ? null : objRow[convRTResearchResult.TopicName].ToString().Trim(); //栏目主题
objvRTResearchResultEN.TopicContent = objRow[convRTResearchResult.TopicContent] == DBNull.Value ? null : objRow[convRTResearchResult.TopicContent].ToString().Trim(); //主题内容
objvRTResearchResultEN.TopicProposePeople = objRow[convRTResearchResult.TopicProposePeople] == DBNull.Value ? null : objRow[convRTResearchResult.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTResearchResultEN.Periodical = objRow[convRTResearchResult.Periodical] == DBNull.Value ? null : objRow[convRTResearchResult.Periodical].ToString().Trim(); //期刊
objvRTResearchResultEN.Author = objRow[convRTResearchResult.Author] == DBNull.Value ? null : objRow[convRTResearchResult.Author].ToString().Trim(); //作者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvRTResearchResultDA: GetObjByDataRow)", objException.Message));
}
objvRTResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTResearchResultEN;
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
objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTResearchResultEN._CurrTabName, convRTResearchResult.mId, 8, "");
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
objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTResearchResultEN._CurrTabName, convRTResearchResult.mId, 8, strPrefix);
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
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vRTResearchResult where " + strCondition;
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
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vRTResearchResult where " + strCondition;
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
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTResearchResult", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvRTResearchResultDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTResearchResult", strCondition))
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
objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vRTResearchResult");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvRTResearchResultENS">源对象</param>
 /// <param name = "objvRTResearchResultENT">目标对象</param>
public void CopyTo(clsvRTResearchResultEN objvRTResearchResultENS, clsvRTResearchResultEN objvRTResearchResultENT)
{
objvRTResearchResultENT.TopicId = objvRTResearchResultENS.TopicId; //主题Id
objvRTResearchResultENT.PaperId = objvRTResearchResultENS.PaperId; //论文Id
objvRTResearchResultENT.UpdDate = objvRTResearchResultENS.UpdDate; //修改日期
objvRTResearchResultENT.UpdUser = objvRTResearchResultENS.UpdUser; //修改人
objvRTResearchResultENT.Memo = objvRTResearchResultENS.Memo; //备注
objvRTResearchResultENT.mId = objvRTResearchResultENS.mId; //mId
objvRTResearchResultENT.UserName = objvRTResearchResultENS.UserName; //用户名
objvRTResearchResultENT.PaperTitle = objvRTResearchResultENS.PaperTitle; //论文标题
objvRTResearchResultENT.PaperContent = objvRTResearchResultENS.PaperContent; //主题内容
objvRTResearchResultENT.TopicName = objvRTResearchResultENS.TopicName; //栏目主题
objvRTResearchResultENT.TopicContent = objvRTResearchResultENS.TopicContent; //主题内容
objvRTResearchResultENT.TopicProposePeople = objvRTResearchResultENS.TopicProposePeople; //主题提出人
objvRTResearchResultENT.Periodical = objvRTResearchResultENS.Periodical; //期刊
objvRTResearchResultENT.Author = objvRTResearchResultENS.Author; //作者
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvRTResearchResultEN objvRTResearchResultEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvRTResearchResultEN.TopicId, 8, convRTResearchResult.TopicId);
clsCheckSql.CheckFieldLen(objvRTResearchResultEN.PaperId, 8, convRTResearchResult.PaperId);
clsCheckSql.CheckFieldLen(objvRTResearchResultEN.UpdDate, 20, convRTResearchResult.UpdDate);
clsCheckSql.CheckFieldLen(objvRTResearchResultEN.UpdUser, 20, convRTResearchResult.UpdUser);
clsCheckSql.CheckFieldLen(objvRTResearchResultEN.Memo, 1000, convRTResearchResult.Memo);
clsCheckSql.CheckFieldLen(objvRTResearchResultEN.UserName, 30, convRTResearchResult.UserName);
clsCheckSql.CheckFieldLen(objvRTResearchResultEN.PaperTitle, 500, convRTResearchResult.PaperTitle);
clsCheckSql.CheckFieldLen(objvRTResearchResultEN.TopicName, 200, convRTResearchResult.TopicName);
clsCheckSql.CheckFieldLen(objvRTResearchResultEN.TopicProposePeople, 50, convRTResearchResult.TopicProposePeople);
clsCheckSql.CheckFieldLen(objvRTResearchResultEN.Periodical, 100, convRTResearchResult.Periodical);
clsCheckSql.CheckFieldLen(objvRTResearchResultEN.Author, 200, convRTResearchResult.Author);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvRTResearchResultEN.TopicId, convRTResearchResult.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvRTResearchResultEN.PaperId, convRTResearchResult.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvRTResearchResultEN.UpdDate, convRTResearchResult.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTResearchResultEN.UpdUser, convRTResearchResult.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTResearchResultEN.Memo, convRTResearchResult.Memo);
clsCheckSql.CheckSqlInjection4Field(objvRTResearchResultEN.UserName, convRTResearchResult.UserName);
clsCheckSql.CheckSqlInjection4Field(objvRTResearchResultEN.PaperTitle, convRTResearchResult.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvRTResearchResultEN.TopicName, convRTResearchResult.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvRTResearchResultEN.TopicProposePeople, convRTResearchResult.TopicProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvRTResearchResultEN.Periodical, convRTResearchResult.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvRTResearchResultEN.Author, convRTResearchResult.Author);
//检查外键字段长度
 objvRTResearchResultEN._IsCheckProperty = true;
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
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
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
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
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
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTResearchResultEN._CurrTabName);
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
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTResearchResultEN._CurrTabName, strCondition);
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
 objSQL = clsvRTResearchResultDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}