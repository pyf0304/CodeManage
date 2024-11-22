/**
 * Created by Leo on 2015/4/26.
 */
export class Dictionary {
    constructor() {

    }
    //var userInfo: { [index: string]: string } = {}
    public elements: { [key: string]: string } = {};
    //Length of Dictionary
    length(): number {
        var intCount: number = 0;
        for (let k in this.elements) {
            intCount++;
        }
        return intCount;
    };
    //Check whether the Dictionary is empty
    isEmpty(): boolean {
        return (this.length() < 1);
    };
    //remove all elements from the Dictionary
    removeAll(): void {
        this.elements = {};//new  Array();
    };
    //get specify element of the dictionary
    element(index: number) {
        var rlt = "";
        if (index >= 0 && index < this.length()) {
            rlt = this.elements[index];
        }
        return rlt;
    }
    //check whether the Dictionary contains this key
    Exists(key): boolean {
        var rlt = false;
        try {
            //for (let k in map) {
            //    egret.log(map[k]);
            //}
            //for (var i = 0, iLen = this.length(); i < iLen; i++) {
            //    if (this.elements[i].key == key) {
            //        rlt = true;
            //        break;
            //    }
            //}
            for (let k in this.elements) {
                if (k == key) {
                    rlt = true;
                    break;
                }
            }
        }
        catch (ex) {
        }
        return rlt;
    };
    //check whether the Dictionary contains this value
    containsValue(value: string) {
        var rlt = false;
        try {
            //for (let k in map) {
            //    egret.log(map[k]);
            //}
            for (let k in this.elements) {
                if (this.elements[k] == value) {
                    rlt = true;
                    break;
                }
            }
        }
        catch (ex) {
        }
        return rlt;
    };
    //remove this key from the Dictionary
    remove(key) {
        var rlt = false;
        try {
            //for (let k in map) {
            //    egret.log(map[k]);
            //}
            for (let k in this.elements) {
                if (k === key) {
                    //this.elements.splice(k, 1);
                    delete this.elements[k];
                    rlt = true;
                    break;
                }
            }
        }
        catch (ex) {
        }
        return rlt;
    };
    //add this key/value to the Dictionary,if key is exists,replace the value
    add(key, value) {
        this.remove(key);
        this.elements[key] = value;
    };
    //add this key/value to the Dictionary,if key is exists,append value
    set(key, value) {
        var arr: string = this.getItem(key);
        if (arr != null) {
            if (typeof (arr) == "object") {
                //arr.unshift.apply(arr, value);
                value = arr;
            }
            else {
                var array: Array<string> = [];
                array.push(arr);
                array.unshift.apply(array, value);
                value = array;
            }
            this.remove(key);
        }
        this.elements[key] = value;
    }
    //get value of the key
    getItem(key) {
        var rlt = "";
        try {
            //for (let k in map) {
            //    egret.log(map[k]);
            //}
            for (let k in this.elements) {
                if (k == key) {
                    rlt = this.elements[k];
                    break;
                }
            }
        }
        catch (ex) {
        }
        return rlt;
    };
    //get all keys of the dictionary
    keys() {
        var arr : Array<string>= [];
        //for (let k in map) {
        //    egret.log(map[k]);
        //}
        for (let k in this.elements) {
            arr.push(k);
        }
        return arr;
    }
    //get all values of the dictionary
    values() {
        var arr: Array<string>= [];
        //for (let k in map) {
        //    egret.log(map[k]);
        //}
        for (let k in this.elements) {
            arr.push(this.elements[k]);
        }
        return arr;
    }
    //get all values of the dictionary
    getParamText(): string {
        var strParamText: string = "";
        //for (let k in map) {
        //    egret.log(map[k]);
        //}
        for (let k in this.elements) {
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

