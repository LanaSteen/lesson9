using Abs_Interface.Models;

namespace Abs_Interface
{
    internal class Program
    {

      /*  თქვენ ქმნით საავტომობილო სისტემას, სადაც მანქანებს შეიძლება ჰქონდეთ განსხვავებული ქცევა.ყველა მანქანას აქვს Drive() მეთოდი, მაგრამ ზოგიერთი ტიპის სატრანსპორტო საშუალებებს(მაგ., მანქანა, სატვირთო, ველოსიპედი) სჭირდება დამატებითი მეთოდი, როგორიცაა LoadCargo() (სატვირთო მანქანებისთვის) ან RingBell() (ველოსიპედებისთვის). ზოგიერთ მანქანას აქვს საწვავის საერთო წყარო(მაგ., ავტომობილი და სატვირთო მანქანა იყენებს საწვავს, მაგრამ ველოსიპედი არა).
 
შექმენით საბაზისო ტიპი ყველა მანქანისთვის, დარწმუნდით, რომ თითოეულ მანქანას აქვს Drive() მეთოდი.
შექმენით მმინიმუმ სამი ტიპის სატრანსპორტო საშუალების ობიექტი(მანქანა, სატვირთო, ველოსიპედი), უნიკალური ქცევით(როგორიცაა LoadCargo() სატვირთო მანქანებისთვის).
უნდა გამოიყენოთ აბსტრაქტული კლასებიც და ინტერფეისებიც*/


        static void Main(string[] args)
        {
            //Lion lion = new Lion();
            //lion.MakeSound();


            Truck truck = new Truck();
            truck.LoadCargo();
            truck.UseGas();

            LightCar lightCar = new LightCar();
            lightCar.UseGas();


            Bike bike = new Bike();
            bike.RingBell();





        }
    }


    


}



















abstract public class Anymal  //ანუ არაკონკრეტული ანუ ვერ შევუქმნით ობიექქტებს
 {
    public string Name { get; set;}
    public abstract void MakeSound();
 }


public class Lion : Anymal
{
    public override void MakeSound()
    {
        Console.WriteLine("moo");
   }
}


public abstract class Bird
{
  public abstract void Fly();
}
public class Eagle : Bird
{
   public override void Fly()
    {
        Console.Write("");
    }
}
public class Pinguin : Bird
{
    public override void Fly()
    {
        Console.Write("");
    }
}

// რადგან კლასებს ორმაგი მემკვიდრეობა არ შეუძლიათ ამიმტომ გვჭირდება ინტერფეისი

//ინნტერფეისს ივსევე როგორც აბსტრაქტულ კლასებს არ აქვთ new ანუ არ აქვთ კონკრეტუული სახე, ინტერფეისი ბუნებრივად აბსტრაქტულია

public interface IFyer
{
   public void Fly();
    //public string Name { get; set;}

}

public class Begura : Bird, IFyer
{
       
    // void IFyer.Fly()
    //{
    //    Console.WriteLine("");
    //}
    public override void Fly()
    {
        Console.WriteLine("");
    }
}