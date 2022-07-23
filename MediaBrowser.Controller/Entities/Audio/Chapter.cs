using System.Text.Json.Serialization;

namespace MediaBrowser.Controller.Entities.Audio;

/// <summary>
/// A audiobook chapter.
/// </summary>
public class Chapter: Audio
{
    [JsonIgnore]
    public override bool SupportsPositionTicksResume => true;

    [JsonIgnore]
    public override bool SupportsPlayedStatus => true;
}
