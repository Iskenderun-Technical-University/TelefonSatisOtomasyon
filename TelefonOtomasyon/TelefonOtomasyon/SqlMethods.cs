using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TelefonOtomasyon
{
    class SqlMethods
    {
        SqlConnection _connect = new SqlConnection("Data Source=LAPTOP-HJULEJT3\\SQLEXPRESS;Initial Catalog=Telefon;Integrated Security=True");
        private void ConnectionControl()
        {
            if (_connect.State == System.Data.ConnectionState.Closed)
                _connect.Open();
        }
        public Telefon TelefonGetir(int ID)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from telefon WHERE ID=@id", _connect);
            command.Parameters.AddWithValue("@id",ID);
            SqlDataReader reader = command.ExecuteReader();
            Telefon telefon = new Telefon();
            while (reader.Read())
            {

                telefon._ID = int.Parse(reader["ID"].ToString());
                telefon.marka = reader["marka"].ToString();
                telefon.model = reader["model"].ToString();
                telefon.dahiliHafiza = reader["dahiliHafiza"].ToString();
                telefon.pilGucu = reader["pilGucu"].ToString();
                telefon.ekranBoyut = reader["ekranBoyut"].ToString();
                telefon.ram = reader["ram"].ToString();
                telefon.kameraCozunurluk = reader["kameraCozunurluk"].ToString();
                telefon.mobilBaglantiTipi = reader["mobilBaglantiTipi"].ToString();
                telefon.garanti = reader["garanti"].ToString();
                telefon.fiyat = reader["fiyat"].ToString();
            }
            reader.Close();
            return telefon;
        }
        public List<Telefon> TelefonListGet()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from telefon", _connect);
            SqlDataReader reader = command.ExecuteReader();

            List<Telefon> telefons = new List<Telefon>();
            while (reader.Read())
            {
                Telefon telefon = new Telefon()
                {
                    _ID = int.Parse(reader["ID"].ToString()),
                    marka = reader["marka"].ToString(),
                    model = reader["model"].ToString(),
                    dahiliHafiza = reader["dahiliHafiza"].ToString(),
                    pilGucu = reader["pilGucu"].ToString(),
                    ekranBoyut = reader["ekranBoyut"].ToString(),
                    ram = reader["ram"].ToString(),
                    kameraCozunurluk = reader["kameraCozunurluk"].ToString(),
                    mobilBaglantiTipi = reader["mobilBaglantiTipi"].ToString(),
                    garanti = reader["garanti"].ToString(),
                    fiyat = reader["fiyat"].ToString(),

                };
                telefons.Add(telefon);
            }
            reader.Close();
            return telefons;
        }
        public DataTable SatisVeriCek()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from satislar", _connect);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SatisAra(string kelime)
        {

            ConnectionControl();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand("select * from satislar where tcKimlik=@x or isim=@x or soyisim=@x or telefon=@x or marka=@x or model=@x or hafiza=@x or fiyat=@x or fiyat=@x", _connect);
                command.Parameters.AddWithValue("@x", kelime);
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            return dt;
        }
        public DataTable TelefonVeriCek()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from telefon", _connect);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable TelefonAra(string kelime)
        {

            ConnectionControl();
            DataTable dt = new DataTable();
            try
            {


                SqlCommand command = new SqlCommand("select * from telefon where marka=@x or dahiliHafiza=@x or pilGucu=@x or ekranBoyut=@x or ram=@x or kameraCozunurluk=@x or mobilBaglantiTipi=@x or garanti=@x or fiyat=@x ", _connect);
                command.Parameters.AddWithValue("@x", kelime);
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            return dt;
        }
        public void TelefonEkle(Telefon telefon)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO telefon VALUES (@mar,@mod,@haf,@pil,@ekr,@ram,@kam,@bag,@gar,@fiy)", _connect);
            command.Parameters.AddWithValue("@mar", telefon.marka);
            command.Parameters.AddWithValue("@mod", telefon.model);
            command.Parameters.AddWithValue("@haf", telefon.dahiliHafiza);
            command.Parameters.AddWithValue("@pil", telefon.pilGucu);
            command.Parameters.AddWithValue("@ekr", telefon.ekranBoyut);
            command.Parameters.AddWithValue("@ram", telefon.ram);
            command.Parameters.AddWithValue("@kam", telefon.kameraCozunurluk);
            command.Parameters.AddWithValue("@bag", telefon.mobilBaglantiTipi);
            command.Parameters.AddWithValue("@gar", telefon.garanti);
            command.Parameters.AddWithValue("@fiy", telefon.fiyat);
            command.ExecuteNonQuery();
        }
        public void TelefonUpdate(Telefon telefon)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("UPDATE telefon SET marka=@mar, model=@mod, dahiliHafiza=@haf,pilGucu=@pil,ekranBoyut=@ekr,ram=@ram,kameraCozunurluk=@kam,mobilBaglantiTipi=@bag,garanti=@gar,fiyat=@fiy WHERE ID=@id; ", _connect);
            command.Parameters.AddWithValue("@mar", telefon.marka);
            command.Parameters.AddWithValue("@mod", telefon.model);
            command.Parameters.AddWithValue("@haf", telefon.dahiliHafiza);
            command.Parameters.AddWithValue("@pil", telefon.pilGucu);
            command.Parameters.AddWithValue("@ekr", telefon.ekranBoyut);
            command.Parameters.AddWithValue("@ram", telefon.ram);
            command.Parameters.AddWithValue("@kam", telefon.kameraCozunurluk);
            command.Parameters.AddWithValue("@bag", telefon.mobilBaglantiTipi);
            command.Parameters.AddWithValue("@gar", telefon.garanti);
            command.Parameters.AddWithValue("@fiy", telefon.fiyat);
            command.Parameters.AddWithValue("@id", telefon._ID);
            command.ExecuteNonQuery();
        }
        public void TelefonSil(int ID) 
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("DELETE FROM telefon WHERE ID=@id",_connect);
            command.Parameters.AddWithValue("@id",ID);
            command.ExecuteNonQuery();

        }

        public void SatisYap(string TC, string AD,string SOYAD,string TEL,string MARKA,string MODEL,string HAFIZA,string FIYAT)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO satislar VALUES (@tc,@ad,@soy,@tel,@mar,@mod,@haf,@fiy)", _connect);
            command.Parameters.AddWithValue("@tc", TC);
            command.Parameters.AddWithValue("@ad", AD);
            command.Parameters.AddWithValue("@soy", SOYAD);
            command.Parameters.AddWithValue("@tel", TEL);
            command.Parameters.AddWithValue("@mar", MARKA);
            command.Parameters.AddWithValue("@mod", MODEL);
            command.Parameters.AddWithValue("@haf", HAFIZA);
            command.Parameters.AddWithValue("@fiy", FIYAT);
            command.ExecuteNonQuery();
        }
    }
}
