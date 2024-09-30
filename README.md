# 🎓 Course Management System

### Project Overview
This C# project demonstrates object-oriented programming (OOP) principles by managing courses and participants, such as students and professors. The system supports different types of courses—undergraduate and graduate—and efficiently tracks participants by adding them to each course. The implementation includes interfaces, abstract classes, and specific class implementations, making it easy to extend and modify for various course and participant types.

---

## 🚀 Features

- **Interface: `Course`**
  - Defines the core functionality of courses, including methods for:
    - Getting the course name and code
    - Adding participants
    - Retrieving the list of participants
 
- **Abstract Class: `Person`**
  - Represents a general person in the system, with properties like:
    - `name`, `age`, and `address`
  - Includes abstract methods such as `GetRole`, which must be implemented by derived classes.
 
- **Class: `Professor`**
  - Inherits from `Person` and adds functionality related to professors, including:
    - Teaching a course
    - Specifying a department

- **Class: `Student`**
  - Inherits from `Person` and adds properties and methods like:
    - `studentId`
    - `Study` method to simulate student behavior.

- **Class: `UndergraduateCourse`**
  - Implements the `Course` interface, representing a basic course with a name and code. Participants can be added to the course.

- **Class: `GraduateCourse`**
  - Similar to `UndergraduateCourse`, but focuses on research topics. The course code is dynamically generated based on the research focus.

---

## 📐 UML Diagram
![oop-version4](https://github.com/user-attachments/assets/1de31bdc-95b9-41a3-a000-11c402c8fa02)
---

## ⚙️ Installation

1. **Clone the repository**:
    ```bash
    git clone https://github.com/BatyaWeil/CourseManagementSystem.git
    ```

2. **Navigate to the project directory**:
    ```bash
    cd CourseManagementSystem
    ```

3. **Run the application**:
    - Open the project in your favorite C# IDE (e.g., Visual Studio).
    - Build the project.
    - Run the application to simulate course management.

---

## 📞 Contact
For more information, feel free to reach out:

**Batya Boim**  
📞 0504119712  
✉️ batya4119712@gmail.com
