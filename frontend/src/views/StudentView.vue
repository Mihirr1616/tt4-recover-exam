<template>
  <div class="container">
    <h2>Student Management</h2>
    <form @submit.prevent="addStudent">
      <input v-model="newStudent.fullName" placeholder="Full Name" required />
      <input v-model="newStudent.email" placeholder="Email" required />
      <button type="submit">Add Student</button>
    </form>

    <ul>
      <li v-for="student in students" :key="student.id">
        {{ student.fullName }} ({{ student.email }})
        <button @click="deleteStudent(student.id)">Delete</button>
      </li>
    </ul>
  </div>
</template>

<script>
import StudentService from "@/services/student.service";

export default {
  data() {
    return {
      students: [],
      newStudent: { fullName: "", email: "" }
    };
  },
  mounted() {
    this.loadStudents();
  },
  methods: {
    loadStudents() {
      StudentService.getAll().then((response) => {
        this.students = response.data;
      });
    },
    addStudent() {
      StudentService.create(this.newStudent).then(() => {
        this.loadStudents();
        this.newStudent = { fullName: "", email: "" };
      });
    },
    deleteStudent(id) {
      StudentService.delete(id).then(() => {
        this.loadStudents();
      });
    }
  }
};
</script>

<style scoped>
.container {
  max-width: 600px;
  margin: auto;
}
</style>
