using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using WebApiApplication.Models;

namespace WebApiApplication.Controllers
{
    public class ActivitiesController : ApiController
    {
        /// <summary>
        /// Gets all activities.
        /// </summary>
        /// <returns>A list of all acivities.</returns>
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(IEnumerable<Activity>))]
        public IEnumerable<Activity> Get()
        {
            return StaticStore.Activities;
        }

        /// <summary>
        /// Retrieves a specific activity.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The requested activity if found, otherwise nothing.</returns>
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "OK",
            Type = typeof(Activity))]
        [SwaggerResponse(HttpStatusCode.NotFound,
            Description = "Activity not found")]
        [SwaggerOperation("GetActivityById")]
        public Activity Get([FromUri] int id)
        {
            return StaticStore.Activities.Find(x => x.Id == id);
        }

        /// <summary>
        /// Creates a new activity.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Created status if successful.</returns>
        [SwaggerResponse(HttpStatusCode.Created,
            Description = "Created")]
        public HttpResponseMessage Post([FromBody] Activity value)
        {
            StaticStore.Activities.Add(value);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        /// <summary>
        /// Deletes an activity by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if activity was successfully deleted, otherwise false.</returns>
        [HttpDelete]
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "OK",
            Type = typeof(bool))]
        [SwaggerResponse(HttpStatusCode.NotFound,
            Description = "Activity not found",
            Type = typeof(bool))]
        public HttpResponseMessage Delete([FromUri]int id)
        {
            var activityToDelete = StaticStore.Activities.Find(x => x.Id == id);

            if (activityToDelete == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, false);
            }

            StaticStore.Activities.Remove(activityToDelete);
            return Request.CreateResponse(HttpStatusCode.OK, true);
        }
    }
}