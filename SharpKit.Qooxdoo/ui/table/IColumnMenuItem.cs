// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table
{
    /// <summary>
	/// <para>Interface for a column menu item corresponding to a table column.</para>
	/// </summary>
	public interface IColumnMenuItem
    {
		#region Events

		/// <summary>
		/// <para>Dispatched when a column changes visibility state. The event data is a
		/// boolean indicating whether the table column associated with this menu
		/// item is now visible.</para>
		/// </summary>
		event Action<qx.eventx.type.Data> ChangeVisibleEvent;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Whether the table column associated with this menu item is visible</para>
		/// </summary>
		object Visible { get; set; }

		#endregion Properties

		#region Methods

		/// <summary>
		/// <para>Returns the (computed) value of the property visible.</para>
		/// </summary>
		object GetVisible();

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property visible
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property visible.</param>
		void InitVisible(object value);

		/// <summary>
		/// <para>Resets the user value of the property visible.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		void ResetVisible();

		/// <summary>
		/// <para>Sets the user value of the property visible.</para>
		/// </summary>
		/// <param name="value">New value for property visible.</param>
		void SetVisible(object value);

		#endregion Methods
    }
}