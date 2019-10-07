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
    /// CreateSurveyNodeInputObject
    /// </summary>
    [DataContract]
    public partial class CreateSurveyNodeInputObject :  IEquatable<CreateSurveyNodeInputObject>, IValidatableObject
    {
        /// <summary>
        /// Node type. \\&#39;a\\&#39; answer; \\&#39;q\\&#39; - question
        /// </summary>
        /// <value>Node type. \\&#39;a\\&#39; answer; \\&#39;q\\&#39; - question</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NodeTypeEnum
        {
            
            /// <summary>
            /// Enum A for value: a
            /// </summary>
            [EnumMember(Value = "a")]
            A = 1,
            
            /// <summary>
            /// Enum Q for value: q
            /// </summary>
            [EnumMember(Value = "q")]
            Q = 2
        }

        /// <summary>
        /// Node type. \\&#39;a\\&#39; answer; \\&#39;q\\&#39; - question
        /// </summary>
        /// <value>Node type. \\&#39;a\\&#39; answer; \\&#39;q\\&#39; - question</value>
        [DataMember(Name="nodeType", EmitDefaultValue=false)]
        public NodeTypeEnum? NodeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSurveyNodeInputObject" /> class.
        /// </summary>
        /// <param name="nodeType">Node type. \\&#39;a\\&#39; answer; \\&#39;q\\&#39; - question.</param>
        /// <param name="label">Node label.</param>
        /// <param name="body">Node body.</param>
        /// <param name="startNode">Start node id.</param>
        /// <param name="sendDelay">Define delay for sending question to recipients after previous answer..</param>
        public CreateSurveyNodeInputObject(NodeTypeEnum? nodeType = default(NodeTypeEnum?), string label = default(string), string body = default(string), int? startNode = default(int?), int? sendDelay = default(int?))
        {
            this.NodeType = nodeType;
            this.Label = label;
            this.Body = body;
            this.StartNode = startNode;
            this.SendDelay = sendDelay;
        }
        

        /// <summary>
        /// Node label
        /// </summary>
        /// <value>Node label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Node body
        /// </summary>
        /// <value>Node body</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Start node id
        /// </summary>
        /// <value>Start node id</value>
        [DataMember(Name="startNode", EmitDefaultValue=false)]
        public int? StartNode { get; set; }

        /// <summary>
        /// Define delay for sending question to recipients after previous answer.
        /// </summary>
        /// <value>Define delay for sending question to recipients after previous answer.</value>
        [DataMember(Name="sendDelay", EmitDefaultValue=false)]
        public int? SendDelay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSurveyNodeInputObject {\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  StartNode: ").Append(StartNode).Append("\n");
            sb.Append("  SendDelay: ").Append(SendDelay).Append("\n");
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
            return this.Equals(input as CreateSurveyNodeInputObject);
        }

        /// <summary>
        /// Returns true if CreateSurveyNodeInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSurveyNodeInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSurveyNodeInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeType == input.NodeType ||
                    (this.NodeType != null &&
                    this.NodeType.Equals(input.NodeType))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.StartNode == input.StartNode ||
                    (this.StartNode != null &&
                    this.StartNode.Equals(input.StartNode))
                ) && 
                (
                    this.SendDelay == input.SendDelay ||
                    (this.SendDelay != null &&
                    this.SendDelay.Equals(input.SendDelay))
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
                if (this.NodeType != null)
                    hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.StartNode != null)
                    hashCode = hashCode * 59 + this.StartNode.GetHashCode();
                if (this.SendDelay != null)
                    hashCode = hashCode * 59 + this.SendDelay.GetHashCode();
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
