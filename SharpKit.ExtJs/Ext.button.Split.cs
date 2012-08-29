//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.button
namespace Ext.button
{
    #region Split
    /// <inheritdocs />
    /// <summary>
    /// <p>A split button that provides a built-in dropdown arrow that can fire an event separately from the default click event
    /// of the button. Typically this would be used to display a dropdown menu that provides additional options to the
    /// primary button action, but any custom handler can provide the arrowclick implementation.  Example usage:</p>
    /// <pre><code>// display a dropdown menu:
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.button.Split">Ext.button.Split</see>', {
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// text: 'Options',
    /// // handle a click on the button itself
    /// handler: function() {
    /// alert("The button was clicked");
    /// },
    /// menu: new <see cref="Ext.menu.Menu">Ext.menu.Menu</see>({
    /// items: [
    /// // these will render as dropdown menu items when the arrow is clicked:
    /// {text: 'Item 1', handler: function(){ alert("Item 1 clicked"); }},
    /// {text: 'Item 2', handler: function(){ alert("Item 2 clicked"); }}
    /// ]
    /// })
    /// });
    /// </code></pre>
    /// <p>Instead of showing a menu, you can provide any type of custom functionality you want when the dropdown
    /// arrow is clicked:</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.button.Split">Ext.button.Split</see>', {
    /// renderTo: 'button-ct',
    /// text: 'Options',
    /// handler: optionsHandler,
    /// arrowHandler: myCustomHandler
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Split : Ext.button.Button
    {
        /// <summary>
        /// A function called when the arrow button is clicked (can be used instead of click event)
        /// </summary>
        public System.Delegate arrowHandler;
        /// <summary>
        /// The title attribute of the arrow
        /// </summary>
        public JsString arrowTooltip;
        /// <summary>
        /// Sets this button's arrow click handler.
        /// </summary>
        /// <param name="handler"><p>The function to call when the arrow is clicked</p>
        /// </param>
        /// <param name="scope"><p>Scope for the function passed above</p>
        /// </param>
        public void setArrowHandler(System.Delegate handler, object scope=null){}
        public Split(SplitConfig config){}
        public Split(){}
        public Split(params object[] args){}
    }
    #endregion
    #region SplitConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SplitConfig : Ext.button.ButtonConfig
    {
        /// <summary>
        /// A function called when the arrow button is clicked (can be used instead of click event)
        /// </summary>
        public System.Delegate arrowHandler;
        /// <summary>
        /// The title attribute of the arrow
        /// </summary>
        public JsString arrowTooltip;
        public SplitConfig(params object[] args){}
    }
    #endregion
    #region SplitEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SplitEvents : Ext.button.ButtonEvents
    {
        /// <summary>
        /// Fires when this button's arrow is clicked.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The click event</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void arrowclick(Split @this, object e, object eOpts){}
        public SplitEvents(params object[] args){}
    }
    #endregion
}
#endregion