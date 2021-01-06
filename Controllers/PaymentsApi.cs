/*
 * Car Workshop
 *
 * <h2> WILL BE UPDATED!</h2></br><b>Incomplete</b> API for car workshop system (lacks employees and parts management).</br><a href=\"https://app.swaggerhub.com/apis/soft_eng/project/0.1.1\">Swagger project (contains models)</a>.
 *
 * OpenAPI spec version: 0.1.1
 * Contact: k.baciejowski@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using se_project.Attributes;
using Microsoft.AspNetCore.Authorization;
using se_project.Models;

namespace se_project.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class PaymentsApiController : ControllerBase
    { 
        /// <summary>
        /// Read payment information
        /// </summary>
        
        /// <param name="visitId"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid visit id supplied</response>
        /// <response code="404">Visit not found</response>
        [HttpGet]
        [Route("/api/0.1.1/payment/{visitId}")]
        [ValidateModelState]
        [SwaggerOperation("PaymentVisitIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Payment), description: "Successful operation")]
        public virtual IActionResult PaymentVisitIdGet([FromRoute][Required]int? visitId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Payment));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "{\n  \"isFulfilled\" : false,\n  \"amount\" : 123.99,\n  \"advance\" : 0.0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Payment>(exampleJson)
            : default(Payment);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create/overwrite payment.
        /// </summary>
        
        /// <param name="visitId"></param>
        /// <param name="body"></param>
        /// <response code="400">Validation exception</response>
        /// <response code="404">Visit not found</response>
        [HttpPut]
        [Route("/api/0.1.1/payment/{visitId}")]
        [ValidateModelState]
        [SwaggerOperation("PaymentVisitIdPut")]
        public virtual IActionResult PaymentVisitIdPut([FromRoute][Required]int? visitId, [FromBody]Payment body)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }
    }
}