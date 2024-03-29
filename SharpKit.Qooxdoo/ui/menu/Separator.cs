// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.menu
{
    /// <summary>
	/// <para>This widget draws a separator line between two instances of
	/// <see cref="qx.ui.menu.AbstractButton"/> and is inserted into the
	/// <see cref="qx.ui.menu.Menu"/>.</para>
	/// <para>For convenience reasons there is also
	/// a method <see cref="qx.ui.menu.Menu.AddSeparator"/> to append instances
	/// of this class to the menu.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.menu.Separator", OmitOptionalParameters = true, Export = false)]
    public partial class Separator : qx.ui.core.Widget
    {
		#region Properties

		/// <summary>
		/// <para>Whether the widget is anonymous.</para>
		/// <para>Anonymous widgets are ignored in the event hierarchy. This is useful
		/// for combined widgets where the internal structure do not have a custom
		/// appearance with a different styling from the element around. This is
		/// especially true for widgets like checkboxes or buttons where the text
		/// or icon are handled synchronously for state changes to the outer widget.</para>
		/// </summary>
		[JsProperty(Name = "anonymous", NativeField = true)]
		public bool Anonymous { get; set; }

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		#endregion Properties

		#region Methods

		public Separator() { throw new NotImplementedException(); }

		#endregion Methods
    }
}