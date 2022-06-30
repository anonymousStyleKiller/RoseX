using RoseX.Domain.Enums;

namespace RoseX.Domain.Entities;

public class Vocabulary<T, TId> : StudyTreat<TId>
{
    public LanguageType Word { get; set; }
    public LanguageType Translate { get; set; }
    public SpeechType PartOfSpeech { get; set; }
    public string? Example { get; set; }
    public ContentType AdditionalContentType { get; set; }
    public T? AdditionalMaterial { get; set; }
}