using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace HK1_2020_2021_1.Models
{
    public class DataContext
    {
        public string ConnectionString { get; set; }

        public DataContext(string conn)
        {
            this.ConnectionString = conn;
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public int ThemCanHo(CanHoModel ch)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                var query = "insert into canho values(@macanho,@tencanho)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("macanho", ch.MaCanHo);
                cmd.Parameters.AddWithValue("tencanho", ch.TenCanHo);
                return (cmd.ExecuteNonQuery());
            }
        }

        public List<object> LayNhanVien(int solansua)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"select nv.soDT, nv.manhanvien,count(nv.maNhanVien) as solan
                                from NhanVien nv, NV_BT
                                where nv.maNhanVien = NV_BT.MaNhanVien
                                group by nv.maNhanVien, nv.soDT
                                having count(nv.maNhanVien) >= @solansua";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("solansua", solansua);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            MaNV = reader["manhanvien"].ToString(),
                            SoDT = reader["soDT"].ToString(),
                            SoLan = Convert.ToInt32(reader["solan"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<NhanVienModel> LayTenNV()
        {
            List<NhanVienModel> list = new List<NhanVienModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from NhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVienModel()
                        {
                            MaNhanVien = reader["maNhanVien"].ToString(),
                            TenNhanVien = reader["tenNhanVien"].ToString(),
                            SoDienThoai = reader["soDT"].ToString(),
                            GioiTinh = Convert.ToInt32(reader["gioiTinh"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<NV_BT> LietKeThietBi(string maNV)
        {
            List<NV_BT> list = new List<NV_BT>();
            using(SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from NV_BT where MaNhanVien = @manv";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("manv", maNV);
                using ( var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NV_BT
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            MaThietBi = reader["MaThietBi"].ToString(),
                            MaCanHo = reader["MaCanHo"].ToString(),
                            LanThu = Convert.ToInt32(reader["LanThu"]),
                            NgayBaoTri = (DateTime)(reader["NgayBaoTri"])
                        }) ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public int xoaBaoTri(NV_BT bt)
        {
            var count = 0;
            using(SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"delete from nv_bt where MaNhanVien = @manv and MaThietBi = @matb
                                and MaCanHo=@mach and LanThu=@lanthu";
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("manv", bt.MaNhanVien);
                cmd.Parameters.AddWithValue("matb", bt.MaThietBi);
                cmd.Parameters.AddWithValue("mach", bt.MaCanHo);
                cmd.Parameters.AddWithValue("lanthu", bt.LanThu);
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public NV_BT Lay_NV_BT(NV_BT bt)
        {
            NV_BT bt_show = new NV_BT();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"select * from NV_BT where MaNhanVien = @manv and MaThietBi = @matb
                                and MaCanHo=@mach and LanThu=@lanthu";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("manv", bt.MaNhanVien);
                cmd.Parameters.AddWithValue("matb", bt.MaThietBi);
                cmd.Parameters.AddWithValue("mach", bt.MaCanHo);
                cmd.Parameters.AddWithValue("lanthu", bt.LanThu);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bt_show.MaNhanVien = reader["MaNhanVien"].ToString();
                        bt_show.MaThietBi = reader["MaThietBi"].ToString();
                        bt_show.MaCanHo = reader["MaCanHo"].ToString();
                        bt_show.LanThu = Convert.ToInt32(reader["LanThu"]);
                        bt_show.NgayBaoTri = (DateTime)(reader["ngaybaotri"]);
                    };
                }
                conn.Close();
            }
            return bt_show;
        }

        public void CapNhap_NV_BT(NV_BT bt)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"UPDATE NV_BT
                                 SET NGAYBAOTRI = @ngaybaotri
                                    where manhanvien = @manv 
                                          and macanho = @mach
                                          and mathietbi = @matb
                                          and lanthu = @lanthu;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("manv", bt.MaNhanVien);
                cmd.Parameters.AddWithValue("matb", bt.MaThietBi);
                cmd.Parameters.AddWithValue("mach", bt.MaCanHo);
                cmd.Parameters.AddWithValue("lanthu", bt.LanThu);
                cmd.Parameters.AddWithValue("ngaybaotri", bt.NgayBaoTri);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

