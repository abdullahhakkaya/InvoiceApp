# InvoiceApp

## 📄 Description

**InvoiceApp** is a simple C# console application that demonstrates basic object-oriented programming concepts such as:

- Class design
- Encapsulation using private fields and public getter/setter methods
- Input validation
- Object instantiation and method usage

The application simulates a basic invoice system where a user can manage item details and calculate the total invoice amount.

---

## 🚀 How It Works

The application consists of two main classes:

### 1. `Invoice` Class

Encapsulates the data and behavior related to a product invoice:

#### 🔒 Fields:
- `partNumber`: string
- `partDescription`: string
- `quantity`: int (must be positive)
- `pricePerItem`: decimal (must be positive)

#### ⚙️ Methods:
- Setter and Getter methods for each field
- `getInvoiceAmount()` – calculates total cost: `quantity * pricePerItem`
- Input validation prevents negative values from being assigned to `quantity` and `pricePerItem`

---

### 2. `InvoiceTest` Class

- The `Main()` method creates an `Invoice` object
- Displays its initial details and invoice amount
- Attempts to update the quantity and price with invalid values (which are rejected)
- Then successfully updates them with valid values
- Displays the updated invoice amount

---

## 💻 Sample Output

- Part Number : 132
- Part Describtion : Laptop
- Quantity : 3
- Price Per Item : 500.99
- Invoice Amount = 1502.97
- Entered Quantity : -5 - Only positive values can be entered
- Quantity : 3
- Entered Price : 0 - Only positive values can be entered
- Price Per Item : 500.99
- Entered Quantity : 5 - Updated Quantity : 5
- Entered Price : 389.99 - Updated Price Per Item : 389.99
- Invoice Amount = 1949.95

---

## 🛠️ Requirements

- .NET SDK (version 6 or later recommended)
- A C# IDE (like Visual Studio, Visual Studio Code, or JetBrains Rider)

---

### 📥 Installation

Clone the repository using Git:

```bash
git clone https://github.com/abdullahhakkaya/InvoiceApp.git
cd InvoiceApp
```

### ▶️ Running the Application

Once inside the project directory, run:

```bash
dotnet run
```
