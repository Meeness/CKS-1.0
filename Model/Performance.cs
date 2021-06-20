using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Performance{
        public List<Stat> Stats {get;set;}
        public Performance(Client client)
        {
            Stats = new List<Stat>{};
            Stats.Add(new Stat("Shots Fired"));//Shots fired **not on list**
            Stats.Add(new Stat("Hits"));//Hits
            Stats.Add(new Stat("Accuracy", ()=>Stats[1].GetValue() / ((Stats[0].GetValue()>0)?Stats[0].GetValue():1)));//Accuracy
            Stats.Add(new Stat("Shields Used"));//Shields used
            Stats.Add(new Stat("Hit Points", ()=>BitConverter.ToInt16(client.LWInv.Items.Find(x=>x.Id==0x22).ConvertValueTo4Byte()))); //hp
            Stats.Add(new Stat("Cartridges", ()=>BitConverter.ToInt16(client.LWInv.Items.Find(x=>x.Id==0x50).ConvertValueTo4Byte())));//bullets
            Stats.Add(new Stat("Clips", ()=>BitConverter.ToInt16(client.LWInv.Items.Find(x=>x.Id==0x4f).ConvertValueTo4Byte())));//clips
            
        }
    }
}