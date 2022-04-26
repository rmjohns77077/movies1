using movies1;

var DumbandDumber = new Movie();
DumbandDumber.Title = "Dumb and Dumber";
DumbandDumber.Genre = "Comedy";

var Taken=new Movie();
Taken.Title = "Taken";
Taken.Genre = "Suspense";

var MightyDucks = new Movie();
MightyDucks.Title = "Might Ducks";
MightyDucks.Genre = "Comedy";

List<Movie>movies=new List<Movie>();
movies.Add(DumbandDumber);
movies.Add(Taken);  
movies.Add(MightyDucks);

Console.WriteLine("What Genre are you looking at?");
var genre =Console.ReadLine();
var moviesgenre = movies.Where(m => m.Genre == genre);

Console.WriteLine($"Just the  {genre} movies");

