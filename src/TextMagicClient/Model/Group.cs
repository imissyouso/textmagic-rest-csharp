/* 
 * TextMagic API Documentation
 *
 * # Overview ## Introduction 1 <img style=\"float: right; margin-left: 10px; width: 100px;\" src=\"images/phone.png\"> TextMagic SMS API is a platform for building your own messaging app using our messaging infrastructure. It allows you to send and receive SMS text messages, query information about inbound and outbound messages, manage contacts, create templates (i.e. message formats and static texts) and schedule recurrent SMS messages as well as process bulk SMS messages. <button name=\"button\" onclick=\"http://www.google.com\" class=\"btn\">Try TextMagic API for Free</button>  ### Two Ways to Use TextMagic API * [REST API](https://www.textmagic.com/docs/api/start/) – get full access to TextMagic’s messaging gateway features * [Email to SMS API](https://www.textmagic.com/docs/api/send-email-to-sms/) – set up two-way SMS communication without the need to write any additional code  ### Code Libraries We have created a set of client libraries for the most popular programming languages (such as REST API Java and REST API PHP). These libraries allow you to integrate our API into your code in minutes. Just choose your preferred language to get started:  ## Getting started Get Started with the TextMagic REST API To start sending text messages using the TextMagic REST API, just follow these steps: 1. Generate the API credentials 1. Connect to our API endpoint This page provides all the information you need to get started. Here, we explain the following steps:  How to obtain the API credentials The API endpoint How the REST API works The next step How to obtain the API credentials  ### How to obtain the API credentials To start sending text messages, you need to create an API key. API keys are similar to an account password; the difference is that an API key only provides access to the API: you cannot log in to TextMagic Online using the API key.  Your program sends the login credentials with each API request as HTTP headers: `X-TM-Username` is your TextMagic username, while `X-TM-Key` is your API key.  How to obtain an API key:  1. Log in to TextMagic (or start a free trial if you haven’t registered yet). 1. Go to the API settings page. 1. Click the Add new API key button. 1. Enter an app name for this key. Note, it’s just a label, so pick any name. 1. Click Generate new key. 1. You should now see your new API key in the green notification banner above the table:  ![alt text](images/credentials.png)  > Note for API v1 users > V1 keys are not compatible with the V2 version of the TextMagic REST API, so you will need to generate a new API key to use the V2 endpoint.  ### The API endpoint The TextMagic REST API endpoint is: ``` https://rest.textmagic.com/api/v2 ``` All the URLs referenced in this documentation should use this base URL.  ### How the REST API works REST APIs use the HTTP protocol to send and receive messages. REST messages are usually encoded as JSON documents and are an improvement over older methods such as the XML based SOAP protocol. REST APIs use the same set of methods that web browsers use: POST, GET, PUT or DELETE. These correspond to the CRUD operations: create, read, update and delete. Often, REST URIs provide direct CRUD access to entities or collections of entities, for example: http://api.foo.com/people. In this instance, to delete a person’s endpoint, you might simply call the endpoint DELETE http://api.foo.com/people/{id}. REST makes these types of operations simple.  > Example > > Let’s take the entity most often used in messaging: contacts. Imagine you want to perform operations on your contacts list: well, it’s only a matter of calling the following endpoints: > * GET /api/v2/contacts (get all of your contacts) > * GET /api/v2/contacts/{id} (get a specific contact) > * POST /api/v2/contacts (create a new contact) > * PUT /api/v2/contacts/{id} (update an existing contact) > * DELETE /api/v2/contacts/{id} (delete an existing contact) It’s that simple! In fact, that’s all you need to do to manage the contacts in your TextMagic account!  ## Sandbox Sandbox is a tool to test TextMagic REST API requests without the need to install any applications or write any code. Here, we explain the following details about Sandbox: * The credentials area * Command documentation * How it works  <a href=\"\">Go to TextMagic Sandbox</a>  ### The credentials area To make requests using your TextMagic account, you need to enter your account username and your API key into the corresponding fields. You may also Save them in your browser or press Clear to erase them.  ![alt text](images/sandbox.png) 
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
    /// Group
    /// </summary>
    [DataContract]
    public partial class Group :  IEquatable<Group>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Group() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="favorited">favorited (required).</param>
        /// <param name="membersCount">membersCount (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="service">service (required).</param>
        /// <param name="shared">shared (required).</param>
        /// <param name="avatar">avatar (required).</param>
        /// <param name="isDefault">isDefault (required).</param>
        public Group(int? id = default(int?), string name = default(string), string description = default(string), bool? favorited = default(bool?), int? membersCount = default(int?), User user = default(User), bool? service = default(bool?), bool? shared = default(bool?), GroupImage avatar = default(GroupImage), bool? isDefault = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Group and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Group and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for Group and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "favorited" is required (not null)
            if (favorited == null)
            {
                throw new InvalidDataException("favorited is a required property for Group and cannot be null");
            }
            else
            {
                this.Favorited = favorited;
            }
            // to ensure "membersCount" is required (not null)
            if (membersCount == null)
            {
                throw new InvalidDataException("membersCount is a required property for Group and cannot be null");
            }
            else
            {
                this.MembersCount = membersCount;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for Group and cannot be null");
            }
            else
            {
                this.User = user;
            }
            // to ensure "service" is required (not null)
            if (service == null)
            {
                throw new InvalidDataException("service is a required property for Group and cannot be null");
            }
            else
            {
                this.Service = service;
            }
            // to ensure "shared" is required (not null)
            if (shared == null)
            {
                throw new InvalidDataException("shared is a required property for Group and cannot be null");
            }
            else
            {
                this.Shared = shared;
            }
            // to ensure "avatar" is required (not null)
            if (avatar == null)
            {
                throw new InvalidDataException("avatar is a required property for Group and cannot be null");
            }
            else
            {
                this.Avatar = avatar;
            }
            // to ensure "isDefault" is required (not null)
            if (isDefault == null)
            {
                throw new InvalidDataException("isDefault is a required property for Group and cannot be null");
            }
            else
            {
                this.IsDefault = isDefault;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Favorited
        /// </summary>
        [DataMember(Name="favorited", EmitDefaultValue=false)]
        public bool? Favorited { get; set; }

        /// <summary>
        /// Gets or Sets MembersCount
        /// </summary>
        [DataMember(Name="membersCount", EmitDefaultValue=false)]
        public int? MembersCount { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public bool? Service { get; set; }

        /// <summary>
        /// Gets or Sets Shared
        /// </summary>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public bool? Shared { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public GroupImage Avatar { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Group {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Favorited: ").Append(Favorited).Append("\n");
            sb.Append("  MembersCount: ").Append(MembersCount).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
            return this.Equals(input as Group);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="input">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Favorited == input.Favorited ||
                    (this.Favorited != null &&
                    this.Favorited.Equals(input.Favorited))
                ) && 
                (
                    this.MembersCount == input.MembersCount ||
                    (this.MembersCount != null &&
                    this.MembersCount.Equals(input.MembersCount))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.Shared == input.Shared ||
                    (this.Shared != null &&
                    this.Shared.Equals(input.Shared))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    (this.IsDefault != null &&
                    this.IsDefault.Equals(input.IsDefault))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Favorited != null)
                    hashCode = hashCode * 59 + this.Favorited.GetHashCode();
                if (this.MembersCount != null)
                    hashCode = hashCode * 59 + this.MembersCount.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.Shared != null)
                    hashCode = hashCode * 59 + this.Shared.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
                if (this.IsDefault != null)
                    hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
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
