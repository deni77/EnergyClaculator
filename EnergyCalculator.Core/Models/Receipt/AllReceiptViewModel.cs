namespace EnergyCalculator.Core.Models.Receipt
{
    public class AllReceiptViewModel
    {
        public int Id { get; init; }

        public string Name { get; set; } = null!;
        public string TotalQuantity { get; set; }= null!;

    }
}
