using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace warehouse_code
{
    [Serializable]
   public class Organization:Base<Organization>
    {
       [DataMember]
       public string Orname { get; set; }
       public Shipment Ship { get; set; }
       //private Guid OrgId;
       public List<Shipment> Shipor
       {
           get
           {
               List<Shipment> res = new List<Shipment>();
               foreach (var sh in Shipment.N.Values)
               {
                   if (sh.Partner.Orname == this.Orname)
                   {
                       res.Add(sh);
                   }
               }
               return res;
           }
       }
       public List<Staff>Staffor
       {
            get
            {
                List<Staff> resultList = new List<Staff>();
                foreach (var st in Staff.N.Values) 
                {
                    if (st.Org.Orname == this.Orname)
                    {
                        resultList.Add(st);
                    }
                }
                return resultList;
            }
        }
       public List<Shipment_Organization> ShOrg
       {
           get
           {
               List<Shipment_Organization> resso = new List<Shipment_Organization>();
               foreach (var so in Shipment_Organization.N.Values)
               {
                   if (so.Organization.Orname == this.Orname)
                   {
                       resso.Add(so);
                   }
               }
               return resso;

           }
       }
       public Organization(string orname):
           base()
       {
           Orname = orname;
       }
       public override string ToString()
       {
           return Orname;
       }
    }
}
