(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./clsCommonFunc4Web2.js", "./clsCboObject2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsFldComparisonObj = void 0;
    const clsCommonFunc4Web2_js_1 = require("./clsCommonFunc4Web2.js");
    const clsCboObject2_js_1 = require("./clsCboObject2.js");
    //declare function GetObjLstFromParent(): Array<clsFldComparisonObj>;
    /// <summary>
    /// 下拉框对象类
    /// </summary>
    class clsFldComparisonObj {
        /*
        /// <param name="strFldValue"></param>
        /// <param name="strFldName"></param>
        */
        constructor(strFldName, strComparisonOperator, strFldValue) {
            /// <summary>
            /// 字段值
            /// </summary>
            this.FldValue = "";
            /// <summary>
            /// 字段名
            /// </summary>
            this.FldName = "";
            /// <summary>
            /// 比较操作符
            /// </summary>
            this.ComparisonOperator = "";
            this.FldValue = strFldValue;
            this.FldName = strFldName;
            this.ComparisonOperator = strComparisonOperator;
        }
        /// <summary>
        /// 常量:"FldName"
        /// </summary>
        static get con_FldName() { return "FldName"; }
        ; //文本
        /// <summary>
        /// 常量:"ComparisonOperator"
        /// </summary>
        static get con_ComparisonOperator() { return "ComparisonOperator"; } //值
        /// <summary>
        /// 常量:"FldValue"
        /// </summary>
        static get con_FldValue() { return "FldValue"; } //值
        static GetLocalObjLst() {
            var strFldComparisonObjLst = $("#hidFldComparisonObjLst").val();
            if (strFldComparisonObjLst == null || strFldComparisonObjLst == "") {
                return new Array();
            }
            var arrFldComparisonObj = JSON.parse(strFldComparisonObjLst);
            console.log(`当前记录数:${arrFldComparisonObj.length}.(In clsFldComparisonObj.GetLocalObjLst)`);
            return arrFldComparisonObj;
        }
        ;
        static SetLocalObjLst() {
            var strFldComparisonObjLst = JSON.stringify(clsFldComparisonObj.arrFldComparisonObj);
            $("#hidFldComparisonObjLst").val(strFldComparisonObjLst);
            console.log(`当前记录数:${clsFldComparisonObj.arrFldComparisonObj.length}.(In clsFldComparisonObj.SetLocalObjLst)`);
        }
        ;
        static BindTab() {
            //if (clsFldComparisonObj.arrFldComparisonObj.length == 0) {
            clsFldComparisonObj.arrFldComparisonObj = clsFldComparisonObj.GetLocalObjLst();
            //}
            clsFldComparisonObj.BindTab_FldComparisonObj("divList4FldComparisonObj", clsFldComparisonObj.arrFldComparisonObj);
        }
        /// <summary>
        /// 显示FldComparisonObj对象的所有属性值
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_UT_BindTab)
        /// </summary>
        /// <param name = "divContainer">显示容器</param>
        /// <param name = "arrFldComparisonObjObjLst">需要绑定的对象列表</param>
        /// <returns></returns>
        static BindTab_FldComparisonObj(divContainer, arrFldComparisonObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrFldName = new Array();
            var sstrColHeader = new Array();
            sstrFldName.push(clsFldComparisonObj.con_FldName);
            sstrColHeader.push("字段名");
            sstrFldName.push(clsFldComparisonObj.con_ComparisonOperator);
            sstrColHeader.push("操作符");
            sstrFldName.push(clsFldComparisonObj.con_FldValue);
            sstrColHeader.push("字段值");
            var arrDataColumn = [
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "",
                    Text: "",
                    TdClass: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: clsFldComparisonObj.con_FldName,
                    ColHeader: "字段名",
                    SortBy: "",
                    Text: "",
                    TdClass: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: clsFldComparisonObj.con_ComparisonOperator,
                    ColHeader: "操作符",
                    Text: "",
                    SortBy: "",
                    TdClass: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: clsFldComparisonObj.con_FldValue,
                    ColHeader: "操作符",
                    Text: "",
                    SortBy: "",
                    TdClass: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "修改",
                    Text: "修改",
                    SortBy: "",
                    TdClass: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除",
                    SortBy: "",
                    TdClass: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrFldComparisonObjLst, arrDataColumn, clsFldComparisonObj.con_FldName);
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        static BindDdl_FldName(strDdlName, arrFldNameLst) {
            var objDdl = document.getElementById(strDdlName);
            if (objDdl == null) {
                var strMsg = `下拉框：${strDdlName} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            //为数据源于表的下拉框设置内容
            console.log("开始：BindDdl_FldName");
            var arrCboObject = arrFldNameLst.map(x => new clsCboObject2_js_1.clsCboObject(x, x));
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrCboObject, clsCboObject2_js_1.clsCboObject.con_Text, clsCboObject2_js_1.clsCboObject.con_Value, "字段名");
        }
        static BindDdl_ComparisonOperator(strDdlName) {
            var objDdl = document.getElementById(strDdlName);
            if (objDdl == null) {
                var strMsg = `下拉框：${strDdlName} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            //为数据源于表的下拉框设置内容
            console.log("开始：BindDdl_FldName");
            var arrComparisonOperatorLst = new Array("=", "!=", "like", ">=", ">", "<=", "<");
            var arrCboObject = arrComparisonOperatorLst.map(x => new clsCboObject2_js_1.clsCboObject(x, x));
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrCboObject, clsCboObject2_js_1.clsCboObject.con_Text, clsCboObject2_js_1.clsCboObject.con_Value, "字段名");
        }
        static AddNewRecordSave() {
            //this.DivName = "divAddNewRecordSave";
            var objFldComparisonObj = new clsFldComparisonObj(clsFldComparisonObj.FldName4Ctl, clsFldComparisonObj.ComparisonOperator4Ctl, clsFldComparisonObj.FldValue4Ctl);
            try {
                const responseText = clsFldComparisonObj.IsExist(objFldComparisonObj.FldName);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，字段名：${objFldComparisonObj.FldName}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                clsFldComparisonObj.arrFldComparisonObj.push(objFldComparisonObj);
                clsFldComparisonObj.SetLocalObjLst();
                clsFldComparisonObj.BindTab();
                return true; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /// <summary>
        /// 根据关键字判断是否存在记录, 从本地缓存中判断.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
        /// </summary>
        /// <param name = "strFldName">所给的关键字</param>
        /// <returns>对象</returns>
        static IsExist(strFldName) {
            try {
                var arrFldComparisonObj_Sel = clsFldComparisonObj.arrFldComparisonObj.filter(x => x.FldName == strFldName);
                var objFldComparisonObj;
                if (arrFldComparisonObj_Sel.length > 0) {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (e) {
                var strMsg = `根据关键字:[${strFldName}]判断是否存在不成功!`;
                alert(strMsg);
            }
            return false;
        }
        ;
        /*
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
    */
        static btnDelRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var index = clsFldComparisonObj.arrFldComparisonObj.findIndex(x => x.FldName == strKeyId);
                if (index > -1) {
                    clsFldComparisonObj.arrFldComparisonObj.splice(index, 1);
                    clsFldComparisonObj.SetLocalObjLst();
                }
                const responseText2 = this.BindTab();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
    */
        static btnUpdateRecordInTab_Click(strKeyId) {
            //this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            clsFldComparisonObj.UpdateRecord(strKeyId);
        }
        /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
    */
        static UpdateRecord(strFldName) {
            clsFldComparisonObj.btnOKUpd = "确认修改";
            clsFldComparisonObj.btnCancel = "取消修改";
            clsFldComparisonObj.KeyId = strFldName;
            try {
                var objFldComparisonObj = clsFldComparisonObj.GetObjByFldName_Cache(strFldName);
                clsFldComparisonObj.GetDataFromFldComparisonObjClass(objFldComparisonObj);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    
    */
        static async btnOKUpd_Click() {
            var returnBool;
            var strCommandText = clsFldComparisonObj.btnOKUpd;
            try {
                switch (strCommandText) {
                    case "添加":
                        //const responseText1 = clsFldComparisonObj.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        //FldComparisonObj.clsFldComparisonObj.AddNewRecordSave();
                        returnBool = clsFldComparisonObj.AddNewRecordSave();
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = clsFldComparisonObj.UpdateRecordSave();
                        if (returnBool == true) {
                            HideDialog();
                            //clsFldComparisonObj.BindGv_vUsers();
                        }
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存中获取.
        /// </summary>
        /// <param name = "strFldName">所给的关键字</param>
        /// <returns>对象</returns>
        static GetObjByFldName_Cache(strFldName) {
            var arrFldComparisonObjObjLst_Cache = clsFldComparisonObj.arrFldComparisonObj;
            var obj = new clsFldComparisonObj("", "", "");
            try {
                var arrFldComparisonObj_Sel = arrFldComparisonObjObjLst_Cache.filter(x => x.FldName == strFldName);
                var objFldComparisonObj;
                if (arrFldComparisonObj_Sel.length > 0) {
                    objFldComparisonObj = arrFldComparisonObj_Sel[0];
                    return objFldComparisonObj;
                }
                else {
                    return obj;
                }
            }
            catch (e) {
                var strMsg = `根据关键字:[${strFldName}]获取相应的对象不成功!`;
                alert(strMsg);
            }
            return obj;
        }
        ;
        /* 函数功能:把类对象的属性内容显示到界面上
     <param name = "pobjFldComparisonObj">表实体类对象</param>
    */
        static GetDataFromFldComparisonObjClass(pobjFldComparisonObj) {
            clsFldComparisonObj.FldName4Ctl = pobjFldComparisonObj.FldName; // 学院
            clsFldComparisonObj.ComparisonOperator4Ctl = pobjFldComparisonObj.ComparisonOperator; // 学院名称
            clsFldComparisonObj.FldValue4Ctl = pobjFldComparisonObj.FldValue; // 排序
        }
        /* 修改记录
            */
        static UpdateRecordSave() {
            //this.DivName = "divUpdateRecordSave";
            var objFldComparisonObj = new clsFldComparisonObj("", "", "");
            objFldComparisonObj.FldName = clsFldComparisonObj.KeyId;
            clsFldComparisonObj.PutDataToFldComparisonObjClass(objFldComparisonObj);
            if (objFldComparisonObj.FldName == "" || objFldComparisonObj.FldName == undefined) {
                throw "关键字不能为空!";
            }
            var objFldComparisonObj_Lib = this.GetObjByFldName_Cache(clsFldComparisonObj.KeyId);
            if (objFldComparisonObj_Lib.FldName == "") {
                var strInfo = `字段名:[${clsFldComparisonObj.KeyId}]在缓存中不存在!`;
                //显示信息框
                alert(strInfo);
                return false;
            }
            objFldComparisonObj_Lib.ComparisonOperator = objFldComparisonObj.ComparisonOperator;
            objFldComparisonObj_Lib.FldValue = objFldComparisonObj.FldValue;
            clsFldComparisonObj.SetLocalObjLst();
            var strInfo = `修改记录成功!`;
            //显示信息框
            alert(strInfo);
            this.BindTab();
            return true;
        }
        /* 函数功能:把界面上的属性数据传到类对象中
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
      <param name = "pobjFldComparisonObj">数据传输的目的类对象</param>
    */
        static PutDataToFldComparisonObjClass(pobjFldComparisonObj) {
            pobjFldComparisonObj.FldName = clsFldComparisonObj.FldName4Ctl; // 用户ID
            pobjFldComparisonObj.FldValue = clsFldComparisonObj.FldValue4Ctl; // 用户名
            pobjFldComparisonObj.ComparisonOperator = clsFldComparisonObj.ComparisonOperator4Ctl; // 用户状态号
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        static SetKeyReadOnly(bolReadonly) {
            $('#ddlFldName').prop['ReadOnly'] = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// </summary>	
        static Clear() {
            clsFldComparisonObj.FldName4Ctl = "";
            clsFldComparisonObj.FldValue4Ctl = "";
            clsFldComparisonObj.ComparisonOperator4Ctl = "";
        }
        /* 为插入记录做准备工作
    */
        static AddNewRecord() {
            clsFldComparisonObj.SetKeyReadOnly(false);
            clsFldComparisonObj.btnOKUpd = "确认添加";
            clsFldComparisonObj.btnCancel = "取消添加";
            clsFldComparisonObj.Clear();
            //wucUsersB1.userId = Users_GetMaxStrId_S();
        }
        /* 添加新记录
    */
        static btnAddNewRecord_Click() {
            clsFldComparisonObj.OpType = "Add";
            try {
                console.log("clsFldComparisonObj.arrFldNameLst:(In clsFldComparisonObj)");
                console.log(clsFldComparisonObj.arrFldNameLst);
                clsFldComparisonObj.BindDdl_ComparisonOperator("ddlComparisonOperator");
                clsFldComparisonObj.BindDdl_FldName("ddlFldName", clsFldComparisonObj.arrFldNameLst);
                const responseText = clsFldComparisonObj.AddNewRecord();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
       * 用户状态号
      */
        static set FldName4Ctl(value) {
            if (value == "")
                return;
            $("#ddlFldName").val(value);
        }
        /*
        * 用户状态号
       */
        static get FldName4Ctl() {
            return $("#ddlFldName").val();
        }
        /*
      * 用户名
     */
        static get FldValue4Ctl() {
            return $("#txtFldValue").val();
        }
        /*
      * 用户名
     */
        static set FldValue4Ctl(value) {
            $("#txtFldValue").val(value);
        }
        /*
    * 用户状态号
    */
        static set ComparisonOperator4Ctl(value) {
            if (value == "")
                return;
            $("#ddlComparisonOperator").val(value);
        }
        /*
        * 用户状态号
       */
        static get ComparisonOperator4Ctl() {
            return $("#ddlComparisonOperator").val();
        }
        /*
    * 设置取消按钮的标题
    */
        static set btnCancel(value) {
            $("#btnCancel").html(value);
        }
        /*
        * 设置确定按钮的标题
       */
        static set btnOKUpd(value) {
            $("#btnOKUpd_FC").html(value);
        }
        /*
        * 获取按钮的标题
       */
        static get btnOKUpd() {
            return $("#btnOKUpd_FC").html();
        }
        /*
     * 设置关键字的值
    */
        static set KeyId(value) {
            $("#hidKeyId_FC").val(value);
        }
        /*
        * 设置关键字的值
       */
        static get KeyId() {
            return $("#hidKeyId_FC").val();
        }
        /*
    * 设置操作类型：Add||Update||Detail
    */
        static set OpType(value) {
            $("#hidOpType_FC").val(value);
        }
    }
    exports.clsFldComparisonObj = clsFldComparisonObj;
    clsFldComparisonObj.arrFldComparisonObj = new Array();
});
