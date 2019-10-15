/* 
 * TextMagic API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2
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
using SwaggerDateConverter = TextMagicClient.Client.SwaggerDateConverter;

namespace TextMagicClient.Model
{
    /// <summary>
    /// UpdateSurveyCountryItem
    /// </summary>
    [DataContract]
    public partial class UpdateSurveyCountryItem :  IEquatable<UpdateSurveyCountryItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSurveyCountryItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateSurveyCountryItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSurveyCountryItem" /> class.
        /// </summary>
        /// <param name="country">Two-letter ISO country code (required).</param>
        /// <param name="userInboundId">User inbound phone ID (required).</param>
        public UpdateSurveyCountryItem(string country = default(string), int? userInboundId = default(int?))
        {
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for UpdateSurveyCountryItem and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            // to ensure "userInboundId" is required (not null)
            if (userInboundId == null)
            {
                throw new InvalidDataException("userInboundId is a required property for UpdateSurveyCountryItem and cannot be null");
            }
            else
            {
                this.UserInboundId = userInboundId;
            }
        }
        
        /// <summary>
        /// Two-letter ISO country code
        /// </summary>
        /// <value>Two-letter ISO country code</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// User inbound phone ID
        /// </summary>
        /// <value>User inbound phone ID</value>
        [DataMember(Name="userInboundId", EmitDefaultValue=false)]
        public int? UserInboundId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSurveyCountryItem {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  UserInboundId: ").Append(UserInboundId).Append("\n");
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
            return this.Equals(input as UpdateSurveyCountryItem);
        }

        /// <summary>
        /// Returns true if UpdateSurveyCountryItem instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSurveyCountryItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSurveyCountryItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.UserInboundId == input.UserInboundId ||
                    (this.UserInboundId != null &&
                    this.UserInboundId.Equals(input.UserInboundId))
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
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.UserInboundId != null)
                    hashCode = hashCode * 59 + this.UserInboundId.GetHashCode();
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