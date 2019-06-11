namespace DatingApp2.API.Models
{
    public class Like
    {
        public int LikerId { get; set; } //id usera koji lajka nekog usera
        public int LikeeId { get; set; } // id od usera koji je lajkan od nekog usera
        public User Liker { get; set; }
        public User Likee { get; set; }
    }
}