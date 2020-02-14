using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Undergraduate : Student{

        protected bool Social_service;
        

        public Undergraduate() : base(){
            Social_service = false;
        }

        public Undergraduate(int Id, string Name, int Age, int tuition_fee, bool Socialservice)
            : base(Id, Name, Age, tuition_fee){

            this.Social_service = Social_service;
        
        }

        public override double Scolarship(double scolarship){
            base.Scolarship(scolarship);

            if (aux2 == "yes")
            {
                this.scolarship = this.scolarship + (15);

                this.tuition_fee = (1 - this.scolarship/100) * this.tuition_fee;
                return this.tuition_fee;
            }
            else {
                return 0;
            }

        }

        public override string ShowMenu(){

                return base.ShowMenu() + "\nTuition fee: $" +this.tuition_fee + " \nSocial Service: " +this.aux2;
        }




    }
}
