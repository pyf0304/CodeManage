export class clsString {
    private mstrContent: string = "";
    constructor() {

    }
    public Append(strAppend: string) {
        this.mstrContent += strAppend;
    }

    public AppendFormat(strFormat: string, Para1?: any, Para2?: any, Para3?: any, Para4?: any, Para5?: any, Para6?: any, Para7?: any, Para8?: any, Para9?: any) {
        if (arguments.length === 0)
            return "";

        var str = arguments[0];
        for (var i = 1; i < arguments.length; i++) {
            var re = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
            str = str.replace(re, arguments[i]);
        }
        this.mstrContent += str;
    }
    public ToString() {
        return this.mstrContent;
    }

    /// <summary>
    /// 把单词的第一个字母变成大写
    /// </summary>
    /// <param name="mStr"></param>
    /// <returns></returns>
    public static FirstUcaseS(mStr: string): string {
        if (mStr.length == 0) return "";
        var strResult: string = "";
        if (mStr.length > 1) {
            strResult = mStr.substring(0, 1).toUpperCase() + mStr.substring(1, mStr.length - 1);
        }
        else {
            strResult = mStr.substring(0, 1).toUpperCase();
        }
        return strResult;
    }

    /// <summary>
    /// 把单词的第一个字母变成小写
    /// </summary>
    /// <param name="mStr"></param>
    /// <returns></returns>
    public static FstLcaseS(mStr: string): string {
        if (mStr.length == 0) return "";
        var strResult: string= "";
        if (mStr.length > 1) {
            strResult = mStr.substring(0, 1).toLowerCase() + mStr.substring(1, mStr.length - 1);
        }
        else {
            mStr = mStr.substring(0, 1).toLowerCase();
        }
        return strResult;
    }

    /// <summary>
    /// 组装字符串，
    /// </summary>
    /// <param name="mStr">原来的字符串</param>
    /// <param name="count">该字符串的重复次数</param>
    /// <returns>组装好的字符串</returns>
    public static combineStrS(mStr: string, count:number): string {
        var strTemp: string = "";
        for (var i = 0; i < count; i++)
        strTemp += mStr;
        return strTemp;
    }
    /// <summary>
    /// 随机生成n位字符
    /// </summary>
    /// <returns></returns>
    public static MakeRandom2(): string {
        var randomchars: string = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //			int pwdlen=5;
        var tmpstr: string = "";
        var iRandNum: number = Math.random() * randomchars.length;
        //Random rnd = new Random();
        for (var i = 0; i < 5; i++)
        {
            iRandNum = Math.random() * randomchars.length;
            tmpstr += randomchars[iRandNum];
        }
        return tmpstr;
    }
    /// <summary>
    /// 随机生成n位字符
    /// </summary>
    /// <param name="intNumOfCharacters">字符数</param>
    /// <param name="intAdditionalSeed">附加种子</param>
    /// <returns>返回n位字符</returns>
    public static MakeRandom( intNumOfCharacters:number, intAdditionalSeed:number): string{
        var randomchars : string= "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //			int pwdlen=5;
        var tmpstr: string = "";
        
        var jsTicks = new Date().getTime();
        var intSeed = jsTicks;
        var iRandNum: number = Math.random() * (intSeed + intAdditionalSeed);

        for (var i = 0; i < intNumOfCharacters; i++)
        {
            iRandNum = Math.random() * randomchars.length;
            tmpstr += randomchars[iRandNum];
        }
        return tmpstr;
    }
    public static IsNullOrEmpty(strValue:string):boolean  {
        if (strValue == null) return true;
        if (strValue.length == 0) return true;
    //使用字符截取指定字符
    return false;
    };

    public static FormatBak () :string{
        if (arguments.length === 0)
            return "";

        var str = arguments[0];
        for (var i = 1; i < arguments.length; i++) {
            var re = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
            str = str.replace(re, arguments[i]);
        }
        return str;
    }

    public static Format(strFormat: string, Para1?: any, Para2?: any, Para3?: any, Para4?: any, Para5?: any, Para6?: any, Para7?: any, Para8?: any, Para9?: any): string {
        if (arguments.length === 0)
            return "";

        var str = arguments[0];
        for (var i = 1; i < arguments.length; i++) {
            var re = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
            str = str.replace(re, arguments[i]);
        }
        return str;
    }
}