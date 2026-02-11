class Lasagna
{
    private const int cookingTime = 40;
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return cookingTime;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        return cookingTime - actualMinutesInOven;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        return numberOfLayers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int actualMinutesInOven)
    {
        return PreparationTimeInMinutes(numberOfLayers) + actualMinutesInOven;
    }
}
