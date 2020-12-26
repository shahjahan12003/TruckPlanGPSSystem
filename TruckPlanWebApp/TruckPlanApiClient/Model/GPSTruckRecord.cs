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
    /// GPSTruckRecord
    /// </summary>
    [DataContract]
        public partial class GPSTruckRecord :  IEquatable<GPSTruckRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GPSTruckRecord" /> class.
        /// </summary>
        /// <param name="gpsDeviceID">gpsDeviceID (required).</param>
        /// <param name="recordDate">recordDate (required).</param>
        /// <param name="longitude">longitude (required).</param>
        /// <param name="userId">userId.</param>
        /// <param name="latitude">latitude (required).</param>
        /// <param name="countryName">countryName.</param>
        /// <param name="kilometer">kilometer.</param>
        /// <param name="processStatus">processStatus (default to false).</param>
        /// <param name="currentUser">currentUser.</param>
        /// <param name="id">id.</param>
        public GPSTruckRecord(string gpsDeviceID = default(string), DateTime? recordDate = default(DateTime?), double? longitude = default(double?), int? userId = default(int?), double? latitude = default(double?), string countryName = default(string), double? kilometer = default(double?), bool? processStatus = false, User currentUser = default(User), Guid? id = default(Guid?))
        {
            // to ensure "gpsDeviceID" is required (not null)
            if (gpsDeviceID == null)
            {
                throw new InvalidDataException("gpsDeviceID is a required property for GPSTruckRecord and cannot be null");
            }
            else
            {
                this.GpsDeviceID = gpsDeviceID;
            }
            // to ensure "recordDate" is required (not null)
            if (recordDate == null)
            {
                throw new InvalidDataException("recordDate is a required property for GPSTruckRecord and cannot be null");
            }
            else
            {
                this.RecordDate = recordDate;
            }
            // to ensure "longitude" is required (not null)
            if (longitude == null)
            {
                throw new InvalidDataException("longitude is a required property for GPSTruckRecord and cannot be null");
            }
            else
            {
                this.Longitude = longitude;
            }
            // to ensure "latitude" is required (not null)
            if (latitude == null)
            {
                throw new InvalidDataException("latitude is a required property for GPSTruckRecord and cannot be null");
            }
            else
            {
                this.Latitude = latitude;
            }
            this.UserId = userId;
            this.CountryName = countryName;
            this.Kilometer = kilometer;
            // use default value if no "processStatus" provided
            if (processStatus == null)
            {
                this.ProcessStatus = false;
            }
            else
            {
                this.ProcessStatus = processStatus;
            }
            this.CurrentUser = currentUser;
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets GpsDeviceID
        /// </summary>
        [DataMember(Name="gpsDeviceID", EmitDefaultValue=false)]
        public string GpsDeviceID { get; set; }

        /// <summary>
        /// Gets or Sets RecordDate
        /// </summary>
        [DataMember(Name="recordDate", EmitDefaultValue=false)]
        public DateTime? RecordDate { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets CountryName
        /// </summary>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or Sets Kilometer
        /// </summary>
        [DataMember(Name="kilometer", EmitDefaultValue=false)]
        public double? Kilometer { get; set; }

        /// <summary>
        /// Gets or Sets ProcessStatus
        /// </summary>
        [DataMember(Name="processStatus", EmitDefaultValue=false)]
        public bool? ProcessStatus { get; set; }

        /// <summary>
        /// Gets or Sets CurrentUser
        /// </summary>
        [DataMember(Name="currentUser", EmitDefaultValue=false)]
        public User CurrentUser { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GPSTruckRecord {\n");
            sb.Append("  GpsDeviceID: ").Append(GpsDeviceID).Append("\n");
            sb.Append("  RecordDate: ").Append(RecordDate).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  Kilometer: ").Append(Kilometer).Append("\n");
            sb.Append("  ProcessStatus: ").Append(ProcessStatus).Append("\n");
            sb.Append("  CurrentUser: ").Append(CurrentUser).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as GPSTruckRecord);
        }

        /// <summary>
        /// Returns true if GPSTruckRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of GPSTruckRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GPSTruckRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GpsDeviceID == input.GpsDeviceID ||
                    (this.GpsDeviceID != null &&
                    this.GpsDeviceID.Equals(input.GpsDeviceID))
                ) && 
                (
                    this.RecordDate == input.RecordDate ||
                    (this.RecordDate != null &&
                    this.RecordDate.Equals(input.RecordDate))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
                ) && 
                (
                    this.Kilometer == input.Kilometer ||
                    (this.Kilometer != null &&
                    this.Kilometer.Equals(input.Kilometer))
                ) && 
                (
                    this.ProcessStatus == input.ProcessStatus ||
                    (this.ProcessStatus != null &&
                    this.ProcessStatus.Equals(input.ProcessStatus))
                ) && 
                (
                    this.CurrentUser == input.CurrentUser ||
                    (this.CurrentUser != null &&
                    this.CurrentUser.Equals(input.CurrentUser))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.GpsDeviceID != null)
                    hashCode = hashCode * 59 + this.GpsDeviceID.GetHashCode();
                if (this.RecordDate != null)
                    hashCode = hashCode * 59 + this.RecordDate.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
                if (this.Kilometer != null)
                    hashCode = hashCode * 59 + this.Kilometer.GetHashCode();
                if (this.ProcessStatus != null)
                    hashCode = hashCode * 59 + this.ProcessStatus.GetHashCode();
                if (this.CurrentUser != null)
                    hashCode = hashCode * 59 + this.CurrentUser.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
