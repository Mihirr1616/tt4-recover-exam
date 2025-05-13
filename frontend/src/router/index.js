// src/router/index.js
import { createRouter, createWebHistory } from 'vue-router';
import StudentView from '@/views/StudentView.vue';
import CourseView from '@/views/CourseView.vue';
import TeacherView from '@/views/TeacherView.vue';

const routes = [
  { path: '/students', component: StudentView },
  { path: '/courses', component: CourseView },
  { path: '/teachers', component: TeacherView },
  { path: '/', redirect: '/students' }
];

const router = createRouter({
  history: createWebHistory(),
  routes
});

export default router;
