//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class HtmlButtonElement : HtmlElement
{

	// HTMLButtonElement
	public bool autofocus {get; set; }
	public bool disabled {get; set; }
	public HtmlFormElement form {get; private set; }
	public JsString formAction {get; set; }
	public JsString formEnctype {get; set; }
	public JsString formMethod {get; set; }
	public JsString formNoValidate {get; set; }
	public JsString formTarget {get; set; }
	public JsString name {get; set; }
	public JsString type {get; set; }
	public JsString value {get; set; }
	public bool willValidate {get; private set; }
	public ValidityState validity {get; private set; }
	public JsString validationMessage {get; private set; }
	public bool checkValidity() { return default(bool); }
	public void setCustomValidity(string error) {}
	public NodeList labels {get; private set; }
}

}