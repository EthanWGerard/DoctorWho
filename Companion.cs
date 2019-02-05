using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5A
{
    /// <summary>
    /// this class contains information on how to create a companion
    /// </summary>
    class Companion
    {
        public string name { get; set; }        //name of a companion
        public string performer { get; set; }   //performer of a companion
        public int doctor { get; set; }         //doctor of a companion
        public string debut { get; set; }       //debut of a companion
       
        public Companion(string name, string actor, int doctor, string debut )
        {
            this.name = name;
            this.performer = actor;
            this.doctor = doctor;
            this.debut = debut;
        }
    }
}
