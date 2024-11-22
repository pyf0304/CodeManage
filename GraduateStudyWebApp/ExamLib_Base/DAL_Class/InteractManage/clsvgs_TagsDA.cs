
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_TagsDA
 表名:vgs_Tags(01120757)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 论文标注视图(vgs_Tags)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_TagsDA : clsCommBase4DA
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
 return clsvgs_TagsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_TagsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_TagsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_TagsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_TagsEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vgs_Tags中,检查关键字,长度不正确!(clsvgs_TagsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTagsId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vgs_Tags中,关键字不能为空 或 null!(clsvgs_TagsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTagsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvgs_TagsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vgs_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_Tags(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_TagsDA: GetDataTable_vgs_Tags)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vgs_Tags where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vgs_Tags where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_TagsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_TagsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_Tags where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_Tags where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_TagsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_Tags where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_TagsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_Tags.* from vgs_Tags Left Join {1} on {2} where {3} and vgs_Tags.TagsId not in (Select top {5} vgs_Tags.TagsId from vgs_Tags Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_Tags where {1} and TagsId not in (Select top {2} TagsId from vgs_Tags where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_Tags where {1} and TagsId not in (Select top {3} TagsId from vgs_Tags where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_TagsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_Tags.* from vgs_Tags Left Join {1} on {2} where {3} and vgs_Tags.TagsId not in (Select top {5} vgs_Tags.TagsId from vgs_Tags Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_Tags where {1} and TagsId not in (Select top {2} TagsId from vgs_Tags where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_Tags where {1} and TagsId not in (Select top {3} TagsId from vgs_Tags where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_TagsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_TagsDA:GetObjLst)", objException.Message));
}
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vgs_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_TagsDA: GetObjLst)", objException.Message));
}
objvgs_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_TagsEN);
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
public List<clsvgs_TagsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_TagsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_TagsDA: GetObjLst)", objException.Message));
}
objvgs_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_TagsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_Tags(ref clsvgs_TagsEN objvgs_TagsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vgs_Tags where TagsId = " + "'"+ objvgs_TagsEN.TagsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_TagsEN.TagsId = objDT.Rows[0][convgs_Tags.TagsId].ToString().Trim(); //标注Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_TagsEN.TagsContent = objDT.Rows[0][convgs_Tags.TagsContent].ToString().Trim(); //标注内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_TagsEN.PdfContent = objDT.Rows[0][convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvgs_TagsEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TagsEN.VoteCount = TransNullToInt(objDT.Rows[0][convgs_Tags.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TagsEN.OrderNum = TransNullToInt(objDT.Rows[0][convgs_Tags.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TagsEN.UpdUser = objDT.Rows[0][convgs_Tags.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_TagsEN.UpdDate = objDT.Rows[0][convgs_Tags.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_TagsEN.PdfLineNum = TransNullToInt(objDT.Rows[0][convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TagsEN.PdfX = objDT.Rows[0][convgs_Tags.PdfX].ToString().Trim(); //PdfX(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.PdfY = objDT.Rows[0][convgs_Tags.PdfY].ToString().Trim(); //PdfY(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.Memo = objDT.Rows[0][convgs_Tags.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_TagsEN.IdCurrEduCls = objDT.Rows[0][convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_TagsEN.PaperTitle = objDT.Rows[0][convgs_Tags.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_TagsEN.PaperId = objDT.Rows[0][convgs_Tags.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_TagsEN.ShareId = objDT.Rows[0][convgs_Tags.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_TagsEN.PdfPageNumIn = objDT.Rows[0][convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.PdfPageTop = TransNullToInt(objDT.Rows[0][convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TagsEN.PdfDivLet = objDT.Rows[0][convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.PdfDivTop = objDT.Rows[0][convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.PdfZoom = objDT.Rows[0][convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.TagsTypeId = objDT.Rows[0][convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_TagsDA: Getvgs_Tags)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTagsId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_TagsEN GetObjByTagsId(string strTagsId)
{
CheckPrimaryKey(strTagsId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vgs_Tags where TagsId = " + "'"+ strTagsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
 objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_TagsDA: GetObjByTagsId)", objException.Message));
}
return objvgs_TagsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_TagsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_TagsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
strSQL = "Select * from vgs_Tags where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN()
{
TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(), //标注Id
TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(), //标注内容
PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfPageNum].ToString().Trim()), //Pdf页码
VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.VoteCount].ToString().Trim()), //点赞计数
OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.OrderNum].ToString().Trim()), //序号
UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(), //修改日期
PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfLineNum].ToString().Trim()), //pdf行号
PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(), //PdfX
PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(), //PdfY
Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(), //教学班流水号
PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(), //论文标题
PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(), //论文Id
ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(), //分享Id
PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(), //PdfZoom
TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim() //标注类型ID
};
objvgs_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_TagsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_TagsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_TagsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_TagsDA: GetObjByDataRowvgs_Tags)", objException.Message));
}
objvgs_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_TagsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_TagsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_TagsDA: GetObjByDataRow)", objException.Message));
}
objvgs_TagsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_TagsEN;
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
objSQL = clsvgs_TagsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_TagsEN._CurrTabName, convgs_Tags.TagsId, 10, "");
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
objSQL = clsvgs_TagsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_TagsEN._CurrTabName, convgs_Tags.TagsId, 10, strPrefix);
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
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TagsId from vgs_Tags where " + strCondition;
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
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TagsId from vgs_Tags where " + strCondition;
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
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_Tags", "TagsId = " + "'"+ strTagsId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_TagsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_Tags", strCondition))
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
objSQL = clsvgs_TagsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_Tags");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_TagsENS">源对象</param>
 /// <param name = "objvgs_TagsENT">目标对象</param>
public void CopyTo(clsvgs_TagsEN objvgs_TagsENS, clsvgs_TagsEN objvgs_TagsENT)
{
objvgs_TagsENT.TagsId = objvgs_TagsENS.TagsId; //标注Id
objvgs_TagsENT.TagsContent = objvgs_TagsENS.TagsContent; //标注内容
objvgs_TagsENT.PdfContent = objvgs_TagsENS.PdfContent; //Pdf内容
objvgs_TagsENT.PdfPageNum = objvgs_TagsENS.PdfPageNum; //Pdf页码
objvgs_TagsENT.VoteCount = objvgs_TagsENS.VoteCount; //点赞计数
objvgs_TagsENT.OrderNum = objvgs_TagsENS.OrderNum; //序号
objvgs_TagsENT.UpdUser = objvgs_TagsENS.UpdUser; //修改人
objvgs_TagsENT.UpdDate = objvgs_TagsENS.UpdDate; //修改日期
objvgs_TagsENT.PdfLineNum = objvgs_TagsENS.PdfLineNum; //pdf行号
objvgs_TagsENT.PdfX = objvgs_TagsENS.PdfX; //PdfX
objvgs_TagsENT.PdfY = objvgs_TagsENS.PdfY; //PdfY
objvgs_TagsENT.Memo = objvgs_TagsENS.Memo; //备注
objvgs_TagsENT.IdCurrEduCls = objvgs_TagsENS.IdCurrEduCls; //教学班流水号
objvgs_TagsENT.PaperTitle = objvgs_TagsENS.PaperTitle; //论文标题
objvgs_TagsENT.PaperId = objvgs_TagsENS.PaperId; //论文Id
objvgs_TagsENT.ShareId = objvgs_TagsENS.ShareId; //分享Id
objvgs_TagsENT.PdfPageNumIn = objvgs_TagsENS.PdfPageNumIn; //PdfPageNumIn
objvgs_TagsENT.PdfPageTop = objvgs_TagsENS.PdfPageTop; //pdf页面顶部位置
objvgs_TagsENT.PdfDivLet = objvgs_TagsENS.PdfDivLet; //PdfDivLet
objvgs_TagsENT.PdfDivTop = objvgs_TagsENS.PdfDivTop; //PdfDivTop
objvgs_TagsENT.PdfZoom = objvgs_TagsENS.PdfZoom; //PdfZoom
objvgs_TagsENT.TagsTypeId = objvgs_TagsENS.TagsTypeId; //标注类型ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_TagsEN objvgs_TagsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_TagsEN.TagsId, 10, convgs_Tags.TagsId);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.PdfContent, 2000, convgs_Tags.PdfContent);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.UpdUser, 20, convgs_Tags.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.UpdDate, 20, convgs_Tags.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.PdfX, 50, convgs_Tags.PdfX);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.PdfY, 50, convgs_Tags.PdfY);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.Memo, 1000, convgs_Tags.Memo);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.IdCurrEduCls, 8, convgs_Tags.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.PaperTitle, 500, convgs_Tags.PaperTitle);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.PaperId, 8, convgs_Tags.PaperId);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.ShareId, 2, convgs_Tags.ShareId);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.PdfPageNumIn, 50, convgs_Tags.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.PdfDivLet, 50, convgs_Tags.PdfDivLet);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.PdfDivTop, 50, convgs_Tags.PdfDivTop);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.PdfZoom, 50, convgs_Tags.PdfZoom);
clsCheckSql.CheckFieldLen(objvgs_TagsEN.TagsTypeId, 2, convgs_Tags.TagsTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.TagsId, convgs_Tags.TagsId);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.PdfContent, convgs_Tags.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.UpdUser, convgs_Tags.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.UpdDate, convgs_Tags.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.PdfX, convgs_Tags.PdfX);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.PdfY, convgs_Tags.PdfY);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.Memo, convgs_Tags.Memo);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.IdCurrEduCls, convgs_Tags.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.PaperTitle, convgs_Tags.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.PaperId, convgs_Tags.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.ShareId, convgs_Tags.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.PdfPageNumIn, convgs_Tags.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.PdfDivLet, convgs_Tags.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.PdfDivTop, convgs_Tags.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.PdfZoom, convgs_Tags.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objvgs_TagsEN.TagsTypeId, convgs_Tags.TagsTypeId);
//检查外键字段长度
 objvgs_TagsEN._IsCheckProperty = true;
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
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
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
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
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
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_TagsEN._CurrTabName);
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
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_TagsEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_TagsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}