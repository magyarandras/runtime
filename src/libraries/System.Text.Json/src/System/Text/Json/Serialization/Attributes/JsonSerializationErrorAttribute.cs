// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Text.Json.Serialization
{

    /// <summary>
    /// Specifies a custom JSON serialization error message
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class JsonSerializationErrorAttribute : JsonAttribute
    {
        /// <summary>
        /// The serialization error message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="JsonSerializationErrorAttribute"/>.
        /// </summary>
        public JsonSerializationErrorAttribute(string message)
        {
            Message = message;
        }
    }

}
