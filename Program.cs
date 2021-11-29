// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome Chief!");
Console.WriteLine("S/N\tTODO\tCompleted?\tDate & Time Created\tDate & Time Updated");
Console.ReadLine();


namespace TODO_List
 {  
   public class To_do : IComparable<To_do>  
   {  
     public int TODO_ID { get; set; }  
      public string Task { get; set; } 
     public DateTime date { get; set; }  
     
    
     public To_do(int TODO_ID, DateTime date, string Task)  
     {  
       this.TODO_ID = TODO_ID;  
       this.dateCreated = date;  
       this.dateUpdated = date;  
       this.Task = Task;  
 
   }
   
