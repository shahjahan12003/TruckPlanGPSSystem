/* 
 * API V2
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TruckPlanApiClient.Client.SwaggerDateConverter;

namespace TruckPlanApiClient.Model
{
    /// <summary>
    /// Body
    /// </summary>
    [DataContract]
        public partial class Body :  IEquatable<Body>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// </summary>
        /// <param name="grantType">grantType (required).</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="refreshToken">refreshToken.</param>
        /// <param name="scope">scope.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="clientSecret">clientSecret.</param>
        public Body(string grantType = default(string), string username = default(string), string password = default(string), string refreshToken = default(string), string scope = default(string), string clientId = default(string), string clientSecret = default(string))
        {
            // to ensure "grantType" is required (not null)
            if (grantType == null)
            {
                throw new InvalidDataException("grantType is a required property for Body and cannot be null");
            }
            else
            {
                this.GrantType = grantType;
            }
            this.Username = username;
            this.Password = password;
            this.RefreshToken = refreshToken;
            this.Scope = scope;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
        }
        
        /// <summary>
        /// Gets or Sets GrantType
        /// </summary>
        [DataMember(Name="grant_type", EmitDefaultValue=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name="client_secret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body {\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Body);
        }

        /// <summary>
        /// Returns true if Body instances are equal
        /// </summary>
        /// <param name="input">Instance of Body to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GrantType == input.GrantType ||
                    (this.GrantType != null &&
                    this.GrantType.Equals(input.GrantType))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
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
                int hashCode = 41;
                if (this.GrantType != null)
                    hashCode = hashCode * 59 + this.GrantType.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}