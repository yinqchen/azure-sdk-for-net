// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The description of the DigitalTwins service. </summary>
    public partial class DigitalTwinsPatchDescription
    {
        /// <summary> Initializes a new instance of DigitalTwinsPatchDescription. </summary>
        public DigitalTwinsPatchDescription()
        {
        }

        /// <summary> Initializes a new instance of DigitalTwinsPatchDescription. </summary>
        /// <param name="tags"> Instance tags. </param>
        internal DigitalTwinsPatchDescription(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> Instance tags. </summary>
        public IDictionary<string, string> Tags { get; set; }
    }
}
