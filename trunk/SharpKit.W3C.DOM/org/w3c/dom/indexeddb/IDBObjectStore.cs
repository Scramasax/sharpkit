//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.indexeddb
{

using SharpKit.JavaScript;
using DOMStringList = org.w3c.dom.DOMStringList;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class IDBObjectStore
{

	// IDBObjectStore
	public static short READ_WRITE = 0;
	public static short READ_ONLY = 1;
	public static short SNAPSHOT_READ = 2;
	public short mode {get;private set;}
	public string name {get;private set;}
	public string keyPath {get;private set;}
	public DOMStringList indexNames {get;private set;}
}

}