/*Generated by SharpKit 5 v4.28.5000*/
var Grid = null;
var LastSortHeader = null;
var LastSort = null;
var IsLastSortDescending = false;
function Load()
{
    var list=new Array({Name:"Shooki",Age:7,Description:"Hey",PhoneNumber:"234234"},{Name:"Booki",Age:23,Description:"You",PhoneNumber:"6546"},{Name:"Mooki",Age:54,Description:"What\'s",PhoneNumber:"1235"},{Name:"Looki",Age:13,Description:"Up",PhoneNumber:"27457"},{Name:"Tooki",Age:2,Description:"Dude",PhoneNumber:"9856587"},{Name:"Cookie",Age:8,Description:"Gotta",PhoneNumber:"4768"},{Name:"Rookie",Age:34,Description:"Minute",PhoneNumber:"4567456"},{Name:"Zooki",Age:45,Description:"For",PhoneNumber:"56464"},{Name:"Xooxi",Age:2,Description:"Me",PhoneNumber:"23452456"});
    Grid = (function()
    {
        var $v1=new SharpKitGridSample.Grid();
        $v1.Element = document.getElementById("MyGrid");
        return $v1;
    }).call(this);
    Grid.Render();
    for(var $i2=0,$l2=list.length,c=list[$i2];$i2 < $l2;$i2++,c = list[$i2])
    {
        var row={Element:Grid.CreateRowElement(document.getElementById("MyGridRowTemplate")),Data:c};
        var tr=$(row.Element);
        tr.find(".CellName").text(c.Name);
        tr.find(".CellPhoneNumber").text(c.PhoneNumber);
        tr.find(".CellAge").text(c.Age.toString());
        tr.find(".CellDescription").text(c.Description);
        Grid.AddRow(row);
    }
};
function SortBy(header,pe)
{
    $(LastSortHeader).removeClass("Sorted").removeClass("Descending");
    IsLastSortDescending = LastSort == pe && !IsLastSortDescending;
    LastSort = pe;
    LastSortHeader = header;
    $(LastSortHeader).addClass("Sorted");
    $(LastSortHeader).toggleClass("Descending",IsLastSortDescending);
    var rows=SharpKitGridSample.JsArrayExtensions.OrderBy(Grid.Rows,function(t)
    {
        return t.Data[pe];
    },IsLastSortDescending);
    Grid.DeleteAllRows();
    for(var $i3=0,$l3=rows.length,row=rows[$i3];$i3 < $l3;$i3++,row = rows[$i3])
        Grid.AddRow(row);
};
if(typeof(SharpKitGridSample) == "undefined")
    var SharpKitGridSample={};
SharpKitGridSample.JsArrayExtensions = function()
{
};
SharpKitGridSample.JsArrayExtensions.Compare = function(x,y)
{
    var xx=x;
    var yy=y;
    if(xx > yy)
        return 1;
    if(xx < yy)
        return -1;
    return 0;
};
SharpKitGridSample.JsArrayExtensions.CompareDesc = function(x,y)
{
    var xx=x;
    var yy=y;
    if(xx > yy)
        return -1;
    if(xx < yy)
        return 1;
    return 0;
};
SharpKitGridSample.JsArrayExtensions.OrderBy = function(array,selector,desc)
{
    var array2=array.slice(0);
    if(!desc)
        array2.sort(function(x,y)
        {
            return SharpKitGridSample.JsArrayExtensions.Compare(selector(x),selector(y));
        });
    else
        array2.sort(function(x,y)
        {
            return SharpKitGridSample.JsArrayExtensions.CompareDesc(selector(x),selector(y));
        });
    return array2;
};