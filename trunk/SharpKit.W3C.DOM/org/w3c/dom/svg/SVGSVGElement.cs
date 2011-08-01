//AutoGenerated

namespace org.w3c.dom.svg
{

    using DOMException = org.w3c.dom.DOMException;
    using Element = org.w3c.dom.Element;
    using NodeList = org.w3c.dom.NodeList;
    using DocumentCSS = org.w3c.dom.css.DocumentCSS;
    using ViewCSS = org.w3c.dom.css.ViewCSS;
    using DocumentEvent = org.w3c.dom.events.DocumentEvent;

    public interface SVGSVGElement : SVGElement, SVGTests, SVGLangSpace, SVGExternalResourcesRequired, SVGStylable, SVGLocatable, SVGFitToViewBox, SVGZoomAndPan, org.w3c.dom.events.DocumentEvent, org.w3c.dom.css.ViewCSS, org.w3c.dom.css.DocumentCSS
    {
        // SVGSVGElement
        SVGAnimatedLength x {get;}
        SVGAnimatedLength y {get;}
        SVGAnimatedLength width {get;}
        SVGAnimatedLength height {get;}
        string contentScriptType {get;set;}
        string contentStyleType {get;set;}
        SVGRect viewport {get;}
        float pixelUnitToMillimeterX {get;}
        float pixelUnitToMillimeterY {get;}
        float screenPixelToMillimeterX {get;}
        float screenPixelToMillimeterY {get;}
        bool useCurrentView {get;set;}
        SVGViewSpec currentView {get;}
        float currentScale {get;set;}
        SVGPoint currentTranslate {get;}
        int suspendRedraw(int max_wait_milliseconds);
//TODO:
//ORIGINAL LINE: public void unsuspendRedraw(int suspend_handle_id) throws org.w3c.dom.DOMException;
        void unsuspendRedraw(int suspend_handle_id);
        void unsuspendRedrawAll();
        void forceRedraw();
        void pauseAnimations();
        void unpauseAnimations();
        bool animationsPaused();
        float currentTime {get;set;}
        NodeList getIntersectionList(SVGRect rect, SVGElement referenceElement);
        NodeList getEnclosureList(SVGRect rect, SVGElement referenceElement);
        bool checkIntersection(SVGElement element, SVGRect rect);
        bool checkEnclosure(SVGElement element, SVGRect rect);
        void deselectAll();
        SVGNumber createSVGNumber();
        SVGLength createSVGLength();
        SVGAngle createSVGAngle();
        SVGPoint createSVGPoint();
        SVGMatrix createSVGMatrix();
        SVGRect createSVGRect();
        SVGTransform createSVGTransform();
        SVGTransform createSVGTransformFromMatrix(SVGMatrix matrix);
        Element getElementById(string elementId);
    }

}