# 🎮 Tic Tac Toe Game - WinForms C# Application

A clean and reusable implementation of the classic **Tic Tac Toe** game using **C# Windows Forms**. The app is designed with simplicity and modularity in mind, making it ideal for showcasing event-driven programming, UI painting, and game logic handling.

## 🚀 Features

- ✅ Fully functional **Tic Tac Toe game**.
- 🖱️ Used **Click event** shared among multiple buttons using a **single event handler**.
- 🎯 Handled user actions using `sender` to identify which button was clicked.
- 📦 Used **Tag** property to store the state of each cell (X, O, or empty).
- 🧠 Handled all game states:
  - Player turn switching
  - Win detection
  - Draw detection
  - Automatic game reset after each round
- 🧱 Used:
  - **Enums** to represent players
  - **Struct** for clean data representation
  - **Paint event** to draw the game UI dynamically

## 💡 Clean Code Concepts Used

- **Event-driven design** using one `Click` handler for all game cells.
- Reusable logic for:
  - Turn control
  - Game result checking
  - UI updates
- Clear separation of concerns between UI updates and game logic.
- `Tag` used effectively as a lightweight data store.
- `Paint` event customized to draw additional visuals.

## 📷 UI Preview

*(You can insert a screenshot of the game board here)*

## 🛠️ Technologies

- Language: **C#**
- Framework: **.NET Windows Forms**
- Concepts: Enums, Structs, Event Handling, Tag usage, Paint UI, Game Logic

## 📦 How to Run

1. Open the solution in **Visual Studio**.
2. Build and run the application.
3. Enjoy the game 🎉

## 📬 Contact

For suggestions or feedback, reach out via Telegram:  
**[https://t.me/ahmedelhwwary3]**

---

🧠 This project demonstrates your understanding of event handling, game design logic, and clean reusable code — a solid addition to any beginner-to-intermediate portfolio.

