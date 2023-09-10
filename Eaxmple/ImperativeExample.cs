
namespace functional_programming;
public record ExamplePerson(string Name, int Age);
public static class ImperativeExample
{

    public static int FindOldestImperative(List<ExamplePerson> people)
    {
        if (people.IsEmpty())
        {
            return -1;
        }

        var oldest = people[0];
        foreach (var person in people)
        {
            if (person.Age > oldest.Age)
            {
                oldest = person;
            }
        }
        return oldest.Age;
    }


    public static int FindOldestFunctional(List<ExamplePerson> people)
      => people.IsEmpty() ? -1 : people.Max(x => x.Age);
}

// select many == bind
// select == map
// where == filter

// 