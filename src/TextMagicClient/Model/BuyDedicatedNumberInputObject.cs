/* 
 * TextMagic API Documentation
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2
 * Contact: support@textmagi.biz
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
    /// BuyDedicatedNumberInputObject
    /// </summary>
    [DataContract]
    public partial class BuyDedicatedNumberInputObject :  IEquatable<BuyDedicatedNumberInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuyDedicatedNumberInputObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuyDedicatedNumberInputObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuyDedicatedNumberInputObject" /> class.
        /// </summary>
        /// <param name="phone">Dedicated phone number. (required).</param>
        /// <param name="country">Country code phone number. (required).</param>
        /// <param name="userId">Assigned dedicated number. This number will be available for this account only. You cannot transfer numbers between sub-accounts.  (required).</param>
        public BuyDedicatedNumberInputObject(string phone = default(string), string country = default(string), int? userId = default(int?))
        {
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new InvalidDataException("phone is a required property for BuyDedicatedNumberInputObject and cannot be null");
            }
            else
            {
                this.Phone = phone;
            }
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for BuyDedicatedNumberInputObject and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for BuyDedicatedNumberInputObject and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
        }
        
        /// <summary>
        /// Dedicated phone number.
        /// </summary>
        /// <value>Dedicated phone number.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Country code phone number.
        /// </summary>
        /// <value>Country code phone number.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Assigned dedicated number. This number will be available for this account only. You cannot transfer numbers between sub-accounts. 
        /// </summary>
        /// <value>Assigned dedicated number. This number will be available for this account only. You cannot transfer numbers between sub-accounts. </value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuyDedicatedNumberInputObject {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as BuyDedicatedNumberInputObject);
        }

        /// <summary>
        /// Returns true if BuyDedicatedNumberInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of BuyDedicatedNumberInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuyDedicatedNumberInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
