using Maraudr.Stock.Domain.Enums;
using Maraudr.Stock.Domain.Exceptions;
using Maraudr.Stock.Domain.Interfaces;

namespace Maraudr.Stock.Domain.Entities
{
    public class StockItem(string name) : IRessource
    {
        public Guid Guid { get; init; } = Guid.NewGuid();
        public string Name { get; } = name ?? throw new InvalidItemNameException("Item name is null");
        public string? Description { get; private set; }
        public ItemType ItemType { get; private set; }


        public void SetItemDescription(string description)
        {
            Description = description;
        }

        public void SetItemType(ItemType itemType) 
        { 
            ItemType = itemType;
        }
    }
}
