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
    public partial class Insurance : IEquatable<Insurance>
    { 
        /// <summary>
        /// Gets or Sets DateOfExpiry
        /// </summary>
        [Required]
        [DataMember(Name="dateOfExpiry")]
        public DateTime? DateOfExpiry { get; set; }

        /// <summary>
        /// Gets or Sets Coverage
        /// </summary>
        [Required]
        [DataMember(Name="coverage")]
        public int? Coverage { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum LiabilityInsuranceEnum for liability insurance
            /// </summary>
            [EnumMember(Value = "liability insurance")]
            LiabilityInsuranceEnum = 1,
            
            /// <summary>
            /// Enum ComprehensiveCoverEnum for comprehensive cover
            /// </summary>
            [EnumMember(Value = "comprehensive cover")]
            ComprehensiveCoverEnum = 2
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Required]
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Insurance {\n");
            sb.Append("  DateOfExpiry: ").Append(DateOfExpiry).Append("\n");
            sb.Append("  Coverage: ").Append(Coverage).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Insurance)obj);
        }

        /// <summary>
        /// Returns true if Insurance instances are equal
        /// </summary>
        /// <param name="other">Instance of Insurance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Insurance other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DateOfExpiry == other.DateOfExpiry ||
                    DateOfExpiry != null &&
                    DateOfExpiry.Equals(other.DateOfExpiry)
                ) && 
                (
                    Coverage == other.Coverage ||
                    Coverage != null &&
                    Coverage.Equals(other.Coverage)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
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
                    if (DateOfExpiry != null)
                    hashCode = hashCode * 59 + DateOfExpiry.GetHashCode();
                    if (Coverage != null)
                    hashCode = hashCode * 59 + Coverage.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Insurance left, Insurance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Insurance left, Insurance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
