namespace Tournament_Management_System.Models
{
    public class Sportsmodal
    {
        public int Tournament_Id { get; set; }
        public string? Tournament_type { get; set; }
        public string? Tournament_name { get; set; }
        public int? Maximum_players { get; set; }
        public int? Total_prizes_count { get; set; }
        public int? First_price_amount { get; set; }
        public int? Second_price_count { get; set; }
        public int? Consolation_prize_amount { get; set; }
    }
}

