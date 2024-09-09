namespace TicketPricing2
{
    public class CalcTicketPrice
    {
        public static int calcticketprice(int s, int e)
        {
            int calc = e - s;

            int price;

            if (calc > 1 && calc < 9)
            {
                return price = 8;
            }
            else if (calc > 9 && calc < 16)
            {
                return price = 10;
            }
            else if (calc > 16)
            {
                return price = 15;
            }

            return 0;

        }
    }
}
