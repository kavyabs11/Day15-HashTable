// See https://aka.ms/new-console-template for more information
using Hash;
using Hash;
Console.WriteLine("Welcome to HashTables");

while (true)
{
    Console.WriteLine("\n0. Exit");
    Console.WriteLine("1.Find frequency of words in a sentence");
    Console.WriteLine("Q2. Find Frequency of Words in a Large Paragraph Phrase");

    Console.Write("\nEnter Question Number You Want to Execute : ");
    int Choice = Convert.ToInt32(Console.ReadLine()); // Taking Input From User
    switch (Choice)
    {
        case 1:
            string frequency = "To be or not to be";
            List<string> compareList = new List<string>();
            List<string> storeCountList = new List<string>();
            string[] frequencyArray = frequency.Split(' ');
            MyMapNode<int, string> hash1 = new MyMapNode<int, string>(frequencyArray.Length);

            for (int i = 0; i < frequencyArray.Length; i++)
            {
                hash1.Add(i, frequencyArray[i]);
                Console.Write(hash1.Get(i) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < frequencyArray.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < frequencyArray.Length; j++)
                {
                    if (frequencyArray[j].ToLower() == hash1.Get(i).ToLower())
                    {
                        count++;

                        if (compareList.Contains(hash1.Get(j).ToLower()))
                        {
                            break;
                        }
                    }
                }

                if (compareList.Contains(hash1.Get(i).ToLower()))
                {
                    continue;
                }

                compareList.Add(hash1.Get(i));


                storeCountList.Add(hash1.Get(i) + "\t" + count);
            }


            Console.WriteLine("Word and their frequencies shown below:- ");
            for (int i = 0; i < storeCountList.Count; i++)
            {
                Console.WriteLine(storeCountList[i]);
            }
            Console.WriteLine("#############################################################");
            break;
        case 2:

            string frequency_2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";


            List<string> compareList2 = new List<string>();


            List<string> storeCountList2 = new List<string>();


            string[] frequencyArray2 = frequency_2.Split(' ');


            MyMapNode<int, string> hash2 = new MyMapNode<int, string>(frequencyArray2.Length);

            Console.WriteLine("Given phrase is :\n");
            for (int i = 0; i < frequencyArray2.Length; i++)
            {

                hash2.Add(i, frequencyArray2[i]);
                Console.Write(hash2.Get(i) + " ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < frequencyArray2.Length; i++)
            {

                int count = 0;
                for (int j = 0; j < frequencyArray2.Length; j++)
                {

                    if (frequencyArray2[j].ToLower() == hash2.Get(i).ToLower())
                    {
                        count++;

                        if (compareList2.Contains(hash2.Get(j).ToLower()))
                        {
                            break;
                        }
                    }
                }

                if (compareList2.Contains(hash2.Get(i).ToLower()))
                {
                    continue;
                }

                compareList2.Add(hash2.Get(i));


                storeCountList2.Add(hash2.Get(i) + "\t\t" + count);
            }

            Console.WriteLine("\nWord and their frequencies shown below :- ");
            for (int i = 0; i < storeCountList2.Count; i++)
            {
                Console.WriteLine(storeCountList2[i]);
            }
            Console.WriteLine("##################################################################");
            break;

        default:
            Console.WriteLine("Please enter correct Question Number");
            break;
        case 0:
            return;
    }
}