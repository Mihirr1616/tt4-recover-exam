import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
import axios from 'axios';

// ✅ Correct Backend URL (Port 5222)
axios.defaults.baseURL = 'http://localhost:5222/api';

const app = createApp(App);
app.use(router);
app.config.globalProperties.$axios = axios; // Make Axios globally available
app.mount('#app');
