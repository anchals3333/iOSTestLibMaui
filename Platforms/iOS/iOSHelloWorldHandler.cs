using System;

using Microsoft.Maui.Handlers;
using UIKit;
using iOSTestMauiLib.Controllers;


namespace iOSTestMauiLib.Platforms.iOS
{
    public partial class HelloWorldHandler : ViewHandler<CommonSHelloWorldController, UIView>
    {
        public HelloWorldHandler() : base(PropertyMapper) { }

        public static IPropertyMapper<CommonSHelloWorldController, HelloWorldHandler> PropertyMapper =
            new PropertyMapper<CommonSHelloWorldController, HelloWorldHandler>(ViewHandler.ViewMapper) { };

        protected override UIView CreatePlatformView()
        {
            return null;
            //var wrapper = new HelloWorldViewWrapper();
            //return wrapper.UiView;
        }
    }

}


