$(document).ready(function () {
  custom_size();
  $(window).resize(function () {
    custom_size()
  })
  loginProcess();
})

function loginProcess() {
  $("#btn-login").click(function(){
    if ($("#email").val() == "admin@gmail.com" && $("#password").val() == "admin") {
      $(location).attr('href', 'users/Home.html');
    }
  })
}

function custom_size() {
  if ($(document).width() < 500) {
    $(".left-box").attr("style", "display:none;");
    $(".right-box").attr("style", "display: flex; height:100vh");
  } else {
    $(".left-box").attr("style", "");
    $(".right-box").attr("style", "");
  }
}