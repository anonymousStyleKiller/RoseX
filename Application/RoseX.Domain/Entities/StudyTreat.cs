using RoseX.Domain.Interfaces;

namespace RoseX.Domain.Entities;

public class StudyTreat<TId> : IStudyTreat<TId>
{
    public TId Id { get; set; }
    public DateTime ModifiedOn { get; set; }
    public int Count { get; set; }
}