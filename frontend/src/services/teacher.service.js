import axios from 'axios';

export default {
  getAll() { return axios.get('/teachers'); },
  create(teacher) { return axios.post('/teachers', teacher); },
  delete(id) { return axios.delete(`/teachers/${id}`); }
};