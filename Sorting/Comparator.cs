using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
      var integers = int.Parse(Console.ReadLine());
            var players = new List<Player>(integers);

            for (var rows = 0; rows < integers; rows++)
            {
                var data = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                var player = new Player()
                {
                    Name = data[0],
                    Score = int.Parse(data[1])
                };

                players.Add(player);
            }
            
            players.Sort((firstPlayer, secondPlayer) => firstPlayer.CompareTo(secondPlayer));

            foreach (var player in players)
            {
                Console.WriteLine($"{player.Name} {player.Score}");
            }
        }

        private class Player : IComparable<Player>
        {
            public string? Name { get; set; }

            public int Score { get; set; }

            public int CompareTo(Player? obj)
            {
                if (this.Score == obj.Score)
                {
                    return string.Compare(this.Name, obj.Name, StringComparison.InvariantCulture);
                }

                return this.Score > obj.Score ? -1 : 1;
            }
        }
}
