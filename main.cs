using System;

class MainClass {
  public static void Main (string[] args) {
    int evenNumbers = 0;
    int oddNumbers = 0;
     Console.WriteLine ("Enter numbers or stop enter -1");
    while(true){
      
    int numbers = int.Parse(Console.ReadLine());
    if (numbers < 0 ){
      break;
    }
    if(numbers%2==0){
      evenNumbers++;
    }else{
oddNumbers++;
    }
    }
    Console.WriteLine ("even numbers :" + evenNumbers);
     Console.WriteLine ("odd numbers :" + oddNumbers);
  }
}