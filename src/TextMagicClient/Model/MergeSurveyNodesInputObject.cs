/* 
 * TextMagic API Documentation
 *
 * # Overview ## Introduction <img style=\"float: right; margin-left: 10px; width: 100px;\" src=\"images/phone.png\"> TextMagic SMS API is a platform for building your own messaging app using our messaging infrastructure. It allows you to send and receive SMS text messages, query information about inbound and outbound messages, manage contacts, create templates (i.e. message formats and static texts) and schedule recurrent SMS messages as well as process bulk SMS messages. <button name=\"button\" onclick=\"http://www.google.com\" class=\"btn\">Try TextMagic API for Free</button>  ### Two Ways to Use TextMagic API * [REST API](https://www.textmagic.com/docs/api/start/) – get full access to TextMagic’s messaging gateway features * [Email to SMS API](https://www.textmagic.com/docs/api/send-email-to-sms/) – set up two-way SMS communication without the need to write any additional code  ### Code Libraries We have created a set of client libraries for the most popular programming languages (such as REST API Java and REST API PHP). These libraries allow you to integrate our API into your code in minutes. Just choose your preferred language to get started:  ## Getting started Get Started with the TextMagic REST API To start sending text messages using the TextMagic REST API, just follow these steps: 1. Generate the API credentials 1. Connect to our API endpoint This page provides all the information you need to get started. Here, we explain the following steps:  How to obtain the API credentials The API endpoint How the REST API works The next step How to obtain the API credentials  ### How to obtain the API credentials To start sending text messages, you need to create an API key. API keys are similar to an account password; the difference is that an API key only provides access to the API: you cannot log in to TextMagic Online using the API key.  Your program sends the login credentials with each API request as HTTP headers: `X-TM-Username` is your TextMagic username, while `X-TM-Key` is your API key.  How to obtain an API key:  1. Log in to TextMagic (or start a free trial if you haven’t registered yet). 1. Go to the API settings page. 1. Click the Add new API key button. 1. Enter an app name for this key. Note, it’s just a label, so pick any name. 1. Click Generate new key. 1. You should now see your new API key in the green notification banner above the table:  ![alt text](images/credentials.png)  > Note for API v1 users > V1 keys are not compatible with the V2 version of the TextMagic REST API, so you will need to generate a new API key to use the V2 endpoint.  ### The API endpoint The TextMagic REST API endpoint is: ``` https://rest.textmagic.com/api/v2 ``` All the URLs referenced in this documentation should use this base URL.  ### How the REST API works REST APIs use the HTTP protocol to send and receive messages. REST messages are usually encoded as JSON documents and are an improvement over older methods such as the XML based SOAP protocol. REST APIs use the same set of methods that web browsers use: POST, GET, PUT or DELETE. These correspond to the CRUD operations: create, read, update and delete. Often, REST URIs provide direct CRUD access to entities or collections of entities, for example: http://api.foo.com/people. In this instance, to delete a person’s endpoint, you might simply call the endpoint DELETE http://api.foo.com/people/{id}. REST makes these types of operations simple.  > Example > > Let’s take the entity most often used in messaging: contacts. Imagine you want to perform operations on your contacts list: well, it’s only a matter of calling the following endpoints: > * GET /api/v2/contacts (get all of your contacts) > * GET /api/v2/contacts/{id} (get a specific contact) > * POST /api/v2/contacts (create a new contact) > * PUT /api/v2/contacts/{id} (update an existing contact) > * DELETE /api/v2/contacts/{id} (delete an existing contact) It’s that simple! In fact, that’s all you need to do to manage the contacts in your TextMagic account!  ## Sandbox Sandbox is a tool to test TextMagic REST API requests without the need to install any applications or write any code. Here, we explain the following details about Sandbox: * The credentials area * Command documentation * How it works  <a href=\"\">Go to TextMagic Sandbox</a>  ### The credentials area To make requests using your TextMagic account, you need to enter your account username and your API key into the corresponding fields. You may also Save them in your browser or press Clear to erase them.  ![alt text](images/sandbox.png) 
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
    /// MergeSurveyNodesInputObject
    /// </summary>
    [DataContract]
    public partial class MergeSurveyNodesInputObject :  IEquatable<MergeSurveyNodesInputObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeSurveyNodesInputObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MergeSurveyNodesInputObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeSurveyNodesInputObject" /> class.
        /// </summary>
        /// <param name="firstNode">First node id (required).</param>
        /// <param name="secondNode">Second node id (required).</param>
        public MergeSurveyNodesInputObject(int? firstNode = default(int?), int? secondNode = default(int?))
        {
            // to ensure "firstNode" is required (not null)
            if (firstNode == null)
            {
                throw new InvalidDataException("firstNode is a required property for MergeSurveyNodesInputObject and cannot be null");
            }
            else
            {
                this.FirstNode = firstNode;
            }
            // to ensure "secondNode" is required (not null)
            if (secondNode == null)
            {
                throw new InvalidDataException("secondNode is a required property for MergeSurveyNodesInputObject and cannot be null");
            }
            else
            {
                this.SecondNode = secondNode;
            }
        }
        
        /// <summary>
        /// First node id
        /// </summary>
        /// <value>First node id</value>
        [DataMember(Name="firstNode", EmitDefaultValue=false)]
        public int? FirstNode { get; set; }

        /// <summary>
        /// Second node id
        /// </summary>
        /// <value>Second node id</value>
        [DataMember(Name="secondNode", EmitDefaultValue=false)]
        public int? SecondNode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeSurveyNodesInputObject {\n");
            sb.Append("  FirstNode: ").Append(FirstNode).Append("\n");
            sb.Append("  SecondNode: ").Append(SecondNode).Append("\n");
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
            return this.Equals(input as MergeSurveyNodesInputObject);
        }

        /// <summary>
        /// Returns true if MergeSurveyNodesInputObject instances are equal
        /// </summary>
        /// <param name="input">Instance of MergeSurveyNodesInputObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeSurveyNodesInputObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstNode == input.FirstNode ||
                    (this.FirstNode != null &&
                    this.FirstNode.Equals(input.FirstNode))
                ) && 
                (
                    this.SecondNode == input.SecondNode ||
                    (this.SecondNode != null &&
                    this.SecondNode.Equals(input.SecondNode))
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
                if (this.FirstNode != null)
                    hashCode = hashCode * 59 + this.FirstNode.GetHashCode();
                if (this.SecondNode != null)
                    hashCode = hashCode * 59 + this.SecondNode.GetHashCode();
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
