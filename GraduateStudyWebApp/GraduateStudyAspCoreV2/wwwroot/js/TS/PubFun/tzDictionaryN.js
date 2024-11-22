/*
 * 功能:定义一个字典类
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
    exports.DictionaryN = void 0;
    class DictionaryN {
        constructor() {
            //const userInfo: { [index: string]: string } = {}
            this.elements = {};
        }
        //length of Dictionary
        length() {
            let intCount = 0;
            for (const k in this.elements) {
                intCount++;
            }
            return intCount;
        }
        ;
        //Check whether the Dictionary is empty
        isEmpty() {
            return (this.length() < 1);
        }
        ;
        //remove all elements from the Dictionary
        removeAll() {
            this.elements = {}; //new  Array();
        }
        ;
        //get specify element of the dictionary
        element(index) {
            let rlt;
            if (index >= 0 && index < this.length()) {
                rlt = this.elements[index];
                return rlt;
            }
            return undefined;
        }
        //check whether the Dictionary contains this key
        Exists(key) {
            let rlt = false;
            for (const k in this.elements) {
                if (k == key) {
                    rlt = true;
                    break;
                }
            }
            return rlt;
        }
        ;
        //check whether the Dictionary contains this value
        containsValue(value) {
            let rlt = false;
            for (const k in this.elements) {
                if (this.elements[k] == value) {
                    rlt = true;
                    break;
                }
            }
            return rlt;
        }
        ;
        //remove this key from the Dictionary
        remove(key) {
            let rlt = false;
            for (const k in this.elements) {
                console.log("k:", k);
                if (k === key.toString()) {
                    //this.elements.splice(k, 1);
                    delete this.elements[k];
                    rlt = true;
                    break;
                }
            }
            return rlt;
        }
        ;
        //add this key/value to the Dictionary,if key is exists,replace the value
        add(key, value) {
            this.remove(key);
            this.elements[key] = value;
        }
        ;
        //add this key/value to the Dictionary,if key is exists,append value
        set(key, value) {
            const arr = this.getItem(key);
            if (arr != null) {
                if (typeof (arr) == "object") {
                    //arr.unshift.apply(arr, value);
                    value = arr;
                }
                else {
                    const array = [];
                    array.push(arr);
                    //array.unshift.apply(array, value);
                    array.unshift(value);
                    value = array;
                }
                this.remove(key);
            }
            this.elements[key] = value;
        }
        //get value of the key
        getItem(key) {
            let rlt;
            for (const k in this.elements) {
                console.log("k:", k);
                if (k == key.toString()) {
                    rlt = this.elements[k];
                    return rlt;
                    break;
                }
            }
            return undefined;
        }
        ;
        //get all keys of the dictionary
        keys() {
            const arr = [];
            //for (let k in map) {
            //    egret.log(map[k]);
            //}
            for (const k in this.elements) {
                arr.push(k);
            }
            return arr;
        }
        //get all values of the dictionary
        values() {
            const arr = [];
            //for (let k in map) {
            //    egret.log(map[k]);
            //}
            for (const k in this.elements) {
                arr.push(this.elements[k]);
            }
            return arr;
        }
        //get all values of the dictionary
        getParamText() {
            let strParamText = "";
            //for (let k in map) {
            //    egret.log(map[k]);
            //}
            for (const k in this.elements) {
                if (strParamText === "") {
                    strParamText = `${k}=${this.elements[k]}`;
                }
                else {
                    strParamText += `&${k}=${this.elements[k]}`;
                }
            }
            return strParamText;
        }
    }
    exports.DictionaryN = DictionaryN;
});
