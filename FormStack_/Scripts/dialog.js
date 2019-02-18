
  
<script src="https://code.jquery.com/jquery-1.12.4.js"></script>
<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    $("#field1").click(function () {
        openDialog("#field1");
    });
    $("#field2").click(function () {
        openDialog("#field2");
    });
    $("#field3").click(function () {
        openDialog("#field3");
    });

    function openDialog(id) {
        var name = $(id).attr("name");
    var desc = $(id).attr("desc");
        $("#dialog").dialog({
        title: name,
    text: desc
});

}
 

