
export class clsPrivateSessionStorage {

  

    //////////////////////////////////////////////////////////学生流水号/////////////////////////////////////////////////////////////
    //获取学生流水号ID
    public static GetId_Stu(): string {

        var strKey: string = "id_StudentInfo";
        var strId_Stu: string = "";
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strId_Stu = localStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存Id_Stu为空！");
        }
        return strId_Stu;
    }
    //设置学生流水号Id
    public static SetId_Stu(strId_Stu: string) {
        try {
            //清空本类缓存
            var strKey: string = "id_StudentInfo";
            localStorage.removeItem(strKey);
            //把值存入session
            localStorage.setItem(strKey, strId_Stu);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }

  

    //////////////////////////////////////////////////////////专业ID/////////////////////////////////////////////////////////////
    //专业ID
    public static GetSession_id_XzMajor(): string {

        var strKey: string = "id_XzMajor";
        var strid_XzMajor: string = "";
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strid_XzMajor = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存id_XzMajor为空！");
        }
        return strid_XzMajor;
    }

    //设置用户Id
    public static SetSession_id_XzMajor(strid_XzMajor: string) {
        try {
            //清空本类缓存
            var strKey: string = "id_XzMajor";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strid_XzMajor);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }

    //////////////////////////////////////////////////////////专业/////////////////////////////////////////////////////////////
    //获取用户ID
    public static GetSession_MajorName(): string {

        var strKey: string = "majorName";
        var strMajorName: string = "";
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strMajorName = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存majorName为空！");
        }
        return strMajorName;
    }

    //设置用户Id
    public static SetSession_MajorName(strMajorName: string) {
        try {
            //清空本类缓存
            var strKey: string = "majorName";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strMajorName);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }


    //////////////////////////////////////////////////////////用户List/////////////////////////////////////////////////////////////
    //获取用户Lst
    public static GetUserLst(): string {

        var strKey: string = "UserLst";
        var strUserLst: string = "";
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strUserLst = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存用户Lst为空！");
        }
        return strUserLst;
    }
    //设置用户Lst
    public static SetUserLst(strUserLst: string) {
        try {
            //清空本类缓存
            var strKey: string = "UserLst";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strUserLst);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }


    //获取分页当前页
    public static get PaperNum(): string {

        var strKey: string = "PaperNum";
        var strPaperNum: string = "";
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            strPaperNum = localStorage.getItem(strKey) as string;

        }
        else {
            console.log("缓存strEduClsTypeID为空！");
        }
        return strPaperNum;
    }

    //设置分页当前页
    public static set PaperNum(strPaperNum: string) {
        try {
            //清空本类缓存
            var strKey: string = "PaperNum";
            localStorage.removeItem(strKey);
            //把值存入session
            localStorage.setItem(strKey, strPaperNum);
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `存入缓存出错,${e}.`;
            throw (strMsg);
        }
    }

    //////////////////////////////////////////////////////////主题Id/////////////////////////////////////////////////////////////
    //获取用户ID
    public static get topicId(): string {

        const strKey = "topicId";
        let strTopicId = "";
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            strTopicId = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.error("缓存topicId为空！");
        }
        return strTopicId;
    }
    //设置用户Id
    public static set topicId(strTopicId: string) {
        try {
            //清空本类缓存
            const strKey = "topicId";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strTopicId);
        }
        catch (e: any) {

            const strMsg = `存入缓存出错,${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }


    //////////////////////////////////////////////////////////主题Id/////////////////////////////////////////////////////////////
    //获取用户ID
    public static get topicName(): string {

        const strKey = "topicName";
        let strTopicName = "";
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            strTopicName = sessionStorage.getItem(strKey) as string;

        }
        else {
            console.error("缓存topicName为空！");
        }
        return strTopicName;
    }
    //设置用户Id
    public static set topicName(strTopicName: string) {
        try {
            //清空本类缓存
            const strKey = "topicName";
            sessionStorage.removeItem(strKey);
            //把值存入session
            sessionStorage.setItem(strKey, strTopicName);
        }
        catch (e: any) {

            const strMsg = `存入缓存出错,${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
};