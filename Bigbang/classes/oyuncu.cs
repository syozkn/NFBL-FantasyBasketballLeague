using Bigbang.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bigbang.classes
{
    [Serializable]
    public class oyuncu
    {
        public string name { get; set; }
        public position pozisyon { get; set; }
        public Image foto { get; set; }

        public int ucluk { get; set; }
        public int ikilik { get; set; }
        public int asist { get; set; }
        public int steal { get; set; }
        public int block { get; set; }
        public int rebound { get; set; }

        public special spec { get; set; }
        

        public int stamina { get; set; }

        //stats
        public int SPoint { get; set; }
        public int SAsist { get; set; }
        public int SSteal { get; set; }
        public int SRebound { get; set; }
        public int SBlock { get; set; }
        public int Sgirenikilik { get; set; }
        public int Stoplamikilik { get; set; }
        public int Sgirenucluk { get; set; }
        public int Stoplamucluk { get; set; }
        public int Xpoint { get; set; }
        public int XBlock { get; set; }
        public int Xpoint3 { get; set; }
        public string Asyedek { get; set; }

        //toplamstats
        public int tpoint { get; set; }
        public int tasist { get; set; }
        public int tblock { get; set; }
        public int trebound { get; set; }
        public int tsteal { get; set; }

        public int tekpoint { get; set; }
        public int tekasist { get; set; }
        public int tekblock { get; set; }
        public int tekrebound { get; set; }
        public int teksteal { get; set; }



        private int _offoverall;

        public int Offoverall
        {
            get { if (this.ucluk > this.ikilik)
                {
                    this._offoverall = ((this.ucluk * 13) + (this.asist * 7)) / 20;

                }

                else
                {
                    this._offoverall = ((this.ikilik * 13) + (this.asist * 7)) / 20;
                }




                return this._offoverall;
            }

        }

        private int _defoverall;

        public int Defoverall
        {
            get {
                if (this.block > this.steal)
                {
                    this._defoverall = ((this.block * 13) + (this.rebound * 7)) / 20;
                }
                else
                {
                    this._defoverall = ((this.steal * 15) + (this.rebound * 5)) / 20;
                }








                return _defoverall; }
        }
        private int _overall;

        public int Overall
        {
            get { return this._overall = (this.Offoverall + this.Defoverall) / 2; }

        }
        private int _salary;
        public int salary
        {
            get
            {
                if (this.Overall > 85)
                {
                    this._salary = 35;
                }
                else if (this.Overall > 82)
                {
                    this._salary = 30;
                }
                else if (this.Overall > 79)
                {
                    this._salary = 25;
                }
                else if (this.Overall > 74)
                {
                    this._salary = 20;
                }
                else if (this.Overall > 70)
                {
                    this._salary = 15;
                }
                else if (this.Overall >= 65)
                {
                    this._salary = 10;
                }
                else if (this.Overall < 65 && this.Overall>2)
                {
                    this._salary = 5;
                }
                else if (this.Overall==0)
                {
                    this._salary = 0;
                }
                else this._salary = 0;
                return _salary;
            }
            set { this._salary = value; }

        }

    }   
    

}
