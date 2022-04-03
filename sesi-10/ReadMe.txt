Nama : Alexander Radianta Tarigan
No_Peserta : FSDO003ONL010

Panduan Penggunaan Aplikasi:

Get : api/todo
-Klik try it out
-klik execute
-maka akan tampil semua data di database

Post : /api/todo
-klik try it out
-Lalu masukkan data sesuai kolom database
contoh :
{
  "id": 5,
  "name": "Amazing Spiderman",
  "genre": "Action",
  "duration": "2h 12 mins",
  "releaseDate": "2022-03-28T00:00:00"
}
-klik execute
-data berhasil ditambahkan

Get : /api/Todo/{id}
-klik try it out
-masukkan id 
-klik execute
-data yang dicari akan ditampilkan

Put : /api/Todo/{id}
-klik try it out
-masukkan id yang ingin dirubah
-edit sesuai kolom yang tersedia
-klik execute
-Data berhasil diubah
-untuk mengecek bisa menggunakan Get : /api/Todo/{id}

Delete : /api/Todo/{id}
-klik try it out
-masukkan id data yang ingin dihapus
-klik execute
-data berhasil dihapus
-untuk mengecek bisa menggunakan Get : /api/Todo/{id}


Link Github : https://github.com/alextarigan/ocbc-c--batch-3.git