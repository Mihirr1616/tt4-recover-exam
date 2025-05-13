import axios from 'axios';

export default {
  getAll() { return axios.get('/students'); },
  create(student) { return axios.post('/students', student); },
  delete(id) { return axios.delete(`/students/${id}`); }
};