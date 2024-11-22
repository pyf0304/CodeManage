
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvObjectiveAttachmentDA
 表名:vObjectiveAttachment(01120618)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:02:23
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
 /// vObjectiveAttachment(vObjectiveAttachment)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvObjectiveAttachmentDA : clsCommBase4DA
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
 return clsvObjectiveAttachmentEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvObjectiveAttachmentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvObjectiveAttachmentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvObjectiveAttachmentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvObjectiveAttachmentEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vObjectiveAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vObjectiveAttachment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA: GetDataTable_vObjectiveAttachment)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vObjectiveAttachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vObjectiveAttachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vObjectiveAttachment where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vObjectiveAttachment where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vObjectiveAttachment where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vObjectiveAttachment.* from vObjectiveAttachment Left Join {1} on {2} where {3} and vObjectiveAttachment.ObjectiveAttachmentId not in (Select top {5} vObjectiveAttachment.ObjectiveAttachmentId from vObjectiveAttachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vObjectiveAttachment where {1} and ObjectiveAttachmentId not in (Select top {2} ObjectiveAttachmentId from vObjectiveAttachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vObjectiveAttachment where {1} and ObjectiveAttachmentId not in (Select top {3} ObjectiveAttachmentId from vObjectiveAttachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vObjectiveAttachment.* from vObjectiveAttachment Left Join {1} on {2} where {3} and vObjectiveAttachment.ObjectiveAttachmentId not in (Select top {5} vObjectiveAttachment.ObjectiveAttachmentId from vObjectiveAttachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vObjectiveAttachment where {1} and ObjectiveAttachmentId not in (Select top {2} ObjectiveAttachmentId from vObjectiveAttachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vObjectiveAttachment where {1} and ObjectiveAttachmentId not in (Select top {3} ObjectiveAttachmentId from vObjectiveAttachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvObjectiveAttachmentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA:GetObjLst)", objException.Message));
}
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vObjectiveAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = TransNullToInt(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvObjectiveAttachmentDA: GetObjLst)", objException.Message));
}
objvObjectiveAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvObjectiveAttachmentEN);
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
public List<clsvObjectiveAttachmentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA:GetObjLstByTabName)", objException.Message));
}
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = TransNullToInt(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvObjectiveAttachmentDA: GetObjLst)", objException.Message));
}
objvObjectiveAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvObjectiveAttachmentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvObjectiveAttachment(ref clsvObjectiveAttachmentEN objvObjectiveAttachmentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vObjectiveAttachment where ObjectiveAttachmentId = " + ""+ objvObjectiveAttachmentEN.ObjectiveAttachmentId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvObjectiveAttachmentEN.TopicObjectiveId = objDT.Rows[0][convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objvObjectiveAttachmentEN.ObjectiveAttachmentId = TransNullToInt(objDT.Rows[0][convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvObjectiveAttachmentEN.ObjectiveAttachmentName = objDT.Rows[0][convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvObjectiveAttachmentEN.FilePath = objDT.Rows[0][convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvObjectiveAttachmentEN.UpdDate = objDT.Rows[0][convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvObjectiveAttachmentEN.UpdUserId = objDT.Rows[0][convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvObjectiveAttachmentEN.Memo = objDT.Rows[0][convObjectiveAttachment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvObjectiveAttachmentEN.ObjectiveName = objDT.Rows[0][convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvObjectiveAttachmentEN.ObjectiveContent = objDT.Rows[0][convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvObjectiveAttachmentEN.ObjectiveType = objDT.Rows[0][convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objvObjectiveAttachmentEN.ObjectiveTypeName = objDT.Rows[0][convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName(字段类型:varchar,字段长度:8,是否可空:True)
 objvObjectiveAttachmentEN.Conclusion = objDT.Rows[0][convObjectiveAttachment.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objvObjectiveAttachmentEN.IdCurrEduCls = objDT.Rows[0][convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvObjectiveAttachmentDA: GetvObjectiveAttachment)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngObjectiveAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public clsvObjectiveAttachmentEN GetObjByObjectiveAttachmentId(long lngObjectiveAttachmentId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vObjectiveAttachment where ObjectiveAttachmentId = " + ""+ lngObjectiveAttachmentId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
 objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objvObjectiveAttachmentEN.ObjectiveAttachmentId = Int32.Parse(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName(字段类型:varchar,字段长度:8,是否可空:True)
 objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvObjectiveAttachmentDA: GetObjByObjectiveAttachmentId)", objException.Message));
}
return objvObjectiveAttachmentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvObjectiveAttachmentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vObjectiveAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN()
{
TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(), //客观Id
ObjectiveAttachmentId = TransNullToInt(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()), //客观附件Id
ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(), //附件名称
FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(), //文件路径
UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(), //备注
ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(), //客观名称
ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(), //客观内容
ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(), //客观类型
ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(), //ObjectiveTypeName
Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(), //结论
IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objvObjectiveAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvObjectiveAttachmentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvObjectiveAttachmentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvObjectiveAttachmentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = TransNullToInt(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvObjectiveAttachmentDA: GetObjByDataRowvObjectiveAttachment)", objException.Message));
}
objvObjectiveAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvObjectiveAttachmentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvObjectiveAttachmentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = TransNullToInt(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvObjectiveAttachmentDA: GetObjByDataRow)", objException.Message));
}
objvObjectiveAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvObjectiveAttachmentEN;
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
objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvObjectiveAttachmentEN._CurrTabName, convObjectiveAttachment.ObjectiveAttachmentId, 8, "");
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
objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvObjectiveAttachmentEN._CurrTabName, convObjectiveAttachment.ObjectiveAttachmentId, 8, strPrefix);
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
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ObjectiveAttachmentId from vObjectiveAttachment where " + strCondition;
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
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ObjectiveAttachmentId from vObjectiveAttachment where " + strCondition;
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
 /// <param name = "lngObjectiveAttachmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngObjectiveAttachmentId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vObjectiveAttachment", "ObjectiveAttachmentId = " + ""+ lngObjectiveAttachmentId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvObjectiveAttachmentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vObjectiveAttachment", strCondition))
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
objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vObjectiveAttachment");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentENS">源对象</param>
 /// <param name = "objvObjectiveAttachmentENT">目标对象</param>
public void CopyTo(clsvObjectiveAttachmentEN objvObjectiveAttachmentENS, clsvObjectiveAttachmentEN objvObjectiveAttachmentENT)
{
objvObjectiveAttachmentENT.TopicObjectiveId = objvObjectiveAttachmentENS.TopicObjectiveId; //客观Id
objvObjectiveAttachmentENT.ObjectiveAttachmentId = objvObjectiveAttachmentENS.ObjectiveAttachmentId; //客观附件Id
objvObjectiveAttachmentENT.ObjectiveAttachmentName = objvObjectiveAttachmentENS.ObjectiveAttachmentName; //附件名称
objvObjectiveAttachmentENT.FilePath = objvObjectiveAttachmentENS.FilePath; //文件路径
objvObjectiveAttachmentENT.UpdDate = objvObjectiveAttachmentENS.UpdDate; //修改日期
objvObjectiveAttachmentENT.UpdUserId = objvObjectiveAttachmentENS.UpdUserId; //修改用户Id
objvObjectiveAttachmentENT.Memo = objvObjectiveAttachmentENS.Memo; //备注
objvObjectiveAttachmentENT.ObjectiveName = objvObjectiveAttachmentENS.ObjectiveName; //客观名称
objvObjectiveAttachmentENT.ObjectiveContent = objvObjectiveAttachmentENS.ObjectiveContent; //客观内容
objvObjectiveAttachmentENT.ObjectiveType = objvObjectiveAttachmentENS.ObjectiveType; //客观类型
objvObjectiveAttachmentENT.ObjectiveTypeName = objvObjectiveAttachmentENS.ObjectiveTypeName; //ObjectiveTypeName
objvObjectiveAttachmentENT.Conclusion = objvObjectiveAttachmentENS.Conclusion; //结论
objvObjectiveAttachmentENT.IdCurrEduCls = objvObjectiveAttachmentENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvObjectiveAttachmentEN objvObjectiveAttachmentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvObjectiveAttachmentEN.TopicObjectiveId, 8, convObjectiveAttachment.TopicObjectiveId);
clsCheckSql.CheckFieldLen(objvObjectiveAttachmentEN.ObjectiveAttachmentName, 200, convObjectiveAttachment.ObjectiveAttachmentName);
clsCheckSql.CheckFieldLen(objvObjectiveAttachmentEN.FilePath, 500, convObjectiveAttachment.FilePath);
clsCheckSql.CheckFieldLen(objvObjectiveAttachmentEN.UpdDate, 20, convObjectiveAttachment.UpdDate);
clsCheckSql.CheckFieldLen(objvObjectiveAttachmentEN.UpdUserId, 20, convObjectiveAttachment.UpdUserId);
clsCheckSql.CheckFieldLen(objvObjectiveAttachmentEN.Memo, 1000, convObjectiveAttachment.Memo);
clsCheckSql.CheckFieldLen(objvObjectiveAttachmentEN.ObjectiveName, 500, convObjectiveAttachment.ObjectiveName);
clsCheckSql.CheckFieldLen(objvObjectiveAttachmentEN.ObjectiveType, 2, convObjectiveAttachment.ObjectiveType);
clsCheckSql.CheckFieldLen(objvObjectiveAttachmentEN.ObjectiveTypeName, 8, convObjectiveAttachment.ObjectiveTypeName);
clsCheckSql.CheckFieldLen(objvObjectiveAttachmentEN.IdCurrEduCls, 8, convObjectiveAttachment.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvObjectiveAttachmentEN.TopicObjectiveId, convObjectiveAttachment.TopicObjectiveId);
clsCheckSql.CheckSqlInjection4Field(objvObjectiveAttachmentEN.ObjectiveAttachmentName, convObjectiveAttachment.ObjectiveAttachmentName);
clsCheckSql.CheckSqlInjection4Field(objvObjectiveAttachmentEN.FilePath, convObjectiveAttachment.FilePath);
clsCheckSql.CheckSqlInjection4Field(objvObjectiveAttachmentEN.UpdDate, convObjectiveAttachment.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvObjectiveAttachmentEN.UpdUserId, convObjectiveAttachment.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvObjectiveAttachmentEN.Memo, convObjectiveAttachment.Memo);
clsCheckSql.CheckSqlInjection4Field(objvObjectiveAttachmentEN.ObjectiveName, convObjectiveAttachment.ObjectiveName);
clsCheckSql.CheckSqlInjection4Field(objvObjectiveAttachmentEN.ObjectiveType, convObjectiveAttachment.ObjectiveType);
clsCheckSql.CheckSqlInjection4Field(objvObjectiveAttachmentEN.ObjectiveTypeName, convObjectiveAttachment.ObjectiveTypeName);
clsCheckSql.CheckSqlInjection4Field(objvObjectiveAttachmentEN.IdCurrEduCls, convObjectiveAttachment.IdCurrEduCls);
//检查外键字段长度
 objvObjectiveAttachmentEN._IsCheckProperty = true;
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
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
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
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
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
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvObjectiveAttachmentEN._CurrTabName);
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
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvObjectiveAttachmentEN._CurrTabName, strCondition);
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
 objSQL = clsvObjectiveAttachmentDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}