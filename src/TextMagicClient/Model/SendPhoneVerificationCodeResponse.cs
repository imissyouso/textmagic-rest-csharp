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
    /// SendPhoneVerificationCodeResponse
    /// </summary>
    [DataContract]
    public partial class SendPhoneVerificationCodeResponse :  IEquatable<SendPhoneVerificationCodeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendPhoneVerificationCodeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendPhoneVerificationCodeResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendPhoneVerificationCodeResponse" /> class.
        /// </summary>
        /// <param name="verifyId">The ID of a verification request. This is required to finish the verification request in the next step. (required).</param>
        /// <param name="price">Amount of credit which will be deducted from your account balance when this verification is successfully completed. (required).</param>
        public SendPhoneVerificationCodeResponse(string verifyId = default(string), decimal? price = default(decimal?))
        {
            // to ensure "verifyId" is required (not null)
            if (verifyId == null)
            {
                throw new InvalidDataException("verifyId is a required property for SendPhoneVerificationCodeResponse and cannot be null");
            }
            else
            {
                this.VerifyId = verifyId;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for SendPhoneVerificationCodeResponse and cannot be null");
            }
            else
            {
                this.Price = price;
            }
        }
        
        /// <summary>
        /// The ID of a verification request. This is required to finish the verification request in the next step.
        /// </summary>
        /// <value>The ID of a verification request. This is required to finish the verification request in the next step.</value>
        [DataMember(Name="verifyId", EmitDefaultValue=false)]
        public string VerifyId { get; set; }

        /// <summary>
        /// Amount of credit which will be deducted from your account balance when this verification is successfully completed.
        /// </summary>
        /// <value>Amount of credit which will be deducted from your account balance when this verification is successfully completed.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendPhoneVerificationCodeResponse {\n");
            sb.Append("  VerifyId: ").Append(VerifyId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
            return this.Equals(input as SendPhoneVerificationCodeResponse);
        }

        /// <summary>
        /// Returns true if SendPhoneVerificationCodeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SendPhoneVerificationCodeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendPhoneVerificationCodeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VerifyId == input.VerifyId ||
                    (this.VerifyId != null &&
                    this.VerifyId.Equals(input.VerifyId))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
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
                if (this.VerifyId != null)
                    hashCode = hashCode * 59 + this.VerifyId.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
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
