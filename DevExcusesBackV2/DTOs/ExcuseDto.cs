namespace DevExcusesBackV2.DTOs
{
    public class ExcuseDto
    {
        public int ID { get; set; }
        public int Http_code { get; set; }
        public string? Tag { get; set; }
        public string Message { get; set; }

        public ExcuseDto()
        {
            
        }

        public ExcuseDto(ExcuseDto excuse)
        {
            Http_code = excuse.Http_code;
            Message = excuse.Message;
        }
    }
}
