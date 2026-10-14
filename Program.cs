const int secPerDay = 24*60*60; //Start date is January 1st, 1970
const int secPerYear = 365*secPerDay;

long epoch = 54721080000;

long years = epoch / secPerYear;
long days = (epoch - years * secPerYear) / secPerDay;

Console.WriteLine(epoch + " seconds -> " + years + " years and " + days + " days");