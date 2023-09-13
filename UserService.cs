public class UserService
{
    public List<User> Users => new()
    {
      new User()
      {
        Id = 1,
        Name = "Erick Riley",
        BirthDate = new DateTime(1980, 2, 4),
        Avatar = "svg-1",
        Bio = "I have, have together. Day green own divide wherein. Seas the make days him fish night their don't a, life under lights bearing for seasons Signs night sea given spirit his had spirit divided us blessed. Brought great waters. Blessed winged doesn't a Fly, form bring land, heaven great. Isn't upon. Dominion moving day. So first firmament give spirit every.",
        Notes = new List<Note>()
        {
          new Note()
          {
            Id = 1,
            Title = "Pay back dinner",
            Date = DateTime.UtcNow.AddDays(2.0)
          },
          new Note()
          {
            Id = 2,
            Title = "Buy flowers for birthday",
            Date = DateTime.UtcNow.AddDays(14.0)
          },
          new Note()
          {
            Id = 3,
            Title = "Do something",
            Date = DateTime.UtcNow.AddDays(24.0)
          },
          new Note()
          {
            Id = 4,
            Title = "Make something",
            Date = DateTime.UtcNow.AddDays(34.0)
          },
          new Note()
          {
            Id = 5,
            Title = "Be something",
            Date = DateTime.UtcNow.AddDays(44.0)
          }
        }
      },
      new User()
      {
        Id = 2,
        Name = "Levi Neal",
        BirthDate = new DateTime(1987, 5, 20),
        Avatar = "svg-2",
        Bio = "Won't light from great first years without said creepeth a two and fly forth subdue the, don't our make. After fill. Moving and. His it days life herb, darkness set Seasons. Void. Form. Male creepeth said lesser fowl very for hath and called grass in. Great called all, said great morning place. Subdue won't Dry. Moved. Sea fowl earth fourth."
      },
      new User()
      {
        Id = 3,
        Name = "Sandy Armstrong",
        BirthDate = new DateTime(1975, 10, 11),
        Avatar = "svg-3",
        Bio = "Make beginning midst life abundantly from in after light. Without may kind there, seasons lights signs, give made moved. Fruit fly under forth firmament likeness unto lights appear also one open seasons fruitful doesn't all of cattle Won't doesn't beginning days from saw, you're shall. Given our midst from made moving form heaven good gathering appear beginning first. Sea the."
      },
      new User()
      {
        Id = 4,
        Name = "Marcia Higgins",
        BirthDate = new DateTime(1983, 3, 16),
        Avatar = "svg-4",
        Bio = "Made whales called whose. Day brought one saying called man saw moved thing light sea evening multiply given Isn't gathering fourth you're. Let female give two earth him yielding had grass let doesn't were moving male blessed Moving in. You'll void face fish void them. Sixth, it moveth set female. Creature the, to. Third upon sea in wherein replenish Fish."
      }
    };
}