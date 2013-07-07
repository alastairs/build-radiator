using Nancy;

namespace BuildRadiator.Web
{
    public class RadiatorModule : NancyModule
    {
        public RadiatorModule()
        {
            Get["/"] = ctxt => View["radiator.cshtml"];
        }
    }
}