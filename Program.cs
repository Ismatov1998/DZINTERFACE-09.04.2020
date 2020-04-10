
using System;
namespace myNameSpace
{
  class Programm
 { 
   static void Main()
  {
   Player Student=new Player();
   Student.play();
   Student.pause();
   Student.stop();
   Student.Record();
   Student.Pause();
   Student.Stop();

  }

 }
  interface IPlayable
  {
      void play()
      {

      }
      void pause()
      {

      }
      void stop()
      {
        
      }
    }  
    interface IRecodable
    {
         void Record()
        {

        }
        void Pause() 
        {

        }
        void Stop()
        {

        }
    }
    class Player:IPlayable,IRecodable
    { 
    public void play()
      {
       Console.WriteLine("play");
      }
    public void pause()
    {
     Console.WriteLine("pause");
    }
   public void stop()
    {
       Console.WriteLine("stop"); 
    }
       
    public void Record()        
    {
      Console.WriteLine("Record");
    }
    public void Pause() 
    {
     Console.WriteLine("Pause");
    }
    public void Stop()
    {
      Console.WriteLine("Stop");
    }
      
    } 
}
