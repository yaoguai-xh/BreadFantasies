/*****
*表单验证代码
*
*/
function phoneJudge(){   //手机号验证
		var phone1=document.getElementById("phone");
		var btnSubmit =document.getElementById("btnRegsiter");
		if (phone1.value==""||phone1.value.length<11) {
			document.getElementById("phoneHit").innerHTML="请输入正确的手机号码";
			btnSubmit.disabled = true;
		}
		else{
			btnSubmit.disabled = false;
			document.getElementById("phoneHit").innerHTML="";
		}
}
function userNameJudge(){ //用户名验证
		var btnSubmit =document.getElementById("btnRegsiter");
		var userName1=document.getElementById("userName");
		if (userName1.value=="") {
			document.getElementById("userNameHit").innerHTML="请输入正确的昵称";
			btnSubmit.disabled = true;
		}
		else{
			document.getElementById("userNameHit").innerHTML="";
			btnSubmit.disabled = false;
		}

}
function passwordJudge(){ //密码验证
		var btnSubmit =document.getElementById("confirm");
		var passwordOne=document.getElementById("password1");
		var passwordTwo=document.getElementById("password2");

		if (passwordOne.value==""||passwordOne.value.length<9||passwordOne.value.length>16) {
			document.getElementById("password1Hit").innerHTML="密码格式不正确";
			btnSubmit.disabled = true;
		}
		if (passwordTwo.value==""||passwordTwo.value!=passwordOne.value) {
			document.getElementById("password2Hit").innerHTML="两次输入的密码不一致";
			btnSubmit.disabled = true;
		}
		else{
			document.getElementById("password1Hit").innerHTML="";
			document.getElementById("password2Hit").innerHTML="";
			btnSubmit.disabled = false;
		}
}
	
function CheckboxJudge(){    //表单校验
		var checkbox1=document.getElementById("checkboxAgreement");
		var btnSubmit =document.getElementById("btnRegsiter");
		var year1=document.getElementById("year");
		var month1=document.getElementById("month");
		var days1=document.getElementById("days");
		var days1=document.getElementById("days");
		var prov1=document.getElementById("prov");
		var city1=document.getElementById("city");
		var area1=document.getElementById("area");
		var inputTextarea1=document.getElementById("inputTextarea");
		var flag1=false;
		var flag2=false;
		var flag3=false;
		var flag4=false;
//checkbox验证
		if(checkbox1.checked){ 
			flag1=true;
			document.getElementById("lastHit").innerHTML="";
		}
		else{
			document.getElementById("lastHit").innerHTML="请勾选用户协议";
			flag1=false;
			btnSubmit.disabled = true;
		}
//详细地址验证
		if (inputTextarea1.value=="") { 
			document.getElementById("lastHit").innerHTML="请输入详细地址";
			flag2=false;
			btnSubmit.disabled = true;
		}
		else{
			flag2=true;
		}
//地址下拉列表验证
		if (prov1.value=="-1"||city1.value=="n-1"||area1.value=="-1") { 
			document.getElementById("lastHit").innerHTML="请选择地区";
			flag3=false;
			btnSubmit.disabled = true;
		}
		else{
			
			flag3=true;
		}
//生日验证
		if (year1.value=="none"||month1.value=="none"||days1.value=="none") {
			document.getElementById("lastHit").innerHTML="请选择生日";
			btnSubmit.disabled = true;
			flag4=false;
		}
		else{
			flag4=true;
		}
//总验证
		if (flag1==true && flag2==true && flag3==true && flag4==true) {
			btnSubmit.disabled=false;
		}

}



function phoneJudge1(){   //手机号验证1
		var phone1=document.getElementById("phone");
		var btnSubmit =document.getElementById("confirm");
		if (phone1.value==""||phone1.value.length<11) {
			document.getElementById("phoneHit").innerHTML="请输入正确的手机号码";
			btnSubmit.disabled = true;
		}
		else{
			btnSubmit.disabled = false;
			document.getElementById("phoneHit").innerHTML="";
		}
}
function userNameJudge1(){ //用户名验证1
		var btnSubmit =document.getElementById("confirm");
		var userName1=document.getElementById("userName");
		if (userName1.value=="") {
			document.getElementById("userNameHit").innerHTML="请输入正确的姓名";
			btnSubmit.disabled = true;
		}
		else{
			document.getElementById("userNameHit").innerHTML="";
			btnSubmit.disabled = false;
		}

}
function confirmJudge(){ //确认购买框验证
		var btnSubmit =document.getElementById("confirm");
		var phone1=document.getElementById("phone");
		var userName1=document.getElementById("userName");
		var prov1=document.getElementById("prov");
		var city1=document.getElementById("city");
		var area1=document.getElementById("area");
		var inputTextarea1=document.getElementById("inputTextarea");
		var flag1=false;
		var flag2=false;
//详细地址验证
		if (inputTextarea1.value=="") { 
			document.getElementById("lastHit").innerHTML="请输入详细地址";
			flag1=false;
			btnSubmit.disabled = true;
		}
		else{
			flag1=true;
			document.getElementById("lastHit").innerHTML="";
		}
//地址下拉列表验证
		if (prov1.value=="-1"||city1.value=="n-1"||area1.value=="-1") { 
			document.getElementById("lastHit").innerHTML="请选择地区";
			flag2=false;
			btnSubmit.disabled = true;
		}
		else{
			flag2=true;
		}
//总验证
		if (flag1==true && flag2==true) {
			btnSubmit.disabled=false;
		}
		else{
			btnSubmit.disabled=true;
		}


}
/*****
*日期动态联动代码
*
*/
function showDay(){            //下拉列表———日
		var y = document.getElementById("year").value;
		var m = document.getElementById("month").value;
		var day;
		switch(m){
			case "1":
			case "3":
			case "5":
			case "7":
			case "8":
			case "10":
			case "12":
				day = 31;
				break;
			case "4":
			case "6":
			case "9":
			case "11":
				day = 30;
				break;
			case "2":
				if(y%4==0&&y%100!=0||y%400==0){
					day = 29;
				} else {
					day = 28;
				}
		}
		var str="<option value='none'>请选择日</option>";
		for(a=1;a<=day;a++){
			str += "<option value="+a+">"+a+"</option>";
		}
		document.getElementById("days").innerHTML = str;
}




/**
 * Jquery省市区联动代码
 */

 function CitySelect(options) {
	this.config = {
		 data             :      '',             // 数据
		 provId           :      '',             // 省下拉框id容器 格式是 #XXX
		 cityId           :      '',             // 市下拉框id容器 格式是 #XXX
		 areaId           :      '',             // 区下拉框id容器 格式是 #XXX
		 isSelect         :      true,           // 默认为true 选择第一项 如果页面有指定省市区项时，就显示指定项。
		                                         // 如果false，就选中 "请选择"
		 provCallBack     :      null,           // 省份渲染完成后回调
		 cityCallBack     :      null,           // 市渲染完成后的回调
		 areaCallBack     :      null            // 区渲染完成后的回调
	};
	this.config = $.extend(this.config, options || {});
	this.init();
 }

 CitySelect.prototype = {

	constructor: CitySelect,
	
	/*
	 * 初始化方法init
	 */
	init: function() {
		var self = this,
			_config = self.config;

		if(!/^#/.test(_config.provId)) {
			alert("省份ID传的不正确,格式是 #XXX");
			return;
		}
		if(!/^#/.test(_config.cityId)) {
			alert("城市ID传的不正确,格式是 #XXX");
			return;
		}
		if(!/^#/.test(_config.cityId)) {
			alert("区ID传的不正确,格式是 #XXX");
			return;
		}
		this.provCode = $(_config.provId).attr("data-code");
		this.cityCode = $(_config.cityId).attr("data-code");
		this.areaCode = $(_config.areaId).attr("data-code");
		
		// 使省市区id (#XX --> XX)
		this.provid =  _config.provId.replace(/^#/g,'');
		this.cityid = _config.cityId.replace(/^#/g,'');
		this.areaid = _config.areaId.replace(/^#/g,'');

		// 渲染省份
		self._provFunc();

		//渲染省对应的市
		self._cityFunc();
		
		// 渲染省市 对应的区
		self._areaFunc();
		
		// 如果省份的值是-1的话 那么设置省市区select都为-1
		var provFirstOpt = $(_config.provId).val();
		if(provFirstOpt == -1) {
			$(_config.provId).attr("data-code","-1");
			$(_config.cityId).attr("data-code","-1");
			$(_config.areaId).attr("data-code","-1");
		}
		// change事件 省切换 自动切换市 and 区 
		$(_config.provId).change(function(e){
			self._cityFunc();
			self._areaFunc();
		});

		// 市 change事件 自动切换区
		$(_config.cityId).change(function(e){
			self._areaFunc();
		});
		// 区change事件 
		$(_config.areaId).change(function(){
			$(_config.areaId).attr("data-code",$(this).val());
		});
	},
	/*
	 * 渲染省数据
	 * @method _provFunc {private}
	 */
	_provFunc: function(){
		var self = this,
			_config = self.config;

		var elemHtml = '';
		elemHtml+= '<option value="-1" data-name="请选择省" selected>请选择省</option>';

		$(_config.data).each(function(i,curItem){
			elemHtml += "<option data-name='"+curItem[1]+"' value='"+curItem[1]+"'>"+curItem[1]+"</option>";
		});
		$(_config.provId).html(elemHtml);
		
		if(_config.isSelect) {
			$($(_config.provId + " option")[1]).attr("selected",'true');
			if(this.provCode) {
				self._setSelectCode(_config.provId,this.provCode);
			}
		}
		
		_config.provCallBack && $.isFunction(_config.provCallBack) && _config.provCallBack();
	},
	/*
	 * 渲染省对应的市数据
	 * @method _cityFunc {private}
	 */
	_cityFunc: function(){
		var self = this,
			_config = self.config;

		var provIndex = $(_config.provId).get(0).selectedIndex,   // 获取省份的索引index
			elemHtml = '',
			prov,
			citys,
			provOpt;
		
		provOpt = $($(_config.provId + ' option')[0]).attr("value");
		var opthtml = '<option value="-1" data-name="请选择市" selected>请选择市</option>';

		// 如果省有请选择的话 那么相应的省要减一
		if(provOpt == -1) {
			provIndex--;
		}
		$(_config.cityId).empty();
		$(_config.areaId).empty();
		/*
		 * 如果选择的是 第一项 "请选择" 的话 那么省市区的value都为-1
		 * 并且默认选中市 区的第一项 请选择option
		 */
		if(provIndex < 0){
			$(_config.provId).attr("data-code",'-1');
			$(_config.cityId).attr("data-code",'-1');
			$(_config.areaId).attr("data-code",'-1');

			$(_config.cityId).html(opthtml);
			$(_config.areaId).html(opthtml);
			return;
		}
		prov = _config.data[provIndex];
		citys = prov[2];
		elemHtml += '<option value="-1" data-name="请选择市">请选择市</option>';
		for(var m = 0; m < citys.length; m++) {
			var oneCity = citys[m];
			elemHtml += "<option value='"+oneCity[1]+"' data-name='"+oneCity[1]+"'>"+oneCity[1]+"</option>";
		}
		$(_config.cityId).html(elemHtml);

		if(_config.isSelect) {
			$($(_config.cityId + " option")[1]).attr("selected",'true');
			if(this.cityCode) {
				self._setSelectCode(_config.cityId,this.cityCode);
			}
		}
		self._selectChangeCode();

		_config.cityCallBack && $.isFunction(_config.cityCallBack) && _config.cityCallBack();
	},
	/*
	 * 渲染市对应的区数据
	 * @method _areaFunc {private}
	 */
	_areaFunc: function(){
		var self = this,
			_config = self.config;

		var	provOpt = $($(_config.provId + ' option')[0]).attr("value"),
			cityOpt = $($(_config.cityId + ' option')[0]).attr("value");

		var provIndex = $(_config.provId).get(0).selectedIndex,
			cityIndex = $(_config.cityId).get(0).selectedIndex,
			elemHtml = "",
			prov,
			citys,
			areas,
			oneCity;
		var opthtml = '<option value="-1" data-name="请选择区" selected>请选择区</option>';
		
		/*
		 * 如果省选择了 "请选择了" 那么省和市自动切换到请选择 那么相应的索引index-1
		 * 如果省没有选择 "请选择"，市选择了 "请选择" 那么市的索引index - 1
		 */
		if(provOpt == -1) {
			provIndex--;
			cityIndex--;

		}else if(provOpt != -1 && cityOpt == -1) {
			cityIndex--;
		}
		
		if(provIndex < 0 || cityIndex < 0){
			$(_config.cityId).attr("data-code",'-1');
			$(_config.areaId).attr("data-code",'-1');
			$(_config.areaId).html(opthtml);
			return;
		};
		prov = _config.data[provIndex];
		citys = prov[2];
		oneCity = citys[cityIndex];
		areas = oneCity[2];

		elemHtml += '<option value="-1" data-name="请选择区">请选择区</option>';
		if(areas != null) {
			for(var n = 0; n < areas.length; n++) {
				var oneArea = areas[n];
				elemHtml += "<option value='"+oneArea[1]+"' data-name='"+oneArea[1]+"'>"+oneArea[1]+"</option>";
			}
			
		}
		$(_config.areaId).html(elemHtml);
		
		if(_config.isSelect) {
			$($(_config.areaId + " option")[1]).attr("selected",'true');
			if(this.areaCode) {
				self._setSelectCode(_config.areaId,this.areaCode);
			}
		}
		self._selectChangeCode();

		_config.areaCallBack && $.isFunction(_config.areaCallBack) && _config.areaCallBack();
	},
	 /*
     * 根据change事件来改变省市区select下拉框的data-code的值 
     * @method _changeSetCode private
     * @param selectId 省市区select dom节点
     */
    _changeSetCode: function(selectId){
    	var self = this,
    		_config = self.config;
    	var idx = selectId.selectedIndex, //获取选中的option的索引
            option,
            value,
			dataValue = $(_config.provId).val();
		var html = "<option data-name='请选择' value='-1' selected>请选择</option>",
			provOpt = $($(_config.provId + ' option')[0]).attr("value");

        if(idx > -1) {
			if(dataValue == -1) {
				if(provOpt != "-1") {
					$(_config.provId).prepend(html);
					$(_config.cityId).prepend(html);
					$(_config.areaId).prepend(html);
				}
				$(_config.provId).attr("data-code",'');
				$(_config.cityId).attr("data-code",'');
				$(_config.areaId).attr("data-code",'');
			}else {
				option = selectId.options[idx];  //获取选中的option元素
				value = $(option).val();
				$(selectId).attr("data-code",value);
			}
        }
    },
	_selectChangeCode: function(){
		var self = this,
			_config = self.config;

		// 省change事件时候 省select下拉框data-code也要变化
		var provId = document.getElementById(this.provid);
		self._changeSetCode(provId);

		// 市change事件时候 市select下拉框data-code也要变化
		var cityId = document.getElementById(this.cityid);
		self._changeSetCode(cityId);
		
		// 区change事件时候 市select下拉框data-code也要变化
		var areaId = document.getElementById(this.areaid);
		self._changeSetCode(areaId);
	},
	 /*
     * 根据下拉框select属性data-code值 来初始化省下拉框的值
     * @method _setSelectCode {private}
     * @param selectId 下拉框的Id
     */
    _setSelectCode: function(selectId,code){
    	var self = this,
    		_config = self.config;
    		
    	var optionElems = $(selectId + " option");
		
    	$(optionElems).each(function(index,item){
    		var curCode = $(item).val();
    		if(curCode == code) {
    			$(item).attr("selected",'true');
				$(selectId).attr("data-code",curCode);
    			return;
    		}
    	});
    }
 };