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
    /// UpdateSenderSettingInputObject
    /// </summary>
    [DataContract]
    public partial class UpdateSenderSettingInputObject :  IEquatable<UpdateSenderSettingInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSenderSettingInputObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateSenderSettingInputObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSenderSettingInputObject" /> class.
        /// </summary>
        /// <param name="value">Available phone number in international E.164 format or senderid. (required).</param>
        /// <param name="country">Country for which the setting will be set. (required).</param>
        /// <param name="chatId">Set sender setting for specified chat only..</param>
        public UpdateSenderSettingInputObject(string value = default(string), string country = default(string), int? chatId = default(int?))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for UpdateSenderSettingInputObject and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for UpdateSenderSettingInputObject and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            this.ChatId = chatId;
        }
        
        /// <summary>
        /// Available phone number in international E.164 format or senderid.
        /// </summary>
        /// <value>Available phone number in international E.164 format or senderid.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Country for which the setting will be set.
        /// </summary>
        /// <value>Country for which the setting will be set.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Set sender setting for specified chat only.
        /// </summary>
        /// <value>Set sender setting for specified chat only.</value>
        [DataMember(Name="chatId", EmitDefaultValue=false)]
        public int? ChatId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSenderSettingInputObject {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ChatId: ").Append(ChatId).Append("\n");
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
            return this.Equals(input as UpdateSenderSettingInputObject);
        }

        /// <summary>
        /// Returns true if UpdateSenderSettingInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSenderSettingInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSenderSettingInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.ChatId == input.ChatId ||
                    (this.ChatId != null &&
                    this.ChatId.Equals(input.ChatId))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.ChatId != null)
                    hashCode = hashCode * 59 + this.ChatId.GetHashCode();
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
