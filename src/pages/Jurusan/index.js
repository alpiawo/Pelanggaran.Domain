import { HiMiniPlus, HiMiniPencilSquare, HiMiniTrash } from "react-icons/hi2";
import React, { useEffect, useState } from "react";
import DataTable from "react-data-table-component";
import { useNavigate } from "react-router-dom";
import { fetchJurusan, deleteJurusan, postJurusan } from "../../components/api/api";
import Swal from 'sweetalert2';

const JurusanHome = () => {
    const [jurusan, setJurusan] = useState([]);

    // Add dan Edit State
    const [nama, setNamaJurusan] = useState([]);

    const navigate = useNavigate();

    useEffect(() => {
        const loadJurusan = async () => {
            const result = await fetchJurusan();
            setJurusan(result);
        };
        loadJurusan();
    }, []);

    const handleSubmit = async () => {
        const { value: formValues } = await Swal.fire({
            title: "Add Data Jurusan Baru",
            html: `
                <input id="swal-input1" class="swal2-input" placeholder="Nama Jurusan">
            `,
            focusConfirm: false,
            showCancelButton: true,
            confirmButtonText: "Create",
            preConfirm: () => {
                const nama = document.getElementById("swal-input1").value;
                if (!nama) {
                    Swal.showValidationMessage("Tolong isi nama jurusan dengan benar!");
                }
                return {nama};
            },
        });

        if (formValues) {
            try {
                const response = await postJurusan(formValues);
                setJurusan([...jurusan, response]);
                Swal.fire("Berhasil", "Data berhasil ditambahkan!");
                console.log("Response:", response);
            } catch (error) {
                Swal.fire("Terjasi Kesalahan", "Gagal menambahkan data!", "error");
                console.error("Error:", error);
            }
        }
    }

    const handleDelete = (id) => {
        Swal.fire({
            title: 'Apakah anda ingin menghapus data ini?',
            text: 'Anda tidak akan bisa dikembalikan!',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Batal',
            confirmButtonText: 'Ya, Hapus data ini!'
        }).then((result) => {
            if (result.isConfirmed) {
                deleteJurusan(id);
                setJurusan(jurusan.filter((item) => item.id!== id));

                Swal.fire(
                    'Berhasil dihapus!',
                    `Data dengan ID ${id} Berhasil dihapus.`,
                    'Berhasil'
                );
            }
        })
      }

      

    const columns = [
        {name : 'Id', selector: (row) => row.id, sortable: true},
        {name: 'Nama Jurusan', selector: (row) => row.nama, sortable: true},
        {name: 'Actions', cell: (row) => (
            <div className="flex">
                <button className="p-2 rounded-md bg-orange-400 shadow-sm mr-3 hover:bg-orange-500 hover:shadow-lg" onClick={() => navigate(`/jurusan/edit/${row.id}`)}>
                    <HiMiniPencilSquare />
                </button>
                <button className="p-2 rounded-md bg-red-400 shadow-md hover:bg-red-500 hover:shadow-lg" onClick={() => handleDelete(row.id)} >
                    <HiMiniTrash />
                </button>
            </div>
        ),},
    ];

    return (
        <div className="container bg-white">
            <div className="mt-10 rounded-md shadow p-10">
            <p className="text-center mb-10 text-3xl font-bold">Data Jurusan</p>
            <button onClick={() => handleSubmit() } className="bg-emerald-600 mb-5 text-white flex justify-center items-center p-2 rounded-md">
                <HiMiniPlus className="text-2xl"/> Add Jurusan
            </button>
            <DataTable
                className="rounded"
                title="Karakter"
                columns={columns}
                data={jurusan}
                pagination
                sortIcon={<span>&#9650;</span>}
                />
            </div>
        </div>
    )
}

export default JurusanHome;