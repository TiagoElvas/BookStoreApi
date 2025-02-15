
namespace BookApi.Models // object book structure
{

    public class Book
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int YearReleased { get; set; }



    public Book(int id, string name, string author, int YearReleased){
        this.Id = id;
        this.Name = name;
        this.Author = author;
        this.YearReleased = YearReleased;
    }

    }
}