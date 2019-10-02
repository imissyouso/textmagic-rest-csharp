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
    /// RequestSenderIdInputObject
    /// </summary>
    [DataContract]
    public partial class RequestSenderIdInputObject :  IEquatable<RequestSenderIdInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSenderIdInputObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestSenderIdInputObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSenderIdInputObject" /> class.
        /// </summary>
        /// <param name="senderId">Sender ID that you are applying for. *   11 characters maximum *   Only Latin based characters and digits are allowed *   Should contain at least one letter  (required).</param>
        /// <param name="explanation">Explanation why do you need this Sender ID. (required).</param>
        public RequestSenderIdInputObject(string senderId = default(string), string explanation = default(string))
        {
            // to ensure "senderId" is required (not null)
            if (senderId == null)
            {
                throw new InvalidDataException("senderId is a required property for RequestSenderIdInputObject and cannot be null");
            }
            else
            {
                this.SenderId = senderId;
            }
            // to ensure "explanation" is required (not null)
            if (explanation == null)
            {
                throw new InvalidDataException("explanation is a required property for RequestSenderIdInputObject and cannot be null");
            }
            else
            {
                this.Explanation = explanation;
            }
        }
        
        /// <summary>
        /// Sender ID that you are applying for. *   11 characters maximum *   Only Latin based characters and digits are allowed *   Should contain at least one letter 
        /// </summary>
        /// <value>Sender ID that you are applying for. *   11 characters maximum *   Only Latin based characters and digits are allowed *   Should contain at least one letter </value>
        [DataMember(Name="senderId", EmitDefaultValue=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// Explanation why do you need this Sender ID.
        /// </summary>
        /// <value>Explanation why do you need this Sender ID.</value>
        [DataMember(Name="explanation", EmitDefaultValue=false)]
        public string Explanation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestSenderIdInputObject {\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  Explanation: ").Append(Explanation).Append("\n");
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
            return this.Equals(input as RequestSenderIdInputObject);
        }

        /// <summary>
        /// Returns true if RequestSenderIdInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestSenderIdInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestSenderIdInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.Explanation == input.Explanation ||
                    (this.Explanation != null &&
                    this.Explanation.Equals(input.Explanation))
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
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.Explanation != null)
                    hashCode = hashCode * 59 + this.Explanation.GetHashCode();
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
