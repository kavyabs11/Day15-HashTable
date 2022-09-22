// See https://aka.ms/new-console-template for more information
using Hash;
Console.WriteLine("Welcome to HashTables");

while (true)
{
    Console.WriteLine("\n0. Exit");
    Console.WriteLine("1.Find frequency of words in a sentence");

    Console.Write("\nEnter Question Number You Want to Execute : ");
    int Choice = Convert.ToInt32(Console.ReadLine()); // Taking Input From User
    switch (Choice)
    {
        case 1:
            //Declaring String
            string frequency = "To be or not to be";

            //Declaring List to Comare With Hash Table
            List<string> compareList = new List<string>();

            //Declaring List to Store Words 
            List<string> storeCountList = new List<string>();

            //Spliting the String store in Array
            string[] frequencyArray = frequency.Split(' ');

            //Declaring Length of Frequency Array
            MyMapNode<int, string> hash1 = new MyMapNode<int, string>(frequencyArray.Length);
            for (int i = 0; i < frequencyArray.Length; i++)
            {
                //Adding Words in Hast Table
                hash1.Add(i, frequencyArray[i]);

                //Displaying Word & Store in Hash Table
                Console.Write(hash1.Get(i) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < frequencyArray.Length; i++)
            {
                //Declaring count to count number of occurances of the words
                int count = 0;
                for (int j = 0; j < frequencyArray.Length; j++)
                {
                    //If our phrase array contains same word
                    if (frequencyArray[j].ToLower() == hash1.Get(i).ToLower())
                    {
                        //then we will increase the count
                        count++;

                        //Condition checking and loop breaking for internal loop
                        //to avoid duplicate entries in our table we are using a condition
                        if (compareList.Contains(hash1.Get(j).ToLower()))
                        {
                            //if value is already available in our compareList2 list then we'll break internal loop
                            break;
                        }
                    }
                }
                //Condition checking and loop breaking for external loop
                //if value already present in our compareList2 list then we'll continue from next iteration
                if (compareList.Contains(hash1.Get(i).ToLower()))
                {
                    continue;
                }
                //Adding the word to compareList for further comparison for duplicates
                compareList.Add(hash1.Get(i));

                //finally storing the word and its frequency in storeCountList list
                storeCountList.Add(hash1.Get(i) + "\t" + count);
            }

            //Printing each word in our sentence and its frequency stored in storeCountList
            Console.WriteLine("Word and their frequencies shown below:- ");
            for (int i = 0; i < storeCountList.Count; i++)
            {
                Console.WriteLine(storeCountList[i]);
            }
            break;
        default:
            Console.WriteLine("Please enter correct Question Number");
            break;
        case 0:
            return;
    }
}
Console.ReadKey();