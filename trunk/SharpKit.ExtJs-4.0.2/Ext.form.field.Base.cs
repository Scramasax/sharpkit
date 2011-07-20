//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.field
namespace Ext.form.field
{
    #region Base
    /// <summary>
    /// Base class for form fields that provides default event handling, rendering, and other common functionality
    /// needed by all form field types. Utilizes the Ext.form.field.Field mixin for value handling and validation,
    /// and the Ext.form.Labelable mixin to provide label and error message display. In most cases you will want to use a subclass, such as Ext.form.field.Text or Ext.form.field.Checkbox,
    /// rather than creating instances of this class directly. However if you are implementing a custom form field,
    /// using this as the parent class is recommended. Values and Conversions Because BaseField implements the Field mixin, it has a main value that can be initialized with the
    /// value config and manipulated via the getValue and setValue methods. This main
    /// value can be one of many data types appropriate to the current field, for instance a Date
    /// field would use a JavaScript Date object as its value type. However, because the field is rendered as a HTML
    /// input, this value data type can not always be directly used in the rendered field. Therefore BaseField introduces the concept of a &quot;raw value&quot;. This is the value of the rendered HTML input field,
    /// and is normally a String. The getRawValue and setRawValue methods can be used to directly
    /// work with the raw value, though it is recommended to use getValue and setValue in most cases. Conversion back and forth between the main value and the raw value is handled by the valueToRaw and
    /// rawToValue methods. If you are implementing a subclass that uses a non-String value data type, you
    /// should override these methods to handle the conversion. Rendering The content of the field body is defined by the fieldSubTpl XTemplate, with its argument data
    /// created by the getSubTplData method. Override this template and/or method to create custom
    /// field renderings.
    /// Example usage: // A simple subclass of BaseField that creates a HTML5 search field. Redirects to the
    /// // searchUrl when the Enter key is pressed.
    /// Ext.define(&#39;Ext.form.SearchField&#39;, {
    /// extend: &#39;Ext.form.field.Base&#39;,
    /// alias: &#39;widget.searchfield&#39;,
    /// inputType: &#39;search&#39;,
    /// // Config defining the search URL
    /// searchUrl: &#39;http://www.google.com/search?q={0}&#39;,
    /// // Add specialkey listener
    /// initComponent: function() {
    /// this.callParent();
    /// this.on(&#39;specialkey&#39;, this.checkEnterKey, this);
    /// },
    /// // Handle enter key presses, execute the search if the field has a value
    /// checkEnterKey: function(field, e) {
    /// var value = this.getValue();
    /// if (e.getKey() === e.ENTER &amp;amp;&amp;amp; !Ext.isEmpty(value)) {
    /// location.href = Ext.String.format(this.searchUrl, value);
    /// }
    /// }
    /// });
    /// Ext.create(&#39;Ext.form.Panel&#39;, {
    /// title: &#39;BaseField Example&#39;,
    /// bodyPadding: 5,
    /// width: 250,
    /// // Fields will be arranged vertically, stretched to full width
    /// layout: &#39;anchor&#39;,
    /// defaults: {
    /// anchor: &#39;100%&#39;
    /// },
    /// items: [{
    /// xtype: &#39;searchfield&#39;,
    /// fieldLabel: &#39;Search&#39;,
    /// name: &#39;query&#39;
    /// }]
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Base : Ext.Component, Labelable, Ext.form.field.Field, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// A utility for grouping a set of modifications which may trigger value changes into a single
        /// transaction, to prevent e...
        /// </summary>
        public object batchChanges(object fn){return null;}
        /// <summary>
        /// Checks whether the value of the field has changed since the last time it was checked. ...
        /// </summary>
        public object checkChange(){return null;}
        /// <summary>
        /// Checks the isDirty state of the field and if it has changed since the last time
        /// it was checked, fires the dirtychange...
        /// </summary>
        public object checkDirty(){return null;}
        /// <summary>
        /// Clear any invalid styles/messages for this field. ...
        /// </summary>
        public object clearInvalid(){return null;}
        /// <summary>
        /// Only relevant if the instance's isFileUpload method returns true. ...
        /// </summary>
        public HTMLInputElement extractFileInput(){return null;}
        /// <summary>
        /// Gets the active error message for this component, if any. ...
        /// </summary>
        public JsString getActiveError(){return null;}
        /// <summary>
        /// Gets an Array of any active error messages currently applied to the field. ...
        /// </summary>
        public JsArray getActiveErrors(){return null;}
        /// <summary>
        /// Calculate and return the natural width of the bodyEl. ...
        /// </summary>
        public object getBodyNaturalWidth(){return null;}
        /// <summary>
        /// Runs this field's validators and returns an array of error messages for any validation failures. ...
        /// </summary>
        public JsArray getErrors(object value){return null;}
        /// <summary>
        /// Returns the label for the field. ...
        /// </summary>
        public JsString getFieldLabel(){return null;}
        /// <summary>
        /// Returns the input id for this field. ...
        /// </summary>
        public JsString getInputId(){return null;}
        /// <summary>
        /// Generates the arguments for the field decorations rendering template. ...
        /// </summary>
        public object getLabelableRenderData(){return null;}
        /// <summary>
        /// Returns the additional Ext.AbstractComponent.renderSelectors for selecting the field
        /// decoration elements from the ren...
        /// </summary>
        public object getLabelableSelectors(){return null;}
        /// <summary>
        /// Returns the value(s) that should be saved to the Ext.data.Model instance for this field, when
        /// Ext.form.Basic.updateRe...
        /// </summary>
        public object getModelData(){return null;}
        /// <summary>
        /// Returns the name attribute of the field. ...
        /// </summary>
        public new JsString getName(){return null;}
        /// <summary>
        /// Returns the raw value of the field, without performing any normalization, conversion, or validation. ...
        /// </summary>
        public JsString getRawValue(){return null;}
        /// <summary>
        /// Creates and returns the data object to be used when rendering the fieldSubTpl. ...
        /// </summary>
        public object getSubTplData(){return null;}
        /// <summary>
        /// Gets the markup to be inserted into the outer template's bodyEl. ...
        /// </summary>
        public JsString getSubTplMarkup(){return null;}
        /// <summary>
        /// Returns the parameter(s) that would be included in a standard form submit for this field. ...
        /// </summary>
        public object getSubmitData(){return null;}
        /// <summary>
        /// Returns the value that would be included in a standard form submit for this field. ...
        /// </summary>
        public JsString getSubmitValue(){return null;}
        /// <summary>
        /// Returns the current data value of the field. ...
        /// </summary>
        public object getValue(){return null;}
        /// <summary>
        /// Tells whether the field currently has an active error message. ...
        /// </summary>
        public bool hasActiveError(){return false;}
        /// <summary>
        /// Initializes this Field mixin on the current instance. ...
        /// </summary>
        public object initField(){return null;}
        /// <summary>
        /// Performs initialization of this mixin. ...
        /// </summary>
        public object initLabelable(){return null;}
        /// <summary>
        /// Initializes the field's value based on the initial config. ...
        /// </summary>
        public object initValue(){return null;}
        /// <summary>
        /// Returns true if the value of this Field has been changed from its originalValue. ...
        /// </summary>
        public bool isDirty(){return false;}
        /// <summary>
        /// Returns whether two field values are logically equal. ...
        /// </summary>
        public bool isEqual(object value1, object value2){return false;}
        /// <summary>
        /// Returns whether this Field is a file upload field; if it returns true, forms will use
        /// special techniques for submitti...
        /// </summary>
        public bool isFileUpload(){return false;}
        /// <summary>
        /// Returns whether or not the field value is currently valid by
        /// validating the processed raw value
        /// of the field. ...
        /// </summary>
        public bool isValid(){return false;}
        /// <summary>
        /// Display one or more error messages associated with this field, using msgTarget to determine how to
        /// display the messag...
        /// </summary>
        public object markInvalid(object errors){return null;}
        /// <summary>
        /// Performs any necessary manipulation of a raw field value to prepare it for conversion
        /// and/or validation, for instance...
        /// </summary>
        public object processRawValue(object value){return null;}
        /// <summary>
        /// Converts a raw input field value into a mixed-type value that is suitable for this particular field type. ...
        /// </summary>
        public object rawToValue(object rawValue){return null;}
        /// <summary>
        /// Resets the current field value to the originally loaded value and clears any validation messages. ...
        /// </summary>
        public object reset(){return null;}
        /// <summary>
        /// Resets the field's originalValue property so it matches the current value. ...
        /// </summary>
        public object resetOriginalValue(){return null;}
        /// <summary>
        /// Sets the active error message to the given string. ...
        /// </summary>
        public object setActiveError(JsString msg){return null;}
        /// <summary>
        /// Set the active error message to an Array of error messages. ...
        /// </summary>
        public object setActiveErrors(JsArray errors){return null;}
        /// <summary>
        /// Applies a set of default configuration values to this Labelable instance. ...
        /// </summary>
        public object setFieldDefaults(object defaults){return null;}
        /// <summary>
        /// Set the CSS style of the field input element. ...
        /// </summary>
        public object setFieldStyle(object style){return null;}
        /// <summary>
        /// Sets the field's raw value directly, bypassing value conversion, change detection, and
        /// validation. ...
        /// </summary>
        public object setRawValue(object value){return null;}
        /// <summary>
        /// Sets the read only state of this field. ...
        /// </summary>
        public object setReadOnly(bool readOnly){return null;}
        /// <summary>
        /// Sets a data value into the field and runs the change detection and validation. ...
        /// </summary>
        public Ext.form.field.Field setValue(object value){return null;}
        /// <summary>
        /// Clears the active error message(s). ...
        /// </summary>
        public object unsetActiveError(){return null;}
        /// <summary>
        /// Returns whether or not the field value is currently valid by validating the
        /// field's current value, and fires the vali...
        /// </summary>
        public bool validate(){return false;}
        /// <summary>
        /// Uses getErrors to build an array of validation errors. ...
        /// </summary>
        public bool validateValue(object value){return false;}
        /// <summary>
        /// Converts a mixed-type value to a raw representation suitable for displaying in the field. ...
        /// </summary>
        public object valueToRaw(object value){return null;}
        /// <summary>
        /// The div Element wrapping the component's contents. ...
        /// </summary>
        public Ext.core.Element bodyEl{get;set;}
        /// <summary>
        /// The div Element that will contain the component's error message(s). ...
        /// </summary>
        public Ext.core.Element errorEl{get;set;}
        /// <summary>
        /// The input Element for this Field. ...
        /// </summary>
        public Ext.core.Element inputEl{get;set;}
        /// <summary>
        /// Flag denoting that this object is labelable as a field. ...
        /// </summary>
        public bool isFieldLabelable{get;set;}
        /// <summary>
        /// Flag denoting that this component is a Field. ...
        /// </summary>
        public bool isFormField{get;set;}
        /// <summary>
        /// The label Element for this component. ...
        /// </summary>
        public Ext.core.Element labelEl{get;set;}
        /// <summary>
        /// The original value of the field as configured in the value configuration, or as loaded by
        /// the last form load operatio...
        /// </summary>
        public object originalValue{get;set;}
        public Base(Ext.form.field.BaseConfig config){}
        public Base(){}
    }
    #endregion
    #region BaseConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class BaseConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// If specified, then the component will be displayed with this value as its active error when
        /// first rendered. ...
        /// </summary>
        public JsString activeError{get;set;}
        /// <summary>
        /// The template used to format the Array of error messages passed to setActiveErrors
        /// into a single HTML string. ...
        /// </summary>
        public XTemplate activeErrorsTpl{get;set;}
        /// <summary>
        /// Whether to adjust the component's body area to make room for 'side' or 'under'
        /// error messages. ...
        /// </summary>
        public bool autoFitErrors{get;set;}
        /// <summary>
        /// The CSS class to be applied to the body content element. ...
        /// </summary>
        public JsString baseBodyCls{get;set;}
        /// <summary>
        /// Defines a timeout in milliseconds for buffering checkChangeEvents that fire in rapid succession. ...
        /// </summary>
        public JsNumber checkChangeBuffer{get;set;}
        /// <summary>
        /// A list of event names that will be listened for on the field's input element, which
        /// will cause the field's value to b...
        /// </summary>
        public JsArray checkChangeEvents{get;set;}
        /// <summary>
        /// The CSS class to be applied to the special clearing div rendered directly after the field
        /// contents wrapper to provide...
        /// </summary>
        public JsString clearCls{get;set;}
        public JsString dirtyCls{get;set;}
        /// <summary>
        /// True to disable the field (defaults to false). ...
        /// </summary>
        public new bool disabled{get;set;}
        /// <summary>
        /// The CSS class to be applied to the error message element. ...
        /// </summary>
        public JsString errorMsgCls{get;set;}
        /// <summary>
        /// An extra CSS class to be applied to the body content element in addition to fieldBodyCls. ...
        /// </summary>
        public JsString fieldBodyCls{get;set;}
        public JsString fieldCls{get;set;}
        /// <summary>
        /// The label for the field. ...
        /// </summary>
        public JsString fieldLabel{get;set;}
        /// <summary>
        /// Optional CSS style(s) to be applied to the field input element. ...
        /// </summary>
        public JsString fieldStyle{get;set;}
        public JsString focusCls{get;set;}
        /// <summary>
        /// A CSS class to be applied to the outermost element to denote that it is participating in the form
        /// field layout. ...
        /// </summary>
        public JsString formItemCls{get;set;}
        /// <summary>
        /// When set to true, the label element (fieldLabel and labelSeparator) will be
        /// automatically hidden if the fieldLabel is...
        /// </summary>
        public bool hideEmptyLabel{get;set;}
        /// <summary>
        /// Set to true to completely hide the label element (fieldLabel and labelSeparator). ...
        /// </summary>
        public bool hideLabel{get;set;}
        /// <summary>
        /// The id that will be given to the generated input DOM element. ...
        /// </summary>
        public JsString inputId{get;set;}
        /// <summary>
        /// The type attribute for input fields -- e.g. ...
        /// </summary>
        public JsString inputType{get;set;}
        public JsString invalidCls{get;set;}
        /// <summary>
        /// The error text to use when marking a field invalid and no message is provided
        /// (defaults to 'The value in this field i...
        /// </summary>
        public JsString invalidText{get;set;}
        /// <summary>
        /// Controls the position and alignment of the fieldLabel. ...
        /// </summary>
        public JsString labelAlign{get;set;}
        /// <summary>
        /// The CSS class to be applied to the label element. ...
        /// </summary>
        public JsString labelCls{get;set;}
        /// <summary>
        /// The amount of space in pixels between the fieldLabel and the input field. ...
        /// </summary>
        public JsNumber labelPad{get;set;}
        public JsString labelSeparator{get;set;}
        /// <summary>
        /// A CSS style specification string to apply directly to this field's label. ...
        /// </summary>
        public JsString labelStyle{get;set;}
        /// <summary>
        /// The width of the fieldLabel in pixels. ...
        /// </summary>
        public JsNumber labelWidth{get;set;}
        /// <summary>
        /// The rendering template for the field decorations. ...
        /// </summary>
        public object labelableRenderTpl{get;set;}
        /// <summary>
        /// The location where the error message text should display. ...
        /// </summary>
        public JsString msgTarget{get;set;}
        /// <summary>
        /// The name of the field (defaults to undefined). ...
        /// </summary>
        public JsString name{get;set;}
        /// <summary>
        /// true to disable displaying any error message set on this object. ...
        /// </summary>
        public bool preventMark{get;set;}
        /// <summary>
        /// true to mark the field as readOnly in HTML
        /// (defaults to false). ...
        /// </summary>
        public bool readOnly{get;set;}
        public JsString readOnlyCls{get;set;}
        /// <summary>
        /// Setting this to false will prevent the field from being
        /// submitted even when it is not disabled. ...
        /// </summary>
        public bool submitValue{get;set;}
        /// <summary>
        /// The tabIndex for this field. ...
        /// </summary>
        public JsNumber tabIndex{get;set;}
        /// <summary>
        /// Whether the field should validate when it loses focus (defaults to true). ...
        /// </summary>
        public bool validateOnBlur{get;set;}
        /// <summary>
        /// Specifies whether this field should be validated immediately whenever a change in its value is detected. ...
        /// </summary>
        public bool validateOnChange{get;set;}
        public object value{get;set;}
    }
    #endregion
    #region BaseEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class BaseEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Fires when this field loses input focus. ...
        /// </summary>
        public static JsString blur="blur";
        /// <summary>
        /// Fires when a user-initiated change is detected in the value of the field. ...
        /// </summary>
        public static JsString change="change";
        /// <summary>
        /// Fires when a change in the field's isDirty state is detected. ...
        /// </summary>
        public static JsString dirtychange="dirtychange";
        /// <summary>
        /// Fires when the active error message is changed via setActiveError. ...
        /// </summary>
        public static JsString errorchange="errorchange";
        /// <summary>
        /// Fires when this field receives input focus. ...
        /// </summary>
        public static JsString focus="focus";
        /// <summary>
        /// Fires when any key related to navigation (arrows, tab, enter, esc, etc.) is pressed. ...
        /// </summary>
        public static JsString specialkey="specialkey";
        /// <summary>
        /// Fires when a change in the field's validity is detected. ...
        /// </summary>
        public static JsString validitychange="validitychange";
    }
    #endregion
}
#endregion
