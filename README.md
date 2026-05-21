# Basic ATM Simulator (C#)

A simple console-based ATM simulator built with C# as a beginner-friendly project.
---
## 📋 Features
- 🔐 PIN Authentication
- 💰 Check Balance
- 💸 Withdraw (multiples of ₱100 only)
- 📥 Deposit
- 📄 Transaction History

---
### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)
- Visual Studio Code or Visual Studio

### How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/anthonysoreta1-creator/basic-atm-simulator.git
   cd basic-atm-simulator
   ```

2. Run the project:
   ```bash
   dotnet run
   ```

3. Enter the default PIN when prompted:
   ```
   PIN: 1234
   ```

---

## 🖥️ Demo

```
Enter PIN: ****
Login successful!

=== ATM MENU ===
[1] Check Balance
[2] Withdraw
[3] Deposit
[4] Transaction History
[5] Exit
Choose: 1

Balance: ₱5,000.00
```

---

## 📁 Project Structure

```
basic-atm-simulator/
├── Program.cs       # Main source code
├── ATM.csproj       # Project file
└── README.md        # Documentation
```

---

## Built With

- C# (.NET)
- Visual Studio Code

---

## 📌 Notes

- Starting balance is set to **₱5,000.00**
- Withdrawals must be in **multiples of ₱100**
- Data resets every time the program is closed (no database yet)

---

## Possible Improvements

- [ ] Multiple user accounts
- [ ] PIN change feature
- [ ] Save transactions to a file
- [ ] GUI using Windows Forms

---

## 👤 Author

Anthony — feel free to fork and improve!

---

## 📄 License

This project is open source and free to use.
