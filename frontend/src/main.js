import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
import axios from 'axios';

// Global Axios Configuration
axios.defaults.baseURL = 'http://localhost:5222/api';

const app = createApp(App);
app.use(router);
app.mount('#app');
