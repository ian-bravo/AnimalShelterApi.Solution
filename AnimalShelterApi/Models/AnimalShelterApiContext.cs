using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Anya", Size = "Large", Sex = "Female", Age = 7 },
          new Cat { CatId = 2, Name = "Faith", Size = "Medium", Sex = "Female", Age = 10 },
          new Cat { CatId = 3, Name = "Willow", Size = "Medium", Sex = "Female", Age = 2 },
          new Cat { CatId = 4, Name = "Spike", Size = "Small", Sex = "Male", Age = 4 },
          new Cat { CatId = 5, Name = "Giles", Size = "Medium", Sex = "Male", Age = 10 }
        );

      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Beatrice", Size = "Large", Sex = "Female", Age = 5 },
          new Dog { DogId = 2, Name = "Winky", Size = "Small", Sex = "Male", Age = 3 },
          new Dog { DogId = 3, Name = "Hubert", Size = "Large", Sex = "Male", Age = 2 },
          new Dog { DogId = 4, Name = "Rhapsody", Size = "Large", Sex = "Female", Age = 4 },
          new Dog { DogId = 5, Name = "Jessica", Size = "Medium", Sex = "Female", Age = 7 }
        );
    }
  }
}