namespace BookApi.Models{
    public class BookItem{
        public long Id {get; set;}
        public string title {get; set;}
        public string isbn {get; set;}
        public string author{get; set;}
        public string genre{get; set;}
        public int rating{get; set;}
    }
}