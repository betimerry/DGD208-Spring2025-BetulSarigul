
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

public class PopularityManager
{
    private HayvanYonetme petManager;
    private int popularity;
    private readonly int maxPopularity = 100;

    public event Action<int> OnPopularityChanged;

    public PopularityManager(HayvanYonetme petManager)
    {
        this.petManager = petManager;
        popularity = 0;
    }

    public async Task StartChecking()
    {
        while (true)
        {
            await Task.Delay(10000);
            CalculatePopularity();
            OnPopularityChanged?.Invoke(popularity);
        }
    }

    private void CalculatePopularity()
    {
        var pets = petManager.pets;
        int petCount = pets.Count;
        int diversity = pets.Select(p => p.Type).Distinct().Count();
        bool allStatsAbove60 = pets.All(p =>
            p.Hunger >= 60 && p.Sleep >= 60 && p.Fun >= 60
        );

        int popularityScore = 0;
        if (petCount >= 8) popularityScore += 40;
        else popularityScore += (int)((double)petCount / 8 * 40);

        if (diversity >= 5) popularityScore += 30;
        else popularityScore += (int)((double)diversity / 5 * 30);

        if (allStatsAbove60) popularityScore += 30;

        popularity = Math.Min(popularityScore, maxPopularity);
    }

    public int GetPopularity()
    {
        return popularity;
    }
}
