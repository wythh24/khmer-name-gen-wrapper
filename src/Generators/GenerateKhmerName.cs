namespace src.Generators;

public class GenerateKhmerName : GenerateNameWrapper
{
    private static readonly string[] firstSyllables =
    {
        "Ra", "Tha", "Ve", "Da", "Sa", "Ka", "Pha", "Ra", "So", "Nea",
        "Ka", "Lea", "Ko", "Mo", "Ba", "Che", "Pea", "The", "Nea", "Pea",
        "Keo", "Chan", "Kun", "Sao", "Mon", "Thi", "Chea", "Penh", "Rin", "Roeun",
        "Pich", "Pov", "Rith", "Sok", "Mao", "Phally", "Vichet", "Ravy", "Pheakdei", "Pheaktra",
        "Rithy", "Sreyneang", "Sokun", "Sovann", "Thyda", "Vibol", "Visal", "Virak", "Vanna", "Vannak",
        "Kosal", "Sophea", "Phearun", "Rattana", "Pisey", "Sina", "Sopanha", "Sophal", "Sovichea", "Thida",
        "Ratanak", "Maly", "Malis", "Sovan", "Sreyroth", "Sreypich", "Piseth", "Vorleak", "Visoth", "Kosal",
        "Panha", "Bopha", "Sovannary", "Nita", "Sokhak", "Sopheap", "Sreypov", "Sereyroth", "Maly", "Malin",
        "Dalin", "Sarath", "Nisa", "Kakada", "Rattanak", "Bunthoeun", "Rathana", "Sreyroth", "Sreymom", "Kimsan"
    };

    private static readonly string[] secondSyllables =
    {
        "vich", "nara", "na", "sok", "vatey", "mony", "sith", "rith", "nou", "kea",
        "sopheak", "rasmey", "kosal", "kunthea", "phalla", "virak", "srey", "seila", "vannak", "thida",
        "thorn", "thoeun", "phearum", "chanthy", "chheng", "sophea", "ravy", "pich", "phal", "sreyneang",
        "sokha", "sopanha", "tharith", "vibol", "vannak", "sopheap", "chhunly", "vandy", "socheat", "sreypov",
        "phearith", "pisey", "sokun", "sreyleak", "sokheng", "sophea", "visoth", "pheakdei", "virak", "thida",
        "rattana", "vichea", "visal", "viseth", "visoth", "chhunly", "chhunleap", "sokheng", "sokchea", "sopheap",
        "sreyroth", "sreymom", "sreyneang", "sokmean", "sopheap", "sopheap", "sopanha", "pisey", "phearith", "sreynich",
        "sopheaktra", "vichheka", "vandeth", "vannet", "visoth", "vireak", "virith", "vuthy", "vutha", "sreypich",
        "sreymao", "sreysokun", "sros", "sreypheak", "sreypov", "sokchan", "soksan", "sopanny", "sorithy", "sokseang"
    };

    /// <summary>
    /// Generates a Khmer name consisting of a first name and a last name.
    /// </summary>
    /// <returns>A string representing a Khmer first name followed by a Khmer last name</returns>
    public override string Generate()
    {
        return $"{GetRandomSyllable(firstSyllables)} {GetRandomSyllable(secondSyllables)}";
    }

    private string GetRandomSyllable(string[] syllables)
    {
        int index = random.Next(syllables.Length);
        return syllables[index];
    }
}