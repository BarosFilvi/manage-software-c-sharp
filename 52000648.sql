CREATE DATABASE "QLCH"
GO
USE "QLCH"
GO

CREATE TABLE DaiLy
(
  MaDaiLy INT NOT NULL,
  TenChuDaiLy NVARCHAR(255),
  DiaChi NVARCHAR(255),
  SoDienThoai CHAR(10),
  HinhThucThanhToan CHAR(10),
  NoDauKy INT,
  PRIMARY KEY (MaDaiLy)
);

CREATE TABLE HoaDon
(
  SoHoaDon INT NOT NULL,
  NgayLapHoaDon DATE,
  MaDaiLy INT,
  PRIMARY KEY (SoHoaDon),
  FOREIGN KEY (MaDaiLy) REFERENCES DaiLy(MaDaiLy)
);

CREATE TABLE SanPham
(
  MaSanPham INT NOT NULL,
  TenSanPham NVARCHAR(255),
  KichThuoc INT,
  DonGiaTraCham INT,
  DonGiaTraNgay INT,
  DonGiaTraGop INT,
  GhiChu NVARCHAR(255),
  PRIMARY KEY (MaSanPham)
);

CREATE TABLE ThanhToan
(
  SoPhieuThu INT NOT NULL,
  NgayLapPhieu DATE,
  SoTien INT,
  MaDaiLy INT,
  PRIMARY KEY (SoPhieuThu),
  FOREIGN KEY (MaDaiLy) REFERENCES DaiLy(MaDaiLy)
);

CREATE TABLE ChiTietHoaDon
(
  SoLuong INT,
  SoHoaDon INT NOT NULL,
  MaSanPham INT NOT NULL,
  PRIMARY KEY (SoHoaDon, MaSanPham),
  FOREIGN KEY (SoHoaDon) REFERENCES HoaDon(SoHoaDon),
  FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);