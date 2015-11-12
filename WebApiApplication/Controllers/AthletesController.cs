using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using WebApiApplication.Models;

namespace WebApiApplication.Controllers
{
    public class AthletesController : ApiController
    {
        /// <summary>
        /// Gets all athletes.
        /// </summary>
        /// <returns>A list of all athletes.</returns>
        [SwaggerResponse(HttpStatusCode.OK,
            Type = typeof(IEnumerable<Athlete>))]
        public IEnumerable<Athlete> Get()
        {
            return StaticStore.Athletes;
        }

        /// <summary>
        /// Retrieves a specific athlete.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The requested activity if found, otherwise nothing.</returns>
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "OK",
            Type = typeof(Activity))]
        [SwaggerResponse(HttpStatusCode.NotFound,
            Description = "Athlete not found")]
        [SwaggerOperation("GetAthleteById")]
        public Athlete Get([FromUri] int id)
        {
            return StaticStore.Athletes.Find(x => x.Id == id);
        }

        /// <summary>
        /// Creates a new athlete.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Created status if successful.</returns>
        [SwaggerResponse(HttpStatusCode.Created,
            Description = "Created")]
        public HttpResponseMessage Post([FromBody] Athlete value)
        {
            StaticStore.Athletes.Add(value);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        /// <summary>
        /// Deletes an athlete by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if athlete was successfully deleted, otherwise false.</returns>
        [HttpDelete]
        [SwaggerResponse(HttpStatusCode.OK,
            Description = "OK",
            Type = typeof(bool))]
        [SwaggerResponse(HttpStatusCode.NotFound,
            Description = "Athlete not found",
            Type = typeof(bool))]
        public HttpResponseMessage Delete([FromUri]int id)
        {
            var athleteToDelete = StaticStore.Athletes.Find(x => x.Id == id);

            if (athleteToDelete == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, false);
            }

            StaticStore.Athletes.Remove(athleteToDelete);
            return Request.CreateResponse(HttpStatusCode.OK, true);
        }
    }
}