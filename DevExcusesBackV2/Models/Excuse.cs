namespace DevExcusesBackV2.Models
{
    public class Excuse
    {
        public int ID { get; set; }
        public int Http_code { get; set; }
        public string? Tag { get; set; }
        public string Message { get; set; }

        public static int Ids;

        public Excuse()
        {
            this.ID = Interlocked.Increment(ref Ids);
        }
    }
}
