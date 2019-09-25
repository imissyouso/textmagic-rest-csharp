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
    /// GetSurveyNodesResponse
    /// </summary>
    [DataContract]
    public partial class GetSurveyNodesResponse :  IEquatable<GetSurveyNodesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSurveyNodesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSurveyNodesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSurveyNodesResponse" /> class.
        /// </summary>
        /// <param name="nodes">nodes (required).</param>
        /// <param name="rows">rows (required).</param>
        public GetSurveyNodesResponse(Object nodes = default(Object), Object rows = default(Object))
        {
            // to ensure "nodes" is required (not null)
            if (nodes == null)
            {
                throw new InvalidDataException("nodes is a required property for GetSurveyNodesResponse and cannot be null");
            }
            else
            {
                this.Nodes = nodes;
            }
            // to ensure "rows" is required (not null)
            if (rows == null)
            {
                throw new InvalidDataException("rows is a required property for GetSurveyNodesResponse and cannot be null");
            }
            else
            {
                this.Rows = rows;
            }
        }
        
        /// <summary>
        /// Gets or Sets Nodes
        /// </summary>
        [DataMember(Name="nodes", EmitDefaultValue=false)]
        public Object Nodes { get; set; }

        /// <summary>
        /// Gets or Sets Rows
        /// </summary>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public Object Rows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSurveyNodesResponse {\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
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
            return this.Equals(input as GetSurveyNodesResponse);
        }

        /// <summary>
        /// Returns true if GetSurveyNodesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSurveyNodesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSurveyNodesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nodes == input.Nodes ||
                    (this.Nodes != null &&
                    this.Nodes.Equals(input.Nodes))
                ) && 
                (
                    this.Rows == input.Rows ||
                    (this.Rows != null &&
                    this.Rows.Equals(input.Rows))
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
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
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
