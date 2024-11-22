
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_ViewIdGCVariableRelaEx : RelatedActions_ViewIdGCVariableRela
    {
        public override bool UpdRelaTabDate(string strVarId, string strViewId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsViewIdGCVariableRelaBLEx_Static
    {
        public static bool bolIsDefRoute = false;
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objViewIdGCVariableRelaENS">源对象</param>
        /// <returns>目标对象=>clsViewIdGCVariableRelaEN:objViewIdGCVariableRelaENT</returns>
        public static clsViewIdGCVariableRelaENEx CopyToEx(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENS)
        {
            try
            {
                clsViewIdGCVariableRelaENEx objViewIdGCVariableRelaENT = new clsViewIdGCVariableRelaENEx();
                clsViewIdGCVariableRelaBL.ViewIdGCVariableRelaDA.CopyTo(objViewIdGCVariableRelaENS, objViewIdGCVariableRelaENT);
                return objViewIdGCVariableRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objViewIdGCVariableRelaENS">源对象</param>
        /// <returns>目标对象=>clsViewIdGCVariableRelaEN:objViewIdGCVariableRelaENT</returns>
        public static clsViewIdGCVariableRelaEN CopyTo(this clsViewIdGCVariableRelaENEx objViewIdGCVariableRelaENS)
        {
            try
            {
                clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENT = new clsViewIdGCVariableRelaEN();
                clsViewIdGCVariableRelaBL.CopyTo(objViewIdGCVariableRelaENS, objViewIdGCVariableRelaENT);
                return objViewIdGCVariableRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static string GetGC_InitVarValue(this clsViewIdGCVariableRelaEN objViewIdGCVariableRela, IImportClass objImportClass, string strBaseUrl)
        {
            try
            {
                StringBuilder sbCodeText = new StringBuilder();
                var objVar = clsGCVariableBL.GetObjByVarIdCache(objViewIdGCVariableRela.VarId);
                switch (objViewIdGCVariableRela.RetrievalMethodId)
                {
                    case enumRetrievalMethod.Undefined_01:
                        if (objVar.VarTypeId == enumGCVariableType.Object_0010)
                        {
                            sbCodeText.Append("\r\n" + $"{objVar.GetVarName4View()}.value = null;");
                        }
                        else if (objVar.IsBoolType() == true)
                        {
                            sbCodeText.Append("\r\n" + $"{objVar.GetVarName4View()}.value = true;");
                        }
                        else if (objVar.IsNumberType() == true)
                        {
                            sbCodeText.Append("\r\n" + $"{objVar.GetVarName4View()}.value = 0;");
                        }
                        else
                        {
                            sbCodeText.Append("\r\n" + $"{objVar.GetVarName4View()}.value = \"\";");
                        }
                        break;
                    case enumRetrievalMethod.RouteParameters_02:
                        if (bolIsDefRoute == false)
                        {
                            sbCodeText.Append("\r\n" + $" const route = useRoute(); // 获取当前路由信息");
                            bolIsDefRoute = true;
                        }
                        sbCodeText.Append("\r\n" + $" if (typeof route.params.{objVar.VarName} === 'string') {{");
                        sbCodeText.Append("\r\n" + $" {objVar.GetVarName4View()}.value = route.params.{objVar.VarName};");
                        //   // clsPrivateSessionStorage.viewId = viewId.value;
                        sbCodeText.Append("\r\n" + "}");
                        break;
                    case enumRetrievalMethod.RouteQuery_03:

                        if (bolIsDefRoute == false)
                        {
                            sbCodeText.Append("\r\n" + $" const route = useRoute(); // 获取当前路由信息");
                            bolIsDefRoute = true;
                        }
                        sbCodeText.Append("\r\n" + $" if (typeof route.query.{objVar.VarName} === 'string') {{");
                        sbCodeText.Append("\r\n" + $" {objVar.GetVarName4View()}.value = route.query.{objVar.VarName};");
                        //   // clsPrivateSessionStorage.viewId = viewId.value;
                        sbCodeText.Append("\r\n" + "}");
                        break;

                    case enumRetrievalMethod.LocalStorage_05:
                    case enumRetrievalMethod.SessionStorage_04:
                        sbCodeText.Append("\r\n" + $"{objVar.GetVarName4View()}.value = {objVar.VarExpression};");
                        if (string.IsNullOrEmpty(objVar.ClsName) == false)
                        {
                            objImportClass.AddImportClass("", objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, strBaseUrl);
                        }
                        break;
                    case enumRetrievalMethod.StoreStorage_06:
                        sbCodeText.Append("\r\n" + $"{objVar.GetVarName4View()}.value = {objVar.VarExpression};");
                        if (string.IsNullOrEmpty(objVar.ClsName) == false)
                        {
                            objImportClass.AddImportClass("", objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, strBaseUrl);
                        }
                        break;
                    case enumRetrievalMethod.CustomDefined_07:
                        if (objVar.VarTypeId == enumGCVariableType.Object_0010)
                        {
                            sbCodeText.Append("\r\n" + $"{objVar.GetVarName4View()}.value = null;");
                        }
                        else if (objVar.IsBoolType() == true)
                        {
                            sbCodeText.Append("\r\n" + $"{objVar.GetVarName4View()}.value = true;");
                        }
                        else if (objVar.IsNumberType() == true)
                        {
                            sbCodeText.Append("\r\n" + $"{objVar.GetVarName4View()}.value = 0;");
                        }
                        else
                        {
                            sbCodeText.Append("\r\n" + $"{objVar.GetVarName4View()}.value = \"\";");
                        }
                        break;
                }
                return sbCodeText.ToString();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static string GetVarName4View(this clsViewIdGCVariableRelaEN objViewIdGCVariableRela)
        {
            clsGCVariableEN objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objViewIdGCVariableRela.VarId);
            return objGCVariable.GetVarName4View();
        }
    }
    /// <summary>
    /// 界面变量关系(ViewIdGCVariableRela)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsViewIdGCVariableRelaBLEx : clsViewIdGCVariableRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsViewIdGCVariableRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsViewIdGCVariableRelaDAEx ViewIdGCVariableRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsViewIdGCVariableRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objViewIdGCVariableRelaENS">源对象</param>
        /// <returns>目标对象=>clsViewIdGCVariableRelaEN:objViewIdGCVariableRelaENT</returns>
        public static clsViewIdGCVariableRelaENEx CopyToEx(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENS)
        {
            try
            {
                clsViewIdGCVariableRelaENEx objViewIdGCVariableRelaENT = new clsViewIdGCVariableRelaENEx();
                clsViewIdGCVariableRelaBL.ViewIdGCVariableRelaDA.CopyTo(objViewIdGCVariableRelaENS, objViewIdGCVariableRelaENT);
                return objViewIdGCVariableRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsViewIdGCVariableRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsViewIdGCVariableRelaEN> arrObjLst = clsViewIdGCVariableRelaBL.GetObjLst(strCondition);
            List<clsViewIdGCVariableRelaENEx> arrObjExLst = new List<clsViewIdGCVariableRelaENEx>();
            foreach (clsViewIdGCVariableRelaEN objInFor in arrObjLst)
            {
                clsViewIdGCVariableRelaENEx objViewIdGCVariableRelaENEx = new clsViewIdGCVariableRelaENEx();
                clsViewIdGCVariableRelaBL.CopyTo(objInFor, objViewIdGCVariableRelaENEx);
                arrObjExLst.Add(objViewIdGCVariableRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strVarId">表关键字</param>
        /// <param name = "strViewId">表关键字</param>
        /// <param name = "strRetrievalMethodId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsViewIdGCVariableRelaENEx GetObjExByKeyLst(string strVarId, string strViewId)
        {
            clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = clsViewIdGCVariableRelaBL.GetObjByKeyLst(strVarId, strViewId);
            clsViewIdGCVariableRelaENEx objViewIdGCVariableRelaENEx = new clsViewIdGCVariableRelaENEx();
            clsViewIdGCVariableRelaBL.CopyTo(objViewIdGCVariableRelaEN, objViewIdGCVariableRelaENEx);
            return objViewIdGCVariableRelaENEx;
        }
        public static bool GetViewVar(string strViewId, string strPrjId, string strOpUser)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' ";
            clsViewIdGCVariableRelaBL.SetFldValue(conViewIdGCVariableRela._CurrTabName, conViewIdGCVariableRela.IsUseInRegion, "0", strWhere);
            clsViewIdGCVariableRelaEN objViewIdGCVariableRela;
            var arrEditRegionFlds = clsEditRegionFldsBLEx.GetObjExLstEx(strViewId, strPrjId);
            var arrEditRegionFlds_Sel = arrEditRegionFlds.Where(x => x.CtlTypeId == enumCtlType.ViewVariable_38 && x.InUse == true);
            foreach (var objInFor in arrEditRegionFlds_Sel)
            {
                if (string.IsNullOrEmpty(objInFor.VarId) == true) continue;
                strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.VarId} = '{objInFor.VarId}' ";
                objViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjByKeyLst(objInFor.VarId, strViewId);

                if (objViewIdGCVariableRela == null)
                {
                    var obj = new clsViewIdGCVariableRelaEN();
                    obj.ViewId = strViewId;
                    obj.VarId = objInFor.VarId;
                    obj.RetrievalMethodId = enumRetrievalMethod.Undefined_01;
                    obj.RegionTypeNames = "EditRegion,";
                    obj.PrjId = strPrjId;
                    obj.IsUseInRegion = true;
                    obj.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    obj.UpdUser = strOpUser;
                    clsViewIdGCVariableRelaBL.AddNewRecordBySql2(obj);
                }
                else if (objViewIdGCVariableRela.RegionTypeNames == null)
                {
                    objViewIdGCVariableRela.RegionTypeNames = "EditRegion,";
                    objViewIdGCVariableRela.IsUseInRegion = true;
                    objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewIdGCVariableRela.UpdUser = strOpUser;
                    clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);

                }
                else if (objViewIdGCVariableRela.RegionTypeNames.IndexOf("EditRegion") == -1)
                {
                    objViewIdGCVariableRela.RegionTypeNames += "EditRegion,";
                    objViewIdGCVariableRela.IsUseInRegion = true;
                    objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewIdGCVariableRela.UpdUser = strOpUser;
                    clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);
                }
                else
                {
                    clsViewIdGCVariableRelaBL.SetFldValue(conViewIdGCVariableRela._CurrTabName, conViewIdGCVariableRela.IsUseInRegion, "1", strWhere);
                }
            }
            var arrEditRegionFlds_Ddl = arrEditRegionFlds.Where(x => x.CtlTypeId == enumCtlType.DropDownList_06);

            foreach (var objInFor in arrEditRegionFlds_Ddl)
            {
                if (string.IsNullOrEmpty(objInFor.TabFeatureId4Ddl) == false)
                {
                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInFor.TabFeatureId4Ddl, objInFor.PrjId);

                    var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInFor.PrjId);

                    var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    List<string> arrVarId_Cond = new List<string>();
                    if (arrTabFeatureFlds_Cond.Count > 1)
                    {
                        if (string.IsNullOrEmpty(objInFor.VarIdCond2) == false) arrVarId_Cond.Add(objInFor.VarIdCond2);
                        if (string.IsNullOrEmpty(objInFor.VarIdCond1) == false) arrVarId_Cond.Add(objInFor.VarIdCond1);
                    }
                    else if (arrTabFeatureFlds_Cond.Count == 1)
                    {
                        if (string.IsNullOrEmpty(objInFor.VarIdCond1) == false) arrVarId_Cond.Add(objInFor.VarIdCond1);
                    }
                    foreach (var strVarId in arrVarId_Cond)
                    {
                        var strVarId_T = clsViewIdGCVariableRelaBLEx.GetCommonOriginVarId(strViewId, strVarId, strPrjId);
                        if (strVarId_T == "") strVarId_T = strVarId;
                        strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.VarId} = '{strVarId_T}' ";
                        objViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjByKeyLst(strVarId_T, strViewId);

                        if (objViewIdGCVariableRela == null)
                        {
                            var obj = new clsViewIdGCVariableRelaEN();
                            obj.ViewId = strViewId;
                            obj.VarId = strVarId_T;
                            obj.RetrievalMethodId = enumRetrievalMethod.Undefined_01;
                            obj.RegionTypeNames = $"CondField(E,{objInFor.ObjFieldTab().FldName}),";
                            obj.PrjId = strPrjId;
                            obj.IsUseInRegion = true;
                            obj.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            obj.UpdUser = strOpUser;
                            clsViewIdGCVariableRelaBL.AddNewRecordBySql2(obj);
                        }
                        else if (objViewIdGCVariableRela.RegionTypeNames == null)
                        {
                            objViewIdGCVariableRela.RegionTypeNames = $"CondField(E,{objInFor.ObjFieldTab().FldName}),";
                            objViewIdGCVariableRela.IsUseInRegion = true;
                            objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            objViewIdGCVariableRela.UpdUser = strOpUser;
                            clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);
                        }
                        else if (objViewIdGCVariableRela.RegionTypeNames.IndexOf("CondField") == -1)
                        {
                            objViewIdGCVariableRela.RegionTypeNames += $"CondField(E,{objInFor.ObjFieldTab().FldName}),";
                            objViewIdGCVariableRela.IsUseInRegion = true;
                            objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            objViewIdGCVariableRela.UpdUser = strOpUser;
                            clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);
                        }
                        else
                        {
                            clsViewIdGCVariableRelaBL.SetFldValue(conViewIdGCVariableRela._CurrTabName, conViewIdGCVariableRela.IsUseInRegion, "1", strWhere);
                        }
                    }
                }
            }

            var arrQryRegionFlds = clsQryRegionFldsBLEx.GetObjExLstEx(strViewId, strPrjId);
            var arrQryRegionFlds_Sel = arrQryRegionFlds.Where(x => x.CtlTypeId == enumCtlType.ViewVariable_38 && x.InUse == true);
            foreach (var objInFor in arrQryRegionFlds_Sel)
            {
                strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.VarId} = '{objInFor.VarId}' ";
                objViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjByKeyLst(objInFor.VarId, strViewId);

                if (objViewIdGCVariableRela == null)
                {
                    var obj = new clsViewIdGCVariableRelaEN();
                    obj.ViewId = strViewId;
                    obj.VarId = objInFor.VarId;
                    obj.RetrievalMethodId = enumRetrievalMethod.Undefined_01;
                    obj.RegionTypeNames = "QueryRegion,";
                    obj.PrjId = strPrjId;
                    obj.IsUseInRegion = true;
                    obj.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    obj.UpdUser = strOpUser;
                    clsViewIdGCVariableRelaBL.AddNewRecordBySql2(obj);
                }
                else if (objViewIdGCVariableRela.RegionTypeNames == null)
                {
                    objViewIdGCVariableRela.RegionTypeNames = "QueryRegion,";
                    objViewIdGCVariableRela.IsUseInRegion = true;
                    objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewIdGCVariableRela.UpdUser = strOpUser;
                    clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);
                }
                else if (objViewIdGCVariableRela.RegionTypeNames.IndexOf("QueryRegion") == -1)
                {
                    objViewIdGCVariableRela.RegionTypeNames += "QueryRegion,";
                    objViewIdGCVariableRela.IsUseInRegion = true;
                    objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewIdGCVariableRela.UpdUser = strOpUser;
                    clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);
                }
                else
                {
                    clsViewIdGCVariableRelaBL.SetFldValue(conViewIdGCVariableRela._CurrTabName, conViewIdGCVariableRela.IsUseInRegion, "1", strWhere);
                }
            }
        
            var arrQryRegionFlds_Ddl = arrQryRegionFlds.Where(x => x.CtlTypeId == enumCtlType.DropDownList_06);

            foreach (var objInFor in arrQryRegionFlds_Ddl)
            {
                if (string.IsNullOrEmpty(objInFor.TabFeatureId4Ddl) == false)
                {
                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInFor.TabFeatureId4Ddl, objInFor.PrjId);

                    var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInFor.PrjId);

                    var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    List<string> arrVarId_Cond = new List<string>();
                    if (arrTabFeatureFlds_Cond.Count > 1)
                    {
                        if (string.IsNullOrEmpty(objInFor.VarIdCond2) == false && objInFor.VarIdCond2!="0") arrVarId_Cond.Add(objInFor.VarIdCond2);
                        if (string.IsNullOrEmpty(objInFor.VarIdCond1) == false && objInFor.VarIdCond1 != "0") arrVarId_Cond.Add(objInFor.VarIdCond1);
                    }
                    else if (arrTabFeatureFlds_Cond.Count == 1)
                    {
                        if (string.IsNullOrEmpty(objInFor.VarIdCond1) == false && objInFor.VarIdCond1 != "0") arrVarId_Cond.Add(objInFor.VarIdCond1);
                    }
                    foreach (var strVarId in arrVarId_Cond)
                    {
                        var strVarId_T = clsViewIdGCVariableRelaBLEx.GetCommonOriginVarId(strViewId, strVarId, strPrjId);
                        if (strVarId_T == "") strVarId_T = strVarId;
                        strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.VarId} = '{strVarId_T}' ";
                        objViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjByKeyLst(strVarId_T, strViewId);

                        if (objViewIdGCVariableRela == null)
                        {
                            var obj = new clsViewIdGCVariableRelaEN();
                            obj.ViewId = strViewId;
                            obj.VarId = strVarId_T;
                            obj.RetrievalMethodId = enumRetrievalMethod.Undefined_01;
                            obj.RegionTypeNames = $"CondField(Q,{objInFor.ObjFieldTab().FldName}),";
                            obj.PrjId = strPrjId;
                            obj.IsUseInRegion = true;
                            obj.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            obj.UpdUser = strOpUser;
                            clsViewIdGCVariableRelaBL.AddNewRecordBySql2(obj);
                        }
                        else if (objViewIdGCVariableRela.RegionTypeNames == null)
                        {
                            objViewIdGCVariableRela.RegionTypeNames = $"CondField(Q,{objInFor.ObjFieldTab().FldName}),";
                            objViewIdGCVariableRela.IsUseInRegion = true;
                            objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            objViewIdGCVariableRela.UpdUser = strOpUser;
                            clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);
                        }
                        else if (objViewIdGCVariableRela.RegionTypeNames.IndexOf("CondField") == -1)
                        {
                            objViewIdGCVariableRela.RegionTypeNames += $"CondField(Q,{objInFor.ObjFieldTab().FldName}),";
                            objViewIdGCVariableRela.IsUseInRegion = true;
                            objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            objViewIdGCVariableRela.UpdUser = strOpUser;
                            clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);
                        }
                        else
                        {
                            clsViewIdGCVariableRelaBL.SetFldValue(conViewIdGCVariableRela._CurrTabName, conViewIdGCVariableRela.IsUseInRegion, "1", strWhere);
                        }
                    }
                }
            }


            clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewId(strViewId, strPrjId);
            if (objAdjustOrderNum != null)
            {
                foreach (var objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                {
                    //var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.VarId} in (select {conGCVariable.VarId} from {conGCVariable._CurrTabName} where {conGCVariable.VarName} = '{strFldName}') ";
                    //var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
                    //if (arrViewIdGCVariableRela.Count > 0) return arrViewIdGCVariableRela[0];
                    //return null;

                    strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.VarId} in (select {conGCVariable.VarId} from {conGCVariable._CurrTabName} where {conGCVariable.VarName} = '{objInFor.FldName}') ";
                    var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
                    //if (arrViewIdGCVariableRela.Count > 0) return arrViewIdGCVariableRela[0];
                    //objViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjByKeyLst(objInFor.VarId, strViewId);
                    if (arrViewIdGCVariableRela.Count > 0) objViewIdGCVariableRela = arrViewIdGCVariableRela[0];
                    if (arrViewIdGCVariableRela.Count == 0)
                    {
                        var strWhere2 = $" {conGCVariable.VarName} = '{objInFor.FldName}' and {conGCVariable.VarId} in (select {conGCVariablePrjIdRela.VarId} from {conGCVariablePrjIdRela._CurrTabName} where {conGCVariablePrjIdRela.PrjId} ='{strPrjId}' ) ";
                        var objVar = clsGCVariableBL.GetFirstObj_S(strWhere2);
                        if (objVar == null)
                        {
                            var strMsg = $"字段名:{objInFor.FldName} 在工程:{strPrjId}中没有相应的变量名，请检查！";
                            throw new Exception(strMsg);
                        }
                        var obj = new clsViewIdGCVariableRelaEN();
                        obj.ViewId = strViewId;
                        obj.VarId = objVar.VarId;
                        obj.RetrievalMethodId = enumRetrievalMethod.Undefined_01;
                        obj.RegionTypeNames = "FeatureRegion,";
                        obj.PrjId = strPrjId;
                        obj.IsUseInRegion = true;
                        obj.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        obj.UpdUser = strOpUser;
                        clsViewIdGCVariableRelaBL.AddNewRecordBySql2(obj);
                    }
                    else
                    {
                        objViewIdGCVariableRela = arrViewIdGCVariableRela[0];
                        if (objViewIdGCVariableRela.RegionTypeNames == null)
                        {
                            objViewIdGCVariableRela.RegionTypeNames = "FeatureRegion,";
                            objViewIdGCVariableRela.IsUseInRegion = true;
                            objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            objViewIdGCVariableRela.UpdUser = strOpUser;
                            clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);
                        }
                        else if (objViewIdGCVariableRela.RegionTypeNames.IndexOf("FeatureRegion") == -1)
                        {
                            objViewIdGCVariableRela.RegionTypeNames += "FeatureRegion,";
                            objViewIdGCVariableRela.IsUseInRegion = true;
                            objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            objViewIdGCVariableRela.UpdUser = strOpUser;
                            clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);
                        }
                        else
                        {
                            clsViewIdGCVariableRelaBL.SetFldValue(conViewIdGCVariableRela._CurrTabName, conViewIdGCVariableRela.IsUseInRegion, "1", strWhere);
                        }
                    }
                }
            }

            GetViewVarFromMainTab(strViewId, strPrjId, strOpUser);
            clsViewInfoBLEx.SetViewUpdDate(strViewId);
            return true;
        }
        /// <summary>
        /// 在界面变量中获取某变量的同源变量
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strVarId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string GetCommonOriginVarId(string strViewId, string strVarId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strVarId) == true || strVarId == "0") return strVarId;
            var objVar_S = clsGCVariableBL.GetObjByVarIdCache(strVarId);
            if (string.IsNullOrEmpty(objVar_S.FldId) == true)
            {
                string strMsg = $"变量:[{objVar_S.VarName}({objVar_S.VarId})]没有相关的字段！";
                throw new Exception(strMsg);
            }
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' ";
            List<clsViewIdGCVariableRelaENEx> arrViewIdGCVariableRelaENEx = clsViewIdGCVariableRelaBLEx.GetObjExLst(strWhere);
            foreach (var objInFor in arrViewIdGCVariableRelaENEx)
            {
                var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                if (string.IsNullOrEmpty(objVar.FldId) == true) continue;
                if (objVar.FldId == objVar_S.FldId) return objVar.VarId;
            }
            return "";
            //var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
            //string strMsg0 = $"在界面:[${objViewInfo.ViewName}({objViewInfo.ViewId})]的变量中，没有变量:[{objVar_S.VarName}({objVar_S.VarId})]的同源变量！";
            //throw new Exception(strMsg0);

        }


        public static bool GetViewVarFromMainTab(string strViewId, string strPrjId, string strOpUser)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' ";

            var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
            if (objViewInfo == null) return false;
            if (string.IsNullOrEmpty(objViewInfo.MainTabId) == true) return true;
            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfo.MainTabId, strPrjId);
            if (objPrjTab == null) return false;
            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == true) return true;
            List<clsViewIdGCVariableRelaENEx> arrViewIdGCVariableRelaENEx = clsViewIdGCVariableRelaBLEx.GetObjExLst(strWhere);
            foreach (var objInFor in arrViewIdGCVariableRelaENEx)
            {
                var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                if (string.IsNullOrEmpty(objVar.FldId) == true) continue;
                if (objVar.FldId.Substring(0, 4) == strPrjId)
                {
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objVar.FldId, strPrjId);
                }
                objInFor.FldId = objVar.FldId;
            }
            List<string> arrFldId = new List<string>();
            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField2TS) == false) arrFldId.Add(objPrjTab.CacheClassifyField2TS);
            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false) arrFldId.Add(objPrjTab.CacheClassifyFieldTS);
            foreach (var strFldId in arrFldId)
            {
                var objViewIdGCVariableRela = arrViewIdGCVariableRelaENEx.Find(x => x.FldId == strFldId);

                if (objViewIdGCVariableRela == null)
                {
                    string strWhere_Var = $"{conGCVariable.FldId}='{strFldId}' and {conGCVariable.VarTypeId}='{enumGCVariableType.CacheClassifyField_0007}'";
                    var objVar_FldId = clsGCVariableBL.GetFirstObj_S(strWhere_Var);
                    if (objVar_FldId == null)
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, strPrjId);
                        string strMsg = $"字段:[{objFieldTab.FldName}]在变量表中没有缓存分类的记录！";
                        throw new Exception(strMsg);
                    }
                    var obj = new clsViewIdGCVariableRelaEN();
                    obj.ViewId = strViewId;
                    obj.VarId = objVar_FldId.VarId;
                    obj.RetrievalMethodId = enumRetrievalMethod.Undefined_01;
                    obj.RegionTypeNames = "CacheField,";
                    obj.PrjId = strPrjId;
                    obj.IsUseInRegion = true;
                    obj.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    obj.UpdUser = strOpUser;
                    clsViewIdGCVariableRelaBL.AddNewRecordBySql2(obj);
                }

                else if (objViewIdGCVariableRela.RegionTypeNames.IndexOf("CacheField") == -1)
                {
                    objViewIdGCVariableRela.RegionTypeNames += "CacheField,";
                    objViewIdGCVariableRela.IsUseInRegion = true;
                    objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewIdGCVariableRela.UpdUser = strOpUser;
                    clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);
                }
                else
                {
                    objViewIdGCVariableRela.RegionTypeNames = "CacheField,";
                    objViewIdGCVariableRela.IsUseInRegion = true;
                    objViewIdGCVariableRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewIdGCVariableRela.UpdUser = strOpUser;
                    clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRela);
                }
            }
            
            return true;
        }
        public static List<clsViewIdGCVariableRelaEN> GetObjLstByViewId(string strViewId)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' ";

            var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
            return arrViewIdGCVariableRela;
        }
        public static string GetAllViewVarNames(string strViewId)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}'  ";
            var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
            List<string> arrVarNames = new List<string>();
            foreach (var objInFor in arrViewIdGCVariableRela)
            {
                var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                arrVarNames.Add(objGCVariable.GetVarName4View());
            }
            string result = string.Join(",", arrVarNames);
            return result;
        }
        public static List<clsViewIdGCVariableRelaEN> GetEditRegionViewVarLst(string strViewId)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.RegionTypeNames} like '%EditRegion%' ";
            var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
            return arrViewIdGCVariableRela;
        }
        public static List<string> GetEditRegionViewVarNameLst(string strViewId)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.RegionTypeNames} like '%EditRegion%' ";
            var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
            List<string> arrVarNames = new List<string>();
            foreach (var objInFor in arrViewIdGCVariableRela)
            {
                var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                arrVarNames.Add(objGCVariable.GetVarName4View());
            }
            return arrVarNames;
        }
        public static string GetEditRegionViewVarNames(string strViewId)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.RegionTypeNames} like '%EditRegion%' ";
            var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
            List<string> arrVarNames = new List<string>();
            foreach (var objInFor in arrViewIdGCVariableRela)
            {
                var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                arrVarNames.Add(objGCVariable.GetVarName4View());
            }
            string result = string.Join(",", arrVarNames);
            return result;
        }
        public static List<clsViewIdGCVariableRelaEN> GetQryRegionViewVarLst(string strViewId)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.RegionTypeNames} like '%QueryRegion%' ";
            var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
            return arrViewIdGCVariableRela;
        }
        public static int GetCacheViewVarCount(string strViewId)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.RegionTypeNames} like '%CacheField%' ";
            var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
            return arrViewIdGCVariableRela.Count;
        }
        public static clsViewIdGCVariableRelaEN GetCacheViewVar(string strViewId, string strFldId)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.RegionTypeNames} like '%CacheField%' ";
            var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
            foreach (var objInFor in arrViewIdGCVariableRela)
            {
                var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                if (objVar.FldId == strFldId) return objInFor;
            }
            return null;
        }


        public static string GetGC_InitVarValue(string strViewId, IImportClass objImportClass, string strBaseUrl)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}'  ";
            var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
            StringBuilder sbCodeText = new StringBuilder();
            clsViewIdGCVariableRelaBLEx_Static.bolIsDefRoute = false;
            foreach (var objInFor in arrViewIdGCVariableRela)
            {
                sbCodeText.Append(objInFor.GetGC_InitVarValue(objImportClass, strBaseUrl));
            }
            return sbCodeText.ToString();
        }
        public static bool IsNeedUseRoute(string strViewId)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' ";

            var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
            if (arrViewIdGCVariableRela.Count(x => x.RetrievalMethodId == enumRetrievalMethod.RouteQuery_03 ||
            x.RetrievalMethodId == enumRetrievalMethod.RouteParameters_02) > 0) return true;
            return false;
        }

        public static string GetViewVarName(bool bolIsHasCacheClassfyFld, string strViewId, string strFldId, string strPrjId)
        {
            //clsGCVariableEN objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objViewIdGCVariableRela.VarId);
            //return objGCVariable.GetVarName4View();

            if (bolIsHasCacheClassfyFld == false) return "";
            if (clsViewIdGCVariableRelaBLEx.GetCacheViewVarCount(strViewId) == 0) return "";
            var objViewIdGCVariableRela = clsViewIdGCVariableRelaBLEx.GetCacheViewVar(strViewId, strFldId);
            if (objViewIdGCVariableRela == null)
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, strPrjId);
                string strMsg = $"在界面变量中没有缓存字段:[{objFieldTab.FldName}({objFieldTab.FldId})]的变量！";
                throw new Exception(strMsg);
            }

            var strViewVarName = objViewIdGCVariableRela.GetVarName4View();
            return strViewVarName;
        }
        public static string GetViewVarNameByFldName(string strViewId, string strFldName)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.VarId} in (select {conGCVariable.VarId} from {conGCVariable._CurrTabName} where {conGCVariable.VarName} = '{strFldName}') ";
            var objViewIdGCVariableRela = GetViewVarObjByFldName(strViewId, strFldName);
            if (objViewIdGCVariableRela == null) return "";
            //var objVar = clsGCVariableBL.GetObjByVarIdCache(objViewIdGCVariableRela.VarId);
            string strVarName4View = objViewIdGCVariableRela.GetVarName4View();

            return strVarName4View;
        }
        public static bool CheckViewVarName(string strViewVarName , string strFldName, string strViewName)
        {
            if (strViewVarName.Length > 0) return true;
            string strMsg = $"在界面：[{strViewName}]中，字段名:[{strFldName}] 没有相应的界面变量，请检查！";
            throw new Exception (strMsg);
        }
        public static clsViewIdGCVariableRelaEN GetViewVarObjByFldName(string strViewId, string strFldName)
        {
            var strWhere = $"{conViewIdGCVariableRela.ViewId} = '{strViewId}' and {conViewIdGCVariableRela.VarId} in (select {conGCVariable.VarId} from {conGCVariable._CurrTabName} where {conGCVariable.VarName} = '{strFldName}') ";
            var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjLst(strWhere);
            if (arrViewIdGCVariableRela.Count > 0) return arrViewIdGCVariableRela[0];
            return null;
        }

    }
}