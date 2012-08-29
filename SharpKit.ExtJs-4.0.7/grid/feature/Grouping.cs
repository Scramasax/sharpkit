//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.feature
namespace Ext.grid.feature
{
    #region Grouping
    /// <summary>
    /// This feature allows to display the grid rows aggregated into groups as specified by the Ext.data.Store.groupers
    /// specified on the Store. The group will show the title for the group name and then the appropriate records for the group
    /// underneath. The groups can also be expanded and collapsed. Extra Events This feature adds several extra events that will be fired on the grid to interact with the groups:  groupclick groupdblclick groupcontextmenu groupexpand groupcollapse  Menu Augmentation This feature adds extra options to the grid column menu to provide the user with functionality to modify the grouping.
    /// This can be disabled by setting the enableGroupingMenu option. The option to disallow grouping from being turned off
    /// by thew user is enableNoGroups. Controlling Group Text The groupHeaderTpl is used to control the rendered title for each group. It can modified to customized
    /// the default display. Example Usage var groupingFeature = Ext.create(&#39;Ext.grid.feature.Grouping&#39;, {
    /// groupHeaderTpl: &#39;Group: {name} ({rows.length})&#39;, //print the number of items in the group
    /// startCollapsed: true // start all groups collapsed
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Grouping : Feature
    {
        public Grouping(GroupingConfig config){}
        public Grouping(){}
    }
    #endregion
    #region GroupingConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class GroupingConfig : FeatureConfig
    {
        public JsNumber depthToIndent{get;set;}
        public bool enableGroupingMenu{get;set;}
        public bool enableNoGroups{get;set;}
        public JsString groupByText{get;set;}
        /// <summary>
        /// Template snippet, this cannot be an actual template. ...
        /// </summary>
        public JsString groupHeaderTpl{get;set;}
        public bool hideGroupedHeader{get;set;}
        public JsString showGroupsText{get;set;}
        public bool startCollapsed{get;set;}
    }
    #endregion
    #region GroupingEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class GroupingEvents : FeatureEvents
    {
        /// <summary>
        /// ...
        /// </summary>
        public static JsString groupclick="groupclick";
        /// <summary>
        /// ...
        /// </summary>
        public static JsString groupcollapse="groupcollapse";
        /// <summary>
        /// ...
        /// </summary>
        public static JsString groupcontextmenu="groupcontextmenu";
        /// <summary>
        /// ...
        /// </summary>
        public static JsString groupdblclick="groupdblclick";
        /// <summary>
        /// ...
        /// </summary>
        public static JsString groupexpand="groupexpand";
    }
    #endregion
}
#endregion
