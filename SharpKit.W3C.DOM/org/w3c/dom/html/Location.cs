//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class Location
{

	// Location
	public string href {get;set;}
	public void assign(string url) {}
	public void replace(string url) {}
	public void reload() {}
	public string protocol {get;set;}
	public string host {get;set;}
	public string hostname {get;set;}
	public string port {get;set;}
	public string pathname {get;set;}
	public string search {get;set;}
	public string hash {get;set;}
	public string resolveURL(string url) { return default(string); }
}

}