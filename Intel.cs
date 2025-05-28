using System.Text.Json.Serialization;

namespace MauiVigilant
{
    public class Intel
    {
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets
        /// The identifier of the sender of the alert message
        /// </summary>
        public string? Provider { get; set; }

        /// <summary>
        /// Gets or sets
        /// The identifier of the alert message
        /// </summary>
        public string MessageId { get; set; } = null!;

        /// <summary>
        /// Gets or sets
        /// The text identifying the AlertTitle
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets
        /// The time and date of the origination of the alert message
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        public string? Category { get; set; }

        /// <summary>
        /// Gets or sets
        /// The text identifying the source of the alert message
        /// </summary>
        public string? Source { get; set; }

        /// <summary>
        /// General content of the Alert.
        /// </summary>
        public string? Content { get; set; }

        /// <summary>
        /// A simple summary of the Alert.
        /// </summary>
        public string? Summary { get; set; }

        /// <summary>
        /// Related relevant URIs amplifying the Alert.
        /// </summary>
        public string? Link { get; set; }


        /// <summary>
        /// Gets or sets
        /// The code denoting the severity of the subject event of the alert message
        /// </summary>
        public string? Severity { get; set; }

        public List<CompactArea>? Areas { get; set; }

        [JsonIgnore] public double? Distance { get; set; }
    }
}
