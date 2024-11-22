
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TagsDA
 表名:gs_Tags(01120714)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 标注(gs_Tags)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_TagsDA : clsCommBase4DA
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
 return clsgs_TagsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_TagsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_TagsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_TagsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_TagsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTagsId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTagsId)
{
strTagsId = strTagsId.Replace("'", "''");
if (strTagsId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:gs_Tags中,检查关键字,长度不正确!(clsgs_TagsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTagsId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:gs_Tags中,关键字不能为空 或 null!(clsgs_TagsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTagsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsgs_TagsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from gs_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_Tags(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_TagsDA: GetDataTable_gs_Tags)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from gs_Tags where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from gs_Tags where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_TagsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_Tags where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_Tags where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_TagsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_Tags where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_TagsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_Tags.* from gs_Tags Left Join {1} on {2} where {3} and gs_Tags.TagsId not in (Select top {5} gs_Tags.TagsId from gs_Tags Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_Tags where {1} and TagsId not in (Select top {2} TagsId from gs_Tags where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_Tags where {1} and TagsId not in (Select top {3} TagsId from gs_Tags where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_TagsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_Tags.* from gs_Tags Left Join {1} on {2} where {3} and gs_Tags.TagsId not in (Select top {5} gs_Tags.TagsId from gs_Tags Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_Tags where {1} and TagsId not in (Select top {2} TagsId from gs_Tags where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_Tags where {1} and TagsId not in (Select top {3} TagsId from gs_Tags where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_TagsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_TagsDA:GetObjLst)", objException.Message));
}
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from gs_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_TagsDA: GetObjLst)", objException.Message));
}
objgs_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_TagsEN);
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
public List<clsgs_TagsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_TagsDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_TagsEN> arrObjLst = new List<clsgs_TagsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_TagsDA: GetObjLst)", objException.Message));
}
objgs_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_TagsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_Tags(ref clsgs_TagsEN objgs_TagsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from gs_Tags where TagsId = " + "'"+ objgs_TagsEN.TagsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_TagsEN.TagsId = objDT.Rows[0][congs_Tags.TagsId].ToString().Trim(); //标注Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_TagsEN.TagsContent = objDT.Rows[0][congs_Tags.TagsContent].ToString().Trim(); //标注内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objgs_TagsEN.PdfContent = objDT.Rows[0][congs_Tags.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objgs_TagsEN.PdfPageNum = TransNullToInt(objDT.Rows[0][congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objgs_TagsEN.VoteCount = TransNullToInt(objDT.Rows[0][congs_Tags.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objgs_TagsEN.UserId = objDT.Rows[0][congs_Tags.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objgs_TagsEN.OrderNum = TransNullToInt(objDT.Rows[0][congs_Tags.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objgs_TagsEN.UpdUser = objDT.Rows[0][congs_Tags.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TagsEN.UpdDate = objDT.Rows[0][congs_Tags.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TagsEN.PdfLineNum = TransNullToInt(objDT.Rows[0][congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号(字段类型:int,字段长度:4,是否可空:True)
 objgs_TagsEN.PdfX = objDT.Rows[0][congs_Tags.PdfX].ToString().Trim(); //PdfX(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.PdfY = objDT.Rows[0][congs_Tags.PdfY].ToString().Trim(); //PdfY(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.Memo = objDT.Rows[0][congs_Tags.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_TagsEN.IdCurrEduCls = objDT.Rows[0][congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_TagsEN.PaperId = objDT.Rows[0][congs_Tags.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_TagsEN.ShareId = objDT.Rows[0][congs_Tags.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_TagsEN.PdfPageNumIn = objDT.Rows[0][congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.PdfPageTop = TransNullToInt(objDT.Rows[0][congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objgs_TagsEN.selectSpanRange = objDT.Rows[0][congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.PdfDivLet = objDT.Rows[0][congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.PdfDivTop = objDT.Rows[0][congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.PdfZoom = objDT.Rows[0][congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.TagsTypeId = objDT.Rows[0][congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_TagsDA: Getgs_Tags)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTagsId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_TagsEN GetObjByTagsId(string strTagsId)
{
CheckPrimaryKey(strTagsId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from gs_Tags where TagsId = " + "'"+ strTagsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
 objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号(字段类型:int,字段长度:4,是否可空:True)
 objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_TagsDA: GetObjByTagsId)", objException.Message));
}
return objgs_TagsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_TagsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_TagsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from gs_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN()
{
TagsId = objRow[congs_Tags.TagsId].ToString().Trim(), //标注Id
TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(), //标注内容
PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfPageNum].ToString().Trim()), //Pdf页码
VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.VoteCount].ToString().Trim()), //点赞计数
UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(), //用户ID
OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.OrderNum].ToString().Trim()), //序号
UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(), //修改日期
PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfLineNum].ToString().Trim()), //pdf行号
PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(), //PdfX
PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(), //PdfY
Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(), //教学班流水号
PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(), //论文Id
ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(), //分享Id
PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(), //选择Span范围
PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(), //PdfZoom
TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim() //标注类型ID
};
objgs_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_TagsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_TagsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_TagsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_TagsDA: GetObjByDataRowgs_Tags)", objException.Message));
}
objgs_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_TagsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_TagsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_TagsEN objgs_TagsEN = new clsgs_TagsEN();
try
{
objgs_TagsEN.TagsId = objRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objgs_TagsEN.TagsContent = objRow[congs_Tags.TagsContent] == DBNull.Value ? null : objRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objgs_TagsEN.PdfContent = objRow[congs_Tags.PdfContent] == DBNull.Value ? null : objRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objgs_TagsEN.PdfPageNum = objRow[congs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objgs_TagsEN.VoteCount = objRow[congs_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.VoteCount].ToString().Trim()); //点赞计数
objgs_TagsEN.UserId = objRow[congs_Tags.UserId] == DBNull.Value ? null : objRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objgs_TagsEN.OrderNum = objRow[congs_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.OrderNum].ToString().Trim()); //序号
objgs_TagsEN.UpdUser = objRow[congs_Tags.UpdUser] == DBNull.Value ? null : objRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objgs_TagsEN.UpdDate = objRow[congs_Tags.UpdDate] == DBNull.Value ? null : objRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objgs_TagsEN.PdfLineNum = objRow[congs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objgs_TagsEN.PdfX = objRow[congs_Tags.PdfX] == DBNull.Value ? null : objRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objgs_TagsEN.PdfY = objRow[congs_Tags.PdfY] == DBNull.Value ? null : objRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objgs_TagsEN.Memo = objRow[congs_Tags.Memo] == DBNull.Value ? null : objRow[congs_Tags.Memo].ToString().Trim(); //备注
objgs_TagsEN.IdCurrEduCls = objRow[congs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TagsEN.PaperId = objRow[congs_Tags.PaperId] == DBNull.Value ? null : objRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objgs_TagsEN.ShareId = objRow[congs_Tags.ShareId] == DBNull.Value ? null : objRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objgs_TagsEN.PdfPageNumIn = objRow[congs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objgs_TagsEN.PdfPageTop = objRow[congs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objgs_TagsEN.selectSpanRange = objRow[congs_Tags.selectSpanRange] == DBNull.Value ? null : objRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objgs_TagsEN.PdfDivLet = objRow[congs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objgs_TagsEN.PdfDivTop = objRow[congs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objgs_TagsEN.PdfZoom = objRow[congs_Tags.PdfZoom] == DBNull.Value ? null : objRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objgs_TagsEN.TagsTypeId = objRow[congs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_TagsDA: GetObjByDataRow)", objException.Message));
}
objgs_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_TagsEN;
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
objSQL = clsgs_TagsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_TagsEN._CurrTabName, congs_Tags.TagsId, 10, "");
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
objSQL = clsgs_TagsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_TagsEN._CurrTabName, congs_Tags.TagsId, 10, strPrefix);
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
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TagsId from gs_Tags where " + strCondition;
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
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TagsId from gs_Tags where " + strCondition;
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
 /// <param name = "strTagsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTagsId)
{
CheckPrimaryKey(strTagsId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_Tags", "TagsId = " + "'"+ strTagsId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_TagsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_Tags", strCondition))
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
objSQL = clsgs_TagsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_Tags");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_TagsEN objgs_TagsEN)
 {
 if (objgs_TagsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TagsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from gs_Tags where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_Tags");
objRow = objDS.Tables["gs_Tags"].NewRow();
objRow[congs_Tags.TagsId] = objgs_TagsEN.TagsId; //标注Id
 if (objgs_TagsEN.TagsContent !=  "")
 {
objRow[congs_Tags.TagsContent] = objgs_TagsEN.TagsContent; //标注内容
 }
 if (objgs_TagsEN.PdfContent !=  "")
 {
objRow[congs_Tags.PdfContent] = objgs_TagsEN.PdfContent; //Pdf内容
 }
objRow[congs_Tags.PdfPageNum] = objgs_TagsEN.PdfPageNum; //Pdf页码
objRow[congs_Tags.VoteCount] = objgs_TagsEN.VoteCount; //点赞计数
 if (objgs_TagsEN.UserId !=  "")
 {
objRow[congs_Tags.UserId] = objgs_TagsEN.UserId; //用户ID
 }
objRow[congs_Tags.OrderNum] = objgs_TagsEN.OrderNum; //序号
 if (objgs_TagsEN.UpdUser !=  "")
 {
objRow[congs_Tags.UpdUser] = objgs_TagsEN.UpdUser; //修改人
 }
 if (objgs_TagsEN.UpdDate !=  "")
 {
objRow[congs_Tags.UpdDate] = objgs_TagsEN.UpdDate; //修改日期
 }
objRow[congs_Tags.PdfLineNum] = objgs_TagsEN.PdfLineNum; //pdf行号
 if (objgs_TagsEN.PdfX !=  "")
 {
objRow[congs_Tags.PdfX] = objgs_TagsEN.PdfX; //PdfX
 }
 if (objgs_TagsEN.PdfY !=  "")
 {
objRow[congs_Tags.PdfY] = objgs_TagsEN.PdfY; //PdfY
 }
 if (objgs_TagsEN.Memo !=  "")
 {
objRow[congs_Tags.Memo] = objgs_TagsEN.Memo; //备注
 }
 if (objgs_TagsEN.IdCurrEduCls !=  "")
 {
objRow[congs_Tags.IdCurrEduCls] = objgs_TagsEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_TagsEN.PaperId !=  "")
 {
objRow[congs_Tags.PaperId] = objgs_TagsEN.PaperId; //论文Id
 }
 if (objgs_TagsEN.ShareId !=  "")
 {
objRow[congs_Tags.ShareId] = objgs_TagsEN.ShareId; //分享Id
 }
 if (objgs_TagsEN.PdfPageNumIn !=  "")
 {
objRow[congs_Tags.PdfPageNumIn] = objgs_TagsEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[congs_Tags.PdfPageTop] = objgs_TagsEN.PdfPageTop; //pdf页面顶部位置
 if (objgs_TagsEN.selectSpanRange !=  "")
 {
objRow[congs_Tags.selectSpanRange] = objgs_TagsEN.selectSpanRange; //选择Span范围
 }
 if (objgs_TagsEN.PdfDivLet !=  "")
 {
objRow[congs_Tags.PdfDivLet] = objgs_TagsEN.PdfDivLet; //PdfDivLet
 }
 if (objgs_TagsEN.PdfDivTop !=  "")
 {
objRow[congs_Tags.PdfDivTop] = objgs_TagsEN.PdfDivTop; //PdfDivTop
 }
 if (objgs_TagsEN.PdfZoom !=  "")
 {
objRow[congs_Tags.PdfZoom] = objgs_TagsEN.PdfZoom; //PdfZoom
 }
 if (objgs_TagsEN.TagsTypeId !=  "")
 {
objRow[congs_Tags.TagsTypeId] = objgs_TagsEN.TagsTypeId; //标注类型ID
 }
objDS.Tables[clsgs_TagsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_TagsEN._CurrTabName);
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
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_TagsEN objgs_TagsEN)
{
 if (objgs_TagsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TagsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_TagsEN.TagsId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsId);
 var strTagsId = objgs_TagsEN.TagsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsId + "'");
 }
 
 if (objgs_TagsEN.TagsContent !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsContent);
 var strTagsContent = objgs_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsContent + "'");
 }
 
 if (objgs_TagsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfContent);
 var strPdfContent = objgs_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objgs_TagsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageNum);
 arrValueListForInsert.Add(objgs_TagsEN.PdfPageNum.ToString());
 }
 
 if (objgs_TagsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.VoteCount);
 arrValueListForInsert.Add(objgs_TagsEN.VoteCount.ToString());
 }
 
 if (objgs_TagsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UserId);
 var strUserId = objgs_TagsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objgs_TagsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.OrderNum);
 arrValueListForInsert.Add(objgs_TagsEN.OrderNum.ToString());
 }
 
 if (objgs_TagsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UpdUser);
 var strUpdUser = objgs_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TagsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UpdDate);
 var strUpdDate = objgs_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TagsEN.PdfLineNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfLineNum);
 arrValueListForInsert.Add(objgs_TagsEN.PdfLineNum.ToString());
 }
 
 if (objgs_TagsEN.PdfX !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfX);
 var strPdfX = objgs_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfX + "'");
 }
 
 if (objgs_TagsEN.PdfY !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfY);
 var strPdfY = objgs_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfY + "'");
 }
 
 if (objgs_TagsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.Memo);
 var strMemo = objgs_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TagsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.IdCurrEduCls);
 var strIdCurrEduCls = objgs_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_TagsEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PaperId);
 var strPaperId = objgs_TagsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_TagsEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.ShareId);
 var strShareId = objgs_TagsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objgs_TagsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageNumIn);
 var strPdfPageNumIn = objgs_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objgs_TagsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageTop);
 arrValueListForInsert.Add(objgs_TagsEN.PdfPageTop.ToString());
 }
 
 if (objgs_TagsEN.selectSpanRange !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.selectSpanRange);
 var strselectSpanRange = objgs_TagsEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strselectSpanRange + "'");
 }
 
 if (objgs_TagsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfDivLet);
 var strPdfDivLet = objgs_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objgs_TagsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfDivTop);
 var strPdfDivTop = objgs_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objgs_TagsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfZoom);
 var strPdfZoom = objgs_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objgs_TagsEN.TagsTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsTypeId);
 var strTagsTypeId = objgs_TagsEN.TagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_Tags");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_TagsEN objgs_TagsEN)
{
 if (objgs_TagsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TagsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_TagsEN.TagsId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsId);
 var strTagsId = objgs_TagsEN.TagsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsId + "'");
 }
 
 if (objgs_TagsEN.TagsContent !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsContent);
 var strTagsContent = objgs_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsContent + "'");
 }
 
 if (objgs_TagsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfContent);
 var strPdfContent = objgs_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objgs_TagsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageNum);
 arrValueListForInsert.Add(objgs_TagsEN.PdfPageNum.ToString());
 }
 
 if (objgs_TagsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.VoteCount);
 arrValueListForInsert.Add(objgs_TagsEN.VoteCount.ToString());
 }
 
 if (objgs_TagsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UserId);
 var strUserId = objgs_TagsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objgs_TagsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.OrderNum);
 arrValueListForInsert.Add(objgs_TagsEN.OrderNum.ToString());
 }
 
 if (objgs_TagsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UpdUser);
 var strUpdUser = objgs_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TagsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UpdDate);
 var strUpdDate = objgs_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TagsEN.PdfLineNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfLineNum);
 arrValueListForInsert.Add(objgs_TagsEN.PdfLineNum.ToString());
 }
 
 if (objgs_TagsEN.PdfX !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfX);
 var strPdfX = objgs_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfX + "'");
 }
 
 if (objgs_TagsEN.PdfY !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfY);
 var strPdfY = objgs_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfY + "'");
 }
 
 if (objgs_TagsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.Memo);
 var strMemo = objgs_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TagsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.IdCurrEduCls);
 var strIdCurrEduCls = objgs_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_TagsEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PaperId);
 var strPaperId = objgs_TagsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_TagsEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.ShareId);
 var strShareId = objgs_TagsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objgs_TagsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageNumIn);
 var strPdfPageNumIn = objgs_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objgs_TagsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageTop);
 arrValueListForInsert.Add(objgs_TagsEN.PdfPageTop.ToString());
 }
 
 if (objgs_TagsEN.selectSpanRange !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.selectSpanRange);
 var strselectSpanRange = objgs_TagsEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strselectSpanRange + "'");
 }
 
 if (objgs_TagsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfDivLet);
 var strPdfDivLet = objgs_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objgs_TagsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfDivTop);
 var strPdfDivTop = objgs_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objgs_TagsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfZoom);
 var strPdfZoom = objgs_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objgs_TagsEN.TagsTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsTypeId);
 var strTagsTypeId = objgs_TagsEN.TagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_Tags");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objgs_TagsEN.TagsId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_TagsEN objgs_TagsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_TagsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TagsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_TagsEN.TagsId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsId);
 var strTagsId = objgs_TagsEN.TagsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsId + "'");
 }
 
 if (objgs_TagsEN.TagsContent !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsContent);
 var strTagsContent = objgs_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsContent + "'");
 }
 
 if (objgs_TagsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfContent);
 var strPdfContent = objgs_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objgs_TagsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageNum);
 arrValueListForInsert.Add(objgs_TagsEN.PdfPageNum.ToString());
 }
 
 if (objgs_TagsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.VoteCount);
 arrValueListForInsert.Add(objgs_TagsEN.VoteCount.ToString());
 }
 
 if (objgs_TagsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UserId);
 var strUserId = objgs_TagsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objgs_TagsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.OrderNum);
 arrValueListForInsert.Add(objgs_TagsEN.OrderNum.ToString());
 }
 
 if (objgs_TagsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UpdUser);
 var strUpdUser = objgs_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TagsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UpdDate);
 var strUpdDate = objgs_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TagsEN.PdfLineNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfLineNum);
 arrValueListForInsert.Add(objgs_TagsEN.PdfLineNum.ToString());
 }
 
 if (objgs_TagsEN.PdfX !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfX);
 var strPdfX = objgs_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfX + "'");
 }
 
 if (objgs_TagsEN.PdfY !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfY);
 var strPdfY = objgs_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfY + "'");
 }
 
 if (objgs_TagsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.Memo);
 var strMemo = objgs_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TagsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.IdCurrEduCls);
 var strIdCurrEduCls = objgs_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_TagsEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PaperId);
 var strPaperId = objgs_TagsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_TagsEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.ShareId);
 var strShareId = objgs_TagsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objgs_TagsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageNumIn);
 var strPdfPageNumIn = objgs_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objgs_TagsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageTop);
 arrValueListForInsert.Add(objgs_TagsEN.PdfPageTop.ToString());
 }
 
 if (objgs_TagsEN.selectSpanRange !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.selectSpanRange);
 var strselectSpanRange = objgs_TagsEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strselectSpanRange + "'");
 }
 
 if (objgs_TagsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfDivLet);
 var strPdfDivLet = objgs_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objgs_TagsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfDivTop);
 var strPdfDivTop = objgs_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objgs_TagsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfZoom);
 var strPdfZoom = objgs_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objgs_TagsEN.TagsTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsTypeId);
 var strTagsTypeId = objgs_TagsEN.TagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_Tags");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objgs_TagsEN.TagsId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_TagsEN objgs_TagsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_TagsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TagsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_TagsEN.TagsId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsId);
 var strTagsId = objgs_TagsEN.TagsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsId + "'");
 }
 
 if (objgs_TagsEN.TagsContent !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsContent);
 var strTagsContent = objgs_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsContent + "'");
 }
 
 if (objgs_TagsEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfContent);
 var strPdfContent = objgs_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objgs_TagsEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageNum);
 arrValueListForInsert.Add(objgs_TagsEN.PdfPageNum.ToString());
 }
 
 if (objgs_TagsEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.VoteCount);
 arrValueListForInsert.Add(objgs_TagsEN.VoteCount.ToString());
 }
 
 if (objgs_TagsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UserId);
 var strUserId = objgs_TagsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objgs_TagsEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.OrderNum);
 arrValueListForInsert.Add(objgs_TagsEN.OrderNum.ToString());
 }
 
 if (objgs_TagsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UpdUser);
 var strUpdUser = objgs_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TagsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.UpdDate);
 var strUpdDate = objgs_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TagsEN.PdfLineNum !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfLineNum);
 arrValueListForInsert.Add(objgs_TagsEN.PdfLineNum.ToString());
 }
 
 if (objgs_TagsEN.PdfX !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfX);
 var strPdfX = objgs_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfX + "'");
 }
 
 if (objgs_TagsEN.PdfY !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfY);
 var strPdfY = objgs_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfY + "'");
 }
 
 if (objgs_TagsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.Memo);
 var strMemo = objgs_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TagsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.IdCurrEduCls);
 var strIdCurrEduCls = objgs_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_TagsEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PaperId);
 var strPaperId = objgs_TagsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_TagsEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.ShareId);
 var strShareId = objgs_TagsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objgs_TagsEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageNumIn);
 var strPdfPageNumIn = objgs_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objgs_TagsEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfPageTop);
 arrValueListForInsert.Add(objgs_TagsEN.PdfPageTop.ToString());
 }
 
 if (objgs_TagsEN.selectSpanRange !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.selectSpanRange);
 var strselectSpanRange = objgs_TagsEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strselectSpanRange + "'");
 }
 
 if (objgs_TagsEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfDivLet);
 var strPdfDivLet = objgs_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objgs_TagsEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfDivTop);
 var strPdfDivTop = objgs_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objgs_TagsEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.PdfZoom);
 var strPdfZoom = objgs_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objgs_TagsEN.TagsTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_Tags.TagsTypeId);
 var strTagsTypeId = objgs_TagsEN.TagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTagsTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_Tags");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_Tagss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from gs_Tags where TagsId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_Tags");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTagsId = oRow[congs_Tags.TagsId].ToString().Trim();
if (IsExist(strTagsId))
{
 string strResult = "关键字变量值为:" + string.Format("TagsId = {0}", strTagsId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_TagsEN._CurrTabName ].NewRow();
objRow[congs_Tags.TagsId] = oRow[congs_Tags.TagsId].ToString().Trim(); //标注Id
objRow[congs_Tags.TagsContent] = oRow[congs_Tags.TagsContent].ToString().Trim(); //标注内容
objRow[congs_Tags.PdfContent] = oRow[congs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objRow[congs_Tags.PdfPageNum] = oRow[congs_Tags.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[congs_Tags.VoteCount] = oRow[congs_Tags.VoteCount].ToString().Trim(); //点赞计数
objRow[congs_Tags.UserId] = oRow[congs_Tags.UserId].ToString().Trim(); //用户ID
objRow[congs_Tags.OrderNum] = oRow[congs_Tags.OrderNum].ToString().Trim(); //序号
objRow[congs_Tags.UpdUser] = oRow[congs_Tags.UpdUser].ToString().Trim(); //修改人
objRow[congs_Tags.UpdDate] = oRow[congs_Tags.UpdDate].ToString().Trim(); //修改日期
objRow[congs_Tags.PdfLineNum] = oRow[congs_Tags.PdfLineNum].ToString().Trim(); //pdf行号
objRow[congs_Tags.PdfX] = oRow[congs_Tags.PdfX].ToString().Trim(); //PdfX
objRow[congs_Tags.PdfY] = oRow[congs_Tags.PdfY].ToString().Trim(); //PdfY
objRow[congs_Tags.Memo] = oRow[congs_Tags.Memo].ToString().Trim(); //备注
objRow[congs_Tags.IdCurrEduCls] = oRow[congs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[congs_Tags.PaperId] = oRow[congs_Tags.PaperId].ToString().Trim(); //论文Id
objRow[congs_Tags.ShareId] = oRow[congs_Tags.ShareId].ToString().Trim(); //分享Id
objRow[congs_Tags.PdfPageNumIn] = oRow[congs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[congs_Tags.PdfPageTop] = oRow[congs_Tags.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[congs_Tags.selectSpanRange] = oRow[congs_Tags.selectSpanRange].ToString().Trim(); //选择Span范围
objRow[congs_Tags.PdfDivLet] = oRow[congs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[congs_Tags.PdfDivTop] = oRow[congs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[congs_Tags.PdfZoom] = oRow[congs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objRow[congs_Tags.TagsTypeId] = oRow[congs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
 objDS.Tables[clsgs_TagsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_TagsEN._CurrTabName);
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
 /// <param name = "objgs_TagsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_TagsEN objgs_TagsEN)
{
 if (objgs_TagsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TagsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from gs_Tags where TagsId = " + "'"+ objgs_TagsEN.TagsId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_TagsEN._CurrTabName);
if (objDS.Tables[clsgs_TagsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TagsId = " + "'"+ objgs_TagsEN.TagsId+"'");
return false;
}
objRow = objDS.Tables[clsgs_TagsEN._CurrTabName].Rows[0];
 if (objgs_TagsEN.IsUpdated(congs_Tags.TagsId))
 {
objRow[congs_Tags.TagsId] = objgs_TagsEN.TagsId; //标注Id
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.TagsContent))
 {
objRow[congs_Tags.TagsContent] = objgs_TagsEN.TagsContent; //标注内容
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfContent))
 {
objRow[congs_Tags.PdfContent] = objgs_TagsEN.PdfContent; //Pdf内容
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageNum))
 {
objRow[congs_Tags.PdfPageNum] = objgs_TagsEN.PdfPageNum; //Pdf页码
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.VoteCount))
 {
objRow[congs_Tags.VoteCount] = objgs_TagsEN.VoteCount; //点赞计数
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.UserId))
 {
objRow[congs_Tags.UserId] = objgs_TagsEN.UserId; //用户ID
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.OrderNum))
 {
objRow[congs_Tags.OrderNum] = objgs_TagsEN.OrderNum; //序号
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.UpdUser))
 {
objRow[congs_Tags.UpdUser] = objgs_TagsEN.UpdUser; //修改人
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.UpdDate))
 {
objRow[congs_Tags.UpdDate] = objgs_TagsEN.UpdDate; //修改日期
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfLineNum))
 {
objRow[congs_Tags.PdfLineNum] = objgs_TagsEN.PdfLineNum; //pdf行号
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfX))
 {
objRow[congs_Tags.PdfX] = objgs_TagsEN.PdfX; //PdfX
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfY))
 {
objRow[congs_Tags.PdfY] = objgs_TagsEN.PdfY; //PdfY
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.Memo))
 {
objRow[congs_Tags.Memo] = objgs_TagsEN.Memo; //备注
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.IdCurrEduCls))
 {
objRow[congs_Tags.IdCurrEduCls] = objgs_TagsEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.PaperId))
 {
objRow[congs_Tags.PaperId] = objgs_TagsEN.PaperId; //论文Id
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.ShareId))
 {
objRow[congs_Tags.ShareId] = objgs_TagsEN.ShareId; //分享Id
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageNumIn))
 {
objRow[congs_Tags.PdfPageNumIn] = objgs_TagsEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageTop))
 {
objRow[congs_Tags.PdfPageTop] = objgs_TagsEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.selectSpanRange))
 {
objRow[congs_Tags.selectSpanRange] = objgs_TagsEN.selectSpanRange; //选择Span范围
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfDivLet))
 {
objRow[congs_Tags.PdfDivLet] = objgs_TagsEN.PdfDivLet; //PdfDivLet
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfDivTop))
 {
objRow[congs_Tags.PdfDivTop] = objgs_TagsEN.PdfDivTop; //PdfDivTop
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfZoom))
 {
objRow[congs_Tags.PdfZoom] = objgs_TagsEN.PdfZoom; //PdfZoom
 }
 if (objgs_TagsEN.IsUpdated(congs_Tags.TagsTypeId))
 {
objRow[congs_Tags.TagsTypeId] = objgs_TagsEN.TagsTypeId; //标注类型ID
 }
try
{
objDA.Update(objDS, clsgs_TagsEN._CurrTabName);
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
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_TagsEN objgs_TagsEN)
{
 if (objgs_TagsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TagsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_Tags Set ");
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.TagsContent))
 {
 if (objgs_TagsEN.TagsContent !=  null)
 {
 var strTagsContent = objgs_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTagsContent, congs_Tags.TagsContent); //标注内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.TagsContent); //标注内容
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfContent))
 {
 if (objgs_TagsEN.PdfContent !=  null)
 {
 var strPdfContent = objgs_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, congs_Tags.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfContent); //Pdf内容
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageNum))
 {
 if (objgs_TagsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfPageNum, congs_Tags.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfPageNum); //Pdf页码
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.VoteCount))
 {
 if (objgs_TagsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.VoteCount, congs_Tags.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.VoteCount); //点赞计数
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UserId))
 {
 if (objgs_TagsEN.UserId !=  null)
 {
 var strUserId = objgs_TagsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, congs_Tags.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.UserId); //用户ID
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.OrderNum))
 {
 if (objgs_TagsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.OrderNum, congs_Tags.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.OrderNum); //序号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UpdUser))
 {
 if (objgs_TagsEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_Tags.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.UpdUser); //修改人
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UpdDate))
 {
 if (objgs_TagsEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_Tags.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.UpdDate); //修改日期
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfLineNum))
 {
 if (objgs_TagsEN.PdfLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfLineNum, congs_Tags.PdfLineNum); //pdf行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfLineNum); //pdf行号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfX))
 {
 if (objgs_TagsEN.PdfX !=  null)
 {
 var strPdfX = objgs_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfX, congs_Tags.PdfX); //PdfX
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfX); //PdfX
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfY))
 {
 if (objgs_TagsEN.PdfY !=  null)
 {
 var strPdfY = objgs_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfY, congs_Tags.PdfY); //PdfY
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfY); //PdfY
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.Memo))
 {
 if (objgs_TagsEN.Memo !=  null)
 {
 var strMemo = objgs_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_Tags.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.Memo); //备注
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.IdCurrEduCls))
 {
 if (objgs_TagsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_Tags.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PaperId))
 {
 if (objgs_TagsEN.PaperId !=  null)
 {
 var strPaperId = objgs_TagsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_Tags.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PaperId); //论文Id
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.ShareId))
 {
 if (objgs_TagsEN.ShareId !=  null)
 {
 var strShareId = objgs_TagsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, congs_Tags.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.ShareId); //分享Id
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageNumIn))
 {
 if (objgs_TagsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objgs_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, congs_Tags.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageTop))
 {
 if (objgs_TagsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfPageTop, congs_Tags.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.selectSpanRange))
 {
 if (objgs_TagsEN.selectSpanRange !=  null)
 {
 var strselectSpanRange = objgs_TagsEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strselectSpanRange, congs_Tags.selectSpanRange); //选择Span范围
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.selectSpanRange); //选择Span范围
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfDivLet))
 {
 if (objgs_TagsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objgs_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, congs_Tags.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfDivTop))
 {
 if (objgs_TagsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objgs_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, congs_Tags.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfZoom))
 {
 if (objgs_TagsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objgs_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, congs_Tags.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfZoom); //PdfZoom
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.TagsTypeId))
 {
 if (objgs_TagsEN.TagsTypeId !=  null)
 {
 var strTagsTypeId = objgs_TagsEN.TagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTagsTypeId, congs_Tags.TagsTypeId); //标注类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.TagsTypeId); //标注类型ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TagsId = '{0}'", objgs_TagsEN.TagsId); 
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
 /// <param name = "objgs_TagsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_TagsEN objgs_TagsEN, string strCondition)
{
 if (objgs_TagsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TagsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_Tags Set ");
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.TagsContent))
 {
 if (objgs_TagsEN.TagsContent !=  null)
 {
 var strTagsContent = objgs_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TagsContent = '{0}',", strTagsContent); //标注内容
 }
 else
 {
 sbSQL.Append(" TagsContent = null,"); //标注内容
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfContent))
 {
 if (objgs_TagsEN.PdfContent !=  null)
 {
 var strPdfContent = objgs_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageNum))
 {
 if (objgs_TagsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfPageNum, congs_Tags.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfPageNum); //Pdf页码
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.VoteCount))
 {
 if (objgs_TagsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.VoteCount, congs_Tags.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.VoteCount); //点赞计数
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UserId))
 {
 if (objgs_TagsEN.UserId !=  null)
 {
 var strUserId = objgs_TagsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.OrderNum))
 {
 if (objgs_TagsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.OrderNum, congs_Tags.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.OrderNum); //序号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UpdUser))
 {
 if (objgs_TagsEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UpdDate))
 {
 if (objgs_TagsEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfLineNum))
 {
 if (objgs_TagsEN.PdfLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfLineNum, congs_Tags.PdfLineNum); //pdf行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfLineNum); //pdf行号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfX))
 {
 if (objgs_TagsEN.PdfX !=  null)
 {
 var strPdfX = objgs_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfX = '{0}',", strPdfX); //PdfX
 }
 else
 {
 sbSQL.Append(" PdfX = null,"); //PdfX
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfY))
 {
 if (objgs_TagsEN.PdfY !=  null)
 {
 var strPdfY = objgs_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfY = '{0}',", strPdfY); //PdfY
 }
 else
 {
 sbSQL.Append(" PdfY = null,"); //PdfY
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.Memo))
 {
 if (objgs_TagsEN.Memo !=  null)
 {
 var strMemo = objgs_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.IdCurrEduCls))
 {
 if (objgs_TagsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PaperId))
 {
 if (objgs_TagsEN.PaperId !=  null)
 {
 var strPaperId = objgs_TagsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.ShareId))
 {
 if (objgs_TagsEN.ShareId !=  null)
 {
 var strShareId = objgs_TagsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageNumIn))
 {
 if (objgs_TagsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objgs_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageTop))
 {
 if (objgs_TagsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfPageTop, congs_Tags.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.selectSpanRange))
 {
 if (objgs_TagsEN.selectSpanRange !=  null)
 {
 var strselectSpanRange = objgs_TagsEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" selectSpanRange = '{0}',", strselectSpanRange); //选择Span范围
 }
 else
 {
 sbSQL.Append(" selectSpanRange = null,"); //选择Span范围
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfDivLet))
 {
 if (objgs_TagsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objgs_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfDivTop))
 {
 if (objgs_TagsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objgs_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfZoom))
 {
 if (objgs_TagsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objgs_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.TagsTypeId))
 {
 if (objgs_TagsEN.TagsTypeId !=  null)
 {
 var strTagsTypeId = objgs_TagsEN.TagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TagsTypeId = '{0}',", strTagsTypeId); //标注类型ID
 }
 else
 {
 sbSQL.Append(" TagsTypeId = null,"); //标注类型ID
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
 /// <param name = "objgs_TagsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_TagsEN objgs_TagsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_TagsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TagsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_Tags Set ");
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.TagsContent))
 {
 if (objgs_TagsEN.TagsContent !=  null)
 {
 var strTagsContent = objgs_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TagsContent = '{0}',", strTagsContent); //标注内容
 }
 else
 {
 sbSQL.Append(" TagsContent = null,"); //标注内容
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfContent))
 {
 if (objgs_TagsEN.PdfContent !=  null)
 {
 var strPdfContent = objgs_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageNum))
 {
 if (objgs_TagsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfPageNum, congs_Tags.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfPageNum); //Pdf页码
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.VoteCount))
 {
 if (objgs_TagsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.VoteCount, congs_Tags.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.VoteCount); //点赞计数
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UserId))
 {
 if (objgs_TagsEN.UserId !=  null)
 {
 var strUserId = objgs_TagsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.OrderNum))
 {
 if (objgs_TagsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.OrderNum, congs_Tags.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.OrderNum); //序号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UpdUser))
 {
 if (objgs_TagsEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UpdDate))
 {
 if (objgs_TagsEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfLineNum))
 {
 if (objgs_TagsEN.PdfLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfLineNum, congs_Tags.PdfLineNum); //pdf行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfLineNum); //pdf行号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfX))
 {
 if (objgs_TagsEN.PdfX !=  null)
 {
 var strPdfX = objgs_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfX = '{0}',", strPdfX); //PdfX
 }
 else
 {
 sbSQL.Append(" PdfX = null,"); //PdfX
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfY))
 {
 if (objgs_TagsEN.PdfY !=  null)
 {
 var strPdfY = objgs_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfY = '{0}',", strPdfY); //PdfY
 }
 else
 {
 sbSQL.Append(" PdfY = null,"); //PdfY
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.Memo))
 {
 if (objgs_TagsEN.Memo !=  null)
 {
 var strMemo = objgs_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.IdCurrEduCls))
 {
 if (objgs_TagsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PaperId))
 {
 if (objgs_TagsEN.PaperId !=  null)
 {
 var strPaperId = objgs_TagsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.ShareId))
 {
 if (objgs_TagsEN.ShareId !=  null)
 {
 var strShareId = objgs_TagsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageNumIn))
 {
 if (objgs_TagsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objgs_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageTop))
 {
 if (objgs_TagsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfPageTop, congs_Tags.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.selectSpanRange))
 {
 if (objgs_TagsEN.selectSpanRange !=  null)
 {
 var strselectSpanRange = objgs_TagsEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" selectSpanRange = '{0}',", strselectSpanRange); //选择Span范围
 }
 else
 {
 sbSQL.Append(" selectSpanRange = null,"); //选择Span范围
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfDivLet))
 {
 if (objgs_TagsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objgs_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfDivTop))
 {
 if (objgs_TagsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objgs_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfZoom))
 {
 if (objgs_TagsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objgs_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.TagsTypeId))
 {
 if (objgs_TagsEN.TagsTypeId !=  null)
 {
 var strTagsTypeId = objgs_TagsEN.TagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TagsTypeId = '{0}',", strTagsTypeId); //标注类型ID
 }
 else
 {
 sbSQL.Append(" TagsTypeId = null,"); //标注类型ID
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
 /// <param name = "objgs_TagsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_TagsEN objgs_TagsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_TagsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TagsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_Tags Set ");
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.TagsContent))
 {
 if (objgs_TagsEN.TagsContent !=  null)
 {
 var strTagsContent = objgs_TagsEN.TagsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTagsContent, congs_Tags.TagsContent); //标注内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.TagsContent); //标注内容
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfContent))
 {
 if (objgs_TagsEN.PdfContent !=  null)
 {
 var strPdfContent = objgs_TagsEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, congs_Tags.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfContent); //Pdf内容
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageNum))
 {
 if (objgs_TagsEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfPageNum, congs_Tags.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfPageNum); //Pdf页码
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.VoteCount))
 {
 if (objgs_TagsEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.VoteCount, congs_Tags.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.VoteCount); //点赞计数
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UserId))
 {
 if (objgs_TagsEN.UserId !=  null)
 {
 var strUserId = objgs_TagsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, congs_Tags.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.UserId); //用户ID
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.OrderNum))
 {
 if (objgs_TagsEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.OrderNum, congs_Tags.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.OrderNum); //序号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UpdUser))
 {
 if (objgs_TagsEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TagsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_Tags.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.UpdUser); //修改人
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.UpdDate))
 {
 if (objgs_TagsEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TagsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_Tags.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.UpdDate); //修改日期
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfLineNum))
 {
 if (objgs_TagsEN.PdfLineNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfLineNum, congs_Tags.PdfLineNum); //pdf行号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfLineNum); //pdf行号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfX))
 {
 if (objgs_TagsEN.PdfX !=  null)
 {
 var strPdfX = objgs_TagsEN.PdfX.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfX, congs_Tags.PdfX); //PdfX
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfX); //PdfX
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfY))
 {
 if (objgs_TagsEN.PdfY !=  null)
 {
 var strPdfY = objgs_TagsEN.PdfY.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfY, congs_Tags.PdfY); //PdfY
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfY); //PdfY
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.Memo))
 {
 if (objgs_TagsEN.Memo !=  null)
 {
 var strMemo = objgs_TagsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_Tags.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.Memo); //备注
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.IdCurrEduCls))
 {
 if (objgs_TagsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_TagsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_Tags.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PaperId))
 {
 if (objgs_TagsEN.PaperId !=  null)
 {
 var strPaperId = objgs_TagsEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_Tags.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PaperId); //论文Id
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.ShareId))
 {
 if (objgs_TagsEN.ShareId !=  null)
 {
 var strShareId = objgs_TagsEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, congs_Tags.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.ShareId); //分享Id
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageNumIn))
 {
 if (objgs_TagsEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objgs_TagsEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, congs_Tags.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfPageTop))
 {
 if (objgs_TagsEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TagsEN.PdfPageTop, congs_Tags.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.selectSpanRange))
 {
 if (objgs_TagsEN.selectSpanRange !=  null)
 {
 var strselectSpanRange = objgs_TagsEN.selectSpanRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strselectSpanRange, congs_Tags.selectSpanRange); //选择Span范围
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.selectSpanRange); //选择Span范围
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfDivLet))
 {
 if (objgs_TagsEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objgs_TagsEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, congs_Tags.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfDivTop))
 {
 if (objgs_TagsEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objgs_TagsEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, congs_Tags.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.PdfZoom))
 {
 if (objgs_TagsEN.PdfZoom !=  null)
 {
 var strPdfZoom = objgs_TagsEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, congs_Tags.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.PdfZoom); //PdfZoom
 }
 }
 
 if (objgs_TagsEN.IsUpdated(congs_Tags.TagsTypeId))
 {
 if (objgs_TagsEN.TagsTypeId !=  null)
 {
 var strTagsTypeId = objgs_TagsEN.TagsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTagsTypeId, congs_Tags.TagsTypeId); //标注类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_Tags.TagsTypeId); //标注类型ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TagsId = '{0}'", objgs_TagsEN.TagsId); 
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
 /// <param name = "strTagsId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTagsId) 
{
CheckPrimaryKey(strTagsId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTagsId,
};
 objSQL.ExecSP("gs_Tags_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTagsId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTagsId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTagsId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
//删除gs_Tags本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_Tags where TagsId = " + "'"+ strTagsId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_Tags(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
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
//删除gs_Tags本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_Tags where TagsId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTagsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTagsId) 
{
CheckPrimaryKey(strTagsId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
//删除gs_Tags本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_Tags where TagsId = " + "'"+ strTagsId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_Tags(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_TagsDA: Delgs_Tags)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_Tags where " + strCondition ;
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
public bool Delgs_TagsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_TagsDA: Delgs_TagsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_Tags where " + strCondition ;
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
 /// <param name = "objgs_TagsENS">源对象</param>
 /// <param name = "objgs_TagsENT">目标对象</param>
public void CopyTo(clsgs_TagsEN objgs_TagsENS, clsgs_TagsEN objgs_TagsENT)
{
objgs_TagsENT.TagsId = objgs_TagsENS.TagsId; //标注Id
objgs_TagsENT.TagsContent = objgs_TagsENS.TagsContent; //标注内容
objgs_TagsENT.PdfContent = objgs_TagsENS.PdfContent; //Pdf内容
objgs_TagsENT.PdfPageNum = objgs_TagsENS.PdfPageNum; //Pdf页码
objgs_TagsENT.VoteCount = objgs_TagsENS.VoteCount; //点赞计数
objgs_TagsENT.UserId = objgs_TagsENS.UserId; //用户ID
objgs_TagsENT.OrderNum = objgs_TagsENS.OrderNum; //序号
objgs_TagsENT.UpdUser = objgs_TagsENS.UpdUser; //修改人
objgs_TagsENT.UpdDate = objgs_TagsENS.UpdDate; //修改日期
objgs_TagsENT.PdfLineNum = objgs_TagsENS.PdfLineNum; //pdf行号
objgs_TagsENT.PdfX = objgs_TagsENS.PdfX; //PdfX
objgs_TagsENT.PdfY = objgs_TagsENS.PdfY; //PdfY
objgs_TagsENT.Memo = objgs_TagsENS.Memo; //备注
objgs_TagsENT.IdCurrEduCls = objgs_TagsENS.IdCurrEduCls; //教学班流水号
objgs_TagsENT.PaperId = objgs_TagsENS.PaperId; //论文Id
objgs_TagsENT.ShareId = objgs_TagsENS.ShareId; //分享Id
objgs_TagsENT.PdfPageNumIn = objgs_TagsENS.PdfPageNumIn; //PdfPageNumIn
objgs_TagsENT.PdfPageTop = objgs_TagsENS.PdfPageTop; //pdf页面顶部位置
objgs_TagsENT.selectSpanRange = objgs_TagsENS.selectSpanRange; //选择Span范围
objgs_TagsENT.PdfDivLet = objgs_TagsENS.PdfDivLet; //PdfDivLet
objgs_TagsENT.PdfDivTop = objgs_TagsENS.PdfDivTop; //PdfDivTop
objgs_TagsENT.PdfZoom = objgs_TagsENS.PdfZoom; //PdfZoom
objgs_TagsENT.TagsTypeId = objgs_TagsENS.TagsTypeId; //标注类型ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_TagsEN objgs_TagsEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_TagsEN.TagsId, 10, congs_Tags.TagsId);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfContent, 2000, congs_Tags.PdfContent);
clsCheckSql.CheckFieldLen(objgs_TagsEN.UserId, 18, congs_Tags.UserId);
clsCheckSql.CheckFieldLen(objgs_TagsEN.UpdUser, 20, congs_Tags.UpdUser);
clsCheckSql.CheckFieldLen(objgs_TagsEN.UpdDate, 20, congs_Tags.UpdDate);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfX, 50, congs_Tags.PdfX);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfY, 50, congs_Tags.PdfY);
clsCheckSql.CheckFieldLen(objgs_TagsEN.Memo, 1000, congs_Tags.Memo);
clsCheckSql.CheckFieldLen(objgs_TagsEN.IdCurrEduCls, 8, congs_Tags.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PaperId, 8, congs_Tags.PaperId);
clsCheckSql.CheckFieldLen(objgs_TagsEN.ShareId, 2, congs_Tags.ShareId);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfPageNumIn, 50, congs_Tags.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objgs_TagsEN.selectSpanRange, 50, congs_Tags.selectSpanRange);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfDivLet, 50, congs_Tags.PdfDivLet);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfDivTop, 50, congs_Tags.PdfDivTop);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfZoom, 50, congs_Tags.PdfZoom);
clsCheckSql.CheckFieldLen(objgs_TagsEN.TagsTypeId, 2, congs_Tags.TagsTypeId);
//检查字段外键固定长度
 objgs_TagsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_TagsEN objgs_TagsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfContent, 2000, congs_Tags.PdfContent);
clsCheckSql.CheckFieldLen(objgs_TagsEN.UserId, 18, congs_Tags.UserId);
clsCheckSql.CheckFieldLen(objgs_TagsEN.UpdUser, 20, congs_Tags.UpdUser);
clsCheckSql.CheckFieldLen(objgs_TagsEN.UpdDate, 20, congs_Tags.UpdDate);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfX, 50, congs_Tags.PdfX);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfY, 50, congs_Tags.PdfY);
clsCheckSql.CheckFieldLen(objgs_TagsEN.Memo, 1000, congs_Tags.Memo);
clsCheckSql.CheckFieldLen(objgs_TagsEN.IdCurrEduCls, 8, congs_Tags.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PaperId, 8, congs_Tags.PaperId);
clsCheckSql.CheckFieldLen(objgs_TagsEN.ShareId, 2, congs_Tags.ShareId);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfPageNumIn, 50, congs_Tags.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objgs_TagsEN.selectSpanRange, 50, congs_Tags.selectSpanRange);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfDivLet, 50, congs_Tags.PdfDivLet);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfDivTop, 50, congs_Tags.PdfDivTop);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfZoom, 50, congs_Tags.PdfZoom);
clsCheckSql.CheckFieldLen(objgs_TagsEN.TagsTypeId, 2, congs_Tags.TagsTypeId);
//检查外键字段长度
 objgs_TagsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_TagsEN objgs_TagsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_TagsEN.TagsId, 10, congs_Tags.TagsId);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfContent, 2000, congs_Tags.PdfContent);
clsCheckSql.CheckFieldLen(objgs_TagsEN.UserId, 18, congs_Tags.UserId);
clsCheckSql.CheckFieldLen(objgs_TagsEN.UpdUser, 20, congs_Tags.UpdUser);
clsCheckSql.CheckFieldLen(objgs_TagsEN.UpdDate, 20, congs_Tags.UpdDate);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfX, 50, congs_Tags.PdfX);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfY, 50, congs_Tags.PdfY);
clsCheckSql.CheckFieldLen(objgs_TagsEN.Memo, 1000, congs_Tags.Memo);
clsCheckSql.CheckFieldLen(objgs_TagsEN.IdCurrEduCls, 8, congs_Tags.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PaperId, 8, congs_Tags.PaperId);
clsCheckSql.CheckFieldLen(objgs_TagsEN.ShareId, 2, congs_Tags.ShareId);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfPageNumIn, 50, congs_Tags.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objgs_TagsEN.selectSpanRange, 50, congs_Tags.selectSpanRange);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfDivLet, 50, congs_Tags.PdfDivLet);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfDivTop, 50, congs_Tags.PdfDivTop);
clsCheckSql.CheckFieldLen(objgs_TagsEN.PdfZoom, 50, congs_Tags.PdfZoom);
clsCheckSql.CheckFieldLen(objgs_TagsEN.TagsTypeId, 2, congs_Tags.TagsTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.TagsId, congs_Tags.TagsId);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.PdfContent, congs_Tags.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.UserId, congs_Tags.UserId);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.UpdUser, congs_Tags.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.UpdDate, congs_Tags.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.PdfX, congs_Tags.PdfX);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.PdfY, congs_Tags.PdfY);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.Memo, congs_Tags.Memo);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.IdCurrEduCls, congs_Tags.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.PaperId, congs_Tags.PaperId);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.ShareId, congs_Tags.ShareId);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.PdfPageNumIn, congs_Tags.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.selectSpanRange, congs_Tags.selectSpanRange);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.PdfDivLet, congs_Tags.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.PdfDivTop, congs_Tags.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.PdfZoom, congs_Tags.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objgs_TagsEN.TagsTypeId, congs_Tags.TagsTypeId);
//检查外键字段长度
 objgs_TagsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_Tags(标注),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_TagsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_TagsEN objgs_TagsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objgs_TagsEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null");
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objgs_TagsEN.PaperId);
}
 sbCondition.AppendFormat(" and TagsId = '{0}'", objgs_TagsEN.TagsId);
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
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
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
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
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
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_TagsEN._CurrTabName);
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
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_TagsEN._CurrTabName, strCondition);
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
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
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
 objSQL = clsgs_TagsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}