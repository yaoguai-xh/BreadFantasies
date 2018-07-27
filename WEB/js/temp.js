var imgUrl;
var count;
var img;
var img1;
var temp;
var block;
var li;
var templi;
window.onload = function(){
		img = new Image();
		count = 1;
		imgUrl = ["pic/home_title.png","pic/bread4.png","pic/dis3.png"];
		img1 = document.getElementById("picture");
		block = document.getElementById("block");
		li = block.getElementsByTagName("li");
		templi = li[0];
		imgLoad();
		addListener();
		temp = setInterval("autoScroll()",2500);
}
	function addListener(){
		var i;
		for(i=0;i<li.length;i++){
			li[i].onclick=changeImg;
		}
	}
	function imgLoad(){
		var i ;
		for(i = 0;i<imgUrl.length;i++){
			img.src = imgUrl[i];
		}
	}
	function changeImg(){
		var i;
		for(i = 0;i<li.length;i++){
			if(this==li[i]){
				img1.src = imgUrl[i];
				templi.style.backgroundColor = "#ff8b31";
				this.style.backgroundColor = "#717171";
				count = i;
				templi = this;
			}
		}
	}
	function autoScroll(){
		templi.style.backgroundColor="#ff8b31";
		img1.src = imgUrl[count];
		li[count].style.backgroundColor="#717171";
		templi = li[count];
		count = (count+1)%imgUrl.length;
	}
