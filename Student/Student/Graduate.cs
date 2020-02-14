using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
     class Graduate : Student{

        public int SNI_level;
        private int flag;
        public Graduate() : base() {
            SNI_level = 0;

        }

        public Graduate(int Id, string Name, int Age, int tuition_fee, int SNI_level) 
            : base(Id,Name,Age,tuition_fee){

            this.SNI_level = SNI_level;

            Check_SNI(SNI_level);
        }

        public bool Check_SNI(int SNI_Level) {

            if (SNI_level == 1 || SNI_level == 2)
            {
                flag = 1;
                return true;
            }
            else if (SNI_level == 3)
            {
                flag = 3;
                return true;

            }

            else {
                return false;
            }
           
        }

        public override string ShowMenu()
        {
            return base.ShowMenu() + "\nTuition fee: $" + this.tuition_fee + "\nSNI Level: " + this.SNI_level;
        }

        public override double Scolarship(double scolarship)
        {
            base.Scolarship(scolarship);

            if (Check_SNI(SNI_level) == true)
            {

                if (flag == 1)
                {
                    this.scolarship = this.scolarship + (15);
                    this.tuition_fee = (1 - this.scolarship / 100) * this.tuition_fee;
                    return this.tuition_fee;
                }
                else if (flag == 3)
                {
                    this.scolarship = this.scolarship + (30);

                    this.tuition_fee = (1 - this.scolarship / 100) * this.tuition_fee;
                    return this.tuition_fee;
                }
            }

            return 0;
        }
    }
}
