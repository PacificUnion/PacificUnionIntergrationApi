using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PacUnionFinancial.Intergration.WebApi.Models;
using System.Net.Http;
using System.Web.Http.Controllers;
using PacUnionFinancial.Intergration.WebApi.Controllers;
using System.Threading.Tasks;

namespace PacUnionFinancial.Intergration.WebApi.Tests.Controllers
{
    [TestClass]
    public class RoostifyWebHookControllerTest
    {
        [TestMethod]
        public async Task TestPost()
        {
            var notification = new RoostifyNotification
            {
                created = DateTime.Now,
                event_type = "application.created",
                id = "1234"
            };
            var content = new ObjectContent<RoostifyNotification>(notification, new System.Net.Http.Formatting.JsonMediaTypeFormatter());
            content.Headers.Add("Content-Disposition", "form-data");
            content.Headers.Add("X-Roostify-Signature", "test");

            var controllerContext = new HttpControllerContext
            {
                Request = new HttpRequestMessage
                {
                    Content = new MultipartContent { content },

                }

            };
            controllerContext.Request.Headers.Add("X-Roostify-Signature", "test");
            var controller = new RoostifyWebHookController();
            controller.ControllerContext = controllerContext;
            await controller.Post(notification);

        }
    }
}
