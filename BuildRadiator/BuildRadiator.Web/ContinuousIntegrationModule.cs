using System.Collections.Generic;
using System.Linq;
using Nancy;
using TeamCitySharp;
using TeamCitySharp.DomainEntities;

namespace BuildRadiator.Web
{
    public class ContinuousIntegrationModule : NancyModule
    {
        public ContinuousIntegrationModule() : base("/build")
        {
            Get["/projects"] = _ => string.Join("<br />", GetTeamCityProjects().Select(p => p.Name));
        }

        private IEnumerable<Project> GetTeamCityProjects()
        {
            var client = new TeamCityClient("");
            client.Connect(string.Empty, string.Empty, actAsGuest: true);
            return client.AllProjects();
        }
    }
}