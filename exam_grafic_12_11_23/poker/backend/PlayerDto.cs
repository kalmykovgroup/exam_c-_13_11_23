using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace poker.backend
{
    internal class PlayerDto
    {
        const string path = "player.bat";

        public string Name { get; set; }
        public int Balance { get; set; }
        public int Record { get; set; }
        public int Id { get; set; }

        public PlayerDto() { Name = ""; }

        public PlayerDto(string name, int balance, int record, int id)
        {
            Name = name;
            Balance = balance;
            Record = record;
            Id = id;
        }

        public static void ToDto(IEnumerable<Player> players)
        {
            IEnumerable<PlayerDto> tmp = players.Select(item => new PlayerDto(item.Name, item.Balance, item.Record, item.Id));
 
            File.WriteAllText(path, JsonSerializer.Serialize(tmp));

        }

        public static List<Player> FromDto()
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                IEnumerable<PlayerDto> list = JsonSerializer.Deserialize<IEnumerable<PlayerDto>>(json) ?? new List<PlayerDto>();

                return list.Select(player => new Player(player.Name, player.Balance, player.Record, player.Id)).ToList();
            }
            
            return new List<Player>();
        }
        
    }
}
