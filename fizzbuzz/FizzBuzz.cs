using System;

namespace fizzBuzz
{
    

    public class FizzBuzz{
       private int sayNumber;
        public String Shout()
        {
            if(sayNumber%3 ==0 && sayNumber%5 ==0){
                return "FizzBuzz";
            }
            if(sayNumber%3 ==0){
                return "Fizz";
            }
            if(sayNumber%5 ==0){
                return "Buzz";
            }    
            return sayNumber.ToString();  
        }
        public void inputNumber(int number)
        {
            sayNumber = number;
        }

    }
    


}