

namespace functional_programming;

public static class Examples
{

    // List of Characters from Rick and Morty

    private static readonly string rickAndMortyCharactersCsv = @"
1,Rick Sanchez,Alive,Human,,Male;
2,Morty Smith,Alive,Human,,Male;
3,Summer Smith,Alive,Human,,Female;
4,Beth Smith,Alive,Human,,Female;
5,Jerry Smith,Alive,Human,,Male;
6,Abadango Cluster Princess,Alive,Alien,,Female;
7,Abradolf Lincler,unknown,Human,Genetic experiment,Male;
8,Adjudicator Rick,Dead,Human,,Male;
9,Agency Director,Dead,Human,,Male;
10,Alan Rails,Dead,Human,Superhuman (Ghost trains summoner),Male;
11,Albert Einstein,Dead,Human,,Male;
12,Alexander,Dead,Human,,Male;
13,Alien Googah,unknown,Alien,,unknown;
14,Alien Morty,unknown,Alien,,Male;
15,Alien Rick,unknown,Alien,,Male;
16,Amish Cyborg,Dead,Alien,Parasite,Male;
17,Annie,Alive,Human,,Female;
18,Antenna Morty,Alive,Human,Human with antennae,Male;
19,Antenna Rick,unknown,Human,Human with antennae,Male;
20,Ants in my Eyes Johnson,unknown,Human,Human with ants in his eyes,Male";


    public static List<string> Example1()
    {
        var charactersSplit = rickAndMortyCharactersCsv.Split(";");
        var charactersAlive = new List<string>();
        foreach (var row in charactersSplit)
        {
            var splitColumn = row.Split(",");
            var status = splitColumn[2];
            if ("Alive".Equals(status))
            {
                charactersAlive.Add(splitColumn[1]);
            }
        }
        return charactersAlive;
    }

    // LINQ is functioanl
    // immutable 
    // consise
    // declarative
    // logical what i want to do
    // higher order functions

    public static List<string> Example2() => rickAndMortyCharactersCsv.Split(";")
             .Select(row => row.Split(","))
             .Where(column => "Alive".Equals(column[2]))
             .Select(column => column[1])
             .ToList();

    public static List<Character> Characters() => rickAndMortyCharactersCsv.Split(";")
             .Select(row => row.Split(","))
             .Select(column => new Character(
                int.Parse(column[0]),
                column[1],
                column[2],
                column[3],
                column[4],
                column[5]))
             .ToList();

    public static Character FetchCharactersById(int id)
    {
        return Characters().First(c => c.Id == id);
    }
}