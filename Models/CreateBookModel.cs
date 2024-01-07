namespace BookRatingManager.Api.Models
{
    public class CreateBookModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description{ get; set; }
        public string Author { get; set; }
        public string Published{ get; set; }
        public string Pages{ get; set; }
        public string Isbn { get; set; }
        public string Year { get; set; }
        public DateTime Created { get; set; }
        public decimal AverageRating { get; set;}
      
    }

}
