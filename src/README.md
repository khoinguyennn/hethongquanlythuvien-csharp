## Lược đồ cơ sở dữ liệu
```mermaid
erDiagram
    NGUOIDUNG {
        MANGUOIDUNG Varchar(100) "Primary"
        TENNGUOIDUNG NVarchar(120) "Required"
        LOAINGUOIDUNG Varchar(50) "AllowNull"
        SODIENTHOAI Varchar(80) "AllowNull"
        EMAIL Varchar(90) "AllowNull"
        DIACHI NVarchar(100) "AllowNull"
        THONGTINBOSUNG NVarchar(100) "AllowNull"
    }

    DANHMUC {
        MADANHMUC Varchar(100) "Primary"
        TENDANHMUC NVarchar(120) "AllowNull"
        MOTADANHMUC NVarchar(100) "AllowNull"
    }

    TACGIA {
        MATACGIA Varchar(100) "Primary"
        TENTACGIA NVarchar(120) "AllowNull"
    }

    SACH {
        MASACH Varchar(80) "Primary"
        MADANHMUC Varchar(100) "Required"
        MATACGIA Varchar(100) "Required"
        TENSACH NVarchar(100) "AllowNull"
        NAMXUATBAN Int "AllowNull"
        ISBN Varchar(70) "AllowNull"
        SOLUONG Int "AllowNull"
        SOLUONGCONLAI Int "AllowNull"
        MOTASACH NVarchar(100) "AllowNull"
    }

    PHIEUMUON {
        MAPHIEUMUON Varchar(100) "Primary"
        MANGUOIDUNG Varchar(100) "Required"
        MASACH Varchar(80) "Required"
        NGAYMUON Date "AllowNull"
        SOLUONGSACH Int "AllowNull"
        NGAYTRADUKIEN Date "AllowNull"
    }

    HOADONTRASACH {
        MAHOADON Varchar(100) "Primary"
        MAPHIEUMUON Varchar(100) "Required"
        NGAYTRA Date "AllowNull"
        TONGPHIPHAT Int "AllowNull"
    }

    CHITIETSACH {
        MASACH Varchar(80) "Primary, Foreign"
        MAHOADON Varchar(100) "Primary, Foreign"
        SONGAYSUDUNG Int "AllowNull"
        TINHTRANGSACH NVarchar(100) "AllowNull"
    }

    NGUOIDUNG ||--o{ PHIEUMUON : ""
    PHIEUMUON ||--o{ HOADONTRASACH : ""
    PHIEUMUON ||--o{ SACH : ""
    HOADONTRASACH ||--o{ CHITIETSACH : ""
    CHITIETSACH ||--o{ SACH : ""
    SACH ||--o{ DANHMUC : ""
    SACH ||--o{ TACGIA : ""
```