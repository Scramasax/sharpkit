/* Generated by SharpKit 5 v5.4.4 */

if (typeof(SharpKit) == "undefined")
    var SharpKit = {};
if (typeof(SharpKit.Html) == "undefined")
    SharpKit.Html = {};
SharpKit.Html.Extensions = function (){
};
SharpKit.Html.Extensions.Descendents = function (el){
    return new SharpKit.Html.HtmlElementEnumerator(el, true, false);
};
SharpKit.Html.Extensions.Children = function (el){
    return new SharpKit.Html.HtmlElementEnumerator(el, false, false);
};
SharpKit.Html.HtmlElementEnumerator = function (root, includeDescendents, includeSelf){
    this.IncludeDescendents = false;
    this.IncludeSelf = false;
    this._Current = null;
    this.Root = null;
    this.Stack = null;
    this.IncludeDescendents = includeDescendents;
    this.IncludeSelf = includeSelf;
    this.Root = root;
    if (this.IncludeDescendents){
        this.Stack =  [];
        this.Stack.push(this.Root);
    }
};
SharpKit.Html.HtmlElementEnumerator.prototype.get_Current = function (){
    return this._Current;
};
SharpKit.Html.HtmlElementEnumerator.prototype.Dispose = function (){
    this.Root = null;
    this._Current = null;
    this.Stack = null;
};
SharpKit.Html.HtmlElementEnumerator.prototype.MoveNext = function (){
    if (!this.IncludeDescendents){
        var node = this._Current;
        if (node == null)
            node = this.Root.firstChild;
        else
            node = node.nextSibling;
        while (node != null && node.nodeType != 1)
            node = node.nextSibling;
        this._Current = node;
        return this._Current != null;
    }
    else {
        var node = this._Current;
        if (node != null){
            node = node.nextSibling;
            while (node != null && this._Current.nodeType != 1)
                node = node.nextSibling;
        }
        while (node == null && this.Stack.length > 0){
            var parent = this.Stack.pop();
            node = parent.firstChild;
            while (node != null && node.nodeType != 1)
                node = node.nextSibling;
        }
        this._Current = node;
        if (this._Current == null)
            return false;
        this.Stack.push(this._Current);
        return true;
    }
};
SharpKit.Html.HtmlElementEnumerator.prototype.Reset = function (){
    if (this.IncludeDescendents){
        this.Stack =  [];
        this.Stack.push(this.Root);
    }
    this._Current = null;
};
SharpKit.Html.HtmlElementEnumerator.prototype.GetEnumerator = function (){
    return this;
};

