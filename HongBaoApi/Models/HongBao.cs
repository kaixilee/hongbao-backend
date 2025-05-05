namespace HongBaoApi.Models
{
    public class HongBao
    {
        public int Id { get; set; } // Auto-increment ID
        public string Code { get; set; } = Guid.NewGuid().ToString(); // Unique string for URL
        public string Design { get; set; } = string.Empty; // ID of one of the designs
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}