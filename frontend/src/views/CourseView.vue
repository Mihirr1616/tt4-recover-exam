<template>
  <div class="container">
    <h2>Course Management</h2>
    <form @submit.prevent="addCourse">
      <input v-model="newCourse.title" placeholder="Course Title" required />
      <button type="submit">Add Course</button>
    </form>

    <ul>
      <li v-for="course in courses" :key="course.id">
        {{ course.title }}
        <button @click="deleteCourse(course.id)">Delete</button>
      </li>
    </ul>
  </div>
</template>

<script>
import CourseService from "@/services/course.service";

export default {
  data() {
    return {
      courses: [],
      newCourse: { title: "" }
    };
  },
  mounted() {
    this.loadCourses();
  },
  methods: {
    loadCourses() {
      CourseService.getAll().then((response) => {
        this.courses = response.data;
      });
    },
    addCourse() {
      CourseService.create(this.newCourse).then(() => {
        this.loadCourses();
        this.newCourse = { title: "" };
      });
    },
    deleteCourse(id) {
      CourseService.delete(id).then(() => {
        this.loadCourses();
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
