﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCH_ThucPham
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyBanHang")]
	public partial class qlTrungTamThuongMaiDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblChiTietHDBan(tblChiTietHDBan instance);
    partial void UpdatetblChiTietHDBan(tblChiTietHDBan instance);
    partial void DeletetblChiTietHDBan(tblChiTietHDBan instance);
    partial void InserttblPhanLoai(tblPhanLoai instance);
    partial void UpdatetblPhanLoai(tblPhanLoai instance);
    partial void DeletetblPhanLoai(tblPhanLoai instance);
    partial void InserttblHang(tblHang instance);
    partial void UpdatetblHang(tblHang instance);
    partial void DeletetblHang(tblHang instance);
    partial void InserttblHDBan(tblHDBan instance);
    partial void UpdatetblHDBan(tblHDBan instance);
    partial void DeletetblHDBan(tblHDBan instance);
    partial void InserttblKhach(tblKhach instance);
    partial void UpdatetblKhach(tblKhach instance);
    partial void DeletetblKhach(tblKhach instance);
    partial void InserttblNhanVien(tblNhanVien instance);
    partial void UpdatetblNhanVien(tblNhanVien instance);
    partial void DeletetblNhanVien(tblNhanVien instance);
    #endregion
		
		public qlTrungTamThuongMaiDataContext() : 
				base(global::QLCH_ThucPham.Properties.Settings.Default.QLBanHangConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public qlTrungTamThuongMaiDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlTrungTamThuongMaiDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlTrungTamThuongMaiDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlTrungTamThuongMaiDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblChiTietHDBan> tblChiTietHDBans
		{
			get
			{
				return this.GetTable<tblChiTietHDBan>();
			}
		}
		
		public System.Data.Linq.Table<tblPhanLoai> tblPhanLoais
		{
			get
			{
				return this.GetTable<tblPhanLoai>();
			}
		}
		
		public System.Data.Linq.Table<tblHang> tblHangs
		{
			get
			{
				return this.GetTable<tblHang>();
			}
		}
		
		public System.Data.Linq.Table<tblHDBan> tblHDBans
		{
			get
			{
				return this.GetTable<tblHDBan>();
			}
		}
		
		public System.Data.Linq.Table<tblKhach> tblKhaches
		{
			get
			{
				return this.GetTable<tblKhach>();
			}
		}
		
		public System.Data.Linq.Table<tblNhanVien> tblNhanViens
		{
			get
			{
				return this.GetTable<tblNhanVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblChiTietHDBan")]
	public partial class tblChiTietHDBan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHDBan;
		
		private string _MaHang;
		
		private double _SoLuong;
		
		private double _DonGia;
		
		private double _GiamGia;
		
		private double _ThanhTien;
		
		private EntityRef<tblHang> _tblHangs;
		
		private EntityRef<tblHDBan> _tblHDBans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDBanChanging(string value);
    partial void OnMaHDBanChanged();
    partial void OnMaHangChanging(string value);
    partial void OnMaHangChanged();
    partial void OnSoLuongChanging(double value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaChanging(double value);
    partial void OnDonGiaChanged();
    partial void OnGiamGiaChanging(double value);
    partial void OnGiamGiaChanged();
    partial void OnThanhTienChanging(double value);
    partial void OnThanhTienChanged();
    #endregion
		
		public tblChiTietHDBan()
		{
			this._tblHangs = default(EntityRef<tblHang>);
			this._tblHDBans = default(EntityRef<tblHDBan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHDBan", DbType="NVarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHDBan
		{
			get
			{
				return this._MaHDBan;
			}
			set
			{
				if ((this._MaHDBan != value))
				{
					this.OnMaHDBanChanging(value);
					this.SendPropertyChanging();
					this._MaHDBan = value;
					this.SendPropertyChanged("MaHDBan");
					this.OnMaHDBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHang
		{
			get
			{
				return this._MaHang;
			}
			set
			{
				if ((this._MaHang != value))
				{
					this.OnMaHangChanging(value);
					this.SendPropertyChanging();
					this._MaHang = value;
					this.SendPropertyChanged("MaHang");
					this.OnMaHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Float NOT NULL")]
		public double SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Float NOT NULL")]
		public double DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiamGia", DbType="Float NOT NULL")]
		public double GiamGia
		{
			get
			{
				return this._GiamGia;
			}
			set
			{
				if ((this._GiamGia != value))
				{
					this.OnGiamGiaChanging(value);
					this.SendPropertyChanging();
					this._GiamGia = value;
					this.SendPropertyChanged("GiamGia");
					this.OnGiamGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Float NOT NULL")]
		public double ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblChiTietHDBan_tblHang", Storage="_tblHangs", ThisKey="MaHang", OtherKey="MaHang", IsUnique=true, IsForeignKey=false)]
		public tblHang tblHangs
		{
			get
			{
				return this._tblHangs.Entity;
			}
			set
			{
				tblHang previousValue = this._tblHangs.Entity;
				if (((previousValue != value) 
							|| (this._tblHangs.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblHangs.Entity = null;
						previousValue.tblChiTietHDBan = null;
					}
					this._tblHangs.Entity = value;
					if ((value != null))
					{
						value.tblChiTietHDBan = this;
					}
					this.SendPropertyChanged("tblHangs");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblChiTietHDBan_tblHDBan", Storage="_tblHDBans", ThisKey="MaHDBan", OtherKey="MaHDBan", IsUnique=true, IsForeignKey=false)]
		public tblHDBan tblHDBans
		{
			get
			{
				return this._tblHDBans.Entity;
			}
			set
			{
				tblHDBan previousValue = this._tblHDBans.Entity;
				if (((previousValue != value) 
							|| (this._tblHDBans.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblHDBans.Entity = null;
						previousValue.tblChiTietHDBan = null;
					}
					this._tblHDBans.Entity = value;
					if ((value != null))
					{
						value.tblChiTietHDBan = this;
					}
					this.SendPropertyChanged("tblHDBans");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblPhanLoai")]
	public partial class tblPhanLoai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaPhanLoai;
		
		private string _TenPhanLoai;
		
		private EntitySet<tblHang> _tblHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPhanLoaiChanging(string value);
    partial void OnMaPhanLoaiChanged();
    partial void OnTenPhanLoaiChanging(string value);
    partial void OnTenPhanLoaiChanged();
    #endregion
		
		public tblPhanLoai()
		{
			this._tblHangs = new EntitySet<tblHang>(new Action<tblHang>(this.attach_tblHangs), new Action<tblHang>(this.detach_tblHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhanLoai", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaPhanLoai
		{
			get
			{
				return this._MaPhanLoai;
			}
			set
			{
				if ((this._MaPhanLoai != value))
				{
					this.OnMaPhanLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaPhanLoai = value;
					this.SendPropertyChanged("MaPhanLoai");
					this.OnMaPhanLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenPhanLoai", DbType="NVarChar(50)")]
		public string TenPhanLoai
		{
			get
			{
				return this._TenPhanLoai;
			}
			set
			{
				if ((this._TenPhanLoai != value))
				{
					this.OnTenPhanLoaiChanging(value);
					this.SendPropertyChanging();
					this._TenPhanLoai = value;
					this.SendPropertyChanged("TenPhanLoai");
					this.OnTenPhanLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblPhanLoai_tblHang", Storage="_tblHangs", ThisKey="MaPhanLoai", OtherKey="MaPhanLoai")]
		public EntitySet<tblHang> tblHangs
		{
			get
			{
				return this._tblHangs;
			}
			set
			{
				this._tblHangs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblHangs(tblHang entity)
		{
			this.SendPropertyChanging();
			entity.tblPhanLoai = this;
		}
		
		private void detach_tblHangs(tblHang entity)
		{
			this.SendPropertyChanging();
			entity.tblPhanLoai = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblHang")]
	public partial class tblHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHang;
		
		private string _TenHang;
		
		private string _MaPhanLoai;
		
		private double _SoLuong;
		
		private double _DonGiaNhap;
		
		private double _DonGiaBan;
		
		private string _Anh;
		
		private string _GhiChu;
		
		private EntityRef<tblChiTietHDBan> _tblChiTietHDBan;
		
		private EntityRef<tblPhanLoai> _tblPhanLoai;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHangChanging(string value);
    partial void OnMaHangChanged();
    partial void OnTenHangChanging(string value);
    partial void OnTenHangChanged();
    partial void OnMaPhanLoaiChanging(string value);
    partial void OnMaPhanLoaiChanged();
    partial void OnSoLuongChanging(double value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaNhapChanging(double value);
    partial void OnDonGiaNhapChanged();
    partial void OnDonGiaBanChanging(double value);
    partial void OnDonGiaBanChanged();
    partial void OnAnhChanging(string value);
    partial void OnAnhChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
		
		public tblHang()
		{
			this._tblChiTietHDBan = default(EntityRef<tblChiTietHDBan>);
			this._tblPhanLoai = default(EntityRef<tblPhanLoai>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHang
		{
			get
			{
				return this._MaHang;
			}
			set
			{
				if ((this._MaHang != value))
				{
					if (this._tblChiTietHDBan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHangChanging(value);
					this.SendPropertyChanging();
					this._MaHang = value;
					this.SendPropertyChanged("MaHang");
					this.OnMaHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenHang
		{
			get
			{
				return this._TenHang;
			}
			set
			{
				if ((this._TenHang != value))
				{
					this.OnTenHangChanging(value);
					this.SendPropertyChanging();
					this._TenHang = value;
					this.SendPropertyChanged("TenHang");
					this.OnTenHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhanLoai", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaPhanLoai
		{
			get
			{
				return this._MaPhanLoai;
			}
			set
			{
				if ((this._MaPhanLoai != value))
				{
					if (this._tblPhanLoai.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPhanLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaPhanLoai = value;
					this.SendPropertyChanged("MaPhanLoai");
					this.OnMaPhanLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Float NOT NULL")]
		public double SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGiaNhap", DbType="Float NOT NULL")]
		public double DonGiaNhap
		{
			get
			{
				return this._DonGiaNhap;
			}
			set
			{
				if ((this._DonGiaNhap != value))
				{
					this.OnDonGiaNhapChanging(value);
					this.SendPropertyChanging();
					this._DonGiaNhap = value;
					this.SendPropertyChanged("DonGiaNhap");
					this.OnDonGiaNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGiaBan", DbType="Float NOT NULL")]
		public double DonGiaBan
		{
			get
			{
				return this._DonGiaBan;
			}
			set
			{
				if ((this._DonGiaBan != value))
				{
					this.OnDonGiaBanChanging(value);
					this.SendPropertyChanging();
					this._DonGiaBan = value;
					this.SendPropertyChanged("DonGiaBan");
					this.OnDonGiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anh", DbType="NVarChar(200)")]
		public string Anh
		{
			get
			{
				return this._Anh;
			}
			set
			{
				if ((this._Anh != value))
				{
					this.OnAnhChanging(value);
					this.SendPropertyChanging();
					this._Anh = value;
					this.SendPropertyChanged("Anh");
					this.OnAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(200)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblChiTietHDBan_tblHang", Storage="_tblChiTietHDBan", ThisKey="MaHang", OtherKey="MaHang", IsForeignKey=true)]
		public tblChiTietHDBan tblChiTietHDBan
		{
			get
			{
				return this._tblChiTietHDBan.Entity;
			}
			set
			{
				tblChiTietHDBan previousValue = this._tblChiTietHDBan.Entity;
				if (((previousValue != value) 
							|| (this._tblChiTietHDBan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblChiTietHDBan.Entity = null;
						previousValue.tblHangs = null;
					}
					this._tblChiTietHDBan.Entity = value;
					if ((value != null))
					{
						value.tblHangs = this;
						this._MaHang = value.MaHang;
					}
					else
					{
						this._MaHang = default(string);
					}
					this.SendPropertyChanged("tblChiTietHDBan");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblPhanLoai_tblHang", Storage="_tblPhanLoai", ThisKey="MaPhanLoai", OtherKey="MaPhanLoai", IsForeignKey=true)]
		public tblPhanLoai tblPhanLoai
		{
			get
			{
				return this._tblPhanLoai.Entity;
			}
			set
			{
				tblPhanLoai previousValue = this._tblPhanLoai.Entity;
				if (((previousValue != value) 
							|| (this._tblPhanLoai.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblPhanLoai.Entity = null;
						previousValue.tblHangs.Remove(this);
					}
					this._tblPhanLoai.Entity = value;
					if ((value != null))
					{
						value.tblHangs.Add(this);
						this._MaPhanLoai = value.MaPhanLoai;
					}
					else
					{
						this._MaPhanLoai = default(string);
					}
					this.SendPropertyChanged("tblPhanLoai");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblHDBan")]
	public partial class tblHDBan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHDBan;
		
		private string _MaNhanVien;
		
		private System.DateTime _NgayBan;
		
		private string _MaKhach;
		
		private double _TongTien;
		
		private EntityRef<tblChiTietHDBan> _tblChiTietHDBan;
		
		private EntityRef<tblNhanVien> _tblNhanVien;
		
		private EntityRef<tblKhach> _tblKhach;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDBanChanging(string value);
    partial void OnMaHDBanChanged();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    partial void OnNgayBanChanging(System.DateTime value);
    partial void OnNgayBanChanged();
    partial void OnMaKhachChanging(string value);
    partial void OnMaKhachChanged();
    partial void OnTongTienChanging(double value);
    partial void OnTongTienChanged();
    #endregion
		
		public tblHDBan()
		{
			this._tblChiTietHDBan = default(EntityRef<tblChiTietHDBan>);
			this._tblNhanVien = default(EntityRef<tblNhanVien>);
			this._tblKhach = default(EntityRef<tblKhach>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHDBan", DbType="NVarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHDBan
		{
			get
			{
				return this._MaHDBan;
			}
			set
			{
				if ((this._MaHDBan != value))
				{
					if (this._tblChiTietHDBan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHDBanChanging(value);
					this.SendPropertyChanging();
					this._MaHDBan = value;
					this.SendPropertyChanged("MaHDBan");
					this.OnMaHDBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					if (this._tblNhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayBan", DbType="DateTime NOT NULL")]
		public System.DateTime NgayBan
		{
			get
			{
				return this._NgayBan;
			}
			set
			{
				if ((this._NgayBan != value))
				{
					this.OnNgayBanChanging(value);
					this.SendPropertyChanging();
					this._NgayBan = value;
					this.SendPropertyChanged("NgayBan");
					this.OnNgayBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhach", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaKhach
		{
			get
			{
				return this._MaKhach;
			}
			set
			{
				if ((this._MaKhach != value))
				{
					if (this._tblKhach.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhachChanging(value);
					this.SendPropertyChanging();
					this._MaKhach = value;
					this.SendPropertyChanged("MaKhach");
					this.OnMaKhachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Float NOT NULL")]
		public double TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblChiTietHDBan_tblHDBan", Storage="_tblChiTietHDBan", ThisKey="MaHDBan", OtherKey="MaHDBan", IsForeignKey=true)]
		public tblChiTietHDBan tblChiTietHDBan
		{
			get
			{
				return this._tblChiTietHDBan.Entity;
			}
			set
			{
				tblChiTietHDBan previousValue = this._tblChiTietHDBan.Entity;
				if (((previousValue != value) 
							|| (this._tblChiTietHDBan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblChiTietHDBan.Entity = null;
						previousValue.tblHDBans = null;
					}
					this._tblChiTietHDBan.Entity = value;
					if ((value != null))
					{
						value.tblHDBans = this;
						this._MaHDBan = value.MaHDBan;
					}
					else
					{
						this._MaHDBan = default(string);
					}
					this.SendPropertyChanged("tblChiTietHDBan");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblNhanVien_tblHDBan", Storage="_tblNhanVien", ThisKey="MaNhanVien", OtherKey="MaNhanVien", IsForeignKey=true)]
		public tblNhanVien tblNhanVien
		{
			get
			{
				return this._tblNhanVien.Entity;
			}
			set
			{
				tblNhanVien previousValue = this._tblNhanVien.Entity;
				if (((previousValue != value) 
							|| (this._tblNhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblNhanVien.Entity = null;
						previousValue.tblHDBans.Remove(this);
					}
					this._tblNhanVien.Entity = value;
					if ((value != null))
					{
						value.tblHDBans.Add(this);
						this._MaNhanVien = value.MaNhanVien;
					}
					else
					{
						this._MaNhanVien = default(string);
					}
					this.SendPropertyChanged("tblNhanVien");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblKhach_tblHDBan", Storage="_tblKhach", ThisKey="MaKhach", OtherKey="MaKhach", IsForeignKey=true)]
		public tblKhach tblKhach
		{
			get
			{
				return this._tblKhach.Entity;
			}
			set
			{
				tblKhach previousValue = this._tblKhach.Entity;
				if (((previousValue != value) 
							|| (this._tblKhach.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblKhach.Entity = null;
						previousValue.tblHDBans.Remove(this);
					}
					this._tblKhach.Entity = value;
					if ((value != null))
					{
						value.tblHDBans.Add(this);
						this._MaKhach = value.MaKhach;
					}
					else
					{
						this._MaKhach = default(string);
					}
					this.SendPropertyChanged("tblKhach");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblKhach")]
	public partial class tblKhach : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhach;
		
		private string _TenKhach;
		
		private string _DiaChi;
		
		private string _DienThoai;
		
		private EntitySet<tblHDBan> _tblHDBans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhachChanging(string value);
    partial void OnMaKhachChanged();
    partial void OnTenKhachChanging(string value);
    partial void OnTenKhachChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    #endregion
		
		public tblKhach()
		{
			this._tblHDBans = new EntitySet<tblHDBan>(new Action<tblHDBan>(this.attach_tblHDBans), new Action<tblHDBan>(this.detach_tblHDBans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhach", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKhach
		{
			get
			{
				return this._MaKhach;
			}
			set
			{
				if ((this._MaKhach != value))
				{
					this.OnMaKhachChanging(value);
					this.SendPropertyChanging();
					this._MaKhach = value;
					this.SendPropertyChanged("MaKhach");
					this.OnMaKhachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhach", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenKhach
		{
			get
			{
				return this._TenKhach;
			}
			set
			{
				if ((this._TenKhach != value))
				{
					this.OnTenKhachChanging(value);
					this.SendPropertyChanging();
					this._TenKhach = value;
					this.SendPropertyChanged("TenKhach");
					this.OnTenKhachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblKhach_tblHDBan", Storage="_tblHDBans", ThisKey="MaKhach", OtherKey="MaKhach")]
		public EntitySet<tblHDBan> tblHDBans
		{
			get
			{
				return this._tblHDBans;
			}
			set
			{
				this._tblHDBans.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblHDBans(tblHDBan entity)
		{
			this.SendPropertyChanging();
			entity.tblKhach = this;
		}
		
		private void detach_tblHDBans(tblHDBan entity)
		{
			this.SendPropertyChanging();
			entity.tblKhach = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblNhanVien")]
	public partial class tblNhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNhanVien;
		
		private string _TenNhanVien;
		
		private string _GioiTinh;
		
		private string _DiaChi;
		
		private string _DienThoai;
		
		private System.DateTime _NgaySinh;
		
		private EntitySet<tblHDBan> _tblHDBans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    partial void OnTenNhanVienChanging(string value);
    partial void OnTenNhanVienChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnNgaySinhChanging(System.DateTime value);
    partial void OnNgaySinhChanged();
    #endregion
		
		public tblNhanVien()
		{
			this._tblHDBans = new EntitySet<tblHDBan>(new Action<tblHDBan>(this.attach_tblHDBans), new Action<tblHDBan>(this.detach_tblHDBans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhanVien", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNhanVien
		{
			get
			{
				return this._TenNhanVien;
			}
			set
			{
				if ((this._TenNhanVien != value))
				{
					this.OnTenNhanVienChanging(value);
					this.SendPropertyChanging();
					this._TenNhanVien = value;
					this.SendPropertyChanged("TenNhanVien");
					this.OnTenNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime NOT NULL")]
		public System.DateTime NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblNhanVien_tblHDBan", Storage="_tblHDBans", ThisKey="MaNhanVien", OtherKey="MaNhanVien")]
		public EntitySet<tblHDBan> tblHDBans
		{
			get
			{
				return this._tblHDBans;
			}
			set
			{
				this._tblHDBans.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblHDBans(tblHDBan entity)
		{
			this.SendPropertyChanging();
			entity.tblNhanVien = this;
		}
		
		private void detach_tblHDBans(tblHDBan entity)
		{
			this.SendPropertyChanging();
			entity.tblNhanVien = null;
		}
	}
}
#pragma warning restore 1591