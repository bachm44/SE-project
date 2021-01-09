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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace se_project.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponse200 : IEquatable<InlineResponse200>
    { 
        /// <summary>
        /// Gets or Sets LicensePlate
        /// </summary>
        [DataMember(Name="licensePlate")]
        public string LicensePlate { get; set; }

        /// <summary>
        /// Gets or Sets Visit
        /// </summary>
        [DataMember(Name="visit")]
        public Visit Visit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200 {\n");
            sb.Append("  LicensePlate: ").Append(LicensePlate).Append("\n");
            sb.Append("  Visit: ").Append(Visit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InlineResponse200)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse200 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse200 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LicensePlate == other.LicensePlate ||
                    LicensePlate != null &&
                    LicensePlate.Equals(other.LicensePlate)
                ) && 
                (
                    Visit == other.Visit ||
                    Visit != null &&
                    Visit.Equals(other.Visit)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (LicensePlate != null)
                    hashCode = hashCode * 59 + LicensePlate.GetHashCode();
                    if (Visit != null)
                    hashCode = hashCode * 59 + Visit.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse200 left, InlineResponse200 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse200 left, InlineResponse200 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
