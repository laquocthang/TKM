﻿using System;

namespace FacadePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			TruongDaiHocDaLat dhdl = new TruongDaiHocDaLat();
			dhdl.DongTienHocPhi();
			dhdl.DangKyHocPhan();
			Console.ReadKey();
		}
	}

	/// <summary>
	/// System: Hệ thống Trường Đại học Đà Lạt
	/// </summary>
	class TruongDaiHocDaLat
	{
		QuanLyHocPhan hocPhan;
		QuanLySinhVien sinhVien;
		QuanLyTaiChinh taiChinh;

		public TruongDaiHocDaLat()
		{
			hocPhan = new QuanLyHocPhan();
			sinhVien = new QuanLySinhVien();
			taiChinh = new QuanLyTaiChinh();
		}

		/// <summary>
		/// Hệ thống đóng tiền học phí
		/// </summary>
		public void DongTienHocPhi()
		{
			Console.WriteLine("Cac hoat dong ben trong Dong tien hoc phi");
			taiChinh.DongTienHocPhi();
			sinhVien.CapNhatThongTinSinhVien();
		}

		/// <summary>
		/// Hệ thống đăng ký học phần
		/// </summary>
		public void DangKyHocPhan()
		{
			Console.WriteLine("Cac hoat dong ben trong Dang ky hoc phan");
			hocPhan.DangKyHocPhan();
			sinhVien.CapNhatThongTinSinhVien();
		}
	}

	/// <summary>
	/// Subsystem1: Hệ thống quản lý học phần
	/// </summary>
	class QuanLyHocPhan
	{
		public void DangKyHocPhan()
		{
			Console.WriteLine("\tDang ky hoc phan thanh cong");
		}
	}

	/// <summary>
	/// Subsystem2: Hệ thống quản lý sinh viên
	/// </summary>
	class QuanLySinhVien
	{
		public void CapNhatThongTinSinhVien()
		{
			Console.WriteLine("\tDa cap nhat thong tin");
		}
	}

	/// <summary>
	/// Subsystem3: Hệ thống quản lý tài chính
	/// </summary>
	class QuanLyTaiChinh
	{
		public void DongTienHocPhi()
		{
			Console.WriteLine("\tDong tien hoc phi thanh cong");
		}
	}

}
