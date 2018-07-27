<script type="text/javascript">
          document.getElementById("confirm").onclick = function () {
              sendData();
          }
          //send,发送表单数据到服务器...
          function sendData() {
              document.getElementById("confirm").value = "666";
              var addressString = "";
              addressString += $("#prov").val() + "*" + $("#city").val() + "*" + $("#area").val() + "*" + $("#inputTextarea").val();
              $.ajax({
                  type: 'post',
                  url: 'Handler.ashx',
                  async: true,
                  data: { KEY: '7', goodsNum: $("#goodsNum").val(), price: $("#price").text(), userName:
                  $("#userName").val(), phone: $("#phone").val(), address: addressString, goodsId: $("#showGoodsId").text(),
                      goodsName: $("#showGoodsName").text()
                  },
                  success: function (result) {
                      if (result != "f") {
                          showS();
                      }
                      else {
                          showF();
                      }
                  },
                  error: function () {
                      showError();
                  }
              });
          }
          function showS() {
              document.getElementById('confirmOrder').style.display = 'none';
              document.getElementById('fade').style.display = 'none';
              $("#stantard-dialogBox").dialogBox({
                  title: '提示',
                  hasMask: true,
                  width: 300,
                  height: 150,
                  effect: 'fall',
                  content: '<h1 style="text-align:center">下单成功,请耐心等待.</h1>'
              });
          }
          function showF() {
              $("#stantard-dialogBox").dialogBox({
                  title: '提示',
                  hasMask: true,
                  width: 300,
                  height: 150,
                  effect: 'fall',
                  content: '<h1 style="text-align:center">下单失败,或需要重新提交.</h1>'
              });
          }
          function showError() {
              $("#stantard-dialogBox").dialogBox({ 
                  title: '提示',
                  hasMask: true,
                  width: 400,
                  height: 150,
                  effect: 'fall',
                  content: '<h1 style="text-align:center">网络错误,请检查网络设备是否正常连接.</h1>'
              });
          }
      </script>