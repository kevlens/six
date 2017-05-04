$.extend($.fn.validatebox.defaults.rules, {
    /*必须和某个字段相等*/
    equalTo: { validator: function (value, param) { return $(param[0]).val() == value; }, message: '字段不匹配' },
 

    //手机号码验证
    mobile:{
        validator:function(value){
            var reg = /^(((13[0-9]{1})|(14[0-9]{1})|(15[0-9]{1})|(18[0-9]{1}))+\d{8})$/;
 
            return value.length == 11 && reg.test(value);
        },
        message: "手机号码格式不正确."
    },
    //验证中文  
    CHS: {
        validator: function (value) {
            return /^[\u0391-\uFFE5]+$/.test(value);
        },
        message: "只能输入汉字."
    },
    //字符验证
    stringCheck: {
        validator: function (value) {
            return /^[\u0391-\uFFE5\w]+$/.test(value);
        },
        message: "只能包括中文字、英文字母、数字和下划线."
    },
    //密码验证
    isRegisterPassWord: {
        validator: function (value) {
            return /^(?=.*[a-zA-Z])(?=.*\d)(?=.*[~!@#$%^&*()_+`\-={}:";'<>?,.\/]).{8,25}$/.test(value);//数字、大小写字母、特殊字符，三项全包含
            //return /^(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$/.test(value);//可不含特殊字符
        },
        message: "不允许弱密码"
    },
    //字符验证
    textCheck: {
        validator: function (value) {
            return /^[0-9\.,-]*$/.test(value);
        },
        message: "只能包括逗号、数字和横线."
    },
    //验证中文,英文,数字
    stringCheckSub: {
        validator: function (value) {
            return /^[a-zA-Z0-9\u4E00-\u9FA5]+$/.test(value);
        },
        message: "只能包括中文字、英文字母、数字."
    },
    englishCheckSub: {
        validator: function (value) {
            return /^[a-zA-Z0-9]+$/.test(value);
        },
        message: "只能包括英文字母、数字."
    },
    //匹配由数字、26个英文字母或者下划线组成的字符串 
    englishsymbolCheckSub: {
        validator: function (value) {
            return /^\w+$/.test(value);
        },
        message: "只能包括英文字母、数字、下划线"
    },
    numberCheckSub: {
        validator: function (value) {
            return /^[0-9]+$/.test(value);
        },
        message: "只能输入数字."
    },
    intOrFloat: {// 验证整数或小数
        validator: function (value) {
            return /^d+(.d+)?$/i.test(value);
        },
        message: "只能输入数字，保留三位小数"
    },
    intFloat:{
        validator: function(value){
            return /^(\d{1,10}|\d{1,7}\.\d{1,3})$/.test(value);
        },
        message:"只能输入数字，保留三位小数"
    },
    intOrDecimal: {
        validator: function (value) {
            return /^[0-9]{0,5}.\d{0,3}$/.test(value);
        },
        message: "请输入合法的数字类型"
    },
    date: {//验证日期
        validator: function (value) {
            return /(([0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]{1}|[0-9]{1}[1-9][0-9]{2}|[1-9][0-9]{3})-(((0[13578]|1[02])-(0[1-9]|[12][0-9]|3[01]))|((0[469]|11)-(0[1-9]|[12][0-9]|30))|(02-(0[1-9]|[1][0-9]|2[0-8]))))|((([0-9]{2})(0[48]|[2468][048]|[13579][26])|((0[48]|[2468][048]|[3579][26])00))-02-29)/.test(value);
        },
        message: "只能输入日期格式(yyyy-MM-dd)"
    },
    email: {
        validator: function (value) {
            return /^w+([-+.]w+)*@w+([-.]w+)*.w+([-.]w+)*$/.test(value);
        },
        message: "请输入有效的电子邮件账号(例：abc@126.com)"
    },
    year: {
        validator: function (value) {
            return /^\d{4}$/.test(value);
        },
        message: "请输入正确的年份(例：2015)"
    }
});

/*
$.extend($.fn.validatebox.defaults.rules, {
 minLength : { // 判断最小长度
     validator : function(value, param) {
         return value.length >= param[0];
         },
     message : "最少输入 {0} 个字符。"
     },
 length:{validator:function(value,param){
     var len=$.trim(value).length;
     return len>=param[0]&&len<=param[1];
     },
     message:"输入内容长度必须介于{0}和{1}之间."
     },
 phone : {// 验证电话号码
     validator : function(value) {
         return /^(((d{2,3}))|(d{3}-))?((0d{2,3})|0d{2,3}-)?[1-9]d{6,7}(-d{1,4})?$/i.test(value);
         },
     message : "格式不正确,请使用下面格式:020-88888888"
     },
 mobile : {// 验证手机号码
     validator : function(value) {
         return /^(13|15|18)d{9}$/i.test(value);
         },
     message : "手机号码格式不正确"
     },
 idcard : {// 验证身份证
     validator : function(value) {
         return /^d{15}(d{2}[A-Za-z0-9])?$/i.test(value);
         },
     message : "身份证号码格式不正确"
     },
 intOrFloat : {// 验证整数或小数
     validator : function(value) {
         return /^d+(.d+)?$/i.test(value);
         },
     message : "请输入数字，并确保格式正确"
     },
 currency : {// 验证货币
     validator : function(value) {
         return /^d+(.d+)?$/i.test(value);
         },
     message : "货币格式不正确"
     },
 qq : {// 验证QQ,从10000开始
     validator : function(value) {
         return /^[1-9]d{4,9}$/i.test(value);
         },
     message : "QQ号码格式不正确"
     },
 integer : {// 验证整数
     validator : function(value) {
         return /^[+]?[1-9]+d*$/i.test(value);
         },
     message : "请输入整数"
     },
 chinese : {// 验证中文
     validator : function(value) {
         return /^[u0391-uFFE5]+$/i.test(value);
         },
     message : "请输入中文"
     },
 english : {// 验证英语
     validator : function(value) {
         return /^[A-Za-z]+$/i.test(value);
         },
     message : "请输入英文"
     },
 unnormal : {// 验证是否包含空格和非法字符
     validator : function(value) {
         return /.+/i.test(value);
         },
     message : "输入值不能为空和包含其他非法字符"
     },
 username : {// 验证用户名
     validator : function(value) {
         return /^[a-zA-Z][a-zA-Z0-9_]{5,15}$/i.test(value);
         },
     message : "用户名不合法（字母开头，允许6-16字节，允许字母数字下划线）"
     },
 faxno : {// 验证传真
     validator : function(value) {
        // return /^[+]{0,1}(d){1,3}[ ]?([-]?((d)|[ ]){1,12})+$/i.test(value);
         return /^(((d{2,3}))|(d{3}-))?((0d{2,3})|0d{2,3}-)?[1-9]d{6,7}(-d{1,4})?$/i.test(value);
         },
     message : "传真号码不正确"
     },
 zip : {// 验证邮政编码
     validator : function(value) {
         return /^[1-9]d{5}$/i.test(value);
         },
     message : "邮政编码格式不正确"
     },
 ip : {// 验证IP地址
     validator : function(value) {
         return /d+.d+.d+.d+/i.test(value);
         },
     message : "IP地址格式不正确"
     },
 name : {// 验证姓名，可以是中文或英文
     validator : function(value) {
         return /^[u0391-uFFE5]+$/i.test(value)|/^w+[ws]+w+$/i.test(value);
         },
     message : "请输入姓名"
     },
 carNo:{
     validator : function(value){
         return /^[u4E00-u9FA5][da-zA-Z]{6}$/.test(value);
         },
     message : "车牌号码无效（例：粤J12350）"
     },
 carenergin:{
     validator : function(value){
         return /^[a-zA-Z0-9]{16}$/.test(value);
         },
     message : "发动机型号无效(例：FG6H012345654584)"
     },
 email:{
     validator : function(value){
         return /^w+([-+.]w+)*@w+([-.]w+)*.w+([-.]w+)*$/.test(value);
         },
     message : "请输入有效的电子邮件账号(例：abc@126.com)" 
     },
 msn:{
     validator : function(value){
         return /^w+([-+.]w+)*@w+([-.]w+)*.w+([-.]w+)*$/.test(value);
         },
     message : "请输入有效的msn账号(例：abc@hotnail(msn/live).com)"
     },same:{
         validator : function(value, param){
             if($("#"+param[0]).val() != "" && value != ""){
                 return $("#"+param[0]).val() == value;
                 }else{
                 return true;
                 }
             },
         message : "两次输入的密码不一致！" 
         }
});


    allNotNull: {
    validator:function(toValue,fromValue){
        if(fromValue ==null || fromValue.length ==0 || fromValue[0]==null || fromValue[0]==""){
            if(toValue ==null || toValue.length ==0 || toValue[0]==null || toValue[0]==""){
                $.fn.validatebox.defaults.rules.compareDigit.message="站（场）名与线名、行别、里程不可同时为空 ";
                return false;
            }else{
                return true;
            }
        }else
        {return true;}
    },
    message:""
    },

     // 输入框级联验证
     <input name="skymileFo1" id="skymileFo1" style="width: 65px;" class="easyui-numberbox" data-bind="textboxValue: addForm.MILEAGE_BEGIN" data-options="required:true,min:0,precision:3" />-
     <input name="skymileTo1" id="skymileTo1" style="width: 65px;" class="easyui-numberbox" data-bind="textboxValue: addForm.MILEAGE_END"  validType="mileendcheck['#skymileFo1','#skymileTo1']" data-options="required:true,min:0,precision:3"/>

        mileendcheck: {
            validator: function(value,param) {
                // bind to the blur event of the target in order to revalidate whenever the target field is updated
                // TODO find a way to bind the event just once, avoiding the unbind-rebind overhead
                var target = $(param[0]);
                var element = $(param[1]);
                
                $("input", target.next("span")).blur(function () {
                    element.textbox("isValid");
                });
                
                return value == target.val();
            },
            message: '两次输入内容不同'
        }
**/

