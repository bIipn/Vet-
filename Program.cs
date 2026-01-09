// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";



int maxPets = 6;
string? readResult;
string menuSelection = "";
string[,] ourAnimals = new string[maxPets, 8];


for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "Species: dog";
            animalID = "d1";
            animalAge = "AGE: 2";
            animalPhysicalDescription = "DISC: medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "PERSONALITY: loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "Nickname: lola";
            break;
        case 1:
            animalSpecies = "Species: dog";
            animalID = "d2";
            animalAge = "AGE: 9";
            animalPhysicalDescription = "DISC: large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "Personality: loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "Nickname: loki";
            break;
        case 2:
            animalSpecies = "Species: cat";
            animalID = "c3";
            animalAge = "AGE: 1";
            animalPhysicalDescription = "DISC: small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "Personality: friendly";
            animalNickname = "Nickname:Puss";
            break;
        case 3:
            animalSpecies = " Species: cat";
            animalID = "c4";
            animalAge = "Age ?";
            animalPhysicalDescription = "Dsc:";
            animalPersonalityDescription = "Personality:";
            animalNickname = "Nickname:";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }
    ourAnimals[i, 0] = animalSpecies;
    ourAnimals[i, 1] = animalID;
    ourAnimals[i, 2] = animalAge;
    ourAnimals[i, 3] = animalPhysicalDescription;
    ourAnimals[i, 4] = animalPersonalityDescription;
    ourAnimals[i, 5] = animalNickname;
}
 
// variables that support data entry
do
{
    Console.WriteLine("Please select an option:");
    Console.WriteLine("1. List all of our current pet information");
    Console.WriteLine("2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine("3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine("4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine("5. Edit an animal's age");
    Console.WriteLine("6. Edit an animal's personality description");
    Console.WriteLine("7. Display all cats with a specified characteristic");
    Console.WriteLine("8. Display all dogs with a specified characteristic");
    menuSelection = Console.ReadLine();
    if (menuSelection == "exit")
        break;
    
}while (menuSelection != "1" && menuSelection != "2" && menuSelection != "3" && menuSelection != "4" && menuSelection != "5" && menuSelection != "6" && menuSelection != "7" && menuSelection != "8");

//Console.WriteLine($"You selected menu option {menuSelection}.");

switch(menuSelection)
{
    case "1": 
    
for (int i = 0; i < maxPets; i++)
{
    if (ourAnimals[i, 0] != "ID #: ")
    {
        Console.WriteLine();
        for (int j = 0; j < 6; j++)
        {
            Console.WriteLine(ourAnimals[i, j]);
        }
    }
}
        Console.WriteLine("Press the Enter key to continue.");
        break;

    case "2":
        
    // Add a new animal friend to the ourAnimals array
    string anotherPet = "y";
    int petCount = 0;
    for (int i = 0; i < maxPets; i++)
    {
        if (ourAnimals[i, 0] != "ID #: ")
        {
                petCount += 1;
        }

    }

    if (petCount < maxPets)
    {
        Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
        readResult = Console.ReadLine();
    }

    
    bool validEntry = false;
// get species (cat or dog) - string animalSpecies is a required field 
// get species (cat or dog) - string animalSpecies is a required field 
do
{
    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        animalSpecies = readResult.ToLower();
        if (animalSpecies != "dog" && animalSpecies != "cat")
        {
            //Console.WriteLine($"You entered: {animalSpecies}.");
            validEntry = false;
        }
        else
        {
            validEntry = true;
        }
    }
} while (validEntry == false);
{
    // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
    petCount = petCount + 1;

    // check maxPet limit
if (petCount < maxPets)
{
        // another pet?
    Console.WriteLine("Do you want to enter info for another pet (y/n)");
    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            anotherPet = readResult.ToLower();
        }

    } while (anotherPet != "y" && anotherPet != "n");
}
}


animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
// get the pet's age. can be ? at initial entry.
do
{
    int petAge;
    Console.WriteLine("Enter the pet's age or enter ? if unknown");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        animalAge = readResult;
        if (animalAge != "?")
        {
            validEntry = int.TryParse(animalAge, out petAge);
        }
        else
        {
            validEntry = true;
        }
    }
} while (validEntry == false);
        
        
// get a description of the pet's personality - animalPersonalityDescription can be blank.
do
{
    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        animalPersonalityDescription = readResult.ToLower();
        if (animalPersonalityDescription == "")
        {
            animalPersonalityDescription = "tbd";
        }
    }
} while (animalPersonalityDescription == "");

// get the pet's nickname. animalNickname can be blank.
do
{
    Console.WriteLine("Enter a nickname for the pet");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        animalNickname = readResult.ToLower();
        if (animalNickname == "")
        {
            animalNickname = "tbd";
        }
    }
} while (animalNickname == "");

// store the pet information in the ourAnimals array (zero based)
ourAnimals[petCount, 0] = "ID #: " + animalID;
ourAnimals[petCount, 1] = "Species: " + animalSpecies;
ourAnimals[petCount, 2] = "Age: " + animalAge;
ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

if (petCount >= maxPets)
{
    Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
    Console.WriteLine("Press the Enter key to continue.");
    readResult = Console.ReadLine();
    
}
Console.WriteLine("Press the Enter key to continue.");
readResult = Console.ReadLine();
break;
       
// build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)


    case "3":
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "4":
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "5":
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "6":
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "7":
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "8":
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    
    default:
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
}



// array used to store runtime data, there is no persisted data


// Example loop to populate the array
