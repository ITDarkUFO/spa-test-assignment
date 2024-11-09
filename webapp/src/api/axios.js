import axios from 'axios'

const axiosInstance = axios.create({
    baseURL: "https://localhost:7087",
    timeout: 10000,
    headers: { 'Content-Type': 'application/json', },
});

axiosInstance.interceptors.request.use(function (config) {
    const url = new URL(config.url, config.baseURL);
    url.searchParams.append('culture', 'ru-RU');
    config.url = url.toString();

    return config;
}, function (error) {
    return Promise.reject(error);
});

export default axiosInstance;