
//////////  Task1 /////////////



// using System;

// class Program{
//      static void Main(){
//         string first_name = "Maryam";
//         int Age = 28;
//         double  favorite_number = 2;
//         Console.WriteLine($"\nHello, my name is {first_name}. I am {Age} years old, and my favorite number is {favorite_number}.");

//     }
// }



//////////  Task2 /////////////


// using System;

// class Program{
//      static void Main(){
//         int[] InputNumber = new int[5]; 
//         Console.WriteLine("Enter any 5 numbers you like:");
//         for(int i=0; i < InputNumber.Length ; i++){
//             InputNumber[i]=Convert.ToInt32(Console.ReadLine());
//         }

//         foreach(int PrintNum in InputNumber){
//             Console.WriteLine("Valu in Array: "+PrintNum);
//         }

//     }
// }


//////////  Task3 /////////////


// using System;

// class Program{
//      static void Main(){
//         Console.WriteLine("Enter any number:");
//         int InputNumber =Convert.ToInt32(Console.ReadLine());
//         if(IsEven(InputNumber)==true){
//             Console.WriteLine("The number is: Even");
//         }else{Console.WriteLine("The number is: Odd");}


//         bool IsEven(int number){
//             float R = number%2;
//             if (R ==0 ){
//                 return true;
//             }else{
//                 return false;
//             }
//         }

//     }
// }


//////////  Task4 /////////////


// using System;

// class Program{
//      static void Main(){
//         Console.WriteLine("Enter your age:");
//         int InputNumber =Convert.ToInt32(Console.ReadLine());
       
//        if(InputNumber <=12){
//             Console.WriteLine("You are a child");
//         }else if(InputNumber >= 13 && InputNumber <= 17){
//             Console.WriteLine("You are a teenager");
//         }else if(InputNumber >= 18){
//             Console.WriteLine("You are an adult");
//         }

//     }
// }


//////////  Task5 /////////////


// using System;

// class Program{
//      static void Main(){
//         Console.WriteLine("Enter number between 1 and 12:");
//         int InputNumber =Convert.ToInt32(Console.ReadLine());

//         switch(InputNumber){

//             case (1):
//             Console.WriteLine(" the moth is January");
//             break;

//             case 2:
//             Console.WriteLine(" the moth is FEB");
//             break;

//             case 3:
//             Console.WriteLine(" the moth is March");
//             break;

//             case 4:
//             Console.WriteLine(" the moth is April");
//             break;

//             case 5:
//             Console.WriteLine(" the moth is May");
//             break;

//             case 6:
//             Console.WriteLine(" the moth is Jun");
//             break;

//             case 7:
//             Console.WriteLine(" the moth is July");
//             break;

//             case 8:
//             Console.WriteLine(" the moth is augest");
//             break;

//             case 9:
//             Console.WriteLine(" the moth is Septemper");
//             break;

//             case 10:
//             Console.WriteLine(" the moth is Octoper");
//             break;

//             case 11:
//             Console.WriteLine(" the moth is November");
//             break;

//             case 12:
//             Console.WriteLine(" the moth is Decmber");
//             break;

//             default: 
//             Console.WriteLine("Try agin");
//             break;
//         }
//     }
// }





//////////  Task4 /////////////


using System;

class Program{
     static void Main(){
        Console.WriteLine("Enter number between 1 and 12:");
        Book Book1 = new Book("5am club", "Name of the arther", 45);
        Book Book2 = new Book("7 habit", "Steven cofe", 30);
        Book Book3 = new Book("اليقظه الذهنيه", "محمد", 60);
        
        Book1.PrintDetails();
        Book2.PrintDetails();
        Book3.PrintDetails();
    }
}

class Book {
    string Title;
    string Author;
    double Price;

    public Book(string _Title, string _Author, double _Price){
        Title = _Title;
        Author = _Author;
        Price = _Price;
    }

    public void PrintDetails(){
        Console.WriteLine($"\nTitle: {Title}, Author: {Author}, Price: {Price}");
    }
}