namespace TicketPricing2.models
{
    public class StationLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StationId { get; set; }
        public Station Station { get; set; }
        public Boolean istransition { get; set; }

    }
}
