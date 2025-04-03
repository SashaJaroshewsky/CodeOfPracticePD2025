namespace LB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy(100);
            BreakableWall wall = new BreakableWall(1000);

            LinkedList<IDamageable> damageables = new LinkedList<IDamageable>();
            damageables.AddLast(enemy);
            damageables.AddLast(wall);

            Bullet bullet = new Bullet(10);
            Rocket rocket = new Rocket(40);

            Projectile projectile = bullet;
            projectile = rocket;

            foreach (var objectDamage in damageables)
            {
                rocket.HitTarget(objectDamage);
            }
        }
    }
}
