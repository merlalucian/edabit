using System;
public class Program 
{
    public static int MinTurns(string current, string target) 
    {
			
        int rotation = 0; 
			
        int input_digit, code_digit; 
		int	input =  Convert.ToInt32(current);
		int	unlock_code = Convert.ToInt32(target);
  
      
        while (input > 0 ||  
               unlock_code > 0) 
        { 
  
   
            input_digit = input % 10; 
            code_digit = unlock_code % 10; 
  
           
            rotation += Math.Min(Math.Abs(input_digit - 
                        code_digit), 10 - Math.Abs( 
                        input_digit - code_digit)); 
  
           
            input /= 10; 
            unlock_code /= 10; 
        } 
  
        return rotation; 
    } 
    }
