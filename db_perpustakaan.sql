/*
SQLyog Enterprise - MySQL GUI v7.02 
MySQL - 5.5.5-10.1.10-MariaDB : Database - db_perpustakaan
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_perpustakaan` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `db_perpustakaan`;

/*Table structure for table `tb_admin` */

DROP TABLE IF EXISTS `tb_admin`;

CREATE TABLE `tb_admin` (
  `User_id` int(11) NOT NULL AUTO_INCREMENT,
  `Nama_admin` varchar(30) NOT NULL,
  `Username` varchar(25) NOT NULL,
  `Password` char(15) NOT NULL,
  `Status` char(15) NOT NULL,
  `Foto` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`User_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `tb_admin` */

insert  into `tb_admin`(`User_id`,`Nama_admin`,`Username`,`Password`,`Status`,`Foto`) values (1,'Fitra Surya Saputra','mfaa','pknk','Admin','D:\\mfaa\\1.jpg'),(3,'sinta cantika','sinta','unaspasim','Pustakawan','C:\\Users\\LabPro1_10\\Pictures\\icon coca cola\\coca-c'),(4,'Dila Nurhayati F','pk','pknk','Admin','D:\\mfaa\\bhan nana\\users_with_circle_256.png'),(5,'Syamsul Abdul Aziz','syamsul','12345','Pustakawan','D:\\mfaa\\bhan nana\\New folder\\74472.png');

/*Table structure for table `tb_anggota` */

DROP TABLE IF EXISTS `tb_anggota`;

CREATE TABLE `tb_anggota` (
  `Id_kartu_anggota` int(11) NOT NULL AUTO_INCREMENT,
  `Nis_siswa` char(12) NOT NULL,
  `Nama_siswa` varchar(30) NOT NULL,
  `Jk` char(11) NOT NULL,
  `Tgl_lahir` date NOT NULL,
  `Jurusan` varchar(30) NOT NULL,
  `Alamat` varchar(30) NOT NULL,
  `No_hp` char(14) DEFAULT NULL,
  `Foto` varchar(100) NOT NULL,
  PRIMARY KEY (`Id_kartu_anggota`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

/*Data for the table `tb_anggota` */

insert  into `tb_anggota`(`Id_kartu_anggota`,`Nis_siswa`,`Nama_siswa`,`Jk`,`Tgl_lahir`,`Jurusan`,`Alamat`,`No_hp`,`Foto`) values (1,'1214171010','Ihsan Nasihin','Laki - laki','1997-01-01','IPA','Kp. Ancol','0823451423148','C:\\Users\\LabPro1_10\\Pictures\\AAoojj4.jpg'),(2,'703740727','Rudi Budiman','Laki - laki','1997-01-01','IPA','Kp. Ciamis','0876356238723','C:\\Users\\LabPro1_10\\Pictures\\AAooqIq.jpg'),(3,'1214171011','Sholeh Sumarudin','Laki - laki','1998-06-17','IPA','Kp. Damar Jl. Petir no.25','081341524353','D:\\mfaa\\download.jpg'),(4,'1214171012','Ita','Perempuan','1999-07-14','IPA','Kp. Runtuhan jl.babakan','085645165243','D:\\mfaa\\hah.png'),(5,'1214171013','Anita Bahri','Perempuan','1999-08-20','IPS','Kp. Banteng ulung Jl. rupawan','087652435423','D:\\mfaa\\house-top-icon-17736.png'),(6,'1214171014','Syamsul Abdul Aziz','Laki - laki','1999-03-12','IPA','Kp. Cicangkang','0865142341524','D:\\mfaa\\bgd.jpg'),(7,'1214171015','Fitra Surya Saputra','Laki - laki','1999-03-06','IPA','Kp. Jati Sari','082317127267','D:\\mfaa\\face.png'),(8,'1214171016','Yandi','Laki - laki','1998-06-17','IPS','Kp. Cicongka','084356251423','D:\\mfaa\\bhan nana\\foto seleksi mhs berprestasi 13 032018.jpg'),(9,'1214171017','Roni','Laki - laki','1999-11-24','IPS','Kp. Nangro','0834154241525','D:\\mfaa\\bhan nana\\giphy (1).gif'),(10,'1214171018','Helin','Perempuan','2000-11-23','IPS','Kp. Roemah','083431324132','D:\\mfaa\\bhan nana\\Wwalczyszyn-Android-Style-Honeycomb-Books.ico'),(11,'1214171019','Haryanti','Perempuan','1999-12-01','IPA','Kp. ronggeng','082341524536','D:\\mfaa\\bhan nana\\giphy.gif'),(12,'1214171020','Nurdin','Laki - laki','1998-11-12','IPA','Kp. Jati mulyo','082431324516','C:\\Users\\Public\\Pictures\\Sample Pictures\\Penguins.jpg');

/*Table structure for table `tb_buku` */

DROP TABLE IF EXISTS `tb_buku`;

CREATE TABLE `tb_buku` (
  `Kode_buku` char(10) NOT NULL,
  `Kategori` char(20) NOT NULL,
  `Judul` varchar(30) NOT NULL,
  `Pengarang` varchar(30) DEFAULT NULL,
  `Penerbit` varchar(25) DEFAULT NULL,
  `Tahun_terbit` char(5) DEFAULT NULL,
  `Lokasi` char(10) NOT NULL,
  `Tgl_masuk` date NOT NULL,
  `Harga` int(11) NOT NULL,
  `Stok` int(11) NOT NULL,
  `Alamat_gambar` varchar(100) NOT NULL,
  PRIMARY KEY (`Kode_buku`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tb_buku` */

insert  into `tb_buku`(`Kode_buku`,`Kategori`,`Judul`,`Pengarang`,`Penerbit`,`Tahun_terbit`,`Lokasi`,`Tgl_masuk`,`Harga`,`Stok`,`Alamat_gambar`) values ('B01','Agama','Ilmu Hitam','Fitra','Andi','2017','200','2018-01-30',20000,16,'C:\\Users\\LabPro1_10\\Pictures\\AAoookl.jpg'),('B02','Filsafat dan psikolo','Ilmu Yunani Kuno','Bunya','fdfd','2018','100','2019-05-29',20000,2,'C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg'),('B03','Bahasa','Bahasa Indonesia','Wia Handayani','Gramedia','2015','400','2016-07-14',35000,1,'D:\\mfaa\\8338-200.png'),('B04','Kesenian dan rekreas','Belajar Gitar Dengan Mudah','Patrio DJ','Andi','2018','700','2018-02-07',30000,5,'D:\\mfaa\\cek.png'),('B05','Agama','Hidayah','Sukaesih','PUB PASIM','2018','200','2018-07-11',25000,5,'D:\\mfaa\\bhan nana\\28962.png'),('B06','Sejarah dan geografi','Bung TOMO','Nurdin','Gramedia','2017','900','2017-08-26',45000,3,'D:\\mfaa\\bhan nana\\Buku.jpg'),('B07','Sains dan matematika','ALjabar Linear','Roni A','PUB PASIM','2018','500','2018-06-06',25000,2,'D:\\mfaa\\bhan nana\\foto penyerahan ijazah wisuda mAret 2018.JPG'),('B08','Bahasa','Sastra Jepang','Rudi Hanto','Putra Bagja','2017','400','2018-01-01',25000,2,'D:\\mfaa\\bhan nana\\books-icon-psd-image-2331red-book.png'),('B09','Teknologi','Robotika','Hotman','Gramedia','2018','600','2018-07-19',35000,3,'D:\\mfaa\\bhan nana\\Custom-Icon-Design-Pretty-Office-7-Calendar.ico'),('B10','Ilmu sosial','Sosialiasi Hebat','sukoy','Andi','2016','300','2017-06-20',20000,5,'D:\\mfaa\\bhan nana\\b5cdab07.png'),('B11','Teknologi','Pengaruh Teknologi Dijaman Now','Fitra Surya Saputra','PUB PASIM','2018','600','2018-09-01',50000,5,'C:\\Users\\Public\\Pictures\\Sample Pictures\\Desert.jpg');

/*Table structure for table `tb_kategori_buku` */

DROP TABLE IF EXISTS `tb_kategori_buku`;

CREATE TABLE `tb_kategori_buku` (
  `Kode_ddc` char(5) NOT NULL,
  `Kategori` varchar(50) NOT NULL,
  PRIMARY KEY (`Kode_ddc`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tb_kategori_buku` */

insert  into `tb_kategori_buku`(`Kode_ddc`,`Kategori`) values ('000','Komputer,Informasi dan referensi umum'),('100','Filsafat dan psikologi'),('200','Agama'),('300','Ilmu sosial'),('400','Bahasa'),('500','Sains dan matematika'),('600','Teknologi'),('700','Kesenian dan rekreasi'),('800','Sastra'),('900','Sejarah dan geografi');

/*Table structure for table `tb_peminjaman` */

DROP TABLE IF EXISTS `tb_peminjaman`;

CREATE TABLE `tb_peminjaman` (
  `Id_peminjaman` int(11) NOT NULL AUTO_INCREMENT,
  `Id_kartu_anggota` int(13) NOT NULL,
  `Nama_siswa` varchar(30) NOT NULL,
  `Kode_buku` char(11) NOT NULL,
  `Judul` varchar(30) NOT NULL,
  `Tgl_pinjam` date NOT NULL,
  `Tgl_kembali` date NOT NULL,
  `Status` char(20) NOT NULL,
  `Keterangan` varchar(50) DEFAULT NULL,
  `Alamat_gbr` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id_peminjaman`),
  KEY `fk_bku` (`Kode_buku`),
  KEY `fk_id` (`Id_kartu_anggota`),
  CONSTRAINT `fk_bku` FOREIGN KEY (`Kode_buku`) REFERENCES `tb_buku` (`Kode_buku`),
  CONSTRAINT `fk_id` FOREIGN KEY (`Id_kartu_anggota`) REFERENCES `tb_anggota` (`Id_kartu_anggota`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

/*Data for the table `tb_peminjaman` */

insert  into `tb_peminjaman`(`Id_peminjaman`,`Id_kartu_anggota`,`Nama_siswa`,`Kode_buku`,`Judul`,`Tgl_pinjam`,`Tgl_kembali`,`Status`,`Keterangan`,`Alamat_gbr`) values (4,1,'Ihsan Nasihin','B01','Ilmu Hitam','2018-08-31','2018-08-31','Ada','gfvhfgh','C:\\Users\\LabPro1_10\\Pictures\\AAoookl.jpg'),(5,2,'Rudi Budiman','B02','Ilmu Yunani Kuno','2018-08-31','2018-09-04','Ada','Buku Bagus','C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg'),(6,6,'Syamsul Abdul Aziz','B04','Belajar Gitar Dengan Mudah','2018-09-01','2018-09-07','Diperpanjang','Buku dalam kurang memuaskan','D:\\mfaa\\cek.png'),(7,7,'Fitra Surya Saputra','B10','Sosialiasi Hebat','2018-09-01','2018-09-04','Ada','Jilid buku sedikit sobek','D:\\mfaa\\bhan nana\\b5cdab07.png'),(8,5,'Anita Bahri','B09','Robotika','2018-09-01','2018-09-04','Dipinjam','Buku dalam keadaan sehat walafiat','D:\\mfaa\\bhan nana\\Custom-Icon-Design-Pretty-Office-7-Calendar.ico');

/*Table structure for table `tb_pengembalian` */

DROP TABLE IF EXISTS `tb_pengembalian`;

CREATE TABLE `tb_pengembalian` (
  `Id_pengembalian` char(10) NOT NULL,
  `Nama_siswa` varchar(30) NOT NULL,
  `Judul` varchar(30) NOT NULL,
  `Tgl_kembali` date NOT NULL,
  `Lama_pinjam` char(8) NOT NULL,
  `Terlambat` char(5) NOT NULL,
  `Denda` int(11) NOT NULL,
  `Status` char(30) NOT NULL,
  `Keterangan` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_pengembalian`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tb_pengembalian` */

insert  into `tb_pengembalian`(`Id_pengembalian`,`Nama_siswa`,`Judul`,`Tgl_kembali`,`Lama_pinjam`,`Terlambat`,`Denda`,`Status`,`Keterangan`) values ('P01','sinta','aisyah','2018-09-04','3 Hari','',0,'Ada','NAON WE'),('P02','Ihsan Nasihin','Ilmu Hitam','2018-09-01','3 Hari','',0,'Ada','dcvds'),('P03','Ihsan Nasihin','Ilmu Hitam','2018-09-02','3 Hari','',0,'Ada','FGD'),('P04','Ihsan Nasihin','Ilmu Hitam','2018-08-31','3 Hari','',0,'Ada','gfvhfgh'),('P05','Rudi Budiman','Ilmu Yunani Kuno','2018-09-03','3 Hari','',0,'Diperpanjang','Buku Bagus'),('P06','Rudi Budiman','Ilmu Yunani Kuno','2018-09-04','3 Hari','',0,'Ada','Buku Bagus'),('P07','Syamsul Abdul Aziz','Belajar Gitar Dengan Mudah','2018-09-04','3 Hari','',0,'Diperpanjang','Buku dalam keadaan bagus'),('P08','Fitra Surya Saputra','Sosialiasi Hebat','2018-08-28','3 Hari','4',8000,'Diperpanjang','Jilid buku sedikit sobek'),('P09','Fitra Surya Saputra','Sosialiasi Hebat','2018-09-04','3 Hari','',0,'Ada','Jilid buku sedikit sobek');

/*Table structure for table `tb_pengunjung` */

DROP TABLE IF EXISTS `tb_pengunjung`;

CREATE TABLE `tb_pengunjung` (
  `No` int(11) NOT NULL AUTO_INCREMENT,
  `Nama_pengunjung` varchar(30) NOT NULL,
  `Jenis_kelamin` char(15) NOT NULL,
  `Jurusan` char(10) NOT NULL,
  `Keperluan` varchar(50) NOT NULL,
  `Dicari` varchar(30) NOT NULL,
  `Saran` varchar(1000) DEFAULT NULL,
  `Tanggal_berkunjung` date NOT NULL,
  `Jam` char(15) NOT NULL,
  PRIMARY KEY (`No`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

/*Data for the table `tb_pengunjung` */

insert  into `tb_pengunjung`(`No`,`Nama_pengunjung`,`Jenis_kelamin`,`Jurusan`,`Keperluan`,`Dicari`,`Saran`,`Tanggal_berkunjung`,`Jam`) values (1,'Fitra Surya Saputra','Laki - laki','IPA','Meminjam Buku','Buku Matematika','Perbanyak lagi buku-buku nya','2018-09-01','6:40:12 AM'),(2,'Dila Nurhayati Fadhilah','Perempuan','IPA','Membaca','Buku Biologi','Tidak ada','2018-09-01','6:40:12 AM'),(3,'Erni','Perempuan','IPS','Membaca','Buku Akuntansi','Layani pelanggan dengan puas','2018-09-01','6:40:12 AM'),(4,'Nurdin','Laki - laki','IPS','Meminjam','Buku Fisika','','2018-09-01','6:40:12 AM'),(5,'Fitra Sutrya Saputra','Laki - laki','IPA','Meminjam','Buku Biologi','','2018-09-01','6:40:12 AM'),(6,'Popi','Perempuan','IPS','Membaca','Pantun','','2018-09-01','6:40:12 AM'),(7,'Teguh Nurwansyah','Laki - laki','IPS','Meminjam','Buku Penjaskes','jaga kebersihan perpustakaan','2018-09-01','6:40:12 AM'),(8,'Fahmi Ali','Laki - laki','IPA','Mengunjungi','Ilmu Yang Bermanfaat','jaga keamanan','2018-09-01','6:40:12 AM'),(9,'Fardiansyah Tanjung','Laki - laki','IPS','Meminjam Buku','Ilmu pengetahuan','tidak','2018-09-01','6:56:55 AM'),(10,'Rudi Unto','Laki - laki','IPA','Meminjam','Ilmu','','2018-09-01','6:56:55 AM'),(11,'Siti Nurliani Susanti','Perempuan','IPA','Meminjam dan membaca','Buku biologi dan Fisika','Jagalah kebersihan perpustakaan','2018-09-01','7:02:37 AM');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
