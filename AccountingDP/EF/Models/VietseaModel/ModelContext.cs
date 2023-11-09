using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AccountingDP.EF.Models.VietseaModel;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dmkhachhang> Dmkhachhangs { get; set; }

    public virtual DbSet<Xnt01012018> Xnt01012018s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle("Data Source=192.168.0.50:1522/TBNETERP;User Id=TBNETERP;Password=TBNETERP");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("TBNETERP");

        modelBuilder.Entity<Dmkhachhang>(entity =>
        {
            entity.HasKey(e => new { e.Makhachhang, e.Madonvi }).HasName("DMKHACHHANG_PK");

            entity.ToTable("DMKHACHHANG");

            entity.Property(e => e.Makhachhang)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAKHACHHANG");
            entity.Property(e => e.Madonvi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MADONVI");
            entity.Property(e => e.Chucdanhkhachhang)
                .HasMaxLength(500)
                .HasColumnName("CHUCDANHKHACHHANG");
            entity.Property(e => e.Diachikhachhang).HasColumnName("DIACHIKHACHHANG");
            entity.Property(e => e.Diachinganhang).HasColumnName("DIACHINGANHANG");
            entity.Property(e => e.Diachitochu).HasColumnName("DIACHITOCHU");
            entity.Property(e => e.Diengiai).HasColumnName("DIENGIAI");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(50)
                .HasColumnName("DIENTHOAI");
            entity.Property(e => e.Dienthoaicoquan)
                .HasMaxLength(50)
                .HasColumnName("DIENTHOAICOQUAN");
            entity.Property(e => e.Dienthoaididong)
                .HasMaxLength(50)
                .HasColumnName("DIENTHOAIDIDONG");
            entity.Property(e => e.Dienthoainharieng)
                .HasMaxLength(50)
                .HasColumnName("DIENTHOAINHARIENG");
            entity.Property(e => e.Emailkhachhang)
                .HasMaxLength(100)
                .HasColumnName("EMAILKHACHHANG");
            entity.Property(e => e.Emailtochuc)
                .HasMaxLength(300)
                .HasColumnName("EMAILTOCHUC");
            entity.Property(e => e.Enddate)
                .HasColumnType("DATE")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.Facebook)
                .HasMaxLength(200)
                .HasColumnName("FACEBOOK");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasColumnName("FAX");
            entity.Property(e => e.Formdate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FORMDATE");
            entity.Property(e => e.Giotinh)
                .HasColumnType("NUMBER")
                .HasColumnName("GIOTINH");
            entity.Property(e => e.Hanmucnomax)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("HANMUCNOMAX");
            entity.Property(e => e.Hanmucnomaxngay)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("HANMUCNOMAXNGAY");
            entity.Property(e => e.Issudung)
                .HasColumnType("NUMBER")
                .HasColumnName("ISSUDUNG");
            entity.Property(e => e.Istrangthai)
                .HasColumnType("NUMBER")
                .HasColumnName("ISTRANGTHAI");
            entity.Property(e => e.Kyhieumahoadon)
                .HasMaxLength(100)
                .HasColumnName("KYHIEUMAHOADON");
            entity.Property(e => e.Laisuatngay)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("LAISUATNGAY");
            entity.Property(e => e.Macha)
                .HasMaxLength(100)
                .HasColumnName("MACHA");
            entity.Property(e => e.Mahoadon)
                .HasMaxLength(100)
                .HasColumnName("MAHOADON");
            entity.Property(e => e.Mahopdong)
                .HasMaxLength(100)
                .HasColumnName("MAHOPDONG");
            entity.Property(e => e.Manhomkhachang)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("MANHOMKHACHANG");
            entity.Property(e => e.Manvquanly)
                .HasMaxLength(20)
                .HasColumnName("MANVQUANLY");
            entity.Property(e => e.Maphongban)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAPHONGBAN");
            entity.Property(e => e.Masothe)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MASOTHE");
            entity.Property(e => e.Masothue)
                .HasMaxLength(200)
                .HasColumnName("MASOTHUE");
            entity.Property(e => e.Matuyen)
                .HasMaxLength(50)
                .HasColumnName("MATUYEN");
            entity.Property(e => e.Ngaycap)
                .HasColumnType("DATE")
                .HasColumnName("NGAYCAP");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("DATE")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Ngaysua)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE")
                .HasColumnName("NGAYSUA");
            entity.Property(e => e.Ngaytao)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE")
                .HasColumnName("NGAYTAO");
            entity.Property(e => e.Nghenghiep)
                .HasMaxLength(300)
                .HasColumnName("NGHENGHIEP");
            entity.Property(e => e.Noicap)
                .HasMaxLength(1000)
                .HasColumnName("NOICAP");
            entity.Property(e => e.Socmnd)
                .HasMaxLength(200)
                .HasColumnName("SOCMND");
            entity.Property(e => e.Songaythanhtoan)
                .HasColumnType("NUMBER")
                .HasColumnName("SONGAYTHANHTOAN");
            entity.Property(e => e.Taikhoannganhang)
                .HasMaxLength(300)
                .HasColumnName("TAIKHOANNGANHANG");
            entity.Property(e => e.Tenkhac)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("TENKHAC");
            entity.Property(e => e.Tenkhachhang)
                .HasMaxLength(1000)
                .HasColumnName("TENKHACHHANG");
            entity.Property(e => e.Tentochu)
                .HasMaxLength(1000)
                .HasColumnName("TENTOCHU");
            entity.Property(e => e.Tyleck)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("TYLECK");
            entity.Property(e => e.Usersua)
                .HasMaxLength(100)
                .HasColumnName("USERSUA");
            entity.Property(e => e.Usertao)
                .HasMaxLength(100)
                .HasColumnName("USERTAO");
            entity.Property(e => e.Website)
                .HasMaxLength(300)
                .HasColumnName("WEBSITE");
            entity.Property(e => e.Xunghokhachhang)
                .HasMaxLength(500)
                .HasColumnName("XUNGHOKHACHHANG");
        });

        modelBuilder.Entity<Xnt01012018>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XNT_01012018");

            entity.HasIndex(e => new { e.Madonvi, e.Mavtu, e.Makhohang }, "XNT_01012018_INDEX1");

            entity.Property(e => e.Barcodevtu)
                .HasMaxLength(50)
                .HasColumnName("BARCODEVTU");
            entity.Property(e => e.Dongiabanbuon)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("DONGIABANBUON");
            entity.Property(e => e.Dongiabanle)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("DONGIABANLE");
            entity.Property(e => e.Dongiamua)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("DONGIAMUA");
            entity.Property(e => e.Donvile)
                .HasMaxLength(30)
                .HasColumnName("DONVILE");
            entity.Property(e => e.Donvilon)
                .HasMaxLength(30)
                .HasColumnName("DONVILON");
            entity.Property(e => e.Donviquydoi)
                .HasDefaultValueSql("1")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("DONVIQUYDOI");
            entity.Property(e => e.Giatrivat)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("GIATRIVAT");
            entity.Property(e => e.Giavon)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("GIAVON");
            entity.Property(e => e.Macongthuc)
                .HasMaxLength(50)
                .HasColumnName("MACONGTHUC");
            entity.Property(e => e.Madonvi)
                .HasMaxLength(20)
                .HasColumnName("MADONVI");
            entity.Property(e => e.Madvtinh)
                .HasMaxLength(50)
                .HasColumnName("MADVTINH");
            entity.Property(e => e.Makehang)
                .HasMaxLength(50)
                .HasColumnName("MAKEHANG");
            entity.Property(e => e.Makhachhang)
                .HasMaxLength(50)
                .HasColumnName("MAKHACHHANG");
            entity.Property(e => e.Makhohang)
                .HasMaxLength(50)
                .HasColumnName("MAKHOHANG");
            entity.Property(e => e.Maloaivtu)
                .HasMaxLength(50)
                .HasColumnName("MALOAIVTU");
            entity.Property(e => e.Mangoaite)
                .HasMaxLength(50)
                .HasColumnName("MANGOAITE");
            entity.Property(e => e.Manhomvtu)
                .HasMaxLength(50)
                .HasColumnName("MANHOMVTU");
            entity.Property(e => e.Mavat)
                .HasMaxLength(50)
                .HasColumnName("MAVAT");
            entity.Property(e => e.Mavatdb)
                .HasMaxLength(50)
                .HasColumnName("MAVATDB");
            entity.Property(e => e.Mavatnk)
                .HasMaxLength(50)
                .HasColumnName("MAVATNK");
            entity.Property(e => e.Mavtu)
                .HasMaxLength(50)
                .HasColumnName("MAVTU");
            entity.Property(e => e.Mavtuncc)
                .HasMaxLength(50)
                .HasColumnName("MAVTUNCC");
            entity.Property(e => e.Mavtuphu)
                .HasMaxLength(50)
                .HasColumnName("MAVTUPHU");
            entity.Property(e => e.Nchuyenkhogt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NCHUYENKHOGT");
            entity.Property(e => e.Nchuyenkhosl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NCHUYENKHOSL");
            entity.Property(e => e.Ndieuchinhgt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NDIEUCHINHGT");
            entity.Property(e => e.Ndieuchinhsl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NDIEUCHINHSL");
            entity.Property(e => e.Ndodanggt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NDODANGGT");
            entity.Property(e => e.Ndodangsl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NDODANGSL");
            entity.Property(e => e.Nhapmuagt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NHAPMUAGT");
            entity.Property(e => e.Nhapmuasl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NHAPMUASL");
            entity.Property(e => e.Nkhacgt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NKHACGT");
            entity.Property(e => e.Nkhacsl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NKHACSL");
            entity.Property(e => e.Nkhaugt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NKHAUGT");
            entity.Property(e => e.Nkhausl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NKHAUSL");
            entity.Property(e => e.Nkiemkegt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NKIEMKEGT");
            entity.Property(e => e.Nkiemkesl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NKIEMKESL");
            entity.Property(e => e.Nthanhphamgt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NTHANHPHAMGT");
            entity.Property(e => e.Nthanhphamsl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NTHANHPHAMSL");
            entity.Property(e => e.Ntralaigt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NTRALAIGT");
            entity.Property(e => e.Ntralaisl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("NTRALAISL");
            entity.Property(e => e.Sltonmax)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("SLTONMAX");
            entity.Property(e => e.Sltonmin)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("SLTONMIN");
            entity.Property(e => e.Tenkehang)
                .HasMaxLength(500)
                .HasColumnName("TENKEHANG");
            entity.Property(e => e.Tenkhachhang)
                .HasMaxLength(500)
                .HasColumnName("TENKHACHHANG");
            entity.Property(e => e.Tenkho)
                .HasMaxLength(500)
                .HasColumnName("TENKHO");
            entity.Property(e => e.Tenloaivtu)
                .HasMaxLength(500)
                .HasColumnName("TENLOAIVTU");
            entity.Property(e => e.Tennhomvtu)
                .HasMaxLength(500)
                .HasColumnName("TENNHOMVTU");
            entity.Property(e => e.Tenvtu)
                .HasMaxLength(200)
                .HasColumnName("TENVTU");
            entity.Property(e => e.Tkcpnguyenlieu)
                .HasMaxLength(50)
                .HasColumnName("TKCPNGUYENLIEU");
            entity.Property(e => e.Tkdoanhthu)
                .HasMaxLength(50)
                .HasColumnName("TKDOANHTHU");
            entity.Property(e => e.Tkgiavon)
                .HasMaxLength(50)
                .HasColumnName("TKGIAVON");
            entity.Property(e => e.Tkkm)
                .HasMaxLength(50)
                .HasColumnName("TKKM");
            entity.Property(e => e.Tksanphamdd)
                .HasMaxLength(50)
                .HasColumnName("TKSANPHAMDD");
            entity.Property(e => e.Tkvtu)
                .HasMaxLength(50)
                .HasColumnName("TKVTU");
            entity.Property(e => e.Toncuoikygt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("TONCUOIKYGT");
            entity.Property(e => e.Toncuoikysl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("TONCUOIKYSL");
            entity.Property(e => e.Tondaukygt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("TONDAUKYGT");
            entity.Property(e => e.Tondaukysl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("TONDAUKYSL");
            entity.Property(e => e.Trangthai)
                .HasDefaultValueSql("10")
                .HasColumnType("NUMBER")
                .HasColumnName("TRANGTHAI");
            entity.Property(e => e.Xbanamgt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XBANAMGT");
            entity.Property(e => e.Xbanamsl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XBANAMSL");
            entity.Property(e => e.Xbangt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XBANGT");
            entity.Property(e => e.Xbansl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XBANSL");
            entity.Property(e => e.Xchuyenkhogt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XCHUYENKHOGT");
            entity.Property(e => e.Xchuyenkhosl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XCHUYENKHOSL");
            entity.Property(e => e.Xdichdanhgt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XDICHDANHGT");
            entity.Property(e => e.Xdichdanhsl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XDICHDANHSL");
            entity.Property(e => e.Xdieuchinhgt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XDIEUCHINHGT");
            entity.Property(e => e.Xdieuchinhsl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XDIEUCHINHSL");
            entity.Property(e => e.Xkhacgt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XKHACGT");
            entity.Property(e => e.Xkhacsl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XKHACSL");
            entity.Property(e => e.Xkiemkegt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XKIEMKEGT");
            entity.Property(e => e.Xkiemkesl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XKIEMKESL");
            entity.Property(e => e.Xsxgt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XSXGT");
            entity.Property(e => e.Xsxsl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XSXSL");
            entity.Property(e => e.Xtaichegt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XTAICHEGT");
            entity.Property(e => e.Xtaichesl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XTAICHESL");
            entity.Property(e => e.Xtralaigt)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XTRALAIGT");
            entity.Property(e => e.Xtralaisl)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("XTRALAISL");
        });
        modelBuilder.HasSequence("BTKCCT_SEQ");
        modelBuilder.HasSequence("CTKTGTGTDVAO_SEQ");
        modelBuilder.HasSequence("CTUGOC_KEY_SEQ");
        modelBuilder.HasSequence("DM_TEST3_ID_SEQ");
        modelBuilder.HasSequence("DMGIADV_SEQ");
        modelBuilder.HasSequence("DMLOAIHOPDONG_SEQ");
        modelBuilder.HasSequence("DMLOAILAODONG_SEQ");
        modelBuilder.HasSequence("DMNHOMVITRI_SEQ");
        modelBuilder.HasSequence("DMVANBANXULY_SEQ");
        modelBuilder.HasSequence("DMVITRI_SEQ");
        modelBuilder.HasSequence("LICHDATNCC_SEQ");
        modelBuilder.HasSequence("SLBANLE_SEQ");
        modelBuilder.HasSequence("TRUNGBAYGDCHITIET_SEQ");
        modelBuilder.HasSequence("VATTUGDCT_SEQ");
        modelBuilder.HasSequence("VATTUGDDHCT_SEQ");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
