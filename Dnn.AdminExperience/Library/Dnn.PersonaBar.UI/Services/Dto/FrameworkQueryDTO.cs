﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.PersonaBar.UI.Services.DTO
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class FrameworkQueryDTO
    {
        [DataMember(Name = "UpToDate")]
        public bool UpToDate { get; set; } = true;

        [DataMember(Name = "Version")]
        public string Version { get; set; } = string.Empty;

        [DataMember(Name = "Url")]
        public string Url { get; set; } = string.Empty;

        [DataMember(Name = "Critical")]
        public bool IsCritical { get; set; } = false;

        [DataMember(Name = "Published")]
        public DateTime Published { get; set; }
    }
}
