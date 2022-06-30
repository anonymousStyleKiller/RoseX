using RoseX.Domain.Enums;

namespace RoseX.Domain.Entities;

public class WorkBook<T, TId> : StudyTreat<TId>
{
    public string? Note { get; set; }
    public ContentType AdditionalContentType { get; set; }
    public T? AdditionalMaterial { get; set; }
    public LessonType LessonType { get; set; }
}