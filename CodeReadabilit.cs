using System.Net.NetworkInformation;

class Pro 
{
    static void Main() 
    {
    //    int[] inventory = {200,450,700,250};
    //    int sum = 0;
    //    int bin = 0;

    //    foreach (int items in inventory )
    //    {
    //     sum += items;
    //     bin++;
    //     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");

    //    }
    //    Console.WriteLine($"We have {sum} items in inventory");

    
    
    // string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

    // foreach(string orderID in orderIDs)
    // {
    //     if(orderID.StartsWith("B"))
    //     {
    //         Console.WriteLine(orderID);
    //     }
    // }

//    string firstName = "Bob";
//    int widgetsPurchased = 7;
//     // Testing a change to the message.
//    // int widgetsSold = 7;
//    // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
//      Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
//     }


    ///////////////////////////////////////////////////////
    
    // Random random = new Random();
    // string[] orderIDs = new string[5];

    // //Loop through each orderIDs

    // for( int i=0; i < orderIDs.Length; i++) 
    // {
    //     // Get Random value that equates to ASCII letters A through E
    //     int prefixValue = random.Next(65,70);

    //      // Convert the random value into a char, then a string
    //      string prefix = Convert.ToChar(prefixValue).ToString();

    //     //Create a random number, pad with zeros
    //     string suffix = random.Next(1,1000).ToString("000");

    //     //Combine the prefix and suffix together. then assign to current orderID
    //     orderIDs[i] = prefix + suffix;
    // }


    // //print out each orderID
    // foreach (var orderID in orderIDs)
    // {
    //     Console.WriteLine(orderID);
    // }

    ////////////////////////////////////////////////////
    ///

//     string str = "The quick brown fox jumps over the lazy dog.";
// // convert the message into a char array
// char[] charMessage = str.ToCharArray();
// // Reverse the chars
// Array.Reverse(charMessage);
// int x = 0;
// // count the o's
// foreach (char i in charMessage) { if (i == 'o') { x++; } }
// // convert it back to a string
// string new_message = new String(charMessage);
// // print it out
// Console.WriteLine(new_message);
// Console.WriteLine($"'o' appears {x} times.");

/////////////////////////////////////////////////////// 


 string originalMessage = "The quick brown fox jumps over the lazy dog.";

 char[] message = originalMessage.ToCharArray();

 Array.Reverse(message);

 int letterCount = 0;

 foreach (char letter in message)
 {
    if(letter == 'o')
    {
        letterCount++;
    }
 }
   
   string newMessage = new string(message);

   Console.WriteLine(newMessage);
   Console.WriteLine($"'o' appears {letterCount} times.");
}

}