# 📚 TT4 – Recovery Exam

## 📝 Overview

This exam consists of **two parts**:

1. **Multiple-Choice Questions** (Easy to Intermediate)
2. **Fullstack CRUD Project** (Backend + Frontend)

---

## ✅ Submission Checklist

* [ ] Complete all MCQs and download the result `.7z` file
* [ ] Build and push your fullstack project to GitHub
* [ ] Include a proper `README.md` and Docker setup
* [ ] Submit a `.7z` file and a `.txt` file containing your GitHub repo link inside a zipped folder named `tt4-exam`
* [ ] Submit via **MIO**

---

## Use sound judgment and best practices throughout the development process.

---

## 🧠 Part I – Multiple Choice Questions

### 🧪 Instructions:

1. **Run the Docker container**:

   ```bash
   docker login
   docker system prune -a --volumes -f
   docker run --name midterm-tt4 -p 8080:80 -d allanbarcelos/midterm-exam-tt4:latest
   ```

   > ⚠️ Use another port if `8080` is already in use.

2. **Access the Quiz**:
   Open your browser and go to [http://localhost:8080](http://localhost:8080)

3. **Complete the Quiz**:

   * Answer all questions
   * You may retry within the allowed time

4. **Download & Extract Results**:
   You’ll receive a `.zip` file containing:

   * A **PDF** of your results
   * A **password-protected `.7z` file** named:

     ```
     <student_code>_<LastName><FirstName>_Protected.7z
     ```

5. **Submission**:

   * Submit **only the `.7z` file**
   * Any other format will **invalidate** this part

---

## 💻 Part II – Fullstack Project (10 Points)

### 🛠️ Requirements

Create a **Fullstack App (College Management System) **

#### 🔙 Backend (ASP.NET Core + PostgreSQL)

* **Framework & ORM**:
  Use **ASP.NET Core Web API** with **Entity Framework Core** for data access.

* **Authentication & Authorization**:
  Implement secure authentication and role-based authorization using ASP.NET Identity.

* **CORS Configuration**:
  Enable Cross-Origin Resource Sharing (CORS) to support frontend integration.

* **Entities**:

  * `Student`
  * `Course`
  * `Teacher`
  * `User` / `Role`
  * Many-to-many relationships:

    * `StudentCourse`
    * `TeacherCourse`

* **Role-Based Access**:

  * **Student**: Access to personal profile, enrolled courses, and grades.
  * **Teacher**: Access to personal profile and assigned courses; can add grades.
  * **Administrator**: Full access; can manage users and assign students and teachers to courses.

* Push to:

  ```
  docker.io/<DOCKER_HUB_USERNAME>/recover-exam-backend
  ```

#### 🌐 Frontend (Framework of Your Choice)

* Choose: ReactJS, Angular, VueJS, or Svelte
* Required pages:
  * Login
  * Student (CRUD)
  * Course (CRUD)
* Integrate with backend API
* Use a UI framework (Tailwind, Material, or Bootstrap)
* Push to:

  ```
  docker.io/<DOCKER_HUB_USERNAME>/recover-exam-frontend
  ```

---

## 🐳 Docker Setup

* Create Dockerfiles for both frontend and backend
* Add a `docker-compose.yml` for a full production simulation
* Your app must run using:

  ```bash
  docker-compose up
  ```

  > ⚠️ Ensure database migrations run automatically

---

## 📁 Project Structure

Repository name: `tt4-recover-exam`

```
tt4-exam/
├── backend/
│   ├── Dockerfile
│   ├── .gitignore
│   └── ...
├── frontend/
│   └── ...
├── .gitignore
├── .dockerignore
├── default.conf
├── Dockerfile
├── docker-compose.yml
├── README.md
```

---

## 📄 README Instructions

> ✨ To include this exam document in your `README.md`:

1. Scroll to the top of this document
2. Click “Raw”
3. Press `Ctrl + A`, then `Ctrl + C`
4. Paste into your `README.md`

---

## 🧮 Grading Criteria

| Section                 | Points | Description                                      |
| ----------------------- | ------ | ------------------------------------------------ |
| MCQ Submission & Repo   | 4.0    | Working repo and MCQ `.7z` submission            |
| Backend Implementation  | 2.0    | CRUD, DB, CORS, correct API endpoints            |
| Frontend Implementation | 2.0    | Complete CRUD with API integration               |
| Docker Setup            | 1.5    | Dockerfiles and working `docker-compose`         |
| GitHub Repo + README    | 0.5    | Proper structure and includes this exam document |
| **TOTAL**               | **10** |                                                  |

---

## 🧾 Reference Projects

* [Student Management System](https://github.com/allanbarcelos/student-management-system)
* [Task Management System](https://github.com/allanbarcelos/task-management-system)
* [VueJS Project](https://github.com/allanbarcelos/tt4-final-exam-simulation_vuejs)
* [Angular Project](https://github.com/allanbarcelos/tt4-final-exam-simulation_angular)
* [ReactJS Project](https://github.com/allanbarcelos/tt4-final-exam-simulation_reactjs)
* [Svelte Project](https://github.com/allanbarcelos/tt4-final-exam-simulation_svelte)

---

## 📦 Submission Format

1. Create a folder named `tt4-exam`
2. Add:

   * Your `.7z` file from Part I
   * A file named `final-exam.txt` with your GitHub repo link
3. Zip the folder and submit via **MIO**

---

## 💡 Tips

* Ensure the entire application runs smoothly using `docker-compose up`, including:

  * Automatic **database migrations** on startup.
  * Proper configuration for **multiple environments** (Development and Production).

* Follow best practices to build a clean, well-structured, and maintainable application.

* When running the app with Docker:

  * The application should be accessible at `http://localhost` (default to port 80).
  * The API should be available at: `http://localhost/api`
  * Swagger UI should be accessible at: `http://localhost/api/swagger`
