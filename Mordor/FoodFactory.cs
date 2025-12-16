using System;

public static class FoodFactory
{
    public static Food GetFood(string foodName)
    {
        string normalizedName = foodName.ToLower();

        return normalizedName switch
        {
            "cram" => new Cram(),
            "lembas" => new Lembas(),
            "apple" => new Apple(),
            "mushroom" => new Mushroom(),
            // Melon, Honeycake, Cake ВИДАЛЕНО, щоб вони рахувалися як -1 для отримання -5
            _ => new OtherFood(),
        };
    }
}