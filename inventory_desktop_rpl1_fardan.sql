-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Waktu pembuatan: 25 Des 2022 pada 11.44
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory_desktop_rpl1_fardan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin`
--

CREATE TABLE `admin` (
  `id_admin` int(11) NOT NULL,
  `nama` varchar(50) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `username` varchar(25) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `password` varchar(30) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `email` varchar(50) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `telepon` varchar(20) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `admin`
--

INSERT INTO `admin` (`id_admin`, `nama`, `username`, `password`, `email`, `telepon`) VALUES
(1, 'Muhamad Fardan', 'frrdann_', 'adadehh', 'fardan@gmail.com', '+62 787-8738-8775'),
(2, 'Rabil Sepnur Qolbu', '_.sq14._', 'hayoongapain', 'rabil@gmail.com', '+62 734-8475-8439'),
(3, 'Julian Galang', 'juliannn', 'hayoooo', 'julian@gmail.com', '+62 655-5645-8977'),
(4, 'Vincent Novalino', 'vinccct', 'hehehehhe', 'vincent@gmail.com', '+62 867-6537-3657'),
(5, 'Fahmi Bhaitar', 'pahmii', 'apaaaaa', 'fahmi@gmail.com', '+62 657-6545-6544');

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE `barang` (
  `id` int(11) NOT NULL,
  `nama` varchar(50) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `harga` varchar(25) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `stok` int(11) NOT NULL,
  `jenis_barang` varchar(20) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `id_supplier` varchar(50) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `nama_supplier` varchar(50) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`id`, `nama`, `harga`, `stok`, `jenis_barang`, `id_supplier`, `nama_supplier`) VALUES
(1, 'Oreo Blackpink', 'Rp 16.500,00', 999999999, 'barang jadi', '1', 'Agata Hoogeveen'),
(2, 'Lemari Pakaian', 'Rp 700.000,00', 900000000, 'barang tetap', '3', 'Ayoko Barto'),
(3, 'Honda Beat Deluxe Hitam', 'Rp 19.050.000,00', 999999999, 'barang bergerak', '2', 'Anggi Adya'),
(4, 'Rumah Bambu', 'Rp 1.300.000,00', 100000000, 'barang tetap', '3', 'Ayoko Barto'),
(5, 'Gelang Emas Roseg Dior', 'Rp 8.550.000,00', 999999999, 'barang mewah', '4', 'Muhamad Fardan');

-- --------------------------------------------------------

--
-- Struktur dari tabel `supplier`
--

CREATE TABLE `supplier` (
  `id_supplier` int(11) NOT NULL,
  `nama` varchar(50) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `alamat` varchar(50) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `telepon` varchar(30) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `email` varchar(50) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL,
  `kontak` varchar(50) CHARACTER SET utf8 COLLATE utf8_swedish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `supplier`
--

INSERT INTO `supplier` (`id_supplier`, `nama`, `alamat`, `telepon`, `email`, `kontak`) VALUES
(1, 'Agata Hoogeveen', 'Jl.Cibinong', '+62 887-8777-7448', 'agata@gmail.com', 'agata on instagram'),
(2, 'Anggi Adya', 'Jl.Rawa Ilat', '+62 875-5785-8746', 'anggi@gmail.com', 'anggi on instagram'),
(3, 'Ayoko Barto', 'Jl.Gunung Putri', '+62 656-6575-7665', 'ayoko@gmail.com', 'ayoko on instagram'),
(4, 'Muhamad Fardan', 'Jl.Citra Kuning', '+62 657-7678-7665', 'fardan@gmail.com', 'fardan on instagram'),
(5, 'Stenly', 'Jl.Kenari Mas', '+62 876-7667-8999', 'stenly@gmail.com', 'stenly on instagram');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indeks untuk tabel `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `admin`
--
ALTER TABLE `admin`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT untuk tabel `barang`
--
ALTER TABLE `barang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT untuk tabel `supplier`
--
ALTER TABLE `supplier`
  MODIFY `id_supplier` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
