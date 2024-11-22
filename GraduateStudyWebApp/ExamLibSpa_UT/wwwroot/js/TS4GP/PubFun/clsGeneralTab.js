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
    var clsGeneralTab = /** @class */ (function () {
        //以下是属性变量
        ///该函数不存在:
        function clsGeneralTab() {
            this._CurrTabName = ""; //当前表名，与该类相关的表名
            this._KeyFldName = ""; //当前表的关键字字段的名称
            this.mintIntTag = 0; //整型Tag
            this.mstrStrTag = ""; //字符型标签
            this.mbolIsCheckProperty = false; //是否检查属性
            this.hmProperty = {};
            this.mstrsf_UpdFldSetStr = ""; //修改字符标志串
        }
        Object.defineProperty(clsGeneralTab.prototype, "IntTag", {
            /// <summary>
            /// 整型Tag(说明:;字段类型:int;字段长度:4;是否可空:False)
            /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
            /// </summary>
            get: function () {
                return this.mintIntTag;
            },
            set: function (value) {
                this.mintIntTag = value;
                //记录修改过的字段
                this.hmProperty["IntTag"] = true;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsGeneralTab.prototype, "StrTag", {
            /// <summary>
            /// 字符型标签(说明:;字段类型:string;字段长度:1000;是否可空:False)
            /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
            /// </summary>
            get: function () {
                return this.mstrStrTag;
            },
            set: function (value) {
                if (value === "") {
                    //this.mintErrNo = 1;
                    this.mstrStrTag = value;
                }
                else {
                    this.mstrStrTag = value;
                }
                //记录修改过的字段
                this.hmProperty["StrTag"] = true;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsGeneralTab.prototype, "sf_UpdFldSetStr", {
            get: function () {
                return this.mstrsf_UpdFldSetStr;
            },
            set: function (value) {
                this.mstrsf_UpdFldSetStr = value;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsGeneralTab.prototype, "_IsCheckProperty", {
            //public get hmProperty()// : String
            //{
            //    return this.hmProperty;
            //}
            //public sethmProperty(value: string, IsUpdated:boolean) {
            //    this.hmProperty[value] = IsUpdated;
            //}
            /// <summary>
            /// 是否检查属性(说明:;字段类型:bool;字段长度:1;是否可空:False)
            /// (ExamLibWeb.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
            /// </summary>
            get: function () {
                return this.mbolIsCheckProperty;
            },
            set: function (value) {
                this.mbolIsCheckProperty = value;
                //记录修改过的字段
                this.hmProperty["IsCheckProperty"] = true;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsGeneralTab.prototype, "UpdFldProperty", {
            /// <summary>
            /// 设置类的有些属性初始值
            /// </summary>
            //public SetInit () {
            //    this.CurrTabName = "Users"; //当前表名，与该类相关的表名
            //    this.KeyFldName = "UserId"; //当前表的关键字字段的名称
            //    this.hmProperty = {};//new { [key: string]: string }();
            //    //mstrModuleName = this.GetType().toString();
            //}
            get: function () {
                return this.hmProperty;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsGeneralTab.prototype, "UpdFldString", {
            /*
             * 获取修改的字段名串
             */
            get: function () {
                var sbMsg = "";
                //var iLen = this.hmProperty.length();
                for (var key in this.hmProperty) {
                    var value = this.hmProperty[key];
                    sbMsg = sbMsg + key + "|";
                }
                return sbMsg;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsGeneralTab.prototype, "TabName_Curr", {
            //public get ErrNo ()//->Int 
            //{
            //    return this.mintErrNo;
            //}
            //public set ErrNo (value:Number) {
            //    this.mintErrNo = value;
            //}
            //public get DispErrMsg () { //对外显示的错误信息
            //    return this.mstrDispErrMsg;
            //}
            //public set DispErrMsg (value:string) { //对外显示的错误信息
            //    this.mstrDispErrMsg = value;
            //}
            get: function () {
                return this._CurrTabName;
            },
            enumerable: true,
            configurable: true
        });
        return clsGeneralTab;
    }());
    exports.clsGeneralTab = clsGeneralTab;
});
