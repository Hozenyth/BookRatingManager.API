namespace BookRatingManager.Api.Models
{
    public class CreateRatingModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Score { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
