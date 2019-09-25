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
    /// UpdateSurveyInputObject
    /// </summary>
    [DataContract]
    public partial class UpdateSurveyInputObject :  IEquatable<UpdateSurveyInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSurveyInputObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateSurveyInputObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSurveyInputObject" /> class.
        /// </summary>
        /// <param name="name">Survey name (required).</param>
        /// <param name="contacts">Array of contact resources id message will be sent to.</param>
        /// <param name="lists">Array of list resources id message will be sent to.</param>
        /// <param name="phones">Array of E.164 phone numbers message will be sent to.</param>
        /// <param name="country">Country values mapping (country &#x3D;&gt; inbound phone id), e.g. country[GB] &#x3D; \&quot;123\&quot;, country[US] &#x3D; \&quot;123\&quot;.</param>
        public UpdateSurveyInputObject(string name = default(string), string contacts = default(string), string lists = default(string), string phones = default(string), Object country = default(Object))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UpdateSurveyInputObject and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Contacts = contacts;
            this.Lists = lists;
            this.Phones = phones;
            this.Country = country;
        }
        
        /// <summary>
        /// Survey name
        /// </summary>
        /// <value>Survey name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Array of contact resources id message will be sent to
        /// </summary>
        /// <value>Array of contact resources id message will be sent to</value>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public string Contacts { get; set; }

        /// <summary>
        /// Array of list resources id message will be sent to
        /// </summary>
        /// <value>Array of list resources id message will be sent to</value>
        [DataMember(Name="lists", EmitDefaultValue=false)]
        public string Lists { get; set; }

        /// <summary>
        /// Array of E.164 phone numbers message will be sent to
        /// </summary>
        /// <value>Array of E.164 phone numbers message will be sent to</value>
        [DataMember(Name="phones", EmitDefaultValue=false)]
        public string Phones { get; set; }

        /// <summary>
        /// Country values mapping (country &#x3D;&gt; inbound phone id), e.g. country[GB] &#x3D; \&quot;123\&quot;, country[US] &#x3D; \&quot;123\&quot;
        /// </summary>
        /// <value>Country values mapping (country &#x3D;&gt; inbound phone id), e.g. country[GB] &#x3D; \&quot;123\&quot;, country[US] &#x3D; \&quot;123\&quot;</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public Object Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSurveyInputObject {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Lists: ").Append(Lists).Append("\n");
            sb.Append("  Phones: ").Append(Phones).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as UpdateSurveyInputObject);
        }

        /// <summary>
        /// Returns true if UpdateSurveyInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSurveyInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSurveyInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    (this.Contacts != null &&
                    this.Contacts.Equals(input.Contacts))
                ) && 
                (
                    this.Lists == input.Lists ||
                    (this.Lists != null &&
                    this.Lists.Equals(input.Lists))
                ) && 
                (
                    this.Phones == input.Phones ||
                    (this.Phones != null &&
                    this.Phones.Equals(input.Phones))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.Lists != null)
                    hashCode = hashCode * 59 + this.Lists.GetHashCode();
                if (this.Phones != null)
                    hashCode = hashCode * 59 + this.Phones.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
