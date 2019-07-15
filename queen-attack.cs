using System;
using System.Collections.Generic;
class QueenAttack
{
  static bool Attack (int queenX, int queenY, int opponentX, int opponentY)
  {
  if (queenX == opponentX || queenY ==opponentY ){
    return true;
  }
  else if ( Math.Abs(queenX - opponentX) == Math.Abs(queenY - opponentY))
  {
    return true;
  }
  else
  {
    return false;
  }
}
  static void Main()
  {
    Console.WriteLine("Enter X- cooridnate for Queen");
    string xQueen = Console.ReadLine();
    Console.WriteLine("Enter Y- cooridnate for Queen");
    string yQueen = Console.ReadLine();
    Console.WriteLine("Enter X- cooridnate for opponent");
    string xOpponent = Console.ReadLine();
    Console.WriteLine("Enter Y- cooridnate for opponent");
    string yOpponent = Console.ReadLine();
    int queenX=int.Parse(xQueen);
    int queenY=int.Parse(yQueen);
    int opponentX=int.Parse(xOpponent);
    int opponentY=int.Parse(yOpponent);
  bool result = Attack(queenX,queenY,opponentX,opponentY);
  if (result ==true){
    Console.WriteLine ("queen is capable of 'attacking' opponent! ");

  }
  else {
    Console.WriteLine ("you are in safe position!");
  }

  }

}
