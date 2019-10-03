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
    /// If it was a **POST** or **PUT** request (and the **message** returned is &#x60;Validation Failed&#x60;), this field may contain **errors **that describe the errors grouped by the input parameter name. 
    /// </summary>
    [DataContract]
    public partial class BadRequestResponseErrors :  IEquatable<BadRequestResponseErrors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestResponseErrors" /> class.
        /// </summary>
        /// <param name="common">Array of messages with errors related to the entire request. For example, you did not specify either the **text** or **templateId** when [sending the message](/docs/api/send-sms/). .</param>
        /// <param name="fields">Associative array. The keys are the POST/PUT parameters names and the values are arrays with error messages for these parameters. .</param>
        public BadRequestResponseErrors(List<string> common = default(List<string>), Object fields = default(Object))
        {
            this.Common = common;
            this.Fields = fields;
        }
        
        /// <summary>
        /// Array of messages with errors related to the entire request. For example, you did not specify either the **text** or **templateId** when [sending the message](/docs/api/send-sms/). 
        /// </summary>
        /// <value>Array of messages with errors related to the entire request. For example, you did not specify either the **text** or **templateId** when [sending the message](/docs/api/send-sms/). </value>
        [DataMember(Name="common", EmitDefaultValue=false)]
        public List<string> Common { get; set; }

        /// <summary>
        /// Associative array. The keys are the POST/PUT parameters names and the values are arrays with error messages for these parameters. 
        /// </summary>
        /// <value>Associative array. The keys are the POST/PUT parameters names and the values are arrays with error messages for these parameters. </value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public Object Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BadRequestResponseErrors {\n");
            sb.Append("  Common: ").Append(Common).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as BadRequestResponseErrors);
        }

        /// <summary>
        /// Returns true if BadRequestResponseErrors instances are equal
        /// </summary>
        /// <param name="input">Instance of BadRequestResponseErrors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BadRequestResponseErrors input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Common == input.Common ||
                    this.Common != null &&
                    this.Common.SequenceEqual(input.Common)
                ) && 
                (
                    this.Fields == input.Fields ||
                    (this.Fields != null &&
                    this.Fields.Equals(input.Fields))
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
                if (this.Common != null)
                    hashCode = hashCode * 59 + this.Common.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
