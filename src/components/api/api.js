import axios from 'axios';

const URL = 'https://localhost:7106/api/';

// Page Jurusan

export const fetchJurusan = async () => {
    try {
        const response = await axios.get(`${URL}Jurusan`);
        return response.data;
    } catch (error) {
        console.error("Ada yang error nih",error);
        throw error;
    }
};

export const postJurusan = async (jurusan) => {
    try {
        const response = await axios.post(`${URL}Jurusan`, jurusan, {
            headers: {
                'Content-Type': 'application/json',
            },
        });
        return response.data;
    } catch (error) {
        console.error("Ada yang error nih",error);
        throw error;
    }
};

export const putJurusan = async (id, jurusan) => {
    try {
        const response = await axios.put(`${URL}jurusan/${id}`, jurusan);
        return response.data;
    } catch (error) {
        console.error("Ada yang error nih",error);
        throw error;
    }
}

export const deleteJurusan = async (id) => {
    try {
        const response = await axios.delete(`${URL}jurusan/${id}`);
        return response.data
    } catch (error) {
        console.error("Ada yang error nih",error);
        throw error;
    }
};




// Page Kelas