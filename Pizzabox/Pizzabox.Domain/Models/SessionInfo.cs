namespace Pizzabox.Domain.Models
{
    public static class SessionInfo
    {
        public static User CurrentUser { get; set; }
        public static Order CurrentOrder { get; set; }
    }
}