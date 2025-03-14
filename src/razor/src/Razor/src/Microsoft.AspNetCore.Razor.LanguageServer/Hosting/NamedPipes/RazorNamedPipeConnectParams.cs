﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System.Text.Json.Serialization;

namespace Microsoft.AspNetCore.Razor.LanguageServer.Hosting.NamedPipes;

internal class RazorNamedPipeConnectParams
{
    [JsonPropertyName("pipeName")]
    public required string PipeName { get; set; }
}
