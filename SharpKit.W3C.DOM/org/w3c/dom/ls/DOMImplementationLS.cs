using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.ls
{

    using DOMException = org.w3c.dom.DOMException;

    public interface DOMImplementationLS
    {
        // DOMImplementationLS
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short MODE_SYNCHRONOUS = 1;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short MODE_ASYNCHRONOUS = 2;
//TODO:
//ORIGINAL LINE: public LSParser createLSParser(short mode, String schemaType) throws org.w3c.dom.DOMException;
        LSParser createLSParser(short mode, JsString schemaType);
        LSSerializer createLSSerializer();
        LSInput createLSInput();
        LSOutput createLSOutput();
    }

}