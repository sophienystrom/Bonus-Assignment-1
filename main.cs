using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine ("Give length of side 1 of triangle:");
  var side1 = Console.ReadLine ();
  Console.WriteLine ("Give length of side 2 of triangle"); 
  var side2 = Console.ReadLine ();
  Console.WriteLine ("Give length of side 3 of triangle");
  var side3 = Console.ReadLine ();

  int s1 = Convert.ToInt32 (side1);
  int s2 = Convert.ToInt32 (side2);
  int s3 = Convert.ToInt32 (side3);

  var combo1 = (s1 + s2);
  var combo2 = (s1 + s3);
  var combo3 = (s2 + s1);
  var combo4 = (s2 + s3);
  var combo5 = (s3 + s1);
  var combo6 = (s3 + s2);
  var combo7 = (s1);
  var combo8 = (s2);
  var combo9 = (s3);

  if ( combo1 > combo9 ||  combo2 > combo8 || combo3 > combo9 || combo4 > combo7 || combo5 > combo8 || combo6 > combo7) {
  Console.WriteLine ("Triangle can be formed"); }

  else if ( combo1 <= combo9 ||  combo2 <= combo8 || combo3 <= combo9 || combo4 <= combo7 || combo5 <= combo8 || combo6 <= combo7 ) {
  Console.WriteLine ("Triangle cannot be formed");
  System.Environment.Exit(combo1); }

  if (combo7 == combo8 && combo7 == combo9 && combo8 == combo9) {
  Console.WriteLine ("The Triangle is Equilateral"); }

  else if (combo7 != combo8 && combo7 != combo9 && combo8 != combo9){
  Console.WriteLine ("The Triangle is Scalene");
  }

  else if (combo7 == combo8 || combo7 == combo9 || combo8 == combo9){
  Console.WriteLine ("The Triangle is Iscoceles"); }
  
  }

}