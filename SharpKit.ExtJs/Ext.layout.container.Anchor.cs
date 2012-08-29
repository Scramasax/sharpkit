//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.layout.container
namespace Ext.layout.container
{
    #region Anchor
    /// <inheritdocs />
    /// <summary>
    /// <p>This is a layout that enables anchoring of contained elements relative to the container's dimensions.
    /// If the container is resized, all anchored items are automatically rerendered according to their
    /// <c><see cref="Ext.layout.container.AnchorConfig.anchor">anchor</see></c> rules.</p>
    /// <p>This class is intended to be extended or created via the <see cref="Ext.container.AbstractContainerConfig.layout">layout</see>: 'anchor'
    /// config, and should generally not need to be created directly via the new keyword.</p>
    /// <p>AnchorLayout does not have any direct config options (other than inherited ones). By default,
    /// AnchorLayout will calculate anchor measurements based on the size of the container itself. However, the
    /// container using the AnchorLayout can supply an anchoring-specific config property of <c>anchorSize</c>.</p>
    /// <p>If anchorSize is specifed, the layout will use it as a virtual container for the purposes of calculating
    /// anchor measurements based on it instead, allowing the container to be sized independently of the anchoring
    /// logic if necessary.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.panel.Panel">Ext.Panel</see>', {
    /// width: 500,
    /// height: 400,
    /// title: "AnchorLayout Panel",
    /// layout: 'anchor',
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// items: [
    /// {
    /// xtype: 'panel',
    /// title: '75% Width and 20% Height',
    /// anchor: '75% 20%'
    /// },
    /// {
    /// xtype: 'panel',
    /// title: 'Offset -300 Width &amp; -200 Height',
    /// anchor: '-300 -200'
    /// },
    /// {
    /// xtype: 'panel',
    /// title: 'Mixed Offset and Percent',
    /// anchor: '-250 20%'
    /// }
    /// ]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Anchor : Ext.layout.container.Container
    {
        /// <summary>
        /// This configuation option is to be applied to child items of a container managed by
        /// this layout (ie. configured with layout:'anchor').
        /// This value is what tells the layout how an item should be anchored to the container. <c>items</c>
        /// added to an AnchorLayout accept an anchoring-specific config property of <strong>anchor</strong> which is a string
        /// containing two values: the horizontal anchor value and the vertical anchor value (for example, '100% 50%').
        /// The following types of anchor values are supported:
        /// <li><p><strong>Percentage</strong> : Any value between 1 and 100, expressed as a percentage.</p>
        /// <p>The first anchor is the percentage width that the item should take up within the container, and the
        /// second is the percentage height.  For example:</p>
        /// <pre><code>// two values specified
        /// anchor: '100% 50%' // render item complete width of the container and
        /// // 1/2 height of the container
        /// // one value specified
        /// anchor: '100%'     // the width value; the height will default to auto
        /// </code></pre></li>
        /// <li><p><strong>Offsets</strong> : Any positive or negative integer value.</p>
        /// <p>This is a raw adjustment where the first anchor is the offset from the right edge of the container,
        /// and the second is the offset from the bottom edge. For example:</p>
        /// <pre><code>// two values specified
        /// anchor: '-50 -100' // render item the complete width of the container
        /// // minus 50 pixels and
        /// // the complete height minus 100 pixels.
        /// // one value specified
        /// anchor: '-50'      // anchor value is assumed to be the right offset value
        /// // bottom offset will default to 0
        /// </code></pre></li>
        /// <li><p><strong>Sides</strong> : Valid values are <c>right</c> (or <c>r</c>) and <c>bottom</c> (or <c>b</c>).</p>
        /// <p>Either the container must have a fixed size or an anchorSize config value defined at render time in
        /// order for these to have any effect.</p></li>
        /// <li><p><strong>Mixed</strong> :</p>
        /// <p>Anchor values can also be mixed as needed.  For example, to render the width offset from the container
        /// right edge by 50 pixels and 75% of the container's height use:</p>
        /// <pre><code>anchor:   '-50 75%'
        /// </code></pre></li>
        /// </summary>
        public JsString anchor;
        /// <summary>
        /// Default anchor for all child container items applied if no anchor or specific width is set on the child item.
        /// Defaults to: <c>&quot;100%&quot;</c>
        /// </summary>
        public JsString defaultAnchor;
        public Anchor(AnchorConfig config){}
        public Anchor(){}
        public Anchor(params object[] args){}
    }
    #endregion
    #region AnchorConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AnchorConfig : Ext.layout.container.ContainerConfig
    {
        /// <summary>
        /// This configuation option is to be applied to child items of a container managed by
        /// this layout (ie. configured with layout:'anchor').
        /// This value is what tells the layout how an item should be anchored to the container. <c>items</c>
        /// added to an AnchorLayout accept an anchoring-specific config property of <strong>anchor</strong> which is a string
        /// containing two values: the horizontal anchor value and the vertical anchor value (for example, '100% 50%').
        /// The following types of anchor values are supported:
        /// <li><p><strong>Percentage</strong> : Any value between 1 and 100, expressed as a percentage.</p>
        /// <p>The first anchor is the percentage width that the item should take up within the container, and the
        /// second is the percentage height.  For example:</p>
        /// <pre><code>// two values specified
        /// anchor: '100% 50%' // render item complete width of the container and
        /// // 1/2 height of the container
        /// // one value specified
        /// anchor: '100%'     // the width value; the height will default to auto
        /// </code></pre></li>
        /// <li><p><strong>Offsets</strong> : Any positive or negative integer value.</p>
        /// <p>This is a raw adjustment where the first anchor is the offset from the right edge of the container,
        /// and the second is the offset from the bottom edge. For example:</p>
        /// <pre><code>// two values specified
        /// anchor: '-50 -100' // render item the complete width of the container
        /// // minus 50 pixels and
        /// // the complete height minus 100 pixels.
        /// // one value specified
        /// anchor: '-50'      // anchor value is assumed to be the right offset value
        /// // bottom offset will default to 0
        /// </code></pre></li>
        /// <li><p><strong>Sides</strong> : Valid values are <c>right</c> (or <c>r</c>) and <c>bottom</c> (or <c>b</c>).</p>
        /// <p>Either the container must have a fixed size or an anchorSize config value defined at render time in
        /// order for these to have any effect.</p></li>
        /// <li><p><strong>Mixed</strong> :</p>
        /// <p>Anchor values can also be mixed as needed.  For example, to render the width offset from the container
        /// right edge by 50 pixels and 75% of the container's height use:</p>
        /// <pre><code>anchor:   '-50 75%'
        /// </code></pre></li>
        /// </summary>
        public JsString anchor;
        /// <summary>
        /// Default anchor for all child container items applied if no anchor or specific width is set on the child item.
        /// Defaults to: <c>&quot;100%&quot;</c>
        /// </summary>
        public JsString defaultAnchor;
        public AnchorConfig(params object[] args){}
    }
    #endregion
    #region AnchorEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AnchorEvents : Ext.layout.container.ContainerEvents
    {
        public AnchorEvents(params object[] args){}
    }
    #endregion
}
#endregion