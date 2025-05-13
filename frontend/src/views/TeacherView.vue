<template>
  <div>
    <h2>Teacher Management</h2>
    <form @submit.prevent="addTeacher">
      <input v-model="newTeacher.fullName" placeholder="Full Name" />
      <input v-model="newTeacher.email" placeholder="Email" />
      <button type="submit">Add Teacher</button>
    </form>

    <ul>
      <li v-for="teacher in teachers" :key="teacher.id">
        {{ teacher.fullName }} ({{ teacher.email }})
        <button @click="deleteTeacher(teacher.id)">Delete</button>
      </li>
    </ul>
  </div>
</template>

<script>
import TeacherService from '@/services/teacher.service';

export default {
  data() {
    return {
      teachers: [],
      newTeacher: { fullName: '', email: '' }
    };
  },
  mounted() { this.loadTeachers(); },
  methods: {
    loadTeachers() { TeacherService.getAll().then(res => this.teachers = res.data); },
    addTeacher() {
      TeacherService.create(this.newTeacher).then(() => {
        this.loadTeachers();
        this.newTeacher = { fullName: '', email: '' };
      });
    },
    deleteTeacher(id) {
      TeacherService.delete(id).then(() => this.loadTeachers());
    }
  }
};
</script>

<style scoped>
.container { max-width: 600px; margin: auto; }
</style>