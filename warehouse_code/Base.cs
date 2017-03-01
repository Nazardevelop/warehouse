using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MySql.Data.MySqlClient;
namespace warehouse_code
{ 
    [Serializable]
    public class Base<T> where T : Base<T>
    {
        public static Dictionary<Guid, T> N = new Dictionary<Guid, T>();
        public Guid Id { get; private set; }
        public Base()
        {
            Id = Guid.NewGuid();
            N.Add(Id, (T)this);
        }
        public static void Serialize()
        {
            XmlWriter XmlWriter = XmlWriter.Create(typeof(T).Name + ".xml");
            DataContractSerializer DataCS = new DataContractSerializer(typeof(Dictionary<Guid, T>));
            DataCS.WriteObject(XmlWriter, N);
            XmlWriter.Close();
        }
        public static void DeSerialize()
        {
            XmlReader XmlReader = XmlReader.Create(typeof(T).Name + ".xml");
            DataContractSerializer DataCS = new DataContractSerializer(typeof(Dictionary<Guid, T>));
            try
            {
                N = (Dictionary<Guid, T>)DataCS.ReadObject(XmlReader);
            }
            catch { }
            finally
            {
                XmlReader.Close();
            }
        }
        //public static void MySqlSerialize()
        //{
        //    string myConnection = "datasource=localhost;port=3306;username=root;password=0979770461";
        //    MySqlConnection myConnect = new MySqlConnection(myConnection);
        //    MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
        //    myDataAdapter.SelectCommand = new MySqlCommand("select * database.edata;", myConnect);
        //    MySqlCommandBuilder myCommandBuilder = new MySqlCommandBuilder(myDataAdapter);
        //    myConnect.Open();
            

        //}
    }
}
