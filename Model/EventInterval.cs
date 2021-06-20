using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class EventHandler{

        //eventlist from a new eventclass
        public EventHandler()
        {
            
        }
        public void AddEvent(Player player, EventType eventInt){
            //events -> LW,    CK,     LW,    LW,   LW,     LW
            //events -> Start, Shield, Shoot, hit, Killed, End

            switch(eventInt){
                case EventType.Shield:
                    //add event to eventlist
                    player.Performance.Stats[3].Value++;
                    break;
                case EventType.Shoot:
                    //add event to eventlist
                    player.Performance.Stats[0].Value++;
                    break;
                case EventType.Shot:
                    //add event to eventlist
                    player.Performance.Stats[1].Value++;
                    break;
            }
        }
        public enum EventType{
            Start = 0,
            Shield,
            Shoot,
            Shot,
            Killed,
            End,
        }
    }
}