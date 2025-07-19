//List<int> score = new List<int> { 70, 40, 80, 50, 10, 5, 60, 30, 90, 20 };

//var sortedScores = score.OrderBy(s => s).ToList();

//foreach(var s in sortedScores)
//    Console.WriteLine(s);

//var sortedScores = score
//    .OrderBy(s => s)
//    .Where(s => s > 50).ToList();

//foreach (var s in sortedScores)
//    Console.WriteLine(s);

//score.Sort();
//var sortedScores = score.OrderByDescending(s => s).ToList();

//foreach (var s in score)
//    Console.WriteLine(s);

//var sortedScores = score.Where(s => s > 50).ToList();

//foreach (var s in sortedScores)
//    Console.WriteLine(s);

//var totalScore = score.Where(x => x < 50).Sum();

//Console.WriteLine(totalScore);

//var sortedScores = score.First(s => s < 20);
//Console.WriteLine(sortedScores);

//var sorted = score
//    .FirstOrDefault(x => x < 3);

//Console.WriteLine(sorted);

//var sorted = score
//    .Select(x => x % 3 == 0)
//    .ToList();

//foreach(var s in sorted)
//    Console.WriteLine(s);

//var sorted = score
//    .Count(x => x % 3 == 0);

//Console.WriteLine(sorted);

//var sorted = score
//    .Any(x => x % 4 == 0); //result: true

//Console.WriteLine(sorted);

//var sorted = score
//    .All(x => x % 4 == 0); //result: false

//Console.WriteLine(sorted);

//var sorted = score
//    .Any(x => x.Equals(100) || x.Equals(10)); //true

//Console.WriteLine(sorted);

//var sorted = score
//    .FindAll(x => x > 50);

//foreach(var s in sorted)
//    Console.WriteLine(s);

//var sorted = score
//    .FindLast(x => x < 50);

//Console.WriteLine(sorted);