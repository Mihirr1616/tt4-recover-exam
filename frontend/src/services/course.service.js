import axios from 'axios';

const API_URL = 'http://localhost:5000/api/courses';

export default {
  getAll() {
    return axios.get(API_URL);
  },
  create(course) {
    return axios.post(API_URL, course);
  },
  update(id, course) {
    return axios.put(`${API_URL}/${id}`, course);
  },
  delete(id) {
    return axios.delete(`${API_URL}/${id}`);
  }
};
