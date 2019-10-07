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
    /// Confirmation code to check
    /// </summary>
    [DataContract]
    public partial class CheckPhoneVerificationCodeInputObject :  IEquatable<CheckPhoneVerificationCodeInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckPhoneVerificationCodeInputObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckPhoneVerificationCodeInputObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckPhoneVerificationCodeInputObject" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        public CheckPhoneVerificationCodeInputObject(int? code = default(int?))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for CheckPhoneVerificationCodeInputObject and cannot be null");
            }
            else
            {
                this.Code = code;
            }
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int? Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckPhoneVerificationCodeInputObject {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as CheckPhoneVerificationCodeInputObject);
        }

        /// <summary>
        /// Returns true if CheckPhoneVerificationCodeInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckPhoneVerificationCodeInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckPhoneVerificationCodeInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
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
