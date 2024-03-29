//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region Filter
    /// <summary>
    /// Represents a filter that can be applied to a MixedCollection. Can either simply
    /// filter on a property/value pair or pass in a filter function with custom logic. Filters are always used in the context
    /// of MixedCollections, though Stores frequently create them when filtering and searching on their
    /// records. Example usage: //set up a fictional MixedCollection containing a few people to filter on
    /// var allNames = new Ext.util.MixedCollection();
    /// allNames.addAll([
    /// {id: 1, name: &#39;Ed&#39;,    age: 25},
    /// {id: 2, name: &#39;Jamie&#39;, age: 37},
    /// {id: 3, name: &#39;Abe&#39;,   age: 32},
    /// {id: 4, name: &#39;Aaron&#39;, age: 26},
    /// {id: 5, name: &#39;David&#39;, age: 32}
    /// ]);
    /// var ageFilter = new Ext.util.Filter({
    /// property: &#39;age&#39;,
    /// value   : 32
    /// });
    /// var longNameFilter = new Ext.util.Filter({
    /// filterFn: function(item) {
    /// return item.name.length &gt; 4;
    /// }
    /// });
    /// //a new MixedCollection with the 3 names longer than 4 characters
    /// var longNames = allNames.filter(longNameFilter);
    /// //a new MixedCollection with the 2 people of age 24:
    /// var youngFolk = allNames.filter(ageFilter);
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Filter
    {
        /// <summary>
        /// Creates new Filter. ...
        /// </summary>
        public Filter(object config=null){}
        public Filter(FilterConfig config){}
    }
    #endregion
    #region FilterConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class FilterConfig
    {
        /// <summary>
        /// True to allow any match - no regex start/end line anchors will be added. ...
        /// </summary>
        public bool anyMatch{get;set;}
        /// <summary>
        /// True to make the regex case sensitive (adds 'i' switch to regex). ...
        /// </summary>
        public bool caseSensitive{get;set;}
        /// <summary>
        /// True to force exact match (^ and $ characters added to the regex). ...
        /// </summary>
        public bool exactMatch{get;set;}
        /// <summary>
        /// A custom filter function which is passed each item in the Ext.util.MixedCollection
        /// in turn. ...
        /// </summary>
        public JsAction filterFn{get;set;}
        /// <summary>
        /// The property to filter on. ...
        /// </summary>
        public JsString property{get;set;}
        /// <summary>
        /// Optional root property. ...
        /// </summary>
        public JsString root{get;set;}
    }
    #endregion
    #region FilterEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class FilterEvents
    {
    }
    #endregion
}
#endregion
