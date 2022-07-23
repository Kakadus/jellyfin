#nullable disable

#pragma warning disable CA1721, CA1826, CS1591

using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace MediaBrowser.Controller.Entities.Audio
{
    /// <summary>
    /// Class NewAudioBook. It is a MusicAlbum, which supports tick resume and played status.
    /// </summary>
    public class NewAudioBook : MusicAlbum
    {
        [JsonIgnore]
        public override bool SupportsPositionTicksResume => true;

        [JsonIgnore]
        public override bool SupportsPlayedStatus => true;

        [JsonIgnore]
        public override IEnumerable<Audio> Tracks => GetRecursiveChildren(i => i is Chapter).Cast<Chapter>();
    }
}
