/*
 * Cielo24
 *
 * The cielo24 Web Services Platform API allows developers to easily integrate transcription, captioning and keyword extraction into their applications without having to use a manual web portal.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: devs@cielo24.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = cielo24.Client.OpenAPIDateConverter;

namespace cielo24.Model
{
    /// <summary>
    /// AddMediaResponse
    /// </summary>
    [DataContract(Name = "AddMediaResponse")]
    public partial class AddMediaResponse : IEquatable<AddMediaResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddMediaResponse" /> class.
        /// </summary>
        /// <param name="taskId">taskId.</param>
        public AddMediaResponse(string taskId = default(string))
        {
            this.TaskId = taskId;
        }

        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name = "TaskId", EmitDefaultValue = false)]
        public string TaskId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddMediaResponse {\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddMediaResponse);
        }

        /// <summary>
        /// Returns true if AddMediaResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AddMediaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddMediaResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
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
                if (this.TaskId != null)
                {
                    hashCode = (hashCode * 59) + this.TaskId.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}