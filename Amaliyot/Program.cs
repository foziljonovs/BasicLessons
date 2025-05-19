
using Amaliyot;

List<User> users = new List<User>();

int count = 1;
User user1 = new User(count,
    "Abdulvosid Foziljonov",
    19,
    "tahsimuz@gmail.com",
    "1234",
    "+998945666964");

users.Add(user1);
count++;

Console.WriteLine($"id: {user1.getId()}, ismi: {user1.FullName}");

User user2 = new User(count,
    "Zikrullo Yo'ldashev",
    15,
    "zikrullo11@gmail.com",
    "1234",
    "+998906667766");

users.Add(user2);
count++;

Console.WriteLine($"id: {user2.getId()}, ismi: {user2.FullName}");