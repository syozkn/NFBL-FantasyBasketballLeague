using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigbang.classes
{
    [Serializable]
    public class team
    {
        
        public string name { get; set; }
        public Image logo { get; set; }
        public List<oyuncu> kadro { get; set; }

        public oyuncu pg1 { get; set; }
        public oyuncu pg2 { get; set; }
        public oyuncu sg1 { get; set; }
        public oyuncu sg2 { get; set; }
        public oyuncu sf1 { get; set; }

        public oyuncu sf2 { get; set; }
        public oyuncu pf1 { get; set; }
        public oyuncu pf2 { get; set; }
        public oyuncu c1 { get; set; }
        public oyuncu c2 { get; set; }
        public int skor { get; set; }
        public int playoffgalibiyet { get; set; }
        public int playoffgalibiyet2 { get; set; }
        public int finalgalibiyet { get; set; }
        public int sayi { get; set; }


        private int _overall;

        public int Overallteam
        {
            get {
                this._overall = ((this.pg1.Overall*14) + (this.pg2.Overall*6) + (this.sg1.Overall*14) + (this.sg2.Overall*6) + (this.sf1.Overall * 14) + (this.sf2.Overall*6) + (this.pf1.Overall*14) + (this.pf2.Overall*6) + (this.c1.Overall*14) + (this.c2.Overall*6)) / 100;



                
                
                
                
                return _overall; 
             }
        }

        private int _defoverall;

        public int defoverallteam
        {
            get
            {
                this._defoverall= (this.pg1.Defoverall + this.pg2.Defoverall + this.sg1.Defoverall + this.sg2.Defoverall + this.sf1.Defoverall + this.sf2.Defoverall + this.pf1.Defoverall + this.pf2.Defoverall + this.c1.Defoverall + this.c2.Defoverall) / 10;







                return _defoverall;
            }
        }

        private int _offoverall;

        public int offoverallteam
        {
            get
            {
                this._offoverall = (this.pg1.Offoverall + this.pg2.Offoverall + this.sg1.Offoverall + this.sg2.Offoverall + this.sf1.Offoverall + this.sf2.Offoverall + this.pf1.Offoverall + this.pf2.Offoverall + this.c1.Offoverall + this.c2.Offoverall) / 10;







                return _offoverall;
            }
        }

        private double _winpct;

        public double galibiyetorani
        {
            get {
                if (this.win != 0 )

                { this._winpct = this.win / (this.win + this.lose); }
                
                else if(this.win ==0)
                    { this._winpct = 0; }
                
                
                
                
                return _winpct; }
             
        }

        public double win { get; set; }
        public double lose { get; set; }

        public override string ToString()
        {
            return  this.win +"    "+ this.lose+"      " + this.name; 
        }

        public int salary { get; set; }

        public tactics taktik1 { get; set; }
        public tactics taktik2 { get; set; }
        public tactics taktik3 { get; set; }
        public tactics taktik4 { get; set; }
        public tactics standart { get; set; }
        
    }
}
