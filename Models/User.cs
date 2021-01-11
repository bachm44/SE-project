﻿/*
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
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace se_project.Models
{
    public enum UserType {
        WORKSHOP_EMPLOYEE,
        CLIENT,
        INSURANCE_EMPLOYEE,
        UNAUTHORIZED,
    }
    
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class User : IEquatable<User>
    {
        /// <summary>
        /// Gets or Sets GUID
        /// </summary>
        //[Required]
        [DataMember(Name="guid")]
        public string Guid { get; set; }
        
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [Key]
        [Required]
        [DataMember(Name="username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [Required]
        [DataMember(Name="password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [Required]
        [DataMember(Name="userType")]
        public UserType UserType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [Required]
        [DataMember(Name="surname")]
        public string Surname { get; set; }
        
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount")]
        public int Discount { get; set; }

        public virtual ICollection<EmployeeVisit> AssignedVisits { get; set; }

        /// <summary>
        /// Gets or Sets UserVisits
        /// </summary>
        public virtual ICollection<Visit> UserVisits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelUser {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  GUID: ").Append(Guid).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
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
            if (obj.GetType() != this.GetType()) return false;
            return Equals((User) obj);
        }

        /// <summary>
        /// Returns true if ModelUser instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Username == other.Username ||
                    Username != null &&
                    Username.Equals(other.Username)
                ) && 
                (
                    Password == other.Password ||
                    Password != null &&
                    Password.Equals(other.Password)
                ) && 
                (
                    Guid == other.Guid ||
                    Guid != null &&
                    Guid.Equals(other.Guid)
                ) && 
                (
                    UserType == other.UserType ||
                    UserType.Equals(other.UserType)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Surname == other.Surname ||
                    Surname != null &&
                    Surname.Equals(other.Surname)
                ) && 
                (
                    PhoneNumber == other.PhoneNumber ||
                    PhoneNumber != null &&
                    PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    Discount == other.Discount ||
                    Discount != null &&
                    Discount.Equals(other.Discount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Username, Password, Guid, UserType);
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(User left, User right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(User left, User right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
