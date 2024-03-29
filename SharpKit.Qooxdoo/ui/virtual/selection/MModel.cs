// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.selection
{
    /// <summary>
	/// <para>Implements the different selection modes single, multi, additive and one
	/// selection with there drag and quick selection.</para>
	/// <para>Example how to use selection:</para>
	/// <code>
	/// var rawData = [];
	/// for (var i = 0; i < 2500; i++) {
	/// rawData[i] = "Item No " + i;
	/// }
	/// var model = qx.data.marshal.Json.createModel(rawData);
	/// var list = new qx.ui.list.List(model);
	/// // Pre-Select "Item No 20"
	/// list.getSelection().push(model.getItem(20));
	/// // log change selection
	/// list.getSelection().addListener("change", function(e) {
	/// this.debug("Selection: " + list.getSelection().getItem(0));
	/// }, this);
	/// </code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.selection.MModel", OmitOptionalParameters = true, Export = false)]
    public partial class MModel 
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Selection"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeSelection;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Enable drag selection (multi selection of items through
		/// dragging the mouse in pressed states).</para>
		/// <para>Only possible for the selection modes multi and additive</para>
		/// </summary>
		[JsProperty(Name = "dragSelection", NativeField = true)]
		public bool DragSelection { get; set; }

		/// <summary>
		/// <para>Enable quick selection mode, where no click is needed to change the selection.</para>
		/// <para>Only possible for the modes single and one.</para>
		/// </summary>
		[JsProperty(Name = "quickSelection", NativeField = true)]
		public bool QuickSelection { get; set; }

		/// <summary>
		/// <para>Current selected items</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: false
		/// </remarks>
		[JsProperty(Name = "selection", NativeField = true)]
		public qx.data.Array Selection { get; set; }

		/// <summary>
		/// <para>The selection mode to use.</para>
		/// <see cref="qx.ui.core.selection.Abstract.Mode"/></para>
		/// </summary>
		/// <remarks>
		/// Possible values: "single","multi","additive","one"
		/// </remarks>
		[JsProperty(Name = "selectionMode", NativeField = true)]
		public object SelectionMode { get; set; }

		#endregion Properties

		#region Methods

		public MModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property dragSelection.</para>
		/// </summary>
		[JsMethod(Name = "getDragSelection")]
		public bool GetDragSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property quickSelection.</para>
		/// </summary>
		[JsMethod(Name = "getQuickSelection")]
		public bool GetQuickSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property selection.</para>
		/// </summary>
		[JsMethod(Name = "getSelection")]
		public qx.data.Array GetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property selectionMode.</para>
		/// </summary>
		[JsMethod(Name = "getSelectionMode")]
		public object GetSelectionMode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property dragSelection
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property dragSelection.</param>
		[JsMethod(Name = "initDragSelection")]
		public void InitDragSelection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property quickSelection
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property quickSelection.</param>
		[JsMethod(Name = "initQuickSelection")]
		public void InitQuickSelection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property selection
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property selection.</param>
		[JsMethod(Name = "initSelection")]
		public void InitSelection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property selectionMode
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property selectionMode.</param>
		[JsMethod(Name = "initSelectionMode")]
		public void InitSelectionMode(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property dragSelection equals true.</para>
		/// </summary>
		[JsMethod(Name = "isDragSelection")]
		public void IsDragSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property quickSelection equals true.</para>
		/// </summary>
		[JsMethod(Name = "isQuickSelection")]
		public void IsQuickSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property dragSelection.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDragSelection")]
		public void ResetDragSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property quickSelection.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetQuickSelection")]
		public void ResetQuickSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property selection.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSelection")]
		public void ResetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property selectionMode.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSelectionMode")]
		public void ResetSelectionMode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property dragSelection.</para>
		/// </summary>
		/// <param name="value">New value for property dragSelection.</param>
		[JsMethod(Name = "setDragSelection")]
		public void SetDragSelection(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property quickSelection.</para>
		/// </summary>
		/// <param name="value">New value for property quickSelection.</param>
		[JsMethod(Name = "setQuickSelection")]
		public void SetQuickSelection(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property selection.</para>
		/// </summary>
		/// <param name="value">New value for property selection.</param>
		[JsMethod(Name = "setSelection")]
		public void SetSelection(qx.data.Array value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property selectionMode.</para>
		/// </summary>
		/// <param name="value">New value for property selectionMode.</param>
		[JsMethod(Name = "setSelectionMode")]
		public void SetSelectionMode(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property dragSelection.</para>
		/// </summary>
		[JsMethod(Name = "toggleDragSelection")]
		public void ToggleDragSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property quickSelection.</para>
		/// </summary>
		[JsMethod(Name = "toggleQuickSelection")]
		public void ToggleQuickSelection() { throw new NotImplementedException(); }

		#endregion Methods
    }
}