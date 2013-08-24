namespace DTOs
{
    using System.Runtime.Serialization;


    public class  BasicResponse
    {
        
        public bool Success { get; set; }

      
        public string Message { get; set; }
   
        public Enums.ErrorCode ErrorCode { get; set; }
    }
}