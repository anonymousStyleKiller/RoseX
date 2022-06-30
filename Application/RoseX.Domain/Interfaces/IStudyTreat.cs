namespace RoseX.Domain.Interfaces;


public interface IStudyTreat<TId> : IStudyTreat, IEntity<TId> { }

public interface IStudyTreat : IEntity
{
    public DateTime ModifiedOn { get; set; }
    public int Count { get; set; }
}