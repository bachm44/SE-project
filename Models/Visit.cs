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
    public partial class Visit : IEquatable<Visit>
    { 
        /// <summary>
        /// Gets or Sets VisitId
        /// </summary>
        [Required]
        [DataMember(Name="visitId")]
        public long? VisitId { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [Required]
        [DataMember(Name="date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Gets or Sets RequiredActions
        /// </summary>
        [DataMember(Name="requiredActions")]
        public List<string> RequiredActions { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum AtServiceEnum for atService
            /// </summary>
            [EnumMember(Value = "atService")]
            AtServiceEnum = 1,
            
            /// <summary>
            /// Enum RepairedEnum for repaired
            /// </summary>
            [EnumMember(Value = "repaired")]
            RepairedEnum = 2,
            
            /// <summary>
            /// Enum CheckedInEnum for checkedIn
            /// </summary>
            [EnumMember(Value = "checkedIn")]
            CheckedInEnum = 3
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or Sets AssignedEmployees
        /// </summary>
        [DataMember(Name="assignedEmployees")]
        public List<Employee> AssignedEmployees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Visit {\n");
            sb.Append("  VisitId: ").Append(VisitId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  RequiredActions: ").Append(RequiredActions).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AssignedEmployees: ").Append(AssignedEmployees).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Visit)obj);
        }

        /// <summary>
        /// Returns true if Visit instances are equal
        /// </summary>
        /// <param name="other">Instance of Visit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Visit other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    VisitId == other.VisitId ||
                    VisitId != null &&
                    VisitId.Equals(other.VisitId)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    Price == other.Price ||
                    Price != null &&
                    Price.Equals(other.Price)
                ) && 
                (
                    RequiredActions == other.RequiredActions ||
                    RequiredActions != null &&
                    RequiredActions.SequenceEqual(other.RequiredActions)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    AssignedEmployees == other.AssignedEmployees ||
                    AssignedEmployees != null &&
                    AssignedEmployees.SequenceEqual(other.AssignedEmployees)
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
                    if (VisitId != null)
                    hashCode = hashCode * 59 + VisitId.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
                    if (RequiredActions != null)
                    hashCode = hashCode * 59 + RequiredActions.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (AssignedEmployees != null)
                    hashCode = hashCode * 59 + AssignedEmployees.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Visit left, Visit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Visit left, Visit right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
