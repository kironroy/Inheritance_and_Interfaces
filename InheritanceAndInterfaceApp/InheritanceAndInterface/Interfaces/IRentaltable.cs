namespace InheritanceAndInterface
{
    public interface IRentaltable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }

}
