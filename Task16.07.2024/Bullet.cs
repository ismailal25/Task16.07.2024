namespace Task16._07._2024
{
    public class Bullet
    {
        
    public int Id { get; set; } 
        public BulletType Type { get; set; }

        public Bullet(BulletType type)
        {
            Type = type;
            Id = 0; 
        }
    }
}

