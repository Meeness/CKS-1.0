using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Stat{
        private static int _autoIncrement = 1;

        public int Id{get;private set;}
        public string Name{get;set;}
        public double Value{get;set;}
        public GetValueDel GetValue{get;set;}
        public Stat(string name, GetValueDel getvalue)
        {
            Id=_autoIncrement;
            _autoIncrement++;
            Name=name;
            GetValue=getvalue;
        }
        public Stat(string name){
            Id=_autoIncrement;
            _autoIncrement++;
            Name=name;
            Value=0;
            GetValue=()=>Value;
        }
    }
    public delegate double GetValueDel();
}