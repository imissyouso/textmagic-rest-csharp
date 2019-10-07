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
    /// MessagesIcsParametersRecipients
    /// </summary>
    [DataContract]
    public partial class MessagesIcsParametersRecipients :  IEquatable<MessagesIcsParametersRecipients>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesIcsParametersRecipients" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagesIcsParametersRecipients() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesIcsParametersRecipients" /> class.
        /// </summary>
        /// <param name="contacts">contacts (required).</param>
        /// <param name="groups">groups (required).</param>
        /// <param name="numbers">numbers (required).</param>
        public MessagesIcsParametersRecipients(List<int?> contacts = default(List<int?>), List<int?> groups = default(List<int?>), List<string> numbers = default(List<string>))
        {
            // to ensure "contacts" is required (not null)
            if (contacts == null)
            {
                throw new InvalidDataException("contacts is a required property for MessagesIcsParametersRecipients and cannot be null");
            }
            else
            {
                this.Contacts = contacts;
            }
            // to ensure "groups" is required (not null)
            if (groups == null)
            {
                throw new InvalidDataException("groups is a required property for MessagesIcsParametersRecipients and cannot be null");
            }
            else
            {
                this.Groups = groups;
            }
            // to ensure "numbers" is required (not null)
            if (numbers == null)
            {
                throw new InvalidDataException("numbers is a required property for MessagesIcsParametersRecipients and cannot be null");
            }
            else
            {
                this.Numbers = numbers;
            }
        }
        
        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<int?> Contacts { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<int?> Groups { get; set; }

        /// <summary>
        /// Gets or Sets Numbers
        /// </summary>
        [DataMember(Name="numbers", EmitDefaultValue=false)]
        public List<string> Numbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagesIcsParametersRecipients {\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Numbers: ").Append(Numbers).Append("\n");
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
            return this.Equals(input as MessagesIcsParametersRecipients);
        }

        /// <summary>
        /// Returns true if MessagesIcsParametersRecipients instances are equal
        /// </summary>
        /// <param name="input">Instance of MessagesIcsParametersRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagesIcsParametersRecipients input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Numbers == input.Numbers ||
                    this.Numbers != null &&
                    this.Numbers.SequenceEqual(input.Numbers)
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
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Numbers != null)
                    hashCode = hashCode * 59 + this.Numbers.GetHashCode();
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
