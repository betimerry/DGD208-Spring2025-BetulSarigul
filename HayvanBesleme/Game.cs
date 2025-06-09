
using System;
using System.Linq;
using System.Threading.Tasks;

public class Game
{
    private HayvanYonetme petManager = new HayvanYonetme();
    private PopularityManager popularityManager;
    private int popularity;

    public async Task GameLoop()
    {
        popularityManager = new PopularityManager(petManager);
        popularityManager.OnPopularityChanged += (pop) => popularity = pop;
        _ = popularityManager.StartChecking();

        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine($"Zoo Simulator    Popularity: {popularity}/100");
            Console.WriteLine("1. Adopt a Pet");
            Console.WriteLine("2. Feed a Pet");
            Console.WriteLine("3. Put Pet to Sleep");
            Console.WriteLine("4. Entertain a Pet");
            Console.WriteLine("5. View Pet Stats");
            Console.WriteLine("6. Exit Game");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AdoptPet();
                    break;
                case "2":
                    FeedPet();
                    break;
                case "3":
                    SleepPet();
                    break;
                case "4":
                    EntertainPet();
                    break;
                case "5":
                    ViewPetStats();
                    break;
                case "6":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void AdoptPet()
    {
        Console.Write("Enter the name of the pet: ");
        string name = Console.ReadLine();
        Console.WriteLine("Choose the type of pet:");
        foreach (var type in Enum.GetValues(typeof(PetType)))
        {
            Console.WriteLine($"{(int)type} - {type}");
        }
        if (int.TryParse(Console.ReadLine(), out int selectedType) &&
            Enum.IsDefined(typeof(PetType), selectedType))
        {
            PetType type = (PetType)selectedType;
            petManager.AddPet(new Pet(name, type));
            Console.WriteLine("Pet adopted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
        Console.ReadKey();
    }

    private void FeedPet()
    {
        SelectPetAndUseItem(ItemType.Food, PetStat.Hunger, "Feed");
    }

    private void SleepPet()
    {
        SelectPetAndUseItem(ItemType.Sleep, PetStat.Sleep, "Sleep");
    }

    private void EntertainPet()
    {
        SelectPetAndUseItem(ItemType.Fun, PetStat.Fun, "Entertain");
    }

    private void SelectPetAndUseItem(ItemType itemType, PetStat stat, string action)
    {
        var pets = petManager.pets;
        if (pets.Count == 0)
        {
            Console.WriteLine("You have no pets.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Your Pets:");
        for (int i = 0; i < pets.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {pets[i].Name} ({pets[i].Type})");
        }

        Console.Write($"Select a pet to {action.ToLower()}: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= pets.Count)
        {
            var selectedPet = pets[index - 1];
            var items = ItemDatabase.AllItems
                .Where(x => x.CompatibleWith.Contains(selectedPet.Type) && x.Type == itemType)
                .ToList();

            if (items.Count == 0)
            {
                Console.WriteLine($"No suitable {action.ToLower()} items available.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Available {action} Items:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Name} (+{items[i].EffectAmount} {stat})");
            }

            Console.Write("Choose an item: ");
            if (int.TryParse(Console.ReadLine(), out int itemIndex) && itemIndex >= 1 && itemIndex <= items.Count)
            {
                var item = items[itemIndex - 1];
                switch (stat)
                {
                    case PetStat.Hunger:
                        selectedPet.Hunger = Math.Min(100, selectedPet.Hunger + item.EffectAmount);
                        break;
                    case PetStat.Sleep:
                        selectedPet.Sleep = Math.Min(100, selectedPet.Sleep + item.EffectAmount);
                        break;
                    case PetStat.Fun:
                        selectedPet.Fun = Math.Min(100, selectedPet.Fun + item.EffectAmount);
                        break;
                }
                Console.WriteLine($"{selectedPet.Name} has been {action.ToLower()}ed with {item.Name}!");
            }
            else
            {
                Console.WriteLine("Invalid item selection.");
            }
        }
        else
        {
            Console.WriteLine("Invalid pet selection.");
        }
        Console.ReadKey();
    }

    private void ViewPetStats()
    {
        var pets = petManager.pets;
        if (pets.Count == 0)
        {
            Console.WriteLine("You have no pets.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Your Pets:");
        foreach (var pet in pets)
        {
            Console.WriteLine($"Name: {pet.Name} | Type: {pet.Type} | Hunger: {pet.Hunger} | Sleep: {pet.Sleep} | Fun: {pet.Fun}");
        }
        Console.ReadKey();
    }
}
