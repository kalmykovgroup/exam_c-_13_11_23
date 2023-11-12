using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker.backend
{
    internal class Player
    { 
     
        public static int InitialBalance = 10_000;
  
        public string Name { get; }
        public int Balance { get; set; }
        public int Record { get; set; }
        public int Id { get; }


        public Player() {
            Name = string.Empty;
            Balance = 0;
            Id = new Random().Next(100_000, 999_999);
            Record = 0;
        }

        public Player(string name): this()
        {
            Name = name;
            Balance = InitialBalance;
            Record = Balance;
        }


        public Player(string name, int balance, int record, int id)
        {
            Name = name;
            Id = id;
            Balance = balance;
            Record = record;
        }
        
       

    }
}
