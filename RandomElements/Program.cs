string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takaeaway" };

Random rnd= new Random();

int RandomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat: {snacks[RandomIndex]}");