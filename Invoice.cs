

namespace InvoiceApp
{
    internal class Invoice
    {
        private string partNumber;
        private string partDescription;
        private int quantity;
        private decimal pricePerItem;

        public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem)
        {
            this.partNumber = partNumber;
            this.partDescription = partDescription;
            this.quantity = quantity;
            this.pricePerItem = pricePerItem;
        }

        public void setPartNumber(string partNumber) 
        {
            this.partNumber = partNumber;
        }
        public string getPartNumber()
        {
            return this.partNumber;
        }
        public void setPartDescription(string partDescription)
        {
            this.partDescription= partDescription;
        }
        public string getPartDescription()
        {
            return this.partDescription;
        }
        public void setQuantity(int quantity)
        {
            if (quantity > 0)
            {
                this.quantity = quantity;
                Console.WriteLine("Entered Quantity : " + this.quantity + " - Updated Quantity : " + this.quantity);
            }
            else
            {
                Console.WriteLine("Entered Quantity : " + quantity + " - Only positive values can be entered");
                Console.WriteLine("Quantity : " + this.quantity);
            }
        }
        public int getQuantity()
        {
            return this.quantity; 
        }
        public void setPricePerItem(decimal pricePerItem)
        {
            if(pricePerItem > 0)
            {
                this.pricePerItem = pricePerItem ;
                Console.WriteLine("Entered Price : " + this.pricePerItem + " - Updated Price Per Item : " + this.pricePerItem);
            }
            else
            {
                Console.WriteLine("Entered Price : " + pricePerItem + " - Only positive values can be entered");
                Console.WriteLine("Price Per Item : " + this.pricePerItem);
            }
        }
        public decimal getPricePerItem()
        {
            return this.pricePerItem;
        }
        public decimal getInvoiceAmount()
        {
            return quantity * pricePerItem;
        }
    }
}
