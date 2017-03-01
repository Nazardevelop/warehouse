using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace warehouse_code
{
    [Serializable]
    public class Shipment:Base<Shipment>
    {
        [DataMember]
        public string Shname { get; set; }
        [DataMember]
        public int Amount { get; set; }
       [DataMember]
        public Organization Partner { get; set; }
       public List<Organization> Orgship
       {
           get
           {
               List<Organization> org = new List<Organization>();
               foreach (var or in Organization.N.Values)
               {
                   if (or.Ship.Shname == this.Shname)
                   {
                       org.Add(or);
                   }
               }
               return org;
           }
       }
       public List<Shipment_Organization> Orgsh
       {
           get
           {
               List<Shipment_Organization> orgsh = new List<Shipment_Organization>();
               foreach (var os in Shipment_Organization.N.Values)
               {
                   if (os.Shipment.Shname==this.Shname)
                   {
                       orgsh.Add(os);
                   }
               }
               return orgsh;
           }
       }
       public Shipment(string shname, int amount, Organization partner) :
           base()
       {
           Shname = shname;
           Amount = amount;
           Partner = partner;
       }
     
  
      
       public override string ToString()
       {
           return Shname + "..." + Amount+"-amount";
       }

    }
}
