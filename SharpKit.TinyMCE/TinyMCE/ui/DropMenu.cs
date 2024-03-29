//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.ui
{
    /// <summary>
    /// This class is used to create drop menus, a drop menu can be a context menu, or a menu for a list box or a menu bar.
    /// </summary>
    [JsType(JsMode.Prototype, Name="tinymce.ui.DropMenu", Export=false)]
    public  partial class DropMenu
    {
        /// <summary>
        /// Adds a new menu, menu item or sub classes of them to the drop menu.
        /// </summary>
        /// <param name="o">Menu or menu item to add to the drop menu.</param>
        public SharpKit.TinyMCE.ui.Control add(SharpKit.TinyMCE.ui.Control o){return null;}
        public object addMenu(){return null;}
        public object addSeparator(){return null;}
        /// <summary>
        /// Collapses the menu, this will hide the menu and all menu items.
        /// </summary>
        /// <param name="d">Optional deep state. If this is set to true all children will be collapsed as well.</param>
        public object collapse(bool d){return null;}
        /// <summary>
        /// Created a new sub menu for the drop menu control.
        /// </summary>
        /// <param name="s">Optional name/value settings object.</param>
        public SharpKit.TinyMCE.ui.DropMenu createMenu(object s){return null;}
        /// <summary>
        /// Destroys the menu. This will remove the menu from the DOM and any events added to it etc.
        /// </summary>
        public object destroy(){return null;}
        /// <summary>
        /// Constructs a new drop menu control instance.
        /// </summary>
        /// <param name="id">Button control id for the button.</param>
        /// <param name="s">Optional name/value settings object.</param>
        public DropMenu(string id, object s){}
        public object expand(){return null;}
        public object hasMenus(){return null;}
        /// <summary>
        /// Hides the displayed menu.
        /// </summary>
        public object hideMenu(){return null;}
        public object isActive(){return null;}
        public object isCollapsed(){return null;}
        public object isDisabled(){return null;}
        public object isRendered(){return null;}
        public object isSelected(){return null;}
        public object postRender(){return null;}
        /// <summary>
        /// Removes a specific sub menu or menu item from the drop menu.
        /// </summary>
        /// <param name="o">Menu item or menu to remove from drop menu.</param>
        public SharpKit.TinyMCE.ui.Control remove(SharpKit.TinyMCE.ui.Control o){return null;}
        public object removeAll(){return null;}
        public object renderHTML(){return null;}
        /// <summary>
        /// Renders the specified menu node to the dom.
        /// </summary>
        public SharpKit.TinyMCE.dom.Element renderNode(){return null;}
        public object renderTo(){return null;}
        public object setActive(){return null;}
        public object setDisabled(){return null;}
        public object setSelected(){return null;}
        public object setState(){return null;}
        /// <summary>
        /// Displays the menu at the specified cordinate.
        /// </summary>
        /// <param name="x">Horizontal position of the menu.</param>
        /// <param name="y">Vertical position of the menu.</param>
        /// <param name="px">Optional parent X position used when menus are cascading.</param>
        public object showMenu(object x, object y, object px){return null;}
        /// <summary>
        /// Repaints the menu after new items have been added dynamically.
        /// </summary>
        public object update(){return null;}
    }
}
