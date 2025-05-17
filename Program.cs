namespace InvoiceApp
{
    internal class InvoiceTest
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("132", "Laptop", 3, 500.99m);

            Console.WriteLine("Part Number : " + invoice1.getPartNumber());
            Console.WriteLine("Part Describtion : " + invoice1.getPartDescription());
            Console.WriteLine("Quantity : " + invoice1.getQuantity());
            Console.WriteLine("Price Per Item : " + invoice1.getPricePerItem());

            Console.WriteLine("Invoice Amount = " + invoice1.getInvoiceAmount());

            invoice1.setQuantity(-5); //not change
            invoice1.setPricePerItem(0); //not change

            invoice1.setQuantity(5);
            invoice1.setPricePerItem(389.99m);

            Console.WriteLine("Invoice Amount = " + invoice1.getInvoiceAmount());
            Console.ReadLine();
        }
    }
}
