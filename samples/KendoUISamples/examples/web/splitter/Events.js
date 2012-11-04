/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    $("#splitter").kendoSplitter( {orientation: "vertical", panes:  [ {collapsible: true, size: "100px"}, {collapsible: false, contentUrl: "../../content/web/splitter/ajax/ajaxContent1.html"}, {collapsible: true, size: "20%"}], expand: onExpand, collapse: onCollapse, contentLoad: onContentLoad, resize: onResize});
};
function onResize(e)
{
    kendoConsole.log("Resized :: Splitter <b>#" + this.element["0"].id + "</b>");
};
function onExpand(e)
{
    kendoConsole.log("Expanded :: Pane <b>#" + e.pane.id + "</b> from splitter <b>#" + this.element["0"].id + "</b> expanded");
};
function onCollapse(e)
{
    kendoConsole.log("Collapsed :: Pane <b>#" + e.pane.id + "</b> from splitter <b>#" + this.element["0"].id + "</b> collapsed");
};
function onContentLoad(e)
{
    kendoConsole.log("Content loaded in <b>#" + e.pane.id + "</b> and starts with <b>" + $(e.pane).text().substr(0, 20) + "...</b>");
};