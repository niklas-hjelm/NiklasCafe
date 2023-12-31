﻿using System.Text;

namespace NiklasCafe.Models;

public class Drink
{
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    public override string ToString()
    {
        var drinkDescription = string.Empty;

        drinkDescription += "The drink contains:\n";

        foreach (var drinkIngredient in Ingredients)
        {
            drinkDescription += $"\t{drinkIngredient.Name}\n";
        }

        return drinkDescription;
    }
}