namespace InsuranceProgram.Layers.Persistence
{
    public class Variables
    {
        public static string UserId { get; set; }
        public static int UserRole { get; set; }
        public static string ClientId { get; set; }
        public static string ClientName { get; set; }
        public static string ClientEmail { get; set; }
        public static int PolicyID { get; set; }
        public static string PolicyDescription { get; set; }
        //Coverage Variables
        public static decimal CoverageAmount { get; set; }
        public static int CoverageId { get; set; }
        public static string CoverageDescription { get; set; }
    }
}
