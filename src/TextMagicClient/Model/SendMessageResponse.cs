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
    /// SendMessageResponse
    /// </summary>
    [DataContract]
    public partial class SendMessageResponse :  IEquatable<SendMessageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendMessageResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="href">href (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="sessionId">sessionId (required).</param>
        /// <param name="bulkId">bulkId (required).</param>
        /// <param name="messageId">messageId (required).</param>
        /// <param name="scheduleId">scheduleId (required).</param>
        /// <param name="chatId">chatId (required).</param>
        public SendMessageResponse(int? id = default(int?), string href = default(string), string type = default(string), int? sessionId = default(int?), int? bulkId = default(int?), int? messageId = default(int?), int? scheduleId = default(int?), int? chatId = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "href" is required (not null)
            if (href == null)
            {
                throw new InvalidDataException("href is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.Href = href;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "sessionId" is required (not null)
            if (sessionId == null)
            {
                throw new InvalidDataException("sessionId is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.SessionId = sessionId;
            }
            // to ensure "bulkId" is required (not null)
            if (bulkId == null)
            {
                throw new InvalidDataException("bulkId is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.BulkId = bulkId;
            }
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new InvalidDataException("messageId is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.MessageId = messageId;
            }
            // to ensure "scheduleId" is required (not null)
            if (scheduleId == null)
            {
                throw new InvalidDataException("scheduleId is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.ScheduleId = scheduleId;
            }
            // to ensure "chatId" is required (not null)
            if (chatId == null)
            {
                throw new InvalidDataException("chatId is a required property for SendMessageResponse and cannot be null");
            }
            else
            {
                this.ChatId = chatId;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public int? SessionId { get; set; }

        /// <summary>
        /// Gets or Sets BulkId
        /// </summary>
        [DataMember(Name="bulkId", EmitDefaultValue=false)]
        public int? BulkId { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public int? MessageId { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleId
        /// </summary>
        [DataMember(Name="scheduleId", EmitDefaultValue=false)]
        public int? ScheduleId { get; set; }

        /// <summary>
        /// Gets or Sets ChatId
        /// </summary>
        [DataMember(Name="chatId", EmitDefaultValue=false)]
        public int? ChatId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendMessageResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  BulkId: ").Append(BulkId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
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
            return this.Equals(input as SendMessageResponse);
        }

        /// <summary>
        /// Returns true if SendMessageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SendMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendMessageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.BulkId == input.BulkId ||
                    (this.BulkId != null &&
                    this.BulkId.Equals(input.BulkId))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.ScheduleId == input.ScheduleId ||
                    (this.ScheduleId != null &&
                    this.ScheduleId.Equals(input.ScheduleId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.BulkId != null)
                    hashCode = hashCode * 59 + this.BulkId.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.ScheduleId != null)
                    hashCode = hashCode * 59 + this.ScheduleId.GetHashCode();
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
