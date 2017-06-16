using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DatabaseManagementProject
{
    class Sorgular
    {
        SqlConnection myconnection = new SqlConnection("Data Source=DESKTOP-G51H1QD\\SQLEXPRESS;Initial Catalog=DatabaseManagementProject;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
       
        
        public int GirişPanel(string a,string b)
        {
            
            myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_LoginPage";
            sorgu.Parameters.AddWithValue("@UserName", a);
            sorgu.Parameters.AddWithValue("@Password",b);
            SqlDataReader dr = sorgu.ExecuteReader();
            int uid=0;
            if (dr.Read())
            {
                uid = Convert.ToInt32(dr["Uid"]);
                myconnection.Close();
                dr.Close();
                return uid;
            }
            else
            {
                myconnection.Close();
                dr.Close();
                return uid; 
            }
            
        }
        public void sp_insertBolum(string a)
        {
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_insertBolum";
            sorgu.Parameters.AddWithValue("@BolumAd", a);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public void sp_insertBirim(string a)
        {
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_insertBirim";
            sorgu.Parameters.AddWithValue("@Ubirim", a);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public void sp_insertAltU(int a,string b,int c)
        {
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_insertAltU";
            sorgu.Parameters.AddWithValue("@Uustid", a);
            sorgu.Parameters.AddWithValue("@Uisim", b);
            sorgu.Parameters.AddWithValue("@Ucarpan", c);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public string[] SelectBolumCBox()
        {
            myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            
            int sayac=countBolum();
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            string[] a = new string[sayac];
            int i = 0;
            sorgu.CommandText = "sp_SelectBolumCBox";
            SqlDataReader dr = sorgu.ExecuteReader();
            while(dr.Read())
            {
                a[i] = dr["Bisim"].ToString();
                i++;
            }
            myconnection.Close();
            return a;
            
        }
        public int countBolum()
        {
            if (myconnection.State==ConnectionState.Closed)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_countBolum";
            int a = 0;
            a = (Int32)sorgu.ExecuteScalar();
            myconnection.Close();
            return a;
        }
        public string[]SelectUnvanCbox()
        {
            myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;

            int sayac = countUstUnvan();
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            string[] a = new string[sayac];
            int i = 0;
            sorgu.CommandText = "sp_SelectUnvanCbox";
            SqlDataReader dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                a[i] = dr["Uisim"].ToString();
                i++;
            }
            myconnection.Close();
            return a;
        }
        public int countUstUnvan()
        {
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_countUstUnvan";
            int a = 0;
            a = (Int32)sorgu.ExecuteScalar();
            myconnection.Close();
            return a;
        }
        public string[]SelectAuCbox(string a)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            int sayac = countAu(a);
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            string[] array = new string[sayac]; 
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_SelectAuCbox";
            sorgu.Parameters.AddWithValue("@Uisim", a);
            SqlDataReader dr;
            
            dr = sorgu.ExecuteReader();
            int i=0;
            while(dr.Read())
            {
                array[i] = dr["Uisim"].ToString();
                i++;
            }
            myconnection.Close();
            return array;
        }
        public int countAu(string a)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_countAltUnvan";
            sorgu.Parameters.AddWithValue("Uisim", a);
            int b = 0;
            b = (Int32)sorgu.ExecuteScalar();
            myconnection.Close();
            return b;
        }
        public int countizin()
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_countizin";
            int b = 0;
            b = (Int32)sorgu.ExecuteScalar();
            myconnection.Close();
            return b;
        }
        public string[] SelectIzinCBox()
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            int sayac = countizin();
            myconnection.Close();
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            string[] b = new string[sayac];
            SqlCommand sorgu1 = new SqlCommand();
            sorgu1.Connection = myconnection;
            sorgu1.CommandType = CommandType.StoredProcedure;
            sorgu1.CommandText = "sp_SelectIname";
            
            SqlDataReader rd=sorgu1.ExecuteReader();
            
            int i = 0;
            while(rd.Read())
            {
                b[i] =(rd["Iisim"]).ToString();
                i++;
            }
            rd.Close();
            myconnection.Close();
            return b;
        }
        public string[] SelectMeslekCBox()
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            int sayac = CountMeslek();
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            string[] array = new string[sayac];
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_SelectMeslekCBox";
            SqlDataReader dr = sorgu.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                array[i] = dr["Misim"].ToString();
                i++;
            }
            myconnection.Close();
            return array;
            
        }
        public int CountMeslek()
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_CountMeslek";
            int b = 0;
            b = (Int32)sorgu.ExecuteScalar();
            myconnection.Close();
            return b;
        }
        public void Personel_Ekle(string Ptc,string Pisim,string Psoyisim,DateTime Pdogum,char Pcinsiyet,string Pmail,string Ptel,string Padres)
        {
            if(ConnectionState.Closed==myconnection.State)
            myconnection.Open();
            
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_SecreterPanel1";
            sorgu.Parameters.AddWithValue("@Ptc", Ptc);
            sorgu.Parameters.AddWithValue("@Pisim", Pisim);
            sorgu.Parameters.AddWithValue("@Psoyisim", Psoyisim);
            sorgu.Parameters.AddWithValue("@Pdogum", Pdogum);
            sorgu.Parameters.AddWithValue("@Pcinsiyet", Pcinsiyet);
            sorgu.Parameters.AddWithValue("@Pmail", Pmail);
            sorgu.Parameters.AddWithValue("@Ptel", Ptel);
            sorgu.Parameters.AddWithValue("@Padres", Padres);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public int FindPid(string Ptc)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_FindPid";
            sorgu.Parameters.AddWithValue("@Ptc", Ptc);
            int sayac = 0;
            SqlDataReader rd = sorgu.ExecuteReader();
            if (rd.Read())
            {
                sayac = Convert.ToInt32(rd["Pid"]);
            }
            rd.Close();
            myconnection.Close();
            return sayac;
        }
        public int FindBid(string a)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_SelectBid";
            sorgu.Parameters.AddWithValue("@Bisim",a);
            int sayac = 0;
            SqlDataReader rd = sorgu.ExecuteReader();
            if (rd.Read())
            {
                sayac = Convert.ToInt32(rd["Bid"]);
            }
            rd.Close();
            myconnection.Close();
            return sayac;
        }
        public void insertCalisirTable(int Pid,int Bid,DateTime Batarih)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_insertCalisirWithoutBiTable";
            sorgu.Parameters.AddWithValue("@Pid",Pid);
            sorgu.Parameters.AddWithValue("@Bid", Bid);
            sorgu.Parameters.AddWithValue("@Batarih", Batarih);
           
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public int findUid(string Uisim)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_FindUid";
            int sayac = 0;
            sorgu.Parameters.AddWithValue("@Uisim", Uisim);
            SqlDataReader rd = sorgu.ExecuteReader();
            if (rd.Read())
            {
                sayac = Convert.ToInt32(rd["Uid"]);

            }
            rd.Close();
            myconnection.Close();
            return sayac;
        }
        public void insertSahiptirpuTable(int Pid,int Uid)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_insertSahiptirpuTable";
            sorgu.Parameters.AddWithValue("@Uid", Uid);
            sorgu.Parameters.AddWithValue("@Pid", Pid);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public int FindMid(string a)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            int sayac = 0;
            sorgu.CommandText = "sp_FindMid";
            sorgu.Parameters.AddWithValue("@Misim", a);
            SqlDataReader rd = sorgu.ExecuteReader();
            if (rd.Read())
            {
                sayac = Convert.ToInt32(rd["Mid"]);
            }
            rd.Close();
            myconnection.Close();
            return sayac;
        }
        
        public void insertSahiptirTable(int m,int p)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_insertSahiptirTable";
            sorgu.Parameters.AddWithValue("@Mid", m);
            sorgu.Parameters.AddWithValue("@Pid", p);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public void insertMeslekTable(string a)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_insertMeslekTable";
            sorgu.Parameters.AddWithValue("@Misim",a);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public void insertAltU(string Uisim,int carpan) 
        {
            int Uustid;
            Uustid = findUid(Uisim);
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_insertAltU";
            sorgu.Parameters.AddWithValue("@Uustid",Uustid);
            sorgu.Parameters.AddWithValue("@Uisim",Uisim);
            sorgu.Parameters.AddWithValue("@Ucarpan",carpan);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public void UnvanEkleTableUst(string Uisim)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_UnvanEkleTableUst";
            sorgu.Parameters.AddWithValue("@Uisim", Uisim);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public void PersonelSil(int Pid)
        {
              if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_delPersonel";
            sorgu.Parameters.AddWithValue("@Pid", Pid);
            sorgu.ExecuteNonQuery();
        }
        public string sp_findUstUnvan(string Uisim)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_findUstUnvan";
            sorgu.Parameters.AddWithValue("@Uisim", Uisim);
            SqlDataReader rd = sorgu.ExecuteReader();
            string b="";
            if(rd.Read())
            {
                b = rd["Uisim"].ToString();
            }
            rd.Close();
            myconnection.Close();
            return b;
        }
        public int sp_finIid(string Iisim,DateTime Ibaslama,DateTime Ibitis)
        {
            int b = 0;
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_finIid";
            sorgu.Parameters.AddWithValue("@izin_isim", Iisim);
            sorgu.Parameters.AddWithValue("@Ibaslama", Ibaslama);
            sorgu.Parameters.AddWithValue("@Ibitis", Ibitis);
            SqlDataReader rd = sorgu.ExecuteReader();
            if(rd.Read())
            {
                b = Convert.ToInt32(rd["Iid"]);
            }
            rd.Close();
            myconnection.Close();
            return b;
        }
        public void sp_Update(int Pid,int Mid,int Bid,int Uid)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_UpdateCalisirTable";
            sorgu.Parameters.AddWithValue("@pid", Pid);
            sorgu.Parameters.AddWithValue("@Bid", Bid);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
            myconnection.Open();
            SqlCommand sorgu1 = new SqlCommand();
            sorgu1.Connection = myconnection;
            sorgu1.CommandType = CommandType.StoredProcedure;
            sorgu1.CommandText = "sp_updateSahiptirTable";
            sorgu1.Parameters.AddWithValue("@Mid", Mid);
            sorgu1.Parameters.AddWithValue("@Pid", Pid);
            sorgu1.ExecuteNonQuery();
            myconnection.Close();
            myconnection.Open();
            SqlCommand sorgu2 = new SqlCommand();
            sorgu2.Connection = myconnection;
            sorgu2.CommandType = CommandType.StoredProcedure;
            sorgu2.CommandText = "sp_updateSahiptirpuTable";
            sorgu2.Parameters.AddWithValue("@Uid", Uid);
            sorgu2.Parameters.AddWithValue("@Pid", Pid);
            sorgu2.ExecuteNonQuery();
            myconnection.Close();
         }
        public void sp_insertizinTable(string Iisim,DateTime Ibaslama,DateTime Ibitiş)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_insertizinTable";
            sorgu.Parameters.AddWithValue("@Iisim",Iisim);
            sorgu.Parameters.AddWithValue("@Ibaslama", Ibaslama);
            sorgu.Parameters.AddWithValue("@Ibitis", Ibitiş);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public void sp_insertAlırIpTable(int Pid,int Iid)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_insertAlırIpTable";
            sorgu.Parameters.AddWithValue("@Iid", Iid);
            sorgu.Parameters.AddWithValue("@Pid", Pid);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public int sp_CountBYonetici()
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();

            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_countByonetici";
            int b = (Int32)sorgu.ExecuteScalar();
            myconnection.Close();
            return b;
        }
        public string[] sp_FindBolumYonetici()
        {
            int sayac = sp_CountBYonetici();
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            string[] a = new string[sayac];
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_FindBolumYonetici";
            SqlDataReader rd = sorgu.ExecuteReader();
            int i=0;
            while (rd.Read())
            {
                a[i] = rd["Pisim"].ToString();
            }
            myconnection.Close();
            return a;
        }
        public string sp_FindFabrikaYonetici()
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();

            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_FindFabrikaYonetici";
            SqlDataReader rd = sorgu.ExecuteReader();
            string b = "";
            if (rd.Read())
            {
                b = rd["Pisim"].ToString();
            }
            rd.Close();
            myconnection.Close();
            return b;
        }
        public void TodayMaasOnayla(DateTime a)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_MaasOnay";
            sorgu.Parameters.AddWithValue("@Today", a);
            sorgu.ExecuteNonQuery();
            myconnection.Close();
        }
        public string[] sp_FindBU(string Ptc)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_FindBU";
            sorgu.Parameters.AddWithValue("@Ptc", Ptc);
            SqlDataReader rd=sorgu.ExecuteReader();
            string[] a = new string[2];
            if (rd.Read())
            {
                a[0] = rd["Bisim"].ToString();
                a[1] = rd["Uisim"].ToString();
            }
            myconnection.Close();
            return a;
        }
        public string sp_FindBYmail(int Bid)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_FindBYmail";
            string a="";
            sorgu.Parameters.AddWithValue("@Bid", Bid);
            SqlDataReader rd = sorgu.ExecuteReader();
            if(rd.Read())
            {
                a = rd["Pmail"].ToString();
            }
            return a;
 
        }
        public int sp_findBid_Bisim(String Bisim)
        {
            if (ConnectionState.Closed == myconnection.State)
                myconnection.Open();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = myconnection;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_findBid_Bisim";
            int a=0;
            sorgu.Parameters.AddWithValue("@Bisim", Bisim);
            a = (Int32)sorgu.ExecuteScalar();
            
            return a;
        }
        
    }
}
