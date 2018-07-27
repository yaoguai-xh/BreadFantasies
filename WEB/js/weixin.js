/**
 * Created by Administrator on 2017/10/22 0022.
 */
$(document).ready(function(){
    $(".weixin").mouseover(function(){
        $(".erwei").css("opacity","1");
    });
    $(".weixin").mouseout(function(){
        $(".erwei").css("opacity","0");
    });

    $(".fa").click(function(){
        $(".list1").css("display","block");
        $(".list2").css("display","none");
        $(".list3").css("display","none");   $(".fa").css("background-color","#31708f");
        $(".wan").css("background-color","rgba(138, 167, 255, 0.69");
        $(".shouhuo").css("background-color","rgba(138, 167, 255, 0.69");
    });
    $(".shouhuo").click(function(){
        $(".list1").css("display","none");
        $(".list2").css("display","block");
        $(".list3").css("display","none");   $(".shouhuo").css("background-color","#31708f");
        $(".shouhuo").css("background-color","#31708f");
        $(".fa").css("background-color","rgba(138, 167, 255, 0.69");
        $(".wan").css("background-color","rgba(138, 167, 255, 0.69");
    });
    $(".wan").click(function(){
        $(".list1").css("display","none");
        $(".list2").css("display","none");
        $(".list3").css("display","block");   $(".wan").css("background-color","#31708f");
        $(".fa").css("background-color","rgba(138, 167, 255, 0.69");
        $(".shouhuo").css("background-color","rgba(138, 167, 255, 0.69");

    });


});
