using ConsoleDiablo.DataModels;
using ConsoleDiablo.DataModels.Characters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ConsoleDiablo.Data
{
    internal static class DataMapper
    {
        private const string DATA_PATH = "../../../../data/";
        private const string CONFIG_PATH = "config.ini";
        private const string DEFAULT_CONFIG = "accounts=accounts.csv\r\ncharacters=characters.csv";

        private static readonly Dictionary<string, string> config;

        static DataMapper()
        {
            Directory.CreateDirectory(DATA_PATH);
            config = LoadConfig(DATA_PATH + CONFIG_PATH);
        }

        private static Dictionary<string, string> LoadConfig(string configPath)
        {
            EnsureConfigFile(configPath);

            var contents = ReadLines(configPath);

            var config = contents.Select(l => l.Split('=')).ToDictionary(t => t[0], t => DATA_PATH + t[1]);

            return config;
        }

        public static List<Account> LoadAccounts()
        {
            List<Account> accounts = new List<Account>();
            var dataLines = ReadLines(config["accounts"]);

            foreach (var line in dataLines)
            {
                string[] args = line.Split(';');
                int id = int.Parse(args[0]);
                string accountName = args[1];
                string password = args[2];
                var characterIds = args[3]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                Account account = new Account(id, accountName, password);
                accounts.Add(account);
            }

            return accounts;
        }

        public static void SaveAccounts(List<Account> accounts)
        {
            List<string> lines = new List<string>();

            foreach (var account in accounts)
            {
                const string accountFormat = "{0};{1};{2};{3}";
                string line = string.Format(
                    accountFormat,
                    account.Id,
                    account.AccountName,
                    account.Password,
                    string.Join(",", account.Characters)
                    );

                lines.Add(line);
            }

            WriteLines(config["accounts"], lines.ToArray());
        }

        public static List<Character> LoadCharacters()
        {
            List<Character> characters = new List<Character>();
            var dataLines = ReadLines(config["characters"]);

            foreach (var line in dataLines)
            {
                var args = line.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var name = args[0];
                var strength = double.Parse(args[1]);
                var damage = double.Parse(args[2]);
                var dexterity = double.Parse(args[3]);
                var defense = double.Parse(args[4]);
                var vitality = double.Parse(args[5]);
                var baseLife = double.Parse(args[6]);
                var life = double.Parse(args[7]);
                var lifeRegenerationMultiplier = double.Parse(args[8]);
                var energy = double.Parse(args[9]);
                var baseMana = double.Parse(args[10]);
                var mana = double.Parse(args[11]);
                var manaRegenerationMultiplier = double.Parse(args[12]);
                var moneyBalance = double.Parse(args[13]);
                var experience = double.Parse(args[14]);
                var level = int.Parse(args[15]);
                var fireResistance = double.Parse(args[16]);
                var lightningResistance = double.Parse(args[17]);
                var coldResistance = double.Parse(args[18]);
                var poisonResistance = double.Parse(args[19]);
                var type = args[20];

                var characterType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == type);

                if (characterType == null)
                {
                    throw new InvalidOperationException("Invalid character type \"{type}\"!");
                }

                var character = (Character)Activator.CreateInstance(characterType, name,
                    strength,
                    damage,
                    dexterity,
                    defense,
                    vitality,
                    baseLife,
                    life,
                    lifeRegenerationMultiplier,
                    energy,
                    baseMana,
                    mana,
                    manaRegenerationMultiplier,
                    moneyBalance,
                    experience,
                    level,
                    fireResistance,
                    lightningResistance,
                    coldResistance,
                    poisonResistance,
                    type);

                characters.Add(character);
            }

            return characters;
        }

        public static void SaveCharacters(List<Character> characters)
        {
            List<string> lines = new List<string>();
            foreach (var character in characters)
            {
                const string characterFormat = "{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14};{15};{16};{17};{18};{19}";
                string line = string.Format(character.Name,
                    character.Strength,
                    character.Damage,
                    character.Dexterity,
                    character.Defense,
                    character.Vitality,
                    character.BaseLife,
                    character.Life,
                    character.LifeRegenerationMultiplier,
                    character.Energy,
                    character.BaseMana,
                    character.Mana,
                    character.ManaRegenerationMultiplier,
                    character.MoneyBalance,
                    character.Experience,
                    character.Level,
                    character.FireResistance,
                    character.LightningResistance,
                    character.ColdResistance,
                    character.PoisonResistance
                    );

                lines.Add(line);
            }

            WriteLines(config["posts"], lines.ToArray());
        }

        private static void WriteLines(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }

        private static string[] ReadLines(string path)
        {
            EnsureFile(path);
            var lines = File.ReadAllLines(path);
            return lines;
        }

        private static void EnsureFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        private static void EnsureConfigFile(string configPath)
        {
            if (!File.Exists(configPath))
            {
                File.WriteAllText(configPath, DEFAULT_CONFIG);
            }

        }
    }
}
