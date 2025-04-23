namespace Maraudr.Stock.Domain.Interfaces;

public interface IRessource
{
    string Name { get; }
    string? Description { get; }
    void SetItemDescription(string description);
}
