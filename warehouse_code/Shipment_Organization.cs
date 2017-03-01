using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse_code
{
   public class Shipment_Organization: Base<Shipment_Organization>
    {
       private Guid orgId;
       public Organization Organization
       {
           get { return Organization.N[orgId]; }
           set { orgId = value.Id; }
       }
       private Guid shipId;
       public Shipment Shipment
       {
           get { return Shipment.N[shipId]; }
           set { shipId = value.Id; }
       }
       public Shipment_Organization(Organization or, Shipment s)
       {
           Shipment = s;
           Organization = or;
       }
    }
}
