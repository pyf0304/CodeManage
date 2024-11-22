(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./clsCboObject.js", "./clsCommFunc4Ctrl.js", "./clsCommFunc4Web.js", "./clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsFldComparisonObj = void 0;
    /*import $ from "jquery";*/
    const clsCboObject_js_1 = require("./clsCboObject.js");
    const clsCommFunc4Ctrl_js_1 = require("./clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("./clsCommFunc4Web.js");
    const clsString_js_1 = require("./clsString.js");
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
            this.fldName = "";
            /// <summary>
            /// 比较操作符
            /// </summary>
            this.ComparisonOperator = "";
            this.FldValue = strFldValue;
            this.fldName = strFldName;
            this.ComparisonOperator = strComparisonOperator;
        }
        /// <summary>
        /// 常量:"fldName"
        /// </summary>
        static get con_FldName() { return "fldName"; }
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
            const strFldComparisonObjLst = $("#hidFldComparisonObjLst").val();
            if (strFldComparisonObjLst == null || strFldComparisonObjLst == "") {
                return new Array();
            }
            const arrFldComparisonObj = JSON.parse(strFldComparisonObjLst.toString());
            console.log(`当前记录数:${arrFldComparisonObj.length}.(In clsFldComparisonObj.GetLocalObjLst)`);
            return arrFldComparisonObj;
        }
        ;
        static SetLocalObjLst() {
            const strFldComparisonObjLst = JSON.stringify(clsFldComparisonObj.arrFldComparisonObj);
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
            const o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            const sstrFldName = new Array();
            const sstrColHeader = new Array();
            sstrFldName.push(clsFldComparisonObj.con_FldName);
            sstrColHeader.push("字段名");
            sstrFldName.push(clsFldComparisonObj.con_ComparisonOperator);
            sstrColHeader.push("操作符");
            sstrFldName.push(clsFldComparisonObj.con_FldValue);
            sstrColHeader.push("字段值");
            const arrDataColumn = [
                {
                    fldName: "",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "",
                    text: "", sortBy: "",
                    tdClass: "text-left",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: clsFldComparisonObj.con_FldName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "字段名",
                    text: "", sortBy: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: clsFldComparisonObj.con_ComparisonOperator,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "操作符",
                    text: "", sortBy: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: clsFldComparisonObj.con_FldValue,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "操作符",
                    text: "", sortBy: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    sortBy: "",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改",
                    text: "修改",
                    tdClass: "text-left",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        const btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    fldName: "",
                    sortBy: "",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "删除",
                    text: "删除",
                    tdClass: "text-left",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        const btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            //clsCommFunc4Web.BindTab(o, arrFldComparisonObjLst, arrDataColumn, clsFldComparisonObj.con_FldName);
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        static BindDdl_FldName(strDdlName, arrFldNameLst) {
            const objDdl = document.getElementById(strDdlName);
            if (objDdl == null) {
                const strMsg = `下拉框:${strDdlName} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            //为数据源于表的下拉框设置内容
            console.log("开始:BindDdl_FldName");
            const arrCboObject = arrFldNameLst.map(x => new clsCboObject_js_1.clsCboObject(x, x));
            (0, clsCommFunc4Web_js_1.BindDdl_CboObject)(strDdlName, arrCboObject, clsCboObject_js_1.clsCboObject.con_Text, clsCboObject_js_1.clsCboObject.con_Value, "字段名");
        }
        static BindDdl_ComparisonOperator(strDdlName) {
            const objDdl = document.getElementById(strDdlName);
            if (objDdl == null) {
                const strMsg = `下拉框:${strDdlName} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            //为数据源于表的下拉框设置内容
            console.log("开始:BindDdl_FldName");
            const arrComparisonOperatorLst = new Array("=", "!=", "like", ">=", ">", "<=", "<");
            const arrCboObject = arrComparisonOperatorLst.map(x => new clsCboObject_js_1.clsCboObject(x, x));
            (0, clsCommFunc4Web_js_1.BindDdl_CboObject)(strDdlName, arrCboObject, clsCboObject_js_1.clsCboObject.con_Text, clsCboObject_js_1.clsCboObject.con_Value, "字段名");
        }
        static AddNewRecordSave() {
            //this.DivName = "divAddNewRecordSave";
            const objFldComparisonObj = new clsFldComparisonObj(clsFldComparisonObj.FldName4Ctl, clsFldComparisonObj.ComparisonOperator4Ctl, clsFldComparisonObj.FldValue4Ctl);
            try {
                const responseText = clsFldComparisonObj.IsExist(objFldComparisonObj.fldName);
                const bolIsExist = responseText;
                if (bolIsExist == true) {
                    const strMsg = `添加记录时，字段名:${objFldComparisonObj.fldName}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                clsFldComparisonObj.arrFldComparisonObj.push(objFldComparisonObj);
                clsFldComparisonObj.SetLocalObjLst();
                clsFldComparisonObj.BindTab();
                return true; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                const strMsg = `添加记录不成功,$${e}.`;
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
                const arrFldComparisonObj_Sel = clsFldComparisonObj.arrFldComparisonObj.filter(x => x.fldName == strFldName);
                // const objFldComparisonObj: clsFldComparisonObj;
                if (arrFldComparisonObj_Sel.length > 0) {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (e) {
                const strMsg = `根据关键字:[${strFldName}]判断是否存在不成功!`;
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
                const index = clsFldComparisonObj.arrFldComparisonObj.findIndex(x => x.fldName == strKeyId);
                if (index > -1) {
                    clsFldComparisonObj.arrFldComparisonObj.splice(index, 1);
                    clsFldComparisonObj.SetLocalObjLst();
                }
                const responseText2 = this.BindTab();
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                const strMsg = `删除记录不成功. $${e}.`;
                alert(strMsg);
            }
        }
        /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
    */
        static btnUpdateRecordInTab_Click(strKeyId) {
            //this.opType = "Update";
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
            clsFldComparisonObj.keyId = strFldName;
            try {
                const objFldComparisonObj = clsFldComparisonObj.GetObjByFldName_Cache(strFldName);
                clsFldComparisonObj.GetDataFromFldComparisonObjClass(objFldComparisonObj);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                const strMsg = `根据关键字获取相应的记录的对象不成功,$${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    
    */
        static async btnOKUpd_Click() {
            let returnBool;
            const strCommandText = clsFldComparisonObj.btnOKUpd;
            let strMsg = "";
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
                        strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                const strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存中获取.
        /// </summary>
        /// <param name = "strFldName">所给的关键字</param>
        /// <returns>对象</returns>
        static GetObjByFldName_Cache(strFldName) {
            const arrFldComparisonObjObjLst_Cache = clsFldComparisonObj.arrFldComparisonObj;
            const obj = new clsFldComparisonObj("", "", "");
            try {
                const arrFldComparisonObj_Sel = arrFldComparisonObjObjLst_Cache.filter(x => x.fldName == strFldName);
                let objFldComparisonObj;
                if (arrFldComparisonObj_Sel.length > 0) {
                    objFldComparisonObj = arrFldComparisonObj_Sel[0];
                    return objFldComparisonObj;
                }
                else {
                    return obj;
                }
            }
            catch (e) {
                const strMsg = `根据关键字:[${strFldName}]获取相应的对象不成功!`;
                alert(strMsg);
            }
            return obj;
        }
        ;
        /* 函数功能:把类对象的属性内容显示到界面上
     <param name = "pobjFldComparisonObj">表实体类对象</param>
    */
        static GetDataFromFldComparisonObjClass(pobjFldComparisonObj) {
            clsFldComparisonObj.FldName4Ctl = pobjFldComparisonObj.fldName; // 学院
            clsFldComparisonObj.ComparisonOperator4Ctl = pobjFldComparisonObj.ComparisonOperator; // 学院名称
            clsFldComparisonObj.FldValue4Ctl = pobjFldComparisonObj.FldValue; // 排序
        }
        /* 修改记录
            */
        static UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            //
            const objFldComparisonObj = new clsFldComparisonObj("", "", "");
            objFldComparisonObj.fldName = clsFldComparisonObj.keyId;
            clsFldComparisonObj.PutDataToFldComparisonObjClass(objFldComparisonObj);
            if (objFldComparisonObj.fldName == "" || objFldComparisonObj.fldName == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            const objFldComparisonObj_Lib = this.GetObjByFldName_Cache(clsFldComparisonObj.keyId);
            if (objFldComparisonObj_Lib.fldName == "") {
                const strInfo = `字段名:[${clsFldComparisonObj.keyId}]在缓存中不存在!`;
                //显示信息框
                alert(strInfo);
                return false;
            }
            objFldComparisonObj_Lib.ComparisonOperator = objFldComparisonObj.ComparisonOperator;
            objFldComparisonObj_Lib.FldValue = objFldComparisonObj.FldValue;
            clsFldComparisonObj.SetLocalObjLst();
            const strInfo = `修改记录成功!`;
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
            pobjFldComparisonObj.fldName = clsFldComparisonObj.FldName4Ctl; // 用户ID
            pobjFldComparisonObj.FldValue = clsFldComparisonObj.FldValue4Ctl; // 用户名
            pobjFldComparisonObj.ComparisonOperator = clsFldComparisonObj.ComparisonOperator4Ctl; // 用户状态号
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        static SetKeyReadOnly(bolReadonly) {
            $('#ddlFldName').prop('ReadOnly', bolReadonly);
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
            //wucUsersB1.userId = clsUsersDnPathFuncMapRela_GetMaxStrId_S();
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
                console.log('catch(e)=');
                console.error(e);
                const strMsg = `添加新记录初始化不成功,${e}.`;
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
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(clsFldComparisonObj.divName4Query, "ddlFldName");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /*
      * 用户名
     */
        static get FldValue4Ctl() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(clsFldComparisonObj.divName4Query, "txtFldValue");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
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
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(clsFldComparisonObj.divName4Query, "ddlComparisonOperator");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
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
        static set keyId(value) {
            $("#hidKeyId_FC").val(value);
        }
        /*
        * 设置关键字的值
       */
        static get keyId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(clsFldComparisonObj.divName4Query, "hidKeyId_FC");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /*
    * 设置操作类型:Add||Update||Detail
    */
        static set OpType(value) {
            $("#hidOpType_FC").val(value);
        }
    }
    exports.clsFldComparisonObj = clsFldComparisonObj;
    clsFldComparisonObj.divName4Query = "divQuery";
    clsFldComparisonObj.arrFldComparisonObj = new Array();
});
