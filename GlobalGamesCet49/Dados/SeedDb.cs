namespace GlobalGamesCet49.Dados
{
    using GlobalGamesCet49.Dados.Entidades;
    using GlobalGamesCet49.Helpers;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Linq;
    using System.Threading.Tasks;


    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly Random random;

        public SeedDb (DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();

        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("hugoglima1999@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Hugo",
                    LastName = "Lima",
                    Email = "hugoglima1999@gmail.com",
                };

                var result = await this.userHelper.AddUserAsync(user, "123456");

                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Couldn't create user in seed");
                }

            }

            if (!this.context.UserLogin.Any())
            {
                this.AddUserLogin("Tiago", user);
                this.AddUserLogin("Alex", user);
                this.AddUserLogin("Rodrigo", user);
                this.AddUserLogin("Vasco", user);
                this.AddUserLogin("Ana", user);

                await this.context.SaveChangesAsync();
            }
        }

        private void AddUserLogin(string nome, User user)
        {
            this.context.UserLogin.Add(new UserLogin
            {
                Name = nome,
                User = user
            });
        }
    }
}

