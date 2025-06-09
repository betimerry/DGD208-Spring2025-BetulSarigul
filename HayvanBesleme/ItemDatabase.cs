using System.Collections.Generic;

public static class ItemDatabase
{
    public static List<Item> AllItems = new List<Item>
    {

        new Item {
            Name = "Dog Food",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Dog },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 20,
            Duration = 1.0f
        },
        new Item {
            Name = "Dog Bed",
            Type = ItemType.Sleep,
            CompatibleWith = new List<PetType> { PetType.Dog },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 15,
            Duration = 1.0f
        },
        new Item {
            Name = "Dog Toy",
            Type = ItemType.Fun,
            CompatibleWith = new List<PetType> { PetType.Dog },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f
        },


        new Item {
            Name = "Cat Food",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Cat },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 20,
            Duration = 1.0f
        },
        new Item {
            Name = "Cat Bed",
            Type = ItemType.Sleep,
            CompatibleWith = new List<PetType> { PetType.Cat },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 15,
            Duration = 1.0f
        },
        new Item {
            Name = "Cat Toy",
            Type = ItemType.Fun,
            CompatibleWith = new List<PetType> { PetType.Cat },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f
        },

        new Item {
            Name = "Rabbit Food",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Rabbit },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 20,
            Duration = 1.0f
        },
        new Item {
            Name = "Rabbit Nest",
            Type = ItemType.Sleep,
            CompatibleWith = new List<PetType> { PetType.Rabbit },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 15,
            Duration = 1.0f
        },
        new Item {
            Name = "Rabbit Chew Toy",
            Type = ItemType.Fun,
            CompatibleWith = new List<PetType> { PetType.Rabbit },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f
        },


        new Item {
            Name = "Bird Seed",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Bird },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 20,
            Duration = 1.0f
        },
        new Item {
            Name = "Bird Perch",
            Type = ItemType.Sleep,
            CompatibleWith = new List<PetType> { PetType.Bird },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 15,
            Duration = 1.0f
        },
        new Item {
            Name = "Bird Bell",
            Type = ItemType.Fun,
            CompatibleWith = new List<PetType> { PetType.Bird },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f
        },


        new Item {
            Name = "Turtle Pellets",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Turtle },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 20,
            Duration = 1.0f
        },
        new Item {
            Name = "Turtle Hide",
            Type = ItemType.Sleep,
            CompatibleWith = new List<PetType> { PetType.Turtle },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 15,
            Duration = 1.0f
        },
        new Item {
            Name = "Turtle Ball",
            Type = ItemType.Fun,
            CompatibleWith = new List<PetType> { PetType.Turtle },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f
        },

        new Item {
            Name = "Fish Flakes",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Fish },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 20,
            Duration = 1.0f
        },
        new Item {
            Name = "Aquarium Hide",
            Type = ItemType.Sleep,
            CompatibleWith = new List<PetType> { PetType.Fish },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 15,
            Duration = 1.0f
        },
        new Item {
            Name = "Bubble Wand",
            Type = ItemType.Fun,
            CompatibleWith = new List<PetType> { PetType.Fish },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f
        },


        new Item {
            Name = "Horse Hay",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Horse },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 20,
            Duration = 1.0f
        },
        new Item {
            Name = "Stable Blanket",
            Type = ItemType.Sleep,
            CompatibleWith = new List<PetType> { PetType.Horse },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 15,
            Duration = 1.0f
        },
        new Item {
            Name = "Horse Ball",
            Type = ItemType.Fun,
            CompatibleWith = new List<PetType> { PetType.Horse },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f
        },


        new Item {
            Name = "Deer Grass",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Deer },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 20,
            Duration = 1.0f
        },
        new Item {
            Name = "Forest Bed",
            Type = ItemType.Sleep,
            CompatibleWith = new List<PetType> { PetType.Deer },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 15,
            Duration = 1.0f
        },
        new Item {
            Name = "Deer Toy",
            Type = ItemType.Fun,
            CompatibleWith = new List<PetType> { PetType.Deer },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f
        }
    };
}

