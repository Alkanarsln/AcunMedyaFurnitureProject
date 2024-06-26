namespace AcunMedyaFurnitureProject.DataAccess.Entities
{
    public class UserMessage
    {
        public int UserMessageID { get; set; }
        public string NameSurname { get; set; }
        public string Email{ get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
    }
}
