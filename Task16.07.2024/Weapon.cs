namespace Task16._07._2024
{
    public class Weapon
    {
        public int Id { get; set; } 
        public BulletType FireType { get; private set; }
        public int MaxBullets { get; private set; }
        private int currentBullets;

        public Weapon(BulletType fireType, int maxBullets)
        {
            FireType = fireType;
            MaxBullets = maxBullets;
            currentBullets = 0;
            Id = 0; 
        }

        public void Fire()
        {
            Console.WriteLine($"Fire Type: {FireType}, Bullets Left: {currentBullets}");
            currentBullets--;
        }

        public void Fill()
        {
            int bulletsToFill = MaxBullets - currentBullets;
            for (int i = 0; i < bulletsToFill; i++)
            {
                Bullet bullet = new Bullet(FireType);
                
                currentBullets++;
            }
        }

        public void PullTrigger()
        {
            if (currentBullets > 0)
            {
                Console.WriteLine($"Next Bullet Type: {FireType}");
            }
            else
            {
                Console.WriteLine("Out of bullets!");
            }
        }
    }
}
