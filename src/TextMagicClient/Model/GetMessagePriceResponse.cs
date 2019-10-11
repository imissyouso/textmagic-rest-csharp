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
    /// GetMessagePriceResponse
    /// </summary>
    [DataContract]
    public partial class GetMessagePriceResponse :  IEquatable<GetMessagePriceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMessagePriceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetMessagePriceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMessagePriceResponse" /> class.
        /// </summary>
        /// <param name="total">Total price of the mesasge. (required).</param>
        /// <param name="parts">Message parts (multiples of 160 characters) count. (required).</param>
        /// <param name="countries">countries (required).</param>
        public GetMessagePriceResponse(decimal? total = default(decimal?), int? parts = default(int?), List<GetMessagePriceResponseCountriesItem> countries = default(List<GetMessagePriceResponseCountriesItem>))
        {
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new InvalidDataException("total is a required property for GetMessagePriceResponse and cannot be null");
            }
            else
            {
                this.Total = total;
            }
            // to ensure "parts" is required (not null)
            if (parts == null)
            {
                throw new InvalidDataException("parts is a required property for GetMessagePriceResponse and cannot be null");
            }
            else
            {
                this.Parts = parts;
            }
            // to ensure "countries" is required (not null)
            if (countries == null)
            {
                throw new InvalidDataException("countries is a required property for GetMessagePriceResponse and cannot be null");
            }
            else
            {
                this.Countries = countries;
            }
        }
        
        /// <summary>
        /// Total price of the mesasge.
        /// </summary>
        /// <value>Total price of the mesasge.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Message parts (multiples of 160 characters) count.
        /// </summary>
        /// <value>Message parts (multiples of 160 characters) count.</value>
        [DataMember(Name="parts", EmitDefaultValue=false)]
        public int? Parts { get; set; }

        /// <summary>
        /// Gets or Sets Countries
        /// </summary>
        [DataMember(Name="countries", EmitDefaultValue=false)]
        public List<GetMessagePriceResponseCountriesItem> Countries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetMessagePriceResponse {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Parts: ").Append(Parts).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
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
            return this.Equals(input as GetMessagePriceResponse);
        }

        /// <summary>
        /// Returns true if GetMessagePriceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMessagePriceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMessagePriceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Parts == input.Parts ||
                    (this.Parts != null &&
                    this.Parts.Equals(input.Parts))
                ) && 
                (
                    this.Countries == input.Countries ||
                    this.Countries != null &&
                    this.Countries.SequenceEqual(input.Countries)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Parts != null)
                    hashCode = hashCode * 59 + this.Parts.GetHashCode();
                if (this.Countries != null)
                    hashCode = hashCode * 59 + this.Countries.GetHashCode();
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
