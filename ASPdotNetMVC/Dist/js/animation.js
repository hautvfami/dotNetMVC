$(document).ready(()=>{
  handleScrollbar();
  handleSidebar();
})
function handleScrollbar(){
  $("#SuppressScrollX").perfectScrollbar();
  $("#12345678").perfectScrollbar();
}
function handleSidebar(){
  $("#minimizeSidebar").click(()=>{
    if($("body").attr('class')=="bootstrap-collapse perfect-scrollbar-on"){
      $("body").attr("class","bootstrap-collapse perfect-scrollbar-on sidebar-mini");
    }else{
    $("body").attr("class","bootstrap-collapse perfect-scrollbar-on");
    }
  });
}