/*@Generated by SharpKit v4.23.5000*/
function jQueryEventsSample_Load()
{
    $("#button1").click(function(e)
    {
        $(this).text("I have been clicked!");
    });
    alert("Button click was bound");
}
