/*
 * 功能:公共数据实体底层
 * 版本:2019-07-24-01
 * 作者:潘以锋
 * */
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsGeneralTab = void 0;
    class clsGeneralTab {
        //以下是属性变量
        ///该函数不存在:
        constructor() {
            this.whereCond = "";
            //以下是出错信息
            //public mstrErrMsg :Array<String> = [ "0:正常", "1:院系号为空", "2:专业编号为空", "3:已有相同的编号"];
            //以下是出错信息号码
            //public mintErrNo: Number = 0; //0:正常,1:房间号为空,2:学号为空
            //public mstrDispErrMsg: string; //对外显示的错误信息
            //public mstrModuleName: string;
            //		public static String mstrClassName;
            //public mblnDisposed : boolean = false; //是否已经释放对象(用于析构函数)
            //public EXCEPTION_MSG = " there was an error in the method. please see the Application Log for details.";
            /// <summary>
            /// 常量:"intTag"
            /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            this.con_IntTag = "intTag"; //整型Tag
            /// <summary>
            /// 常量:"strTag"
            /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            this.con_StrTag = "strTag"; //字符型标签
            /// <summary>
            /// 常量:"IsCheckProperty"
            /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
            /// </summary>
            this.con_IsCheckProperty = "isCheckProperty"; //是否检查属性
            this.intTag = 0; //整型Tag
            this.strTag = ""; //字符型标签
            this.isCheckProperty = false; //是否检查属性
            this.hmProperty = {};
            this.dicFldComparisonOp = {};
            this.sf_UpdFldSetStr = ""; //修改字符标志串
            this.sf_FldComparisonOp = ""; //修改字符标志串
            this.whereCond = "";
        }
        GetFldValue(strFldName) {
            return "";
        }
        SetFldValue(strFldName, strFldValue) {
        }
        /// <summary>
        /// 整型Tag(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        SetIntTag(value) {
            this.intTag = value;
            //记录修改过的字段
            this.hmProperty["intTag"] = true;
        }
        SetStrTag(value) {
            if (value === "") {
                //this.mintErrNo = 1;
                this.strTag = value;
            }
            else {
                this.strTag = value;
            }
            //记录修改过的字段
            this.hmProperty["strTag"] = true;
        }
        //public get sf_UpdFldSetStr(): string {
        //    return this.mstrsf_UpdFldSetStr;
        //}
        //public set sf_UpdFldSetStr(value: string) {
        //    this.mstrsf_UpdFldSetStr = value;
        //}
        //public get sf_FldComparisonOp(): string {
        //    return this.mstrsf_FldComparisonOp;
        //}
        //public set sf_FldComparisonOp(value: string) {
        //    this.mstrsf_FldComparisonOp = value;
        //}
        //public get hmProperty()// : String
        //{
        //    return this.hmProperty;
        //}
        //public sethmProperty(value: string, IsUpdated:boolean) {
        //    this.hmProperty[value] = IsUpdated;
        //}
        SetIsCheckProperty(value) {
            this.isCheckProperty = value;
            //记录修改过的字段
            this.hmProperty["isCheckProperty"] = true;
        }
        /// <summary>
        /// 设置类的有些属性初始值
        /// </summary>
        //public SetInit () {
        //    this.CurrTabName = "Users"; //当前表名，与该类相关的表名
        //    this.keyFldName = "userId"; //当前表的关键字字段的名称
        //    this.hmProperty = {};//new { [key: string]: string }();
        //    //mstrModuleName = this.GetType().toString();
        //}
        get updFldProperty() {
            return this.hmProperty;
        }
        /*
         * 获取修改的字段名串
         */
        get updFldString() {
            let sbMsg = "";
            //const iLen = this.hmProperty.length();
            for (const key in this.hmProperty) {
                const value = this.hmProperty[key];
                sbMsg = sbMsg + key + "|";
            }
            return sbMsg;
        }
    }
    exports.clsGeneralTab = clsGeneralTab;
    clsGeneralTab._CurrTabName = ""; //当前表名，与该类相关的表名
    clsGeneralTab._KeyFldName = ""; //当前表的关键字字段的名称
});
