//1. Iterate and print values

using System.Security.Cryptography.X509Certificates;

List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);
    
static void PrintList(List<string> MyList) 
{
     foreach (string item in MyList)
     {
         Console.WriteLine(item);
     }
 }

//Print sum
 List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
    SumOfNumbers(TestIntList);
    

static void SumOfNumbers(List<int> IntList)
{
    int sum = IntList.Sum();
    Console.WriteLine("The sum is: " + sum);
}

//Find max


List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
int max = FindMax(TestIntList2);
Console.WriteLine("The maximum value is: " + max);


static int FindMax(List<int> IntList)
{
    int max = IntList.Max();
    return max;
}



//Squere the value


List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
List<int> squaredList = SquareValues(TestIntList3);

Console.WriteLine("Original List: " + string.Join(", ", TestIntList3));
Console.WriteLine("Squared List: " + string.Join(", ", squaredList));
    

static List<int> SquareValues(List<int> IntList)
{
    List<int> squaredList = IntList.Select(x => x * x).ToList();
    return squaredList;
}


//5. Replace Negative Numbers with 0
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
int[] nonNegativesArray = NonNegatives(TestIntArray);

Console.WriteLine("Original Array: " + string.Join(", ", TestIntArray));
Console.WriteLine("Non-Negatives Array: " + string.Join(", ", nonNegativesArray));
    

static int[] NonNegatives(int[] IntArray)
{
    int[] resultArray = new int[IntArray.Length];

    for (int i = 0; i < IntArray.Length; i++)
    {
        resultArray[i] = Math.Max(0, IntArray[i]);
    }

    return resultArray;
}

//6. Print Dictionary


Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);
    

static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (var kvp in MyDictionary)
    {
        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}


//Find Key 


Dictionary<string, string> TestDictt = new Dictionary<string, string>();
TestDictt.Add("HeroName", "Iron Man");
TestDictt.Add("RealName", "Tony Stark");
TestDictt.Add("Powers", "Money and intelligence");

Console.WriteLine(FindKey(TestDictt, "RealName"));  // This should print true
Console.WriteLine(FindKey(TestDictt, "Name"));      // This should print false
    

static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    return MyDictionary.ContainsKey(SearchTerm);
}



// 8. Generate a Dictionary


List<string> names = new List<string> { "Julie", "Harold", "James", "Monica" };
List<int> numbers = new List<int> { 6, 12, 7, 10 };

Dictionary<string, int> resultDict = GenerateDictionary(names, numbers);

// Print the result
foreach (var kvp in resultDict)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}
    

static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> resultDict = new Dictionary<string, int>();

    for (int i = 0; i < Names.Count; i++)
    {
        resultDict.Add(Names[i], Numbers[i]);
    }

    return resultDict;
}