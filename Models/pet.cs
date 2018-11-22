using Microsoft.AspNetCore.Mvc;
using System;
namespace DojoDachi.Models
{
    public class Pet
    {   
        public int fullness{get;set;}
        public int happiness{get;set;}
        public int meals{get;set;}
        public int energy{get;set;}

        public string PetHandler=null;
        public Pet()
        {
            this.fullness=20;
            this.happiness=20;
            this.meals=3;
            this.energy=50;
        }
        
        public string Feed(){
  
            if (this.meals>0)
            {
                Random chance=new Random();
                this.meals--;

                if (chance.Next(1,101)>25)
                {
                    Random random=new Random();
                    int increasedBy=random.Next(5,11);
                    this.fullness+=increasedBy;
                    // checking if the pet is still alive
                    string checking=WinOrDead();
                    if(checking!="Progress"){
                        return checking;
                    }
                    return "You Fed your Dojodachi. Fullness + "+increasedBy+", Meal -1";
                }
                return"Your Dojodachi did not like the food";
               
            }
            return "You do not have enough meal to Feed your Dojodachi";
        }
        public string Play(){
            
            if (this.energy>=5)
            {
                Random chance=new Random();
                this.energy-=5;
                if (chance.Next(1,101)>25)
                {
                    Random random=new Random();
                    int increasedBy=random.Next(5,11);
                    this.happiness+=increasedBy;

                    // checking if the pet is still alive
                    string checking=WinOrDead();
                    if(checking!="Progress"){
                        return checking;
                    }
                    return "You played with your Dojodachi. Happiness + "+increasedBy+", Energy -5";
                }

                return"Your Dojodachi did not like playing";
            }
            return "Your Dojodachi don't have the energy to play";
        }
        public string Work(){
            if (this.energy>=5)
            {
                this.energy-=5;
                Random random=new Random();
                int increasedBy=random.Next(1,4);
                this.meals+=increasedBy;

                // checking if the pet is still alive
                string checking=WinOrDead();
                if(checking!="Progress"){
                    return checking;
                }
                return"Your Dojodachi was rewarded with "+increasedBy+" meals, Energy -5";
            }
            return "Your Dojodachi don't have the energy to work";
        }
        public string Sleep(){

            this.energy+=15;
            this.fullness-=5;
            this.happiness-=5;

            // checking if the pet is still alive
            string checking=WinOrDead();
            if(checking!="Progress"){
                return checking;
            }
            return"Your Dojodachi got "+this.energy+" energy, Fullness -5, happiness -5";
            
        
        }
        public string WinOrDead(){
            if (this.fullness<1 || this.happiness<1)
            {
                PetHandler="Fail";
                return "Your Dojodachi hass passed away";
            }
            else if (this.energy>=100 && this.fullness>=100 && this.happiness>=100)
            {
                PetHandler="Won";
                return "Congratulations! You Won!";
            }
            PetHandler=null;
            return "Progress";
            
        }

        public void Restart(){
            this.fullness=20;
            this.happiness=20;
            this.meals=3;
            this.energy=50;
        }



    }
}