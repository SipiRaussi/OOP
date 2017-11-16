using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDConsoleApplication
{
    class Character
    {
        public Character(string name)
        {
            this.name = name;
            Init();
        }


        // Private variables
        private string name;
        private int level;

        private string raceNClass;
        private string background;
        private string playerName;
        private int experiencePoints;
        private string alignment;
        private string adventuringGroup;

        private int strength;
        private int dexterity;
        private int constitution;
        private int intelligence;
        private int wisdom;
        private int charisma;

        private string armorClass;
        private int maxHP;
        private int tempHp;
        private int currentHP;

        private AttacksAndSpellcasting[] attAndSpells = new AttacksAndSpellcasting[8];
        private string[] featureAndTraits = new string[18];
        private string[] inventoryAndEquipment = new string[18];

        private Weapon w = null;

        // Public variables with getters and setters
        public string Name
        {
            get
            {
                if(name != null)
                    return name;
                else
                    return "Name no yet set";
            }
            set
            {
                if(value.Length != 0)
                    name = value;
            }
        }
        public int Level { get; }

        public string RaceNClass { get; }
        public string Background { get; }
        public string PlayerName { get; }
        public int ExperiencePoints { get; }
        public string Alignment { get; }
        public string AdventuringGroup { get; }

        public int Strength { get; }
        public int Dexterity { get; }
        public int Constitution { get; }
        public int Intelligence { get; }
        public int Wisdom { get; }
        public int Charisma { get; }

        public string ArmorClass { get; }
        public int MaxHP { get; }
        public int TempHp { get; }
        public int CurrentHP { get; }

        public AttacksAndSpellcasting[] AttAndSpells { get; }
        public string[] FeatureAndTraits { get; }
        public string[] InventoryAndEquipment { get; }

        public void Init()
        {
            w = new Weapon();
            w.Init();
        }
    }

    /// <summary>
    /// Characters attack or spell.
    /// </summary>
    struct AttacksAndSpellcasting
    {
        public string name;
        public string attack;
        public int damage;
        public int range;
        public int ammo;
        public int used;

        public AttacksAndSpellcasting(string name, string attack, int damage, int range, int ammo, int used)
        {
            this.name = name;
            this.attack = attack;
            this.damage = damage;
            this.range = range;
            this.ammo = ammo;
            this.used = used;
        }
    }
}
