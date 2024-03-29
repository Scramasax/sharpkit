//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.grid.property
{
    #region HeaderContainer
    /// <inheritdocs />
    /// <summary>
    /// <p>A custom HeaderContainer for the <see cref="Ext.grid.property.Grid">Ext.grid.property.Grid</see>.
    /// Generally it should not need to be used directly.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class HeaderContainer : Ext.grid.header.Container
    {
        /// <summary>
        /// Creates new HeaderContainer.
        /// </summary>
        /// <param name="grid"><p>The grid this store will be bound to</p>
        /// </param>
        /// <param name="source"><p>The source data config object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public HeaderContainer(Grid grid, object source){}
        public HeaderContainer(HeaderContainerConfig config){}
        public HeaderContainer(){}
        public HeaderContainer(params object[] args){}
    }
    #endregion
    #region HeaderContainerConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class HeaderContainerConfig : Ext.grid.header.ContainerConfig
    {
        public HeaderContainerConfig(params object[] args){}
    }
    #endregion
    #region HeaderContainerEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class HeaderContainerEvents : Ext.grid.header.ContainerEvents
    {
        public HeaderContainerEvents(params object[] args){}
    }
    #endregion
}
