
import { Dictionary } from "../PubFun/tzDictionary.js";
declare var $;
export class ParameterAttribute {
    /// <summary>
    /// 论文id
    /// </summary>
    public ThesisId: string = "";
    /// <summary>
    /// 子论文类型Id
    /// </summary>
    public SubviewPointTypeId: string = "";
   

    public static GetMapParam(objParameterAttribute: ParameterAttribute): Dictionary {
        //List < string > arrLst = new List<string>(objUserLoginInfo.CurrSelPrjId);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("ThesisId", objParameterAttribute.ThesisId);
        mapParam.add("SubviewPointTypeId", objParameterAttribute.SubviewPointTypeId);

        return mapParam;

    }
    /*
     *把Html string 转换成对象。先转换成JSON string , 然后再转换成对象 
     */
    public static GetObjByHtmlString(strParameterAttribute: string): ParameterAttribute {
        var strParameterAttribute2 = $.parseHTML(strParameterAttribute);
        var objParameterAttribute: ParameterAttribute = JSON.parse(strParameterAttribute2[0].wholeText);
        return objParameterAttribute;
    }
}