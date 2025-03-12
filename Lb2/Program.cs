namespace Lb2
{
    internal class Program
    {
        static void Main()
        {
            RegularUser regularUser = new RegularUser("Андрій", "Andre@gma.ua", "12345");
            Admin admin = new Admin("Макс", "Maxik@gma.ua", "54321");
            Moderator moderator = new Moderator("Влад", "VladIsLove@gma.ua", "55555");

            List<User> users = new List<User>();
            users.Add(regularUser);
            users.Add(admin);
            users.Add(moderator);

            foreach (var user in users)
            {
                user.DisplayInfo();
                if (user is RegularUser user1)
                    user1.PostComment("kerjgn;slrgn;ari");
                if (user is Admin admin1)
                    admin1.Authenticate("Maxik@gma.ua", "54321");
            }

            admin.BlockUser(admin);

           // regularUser.TryBlock(admin);

        }
    }
}
