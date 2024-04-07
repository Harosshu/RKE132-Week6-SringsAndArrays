//string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" };

//Random rnd = new Random();

//int randomIndex = rnd.Next(0, snacks.Length);

//Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");

string[] colors = { "red", "green", "blue", "pink", "yellow" };

Random rnd = new Random();
int randomIndex = rnd.Next(0, colors.Length);
string randomColor = colors[randomIndex];

Console.WriteLine($"You should wear {randomColor} today.");