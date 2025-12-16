using System;
using System.Collections.Generic;

// Базовий клас Food
public abstract class Food
{
    public abstract int Points { get; }
}

// Нащадки Food
public class Cram : Food { public override int Points => 2; }
public class Lembas : Food { public override int Points => 3; }
public class Apple : Food { public override int Points => 1; }
public class Melon : Food { public override int Points => 1; }

// НОВІ КЛАСИ, ЯКІ ДАЮТЬ +2 ОЧКА (для забезпечення Happy 7)
public class Cake : Food { public override int Points => 2; }
public class Honeycake : Food { public override int Points => 2; }

public class Mushroom : Food { public override int Points => -10; }
public class OtherFood : Food { public override int Points => -1; }

// Базовий клас Mood
public abstract class Mood { public abstract string Name { get; } }

// Нащадки Mood
public class Angry : Mood { public override string Name => "Angry"; }
public class Sad : Mood { public override string Name => "Sad"; }
public class Happy : Mood { public override string Name => "Happy"; }
public class JavaScript : Mood { public override string Name => "JavaScript"; }

// Клас персонажа
public class Gandalf
{
    private int happinessPoints;
    public int HappinessPoints => this.happinessPoints;

    public void Eat(Food food)
    {
        this.happinessPoints += food.Points;
    }

    public Mood GetMood()
    {
        if (this.happinessPoints < -5)
        {
            return new Angry();
        }
        else if (this.happinessPoints <= 0)
        {
            return new Sad();
        }
        else if (this.happinessPoints <= 15)
        {
            return new Happy();
        }
        else
        {
            return new JavaScript();
        }
    }
}