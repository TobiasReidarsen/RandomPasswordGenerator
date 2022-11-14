// user is asked to if they want a new password
// they specify the lenght of the password
// the password is returned to them

//ChooseMode();

using System.Runtime.CompilerServices;
using System.Text;

void ChooseMode()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine(
            "1 to just make a new password with no username.\n2 for making a new password with a username.\n3 for viewing old passwords and usernames.");
        var input = Console.ReadKey(true);
        Console.Clear();
        switch (input.Key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("For creating a random password and not storing it" +
                                  "\nPress any key to continue");
                Console.ReadKey(true);
                Console.Clear();
                //GeneratePassword();
                return;
            case ConsoleKey.D2:
                break;
            case ConsoleKey.D3:
                break;
            default:
                Console.WriteLine("invalid input. Press any key to continue");
                Console.ReadKey(true);
                break;
        }
    }
}

ulong CreateSeed(){ // #TODO: This entire thing should not be in main. Move it later. And make it more generic. Was a pain to change every int32 to ulong.
    ulong firstSeedPart = (ulong)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
    ulong[] secondSeedPart = SplitDigits(firstSeedPart);
     
    secondSeedPart.Reverse();
    ulong seedInt = ConcatIntArr(secondSeedPart);
    ulong[] sumOfParts = AddElementsInArrays(SplitDigits(firstSeedPart), secondSeedPart);
    ulong crossSum = secondSeedPart.Aggregate((sum, next) => sum + next);
    ulong secondSum = sumOfParts.Aggregate((sum, next) => sum + next);

    ulong assembleParts = (seedInt + firstSeedPart) + (secondSum * secondSum);
    Console.WriteLine(assembleParts);
    return assembleParts;
}

ulong ConcatIntArr(ulong[] arr1)
{
    StringBuilder toReturn = new StringBuilder();
    foreach (var ele in arr1)
    {
        toReturn.Append(ele);
    }

    return ulong.Parse(toReturn.ToString());
}

ulong[] AddElementsInArrays(ulong[] array1, ulong[] array2)
{
    var addingAll = // code from here https://stackoverflow.com/questions/15649621/multiplying-each-element-of-one-array-by-all-the-elements-of-a-second-array
        from x in array1
        from y in array2
        select x * y;
    return addingAll.ToArray();
}

ulong[] SplitDigits(ulong integer)
{
    var addToo = new List<ulong>(){};
    while(integer>=10){
        
        addToo.Add(integer % 10);
        integer = integer/10;
    }
    addToo.Add(integer);
    return addToo.ToArray();
}

CreateSeed();