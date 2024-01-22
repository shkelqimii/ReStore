import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";

const sleep = () => new Promise(resolve => setTimeout(resolve, 0));

axios.defaults.baseURL = 'http://localhost:5001/api/';

// Define the ErrorResponse interface
interface ErrorResponse {
    title?: string;
}

const responseBody = (response: AxiosResponse) => response.data;

axios.interceptors.response.use(async response => {
    await sleep();
    return response;
}, (error: AxiosError) => {
    const { data, status } = error.response || {};
    const errorData = data as ErrorResponse; // Cast data to ErrorResponse

    switch (status) {
        case 400:
            if (errorData.title) toast.error(errorData.title);
            break;
        case 401:
            if (errorData.title) toast.error(errorData.title);
            break;
        case 500:
            if (errorData.title) toast.error(errorData.title);
            break;
        default:
            toast.error("An unexpected error occurred");
            break;
    }

    return Promise.reject(error.response);
});

const requests = {
    get: (url: string) => axios.get(url).then(responseBody),
    post: (url: string, body: object) => axios.post(url, body).then(responseBody),
    put: (url: string, body: object) => axios.put(url, body).then(responseBody),
    delete: (url: string) => axios.delete(url).then(responseBody),
};

const Catalog = {
    list: () => requests.get('products'),
    details: (id: number) => requests.get(`products/${id}`)
};

const TestErrors = {
    get400Error: () => requests.get('buggy/bad-request'),
    get401Error: () => requests.get('buggy/unauthorized'),
    get404Error: () => requests.get('buggy/not-found'),
    get500Error: () => requests.get('buggy/server-error'),
    getValidationError: () => requests.get('buggy/validation-error'),
};

const agent = {
    Catalog,
    TestErrors
};

export default agent;
