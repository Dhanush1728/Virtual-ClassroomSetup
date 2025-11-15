<<<<<<< HEAD
# Virtual-Classroom-Setup
A 3D Virtual Classroom built in Unity 2022.3 LTS featuring chat-based Q&amp;A, realistic classroom environment, student avatars, and C# scripting. Includes UI, walls, ceiling, tables, chairs, and local AI-style tutor responses.
# 🧑‍🏫 Virtual Classroom Setup (Unity 3D Project)

A complete 3D **Virtual Classroom** created using **Unity 2022.3 LTS**, featuring:
- A realistic classroom environment (walls, ceiling, tables, chairs)
- Student avatars with name tags
- Text-based chat system between student and tutor
- Simple AI-style automated responses
- Optional tutor voice playback
- Home screen navigation (Join Classroom / Exit)

This project is perfect for learning Unity UI, C# scripting, scene design, and 3D layout.

---

## 📖 Table of Contents
- [Project Overview](#project-overview)
- [Technologies Used](#technologies-used)
- [How the Project Works](#how-the-project-works)
- [Setup Instructions](#setup-instructions)
- [Classroom Design](#classroom-design)
- [Chat System Script](#chat-system-script)
- [Optional Voice Feature](#optional-voice-feature)
- [Final Output](#final-output)
- [Future Improvements](#future-improvements)
- [Author](#author)
- [License](#license)

---

## 📘 Project Overview
The **Virtual Classroom Setup** simulates a basic 3D classroom where students can interact with a tutor through a chat-based question system.  
The user types a question in the chat panel, and the tutor responds instantly using predefined logic.

This project demonstrates:
- Unity UI design  
- 3D modeling using built-in objects  
- Basic AI-style question answering  
- Scene switching using buttons  
- Avatar placement and environment design  

---

## 🧩 Technologies Used

| Component | Technology |
|----------|------------|
| Game Engine | Unity 2022.3 LTS |
| Scripting | C# |
| UI System | TextMeshPro + Unity Canvas |
| Models | Unity 3D Objects + Optional Avatar Models |
| Audio (Optional) | AudioSource component |
| Navigation | SceneManager |

---

## 🛠️ How the Project Works

### **1. Home Screen**
- Displays title  
- Contains **Join Classroom** and **Exit** buttons  
- Loads the Classroom scene using SceneManager

### **2. Classroom Scene**
Includes:
- Floor, board, tables, chairs
- 4 walls + ceiling (made using cubes)
- Student avatars seated with name tags
- Chat panel on the right side

### **3. Chat System**
User types a question → tutor responds using built-in logic inside a C# script.

---

## ⚙️ Setup Instructions

### **1️⃣ Create Project**
- Open Unity Hub → Unity 2022.3 LTS  
- Create 3D Project → Name: `VirtualClassroom`

### **2️⃣ Import Required Packages**
Go to **Window → Package Manager** and install:
- TextMeshPro
- Unity UI Toolkit
- Input System (optional)

### **3️⃣ Player Settings**
File → Build Settings → Switch Platform (PC Standalone)  
Player → Other Settings:
- Disable Auto Graphics API
- Remove Vulkan (keep OpenGL/DirectX)
- Enable IL2CPP backend

---

## 🏫 Classroom Design

### **3D Objects Created**
- **Plane** → Floor  
- **Cube** → Tables & Chairs  
- **Quad** → Board  
- **Cube Walls**:
  - Wall_Back
  - Wall_Left
  - Wall_Right
  - Wall_Front
- **Cube Ceiling**

### **Student Avatars**
- 3D avatar models  
- Positioned avatars on chairs facing the board  

### **Materials**
- Wall Material (cream color)
- Floor Material (optional)
- Board Material (green/black)

---

## 💬 Chat System Script

### `QAHandler.cs` (Used in Chat Panel)

'''csharp

using UnityEngine;
using TMPro;

public class QAHandler : MonoBehaviour {

    public TMP_InputField inputField;
    public TextMeshProUGUI chatHistory;
    public void OnAsk() {
        string question = inputField.text;
        if (!string.IsNullOrEmpty(question)) {
        
            string answer = GetAnswer(question);
            chatHistory.text += "\nYou: " + question + "\nTutor: " + answer;
            inputField.text = "";
        }
    }
    
    string GetAnswer(string q) {
        if (q.ToLower().Contains("hello")) return "Hello, welcome to the class!";
        if (q.ToLower().Contains("ai")) return "AI stands for Artificial Intelligence.";
        return "Sorry, I don’t know that yet.";
    }
}





**Script Handles:**
   -Student question detection
   -Displaying question + response in scroll view
   -Simple keyword-based tutor answers

**🖼️ Final Output**
    -Home Screen → Join Classroom
    -Classroom with:
      Walls, ceiling, tables, chairs, avatars
    -Chat Panel (InputField, Button, ScrollView)
    -Tutor answering questions
    -Multiple Q&A messages appear in chat history
    -Environment looks like a real classroom

**🚀Future Improvements**
     -Add multiplayer networking for multiple students
     -Integrate ChatGPT for real AI answers
     -Add sitting/writing animations for students
     -Add interactions like raising hand, voice chat
     -Better room lighting and textures

**👩‍💻 Author**

Divyadharshini P
B.Tech – Artificial Intelligence and Data Science
Sri Jayaram Institute of Engineering and Technology
Gummidipoondi, Thiruvallur

📧 Email: dhanush11092006@gmail.com
 LinkedIn:www.linkedin.com/in/dhanush1728

