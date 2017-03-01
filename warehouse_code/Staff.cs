using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace warehouse_code
{[Serializable]
   public class Staff:Base<Staff>
    {
        [DataMember]
        public string Post { get; set; }
        [DataMember]
        public Organization Org { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SName { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }
        public Staff(string post, string name, string sname, string sex, DateTime birthday, Organization org) :
            base()
        {
            Post = post;
            Org = org;
            Name = name;
            SName = sname;
            Sex = sex;
            Birthday = birthday;
           // N.Add(Id, this);
        }
        public override string ToString()
        {
            return SName + "..." + Post+"..."+Org;
        }
        

    }
}
