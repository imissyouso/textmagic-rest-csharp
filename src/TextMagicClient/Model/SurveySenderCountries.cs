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
    /// SurveySenderCountries
    /// </summary>
    [DataContract]
    public partial class SurveySenderCountries :  IEquatable<SurveySenderCountries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveySenderCountries" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SurveySenderCountries() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveySenderCountries" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="countryName">countryName (required).</param>
        /// <param name="fromNumber">fromNumber (required).</param>
        /// <param name="allowDedicated">allowDedicated (required).</param>
        public SurveySenderCountries(int? id = default(int?), string countryName = default(string), string fromNumber = default(string), bool? allowDedicated = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SurveySenderCountries and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "countryName" is required (not null)
            if (countryName == null)
            {
                throw new InvalidDataException("countryName is a required property for SurveySenderCountries and cannot be null");
            }
            else
            {
                this.CountryName = countryName;
            }
            // to ensure "fromNumber" is required (not null)
            if (fromNumber == null)
            {
                throw new InvalidDataException("fromNumber is a required property for SurveySenderCountries and cannot be null");
            }
            else
            {
                this.FromNumber = fromNumber;
            }
            // to ensure "allowDedicated" is required (not null)
            if (allowDedicated == null)
            {
                throw new InvalidDataException("allowDedicated is a required property for SurveySenderCountries and cannot be null");
            }
            else
            {
                this.AllowDedicated = allowDedicated;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets CountryName
        /// </summary>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or Sets FromNumber
        /// </summary>
        [DataMember(Name="fromNumber", EmitDefaultValue=false)]
        public string FromNumber { get; set; }

        /// <summary>
        /// Gets or Sets AllowDedicated
        /// </summary>
        [DataMember(Name="allowDedicated", EmitDefaultValue=false)]
        public bool? AllowDedicated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SurveySenderCountries {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  FromNumber: ").Append(FromNumber).Append("\n");
            sb.Append("  AllowDedicated: ").Append(AllowDedicated).Append("\n");
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
            return this.Equals(input as SurveySenderCountries);
        }

        /// <summary>
        /// Returns true if SurveySenderCountries instances are equal
        /// </summary>
        /// <param name="input">Instance of SurveySenderCountries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SurveySenderCountries input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
                ) && 
                (
                    this.FromNumber == input.FromNumber ||
                    (this.FromNumber != null &&
                    this.FromNumber.Equals(input.FromNumber))
                ) && 
                (
                    this.AllowDedicated == input.AllowDedicated ||
                    (this.AllowDedicated != null &&
                    this.AllowDedicated.Equals(input.AllowDedicated))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
                if (this.FromNumber != null)
                    hashCode = hashCode * 59 + this.FromNumber.GetHashCode();
                if (this.AllowDedicated != null)
                    hashCode = hashCode * 59 + this.AllowDedicated.GetHashCode();
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
