using Pattern;

var sing1 = Singleton.GetInstance();
WriteLine(sing1.RandomNumber);

var sing2 = Singleton.GetInstance();
WriteLine(sing2.RandomNumber);

WriteLine($"{nameof(sing1)} is equal to {nameof(sing2)}: {sing1 == sing2}");