﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointAttachmentDA
 表名:vViewpointAttachment(01120593)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:52:52
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
 /// v观点附件(vViewpointAttachment)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewpointAttachmentDA : clsCommBase4DA
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
 return clsvViewpointAttachmentEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewpointAttachmentEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewpointAttachmentEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvViewpointAttachmentEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewpointAttachmentEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewpointAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewpointAttachment(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewpointAttachmentDA: GetDataTable_vViewpointAttachment)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointAttachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewpointAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewpointAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointAttachment where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewpointAttachmentDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewpointAttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewpointAttachment where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewpointAttachment where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewpointAttachmentDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewpointAttachment where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewpointAttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vViewpointAttachment.* from vViewpointAttachment Left Join {1} on {2} where {3} and vViewpointAttachment.ViewpointAttachmentId not in (Select top {5} vViewpointAttachment.ViewpointAttachmentId from vViewpointAttachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewpointAttachment where {1} and ViewpointAttachmentId not in (Select top {2} ViewpointAttachmentId from vViewpointAttachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewpointAttachment where {1} and ViewpointAttachmentId not in (Select top {3} ViewpointAttachmentId from vViewpointAttachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewpointAttachmentDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vViewpointAttachment.* from vViewpointAttachment Left Join {1} on {2} where {3} and vViewpointAttachment.ViewpointAttachmentId not in (Select top {5} vViewpointAttachment.ViewpointAttachmentId from vViewpointAttachment Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewpointAttachment where {1} and ViewpointAttachmentId not in (Select top {2} ViewpointAttachmentId from vViewpointAttachment where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewpointAttachment where {1} and ViewpointAttachmentId not in (Select top {3} ViewpointAttachmentId from vViewpointAttachment where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvViewpointAttachmentEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewpointAttachmentDA:GetObjLst)", objException.Message));
}
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = TransNullToInt(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewpointAttachmentDA: GetObjLst)", objException.Message));
}
objvViewpointAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewpointAttachmentEN);
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
public List<clsvViewpointAttachmentEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewpointAttachmentDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = TransNullToInt(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewpointAttachmentDA: GetObjLst)", objException.Message));
}
objvViewpointAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewpointAttachmentEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewpointAttachment(ref clsvViewpointAttachmentEN objvViewpointAttachmentEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointAttachment where ViewpointAttachmentId = " + ""+ objvViewpointAttachmentEN.ViewpointAttachmentId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewpointAttachmentEN.ViewpointAttachmentId = TransNullToInt(objDT.Rows[0][convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvViewpointAttachmentEN.Reason = objDT.Rows[0][convViewpointAttachment.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointAttachmentEN.ViewpointAttachmentName = objDT.Rows[0][convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvViewpointAttachmentEN.Source = objDT.Rows[0][convViewpointAttachment.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointAttachmentEN.ViewpointId = objDT.Rows[0][convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointAttachmentEN.FilePath = objDT.Rows[0][convViewpointAttachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewpointAttachmentEN.UpdUser = objDT.Rows[0][convViewpointAttachment.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointAttachmentEN.UpdDate = objDT.Rows[0][convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointAttachmentEN.ViewpointContent = objDT.Rows[0][convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointAttachmentEN.ViewpointName = objDT.Rows[0][convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointAttachmentEN.ViewpointTypeId = objDT.Rows[0][convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvViewpointAttachmentEN.ViewpointTypeName = objDT.Rows[0][convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointAttachmentEN.VPProposePeople = objDT.Rows[0][convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointAttachmentEN.IdCurrEduCls = objDT.Rows[0][convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewpointAttachmentDA: GetvViewpointAttachment)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngViewpointAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewpointAttachmentEN GetObjByViewpointAttachmentId(long lngViewpointAttachmentId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointAttachment where ViewpointAttachmentId = " + ""+ lngViewpointAttachmentId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
 objvViewpointAttachmentEN.ViewpointAttachmentId = Int32.Parse(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewpointAttachmentDA: GetObjByViewpointAttachmentId)", objException.Message));
}
return objvViewpointAttachmentEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewpointAttachmentEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewpointAttachmentDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
strSQL = "Select * from vViewpointAttachment where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN()
{
ViewpointAttachmentId = TransNullToInt(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()), //主键Id
Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(), //理由
ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(), //附件名称
Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(), //来源
ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(), //观点Id
FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(), //文件路径
UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(), //修改日期
ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(), //观点内容
ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(), //观点名称
ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(), //观点类型Id
ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(), //观点类型名
VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(), //观点提出人
IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objvViewpointAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewpointAttachmentEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewpointAttachmentDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewpointAttachmentEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = TransNullToInt(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewpointAttachmentDA: GetObjByDataRowvViewpointAttachment)", objException.Message));
}
objvViewpointAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewpointAttachmentEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewpointAttachmentEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = TransNullToInt(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewpointAttachmentDA: GetObjByDataRow)", objException.Message));
}
objvViewpointAttachmentEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewpointAttachmentEN;
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
objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewpointAttachmentEN._CurrTabName, convViewpointAttachment.ViewpointAttachmentId, 8, "");
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
objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewpointAttachmentEN._CurrTabName, convViewpointAttachment.ViewpointAttachmentId, 8, strPrefix);
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
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewpointAttachmentId from vViewpointAttachment where " + strCondition;
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
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewpointAttachmentId from vViewpointAttachment where " + strCondition;
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
 /// <param name = "lngViewpointAttachmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngViewpointAttachmentId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewpointAttachment", "ViewpointAttachmentId = " + ""+ lngViewpointAttachmentId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewpointAttachmentDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewpointAttachment", strCondition))
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
objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewpointAttachment");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvViewpointAttachmentENS">源对象</param>
 /// <param name = "objvViewpointAttachmentENT">目标对象</param>
public void CopyTo(clsvViewpointAttachmentEN objvViewpointAttachmentENS, clsvViewpointAttachmentEN objvViewpointAttachmentENT)
{
objvViewpointAttachmentENT.ViewpointAttachmentId = objvViewpointAttachmentENS.ViewpointAttachmentId; //主键Id
objvViewpointAttachmentENT.Reason = objvViewpointAttachmentENS.Reason; //理由
objvViewpointAttachmentENT.ViewpointAttachmentName = objvViewpointAttachmentENS.ViewpointAttachmentName; //附件名称
objvViewpointAttachmentENT.Source = objvViewpointAttachmentENS.Source; //来源
objvViewpointAttachmentENT.ViewpointId = objvViewpointAttachmentENS.ViewpointId; //观点Id
objvViewpointAttachmentENT.FilePath = objvViewpointAttachmentENS.FilePath; //文件路径
objvViewpointAttachmentENT.UpdUser = objvViewpointAttachmentENS.UpdUser; //修改人
objvViewpointAttachmentENT.UpdDate = objvViewpointAttachmentENS.UpdDate; //修改日期
objvViewpointAttachmentENT.ViewpointContent = objvViewpointAttachmentENS.ViewpointContent; //观点内容
objvViewpointAttachmentENT.ViewpointName = objvViewpointAttachmentENS.ViewpointName; //观点名称
objvViewpointAttachmentENT.ViewpointTypeId = objvViewpointAttachmentENS.ViewpointTypeId; //观点类型Id
objvViewpointAttachmentENT.ViewpointTypeName = objvViewpointAttachmentENS.ViewpointTypeName; //观点类型名
objvViewpointAttachmentENT.VPProposePeople = objvViewpointAttachmentENS.VPProposePeople; //观点提出人
objvViewpointAttachmentENT.IdCurrEduCls = objvViewpointAttachmentENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewpointAttachmentEN objvViewpointAttachmentEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewpointAttachmentEN.ViewpointAttachmentName, 200, convViewpointAttachment.ViewpointAttachmentName);
clsCheckSql.CheckFieldLen(objvViewpointAttachmentEN.Source, 500, convViewpointAttachment.Source);
clsCheckSql.CheckFieldLen(objvViewpointAttachmentEN.ViewpointId, 8, convViewpointAttachment.ViewpointId);
clsCheckSql.CheckFieldLen(objvViewpointAttachmentEN.FilePath, 500, convViewpointAttachment.FilePath);
clsCheckSql.CheckFieldLen(objvViewpointAttachmentEN.UpdUser, 20, convViewpointAttachment.UpdUser);
clsCheckSql.CheckFieldLen(objvViewpointAttachmentEN.UpdDate, 20, convViewpointAttachment.UpdDate);
clsCheckSql.CheckFieldLen(objvViewpointAttachmentEN.ViewpointName, 500, convViewpointAttachment.ViewpointName);
clsCheckSql.CheckFieldLen(objvViewpointAttachmentEN.ViewpointTypeId, 4, convViewpointAttachment.ViewpointTypeId);
clsCheckSql.CheckFieldLen(objvViewpointAttachmentEN.ViewpointTypeName, 50, convViewpointAttachment.ViewpointTypeName);
clsCheckSql.CheckFieldLen(objvViewpointAttachmentEN.VPProposePeople, 50, convViewpointAttachment.VPProposePeople);
clsCheckSql.CheckFieldLen(objvViewpointAttachmentEN.IdCurrEduCls, 8, convViewpointAttachment.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewpointAttachmentEN.ViewpointAttachmentName, convViewpointAttachment.ViewpointAttachmentName);
clsCheckSql.CheckSqlInjection4Field(objvViewpointAttachmentEN.Source, convViewpointAttachment.Source);
clsCheckSql.CheckSqlInjection4Field(objvViewpointAttachmentEN.ViewpointId, convViewpointAttachment.ViewpointId);
clsCheckSql.CheckSqlInjection4Field(objvViewpointAttachmentEN.FilePath, convViewpointAttachment.FilePath);
clsCheckSql.CheckSqlInjection4Field(objvViewpointAttachmentEN.UpdUser, convViewpointAttachment.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvViewpointAttachmentEN.UpdDate, convViewpointAttachment.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvViewpointAttachmentEN.ViewpointName, convViewpointAttachment.ViewpointName);
clsCheckSql.CheckSqlInjection4Field(objvViewpointAttachmentEN.ViewpointTypeId, convViewpointAttachment.ViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewpointAttachmentEN.ViewpointTypeName, convViewpointAttachment.ViewpointTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewpointAttachmentEN.VPProposePeople, convViewpointAttachment.VPProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvViewpointAttachmentEN.IdCurrEduCls, convViewpointAttachment.IdCurrEduCls);
//检查外键字段长度
 objvViewpointAttachmentEN._IsCheckProperty = true;
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
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
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
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
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
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewpointAttachmentEN._CurrTabName);
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
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewpointAttachmentEN._CurrTabName, strCondition);
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
 objSQL = clsvViewpointAttachmentDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}