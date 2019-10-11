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
    /// GetMessagePriceResponseCountriesItem
    /// </summary>
    [DataContract]
    public partial class GetMessagePriceResponseCountriesItem :  IEquatable<GetMessagePriceResponseCountriesItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMessagePriceResponseCountriesItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetMessagePriceResponseCountriesItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMessagePriceResponseCountriesItem" /> class.
        /// </summary>
        /// <param name="country">Two-letter ISO country code (required).</param>
        /// <param name="countryName">Country name (required).</param>
        /// <param name="allowDedicated">Is allow to use dedicated number (required).</param>
        /// <param name="count">Parts count to send (required).</param>
        /// <param name="max">Maximum parts to send (required).</param>
        /// <param name="sum">Total price to send (required).</param>
        /// <param name="landline">Is this landline number? (required).</param>
        public GetMessagePriceResponseCountriesItem(string country = default(string), string countryName = default(string), bool? allowDedicated = default(bool?), decimal? count = default(decimal?), decimal? max = default(decimal?), string sum = default(string), decimal? landline = default(decimal?))
        {
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for GetMessagePriceResponseCountriesItem and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            // to ensure "countryName" is required (not null)
            if (countryName == null)
            {
                throw new InvalidDataException("countryName is a required property for GetMessagePriceResponseCountriesItem and cannot be null");
            }
            else
            {
                this.CountryName = countryName;
            }
            // to ensure "allowDedicated" is required (not null)
            if (allowDedicated == null)
            {
                throw new InvalidDataException("allowDedicated is a required property for GetMessagePriceResponseCountriesItem and cannot be null");
            }
            else
            {
                this.AllowDedicated = allowDedicated;
            }
            // to ensure "count" is required (not null)
            if (count == null)
            {
                throw new InvalidDataException("count is a required property for GetMessagePriceResponseCountriesItem and cannot be null");
            }
            else
            {
                this.Count = count;
            }
            // to ensure "max" is required (not null)
            if (max == null)
            {
                throw new InvalidDataException("max is a required property for GetMessagePriceResponseCountriesItem and cannot be null");
            }
            else
            {
                this.Max = max;
            }
            // to ensure "sum" is required (not null)
            if (sum == null)
            {
                throw new InvalidDataException("sum is a required property for GetMessagePriceResponseCountriesItem and cannot be null");
            }
            else
            {
                this.Sum = sum;
            }
            // to ensure "landline" is required (not null)
            if (landline == null)
            {
                throw new InvalidDataException("landline is a required property for GetMessagePriceResponseCountriesItem and cannot be null");
            }
            else
            {
                this.Landline = landline;
            }
        }
        
        /// <summary>
        /// Two-letter ISO country code
        /// </summary>
        /// <value>Two-letter ISO country code</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        /// <value>Country name</value>
        [DataMember(Name="country_name", EmitDefaultValue=false)]
        public string CountryName { get; set; }

        /// <summary>
        /// Is allow to use dedicated number
        /// </summary>
        /// <value>Is allow to use dedicated number</value>
        [DataMember(Name="allow_dedicated", EmitDefaultValue=false)]
        public bool? AllowDedicated { get; set; }

        /// <summary>
        /// Parts count to send
        /// </summary>
        /// <value>Parts count to send</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public decimal? Count { get; set; }

        /// <summary>
        /// Maximum parts to send
        /// </summary>
        /// <value>Maximum parts to send</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public decimal? Max { get; set; }

        /// <summary>
        /// Total price to send
        /// </summary>
        /// <value>Total price to send</value>
        [DataMember(Name="sum", EmitDefaultValue=false)]
        public string Sum { get; set; }

        /// <summary>
        /// Is this landline number?
        /// </summary>
        /// <value>Is this landline number?</value>
        [DataMember(Name="landline", EmitDefaultValue=false)]
        public decimal? Landline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetMessagePriceResponseCountriesItem {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  AllowDedicated: ").Append(AllowDedicated).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
            sb.Append("  Landline: ").Append(Landline).Append("\n");
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
            return this.Equals(input as GetMessagePriceResponseCountriesItem);
        }

        /// <summary>
        /// Returns true if GetMessagePriceResponseCountriesItem instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMessagePriceResponseCountriesItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMessagePriceResponseCountriesItem input)
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
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
                ) && 
                (
                    this.AllowDedicated == input.AllowDedicated ||
                    (this.AllowDedicated != null &&
                    this.AllowDedicated.Equals(input.AllowDedicated))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this.Sum == input.Sum ||
                    (this.Sum != null &&
                    this.Sum.Equals(input.Sum))
                ) && 
                (
                    this.Landline == input.Landline ||
                    (this.Landline != null &&
                    this.Landline.Equals(input.Landline))
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
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
                if (this.AllowDedicated != null)
                    hashCode = hashCode * 59 + this.AllowDedicated.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Sum != null)
                    hashCode = hashCode * 59 + this.Sum.GetHashCode();
                if (this.Landline != null)
                    hashCode = hashCode * 59 + this.Landline.GetHashCode();
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
