using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerStatistics {

    private readonly static PlayerStatistics instance = new PlayerStatistics();

    private PlayerStatistics() { }

    public static PlayerStatistics getInstance()
    {
        return instance;
    }

    readonly int[] GainedHealth = {15,18,18,20,19,21,20,21,21,21,22,22,21,23,26,21,23,25,26,28,28,29,30,30,32,
                                31,33,32,34,23,24,23,23,23,23,22,22,21,21,21,20,20,19,19,18,18,16,16,15,11,
                                8,9,9,9,9,9,9,9,9,8,9,9,9,8,9,9,8,9,8,9,8,9,8,9,8,8,9,8,8,8,9,8,8,8,8,8,7,8,
                                8,7,8,7,8,7,8,7,7,7,7,6,6};

    readonly int[] BleedResistance = {10,13,17,20,23,27,30,33,37,40,44,48,52,56,60,63,65,68,71,73,76,79,81,
                                      84,87,89,92,95,97,100,101,101,102,103,104,104,106,106,107,107,108,109,
                                      109,110,111,112,112,113,114,114,115,116,117,117,118,119,120,120,121,
                                      122,122,123,124,125,126,127,128,128,128,129,130,130,131,132,133,133,
                                      134,135,136,136,137,138,138,139,140,141,141,142,143,143,144,145,146,
                                      146,147,148,149,149,150};

    readonly Dictionary<int, int> spellSlotCountPerLevel = new Dictionary<int, int>()
    {   {10, 1},
        {12, 2},
        {14, 3},
        {16, 4},
        {19, 5},
        {23, 6},
        {28, 7},
        {34, 8},
        {41, 9},
        {50, 10}
    };

    //notsetable Statistics
    private int _currentHealt;
    private int _maxHealth;
    private int _currentStamina;
    private int _maxStamina;
    private int _equipLoad;
    private int _rWeapon1Dmg;
    private int _rWeapon2Dmg;
    private int _lWeapon1Dmg;
    private int _lWeapon2Dmg;
    private int _naturalPhysicalDefense;
    private int _totalPhysicalDefense;
    private int _defenseVsStrike;
    private int _defenseVsSlash;
    private int _defenseVsThrust;
    private int _naturalMagicDefense;
    private int _totalMagicDefense;
    private int _naturalFlameDefense;
    private int _totalFlameDefense;
    private int _naturalLightningDefense;
    private int _totalLightningDefense;
    private int _poise;
    private int _bleedResist;
    private int _poisonResist;
    private int _curseResist;
    private int _itemDiscovery;
    private int _souls;
    private int _spellSlotCount;

    public int CurrentHealt
    {
        get
        {
            return _currentHealt;
        }

        set
        {
            if (value >= MaxHealth)
            {
                _currentHealt = MaxHealth;
            }
            else
            {
                _currentHealt = value;
            }

        }
    }

    public int MaxHealth
    {
        get
        {
            return _maxHealth;
        }

        set
        {
            _maxHealth = value;
        }
    }

    public int CurrentStamina
    {
        get
        {
            return _currentStamina;
        }

        set
        {
            if (value >= MaxStamina)
            {
                _currentStamina = MaxStamina;
            }
            else
            {
                _currentStamina = value;
            }
        }
    }

    public int MaxStamina
    {
        get
        {
            return _maxStamina;
        }

        set
        {
            _maxStamina = value;
        }
    }

    public int EquipLoad
    {
        get
        {
            return _equipLoad;
        }

        set
        {
            _equipLoad = value;
        }
    }

    public int RWeapon1Dmg
    {
        get
        {
            return _rWeapon1Dmg;
        }

        set
        {
            _rWeapon1Dmg = value;
        }
    }

    public int RWeapon2Dmg
    {
        get
        {
            return _rWeapon2Dmg;
        }

        set
        {
            _rWeapon2Dmg = value;
        }
    }

    public int LWeapon1Dmg
    {
        get
        {
            return _lWeapon1Dmg;
        }

        set
        {
            _lWeapon1Dmg = value;
        }
    }

    public int LWeapon2Dmg
    {
        get
        {
            return _lWeapon2Dmg;
        }

        set
        {
            _lWeapon2Dmg = value;
        }
    }

    public int NaturalPhysicalDefense
    {
        get
        {
            return _naturalPhysicalDefense;
        }

        set
        {
            _naturalPhysicalDefense = value;
        }
    }

    public int TotalPhysicalDefense
    {
        get
        {
            return _totalPhysicalDefense;
        }

        set
        {
            _totalPhysicalDefense = value;
        }
    }

    public int DefenseVsStrike
    {
        get
        {
            return _defenseVsStrike;
        }

        set
        {
            _defenseVsStrike = value;
        }
    }

    public int DefenseVsSlash
    {
        get
        {
            return _defenseVsSlash;
        }

        set
        {
            _defenseVsSlash = value;
        }
    }

    public int DefenseVsThrust
    {
        get
        {
            return _defenseVsThrust;
        }

        set
        {
            _defenseVsThrust = value;
        }
    }

    public int NaturalMagicDefense
    {
        get
        {
            return _naturalMagicDefense;
        }

        set
        {
            _naturalMagicDefense = value;
        }
    }

    public int TotalMagicDefense
    {
        get
        {
            return _totalMagicDefense;
        }

        set
        {
            _totalMagicDefense = value;
        }
    }

    public int NaturalFlameDefense
    {
        get
        {
            return _naturalFlameDefense;
        }

        set
        {
            _naturalFlameDefense = value;
        }
    }

    public int TotalFlameDefense
    {
        get
        {
            return _totalFlameDefense;
        }

        set
        {
            _totalFlameDefense = value;
        }
    }

    public int NaturalLightningDefense
    {
        get
        {
            return _naturalLightningDefense;
        }

        set
        {
            _naturalLightningDefense = value;
        }
    }

    public int TotalLightningDefense
    {
        get
        {
            return _totalLightningDefense;
        }

        set
        {
            _totalLightningDefense = value;
        }
    }

    public int Poise
    {
        get
        {
            return _poise;
        }

        set
        {
            _poise = value;
        }
    }

    public int BleedResist
    {
        get
        {
            return _bleedResist;
        }

        set
        {
            _bleedResist = value;
        }
    }

    public int PoisonResist
    {
        get
        {
            return _poisonResist;
        }

        set
        {
            _poisonResist = value;
        }
    }

    public int CurseResist
    {
        get
        {
            return _curseResist;
        }

        set
        {
            _curseResist = value;
        }
    }

    public int ItemDiscovery
    {
        get
        {
            return _itemDiscovery;
        }

        set
        {
            _itemDiscovery = value;
        }
    }

    public int Souls
    {
        get
        {
            return _souls;
        }

        set
        {
            _souls = value;
        }
    }

    public int SpellSlotCount
    {
        get
        {
            return _spellSlotCount;
        }

        set
        {
            _spellSlotCount = value;
        }
    }

    //setable Statistics
    private int _level;
    private int _vitality;
    private int _attunement;
    private int _endurance;
    private int _strength;
    private int _dexterity;
    private int _resistance;
    private int _intelligence;
    private int _faith;
    private int _humanityLvl;

    public int HumanityLvl
    {
        get
        {
            return _humanityLvl;
        }

        set
        {
            _humanityLvl = value;
        }
    }

    public int Level
    {
        get
        {
            return _level;
        }

        set
        {
            _level = value;
        }
    }

    public int Vitality
    {
        get
        {
            return _vitality;
        }

        set
        {
            _vitality = value;
        }
    }

    public int Attunement
    {
        get
        {
            return _attunement;
        }

        set
        {
            _attunement = value;
        }
    }

    public int Endurance
    {
        get
        {
            return _endurance;
        }

        set
        {
            _endurance = value;
        }
    }

    public int Strength
    {
        get
        {
            return _strength;
        }

        set
        {
            _strength = value;
        }
    }

    public int Dexterity
    {
        get
        {
            return _dexterity;
        }

        set
        {
            _dexterity = value;
        }
    }

    public int Resistance
    {
        get
        {
            return _resistance;
        }

        set
        {
            _resistance = value;
        }
    }

    public int Intelligence
    {
        get
        {
            return _intelligence;
        }

        set
        {
            _intelligence = value;
        }
    }

    public int Faith
    {
        get
        {
            return _faith;
        }

        set
        {
            _faith = value;
        }
    }

    public void CalculateMaxHp(int additionalHealthBonus = 0)
    {
        if(Level == 1)
        {
            MaxHealth = 400;
        }
        else
        MaxHealth += GainedHealth[Vitality-2] + additionalHealthBonus;
    }

    public void SetSpellSlotsCount(int spellSlotCount = 1)
    {
        if (spellSlotCountPerLevel.ContainsKey(Attunement))
        {
            SpellSlotCount = spellSlotCountPerLevel[Attunement];
        }
        else
        {
            SpellSlotCount = spellSlotCount;
        }
        
    }

    public void CalculateStamina(int additionalStamina = 0)
    {
        if(Endurance <=  40)
        {
            MaxStamina = 81 + Endurance + additionalStamina;
        }
    }

    public void CalculateEqBurden(int additionalEqburden = 0)
    {
        EquipLoad = 41 + Endurance + additionalEqburden;
    }

    public void CalculateBleedResistance(int additionalBleedResistance = 0)
    {
        BleedResist = BleedResistance[Endurance - 1] + additionalBleedResistance;
    }

    
}
