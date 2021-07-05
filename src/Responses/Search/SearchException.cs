using System.Text.Json.Serialization;

// ReSharper disable UnusedAutoPropertyAccessor.Local
namespace Victoria.Responses.Search {
    /// <summary>
    ///     If LoadStatus was LoadFailed then Exception is returned.
    /// </summary>
    public struct SearchException {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("message"), JsonInclude]
        public string Message { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("severity"), JsonInclude]
        public string Severity { get; private set; }
    }
}