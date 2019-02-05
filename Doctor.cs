using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5A
{
    /// <summary>
    /// This class contains information on how to create a doctor object
    /// </summary>
    class Doctor
    {
        public int ordinal { get; set; }        //ordinal of a doctor
        public string actor { get; set; }       //actor of a docor
        public int series { get; set; }         //series of a doctor
        public int age { get; set; }            //age of a doctor
        public string debut { get; set; }       //debut of a doctor

        

        public Doctor(int ordinal, string actor, int series, int age, string debut)
        {
            this.ordinal = ordinal;
            this.actor = actor;
            this.series = series;
            this.age = age;
            this.debut = debut;
        }
    }
}
