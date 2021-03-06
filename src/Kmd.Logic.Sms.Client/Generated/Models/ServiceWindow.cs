// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Sms.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ServiceWindow
    {
        /// <summary>
        /// Initializes a new instance of the ServiceWindow class.
        /// </summary>
        public ServiceWindow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceWindow class.
        /// </summary>
        public ServiceWindow(ServiceWindowTime fromTime, ServiceWindowTime toTime)
        {
            FromTime = fromTime;
            ToTime = toTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fromTime")]
        public ServiceWindowTime FromTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toTime")]
        public ServiceWindowTime ToTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FromTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FromTime");
            }
            if (ToTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ToTime");
            }
            if (FromTime != null)
            {
                FromTime.Validate();
            }
            if (ToTime != null)
            {
                ToTime.Validate();
            }
        }
    }
}
