
using System.Collections.Generic;

public class HayvanYonetme
{
    public List<Pet> pets = new List<Pet>();

    public void AddPet(Pet pet)
    {
        pets.Add(pet);
    }
}
